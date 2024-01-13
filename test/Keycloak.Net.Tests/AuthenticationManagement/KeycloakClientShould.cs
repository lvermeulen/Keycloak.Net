namespace Keycloak.Net.Tests
{
    using System.Linq;
    using System.Threading.Tasks;
    using Xunit;

    public partial class KeycloakClientShould
    {
        [Fact]
        public async Task GetAuthenticatorProvidersAsync()
        {
            var result = await _client.GetAuthenticatorProvidersAsync(RealmId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetClientAuthenticatorProvidersAsync()
        {
            var result = await _client.GetClientAuthenticatorProvidersAsync(RealmId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetAuthenticatorProviderConfigurationDescriptionAsync()
        {
            var providers = await _client.GetAuthenticatorProvidersAsync(RealmId);
            string providerId = providers.FirstOrDefault()?.FirstOrDefault(x => x.Key == "id").Value.ToString();
            if (providerId != null)
            {
                var result = await _client.GetAuthenticatorProviderConfigurationDescriptionAsync(RealmId, providerId);
                Assert.NotNull(result);
            }
        }

        [Fact(Skip = "Not working yet")]
        public async Task GetAuthenticatorConfigurationAsync()
        {
            string configurationId = ""; //TODO
            if (configurationId != null)
            {
                var result = await _client.GetAuthenticatorConfigurationAsync(RealmId, configurationId);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetAuthenticationExecutionAsync()
        {
            var flows = await _client.GetAuthenticationFlowsAsync(RealmId);
            string flowAlias = flows.FirstOrDefault()?.Alias;
            if (flowAlias != null)
            {
                var executions = await _client.GetAuthenticationFlowExecutionsAsync(RealmId, flowAlias);
                string executionId = executions.FirstOrDefault()?.Id;
                if (executionId != null)
                {
                    var result = await _client.GetAuthenticationExecutionAsync(RealmId, executionId);
                    Assert.NotNull(result);
                }
            }
        }

        [Fact]
        public async Task GetAuthenticationFlowsAsync()
        {
            var result = await _client.GetAuthenticationFlowsAsync(RealmId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetAuthenticationFlowExecutionsAsync()
        {
            var flows = await _client.GetAuthenticationFlowsAsync(RealmId);
            string flowAlias = flows.FirstOrDefault()?.Alias;
            if (flowAlias != null)
            {
                var result = await _client.GetAuthenticationFlowExecutionsAsync(RealmId, flowAlias);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetAuthenticationFlowByIdAsync()
        {
            var flows = await _client.GetAuthenticationFlowsAsync(RealmId);
            string flowId = flows.FirstOrDefault()?.Id;
            if (flowId != null)
            {
                var result = await _client.GetAuthenticationFlowByIdAsync(RealmId, flowId);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetFormActionProvidersAsync()
        {
            var result = await _client.GetFormActionProvidersAsync(RealmId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetFormProvidersAsync()
        {
            var result = await _client.GetFormProvidersAsync(RealmId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetConfigurationDescriptionsForAllClientsAsync()
        {
            var result = await _client.GetConfigurationDescriptionsForAllClientsAsync(RealmId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetRequiredActionsAsync()
        {
            var result = await _client.GetRequiredActionsAsync(RealmId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetRequiredActionByAliasAsync()
        {
            var requiredActions = await _client.GetRequiredActionsAsync(RealmId);
            string requiredActionAlias = requiredActions.FirstOrDefault()?.Alias;
            if (requiredActionAlias != null)
            {
                var result = await _client.GetRequiredActionByAliasAsync(RealmId, requiredActionAlias);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetUnregisteredRequiredActionsAsync()
        {
            var result = await _client.GetUnregisteredRequiredActionsAsync(RealmId);
            Assert.NotNull(result);
        }
    }
}
