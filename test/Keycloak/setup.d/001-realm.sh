#!/bin/bash
PREFIX="[$(basename "$0")]"

CLIENT_ID_ACCESS="test-client"
CLIENT_SECRET_ACCESS="test-client-secret"

echo "$PREFIX Create realm $KEYCLOAK_TEST_REALM"
/opt/keycloak/bin/kcadm.sh create realms -s realm=$KEYCLOAK_TEST_REALM \
    -s enabled=false -s displayName="Test setting up"

echo "$PREFIX Create client $CLIENT_ID_ACCESS on $KEYCLOAK_TEST_REALM"
/opt/keycloak/bin/kcadm.sh create clients -r $KEYCLOAK_TEST_REALM -s clientId=$CLIENT_ID_ACCESS -s enabled=true -s secret=$CLIENT_SECRET_ACCESS\
    -s directAccessGrantsEnabled=true -s serviceAccountsEnabled=true

CLIENT_SA="service-account-$CLIENT_ID_ACCESS"
echo "$PREFIX Adding roles to service account $CLIENT_SA on $KEYCLOAK_TEST_REALM"
/opt/keycloak/bin/kcadm.sh add-roles -r $KEYCLOAK_TEST_REALM --uusername $CLIENT_SA --cclientid realm-management \
    --rolename view-identity-providers \
    --rolename manage-events \
    --rolename view-clients \
    --rolename view-authorization \
    --rolename view-users \
    --rolename realm-admin \
    --rolename query-users \
    --rolename impersonation \
    --rolename manage-identity-providers \
    --rolename view-realm \
    --rolename query-clients \
    --rolename view-events \
    --rolename manage-authorization \
    --rolename query-groups \
    --rolename create-client \
    --rolename manage-realm \
    --rolename query-realms \
    --rolename manage-users \
    --rolename manage-clients