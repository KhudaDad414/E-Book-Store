Imports System.Data.SqlClient

Public Class Publisher
    Inherits Person

    Public Property accountNumber As String


    Public Sub New(email As String, password As String)
        Me.email = email
        Me.password = password
    End Sub
    Public Sub New(companyName As String, mobileNumber As String, email As String, password As String, address As String, pinCode As Integer, account As String)
        Me.firstName = companyName
        Me.mobileNumber = mobileNumber
        Me.email = email
        Me.password = password
        Me.address = address
        Me.pinCode = pinCode
        Me.accountNumber = account
    End Sub

    Public Sub uploadInfo()
        Dim connection As New SqlConnection(Constants.PublisherConnectionString)
        connection.Open()
        Dim command As New SqlCommand("User.InsertPublisherInfo", connection)
        command.CommandType = CommandType.StoredProcedure




        command.Parameters.Add(New SqlParameter("@companyName", firstName))
        command.Parameters.Add(New SqlParameter("@mobileNumber", mobileNumber))
        command.Parameters.Add(New SqlParameter("@email", email))
        command.Parameters.Add(New SqlParameter("@password", password))
        command.Parameters.Add(New SqlParameter("@address", address))
        command.Parameters.Add(New SqlParameter("@pinCode", pinCode))
        command.Parameters.Add(New SqlParameter("@accountNumber", accountNumber))


        Try

            command.ExecuteNonQuery()


            MsgBox("Registered Successfuly.")
            connection.Close()
        Catch e As Exception
            MsgBox(e.ToString())
        End Try


    End Sub

    Public Function Login() As Boolean
        Dim connection As New SqlConnection(Constants.PublisherConnectionString)
        Dim reader As SqlDataReader

        connection.Open()
        Dim command As New SqlCommand("User.PublisherLogin", connection)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.Add(New SqlParameter("@email", email))
        command.Parameters.Add(New SqlParameter("@password", password))

        reader = command.ExecuteReader()

        If reader.Read Then
            Me.firstName = reader("companyName")
            Me.mobileNumber = reader("mobileNumber")
            Me.email = reader("email")
            Me.password = reader("password")
            Me.address = reader("address")
            Me.pinCode = reader("pinCode")
            Me.ID = reader("ID")

            Me.accountNumber = reader("accountNumber")

            Return True
        Else
            MsgBox("User name or Password is wrong.")
            Return False
        End If

        connection.Close()
    End Function
End Class
