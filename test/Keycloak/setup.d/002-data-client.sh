#!/bin/bash
PREFIX="[$(basename "$0")]"

CLIENT_ID_SUBJECT="test-client-subject"
CLIENT_SECRET_SUBJECT="test-client-subject-secret"

echo "$PREFIX Create client $CLIENT_ID_SUBJECT on $KEYCLOAK_TEST_REALM"
/opt/keycloak/bin/kcadm.sh create clients -r $KEYCLOAK_TEST_REALM -s clientId=$CLIENT_ID_SUBJECT -s enabled=true -s secret=$CLIENT_SECRET_SUBJECT \
    -s directAccessGrantsEnabled=true -s serviceAccountsEnabled=true -s authorizationServicesEnabled=true