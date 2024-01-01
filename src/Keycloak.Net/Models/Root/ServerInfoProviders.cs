namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class ServerInfoProviders
    {
        [JsonPropertyName("account")]
        public EmailTemplateClass Account { get; set; }

        [JsonPropertyName("actionToken")]
        public ActionToken ActionToken { get; set; }

        [JsonPropertyName("actionTokenHandler")]
        public ActionTokenHandler ActionTokenHandler { get; set; }

        [JsonPropertyName("authenticationSessions")]
        public ActionToken AuthenticationSessions { get; set; }

        [JsonPropertyName("authenticator")]
        public Authenticator Authenticator { get; set; }

        [JsonPropertyName("authorization")]
        public Authorization Authorization { get; set; }

        [JsonPropertyName("authorizationCache")]
        public AuthorizationCache AuthorizationCache { get; set; }

        [JsonPropertyName("authorizationPersister")]
        public AuthorizationPersister AuthorizationPersister { get; set; }

        [JsonPropertyName("bruteForceProtector")]
        public BruteForceProtector BruteForceProtector { get; set; }

        [JsonPropertyName("client-authenticator")]
        public ClientAuthenticator ClientAuthenticator { get; set; }

        [JsonPropertyName("client-description-converter")]
        public ClientDescriptionConverter ClientDescriptionConverter { get; set; }

        [JsonPropertyName("client-installation")]
        public Authenticator ClientInstallation { get; set; }

        [JsonPropertyName("client-registration")]
        public ClientRegistration ClientRegistration { get; set; }

        [JsonPropertyName("client-registration-policy")]
        public ClientRegistrationPolicy ClientRegistrationPolicy { get; set; }

        [JsonPropertyName("client-storage")]
        public ClientStorage ClientStorage { get; set; }

        [JsonPropertyName("clientSignature")]
        public Authenticator ClientSignature { get; set; }

        [JsonPropertyName("cluster")]
        public ActionToken Cluster { get; set; }

        [JsonPropertyName("codeToTokenStore")]
        public ActionToken CodeToTokenStore { get; set; }

        [JsonPropertyName("connectionsHttpClient")]
        public AuthorizationCache ConnectionsHttpClient { get; set; }

        [JsonPropertyName("connectionsInfinispan")]
        public AuthorizationCache ConnectionsInfinispan { get; set; }

        [JsonPropertyName("connectionsJpa")]
        public ConnectionsJpa ConnectionsJpa { get; set; }

        [JsonPropertyName("connectionsJpaUpdater")]
        public ConnectionsJpaUpdater ConnectionsJpaUpdater { get; set; }

        [JsonPropertyName("connectionsLiquibase")]
        public AuthorizationCache ConnectionsLiquibase { get; set; }

        [JsonPropertyName("credential")]
        public Credential Credential { get; set; }

        [JsonPropertyName("dblock")]
        public AuthorizationPersister Dblock { get; set; }

        [JsonPropertyName("emailSender")]
        public AuthorizationCache EmailSender { get; set; }

        [JsonPropertyName("emailTemplate")]
        public EmailTemplateClass EmailTemplate { get; set; }

        [JsonPropertyName("eventsListener")]
        public EventsListener EventsListener { get; set; }

        [JsonPropertyName("eventsStore")]
        public AuthorizationPersister EventsStore { get; set; }

        [JsonPropertyName("exception-converter")]
        public AuthorizationPersister ExceptionConverter { get; set; }

        [JsonPropertyName("executors")]
        public AuthorizationCache Executors { get; set; }

        [JsonPropertyName("export")]
        public Port Export { get; set; }

        [JsonPropertyName("form-action")]
        public FormAction FormAction { get; set; }

        [JsonPropertyName("form-authenticator")]
        public FormAuthenticator FormAuthenticator { get; set; }

        [JsonPropertyName("hash")]
        public Hash Hash { get; set; }

        [JsonPropertyName("hostname")]
        public Hostname Hostname { get; set; }

        [JsonPropertyName("identity-provider-mapper")]
        public Authenticator IdentityProviderMapper { get; set; }

        [JsonPropertyName("identity_provider")]
        public IdentityProvider IdentityProvider { get; set; }

        [JsonPropertyName("import")]
        public Port Import { get; set; }

        [JsonPropertyName("jpa-entity-provider")]
        public ClientStorage JpaEntityProvider { get; set; }

        [JsonPropertyName("jta-lookup")]
        public JtaLookup JtaLookup { get; set; }

        [JsonPropertyName("keys")]
        public Keys Keys { get; set; }

        [JsonPropertyName("ldap-mapper")]
        public LdapMapper LdapMapper { get; set; }

        [JsonPropertyName("localeSelector")]
        public AuthorizationCache LocaleSelector { get; set; }

        [JsonPropertyName("login")]
        public EmailTemplateClass Login { get; set; }

        [JsonPropertyName("login-protocol")]
        public LoginProtocol LoginProtocol { get; set; }

        [JsonPropertyName("migration")]
        public AuthorizationCache Migration { get; set; }

        [JsonPropertyName("oauth2-token-introspection")]
        public Oauth2TokenIntrospection Oauth2TokenIntrospection { get; set; }

        [JsonPropertyName("openid-connect-ext")]
        public ClientStorage OpenIdConnectExt { get; set; }

        [JsonPropertyName("password-hashing")]
        public Authenticator PasswordHashing { get; set; }

        [JsonPropertyName("password-policy")]
        public Authenticator PasswordPolicy { get; set; }

        [JsonPropertyName("password-policy-manager")]
        public AuthorizationCache PasswordPolicyManager { get; set; }

        [JsonPropertyName("policy")]
        public Policy Policy { get; set; }

        [JsonPropertyName("protocol-mapper")]
        public Authenticator ProtocolMapper { get; set; }

        [JsonPropertyName("publicKeyStorage")]
        public ActionToken PublicKeyStorage { get; set; }

        [JsonPropertyName("realm")]
        public AuthorizationPersister Realm { get; set; }

        [JsonPropertyName("realm-restapi-extension")]
        public ClientStorage RealmRestapiExtension { get; set; }

        [JsonPropertyName("realmCache")]
        public AuthorizationCache RealmCache { get; set; }

        [JsonPropertyName("required-action")]
        public RequiredAction RequiredAction { get; set; }

        [JsonPropertyName("scripting")]
        public Scripting Scripting { get; set; }

        [JsonPropertyName("signature")]
        public Authenticator Signature { get; set; }

        [JsonPropertyName("singleUseTokenStore")]
        public ActionToken SingleUseTokenStore { get; set; }

        [JsonPropertyName("social")]
        public Authenticator Social { get; set; }

        [JsonPropertyName("stickySessionEncoder")]
        public ActionToken StickySessionEncoder { get; set; }

        [JsonPropertyName("storage")]
        public Storage Storage { get; set; }

        [JsonPropertyName("theme")]
        public Theme Theme { get; set; }

        [JsonPropertyName("themeResource")]
        public ClientStorage ThemeResource { get; set; }

        [JsonPropertyName("themeSelector")]
        public AuthorizationCache ThemeSelector { get; set; }

        [JsonPropertyName("timer")]
        public Timer Timer { get; set; }

        [JsonPropertyName("truststore")]
        public Truststore Truststore { get; set; }

        [JsonPropertyName("user")]
        public AuthorizationPersister User { get; set; }

        [JsonPropertyName("userCache")]
        public AuthorizationCache UserCache { get; set; }

        [JsonPropertyName("userFederatedStorage")]
        public AuthorizationPersister UserFederatedStorage { get; set; }

        [JsonPropertyName("userSessionPersister")]
        public AuthorizationPersister UserSessionPersister { get; set; }

        [JsonPropertyName("userSessions")]
        public ActionToken UserSessions { get; set; }

        [JsonPropertyName("well-known")]
        public WellKnown WellKnown { get; set; }

        [JsonPropertyName("x509cert-lookup")]
        public AuthorizationCache X509CertLookup { get; set; }
    }
}
