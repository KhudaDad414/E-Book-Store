<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBook
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MaterialSingleLineTextField6 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialSingleLineTextField5 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MaterialSingleLineTextField3 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialSingleLineTextField2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialSingleLineTextField1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 365)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(784, 152)
        Me.TextBox1.TabIndex = 26
        Me.TextBox1.Text = "Description"
        '
        'MaterialSingleLineTextField6
        '
        Me.MaterialSingleLineTextField6.Depth = 0
        Me.MaterialSingleLineTextField6.Hint = "Pages"
        Me.MaterialSingleLineTextField6.Location = New System.Drawing.Point(592, 193)
        Me.MaterialSingleLineTextField6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField6.Name = "MaterialSingleLineTextField6"
        Me.MaterialSingleLineTextField6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField6.SelectedText = ""
        Me.MaterialSingleLineTextField6.SelectionLength = 0
        Me.MaterialSingleLineTextField6.SelectionStart = 0
        Me.MaterialSingleLineTextField6.Size = New System.Drawing.Size(209, 23)
        Me.MaterialSingleLineTextField6.TabIndex = 25
        Me.MaterialSingleLineTextField6.UseSystemPasswordChar = False
        '
        'MaterialSingleLineTextField5
        '
        Me.MaterialSingleLineTextField5.Depth = 0
        Me.MaterialSingleLineTextField5.Hint = "Publish Year"
        Me.MaterialSingleLineTextField5.Location = New System.Drawing.Point(592, 154)
        Me.MaterialSingleLineTextField5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField5.Name = "MaterialSingleLineTextField5"
        Me.MaterialSingleLineTextField5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField5.SelectedText = ""
        Me.MaterialSingleLineTextField5.SelectionLength = 0
        Me.MaterialSingleLineTextField5.SelectionStart = 0
        Me.MaterialSingleLineTextField5.Size = New System.Drawing.Size(209, 23)
        Me.MaterialSingleLineTextField5.TabIndex = 24
        Me.MaterialSingleLineTextField5.UseSystemPasswordChar = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.Control
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Children's", "Teen and Young Adult", "Self-Help", "Literature & Fiction", "Mystery & Thriller", "Sci-fi & Fantasy", "Romance"})
        Me.ComboBox1.Location = New System.Drawing.Point(592, 232)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(209, 21)
        Me.ComboBox1.TabIndex = 23
        '
        'MaterialSingleLineTextField3
        '
        Me.MaterialSingleLineTextField3.Depth = 0
        Me.MaterialSingleLineTextField3.Hint = "Price"
        Me.MaterialSingleLineTextField3.Location = New System.Drawing.Point(592, 115)
        Me.MaterialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField3.Name = "MaterialSingleLineTextField3"
        Me.MaterialSingleLineTextField3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField3.SelectedText = ""
        Me.MaterialSingleLineTextField3.SelectionLength = 0
        Me.MaterialSingleLineTextField3.SelectionStart = 0
        Me.MaterialSingleLineTextField3.Size = New System.Drawing.Size(209, 23)
        Me.MaterialSingleLineTextField3.TabIndex = 22
        Me.MaterialSingleLineTextField3.UseSystemPasswordChar = False
        '
        'MaterialSingleLineTextField2
        '
        Me.MaterialSingleLineTextField2.Depth = 0
        Me.MaterialSingleLineTextField2.Hint = "Author Name"
        Me.MaterialSingleLineTextField2.Location = New System.Drawing.Point(592, 76)
        Me.MaterialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField2.Name = "MaterialSingleLineTextField2"
        Me.MaterialSingleLineTextField2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField2.SelectedText = ""
        Me.MaterialSingleLineTextField2.SelectionLength = 0
        Me.MaterialSingleLineTextField2.SelectionStart = 0
        Me.MaterialSingleLineTextField2.Size = New System.Drawing.Size(209, 23)
        Me.MaterialSingleLineTextField2.TabIndex = 21
        Me.MaterialSingleLineTextField2.UseSystemPasswordChar = False
        '
        'MaterialSingleLineTextField1
        '
        Me.MaterialSingleLineTextField1.Depth = 0
        Me.MaterialSingleLineTextField1.Hint = "Book Name"
        Me.MaterialSingleLineTextField1.Location = New System.Drawing.Point(590, 37)
        Me.MaterialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField1.Name = "MaterialSingleLineTextField1"
        Me.MaterialSingleLineTextField1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField1.SelectedText = ""
        Me.MaterialSingleLineTextField1.SelectionLength = 0
        Me.MaterialSingleLineTextField1.SelectionStart = 0
        Me.MaterialSingleLineTextField1.Size = New System.Drawing.Size(209, 23)
        Me.MaterialSingleLineTextField1.TabIndex = 20
        Me.MaterialSingleLineTextField1.UseSystemPasswordChar = False
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(592, 269)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(207, 36)
        Me.MaterialFlatButton1.TabIndex = 29
        Me.MaterialFlatButton1.Text = "⠀⠀⠀⠀⠀⠀⠀⠀Upload⠀⠀⠀⠀⠀⠀⠀⠀"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 280)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "SELECT PDF"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(303, 37)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 280)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "SELECT A LOGO (200X280 PX)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 336)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(783, 23)
        Me.ProgressBar1.TabIndex = 32
        Me.ProgressBar1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(384, 320)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'AddBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MaterialFlatButton1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MaterialSingleLineTextField6)
        Me.Controls.Add(Me.MaterialSingleLineTextField5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.MaterialSingleLineTextField3)
        Me.Controls.Add(Me.MaterialSingleLineTextField2)
        Me.Controls.Add(Me.MaterialSingleLineTextField1)
        Me.Name = "AddBook"
        Me.Size = New System.Drawing.Size(817, 535)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MaterialSingleLineTextField6 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialSingleLineTextField5 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MaterialSingleLineTextField3 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialSingleLineTextField2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialSingleLineTextField1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
End Class
