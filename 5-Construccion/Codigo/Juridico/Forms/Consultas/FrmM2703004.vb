Imports ADSUM
Imports Tools.Comun.Tools
Imports System.Windows.Forms
Imports Juridico.Dominio
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Drawing

Public Class FrmM2703004    'Tablero vencimiento contratos

#Region "DECLARACIONES"

    Private WithEvents Manejador As ManejadorXtraGridAdvanced
    Dim frmEspera As New QNGuarda.frmStatus()
    Dim dsDatos As DataSet

#End Region

#Region "FUNCIONES Y PROCEDIMIENTOS"

    Private Sub Nuevo()

        LimpiaGrid()

        atxCodContratante.CatalogoBase = New Catalogo(New MetaCatalogo("JUR_Beneficiarios"))
        atxCodDepto.CatalogoBase = New Catalogo(New MetaCatalogo("JUR_Departamentos"))

        atxCodContratante.Text = ""
        atxCodDepto.Text = ""

        lblDescContratante.Text = ""
        lblDescDepto.Text = ""

        With Me.ToolBarButtons
            .Graficar = False
            .Herramientas = False
            .Imprimir = False
            .Nuevo = True
            .Guardar = False
            .Borrar = False
            .Ejecutar = True
            .Autorizar = False
            .EnvExcel = True
        End With
    End Sub

    Private Sub LimpiaGrid()
        If dsDatos IsNot Nothing Then dsDatos.Clear()
    End Sub

    Private Sub LlenaGrid(cargaInicial As Boolean)
        Try
            frmEspera.Show("Mostrando Información")
            LimpiaGrid()

            If String.IsNullOrEmpty(atxCodDepto.Text) Then atxCodDepto.Text = 0

            dsDatos = FabricaJuridico.ObtenerConsultaContratosPorVencer(atxCodContratante.Text, atxCodDepto.Text)
            grdContratos.DataSource = dsDatos.Tables(0)

            Utilerias.FormatearColumnasGrid(grvContratos)
            Utilerias.AjustarTamañoColumnasGrid(grvContratos)

            If atxCodDepto.Text = 0 Then atxCodDepto.Text = ""
        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
        Finally
            frmEspera.Hide()
        End Try
    End Sub
#End Region

#Region "OVERRIDES"

    Protected Overrides Sub ClickBotonNuevo()
        MyBase.ClickBotonNuevo()
        If MensajeConfirmaLimpiarPantalla() = DialogResult.No Then Return
        Nuevo()
    End Sub

    Protected Overrides Sub ClickBotonEjecutar()
        MyBase.ClickBotonEjecutar()
        LlenaGrid(False)
    End Sub

    Protected Overrides Sub ClickBotonEnvExcel()
        MyBase.ClickBotonEnvExcel()
        Try
            If dsDatos.Tables(0).Rows.Count = 0 Then
                MuestraMensaje("No hay datos para exportar", MessageBoxIcon.Information)
            Else
                Utilerias.ExportarDataSetToExcel(dsDatos)
            End If
        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "EVENTOS"
    Private Sub FrmM2703004_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Manejador = New ManejadorXtraGridAdvanced(grdContratos)
        Manejador.Estilo = ManejadorXtraGridAdvanced.Estilos.Seleccion
        Nuevo()
        LlenaGrid(True)
    End Sub

    Private Sub atxCodContratante_CambioElemento(sender As Object, e As SelectedElementArgs) Handles atxCodContratante.CambioElemento
        Try
            If atxCodContratante.Text.Trim = "" Then Return

            If e.Row IsNot Nothing Then
                atxCodContratante.Text = e.Row("cRFC")
                lblDescContratante.Text = e.Row("cRazonSocial").ToString.Trim()
            End If
        Catch ex As Exception
            MuestraMensaje(ex.ToString, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
End Class