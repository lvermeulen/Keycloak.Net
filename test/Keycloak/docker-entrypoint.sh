#!/bin/bash

/opt/keycloak/setup-realm.sh &
keycloak_setup_pid=$!

/opt/keycloak/start-keycloak.sh &
keycloak_pid=$!

wait $keycloak_setup_pid
wait $keycloak_pid

exit $?