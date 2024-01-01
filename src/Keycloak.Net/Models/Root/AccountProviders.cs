namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class AccountProviders
    {
        [JsonPropertyName("freemarker")]
        public HasOrder Freemarker { get; set; }
    }
}
