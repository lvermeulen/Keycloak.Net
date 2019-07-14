using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;
using Keycloak.Net.Models.Components;

namespace Keycloak.Net
{
    public partial class KeycloakClient
    {
        public async Task<bool> CreateComponentAsync(string realm, Component componentRepresentation)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/components")
                .PostJsonAsync(componentRepresentation)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Component>> GetComponentsAsync(string realm, string name = null, string parent = null, string type = null)
        {
            var queryParams = new Dictionary<string, object>
            {
                [nameof(name)] = name,
                [nameof(parent)] = parent,
                [nameof(type)] = type
            };

            return await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/components")
                .SetQueryParams(queryParams)
                .GetJsonAsync<IEnumerable<Component>>()
                .ConfigureAwait(false);
        }

        public async Task<Component> GetComponentAsync(string realm, string componentId)
        {
            return await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/components/{componentId}")
                .GetJsonAsync<Component>()
                .ConfigureAwait(false);
        }

        public async Task<bool> UpdateComponentAsync(string realm, string componentId, Component componentRepresentation)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/components/{componentId}")
                .PutJsonAsync(componentRepresentation)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteComponentAsync(string realm, string componentId)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/components/{componentId}")
                .DeleteAsync()
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<ComponentType>> GetSubcomponentTypesAsync(string realm, string componentId, string type = null)
        {
            var queryParams = new Dictionary<string, object>
            {
                [nameof(type)] = type
            };

            var result = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/components/{componentId}/sub-component-types")
                .SetQueryParams(queryParams)
                .GetJsonAsync<IEnumerable<ComponentType>>()
                .ConfigureAwait(false);
            return result;
        }
    }
}
