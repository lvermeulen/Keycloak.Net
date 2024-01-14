#!/bin/bash

# Find directories containing at least one file with .csproj extension
result=$(find "/src/test/" -type f -name '*.csproj' -exec dirname {} \; | sort -u)

for dir in $result; do
    echo "Testing $dir"
    pushd "$dir" || exit 1 

    dotnet restore
    dotnet test

    popd || exit 1
done