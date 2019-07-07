using Keycloak.Net.Common.Converters;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    [JsonConverter(typeof(NameConverter))]
    public enum Name
    {
        Base, 
        Keycloak, 
        RhSso
    }
}