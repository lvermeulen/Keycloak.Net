namespace Keycloak.Net.Models.Root
{
    using Keycloak.Net.Common.Converters;
    using System.Text.Json.Serialization;

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
