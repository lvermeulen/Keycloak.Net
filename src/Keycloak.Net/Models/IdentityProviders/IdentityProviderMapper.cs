namespace Keycloak.Net.Models.IdentityProviders
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class IdentityProviderMapper
    {
        [JsonProperty("config")]
        public IDictionary<string, object> Config { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("identityProviderAlias")]
        public string IdentityProviderAlias { get; set; }
        [JsonProperty("identityProviderMapper")]
        // ReSharper disable once InconsistentNaming
        public string _IdentityProviderMapper { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
