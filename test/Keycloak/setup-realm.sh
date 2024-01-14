#!/bin/bash
PREFIX="[$(basename "$0")]"

set -e

echo "$PREFIX Waiting for Keycloak"
/opt/keycloak/wait-for-it.sh -t $((60 * 5)) localhost:8080
if [[ "$?" -ne 0 ]]; then
    echo "$PREFIX Keycloak could not be reached"
    exit $?
fi

echo "$PREFIX Login as admin"
/opt/keycloak/bin/kcadm.sh config credentials --server http://localhost:8080/auth/ --realm master --user "${KEYCLOAK_ADMIN}" --password "${KEYCLOAK_ADMIN_PASSWORD}"

setup_dir="setup.d"
if [ -d "$setup_dir" ]; then
    for script in "$setup_dir"/*.sh; do
        if [ -f "$script" ] ; then
            echo "$PREFIX Executing script: $script"
            bash $script
            if [ $? -ne 0 ]; then
                echo "$PREFIX Error: Script failed to execute"
                exit 1
            fi
        fi
    done
fi

echo "$PREFIX Keycloak setup completed"
exit 0
