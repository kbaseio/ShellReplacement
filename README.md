# ShellReplacement

This program is intended to replace Windows Explorer as the main shell on a Microsoft Windows computer. You may use it on kiosk or thin client computers in order to restrain access to a few software only. It has also a password protected button to start Explorer.exe and a shutdown button.

This is a quick and dirty fork of the program made available (like 10 years ago) by avatar-e on Experts-Exchange.

- Identified  Main Developer : Erwin Ried - https://github.com/eried
- Source Article : https://www.experts-exchange.com/questions/23074854/Windows-Shell-Explorer-Replacement-with-simple-program-launcher.html
- Initial Source Code : http://erwin.ried.cl/files/articles/_public/ShellReplacement_0.1.zip

## Requirements 

### Dev
- Visual Studio 2017 

### Execution
- DotNet Framework 4.5

## Limitation

The software can only have 5 action buttons

## Installation

To replace the main shell, Windows Explorer (explorer.exe), please create the following registry value :

- Location : HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\Winlogon\
- Type : String
- Name : Shell
- Value : The full path to ShellReplacement.exe

Make sure the EXE and the CONFIG files are in the same folder.