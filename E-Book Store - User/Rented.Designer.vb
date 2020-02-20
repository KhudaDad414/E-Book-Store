<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rented
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
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.MyWishListContainer = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel7
        '
        Me.Panel7.AutoScroll = True
        Me.Panel7.Controls.Add(Me.MyWishListContainer)
        Me.Panel7.Controls.Add(Me.Label13)
        Me.Panel7.Location = New System.Drawing.Point(1, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(814, 530)
        Me.Panel7.TabIndex = 10
        '
        'MyWishListContainer
        '
        Me.MyWishListContainer.AutoScroll = True
        Me.MyWishListContainer.Location = New System.Drawing.Point(12, 43)
        Me.MyWishListContainer.Name = "MyWishListContainer"
        Me.MyWishListContainer.Size = New System.Drawing.Size(791, 445)
        Me.MyWishListContainer.TabIndex = 6
        Me.MyWishListContainer.WrapContents = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(5, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(148, 25)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Rented Books"
        '
        'Rented
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel7)
        Me.Name = "Rented"
        Me.Size = New System.Drawing.Size(817, 535)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel7 As Panel
    Friend WithEvents MyWishListContainer As FlowLayoutPanel
    Private WithEvents Label13 As Label
End Class
