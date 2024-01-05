#!/bin/bash

/opt/keycloak/bin/kc.sh start \
    --http-enabled=true \
    --hostname-url=http://localhost:8080/auth/ \
    --http-relative-path /auth/
