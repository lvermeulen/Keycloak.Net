using Keycloak.Net.Common.Converters;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    [JsonConverter(typeof(GroupNameConverter))]
    public enum GroupName
    {
        Social, 
        UserDefined
    }
}