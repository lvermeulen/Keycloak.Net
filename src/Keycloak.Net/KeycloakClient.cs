namespace Keycloak.Net
{
    using System;
    using Flurl;
    using Flurl.Http;
    using Flurl.Http.Configuration;
    using Keycloak.Net.Common.Extensions;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;

    public partial class KeycloakClient
    {
        private ISerializer _serializer = new NewtonsoftJsonSerializer(new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore
        });

        private readonly Url _url;
        private readonly string _userName;
        private readonly string _password;
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly Func<string> _getToken;

        private KeycloakClient(string url)
        {
            _url = url;
        }

        public KeycloakClient(string url, string clientId, string userName, string password)
            : this(url)
        {
            _userName = userName;
            _password = password;
            _clientId = clientId;
        }

        public KeycloakClient(string url, string clientId, string clientSecret)
            : this(url)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
        }

        public KeycloakClient(string url, Func<string> getToken)
            : this(url)
        {
            _getToken = getToken;
        }

        public void SetSerializer(ISerializer serializer)
        {
            _serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
        }

        private IFlurlRequest GetBaseUrl(string authenticationRealm)
        {
            return new Url(_url)
                .AppendPathSegment("/auth")
                .ConfigureRequest(settings => settings.JsonSerializer = _serializer)
                .WithAuthentication(_getToken, _url, authenticationRealm, _userName, _password, _clientId, _clientSecret);
        }
    }
}
