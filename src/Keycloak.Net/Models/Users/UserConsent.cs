namespace Keycloak.Net.Models.Users
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class UserConsent
	{
		[JsonPropertyName("clientId")]
		public string ClientId { get; set; }
		[JsonPropertyName("grantedClientScopes")]
		public IEnumerable<string> GrantedClientScopes { get; set; }
		[JsonPropertyName("createdDate")]
		public long? CreatedDate { get; set; }
		[JsonPropertyName("lastUpdatedDate")]
		public long? LastUpdatedDate { get; set; }
	}
}

