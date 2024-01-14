#!/bin/bash
PREFIX="[$(basename "$0")]"

for index in {1..3}; do
    role_name="test-data-role-$index"
    echo "$PREFIX Create role $role_name on $KEYCLOAK_TEST_REALM"
    /opt/keycloak/bin/kcadm.sh create roles -r $KEYCLOAK_TEST_REALM -s name=$role_name

    username="test-data-user-$index"
    user_id=$(/opt/keycloak/bin/kcadm.sh get users -r $KEYCLOAK_TEST_REALM --fields id,username | jq -r ".[] | select(.username == \"$username\") | .id")
    echo "$PREFIX Assign role $role_name to user $username with id $user_id"
    /opt/keycloak/bin/kcadm.sh add-roles -r $KEYCLOAK_TEST_REALM --uid $user_id --rolename $role_name
done