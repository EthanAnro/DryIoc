@echo off
setlocal EnableDelayedExpansion

dotnet clean -v:m
dotnet build -c:Release -v:m
if %ERRORLEVEL% neq 0 goto :error

echo:
echo:## Finished: RESTORE and BUILD
echo:
echo:## Starting: TestRunner...
echo:

dotnet run --no-build -f net8.0 -c Release --project test/DryIoc.TestRunner
if %ERRORLEVEL% neq 0 goto :error
dotnet run --no-build -c Release --project test/DryIoc.TestRunner.net472
if %ERRORLEVEL% neq 0 goto :error

echo:
echo:## Finished: TestRunner
echo:
echo:## Starting: TESTS...
echo: 

dotnet test --no-build -c:Release

if %ERRORLEVEL% neq 0 goto :error

echo: 
echo:## Finished: TESTS
echo:
echo:## Starting: DOCUMENTATION GENERATION ##
echo:

dotnet build docs\DryIoc.Docs\DryIoc.Docs.csproj -f net6.0 -target:MdGenerate

echo:
echo:## Finished: DOCUMENTATION GENERATION ##
echo:

echo:## Finished: ALL Successful ##
exit /b 0

:error
echo:
echo:## Build is failed :-(
exit /b 1
