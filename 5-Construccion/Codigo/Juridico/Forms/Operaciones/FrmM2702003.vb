Imports ADSUM
Imports Tools.Comun.Tools
Imports Juridico.Dominio
Imports DevExpress.XtraGrid.Views
Imports System.ComponentModel
Imports System.Drawing

Public Class FrmM2702003    '   Captura de Documentos

#Region "Declaraciones"
    Private WithEvents Manejador As ManejadorXtraGridAdvanced
    Private WithEvents ManejadorArchivos As ManejadorXtraGridAdvanced
    Protected gnPantalla As Integer

    Private ADDA As AsistenteDeDatos_Base
    Private dtDDRequerimientos As DataTable
    Private dtArchivos As DataTable
    Private drDatosSolicitud As DataRow

    Private gcComentariosRechazo As String = ""
    Private gbRechazando As Boolean = False

    Protected Enum EN_Pantallas
        CapturaDocumentos = 1
        VerificaDocumentos = 2
    End Enum

#End Region

#Region "Funciones y Procedimientos"

    Private Sub plNuevo(EsLoad As Boolean)


        If EsLoad Then

        Else
            ATXFolio.Enabled = True
            ATXFolio.Text = ""
            ATXFolio.Tag = ""
            lblNomDepto.Text = ""
            lblNomSolicitante.Text = ""
            lblNomBeneficiario.Text = ""
            lblRFC.Text = ""
            lblClasificacion.Text = ""
            lblFecSol.Text = ""

            lblColorStatus.Visible = False
            lblStatus.Visible = False
            lblVigencia.Text = ""
            lblVigencia.Visible = False

            btnEspecificaciones.Enabled = False
            gpoEspecificaciones.Visible = False
            chkTodos.Enabled = False
            gbRechazando = False

            gcComentariosRechazo = ""
            atxEspecificaciones.Text = ""
            atxEspecificaciones.ReadOnly = True

            atxAsignado.Text = ""
            txtNombre.Text = ""

            plCargarRequerimientos(-1)
            plCargarArchivos(-1, -1)

            With Me.ToolBarButtons
                .Guardar = False
                .Borrar = False
                .Imprimir = False
                .EnvExcel = False
                .Graficar = False
                .Ejecutar = False
                .Nuevo = True
            End With

            grdDocumentos.Enabled = False
            grdArchivos.Enabled = False

        End If
    End Sub

    Private Sub plConfiguraCatalogos()
        atxAsignado.CatalogoBase = New Catalogo(New MetaCatalogo("CTL_UsuariosNuevoERP_Nansa_2"))
        'atxAsignado.FiltroExtendido = "cCodGrupoUsuario= 3"

        ATXFolio.CatalogoBase = New Catalogo(New MetaCatalogo("JUR_Solicitudes"))
        'If gnPantalla = EN_Pantallas.CapturaDocumentos Then
        '    ATXFolio.FiltroExtendido = "cUsuario_Registro='" & ADDA.GetLoginUsuario & "'"
        'End If
    End Sub

    Private Sub plEnviaCorreo(CambiaEstatus As Boolean)
        Dim vlCorreo As New clsEnviarEmail
        Dim vlPara, vlConCopia As String
        Dim Obj(6) As Object

        Obj(1) = lblNomSolicitante.Text.Trim
        Obj(2) = ATXFolio.Text.Trim
        Obj(3) = FechaEnFormatoYYYYMMDD(DateTime.Today)
        Obj(4) = ADDA.NombreCortoEmpresa
        Obj(5) = ""
        Obj(6) = ""

        vlPara = drDatosSolicitud("cPara")
        vlConCopia = drDatosSolicitud("cConCopia")

        If CambiaEstatus Then
            Obj(0) = "JUR_AceptaDocumentos"
            Dim vlMensaje As String = FabricaJuridico.ObtenPlantillaCorreo(Obj)

            With vlCorreo
                .Correo = "sistemacontratos"
                .Nombre = "Sistema de Juridico de Contratos"
                .Para = vlPara & "," & vlConCopia
                .ConCopia = "derechocorp@adelnor.com"
                .Asunto = "Cambio de Estatus en Folio de Solicitud Núm: " & drDatosSolicitud!nIDSolContrato.ToString & " de la Empresa: " & ADDA.NombreCortoEmpresa
                .Mensaje = vlMensaje
                .Enviar_Correo()
            End With
        Else
            Obj(0) = "JUR_AgregaDocumentos"
            Dim vlMensaje As String = FabricaJuridico.ObtenPlantillaCorreo(Obj)

            With vlCorreo
                .Correo = "sistemacontratos"
                .Nombre = "Sistema de Juridico de Contratos"
                .Para = vlPara & "," & vlConCopia
                .ConCopia = "derechocorp@adelnor.com"
                .Asunto = "Información sobre el Folio de Solicitud Núm: " & drDatosSolicitud!nIDSolContrato.ToString & " de la Empresa: " & ADDA.NombreCortoEmpresa
                .Mensaje = vlMensaje
                .Enviar_Correo()
            End With
        End If
    End Sub

    Private Sub plEnviaCorreoRechazo()
        Dim vlCorreo As New clsEnviarEmail
        Dim vlPara, vlConCopia As String
        Dim Obj(6) As Object

        Obj(0) = "JUR_RechazaDocumentos"
        Obj(1) = lblNomSolicitante.Text.Trim
        Obj(2) = ATXFolio.Text.Trim
        Obj(3) = FechaEnFormatoYYYYMMDD(DateTime.Today)
        Obj(4) = ADDA.NombreCortoEmpresa
        Obj(5) = atxEspecificaciones.Text.Trim
        Obj(6) = ""

        Dim vlMensaje As String = FabricaJuridico.ObtenPlantillaCorreo(Obj)

        vlPara = drDatosSolicitud("cPara")
        vlConCopia = drDatosSolicitud("cConCopia")

        With vlCorreo
            .Correo = "sistemacontratos"
            .Nombre = "Sistema de Juridico de Contratos"
            .Para = vlPara & "," & vlConCopia
            .ConCopia = "derechocorp@adelnor.com"
            .Asunto = "Información sobre el Folio de Solicitud Núm: " & drDatosSolicitud!nIDSolContrato.ToString & " de la Empresa: " & ADDA.NombreCortoEmpresa
            .Mensaje = vlMensaje
            .Enviar_Correo()
        End With

    End Sub

    Private Sub plCorreoAceptaSolicitud()
        Dim vlCorreo As New clsEnviarEmail
        Dim Obj() As Object = {"JUR_AceptaSolicitud", drDatosSolicitud("cSolicitante"), ATXFolio.Text, FechaEnFormatoYYYYMMDD(DateTime.Today), ADDA.NombreCortoEmpresa, "", ""}

        Dim vlMensaje As String = FabricaJuridico.ObtenPlantillaCorreo(Obj)

        With vlCorreo
            .Correo = "sistemacontratos"
            .Nombre = "Sistema de Juridico de Contratos"
            .Para = drDatosSolicitud("cPara") & "," & drDatosSolicitud("cConCopia")
            .ConCopia = "derechocorp@adelnor.com"
            .Asunto = "Información sobre el Folio de Solicitud Núm: " & drDatosSolicitud!nIDSolContrato.ToString & " de la Empresa: " & ADDA.NombreCortoEmpresa
            .Mensaje = vlMensaje

            .Enviar_Correo()
        End With
    End Sub

    Private Sub plCorreoRetroalimentacionSolicitud(Observaciones As String)
        Dim vlCorreo As New clsEnviarEmail
        Dim Obj() As Object = {"JUR_RetroalimentaSolicitud", drDatosSolicitud("cSolicitante"), ATXFolio.Text, FechaEnFormatoYYYYMMDD(DateTime.Today), ADDA.NombreCortoEmpresa, Observaciones, ""}

        Dim vlMensaje As String = FabricaJuridico.ObtenPlantillaCorreo(Obj)

        With vlCorreo
            .Correo = "sistemacontratos"
            .Nombre = "Sistema de Juridico de Contratos"
            .Para = "derechocorp@adelnor.com"
            .ConCopia = drDatosSolicitud("cPara") + "," + drDatosSolicitud("cConCopia")
            .Asunto = "Modificación de Solicitud De Contrato Núm: " & drDatosSolicitud("nIDSolContrato").ToString & " de la Empresa: " & ADDA.NombreCortoEmpresa
            .Mensaje = vlMensaje

            .Enviar_Correo()
        End With
    End Sub

    Private Function flValidar() As Boolean
        If ATXFolio.Text.Trim = "" Then
            MuestraMensaje("Debe ingresar un folio de solicitud valido.", MessageBoxIcon.Exclamation)

            Return False
        End If

        'If gnPantalla = EN_Pantallas.CapturaDocumentos Then
        '    If dtArchivos.Select("bGuardar=true", "").Count() = 0 Then
        '        MuestraMensaje("No hay documentos que guardar.", MessageBoxIcon.Exclamation)

        '        Return False
        '    End If
        'End If

        If gnPantalla = EN_Pantallas.VerificaDocumentos Then
            If dtDDRequerimientos.Select("bAutorizado=0 AND cMotivo=''", "").Count() > 0 Then
                MuestraMensaje("Existe un documento no autorizado sin especificar alguna observación. Verifique..", MessageBoxIcon.Exclamation)

                Return False
            End If

            If txtNombre.Text = "" Then
                MuestraMensaje("La solicitud de contrato no ha sido asignada a algún abogado valido. Verifique..", MessageBoxIcon.Exclamation)
            End If

        End If

        Return True
    End Function

    Private Function flGuardar() As Boolean
        'Dim xmlArchivos As String
        Dim motivoRechazo As String = "--   DOCUMENTACIÓN CON OBSERVACIONES --" & vbCrLf & vbCrLf

        Try
            'If gnPantalla = EN_Pantallas.CapturaDocumentos Then
            '    xmlArchivos = Utilerias.DataTableAXml(dtArchivos.Select("bGuardar = true").CopyToDataTable(), {"bGuardar", "cDirArchivo"})

            '    If Not ADDA.TieneTransaccionAbierta Then ADDA.AbreTransaccion()

            '    If Not EscribanoJuridico.GuardarDocumentos(ATXFolio.Text, xmlArchivos) Then
            '        If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
            '        MuestraMensaje("Ocurrio un problema al guardar la información, intente de nuevo.", MessageBoxIcon.Exclamation)

            '        Return False
            '    End If

            '    If ADDA.TieneTransaccionAbierta Then ADDA.CierraTransaccion()

            '    plEnviaCorreo(False)
            'End If

            For Each fila As DataRow In dtDDRequerimientos.Rows
                Try
                    EscribanoJuridico.GuardarAutorizacionRequerimientos(
                            ATXFolio.Text, fila("bAutorizado"), IfNull(fila("cMotivo"), ""), fila("nIDReq"))

                    If Not fila("bAutorizado") Then
                        motivoRechazo &= " Documento: " & fila("cDescripcion") & " ==> " & fila("cMotivo") & vbCrLf
                    End If

                Catch ex As Exception
                    If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()

                    MuestraMensaje("Ocurrio un problema al guardar la información, intente de nuevo.", MessageBoxIcon.Exclamation)
                End Try
            Next

            If dtDDRequerimientos.Select("bAutorizado=0", "").Count() > 0 Then
                EscribanoJuridico.RetroAlimentacionSolicitud(motivoRechazo, ATXFolio.Text)

                plCorreoRetroalimentacionSolicitud(motivoRechazo)
            Else
                EscribanoJuridico.GuardarAsignacionUsuarioSeguimiento(ATXFolio.Text)
                plCorreoAceptaSolicitud()
            End If

            Return True
        Catch ex As Exception
            If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
            MuestraMensaje(ex.Message, Windows.Forms.MessageBoxIcon.Error)

            Return False
        End Try
    End Function

    Private Sub plConfiguraGrid()
        With grvDocumentos
            .Columns("nIDReq").OptionsColumn.AllowEdit = False ' 
            .Columns("nIDReq").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            .Columns("cDescripcion").OptionsColumn.AllowEdit = False
            .Columns("cDescripcion").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            .Columns("nGuardado").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            .Columns("nUltimoNum").OptionsColumn.AllowEdit = False
            .Columns("nUltimoNum").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            '.Columns("bAutorizado").Visible = False
        End With

        If gnPantalla = EN_Pantallas.CapturaDocumentos Then
            Dim xBoton As New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
            xBoton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor

            grdDocumentos.RepositoryItems.Add(xBoton)

            grvDocumentos.Columns("bAutorizado").OptionsColumn.AllowEdit = False
            grvDocumentos.Columns("cCargar").ColumnEdit = xBoton
            grvDocumentos.Columns("cCargar").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            grvDocumentos.Columns("nGuardado").OptionsColumn.AllowEdit = False
            grvDocumentos.Columns("cMotivo").OptionsColumn.AllowEdit = False

        ElseIf gnPantalla = EN_Pantallas.VerificaDocumentos Then
            grvDocumentos.Columns("cCargar").Visible = False
            'grvDocumentos.Columns("bAutorizado").Visible = True
            grvDocumentos.Columns("bAutorizado").OptionsColumn.AllowEdit = True
            grvDocumentos.Columns("bAutorizado").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            grvDocumentos.Columns("cMotivo").Visible = True
            grvDocumentos.Columns("cMotivo").OptionsColumn.AllowEdit = True 'DevExpress.Utils.DefaultBoolean.True
            grvDocumentos.Columns("cMotivo").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            grvDocumentos.Columns("cMotivo").Width = 340

        End If
    End Sub

    Private Sub plCargarRequerimientos(FolioSol As Integer)
        dtDDRequerimientos = FabricaJuridico.ObtenDocumentosDigitalizadosCliente(FolioSol)

        If dtDDRequerimientos.Rows.Count = 0 AndAlso FolioSol <> -1 Then
            MuestraMensaje("Al parecer el folio consultado no cuenta con documentos asociados, revíselo por favor.", Windows.Forms.MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        With dtDDRequerimientos
            .Columns("nIDReq").Caption = "IdReq"
            .Columns("cDescripcion").Caption = "Documento"
            .Columns("nGuardado").Caption = "Almacenado"
            .Columns("nUltimoNum").Caption = "Ult. Versión"
            .Columns("cCargar").Caption = "Cargar"
            .Columns("bAutorizado").Caption = IIf(gnPantalla = EN_Pantallas.CapturaDocumentos, "Autorizado", "Autorizar")
            .Columns("cMotivo").Caption = "Observación"
        End With

        grdDocumentos.DataSource = dtDDRequerimientos

        Utilerias.CargarColumnasGrid(grvDocumentos, , False)

        plConfiguraGrid()
    End Sub

    Private Sub plCargarArchivos(FolioSol As Integer, IDRequerimiento As Integer)
        dtArchivos = FabricaJuridico.ObtenArchivosDigitalizadosCliente(FolioSol, IDRequerimiento)

        If dtArchivos.Rows.Count = 0 AndAlso FolioSol <> -1 Then
            MuestraMensaje("Ocurrio un error al consultar los datos, cierre y abra el sistema y vuelva a intentarlo.", MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        With dtArchivos
            .Columns("nIDReq").Caption = "IDReq"
            .Columns("nConsecutivo").Caption = "Versión"
            .Columns("cNombreArchivo").Caption = "Nombre Archivo"
            .Columns("cExtencion").Caption = "Extensión"
            .Columns("cVisualizar").Caption = "Visualizar"
        End With

        grdArchivos.DataSource = dtArchivos

        Utilerias.CargarColumnasGrid(grvArchivos, {"nIDDocumentoDig", "nIDDocumento", "bGuardar", "bActivo", "vArchivo", "cDirArchivo"}, False)

        With grvArchivos
            .Columns("nIDReq").OptionsColumn.AllowEdit = False
            .Columns("nConsecutivo").OptionsColumn.AllowEdit = False
            .Columns("cNombreArchivo").OptionsColumn.AllowEdit = False
            .Columns("cExtencion").OptionsColumn.AllowEdit = False

            .Columns("nIDReq").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            .Columns("nConsecutivo").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            .Columns("cNombreArchivo").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            .Columns("cExtencion").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
        End With

        Dim xVisualiza As New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        xVisualiza.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor

        grdArchivos.RepositoryItems.Add(xVisualiza)

        grvArchivos.Columns("cVisualizar").ColumnEdit = xVisualiza
        grvArchivos.Columns("cVisualizar").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
    End Sub

#End Region

#Region "Eventos"
    Private Sub FrmM2702003_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ADDA = AsistenteDeDatos_Base.DevuelveInstancia()
            Manejador = New ManejadorXtraGridAdvanced(grdDocumentos)
            Manejador.Estilo = ManejadorXtraGridAdvanced.Estilos.Captura
            ManejadorArchivos = New ManejadorXtraGridAdvanced(grdArchivos)
            ManejadorArchivos.Estilo = ManejadorXtraGridAdvanced.Estilos.Captura
            plConfiguraCatalogos()
            plNuevo(True)

            plCargarRequerimientos(-1)
            plCargarArchivos(-1, -1)

            'dtArchivos = dsDatosArchivos.Tables(0)

            With Me.ToolBarButtons
                .Guardar = False
                .Borrar = False
                .Imprimir = False
                .EnvExcel = False
                .Graficar = False
                .Ejecutar = False
                .Nuevo = True
            End With

            grdDocumentos.Enabled = False
            grdArchivos.Enabled = False
        Catch ex As Exception
            MuestraMensaje(ex.Message, Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ATXFolio_CambioElemento(sender As Object, e As SelectedElementArgs) Handles ATXFolio.CambioElemento
        Try
            If ATXFolio.Text.Trim = "" Then Return

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
                    End If

                    'Pintar datos en los controles de pantalla 
                    Dim s As String = drDatosSolicitud("cDescColor").ToString.Trim
                    Dim p = s.Split(","c).Select(Function(x) Int32.Parse(x.Trim()))
                    Dim color As Color = Color.FromArgb(p(0), p(1), p(2))

                    lblVigencia.Text = "ESTA SOLICITUD DE CONTRATO CUENTA CON " & drDatosSolicitud("DiasPorVencer") & " DIAS DE VIGENCIA"
                    lblVigencia.Visible = True

                    ATXFolio.Tag = drDatosSolicitud("nIDSolContrato")
                    atxEspecificaciones.Text = drDatosSolicitud("cEspecificaciones")
                    lblNomDepto.Text = drDatosSolicitud("cDepartamento")
                    lblNomSolicitante.Text = drDatosSolicitud("cSolicitante")
                    lblClasificacion.Text = drDatosSolicitud("cClasificacion")
                    lblNomBeneficiario.Text = drDatosSolicitud("cDescBene")
                    lblRFC.Text = drDatosSolicitud("cRFC")
                    lblFecSol.Text = drDatosSolicitud("dFechaSolicitud")
                    lblColorStatus.BackColor = color
                    lblColorStatus.Visible = True
                    lblStatus.Text = drDatosSolicitud("cDescEstatus")
                    lblStatus.Visible = True
                    ATXFolio.Enabled = False

                    plCargarRequerimientos(ATXFolio.Text.Trim)

                    ATXFolio.Enabled = False
                    btnEspecificaciones.Enabled = True
                    chkTodos.Enabled = True
                    grdDocumentos.Enabled = True
                    grdArchivos.Enabled = True

                    Me.ToolBarButtons.Ejecutar = False

                    If drDatosSolicitud("nIDEstatusSol") = EstatusSolicitudes_New.SolicitudEnRevision OrElse drDatosSolicitud("nIDEstatusSol") = EstatusSolicitudes_New.Rechazado Then
                        Me.ToolBarButtons.Guardar = True
                    Else
                        Me.ToolBarButtons.Guardar = False
                    End If
                End If
            End If
        Catch ex As Exception
            MuestraMensaje(ex.ToString, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonEdit1_ButtonClick(sender As Object, e As Grid.RowCellClickEventArgs) Handles grvDocumentos.RowCellClick
        Dim nIDRequerimiento As Integer
        Dim datosRequerimiento As DataRow = grvDocumentos.GetDataRow(grvDocumentos.FocusedRowHandle)

        If datosRequerimiento!nGuardado > 0 Then
            plCargarArchivos(ATXFolio.Text.Trim, CInt(datosRequerimiento!nIDReq))
        Else
            dtArchivos.Clear()
        End If

        If e.Column.FieldName = "cCargar" Then
            Try
                nIDRequerimiento = CInt(datosRequerimiento!nIDReq)

                If ofdArchivo.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim ultimoDoc As Integer
                    Dim nombreArchivo As String
                    Dim extencionArchivo As String
                    Dim dirArchivo As String
                    Dim rowArchivos = datosRequerimiento.GetChildRows("Archivos")
                    Dim rowArchivo As DataRow

                    dirArchivo = ofdArchivo.FileName

                    extencionArchivo = dirArchivo.Substring(dirArchivo.LastIndexOf("."c) + 1).ToLower

                    If Not {"pdf", "jpg", "jpeg", "png"}.Contains(extencionArchivo) Then
                        MuestraMensaje("El tipo de archivo seleccionado no es permitido dentro del sistema. Verifique.",
                                       MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                    If nIDRequerimiento <> 1 Then
                        If Utilerias.TamañoArchivoMB(dirArchivo) > 10.2D Then
                            MuestraMensaje("El tamaño del archivo es mayor a 10 MB, intente con un archivo de menor tamaño. Puede cambiar la calidad para reducir el tamaño.",
                                           MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    Else
                        'Se da un poco mas de 2 MB pero al usuario se le indica que 2 MB solo para no quedar tan exactos.
                        If Utilerias.TamañoArchivoMB(dirArchivo) > 2.1D Then
                            MuestraMensaje("El tamaño del archivo es mayor a 2 MB, intente con un archivo de menor tamaño. Puede cambiar la calidad para reducir el tamaño.",
                                           MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    End If

                    ultimoDoc = datosRequerimiento!nUltimoNum

                    nombreArchivo = dirArchivo.Substring(dirArchivo.LastIndexOf("\"c) + 1).Replace("."c, "").Replace(CStr(extencionArchivo), "")
                    nombreArchivo = nombreArchivo.Replace("""", "&quot;")
                    nombreArchivo = nombreArchivo.Replace("&", "&amp;")

                    If rowArchivos.Length > 0 Then
                        rowArchivo = rowArchivos(0)

                        With rowArchivo
                            !cNombreArchivo = nombreArchivo
                            !cExtencion = extencionArchivo
                            !vArchivo = IO.File.ReadAllBytes(dirArchivo)
                            !bGuardar = True
                        End With
                        MuestraMensaje("Archivo actualizado.", Windows.Forms.MessageBoxIcon.Information)
                    Else
                        'tbArchivos.Rows.Add({0, nIDRequerimiento, 0, ultimoDoc + 1, nombreArchivo, extencionArchivo,
                        '            True, True, IO.File.ReadAllBytes(dirArchivo), dirArchivo})
                        dtArchivos.Rows.Add({0, nIDRequerimiento, 0, ultimoDoc + 1, nombreArchivo, extencionArchivo,
                                        True, True, IO.File.ReadAllBytes(dirArchivo), dirArchivo})
                        dtArchivos.AcceptChanges()

                        datosRequerimiento!nGuardado += 1

                        If CInt(datosRequerimiento!nGuardado) = 1 Then dtDDRequerimientos.AcceptChanges()
                    End If
                End If

            Catch ex As Exception
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)
            End Try
        End If

        If e.Column.FieldName = "bAutorizado" Then
            If Not gnPantalla = EN_Pantallas.CapturaDocumentos Then
                If e.CellValue Is DBNull.Value Then Exit Sub
                Try
                    grvDocumentos.SetRowCellValue(e.RowHandle, grvDocumentos.Columns("bAutorizado"), Not e.CellValue)
                Catch ex As Exception
                    MuestraMensaje(ex.Message, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub ButtonVisualizar_ButtonClick(sender As Object, e As Grid.RowCellClickEventArgs) Handles grvArchivos.RowCellClick
        Dim grv As Grid.GridView = CType(sender, Grid.GridView)
        Dim row As DataRow
        Dim frm As New FrmVisualizarArchivos
        Dim dirArchivo As String
        Dim extencion As String
        Dim nIDDocumento As Long
        Dim bArchivo As Byte()

        If e.Column.FieldName = "cVisualizar" Then
            Try
                row = grv.GetDataRow(grv.FocusedRowHandle)
                dirArchivo = CStr(row!cDirArchivo)
                extencion = CStr(row!cExtencion)
                nIDDocumento = CLng(row!nIDDocumento)

                If dirArchivo = "" Then
                    dirArchivo = My.Computer.FileSystem.GetTempFileName
                    dirArchivo = dirArchivo.Replace(".tmp", "." & extencion)

                    bArchivo = FabricaJuridico.ObtenerBinarioDocumento(nIDDocumento, OrigenDocumentosBinarios.Documentos_Digitalizados_Cliente)

                    IO.File.WriteAllBytes(dirArchivo, bArchivo)
                    row!cDirArchivo = dirArchivo
                    row!vArchivo = bArchivo
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
        End If
    End Sub

    Private Sub Manejador_CambioElemento(sender As Object, e As ManejadorXtraGridAdvanced.SelectedElement_ADSUMXTRA_GRIDArgs) Handles Manejador.CambioElemento
        Dim vDRow As DataRowView = grvDocumentos.GetRow(grvDocumentos.FocusedRowHandle)

        If vDRow IsNot Nothing Then
            If e.Column.Name = "colcMotivo" Then
                Try
                    dtDDRequerimientos.AcceptChanges()
                    e.EsValido = True
                    Return
                Catch ex As Exception
                    MuestraMensaje(ex.ToString, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub chkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodos.CheckedChanged
        If chkTodos.CheckState = CheckState.Checked Then
            For Each drRow As DataRow In dtDDRequerimientos.Rows
                drRow("bAutorizado") = True
                dtDDRequerimientos.AcceptChanges()
            Next
        Else
            For Each drRow As DataRow In dtDDRequerimientos.Rows
                drRow("bAutorizado") = False
                dtDDRequerimientos.AcceptChanges()
            Next
        End If
    End Sub

    Private Sub grvDocumentos_LostFocus(sender As Object, e As EventArgs) Handles grvDocumentos.LostFocus
        grvDocumentos.CloseEditor()
        dtDDRequerimientos.AcceptChanges()
        Application.DoEvents()

    End Sub

    Private Sub btnEspecificaciones_Click(sender As Object, e As EventArgs) Handles btnEspecificaciones.Click
        gpoEspecificaciones.Visible = True
        gpoEspecificaciones.Text = "Especificaciones"
        atxEspecificaciones.Text = drDatosSolicitud("cEspecificaciones")
    End Sub

    Private Sub BtnCerrarComentario_Click(sender As Object, e As EventArgs) Handles btnCerrarEspecificaciones.Click
        atxEspecificaciones.Text = ""
        gpoEspecificaciones.Visible = False
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
            MuestraMensaje("Información guardada con éxito.", MessageBoxIcon.Information)

            plNuevo(False)
        End If
    End Sub

    Protected Overrides Sub ClickBotonEjecutar()
        MyBase.ClickBotonEjecutar()

        Try
            If ATXFolio.Text.Trim = "" Then
                MuestraMensaje("Debe indicar el folio de solicitud.", Windows.Forms.MessageBoxIcon.Error)
                Exit Sub
            End If

            plCargarRequerimientos(ATXFolio.Text.Trim)

            ATXFolio.Enabled = False
            grdDocumentos.Enabled = True
            grdArchivos.Enabled = True

            Me.ToolBarButtons.Ejecutar = False

            'If gnPantalla = EN_Pantallas.VerificaDocumentos Then gpoAcciones.Visible = True

            'If drDatos("nIDEstatusSol") <> 3 Then
            '    Me.ToolBarButtons.Guardar = False
            'Else
            '    Me.ToolBarButtons.Guardar = True
            'End If
        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub




#End Region
End Class