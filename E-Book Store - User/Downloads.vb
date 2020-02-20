Imports System.Data.SqlClient
Imports UserClassLibrary
Imports System.IO
Public Class Downloads
    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub


    Public Sub loadDownloadList()
        MyWishListContainer.Controls.Clear()
        Dim list As String = File.ReadAllText("./temp/books.list")
        Dim connection As New SqlConnection(Constants.UserConnectionString)
        Dim command As New SqlCommand("User.getUserDownloadsList", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.Add(New SqlParameter("@bookList", list))
        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter(command)
        adapter.Fill(table)
        MyWishListContainer.Controls.Clear()
        For counter As Integer = 0 To table.Rows.Count - 1
            Dim b1 As New BookControl1(table.Rows(counter)(0).ToString(), table.Rows(counter)(1).ToString(), "Paid", table.Rows(counter)(2))
            MyWishListContainer.Controls.Add(b1)
        Next

    End Sub
End Class
