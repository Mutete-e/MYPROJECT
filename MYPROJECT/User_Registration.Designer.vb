<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Registration
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
        Dim Label6 As Label
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtFirstName = New TextBox()
        txtLastname = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        Button_REGISTER = New Button()
        ComboBox1 = New ComboBox()
        RadioButtonMale = New RadioButton()
        RadioButtonFemale = New RadioButton()
        Button1 = New Button()
        Label7 = New Label()
        txt_Password = New TextBox()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(502, 197)
        Label6.Name = "Label6"
        Label6.Size = New Size(89, 25)
        Label6.TabIndex = 12
        Label6.Text = "User Type"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(93, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 25)
        Label1.TabIndex = 0
        Label1.Text = "FirstName"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(501, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 25)
        Label2.TabIndex = 1
        Label2.Text = "LastName"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(93, 261)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 25)
        Label3.TabIndex = 2
        Label3.Text = "Gender"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(93, 127)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 25)
        Label4.TabIndex = 3
        Label4.Text = "Email"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(501, 133)
        Label5.Name = "Label5"
        Label5.Size = New Size(127, 25)
        Label5.TabIndex = 4
        Label5.Text = "PhoneNumber"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(208, 56)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(150, 31)
        txtFirstName.TabIndex = 5
        ' 
        ' txtLastname
        ' 
        txtLastname.Location = New Point(634, 56)
        txtLastname.Name = "txtLastname"
        txtLastname.Size = New Size(150, 31)
        txtLastname.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(208, 127)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(150, 31)
        txtEmail.TabIndex = 8
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(634, 127)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(150, 31)
        txtPhone.TabIndex = 9
        ' 
        ' Button_REGISTER
        ' 
        Button_REGISTER.BackColor = Color.LightSkyBlue
        Button_REGISTER.Location = New Point(452, 351)
        Button_REGISTER.Name = "Button_REGISTER"
        Button_REGISTER.Size = New Size(112, 34)
        Button_REGISTER.TabIndex = 10
        Button_REGISTER.Text = "REGISTER"
        Button_REGISTER.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Admin", "Staff", "Student"})
        ComboBox1.Location = New Point(634, 189)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 33)
        ComboBox1.TabIndex = 13
        ' 
        ' RadioButtonMale
        ' 
        RadioButtonMale.AutoSize = True
        RadioButtonMale.Location = New Point(198, 261)
        RadioButtonMale.Name = "RadioButtonMale"
        RadioButtonMale.Size = New Size(75, 29)
        RadioButtonMale.TabIndex = 14
        RadioButtonMale.TabStop = True
        RadioButtonMale.Text = "Male"
        RadioButtonMale.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonFemale
        ' 
        RadioButtonFemale.AutoSize = True
        RadioButtonFemale.Location = New Point(279, 261)
        RadioButtonFemale.Name = "RadioButtonFemale"
        RadioButtonFemale.Size = New Size(93, 29)
        RadioButtonFemale.TabIndex = 15
        RadioButtonFemale.TabStop = True
        RadioButtonFemale.Text = "Female"
        RadioButtonFemale.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightSkyBlue
        Button1.Location = New Point(634, 351)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 16
        Button1.Text = "EXIT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(93, 194)
        Label7.Name = "Label7"
        Label7.Size = New Size(87, 25)
        Label7.TabIndex = 17
        Label7.Text = "Password"
        ' 
        ' txt_Password
        ' 
        txt_Password.Location = New Point(208, 191)
        txt_Password.Name = "txt_Password"
        txt_Password.Size = New Size(150, 31)
        txt_Password.TabIndex = 18
        ' 
        ' User_Registration
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1279, 639)
        Controls.Add(txt_Password)
        Controls.Add(Label7)
        Controls.Add(Button1)
        Controls.Add(RadioButtonFemale)
        Controls.Add(RadioButtonMale)
        Controls.Add(ComboBox1)
        Controls.Add(Label6)
        Controls.Add(Button_REGISTER)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtLastname)
        Controls.Add(txtFirstName)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "User_Registration"
        Text = "User_Registration"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Button_REGISTER As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RadioButtonMale As RadioButton
    Friend WithEvents RadioButtonFemale As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_Password As TextBox
End Class
