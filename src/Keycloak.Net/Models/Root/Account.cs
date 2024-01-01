namespace Keycloak.Net.Models.Root
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class Account
    {
        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("locales")]
        public List<Locale> Locales { get; set; }
    }
}
