#!/bin/bash
PREFIX="[$(basename "$0")]"

for index in {1..2}; do
    GROUP_NAME="test-data-group-$index"
    
    echo "$PREFIX Create group $GROUP_NAME on $KEYCLOAK_TEST_REALM"
    /opt/keycloak/bin/kcadm.sh create groups -r $KEYCLOAK_TEST_REALM -s name=$GROUP_NAME
done

# Create a group with at least one subgroup
GROUP_NAME="test-data-group-3"
echo "$PREFIX Create group $GROUP_NAME on $KEYCLOAK_TEST_REALM"
parent_group_id=$(/opt/keycloak/bin/kcadm.sh create groups -r $KEYCLOAK_TEST_REALM -s name=$GROUP_NAME -i)

# Create a subgroup
SUBGROUP_NAME="test-data-group-3-subgroup-1"
echo "$PREFIX Create subgroup $SUBGROUP_NAME under $GROUP_NAME"
/opt/keycloak/bin/kcadm.sh create groups/$parent_group_id/children -r $KEYCLOAK_TEST_REALM -s name=$SUBGROUP_NAME