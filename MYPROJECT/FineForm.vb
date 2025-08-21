Imports System.Data.SqlClient

Public Class FineForm
    ' Fine rate per day
    Private Const FineRate As Decimal = 20D ' 20 KES fine per 3 days


    Private Sub FineForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set default values for DateTimePickers
        dtpBorrowedDate.Value = DateTime.Now.AddDays(-7) ' Example: Default borrowed date to 7 days ago
        dtpDueDate.Value = DateTime.Now.AddDays(-2) ' Example: Default due date to 2 days ago
    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtStudentName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class