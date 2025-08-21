Imports System
Imports System.Windows.Forms

Module Program
    ' The entry point for the application
    Sub Main()
        ' Enable visual styles and compatible text rendering
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        ' Start the application with the LoginForm
        ' This initializes the LoginForm as the starting form
        Dim loginForm As New Loginform
        Application.Run(New Loginform)
    End Sub
End Module

