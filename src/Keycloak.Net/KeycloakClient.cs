using System;
using System.Net.Http;
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
        private readonly ConfigurableHttpClientFactory _clientFactory;

        private KeycloakClient(string url)
        {
            _url = url;

            this._clientFactory = new ConfigurableHttpClientFactory();
            FlurlHttp.ConfigureClient(this._url,
                cli => cli.Settings.HttpClientFactory = this._clientFactory);
        }

        public KeycloakClient(string url, string userName, string password)
            : this(url)
        {
            _userName = userName;
            _password = password;
        }

        public KeycloakClient(string url, string clientSecret)
            : this(url)
        {
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

        public void SetHttpClientHandler(HttpClientHandler clientHandler)
        {
            this._clientFactory.SetHttpClientHandler(clientHandler);
        }

        private IFlurlRequest GetBaseUrl(string authenticationRealm) => new Url(_url)
            .AppendPathSegment("/auth")
            .ConfigureRequest(settings => settings.JsonSerializer = _serializer)
            .WithAuthentication(_getToken, _url, authenticationRealm, _userName, _password, _clientSecret);
    }
    public class ConfigurableHttpClientFactory : DefaultHttpClientFactory
    {
        // Values for client configuration
        private HttpClientHandler _clientHandler;

        public ConfigurableHttpClientFactory()
        {
            this._clientHandler = new HttpClientHandler();
        }

        public void SetHttpClientHandler(HttpClientHandler clientHandler)
        {
            this._clientHandler = clientHandler;
        }

        public override HttpMessageHandler CreateMessageHandler()
        {
            return this._clientHandler;
        }
    }
}
