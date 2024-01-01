namespace Keycloak.Net.Tests
{
    using System.IO;
    using Microsoft.Extensions.Configuration;

    public partial class KeycloakClientShould
    {
        private readonly KeycloakClient _client;

        public KeycloakClientShould()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            string url = configuration["url"] ?? "https://localhost:8443";
            string userName = configuration["userName"] ?? "admin";
            string password = configuration["password"] ?? "changeit";

            _client = new KeycloakClient(url, userName, password);
        }
    }
}