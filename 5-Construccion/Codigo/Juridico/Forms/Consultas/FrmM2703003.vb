﻿Imports ADSUM
Imports Tools.Comun.Tools
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports Juridico.Dominio

Public Class FrmM2703003    '   Estatus de Contratos

    '#Region "Declaraciones"
    '    Private ADDA As AsistenteDeDatos_Base
    '    Dim tbDatosCargar As DataTable
    '    Dim tbDatosMovs As DataTable
    '    Private dtEmpleado As DataTable

    '    Private dsDatos As DataSet

    '    Private WithEvents AXGEstatus As ManejadorXtraGridAdvanced
    '#End Region

    '#Region "Funciones y Procedimientos"
    '    Private Sub ConfigurarGrid()
    '        AXGEstatus = New ManejadorXtraGridAdvanced(grdContratos)
    '        AXGEstatus.Estilo = Manejador_XtraGrid.Estilos.Seleccion
    '    End Sub

    '    Private Sub LlenaComboEstatus()
    '        ADDA.RegresaConsultaSQL("SELECT cDescEstatus, nIDEstatusSol FROM dbo.CTL_EstatusSolContrato ORDER BY nIDEstatusSol", cmbEstatus)
    '    End Sub

    '    Private Sub InicializarCatalogos()
    '        atxSolicitante.CatalogoBase = New Catalogo(New MetaCatalogo("JUR_Solicitantes"))
    '        atxCodContratante.CatalogoBase = New Catalogo(New MetaCatalogo("CTL_Beneficiarios"))
    '    End Sub

    '    Private Sub CrearEstructura()
    '        Utilerias.DestruirObjeto(tbDatosMovs)

    '        tbDatosMovs = New DataTable
    '        tbDatosMovs.Columns.Add("Folio", GetType(Integer))
    '        tbDatosMovs.Columns.Add("Depto", GetType(String))
    '        tbDatosMovs.Columns.Add("Grupo", GetType(String))
    '        tbDatosMovs.Columns.Add("Acto", GetType(String))
    '        tbDatosMovs.Columns.Add("Solicitante", GetType(String))
    '        tbDatosMovs.Columns.Add("Contratante", GetType(String))
    '        tbDatosMovs.Columns.Add("FecElaboracion", GetType(Date))
    '        tbDatosMovs.Columns.Add("FecInicial", GetType(Date))
    '        tbDatosMovs.Columns.Add("FecFinal", GetType(Date))
    '        tbDatosMovs.Columns.Add("FecFirma", GetType(Date))
    '        tbDatosMovs.Columns.Add("FolioPropuesta", GetType(String))
    '        tbDatosMovs.Columns.Add("ImpPenalidad", GetType(Decimal))
    '        tbDatosMovs.Columns.Add("Estatus", GetType(Integer))
    '        tbDatosMovs.Columns.Add("Color", GetType(String))

    '        grdContratos.DataSource = tbDatosMovs

    '        'COLUMNAS OCULTAS
    '        grvContratos.Columns("Estatus").Visible = False
    '        grvContratos.Columns("Color").Visible = False

    '        Utilerias.AjustarTamañoColumnasGrid(grvContratos)
    '        Utilerias.FormatearColumnasGrid(grvContratos)
    '    End Sub
    '    Private Sub CargarDatos()
    '        Utilerias.DestruirObjeto(tbDatosCargar)
    '        CrearEstructura()

    '        Dim dsTemp As DataSet
    '        Dim cSolicitante As String = atxSolicitante.Text.Trim
    '        Dim nContratante As Integer = IIf(atxCodContratante.Text.Trim = "", 0, atxCodContratante.Text.Trim)
    '        Dim nEstatus As Integer = IIf(cmbEstatus.SelectedValue = -1, 0, cmbEstatus.SelectedValue)
    '        Dim dFecIni As Date = dtpFecIni.Value.Date
    '        Dim dFecFin As Date = dtpFecFin.Value.Date

    '        dsTemp = FabricaJuridico.ConsultarContratos(cSolicitante, nContratante, nCodDepto, nEstatus, nGrupo, nActo, dFecIni, dFecFin)
    '        tbDatosCargar = dsTemp.Tables(0)
    '        tbDatosMovs.Merge(tbDatosCargar, False, MissingSchemaAction.Ignore)

    '        If tbDatosMovs.Rows.Count > 0 Then
    '            dsTemp.Relations.Add("Detalle", dsTemp.Tables(0).Columns("Folio"), dsTemp.Tables(1).Columns("Folio"))
    '            grdContratos.DataSource = dsTemp
    '            grdContratos.DataMember = dsTemp.Tables(0).TableName

    '            'COLUMNAS OCULTAS
    '            grvContratos.Columns("Estatus").Visible = False
    '            grvContratos.Columns("Color").Visible = False

    '            dsDatos = dsTemp
    '            Utilerias.AjustarTamañoColumnasGrid(grvContratos)
    '            Utilerias.FormatearColumnasGrid(grvContratos)
    '            Utilerias.DestruirObjeto(dsTemp)
    '        Else
    '            MuestraMensaje("No se encontraron contratos con los filtros especificados", MessageBoxIcon.Information)
    '        End If
    '    End Sub
    '    Private Sub Nuevo()
    '        If Not dtEmpleado.Rows(0)("nCodSubDepto") = 2 AndAlso Not dtEmpleado.Rows(0)("nCodSubDepto") = 7 Then
    '            atxSolicitante.Text = dtEmpleado.Rows(0)("cLogin")
    '            lblDescSolicitante.Text = dtEmpleado.Rows(0)("cNombreEmpleado")
    '            atxSolicitante.Enabled = False
    '        Else
    '            lblDescSolicitante.Text = ""
    '        End If
    '        'atxSolicitante.Text = ""
    '        'atxSolicitante.Focus()
    '        atxCodContratante.Text = ""
    '        lblDescContratante.Text = ""
    '        cmbEstatus.SelectedIndex = -1
    '        dtpFecIni.Value = Today.Date
    '        dtpFecFin.Value = Today.Date
    '        cmbEstatus.SelectedIndex = -1
    '        Utilerias.DestruirObjeto(dsDatos)

    '        With Me.ToolBarButtons
    '            .Guardar = False
    '            .Borrar = False
    '            .Imprimir = False
    '            .EnvExcel = False
    '            .Graficar = False
    '            .Ejecutar = True
    '            .Nuevo = True
    '        End With

    '        CrearEstructura()
    '    End Sub

    '    Private Sub ConfigurarEstatus()
    '        txtSolicitado.BackColor = System.Drawing.Color.FromArgb(115, 42, 5)
    '        txtSuspendido.BackColor = System.Drawing.Color.FromArgb(129, 8, 142)
    '        txtClasificado.BackColor = System.Drawing.Color.FromArgb(231, 189, 128)
    '        txtRevisadoSinDoc.BackColor = System.Drawing.Color.FromArgb(247, 244, 6)
    '        txtRevisadoConDoc.BackColor = System.Drawing.Color.FromArgb(10, 245, 209)
    '        txtLiberado.BackColor = System.Drawing.Color.FromArgb(42, 242, 11)
    '        txtFinalizado.BackColor = System.Drawing.Color.FromArgb(26, 136, 9)
    '        txtCancelado.BackColor = System.Drawing.Color.FromArgb(244, 52, 10)
    '    End Sub

    '    Private Sub plConsultaDatosdelEmpleado(prmLogin As String)
    '        dtEmpleado = FabricaJuridico.ObtenDatosdelEmpleado(prmLogin)

    '        For Each vDRow As DataRow In dtEmpleado.Rows
    '            If Not vDRow("nCodDepto") = 2 AndAlso Not vDRow("nCodSubDepto") = 7 Then
    '                atxSolicitante.Text = vDRow("cLogin")
    '                lblDescSolicitante.Text = vDRow("cNombreEmpleado")
    '                atxSolicitante.Enabled = False
    '            End If
    '        Next
    '    End Sub

    '    Private Sub PlEnviarExcel()

    '        Utilerias.ExportarDataSetToExcel(dsDatos)
    '    End Sub
    '#End Region

    '#Region "Overrides"
    '    Protected Overrides Sub ClickBotonNuevo()
    '        MyBase.ClickBotonNuevo()

    '        If MensajeConfirmaLimpiarPantalla() = DialogResult.No Then Return
    '        Nuevo()
    '    End Sub
    '    Protected Overrides Sub ClickBotonEjecutar()
    '        MyBase.ClickBotonEjecutar()

    '        CargarDatos()

    '        Me.ToolBarButtons.EnvExcel = True
    '    End Sub
    '    Protected Overrides Sub ClickBotonEnvExcel()
    '        MyBase.ClickBotonEnvExcel()

    '        If MensajePregunta("Confirma que desea exportar la consulta a un archivo excel?") = DialogResult.No Then Return

    '        PlEnviarExcel()
    '    End Sub
    '#End Region

    '#Region "Eventos"
    '    Private Sub FrmM2703001_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        Try
    '            ADDA = AsistenteDeDatos_Base.DevuelveInstancia
    '            ReferenciaRapidaVisible = False

    '            LlenaComboEstatus()
    '            ConfigurarGrid()
    '            ConfigurarEstatus()
    '            InicializarCatalogos()
    '            plConsultaDatosdelEmpleado(ADDA.GetLoginUsuario)
    '            Nuevo()
    '        Catch ex As Exception
    '            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
    '        End Try
    '    End Sub

    '    Private Sub FrmM2703001_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    '        PGCerrarPantalla(sender, e, True)
    '    End Sub

    '    Private Sub grvMovimientos_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles grvContratos.RowCellStyle
    '        Select Case grvContratos.GetRowCellValue(e.RowHandle, grvContratos.Columns("Estatus"))
    '            Case 1
    '                e.Appearance.BackColor = System.Drawing.Color.FromArgb(115, 42, 5)
    '                e.Appearance.BackColor2 = System.Drawing.Color.FromArgb(115, 42, 5)
    '            Case 2
    '                e.Appearance.BackColor = System.Drawing.Color.FromArgb(129, 8, 142)
    '                e.Appearance.BackColor2 = System.Drawing.Color.FromArgb(129, 8, 142)
    '            Case 3
    '                e.Appearance.BackColor = System.Drawing.Color.FromArgb(231, 189, 128)
    '                e.Appearance.BackColor2 = System.Drawing.Color.FromArgb(231, 189, 128)
    '            Case 4
    '                e.Appearance.BackColor = System.Drawing.Color.FromArgb(247, 244, 6)
    '                e.Appearance.BackColor2 = System.Drawing.Color.FromArgb(247, 244, 6)
    '            Case 5
    '                e.Appearance.BackColor = System.Drawing.Color.FromArgb(10, 245, 209)
    '                e.Appearance.BackColor2 = System.Drawing.Color.FromArgb(10, 245, 209)
    '            Case 6
    '                e.Appearance.BackColor = System.Drawing.Color.FromArgb(42, 242, 11)
    '                e.Appearance.BackColor2 = System.Drawing.Color.FromArgb(42, 242, 11)
    '            Case 7
    '                e.Appearance.BackColor = System.Drawing.Color.FromArgb(26, 136, 9)
    '                e.Appearance.BackColor2 = System.Drawing.Color.FromArgb(26, 136, 9)
    '            Case 8
    '                e.Appearance.BackColor = System.Drawing.Color.FromArgb(244, 52, 10)
    '                e.Appearance.BackColor2 = System.Drawing.Color.FromArgb(244, 52, 10)
    '        End Select
    '    End Sub
    '#End Region

End Class