Get-ChildItem -Recurse -Filter *.cs | ForEach-Object {
    $filePath = $_.FullName
    $content = Get-Content -Path $filePath -Raw

    if ($content -notmatch 'using System\.Text\.Json\;') {
        Write-Host "Skipped $filePath, 'using System.Text.Json' not present." -ForegroundColor DarkRed
        Return;
    }

    # Check if "using System.Text.Json.Serialization" is not already present
    if ($content -match 'using System\.Text\.Json\.Serialization;') {
        Write-Host "Skipped $filePath, 'using System.Text.Json.Serialization' already present." -ForegroundColor DarkYellow
        Return;
    }

    # Replace "using System.Text.Json" with "using System.Text.Json.Serialization"
    $content = $content -replace 'using System\.Text\.Json;', 'using System.Text.Json.Serialization;'

    # Write the modified content back to the file
    Set-Content -Path $filePath -Value $content
    Write-Host "Updated $filePath" -ForegroundColor Green
}