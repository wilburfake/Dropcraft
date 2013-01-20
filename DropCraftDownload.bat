@echo off
set minecraft=
set /p minecraft=What is your minecraft save in dropbox called?  
cd %AppData%/.minecraft/saves
if exist "%minecraft%" rmdir /s /q "%minecraft%"
mkdir %minecraft%
xcopy /e "%userprofile%/Dropbox/minecraft-storage/%minecraft%" "%minecraft%" 
echo Download Complete!
echo Press any key to exit
pause >nul