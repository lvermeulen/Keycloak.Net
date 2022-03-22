using Keycloak.Net.Common.Converters;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    [JsonConverter(typeof(ConfigTypeConverter))]
    public enum ConfigType
    {
        Int, 
        String
    }
}