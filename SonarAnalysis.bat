@echo on
SET var=%cd%
cd %SONAR_SCANNER_INSTALLATION%
SonarScanner.MSBuild.exe begin /k:"CICD-R-D" /d:sonar.host.url="http://localhost:9000" /d:sonar.login="sqp_a1d5be418df3533e83614f3107e85c5b6fee0803"
cd var
MSBuild "%var%\CICID-R-D.sln" /t:Build
cd %SONAR_SCANNER_INSTALLATION%
SonarScanner.MSBuild.exe end  /d:sonar.login="sqp_a1d5be418df3533e83614f3107e85c5b6fee0803"
pause