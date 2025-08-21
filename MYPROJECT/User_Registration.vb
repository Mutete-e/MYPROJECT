Imports System.Data.SqlClient

Public Class User_Registration
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\MYPROJECT\MYPROJECT\Users.mdf;Integrated Security=True"

    Dim genderSelected As String

    Private Sub RadioButtonMale_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonMale.CheckedChanged
        If RadioButtonMale.Checked Then
            genderSelected = "Male"
        End If
    End Sub

    Private Sub RadioButtonFemale_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonFemale.CheckedChanged
        If RadioButtonFemale.Checked Then
            genderSelected = "Female"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button_REGISTER_Click(sender As Object, e As EventArgs) Handles Button_REGISTER.Click
        Try
            'Define the connection String (update your database information)
            Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\MYPROJECT\MYPROJECT\Users.mdf;Integrated Security=True"
            'Create a SQL INSERT Statement with parameters to prevent SQL injection
            Dim insertQuery As String = "INSERT INTO UserTable (FirstName, LastName, Email, PhoneNumber,Gender, UserType, Password) VALUES (@FirstName,@LastName, @Email, @PhoneNumber, @Gender, @UserType, @Password)"

            'Create a connection to the database
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                'Create a command with the INSERT statement and connection
                Using cmd As New SqlCommand(insertQuery, connection)
                    'Add parameters to the command
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                    cmd.Parameters.AddWithValue("@LastName", txtLastname.Text)
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text)
                    cmd.Parameters.AddWithValue("@Gender", genderSelected)
                    cmd.Parameters.AddWithValue("@UserType", ComboBox1.SelectedItem)
                    cmd.Parameters.AddWithValue("@Password", txt_Password.Text)


                    'Clear the form for the next capture of UserData
                    txtFirstName.Clear()
                    txtLastname.Clear()
                    txtEmail.Clear()
                    txtPhone.Clear()
                    RadioButtonMale.Checked = False
                    RadioButtonFemale.Checked = False
                    ComboBox1.SelectedIndex = -1
                    txt_Password.Clear()

                    'Execute the INSERT statement
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("Sign up successful! Redirecting to Login...", MsgBoxStyle.Information)

                        ' Navigate back to Login Form
                        Dim loginForm As New Loginform()
                        loginForm.Show()
                        Me.Close() ' Close the Registration form
                    Else
                        MsgBox("Sign up failed. Please try again.", MsgBoxStyle.Critical)
                    End If

                End Using
            End Using
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class