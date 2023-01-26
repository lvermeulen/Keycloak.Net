namespace Keycloak.Net.Models.Users
{
    using Newtonsoft.Json;

    public class SetPasswordResponse
    {
        public bool Success { get; set; }
        [JsonProperty("error")]
        public string Error { get; set; }
        [JsonProperty("error_description")]
        public string ErrorDescription { get; set; }
    }
}