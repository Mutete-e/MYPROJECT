Imports System.Reflection.Metadata.Ecma335
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Public Class Loginform
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\MYPROJECT\MYPROJECT\Users.mdf;Integrated Security=True"
    Private cmd As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim EMAIL As String = txt_Email.Text
        Dim PASSWORD As String = txtPassword.Text


        If AuthenticateUser(EMAIL, PASSWORD) Then
            MsgBox("Login successful!", MsgBoxStyle.Information)

            ' Hide the Login Form and show the Registration Form
            Me.Hide()
            Dim mainmenu As New MainMenu()
            mainmenu.ShowDialog() ' Show the UserForm as a modal dialog
            Me.Show() ' Show the LoginForm again once the UserForm is closed


        Else
            MsgBox("Invalid username or password.Please try again.", MsgBoxStyle.Information)
        End If

    End Sub



    Private Function AuthenticateUser(Username As String, PASSWORD As String) As Boolean
        Using Connection As New SqlConnection(connectionString)
            Connection.Open()
            'prevent SQL injection by using parameterized sql query 
            Dim loginQuery As String = "SELECT COUNT(*) FROM UserTable WHERE EMAIL = @EMAIL AND PASSWORD = @PASSWORD"

            Using Command As New SqlCommand(loginQuery, Connection)
                Command.Parameters.AddWithValue("@EMAIL", txt_Email.Text)
                Command.Parameters.AddWithValue("@PASSWORD", txtPassword.Text)

                Dim count As Integer = CInt(Command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsignup.Click
        ' Hide the Login Form and show the Registration Form
        Me.Hide()
        Dim userForm As New User_Registration()
        userForm.ShowDialog() ' Show the UserForm as a modal dialog
        Me.Show() ' Show the LoginForm again once the UserForm is closed


    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub Loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
