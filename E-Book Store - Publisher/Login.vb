Imports UserClassLibrary

Public Class Login
    Dim email As String
    Dim password As String

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        email = MaterialTextField1.Text
        password = MaterialTextField2.Text

        Dim publisher As New Publisher(email, password)
        Dim isLoggedIn = publisher.Login()
        If isLoggedIn Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        Label4.ForeColor = Color.Blue
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.ForeColor = Color.Black
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)
        MaterialTextField2.Hint = "Password"
        MaterialTextField1.Hint = "Email ID"


    End Sub

    Private Sub Login_Paint(sender As Object, g As PaintEventArgs) Handles Me.Paint
        Dim r As New Rectangle(384.75, 145.75, 256.5, 291.5)
        Dim d = 50
        Dim b As Brush = Brushes.White


        g.Graphics.FillPie(b, r.X, r.Y, d, d, 180, 90)
        g.Graphics.FillPie(b, r.X + r.Width - d, r.Y, d, d, 270, 90)
        g.Graphics.FillPie(b, r.X, r.Y + r.Height - d, d, d, 90, 90)
        g.Graphics.FillPie(b, r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90)
        g.Graphics.FillRectangle(b, CInt(r.X + d / 2), r.Y, r.Width - d, CInt(d / 2))
        g.Graphics.FillRectangle(b, r.X, CInt(r.Y + d / 2), r.Width, CInt(r.Height - d))
        g.Graphics.FillRectangle(b, CInt(r.X + d / 2), CInt(r.Y + r.Height - d / 2), CInt(r.Width - d), CInt(d / 2))
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        End
    End Sub

    Public Shared Sub CenterForm(ByRef frm As Form)
        Dim r As Rectangle

        r = Screen.FromPoint(frm.Location).WorkingArea


        Dim x = r.Left + (r.Width - frm.Width) \ 2
        Dim y = r.Top + (r.Height - frm.Height) \ 2
        frm.Location = New Point(x, y)
    End Sub
End Class