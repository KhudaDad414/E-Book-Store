Imports System.Data.SqlClient
Imports UserClassLibrary
Public Class MyBooks
    Public Sub loadMyList()
        MyWishListContainer.Controls.Clear()
        Dim connection As New SqlConnection(Constants.PublisherConnectionString)
        Dim command As New SqlCommand("User.getPublisherBookList", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.Add(New SqlParameter("@publisherID", Globals.CurrentUser.ID))
        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter(command)
        adapter.Fill(table)
        MyWishListContainer.Controls.Clear()
        For counter As Integer = 0 To table.Rows.Count - 1
            Dim b1 As New MyBookSingle(table.Rows(counter)(0).ToString(), table.Rows(counter)(1).ToString())
            MyWishListContainer.Controls.Add(b1)
        Next
        connection.Close()
    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub
End Class
