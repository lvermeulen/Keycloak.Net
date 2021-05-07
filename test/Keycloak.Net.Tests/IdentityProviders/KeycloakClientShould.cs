using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData("master")]
        public async Task GetIdentityProviderInstancesAsync(string realm)
        {
            var result = await _client.GetIdentityProviderInstancesAsync(realm).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("master")]
        public async Task GetIdentityProviderAsync(string realm)
        {
            var identityProviderInstances = await _client.GetIdentityProviderInstancesAsync(realm).ConfigureAwait(false);
            string identityProviderAlias = identityProviderInstances.FirstOrDefault()?.Alias;
            if (identityProviderAlias != null)
            {
                var result = await _client.GetIdentityProviderAsync(realm, identityProviderAlias).ConfigureAwait(false);
                Assert.NotNull(result);
            }
        }

        //[Theory]
        //[InlineData("Insurance")]
        //public async Task GetIdentityProviderTokenAsync(string realm)
        //{
        //    var token = await _client.GetIdentityProviderTokenAsync(realm).ConfigureAwait(false);
        //    Assert.NotNull(token);
        //}

        [Theory]
        [InlineData("master")]
        public async Task GetIdentityProviderAuthorizationPermissionsInitializedAsync(string realm)
        {
            var identityProviderInstances = await _client.GetIdentityProviderInstancesAsync(realm).ConfigureAwait(false);
            string identityProviderAlias = identityProviderInstances.FirstOrDefault()?.Alias;
            if (identityProviderAlias != null)
            {
                var result = await _client.GetIdentityProviderAuthorizationPermissionsInitializedAsync(realm, identityProviderAlias).ConfigureAwait(false);
                Assert.NotNull(result);
            }
        }

        [Theory(Skip = "500 Internal server error")]
        [InlineData("master")]
        public async Task GetIdentityProviderMapperTypesAsync(string realm)
        {
            var identityProviderInstances = await _client.GetIdentityProviderInstancesAsync(realm).ConfigureAwait(false);
            string identityProviderAlias = identityProviderInstances.FirstOrDefault()?.Alias;
            if (identityProviderAlias != null)
            {
                var result = await _client.GetIdentityProviderMapperTypesAsync(realm, identityProviderAlias).ConfigureAwait(false);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("master")]
        public async Task GetIdentityProviderMappersAsync(string realm)
        {
            var identityProviderInstances = await _client.GetIdentityProviderInstancesAsync(realm).ConfigureAwait(false);
            string identityProviderAlias = identityProviderInstances.FirstOrDefault()?.Alias;
            if (identityProviderAlias != null)
            {
                var result = await _client.GetIdentityProviderMappersAsync(realm, identityProviderAlias).ConfigureAwait(false);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("master")]
        public async Task GetIdentityProviderMapperByIdAsync(string realm)
        {
            var identityProviderInstances = await _client.GetIdentityProviderInstancesAsync(realm).ConfigureAwait(false);
            string identityProviderAlias = identityProviderInstances.FirstOrDefault()?.Alias;
            if (identityProviderAlias != null)
            {
                var mappers = await _client.GetIdentityProviderMappersAsync(realm, identityProviderAlias).ConfigureAwait(false);
                string mapperId = mappers.FirstOrDefault()?.Id;
                if (mapperId != null)
                {
                    var result = await _client.GetIdentityProviderMapperByIdAsync(realm, identityProviderAlias, mapperId).ConfigureAwait(false);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("master")]
        public async Task GetIdentityProviderByProviderIdAsync(string realm)
        {
            var identityProviderInstances = await _client.GetIdentityProviderInstancesAsync(realm).ConfigureAwait(false);
            string identityProviderId = identityProviderInstances.FirstOrDefault()?.ProviderId;
            if (identityProviderId != null)
            {
                var result = await _client.GetIdentityProviderByProviderIdAsync(realm, identityProviderId).ConfigureAwait(false);
                Assert.NotNull(result);
            }
        }
    }
}
