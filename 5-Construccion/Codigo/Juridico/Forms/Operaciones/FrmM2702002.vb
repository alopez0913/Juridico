Imports System.Drawing
Imports System.IO
Imports ADSUM
Imports DevExpress.XtraGrid.Views.Grid
Imports Juridico.Dominio
Imports Juridico.Enumeradores
Imports Tools.Comun.Tools

Public Class FrmM2702002    '   Clasificación / RetroAlimentación / Cancelación Solicitudes

#Region "Declaraciones"
    Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
    Private WithEvents MXgrdSolicitudes As ManejadorXtraGridAdvanced

    Protected gnTipoPantalla As Integer

    Dim dsSolicitudes As DataSet
    Dim dtSolicitudes As DataTable

    Dim nIDSolicitud As Integer = 0
    Dim cNombreusuario As String = ""

    Dim FrmWait As Tools.Comun.frmStatus
#End Region

#Region "Procedimientos y Funciones"

    Private Sub plNuevo()
        nIDSolicitud = 0
        cNombreusuario = ""

        rdPorSolicitante.Checked = False
        rdPorFecha.Checked = False
        rdPorFolio.Checked = False

        dtpFechaInicio.Value = DamePrimerDiaDelMes(DateTime.Now)
        dtpFechaFin.Value = DateTime.Now

        atxFolio.Text = ""
        atxSolicitante.Text = ""
        lblNombreSolicitante.Text = ""

        ConsultaSolicitudes()
    End Sub

    Private Sub InicializarCatalogos()
        Try
            atxSolicitante.CatalogoBase = New Catalogo(New MetaCatalogo("CTL_UsuariosNuevoERP_Nansa"))
            atxFolio.CatalogoBase = New Catalogo(New MetaCatalogo("JUR_SolicitudesSinClasifica"))

        Catch ex As Exception
            MuestraMensaje("Ocurrió un error al intentar inicializar los catalogos", MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ConsultaSolicitudes()
        Dim vlnTipo As Byte, vlcSolicitante As String

        Try
            Utilerias.DestruirObjeto(dsSolicitudes)
            Utilerias.DestruirObjeto(dtSolicitudes)
            dtSolicitudes = New DataTable

            If Not rdPorSolicitante.Checked And Not rdPorFecha.Checked And Not rdPorFolio.Checked Then
                vlnTipo = 0

                dsSolicitudes = FabricaJuridico.ObtenerSolicitudesSinClasificar(vlnTipo, , dtpFechaInicio.Value, dtpFechaFin.Value)
            Else
                If rdPorSolicitante.Checked Then
                    If atxSolicitante.Text = "" Then
                        MuestraMensaje("Debe especificar un solicitante", MessageBoxIcon.Information)

                        Exit Sub
                    End If

                    vlnTipo = 1
                    vlcSolicitante = atxSolicitante.Text

                    dsSolicitudes = FabricaJuridico.ObtenerSolicitudesSinClasificar(vlnTipo, vlcSolicitante)
                ElseIf rdPorFecha.Checked Then
                    If dtpFechaInicio.Value > dtpFechaFin.Value Then
                        MuestraMensaje("La fecha inicial no puede ser mayor a la fecha final", MessageBoxIcon.Information)

                        Exit Sub
                    End If

                    vlnTipo = 2

                    dsSolicitudes = FabricaJuridico.ObtenerSolicitudesSinClasificar(vlnTipo, "", dtpFechaInicio.Value, dtpFechaFin.Value)
                Else
                    If String.IsNullOrEmpty(atxFolio.Text) Then
                        MuestraMensaje("Debe especificar folio de solicitud", MessageBoxIcon.Information)

                        Exit Sub
                    End If

                    vlnTipo = 3

                    dsSolicitudes = FabricaJuridico.ObtenerSolicitudesSinClasificar(vlnTipo, "", , , atxFolio.Text)
                End If
            End If

            If dsSolicitudes.Tables(0).Rows.Count > 0 Then
                dtSolicitudes = dsSolicitudes.Tables(0)
                dtSolicitudes.Columns("Visualizar").Caption = "Ver Propuesta"

                grdSolicitudes.DataSource = dtSolicitudes

                Utilerias.CargarColumnasGrid(grvSolicitudes, {"nIDEstatus"}, False)

                With grvSolicitudes
                    .Columns("Folio").Width = 75
                    .Columns("Folio").OptionsColumn.AllowEdit = False

                    .Columns("Solicitante").Width = 300
                    .Columns("Solicitante").OptionsColumn.AllowEdit = False

                    .Columns("Contratante").Width = 350
                    .Columns("Contratante").OptionsColumn.AllowEdit = False

                    .Columns("FechaSolicitud").Width = 150
                    .Columns("FechaSolicitud").OptionsColumn.AllowEdit = False

                    .Columns("FechaInicial").Width = 150
                    .Columns("FechaFinal").Width = 150
                End With

                Dim xBoton As New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
                xBoton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor

                grdSolicitudes.RepositoryItems.Add(xBoton)
                grvSolicitudes.Columns("Visualizar").ColumnEdit = xBoton
                grvSolicitudes.Columns("Visualizar").Width = 100
                grvSolicitudes.Columns("Visualizar").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False

                grvSolicitudes.Columns("cCorreo").Visible = False
                grvSolicitudes.Columns("cCorreo2").Visible = False

            Else
                MuestraMensaje("No se encontro información de solicitudes pendientes de clasificar", MessageBoxIcon.Information)
                Me.ToolBarButtons.Guardar = False
            End If

        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
        End Try

        Me.ToolBarButtons.Guardar = True
    End Sub

    Private Function flValidaGuardar() As Boolean
        Dim dtTemp As New DataTable

        dtSolicitudes.AcceptChanges()
        dtTemp = dtSolicitudes.Select("Cancelar = True").CopyToDataTable


        If dtTemp.Rows.Count = 0 Then
            MuestraMensaje("No se ha marcado ninguna operación para la(s) solicitud(es) selecccionada(s)", MessageBoxIcon.Information)

            Return False
        End If

        Utilerias.DestruirObjeto(dtTemp)

        Return True
    End Function

    Private Function flGuardar() As Boolean
        Try
            dtSolicitudes.AcceptChanges()

            For Each fila As DataRow In dtSolicitudes.Rows
                'If fila("Clasificar") = True Then
                '    If EscribanoJuridico.ActualizarSolicitudesContrato(fila("Folio"), EstatusSolicitudes.Clasificado, "", fila("CodigoClasificacion")) Then
                '        plCorreoClasificaSolicitud(fila("Folio"), fila("Correo1"), fila("Correo2"))
                '    End If
                'End If

                'If fila("Retroalimentar") = True Then
                '    If EscribanoJuridico.ActualizarSolicitudesContrato(fila("Folio"), EstatusSolicitudes.RetroAlimentacion, fila("ComentariosRetro")) Then
                '        plCorreoRetroalimentacionSolicitud(fila("Folio"), fila("Correo1"), fila("Correo2"), fila("ComentariosRetro"))
                '    End If
                'End If

                If fila("Cancelar") = True Then
                    If EscribanoJuridico.ActualizarSolicitudesContrato(fila("Folio"), EstatusSolicitudes_New.Cancelado, fila("ComentariosCancelacion")) Then
                        plCorreoCancelacionSolicitud(fila("Folio"), fila("cCorreo"), fila("cCorreo2"), fila("ComentariosCancelacion"))
                    End If
                End If
            Next

            Return True
        Catch ex As Exception
            MuestraMensaje("Fallo la actualización de los registros", MessageBoxIcon.Error)
            Return False

        End Try
    End Function

    Private Sub plCorreoClasificaSolicitud(prmFolio As Integer, prmCorreo1 As String, prmCorreo2 As String)
        Dim vlCorreo As New clsEnviarEmail
        Dim vlPara, vlConCopia As String
        Dim Obj(6) As Object

        Obj(0) = "JUR_Clasifica"
        Obj(1) = ""
        Obj(2) = prmFolio
        Obj(3) = FechaEnFormatoYYYYMMDD(DateTime.Today)
        Obj(4) = ADDA.NombreCortoEmpresa
        Obj(5) = ""
        Obj(6) = ""

        Dim vlMensaje As String = FabricaJuridico.ObtenPlantillaCorreo(Obj)

        vlPara = prmCorreo1.Trim & "," & prmCorreo2.Trim
        vlConCopia = "derechocorp@adelnor.com"

        Try
            With vlCorreo
                .Correo = "sistemacontratos"
                .Nombre = "Sistema de Juridico de Contratos"
                .Para = vlPara
                .ConCopia = vlConCopia
                .Asunto = "Cambio de Estatus en Folio de Solicitud Núm: " & prmFolio & " de la Empresa: " & ADDA.NombreCortoEmpresa
                .Mensaje = vlMensaje
                .Enviar_Correo()
            End With
        Catch ex As Exception
            MuestraMensaje("Ocurrio un fallo al enviar correos.", MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub plCorreoRetroalimentacionSolicitud(prmFolio As Integer, prmCorreo1 As String, prmCorreo2 As String, prmComentariosRetro As String)
        Dim vlCorreo As New clsEnviarEmail
        Dim vlPara, vlConCopia As String
        Dim Obj(6) As Object

        Obj(0) = "JUR_Retro"
        Obj(1) = ""
        Obj(2) = prmFolio
        Obj(3) = FechaEnFormatoYYYYMMDD(DateTime.Today)
        Obj(4) = ADDA.NombreCortoEmpresa
        Obj(5) = prmComentariosRetro.Trim
        Obj(6) = ""

        Dim vlMensaje As String = FabricaJuridico.ObtenPlantillaCorreo(Obj)

        vlPara = prmCorreo1.Trim & "," & prmCorreo2.Trim
        vlConCopia = "derechocorp@adelnor.com"

        Try
            With vlCorreo
                .Correo = "sistemacontratos"
                .Nombre = "Sistema de Juridico de Contratos"
                .Para = vlPara
                .ConCopia = vlConCopia
                .Asunto = "Retroalimentación de Solicitud De Contrato Núm: " & prmFolio & " de la Empresa: " & ADDA.NombreCortoEmpresa
                .Mensaje = vlMensaje
                .Enviar_Correo()
            End With
        Catch ex As Exception
            MuestraMensaje("Ocurrio un fallo al enviar correos.", MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub plCorreoCancelacionSolicitud(prmFolio As Integer, prmCorreo1 As String, prmCorreo2 As String, prmComentariosCancelacion As String)
        Dim vlCorreo As New clsEnviarEmail
        Dim vlPara, vlConCopia As String
        Dim Obj(6) As Object

        Obj(0) = "JUR_CancelaSolicitud"
        Obj(1) = ""
        Obj(2) = prmFolio
        Obj(3) = FechaEnFormatoYYYYMMDD(DateTime.Today)
        Obj(4) = ADDA.NombreCortoEmpresa
        Obj(5) = prmComentariosCancelacion.Trim
        Obj(6) = ""

        Dim vlMensaje As String = FabricaJuridico.ObtenPlantillaCorreo(Obj)

        vlPara = prmCorreo1.Trim & "," & prmCorreo2.Trim
        vlConCopia = "derechocorp@adelnor.com"

        Try
            With vlCorreo
                .Correo = "sistemacontratos"
                .Nombre = "Sistema de Juridico de Contratos"
                .Para = vlPara
                .ConCopia = vlConCopia
                .Asunto = "Cancelación de Solicitud De Contrato Núm: " & prmFolio & " de la Empresa: " & ADDA.NombreCortoEmpresa
                .Mensaje = vlMensaje
                .Enviar_Correo()
            End With
        Catch ex As Exception
            MuestraMensaje("Ocurrio un fallo al enviar correos.", MessageBoxIcon.Information)
        End Try
    End Sub
#End Region

#Region "Eventos"
    Private Sub FrmM2702002_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With Me.ToolBarButtons
            .Borrar = False
            .Imprimir = False
            .EnvExcel = False
            .Ejecutar = True
            .Autorizar = False
            .Archivos = False
            .Herramientas = False
            .Invertir = False
        End With

        InicializarCatalogos()

        MXgrdSolicitudes = New ManejadorXtraGridAdvanced(grdSolicitudes)
        MXgrdSolicitudes.Estilo = ManejadorXtraGridAdvanced.Estilos.Seleccion

        dtpFechaInicio.Value = DamePrimerDiaDelMes(DateTime.Now)
        dtpFechaFin.Value = DateTime.Now

        gpoSolicitante.Enabled = False
        gpoFecha.Enabled = False
        gpoFolio.Enabled = False

        ConsultaSolicitudes()
    End Sub

    Private Sub atxFolio_CambioElemento(sender As Object, e As SelectedElementArgs) Handles atxFolio.CambioElemento
        dtSolicitudes.Rows.Clear()

        ConsultaSolicitudes()
    End Sub

    Private Sub atxSolicitante_CambioElemento(sender As Object, e As SelectedElementArgs) Handles atxSolicitante.CambioElemento
        dtSolicitudes.Rows.Clear()

        ConsultaSolicitudes()
    End Sub

    Private Sub grvSolicitudes_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles grvSolicitudes.RowCellClick
        Dim vlClasificar As Boolean = False
        Dim vlRetroalimentacion As Boolean = False
        Dim vlCancelar As Boolean = False

        Try
            Select Case e.Column.FieldName
                Case Is = "Clasificar"
                    vlClasificar = grvSolicitudes.GetRowCellValue(e.RowHandle, grvSolicitudes.Columns("Clasificar"))

                    If vlClasificar Then
                        grvSolicitudes.SetRowCellValue(e.RowHandle, grvSolicitudes.Columns("Clasificar"), Not e.CellValue)
                    Else
                        grvSolicitudes.SetRowCellValue(e.RowHandle, grvSolicitudes.Columns("Clasificar"), Not e.CellValue)

                        grvSolicitudes.SetRowCellValue(e.RowHandle, grvSolicitudes.Columns("Retroalimentar"), False)
                        grvSolicitudes.SetRowCellValue(e.RowHandle, grvSolicitudes.Columns("Cancelar"), False)

                        Dim frm As New FrmM2702002_Clasifica

                        If frm.ShowDialog() = DialogResult.OK Then
                            If frm.Resultado = 0 Then
                                grvSolicitudes.SetRowCellValue(e.RowHandle, grvSolicitudes.Columns("Clasificar"), Not e.CellValue)
                                Exit Sub
                            Else
                                grvSolicitudes.SetRowCellValue(e.RowHandle, grvSolicitudes.Columns("CodigoClasificacion"), frm.Resultado)
                            End If
                        End If

                        frm.Dispose()
                    End If

                Case Is = "Retroalimentar"
                    grvSolicitudes.SetRowCellValue(e.RowHandle, grvSolicitudes.Columns("Retroalimentar"), Not e.CellValue)

                    grvSolicitudes.SetRowCellValue(e.RowHandle, grvSolicitudes.Columns("Clasificar"), False)
                    grvSolicitudes.SetRowCellValue(e.RowHandle, grvSolicitudes.Columns("Cancelar"), False)

                    vlRetroalimentacion = grvSolicitudes.GetRowCellValue(e.RowHandle, grvSolicitudes.Columns("Retroalimentar"))
                    If vlRetroalimentacion Then
                        Dim userMsg As String = ""
                        userMsg = Microsoft.VisualBasic.InputBox("¿Cuál es el motivo de la retroalimentación?", "RETROALIMENTACIÓN", "Ingrese su comentario aquí")
                        If userMsg <> "" And userMsg <> "Ingrese su comentario aquí" Then
                            grvSolicitudes.SetRowCellValue(e.RowHandle, grvSolicitudes.Columns("ComentariosRetro"), userMsg)
                        End If
                    Else
                        grvSolicitudes.SetRowCellValue(e.RowHandle, grvSolicitudes.Columns("ComentariosRetro"), "")
                    End If

                Case Is = "Cancelar"
                    grvSolicitudes.SetRowCellValue(e.RowHandle, grvSolicitudes.Columns("Cancelar"), Not e.CellValue)

                    grvSolicitudes.SetRowCellValue(e.RowHandle, grvSolicitudes.Columns("Clasificar"), False)
                    grvSolicitudes.SetRowCellValue(e.RowHandle, grvSolicitudes.Columns("Retroalimentar"), False)

                    vlCancelar = grvSolicitudes.GetRowCellValue(e.RowHandle, grvSolicitudes.Columns("Cancelar"))
                    If vlCancelar Then
                        Dim userMsg As String = ""
                        userMsg = Microsoft.VisualBasic.InputBox("¿Cuál es el motivo de cancelación?", "CANCELACIÓN", "Ingrese su comentario aquí")
                        If userMsg <> "" And userMsg <> "Ingrese su comentario aquí" Then
                            grvSolicitudes.SetRowCellValue(e.RowHandle, grvSolicitudes.Columns("ComentariosCancelacion"), userMsg)
                        End If
                    Else
                        grvSolicitudes.SetRowCellValue(e.RowHandle, grvSolicitudes.Columns("ComentariosCancelacion"), "")
                    End If

                Case Is = "Visualizar"
                    Dim row As DataRow = grvSolicitudes.GetDataRow(grvSolicitudes.FocusedRowHandle)
                    Dim frm As New FrmVisualizarArchivos
                    Dim dirArchivo As String
                    Dim extencion As String
                    Dim bArchivo As Byte()

                    Dim dsTemp As DataSet

                    dsTemp = FabricaJuridico.ObtenArchivoPropuesta(row("Folio"))

                    If dsTemp Is Nothing OrElse dsTemp.Tables(0).Rows.Count = 0 Then
                        Exit Sub
                    End If

                    Try
                        extencion = CStr(dsTemp.Tables(0).Rows(0)("cExtension"))
                        dirArchivo = My.Computer.FileSystem.GetTempFileName
                        dirArchivo = dirArchivo.Replace(".tmp", "." & extencion)
                        bArchivo = dsTemp.Tables(0).Rows(0)("bArchivo")

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
                        Utilerias.DestruirObjeto(dsTemp)
                    End Try
            End Select
        Catch ex As Exception
            ex.ToString()
        End Try
    End Sub

    Private Sub grvSolicitudes_DoubleClick(sender As Object, e As EventArgs) Handles grvSolicitudes.DoubleClick
        Dim renglon As DataRow = grvSolicitudes.GetDataRow(grvSolicitudes.FocusedRowHandle)

        Try
            Dim frm As New FrmM2702002_CambioFechas(renglon("Folio"), renglon("FechaInicial"), renglon("FechaFinal"))

            If frm.ShowDialog() = DialogResult.OK Then
                If frm.bResultado Then
                    ConsultaSolicitudes()
                End If
            End If

            frm.Dispose()
        Catch ex As Exception
            MuestraMensaje("", MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub rdPorSolicitante_CheckedChanged(sender As Object, e As EventArgs) Handles rdPorSolicitante.CheckedChanged
        If sender.Checked = True Then
            gpoSolicitante.Enabled = True
            atxSolicitante.Enabled = True
            atxSolicitante.Text = ""
            lblNombreSolicitante.Text = ""
            gpoFecha.Enabled = False
            gpoFolio.Enabled = False

            dtSolicitudes.Rows.Clear()
            atxSolicitante.Focus()
        Else
            gpoSolicitante.Enabled = False
        End If
    End Sub

    Private Sub rdPorFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rdPorFecha.CheckedChanged
        If sender.Checked = True Then
            gpoSolicitante.Enabled = False
            gpoFecha.Enabled = True
            dtpFechaInicio.Enabled = True
            dtpFechaFin.Enabled = True
            gpoFolio.Enabled = False

            dtSolicitudes.Rows.Clear()
            dtpFechaInicio.Focus()
        Else
            gpoFecha.Enabled = False
        End If
    End Sub

    Private Sub rdPorFolio_CheckedChanged(sender As Object, e As EventArgs) Handles rdPorFolio.CheckedChanged
        If sender.Checked = True Then
            gpoSolicitante.Enabled = False
            gpoFecha.Enabled = False
            gpoFolio.Enabled = True
            atxFolio.Enabled = True

            dtSolicitudes.Rows.Clear()
            atxFolio.Focus()
        Else
            gpoFecha.Enabled = False
        End If
    End Sub
#End Region

#Region "OVERRIDES"

    Protected Overrides Sub ClickBotonNuevo()
        MyBase.ClickBotonNuevo()

        If MensajeConfirmaLimpiarPantalla() = DialogResult.No Then Return

        plNuevo()
    End Sub

    Protected Overrides Sub ClickBotonGuardar()
        MyBase.ClickBotonGuardar()

        If Not flValidaGuardar() Then Return

        If ConfirmaGuardar() = DialogResult.No Then Return

        If flGuardar() Then
            MuestraMensaje("Registros actualizados con Éxito", MessageBoxIcon.Information)
        End If

        plNuevo()
    End Sub

    Protected Overrides Sub ClickBotonEjecutar()
        MyBase.ClickBotonEjecutar()

        ConsultaSolicitudes()
    End Sub


#End Region
End Class