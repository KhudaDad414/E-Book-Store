Imports System.Data.SqlClient

Public Class Customer
    Inherits Person
    Public Property isCard As Boolean

    Public Property cardNumber As String
    Public Property cardName As String
    Public Property CVV As Integer


    Public Sub New(email As String, password As String)
        Me.email = email
        Me.password = password
    End Sub
    Public Sub New()
        ' left blank intentionally
    End Sub
    Public Sub New(firstName As String, lastName As String, mobileNumber As String, email As String, password As String, address As String, pinCode As Integer, isCard As Boolean)
        Me.firstName = firstName
        Me.lastName = lastName
        Me.mobileNumber = mobileNumber
        Me.email = email
        Me.password = password
        Me.address = address
        Me.pinCode = pinCode
        Me.isCard = isCard
    End Sub

    Public Sub uploadInfo()
        Dim connection As New SqlConnection(Constants.UserConnectionString)
        connection.Open()
        Dim command As New SqlCommand("User.InsertUserInfo", connection)
        command.CommandType = CommandType.StoredProcedure




        command.Parameters.Add(New SqlParameter("@firstName", firstName))
        command.Parameters.Add(New SqlParameter("@lastName", lastName))
        command.Parameters.Add(New SqlParameter("@mobileNumber", mobileNumber))
        command.Parameters.Add(New SqlParameter("@email", email))
        command.Parameters.Add(New SqlParameter("@password", password))
        command.Parameters.Add(New SqlParameter("@address", address))
        command.Parameters.Add(New SqlParameter("@pinCode", pinCode))
        command.Parameters.Add(New SqlParameter("@isCard", isCard))


        If isCard Then
            command.Parameters.Add(New SqlParameter("@cardNumber", DBNull.Value))
            command.Parameters.Add(New SqlParameter("@cardName", DBNull.Value))
            command.Parameters.Add(New SqlParameter("@CVV", DBNull.Value))
        Else
            command.Parameters.Add(New SqlParameter("@cardNumber", cardNumber))
            command.Parameters.Add(New SqlParameter("@cardName", cardName))
            command.Parameters.Add(New SqlParameter("@CVV", CVV))

        End If
        Try

            command.ExecuteNonQuery()


            MsgBox("Registered Successfuly.")
            connection.Close()
        Catch e As Exception
            MsgBox(e.ToString())
        End Try


    End Sub

    Public Function Login() As Boolean
        Dim connection As New SqlConnection(Constants.UserConnectionString)
        Dim reader As SqlDataReader

        connection.Open()
        Dim command As New SqlCommand("User.Login", connection)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.Add(New SqlParameter("@email", email))
        command.Parameters.Add(New SqlParameter("@password", password))

        reader = command.ExecuteReader()

        If reader.Read Then
            Me.ID = reader("ID")
            Me.firstName = reader("firstName")
            Me.lastName = reader("lastName")
            Me.mobileNumber = reader("mobileNumber")
            Me.email = reader("email")
            Me.password = reader("password")
            Me.address = reader("address")
            Me.pinCode = reader("pinCode")
            Me.isCard = reader("isCard")

            If Not Me.isCard Then
                Me.cardNumber = reader("cardNumber")
                Me.cardName = reader("cardName")
                Me.CVV = reader("CVV")
            End If
            Return True
        Else
            MsgBox("User name or Password is wrong.")
            Return False
        End If

        connection.Close()
    End Function
End Class
