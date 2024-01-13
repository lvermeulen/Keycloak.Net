namespace Keycloak.Net.Tests
{
    using System.Threading.Tasks;
    using Xunit;

    public partial class KeycloakClientShould
    {
        [Fact(Skip = "Not working yet")]
        public async Task TriggerUserSynchronizationAsync()
        {
            string storageProviderId = "";
            var result = await _client.TriggerUserSynchronizationAsync(RealmId, storageProviderId, UserSyncActions.Full);
            Assert.NotNull(result);
        }

        [Fact(Skip = "Not working yet")]
        public async Task TriggerLdapMapperSynchronizationAsync()
        {
            string storageProviderId = "";
            string mapperId = "";
            var result = await _client.TriggerLdapMapperSynchronizationAsync(RealmId, storageProviderId, mapperId, LdapMapperSyncActions.KeycloakToFed);
            Assert.NotNull(result);
        }
    }
}
