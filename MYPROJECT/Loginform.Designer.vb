<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Loginform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        btnlogin = New Button()
        txt_Email = New TextBox()
        txtPassword = New TextBox()
        btnsignup = New Button()
        CheckBox1 = New CheckBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.SkyBlue
        Label1.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(114, 158)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 30)
        Label1.TabIndex = 0
        Label1.Text = "EMAIL"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.SkyBlue
        Label2.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(114, 227)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 30)
        Label2.TabIndex = 1
        Label2.Text = "PASSWORD"
        ' 
        ' btnlogin
        ' 
        btnlogin.BackColor = Color.DeepSkyBlue
        btnlogin.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnlogin.Location = New Point(577, 351)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(163, 54)
        btnlogin.TabIndex = 2
        btnlogin.Text = "LOGIN"
        btnlogin.UseVisualStyleBackColor = False
        ' 
        ' txt_Email
        ' 
        txt_Email.Location = New Point(290, 159)
        txt_Email.Name = "txt_Email"
        txt_Email.Size = New Size(190, 31)
        txt_Email.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(279, 227)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(190, 31)
        txtPassword.TabIndex = 4
        ' 
        ' btnsignup
        ' 
        btnsignup.BackColor = Color.DeepSkyBlue
        btnsignup.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnsignup.Location = New Point(290, 351)
        btnsignup.Name = "btnsignup"
        btnsignup.Size = New Size(143, 54)
        btnsignup.TabIndex = 5
        btnsignup.Text = "SIGN UP"
        btnsignup.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.SkyBlue
        CheckBox1.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(496, 227)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(95, 34)
        CheckBox1.TabIndex = 6
        CheckBox1.Text = "Show"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 22F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(129, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(518, 60)
        Label3.TabIndex = 7
        Label3.Text = "CENTRAL CITY LIBRARY"
        ' 
        ' Loginform
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(939, 450)
        Controls.Add(Label3)
        Controls.Add(CheckBox1)
        Controls.Add(btnsignup)
        Controls.Add(txtPassword)
        Controls.Add(txt_Email)
        Controls.Add(btnlogin)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Loginform"
        Text = "LOGIN FORM"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnlogin As Button
    Friend WithEvents txt_Email As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnsignup As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label3 As Label

End Class
