namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class ActionTokenHandlerProviders
    {
        [JsonPropertyName("verify-email")]
        public HasOrder VerifyEmail { get; set; }

        [JsonPropertyName("execute-actions")]
        public HasOrder ExecuteActions { get; set; }

        [JsonPropertyName("reset-credentials")]
        public HasOrder ResetCredentials { get; set; }

        [JsonPropertyName("idp-verify-account-via-email")]
        public HasOrder IdpVerifyAccountViaEmail { get; set; }
    }
}
