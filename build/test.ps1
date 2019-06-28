foreach ($test in ls $PSScriptRoot\..\test/*) {
    Push-Location $test

	Write-Output "build: Testing project in $test"

	& dotnet restore --no-cache
    & dotnet test
    if($LASTEXITCODE -ne 0) { exit 1 }    

    Pop-Location
}
