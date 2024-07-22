Imports ADSUM
Imports Tools.Comun.Tools
Imports Juridico.Dominio
Imports System.ComponentModel
Imports System.Windows.Forms

Public Class FrmM2702002_CambioFechas

#Region "DECLARACIONES"
    Private vlnFolio As Integer
    Private vldFechaInicial As Date
    Private vldFechaFinal As Date

    Public bResultado As Boolean = False

#End Region

    Private Sub FrmM2702002_CambioFechas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFechaInicial.Text = vldFechaInicial.ToString("dd/MM/yyyy")
        lblFechaFinal.Text = vldFechaFinal.ToString("dd/MM/yyyy")

        dtpFechaInicial.Value = vldFechaInicial.ToString("dd/MM/yyyy")
        dtpFechaFinal.Value = vldFechaFinal.ToString("dd/MM/yyyy")
    End Sub

    Private Sub FrmM2702002_CambioFechas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If
    End Sub

    Private Sub btnAceptarClasificacion_Click(sender As Object, e As EventArgs) Handles btnAceptarClasificacion.Click
        If dtpFechaInicial.Value > dtpFechaFinal.Value Then
            MuestraMensaje("La fecha Inicial no puede ser mayor a la fecha Final", MessageBoxIcon.Information)

            Return
        End If

        If ConfirmaGuardar() Then
            bResultado = FabricaJuridico.AcTualizaFechasSolicitudes(vlnFolio, dtpFechaInicial.Value, dtpFechaFinal.Value)
        End If

        Me.DialogResult = DialogResult.OK
    End Sub
End Class