<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchControl
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
        Me.MyWishListContainer = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'MyWishListContainer
        '
        Me.MyWishListContainer.AutoScroll = True
        Me.MyWishListContainer.Location = New System.Drawing.Point(1, 1)
        Me.MyWishListContainer.Name = "MyWishListContainer"
        Me.MyWishListContainer.Size = New System.Drawing.Size(813, 531)
        Me.MyWishListContainer.TabIndex = 7
        Me.MyWishListContainer.WrapContents = False
        '
        'SearchControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MyWishListContainer)
        Me.Name = "SearchControl"
        Me.Size = New System.Drawing.Size(817, 535)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MyWishListContainer As FlowLayoutPanel
End Class
