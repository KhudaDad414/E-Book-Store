Imports System.Data.SqlClient
Imports System.IO
Public Class Book

    Public Property ID As Integer
    Public Property Name As String
    Public Property Author As String
    Public Property PublisherID As Integer
    Public Property Downloads As Integer
    Public Property Price As Integer
    Public Property Desc As Integer
    Public Property Category As String
    Public Property avgRating As Double
    Public Property Pages As Integer
    Public Property PublishDate As String
    Public Property Cover As Byte()
    Public Property PDF As Byte()




    Public Sub New(name As String, category As String, author As String, price As Integer, publishYear As String, pages As Integer, publisherID As Integer, Desc As String)
        Me.Name = name
        Me.Category = category
        Me.Author = author
        Me.Price = price
        Me.PublishDate = publishYear
        Me.PublisherID = publisherID
        Me.Pages = pages
        Me.Desc = Desc
    End Sub


    Public Sub uploadInfo()
        Dim connection As New SqlConnection(Constants.PublisherConnectionString)
        Dim reader As SqlDataReader
        connection.Open()
        Dim command As New SqlCommand("User.InsertBookInfo", connection)
        command.CommandType = CommandType.StoredProcedure




        command.Parameters.Add(New SqlParameter("@name", Name))
        command.Parameters.Add(New SqlParameter("@category", Category))
        command.Parameters.Add(New SqlParameter("@authorName", Author))
        command.Parameters.Add(New SqlParameter("@price", Price))
        command.Parameters.Add(New SqlParameter("@publishYear", PublishDate))
        command.Parameters.Add(New SqlParameter("@pages", Pages))
        command.Parameters.Add(New SqlParameter("@publisherID", PublisherID))
        command.Parameters.Add(New SqlParameter("@desc", Desc))


        Try

            reader = command.ExecuteReader()

            If reader.Read Then
                Me.ID = reader("ID")
                MsgBox("Registered Successfuly.")

            Else
                MsgBox("Something went wrong.")

            End If
            connection.Close()
        Catch e As Exception
            MsgBox(e.ToString())
        End Try


    End Sub

    Public Sub uploadPdf(path As String)
        PDF = File.ReadAllBytes(path)
        Dim connection As New SqlConnection(Constants.PublisherConnectionString)
        connection.Open()
        Dim command As New SqlCommand("User.uploadBookPDF", connection)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.Add("@file", SqlDbType.VarBinary).Value = Cover
        command.Parameters.Add(New SqlParameter("@id", ID))

        command.ExecuteNonQuery()

        MsgBox("Book uploaded successfuly.")
        connection.Close()
    End Sub

    Public Sub uploadCover(path As String)
        Cover = File.ReadAllBytes(path)
        Dim connection As New SqlConnection(Constants.PublisherConnectionString)
        connection.Open()
        Dim command As New SqlCommand("User.uploadBookCover", connection)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.Add("@file", SqlDbType.VarBinary).Value = Cover
        command.Parameters.Add(New SqlParameter("@id", ID))

        command.ExecuteNonQuery()

        MsgBox("Cover uploaded successfuly.")
        connection.Close()
    End Sub

    'Public Function Login() As Boolean
    '    Dim connection As New SqlConnection(Constants.PublisherConnectionString)
    '    Dim reader As SqlDataReader

    '    connection.Open()
    '    Dim command As New SqlCommand("User.PublisherLogin", connection)
    '    command.CommandType = CommandType.StoredProcedure
    '    command.Parameters.Add(New SqlParameter("@email", email))
    '    command.Parameters.Add(New SqlParameter("@password", password))

    '    reader = command.ExecuteReader()

    '    If reader.Read Then
    '        Me.firstName = reader("companyName")
    '        Me.mobileNumber = reader("mobileNumber")
    '        Me.email = reader("email")
    '        Me.password = reader("password")
    '        Me.address = reader("address")
    '        Me.pinCode = reader("pinCode")

    '        Me.accountNumber = reader("accountNumber")

    '        Return True
    '    Else
    '        MsgBox("User name or Password is wrong.")
    '        Return False
    '    End If

    '    connection.Close()
    'End Function
End Class
