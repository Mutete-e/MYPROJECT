Imports System.Data.SqlClient
Imports Microsoft.Windows.Themes

Public Class REPORTS

    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\MYPROJECT\MYPROJECT\Users.mdf;Integrated Security=True"

    ' Method to fetch and display data in DataGridView

    Private Sub LoadData()
        ' Example: Fill a DataTable with book data
        Dim table As New DataTable()

        table.Columns.Add("TITLE")
        table.Columns.Add("BORROWED COPIES")
        table.Columns.Add("REMAINING COPIES")
        table.Columns.Add("TOTAL")
        table.Columns.Add("LOST COPIES")


        table.Rows.Add("ATOMIC HABITS", "22", "9", "31", "12")
        table.Rows.Add("GAME OF THRONES", "13", "8", "21", "4")
        table.Rows.Add("IT", "6", "8", "14", "10")
        table.Rows.Add("The HOBBIT", "15", "10", "25", "4")
        table.Rows.Add("BANK MIND", "5", "10", "15", "7")
        table.Rows.Add("THE ALCHEMIST", "27", "19", "46", "4")
        table.Rows.Add("MADE FAMILIAR PHYSICS", "27", "16", "43", "-")
        table.Rows.Add("MADE FAMILIAR BIOLOG", "27", "17", "44", "2")
        table.Rows.Add("THE FAULT IN OUR STARS", "24", "16", "40", "3")
        table.Rows.Add("PRIDE AND PREJUDICE", "28", "16", "44", "7")
        table.Rows.Add("MENTOR ENGLISH", "12", "6", "18", "-")
        table.Rows.Add("THE SHINING", "14", "17", "31", "-")
        table.Rows.Add("-", "193", "152", "49")
        ' Bind the DataTable to the DataGridView
        dgvReports.DataSource = table
    End Sub






    ' Event handler for Refresh Button click
    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs)
        LoadData()
    End Sub

    ' Form Load Event
    Private Sub LibraryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData() ' Load data when form loads
    End Sub

    Private Sub dgvBooks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReports.CellContentClick

    End Sub
End Class


