namespace Keycloak.Net
{
    using System.Threading.Tasks;
    using Flurl.Http;
    using Keycloak.Net.Models.Root;

    public partial class KeycloakClient
    {
        public async Task<ServerInfo> GetServerInfoAsync(string realm)
        {
            return await GetBaseUrl(realm)
                .AppendPathSegment("/admin/serverinfo/")
                .GetJsonAsync<ServerInfo>()
                .ConfigureAwait(false);
        }

        public async Task<bool> CorsPreflightAsync(string realm)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment("/admin/serverinfo/")
                .OptionsAsync()
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }
    }
}
