Public Class PaymentScreen
    Private WithEvents tm As New Timer
    Private Sub PaymentScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)
        tm.Interval = 5000
        tm.Start()
    End Sub
    Public Shared Sub CenterForm(ByRef frm As Form)
        Dim r As Rectangle

        r = Screen.FromPoint(frm.Location).WorkingArea


        Dim x = r.Left + (r.Width - frm.Width) \ 2
        Dim y = r.Top + (r.Height - frm.Height) \ 2
        frm.Location = New Point(x, y)
    End Sub
    Private Sub tm_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tm.Tick
        Close()
    End Sub
End Class