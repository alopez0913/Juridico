Imports System.ComponentModel
Imports System.Windows.Forms
Imports ADSUM
Imports Tools.Comun.Tools

Public Class FrmVisualizarArchivos
    Property DirArchivo As String
    Property Extencion As String
    Private Sub FrmVisualizarArchivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists(Me.DirArchivo) Then

            If Me.Extencion.ToUpper = "PDF" Then
                wbrVisualizador.Visible = False
                pdfvPDF.LoadDocument(DirArchivo)
            Else
                pdfvPDF.Visible = False
                wbrVisualizador.Navigate(DirArchivo)
            End If
        Else
            MuestraMensaje("El archivo que se quiere visualiar no existe.", MessageBoxIcon.Exclamation)
            Me.Close()
        End If
    End Sub
    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        If Me.DirArchivo = "" Then Exit Sub
        'wbrVisualizador.Navigate("")
        'Exit Sub
        Dim dg As New SaveFileDialog

        Try
            dg.Filter = "Archivo " & Extencion & "|*." & Extencion.Trim
            dg.DefaultExt = Me.Extencion

            If dg.ShowDialog = DialogResult.OK Then
                IO.File.Copy(Me.DirArchivo, dg.FileName)
                MuestraMensaje("Archivo exportado correctamente.", MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
        Finally
            Utilerias.DestruirObjeto(dg)
        End Try
    End Sub
    Private Sub FrmVisualizarArchivos_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If pdfvPDF.IsDocumentOpened Then pdfvPDF.CloseDocument()

        Utilerias.DestruirObjeto(wbrVisualizador)
        Utilerias.DestruirObjeto(pdfvPDF)

        Me.Dispose()
    End Sub
End Class