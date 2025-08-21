<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Book_Registration
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
        txtTitle = New TextBox()
        Label2 = New Label()
        txtAuthor = New TextBox()
        Label3 = New Label()
        txtISBN = New TextBox()
        Label4 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        cmbGenre = New ComboBox()
        Label5 = New Label()
        txtreg = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaptionText
        Label1.Font = New Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(28, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(155, 51)
        Label1.TabIndex = 0
        Label1.Text = "TITLE"
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(254, 48)
        txtTitle.Multiline = True
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(239, 63)
        txtTitle.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaptionText
        Label2.Font = New Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(537, 182)
        Label2.Name = "Label2"
        Label2.Size = New Size(215, 51)
        Label2.TabIndex = 2
        Label2.Text = "AUTHOR"
        ' 
        ' txtAuthor
        ' 
        txtAuthor.Location = New Point(820, 182)
        txtAuthor.Multiline = True
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(257, 51)
        txtAuthor.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ActiveCaptionText
        Label3.Font = New Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(28, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 51)
        Label3.TabIndex = 4
        Label3.Text = "ISBN"
        ' 
        ' txtISBN
        ' 
        txtISBN.Location = New Point(254, 182)
        txtISBN.Multiline = True
        txtISBN.Name = "txtISBN"
        txtISBN.Size = New Size(180, 51)
        txtISBN.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ActiveCaptionText
        Label4.Font = New Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(537, 60)
        Label4.Name = "Label4"
        Label4.Size = New Size(178, 51)
        Label4.TabIndex = 6
        Label4.Text = "GENRE"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.RoyalBlue
        Button1.Font = New Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(293, 394)
        Button1.Name = "Button1"
        Button1.Size = New Size(279, 92)
        Button1.TabIndex = 12
        Button1.Text = "REGISTER"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.RoyalBlue
        Button2.Font = New Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(776, 391)
        Button2.Name = "Button2"
        Button2.Size = New Size(196, 95)
        Button2.TabIndex = 13
        Button2.Text = "EXIT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' cmbGenre
        ' 
        cmbGenre.FormattingEnabled = True
        cmbGenre.Items.AddRange(New Object() {"Personal Development", "Thriller", " Romance", "Fantasy", "Historical Fiction", "Primary", "Highschool"})
        cmbGenre.Location = New Point(820, 66)
        cmbGenre.Name = "cmbGenre"
        cmbGenre.Size = New Size(215, 33)
        cmbGenre.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ActiveCaptionText
        Label5.Font = New Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(28, 297)
        Label5.Name = "Label5"
        Label5.Size = New Size(183, 51)
        Label5.TabIndex = 15
        Label5.Text = "REGNO"
        ' 
        ' txtreg
        ' 
        txtreg.Location = New Point(254, 296)
        txtreg.Multiline = True
        txtreg.Name = "txtreg"
        txtreg.Size = New Size(189, 52)
        txtreg.TabIndex = 16
        ' 
        ' Book_Registration
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.books_registration
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1173, 572)
        Controls.Add(txtreg)
        Controls.Add(Label5)
        Controls.Add(cmbGenre)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(txtISBN)
        Controls.Add(Label3)
        Controls.Add(txtAuthor)
        Controls.Add(Label2)
        Controls.Add(txtTitle)
        Controls.Add(Label1)
        Name = "Book_Registration"
        Text = "Book Registration"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cmbGenre As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtreg As TextBox
End Class
