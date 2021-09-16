Imports System.IO

Public Class FileManagement


    Public Shared Function readCsv(ByVal fileName As String) As List(Of strBarcodeDestination)
        Dim sData() As String
        Dim arrName, arrValue As New List(Of String)()

        Dim barcodes As New List(Of strBarcodeDestination)
        Try
            Using sr As New StreamReader(fileName)
                While Not sr.EndOfStream
                    sData = sr.ReadLine().Split(";"c)

                    Dim barcode As strBarcodeDestination
                    barcode.barcode = sData(0).Trim()
                    barcode.destination = Integer.Parse(sData(1).Trim())
                    barcodes.Add(barcode)
                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error reading file")
        End Try


        Return barcodes

    End Function

End Class
