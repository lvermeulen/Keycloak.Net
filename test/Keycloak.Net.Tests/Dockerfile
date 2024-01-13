FROM mcr.microsoft.com/dotnet/sdk:8.0

ENV KEYCLOAK_ADMIN admin 
ENV KEYCLOAK_ADMIN_PASSWORD changeme
ENV KEYCLOAK_TEST_REALM test

WORKDIR /src
COPY test/Keycloak.Net.Tests/setup-instance.sh test/Keycloak.Net.Tests/setup-instance.sh
RUN bash test/Keycloak.Net.Tests/setup-instance.sh

COPY Keycloak.Net.sln .
COPY Keycloak.Net.snk .
COPY src src
COPY test/Keycloak.Net.Tests  test/Keycloak.Net.Tests 

RUN chmod +x test/Keycloak.Net.Tests/*.sh

ENTRYPOINT [ "/src/test/Keycloak.Net.Tests/docker-entrypoint.sh" ]