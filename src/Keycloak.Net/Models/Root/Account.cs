using System.Collections.Generic;
using Newtonsoft.Json;

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