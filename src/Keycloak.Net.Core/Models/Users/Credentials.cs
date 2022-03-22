using System.Collections.Generic;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Users
{
	public class Credentials
	{
		[JsonProperty("algorithm")]
		public string Algorithm { get; set; }
		[JsonProperty("config")]
		public IDictionary<string, string> Config { get; set; }
		[JsonProperty("counter")]
		public int? Counter { get; set; }
		[JsonProperty("createdDate")]
		public long? CreatedDate { get; set; }
		[JsonProperty("device")]
		public string Device { get; set; }
		[JsonProperty("digits")]
		public int? Digits { get; set; }
		[JsonProperty("hashIterations")]
		public int? HashIterations { get; set; }
		[JsonProperty("hashSaltedValue")]
		public string HashSaltedValue { get; set; }
		[JsonProperty("period")]
		public int? Period { get; set; }
		[JsonProperty("salt")]
		public string Salt { get; set; }
		[JsonProperty("temporary")]
		public bool? Temporary { get; set; }
		[JsonProperty("type")]
		public string Type { get; set; }
		[JsonProperty("value")]
		public string Value { get; set; }
	}
}
