## How to use this docker-compose with tests:

* run: "docker-compose up"
* go to http://localhost:8087
* Login with user: admin, pass: Pa55w0rd
* create realm: Insurance
* create client id within Insurance: insurance-product
* create user within Insurance: admin
* set password of admin to: Pa55w0rd
* copy the appsettings.json in this directory to ../Keycloak.Net.Tests
* run the tests!

Every test except of `GetResourcesOwnedByClientAsync` should succeed
