Imports System.IO
Public Class PdfViewer
    Dim pdf As String
    Private Sub PdfViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub


    Private Sub PdfViewer_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        File.Delete(pdf)

    End Sub

    Public Sub loadPdf(pdf As String)
        Me.pdf = Path.GetFullPath(pdf)
        AxAcroPDF1.src = Me.pdf + "#toolbar=0"
        AxAcroPDF1.setShowToolbar(False)
        AxAcroPDF1.Show()
    End Sub


End Class