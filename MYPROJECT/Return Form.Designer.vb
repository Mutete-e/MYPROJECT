<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnForm
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
        dgvBorrowed = New DataGridView()
        btnReturn = New Button()
        btnClose = New Button()
        Label2 = New Label()
        dtpReturnDate = New DateTimePicker()
        Label1 = New Label()
        CType(dgvBorrowed, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvBorrowed
        ' 
        dgvBorrowed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBorrowed.BackgroundColor = Color.RosyBrown
        dgvBorrowed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBorrowed.Location = New Point(63, 99)
        dgvBorrowed.Name = "dgvBorrowed"
        dgvBorrowed.RowHeadersWidth = 62
        dgvBorrowed.Size = New Size(1002, 319)
        dgvBorrowed.TabIndex = 6
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(543, 551)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(112, 34)
        btnReturn.TabIndex = 7
        btnReturn.Text = "RETURN"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(846, 551)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(112, 34)
        btnClose.TabIndex = 9
        btnClose.Text = "CLOSE"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(63, 475)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 26)
        Label2.TabIndex = 11
        Label2.Text = "Return Date"
        ' 
        ' dtpReturnDate
        ' 
        dtpReturnDate.Location = New Point(222, 475)
        dtpReturnDate.Name = "dtpReturnDate"
        dtpReturnDate.Size = New Size(300, 31)
        dtpReturnDate.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(344, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(409, 41)
        Label1.TabIndex = 13
        Label1.Text = "RETURN BOOK FORM"
        ' 
        ' ReturnForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkRed
        ClientSize = New Size(1220, 644)
        Controls.Add(Label1)
        Controls.Add(dtpReturnDate)
        Controls.Add(Label2)
        Controls.Add(btnClose)
        Controls.Add(btnReturn)
        Controls.Add(dgvBorrowed)
        Name = "ReturnForm"
        Text = "Return Form"
        CType(dgvBorrowed, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents dgvBorrowed As DataGridView
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpReturnDate As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
