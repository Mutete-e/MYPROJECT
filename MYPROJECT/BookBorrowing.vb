Imports System.Data.SqlClient

Public Class BookBorrowing
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\MYPROJECT\MYPROJECT\Users.mdf;Integrated Security=True"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FirstName As String = txtFirstName.Text
        Dim LastName As String = txtLastName.Text
        Dim Email As String = txtEmail.Text
        Dim PhoneNumber As String = txtPhoneNumber.Text
        Dim Title As String = txtTitle.Text
        Dim REGNO As String = txtREG.Text
        Dim Availability As String = cmbAvailability.SelectedItem
        Dim BorrowedDate As String = dtpBorrowedDate.Value.ToString 'dd MMM yyyy')
        Dim DueDate As String = dtpDueDate.Value.ToString

        ' Validation: Check if all fields are filled
        If String.IsNullOrEmpty(FirstName) Or String.IsNullOrEmpty(LastName) Or
           String.IsNullOrEmpty(Email) Or String.IsNullOrEmpty(PhoneNumber) Or
           String.IsNullOrEmpty(Title) Or String.IsNullOrEmpty(REGNO) Or
           String.IsNullOrEmpty(Availability) Then

            MessageBox.Show("Please fill all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' SQL query to insert data into the BorrowedBooksTable
        Dim query As String = "INSERT INTO BorrowedBooksTable (FirstName, LastName, Email, PhoneNumber, Title, REGNO, Availability, BorrowDate, DueDate) VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @Title, @REGNO, @Availability, @BorrowDate, @DueDate)"

        ' Insert data into the database
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)

                ' Add parameters to the query
                command.Parameters.AddWithValue("@FirstName", FirstName)
                command.Parameters.AddWithValue("@LastName", LastName)
                command.Parameters.AddWithValue("@Email", Email)
                command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber)
                command.Parameters.AddWithValue("@Title", Title)
                command.Parameters.AddWithValue("@REGNO", REGNO)
                command.Parameters.AddWithValue("@Availability", Availability)
                command.Parameters.AddWithValue("@BorrowDate", BorrowedDate)
                command.Parameters.AddWithValue("@DueDate", DueDate)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Record successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)



                    ' Clear the form fields after successful insertion
                    ClearFields()

                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using

    End Sub

    Private Sub ClearFields()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtEmail.Clear()
        txtPhoneNumber.Clear()
        txtTitle.Clear()
        txtREG.Clear()
        cmbAvailability.SelectedIndex = -1
        dtpBorrowedDate.Value = DateTime.Now
        dtpDueDate.Value = DateTime.Now
    End Sub

    Private Sub btnExitClick(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim mainmenuForm As New MainMenu()
        mainmenuForm.Show()

        ' Close the current form (optional, if you don't need it open anymore)
        Me.Close()
    End Sub

    Private Sub BookBorrowing_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class