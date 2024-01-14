FROM quay.io/keycloak/keycloak:20.0

USER root
RUN microdnf install -y jq
USER keycloak

WORKDIR /opt/keycloak

COPY *.sh .
COPY setup.d/*.sh setup.d/
ADD https://raw.githubusercontent.com/vishnubob/wait-for-it/master/wait-for-it.sh ./wait-for-it.sh

USER root
RUN chmod +x *.sh && \
    chown keycloak:root *.sh && \
    chmod +x setup.d/*.sh && \
    chown keycloak:root setup.d/*.sh
USER keycloak

ENV KEYCLOAK_ADMIN admin 
ENV KEYCLOAK_ADMIN_PASSWORD changeme
ENV KEYCLOAK_TEST_REALM test

ENTRYPOINT [ "/opt/keycloak/docker-entrypoint.sh" ]