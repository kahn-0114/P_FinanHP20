@ECHO OFF

REM =============================================
REM パラメータ設定
REM =============================================
REM 起動プログラム
REM SET EXENAME=MENU.EXE
REM SET EXENAME=p_AttenMN00.exe

REM SET BINDRIVE=C:\p_AttenMN00\Bin\

REM SET PATCHDIR=\\192.168.102.195\p_AttenMN00\MainPgm\


REM =============================================
REM 起動処理
REM =============================================
%BINDRIVE%
REM CD %BINDRIVE%%BINDIR%
REM ATTRIB -R %BINDRIVE%%BINDIR%*.*
REM ATTRIB -R %PATCHDIR%*.*
REM XCOPY %PATCHDIR%*.* *.* /D/Y

REM Sleep.bat [秒数]
rem set /a wtime=10000
rem echo WScript.Sleep %wtime% > tmp.vbs
rem cscript //NoLogo tmp.vbs 
rem del tmp.vbs

REM START p_InVenMN00.exe /high
START p_InVenMN00.exe
QUIT
