Imports ADSUM
Imports Tools.Comun.Tools
Imports DevExpress.XtraGrid.Views.Grid
Imports Juridico.Dominio
Imports DevExpress.XtraGrid.Views

Public Class FrmM2702013    '   Consulta Expedientes

#Region "Declaraciones"
    Private dtDocumentos As DataTable
    Private dtArchivos As DataTable
    Private dtExpedientes As DataTable

    Private dsDatos As DataSet

    Private WithEvents MXAExpedientes As ManejadorXtraGridAdvanced
    Private WithEvents MXADocumentos As ManejadorXtraGridAdvanced
    Private WithEvents MXAArchivos As ManejadorXtraGridAdvanced
#End Region

#Region "Funciones y Procedimientos"

    Private Sub plNuevo(prmEsLoad As Boolean)

        If prmEsLoad Then
            plConfigurarGrid()
            plCrearEstructura()
            InicializarCatalogos()
            plLlenaComboActividad()
        Else
            dtExpedientes.Rows.Clear()
            dtDocumentos.Rows.Clear()
            dtArchivos.Rows.Clear()
            dsDatos = Nothing

            gbActividad.Enabled = False
            gbClienteEmpleado.Enabled = False
            gbFecha.Enabled = False
            rbPorActividad.Checked = False
            rbPorClienteEmpleado.Checked = False
            rbPorFecha.Checked = False

            cmbActividad.SelectedIndex = 0
            atxClienteEmpleado.Text = ""
            lblNombreClienteEmpleado.Text = ""
            dtpInicio.Value = Today
            dtpFin.Value = Today
        End If

        With Me.ToolBarButtons
            .Nuevo = True
            .Guardar = False
            .Borrar = False
            .Imprimir = False
            .Ejecutar = True
            .Autorizar = False
            .Archivos = True
            .EnvExcel = True
            .Graficar = False
            .Invertir = False
        End With
    End Sub

    Private Sub plConfigurarGrid()
        MXAExpedientes = New ManejadorXtraGridAdvanced(grdExpedientes)
        MXADocumentos = New ManejadorXtraGridAdvanced(grdDocumentos)
        MXAArchivos = New ManejadorXtraGridAdvanced(grdArchivos)

        MXAExpedientes.Estilo = Manejador_XtraGrid.Estilos.Seleccion
        MXADocumentos.Estilo = Manejador_XtraGrid.Estilos.Seleccion
        MXAArchivos.Estilo = Manejador_XtraGrid.Estilos.Seleccion
    End Sub

    Private Sub InicializarCatalogos()
        atxClienteEmpleado.CatalogoBase = New Catalogo(New MetaCatalogo("JUR_ExpedientesBancoDatos"))
    End Sub

    Private Sub plCrearEstructura()
        Utilerias.DestruirObjeto(dtExpedientes)
        Utilerias.DestruirObjeto(dtDocumentos)
        Utilerias.DestruirObjeto(dtArchivos)

        dtExpedientes = New DataTable
        With dtExpedientes
            .Columns.Add("Cancelar", GetType(Boolean))
            .Columns.Add("CodCliente", GetType(Integer)).Caption = "Código"
            .Columns.Add("RazonSocial", GetType(String)).Caption = "Nombre / Razón Social"
            .Columns.Add("RFC", GetType(String)).Caption = "RFC"
            .Columns.Add("Ciudad", GetType(String)).Caption = "Ciudad"
            .Columns.Add("FechaCredito", GetType(Date)).Caption = "Fecha Credito"
            .Columns.Add("FechaExpediente", GetType(Date)).Caption = "Fecha Expediente"
            .Columns.Add("Observaciones", GetType(String))
            .Columns.Add("Rubro", GetType(Integer))
            .Columns.Add("NombreRubro", GetType(String)).Caption = "Actividad"
            .Columns.Add("SubRubro", GetType(Integer))
            .Columns.Add("NombreSubRubro", GetType(String)).Caption = "Rubro"
        End With

        dtDocumentos = New DataTable
        With dtDocumentos
            .Columns.Add("CodDocumento", GetType(String)).Caption = "Cod Doc"
            .Columns.Add("NombreDocumento", GetType(String)).Caption = "Nombre Documento"
            .Columns.Add("NumDocumentos", GetType(Integer)).Caption = "Num Docs"
        End With

        dtArchivos = New DataTable
        With dtArchivos
            .Columns.Add("nIDDocumentoDig", GetType(Integer))
            .Columns.Add("nCodDocumento", GetType(Integer)).Caption = "Cod Doc"
            .Columns.Add("nIDDocumento", GetType(Integer))
            .Columns.Add("CodSucursal", GetType(Integer)).Caption = "Cod Sucursal"
            .Columns.Add("Sucursal", GetType(String)).Caption = "Sucursal"
            .Columns.Add("Num", GetType(Integer)).Caption = "Num"
            .Columns.Add("NombreArchivo", GetType(String)).Caption = "Nombre Archivo"
            .Columns.Add("Extencion", GetType(String)).Caption = "Extensión"
            .Columns.Add("Archivo", GetType(Byte()))
            .Columns.Add("DirArchivo", GetType(String))
            .Columns.Add("FechaDocumento", GetType(Date)).Caption = "Fecha Documento"
        End With

        grdExpedientes.DataSource = dtExpedientes
        grdDocumentos.DataSource = dtDocumentos
        grdArchivos.DataSource = dtArchivos

        'COLUMNAS OCULTAS
        grvExpedientes.Columns("Observaciones").Visible = False
        grvExpedientes.Columns("Rubro").Visible = False
        grvExpedientes.Columns("SubRubro").Visible = False

        grvArchivos.Columns("nIDDocumentoDig").Visible = False
        grvArchivos.Columns("nIDDocumento").Visible = False
        grvArchivos.Columns("Archivo").Visible = False
        grvArchivos.Columns("DirArchivo").Visible = False

        Utilerias.ConfigurarColumnasGrid(grvExpedientes)
        Utilerias.ConfigurarColumnasGrid(grvDocumentos)
        Utilerias.ConfigurarColumnasGrid(grvArchivos)
    End Sub

    Private Sub plConsultaDocumentos(prmRubro As Integer, prmSubRubro As Integer, prmCodCliente As Integer)
        Dim dsTemp As DataSet

        Try
            dtDocumentos.Rows.Clear()
            dtArchivos.Rows.Clear()
            dsTemp = FabricaJuridico.ObtenDocumentosBancoDatos(prmRubro, prmSubRubro, prmCodCliente)

            If dsTemp Is Nothing AndAlso prmCodCliente <> -1 Then
                MuestraMensaje("Ocurrio un error al consultar los datos, cierre y abra el sistema y vuelva a intentarlo.", Windows.Forms.MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            dtDocumentos.Merge(dsTemp.Tables(0), False, MissingSchemaAction.Ignore)

            grdDocumentos.DataSource = dtDocumentos
            grdDocumentos.DataMember = dtDocumentos.TableName

            With grvDocumentos
                .Columns("CodDocumento").Width = 75
                .Columns("NombreDocumento").Width = 350
                .Columns("NumDocumentos").Width = 75
            End With

            dsDatos = dsTemp

            Utilerias.FormatearColumnasGrid(grvDocumentos)
            Utilerias.DestruirObjeto(dsTemp)
        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub plConsultaExpedientes()
        Dim vlnTipo As Byte, vlnActividad As Integer, vlnCodigo As Integer = 0
        Dim dsTemp As New DataSet

        Try
            dtExpedientes.Rows.Clear()

            If Not rbPorActividad.Checked And Not rbPorClienteEmpleado.Checked And Not rbPorFecha.Checked Then
                vlnTipo = 0
            Else
                If rbPorActividad.Checked Then
                    If cmbActividad.SelectedIndex = -1 OrElse cmbActividad.SelectedIndex = 0 Then
                        MuestraMensaje("Debe especificar una Actividad", MessageBoxIcon.Warning)

                        Exit Sub
                    End If
                    vlnTipo = 1
                    vlnActividad = cmbActividad.SelectedValue
                ElseIf rbPorClienteEmpleado.Checked Then
                    If atxClienteEmpleado.Text = "" Then
                        MuestraMensaje("Debe especificar una Código valido", MessageBoxIcon.Warning)

                        Exit Sub
                    End If
                    vlnTipo = 2
                    vlnCodigo = atxClienteEmpleado.Text
                Else
                    vlnTipo = 3
                End If
            End If

            Select Case vlnTipo
                Case 0, 1, 2
                    dsTemp = FabricaJuridico.ConsultaExpedientesBancoDatos(vlnTipo, vlnActividad, vlnCodigo)
                Case 3
                    dsTemp = FabricaJuridico.ConsultaExpedientesBancoDatos(vlnTipo, vlnActividad, vlnCodigo, dtpInicio.Value, dtpFin.Value)
            End Select

            If dsTemp Is Nothing Then
                MuestraMensaje("No se encontro información de expedientes", MessageBoxIcon.Information)
                Me.ToolBarButtons.Guardar = False

                Exit Sub
            End If

            dtExpedientes.Merge(dsTemp.Tables(0), False, MissingSchemaAction.Ignore)

            grdExpedientes.DataSource = dtExpedientes
            grdExpedientes.DataMember = dtExpedientes.TableName

            With grvExpedientes
                '.Columns("Autorizar").Width = 55
                .Columns("Cancelar").Width = 55
                .Columns("RazonSocial").Width = 350
                .Columns("RFC").Width = 120
                .Columns("Ciudad").Width = 120
                .Columns("FechaCredito").Width = 120
                .Columns("FechaExpediente").Width = 120
                .Columns("NombreRubro").Width = 150
                .Columns("NombreSubRubro").Width = 150
            End With

            dsDatos = dsTemp

            Utilerias.FormatearColumnasGrid(grvExpedientes)
            Utilerias.DestruirObjeto(dsTemp)

            With grvExpedientes.OptionsSelection
                .EnableAppearanceFocusedCell = False
                '.EnableAppearanceFocusedRow = False
                .EnableAppearanceHideSelection = False
            End With

            Me.ToolBarButtons.Guardar = True
        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub plMuestraArchivos(prmCodDocumento)

        dtArchivos.Rows.Clear()

        If dsDatos.Tables(1).Select("nCodDocumento = " & prmCodDocumento).Count = 0 Then
            Exit Sub
        End If

        dtArchivos.Merge(dsDatos.Tables(1).Select("nCodDocumento = " & prmCodDocumento).CopyToDataTable(), False, MissingSchemaAction.Ignore)

        grdArchivos.DataSource = dtArchivos
        grdArchivos.DataMember = dtArchivos.TableName

        Utilerias.FormatearColumnasGrid(grvArchivos)
        Utilerias.AjustarTamañoColumnasGrid(grvArchivos)
    End Sub

    Public Sub plLlenaComboActividad()
        Dim dtDatos As New DataTable

        dtDatos.Columns.Add(New DataColumn("Codigo", GetType(Integer)))
        dtDatos.Columns.Add(New DataColumn("Descripcion", GetType(String)))

        dtDatos.Rows.Add(0, "<<SELECCIONE>>")
        dtDatos.Rows.Add(1, "PRESTAMOS/CREDITOS MUTUOS")
        dtDatos.Rows.Add(2, "ARRENDAMIENTOS")
        dtDatos.Rows.Add(3, "PRESTACION DE SERVICIOS")

        With cmbActividad
            .DataSource = dtDatos
            .DisplayMember = "Descripcion"
            .ValueMember = "Codigo"
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub PlEnviarExcel()

        Utilerias.ExportarDataSetToExcel(dsDatos)
    End Sub

    Private Function flValidarConsulta() As Boolean
        If rbPorActividad.Checked Then
            If cmbActividad.SelectedIndex = -1 OrElse cmbActividad.SelectedIndex = 0 Then
                MuestraMensaje("Debe especificar una Actividad", MessageBoxIcon.Warning)

                Return False
            End If
        End If

        If rbPorClienteEmpleado.Checked Then
            If atxClienteEmpleado.Text = "" Then
                MuestraMensaje("Debe especificar una Código valido", MessageBoxIcon.Warning)

                Return False
            End If
        End If

        If rbPorFecha.Checked Then
            If (dtpFin.Value < dtpInicio.Value) OrElse (dtpInicio.Value > dtpFin.Value) Then
                MuestraMensaje("La fecha Final no puede ser Menor a la Fecha Inicial", MessageBoxIcon.Warning)

                Return False
            End If
        End If

        Return True
    End Function

    Private Function flValidarGuardar() As Boolean
        If Not dtExpedientes.Select("Cancelar = True").Count > 0 Then
            MuestraMensaje("Debe especificar al menos un expediente cómo Cancelado.", MessageBoxIcon.Exclamation)

            Return False
        End If

        Return True
    End Function

    Private Function flGuardar() As Boolean
        Dim xmlExpedientes = Utilerias.DataTableAXml(dtExpedientes.Select("Cancelar = True").CopyToDataTable())

        Try
            If Not ADDA.TieneTransaccionAbierta Then ADDA.AbreTransaccion()

            If Not EscribanoJuridico.CancelaExpedientes(xmlExpedientes) Then
                If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
                MuestraMensaje("Ocurrio un problema al guardar la información, intente de nuevo.", MessageBoxIcon.Exclamation)

                Return False
            End If

            If ADDA.TieneTransaccionAbierta Then ADDA.CierraTransaccion()

            Return True
        Catch ex As Exception
            If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)

            Return False
        End Try
    End Function

