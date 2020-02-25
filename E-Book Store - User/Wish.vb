Imports System.Data.SqlClient
Imports UserClassLibrary
Public Class Wish

    Public Sub loadWishList()
        MyWishListContainer.Controls.Clear()
        Dim connection As New SqlConnection(Constants.UserConnectionString)
        Dim command As New SqlCommand("User.getUserWishList", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.Add(New SqlParameter("@CustomerID", Globals.CurrentUser.ID))
        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter(command)
        adapter.Fill(table)
        MyWishListContainer.Controls.Clear()
        For counter As Integer = 0 To table.Rows.Count - 1
            Dim b1 As New BookControl1(table.Rows(counter)(0).ToString(), table.Rows(counter)(1).ToString(), table.Rows(counter)(2).ToString(), table.Rows(counter)(3))
            MyWishListContainer.Controls.Add(b1)
        Next
        connection.Close()
    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub
End Class
