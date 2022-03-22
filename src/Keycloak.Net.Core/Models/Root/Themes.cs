using System.Collections.Generic;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class Themes
    {
        [JsonProperty("common")]
        public List<Common> Common { get; set; }

        [JsonProperty("admin")]
        public List<Account> Admin { get; set; }

        [JsonProperty("login")]
        public List<Account> Login { get; set; }

        [JsonProperty("welcome")]
        public List<Common> Welcome { get; set; }

        [JsonProperty("account")]
        public List<Account> Account { get; set; }

        [JsonProperty("email")]
        public List<Account> Email { get; set; }
    }
}