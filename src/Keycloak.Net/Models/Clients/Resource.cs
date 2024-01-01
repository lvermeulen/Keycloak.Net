namespace Keycloak.Net.Models.Clients
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class Resource
    {
        [JsonPropertyName("rsid")]
        public string RsId { get; set; }

        [JsonPropertyName("rsname")]
        public string RsName { get; set; }

        [JsonPropertyName("scopes")]
        public IEnumerable<string> Scopes { get; set; }
    }
}

