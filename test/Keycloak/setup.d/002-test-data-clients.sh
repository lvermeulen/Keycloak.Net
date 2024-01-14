#!/bin/bash
PREFIX="[$(basename "$0")]"

for index in {1..3}; do
    CLIENT_ID="test-data-client-$index"
    echo "$PREFIX Create client $CLIENT_ID on $KEYCLOAK_TEST_REALM"
    /opt/keycloak/bin/kcadm.sh create clients -r $KEYCLOAK_TEST_REALM -s clientId=$CLIENT_ID -s enabled=true \
        -s directAccessGrantsEnabled=true -s serviceAccountsEnabled=true -s authorizationServicesEnabled=true
done