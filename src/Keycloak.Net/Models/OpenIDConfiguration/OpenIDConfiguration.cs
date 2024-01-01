namespace Keycloak.Net.Models.OpenIDConfiguration
{
    using System.Text.Json.Serialization;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OpenIDConfiguration
    {
        [JsonPropertyName("issuer")]
        public Uri Issuer { get; set; }

        [JsonPropertyName("authorization_endpoint")]
        public Uri AuthorizationEndpoint { get; set; }

        [JsonPropertyName("token_endpoint")]
        public Uri TokenEndpoint { get; set; }

        [JsonPropertyName("token_introspection_endpoint")]
        public Uri TokenIntrospectionEndpoint { get; set; }

        [JsonPropertyName("userinfo_endpoint")]
        public Uri UserinfoEndpoint { get; set; }

        [JsonPropertyName("end_session_endpoint")]
        public Uri EndSessionEndpoint { get; set; }

        [JsonPropertyName("jwks_uri")]
        public Uri JwksUri { get; set; }

        [JsonPropertyName("check_session_iframe")]
        public Uri CheckSessionIframe { get; set; }

        [JsonPropertyName("grant_types_supported")]
        public string[] GrantTypesSupported { get; set; }

        [JsonPropertyName("response_types_supported")]
        public string[] ResponseTypesSupported { get; set; }

        [JsonPropertyName("subject_types_supported")]
        public string[] SubjectTypesSupported { get; set; }

        [JsonPropertyName("id_token_signing_alg_values_supported")]
        public string[] IdTokenSigningAlgValuesSupported { get; set; }

        [JsonPropertyName("id_token_encryption_alg_values_supported")]
        public string[] IdTokenEncryptionAlgValuesSupported { get; set; }

        [JsonPropertyName("id_token_encryption_enc_values_supported")]
        public string[] IdTokenEncryptionEncValuesSupported { get; set; }

        [JsonPropertyName("userinfo_signing_alg_values_supported")]
        public string[] UserinfoSigningAlgValuesSupported { get; set; }

        [JsonPropertyName("request_object_signing_alg_values_supported")]
        public string[] RequestObjectSigningAlgValuesSupported { get; set; }

        [JsonPropertyName("response_modes_supported")]
        public string[] ResponseModesSupported { get; set; }

        [JsonPropertyName("registration_endpoint")]
        public Uri RegistrationEndpoint { get; set; }

        [JsonPropertyName("token_endpoint_auth_methods_supported")]
        public string[] TokenEndpointAuthMethodsSupported { get; set; }

        [JsonPropertyName("token_endpoint_auth_signing_alg_values_supported")]
        public string[] TokenEndpointAuthSigningAlgValuesSupported { get; set; }

        [JsonPropertyName("claims_supported")]
        public string[] ClaimsSupported { get; set; }

        [JsonPropertyName("claim_types_supported")]
        public string[] ClaimTypesSupported { get; set; }

        [JsonPropertyName("claims_parameter_supported")]
        public bool ClaimsParameterSupported { get; set; }

        [JsonPropertyName("scopes_supported")]
        public string[] ScopesSupported { get; set; }

        [JsonPropertyName("request_parameter_supported")]
        public bool RequestParameterSupported { get; set; }

        [JsonPropertyName("request_uri_parameter_supported")]
        public bool RequestUriParameterSupported { get; set; }

        [JsonPropertyName("code_challenge_methods_supported")]
        public string[] CodeChallengeMethodsSupported { get; set; }

        [JsonPropertyName("tls_client_certificate_bound_access_tokens")]
        public bool TlsClientCertificateBoundAccessTokens { get; set; }

        [JsonPropertyName("introspection_endpoint")]
        public Uri IntrospectionEndpoint { get; set; }
    }
}

