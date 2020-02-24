Public Class UserInfo
    Private Sub UserInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MaterialLabel14.Text = Globals.CurrentUser.firstName
        MaterialLabel13.Text = Globals.CurrentUser.lastName
        MaterialLabel12.Text = Globals.CurrentUser.mobileNumber
        MaterialLabel11.Text = Globals.CurrentUser.email
        MaterialLabel10.Text = Globals.CurrentUser.address
        MaterialLabel9.Text = Globals.CurrentUser.cardNumber
        MaterialLabel8.Text = Globals.CurrentUser.cardName


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
