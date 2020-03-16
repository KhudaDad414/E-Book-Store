<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.button14 = New System.Windows.Forms.Button()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.button7 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.button13 = New System.Windows.Forms.Button()
        Me.Wish2 = New E_Book_Store___User.Wish()
        Me.UserInfo1 = New E_Book_Store___User.UserInfo()
        Me.BookDetails2 = New E_Book_Store___User.BookDetails()
        Me.Bought2 = New E_Book_Store___User.Bought()
        Me.Browse2 = New E_Book_Store___User.Browse()
        Me.Downloads2 = New E_Book_Store___User.Downloads()
        Me.Rented2 = New E_Book_Store___User.Rented()
        Me.SearchControl1 = New E_Book_Store___User.SearchControl()
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
        'button7
        '
        Me.button7.FlatAppearance.BorderSize = 0
        Me.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button7.ForeColor = System.Drawing.Color.White
        Me.button7.Image = CType(resources.GetObject("button7.Image"), System.Drawing.Image)
        Me.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button7.Location = New System.Drawing.Point(12, 335)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(197, 54)
        Me.button7.TabIndex = 4
        Me.button7.Text = "       User"
        Me.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button7.UseVisualStyleBackColor = True
        '
        'button5
        '
        Me.button5.FlatAppearance.BorderSize = 0
        Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button5.ForeColor = System.Drawing.Color.White
        Me.button5.Image = Global.E_Book_Store___User.My.Resources.Resources.Download_2_512
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
        Me.button4.Image = Global.E_Book_Store___User.My.Resources.Resources.boughtbooks
        Me.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button4.Location = New System.Drawing.Point(12, 221)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(197, 54)
        Me.button4.TabIndex = 4
        Me.button4.Text = "       Owned Books"
        Me.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button4.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.FlatAppearance.BorderSize = 0
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.ForeColor = System.Drawing.Color.White
        Me.button3.Image = Global.E_Book_Store___User.My.Resources.Resources.rent
        Me.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button3.Location = New System.Drawing.Point(12, 167)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(197, 54)
        Me.button3.TabIndex = 4
        Me.button3.Text = "       Rented Books"
        Me.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.FlatAppearance.BorderSize = 0
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.Color.White
        Me.button2.Image = Global.E_Book_Store___User.My.Resources.Resources.wishlist
        Me.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button2.Location = New System.Drawing.Point(12, 113)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(197, 54)
        Me.button2.TabIndex = 4
        Me.button2.Text = "       Wish List"
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
        Me.button1.Text = "       Browse"
        Me.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(233, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 27)
        Me.TextBox1.TabIndex = 17
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
        'Wish2
        '
        Me.Wish2.Location = New System.Drawing.Point(209, 46)
        Me.Wish2.Name = "Wish2"
        Me.Wish2.Size = New System.Drawing.Size(817, 535)
        Me.Wish2.TabIndex = 11
        '
        'UserInfo1
        '
        Me.UserInfo1.Location = New System.Drawing.Point(209, 49)
        Me.UserInfo1.Name = "UserInfo1"
        Me.UserInfo1.Size = New System.Drawing.Size(817, 535)
        Me.UserInfo1.TabIndex = 10
        '
        'BookDetails2
        '
        Me.BookDetails2.Location = New System.Drawing.Point(209, 48)
        Me.BookDetails2.Name = "BookDetails2"
        Me.BookDetails2.Size = New System.Drawing.Size(817, 535)
        Me.BookDetails2.TabIndex = 16
        '
        'Bought2
        '
        Me.Bought2.Location = New System.Drawing.Point(209, 48)
        Me.Bought2.Name = "Bought2"
        Me.Bought2.Size = New System.Drawing.Size(814, 530)
        Me.Bought2.TabIndex = 15
        '
        'Browse2
        '
        Me.Browse2.Location = New System.Drawing.Point(209, 48)
        Me.Browse2.Name = "Browse2"
        Me.Browse2.Size = New System.Drawing.Size(817, 535)
        Me.Browse2.TabIndex = 14
        '
        'Downloads2
        '
        Me.Downloads2.Location = New System.Drawing.Point(209, 46)
        Me.Downloads2.Name = "Downloads2"
        Me.Downloads2.Size = New System.Drawing.Size(817, 535)
        Me.Downloads2.TabIndex = 13
        '
        'Rented2
        '
        Me.Rented2.Location = New System.Drawing.Point(209, 46)
        Me.Rented2.Name = "Rented2"
        Me.Rented2.Size = New System.Drawing.Size(817, 535)
        Me.Rented2.TabIndex = 12
        '
        'SearchControl1
        '
        Me.SearchControl1.Location = New System.Drawing.Point(209, 49)
        Me.SearchControl1.Name = "SearchControl1"
        Me.SearchControl1.Size = New System.Drawing.Size(817, 535)
        Me.SearchControl1.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 583)
        Me.Controls.Add(Me.SearchControl1)
        Me.Controls.Add(Me.Wish2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.UserInfo1)
        Me.Controls.Add(Me.BookDetails2)
        Me.Controls.Add(Me.Bought2)
        Me.Controls.Add(Me.Browse2)
        Me.Controls.Add(Me.Downloads2)
        Me.Controls.Add(Me.Rented2)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.button13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Private WithEvents button3 As Button
    Private WithEvents button13 As Button
    Friend WithEvents Browse1 As Browse
    Friend WithEvents Wish1 As Wish
    Friend WithEvents Rented1 As Rented
    Friend WithEvents Downloads1 As Downloads
    Friend WithEvents BookDetails1 As BookDetails
    Friend WithEvents Bought1 As Bought
    Friend WithEvents UserInfo1 As UserInfo
    Friend WithEvents Wish2 As Wish
    Friend WithEvents Rented2 As Rented
    Friend WithEvents Downloads2 As Downloads
    Friend WithEvents Browse2 As Browse
    Friend WithEvents Bought2 As Bought
    Friend WithEvents BookDetails2 As BookDetails
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SearchControl1 As SearchControl
End Class
