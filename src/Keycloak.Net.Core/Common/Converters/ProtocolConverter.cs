using System;
using System.Collections.Generic;
using System.Linq;
using Keycloak.Net.Models.Root;

namespace Keycloak.Net.Common.Converters
{
    public class ProtocolConverter : JsonEnumConverter<Protocol>
    {
        private static readonly Dictionary<Protocol, string> s_pairs = new Dictionary<Protocol, string>
        {
            [Protocol.DockerV2] = "dockerv2",
            [Protocol.OpenIdConnect] = "openid-connect",
            [Protocol.Saml] = "Saml"
        };

        protected override string EntityString { get; } = nameof(Protocol).ToLower();

        protected override string ConvertToString(Protocol value) => s_pairs[value];

        protected override Protocol ConvertFromString(string s)
        {
            var pair = s_pairs.FirstOrDefault(kvp => kvp.Value.Equals(s, StringComparison.OrdinalIgnoreCase));
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (EqualityComparer<KeyValuePair<Protocol, string>>.Default.Equals(pair))
            {
                throw new ArgumentException($"Unknown {EntityString}: {s}");
            }

            return pair.Key;
        }
    }
}
