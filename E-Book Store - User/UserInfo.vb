Imports System.Data.SqlClient
Imports UserClassLibrary

Public Class UserInfo
    Private Sub UserInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MaterialLabel14.Text = Globals.CurrentUser.firstName
        MaterialLabel12.Text = Globals.CurrentUser.mobileNumber
        MaterialLabel11.Text = Globals.CurrentUser.email
        MaterialLabel10.Text = Globals.CurrentUser.address


        MaterialSingleLineTextField1.Hint = "New Value"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub MaterialRaisedButton7_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton7.Click
        Dim choice = ComboBox1.SelectedIndex
        UpdateInfo(choice)
    End Sub

    Private Sub UpdateInfo(c As Integer)
        Dim newValue = MaterialSingleLineTextField1.Text
        Dim connection As New SqlConnection(Constants.UserConnectionString)
        connection.Open()
        Dim command As New SqlCommand("User.UpdateUserInfo", connection)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.Add(New SqlParameter("@choice", c))
        command.Parameters.Add(New SqlParameter("@newValue", newValue))
        command.Parameters.Add(New SqlParameter("@userID", Globals.CurrentUser.ID))
        command.ExecuteNonQuery()

        If c = 0 Then
            Globals.CurrentUser.firstName = newValue
            MaterialLabel14.Text = newValue
        ElseIf c = 1 Then
            Globals.CurrentUser.lastName = newValue
            MaterialLabel13.Text = newValue
        ElseIf c = 2 Then
            Globals.CurrentUser.mobileNumber = newValue
            MaterialLabel12.Text = newValue
        ElseIf c = 3 Then
            Globals.CurrentUser.email = newValue
            MaterialLabel11.Text = newValue
        ElseIf c = 4 Then
            Globals.CurrentUser.address = newValue
            MaterialLabel10.Text = newValue
        ElseIf c = 5 Then
            Globals.CurrentUser.cardNumber = newValue
            MaterialLabel9.Text = newValue
        ElseIf c = 6 Then
            Globals.CurrentUser.cardName = newValue
            MaterialLabel8.Text = newValue

        End If
        MsgBox("Operation was successful.")
    End Sub
End Class
