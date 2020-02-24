
Public Class Form1
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point
    Public Sub New()
        InitializeComponent()
        SidePanel.Height = button1.Height
        SidePanel.Top = button1.Top
        Browse2.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        SidePanel.Height = button1.Height
        SidePanel.Top = button1.Top
        Browse2.BringToFront()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        SidePanel.Height = button2.Height
        SidePanel.Top = button2.Top
        Wish2.BringToFront()
        Wish2.loadWishList()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        SidePanel.Height = button3.Height
        SidePanel.Top = button3.Top
        Rented2.BringToFront()
        Rented2.loadRentedList()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles button13.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        SidePanel.Height = button4.Height
        SidePanel.Top = button4.Top
        Bought2.BringToFront()
        Bought2.loadBoughtList()
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        SidePanel.Height = button5.Height
        SidePanel.Top = button5.Top
        Downloads2.BringToFront()
        Downloads2.loadDownloadList()
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
    End Sub

End Class

