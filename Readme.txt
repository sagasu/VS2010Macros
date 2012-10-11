A basic macro to attach a debugger to w3wp.exe process. I tend to use a shortcut: ctrl+b, ctrl+b

To add to Visual Studio you need to:
1) Tools->Macros->Macros IDE... (or Alt+F11)   It will open a macros IDE

2) At the top you will see "My Macros" item. Click on it an choose Add->Add Existing Item. Navigate to a macro file.
3) Done :) If you want to set up a key shortcut go to VisualStudio -> Tools -> Options -> Keyboard
4) In Show commands containing form type: Macros.MyMacros.AttachDebuggerModule.AttachDebugger
5) In "Press shortcut keys" type: ctrl +b, ctrl + b