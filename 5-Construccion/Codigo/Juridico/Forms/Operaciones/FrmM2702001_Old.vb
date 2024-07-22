Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports ADSUM
Imports Juridico.Dominio
Imports Tools.Comun.Tools

Public Class FrmM2702001_Old

#Region "Declaraciones"
    Private WithEvents MXContratantes As ManejadorXtraGridAdvanced
    Protected gnFolioSolicitud As Integer

    Private ADDA As AsistenteDeDatos_Base
    Private drDatosSolicitud As DataRow
    Private dtContratantes As DataTable
    Private dtArchivo As DataTable
    Dim dsDatos As DataSet

    Private gbPreguntaCerrarPantalla As Boolean = True
    Private vcMensaje As String

#End Region

#Region "Funciones y Procedimientos"

    Private Sub plNuevo(EsLoad As Boolean)
        If EsLoad Then
            plCrearEstructuraGrid()
            plCrearEstructuraArchivo()
            plConfigurarGrid()
            plConfiguraCatalogos()
            plLlenacomboMoneda()
        Else
            ATXFolio.Enabled = True
            ATXFolio.Text = ""
            ATXFolio.Tag = ""

            lblStatus.Visible = False
            lblVigencia.Text = ""
            lblVigencia.Visible = False

            lblNombreSolicitante.Text = ""
            lblNombreDepartamento.Text = ""
            lblNombreJefe.Text = ""
            lblDepartamentoJefe.Text = ""

            ATXProveedor.Text = ""
            lblClave.Text = ""

            ATXCorreo.Text = ""
            ATXCorreo2.Text = ""
            lblNombreClasificacion.Text = ""

            lblFecha.Text = ADDA.RegresaFechaDelSistema
            dtpFechaini.Value = DateTime.Now
            dtpFechaFin.Value = dtpFechaini.Value.AddYears(1)
            dtpFechaFirma.Value = dtpFechaini.Value.AddMonths(1)

            ATXEspecificaciones.Text = ""
            cmbMoneda.SelectedValue = 1
            ATXCantidadPenalidades.Text = Format(0, "$###,###,##0.00")
            ATXPenalidades.Text = ""
            lblRetroalimentacion.Text = ""
            gpoRetroalimentacion.Visible = False

            btnCargaArchivo.Enabled = False
            btnVerArchivo.Enabled = False

            plCargarDatos(-1)
            drDatosSolicitud = Nothing
            gnFolioSolicitud = 0

            With Me.ToolBarButtons
                .Guardar = False
                .Borrar = False
                .Imprimir = False
                .EnvExcel = False
                .Graficar = False
                .Ejecutar = False
                .Nuevo = True
            End With

            ATXFolio.Focus()
        End If
    End Sub

    Private Sub plConfigurarGrid()
        MXContratantes = New ManejadorXtraGridAdvanced(grdProveedores)
        MXContratantes.Estilo = ManejadorXtraGridAdvanced.Estilos.Seleccion
    End Sub

    Private Sub plConfiguraCatalogos()
        ATXFolio.CatalogoBase = New Catalogo(New MetaCatalogo("JUR_SolicitudesSinClasifica"))
        ATXFolio.FiltroExtendido = "cUsuario_Registro='" & ADDA.GetLoginUsuario & "'"
        ATXProveedor.CatalogoBase = New Catalogo(New MetaCatalogo("JUR_Beneficiarios"))
    End Sub

    Private Sub plCrearEstructuraGrid()
        Utilerias.DestruirObjeto(dtContratantes)

        dtContratantes = New DataTable
        With dtContratantes
            .Columns.Add("nIDSolContrato", GetType(Integer))
            .Columns.Add("ntipo", GetType(Integer))
            .Columns.Add("nCodBene", GetType(Integer)).Caption = "Código"
            .Columns.Add("cDescBene", GetType(String)).Caption = "Nombre Beneficiario"
            .Columns.Add("cRFC", GetType(String)).Caption = "RFC"
            .Columns.Add("cTipoPersona", GetType(String)).Caption = "Tipo Persona"
        End With

        grdProveedores.DataSource = dtContratantes

        Utilerias.CargarColumnasGrid(grvProveedores, {"nIDSolContrato", "ntipo"}, True)
        Utilerias.ConfigurarColumnasGrid(grvProveedores)
    End Sub

    Private Sub plCrearEstructuraArchivo()
        Utilerias.DestruirObjeto(dtArchivo)

        dtArchivo = New DataTable

        dtArchivo.Columns.Add("nNumImg", GetType(Integer))
        dtArchivo.Columns.Add("cNombreImg", GetType(String))
        dtArchivo.Columns.Add("cExtension", GetType(String))
        dtArchivo.Columns.Add("bArchivo", GetType(Byte()))
    End Sub

    Private Sub plConsultaDatosdelEmpleado(prmLogin As String)
        Dim vDt As DataTable

        vDt = FabricaJuridico.ObtenDatosdelEmpleado(prmLogin)

        For Each vDRow As DataRow In vDt.Rows
            lblNombreSolicitante.Text = vDRow("cNombreEmpleado")
            lblNombreDepartamento.Text = vDRow("cNombreDepartamento")
            ATXCorreo.Text = vDRow("cCorreoEmpleado")
            lblNombreJefe.Text = vDRow("cNombreJefe")
            lblDepartamentoJefe.Text = vDRow("cDepartamentoJefe")
            ATXCorreo2.Text = vDRow("cCorreoJefe")

            'ATXCorreo.Text = vDRow("cCorreoEmpleado")
            'ATXCorreo2.Text = vDRow("cCorreoJefe")
        Next
    End Sub

    Private Sub plCargarDatos(prmFolioSol As Integer)
        Dim dsTemp As DataSet

        dsTemp = FabricaJuridico.ObtenBeneficiarios(prmFolioSol)

        If dsTemp Is Nothing AndAlso prmFolioSol <> -1 Then
            MuestraMensaje("Ocurrio un error al consultar los datos, cierre y abra el sistema y vuelva a intentarlo.", Windows.Forms.MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        With dsTemp.Tables(0)
            .Columns("nIDSolContrato").Caption = "IdContrato"
            .Columns("ntipo").Caption = "Tipo"
            .Columns("nCodBene").Caption = "Código"
            .Columns("cDescBene").Caption = "Nombre Beneficiario"
            .Columns("cRFC").Caption = "RFC"
            .Columns("cTipoPersona").Caption = "Tipo Persona"
        End With

        grdProveedores.DataSource = dsTemp
        grdProveedores.DataMember = dsTemp.Tables(0).TableName
        Utilerias.CargarColumnasGrid(grvProveedores, {"nIDSolContrato", "ntipo"}, True)

        dsDatos = dsTemp

        Utilerias.ConfigurarColumnasGrid(grvProveedores)
        Utilerias.DestruirObjeto(dsTemp)
    End Sub

    Private Sub plObtenBeneficiario(prmCodBeneficiario As String, prmTipoBeneficiario As String)
        Dim vDt As DataTable

        vDt = FabricaJuridico.ObtenBeneficiario(prmCodBeneficiario, prmTipoBeneficiario)

        For Each vDRow As DataRow In vDt.Rows
            Dim ultimorow As Integer

            ultimorow = grvProveedores.RowCount
            grvProveedores.AddNewRow()
            grvProveedores.FocusedRowHandle = grvProveedores.RowCount - 1
            grvProveedores.SetRowCellValue(ultimorow, "ntipo", 1)
            grvProveedores.SetRowCellValue(ultimorow, "nCodBene", vDRow("nBeneficiario"))
            grvProveedores.SetRowCellValue(ultimorow, "cDescBene", vDRow("cRazonSocial"))
            grvProveedores.SetRowCellValue(ultimorow, "cRFC", vDRow("cRFC"))
            grvProveedores.SetRowCellValue(ultimorow, "cTipoPersona", vDRow("cTipoPersona"))
            grvProveedores.RefreshData()

            For col = 0 To grvProveedores.Columns.Count - 1
                grvProveedores.Columns(col).SortMode = DataGridViewColumnSortMode.NotSortable
            Next

            If grvProveedores.RowCount > 0 Then
                lblClave.Text = Mid(grvProveedores.GetRowCellValue(0, grvProveedores.Columns.ColumnByFieldName("cDescBene")), 1, 10)
            End If
        Next
    End Sub

    Private Function flValidar() As Boolean
        If ATXFolio.Text.Trim = "" Then
            MuestraMensaje("Debe ingresar un folio de solicitud valido.", MessageBoxIcon.Exclamation)

            Return False
        End If

        If grvProveedores.RowCount = 0 Then
            MuestraMensaje("Debe especificar al menos 1 beneficiario/proveedor.", MessageBoxIcon.Exclamation)
            ATXProveedor.Focus()

            Return False
        End If

        If Not ValidaEMail(ATXCorreo.Text.Trim) OrElse Not ValidaEMail(ATXCorreo2.Text.Trim) Then
                MuestraMensaje("Dirección o direcciones de correo no validas.", MessageBoxIcon.Exclamation)
                ATXCorreo.Focus()

                Return False
            End If

        If ATXEspecificaciones.Text.Trim = "" Then
            MuestraMensaje("Debe indicar las especificaciones del contrato.", MessageBoxIcon.Exclamation)
            ATXEspecificaciones.Focus()

            Return False
        End If

        Return True
    End Function

    Private Function flValidarBorrar() As Boolean
        Dim dtTemp As DataTable

        dtTemp = FabricaJuridico.ObtenDocumentosDigitalizadosCliente(ATXFolio.Text)

        If dtTemp.Rows.Count <> 0 Then
            MuestraMensaje("El folio de solicitud cuenta con documentos capturados, no es posible realizar la cancelación.", MessageBoxIcon.Exclamation)

            Return False
        End If

        Return True
    End Function

    Private Function flGuardar() As Boolean
        Dim xmlGuarda As String = ""

        Dim item As String = "<GuardaSolicitud dFechaSolicitud=""{0}"" cClave=""{1}"" cDepartamento=""{2}"" nIDEstatusSol=""{3}"" dFechaIni=""{4}"" dFechaFin=""{5}"" dFechaFirma=""{6}"" 
                                                cEspecificaciones=""{7}"" cPenalidades=""{8}"" nMonedapena=""{9}"" nCantPena=""{10}"" cRetroPropuesta=""{11}"" cCorreo=""{12}"" bActivo=""{13}"" 
                                                cCorreo2=""{14}""/>"
        Dim vlClave As String = lblClave.Text.Replace(" ", "").Trim
        vlClave = vlClave.Replace("&", "&amp;")
        vlClave = vlClave.Replace("""", "&quot;")
        vlClave = vlClave.Replace("'", "''")

        xmlGuarda &= String.Format(item, FechaEnFormatoYYYYMMDD(lblFecha.Text), vlClave, "0", "1", FechaEnFormatoYYYYMMDD(dtpFechaini.Value), FechaEnFormatoYYYYMMDD(dtpFechaFin.Value),
                                         FechaEnFormatoYYYYMMDD(dtpFechaFirma.Value), ATXEspecificaciones.Text.Trim, ATXPenalidades.Text.Trim, cmbMoneda.SelectedValue, IfVacio(CDec(ATXCantidadPenalidades.Text.Trim), "0.00"),
                                         IIf(String.IsNullOrEmpty(lblRetroalimentacion.Text), "", lblRetroalimentacion.Text), ATXCorreo.Text.Trim, "1", ATXCorreo2.Text.Trim)

        Try
            If ATXFolio.Text = "*" Then

                If Not ADDA.TieneTransaccionAbierta Then ADDA.AbreTransaccion()

                gnFolioSolicitud = EscribanoJuridico.GuardaSolicitud(xmlGuarda)

                If gnFolioSolicitud > 0 Then

                    'Se Guardan Contratantes y Obligados Solidarios 
                    For i = 0 To grvProveedores.RowCount - 1
                        EscribanoJuridicoJosue.InsertarContraObligadosSol(gnFolioSolicitud, 0,
                                                                          grvProveedores.GetRowCellValue(i, grvProveedores.Columns.ColumnByFieldName("nCodBene")),
                                                                          grvProveedores.GetRowCellValue(i, grvProveedores.Columns.ColumnByFieldName("cDescBene")),
                                                                          grvProveedores.GetRowCellValue(i, grvProveedores.Columns.ColumnByFieldName("cRFC")),
                                                                          grvProveedores.GetRowCellValue(i, grvProveedores.Columns.ColumnByFieldName("cTipoPersona")))
                    Next

                    If dtArchivo.Rows.Count > 0 Then
                        For Each row As DataRow In dtArchivo.Rows
                            If Not EscribanoJuridicoJosue.InsertarDocuContratos("Contrato Num: " + gnFolioSolicitud.ToString, row("bArchivo")) Then
                                If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
                                MuestraMensaje("Ocurrió un problema al intentar guardar el archivo de la solicitud", MessageBoxIcon.Information)

                                Return False
                            End If
                        Next
                    End If

                    If ADDA.TieneTransaccionAbierta Then ADDA.CierraTransaccion()
                    MuestraMensaje("Solicitud guardada con éxito. Folio #" & gnFolioSolicitud, MessageBoxIcon.Information)

                    Return True
                End If
            Else
                If Not EscribanoJuridico.EliminaArchivoSolicitud(ATXFolio.Text.Trim) Then
                    If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
                    MuestraMensaje("Ocurrió un problema al intentar actualizar el archivo de la solicitud", MessageBoxIcon.Information)

                    Return False
                End If

                gnFolioSolicitud = EscribanoJuridico.ActualizaSolicitud(xmlGuarda, ATXFolio.Text)

                'Se Guardan Contratantes y Obligados Solidarios 
                For i = 0 To grvProveedores.RowCount - 1
                    EscribanoJuridicoJosue.InsertarContraObligadosSol(gnFolioSolicitud, 0,
                                                                          grvProveedores.GetRowCellValue(i, grvProveedores.Columns.ColumnByFieldName("nCodBene")),
                                                                          grvProveedores.GetRowCellValue(i, grvProveedores.Columns.ColumnByFieldName("cDescBene")),
                                                                          grvProveedores.GetRowCellValue(i, grvProveedores.Columns.ColumnByFieldName("cRFC")),
                                                                          grvProveedores.GetRowCellValue(i, grvProveedores.Columns.ColumnByFieldName("cTipoPersona")))
                Next

                With dtArchivo
                    For Each row As DataRow In .Rows
                        If Not EscribanoJuridicoJosue.InsertarDocuContratos("Contrato Num: " + ATXFolio.Text.Trim, row("bArchivo")) Then
                            If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
                            MuestraMensaje("Ocurrió un problema al intentar guardar el archivo de la solicitud", MessageBoxIcon.Information)

                            Return False
                        End If
                    Next
                End With

                If ADDA.TieneTransaccionAbierta Then ADDA.CierraTransaccion()

                MuestraMensaje("Solicitud actualizada con éxito. Folio #" & gnFolioSolicitud, MessageBoxIcon.Information)

                Return True
            End If

            If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()

            Return False
        Catch ex As Exception
            If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
            MuestraMensaje(ex.Message, Windows.Forms.MessageBoxIcon.Error)

            Return False
        End Try
    End Function

    Private Function flCancelar() As Boolean
        If EscribanoJuridico.CancelaSolicitud(ATXFolio.Text) Then
            MuestraMensaje("Solicitud de contrato cancelada correctamente", MessageBoxIcon.Information)
            plEnviaCorreoCancelacion(ATXFolio.Text)

            Return True
        End If

        Return False
    End Function

    Public Sub plLlenacomboMoneda()
        Dim dt As New DataTable

        dt.Columns.Add(New DataColumn("Codigo", GetType(Integer)))
        dt.Columns.Add(New DataColumn("Descripcion", GetType(String)))

        dt.Rows.Add(1, "1.- PESOS")
        dt.Rows.Add(2, "2.- DOLARES")
        dt.Rows.Add(3, "3.- EUROS")

        dt.AcceptChanges()

        cmbMoneda.DataSource = dt
        cmbMoneda.DisplayMember = "Descripcion"
        cmbMoneda.ValueMember = "Codigo"
    End Sub

    Public Function Existe_Doc() As Boolean
        Dim doc As Integer

        doc = FabricaJuridicoJosue.FgExisteDocuContratos(CInt(ATXFolio.Text))

        If doc > 0 Then
            Existe_Doc = True
        Else
            Existe_Doc = False
        End If

    End Function

    Private Sub plCorreoCreaSolicitud(prmFolio As Integer)
        Dim vlCorreo As New clsEnviarEmail
        Dim vlPara, vlConCopia As String
        Dim Obj(5) As Object

        Obj(0) = "JUR_Solicitud"
        Obj(1) = lblNombreSolicitante.Text.Trim
        Obj(2) = prmFolio
        Obj(3) = FechaEnFormatoYYYYMMDD(DateTime.Today)
        Obj(4) = ADDA.NombreCortoEmpresa
        Obj(5) = ATXEspecificaciones.Text.Trim

        Dim vlMensaje As String = FabricaJuridico.ObtenPlantillaCorreo(Obj)

        vlPara = "derechocorp@adelnor.com"
        vlConCopia = ATXCorreo.Text.Trim & "," & ATXCorreo2.Text.Trim

        Try
            With vlCorreo
                .Correo = "sistemacontratos"
                .Nombre = "Sistema de Juridico de Contratos"
                .Para = vlPara
                .ConCopia = vlConCopia
                .Asunto = "Alta de Solicitud de Contrato Num: " & prmFolio & " de la Empresa: " & ADDA.NombreCortoEmpresa
                '.Mensaje = "El Solicitante " & lblNombreSolicitante.Text.Trim & ", del departamento " & lblNombreDepartamento.Text.Trim & ", ha generado la solicitud de contrato Núm: " _
                '                & prmFolio & " de la Empresa " & ADDA.NombreCortoEmpresa & ". <br><br> Esta disponible para su clasificación. <br><br> Saludos." _
                '                & "<br>================================================================================================================================================================================================<br>"
                .Mensaje = vlMensaje
                .Enviar_Correo()
            End With
        Catch ex As Exception
            MuestraMensaje("Ocurrio un fallo al enviar correos.", MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub plEnviaCorreoCancelacion(prmFolio As Integer)
        Dim vlCorreo As New clsEnviarEmail
        Dim vDt As DataTable

        vDt = FabricaJuridico.ObtenDatosdelEmpleado(ADDA.GetLoginUsuario)

        With vlCorreo
            .Correo = "sistemacontratos"
            .Nombre = "Sistema de Juridico de Contratos"
            .Para = "derechocorp@adelnor.com"
            .ConCopia = ATXCorreo.Text.Trim + "," + ATXCorreo2.Text.Trim
            .Asunto = "Cancelación de Solicitud De Contrato Núm: " & prmFolio & " de la Empresa: " & ADDA.NombreCortoEmpresa
            .Mensaje = "Se le informa que la Solicitud de Contrato Núm: " & prmFolio & " de la Empresa " & ADDA.NombreCortoEmpresa & " ha sido CANCELADA por " _
                       & vDt(0)("cNombreEmpleado") & " del departamento " & vDt(0)("cNombreDepartamento") & ". <br><br> Para cualquier aclaración, favor de contactar a los involucrados."

            .Enviar_Correo()
        End With

    End Sub
#End Region

#Region "Eventos"

    Private Sub FrmM2702001_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ADDA = AsistenteDeDatos_Base.DevuelveInstancia

            plNuevo(True)

            lblFecha.Text = ADDA.RegresaFechaDelSistema
            dtpFechaini.Value = DateTime.Now
            dtpFechaFin.Value = dtpFechaini.Value.AddYears(1)
            dtpFechaFirma.Value = dtpFechaini.Value.AddMonths(1)

            txtTipoActo.Enabled = False
            cmbMoneda.SelectedValue = 1
            ATXCantidadPenalidades.Text = Format(0, "$###,###,##0.00")
            ATXFolio.Focus()

            With Me.ToolBarButtons
                .Guardar = False
                .Borrar = False
                .Imprimir = False
                .EnvExcel = False
                .Graficar = False
                .Ejecutar = False
                .Nuevo = True
            End With

        Catch ex As Exception
            MuestraMensaje(ex.Message, Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ATXFolio_Validating(sender As Object, e As CancelEventArgs) Handles ATXFolio.Validating
        Try
            If Not String.IsNullOrEmpty(ATXFolio.Text.Trim) Then
                Dim dtDatos As DataTable

                dtDatos = FabricaJuridico.ConsultaSolicitud(ATXFolio.Text)

                If dtDatos.Rows.Count > 0 Then
                    drDatosSolicitud = dtDatos.NewRow
                    drDatosSolicitud = dtDatos.Rows(0)

                    If Not drDatosSolicitud("bActivo") Then
                        MuestraMensaje("El Folio de solicitud se encuentra cancelado", MessageBoxIcon.Information)
                        ATXFolio.Text = ""
                        ATXFolio.Focus()
                        Return
                        e.Cancel = True
                    End If

                    If drDatosSolicitud("cUsuario_Registro") <> ADDA.GetLoginUsuario() Then
                        MuestraMensaje("El Folio de solicitud no pertenece al usuario ingresado. Verifique..", MessageBoxIcon.Information)
                        ATXFolio.Text = ""
                        ATXFolio.Focus()
                        Return
                        e.Cancel = True
                    End If

                    'Pintar datos en los controles de pantalla 
                    Dim s As String = drDatosSolicitud("cDescColor").ToString.Trim
                    Dim p = s.Split(","c).Select(Function(x) Int32.Parse(x.Trim()))

                    lblVigencia.Text = "ESTA SOLICITUD DE CONTRATO CUENTA CON " & drDatosSolicitud("DiasPorVencer") & " DIAS DE VIGENCIA"
                    lblVigencia.Visible = True

                    'dtpFecha.Value = dtDatos.Rows(0)("dfechasolicitud")
                    lblFecha.Text = drDatosSolicitud("dfechasolicitud")

                    lblStatus.Text = drDatosSolicitud("cDescEstatus")
                    lblStatus.Visible = True
                    ATXFolio.Enabled = False
                    lblClave.Text = drDatosSolicitud("cClave")

                    plCargarDatos(drDatosSolicitud("nIDSolContrato"))

                    ATXCorreo.Text = drDatosSolicitud("cPara")
                    ATXCorreo2.Text = drDatosSolicitud("cConCopia")

                    dtpFechaini.Value = drDatosSolicitud("dFechaIni")
                    dtpFechaFin.Value = drDatosSolicitud("dFechaFin")
                    dtpFechaFirma.Value = drDatosSolicitud("dFechaFirma")
                    plConsultaDatosdelEmpleado(drDatosSolicitud("cUsuario_Registro"))

                    If Not drDatosSolicitud("nSubtipoAct") Is DBNull.Value Then
                        lblNombreClasificacion.Text = drDatosSolicitud("nSubtipoAct") & " - " & drDatosSolicitud("cClasificacion")
                    End If

                    ATXEspecificaciones.Text = drDatosSolicitud("cEspecificaciones")
                    ATXPenalidades.Text = drDatosSolicitud("cPenalidades")
                    cmbMoneda.SelectedValue = drDatosSolicitud("nMonedapena")
                    ATXCantidadPenalidades.Text = Format(drDatosSolicitud("nCantPena"), "$###,###,##0.00")

                    If Not String.IsNullOrEmpty(drDatosSolicitud("cRetroPropuesta")) Then
                        gpoRetroalimentacion.Visible = True
                        lblRetroalimentacion.Text = drDatosSolicitud("cRetroPropuesta")
                    End If

                    btnCargaArchivo.Enabled = True
                    If Existe_Doc() Then btnVerArchivo.Enabled = True

                    If drDatosSolicitud("nIDEstatusSol") = 1 Then Me.ToolBarButtons.Guardar = True
                End If

                Utilerias.DestruirObjeto(dtDatos)
            Else
                ATXFolio.Text = "*"
                ATXFolio.Enabled = False
                plConsultaDatosdelEmpleado(ADDA.GetLoginUsuario)

                btnCargaArchivo.Enabled = True
                Me.ToolBarButtons.Guardar = True
            End If
        Catch ex As Exception
            MuestraMensaje(ex.ToString, MessageBoxIcon.Error)
            e.Cancel = True
        End Try
    End Sub

    Private Sub ATXProveedor_CambioElemento(sender As Object, e As SelectedElementArgs) Handles ATXProveedor.CambioElemento
        Try
            If ATXProveedor.Text.Trim = "" Then Return

            If e.Row IsNot Nothing Then
                plObtenBeneficiario(e.Row!nBeneficiario, e.Row!cTipoPersona)
                ATXProveedor.SetTextBoxValue("")
            End If
        Catch ex As Exception
            MuestraMensaje(ex.ToString, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub grvProveedores_KeyDown(sender As Object, e As KeyEventArgs) Handles grvProveedores.KeyDown
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
            grvProveedores.DeleteSelectedRows()

            If grvProveedores.RowCount = 1 Then
                lblClave.Text = Mid(grvProveedores.GetRowCellValue(0, grvProveedores.Columns.ColumnByFieldName("cDescBene")), 1, 10)
            End If

            If grvProveedores.RowCount = 0 Then
                lblClave.Text = ""
            End If
        End If
    End Sub

    Private Sub txtEspecificaciones_GotFocus(sender As Object, e As EventArgs) Handles ATXEspecificaciones.GotFocus
        ATXEspecificaciones.SelectAll()
    End Sub

    Private Sub ATXFolio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ATXFolio.KeyPress
        ValidaCajaNumerica(sender, e)
    End Sub

    Private Sub Correos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ATXCorreo.KeyPress, ATXCorreo2.KeyPress
        ValidaCajaCorreoElectronico(sender, e)
    End Sub

    Private Sub ATXCantidadPenalidades_Validating(sender As Object, e As CancelEventArgs) Handles ATXCantidadPenalidades.Validating
        ATXCantidadPenalidades.Text = Format(CDbl(ATXCantidadPenalidades.Text), "$###,###,##0.00")
    End Sub

    Private Sub btnCargaArchivo_Click(sender As Object, e As EventArgs) Handles btnCargaArchivo.Click
        Dim tamañoMB As Decimal = 0
        Dim cArchivos As String = ""
        Dim row As DataRow
        Dim nNumImg As Integer

        Try
            With ofdDocumento
                If .ShowDialog = DialogResult.OK Then
                    For i As Integer = 0 To .FileNames.Length - 1
                        tamañoMB = Utilerias.TamañoArchivoMB(.FileNames(i))

                        If tamañoMB > 2.2D Then
                            MuestraMensaje("Este archivo excede el límite de 2MB, favor de ajustar el archivo para disminuir su tamaño" & vbNewLine & vbNewLine &
                                           .SafeFileNames(i),
                                           MessageBoxIcon.Exclamation)
                        Else
                            nNumImg = dtArchivo.Rows.Count() + 1

                            cArchivos += .SafeFileNames(i) & vbNewLine
                            row = dtArchivo.NewRow


                            row!nNumImg = nNumImg
                            row!cNombreImg = .SafeFileNames(i)
                            row!cExtension = .SafeFileNames(i).Substring(.SafeFileNames(i).LastIndexOf("."c) + 1)
                            row!bArchivo = IO.File.ReadAllBytes(.FileNames(i))
                            dtArchivo.Rows.Add(row)
                        End If
                    Next
                End If
            End With
        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnVerArchivo_Click(sender As Object, e As EventArgs) Handles btnVerArchivo.Click
        Dim aBytDocumento() As Byte = Nothing
        Dim fs As FileStream
        Dim dt As DataTable
        Dim ruta As String
        Dim nomdoc As String = ruta + "ContratoNum" + ATXFolio.Text + ".pdf"

        ruta = System.IO.Path.GetTempPath()
        dt = FabricaJuridicoJosue.FgConsultaDocuContratos(CInt(ATXFolio.Text))

        aBytDocumento = dt(0)("RESUL")

        fs = New System.IO.FileStream(nomdoc, System.IO.FileMode.Create)
        fs.Write(aBytDocumento, 0, aBytDocumento.Length)

        Process.Start(nomdoc)
        fs.Close()
    End Sub

#End Region

#Region "Overrides"

    Protected Overrides Sub ClickBotonNuevo()
        MyBase.ClickBotonNuevo()

        If MensajeConfirmaLimpiarPantalla() = Windows.Forms.DialogResult.No Then Return

        plNuevo(False)
    End Sub

    Protected Overrides Sub ClickBotonGuardar()
        MyBase.ClickBotonGuardar()

        If Not flValidar() Then Return

        If MensajeConfirmaGuardar() = Windows.Forms.DialogResult.No Then Return

        If flGuardar() Then
            plCorreoCreaSolicitud(gnFolioSolicitud)
            plNuevo(False)
        End If
    End Sub

    Protected Overrides Sub ClickBotonBorrar()
        MyBase.ClickBotonBorrar()

        If Not flValidarBorrar() Then Return

        If Mensaje_ConfirmacionBorrarGuardar(ETipoMensaje.Borrar) = Windows.Forms.DialogResult.No Then Return

        If flCancelar() Then
            plNuevo(False)
        End If
    End Sub
#End Region
End Class