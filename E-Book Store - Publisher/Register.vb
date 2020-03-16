Imports System.Text.RegularExpressions
Imports UserClassLibrary
Public Class Register



    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        Dim customer As New Publisher(MaterialTextField1.Text, MaterialTextField3.Text, MaterialTextField4.Text, MaterialTextField10.Text, MaterialTextField5.Text, Val(MaterialTextField6.Text), MaterialTextField7.Text)
        If ValidateFields() Then
            customer.uploadInfo()
            Login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)
        MaterialTextField1.Hint = "Company Name"
        MaterialTextField3.Hint = "Mobile Number"
        MaterialTextField4.Hint = "Email"
        MaterialTextField10.Hint = "Password"
        MaterialTextField11.Hint = "Confirm Password"
        MaterialTextField5.Hint = "Address"
        MaterialTextField6.Hint = "Pin Code"
        MaterialTextField7.Hint = "Account Number"



    End Sub

    Private Function ValidateFields() As Boolean

        If (MaterialTextField1.Text.Equals("") Or MaterialTextField3.Text.Equals("") Or MaterialTextField4.Text.Equals("") Or MaterialTextField10.Text.Equals("") Or MaterialTextField11.Text.Equals("") Or MaterialTextField5.Text.Equals("") Or MaterialTextField6.Text.Equals("") Or MaterialTextField7.Text.Equals("")) Then
            MsgBox("All fields are mandatory.")
            Return False
        End If

        Dim regex As Regex = New Regex("^([\w-]+(?:\.[\w-]+)*)@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$")
        Dim match As Match = regex.Match(MaterialTextField4.Text)
        If Not match.Success Then
            MsgBox("Your email is not valid.")
            Return False
        End If

        If Not MaterialTextField10.Text.Equals(MaterialTextField11.Text) Then
            MsgBox("Your passwords doesn't match.")
            Return False
        End If

        regex = New Regex("^((?=\S*?[A-Z])(?=\S*?[a-z])(?=\S*?[0-9]).{6,})\S$")
        match = regex.Match(MaterialTextField10.Text)
        If Not match.Success Then
            MsgBox("your password should contains a minimum of 7 characters, at least 1 uppercase letter, 1 lowercase letter, and 1 number with no spaces.")
            Return False
        End If


        Return True


    End Function

    Private Sub Register_Paint(sender As Object, g As PaintEventArgs) Handles Me.Paint
        Dim r As New Rectangle(364.75, 20, 296.5, 504)
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

    Public Shared Sub CenterForm(ByRef frm As Form)
        Dim r As Rectangle

        r = Screen.FromPoint(frm.Location).WorkingArea


        Dim x = r.Left + (r.Width - frm.Width) \ 2
        Dim y = r.Top + (r.Height - frm.Height) \ 2
        frm.Location = New Point(x, y)
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Login.Show()
        Me.Hide()
    End Sub
End Class