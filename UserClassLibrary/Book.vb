﻿Imports System.Data.SqlClient
Imports System.IO
Public Class Book

    Public Property ID As Integer
    Public Property Name As String
    Public Property Author As String
    Public Property PublisherID As Integer
    Public Property PublisherName As String
    Public Property Downloads As Integer
    Public Property Price As Integer
    Public Property Desc As String
    Public Property Category As String
    Public Property avgRating As Double
    Public Property Pages As Integer
    Public Property PublishDate As String
    Public Property isWished As Boolean
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
    Public Sub New()

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
        command.Parameters.Add("@file", SqlDbType.VarBinary).Value = PDF
        command.Parameters.Add(New SqlParameter("@id", ID))

        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Public Sub addWished(userID As Integer)
        Dim connection As New SqlConnection(Constants.UserConnectionString)
        Dim reader As SqlDataReader

        connection.Open()
        Dim command As New SqlCommand("User.addWished", connection)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.Add(New SqlParameter("@id", ID))
        command.Parameters.Add(New SqlParameter("@CustId", userID))
        command.ExecuteNonQuery()
    End Sub

    Public Sub rent(userID As Integer)
        Dim connection As New SqlConnection(Constants.UserConnectionString)
        Dim reader As SqlDataReader

        connection.Open()
        Dim command As New SqlCommand("User.rent", connection)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.Add(New SqlParameter("@id", ID))
        command.Parameters.Add(New SqlParameter("@CustId", userID))
        command.ExecuteNonQuery()
    End Sub

    Public Sub buy(userID As Integer)
        Dim connection As New SqlConnection(Constants.UserConnectionString)
        Dim reader As SqlDataReader

        connection.Open()
        Dim command As New SqlCommand("User.buy", connection)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.Add(New SqlParameter("@id", ID))
        command.Parameters.Add(New SqlParameter("@CustId", userID))
        command.ExecuteNonQuery()
    End Sub


    Public Sub Download(userID As Integer)
        Dim connection As New SqlConnection(Constants.UserConnectionString)
        Dim reader As SqlDataReader

        connection.Open()
        Dim command As New SqlCommand("User.downloadEbook", connection)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.Add(New SqlParameter("@id", ID))
        command.Parameters.Add(New SqlParameter("@CustId", userID))



        Try

            Dim pdf = CType(command.ExecuteScalar, Byte())
            Dim encodedPdf = Encryption.Encrypt(pdf, CStr(ID + userID), "mySalt")
            File.WriteAllBytes("./temp/" & Me.ID & userID & ".encrypt", encodedPdf)
            connection.Close()
            MsgBox("book Downloaded.")
        Catch e As Exception
            MsgBox(e.ToString())
        End Try
        Dim downloadedBooks() As String = {}
        If (File.Exists("./temp/books.list")) Then
            downloadedBooks = File.ReadAllText("./temp/books.list").Split("|"c)
        End If
        Array.Resize(downloadedBooks, downloadedBooks.Length + 1)
        downloadedBooks(downloadedBooks.Length - 1) = ID & "|"
        File.WriteAllText("./temp/books.list", String.Join("|", downloadedBooks))

    End Sub



    Public Sub removeWished(userID As Integer)
        Dim connection As New SqlConnection(Constants.UserConnectionString)
        Dim reader As SqlDataReader

        connection.Open()
        Dim command As New SqlCommand("User.removeWished", connection)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.Add(New SqlParameter("@id", ID))
        command.Parameters.Add(New SqlParameter("@CustId", userID))
        command.ExecuteNonQuery()
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
