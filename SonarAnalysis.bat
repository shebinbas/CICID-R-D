@echo on
SET var=%cd%
cd %SONAR_SCANNER_INSTALLATION%
SonarScanner.MSBuild.exe begin /k:"CharacterBuilder" /d:sonar.host.url="http://localhost:9000" /d:sonar.login="sqp_a584c6f4a99232a9f40959f00ac479a5fcbbf41d"
cd var
MSBuild "%var%\unity-characterbuilder.sln" /t:Rebuild
cd %SONAR_SCANNER_INSTALLATION%
SonarScanner.MSBuild.exe end  /d:sonar.login="sqp_a584c6f4a99232a9f40959f00ac479a5fcbbf41d"
pause