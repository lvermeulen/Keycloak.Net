namespace Keycloak.Net.Models.IdentityProviders
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class IdentityProviderMapper
    {
        [JsonPropertyName("config")]
        public IDictionary<string, object> Config { get; set; }
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("identityProviderAlias")]
        public string IdentityProviderAlias { get; set; }
        [JsonPropertyName("identityProviderMapper")]
        // ReSharper disable once InconsistentNaming
        public string _IdentityProviderMapper { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}

