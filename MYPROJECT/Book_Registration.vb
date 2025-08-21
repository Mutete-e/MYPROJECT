Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Book_Registration
    Private Sub Data_Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'Define the connection String (update your database information)
            Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\MYPROJECT\MYPROJECT\Users.mdf;Integrated Security=True"
            'Create a SQL INSERT Statement with parameters to prevent SQL injection
            Dim insertQuery As String = "INSERT INTO BooksTable (TITLE, GENRE, ISBN,AUTHOR, REGNO) VALUES (@TITLE, @GENRE, @ISBN, @AUTHOR, @REGNO)"

            'Create a connection to the database
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                'Create a command with the INSERT statement and connection
                Using cmd As New SqlCommand(insertQuery, connection)
                    'Add parameters to the command
                    cmd.Parameters.AddWithValue("@TITLE", txtTitle.Text)
                    cmd.Parameters.AddWithValue("GENRE", cmbGenre.SelectedItem)
                    cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text)
                    cmd.Parameters.AddWithValue("@AUTHOR", txtAuthor.Text)
                    cmd.Parameters.AddWithValue("REGNO", txtreg.Text)



                    'Execute the INSERT statement
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("Data inserted successfully.", MsgBoxStyle.Information)

                        'Clear the form for the next capture of UserData
                        txtTitle.Clear()
                        cmbGenre.SelectedIndex = -1
                        txtISBN.Clear()
                        txtAuthor.Clear()
                        txtreg.Clear()




                    Else
                        MsgBox("Data insertion failed", MsgBoxStyle.Critical)

                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtreg.TextChanged

    End Sub
End Class