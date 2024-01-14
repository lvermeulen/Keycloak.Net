#!/bin/bash
PREFIX="[$(basename "$0")]"

for index in {1..3}; do
    USERNAME="test-data-user-$index"
    EMAIL="user$index@example.com"

    echo "$PREFIX Create user $USERNAME on $KEYCLOAK_TEST_REALM"
    /opt/keycloak/bin/kcadm.sh create users -r $KEYCLOAK_TEST_REALM -s username=$USERNAME -s email=$EMAIL \
        -s enabled=true -s firstName=User -s lastName=$index
done