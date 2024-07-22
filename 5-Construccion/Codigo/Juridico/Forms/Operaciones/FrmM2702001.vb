Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports ADSUM
Imports Juridico.Dominio
Imports Tools.Comun.Tools

Public Class FrmM2702001    '   Solicitud de Contratos

#Region "Declaraciones"
    Private WithEvents MXContratantes As ManejadorXtraGridAdvanced
    Protected gnFolioSolicitud As Integer = 0
    Private gnIDSubActo As Integer
    Private gnTipoPersona As Integer
    Private gnDepartamento As Integer
    Private gcIDSubActo As String
    Private gcFolioSeguimiento As String
    Private gcDescripcionGrupoActo As String

    Private ADDA As AsistenteDeDatos_Base

    Private drDatosSolicitud As DataRow
    Private dtContratantes As DataTable
    Private dtDDRequerimientosGuardar As DataTable
    Private dtArchivosGuardar As New DataTable
    Private dtArchivoPropuesta As DataTable

    Private gbPreguntaCerrarPantalla As Boolean = True
    Private gbEsNuevoOReclasifica As Boolean = False
    Private vcMensaje As String

#End Region

#Region "Funciones y Procedimientos"

    Private Sub plNuevo(EsLoad As Boolean)
        If EsLoad Then
            'plCreaEstructuraGridContratantes()
            'plCrearEstructuraArchivo()
            'plConfigurarGrid()
            'plConfiguraCatalogos()
        Else
            ATXFolio.Enabled = True
            ATXFolio.Text = ""
            ATXFolio.Tag = ""

            lblTextoEstatus.Visible = False
            lblEstatus.Visible = False
            lblEstatus.Text = ""
            lblNombreSolicitante.Text = ""
            lblNombreDepartamento.Text = ""
            lblNombreJefe.Text = ""
            lblDepartamentoJefe.Text = ""
            lblNombreClasificacion.Text = ""

            ATXProveedor.Text = ""
            lblClave.Text = ""

            ATXCorreo.Text = ""
            ATXCorreo2.Text = ""
            ATXClasificacion.Text = ""

            chkFirmaElectronica.Checked = False
            atxCorreoRepresentanteLegal.Text = ""

            gnDepartamento = 0

            lblFecha.Text = ADDA.RegresaFechaDelSistema
            dtpFechaini.Value = DateTime.Now
            dtpFechaFin.Value = dtpFechaini.Value.AddYears(1)

            ATXEspecificaciones.Text = ""
            btnCargaArchivo.Enabled = False
            btnDocumentacion.Enabled = False

            drDatosSolicitud = Nothing
            dtArchivoPropuesta.Rows.Clear()
            dtContratantes.Rows.Clear()
            lvArchivoPropuesta.Items.Clear()

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
        ATXClasificacion.CatalogoBase = New Catalogo(New MetaCatalogo("JUR_GrupocontratoSubActos"))
    End Sub

    Private Sub plCreaEstructuraGridContratantes()
        Utilerias.DestruirObjeto(dtContratantes)

        dtContratantes = New DataTable
        With dtContratantes
            .Columns.Add("nIDSolContrato", GetType(Integer))
            .Columns.Add("nTipo", GetType(Integer))
            .Columns.Add("nCodBene", GetType(Integer)).Caption = "Código"
            .Columns.Add("cDescBene", GetType(String)).Caption = "Nombre Beneficiario"
            .Columns.Add("cRFC", GetType(String)).Caption = "RFC"
            .Columns.Add("cTipoPersona", GetType(String)).Caption = "Tipo Persona"
        End With

        grdProveedores.DataSource = dtContratantes

        Utilerias.CargarColumnasGrid(grvProveedores, {"nIDSolContrato", "nTipo"}, True)
    End Sub

    Private Sub plCrearEstructuraArchivo()
        Utilerias.DestruirObjeto(dtArchivoPropuesta)

        dtArchivoPropuesta = New DataTable

        dtArchivoPropuesta.Columns.Add("nNumImg", GetType(Integer))
        dtArchivoPropuesta.Columns.Add("cNombreImg", GetType(String))
        dtArchivoPropuesta.Columns.Add("cExtension", GetType(String))
        dtArchivoPropuesta.Columns.Add("bArchivo", GetType(Byte()))
    End Sub

    Private Sub plConsultaDatosdelEmpleado(Login As String)
        Dim vDt As DataTable

        vDt = FabricaJuridico.ObtenDatosdelEmpleado(Login)

        For Each vDRow As DataRow In vDt.Rows
            gnDepartamento = vDRow("nCodDepto")
            lblNombreSolicitante.Text = vDRow("cNombreEmpleado")
            lblNombreDepartamento.Text = vDRow("cNombreDepartamento")
            ATXCorreo.Text = vDRow("cCorreoEmpleado")
            lblNombreJefe.Text = vDRow("cNombreJefe")
            lblDepartamentoJefe.Text = vDRow("cDepartamentoJefe")
            ATXCorreo2.Text = vDRow("cCorreoJefe")
        Next
    End Sub

    Private Sub plConsultaSolicitud()
        Dim dtDatos As DataTable = FabricaJuridico.ConsultaSolicitud(ATXFolio.Text)

        If dtDatos.Rows.Count > 0 Then
            drDatosSolicitud = dtDatos.Rows(0)
            gnFolioSolicitud = ATXFolio.Text

            If Not drDatosSolicitud("bActivo") Then
                MuestraMensaje("El Folio de solicitud se encuentra cancelado", MessageBoxIcon.Information)
                ATXFolio.Text = ""
                ATXFolio.Focus()

                Return
            End If

            If ADDA.GetLoginUsuario().ToUpper <> "ADMIN" Then
                If drDatosSolicitud("cUsuario_Registro").ToString.ToUpper <> ADDA.GetLoginUsuario().ToUpper Then
                    MuestraMensaje("El Folio de solicitud no pertenece al usuario ingresado. Verifique..", MessageBoxIcon.Information)
                    ATXFolio.Text = ""
                    ATXFolio.Focus()

                    Return
                End If
            End If

            lblFecha.Text = drDatosSolicitud("dfechasolicitud")
            lblEstatus.Text = drDatosSolicitud("cDescEstatus")
            lblEstatus.Visible = True
            lblTextoEstatus.Visible = True
            ATXFolio.Enabled = False
            ATXClasificacion.Text = drDatosSolicitud("nSubtipoAct")

            gnIDSubActo = drDatosSolicitud("nSubtipoAct")
            gcFolioSeguimiento = drDatosSolicitud("cFolioPropuesta")
            lblClave.Text = drDatosSolicitud("cClave")
            ATXCorreo.Text = drDatosSolicitud("cPara")
            ATXCorreo2.Text = drDatosSolicitud("cConCopia")
            ATXEspecificaciones.Text = drDatosSolicitud("cEspecificaciones")
            dtpFechaini.Value = drDatosSolicitud("dFechaIni")
            dtpFechaFin.Value = drDatosSolicitud("dFechaFin")

            plConsultaDatosdelEmpleado(drDatosSolicitud("cUsuario_Registro"))
            plCargarBeneficiarios(drDatosSolicitud("nIDSolContrato"))
            plCargarArchivoPropuesta(ATXFolio.Text.Trim)

            If dtArchivoPropuesta.Rows.Count > 0 Then btnCargaArchivo.Enabled = False



            If drDatosSolicitud("nIDEstatusSol") = 2 OrElse drDatosSolicitud("nIDEstatusSol") = 3 Then
                atxRetroalimentacion.Text = drDatosSolicitud("cRetroPropuesta")

                ToolBarButtons.Guardar = True
                gpoRetroalimentacion.Visible = True
            End If
            ToolBarButtons.Borrar = True

            ATXClasificacion.Focus()
            SendKeys.Send("{ENTER}")
            Application.DoEvents()

            Utilerias.DestruirObjeto(dtDatos)
        Else
            MuestraMensaje("No se encontro información con el folio de Solicitud indicado. Verifique..", MessageBoxIcon.Information)
            ATXFolio.Focus()
        End If
    End Sub

    Private Sub plCargarBeneficiarios(FolioSol As Integer)
        Dim dsTemp As DataSet

        dsTemp = FabricaJuridico.ObtenBeneficiarios(FolioSol)

        If dsTemp Is Nothing AndAlso FolioSol <> -1 Then
            MuestraMensaje("Ocurrio un error al consultar los datos, cierre y abra el sistema y vuelva a intentarlo.", MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        dtContratantes.Rows.Clear()
        dtContratantes.Merge(dsTemp.Tables(0), False, MissingSchemaAction.Ignore)

        Utilerias.CargarColumnasGrid(grvProveedores, {"nIDSolContrato", "nTipo"}, True)

        Utilerias.DestruirObjeto(dsTemp)
    End Sub

    Private Sub plCargarArchivoPropuesta(FolioSol As Integer)
        Dim dsTemp As DataSet

        dsTemp = FabricaJuridico.ObtenArchivoPropuesta(FolioSol)

        If dsTemp Is Nothing AndAlso FolioSol <> -1 Then
            MuestraMensaje("Ocurrio un error al consultar los datos, cierre y abra el sistema y vuelva a intentarlo.", MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        dtArchivoPropuesta.Merge(dsTemp.Tables(0), False, MissingSchemaAction.Ignore)
        plConfiguraListViewArchivoPropuesta()

        Utilerias.DestruirObjeto(dsTemp)
    End Sub

    Private Sub plObtenBeneficiario(Beneficiario As DataRow)

        dtContratantes.Rows.Add(0,
                                IIf(Beneficiario("TipoPer") = "M", 1, 2),
                                Beneficiario("CodInterno"),
                                Beneficiario("RazonSocial"),
                                Beneficiario("RFC"),
                                Beneficiario("TipoPersona")
                                )
        dtContratantes.AcceptChanges()

        gnTipoPersona = IIf(Beneficiario("TipoPer") = "M", 1, 2)

        For col = 0 To grvProveedores.Columns.Count - 1
            grvProveedores.Columns(col).SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        If grvProveedores.RowCount > 0 Then
            lblClave.Text = Mid(grvProveedores.GetRowCellValue(0, grvProveedores.Columns.ColumnByFieldName("cDescBene")), 1, 10)
        End If
    End Sub

    Private Sub plConfiguraListViewArchivoPropuesta()
        lvArchivoPropuesta.Items.Clear()

        Try
            For Each row As DataRow In dtArchivoPropuesta.Rows
                Dim listViewItem As ListViewItem = New ListViewItem()

                listViewItem.Text = row("cNombreImg")
                listViewItem.Tag = row("nNumImg")

                Select Case row("cExtension").ToString().ToUpper()
                    Case "DOC", "DOCX"
                        listViewItem.ImageIndex = 2

                    Case "PDF"
                        listViewItem.ImageIndex = 0

                    Case "JPG", "PNG", "JPEG"
                        listViewItem.ImageIndex = 1

                    Case "MKV", "AVI", "MP4"
                        listViewItem.ImageIndex = 3
                End Select

                lvArchivoPropuesta.Items.Add(listViewItem)
            Next

        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub plEliminaArchivos()
        If Not ADDA.TieneTransaccionAbierta Then ADDA.AbreTransaccion()

        If Not EscribanoJuridico.EliminaArchivosRequerimientos(gnFolioSolicitud) Then
            If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
            MuestraMensaje("Ocurrió un problema al intentar borrar la documentación de la solicitud", MessageBoxIcon.Information)
        End If

        If ADDA.TieneTransaccionAbierta Then ADDA.CierraTransaccion()
        MuestraMensaje("Documentación borrada con éxito.", MessageBoxIcon.Information)
    End Sub

    Private Function flValidar() As Boolean
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

        If gnIDSubActo = 0 Then
            MuestraMensaje("Debe indicar una clasificación de contrato correcta.", MessageBoxIcon.Exclamation)
            'cmbGrupo.Focus()

            Return False
        End If

        If chkFirmaElectronica.Checked = True Then
            If atxCorreoRepresentanteLegal.Text = "" Then
                MuestraMensaje("Seleccionó Con Firma Electrónica, por tanto, debe de proporcionar el correo del representante legal.", MessageBoxIcon.Exclamation)
                atxCorreoRepresentanteLegal.Focus()

                Return False
            Else
                If Not ValidaEMail(atxCorreoRepresentanteLegal.Text.Trim) Then
                    MuestraMensaje("Dirección de correo no valida.", MessageBoxIcon.Exclamation)
                    atxCorreoRepresentanteLegal.Focus()

                    Return False
                End If
            End If
        End If

        If Not dtArchivosGuardar.Rows.Count > 0 OrElse dtArchivosGuardar Is Nothing Then
            MuestraMensaje("Debe realizar la carga correcta de la documentación.", MessageBoxIcon.Exclamation)
            btnDocumentacion.Focus()

            Return False
        End If

        Return True
    End Function

    Private Function flValidarBorrar() As Boolean
        Dim dsTemp As DataSet

        dsTemp = FabricaJuridico.ObtenContratosDigitalizadosCliente(ATXFolio.Text)

        If dsTemp.Tables(0).Rows.Count <> 0 Then
            MuestraMensaje("El folio de solicitud cuenta con contratos generados, no es posible realizar la cancelación.", MessageBoxIcon.Exclamation)

            Return False
        End If
        Utilerias.DestruirObjeto(dsTemp)

        Return True
    End Function

    Private Function ObtenFolioSeguimiento() As Boolean
        Dim folioSeguimiento As String = ""
        Dim folioConsecutivo As Integer

        If ATXFolio.Text = "*" Then
            folioConsecutivo = EscribanoJuridico.ObtenFolioConsecutivo()
        Else
            folioConsecutivo = gnFolioSolicitud
        End If

        If folioConsecutivo = 0 Then
            Return False
        End If

        Select Case ADDA.IdEmpresa
            Case 1
                folioSeguimiento = "NANSA"
            Case 2
                folioSeguimiento = "NOVA"
            Case 3
                folioSeguimiento = "FERTI"
            Case 4
                folioSeguimiento = "LOGIC"
        End Select

        folioSeguimiento &= String.Concat("/", lblClave.Text.ToUpper.Trim, "/", gcDescripcionGrupoActo.ToUpper.Trim, "/", Replace(FechaEnFormatoYYYYMMDD(DateTime.Now), "-", ""), "/")
        folioSeguimiento &= folioConsecutivo
        folioSeguimiento = folioSeguimiento.Replace(" ", "").Trim
        folioSeguimiento = folioSeguimiento.Replace("&", "&amp;")
        folioSeguimiento = folioSeguimiento.Replace("""", "&quot;")
        folioSeguimiento = folioSeguimiento.Replace("'", "''")

        gcFolioSeguimiento = folioSeguimiento

        Return True
    End Function

    Private Function flGuardar() As Boolean
        Dim xmlGuarda As String = ""
        Dim xmlArchivos As String

        Dim item As String = "<Solicitud dFechaSolicitud=""{0}"" cClave=""{1}"" nDepartamento=""{2}"" nIDEstatusSol=""{3}"" dFechaIni=""{4}"" dFechaFin=""{5}"" cEspecificaciones=""{6}"" 
                                cCorreo=""{7}"" cCorreo2=""{8}"" nIDSubActo=""{9}"" cFolioSeguimiento=""{10}"" bFirmaElectronica=""{11}"" cCorreoRepresentanteLegal=""{12}""/>"
        Dim vlClave As String = lblClave.Text.Replace(" ", "").Trim
        vlClave = vlClave.Replace("&", "&amp;")
        vlClave = vlClave.Replace("""", "&quot;")
        vlClave = vlClave.Replace("'", "''")

        Try
            If Not ADDA.TieneTransaccionAbierta Then ADDA.AbreTransaccion()

            If Not ObtenFolioSeguimiento() Then
                If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
                MuestraMensaje("Ocurrió un problema al obtener el folio de seguimiento.", MessageBoxIcon.Information)

                Return False
            End If

            xmlGuarda &= String.Format(item, FechaEnFormatoYYYYMMDD(lblFecha.Text), vlClave, gnDepartamento, "1", FechaEnFormatoYYYYMMDD(dtpFechaini.Value), FechaEnFormatoYYYYMMDD(dtpFechaFin.Value),
                    ATXEspecificaciones.Text.Trim, ATXCorreo.Text.Trim, ATXCorreo2.Text.Trim, gnIDSubActo, gcFolioSeguimiento, IIf(chkFirmaElectronica.Checked, "1", "0"), atxCorreoRepresentanteLegal.Text)

            If ATXFolio.Text = "*" Then
                gnFolioSolicitud = EscribanoJuridico.GuardaSolicitud(xmlGuarda)

                If gnFolioSolicitud = 0 Then
                    If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
                    MuestraMensaje("Ocurrió un problema al intentar guardar la solicitud.", MessageBoxIcon.Information)

                    Return False
                End If

                'Se guardan Contratantes y Obligados Solidarios 
                For Each fila As DataRow In dtContratantes.Rows
                    EscribanoJuridicoJosue.InsertarContraObligadosSol(gnFolioSolicitud, fila("nTipo"), fila("nCodBene"), fila("cDescBene"), fila("cRFC"), fila("cTipoPersona"))
                Next

                'Se guarda archivo propuesta si se cargó
                If dtArchivoPropuesta.Rows.Count > 0 Then
                    If Not EscribanoJuridico.GuardarArchivoPropuesta(gnFolioSolicitud, dtArchivoPropuesta.Rows(0)) Then
                        If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
                        MuestraMensaje("Ocurrió un problema al intentar guardar el archivo propuesta.", MessageBoxIcon.Information)

                        Return False
                    End If
                End If
            Else
                If Not EscribanoJuridico.ActualizaSolicitud(xmlGuarda, ATXFolio.Text) Then
                    If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
                    MuestraMensaje("Ocurrió un problema al intentar actualizar la solicitud", MessageBoxIcon.Information)

                    Return False
                End If
            End If

            'Se actualizan archivos de requerimientos
            If dtArchivosGuardar.Rows.Count > 0 Then
                xmlArchivos = Utilerias.DataTableAXml(dtArchivosGuardar.Select("bGuardar = true").CopyToDataTable(), {"bGuardar", "cDirArchivo"})

                If Not EscribanoJuridico.GuardarDocumentos(gnFolioSolicitud, xmlArchivos) Then
                    If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
                    MuestraMensaje("Ocurrio un problema al intentar guardar la documentación.", MessageBoxIcon.Exclamation)

                    Return False
                End If
            End If

            If ADDA.TieneTransaccionAbierta Then ADDA.CierraTransaccion()
            MuestraMensaje("Solicitud guardada con éxito. Folio #" & gnFolioSolicitud, MessageBoxIcon.Information)

            Return True
        Catch ex As Exception
            If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)

            Return False
        End Try
    End Function

    Private Function flCancelar() As Boolean
        If EscribanoJuridico.CancelaSolicitud(ATXFolio.Text) Then
            MuestraMensaje("Solicitud de contrato cancelada correctamente", MessageBoxIcon.Information)

            Return True
        End If

        Return False
    End Function

    Private Sub plCorreoRegistraSolicitud(Folio As Integer)
        Dim vlCorreo As New clsEnviarEmail
        Dim Obj() As Object = {"JUR_RegistraSolicitud", lblNombreSolicitante.Text.Trim, Folio, FechaEnFormatoYYYYMMDD(DateTime.Today), ADDA.NombreCortoEmpresa, ATXEspecificaciones.Text.Trim(), gcIDSubActo}

        Dim vlMensaje As String = FabricaJuridico.ObtenPlantillaCorreo(Obj)

        Try
            With vlCorreo
                .Correo = "sistemacontratos"
                .Nombre = "Sistema de Juridico de Contratos"
                .Para = "derechocorp@adelnor.com"
                .ConCopia = ATXCorreo.Text.Trim & "," & ATXCorreo2.Text.Trim
                .Asunto = "Alta de Solicitud de Contrato Num: " & Folio & " de la Empresa: " & ADDA.NombreCortoEmpresa
                .Mensaje = vlMensaje
                .Enviar_Correo()
            End With
        Catch ex As Exception
            MuestraMensaje("Ocurrio un fallo al enviar correos.", MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub plCorreoCancelaSolicitud(Folio As Integer)
        Dim vlCorreo As New clsEnviarEmail
        Dim Obj() As Object = {"JUR_CancelaSolicitud", "", Folio, New DateTime(1900, 1, 1), ADDA.NombreCortoEmpresa, "", ""}

        Dim vlMensaje As String = FabricaJuridico.ObtenPlantillaCorreo(Obj)

        Try
            With vlCorreo
                .Correo = "sistemacontratos"
                .Nombre = "Sistema de Juridico de Contratos"
                .ConCopia = "derechocorp@adelnor.com"
                .Para = ATXCorreo.Text.Trim + "," + ATXCorreo2.Text.Trim
                .Asunto = "Cancelación de Solicitud De Contrato Núm: " & Folio & " de la Empresa: " & ADDA.NombreCortoEmpresa
                .Mensaje = vlMensaje
                .Enviar_Correo()
            End With
        Catch ex As Exception
            MuestraMensaje("Ocurrio un fallo al enviar correos.", MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub plCorreoModificaSolicitud(Folio As Integer)
        Dim vlCorreo As New clsEnviarEmail
        Dim Obj() As Object = {"JUR_ModificaSolicitud", "", Folio, New DateTime(1900, 1, 1), ADDA.NombreCortoEmpresa, "", ""}

        Dim vlMensaje As String = FabricaJuridico.ObtenPlantillaCorreo(Obj)

        Try
            With vlCorreo
                .Correo = "sistemacontratos"
                .Nombre = "Sistema de Juridico de Contratos"
                .ConCopia = "derechocorp@adelnor.com"
                .Para = ATXCorreo.Text.Trim + "," + ATXCorreo2.Text.Trim
                .Asunto = "Modificación de Solicitud De Contrato Núm: " & Folio & " de la Empresa: " & ADDA.NombreCortoEmpresa
                .Mensaje = vlMensaje
                .Enviar_Correo()
            End With
        Catch ex As Exception
            MuestraMensaje("Ocurrio un fallo al enviar correos.", MessageBoxIcon.Information)
        End Try
    End Sub
#End Region

#Region "Eventos"

    Private Sub FrmM2702001_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ADDA = AsistenteDeDatos_Base.DevuelveInstancia

            plCreaEstructuraGridContratantes()
            plCrearEstructuraArchivo()
            plConfigurarGrid()
            plConfiguraCatalogos()

            plNuevo(True)

            lblFecha.Text = ADDA.RegresaFechaDelSistema
            dtpFechaini.Value = DateTime.Now
            dtpFechaFin.Value = dtpFechaini.Value.AddYears(1)

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
            If ATXFolio.Text.Trim = "" Then 'If Not String.IsNullOrEmpty(ATXFolio.Text.Trim) Then
                ATXFolio.Enabled = False
                ATXFolio.Text = "*"
                lblTextoEstatus.Visible = True
                lblEstatus.Visible = True
                lblEstatus.Text = "NUEVO"
                plConsultaDatosdelEmpleado(ADDA.GetLoginUsuario)

                btnCargaArchivo.Enabled = True
                Me.ToolBarButtons.Guardar = True
            Else
                If IsNumeric(ATXFolio.Text) Then
                    plConsultaSolicitud()
                End If

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
                plObtenBeneficiario(e.Row)
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

    Private Sub btnCargaArchivo_Click(sender As Object, e As EventArgs) Handles btnCargaArchivo.Click
        Dim row As DataRow = dtArchivoPropuesta.NewRow
        Dim nNumImg As Integer

        Try
            With ofdArchivo
                .Multiselect = False

                If .ShowDialog = DialogResult.OK Then
                    Dim cArchivo As String = .FileName
                    Dim cExtension As String = cArchivo.Substring(cArchivo.LastIndexOf("."c) + 1).ToLower

                    If Not {"pdf", "doc", "docx"}.Contains(cExtension) Then
                        MuestraMensaje("El tipo de archivo seleccionado no es permitido para esta operación. Verifique.",
                                       MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                    If Utilerias.TamañoArchivoMB(cArchivo) > 10.24D Then
                        MuestraMensaje("El tamaño del archivo es mayor a 10 MB, intente con un archivo de menor tamaño. Puede cambiar la calidad para reducir el tamaño.",
                                        MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                    For i As Integer = 0 To .FileNames.Length - 1
                        nNumImg = dtArchivoPropuesta.Rows.Count() + 1

                        row!nNumImg = nNumImg
                        row!cNombreImg = .SafeFileNames(i)
                        row!cExtension = .SafeFileNames(i).Substring(.SafeFileNames(i).LastIndexOf("."c) + 1)
                        row!bArchivo = IO.File.ReadAllBytes(.FileNames(i))
                        dtArchivoPropuesta.Rows.Add(row)
                    Next
                End If
            End With
            btnCargaArchivo.Enabled = False

            plConfiguraListViewArchivoPropuesta()
        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lvArchivoPropuesta_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvArchivoPropuesta.MouseDoubleClick
        Dim row() As DataRow
        Dim frm As New FrmVisualizarArchivos
        Dim dirArchivo As String
        Dim extencion As String
        Dim bArchivo As Byte()

        Try
            row = dtArchivoPropuesta.Select("nNumImg=" & lvArchivoPropuesta.Items(lvArchivoPropuesta.FocusedItem.Index).Tag)
            extencion = CStr(row(0)("cExtension"))
            dirArchivo = My.Computer.FileSystem.GetTempFileName
            dirArchivo = dirArchivo.Replace(".tmp", "." & extencion)
            bArchivo = row(0)("bArchivo")

            IO.File.WriteAllBytes(dirArchivo, bArchivo)
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

    Private Sub lvArchivoPropuesta_KeyDown(sender As Object, e As KeyEventArgs) Handles lvArchivoPropuesta.KeyDown
        If e.KeyCode = Keys.Delete Then
            If lvArchivoPropuesta.SelectedItems.Count > 0 Then
                If MensajePregunta("¿Desea eliminar el/los archivos seleccionados?") = DialogResult.No Then Return

                Dim item As ListViewItem = lvArchivoPropuesta.SelectedItems(0)
                Dim filasEliminar() As DataRow = dtArchivoPropuesta.Select("nNumImg =" & item.Tag)

                If filasEliminar IsNot Nothing Then
                    For Each fila As DataRow In filasEliminar
                        fila.Delete()
                    Next

                    dtArchivoPropuesta.AcceptChanges()
                    lvArchivoPropuesta.Items.Remove(item)

                    btnCargaArchivo.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub ATXClasificacion_CambioElemento(sender As Object, e As SelectedElementArgs) Handles ATXClasificacion.CambioElemento
        Try
            If Not e.Row Is Nothing Then
                gnIDSubActo = e.Valor
                gcIDSubActo = FabricaJuridico.ConsultaClasificacion(gnIDSubActo)
                gcDescripcionGrupoActo = e.Row!DescActo
                lblNombreClasificacion.Text = e.Row!DescSubActo

                btnDocumentacion.Enabled = True
                btnDocumentacion.Focus()
            Else
                ATXClasificacion.Text = ""
            End If
        Catch ex As Exception
            MuestraMensaje(ex.ToString, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnDocumentacion_Click(sender As Object, e As EventArgs) Handles btnDocumentacion.Click
        If gnFolioSolicitud > 0 AndAlso drDatosSolicitud("nSubtipoAct") <> ATXClasificacion.Text Then
            If MensajePregunta("El cambiar de clasificación la solicitud ocasiona que sean eliminados los archivos capturados previamente. ¿Desea continuar?") = DialogResult.Yes Then
                plEliminaArchivos()

                gbEsNuevoOReclasifica = True
            Else
                Exit Sub
            End If
        End If

        Dim frm As New FrmM2702001_CargaDocumentos(gnIDSubActo, gnTipoPersona, gnFolioSolicitud, gbEsNuevoOReclasifica)

        If frm.ShowDialog() = DialogResult.OK Then
            dtDDRequerimientosGuardar = frm.dtDDRequerimientos
            dtArchivosGuardar = frm.dtArchivos

            If dtArchivosGuardar Is Nothing Then dtArchivosGuardar = New DataTable
        End If
    End Sub

    Private Sub BtnCerrarRetroalimentacion_Click(sender As Object, e As EventArgs) Handles BtnCerrarRetroalimentacion.Click
        gpoRetroalimentacion.Visible = False
    End Sub

#End Region

#Region "Overrides"

    Protected Overrides Sub ClickBotonNuevo()
        MyBase.ClickBotonNuevo()

        If MensajeConfirmaLimpiarPantalla() = DialogResult.No Then Return

        plNuevo(False)
    End Sub

    Protected Overrides Sub ClickBotonGuardar()
        MyBase.ClickBotonGuardar()

        If Not flValidar() Then Return

        If MensajeConfirmaGuardar() = DialogResult.No Then Return

        If flGuardar() Then
            If ATXFolio.Text = "*" Then
                plCorreoRegistraSolicitud(gnFolioSolicitud)
            Else
                plCorreoModificaSolicitud(gnFolioSolicitud)
            End If
            plNuevo(False)
        End If
    End Sub

    Protected Overrides Sub ClickBotonBorrar()
        MyBase.ClickBotonBorrar()

        If Not flValidarBorrar() Then Return

        If Mensaje_ConfirmacionBorrarGuardar(ETipoMensaje.Borrar) = DialogResult.No Then Return

        If flCancelar() Then
            plCorreoCancelaSolicitud(gnFolioSolicitud)
            plNuevo(False)
        End If
    End Sub
#End Region
End Class