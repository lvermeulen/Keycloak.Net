namespace Keycloak.Net.Models.Root
{
    using Keycloak.Net.Common.Converters;
    using Newtonsoft.Json;

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