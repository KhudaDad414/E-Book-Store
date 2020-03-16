
Public Class Form1
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point
    Public Sub New()
        InitializeComponent()
        SidePanel.Height = button1.Height
        SidePanel.Top = button1.Top


    End Sub

    Private Sub panel2_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            mouseOffset = New Point(-e.X, -e.Y)
            ' Set that left button is pressed
            isMouseDown = True
        End If
    End Sub

    Private Sub panel2_MouseMove(sender As Object, e As MouseEventArgs)
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Get the new form position
            mousePos.Offset(mouseOffset.X - 209, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub panel2_MouseUp(sender As Object, e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub


    Private Sub panel1_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            mouseOffset = New Point(-e.X, -e.Y)
            ' Set that left button is pressed
            isMouseDown = True
        End If
    End Sub

    Private Sub panel1_MouseMove(sender As Object, e As MouseEventArgs)
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Get the new form position
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub panel1_MouseUp(sender As Object, e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub Browse1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddBook1_Load(sender As Object, e As EventArgs) Handles AddBook1.Load

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddBook2.BringToFront()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles button2.Click
        SidePanel.Height = button2.Height
        SidePanel.Top = button2.Top
        MyBooks1.BringToFront()
        MyBooks1.loadMyList()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles button3.Click
        SidePanel.Height = button3.Height
        SidePanel.Top = button3.Top
        SalesSummery1.BringToFront()
        SalesSummery1.loadInfo()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles button4.Click
        SidePanel.Height = button4.Height
        SidePanel.Top = button4.Top
        RequestPayment1.BringToFront()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        SidePanel.Height = button7.Height
        SidePanel.Top = button7.Top
        PublisherInfo1.BringToFront()
    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles button13.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        SidePanel.Height = button1.Height
        SidePanel.Top = button1.Top
        AddBook2.BringToFront()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub


End Class

