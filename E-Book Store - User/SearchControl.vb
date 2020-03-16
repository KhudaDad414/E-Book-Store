Imports System.Data.SqlClient
Imports UserClassLibrary
Public Class SearchControl

    Public Sub loadBookList(q As String, connection As SqlConnection)
        MyWishListContainer.Controls.Clear()
        Dim command As New SqlCommand("User.searchBook", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.Add(New SqlParameter("@CustomerID", Globals.CurrentUser.ID))
        command.Parameters.Add(New SqlParameter("@query", q))
        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter(command)
        adapter.Fill(table)
        MyWishListContainer.Controls.Clear()
        For counter As Integer = 0 To table.Rows.Count - 1
            Dim b1 As New BookControl1(table.Rows(counter)(0).ToString(), table.Rows(counter)(1).ToString(), table.Rows(counter)(2).ToString(), table.Rows(counter)(3))
            MyWishListContainer.Controls.Add(b1)
        Next
    End Sub

    Private Sub SearchControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
