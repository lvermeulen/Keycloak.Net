namespace Keycloak.Net.Tests
{
    using System.Linq;
    using System.Threading.Tasks;
    using Xunit;

    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData("test-data-client-1")]
        public async Task GetClientRoleMappingsForGroupAsync(string clientId)
        {
            var groups = await _client.GetGroupHierarchyAsync(RealmId);
            string groupId = groups.FirstOrDefault()?.Id;
            if (groupId != null)
            {
                var clients = await _client.GetClientsAsync(RealmId);
                string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
                if (clientId != null)
                {
                    var result = await _client.GetClientRoleMappingsForGroupAsync(RealmId, groupId, clientsId);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("test-data-client-1")]
        public async Task GetAvailableClientRoleMappingsForGroupAsync(string clientId)
        {
            var groups = await _client.GetGroupHierarchyAsync(RealmId);
            string groupId = groups.FirstOrDefault()?.Id;
            if (groupId != null)
            {
                var clients = await _client.GetClientsAsync(RealmId);
                string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
                if (clientId != null)
                {
                    var result = await _client.GetAvailableClientRoleMappingsForGroupAsync(RealmId, groupId, clientsId);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("test-data-client-1")]
        public async Task GetEffectiveClientRoleMappingsForGroupAsync(string clientId)
        {
            var groups = await _client.GetGroupHierarchyAsync(RealmId);
            string groupId = groups.FirstOrDefault()?.Id;
            if (groupId != null)
            {
                var clients = await _client.GetClientsAsync(RealmId);
                string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
                if (clientId != null)
                {
                    var result = await _client.GetEffectiveClientRoleMappingsForGroupAsync(RealmId, groupId, clientsId);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("test-data-client-1")]
        public async Task GetClientRoleMappingsForUserAsync(string clientId)
        {
            var users = await _client.GetUsersAsync(RealmId);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var clients = await _client.GetClientsAsync(RealmId);
                string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
                if (clientId != null)
                {
                    var result = await _client.GetClientRoleMappingsForUserAsync(RealmId, userId, clientsId);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("test-data-user-1", "test-data-client-1")]
        public async Task GetAvailableClientRoleMappingsForUserAsync(string username, string clientId)
        {
            var users = await _client.GetUsersAsync(RealmId);
            var user = users.FirstOrDefault(u => u.UserName == username);

            Assert.NotNull(user);

            var clients = await _client.GetClientsAsync(RealmId);
            var client = clients.FirstOrDefault(x => x.ClientId == clientId);

            Assert.NotNull(client);

            var result = await _client.GetAvailableClientRoleMappingsForUserAsync(RealmId, user.Id, client.Id);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("test-data-user-1", "test-data-client-1")]
        public async Task GetEffectiveClientRoleMappingsForUserAsync(string username, string clientId)
        {
            var users = await _client.GetUsersAsync(RealmId);
            var user = users.FirstOrDefault(u => u.UserName == username);

            Assert.NotNull(user);

            var clients = await _client.GetClientsAsync(RealmId);
            var client = clients.FirstOrDefault(x => x.ClientId == clientId);

            Assert.NotNull(client);

            var result = await _client.GetEffectiveClientRoleMappingsForUserAsync(RealmId, user.Id, client.Id);
            Assert.NotNull(result);
        }
    }
}
