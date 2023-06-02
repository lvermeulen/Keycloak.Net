using Flurl.Http;
using Keycloak.Net.Models.ClientInitialAccess;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Keycloak.Net
{
    public partial class KeycloakClient
    {
        public async Task<ClientInitialAccessPresentation> CreateInitialAccessTokenAsync(string realm, ClientInitialAccessCreatePresentation create, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/clients-initial-access")
            .PostJsonAsync(create, cancellationToken)
            .ReceiveJson<ClientInitialAccessPresentation>()
            .ConfigureAwait(false);

        public async Task<IEnumerable<ClientInitialAccessPresentation>> GetClientInitialAccessAsync(string realm, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/clients-initial-access")
            .GetJsonAsync<IEnumerable<ClientInitialAccessPresentation>>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<bool> DeleteInitialAccessTokenAsync(string realm, string clientInitialAccessTokenId, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/clients-initial-access/{clientInitialAccessTokenId}")
                .DeleteAsync(cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }
    }
}
