namespace Keycloak.Net.Models.Users
{
    using System.Text.Json.Serialization;

    public class SetPasswordResponse
    {
        public bool Success { get; set; }
        [JsonPropertyName("error")]
        public string Error { get; set; }
        [JsonPropertyName("error_description")]
        public string ErrorDescription { get; set; }
    }
}
