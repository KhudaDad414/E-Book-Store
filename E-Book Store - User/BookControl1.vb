Imports System.Data.SqlClient
Imports UserClassLibrary
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
        If bookName.Length > 28 Then
            Label1.Text = bookName.Substring(0, 28) + "..."
        Else
            Label1.Text = bookName
        End If
        Label2.Text = desc
        Label3.Text = price & " ₹"
        loadImage()
    End Sub
    Private Sub loadImage()
        Dim connection As New SqlConnection(Constants.UserConnectionString)
        Dim reader As SqlDataReader
        connection.Open()
        Dim command As New SqlCommand("User.getBookCover", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.Add(New SqlParameter("@id", id))
        Try

            Dim ImgStream As New IO.MemoryStream(CType(command.ExecuteScalar, Byte()))

            PictureBox13.Image = Image.FromStream(ImgStream)

            ImgStream.Dispose()

            connection.Close()
        Catch e As Exception
            MsgBox(e.ToString())
        End Try


    End Sub

    Private Sub Me_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox13.MouseEnter

        Me.BackColor = Color.White
    End Sub

    Private Sub Me_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox13.MouseLeave

        Me.BackColor = Color.FromArgb(224, 224, 224)

    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Globals.bookDetails.showDetails(id)
        Globals.bookDetails.BringToFront()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
