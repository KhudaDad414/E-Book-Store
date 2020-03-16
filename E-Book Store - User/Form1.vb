Imports System.Data.SqlClient
Imports UserClassLibrary

Public Class Form1
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point
    Private connection As New SqlConnection(Constants.UserConnectionString)
    Private lastCount As Integer
    Private currentButton As Button
    Public Sub New()
        InitializeComponent()
        SidePanel.Height = button1.Height
        SidePanel.Top = button1.Top
        Browse2.BringToFront()
        TextBox1.Text = "SEARCH"
        currentButton = button1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        SidePanel.Height = button1.Height
        SidePanel.Top = button1.Top
        Browse2.BringToFront()
        currentButton = button1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        SidePanel.Height = button2.Height
        SidePanel.Top = button2.Top
        Wish2.BringToFront()
        Wish2.loadWishList()
        currentButton = button2
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        SidePanel.Height = button3.Height
        SidePanel.Top = button3.Top
        Rented2.BringToFront()
        Rented2.loadRentedList()
        currentButton = button3
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles button13.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        SidePanel.Height = button4.Height
        SidePanel.Top = button4.Top
        Bought2.BringToFront()
        Bought2.loadBoughtList()
        currentButton = button4
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        SidePanel.Height = button5.Height
        SidePanel.Top = button5.Top
        Downloads2.BringToFront()
        Downloads2.loadDownloadList()
        currentButton = button5
    End Sub



    Private Sub panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles panel2.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            mouseOffset = New Point(-e.X, -e.Y)
            ' Set that left button is pressed
            isMouseDown = True
        End If
    End Sub

    Private Sub panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles panel2.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Get the new form position
            mousePos.Offset(mouseOffset.X - 209, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles panel2.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub


    Private Sub panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            mouseOffset = New Point(-e.X, -e.Y)
            ' Set that left button is pressed
            isMouseDown = True
        End If
    End Sub

    Private Sub panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles panel1.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Get the new form position
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles panel1.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        SidePanel.Height = button7.Height
        SidePanel.Top = button7.Top
        UserInfo1.BringToFront()
        currentButton = button7
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles panel1.Paint

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If (Not (TextBox1.Text.Equals("SEARCH") Or TextBox1.Text.Equals("") Or TextBox1.Text.Length < lastCount)) Then
            SearchControl1.loadBookList(TextBox1.Text, connection)

        End If
        lastCount = TextBox1.Text.Length
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        For i As Integer = 128 To 732 Step 8
            TextBox1.Size = New Drawing.Size(i, 20)
        Next
        TextBox1.Text = ""
        SearchControl1.BringToFront()
        connection.Open()
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus

        For i As Integer = 732 To 128 Step -8
            TextBox1.Size = New Drawing.Size(i, 20)
        Next

        TextBox1.Text = "SEARCH"
        SearchControl1.SendToBack()
        connection.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If TextBox1.Focused() Then
                currentButton.PerformClick()
                currentButton.Focus()

            End If
        End If
    End Sub
End Class

