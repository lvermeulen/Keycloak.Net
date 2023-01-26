namespace Keycloak.Net
{
    using System;
    using Flurl;
    using Flurl.Http;
    using Flurl.Http.Configuration;
    using Common.Extensions;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using System.Net.Http;

    public partial class KeycloakClient
    {
        private ISerializer _serializer = new NewtonsoftJsonSerializer(new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore
        });

        private readonly Url _url;
        private readonly bool _allowInsecure;
        private readonly string _userName;
        private readonly string _password;
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly Func<string> _getToken;

        private bool _initialized = false;

        private KeycloakClient(string url, bool allowInsecure = false)
        {
            _url = url;
            _allowInsecure = allowInsecure;
        }

        public KeycloakClient(string url, string clientId, string userName, string password, bool allowInsecure = false)
            : this(url)
        {
            _userName = userName;
            _password = password;
            _allowInsecure = allowInsecure;
            _clientId = clientId;
        }

        public KeycloakClient(string url, string clientId, string clientSecret, bool allowInsecure = false)
            : this(url)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
            _allowInsecure = allowInsecure;
        }

        public KeycloakClient(string url, Func<string> getToken, bool allowInsecure = false)
            : this(url)
        {
            _getToken = getToken;
            _allowInsecure = allowInsecure;
        }

        public void SetSerializer(ISerializer serializer)
        {
            _serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
        }

        private IFlurlRequest GetBaseUrl(string authenticationRealm)
        {
            if (!_initialized)
            {
                FlurlHttp.ConfigureClient(_url.Root, cli =>
                    cli.Settings.HttpClientFactory = new UntrustedCertClientFactory());
                _initialized = true;
            }

            return new Url(_url)
                .AppendPathSegment("/auth")
                .ConfigureRequest(settings => settings.JsonSerializer = _serializer)
                .WithAuthentication(_getToken, _url, authenticationRealm, _userName, _password, _clientId, _clientSecret);
        }

        public class UntrustedCertClientFactory : DefaultHttpClientFactory
        {
            public override HttpMessageHandler CreateMessageHandler()
            {
                return new HttpClientHandler
                {
                    ServerCertificateCustomValidationCallback = (_, _, _, _) => true
                };
            }
        }
    }
}
