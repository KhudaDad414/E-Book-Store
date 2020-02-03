Imports UserClassLibrary
Public Class AddBook
    Dim pdfAddress As String
    Dim logoAddress As String
    Dim book As Book

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "PDF Documents|*.pdf"
        Dim response = OpenFileDialog1.ShowDialog()
        If (response <> DialogResult.Cancel) Then
            pdfAddress = OpenFileDialog1.FileName
            Button1.Image = My.Resources.pdf_logo
            Button1.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.png"
        Dim response = OpenFileDialog1.ShowDialog()
        If (response <> DialogResult.Cancel) Then
            logoAddress = OpenFileDialog1.FileName
            Button2.BackgroundImage = Image.FromFile(logoAddress)
            Button2.Text = ""

        End If
    End Sub



    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        If (TextBox1.Text = "Description") Then
            TextBox1.Text = ""
        End If

    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click

        If checkFields() = False Then
            Exit Sub
        End If

        book = New Book(MaterialSingleLineTextField1.Text, ComboBox1.Text, MaterialSingleLineTextField2.Text, Val(MaterialSingleLineTextField3.Text), MaterialSingleLineTextField5.Text, Val(MaterialSingleLineTextField6.Text), Globals.CurrentUser.ID, TextBox1.Text)

        book.uploadInfo()
        book.uploadCover(logoAddress)
        book.uploadPdf(pdfAddress)
    End Sub

    Private Function checkFields() As Boolean
        'TODO: implement this function
        Return True
    End Function
    Private Sub uploadInfo()


    End Sub

    Private Sub AddBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
