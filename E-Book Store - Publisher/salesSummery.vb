Imports System.Data.SqlClient
Imports UserClassLibrary
Public Class salesSummery
    Public Sub loadInfo()
        Dim connection As New SqlConnection(Constants.PublisherConnectionString)
        Dim command As New SqlCommand("User.getPublisherSalesSummery", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.Add(New SqlParameter("@publisherID", Globals.CurrentUser.ID))
        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter(command)
        adapter.Fill(table)
        DataGridView1.DataSource = table
        Dim totalSales = table.Compute("SUM(SalesTotal)", "")
        Dim totalRent = table.Compute("SUM(RentTotal)", "")

        MaterialLabel1.Text = "Total Sales(₹): " + totalSales.ToString()
        MaterialLabel2.Text = "Total Rent(₹): " + totalRent.ToString()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.Columns(DataGridView1.ColumnCount - 4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        DataGridView1.Refresh()
        connection.Close()

    End Sub
End Class
