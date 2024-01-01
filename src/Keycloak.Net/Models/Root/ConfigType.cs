namespace Keycloak.Net.Models.Root
{
    using Keycloak.Net.Common.Converters;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(ConfigTypeConverter))]
    public enum ConfigType
    {
        Int, 
        String
    }
}
