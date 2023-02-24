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
    using Microsoft.Extensions.Logging;

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

        private readonly ILogger _logger;

        private KeycloakClient(string url, bool allowInsecure = false, ILogger logger = null)
        {
            _url = url;
            _allowInsecure = allowInsecure;
            _logger = logger;
        }

        public KeycloakClient(string url, string clientId, string userName, string password, bool allowInsecure = false, ILogger logger = null)
            : this(url)
        {
            _userName = userName;
            _password = password;
            _clientId = clientId;
            _allowInsecure = allowInsecure;
            _logger = logger;
        }

        public KeycloakClient(string url, string clientId, string clientSecret, bool allowInsecure = false, ILogger logger = null)
            : this(url)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
            _allowInsecure = allowInsecure;
            _logger = logger;
        }

        public KeycloakClient(string url, Func<string> getToken, bool allowInsecure = false, ILogger logger = null)
            : this(url)
        {
            _getToken = getToken;
            _allowInsecure = allowInsecure;
            _logger = logger;
        }

        public void SetSerializer(ISerializer serializer)
        {
            _serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
        }

        private IFlurlRequest GetBaseUrl(string authenticationRealm)
        {
            if (!_initialized && _allowInsecure)
            {
                _logger?.LogWarning("Allowing all certificates");
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
