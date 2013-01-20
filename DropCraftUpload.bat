@echo off
set minecraft=
set /p minecraft=What is your minecraft save called?  
if exist "%userprofile%/Dropbox/minecraft-storage/%minecraft%" rmdir /s /q "%userprofile%/Dropbox/minecraft-storage/%minecraft%"
cd C:/Users/Admin/Dropbox/minecraft-storage
mkdir %minecraft%
cd %AppData%/.minecraft/saves
xcopy /e "City" "%userprofile%/Dropbox/minecraft-storage/%minecraft%"
echo Copy Complete!
echo Press any key to exit
pause >nul