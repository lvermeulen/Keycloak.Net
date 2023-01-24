namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class ExportProviders
    {
        [JsonProperty("singleFile")]
        public HasOrder SingleFile { get; set; }

        [JsonProperty("dir")]
        public HasOrder Dir { get; set; }
    }
}