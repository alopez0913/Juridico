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

Public Class FrmM2702006

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
        atxProveedor.CatalogoBase = New Catalogo(New MetaCatalogo("CTL_Beneficiarios"))
        atxSubTipoActo.CatalogoBase = New Catalogo(New MetaCatalogo("JUR_GrupocontratoSubActos"))
        atxCodigo.CatalogoBase = New Catalogo(New MetaCatalogo("SolContratos_RenoExt"))
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
        Grvprovedores.Columns("ntipo").Visible = False
        myManejador = New ManejadorXtraGridAdvanced(GridProveedores)
        myManejador.Estilo = ManejadorXtraGridAdvanced.Estilos.Seleccion
        Utilerias.FormatearColumnasGrid(Grvprovedores)
        Utilerias.AjustarTamañoColumnasGrid(Grvprovedores)
        Utilerias.ConfigurarColumnasGrid(Grvprovedores)
    End Sub
    Protected Overrides Sub ClickBotonNuevo()
        MyBase.ClickBotonNuevo()

        Dim DtPersona As New DataTable
        Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
        atxCodigo.Focus()
        txtEstatus.Text = ""
        txtDepartamento.Enabled = True
        txtDepartamento.Text = ""
        txtDepartamento.Enabled = False
        atxProveedor.Text = ""
        txtClave.Text = ""

        quitartotalsuc()

        DtPersona = FabricaJuridicoJosue.FgConsultaNombreLogin(ADDA.GetLoginUsuario)
        txtDepartamento.Enabled = False
        txtClasificacion.Text = ""
        txtSubTipoActo.Enabled = True
        atxSubTipoActo.Text = ""
        atxSubTipoActo.Enabled = False
        txtSubTipoActo.Enabled = False
        txtSolicitante.Text = DtPersona(0)("nombre")
        txtSolicitante.Enabled = False
        DTPFecha.Value = DtPersona(0)("fechahoy")
        DTPFechaFin.Value = DtPersona(0)("fechahoy")
        DTPFechaini.Value = DtPersona(0)("fechahoy")
        DTPFechaFirma.Value = DtPersona(0)("fechahoy")

        If IfNull(DtPersona(0)("Departamento"), "") = "" Then
            txtDepartamento.Enabled = True
            txtDepartamento.Text = IfNull(DtPersona(0)("Departamento"), "")
            txtDepartamento.Enabled = False
        End If

        cmbMoneda.SelectedIndex = -1
        txtEspecificaciones.Text = ""
        txtPenalidades.Text = ""
        txtretro.Text = ""
        txtCantidadPenalidades.Text = ""

        'Estructura para darle estilo al Grid 
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
        Grvprovedores.Columns("ntipo").Visible = False
        myManejador = New ManejadorXtraGridAdvanced(GridProveedores)
        myManejador.Estilo = ManejadorXtraGridAdvanced.Estilos.Seleccion
        Utilerias.FormatearColumnasGrid(Grvprovedores)
        Utilerias.AjustarTamañoColumnasGrid(Grvprovedores)
        Utilerias.ConfigurarColumnasGrid(Grvprovedores)

        For col = 0 To Grvprovedores.Columns.Count - 1
            Grvprovedores.Columns(col).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        ' 152, 158, 157 color gris
        txtColor.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(152, 158, 157))
        cmbMoneda.SelectedIndex = 0
        txtretro.Enabled = False
        btnArchivo.Enabled = False
        btnVerArchivo.Enabled = False


        lblEstatusRenoExt.Text = ""
        lblEstatusRenoExt.BackColor = Color.Gray
        txtCoreo.Text = ""
        txtcorreo2.Text = ""
        cmbSolicitar.SelectedIndex = -1
        atxCodigo.Text = ""
        atxCodigo.Focus()
    End Sub
    Protected Overrides Sub ClickBotonGuardar()
        MyBase.ClickBotonGuardar()

        Try
            Guardar()
        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Function ValidarDatos() As Boolean
        ValidarDatos = True
        If Grvprovedores.RowCount > 0 Then
            Return True
        Else
            MuestraMensaje("Necesitas Capturar Contratante y/o Obligados Solidarios", MessageBoxIcon.Information)
            Return False
        End If


    End Function

    Public Sub Guardar()
        Dim cmon As Integer
        Dim cDepa As Integer
        Dim NuevaSol As Integer
        Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
        Dim dia As String
        Dim mes As String
        Dim año As String
        Dim fechaIni As String
        Dim fechaFin As String
        Dim fechafirma As String
        Dim cclave As String
        Dim subact As Integer
        Dim nactualiza As Integer
        Dim cantmoneda As Decimal
        Dim tiposol As Integer
        Dim existeRen As Integer

        If txtCantidadPenalidades.Text <> "" Then
            cantmoneda = CDec(txtCantidadPenalidades.Text.Trim)
        Else
            cantmoneda = 0.00
        End If

        dia = Mid(DTPFechaini.Value, 1, 2)
        mes = Mid(DTPFechaini.Value, 4, 2)
        año = Mid(DTPFechaini.Value, 7, 4)
        fechaIni = año + mes + dia


        dia = ""
        mes = ""
        año = ""
        dia = Mid(DTPFechaFin.Value, 1, 2)
        mes = Mid(DTPFechaFin.Value, 4, 2)
        año = Mid(DTPFechaFin.Value, 7, 4)
        fechaFin = año + mes + dia

        dia = ""
        mes = ""
        año = ""
        dia = Mid(DTPFechaFirma.Value, 1, 2)
        mes = Mid(DTPFechaFirma.Value, 4, 2)
        año = Mid(DTPFechaFirma.Value, 7, 4)
        fechafirma = año + mes + dia



        Try
            If Not ValidarDatos() Then
                ClickBotonNuevo()
                Exit Sub
            End If

            If cmbMoneda.SelectedItem.ToString <> "" Then
                cmon = CInt(Mid(cmbMoneda.SelectedItem.ToString, 1, 1))
            Else
                cmon = 0
            End If

            If txtDepartamento.Text <> "" Then
                cDepa = CInt(Mid(txtDepartamento.Text, 1, 2))
            Else
                cDepa = 0
            End If

            ' If txtClave.Enabled = True Then
            'If txtClave.Text <> "" Then
            cclave = txtClave.Text
            'Else
            '    cclave = ""
            'End If
            '  End If

            If cmbSolicitar.SelectedIndex = 0 Then
                tiposol = 3
            Else
                tiposol = 2
            End If

            If atxSubTipoActo.Enabled = True Then
                If atxSubTipoActo.Text <> "" Then
                    subact = CInt(atxSubTipoActo.Text)
                Else
                    subact = 0
                End If
            End If

            'Si Se Tiene Un Codigo Se Manda a Actualizar Si No Hay Código Se Guarda Una Solicitud Nueva
            If atxCodigo.Text <> "" And atxCodigo.Text.Trim <> "*" Then
                existeRen = FabricaJuridicoJosue.FgConsultaSolicitudRenovacion(CInt(atxCodigo.Text.Trim))
            End If

            If existeRen > 0 Then
                nactualiza = EscribanoJuridicoJosue.ACtualizaSolRenoExt(fechaIni, fechaFin, fechafirma,
                                         IfNull(txtEspecificaciones.Text.Trim, ""), txtPenalidades.Text.Trim, cmon, cantmoneda, (ADDA.GetLoginUsuario),
                                            IfNull(txtCoreo.Text.Trim, ""), tiposol, CInt(atxCodigo.Text.Trim), IfNull(txtcorreo2.Text.Trim, ""))

                MuestraMensaje("Información Actulizada con Éxito," & vbNewLine & "Solicitud de Contrato: " & nactualiza, MessageBoxIcon.Information)
                ClickBotonNuevo()

                'If nactualiza > 0 Then
                '    nElimina = FabricaJuridicoJosue.FgEliminaContraObliSol_RenoExt(CInt(atxCodigo.Text.Trim))


                '    If nElimina = 1 Then
                '        Dim ntipoins As Integer
                '        If Grvprovedores.RowCount > 0 Then
                '            For i = 0 To Grvprovedores.RowCount - 1
                '                If Grvprovedores.GetRowCellValue(i, Grvprovedores.Columns.ColumnByFieldName("ntipo")) = -1 Then
                '                    ntipoins = 1
                '                Else
                '                    ntipoins = 0
                '                End If

                '                If Grvprovedores.GetRowCellValue(i, Grvprovedores.Columns.ColumnByFieldName("cTipoPersona")) = "Fisica" Then
                '                    nPersona = "F"
                '                Else
                '                    nPersona = "M"
                '                End If

                '                'Se Guardan Contratantes y Obligados Solidarios 
                '                InsertaContra = EscribanoJuridicoJosue.InsertarContraObligadosSol_RenoExt(CInt(atxCodigo.Text.Trim), ntipoins,
                '                                                                                Grvprovedores.GetRowCellValue(i, Grvprovedores.Columns.ColumnByFieldName("cCodProve")),
                '                                                                                    Grvprovedores.GetRowCellValue(i, Grvprovedores.Columns.ColumnByFieldName("cDescProv")),
                '                                                                                    Grvprovedores.GetRowCellValue(i, Grvprovedores.Columns.ColumnByFieldName("cRFC")),
                '                                                                                    Grvprovedores.GetRowCellValue(i, Grvprovedores.Columns.ColumnByFieldName("cTipoPersona")))

                '            Next
                '            MuestraMensaje("Información Actulizada con Éxito," & vbNewLine & "Solicitud de Contrato: " & nactualiza, MessageBoxIcon.Information)
                '            ClickBotonNuevo()
                '        End If
                '    End If
                'End If
            Else
                'Se Guardan Solicitudes de Contrato
                NuevaSol = EscribanoJuridicoJosue.InsertarSolRenoExt(cclave, cDepa, fechaIni, fechaFin, fechafirma,
                                                              subact, IfNull(txtEspecificaciones.Text.Trim, ""), txtPenalidades.Text.Trim, cmon, cantmoneda, IfNull(txtretro.Text.Trim, ""), (ADDA.GetLoginUsuario), IfNull(txtCoreo.Text.Trim, ""), tiposol, CInt(atxCodigo.Text.Trim), IfNull(txtcorreo2.Text.Trim, ""))

                MuestraMensaje("Información almacenada con éxito," & vbNewLine & "Solicitud de Contrato: " & CInt(atxCodigo.Text.Trim), MessageBoxIcon.Information)
                ClickBotonNuevo()

                'If NuevaSol > 0 Then
                '    Dim ntipoins As Integer
                '    If Grvprovedores.RowCount > 0 Then
                '        For i = 0 To Grvprovedores.RowCount - 1
                '            If Grvprovedores.GetRowCellValue(i, Grvprovedores.Columns.ColumnByFieldName("ntipo")) = -1 Then
                '                ntipoins = 1
                '            Else
                '                ntipoins = 0
                '            End If

                '            If Grvprovedores.GetRowCellValue(i, Grvprovedores.Columns.ColumnByFieldName("cTipoPersona")) = "Fisica" Then
                '                nPersona = "F"
                '            Else
                '                nPersona = "M"
                '            End If

                '            'Se Guardan Contratantes y Obligados Solidarios 
                '            InsertaContra = EscribanoJuridicoJosue.InsertarContraObligadosSol(NuevaSol, ntipoins,
                '                                                                            Grvprovedores.GetRowCellValue(i, Grvprovedores.Columns.ColumnByFieldName("cCodProve")),
                '                                                                                Grvprovedores.GetRowCellValue(i, Grvprovedores.Columns.ColumnByFieldName("cDescProv")),
                '                                                                                Grvprovedores.GetRowCellValue(i, Grvprovedores.Columns.ColumnByFieldName("cRFC")),
                '                                                                                Grvprovedores.GetRowCellValue(i, Grvprovedores.Columns.ColumnByFieldName("cTipoPersona")))

                '        Next
                '    End If

                '    'Se manda correo que se levanto una nueva solicitud
                '    '  EnviarCorreo(NuevaSol)

                '    MuestraMensaje("Información almacenada con éxito," & vbNewLine & "Solicitud de Contrato: " & CInt(atxCodigo.Text.Trim), MessageBoxIcon.Information)
                '    ClickBotonNuevo()
                'End If
            End If
        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub llenacomboMoneda()
        Dim dt As New DataTable

        dt = FabricaJuridicoJosue.FgConsultaMon()

        For i As Integer = 0 To dt.Rows.Count - 1
            cmbMoneda.Items.Add(dt.Rows(i)("NombreMoneda"))
        Next
    End Sub
    Private Sub FrmM2702006_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DtPersona As New DataTable
        Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
        DtPersona = FabricaJuridicoJosue.FgConsultaNombreLogin(ADDA.GetLoginUsuario)
        txtDepartamento.Enabled = False
        atxSubTipoActo.Enabled = False
        txtSubTipoActo.Enabled = False
        txtClasificacion.Enabled = False
        txtEstatus.Enabled = False
        txtSolicitante.Text = DtPersona(0)("nombre")
        txtSolicitante.Enabled = False
        DTPFecha.Value = DtPersona(0)("fechahoy")
        DTPFechaFin.Value = DtPersona(0)("fechahoy")
        DTPFechaini.Value = DtPersona(0)("fechahoy")
        DTPFechaFirma.Value = DtPersona(0)("fechahoy")

        DTPFecha.Enabled = False

        If IfNull(DtPersona(0)("Departamento"), "") = "" Then
            txtDepartamento.Text = IfNull(DtPersona(0)("Departamento"), "")
        End If

        llenacomboMoneda()

        InicializarCatalogos()

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
        Grvprovedores.Columns("ntipo").Visible = False
        myManejador = New ManejadorXtraGridAdvanced(GridProveedores)
        myManejador.Estilo = ManejadorXtraGridAdvanced.Estilos.Seleccion
        Utilerias.FormatearColumnasGrid(Grvprovedores)
        Utilerias.AjustarTamañoColumnasGrid(Grvprovedores)
        Utilerias.ConfigurarColumnasGrid(Grvprovedores)

        txtGrupo.Enabled = False
        txtTipoActo.Enabled = False
        txtSubTipoActo.Enabled = False
        txtClave.Enabled = False
        txtColor.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(152, 158, 157))
        txtColor.Enabled = False
        cmbMoneda.SelectedIndex = 0
        txtretro.Enabled = False
        btnArchivo.Enabled = False
        btnVerArchivo.Enabled = False
        atxCodigo.Focus()

        For col = 0 To Grvprovedores.Columns.Count - 1
            Grvprovedores.Columns(col).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        lblEstatusRenoExt.Text = ""
        lblEstatusRenoExt.BackColor = Color.Gray
        atxProveedor.Enabled = False
        GridProveedores.Enabled = False
        cmbSolicitar.Items.Add(("Extención"))
        cmbSolicitar.Items.Add(("Renovación"))
    End Sub

    Private Sub atxProveedor_CambioElemento(sender As Object, e As SelectedElementArgs) Handles atxProveedor.CambioElemento
        Dim ultimorow As Integer

        If validaEntpro = True Then
            validaEntpro = False
            Exit Sub
        End If

        validaEntpro = True
        If atxProveedor.Text <> "" Then

            If e.Row!cTipoPer = "F" Then
                tipopersona = "Física"
            End If

            If e.Row!cTipoPer = "M" Then
                tipopersona = "Moral"
            End If

            ultimorow = Grvprovedores.RowCount
            Grvprovedores.AddNewRow()
            Grvprovedores.FocusedRowHandle = Grvprovedores.RowCount - 1
            Grvprovedores.SetRowCellValue(ultimorow, "ntipo", 0)
            Grvprovedores.SetRowCellValue(ultimorow, "cCodProve", sender.text)
            Grvprovedores.SetRowCellValue(ultimorow, "cDescProv", e.Row!cRazonSocial)
            Grvprovedores.SetRowCellValue(ultimorow, "cRFC", e.Row!cRFC)
            Grvprovedores.SetRowCellValue(ultimorow, "cTipoPersona", tipopersona)
            Grvprovedores.RefreshData()

            myManejador = New ManejadorXtraGridAdvanced(GridProveedores)
            myManejador.Estilo = ManejadorXtraGridAdvanced.Estilos.Seleccion
            Utilerias.FormatearColumnasGrid(Grvprovedores)
            Utilerias.AjustarTamañoColumnasGrid(Grvprovedores)
            Utilerias.ConfigurarColumnasGrid(Grvprovedores)

            For col = 0 To Grvprovedores.Columns.Count - 1
                Grvprovedores.Columns(col).SortMode = DataGridViewColumnSortMode.NotSortable
            Next

            'If Grvprovedores.RowCount > 0 Then
            '    For i As Integer = 0 To Grvprovedores.RowCount
            '        Grvprovedores.FocusedRowHandle = i
            '        If IfNull(Grvprovedores.GetFocusedRowCellValue("cCodProve").ToString, "") = "" Then
            '            Grvprovedores.DeleteSelectedRows()
            '            Exit Sub
            '        End If
            '    Next
            'End If
        End If
    End Sub

    Private Sub atxSubTipoActo_CambioElemento(sender As Object, e As SelectedElementArgs) Handles atxSubTipoActo.CambioElemento
        If atxSubTipoActo.Enabled Then
            If atxSubTipoActo.Text <> "" Then
                txtSubTipoActo.Text = e.Row!cDescSubActo
                txtGrupo.Text = e.Row!cDescGrupo
                txtTipoActo.Text = e.Row!cDescActo
                txtClasificacion.Text = e.Row!cContrato
            End If
        End If
    End Sub

    Private Sub Grvprovedores_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles Grvprovedores.RowCellClick
        Dim valor As Integer
        Dim clave As String

        If e.Column.FieldName = "ntipo" Then
            Grvprovedores.SetRowCellValue(e.RowHandle, Grvprovedores.Columns("ntipo"), Not e.CellValue)
        End If

        If Grvprovedores.RowCount > 0 Then
            For i As Integer = 0 To Grvprovedores.RowCount
                '  Grvprovedores.FocusedRowHandle = i
                valor = Grvprovedores.GetRowCellValue(i, Grvprovedores.Columns.ColumnByFieldName("ntipo"))
                If valor = -1 Then
                    clave = Grvprovedores.GetRowCellValue(i, Grvprovedores.Columns.ColumnByFieldName("cDescProv"))
                    If clave IsNot Nothing Then
                        txtClave.Text = Mid(clave.Trim, 1, 10)
                        Exit Sub

                    End If
                Else
                    txtClave.Text = ""
                End If
            Next
        End If
    End Sub

    Public Sub llenasuc(prmsol As Integer)
        Dim dt As DataTable
        Dim per As String
        validaEntrada = True

        dt = FabricaJuridicoJosue.FgConsultaContraObliSol(prmsol)

        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1
                Grvprovedores.AddNewRow()
                Grvprovedores.FocusedRowHandle = Grvprovedores.RowCount - 1
                Grvprovedores.SetRowCellValue(i, "ntipo", dt(i)("ntipo"))
                Grvprovedores.SetRowCellValue(i, "cCodProve", dt(i)("nCodBene"))
                Grvprovedores.SetRowCellValue(i, "cDescProv", dt(i)("cDescBene"))
                Grvprovedores.SetRowCellValue(i, "cRFC", dt(i)("cRFC"))

                If dt(i)("cTipoPersona") = "F" Then
                    per = "FÍSICA"
                Else
                    per = "MORAL"
                End If
                Grvprovedores.SetRowCellValue(i, "cTipoPersona", per)
                Grvprovedores.RefreshData()
                Grvprovedores.Columns("ntipo").Visible = False
                myManejador = New ManejadorXtraGridAdvanced(GridProveedores)
                myManejador.Estilo = ManejadorXtraGridAdvanced.Estilos.Seleccion
                Utilerias.FormatearColumnasGrid(Grvprovedores)
                Utilerias.AjustarTamañoColumnasGrid(Grvprovedores)
                Utilerias.ConfigurarColumnasGrid(Grvprovedores)
            Next
        End If

        For col = 0 To Grvprovedores.Columns.Count - 1
            Grvprovedores.Columns(col).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    Private Sub atxCodigo_CambioElemento(sender As Object, e As SelectedElementArgs) Handles atxCodigo.CambioElemento
        Dim col1 As Integer
        Dim col2 As Integer
        Dim col3 As Integer
        Dim caux As String
        Dim dt As DataTable
        Dim consul As Integer

        If validaEntrada = True Then
            validaEntrada = False
            Exit Sub
        End If

        If atxCodigo.Text.Trim = "*" Then
            Exit Sub
        End If

        If atxCodigo.Text.Trim <> "" Then
            If CInt(atxCodigo.Text.Trim) > 0 Then
                consul = FabricaJuridicoJosue.FgConsultaExistSol_RenoExt(CInt(atxCodigo.Text.Trim))

                If consul = 0 Then
                    validaEntrada = True
                    MuestraMensaje("No Existe Informacion Con Ese Código", MessageBoxIcon.Information)
                    atxCodigo.Text = ""
                    atxCodigo.Focus()
                    ClickBotonNuevo()
                    Exit Sub
                End If
            End If

            If consul > 0 Then
                consul = 1
            Else
                consul = 0
            End If

            dt = FabricaJuridicoJosue.FgPA_JUR_ConsultaRenoEXT(CInt(atxCodigo.Text.Trim), consul)

            If dt(0) Is Nothing Then
                dt = FabricaJuridicoJosue.FgPA_JUR_ConsultaRenoEXT(CInt(atxCodigo.Text.Trim), 0)
            End If

            If dt(0)("nIDSolContrato") > 0 Then

                txtClave.Text = dt(0)("cClave")
                DTPFecha.Value = dt(0)("dfechasolicitud")
                txtDepartamento.Enabled = True
                If IfNull(dt(0)("cDepartamento"), "") <> "" Then
                    If dt(0)("cDepartamento").trim = "0 .-" Then
                        txtDepartamento.Text = ""
                    Else
                        txtDepartamento.Text = IfNull(dt(0)("cDepartamento"), "")
                    End If
                End If
                txtDepartamento.Enabled = False
                txtEstatus.Enabled = True
                txtEstatus.Text = dt(0)("nIDEstatusSol")
                ' Me.Guardarbtn.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(0, 122, 204))

                If IfNull(dt(0)("cDescColor").trim, "") <> "" Then
                    For i = 0 To Len(dt(0)("cDescColor").trim) - 1
                        caux = Mid(dt(0)("cDescColor").trim, i + 1, 1)
                        If caux = "," Then
                            col1 = CInt(Mid(dt(0)("cDescColor").trim, 1, i))
                            caux = ""
                            For j = i + 1 To Len(dt(0)("cDescColor").trim) - 1
                                caux = Mid(dt(0)("cDescColor").trim, j + 1, 1)
                                If caux = "," Then
                                    col2 = CInt(Mid(dt(0)("cDescColor").trim, i + 2, j - 3))
                                    col3 = CInt(Mid(dt(0)("cDescColor").trim, j + 2, Len(dt(0)("cDescColor").trim)))
                                    Exit For
                                End If
                            Next
                            Exit For
                        End If
                    Next
                End If

                txtColor.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(col1, col2, col3))
                txtCoreo.Text = ""
                If dt(0)("ccorreo") <> "" Then
                    txtCoreo.Text = dt(0)("ccorreo")
                End If
                txtcorreo2.Text = ""
                If IfNull(dt(0)("ccorreo2"), "") <> "" Then
                    txtcorreo2.Text = dt(0)("ccorreo2")
                End If

                txtEstatus.Enabled = False
                DTPFechaini.Value = dt(0)("dfechaini")
                DTPFechaFin.Value = dt(0)("dfechafin")
                DTPFechaFirma.Value = dt(0)("dfechafirma")
                If dt(0)("nSubtipoAct") > 0 Then
                    atxSubTipoActo.Enabled = True
                    atxSubTipoActo.Text = dt(0)("nSubtipoAct")
                    txtClasificacion.Text = dt(0)("clas")
                    atxSubTipoActo.Enabled = False
                    txtClasificacion.Enabled = False
                End If
                txtSolicitante.Text = dt(0)("cUsuario_Registro")
                txtEspecificaciones.Text = dt(0)("cespecificaciones")
                txtPenalidades.Text = dt(0)("cpenalidades")


                Dim aux As String
                    If dt(0)("nmonedapena") > 0 Then
                        For i = 0 To cmbMoneda.Items.Count - 1
                            cmbMoneda.SelectedIndex = i
                            aux = Mid(cmbMoneda.SelectedItem.ToString, 1, 1)
                            If dt(0)("nmonedapena") = CInt(aux) Then
                                Exit For
                            End If
                        Next
                    End If

                txtCantidadPenalidades.Text = dt(0)("ncantpena")
                txtretro.Text = dt(0)("cRetroPropuesta")

                lblEstatusRenoExt.Text = ""
                lblEstatusRenoExt.BackColor = Color.Gray
                cmbSolicitar.SelectedIndex = -1
                If dt(0)("nIDTipoProcesoSol") > 0 Then
                    If dt(0)("nIDTipoProcesoSol") = 2 Or dt(0)("nIDTipoProcesoSol") = 4 Or dt(0)("nIDTipoProcesoSol") = 5 Then
                        cmbSolicitar.SelectedIndex = 1
                        If dt(0)("nIDTipoProcesoSol") = 2 Then
                            lblEstatusRenoExt.Text = ""
                            lblEstatusRenoExt.BackColor = Color.Gray
                        End If

                        If dt(0)("nIDTipoProcesoSol") = 4 Then
                            lblEstatusRenoExt.Text = "Aceptada"
                            lblEstatusRenoExt.BackColor = Color.Green
                        End If
                        If dt(0)("nIDTipoProcesoSol") = 5 Then
                            lblEstatusRenoExt.Text = "Rechazada"
                            lblEstatusRenoExt.BackColor = Color.Red
                        End If
                    End If
                    If dt(0)("nIDTipoProcesoSol") = 3 Or dt(0)("nIDTipoProcesoSol") = 6 Or dt(0)("nIDTipoProcesoSol") = 7 Then
                        cmbSolicitar.SelectedIndex = 0
                        If dt(0)("nIDTipoProcesoSol") = 3 Then
                            lblEstatusRenoExt.Text = ""
                            lblEstatusRenoExt.BackColor = Color.Gray
                        End If
                        If dt(0)("nIDTipoProcesoSol") = 6 Then
                            lblEstatusRenoExt.Text = "Aceptada"
                            lblEstatusRenoExt.BackColor = Color.Green
                        End If
                        If dt(0)("nIDTipoProcesoSol") = 7 Then
                            lblEstatusRenoExt.Text = "Rechazada"
                            lblEstatusRenoExt.BackColor = Color.Red
                        End If
                    End If

                End If

                quitartotalsuc()
                llenasuc(CInt(atxCodigo.Text))
                atxProveedor.Enabled = False
                GridProveedores.Enabled = False
                btnArchivo.Enabled = True

                If Existe_Doc() Then
                    btnVerArchivo.Enabled = True
                End If

            End If
        End If
    End Sub

    Public Function Existe_Doc() As Boolean
        Dim doc As Integer

        doc = FabricaJuridicoJosue.FgExisteDocuContratos(CInt(atxCodigo.Text))

        If doc > 0 Then
            Existe_Doc = True
        Else
            Existe_Doc = False
        End If

    End Function

    Public Shared Function ArchivoABase64(dirArchivo As String) As String
        Return ArchivoABase64(IO.File.ReadAllBytes(dirArchivo))
    End Function
    Public Shared Function ArchivoABase64(bytes() As Byte) As String
        Return Convert.ToBase64String(bytes)
    End Function

    Private Sub btnArchivo_Click(sender As Object, e As EventArgs) Handles btnArchivo.Click
        Dim origen As Integer = 9
        Dim cext As String = "pdf"
        Dim aux As String = "Contrato Num: "
        Dim ruta As String
        Dim a As Byte()
        Dim resul As Integer


        If atxCodigo.Text.Trim <> "" And atxCodigo.Text.Trim <> "*" Then
            aux = aux + atxCodigo.Text.Trim
        End If

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            ruta = OpenFileDialog1.FileName
            a = IO.File.ReadAllBytes(ruta)
            resul = EscribanoJuridicoJosue.InsertarDocuContratos(aux, a)
            If resul > 0 Then
                MuestraMensaje("Se guardo con Exito el Documento", MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub Grvprovedores_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Grvprovedores.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Back) Then
            Grvprovedores.DeleteSelectedRows()
        End If
    End Sub

    Private Sub atxCodigo_Validated(sender As Object, e As EventArgs) Handles atxCodigo.Validated
        If atxCodigo.Text = "" Then
            atxCodigo.Text = "*"
        End If
    End Sub

    Private Sub btnVerArchivo_Click(sender As Object, e As EventArgs) Handles btnVerArchivo.Click
        Dim aBytDocumento() As Byte = Nothing
        Dim fs As FileStream
        Dim dt As DataTable
        Dim ruta As String
        Dim nomdoc As String = ruta + "ContratoNum" + atxCodigo.Text + ".pdf"

        ruta = System.IO.Path.GetTempPath()
        dt = FabricaJuridicoJosue.FgConsultaDocuContratos(CInt(atxCodigo.Text))

        aBytDocumento = dt(0)("RESUL")

        fs = New System.IO.FileStream(nomdoc, System.IO.FileMode.Create)
        fs.Write(aBytDocumento, 0, aBytDocumento.Length)

        Process.Start(nomdoc)
        fs.Close()
    End Sub


    Private Sub EnviarCorreo(nFolio As Integer)
        Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
        Dim cPara As String
        Dim cCC As String
        Dim cAsunto As String
        Dim cMensaje As String
        Dim dt As DataTable
        Dim contraobligados As String
        Dim per As String
        Dim soli As String

        contraobligados = ""
        contraobligados = "Contratantes: " & "<br>"
        dt = FabricaJuridicoJosue.FgConsultaContraObliSol(nFolio)
        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1
                If dt(i)("ntipo") = 1 Then
                    contraobligados = contraobligados + " "
                Else
                    contraobligados = contraobligados + " Obligado Solidario: "
                End If

                contraobligados = contraobligados + dt(i)("cDescBene")
                'contraobligados = contraobligados + " Código de Beneficiario: " + CStr(dt(i)("nCodBene"))
                'contraobligados = contraobligados + " Nombre:  " + dt(i)("cDescBene")


                If dt(i)("cTipoPersona") = "F" Then
                    per = "FÍSICA"
                Else
                    per = "MORAL"
                End If

                contraobligados = contraobligados + " Persona: " + per
                contraobligados = contraobligados + "   RFC: " + dt(i)("cRFC") + " <br>"

            Next
        End If

        If cmbSolicitar.SelectedIndex = 0 Then soli = "Extension"
        If cmbSolicitar.SelectedIndex = 1 Then soli = "Renovación"

        'cPara = "derechocorp@adelnor.com"
        cPara = "jzazueta@adelnor.com"
        cCC = txtCoreo.Text.Trim

        cAsunto = " Solicitud De " & soli & " De Contrato Num: " & nFolio & " de la Empresa: " & ADDA.NombreCortoEmpresa

        cMensaje = txtSolicitante.Text.Trim & " Del departamento de : " & IfNull(txtDepartamento.Text.Trim, "") & " ha generado la solicitud de " & soli & " de contrato num: " & nFolio & " de la Empresa: " & ADDA.NombreCortoEmpresa & " <br><br>"
        ' cMensaje = cMensaje & "Solicitante: " & txtSolicitante.Text.Trim & " Del Departamento de : " & IfNull(txtDepartamento.Text.Trim, "") & "<br><br> "
        cMensaje = cMensaje & contraobligados & " <br>"
        cMensaje = cMensaje & "Esta disponible para seguimiento y clasificación. <br><br> Saludos.  <br><br><br><br><br><br>"

        Dim vCorreo As New clsEnviarEmail
        With vCorreo
            .Nombre = "Envío Automático del Sistema de Juridico de Contratos"
            .Para = cPara
            .ConCopia = cCC
            .Asunto = cAsunto
            .Mensaje = cMensaje
            .Enviar_Correo()
        End With
    End Sub
End Class