#End Region

#Region "Eventos"
    Private Sub FrmM2702011_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            ADDA = AsistenteDeDatos_Base.DevuelveInstancia()
            plNuevo(True)

            gbActividad.Enabled = False
            gbClienteEmpleado.Enabled = False
            gbFecha.Enabled = False
        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub grvExpedientes_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles grvExpedientes.RowCellClick
        Dim vlRechaza As Boolean = False

        Try
            Select Case e.Column.FieldName
                Case Is = "Cancelar"
                    grvExpedientes.SetRowCellValue(e.RowHandle, grvExpedientes.Columns("Cancelar"), Not e.CellValue)
                    vlRechaza = grvExpedientes.GetRowCellValue(e.RowHandle, grvExpedientes.Columns("Cancelar"))

                    If vlRechaza Then
                        Dim userMsg As String = ""
                        userMsg = Microsoft.VisualBasic.InputBox("¿Cuál es el motivo de cancelación?", "Motivo de Cancelación", "Ingrese su comentario aquí")
                        If userMsg <> "" And userMsg <> "Ingrese su comentario aquí" Then
                            grvExpedientes.SetRowCellValue(e.RowHandle, grvExpedientes.Columns("Observaciones"), userMsg)
                        End If
                    Else
                        grvExpedientes.SetRowCellValue(e.RowHandle, grvExpedientes.Columns("Observaciones"), "")
                    End If
                Case Else
                    plConsultaDocumentos(grvExpedientes.GetRowCellValue(e.RowHandle, grvExpedientes.Columns("Rubro")),
                                            grvExpedientes.GetRowCellValue(e.RowHandle, grvExpedientes.Columns("SubRubro")),
                                            grvExpedientes.GetRowCellValue(e.RowHandle, grvExpedientes.Columns("CodCliente")))
            End Select

            dtExpedientes.AcceptChanges()
        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub grvDocumentos_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles grvDocumentos.RowCellClick
        plMuestraArchivos(grvDocumentos.GetRowCellValue(e.RowHandle, grvDocumentos.Columns("CodDocumento")))
    End Sub

    Private Sub grvArchivos_DoubleClick(sender As Object, e As EventArgs) Handles grvArchivos.DoubleClick
        Dim grv As Grid.GridView = CType(sender, Grid.GridView)
        Dim row As DataRow
        Dim frm As New FrmVisualizarArchivos
        Dim dirArchivo As String
        Dim extencion As String
        Dim nIDDocumento As Long
        Dim bArchivo As Byte()

        Try
            row = grv.GetDataRow(grv.FocusedRowHandle)
            dirArchivo = CStr(row!DirArchivo)
            extencion = CStr(row!Extencion)
            nIDDocumento = CLng(row!nIDDocumento)

            If dirArchivo = "" Then
                dirArchivo = My.Computer.FileSystem.GetTempFileName
                dirArchivo = dirArchivo.Replace(".tmp", "." & extencion)

                bArchivo = FabricaJuridico.ObtenerBinarioDocumento(nIDDocumento, OrigenDocumentosBinarios.Documentos_Digitalizados_BancoDatos)

                IO.File.WriteAllBytes(dirArchivo, bArchivo)
                row!DirArchivo = dirArchivo
                row!Archivo = bArchivo
            End If

            frm.DirArchivo = dirArchivo
            frm.Extencion = extencion

            frm.StartPosition = FormStartPosition.CenterParent
            frm.WindowState = FormWindowState.Maximized
            frm.ShowDialog()
        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
        Finally
            Utilerias.DestruirObjeto(frm)
        End Try
    End Sub

    Private Sub rbPorActividad_Checked(sender As Object, e As EventArgs) Handles rbPorActividad.CheckedChanged
        If sender.Checked = True Then
            gbActividad.Enabled = True
            gbClienteEmpleado.Enabled = False
            gbFecha.Enabled = False

            cmbActividad.SelectedIndex = 0
            plCrearEstructura()
            cmbActividad.Focus()
        Else
            gbActividad.Enabled = False
        End If
    End Sub

    Private Sub rbPorClienteEmpleado_CheckedChanged(sender As Object, e As EventArgs) Handles rbPorClienteEmpleado.CheckedChanged
        If sender.Checked = True Then
            gbClienteEmpleado.Enabled = True
            gbActividad.Enabled = False
            gbFecha.Enabled = False

            atxClienteEmpleado.SetTextBoxValue("")
            lblNombreClienteEmpleado.Text = ""
            plCrearEstructura()
            atxClienteEmpleado.Focus()
        Else
            gbClienteEmpleado.Enabled = False
        End If
    End Sub

    Private Sub rbPorFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbPorFecha.CheckedChanged
        If sender.Checked = True Then
            gbFecha.Enabled = True
            gbActividad.Enabled = False
            gbClienteEmpleado.Enabled = False

            plCrearEstructura()
            dtpInicio.Focus()
        Else
            gbFecha.Enabled = False
        End If
        atxClienteEmpleado.SetTextBoxValue("")
        lblNombreClienteEmpleado.Text = ""
    End Sub

    Private Sub atxClienteEmpleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles atxClienteEmpleado.KeyPress
        ValidaCajaNumerica(sender, e)
    End Sub

    Private Sub atxClienteEmpleado_CambioElemento(sender As Object, e As SelectedElementArgs) Handles atxClienteEmpleado.CambioElemento
        If atxClienteEmpleado.Text.Trim = "" Then Return
        Try
            If atxClienteEmpleado.Text <> "" AndAlso ElementoValidoATX(atxClienteEmpleado) Then
                lblNombreClienteEmpleado.Text = e.Row!RazonSocial

                dtExpedientes.Rows.Clear()
            End If
        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Overrides"
    Protected Overrides Sub ClickBotonNuevo()
        MyBase.ClickBotonNuevo()

        If MensajeConfirmaLimpiarPantalla() = DialogResult.No Then Return

        plNuevo(False)
    End Sub

    Protected Overrides Sub ClickBotonEjecutar()
        MyBase.ClickBotonEjecutar()

        If Not flValidarConsulta() Then Exit Sub

        If Not MuestraMensajeConfirmacion("¿Desea consultar los datos con los filtros especificados?") Then Return

        plConsultaExpedientes()
    End Sub

    Protected Overrides Sub ClickBotonEnvExcel()
        MyBase.ClickBotonEnvExcel()

        Try
            If dsDatos Is Nothing OrElse dsDatos.Tables.Count = 0 OrElse dsDatos.Tables(0).Rows.Count = 0 Then
                MuestraMensaje("No existen Registros en Consulta, verifique", MessageBoxIcon.Information)
            Else
                If Not MuestraMensajeConfirmacion("¿Desea realizar la exportación de la Información?") Then Return
                Utilerias.ExportarDataSetToExcel(dsDatos)
            End If

        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Protected Overrides Sub ClickBotonGuardar()
        MyBase.ClickBotonGuardar()

        If Not flValidarGuardar() Then Return

        If ConfirmaGuardar() = DialogResult.No Then Return

        If flGuardar() Then
            MuestraMensaje("Información guardada con éxito", MessageBoxIcon.Information)
        End If

        plNuevo(False)
    End Sub
#End Region


End Class