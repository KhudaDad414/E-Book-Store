Imports System.Data.SqlClient
Imports UserClassLibrary
Imports System.Text.RegularExpressions
Public Class PublisherInfo
    Private Sub UserInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MaterialLabel14.Text = Globals.CurrentUser.firstName
        MaterialLabel12.Text = Globals.CurrentUser.mobileNumber
        MaterialLabel11.Text = Globals.CurrentUser.email
        MaterialLabel10.Text = Globals.CurrentUser.address
        MaterialLabel9.Text = Globals.CurrentUser.accountNumber

        MaterialSingleLineTextField1.Hint = "New Value"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub MaterialRaisedButton7_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton7.Click
        Dim choice = ComboBox1.SelectedIndex
        UpdateInfo(choice)
    End Sub

    Private Sub UpdateInfo(c As Integer)

        Try
            Dim newValue = MaterialSingleLineTextField1.Text
            If c = 0 Then
                Globals.CurrentUser.firstName = newValue
                MaterialLabel14.Text = newValue
            ElseIf c = 1 Then
                If (newValue.Length() <> 10 Or Not Regex.IsMatch(newValue, "^[0-9 ]+$")) Then
                    MsgBox("mobile Number is not valid.")
                    Return
                End If
                Globals.CurrentUser.mobileNumber = newValue
                    MaterialLabel12.Text = newValue
                ElseIf c = 2 Then
                    Globals.CurrentUser.email = newValue
                    MaterialLabel11.Text = newValue
                ElseIf c = 3 Then
                    Globals.CurrentUser.address = newValue
                    MaterialLabel10.Text = newValue
                ElseIf c = 4 Then
                If (newValue.Length() <> 11 Or Not Regex.IsMatch(newValue, "^[0-9 ]+$")) Then
                    MsgBox("Account Number should be 11 in lenght and Only numbers.")
                    Return
                End If
                Globals.CurrentUser.accountNumber = newValue
                MaterialLabel9.Text = newValue

            End If


            Dim connection As New SqlConnection(Constants.PublisherConnectionString)
            connection.Open()
            Dim command As New SqlCommand("User.UpdatePublisherInfo", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add(New SqlParameter("@choice", c))
            command.Parameters.Add(New SqlParameter("@newValue", newValue))
            command.Parameters.Add(New SqlParameter("@publisherID", Globals.CurrentUser.ID))
            command.ExecuteNonQuery()


            MsgBox("Operation was successful.")
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
End Class
