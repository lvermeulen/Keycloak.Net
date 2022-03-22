using Keycloak.Net.Common.Converters;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    [JsonConverter(typeof(JsonTypeLabelConverter))]
    public enum JsonTypeLabel
    {
        Boolean, 
        ClientList, 
        File, 
        List, 
        MultivaluedList, 
        MultivaluedString, 
        Password, 
        Role, 
        Script, 
        String, 
        Text
    }
}