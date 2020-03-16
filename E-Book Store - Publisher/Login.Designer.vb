<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MaterialTextField1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialTextField2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(395, 358)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Don't have an account?     "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(572, 358)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Sign Up"
        '
        'MaterialTextField1
        '
        Me.MaterialTextField1.BackColor = System.Drawing.Color.White
        Me.MaterialTextField1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextField1.Depth = 0
        Me.MaterialTextField1.Hint = ""
        Me.MaterialTextField1.Location = New System.Drawing.Point(396, 198)
        Me.MaterialTextField1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTextField1.Name = "MaterialTextField1"
        Me.MaterialTextField1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextField1.SelectedText = ""
        Me.MaterialTextField1.SelectionLength = 0
        Me.MaterialTextField1.SelectionStart = 0
        Me.MaterialTextField1.Size = New System.Drawing.Size(233, 23)
        Me.MaterialTextField1.TabIndex = 7
        Me.MaterialTextField1.UseSystemPasswordChar = False
        '
        'MaterialTextField2
        '
        Me.MaterialTextField2.BackColor = System.Drawing.Color.White
        Me.MaterialTextField2.Depth = 0
        Me.MaterialTextField2.Hint = ""
        Me.MaterialTextField2.Location = New System.Drawing.Point(396, 229)
        Me.MaterialTextField2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTextField2.Name = "MaterialTextField2"
        Me.MaterialTextField2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.MaterialTextField2.SelectedText = ""
        Me.MaterialTextField2.SelectionLength = 0
        Me.MaterialTextField2.SelectionStart = 0
        Me.MaterialTextField2.Size = New System.Drawing.Size(233, 23)
        Me.MaterialTextField2.TabIndex = 8
        Me.MaterialTextField2.UseSystemPasswordChar = False
        '
        'MaterialButton1
        '
        Me.MaterialButton1.AutoSize = True
        Me.MaterialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton1.Depth = 0
        Me.MaterialButton1.Location = New System.Drawing.Point(395, 260)
        Me.MaterialButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton1.Name = "MaterialButton1"
        Me.MaterialButton1.Primary = False
        Me.MaterialButton1.Size = New System.Drawing.Size(234, 36)
        Me.MaterialButton1.TabIndex = 9
        Me.MaterialButton1.Text = "⠀⠀⠀⠀⠀⠀⠀⠀ ⠀⠀Login⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀"
        Me.MaterialButton1.UseVisualStyleBackColor = True
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(394, 304)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(236, 36)
        Me.MaterialFlatButton1.TabIndex = 10
        Me.MaterialFlatButton1.Text = "⠀  ⠀  ⠀⠀⠀⠀⠀⠀ ⠀⠀Exit⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(866, 558)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "@Publishers Edition"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.E_Book_Store___User.My.Resources.Resources.red_black_maroon_18147965271
        Me.ClientSize = New System.Drawing.Size(1026, 583)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MaterialFlatButton1)
        Me.Controls.Add(Me.MaterialButton1)
        Me.Controls.Add(Me.MaterialTextField2)
        Me.Controls.Add(Me.MaterialTextField1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MaterialTextField1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialTextField2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Label1 As Label
End Class
