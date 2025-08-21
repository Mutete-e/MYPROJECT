<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotificationForm
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
        btnSend = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtToAddress = New TextBox()
        txtFromAddress = New TextBox()
        txtSubject = New TextBox()
        txtBody = New TextBox()
        SuspendLayout()
        ' 
        ' btnSend
        ' 
        btnSend.Font = New Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSend.Location = New Point(628, 392)
        btnSend.Name = "btnSend"
        btnSend.Size = New Size(133, 48)
        btnSend.TabIndex = 0
        btnSend.Text = "SEND"
        btnSend.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(46, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 34)
        Label1.TabIndex = 1
        Label1.Text = "To"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(46, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 34)
        Label2.TabIndex = 2
        Label2.Text = "From"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(46, 196)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 34)
        Label3.TabIndex = 3
        Label3.Text = "Subject"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(60, 270)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 34)
        Label4.TabIndex = 4
        Label4.Text = "Body"
        ' 
        ' txtToAddress
        ' 
        txtToAddress.Location = New Point(175, 69)
        txtToAddress.Name = "txtToAddress"
        txtToAddress.Size = New Size(150, 31)
        txtToAddress.TabIndex = 5
        ' 
        ' txtFromAddress
        ' 
        txtFromAddress.Location = New Point(175, 129)
        txtFromAddress.Name = "txtFromAddress"
        txtFromAddress.Size = New Size(150, 31)
        txtFromAddress.TabIndex = 6
        ' 
        ' txtSubject
        ' 
        txtSubject.Location = New Point(175, 196)
        txtSubject.Multiline = True
        txtSubject.Name = "txtSubject"
        txtSubject.Size = New Size(150, 31)
        txtSubject.TabIndex = 7
        ' 
        ' txtBody
        ' 
        txtBody.Location = New Point(175, 267)
        txtBody.Multiline = True
        txtBody.Name = "txtBody"
        txtBody.Size = New Size(271, 138)
        txtBody.TabIndex = 8
        ' 
        ' NotificationForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSeaGreen
        ClientSize = New Size(1047, 549)
        Controls.Add(txtBody)
        Controls.Add(txtSubject)
        Controls.Add(txtFromAddress)
        Controls.Add(txtToAddress)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSend)
        Name = "NotificationForm"
        Text = "NotificationForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSend As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtToAddress As TextBox
    Friend WithEvents txtFromAddress As TextBox
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents txtBody As TextBox
End Class
