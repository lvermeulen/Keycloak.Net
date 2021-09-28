﻿using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;
using Keycloak.Net.Models.Key;

namespace Keycloak.Net
{
    public partial class KeycloakClient
    {
        public async Task<KeysMetadata> GetKeysAsync(string realm, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/keys")
            .GetJsonAsync<KeysMetadata>(cancellationToken)
            .ConfigureAwait(false);
    }
}
