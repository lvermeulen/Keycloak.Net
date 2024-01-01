namespace Keycloak.Net
{
    using System;
    using Flurl;
    using Flurl.Http;
    using Flurl.Http.Configuration;
    using Keycloak.Net.Common.Extensions;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Microsoft.Extensions.Logging;

    public partial class KeycloakClient
    {
        private static readonly ISerializer JsonSerializer = new DefaultJsonSerializer(new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
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

        private IFlurlRequest GetBaseUrl(string authenticationRealm)
        {
            if (!_initialized)
            {
                FlurlHttp.Clients.WithDefaults(builder =>
                {
                    if (_allowInsecure)
                    {
                        _logger?.LogWarning("Allowing all certificates");
                        builder.ConfigureInnerHandler(h =>
                        {
                            h.ServerCertificateCustomValidationCallback = (_, _, _, _) => true;
                        });
                    }

                    builder.WithSettings(settings =>
                    {
                        settings.JsonSerializer = JsonSerializer;
                    });
                });

                _initialized = true;
            }

            return new Url(_url)
                .AppendPathSegment("/auth")
                .WithAuthentication(_getToken, _url, authenticationRealm, _userName, _password, _clientId, _clientSecret);
        }
    }
}
