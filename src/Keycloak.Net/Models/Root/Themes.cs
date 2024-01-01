namespace Keycloak.Net.Models.Root
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class Themes
    {
        [JsonPropertyName("common")]
        public List<Common> Common { get; set; }

        [JsonPropertyName("admin")]
        public List<Account> Admin { get; set; }

        [JsonPropertyName("login")]
        public List<Account> Login { get; set; }

        [JsonPropertyName("welcome")]
        public List<Common> Welcome { get; set; }

        [JsonPropertyName("account")]
        public List<Account> Account { get; set; }

        [JsonPropertyName("email")]
        public List<Account> Email { get; set; }
    }
}
