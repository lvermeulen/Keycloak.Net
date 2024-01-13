namespace Keycloak.Net.Tests
{
    using System.Linq;
    using System.Threading.Tasks;
    using Xunit;

    public partial class KeycloakClientShould
    {
        [Fact]
        public async Task GetIdentityProviderInstancesAsync()
        {
            var result = await _client.GetIdentityProviderInstancesAsync(RealmId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetIdentityProviderAsync()
        {
            var identityProviderInstances = await _client.GetIdentityProviderInstancesAsync(RealmId);
            string identityProviderAlias = identityProviderInstances.FirstOrDefault()?.Alias;
            if (identityProviderAlias != null)
            {
                var result = await _client.GetIdentityProviderAsync(RealmId, identityProviderAlias);
                Assert.NotNull(result);
            }
        }

        //[Theory]
        //[InlineData(DefaultRealm)]
        //public async Task GetIdentityProviderTokenAsync()
        //{
        //    var token = await _client.GetIdentityProviderTokenAsync(RealmId).ConfigureAwait(false);
        //    Assert.NotNull(token);
        //}

        [Fact]
        public async Task GetIdentityProviderAuthorizationPermissionsInitializedAsync()
        {
            var identityProviderInstances = await _client.GetIdentityProviderInstancesAsync(RealmId);
            string identityProviderAlias = identityProviderInstances.FirstOrDefault()?.Alias;
            if (identityProviderAlias != null)
            {
                var result = await _client.GetIdentityProviderAuthorizationPermissionsInitializedAsync(RealmId, identityProviderAlias);
                Assert.NotNull(result);
            }
        }

        [Fact(Skip = "500 Internal server error")]
        public async Task GetIdentityProviderMapperTypesAsync()
        {
            var identityProviderInstances = await _client.GetIdentityProviderInstancesAsync(RealmId);
            string identityProviderAlias = identityProviderInstances.FirstOrDefault()?.Alias;
            if (identityProviderAlias != null)
            {
                var result = await _client.GetIdentityProviderMapperTypesAsync(RealmId, identityProviderAlias);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetIdentityProviderMappersAsync()
        {
            var identityProviderInstances = await _client.GetIdentityProviderInstancesAsync(RealmId);
            string identityProviderAlias = identityProviderInstances.FirstOrDefault()?.Alias;
            if (identityProviderAlias != null)
            {
                var result = await _client.GetIdentityProviderMappersAsync(RealmId, identityProviderAlias);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetIdentityProviderMapperByIdAsync()
        {
            var identityProviderInstances = await _client.GetIdentityProviderInstancesAsync(RealmId);
            string identityProviderAlias = identityProviderInstances.FirstOrDefault()?.Alias;
            if (identityProviderAlias != null)
            {
                var mappers = await _client.GetIdentityProviderMappersAsync(RealmId, identityProviderAlias);
                string mapperId = mappers.FirstOrDefault()?.Id;
                if (mapperId != null)
                {
                    var result = await _client.GetIdentityProviderMapperByIdAsync(RealmId, identityProviderAlias, mapperId);
                    Assert.NotNull(result);
                }
            }
        }

        [Fact]
        public async Task GetIdentityProviderByProviderIdAsync()
        {
            var identityProviderInstances = await _client.GetIdentityProviderInstancesAsync(RealmId);
            string identityProviderId = identityProviderInstances.FirstOrDefault()?.ProviderId;
            if (identityProviderId != null)
            {
                var result = await _client.GetIdentityProviderByProviderIdAsync(RealmId, identityProviderId);
                Assert.NotNull(result);
            }
        }
    }
}
