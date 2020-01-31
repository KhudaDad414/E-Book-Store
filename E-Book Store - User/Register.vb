﻿Imports UserClassLibrary
Public Class Register
    Private Sub MaterialCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox1.CheckedChanged
        If MaterialCheckBox1.Checked Then


            MaterialTextField7.Enabled = False
            MaterialTextField8.Enabled = False
            MaterialTextField9.Enabled = False
        Else


            MaterialTextField7.Enabled = True
            MaterialTextField8.Enabled = True
            MaterialTextField9.Enabled = True
        End If
    End Sub


    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        Dim customer As New Customer(MaterialTextField1.Text, MaterialTextField2.Text, MaterialTextField3.Text, MaterialTextField4.Text, MaterialTextField10.Text, MaterialTextField5.Text, Val(MaterialTextField6.Text), Not MaterialCheckBox1.Checked)
        If MaterialCheckBox1.Checked Then
        Else
            customer.cardName = MaterialTextField7.Text
            customer.cardNumber = MaterialTextField8.Text
            customer.CVV = Val(MaterialTextField9.Text)
        End If

        customer.uploadInfo()
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)
        MaterialTextField1.Hint = "First Name"
        MaterialTextField2.Hint = "Last Name"
        MaterialTextField3.Hint = "Mobile Number"
        MaterialTextField4.Hint = "Email"
        MaterialTextField10.Hint = "Password"
        MaterialTextField11.Hint = "Confirm Password"
        MaterialTextField5.Hint = "Address"
        MaterialTextField6.Hint = "Pin Code"
        MaterialTextField7.Hint = "Card Number"
        MaterialTextField8.Hint = "Name On the Card"
        MaterialTextField9.Hint = "CVV"
    End Sub

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