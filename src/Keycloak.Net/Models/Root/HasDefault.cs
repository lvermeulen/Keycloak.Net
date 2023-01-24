namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class HasDefault
    {
        [JsonProperty("default")]
        public HasOrder Default { get; set; }
    }
}