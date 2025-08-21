<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookBorrowing
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
        Label2 = New Label()
        txtFirstName = New TextBox()
        Label3 = New Label()
        txtLastName = New TextBox()
        Label4 = New Label()
        txtEmail = New TextBox()
        Label5 = New Label()
        txtPhoneNumber = New TextBox()
        Label6 = New Label()
        txtTitle = New TextBox()
        Label7 = New Label()
        txtREG = New TextBox()
        Label8 = New Label()
        cmbAvailability = New ComboBox()
        Label9 = New Label()
        dtpBorrowedDate = New DateTimePicker()
        Label10 = New Label()
        dtpDueDate = New DateTimePicker()
        Button1 = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(234, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(494, 41)
        Label1.TabIndex = 0
        Label1.Text = "BORROWING BOOK FORM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(35, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(143, 29)
        Label2.TabIndex = 1
        Label2.Text = "First Name"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFirstName.Location = New Point(228, 126)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(180, 36)
        txtFirstName.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(441, 125)
        Label3.Name = "Label3"
        Label3.Size = New Size(140, 29)
        Label3.TabIndex = 3
        Label3.Text = "Last Name"
        ' 
        ' txtLastName
        ' 
        txtLastName.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtLastName.Location = New Point(587, 121)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(197, 36)
        txtLastName.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(849, 125)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 29)
        Label4.TabIndex = 5
        Label4.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(944, 121)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(245, 36)
        txtEmail.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(35, 226)
        Label5.Name = "Label5"
        Label5.Size = New Size(191, 29)
        Label5.TabIndex = 7
        Label5.Text = "Phone Number"
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPhoneNumber.Location = New Point(232, 227)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(176, 36)
        txtPhoneNumber.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(605, 227)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 29)
        Label6.TabIndex = 9
        Label6.Text = "Title"
        ' 
        ' txtTitle
        ' 
        txtTitle.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTitle.Location = New Point(805, 226)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(384, 36)
        txtTitle.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(40, 329)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 29)
        Label7.TabIndex = 11
        Label7.Text = "REGNO"
        ' 
        ' txtREG
        ' 
        txtREG.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtREG.Location = New Point(228, 329)
        txtREG.Name = "txtREG"
        txtREG.Size = New Size(180, 36)
        txtREG.TabIndex = 12
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(605, 325)
        Label8.Name = "Label8"
        Label8.Size = New Size(145, 29)
        Label8.TabIndex = 13
        Label8.Text = "Availability"
        ' 
        ' cmbAvailability
        ' 
        cmbAvailability.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbAvailability.FormattingEnabled = True
        cmbAvailability.Items.AddRange(New Object() {"Available", "Unavailable"})
        cmbAvailability.Location = New Point(805, 325)
        cmbAvailability.Name = "cmbAvailability"
        cmbAvailability.Size = New Size(384, 37)
        cmbAvailability.TabIndex = 14
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(40, 421)
        Label9.Name = "Label9"
        Label9.Size = New Size(192, 29)
        Label9.TabIndex = 15
        Label9.Text = "Borrowed Date"
        ' 
        ' dtpBorrowedDate
        ' 
        dtpBorrowedDate.Format = DateTimePickerFormat.Short
        dtpBorrowedDate.Location = New Point(249, 421)
        dtpBorrowedDate.Name = "dtpBorrowedDate"
        dtpBorrowedDate.Size = New Size(300, 31)
        dtpBorrowedDate.TabIndex = 16
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Sienna
        Label10.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(605, 423)
        Label10.Name = "Label10"
        Label10.Size = New Size(123, 29)
        Label10.TabIndex = 17
        Label10.Text = "Due Date"
        ' 
        ' dtpDueDate
        ' 
        dtpDueDate.Format = DateTimePickerFormat.Short
        dtpDueDate.Location = New Point(805, 421)
        dtpDueDate.Name = "dtpDueDate"
        dtpDueDate.Size = New Size(384, 31)
        dtpDueDate.TabIndex = 18
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Olive
        Button1.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(441, 534)
        Button1.Name = "Button1"
        Button1.Size = New Size(214, 80)
        Button1.TabIndex = 19
        Button1.Text = "BORROW"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Olive
        btnExit.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(780, 534)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(193, 80)
        btnExit.TabIndex = 20
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' BookBorrowing
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Sienna
        ClientSize = New Size(1265, 637)
        Controls.Add(btnExit)
        Controls.Add(Button1)
        Controls.Add(dtpDueDate)
        Controls.Add(Label10)
        Controls.Add(dtpBorrowedDate)
        Controls.Add(Label9)
        Controls.Add(cmbAvailability)
        Controls.Add(Label8)
        Controls.Add(txtREG)
        Controls.Add(Label7)
        Controls.Add(txtTitle)
        Controls.Add(Label6)
        Controls.Add(txtPhoneNumber)
        Controls.Add(Label5)
        Controls.Add(txtEmail)
        Controls.Add(Label4)
        Controls.Add(txtLastName)
        Controls.Add(Label3)
        Controls.Add(txtFirstName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "BookBorrowing"
        Text = "BookBorrowing"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtREG As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbAvailability As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpBorrowedDate As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpDueDate As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents btnExit As Button
End Class
