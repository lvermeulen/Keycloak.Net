using Microsoft.Extensions.Configuration;
using System.IO;

namespace Keycloak.Net.Tests
{
    public partial class KeycloakClientShould
    {
        private readonly KeycloakClient _client;

        public KeycloakClientShould()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            string url = configuration["url"];
            string userName = configuration["userName"];
            string password = configuration["password"];

            _client = new KeycloakClient(url, userName, password);
        }
    }
}
