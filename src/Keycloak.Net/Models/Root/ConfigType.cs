namespace Keycloak.Net.Models.Root
{
    using Keycloak.Net.Common.Converters;
    using Newtonsoft.Json;

    [JsonConverter(typeof(ConfigTypeConverter))]
    public enum ConfigType
    {
        Int, 
        String
    }
}