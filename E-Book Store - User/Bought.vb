Imports System.Data.SqlClient
Imports UserClassLibrary
Public Class Bought
    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub
    Public Sub loadBoughtList()
        MyWishListContainer.Controls.Clear()
        Dim connection As New SqlConnection(Constants.UserConnectionString)
        Dim command As New SqlCommand("User.getUserBoughtList", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.Add(New SqlParameter("@CustomerID", Globals.CurrentUser.ID))
        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter(command)
        adapter.Fill(table)
        MyWishListContainer.Controls.Clear()
        For counter As Integer = 0 To table.Rows.Count - 1
            Dim b1 As New UserControl2(table.Rows(counter)(0).ToString(), table.Rows(counter)(1).ToString())
            MyWishListContainer.Controls.Add(b1)
        Next

    End Sub
End Class
