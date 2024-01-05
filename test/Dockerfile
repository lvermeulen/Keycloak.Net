FROM quay.io/keycloak/keycloak:latest as builder

WORKDIR /opt/keycloak

COPY docker-entrypoint.sh ./docker-entrypoint.sh
COPY setup-realm.sh ./setup-realm.sh
COPY start-keycloak.sh ./start-keycloak.sh
ADD https://raw.githubusercontent.com/vishnubob/wait-for-it/master/wait-for-it.sh ./wait-for-it.sh

USER root
RUN chmod +x *.sh && \
    chown keycloak:root *.sh
USER keycloak

ENV KEYCLOAK_ADMIN admin 
ENV KEYCLOAK_ADMIN_PASSWORD changeme
ENTRYPOINT [ "./docker-entrypoint.sh" ]