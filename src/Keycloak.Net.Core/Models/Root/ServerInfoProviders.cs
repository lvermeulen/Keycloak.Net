using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class ServerInfoProviders
    {
        [JsonProperty("account")]
        public EmailTemplateClass Account { get; set; }

        [JsonProperty("actionToken")]
        public ActionToken ActionToken { get; set; }

        [JsonProperty("actionTokenHandler")]
        public ActionTokenHandler ActionTokenHandler { get; set; }

        [JsonProperty("authenticationSessions")]
        public ActionToken AuthenticationSessions { get; set; }

        [JsonProperty("authenticator")]
        public Authenticator Authenticator { get; set; }

        [JsonProperty("authorization")]
        public Authorization Authorization { get; set; }

        [JsonProperty("authorizationCache")]
        public AuthorizationCache AuthorizationCache { get; set; }

        [JsonProperty("authorizationPersister")]
        public AuthorizationPersister AuthorizationPersister { get; set; }

        [JsonProperty("bruteForceProtector")]
        public BruteForceProtector BruteForceProtector { get; set; }

        [JsonProperty("client-authenticator")]
        public ClientAuthenticator ClientAuthenticator { get; set; }

        [JsonProperty("client-description-converter")]
        public ClientDescriptionConverter ClientDescriptionConverter { get; set; }

        [JsonProperty("client-installation")]
        public Authenticator ClientInstallation { get; set; }

        [JsonProperty("client-registration")]
        public ClientRegistration ClientRegistration { get; set; }

        [JsonProperty("client-registration-policy")]
        public ClientRegistrationPolicy ClientRegistrationPolicy { get; set; }

        [JsonProperty("client-storage")]
        public ClientStorage ClientStorage { get; set; }

        [JsonProperty("clientSignature")]
        public Authenticator ClientSignature { get; set; }

        [JsonProperty("cluster")]
        public ActionToken Cluster { get; set; }

        [JsonProperty("codeToTokenStore")]
        public ActionToken CodeToTokenStore { get; set; }

        [JsonProperty("connectionsHttpClient")]
        public AuthorizationCache ConnectionsHttpClient { get; set; }

        [JsonProperty("connectionsInfinispan")]
        public AuthorizationCache ConnectionsInfinispan { get; set; }

        [JsonProperty("connectionsJpa")]
        public ConnectionsJpa ConnectionsJpa { get; set; }

        [JsonProperty("connectionsJpaUpdater")]
        public ConnectionsJpaUpdater ConnectionsJpaUpdater { get; set; }

        [JsonProperty("connectionsLiquibase")]
        public AuthorizationCache ConnectionsLiquibase { get; set; }

        [JsonProperty("credential")]
        public Credential Credential { get; set; }

        [JsonProperty("dblock")]
        public AuthorizationPersister Dblock { get; set; }

        [JsonProperty("emailSender")]
        public AuthorizationCache EmailSender { get; set; }

        [JsonProperty("emailTemplate")]
        public EmailTemplateClass EmailTemplate { get; set; }

        [JsonProperty("eventsListener")]
        public EventsListener EventsListener { get; set; }

        [JsonProperty("eventsStore")]
        public AuthorizationPersister EventsStore { get; set; }

        [JsonProperty("exception-converter")]
        public AuthorizationPersister ExceptionConverter { get; set; }

        [JsonProperty("executors")]
        public AuthorizationCache Executors { get; set; }

        [JsonProperty("export")]
        public Port Export { get; set; }

        [JsonProperty("form-action")]
        public FormAction FormAction { get; set; }

        [JsonProperty("form-authenticator")]
        public FormAuthenticator FormAuthenticator { get; set; }

        [JsonProperty("hash")]
        public Hash Hash { get; set; }

        [JsonProperty("hostname")]
        public Hostname Hostname { get; set; }

        [JsonProperty("identity-provider-mapper")]
        public Authenticator IdentityProviderMapper { get; set; }

        [JsonProperty("identity_provider")]
        public IdentityProvider IdentityProvider { get; set; }

        [JsonProperty("import")]
        public Port Import { get; set; }

        [JsonProperty("jpa-entity-provider")]
        public ClientStorage JpaEntityProvider { get; set; }

        [JsonProperty("jta-lookup")]
        public JtaLookup JtaLookup { get; set; }

        [JsonProperty("keys")]
        public Keys Keys { get; set; }

        [JsonProperty("ldap-mapper")]
        public LdapMapper LdapMapper { get; set; }

        [JsonProperty("localeSelector")]
        public AuthorizationCache LocaleSelector { get; set; }

        [JsonProperty("login")]
        public EmailTemplateClass Login { get; set; }

        [JsonProperty("login-protocol")]
        public LoginProtocol LoginProtocol { get; set; }

        [JsonProperty("migration")]
        public AuthorizationCache Migration { get; set; }

        [JsonProperty("oauth2-token-introspection")]
        public Oauth2TokenIntrospection Oauth2TokenIntrospection { get; set; }

        [JsonProperty("openid-connect-ext")]
        public ClientStorage OpenIdConnectExt { get; set; }

        [JsonProperty("password-hashing")]
        public Authenticator PasswordHashing { get; set; }

        [JsonProperty("password-policy")]
        public Authenticator PasswordPolicy { get; set; }

        [JsonProperty("password-policy-manager")]
        public AuthorizationCache PasswordPolicyManager { get; set; }

        [JsonProperty("policy")]
        public Policy Policy { get; set; }

        [JsonProperty("protocol-mapper")]
        public Authenticator ProtocolMapper { get; set; }

        [JsonProperty("publicKeyStorage")]
        public ActionToken PublicKeyStorage { get; set; }

        [JsonProperty("realm")]
        public AuthorizationPersister Realm { get; set; }

        [JsonProperty("realm-restapi-extension")]
        public ClientStorage RealmRestapiExtension { get; set; }

        [JsonProperty("realmCache")]
        public AuthorizationCache RealmCache { get; set; }

        [JsonProperty("required-action")]
        public RequiredAction RequiredAction { get; set; }

        [JsonProperty("scripting")]
        public Scripting Scripting { get; set; }

        [JsonProperty("signature")]
        public Authenticator Signature { get; set; }

        [JsonProperty("singleUseTokenStore")]
        public ActionToken SingleUseTokenStore { get; set; }

        [JsonProperty("social")]
        public Authenticator Social { get; set; }

        [JsonProperty("stickySessionEncoder")]
        public ActionToken StickySessionEncoder { get; set; }

        [JsonProperty("storage")]
        public Storage Storage { get; set; }

        [JsonProperty("theme")]
        public Theme Theme { get; set; }

        [JsonProperty("themeResource")]
        public ClientStorage ThemeResource { get; set; }

        [JsonProperty("themeSelector")]
        public AuthorizationCache ThemeSelector { get; set; }

        [JsonProperty("timer")]
        public Timer Timer { get; set; }

        [JsonProperty("truststore")]
        public Truststore Truststore { get; set; }

        [JsonProperty("user")]
        public AuthorizationPersister User { get; set; }

        [JsonProperty("userCache")]
        public AuthorizationCache UserCache { get; set; }

        [JsonProperty("userFederatedStorage")]
        public AuthorizationPersister UserFederatedStorage { get; set; }

        [JsonProperty("userSessionPersister")]
        public AuthorizationPersister UserSessionPersister { get; set; }

        [JsonProperty("userSessions")]
        public ActionToken UserSessions { get; set; }

        [JsonProperty("well-known")]
        public WellKnown WellKnown { get; set; }

        [JsonProperty("x509cert-lookup")]
        public AuthorizationCache X509CertLookup { get; set; }
    }
}