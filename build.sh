#!/bin/sh

cd parent
git pull && git status
cd ..

dotnet build
rm -R parent/test/PoViEmu.Tests/TestResults
rm -R src/PocketEmu.Tests/TestResults
dotnet test --collect:"XPlat Code Coverage"
~/.dotnet/tools/reportgenerator -reports:**/coverage.cobertura.xml -targetdir:coverage -reporttypes:Html
