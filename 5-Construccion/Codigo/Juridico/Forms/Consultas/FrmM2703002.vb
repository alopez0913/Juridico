
Imports System.Data.SqlClient
Imports System.Data
Imports QNGuarda
Imports ADSUM
Imports Tools.Comun.Tools
Imports System.Windows.Forms
Imports Catalogos.Dominio
Imports System.ComponentModel

Imports Juridico.Dominio

Imports System.Drawing.Text
Imports System.Drawing
Imports System.Drawing.Drawing2D

Imports System.IO
Imports System.Configuration
Imports DevExpress.XtraGrid.Views.Grid

Public Class FrmM2703002

    Dim myDTS As DataSet
    Dim myDT As DataTable
    Dim bLoad As Boolean = False
    Dim iCerrar As Integer = 0
    Dim iCodProv As Integer = 0

    Private DTXML As DataTable
    Private ADDA As AsistenteDeDatos_Base
    Private gbPreguntaCerrarPantalla As Boolean = True
    Private vcMensaje As String
    Private myManejador As ManejadorXtraGridAdvanced
    Private FrmWait As New QNGuarda.frmStatus()

    Public tipopersona As String
    Public validadoble As String
    Public validaEntrada As Boolean = False

    Public validaEntpro As Boolean = False

    Private Sub InicializarCatalogos()
        '  atxProveedor.CatalogoBase = New Catalogo(New MetaCatalogo("CTL_Beneficiarios"))
        atxSubTipoActo.CatalogoBase = New Catalogo(New MetaCatalogo("JUR_GrupocontratoSubActos"))
        atxCodigo.CatalogoBase = New Catalogo(New MetaCatalogo("SolContratos"))
    End Sub
    Protected Overrides Sub ClickBotonEnvExcel()
        MyBase.ClickBotonEnvExcel()

        If MensajePregunta("Confirma que desea exportar la consulta a un archivo excel?") = DialogResult.No Then Return

        PlEnviarExcel()

    End Sub
    Private Sub PlEnviarExcel()

        Utilerias.ExportarDataSetToExcel(myDTS)

    End Sub

    Protected Overrides Sub ClickBotonNuevo()
        MyBase.ClickBotonNuevo()

        Dim DtPersona As New DataTable
        Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
        atxCodigo.Focus()
        txtEstatus.Text = ""

        'Estructura para darle estilo al Grid () no hagarró el código de CrearEstructuraGridprov()
        Utilerias.DestruirObjeto(DTXML)

        DTXML = New DataTable
        With DTXML
            .Columns.Add("Version", GetType(Integer)).Caption = "Version"
            .Columns.Add("Fecha", GetType(String)).Caption = "Fecha"
            .Columns.Add("Generó", GetType(String)).Caption = "Generó"
            .Columns.Add("MOTIVO", GetType(String)).Caption = "MOTIVO"
        End With

        GridProveedores.DataSource = DTXML
        With Grvprovedores
            .PopulateColumns()
        End With


        myManejador = New ManejadorXtraGridAdvanced(GridProveedores)
        myManejador.Estilo = ManejadorXtraGridAdvanced.Estilos.Seleccion
        Utilerias.FormatearColumnasGrid(Grvprovedores)
        Utilerias.AjustarTamañoColumnasGrid(Grvprovedores)
        Utilerias.ConfigurarColumnasGrid(Grvprovedores)


        quitartotalsuc()
        Me.ToolBarButtons.Ejecutar = True
        Me.ToolBarButtons.EnvExcel = True
        ' 152, 158, 157 color gris
        txtColor.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(152, 158, 157))

        atxCodigo.Text = ""
        atxCodigo.Focus()
    End Sub
    Public Sub quitartotalsuc()
        Grvprovedores.DeleteSelectedRows()

        For i As Integer = 1 To Grvprovedores.RowCount
            Grvprovedores.FocusedRowHandle = i
            Grvprovedores.DeleteSelectedRows()
            Grvprovedores.RefreshData()
        Next

        'Estructura para darle estilo al Grid () no hagarró el código de CrearEstructuraGridprov()
        Utilerias.DestruirObjeto(DTXML)

        DTXML = New DataTable
        With DTXML
            .Columns.Add("ntipo", GetType(Boolean)).Caption = "Contratante"
            .Columns.Add("cCodProve", GetType(String)).Caption = "Código"
            .Columns.Add("cDescProv", GetType(String)).Caption = "DescProv"
            .Columns.Add("cRFC", GetType(String)).Caption = "RFC"
            .Columns.Add("cTipoPersona", GetType(String)).Caption = "TipoPersona"
        End With

        GridProveedores.DataSource = DTXML
        With Grvprovedores
            .PopulateColumns()
        End With

        myManejador = New ManejadorXtraGridAdvanced(GridProveedores)
        myManejador.Estilo = ManejadorXtraGridAdvanced.Estilos.Seleccion
        Utilerias.FormatearColumnasGrid(Grvprovedores)
        Utilerias.AjustarTamañoColumnasGrid(Grvprovedores)
        Utilerias.ConfigurarColumnasGrid(Grvprovedores)
    End Sub
    Private Sub FrmM2703002_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grbFolio.Enabled = False
        grbClasificacion.Enabled = False
        grboxRangoFechas.Enabled = False
        grbSolicitante.Enabled = False
        grbDepartamento.Enabled = False
        cmbTipoConsulta.Items.Add(("Folio"))
        cmbTipoConsulta.Items.Add(("Clasificación"))
        cmbTipoConsulta.Items.Add(("Solicitante"))
        cmbTipoConsulta.Items.Add(("Departamento"))
        cmbTipoConsulta.Items.Add(("Rango de Fechas"))
        cmbTipoConsulta.Items.Add(("Fecha Vencimiento"))

        'Estructura para darle estilo al Grid () no hagarró el código de CrearEstructuraGridprov()
        Utilerias.DestruirObjeto(DTXML)

        DTXML = New DataTable
        With DTXML
            .Columns.Add("Version", GetType(Integer)).Caption = "Version"
            .Columns.Add("Fecha", GetType(String)).Caption = "Fecha"
            .Columns.Add("Generó", GetType(String)).Caption = "Generó"
            .Columns.Add("MOTIVO", GetType(String)).Caption = "MOTIVO"
        End With

        GridProveedores.DataSource = DTXML
        With Grvprovedores
            .PopulateColumns()
        End With


        myManejador = New ManejadorXtraGridAdvanced(GridProveedores)
        myManejador.Estilo = ManejadorXtraGridAdvanced.Estilos.Seleccion
        Utilerias.FormatearColumnasGrid(Grvprovedores)
        Utilerias.AjustarTamañoColumnasGrid(Grvprovedores)
        Utilerias.ConfigurarColumnasGrid(Grvprovedores)

        Me.ToolBarButtons.Ejecutar = True
        Me.ToolBarButtons.EnvExcel = True
    End Sub
    Protected Overrides Sub ClickBotonEjecutar()
        MyBase.ClickBotonEjecutar()

        Try
            If atxCodigo.Text.Trim <> "" Then
                plCargarDatos(atxCodigo.Text.Trim)

                Me.ToolBarButtons.Ejecutar = True
                Me.ToolBarButtons.Guardar = True
            Else
                MuestraMensaje("Debes Proporcionar un Número de Contrato", MessageBoxIcon.Information)
                atxCodigo.Focus()

            End If


        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub plCargarDatos(prmSol As Integer)
        Dim dt As DataTable

        dt = FabricaJuridicoJosue.FgConsulta_BitacoraHistdt(prmSol)

        GridProveedores.DataSource = DTXML
        If dt.Rows.Count > 0 Then
            GridProveedores.DataSource = dt

            For i = 0 To dt.Rows.Count - 1
                Grvprovedores.SetRowCellValue(i, Grvprovedores.Columns(0), dt(i)("Version"))
                Grvprovedores.SetRowCellValue(i, Grvprovedores.Columns(1), dt(i)("Fecha"))
                Grvprovedores.SetRowCellValue(i, Grvprovedores.Columns(2), dt(i)("Generó"))
                Grvprovedores.SetRowCellValue(i, Grvprovedores.Columns(3), dt(i)("MOTIVO"))
            Next
        End If

        Grvprovedores.PopulateColumns()
        Grvprovedores.RefreshData()

        myManejador = New ManejadorXtraGridAdvanced(GridProveedores)
        myManejador.Estilo = ManejadorXtraGridAdvanced.Estilos.Seleccion
        Utilerias.FormatearColumnasGrid(Grvprovedores)
        Utilerias.AjustarTamañoColumnasGrid(Grvprovedores)
        Utilerias.ConfigurarColumnasGrid(Grvprovedores)
        myDTS = FabricaJuridicoJosue.FgConsulta_BitacoraHist(prmSol)
    End Sub
    Private Sub cmbTipoConsulta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoConsulta.SelectedIndexChanged
        If cmbTipoConsulta.SelectedIndex = 0 Then
            grbFolio.Enabled = True
            grbClasificacion.Enabled = False
            grboxRangoFechas.Enabled = False
            grbSolicitante.Enabled = False
            grbDepartamento.Enabled = False
        End If

        If cmbTipoConsulta.SelectedIndex = 1 Then
            grbFolio.Enabled = False
            grbClasificacion.Enabled = True
            grboxRangoFechas.Enabled = False
            grbSolicitante.Enabled = False
            grbDepartamento.Enabled = False
        End If

        If cmbTipoConsulta.SelectedIndex = 2 Then
            grbFolio.Enabled = False
            grbClasificacion.Enabled = False
            grboxRangoFechas.Enabled = False
            grbSolicitante.Enabled = True
            grbDepartamento.Enabled = False
        End If

        If cmbTipoConsulta.SelectedIndex = 3 Then
            grbFolio.Enabled = False
            grbClasificacion.Enabled = False
            grboxRangoFechas.Enabled = False
            grbSolicitante.Enabled = False
            grbDepartamento.Enabled = True
        End If

        If cmbTipoConsulta.SelectedIndex = 4 Or cmbTipoConsulta.SelectedIndex = 5 Then
            grbFolio.Enabled = False
            grbClasificacion.Enabled = False
            grboxRangoFechas.Enabled = True
            grbSolicitante.Enabled = False
            grbDepartamento.Enabled = False

            DTPFechaini.Enabled = True

            If cmbTipoConsulta.SelectedIndex = 5 Then
                DTPFechaini.Enabled = False
            End If
        End If


    End Sub

    Public Shared Sub ValidarTeclearSoloNumeroEntero(ByRef sender As Object, ByRef e As KeyPressEventArgs)
        If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8) AndAlso Not e.KeyChar = Chr(13)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub atxCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles atxCodigo.KeyPress
        ValidarTeclearSoloNumeroEntero(sender, e)

        'If atxCodigo.Text.Trim <> "" Then
        '    If e.KeyChar = Convert.ToChar(Keys.Enter) Then
        '        plCargarDatos(CInt(atxCodigo.Text.Trim))
        '    End If
        'Else
        '    MuestraMensaje("Debes Proporcionar un Número de Contrato", MessageBoxIcon.Information)
        'End If
    End Sub
End Class