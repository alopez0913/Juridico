Imports ADSUM
Imports Tools.Comun.Tools
Imports Juridico.Dominio
Imports System.ComponentModel
Imports System.Windows.Forms

Public Class FrmM2702002_Clasifica

#Region "DECLARACIONES"
    Private ADDA As AsistenteDeDatos_Base

    Public Resultado As Integer = 0

#End Region

#Region "EVENTOS"

    Private Sub ATXClasificacion_CambioElemento(sender As Object, e As SelectedElementArgs) Handles ATXClasificacion.CambioElemento
        Try
            If Not String.IsNullOrEmpty(ATXClasificacion.Text.Trim) Then
                lblNombreClasificacion.Text = e.Row!Contrato
            End If
        Catch ex As Exception
            MuestraMensaje(ex.ToString, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptarClasificacion_Click(sender As Object, e As EventArgs) Handles btnAceptarClasificacion.Click
        If Not String.IsNullOrEmpty(ATXClasificacion.Text) Then
            Resultado = ATXClasificacion.Text

            Me.DialogResult = DialogResult.OK
        Else
            Resultado = 0

            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub FrmM2702002_Clasifica_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If
    End Sub

    Private Sub FrmM2702002_Clasifica_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.ActiveControl = ATXClasificacion
    End Sub

    Private Sub FrmM2702002_Clasifica_Load(sender As Object, e As EventArgs) Handles Me.Load

        ATXClasificacion.CatalogoBase = New Catalogo(New MetaCatalogo("JUR_GrupocontratoSubActos"))
    End Sub
#End Region


End Class