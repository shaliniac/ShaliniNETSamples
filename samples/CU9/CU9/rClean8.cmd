DEL /S /F *.vssscc *.vspscc
DEL /S /F /Q /A H *.suo
for /d /r . %%d in (bin,obj,App_Data,packages) do @if exist "%%d" rd /s/q "%%d"
