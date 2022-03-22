using Newtonsoft.Json;

namespace Keycloak.Net.Models.Clients
{
    public class AddressClaimSet
    {
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("formatted")]
        public string Formatted { get; set; }
        [JsonProperty("locality")]
        public string Locality { get; set; }
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }
        [JsonProperty("region")]
        public string Region { get; set; }
        [JsonProperty("street_address")]
        public string StreetAddress { get; set; }
    }
}
