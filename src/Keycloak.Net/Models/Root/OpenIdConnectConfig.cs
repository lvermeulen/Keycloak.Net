namespace Keycloak.Net.Models.Root
{
    using Keycloak.Net.Common.Converters;
    using System.Text.Json.Serialization;

    public class OpenIdConnectConfig
    {
        [JsonPropertyName("userinfo.token.claim")]
        [JsonConverter(typeof(BooleanJsonConverter))]
        public bool? UserInfoTokenClaim { get; set; }

        [JsonPropertyName("user.attribute")]
        public string UserAttribute { get; set; }

        [JsonPropertyName("id.token.claim")]
        [JsonConverter(typeof(BooleanJsonConverter))]
        public bool? IdTokenClaim { get; set; }

        [JsonPropertyName("access.token.claim")]
        [JsonConverter(typeof(BooleanJsonConverter))]
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
        [JsonConverter(typeof(BooleanJsonConverter))]
        public bool? Multivalued { get; set; }
    }
}
