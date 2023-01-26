namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class ActionTokenHandlerProviders
    {
        [JsonProperty("verify-email")]
        public HasOrder VerifyEmail { get; set; }

        [JsonProperty("execute-actions")]
        public HasOrder ExecuteActions { get; set; }

        [JsonProperty("reset-credentials")]
        public HasOrder ResetCredentials { get; set; }

        [JsonProperty("idp-verify-account-via-email")]
        public HasOrder IdpVerifyAccountViaEmail { get; set; }
    }
}