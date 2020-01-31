<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Downloads
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Downloads))
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.Panel14.SuspendLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoScroll = True
        Me.FlowLayoutPanel3.Controls.Add(Me.Panel14)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 3)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(817, 529)
        Me.FlowLayoutPanel3.TabIndex = 13
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel14.Controls.Add(Me.PictureBox13)
        Me.Panel14.Controls.Add(Me.Label51)
        Me.Panel14.Controls.Add(Me.Label52)
        Me.Panel14.Controls.Add(Me.Label54)
        Me.Panel14.Location = New System.Drawing.Point(3, 3)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(193, 248)
        Me.Panel14.TabIndex = 3
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(0, 48)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(188, 144)
        Me.PictureBox13.TabIndex = 1
        Me.PictureBox13.TabStop = False
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(3, 224)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(188, 17)
        Me.Label51.TabIndex = 1
        Me.Label51.Text = "which is used as a placeholder"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(9, 204)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(177, 17)
        Me.Label52.TabIndex = 1
        Me.Label52.Text = "Lorem ispum is a dummy text"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(8, 15)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(78, 25)
        Me.Label54.TabIndex = 1
        Me.Label54.Text = "Burger"
        '
        'Downloads
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Name = "Downloads"
        Me.Size = New System.Drawing.Size(817, 535)
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Private WithEvents Panel14 As Panel
    Private WithEvents PictureBox13 As PictureBox
    Private WithEvents Label51 As Label
    Private WithEvents Label52 As Label
    Private WithEvents Label54 As Label
End Class
