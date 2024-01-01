namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class OpenIdConnectConfig
    {
        [JsonPropertyName("userinfo.token.claim")]
        public bool? UserInfoTokenClaim { get; set; }

        [JsonPropertyName("user.attribute")]
        public string UserAttribute { get; set; }

        [JsonPropertyName("id.token.claim")]
        public bool? IdTokenClaim { get; set; }

        [JsonPropertyName("access.token.claim")]
        public bool? AccessTokenClaim { get; set; }

        [JsonPropertyName("claim.name")]
        public string ClaimName { get; set; }

        [JsonPropertyName("jsonType.label")]
        public JsonTypeLabel? JsonTypeLabel { get; set; }

        [JsonPropertyName("user.attribute.formatted")]
        public string UserAttributeFormatted { get; set; }

        [JsonPropertyName("user.attribute.country")]
        public string UserAttributeCountry { get; set; }

        [JsonPropertyName("user.attribute.postal_code")]
        public string UserAttributePostalCode { get; set; }

        [JsonPropertyName("user.attribute.street")]
        public string UserAttributeStreet { get; set; }

        [JsonPropertyName("user.attribute.region")]
        public string UserAttributeRegion { get; set; }

        [JsonPropertyName("user.attribute.locality")]
        public string UserAttributeLocality { get; set; }

        [JsonPropertyName("user.session.note")]
        public string UserSessionNote { get; set; }

        [JsonPropertyName("multivalued")]
        public bool? Multivalued { get; set; }
    }
}
