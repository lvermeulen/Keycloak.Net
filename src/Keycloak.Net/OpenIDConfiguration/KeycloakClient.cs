namespace Keycloak.Net
{
    using System.Threading.Tasks;
    using Flurl.Http;
    using Models.OpenIDConfiguration;

    public partial class KeycloakClient
    {
        public async Task<OpenIDConfiguration> GetOpenIDConfigurationAsync(string realm)
        {
            return await GetBaseUrl(realm)
            .AppendPathSegment($"/realms/{realm}/.well-known/openid-configuration")
            .GetJsonAsync<OpenIDConfiguration>()
            .ConfigureAwait(false);
        }
    }
}
