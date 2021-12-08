ilasm test.cil
if ($LASTEXITCODE -eq 0) {
    Write-Host "ilasm success: $LASTEXITCODE"
    .\test.exe
} else {
    Write-Host "ilasm failure: $LASTEXITCODE"
}
