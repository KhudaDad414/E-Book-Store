Imports System.Data.SqlClient
Imports UserClassLibrary
Public Class Browse
    Private Sub Browse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New SqlConnection(Constants.UserConnectionString)
        connection.Open()

        loadTopFree(connection)
        loadBestSeller(connection)
        loadRecomended(connection)

        connection.Close()
    End Sub
    Private Sub loadRecomended(connection As SqlConnection)
        Dim command As New SqlCommand("User.getRecomended", connection)
        command.CommandType = CommandType.StoredProcedure

        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter(command)

        adapter.Fill(table)
        RecomendedContainer.Controls.Clear()
        For counter As Integer = 0 To table.Rows.Count - 1
            Dim b1 As New BookControl1(table.Rows(counter)(0).ToString(), table.Rows(counter)(1).ToString(), table.Rows(counter)(2).ToString(), table.Rows(counter)(3))
            RecomendedContainer.Controls.Add(b1)
        Next

    End Sub
    Private Sub loadBestSeller(connection As SqlConnection)
        Dim command As New SqlCommand("User.getBestSellers", connection)
        command.CommandType = CommandType.StoredProcedure

        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter(command)

        adapter.Fill(table)
        BestSellerContainer.Controls.Clear()
        For counter As Integer = 0 To table.Rows.Count - 1
            Dim b1 As New BookControl1(table.Rows(counter)(0).ToString(), table.Rows(counter)(1).ToString(), table.Rows(counter)(2).ToString(), table.Rows(counter)(3))
            BestSellerContainer.Controls.Add(b1)
        Next

    End Sub
    Private Sub loadTopFree(connection As SqlConnection)

        Dim command As New SqlCommand("User.getTopFree", connection)
        command.CommandType = CommandType.StoredProcedure

        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter(command)

        adapter.Fill(table)
        TopFreeContainer.Controls.Clear()
        For counter As Integer = 0 To table.Rows.Count - 1
            Dim b1 As New BookControl1(table.Rows(counter)(0).ToString(), table.Rows(counter)(1).ToString(), table.Rows(counter)(2).ToString(), table.Rows(counter)(3))
            TopFreeContainer.Controls.Add(b1)
        Next


    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub
End Class
