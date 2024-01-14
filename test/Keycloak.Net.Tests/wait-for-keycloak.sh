#!/bin/bash

KEYCLOAK_URL="http://keycloak:8080/auth/realms/$KEYCLOAK_TEST_REALM/protocol/openid-connect/auth"
WAIT_INTERVAL=5
CURL_TIMEOUT=2 

echo "Waiting for realm $KEYCLOAK_TEST_REALM to be available on $KEYCLOAK_URL"
while true; do
    http_status=$(curl -sS --max-time $CURL_TIMEOUT -o /tmp/response.txt -w "%{http_code}" "$KEYCLOAK_URL")
    if [[ $http_status -gt 000 && $http_status -lt 500 ]]; then
        response=$(cat /tmp/response.txt)
        title=$(echo $response | grep -oP '<title>\K[^<]+')
        if [[ $title == *"Test Ready"* ]]; then
            echo "Realm exists! Response: $title"
            break
        fi
    fi

    echo "Realm not yet available. Retrying in $WAIT_INTERVAL seconds..."
    sleep $WAIT_INTERVAL
done