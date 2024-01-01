namespace Keycloak.Net.Models.Users
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class Credentials
	{
		[JsonPropertyName("algorithm")]
		public string Algorithm { get; set; }
		[JsonPropertyName("config")]
		public IDictionary<string, string> Config { get; set; }
		[JsonPropertyName("counter")]
		public int? Counter { get; set; }
		[JsonPropertyName("createdDate")]
		public long? CreatedDate { get; set; }
		[JsonPropertyName("device")]
		public string Device { get; set; }
		[JsonPropertyName("digits")]
		public int? Digits { get; set; }
		[JsonPropertyName("hashIterations")]
		public int? HashIterations { get; set; }
		[JsonPropertyName("hashSaltedValue")]
		public string HashSaltedValue { get; set; }
		[JsonPropertyName("period")]
		public int? Period { get; set; }
		[JsonPropertyName("salt")]
		public string Salt { get; set; }
		[JsonPropertyName("temporary")]
		public bool? Temporary { get; set; }
		[JsonPropertyName("type")]
		public string Type { get; set; }
		[JsonPropertyName("value")]
		public string Value { get; set; }
	}
}

