namespace Keycloak.Net.Models.Users
{
    using Newtonsoft.Json;

    public class UserAccess
    {
        [JsonProperty("manageGroupMembership")]
        public bool? ManageGroupMembership { get; set; }
        [JsonProperty("view")]
        public bool? View { get; set; }
        [JsonProperty("mapRoles")]
        public bool? MapRoles { get; set; }
        [JsonProperty("impersonate")]
        public bool? Impersonate { get; set; }
        [JsonProperty("manage")]
        public bool? Manage { get; set; }
    }
}
