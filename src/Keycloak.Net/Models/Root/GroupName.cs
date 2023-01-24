namespace Keycloak.Net.Models.Root
{
    using Keycloak.Net.Common.Converters;
    using Newtonsoft.Json;

    [JsonConverter(typeof(GroupNameConverter))]
    public enum GroupName
    {
        Social, 
        UserDefined
    }
}