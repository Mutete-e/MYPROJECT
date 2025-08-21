Public Class MainMenu
    ' Properties to store logged-in user information
    Public LoggedInUser As String
    Public UserType As String ' e.g., "Student", "Staff", "Admin"
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the welcome message
        Label1.Text = $"Welcome, {LoggedInUser} ({UserType})"

        ConfigureMenuBasedOnRole()

    End Sub
    Private Sub ConfigureMenuBasedOnRole()


        If UserType = "Student" Then
            ' Show buttons relevant to students

            btnBorrow.Visible = False
            btnReturn.Visible = False
            btnFines.Visible = False
            btnNotification.Visible = False

        ElseIf UserType = "Staff" Then
            ' Show staff features
            btnBorrow.Visible = True
            btnNotification.Visible = True
            btnFines.Visible = True
            btnReturn.Visible = True


        ElseIf UserType = "Admin" Then
            ' Show all features for admins
            btnBorrow.Visible = True
            btnNotification.Visible = True
            btnFines.Visible = True
            btnReturn.Visible = True

        End If
    End Sub

    Private Sub btnFines_Click(sender As Object, e As EventArgs) Handles btnFines.Click
        ' Navigate to Outstanding Fines form
        Dim finesForm As New FineForm()
        finesForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnNotification.Click
        ' Navigate to Reports form
        Dim notificationForm As New NotificationForm()
        notificationForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Navigate back to Login Form
        Dim loginForm As New Loginform()
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        Dim bookborrowingForm As New BookBorrowing()
        bookborrowingForm.Show()
        Me.Close()
    End Sub

    Private Sub btnManage_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim returnForm As New ReturnForm()
        returnForm.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim book_registration As New Book_Registration()
        book_registration.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim user_registration As New User_Registration()
        user_registration.Show()
        Me.Close()
    End Sub

    Private Sub REPORTS_Click(sender As Object, e As EventArgs) Handles REPORTS.Click
        Dim reports As New REPORTS()
        reports.Show()
        Me.Close()
    End Sub
End Class