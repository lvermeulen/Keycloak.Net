using Newtonsoft.Json;
using System.Collections.Generic;

namespace Keycloak.Net.Models.Root
{
    public class Account
    {
        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("locales")]
        public List<Locale> Locales { get; set; }
    }
}