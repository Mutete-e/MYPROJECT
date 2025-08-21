Imports System.Data.SqlClient
Imports Microsoft.Windows.Themes

Public Class ReturnForm

    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\MYPROJECT\MYPROJECT\Users.mdf;Integrated Security=True"
    Private Sub LoadData()
        ' Example: Fill a DataTable with book data
        Dim table As New DataTable()

        table.Columns.Add("Title")
        table.Columns.Add("Student Name")
        table.Columns.Add("Borrowed Date")
        ' Add sample rows

        table.Rows.Add("ATOMIC HABITS", "ABDUL RAZAK", "15/12/2024")
        table.Rows.Add("IT", "ELVIS SWAI", "13/12/2024")
        table.Rows.Add("IT", "JOSEPH MURIMA", "16/12/2024")
        table.Rows.Add("THE ALCHEMIST", "TIFFANY ACHIENG", "10/12/2024")
        table.Rows.Add("THE SHINING", "JANE WENDY", "12/12/2024")
        table.Rows.Add("THE ALCHEMIST", "TYLA WETIN", "13/12/2024")
        table.Rows.Add("THE NOTEBOOK", "TIFFANY ACHIENG", "3/12/2024")
        table.Rows.Add("THE HOBBIT", "SIMON KAMAU", "19/12/2024")
        table.Rows.Add("THE SHINING", "WILL MUSAU", "20/12/2024")
        table.Rows.Add("MADE FAMILIAR PHYSICS", "TYLA WETIN", "13/12/2024")
        table.Rows.Add("PRIDE AND PREJUDICE", "WINNIE  NYABOKE", "7/12/2024")
        table.Rows.Add("BANK MIND", "JOE MALOBA", "17/12/2024")
        table.Rows.Add("GAME OF THRONES", "CHRIS NJOROGE", "16/12/2024")
        table.Rows.Add("MADE FAMILIAR BIOLOGY", "ROSE MWENDE", "8/12/2024")
        table.Rows.Add("THE FAULT IN OUR STARS", "BIEN OPOLLO", "13/12/2024")
        table.Rows.Add("THE ALCHEMIST", "JOSEPH MURIMA", "8/12/2024")

        ' Bind the DataTable to the DataGridView
        dgvBorrowed.DataSource = table
    End Sub



    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        If dgvBorrowed.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a book to return.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Example logic to remove the selected row
        Dim selectedRow As DataGridViewRow = dgvBorrowed.SelectedRows(0)
        dgvBorrowed.Rows.Remove(selectedRow)

        MessageBox.Show("Book returned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim mainmenuForm As New MainMenu()
        mainmenuForm.Show()

        ' Close the current form (optional, if you don't need it open anymore)
        Me.Close()
    End Sub


    Private Sub ReturnForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData() ' 
    End Sub



    Private Sub dgvBorrowed_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBorrowed.CellContentClick

    End Sub
End Class