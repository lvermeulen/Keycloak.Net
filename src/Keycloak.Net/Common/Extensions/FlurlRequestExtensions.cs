using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace Keycloak.Net.Common.Extensions
{
    public static class FlurlRequestExtensions
    {
        private static async Task<string> GetAccessTokenAsync(string url, string realm, string userName, string password)
        {
            var result = await url
                .AppendPathSegment($"/auth/realms/{realm}/protocol/openid-connect/token")
                .WithHeader("Accept", "application/json")
                .PostUrlEncodedAsync(new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("grant_type", "password"),
                    new KeyValuePair<string, string>("username", userName),
                    new KeyValuePair<string, string>("password", password),
                    new KeyValuePair<string, string>("client_id", "admin-cli")
                })
                .ReceiveJson();

            string accessToken = result
                .access_token.ToString();

            return accessToken;
        }

        private static string GetAccessToken(string url, string realm, string userName, string password) => GetAccessTokenAsync(url, realm, userName, password).GetAwaiter().GetResult();

        public static IFlurlRequest WithAuthentication(this IFlurlRequest request, Func<string> getToken, string url, string realm, string userName, string password)
        {
            if (getToken != null)
            {
                string token = getToken();
                return request.WithOAuthBearerToken(token);
            }

            return request.WithOAuthBearerToken(GetAccessToken(url, realm, userName, password));
        }
    }
}
