Imports UserClassLibrary
Public Class AddBook
    Dim pdfAddress As String
    Dim logoAddress As String
    Dim book As Book
    Dim pdfButtonTitle As String
    Dim coverButtonTitle As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "PDF Documents|*.pdf"
        Dim response = OpenFileDialog1.ShowDialog()
        If (response <> DialogResult.Cancel) Then
            pdfAddress = OpenFileDialog1.FileName
            Button1.Image = My.Resources.pdf_logo
            pdfButtonTitle = Button1.Text
            Button1.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.png"
        Dim response = OpenFileDialog1.ShowDialog()
        If (response <> DialogResult.Cancel) Then
            logoAddress = OpenFileDialog1.FileName
            Button2.BackgroundImage = Image.FromFile(logoAddress)
            coverButtonTitle = Button2.Text
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
        ProgressBar1.Visible = True
        Label1.Visible = True
        Label1.Text = "Uploading book info..."
        Threading.Thread.Sleep(700)
        book.uploadInfo()
        ProgressBar1.Value = 33
        Label1.Text = "Uploading Cover..."
        Threading.Thread.Sleep(700)
        book.uploadCover(logoAddress)
        ProgressBar1.Value = 66
        Label1.Text = "Uploading PDF..."
        Threading.Thread.Sleep(700)
        book.uploadPdf(pdfAddress)
        ProgressBar1.Value = 100
        Threading.Thread.Sleep(700)
        ProgressBar1.Visible = False
        Label1.Visible = False
        MsgBox("Book uploaded successfully.")
        clearFields()
    End Sub

    Private Function checkFields() As Boolean
        'TODO: implement this function
        Return True
    End Function

    Private Sub clearFields()
        MaterialSingleLineTextField1.Text = ""
        ComboBox1.Text = ""
        MaterialSingleLineTextField2.Text = ""
        MaterialSingleLineTextField3.Text = ""
        MaterialSingleLineTextField5.Text = ""
        MaterialSingleLineTextField6.Text = ""
        TextBox1.Text = ""
        Button1.Text = pdfButtonTitle
        Button2.Text = coverButtonTitle
        Button1.Image = Nothing
        Button2.BackgroundImage = Nothing
        Button1.Text = pdfButtonTitle
        Button2.Text = coverButtonTitle
    End Sub
    Private Sub uploadInfo()


    End Sub

    Private Sub AddBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
