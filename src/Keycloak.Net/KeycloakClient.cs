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
        private static readonly ISerializer s_serializer = new NewtonsoftJsonSerializer(new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore
        });

        static KeycloakClient()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore
            };
        }

        private readonly Url _url;
        private readonly string _userName;
        private readonly string _password;
        private readonly Func<string> _getToken;

        private KeycloakClient(string url)
        {
            _url = url;
        }

        public KeycloakClient(string url, string userName, string password)
            : this(url)
        {
            _userName = userName;
            _password = password;
        }

        public KeycloakClient(string url, Func<string> getToken)
            : this(url)
        {
            _getToken = getToken;
        }
        
        private IFlurlRequest GetBaseUrl(string authenticationRealm) => new Url(_url)
            .AppendPathSegment("/auth")
            .ConfigureRequest(settings => settings.JsonSerializer = s_serializer)
            .WithAuthentication(_getToken, _url, authenticationRealm, _userName, _password);
    }
}
