using System.Collections.Generic;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.RealmsAdmin
{
    public class Realm
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("realm")]
        // ReSharper disable once InconsistentNaming
        public string _Realm { get; set; }
        [JsonProperty("notBefore")]
        public int? NotBefore { get; set; }
        [JsonProperty("revokeRefreshToken")]
        public bool? RevokeRefreshToken { get; set; }
        [JsonProperty("refreshTokenMaxReuse")]
        public int? RefreshTokenMaxReuse { get; set; }
        [JsonProperty("accessTokenLifespan")]
        public int? AccessTokenLifespan { get; set; }
        [JsonProperty("accessTokenLifespanForImplicitFlow")]
        public int? AccessTokenLifespanForImplicitFlow { get; set; }
        [JsonProperty("ssoSessionIdleTimeout")]
        public int? SsoSessionIdleTimeout { get; set; }
        [JsonProperty("ssoSessionMaxLifespan")]
        public int? SsoSessionMaxLifespan { get; set; }
        [JsonProperty("ssoSessionIdleTimeoutRememberMe")]
        public int? SsoSessionIdleTimeoutRememberMe { get; set; }
        [JsonProperty("ssoSessionMaxLifespanRememberMe")]
        public int? SsoSessionMaxLifespanRememberMe { get; set; }
        [JsonProperty("offlineSessionIdleTimeout")]
        public int? OfflineSessionIdleTimeout { get; set; }
        [JsonProperty("offlineSessionMaxLifespanEnabled")]
        public bool? OfflineSessionMaxLifespanEnabled { get; set; }
        [JsonProperty("offlineSessionMaxLifespan")]
        public int? OfflineSessionMaxLifespan { get; set; }
        [JsonProperty("accessCodeLifespan")]
        public int? AccessCodeLifespan { get; set; }
        [JsonProperty("accessCodeLifespanUserAction")]
        public int? AccessCodeLifespanUserAction { get; set; }
        [JsonProperty("accessCodeLifespanLogin")]
        public int? AccessCodeLifespanLogin { get; set; }
        [JsonProperty("actionTokenGeneratedByAdminLifespan")]
        public int? ActionTokenGeneratedByAdminLifespan { get; set; }
        [JsonProperty("actionTokenGeneratedByUserLifespan")]
        public int? ActionTokenGeneratedByUserLifespan { get; set; }
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
        [JsonProperty("sslRequired")]
        public string SslRequired { get; set; }
        [JsonProperty("registrationAllowed")]
        public bool? RegistrationAllowed { get; set; }
        [JsonProperty("registrationEmailAsUsername")]
        public bool? RegistrationEmailAsUsername { get; set; }
        [JsonProperty("rememberMe")]
        public bool? RememberMe { get; set; }
        [JsonProperty("verifyEmail")]
        public bool? VerifyEmail { get; set; }
        [JsonProperty("loginWithEmailAllowed")]
        public bool? LoginWithEmailAllowed { get; set; }
        [JsonProperty("duplicateEmailsAllowed")]
        public bool? DuplicateEmailsAllowed { get; set; }
        [JsonProperty("resetPasswordAllowed")]
        public bool? ResetPasswordAllowed { get; set; }
        [JsonProperty("editUsernameAllowed")]
        public bool? EditUsernameAllowed { get; set; }
        [JsonProperty("bruteForceProtected")]
        public bool? BruteForceProtected { get; set; }
        [JsonProperty("permanentLockout")]
        public bool? PermanentLockout { get; set; }
        [JsonProperty("maxFailureWaitSeconds")]
        public int? MaxFailureWaitSeconds { get; set; }
        [JsonProperty("minimumQuickLoginWaitSeconds")]
        public int? MinimumQuickLoginWaitSeconds { get; set; }
        [JsonProperty("waitIncrementSeconds")]
        public int? WaitIncrementSeconds { get; set; }
        [JsonProperty("quickLoginCheckMilliSeconds")]
        public int? QuickLoginCheckMilliSeconds { get; set; }
        [JsonProperty("maxDeltaTimeSeconds")]
        public int? MaxDeltaTimeSeconds { get; set; }
        [JsonProperty("failureFactor")]
        public int? FailureFactor { get; set; }
        [JsonProperty("defaultRoles")]
        public IEnumerable<string> DefaultRoles { get; set; }
        [JsonProperty("requiredCredentials")]
        public IEnumerable<string> RequiredCredentials { get; set; }
        [JsonProperty("otpPolicyType")]
        public string OtpPolicyType { get; set; }
        [JsonProperty("otpPolicyAlgorithm")]
        public string OtpPolicyAlgorithm { get; set; }
        [JsonProperty("otpPolicyInitialCounter")]
        public int? OtpPolicyInitialCounter { get; set; }
        [JsonProperty("otpPolicyDigits")]
        public int? OtpPolicyDigits { get; set; }
        [JsonProperty("otpPolicyLookAheadWindow")]
        public int? OtpPolicyLookAheadWindow { get; set; }
        [JsonProperty("otpPolicyPeriod")]
        public int? OtpPolicyPeriod { get; set; }
        [JsonProperty("otpSupportedApplications")]
        public IEnumerable<string> OtpSupportedApplications { get; set; }
        [JsonProperty("browserSecurityHeaders")]
        public BrowserSecurityHeaders BrowserSecurityHeaders { get; set; }
        [JsonProperty("smtpServer")]
        public SmtpServer SmtpServer { get; set; }
        [JsonProperty("eventsEnabled")]
        public bool? EventsEnabled { get; set; }
        [JsonProperty("eventsListeners")]
        public IEnumerable<string> EventsListeners { get; set; }
        [JsonProperty("enabledEventTypes")]
        public IEnumerable<object> EnabledEventTypes { get; set; }
        [JsonProperty("adminEventsEnabled")]
        public bool? AdminEventsEnabled { get; set; }
        [JsonProperty("adminEventsDetailsEnabled")]
        public bool? AdminEventsDetailsEnabled { get; set; }
        [JsonProperty("identityProviders")]
        public IEnumerable<IdentityProvider> IdentityProviders { get; set; }
        [JsonProperty("internationalizationEnabled")]
        public bool? InternationalizationEnabled { get; set; }
        [JsonProperty("supportedLocales")]
        public IEnumerable<object> SupportedLocales { get; set; }
        [JsonProperty("browserFlow")]
        public string BrowserFlow { get; set; }
        [JsonProperty("registrationFlow")]
        public string RegistrationFlow { get; set; }
        [JsonProperty("directGrantFlow")]
        public string DirectGrantFlow { get; set; }
        [JsonProperty("resetCredentialsFlow")]
        public string ResetCredentialsFlow { get; set; }
        [JsonProperty("clientAuthenticationFlow")]
        public string ClientAuthenticationFlow { get; set; }
        [JsonProperty("dockerAuthenticationFlow")]
        public string DockerAuthenticationFlow { get; set; }
        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }
        [JsonProperty("userManagedAccessAllowed")]
        public bool? UserManagedAccessAllowed { get; set; }
        [JsonProperty("passwordPolicy")]
        public string PasswordPolicy{ get; set; }
    }
}
