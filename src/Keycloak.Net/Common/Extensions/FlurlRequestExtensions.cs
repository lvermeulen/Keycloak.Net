namespace Keycloak.Net.Common.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Flurl;
    using Flurl.Http;

    public static class FlurlRequestExtensions
    {
        private static async Task<string> GetAccessTokenWithUsernameAsync(string url, string realm, string userName, string password, string clientId)
        {
            var result = await url
                .AppendPathSegment($"/auth/realms/{realm}/protocol/openid-connect/token")
                .WithHeader("Accept", "application/json")
                .PostUrlEncodedAsync(new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("grant_type", "password"),
                    new KeyValuePair<string, string>("username", userName),
                    new KeyValuePair<string, string>("password", password),
                    new KeyValuePair<string, string>("client_id", clientId)
                })
                .ReceiveJson<Token>().ConfigureAwait(false);

            return result.AccessToken;
        }

        private static string GetAccessTokenWithUsername(string url, string realm, string userName, string password, string clientId) {
            return GetAccessTokenWithUsernameAsync(url, realm, userName, password, clientId).GetAwaiter().GetResult();
        } 

        private static async Task<string> GetAccessTokenWithClientCredentialsAsync(string url, string realm, string clientId, string clientSecret)
        {
            var result = await url
                .AppendPathSegment($"/auth/realms/{realm}/protocol/openid-connect/token")
                .WithHeader("Content-Type", "application/x-www-form-urlencoded")
                .PostUrlEncodedAsync(new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("grant_type", "client_credentials"),
                    new KeyValuePair<string, string>("client_secret", clientSecret),
                    new KeyValuePair<string, string>("client_id", clientId)
                })
                .ReceiveJson<Token>().ConfigureAwait(false);

            return result.AccessToken;
        }

        private static string GetAccessTokenWithClientCredentials(string url, string realm, string clientId, string clientSecret) {
            return GetAccessTokenWithClientCredentialsAsync(url, realm, clientId, clientSecret).GetAwaiter().GetResult();
        }

        public static IFlurlRequest WithAuthentication(this Url request, Func<string> getToken, string url, string realm, string userName, string password, string clientId, string clientSecret)
        {
            return new FlurlRequest(request).WithAuthentication(getToken, url, realm, userName, password, clientId, clientSecret);
        }

        public static IFlurlRequest WithAuthentication(this IFlurlRequest request, Func<string> getToken, string url, string realm, string userName, string password, string clientId, string clientSecret)
        {
            string token = null;

            if (getToken != null)
            {
                token = getToken();
            }
            else if (clientId != null && clientSecret != null)
            {
                token = GetAccessTokenWithClientCredentials(url, realm, clientId, clientSecret);
            }
            else
            {
                token = GetAccessTokenWithUsername(url, realm, userName, password, clientId);
            }

            return request.WithOAuthBearerToken(token);
        }

        public static IFlurlRequest WithForwardedHttpHeaders(this IFlurlRequest request, ForwardedHttpHeaders forwardedHeaders)
        {
            if (!string.IsNullOrEmpty(forwardedHeaders?.forwardedFor))
            {
	            request = request.WithHeader("X-Forwarded-For", forwardedHeaders.forwardedFor);
            }

            if (!string.IsNullOrEmpty(forwardedHeaders?.forwardedProto))
            {
	            request = request.WithHeader("X-Forwarded-Proto", forwardedHeaders.forwardedProto);
            }

            if (!string.IsNullOrEmpty(forwardedHeaders?.forwardedHost))
            {
	            request = request.WithHeader("X-Forwarded-Host", forwardedHeaders.forwardedHost);
            }

            return request;
        }
    }
}
