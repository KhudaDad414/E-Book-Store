Imports UserClassLibrary
Imports System.Data.SqlClient

Public Class RequestPayment
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As New SqlConnection(Constants.PublisherConnectionString)
        connection.Open()
        Dim command As New SqlCommand("User.RequestPayment", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.Add(New SqlParameter("@publisherID", Globals.CurrentUser.ID))

        Dim Id = command.ExecuteScalar()

        If (Id > 0) Then
            MsgBox("Your application for payment was successful. Your Application Id is: " & Id & vbNewLine & " Use this Id for forthur inquiries.")
        Else
            MsgBox("Your application for payment was not successfull." & vbNewLine & " Please try again later or contact support team.")
        End If

        connection.Close()
    End Sub
End Class
