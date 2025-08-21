<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        btnReturn = New Button()
        btnFines = New Button()
        btnNotification = New Button()
        btnLogout = New Button()
        btnBorrow = New Button()
        Button1 = New Button()
        Button2 = New Button()
        REPORTS = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(251, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(589, 54)
        Label1.TabIndex = 1
        Label1.Text = " CENTRAL CITY LIBRARY"
        ' 
        ' btnReturn
        ' 
        btnReturn.BackColor = Color.MediumSeaGreen
        btnReturn.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnReturn.Location = New Point(67, 349)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(225, 78)
        btnReturn.TabIndex = 2
        btnReturn.Text = "RETURN"
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' btnFines
        ' 
        btnFines.BackColor = Color.MediumSeaGreen
        btnFines.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnFines.Location = New Point(437, 349)
        btnFines.Name = "btnFines"
        btnFines.Size = New Size(250, 78)
        btnFines.TabIndex = 4
        btnFines.Text = "FINES"
        btnFines.UseVisualStyleBackColor = False
        ' 
        ' btnNotification
        ' 
        btnNotification.BackColor = Color.MediumSeaGreen
        btnNotification.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnNotification.Location = New Point(47, 484)
        btnNotification.Name = "btnNotification"
        btnNotification.Size = New Size(230, 66)
        btnNotification.TabIndex = 5
        btnNotification.Text = "NOTIFICATION"
        btnNotification.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.RosyBrown
        btnLogout.Location = New Point(1025, 557)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(176, 64)
        btnLogout.TabIndex = 6
        btnLogout.Text = "LOGOUT"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnBorrow
        ' 
        btnBorrow.BackColor = Color.MediumSeaGreen
        btnBorrow.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnBorrow.Location = New Point(793, 205)
        btnBorrow.Name = "btnBorrow"
        btnBorrow.Size = New Size(242, 71)
        btnBorrow.TabIndex = 7
        btnBorrow.Text = "BORROW"
        btnBorrow.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.MediumSeaGreen
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(437, 199)
        Button1.Name = "Button1"
        Button1.Size = New Size(250, 77)
        Button1.TabIndex = 8
        Button1.Text = "BOOK REGISTRATION"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.MediumSeaGreen
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(67, 198)
        Button2.Name = "Button2"
        Button2.Size = New Size(237, 88)
        Button2.TabIndex = 9
        Button2.Text = "USER REGISTRATION"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' REPORTS
        ' 
        REPORTS.BackColor = Color.MediumSeaGreen
        REPORTS.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        REPORTS.Location = New Point(793, 330)
        REPORTS.Name = "REPORTS"
        REPORTS.Size = New Size(252, 78)
        REPORTS.TabIndex = 10
        REPORTS.Text = "REPORTS"
        REPORTS.UseVisualStyleBackColor = False
        ' 
        ' MainMenu
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SaddleBrown
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1232, 684)
        Controls.Add(REPORTS)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(btnBorrow)
        Controls.Add(btnLogout)
        Controls.Add(btnNotification)
        Controls.Add(btnFines)
        Controls.Add(btnReturn)
        Controls.Add(Label1)
        Name = "MainMenu"
        Text = "MainMenu"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnFines As Button
    Friend WithEvents btnNotification As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnBorrow As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents REPORTS As Button
End Class
