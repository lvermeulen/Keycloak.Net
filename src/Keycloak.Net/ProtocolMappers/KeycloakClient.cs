using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;
using Keycloak.Net.Models.ProtocolMappers;

namespace Keycloak.Net
{
    public partial class KeycloakClient
    {
        public async Task<bool> CreateMultipleProtocolMappersAsync(string realm, string clientScopeId, IEnumerable<ProtocolMapperRepresentation> protocolMapperRepresentations)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}/protocol-mappers/add-models")
                .PostJsonAsync(protocolMapperRepresentations)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> CreateProtocolMapperAsync(string realm, string clientScopeId, ProtocolMapperRepresentation protocolMapperRepresentation)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}/protocol-mappers/models")
                .PostJsonAsync(protocolMapperRepresentation)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<ProtocolMapperRepresentation>> GetProtocolMappersAsync(string realm, string clientScopeId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}/protocol-mappers/models")
            .GetJsonAsync<IEnumerable<ProtocolMapperRepresentation>>()
            .ConfigureAwait(false);

        public async Task<ProtocolMapperRepresentation> GetProtocolMapperAsync(string realm, string clientScopeId, string protocolMapperId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}/protocol-mappers/models/{protocolMapperId}")
            .GetJsonAsync<ProtocolMapperRepresentation>()
            .ConfigureAwait(false);

        public async Task<bool> UpdateProtocolMapperAsync(string realm, string clientScopeId, string protocolMapperId, ProtocolMapperRepresentation protocolMapperRepresentation)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}/protocol-mappers/models/{protocolMapperId}")
                .PutJsonAsync(protocolMapperRepresentation)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteProtocolMapperAsync(string realm, string clientScopeId, string protocolMapperId)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}/protocol-mappers/models/{protocolMapperId}")
                .DeleteAsync()
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<ProtocolMapperRepresentation>> GetProtocolMappersByNameAsync(string realm, string clientScopeId, string protocol) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}/protocol-mappers/protocol/{protocol}")
            .GetJsonAsync<IEnumerable<ProtocolMapperRepresentation>>()
            .ConfigureAwait(false);
    }
}
