<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FineForm
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
        Label2 = New Label()
        dtpBorrowedDate = New DateTimePicker()
        Label3 = New Label()
        dtpDueDate = New DateTimePicker()
        Label5 = New Label()
        Button1 = New Button()
        Label4 = New Label()
        dtpPaymentDate = New DateTimePicker()
        Button3 = New Button()
        lblFineAmount = New Label()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(49, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(169, 26)
        Label2.TabIndex = 2
        Label2.Text = "Borrowed Date"
        ' 
        ' dtpBorrowedDate
        ' 
        dtpBorrowedDate.Location = New Point(258, 127)
        dtpBorrowedDate.Name = "dtpBorrowedDate"
        dtpBorrowedDate.Size = New Size(300, 31)
        dtpBorrowedDate.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(605, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 26)
        Label3.TabIndex = 4
        Label3.Text = "Due Date"
        ' 
        ' dtpDueDate
        ' 
        dtpDueDate.Location = New Point(776, 127)
        dtpDueDate.Name = "dtpDueDate"
        dtpDueDate.Size = New Size(300, 31)
        dtpDueDate.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(403, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(426, 45)
        Label5.TabIndex = 7
        Label5.Text = "FINE CALCULATION"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Pink
        Button1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(239, 244)
        Button1.Name = "Button1"
        Button1.Size = New Size(271, 64)
        Button1.TabIndex = 8
        Button1.Text = "CALCULATE FINE"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlLight
        Label4.Location = New Point(581, 263)
        Label4.Name = "Label4"
        Label4.Size = New Size(150, 26)
        Label4.TabIndex = 11
        Label4.Text = "PaymentDate"
        ' 
        ' dtpPaymentDate
        ' 
        dtpPaymentDate.Location = New Point(751, 259)
        dtpPaymentDate.Name = "dtpPaymentDate"
        dtpPaymentDate.Size = New Size(300, 31)
        dtpPaymentDate.TabIndex = 12
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.LightPink
        Button3.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(794, 413)
        Button3.Name = "Button3"
        Button3.Size = New Size(170, 59)
        Button3.TabIndex = 13
        Button3.Text = "REFRESH"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' lblFineAmount
        ' 
        lblFineAmount.AutoSize = True
        lblFineAmount.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFineAmount.ForeColor = SystemColors.ControlLightLight
        lblFineAmount.Location = New Point(73, 263)
        lblFineAmount.Name = "lblFineAmount"
        lblFineAmount.Size = New Size(145, 26)
        lblFineAmount.TabIndex = 14
        lblFineAmount.Text = "Fine Amount"
        ' 
        ' FineForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Crimson
        ClientSize = New Size(1210, 533)
        Controls.Add(lblFineAmount)
        Controls.Add(Button3)
        Controls.Add(dtpPaymentDate)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(dtpDueDate)
        Controls.Add(Label3)
        Controls.Add(dtpBorrowedDate)
        Controls.Add(Label2)
        Name = "FineForm"
        Text = "FineForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpBorrowedDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDueDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpPaymentDate As DateTimePicker
    Friend WithEvents Button3 As Button
    Friend WithEvents lblFineAmount As Label
End Class
