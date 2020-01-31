<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.button14 = New System.Windows.Forms.Button()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.button7 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button13 = New System.Windows.Forms.Button()
        Me.button12 = New System.Windows.Forms.Button()
        Me.button11 = New System.Windows.Forms.Button()
        Me.AddBook1 = New E_Book_Store___User.AddBook()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'button14
        '
        Me.button14.FlatAppearance.BorderSize = 0
        Me.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button14.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button14.ForeColor = System.Drawing.Color.White
        Me.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button14.Location = New System.Drawing.Point(3, 546)
        Me.button14.Name = "button14"
        Me.button14.Size = New System.Drawing.Size(36, 34)
        Me.button14.TabIndex = 4
        Me.button14.Text = "?"
        Me.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button14.UseVisualStyleBackColor = True
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel2.Location = New System.Drawing.Point(209, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(817, 10)
        Me.panel2.TabIndex = 6
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.panel1.Controls.Add(Me.SidePanel)
        Me.panel1.Controls.Add(Me.button7)
        Me.panel1.Controls.Add(Me.button6)
        Me.panel1.Controls.Add(Me.button5)
        Me.panel1.Controls.Add(Me.button4)
        Me.panel1.Controls.Add(Me.button3)
        Me.panel1.Controls.Add(Me.button14)
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(209, 583)
        Me.panel1.TabIndex = 5
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.SidePanel.Location = New System.Drawing.Point(1, 61)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(10, 54)
        Me.SidePanel.TabIndex = 4
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'button7
        '
        Me.button7.FlatAppearance.BorderSize = 0
        Me.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button7.ForeColor = System.Drawing.Color.White
        Me.button7.Image = CType(resources.GetObject("button7.Image"), System.Drawing.Image)
        Me.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button7.Location = New System.Drawing.Point(12, 383)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(197, 54)
        Me.button7.TabIndex = 4
        Me.button7.Text = "       User"
        Me.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button7.UseVisualStyleBackColor = True
        '
        'button6
        '
        Me.button6.FlatAppearance.BorderSize = 0
        Me.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button6.ForeColor = System.Drawing.Color.White
        Me.button6.Image = CType(resources.GetObject("button6.Image"), System.Drawing.Image)
        Me.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button6.Location = New System.Drawing.Point(12, 329)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(197, 54)
        Me.button6.TabIndex = 4
        Me.button6.Text = "       Favourite"
        Me.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button6.UseVisualStyleBackColor = True
        '
        'button5
        '
        Me.button5.FlatAppearance.BorderSize = 0
        Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button5.ForeColor = System.Drawing.Color.White
        Me.button5.Image = CType(resources.GetObject("button5.Image"), System.Drawing.Image)
        Me.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button5.Location = New System.Drawing.Point(12, 275)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(197, 54)
        Me.button5.TabIndex = 4
        Me.button5.Text = "       Downloads"
        Me.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button5.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.FlatAppearance.BorderSize = 0
        Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button4.ForeColor = System.Drawing.Color.White
        Me.button4.Image = CType(resources.GetObject("button4.Image"), System.Drawing.Image)
        Me.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button4.Location = New System.Drawing.Point(12, 221)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(197, 54)
        Me.button4.TabIndex = 4
        Me.button4.Text = "       Request Payment"
        Me.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button4.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.FlatAppearance.BorderSize = 0
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.ForeColor = System.Drawing.Color.White
        Me.button3.Image = CType(resources.GetObject("button3.Image"), System.Drawing.Image)
        Me.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button3.Location = New System.Drawing.Point(12, 167)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(197, 54)
        Me.button3.TabIndex = 4
        Me.button3.Text = "       Sales Summery"
        Me.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.FlatAppearance.BorderSize = 0
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.Color.White
        Me.button2.Image = CType(resources.GetObject("button2.Image"), System.Drawing.Image)
        Me.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button2.Location = New System.Drawing.Point(12, 113)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(197, 54)
        Me.button2.TabIndex = 4
        Me.button2.Text = "       My Books"
        Me.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.FlatAppearance.BorderSize = 0
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.White
        Me.button1.Image = CType(resources.GetObject("button1.Image"), System.Drawing.Image)
        Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button1.Location = New System.Drawing.Point(12, 59)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(197, 54)
        Me.button1.TabIndex = 4
        Me.button1.Text = "       Add Book"
        Me.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button1.UseVisualStyleBackColor = True
        '
        'button13
        '
        Me.button13.FlatAppearance.BorderSize = 0
        Me.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button13.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button13.ForeColor = System.Drawing.Color.White
        Me.button13.Image = CType(resources.GetObject("button13.Image"), System.Drawing.Image)
        Me.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button13.Location = New System.Drawing.Point(977, 19)
        Me.button13.Name = "button13"
        Me.button13.Size = New System.Drawing.Size(32, 35)
        Me.button13.TabIndex = 9
        Me.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button13.UseVisualStyleBackColor = True
        '
        'button12
        '
        Me.button12.FlatAppearance.BorderSize = 0
        Me.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button12.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button12.ForeColor = System.Drawing.Color.White
        Me.button12.Image = CType(resources.GetObject("button12.Image"), System.Drawing.Image)
        Me.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button12.Location = New System.Drawing.Point(928, 19)
        Me.button12.Name = "button12"
        Me.button12.Size = New System.Drawing.Size(32, 35)
        Me.button12.TabIndex = 10
        Me.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button12.UseVisualStyleBackColor = True
        '
        'button11
        '
        Me.button11.FlatAppearance.BorderSize = 0
        Me.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button11.ForeColor = System.Drawing.Color.White
        Me.button11.Image = CType(resources.GetObject("button11.Image"), System.Drawing.Image)
        Me.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button11.Location = New System.Drawing.Point(890, 19)
        Me.button11.Name = "button11"
        Me.button11.Size = New System.Drawing.Size(32, 35)
        Me.button11.TabIndex = 11
        Me.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button11.UseVisualStyleBackColor = True
        '
        'AddBook1
        '
        Me.AddBook1.Location = New System.Drawing.Point(209, 48)
        Me.AddBook1.Name = "AddBook1"
        Me.AddBook1.Size = New System.Drawing.Size(817, 535)
        Me.AddBook1.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 583)
        Me.Controls.Add(Me.AddBook1)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.button13)
        Me.Controls.Add(Me.button12)
        Me.Controls.Add(Me.button11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents button14 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents button5 As Button
    Private WithEvents button4 As Button
    Private WithEvents panel2 As Panel
    Private WithEvents panel1 As Panel
    Private WithEvents SidePanel As Panel
    Private WithEvents button7 As Button
    Private WithEvents button6 As Button
    Private WithEvents button3 As Button
    Private WithEvents button13 As Button
    Private WithEvents button12 As Button
    Private WithEvents button11 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents AddBook1 As AddBook
End Class
