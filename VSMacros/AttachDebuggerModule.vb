Imports System
Imports EnvDTE
Imports EnvDTE80
Imports EnvDTE90
Imports EnvDTE90a
Imports EnvDTE100
Imports System.Diagnostics

Public Module AttachDebuggerModule
    Public Sub AttachDebugger()
        For Each proc In DTE.Debugger.LocalProcesses
            If proc.Name.IndexOf("w3wp.exe") <> -1 Then
                proc.Attach()
                Exit Sub
            End If
        Next
    End Sub
End Module
