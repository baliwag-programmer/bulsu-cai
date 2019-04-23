@echo off

set user=%1
set db=%2
set host=%3
set port=%4
set filename=%5

ECHO %filename%
"%~dp0mysqldump.exe" -u %user% %db% --host %host% --port %port% --no-create-info=true --verbose > %filename%