using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetAuthenticatorProvidersAsync(string realm)
        {
            var result = await _client.GetAuthenticatorProvidersAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetClientAuthenticatorProvidersAsync(string realm)
        {
            var result = await _client.GetClientAuthenticatorProvidersAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetAuthenticatorProviderConfigurationDescriptionAsync(string realm)
        {
            var providers = await _client.GetAuthenticatorProvidersAsync(realm);
            string providerId = providers.FirstOrDefault()?.FirstOrDefault(x => x.Key == "id").Value.ToString();
            if (providerId != null)
            {
                var result = await _client.GetAuthenticatorProviderConfigurationDescriptionAsync(realm, providerId);
                Assert.NotNull(result);
            }
        }

        [Theory(Skip = "Not working yet")]
        [InlineData("Insurance")]
        public async Task GetAuthenticatorConfigurationAsync(string realm)
        {
            string configurationId = ""; //TODO
            if (configurationId != null)
            {
                var result = await _client.GetAuthenticatorConfigurationAsync(realm, configurationId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetAuthenticationExecutionAsync(string realm)
        {
            var flows = await _client.GetAuthenticationFlowsAsync(realm);
            string flowAlias = flows.FirstOrDefault()?.Alias;
            if (flowAlias != null)
            {
                var executions = await _client.GetAuthenticationFlowExecutionsAsync(realm, flowAlias);
                string executionId = executions.FirstOrDefault()?.Id;
                if (executionId != null)
                {
                    var result = await _client.GetAuthenticationExecutionAsync(realm, executionId);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetAuthenticationFlowsAsync(string realm)
        {
            var result = await _client.GetAuthenticationFlowsAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetAuthenticationFlowExecutionsAsync(string realm)
        {
            var flows = await _client.GetAuthenticationFlowsAsync(realm);
            string flowAlias = flows.FirstOrDefault()?.Alias;
            if (flowAlias != null)
            {
                var result = await _client.GetAuthenticationFlowExecutionsAsync(realm, flowAlias);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetAuthenticationFlowByIdAsync(string realm)
        {
            var flows = await _client.GetAuthenticationFlowsAsync(realm);
            string flowId = flows.FirstOrDefault()?.Id;
            if (flowId != null)
            {
                var result = await _client.GetAuthenticationFlowByIdAsync(realm, flowId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetFormActionProvidersAsync(string realm)
        {
            var result = await _client.GetFormActionProvidersAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetFormProvidersAsync(string realm)
        {
            var result = await _client.GetFormProvidersAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetConfigurationDescriptionsForAllClientsAsync(string realm)
        {
            var result = await _client.GetConfigurationDescriptionsForAllClientsAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRequiredActionsAsync(string realm)
        {
            var result = await _client.GetRequiredActionsAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRequiredActionByAliasAsync(string realm)
        {
            var requiredActions = await _client.GetRequiredActionsAsync(realm);
            string requiredActionAlias = requiredActions.FirstOrDefault()?.Alias;
            if (requiredActionAlias != null)
            {
                var result = await _client.GetRequiredActionByAliasAsync(realm, requiredActionAlias);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetUnregisteredRequiredActionsAsync(string realm)
        {
            var result = await _client.GetUnregisteredRequiredActionsAsync(realm);
            Assert.NotNull(result);
        }
    }
}
