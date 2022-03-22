using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class OpenIdConnectConfig
    {
        [JsonProperty("userinfo.token.claim")]
        public bool? UserInfoTokenClaim { get; set; }

        [JsonProperty("user.attribute")]
        public string UserAttribute { get; set; }

        [JsonProperty("id.token.claim")]
        public bool? IdTokenClaim { get; set; }

        [JsonProperty("access.token.claim")]
        public bool? AccessTokenClaim { get; set; }

        [JsonProperty("claim.name")]
        public string ClaimName { get; set; }

        [JsonProperty("jsonType.label")]
        public JsonTypeLabel? JsonTypeLabel { get; set; }

        [JsonProperty("user.attribute.formatted")]
        public string UserAttributeFormatted { get; set; }

        [JsonProperty("user.attribute.country")]
        public string UserAttributeCountry { get; set; }

        [JsonProperty("user.attribute.postal_code")]
        public string UserAttributePostalCode { get; set; }

        [JsonProperty("user.attribute.street")]
        public string UserAttributeStreet { get; set; }

        [JsonProperty("user.attribute.region")]
        public string UserAttributeRegion { get; set; }

        [JsonProperty("user.attribute.locality")]
        public string UserAttributeLocality { get; set; }

        [JsonProperty("user.session.note")]
        public string UserSessionNote { get; set; }

        [JsonProperty("multivalued")]
        public bool? Multivalued { get; set; }
    }
}