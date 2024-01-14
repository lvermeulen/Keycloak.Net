$choices = @(
    @{
        Label = "Test / Setup and Run";
        Action = {
            & docker compose `
                -f docker-compose.test.yml `
                up --build --remove-orphans `
                --abort-on-container-exit `
                --exit-code-from tests

            
            & docker compose `
                -f docker-compose.test.yml `
                down
        };
    },
    @{
        Label = "Test / Setup Keycloak";
        Action = {
            & docker compose `
                -f docker-compose.test.yml `
                up keycloak --build --remove-orphans
        };
    },
    @{
        Label = "Test / Only Tests";
        Action = {
            & docker compose `
                -f docker-compose.test.yml `
                up tests --build --remove-orphans
        };
    },
    @{
        Label = "Test / Down";
        Action = {
            & docker compose `
                -f docker-compose.test.yml `
                down
        };
    }
)

function Run-Main {
    # call the function
    $title = @("Start up:")
    $choice = Show-Menu `
        -title ($title -join "`n")`
        -options @($choices | %{ $_.Label })

    if($null -ne $choice) {
        Run-Choice -choice $choice
    }
}

function Run-Choice($choice) {
    $selected = $choices | ?{ $_.Label -eq $choice } | Select -First 1
    if ($null -ne $selected) {
        & $selected.Action
    } else {
        Write-Error "Unsupported choice $choice"
    }
}

function Show-Menu {
    [CmdletBinding()]
    param (
        [string]$title="Please choose from the list below.",
        [string[]]$options = @()
    )
    # store the options in a List object for easy addition
    $list = [System.Collections.Generic.List[string]]::new()
    $list.AddRange($options)

    # now start an endless loop for the menu handling
    while ($true) {
        Clear-Host
        # loop through the options list and build the menu
        Write-Host "`r`n$title`r`n"
        $index = 1
        #$list.Sort()
        $list | ForEach-Object { Write-Host ("{0}.`t{1}" -f $index++, $_ )}
        Write-Host "`nQ.`tQuit"

        $selection = Read-Host "`r`nEnter Option"

        switch ($selection) {
            {$_ -like 'Q*' } {
                # if the user presses 'Q', exit the function
                return
            }
            default {
                # test if a valid numeric input in range has been given
                if ([int]::TryParse($selection, [ref]$index)) {
                    if ($index -gt 0 -and $index -le $list.Count) {
                        # do whatever you need to perform
                        $selection = $list[$index - 1]  # this gives you the text of the selected item

                        # for demo, just output on screen what option was selected
                        Write-Host "Executing $selection" -ForegroundColor Green
                        # return the selection made to the calling script
                        return $selection
                    }
                    else {
                        Write-Host "Please enter a valid option from the menu" -ForegroundColor Red
                    }
                }
                else {
                    Write-Host "Please enter a valid option from the menu" -ForegroundColor Red
                }
            }
        }

        # add a little pause and start over again
        Start-Sleep -Seconds 1
    }
}

Run-Main
