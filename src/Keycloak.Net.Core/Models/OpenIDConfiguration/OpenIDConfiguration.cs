using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Keycloak.Net.Models.OpenIDConfiguration
{
    public class OpenIDConfiguration
    {
        [JsonProperty("issuer")]
        public Uri Issuer { get; set; }

        [JsonProperty("authorization_endpoint")]
        public Uri AuthorizationEndpoint { get; set; }

        [JsonProperty("token_endpoint")]
        public Uri TokenEndpoint { get; set; }

        [JsonProperty("token_introspection_endpoint")]
        public Uri TokenIntrospectionEndpoint { get; set; }

        [JsonProperty("userinfo_endpoint")]
        public Uri UserinfoEndpoint { get; set; }

        [JsonProperty("end_session_endpoint")]
        public Uri EndSessionEndpoint { get; set; }

        [JsonProperty("jwks_uri")]
        public Uri JwksUri { get; set; }

        [JsonProperty("check_session_iframe")]
        public Uri CheckSessionIframe { get; set; }

        [JsonProperty("grant_types_supported")]
        public string[] GrantTypesSupported { get; set; }

        [JsonProperty("response_types_supported")]
        public string[] ResponseTypesSupported { get; set; }

        [JsonProperty("subject_types_supported")]
        public string[] SubjectTypesSupported { get; set; }

        [JsonProperty("id_token_signing_alg_values_supported")]
        public string[] IdTokenSigningAlgValuesSupported { get; set; }

        [JsonProperty("id_token_encryption_alg_values_supported")]
        public string[] IdTokenEncryptionAlgValuesSupported { get; set; }

        [JsonProperty("id_token_encryption_enc_values_supported")]
        public string[] IdTokenEncryptionEncValuesSupported { get; set; }

        [JsonProperty("userinfo_signing_alg_values_supported")]
        public string[] UserinfoSigningAlgValuesSupported { get; set; }

        [JsonProperty("request_object_signing_alg_values_supported")]
        public string[] RequestObjectSigningAlgValuesSupported { get; set; }

        [JsonProperty("response_modes_supported")]
        public string[] ResponseModesSupported { get; set; }

        [JsonProperty("registration_endpoint")]
        public Uri RegistrationEndpoint { get; set; }

        [JsonProperty("token_endpoint_auth_methods_supported")]
        public string[] TokenEndpointAuthMethodsSupported { get; set; }

        [JsonProperty("token_endpoint_auth_signing_alg_values_supported")]
        public string[] TokenEndpointAuthSigningAlgValuesSupported { get; set; }

        [JsonProperty("claims_supported")]
        public string[] ClaimsSupported { get; set; }

        [JsonProperty("claim_types_supported")]
        public string[] ClaimTypesSupported { get; set; }

        [JsonProperty("claims_parameter_supported")]
        public bool ClaimsParameterSupported { get; set; }

        [JsonProperty("scopes_supported")]
        public string[] ScopesSupported { get; set; }

        [JsonProperty("request_parameter_supported")]
        public bool RequestParameterSupported { get; set; }

        [JsonProperty("request_uri_parameter_supported")]
        public bool RequestUriParameterSupported { get; set; }

        [JsonProperty("code_challenge_methods_supported")]
        public string[] CodeChallengeMethodsSupported { get; set; }

        [JsonProperty("tls_client_certificate_bound_access_tokens")]
        public bool TlsClientCertificateBoundAccessTokens { get; set; }

        [JsonProperty("introspection_endpoint")]
        public Uri IntrospectionEndpoint { get; set; }
    }
}
