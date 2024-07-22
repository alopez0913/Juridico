Imports Tools.Comun.Tools
Imports ADSUM
Imports Juridico.Dominio
Imports DevExpress.XtraGrid.Views.Grid

Public Class FrmM2701005

#Region "Declaraciones"
    'Public ADDA = AsistenteDeDatos_Base.DevuelveInstancia
    Private ADDA As AsistenteDeDatos_Base
    Private WithEvents MXGrdDocumentosRequeridos As ManejadorXtraGridAdvanced

    Private DTDocumentos As DataTable
    Private DTDocumentosRes As DataTable

#End Region

#Region "Eventos"
    Private Sub FrmM2701003_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me.ToolBarButtons
            .Nuevo = True
            .Guardar = True
            .Borrar = False
            .EnvExcel = False
            .Ejecutar = True
            .Imprimir = False
            .Graficar = False
            .Autorizar = False
            .Herramientas = False
            .Invertir = False
            .Cambio_Password = True
        End With

        MXGrdDocumentosRequeridos = New ManejadorXtraGridAdvanced(grdDocumentosRequeridos)
        MXGrdDocumentosRequeridos.Estilo = ManejadorXtraGridAdvanced.Estilos.Captura 

        PlInicializaCatalogos()

        plConsultarDocumentos()
    End Sub

    Private Sub AtxIdContrato_CambioElemento(sender As Object, e As SelectedElementArgs) Handles AtxIdContrato.CambioElemento

        Try
            If AtxIdContrato.Text.Trim = "" Then Return

            If e.Valor Is Nothing OrElse Not IsNumeric(e.Valor) OrElse CInt(e.Valor) = 0 Then
                If AtxIdContrato.Text.Trim <> "" And AtxIdContrato.Text.Trim <> "*" Then
                    MuestraMensaje("Codigo de contrato no existe o esta inactivo, verifique por favor", MessageBoxIcon.Exclamation)
                    AtxIdContrato.Enabled = True
                    AtxIdContrato.Text = ""
                    AtxIdContrato.Focus()
                    'bNuevo = False
                Else
                    'Nuevo registro
                    AtxIdContrato.Text = "*"
                    AtxIdContrato.Enabled = False
                    'Me.ToolBarButtons.Guardar = True
                End If
            Else

                If AtxIdContrato.Text = AtxIdContrato.Tag Then
                    AtxIdContrato.Tag = ""
                    Exit Sub
                End If

                If e.Row IsNot Nothing Then
                    'Pintar datos en los controles de pantalla 
                    AtxIdContrato.Tag = e.Valor
                    '  								bActivo
                    AtxDescripcion.Text = e.Row!Contrato
                    AtxIdContrato.Enabled = False

                    plConsultarDocumentosDelContrato(AtxIdContrato.Text.Trim)

                    'Me.ToolBarButtons.Guardar = True
                    'Me.ToolBarButtons.Borrar = True
                    ' bNuevo = False
                Else
                    AtxIdContrato.Tag = ""
                    AtxIdContrato.Text = ""
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub grvDocumentosRequeridos_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles grvDocumentosRequeridos.RowCellClick
        Dim nIdOCGenerada As Integer = 0
        Dim nFolioOC As Integer = 0
        Dim vlSeRegresa As Boolean = False
        Dim vlSeCancela As Boolean = False
        Try
            Select Case e.Column.FieldName
                'Case Is = "bRequerido"

                '    grvDocumentosRequeridos.SetRowCellValue(e.RowHandle, grvDocumentosRequeridos.Columns("bRequerido"), Not e.CellValue)
                '    grvDocumentosRequeridos.SetRowCellValue(e.RowHandle, grvDocumentosRequeridos.Columns("bOpcional"), False) 'Not e.CellValue

                'Case Is = "bOpcional"
                '    grvDocumentosRequeridos.SetRowCellValue(e.RowHandle, grvDocumentosRequeridos.Columns("bOpcional"), Not e.CellValue)
                '    grvDocumentosRequeridos.SetRowCellValue(e.RowHandle, grvDocumentosRequeridos.Columns("bRequerido"), False) 'Not e.CellValue

                Case Else

            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "Procedimientos"
    Private Sub PlInicializaCatalogos()
        ''lamado a metacatalogo
        AtxIdContrato.CatalogoBase = New Catalogo(New MetaCatalogo("JUR_GrupoContratoSubActos"))
    End Sub

    Private Sub PlLimpiar()
        AtxDescripcion.Text = ""
        AtxIdContrato.Text = ""
        AtxIdContrato.Enabled = True
        AtxIdContrato.Focus()

        CrearEstructuraDocumentos()
        plConsultarDocumentos()

    End Sub

    Private Sub CrearEstructuraDocumentos()

        Utilerias.DestruirObjeto(DTDocumentos)

        DTDocumentos = New DataTable
        With DTDocumentos
            .Columns.Add("nIDReq", GetType(Integer)).Caption = "IdReq"
            .Columns.Add("cDescripcion", GetType(String)).Caption = "Documento"
            .Columns.Add("cEstado", GetType(String)).Caption = "Estado"

        End With

        grdDocumentosRequeridos.DataSource = DTDocumentos

        With grvDocumentosRequeridos

            .PopulateColumns()
            'COLUMNA OCULTA
        End With

    End Sub

    Private Sub plConsultarDocumentos()
        Try
            Utilerias.DestruirObjeto(DTDocumentos)
            CrearEstructuraDocumentos()

            DTDocumentosRes = Dominio.FabricaJuridico.ObtenerDocumentacionSolicitable()

            If DTDocumentosRes.Rows.Count > 0 Then
                DTDocumentos.Merge(DTDocumentosRes, False, MissingSchemaAction.Ignore)

                grdDocumentosRequeridos.DataSource = DTDocumentos

                With grvDocumentosRequeridos
                    .PopulateColumns()
                    'COLUMNA OCULTA
                End With

                plConfiguraGrid

                Utilerias.FormatearColumnasGrid(grvDocumentosRequeridos)
                Utilerias.AjustarTamañoColumnasGrid(grvDocumentosRequeridos)

            Else
                MuestraMensaje("No se encontro información de Documentación solicitable", MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub plConsultarDocumentosDelContrato(prt_nIdContrato As Integer)
        Try
            Utilerias.DestruirObjeto(DTDocumentos)
            CrearEstructuraDocumentos()

            DTDocumentosRes = Dominio.FabricaJuridico.ObtenerDocumentacionContrato(prt_nIdContrato)

            If DTDocumentosRes.Rows.Count > 0 Then
                DTDocumentos.Merge(DTDocumentosRes, False, MissingSchemaAction.Ignore)

                grdDocumentosRequeridos.DataSource = DTDocumentos
                With grvDocumentosRequeridos
                    .PopulateColumns()
                    'COLUMNA OCULTA
                End With

                plConfiguraGrid()

                Utilerias.FormatearColumnasGrid(grvDocumentosRequeridos)
                Utilerias.AjustarTamañoColumnasGrid(grvDocumentosRequeridos)

                'With grvDocumentosRequeridos.OptionsSelection
                '    .EnableAppearanceFocusedCell = False
                '    .EnableAppearanceFocusedRow = False
                '    .EnableAppearanceHideSelection = False
                'End With

            Else
                MuestraMensaje("No se encontro información de Documentación solicitable", MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub plConfiguraGrid()
        Dim xEstado As New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        xEstado.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        xEstado.Items.Clear()
        xEstado.Items.Add("1-Opcional")
        xEstado.Items.Add("2-Requerido")
        xEstado.Items.Add("")

        grdDocumentosRequeridos.RepositoryItems.Add(xEstado)

        grvDocumentosRequeridos.Columns("cEstado").ColumnEdit = xEstado
        grvDocumentosRequeridos.Columns("nIDReq").OptionsColumn.AllowEdit = False
        grvDocumentosRequeridos.Columns("cDescripcion").OptionsColumn.AllowEdit = False
        grvDocumentosRequeridos.Columns("nIDReq").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
        grvDocumentosRequeridos.Columns("cDescripcion").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
        grvDocumentosRequeridos.Columns("cEstado").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
    End Sub

#End Region

#Region "Overrides"
    Protected Overrides Sub ClickBotonNuevo()
        MyBase.ClickBotonNuevo()

        If MensajeConfirmaLimpiarPantalla() = Windows.Forms.DialogResult.No Then Return
        PlLimpiar()
    End Sub

    Protected Overrides Sub ClickBotonGuardar()
        MyBase.ClickBotonGuardar()
        Try
            If Not flValidarDatos() Then Return

            If MensajeConfirmaGuardar() = DialogResult.No Then Return

            If FlGuardar() Then

                PlLimpiar()
            Else
                MuestraMensaje("Ocurrió un Error al momento de guardar.", MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MuestraMensaje("Ocurrió un Error al momento de guardar." & vbCrLf & ex.Message, MessageBoxIcon.Information)
        End Try

    End Sub

    Protected Overrides Sub ClickBotonEjecutar()
        MyBase.ClickBotonEjecutar()
        If AtxIdContrato.Text = "" Then Return
        If MsgBox("¿Desea consultar los docmuentos necesarios para el contrato?", vbYesNo) = Windows.Forms.DialogResult.No Then Return
        Try
            plConsultarDocumentosDelContrato(AtxIdContrato.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

#End Region

#Region "Funciones"
    Private Function FlGuardar() As Boolean
        Dim vOk As Boolean = False
        Dim cEstado As String = ""
        Dim nIDReq As Integer = 0, nValor As Integer = 0
        ADDA = AsistenteDeDatos_Base.DevuelveInstancia

        Try

            If Not ADDA.TieneTransaccionAbierta Then ADDA.AbreTransaccion()

            If Not Dominio.EscribanoJuridico.EliminarDocumentacionPorContrato(AtxIdContrato.Text.Trim) Then
                If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
                Return vOk
            End If

            With grvDocumentosRequeridos
                For i = 0 To .RowCount - 1
                    nIDReq = .GetRowCellValue(i, .Columns("nIDReq"))

                    cEstado = .GetRowCellValue(i, .Columns("cEstado"))
                    If cEstado.Trim = "" Then
                        nValor = 0
                    Else
                        nValor = CInt(cEstado.Substring(0, 1))
                    End If
                    If nValor > 0 Then
                        If Not Dominio.EscribanoJuridico.GuardarListaDocumentoParaContrato(AtxIdContrato.Text.Trim, nIDReq, nValor) Then
                            If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
                            Return vOk
                        End If
                    End If

                Next
            End With

            If ADDA.TieneTransaccionAbierta Then ADDA.CierraTransaccion()
            vOk = True
            Return vOk

        Catch ex As Exception
            If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
            Throw ex
            Return False
        End Try
    End Function

    Private Function flValidarDatos() As Boolean
        Dim vbOk As Boolean = False
        Dim bCapturaGrid As Boolean = False

        If AtxIdContrato.Text.Trim = "" Then
            MuestraMensaje("Debe de seleccionar un contrato antes", MessageBoxIcon.Exclamation)
            Return vbOk
        End If

        If AtxDescripcion.Text.Trim = "" Then
            MuestraMensaje("El contrato debe de tener una descripción", MessageBoxIcon.Exclamation)
            Return vbOk
        End If

        With grvDocumentosRequeridos
            For i = 0 To .RowCount - 1
                If .GetRowCellValue(i, .Columns("cEstado")) <> "" Then
                    bCapturaGrid = True
                    Exit For
                End If
            Next
        End With

        If Not bCapturaGrid Then
            MuestraMensaje("Favor de capturar estatus para al menos un documento", MessageBoxIcon.Exclamation)
            Return vbOk
        End If

        vbOk = True

        Return vbOk

    End Function

#End Region
End Class