using Keycloak.Net.Common.Converters;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    [JsonConverter(typeof(CategoryConverter))]
    public enum Category
    {
        AttributeStatementMapper, 
        DockerAuthMapper, 
        GroupMapper, 
        RoleMapper, 
        TokenMapper
    }
}