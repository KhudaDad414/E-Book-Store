Imports System.Data.SqlClient
Imports UserClassLibrary
Imports System.Text.RegularExpressions

Public Class BookDetails
    Dim book As New Book()
    Dim rentOption = -1


    Public Sub showDetails(id As Integer)
        loadBook(id)
        If (book.Price = 0) Then
            MaterialRaisedButton2.Visible = False
            ComboBox1.Visible = False
        End If
        If book.isWished Then
            PictureBox2.Image = My.Resources.hearted
        Else
            PictureBox2.Image = My.Resources.un_hearted
        End If
        MaterialLabel1.Text = book.Name
        MaterialLabel2.Text = book.Author
        MaterialLabel3.Text = book.PublisherName
        MaterialLabel4.Text = book.Downloads
        MaterialRaisedButton1.Text = "BUY (" & book.Price & ".00 ₹)"
        MaterialLabel6.Text = book.Category
        MaterialLabel7.Text = book.avgRating
        MaterialLabel8.Text = book.Pages
        MaterialLabel9.Text = book.PublishDate
        MaterialLabel10.Text = book.Desc
        Dim ImgStream As New IO.MemoryStream(book.Cover)

        PictureBox1.Image = Image.FromStream(ImgStream)

        ImgStream.Dispose()
    End Sub
    Private Sub loadBook(ID As Integer)
        Dim connection As New SqlConnection(Constants.UserConnectionString)
        Dim reader As SqlDataReader

        connection.Open()
        Dim command As New SqlCommand("User.getBookById", connection)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.Add(New SqlParameter("@id", ID))
        command.Parameters.Add(New SqlParameter("@CustId", Globals.CurrentUser.ID))


        reader = command.ExecuteReader()

        If reader.Read Then
            book.ID = reader("ID")
            book.Name = reader("name")
            book.Author = reader("author")
            book.PublisherName = reader("publisher")
            book.Downloads = reader("downloads")
            book.Price = reader("price")
            book.Desc = reader("desc")
            book.Category = reader("category")
            book.PublishDate = reader("publishDate")
            book.Pages = reader("pages")
            book.Cover = reader("logo")
            book.avgRating = reader("avgRating")
            book.isWished = reader("isWished")

        Else
            MsgBox("Something went wrong.")

        End If

        connection.Close()

    End Sub

    Private Sub BookDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Globals.bookDetails = Me
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If book.isWished Then
            book.removeWished(Globals.CurrentUser.ID)
            book.isWished = False
            PictureBox2.Image = My.Resources.un_hearted

        Else
            book.addWished(Globals.CurrentUser.ID)
            PictureBox2.Image = My.Resources.hearted
            book.isWished = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        rentOption = ComboBox1.SelectedIndex
        If rentOption = 0 Then
            MaterialRaisedButton2.Text = "RENT FOR(" & FormatNumber((book.Price * 0.3), 2) & " ₹)"
        ElseIf rentOption = 1 Then
            MaterialRaisedButton2.Text = "RENT FOR(" & FormatNumber((book.Price * 0.4), 2) & " ₹)"
        Else
            MaterialRaisedButton2.Text = "RENT FOR(" & FormatNumber((book.Price * 0.5), 2) & " ₹)"
        End If
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        If rentOption <> -1 And paymentHandler() Then
            If rentOption = 0 Then
                book.rent(Globals.CurrentUser.ID, 0.3)
            ElseIf rentOption = 1 Then
                book.rent(Globals.CurrentUser.ID, 0.4)
            Else
                book.rent(Globals.CurrentUser.ID, 0.5)
            End If


        End If
    End Sub
    Private Function paymentHandler() As Boolean
        If (book.Price > 0) Then
            Dim a = InputBox("Enter your CVV")
            If (a.Length() <> 3 Or Not Regex.IsMatch(a, "^[0-9 ]+$")) Then
                MsgBox("CVV Should be 3 digits.")
                Return False
            End If
            PaymentScreen.ShowDialog()
        End If
        Return True
    End Function




    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click

        If paymentHandler() Then
            book.buy(Globals.CurrentUser.ID)
        End If
    End Sub


End Class
