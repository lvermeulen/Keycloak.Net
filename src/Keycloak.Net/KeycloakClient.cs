using System;
using Flurl;
using Flurl.Http;
using Flurl.Http.Configuration;
using Keycloak.Net.Common.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Keycloak.Net
{
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
        private readonly string _clientSecret;
        private readonly Func<string> _getToken;
        private readonly string _authRealm;

        private KeycloakClient(string url)
        {
            _url = url;
        }

        public KeycloakClient(string url, string userName, string password, string authRealm = null)
            : this(url)
        {
            _userName = userName;
            _password = password;
            _authRealm = authRealm;
        }

        public KeycloakClient(string url, string clientSecret, string authRealm = null)
            : this(url)
        {
            _clientSecret = clientSecret;
            _authRealm = authRealm;
        }

        public KeycloakClient(string url, Func<string> getToken, string authRealm = null)
            : this(url)
        {
            _getToken = getToken;
            _authRealm = authRealm;
        }

        public void SetSerializer(ISerializer serializer)
        {
            _serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
        }

        private IFlurlRequest GetBaseUrl(string targetRealm) => new Url(_url)
            .AppendPathSegment("/auth")
            .ConfigureRequest(settings => settings.JsonSerializer = _serializer)
            .WithAuthentication(_getToken, _url, _authRealm ?? targetRealm, _userName, _password, _clientSecret);
    }
}
