Public Class BookControl1
    Public Property bookName As String
    Public Property desc As String
    Public Property price As String
    Public Property id As Integer

    Public Sub New(name As String, desc As String, price As String, id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.bookName = name
        Me.desc = desc
        Me.price = price
        Me.id = id

    End Sub
    Private Sub BookControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = bookName
        Label2.Text = desc
        Label3.Text = price
    End Sub
End Class
