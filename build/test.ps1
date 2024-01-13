$workingDirectory = "$PSScriptRoot\..";



$testProjects = Get-ChildItem -Recurse -Include "*.csproj" (Join-Path $workingDirectory "test")
foreach ($test in $testProjects) {
    Push-Location $test.Parent

	Write-Output "build: Testing project in $test"

	& dotnet restore --no-cache
    & dotnet test
    if($LASTEXITCODE -ne 0) { exit 1 }    

    Pop-Location
}
