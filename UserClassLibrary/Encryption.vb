Imports System.Text
Imports System.Security.Cryptography
Imports System.IO
Public Class Encryption
    Public Shared Function Encrypt(ByVal pdf As Byte(), ByVal Password As String, ByVal salt As String) As Byte()
        Dim HashAlgorithm As String = "SHA1" 'Can be SHA1 or MD5
        Dim PasswordIterations As String = 2
        Dim InitialVector As String = "CanEncryption123" 'This should be a string of 16 ASCII characters.
        Dim KeySize As Integer = 256 'Can be 128, 192, or 256.

        Dim InitialVectorBytes As Byte() = Encoding.ASCII.GetBytes(InitialVector)
        Dim SaltValueBytes As Byte() = Encoding.ASCII.GetBytes(salt)
        Dim DerivedPassword As PasswordDeriveBytes = New PasswordDeriveBytes(Password, SaltValueBytes, HashAlgorithm, PasswordIterations)
        Dim KeyBytes As Byte() = DerivedPassword.GetBytes(KeySize / 8)
        Dim SymmetricKey As RijndaelManaged = New RijndaelManaged()
        SymmetricKey.Padding = PaddingMode.PKCS7
        SymmetricKey.Mode = CipherMode.CBC

        Dim CipherTextBytes As Byte() = Nothing
        Using Encryptor As ICryptoTransform = SymmetricKey.CreateEncryptor(KeyBytes, InitialVectorBytes)
            Using MemStream As New MemoryStream()
                Using CryptoStream As New CryptoStream(MemStream, Encryptor, CryptoStreamMode.Write)
                    CryptoStream.Write(pdf, 0, pdf.Length)
                    CryptoStream.FlushFinalBlock()
                    CipherTextBytes = MemStream.ToArray()
                    MemStream.Close()
                    CryptoStream.Close()
                End Using
            End Using
        End Using
        SymmetricKey.Clear()
        Return CipherTextBytes
    End Function
    Public Shared Function Decrypt(ByVal CipherBytes As Byte(), ByVal password As String, ByVal salt As String) As Byte()
        Dim HashAlgorithm As String = "SHA1"
        Dim PasswordIterations As String = 2
        Dim InitialVector As String = "CanEncryption123"
        Dim KeySize As Integer = 256


        Dim InitialVectorBytes As Byte() = Encoding.ASCII.GetBytes(InitialVector)
        Dim SaltValueBytes As Byte() = Encoding.ASCII.GetBytes(salt)
        Dim DerivedPassword As PasswordDeriveBytes = New PasswordDeriveBytes(password, SaltValueBytes, HashAlgorithm, PasswordIterations)
        Dim KeyBytes As Byte() = DerivedPassword.GetBytes(KeySize / 8)
        Dim SymmetricKey As RijndaelManaged = New RijndaelManaged()
        SymmetricKey.Padding = PaddingMode.PKCS7
        SymmetricKey.Mode = CipherMode.CBC
        Dim PlainTextBytes As Byte() = New Byte(CipherBytes.Length - 1) {}

        Dim ByteCount As Integer = 0

        Using Decryptor As ICryptoTransform = SymmetricKey.CreateDecryptor(KeyBytes, InitialVectorBytes)
            Using MemStream As MemoryStream = New MemoryStream(CipherBytes)
                Using CryptoStream As CryptoStream = New CryptoStream(MemStream, Decryptor, CryptoStreamMode.Read)
                    ByteCount = CryptoStream.Read(PlainTextBytes, 0, PlainTextBytes.Length)
                    MemStream.Close()
                    CryptoStream.Close()
                End Using
            End Using
        End Using
        SymmetricKey.Clear()
        Return PlainTextBytes
    End Function
End Class
