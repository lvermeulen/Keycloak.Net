namespace Keycloak.Net.Models.Root
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class Account
    {
        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("locales")]
        public List<Locale> Locales { get; set; }
    }
}