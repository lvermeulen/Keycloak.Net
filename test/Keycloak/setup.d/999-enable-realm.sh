PREFIX="[$(basename "$0")]"

echo "$PREFIX Create realm $KEYCLOAK_TEST_REALM"
/opt/keycloak/bin/kcadm.sh update realms/$KEYCLOAK_TEST_REALM \
    -s enabled=true -s displayName="Test Ready"