namespace Keycloak.Net
{
    using System.Threading.Tasks;
    using Flurl.Http;
    using Keycloak.Net.Models.Key;

    public partial class KeycloakClient
    {
        public async Task<KeysMetadata> GetKeysAsync(string realm)
        {
            return await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/keys")
            .GetJsonAsync<KeysMetadata>()
            .ConfigureAwait(false);
        }
    }
}
