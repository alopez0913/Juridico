Imports ADSUM
Imports Tools.Comun.Tools
Imports Juridico.Dominio
Imports DevExpress.XtraGrid.Views
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO

Public Class FrmM2702005    '   Generación de Contrato / Revisión de Contrato / Liberación de Contrato

#Region "Declaraciones"
    Private ADDA As AsistenteDeDatos_Base
    Private WithEvents Manejador As ManejadorXtraGridAdvanced
    Private WithEvents ManejadorContratosFirmados As ManejadorXtraGridAdvanced
    Protected gnPantalla As Integer
    Private cUsuariosJuridico() As String = {"egarcia", "mquinonez", "rguerrero", "admin"}

    Private dtArchivosContratos As DataTable
    Private dtArchivosContratosFirmados As DataTable
    Private drDatosSolicitud As DataRow

    Dim vRutaArchivo As String = ""

    'Dim dsDatos As DataSet
    'Dim dsDatosContratos As DataSet

    Protected Enum EN_Pantallas
        GeneraVersion = 1
        EvaluaVersion = 2
        LiberaVersion = 3 'Ahora finaliza el contrato por jurídico
        FinalizaVersion = 4 ' Ahora solo sirve para consultar por el usuario
    End Enum

#End Region

#Region "Funciones y Procedimientos"

    Private Sub plNuevo(EsLoad As Boolean)

        If EsLoad Then
            plConfiguraCatalogos()
        Else
            ATXFolio.Enabled = True
            ATXFolio.Text = ""
            txtFolioSeguimiento.Text = ""
            ATXObservacion.Text = ""

            lblNomDepto.Text = ""
            lblNomSolicitante.Text = ""
            lblNomBeneficiario.Text = ""
            lblClasificacion.Text = ""
            lblColorStatus.Visible = False
            lblStatus.Visible = False

            lvContratos.Items.Clear()
            lvContratosFirmados.Items.Clear()

            Utilerias.DestruirObjeto(dtArchivosContratos)
            Utilerias.DestruirObjeto(dtArchivosContratosFirmados)
            plCargarDatos(-1)
            plCargarContratosFirmados(-1)

            drDatosSolicitud = Nothing

            With Me.ToolBarButtons
                .Guardar = False
                .Borrar = False
                .Imprimir = False
                .EnvExcel = False
                .Graficar = False
                .Ejecutar = False
                .Nuevo = True
            End With

            If gnPantalla = EN_Pantallas.GeneraVersion Then
                btnAñadeLiberaPropuesta.Text = "Añadir propuesta"
                btnAñadeLiberaPropuesta.Visible = True
                btnAñadeLiberaPropuesta.Enabled = False

            ElseIf gnPantalla = EN_Pantallas.EvaluaVersion Then
                gpoRespuestaPropuesta.Enabled = False

            ElseIf gnPantalla = EN_Pantallas.LiberaVersion Then
                btnAñadeLiberaPropuesta.Text = "Liberar propuesta"
                btnAñadeLiberaPropuesta.Visible = True
                btnAñadeLiberaPropuesta.Enabled = False
                grdContratosFirmados.Visible = False
                gpoContratosFirmados.Visible = False

            ElseIf gnPantalla = EN_Pantallas.FinalizaVersion Then
                grdContratosFirmados.Enabled = False
            End If

            grdDocumentos.Enabled = False
            ATXFolio.Focus()

        End If
    End Sub

    Private Sub plConsultaSolicitud()
        Dim dtDatos As DataTable = FabricaJuridico.ConsultaSolicitud(ATXFolio.Text)

        If dtDatos.Rows.Count > 0 Then
            drDatosSolicitud = dtDatos.Rows(0)

            If Not drDatosSolicitud("bActivo") Then
                MuestraMensaje("El Folio de solicitud se encuentra cancelado", MessageBoxIcon.Information)
                ATXFolio.Text = ""
                ATXFolio.Focus()

                Return
            End If

            If gnPantalla = EN_Pantallas.EvaluaVersion OrElse gnPantalla = EN_Pantallas.LiberaVersion Then
                If UCase(ADDA.GetLoginUsuario()) <> "ADMIN" Then
                    If Not drDatosSolicitud("cUsuario_Registro") = ADDA.GetLoginUsuario() Then
                        MuestraMensaje("El Folio de solicitud no pertenece al usuario ingresado. Verifique..", MessageBoxIcon.Information)
                        ATXFolio.Text = ""
                        ATXFolio.Focus()

                        Return
                    End If
                End If
            End If

            'Pintar datos en los controles de pantalla 
            Dim s As String = drDatosSolicitud("cDescColor").ToString.Trim
            Dim p = s.Split(","c).Select(Function(x) Int32.Parse(x.Trim()))
            Dim color As Color = Color.FromArgb(p(0), p(1), p(2))

            ATXFolio.Tag = drDatosSolicitud("nIDSolContrato")
            lblNomDepto.Text = drDatosSolicitud("cDepartamento")
            lblNomSolicitante.Text = drDatosSolicitud("cSolicitante")
            lblClasificacion.Text = FabricaJuridico.ConsultaClasificacion(drDatosSolicitud("nClasificacion"))
            lblNomBeneficiario.Text = drDatosSolicitud("cDescBene")
            txtFolioSeguimiento.Text = drDatosSolicitud("cFolioPropuesta")
            lblStatus.Text = drDatosSolicitud("cDescEstatus")

            dtpFechaini.Value = drDatosSolicitud("dFechaIni")
            dtpFechaFin.Value = drDatosSolicitud("dFechaFin")

            lblColorStatus.BackColor = color
            lblColorStatus.Visible = True
            lblStatus.Visible = True
            ATXFolio.Enabled = False
            ATXFolio.Enabled = False

            plCargarDatos(ATXFolio.Text)
            plCargarContratosFirmados(ATXFolio.Text)

            Select Case gnPantalla
                Case EN_Pantallas.FinalizaVersion
                    ToolBarButtons.Ejecutar = False

                    If cUsuariosJuridico.Contains(ADDA.GetLoginUsuario) Then
                        'ToolBarButtons.Guardar = True '2024-06-18 al cambiarle de nombre inhabilite el botón de Guardar
                        lvContratosFirmados.Enabled = True
                    End If

                Case EN_Pantallas.GeneraVersion
                    If drDatosSolicitud("nIDEstatusSol") = 4 OrElse drDatosSolicitud("nIDEstatusSol") = 6 Then
                        btnAñadeLiberaPropuesta.Enabled = True
                    End If

                Case EN_Pantallas.EvaluaVersion
                    If drDatosSolicitud("nIDEstatusSol") = 5 Then
                        gpoRespuestaPropuesta.Enabled = True
                    End If

                Case EN_Pantallas.LiberaVersion, EN_Pantallas.FinalizaVersion
                    plCargarContratosFirmados(ATXFolio.Text().Trim())

                    If drDatosSolicitud("nIDEstatusSol") = 7 OrElse drDatosSolicitud("nIDEstatusSol") = 8 Then
                        btnAñadeLiberaPropuesta.Enabled = True
                    Else
                        grdContratosFirmados.Enabled = False
                        lvContratosFirmados.Enabled = True
                    End If
            End Select

            If gnPantalla <> EN_Pantallas.FinalizaVersion Then
                ToolBarButtons.Guardar = True
            End If

            Utilerias.DestruirObjeto(dtDatos)
        Else
            MuestraMensaje("No se encontro información con el folio de Solicitud indicado. Verifique..", MessageBoxIcon.Information)
            ATXFolio.Focus()
        End If
    End Sub

    Private Sub plConfiguraCatalogos()
        ATXFolio.CatalogoBase = New Catalogo(New MetaCatalogo("JUR_Solicitudes"))

        If gnPantalla = EN_Pantallas.EvaluaVersion OrElse gnPantalla = EN_Pantallas.LiberaVersion Then
            ATXFolio.FiltroExtendido = "cUsuario_Registro = '" & ADDA.GetLoginUsuario & "'"
        End If
    End Sub

    Private Sub plEnviaCorreo(Pantalla As Integer)
        Dim vlCorreo As New clsEnviarEmail
        Dim vlPara, vlConCopia As String
        Dim Obj(6) As Object

        Obj(0) = "JUR_Solicitud"
        Obj(1) = lblNomSolicitante.Text.Trim
        Obj(2) = ATXFolio.Text.Trim
        Obj(3) = FechaEnFormatoYYYYMMDD(DateTime.Today)
        Obj(4) = ADDA.NombreCortoEmpresa
        Obj(5) = ""
        Obj(6) = ""

        vlPara = drDatosSolicitud("cPara")
        vlConCopia = drDatosSolicitud("cConCopia")

        If Pantalla = EN_Pantallas.GeneraVersion Then
            Obj(0) = "JUR_GeneraVersion"
            Dim vlMensaje As String = FabricaJuridico.ObtenPlantillaCorreo(Obj)

            With vlCorreo
                .Correo = "sistemacontratos"
                .Nombre = "Sistema de Juridico de Contratos"
                .Para = vlPara & "," & vlConCopia
                .ConCopia = "derechocorp@adelnor.com"
                .Asunto = "Información sobre el Folio de Solicitud Núm: " & drDatosSolicitud!nIDSolContrato & " de la Empresa: " & ADDA.NombreCortoEmpresa
                .Mensaje = vlMensaje
                .Enviar_Correo()
            End With

        ElseIf Pantalla = EN_Pantallas.EvaluaVersion Then
            Obj(0) = IIf(optAceptar.Checked, "JUR_ValidaVersion", "JUR_RechazaVersion")
            Dim vlMensaje As String = FabricaJuridico.ObtenPlantillaCorreo(Obj)

            With vlCorreo
                .Correo = "sistemacontratos"
                .Nombre = "Sistema de Juridico de Contratos"
                .Para = "derechocorp@adelnor.com"
                .ConCopia = vlPara & "," & vlConCopia
                .Asunto = "Información sobre el Folio de Solicitud Núm: " & drDatosSolicitud!nIDSolContrato & " de la Empresa: " & ADDA.NombreCortoEmpresa
                .Mensaje = vlMensaje
                If optRechazar.Checked = True And lblRutaDetallePropuesta.Text <> "" Then
                    .ListaArchivosAdjuntar.Add(lblRutaDetallePropuesta.Text)
                End If
                .Enviar_Correo()
            End With

        ElseIf Pantalla = EN_Pantallas.LiberaVersion Then 'Al quitar la funcionalidad de la siguiente pantalla modifique para que la tomara desde aqui
            Obj(0) = "JUR_LiberaVersion"
            Dim vlMensaje As String = FabricaJuridico.ObtenPlantillaCorreo(Obj)

            With vlCorreo
                .Correo = "sistemacontratos"
                .Nombre = "Sistema de Juridico de Contratos"
                .Para = "derechocorp@adelnor.com"
                .ConCopia = vlPara & "," & vlConCopia
                .Asunto = "Cambio de Estatus en Folio de Solicitud Núm: " & drDatosSolicitud!nIDSolContrato & " de la Empresa: " & ADDA.NombreCortoEmpresa
                .Mensaje = vlMensaje
                .Enviar_Correo()
            End With

        ElseIf Pantalla = EN_Pantallas.FinalizaVersion Then
            Obj(0) = "JUR_FinalizaVersion"
            Dim vlMensaje As String = FabricaJuridico.ObtenPlantillaCorreo(Obj)

            With vlCorreo
                .Correo = "sistemacontratos"
                .Nombre = "Sistema de Juridico de Contratos"
                .Para = vlPara & "," & vlConCopia
                .ConCopia = "derechocorp@adelnor.com"
                .Asunto = "Cambio de Estatus en Folio de Solicitud Núm: " & drDatosSolicitud!nIDSolContrato & " de la Empresa: " & ADDA.NombreCortoEmpresa
                .Mensaje = vlMensaje
                .Enviar_Correo()
            End With

        End If
    End Sub

    Private Function flValidar() As Boolean
        If ATXFolio.Text.Trim = "" Then
            MuestraMensaje("Debe ingresar un folio de solicitud valido.", MessageBoxIcon.Exclamation)

            Return False
        End If

        If dtpFechaini.Value > dtpFechaFin.Value Then
            Dim vlAux As Date = dtpFechaini.Value
            dtpFechaini.Value = dtpFechaFin.Value
            dtpFechaFin.Value = vlAux
        End If

        If gnPantalla = EN_Pantallas.GeneraVersion Then
            If dtArchivosContratos.Select("bGuardar=true", "").Count() = 0 Then
                MuestraMensaje("No hay documentos que guardar.", MessageBoxIcon.Exclamation)

                Return False
            End If
        ElseIf gnPantalla = EN_Pantallas.EvaluaVersion Then
            If optRechazar.Checked AndAlso ATXObservacion.Text.Length = 0 Then
                MuestraMensaje("Al rechazar una propuesta, debe especificar una observación.", MessageBoxIcon.Exclamation)

                Return False
            End If
        End If

        Return True
    End Function

    Private Function flGuardar() As Boolean
        Try
            If gnPantalla = EN_Pantallas.GeneraVersion Then
                Dim vObj(13) As Object

                For Each vDRow As DataRow In dtArchivosContratos.Rows
                    If vDRow("bGuardar") = True Then

                        vObj(0) = ATXFolio.Text
                        vObj(1) = vDRow("nIDDocumentoDig")
                        vObj(2) = vDRow("nIDReq")
                        vObj(3) = vDRow("nIDDocumento")
                        vObj(4) = vDRow("nConsecutivo")
                        vObj(5) = vDRow("cNombreArchivo")
                        vObj(6) = vDRow("cExtencion")
                        vObj(7) = vDRow("bGuardar")
                        vObj(8) = vDRow("bActivo")
                        vObj(9) = vDRow("dFechaDigit")
                        vObj(10) = vDRow("cUsuario_Registro")
                        vObj(11) = vDRow("vArchivo")
                        vObj(12) = vDRow("cDirArchivo")
                        vObj(13) = txtFolioSeguimiento.Text
                    End If
                Next

                If Not ADDA.TieneTransaccionAbierta Then ADDA.AbreTransaccion()

                If Not EscribanoJuridico.GuardarContratos(vObj) Then
                    If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
                    MuestraMensaje("Ocurrio un problema al guardar la información, intente de nuevo.", MessageBoxIcon.Exclamation)

                    Return False
                End If

                If ADDA.TieneTransaccionAbierta Then ADDA.CierraTransaccion()
                plEnviaCorreo(gnPantalla)

            ElseIf gnPantalla = EN_Pantallas.EvaluaVersion Then
                Dim vObj(3) As Object
                Dim vDRow As DataRow = dtArchivosContratos.Rows(0)

                Dim vExtensionArchivo As String = ""
                Dim vNombreArchivo As String = ""
                Dim nFolioNvo As Integer = 0
                Dim vlbArchivoBytes As Byte()

                vObj(0) = vDRow("nIDDocumentoDig")
                vObj(1) = IIf(optAceptar.Checked, 1, 0)
                vObj(2) = ATXObservacion.Text
                vObj(3) = ADDA.GetLoginUsuario

                If Not ADDA.TieneTransaccionAbierta Then ADDA.AbreTransaccion()

                If Not EscribanoJuridico.ValidaContratos(vObj) Then
                    If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
                    MuestraMensaje("Ocurrio un problema al guardar la información, intente de nuevo.", MessageBoxIcon.Exclamation)

                    Return False
                End If

                If optRechazar.Checked Then
                    If lblRutaDetallePropuesta.Text <> "" Then
                        nFolioNvo = txtFolioSeguimiento.Text

                        'GRABAR IMAGENES
                        If My.Computer.FileSystem.FileExists(lblRutaDetallePropuesta.Text.Trim) Then 'Busca por ruta anterior de almacenaje
                            'Dim vlFecAux As Date = ADDA.RegresaFechaDelSistema
                            vNombreArchivo = Path.GetFileNameWithoutExtension(lblRutaDetallePropuesta.Text.Trim)
                            vExtensionArchivo = Path.GetExtension(lblRutaDetallePropuesta.Text.Trim).Replace(".", "")
                            vlbArchivoBytes = File.ReadAllBytes(lblRutaDetallePropuesta.Text.Trim)

                            If Not Dominio.EscribanoJuridico.GrabarArchivo_DetallePropuesta(nFolioNvo, vNombreArchivo, vExtensionArchivo, vlbArchivoBytes) Then
                                If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
                                Return False
                            End If
                        End If
                    End If

                End If

                If ADDA.TieneTransaccionAbierta Then ADDA.CierraTransaccion()
                plEnviaCorreo(gnPantalla)

            ElseIf gnPantalla = EN_Pantallas.LiberaVersion Then 'ElseIf gnPantalla = EN_Pantallas.FinalizaVersion Then 'Se cambia el punto de terminación de FinalizaVersion a LiberaVersion y se actualizan las fechas para el contrato
                Dim vObj(3) As Object

                vObj(0) = ATXFolio.Text
                vObj(1) = ADDA.GetLoginUsuario
                vObj(2) = FechaEnFormatoYYYYMMDD(dtpFechaini.Value)
                vObj(3) = FechaEnFormatoYYYYMMDD(dtpFechaFin.Value)

                If Not ADDA.TieneTransaccionAbierta Then ADDA.AbreTransaccion()

                If Not EscribanoJuridico.FinalizaContrato(vObj) Then
                    If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
                    MuestraMensaje("Ocurrio un problema al guardar la información, intente de nuevo.", MessageBoxIcon.Exclamation)

                    Return False
                End If

                If ADDA.TieneTransaccionAbierta Then ADDA.CierraTransaccion()
                plEnviaCorreo(gnPantalla)

            End If

            Return True
        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)

            Return False
        End Try
    End Function

    Private Function flLiberaContrato() As Boolean
        Try
            plSubeContratoFirmado()

            Dim vObj(13) As Object

            For Each vDRow As DataRow In dtArchivosContratosFirmados.Rows
                If vDRow("bGuardar") = True Then

                    vObj(0) = ATXFolio.Text
                    vObj(1) = vDRow("nIDDocumentoDig")
                    vObj(2) = vDRow("nIDReq")
                    vObj(3) = vDRow("nIDDocumento")
                    vObj(4) = vDRow("nConsecutivo")
                    vObj(5) = vDRow("cNombreArchivo")
                    vObj(6) = vDRow("cExtencion")
                    vObj(7) = vDRow("bGuardar")
                    vObj(8) = vDRow("bActivo")
                    vObj(9) = vDRow("dFechaDigit")
                    vObj(10) = vDRow("cUsuario_Registro")
                    vObj(11) = vDRow("vArchivo")
                    vObj(12) = vDRow("cDirArchivo")
                    vObj(13) = txtFolioSeguimiento.Text
                End If
            Next

            If Not ADDA.TieneTransaccionAbierta Then ADDA.AbreTransaccion()

            If Not EscribanoJuridico.LiberaContrato(vObj) Then
                If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
                MuestraMensaje("Ocurrio un problema al guardar la información, intente de nuevo.", MessageBoxIcon.Exclamation)

                Return False
            End If

            plEnviaCorreo(gnPantalla)

            Return True
        Catch ex As Exception
            If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)

            Return False
        End Try
    End Function

    Private Sub plCargarDatos(FolioSol As Integer)
        Dim dsTemp As DataSet

        Utilerias.DestruirObjeto(dtArchivosContratos)

        dsTemp = FabricaJuridico.ObtenContratosDigitalizadosCliente(FolioSol)

        If dsTemp Is Nothing AndAlso FolioSol <> -1 Then
            MuestraMensaje("Ocurrio un error al consultar los datos, cierre y abra el sistema y vuelva a intentarlo.", MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        With dsTemp.Tables(0)
            .Columns("nIDDocumento").Caption = "ID Documento"
            .Columns("nConsecutivo").Caption = "Versión"
            .Columns("dFechaDigit").Caption = "Modificado"
            .Columns("cUsuario_Registro").Caption = "Modificado por"
        End With

        grdDocumentos.DataSource = dsTemp
        grdDocumentos.DataMember = dsTemp.Tables(0).TableName

        grvDocumentos.PopulateColumns()

        plConfiguraGrid()

        dtArchivosContratos = dsTemp.Tables(0)

        plConfiguraListViewContratos()

        Utilerias.FormatearColumnasGrid(grvDocumentos)
        Utilerias.AjustarTamañoColumnasGrid(grvDocumentos)
        Utilerias.DestruirObjeto(dsTemp)
    End Sub

    Private Sub plCargarContratosFirmados(FolioSol As Integer)
        Dim dsTemp As DataSet

        Utilerias.DestruirObjeto(dtArchivosContratosFirmados)

        dsTemp = FabricaJuridico.ObtenContratosFirmadosDigitalizados(FolioSol)

        If dsTemp Is Nothing AndAlso FolioSol <> -1 Then
            MuestraMensaje("Ocurrio un error al consultar los datos, cierre y abra el sistema y vuelva a intentarlo.", MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        With dsTemp.Tables(0)
            .Columns("nIDDocumento").Caption = "ID Documento"
            .Columns("nConsecutivo").Caption = "Versión"
            .Columns("dFechaDigit").Caption = "Modificado"
            .Columns("cUsuario_Registro").Caption = "Modificado por"
        End With

        grdContratosFirmados.DataSource = dsTemp
        grdContratosFirmados.DataMember = dsTemp.Tables(0).TableName

        grvContratosFirmados.PopulateColumns()

        plConfiguraGridContratosFirmados()

        dtArchivosContratosFirmados = dsTemp.Tables(0)

        plConfiguraListViewContratosFirmados()

        Utilerias.FormatearColumnasGrid(grvContratosFirmados)
        Utilerias.AjustarTamañoColumnasGrid(grvContratosFirmados)
        Utilerias.DestruirObjeto(dsTemp)
    End Sub

    Private Sub plConfiguraGrid()
        grvDocumentos.Columns("nIDDocumentoDig").Visible = False
        grvDocumentos.Columns("nIDReq").Visible = False
        grvDocumentos.Columns("nIDDocumento").Visible = False
        grvDocumentos.Columns("cNombreArchivo").Visible = False
        grvDocumentos.Columns("cExtencion").Visible = False
        grvDocumentos.Columns("bGuardar").Visible = False
        grvDocumentos.Columns("bActivo").Visible = False
        grvDocumentos.Columns("vArchivo").Visible = False
        grvDocumentos.Columns("cDirArchivo").Visible = False

        grvDocumentos.Columns("nConsecutivo").OptionsColumn.AllowEdit = False
        grvDocumentos.Columns("nConsecutivo").SortOrder = DevExpress.Data.ColumnSortOrder.Descending
        grvDocumentos.Columns("dFechaDigit").OptionsColumn.AllowEdit = False
        grvDocumentos.Columns("dFechaDigit").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
        grvDocumentos.Columns("cUsuario_Registro").OptionsColumn.AllowEdit = False
        grvDocumentos.Columns("cUsuario_Registro").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False

    End Sub

    Private Sub plConfiguraGridContratosFirmados()
        grvContratosFirmados.Columns("nIDDocumentoDig").Visible = False
        grvContratosFirmados.Columns("nIDReq").Visible = False
        grvContratosFirmados.Columns("nIDDocumento").Visible = False
        grvContratosFirmados.Columns("cNombreArchivo").Visible = False
        grvContratosFirmados.Columns("cExtencion").Visible = False
        grvContratosFirmados.Columns("bGuardar").Visible = False
        grvContratosFirmados.Columns("bActivo").Visible = False
        grvContratosFirmados.Columns("vArchivo").Visible = False
        grvContratosFirmados.Columns("cDirArchivo").Visible = False

        grvContratosFirmados.Columns("nConsecutivo").OptionsColumn.AllowEdit = False
        grvContratosFirmados.Columns("nConsecutivo").SortOrder = DevExpress.Data.ColumnSortOrder.Descending
        grvContratosFirmados.Columns("dFechaDigit").OptionsColumn.AllowEdit = False
        grvContratosFirmados.Columns("dFechaDigit").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
        grvContratosFirmados.Columns("cUsuario_Registro").OptionsColumn.AllowEdit = False
        grvContratosFirmados.Columns("cUsuario_Registro").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
    End Sub

    Private Sub plSubeContratoFirmado()
        Dim row As DataRow

        Try
            If dtArchivosContratosFirmados.Rows.Count = 0 Then
                row = dtArchivosContratosFirmados.NewRow
            Else
                row = grvDocumentos.GetDataRow(grvDocumentos.FocusedRowHandle)
            End If

            row!nIDDocumentoDig = 0

            If ofdArchivo.ShowDialog = DialogResult.OK Then
                Dim ultimoDoc As Integer
                Dim nombreArchivo As String
                Dim extencionArchivo As String
                Dim dirArchivo As String

                dirArchivo = ofdArchivo.FileName

                extencionArchivo = dirArchivo.Substring(dirArchivo.LastIndexOf("."c) + 1).ToLower

                If Not {"pdf"}.Contains(extencionArchivo) Then
                    MuestraMensaje("El tipo de archivo seleccionado no es permitido dentro del sistema. Verifique.",
                                       MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                ultimoDoc = IfNull(row!nConsecutivo, 0)
                nombreArchivo = dirArchivo.Substring(dirArchivo.LastIndexOf("\"c) + 1).Replace("."c, "").Replace(CStr(extencionArchivo), "")

                dtArchivosContratosFirmados.Rows.Add({0, 999, 0, ultimoDoc + 1, nombreArchivo, extencionArchivo,
                                    True, True, DateTime.Now, ADDA.GetLoginUsuario, IO.File.ReadAllBytes(dirArchivo), dirArchivo})

                dtArchivosContratosFirmados.AcceptChanges()
            End If

        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub plConfiguraListViewContratosFirmados()
        lvContratosFirmados.Items.Clear()

        Try
            For Each row As DataRow In dtArchivosContratosFirmados.Rows
                Dim listViewItem As ListViewItem = New ListViewItem()

                listViewItem.Text = row("cNombreArchivo")
                listViewItem.Tag = row("nIDDocumentoDig")

                Select Case row("cExtencion").ToString().ToUpper()
                    Case "DOC", "DOCX"
                        listViewItem.ImageIndex = 2

                    Case "PDF"
                        listViewItem.ImageIndex = 0

                    Case "JPG", "PNG", "JPEG"
                        listViewItem.ImageIndex = 1

                    Case "MKV", "AVI", "MP4"
                        listViewItem.ImageIndex = 3
                End Select

                lvContratosFirmados.Items.Add(listViewItem)
            Next

            lvContratosFirmados.Visible = True
            lvContratosFirmados.Enabled = True
        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub plConfiguraListViewContratos()
        lvContratos.Items.Clear()

        Try
            For Each row As DataRow In dtArchivosContratos.Rows
                Dim listViewItem As ListViewItem = New ListViewItem()

                listViewItem.Text = row("cNombreArchivo")
                listViewItem.Tag = row("nIDDocumentoDig")

                Select Case row("cExtencion").ToString().ToUpper()
                    Case "DOC", "DOCX"
                        listViewItem.ImageIndex = 2

                    Case "PDF"
                        listViewItem.ImageIndex = 0

                    Case "JPG", "PNG", "JPEG"
                        listViewItem.ImageIndex = 1

                    Case "MKV", "AVI", "MP4"
                        listViewItem.ImageIndex = 3
                End Select

                lvContratos.Items.Add(listViewItem)
            Next

        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Eventos"
    Private Sub FrmM2702005_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            ADDA = AsistenteDeDatos_Base.DevuelveInstancia()
            Manejador = New ManejadorXtraGridAdvanced(grdDocumentos)
            Manejador.Estilo = ManejadorXtraGridAdvanced.Estilos.Seleccion

            ManejadorContratosFirmados = New ManejadorXtraGridAdvanced(grdContratosFirmados)
            ManejadorContratosFirmados.Estilo = ManejadorXtraGridAdvanced.Estilos.Seleccion

            plNuevo(True)

            plCargarDatos(-1)
            plCargarContratosFirmados(-1)

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

            If gnPantalla = EN_Pantallas.GeneraVersion Then
                btnAñadeLiberaPropuesta.Text = "Añadir propuesta"
                btnAñadeLiberaPropuesta.Visible = True
                btnAñadeLiberaPropuesta.Enabled = False

            ElseIf gnPantalla = EN_Pantallas.EvaluaVersion Then
                Dim drwPoint As Point
                drwPoint.X = 15
                drwPoint.Y = 341

                gpoRespuestaPropuesta.Visible = True
                gpoRespuestaPropuesta.Location = drwPoint
                btnAñadeLiberaPropuesta.Visible = False

            ElseIf gnPantalla = EN_Pantallas.LiberaVersion Then
                btnAñadeLiberaPropuesta.Text = "Liberar propuesta"
                btnAñadeLiberaPropuesta.Visible = True
                btnAñadeLiberaPropuesta.Enabled = False

                grdContratosFirmados.Visible = False
                gpoContratosFirmados.Visible = False

                grboxVigencia.Visible = True

            ElseIf gnPantalla = EN_Pantallas.FinalizaVersion Then
                grdContratosFirmados.Enabled = False
                grdContratosFirmados.Visible = False
                gpoContratosFirmados.Visible = True

            End If

        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmM2102005_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Utilerias.DestruirObjeto(Me.dtArchivosContratos)
        Utilerias.DestruirObjeto(Me.dtArchivosContratosFirmados)
    End Sub

    Private Sub ATXFolio_CambioElemento(sender As Object, e As SelectedElementArgs) Handles ATXFolio.CambioElemento
        Try
            If Not String.IsNullOrEmpty(ATXFolio.Text.Trim) Then
                plConsultaSolicitud()
            End If
        Catch ex As Exception
            MuestraMensaje(ex.ToString, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub pbLiberarPropuesta_DoubleClick(sender As Object, e As EventArgs)
        If Not flValidar() Then Return

        If MensajePregunta("Esta por realizar la liberación del contrato." & vbCr & "Requiere subir el archivo del contrato firmado. ¿Desea continuar?") = DialogResult.No Then Return

        If flLiberaContrato() Then
            MuestraMensaje("Información guardada con éxito.", MessageBoxIcon.Information)

            plNuevo(False)
        End If
    End Sub

    Private Sub btnAñadeLiberaPropuesta_Click(sender As Object, e As EventArgs) Handles btnAñadeLiberaPropuesta.Click
        If gnPantalla = EN_Pantallas.GeneraVersion Then
            Dim nIDRequerimiento As Integer
            Dim nuevoArchivo As DataRow = dtArchivosContratos.NewRow

            Try
                nuevoArchivo("nIDDocumentoDig") = 0

                If ofdArchivo.ShowDialog = DialogResult.OK Then
                    Dim ultimoDoc As Integer = IfNull(nuevoArchivo("nConsecutivo"), 0)
                    Dim nombreArchivo As String
                    Dim extencionArchivo As String
                    Dim dirArchivo As String

                    dirArchivo = ofdArchivo.FileName

                    extencionArchivo = dirArchivo.Substring(dirArchivo.LastIndexOf("."c) + 1).ToLower

                    If Not {"pdf"}.Contains(extencionArchivo) Then
                        MuestraMensaje("El tipo de archivo seleccionado no es permitido dentro del sistema. Verifique.",
                                           MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                    nombreArchivo = dirArchivo.Substring(dirArchivo.LastIndexOf("\"c) + 1).Replace("."c, "").Replace(CStr(extencionArchivo), "")

                    dtArchivosContratos.Rows.Add({0, nIDRequerimiento, 0, ultimoDoc + 1, nombreArchivo, extencionArchivo,
                                        True, True, DateTime.Now, ADDA.GetLoginUsuario, IO.File.ReadAllBytes(dirArchivo), dirArchivo})

                    dtArchivosContratos.AcceptChanges()
                End If

                plConfiguraListViewContratos()
            Catch ex As Exception
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)
            End Try

        ElseIf gnPantalla = EN_Pantallas.LiberaVersion Then
            If Not flValidar() Then Return

            If MensajePregunta("Esta por realizar la liberación del contrato." & vbCr & "Requiere subir el archivo del contrato firmado. ¿Desea continuar?") = DialogResult.No Then Return

            If flLiberaContrato() Then
                MuestraMensaje("Información guardada con éxito.", MessageBoxIcon.Information)

                plNuevo(False)
            End If
        End If
    End Sub

    Private Sub lvContratos_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvContratos.MouseDoubleClick
        Dim row() As DataRow
        Dim frm As New FrmVisualizarArchivos
        Dim dirArchivo As String
        Dim extencion As String
        Dim nIDDocumento As Long
        Dim bArchivo As Byte()

        Try
            row = dtArchivosContratos.Select("nIDDocumentoDig=" & lvContratos.Items(lvContratos.FocusedItem.Index).Tag)
            dirArchivo = CStr(row(0)("cDirArchivo"))
            extencion = CStr(row(0)("cExtencion"))
            nIDDocumento = CLng(row(0)("nIDDocumento"))

            If dirArchivo = "" Then
                dirArchivo = My.Computer.FileSystem.GetTempFileName
                dirArchivo = dirArchivo.Replace(".tmp", "." & extencion)

                bArchivo = FabricaJuridico.ObtenerBinarioDocumento(nIDDocumento, OrigenDocumentosBinarios.Contratos)

                IO.File.WriteAllBytes(dirArchivo, bArchivo)
                row(0)!cDirArchivo = dirArchivo
                row(0)!vArchivo = bArchivo
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

    Private Sub lvContratos_KeyDown(sender As Object, e As KeyEventArgs) Handles lvContratos.KeyDown
        If e.KeyCode = Keys.Delete Then
            If lvContratos.SelectedItems.Count > 0 Then
                If MensajePregunta("¿Desea eliminar el/los archivos seleccionados?") = DialogResult.No Then Return

                Dim item As ListViewItem = lvContratos.SelectedItems(0)
                Dim filasEliminar() As DataRow = dtArchivosContratos.Select("nIDDocumentoDig =" & item.Tag)

                If filasEliminar IsNot Nothing Then
                    For Each fila As DataRow In filasEliminar
                        fila.Delete()
                    Next

                    dtArchivosContratos.AcceptChanges()
                    lvContratos.Items.Remove(item)
                End If
            End If
        End If
    End Sub

    Private Sub lvContratosFirmados_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvContratosFirmados.MouseDoubleClick
        Dim row() As DataRow
        Dim frm As New FrmVisualizarArchivos
        Dim dirArchivo As String
        Dim extencion As String
        Dim nIDDocumento As Long
        Dim bArchivo As Byte()

        Try
            row = dtArchivosContratosFirmados.Select("nIDDocumentoDig=" & lvContratosFirmados.Items(lvContratosFirmados.FocusedItem.Index).Tag)
            dirArchivo = CStr(row(0)("cDirArchivo"))
            extencion = CStr(row(0)("cExtencion"))
            nIDDocumento = CLng(row(0)("nIDDocumento"))

            If dirArchivo = "" Then
                dirArchivo = My.Computer.FileSystem.GetTempFileName
                dirArchivo = dirArchivo.Replace(".tmp", "." & extencion)

                bArchivo = FabricaJuridico.ObtenerBinarioDocumento(nIDDocumento, OrigenDocumentosBinarios.ContratosFirmados)

                IO.File.WriteAllBytes(dirArchivo, bArchivo)
                row(0)!cDirArchivo = dirArchivo
                row(0)!vArchivo = bArchivo
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

    Private Sub grvDocumentos_DoubleClick(sender As Object, e As EventArgs) Handles grvDocumentos.DoubleClick
        Dim grv As Grid.GridView = CType(sender, Grid.GridView)
        Dim row As DataRow
        Dim frm As New FrmVisualizarArchivos
        Dim dirArchivo As String
        Dim extencion As String
        Dim nIDDocumento As Long
        Dim bArchivo As Byte()

        Try
            row = grv.GetDataRow(grv.FocusedRowHandle)
            dirArchivo = CStr(row!cDirArchivo)
            extencion = CStr(row!cExtencion)
            nIDDocumento = CLng(row!nIDDocumento)

            If dirArchivo = "" Then
                dirArchivo = My.Computer.FileSystem.GetTempFileName
                dirArchivo = dirArchivo.Replace(".tmp", "." & extencion)

                bArchivo = FabricaJuridico.ObtenerBinarioDocumento(nIDDocumento, OrigenDocumentosBinarios.Contratos)

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
    End Sub

    Private Sub grvContratosFirmados_DoubleClick(sender As Object, e As EventArgs) Handles grvContratosFirmados.DoubleClick
        Dim grv As Grid.GridView = CType(sender, Grid.GridView)
        Dim row As DataRow
        Dim frm As New FrmVisualizarArchivos
        Dim dirArchivo As String
        Dim extencion As String
        Dim nIDDocumento As Long
        Dim bArchivo As Byte()

        Try
            row = grv.GetDataRow(grv.FocusedRowHandle)
            dirArchivo = CStr(row!cDirArchivo)
            extencion = CStr(row!cExtencion)
            nIDDocumento = CLng(row!nIDDocumento)

            If dirArchivo = "" Then
                dirArchivo = My.Computer.FileSystem.GetTempFileName
                dirArchivo = dirArchivo.Replace(".tmp", "." & extencion)

                bArchivo = FabricaJuridico.ObtenerBinarioDocumento(nIDDocumento, OrigenDocumentosBinarios.ContratosFirmados)

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
    End Sub

    Private Sub optAceptar_CheckedChanged(sender As Object, e As EventArgs) Handles optAceptar.CheckedChanged
        If optRechazar.Checked Then
            ATXObservacion.Enabled = True
            ATXObservacion.Focus()
        Else

            ATXObservacion.Enabled = False
            lblRutaDetallePropuesta.Text = ""
        End If
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

    Private Sub btnAdjuntarMasDetalle_Click(sender As Object, e As EventArgs) Handles btnAdjuntarMasDetalle.Click
        Try
            Dim ofdDetallePropuesta As New OpenFileDialog()

            Dim vExtensionArchivo As String = ""
            Dim vNombreArchivo As String = ""

            ofdDetallePropuesta.Filter = "Documento (*.docx)|*.docx|Documento PDF (*.pdf)|*.pdf"

            vRutaArchivo = lblRutaDetallePropuesta.Text.Trim
            If vRutaArchivo <> "" Then
                If MsgBox("¿Desea quitar la ruta del archivo anterior?", vbYesNo) = vbYes Then
                    vRutaArchivo = ""
                    lblRutaDetallePropuesta.Text = ""
                    'Exit Sub
                End If
            End If

            If ofdDetallePropuesta.ShowDialog = System.Windows.Forms.DialogResult.OK Then

                vRutaArchivo = ofdDetallePropuesta.FileName

                lblRutaDetallePropuesta.Text = vRutaArchivo

                vExtensionArchivo = Path.GetExtension(vRutaArchivo).Replace(".", "")
                vNombreArchivo = Path.GetFileNameWithoutExtension(vRutaArchivo)

                If Not {"pdf", "docx"}.Contains(vExtensionArchivo) Then
                    MuestraMensaje("El tipo de archivo seleccionado no es permitido dentro del sistema. Verifique.",
                                   MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                If Utilerias.TamañoArchivoMB(vRutaArchivo) > 5.1D Then
                    MuestraMensaje("El tamaño del archivo es mayor a 5 MB, intente con un archivo de menor tamaño. Puede cambiar la calidad (escala de grises) para reducir el tamaño.",
                               MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Else

            End If

        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)

        Finally

        End Try
    End Sub

    Private Sub lblRutaDetallePropuesta_DoubleClick(sender As Object, e As EventArgs) Handles lblRutaDetallePropuesta.DoubleClick
        Try
            Dim vExtensionArchivo As String = ""
            Dim vNombreArchivo As String = ""
            vExtensionArchivo = Path.GetExtension(vRutaArchivo).Replace(".", "")
            vNombreArchivo = Path.GetFileNameWithoutExtension(vRutaArchivo)

            If vExtensionArchivo <> "" Then
                If lblRutaDetallePropuesta.Text.Trim <> "" Then
                    Process.Start(lblRutaDetallePropuesta.Text.Trim)
                End If
            End If

        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub

#End Region

End Class