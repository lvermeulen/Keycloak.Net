namespace Keycloak.Net.Models.RealmsAdmin
{
    using System.Text.Json.Serialization;

    public class SmtpServer
    {
        [JsonPropertyName("host")]
        public string Host { get; set; }
        [JsonPropertyName("ssl")]
        public string Ssl { get; set; }
        [JsonPropertyName("starttls")]
        public string StartTls { get; set; }
        [JsonPropertyName("user")]
        public string User { get; set; }
        [JsonPropertyName("password")]
        public string Password { get; set; }
        [JsonPropertyName("auth")]
        public string Auth { get; set; }
        [JsonPropertyName("from")]
        public string From { get; set; }
        [JsonPropertyName("fromDisplayName")]
        public string FromDisplayName { get; set; }
        [JsonPropertyName("replyTo")]
        public string ReplyTo { get; set; }
        [JsonPropertyName("replyToDisplayName")]
        public string ReplyToDisplayName { get; set; }
        [JsonPropertyName("envelopeFrom")]
        public string EnvelopeFrom { get; set; }
    }
}
