#!/bin/bash
PREFIX="[$(basename "$0")]"

TMP=$(date -u +%s)

REALM_ID="test"
CLIENT_ID="test-client"
CLIENT_SECRET="test-client-secret"

set -e

echo "$PREFIX Waiting for Keycloak"
/opt/keycloak/wait-for-it.sh -t $((60*5)) localhost:8080 
if [[ "$?" -ne 0 ]]; then
    echo "$PREFIX Keycloak could not be reached"
    exit $?
fi

echo "$PREFIX Login as admin"
/opt/keycloak/bin/kcadm.sh config credentials --server http://localhost:8080/auth/ --realm master --user "${KEYCLOAK_ADMIN}" --password "${KEYCLOAK_ADMIN_PASSWORD}"

echo "$PREFIX Create realm $REALM_ID"
/opt/keycloak/bin/kcadm.sh create realms -s realm=$REALM_ID -s enabled=true

echo "$PREFIX Create client $CLIENT_ID"
/opt/keycloak/bin/kcadm.sh create clients -r $REALM_ID -s clientId=$CLIENT_ID -s enabled=true -s secret=$CLIENT_SECRET\
    -s directAccessGrantsEnabled=true -s serviceAccountsEnabled=true

CLIENT_SA="service-account-$CLIENT_ID"
echo "$PREFIX Adding roles to service account $CLIENT_SA"
/opt/keycloak/bin/kcadm.sh add-roles -r $REALM_ID --uusername $CLIENT_SA --cclientid realm-management \
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

echo "$PREFIX Keycloak realm '$REALM_ID' and client with fixed credentials have been created."

exit $?
