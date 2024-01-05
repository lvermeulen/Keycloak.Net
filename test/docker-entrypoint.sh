#!/bin/bash

exec /opt/keycloak/setup-realm.sh & 
    exec /opt/keycloak/start-keycloak.sh
exit $?
