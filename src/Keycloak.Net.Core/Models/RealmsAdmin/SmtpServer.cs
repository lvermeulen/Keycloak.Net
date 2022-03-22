using Newtonsoft.Json;

namespace Keycloak.Net.Models.RealmsAdmin
{
    public class SmtpServer
    {
        [JsonProperty("host")]
        public string Host { get; set; }
        [JsonProperty("ssl")]
        public string Ssl { get; set; }
        [JsonProperty("starttls")]
        public string StartTls { get; set; }
        [JsonProperty("user")]
        public string User { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("auth")]
        public string Auth { get; set; }
        [JsonProperty("from")]
        public string From { get; set; }
        [JsonProperty("fromDisplayName")]
        public string FromDisplayName { get; set; }
        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }
        [JsonProperty("replyToDisplayName")]
        public string ReplyToDisplayName { get; set; }
        [JsonProperty("envelopeFrom")]
        public string EnvelopeFrom { get; set; }
    }
}