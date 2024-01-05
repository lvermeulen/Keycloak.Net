namespace Keycloak.Net.Tests
{
    using System.IO;
    using Microsoft.Extensions.Configuration;

    public partial class KeycloakClientShould
    {
        private const string KeycloakUrl = "http://localhost:8080";
        private const string RealmId = "test";
        private const string ClientId = "test-client";
        private const string ClientSecret = "test-client-secret";
        private const string User = $"service-account-{ClientId}";

        private readonly KeycloakClient _client;

        public KeycloakClientShould()
        {
            _client = new KeycloakClient(KeycloakUrl, ClientId, ClientSecret);
        }
    }
}