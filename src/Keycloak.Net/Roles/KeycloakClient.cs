using System.Threading.Tasks;
using Flurl.Http;
using Keycloak.Net.Models.Key;

namespace Keycloak.Net
{
    public partial class KeycloakClient
    {
        public async Task<KeysMetadataRepresentation> GetRolesAsync(string realm) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/keys")
            .GetJsonAsync<KeysMetadataRepresentation>()
            .ConfigureAwait(false);
    }
}
