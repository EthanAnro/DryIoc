# Rename project steps:
#
# 1. Rename project folder
param(
    [parameter(
        HelpMessage="Existing C# Project to rename",
        Mandatory=$true, ValueFromPipeline=$true)]
    [ValidateScript({Test-Path -Path ("$_.csproj")})]
    [string]$ProjectFileName,
    
    [parameter(
        HelpMessage="New project name",
        Mandatory=$true)]
    [string]$NewName)
        
$ProjectPath=Resolve-Path ("$ProjectFileName.csproj")
$ProjectName=[IO.Path]::GetFileNameWithoutExtension($ProjectPath)

echo "Renaming project from `"$ProjectName`" to `"$NewName`" target ..."



# 2. Rename .proj file and other tools ProjectName. files
# 3. Rename ProjectName in .sln file
# 4. Rename ProjectName inside .proj file: RootNamespace and AssemblyName 
# TADAH!



# (Get-Content .\source.txt) | % {$_ -replace [regex]"\bword\b", "WORD"} | Set-Content .\result.txt