using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;
using Keycloak.Net.Models.ProtocolMappers;

namespace Keycloak.Net
{
    public partial class KeycloakClient
    {
        public async Task<bool> CreateMultipleProtocolMappersAsync(string realm, string clientScopeId, IEnumerable<ProtocolMapper> protocolMapperRepresentations)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}/protocol-mappers/add-models")
                .PostJsonAsync(protocolMapperRepresentations)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> CreateProtocolMapperAsync(string realm, string clientScopeId, ProtocolMapper protocolMapperRepresentation)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}/protocol-mappers/models")
                .PostJsonAsync(protocolMapperRepresentation)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> CreateProtocolMapperByClientIdAsync(string realm, string id, ProtocolMapper protocolMapperRepresentation)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/clients/{id}/protocol-mappers/models")
                .PostJsonAsync(protocolMapperRepresentation)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> CreateMultipleProtocolMapperByClientIdAsync(string realm, string id, IEnumerable<ProtocolMapper> protocolMapperRepresentations)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/clients/{id}/protocol-mappers/models")
                .PostJsonAsync(protocolMapperRepresentations)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<ProtocolMapper>> GetProtocolMappersAsync(string realm, string clientScopeId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}/protocol-mappers/models")
            .GetJsonAsync<IEnumerable<ProtocolMapper>>()
            .ConfigureAwait(false);

        public async Task<IEnumerable<ProtocolMapper>> GetProtocolMappersByClientIdAsync(string realm, string id) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/clients/{id}/protocol-mappers/models")
            .GetJsonAsync<IEnumerable<ProtocolMapper>>()
            .ConfigureAwait(false);

        public async Task<IEnumerable<ProtocolMapper>> GetProtocolMappersByClientIdAsync(string realm, string id, string protocolMapperId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/clients/{id}/protocol-mappers/models/{protocolMapperId}")
            .GetJsonAsync<IEnumerable<ProtocolMapper>>()
            .ConfigureAwait(false);

        public async Task<ProtocolMapper> GetProtocolMapperAsync(string realm, string clientScopeId, string protocolMapperId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}/protocol-mappers/models/{protocolMapperId}")
            .GetJsonAsync<ProtocolMapper>()
            .ConfigureAwait(false);

        public async Task<bool> UpdateProtocolMapperAsync(string realm, string clientScopeId, string protocolMapperId, ProtocolMapper protocolMapperRepresentation)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}/protocol-mappers/models/{protocolMapperId}")
                .PutJsonAsync(protocolMapperRepresentation)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateProtocolMapperByClientIdAsync(string realm, string id, string protocolMapperId, ProtocolMapper protocolMapperRepresentation)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/clients/{id}/protocol-mappers/models/{protocolMapperId}")
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

        public async Task<bool> DeleteProtocolMapperByClientIdAsync(string realm, string id, string protocolMapperId)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/clients/{id}/protocol-mappers/models/{protocolMapperId}")
                .DeleteAsync()
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<ProtocolMapper>> GetProtocolMappersByNameAsync(string realm, string clientScopeId, string protocol) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}/protocol-mappers/protocol/{protocol}")
            .GetJsonAsync<IEnumerable<ProtocolMapper>>()
            .ConfigureAwait(false);

        public async Task<IEnumerable<ProtocolMapper>> GetProtocolMappersByClientIdByNameAsync(string realm, string id, string protocol) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/clients/{id}/protocol-mappers/protocol/{protocol}")
            .GetJsonAsync<IEnumerable<ProtocolMapper>>()
            .ConfigureAwait(false);
    }
}
