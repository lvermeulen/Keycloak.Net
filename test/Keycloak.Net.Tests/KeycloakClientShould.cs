namespace Keycloak.Net.Tests
{
    using System;
    using Xunit.Abstractions;

    public partial class KeycloakClientShould
    {
        private static readonly string KeycloakUrl = 
            Environment.GetEnvironmentVariable($"TEST_URL") 
            ?? "http://localhost:8080";

        private static readonly string RealmId = 
            Environment.GetEnvironmentVariable($"TEST_REALM_ID") 
            ?? "test";

        private static readonly string ClientId = 
            Environment.GetEnvironmentVariable($"TEST_CLIENT_ID") 
            ?? "test-client";

        private static readonly string ClientSecret = 
            Environment.GetEnvironmentVariable($"TEST_CLIENT_SECRET") 
            ?? "test-client-secret";

        private static readonly string User = 
            Environment.GetEnvironmentVariable($"TEST_CLIENT_SA") 
            ?? $"service-account-{ClientId}";
            
        private readonly KeycloakClient _client;

        public KeycloakClientShould(ITestOutputHelper output)
        {
            var logger = new XUnitLogger<KeycloakClient>(output);
            _client = new KeycloakClient(KeycloakUrl, ClientId, ClientSecret, logger: logger);
        }
    }
}