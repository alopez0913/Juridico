Imports ADSUM
Imports Tools.Comun.Tools
Imports DevExpress.XtraGrid.Views.Grid
Imports Juridico.Dominio
Imports DevExpress.XtraGrid.Views
Imports DevExpress.XtraGrid

Public Class FrmM2702012    'Banco de Datos (PLD)

#Region "Declaraciones"
    Private dtDocumentos As DataTable
    Private dtArchivos As DataTable
    Private dtExpedientes As DataTable

    Private dsDatos As DataSet

    Private WithEvents MXAExpedientes As ManejadorXtraGridAdvanced
    Private WithEvents MXADocumentos As ManejadorXtraGridAdvanced
    Private WithEvents MXAArchivos As ManejadorXtraGridAdvanced

    Private WithEvents MXAArrendamientosNANSA As ManejadorXtraGridAdvanced
    Private WithEvents MXAArrendamientosFERTIGOLFO As ManejadorXtraGridAdvanced
    Private WithEvents MXAArrendamientosLOGICPRO As ManejadorXtraGridAdvanced

    Private WithEvents MXAPrestamosNANSA As ManejadorXtraGridAdvanced
    Private WithEvents MXAPrestamosFERTIGOLFO As ManejadorXtraGridAdvanced
    Private WithEvents MXAPrestamosLOGICPRO As ManejadorXtraGridAdvanced

    Protected gnSubrubro As Integer

    Protected Enum ENUM_Pantallas
        Parafinanciera = 1
        Empleados = 2
    End Enum
#End Region

#Region "Overrides"
    Protected Overrides Sub ClickBotonNuevo()
        MyBase.ClickBotonNuevo()

        If MensajeConfirmaLimpiarPantalla() = DialogResult.No Then Return

        plNuevo(False)
    End Sub

    Protected Overrides Sub ClickBotonGuardar()
        MyBase.ClickBotonGuardar()

        If Not flValidarGuardar() Then Return

        If MensajeConfirmaGuardar() = DialogResult.No Then Return

        If flGuardar() Then
            MuestraMensaje("Información guardada con éxito.", MessageBoxIcon.Information)

            plNuevo(False)
        End If
    End Sub
#End Region

#Region "Funciones y Procedimientos"

    Private Sub plNuevo(prmEsLoad As Boolean)

        If prmEsLoad Then
            plConfigurarGrid()
            plCrearEstructura()
            InicializarCatalogos()
        Else
            dtExpedientes.Rows.Clear()
            dtDocumentos.Rows.Clear()
            dtArchivos.Rows.Clear()
        End If

        plConsultaExpedientes()

        With Me.ToolBarButtons
            .Guardar = True
            .Borrar = False
            .Imprimir = False
            .EnvExcel = True
            .Graficar = False
            .Ejecutar = False
            .Nuevo = True
        End With

    End Sub

    Private Sub plConfigurarGrid()
        MXAExpedientes = New ManejadorXtraGridAdvanced(grdExpedientes)
        MXADocumentos = New ManejadorXtraGridAdvanced(grdDocumentos)
        MXAArchivos = New ManejadorXtraGridAdvanced(grdArchivos)
        MXAArrendamientosNANSA = New ManejadorXtraGridAdvanced(grdArrendamientoNANSA)
        MXAArrendamientosFERTIGOLFO = New ManejadorXtraGridAdvanced(grdArrendamientoFERTIGOLFO)
        MXAArrendamientosLOGICPRO = New ManejadorXtraGridAdvanced(grdArrendamientoLOGICPRO)
        MXAPrestamosNANSA = New ManejadorXtraGridAdvanced(grdPrestamosNANSA)
        MXAPrestamosFERTIGOLFO = New ManejadorXtraGridAdvanced(grdPrestamosFERTIGOLFO)
        MXAPrestamosLOGICPRO = New ManejadorXtraGridAdvanced(grdPrestamosLOGICPRO)

        MXAExpedientes.Estilo = Manejador_XtraGrid.Estilos.Seleccion
        MXADocumentos.Estilo = Manejador_XtraGrid.Estilos.Seleccion
        MXAArchivos.Estilo = Manejador_XtraGrid.Estilos.Seleccion
        MXAArrendamientosNANSA.Estilo = Manejador_XtraGrid.Estilos.Seleccion
        MXAArrendamientosFERTIGOLFO.Estilo = Manejador_XtraGrid.Estilos.Seleccion
        MXAArrendamientosLOGICPRO.Estilo = Manejador_XtraGrid.Estilos.Seleccion
        MXAPrestamosNANSA.Estilo = Manejador_XtraGrid.Estilos.Seleccion
        MXAPrestamosFERTIGOLFO.Estilo = Manejador_XtraGrid.Estilos.Seleccion
        MXAPrestamosLOGICPRO.Estilo = Manejador_XtraGrid.Estilos.Seleccion
    End Sub

    Private Sub InicializarCatalogos()
        ATXCliente.CatalogoBase = New Catalogo(New MetaCatalogo("JUR_Solicitantes"))
    End Sub

    Private Sub plCrearEstructura()
        Utilerias.DestruirObjeto(dtExpedientes)
        Utilerias.DestruirObjeto(dtDocumentos)
        Utilerias.DestruirObjeto(dtArchivos)

        dtExpedientes = New DataTable
        With dtExpedientes
            .Columns.Add("CodCliente", GetType(Integer)).Caption = "Código"
            .Columns.Add("RazonSocial", GetType(String)).Caption = "Nombre / Razón Social"
            .Columns.Add("RFC", GetType(String)).Caption = "RFC"
            .Columns.Add("Ciudad", GetType(String)).Caption = "Ciudad"
            '.Columns.Add("FechaCredito", GetType(Date)).Caption = "Fecha Credito"
            .Columns.Add("Observaciones", GetType(String))
            .Columns.Add("Rubro", GetType(Integer))
            .Columns.Add("NombreRubro", GetType(String)).Caption = "Actividad"
            .Columns.Add("SubRubro", GetType(Integer))
            .Columns.Add("NombreSubRubro", GetType(String)).Caption = "Rubro"
            .Columns.Add("NumCliente", GetType(Integer))
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
        grvExpedientes.Columns("NumCliente").Visible = False

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
                MuestraMensaje("Ocurrio un error al consultar los datos, cierre y abra el sistema y vuelva a intentarlo.", MessageBoxIcon.Exclamation)
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
        Dim dsTemp As DataSet

        Try
            'Datos Parafinanciera
            dsTemp = FabricaJuridico.ObtenExpedientesBancoDatos(0)

            dsTemp.Relations.Add("Registros", dsTemp.Tables(0).Columns("CodCliente"), dsTemp.Tables(1).Columns("CodCliente"), False)

            grdExpedientes.DataSource = dsTemp.Tables(0)
            grdExpedientes.ForceInitialize()

            With grvExpedientes
                .Columns("RazonSocial").Width = 350
                .Columns("RFC").Width = 120
                .Columns("Ciudad").Width = 120
                .Columns("NombreRubro").Width = 150
                .Columns("NombreSubRubro").Width = 150
            End With

            dsDatos = dsTemp

            Utilerias.FormatearColumnasGrid(grvExpedientes)
            Utilerias.DestruirObjeto(dsTemp)

            'Datos Arrendamiento NANSA
            dsTemp = FabricaJuridico.ObtenExpedientesBancoDatosPLDArrendamiento(1)
            dsTemp.Relations.Add("Registros", dsTemp.Tables(0).Columns("Año"), dsTemp.Tables(1).Columns("Año"), False)

            grdArrendamientoNANSA.DataSource = dsTemp.Tables(0)
            grdArrendamientoNANSA.ForceInitialize()

            Utilerias.FormatearColumnasGrid(grvArrendamientoNANSA)
            Utilerias.DestruirObjeto(dsTemp)

            'Datos Arrendamiento FERTIGOLFO
            dsTemp = FabricaJuridico.ObtenExpedientesBancoDatosPLDArrendamiento(3)
            dsTemp.Relations.Add("Registros", dsTemp.Tables(0).Columns("Año"), dsTemp.Tables(1).Columns("Año"), False)

            grdArrendamientoFERTIGOLFO.DataSource = dsTemp.Tables(0)
            grdArrendamientoFERTIGOLFO.ForceInitialize()

            Utilerias.FormatearColumnasGrid(grvArrendamientoFERTIGOLFO)
            Utilerias.DestruirObjeto(dsTemp)

            'Datos Arrendamiento LOGIC PRO
            dsTemp = FabricaJuridico.ObtenExpedientesBancoDatosPLDArrendamiento(4)
            dsTemp.Relations.Add("Registros", dsTemp.Tables(0).Columns("Año"), dsTemp.Tables(1).Columns("Año"), False)

            grdArrendamientoLOGICPRO.DataSource = dsTemp.Tables(0)
            grdArrendamientoLOGICPRO.ForceInitialize()

            Utilerias.FormatearColumnasGrid(grvArrendamientoLOGICPRO)
            Utilerias.DestruirObjeto(dsTemp)

            'Datos Prestamos NANSA
            dsTemp = FabricaJuridico.ObtenExpedientesBancoDatosPLDPrestamos(1)

            grdPrestamosNANSA.DataSource = dsTemp.Tables(0)
            grdArrendamientoNANSA.ForceInitialize()

            Utilerias.FormatearColumnasGrid(grvPrestamosNANSA)
            Utilerias.DestruirObjeto(dsTemp)

            'Datos Prestamos FERTIGOLFO
            dsTemp = FabricaJuridico.ObtenExpedientesBancoDatosPLDPrestamos(3)

            grdPrestamosFERTIGOLFO.DataSource = dsTemp.Tables(0)
            grdArrendamientoFERTIGOLFO.ForceInitialize()

            Utilerias.FormatearColumnasGrid(grvPrestamosFERTIGOLFO)
            Utilerias.DestruirObjeto(dsTemp)

            'Datos Prestamos LOGICPRO
            dsTemp = FabricaJuridico.ObtenExpedientesBancoDatosPLDPrestamos(4)

            grdPrestamosLOGICPRO.DataSource = dsTemp.Tables(0)
            grdArrendamientoLOGICPRO.ForceInitialize()

            Utilerias.FormatearColumnasGrid(grvPrestamosLOGICPRO)
            Utilerias.DestruirObjeto(dsTemp)

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

    Private Function flValidarGuardar() As Boolean
        If Not dtExpedientes.Select("Autorizar = True").Count > 0 Then
            MuestraMensaje("Debe especificar al menos un expediente cómo Autorizado.", MessageBoxIcon.Exclamation)

            Return False
        End If

        Return True
    End Function

    Private Function flGuardar() As Boolean
        Dim xmlExpedientes = Utilerias.DataTableAXml(dtExpedientes.Select("Autorizar = True").CopyToDataTable())

        Try
            If Not ADDA.TieneTransaccionAbierta Then ADDA.AbreTransaccion()

            If Not EscribanoJuridico.GuardaExpedientes(xmlExpedientes) Then
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

        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub grvExpedientes_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles grvExpedientes.RowCellClick
        Dim vlRechaza As Boolean = False


        Try
            Select Case e.Column.FieldName
                Case Is = "Autorizar"
                    grvExpedientes.SetRowCellValue(e.RowHandle, grvExpedientes.Columns("Autorizar"), Not e.CellValue)
                Case Else
                    gnSubrubro = grvExpedientes.GetRowCellValue(e.RowHandle, grvExpedientes.Columns("SubRubro"))

                    plConsultaDocumentos(grvExpedientes.GetRowCellValue(e.RowHandle, grvExpedientes.Columns("Rubro")),
                                            grvExpedientes.GetRowCellValue(e.RowHandle, grvExpedientes.Columns("SubRubro")),
                                            grvExpedientes.GetRowCellValue(e.RowHandle, grvExpedientes.Columns("NumCliente")))
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

                Select Case gnSubrubro
                    Case ENUM_Pantallas.Parafinanciera
                        bArchivo = FabricaJuridico.ObtenerBinarioDocumento(nIDDocumento, OrigenDocumentosBinarios.Documentos_Digitalizados_BancoDatos)

                    Case ENUM_Pantallas.Empleados
                        bArchivo = FabricaJuridico.ObtenerBinarioDocumento(nIDDocumento, CInt(row!Num))
                End Select

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

    Private Sub grvExpedientes_MasterRowExpanded(sender As Object, e As CustomMasterRowEventArgs) Handles grvExpedientes.MasterRowExpanded
        Dim grvSender As GridView = CType(sender.GetDetailView(e.RowHandle, e.RelationIndex), GridView)

        'grvSender.Columns("Importe").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        'grvSender.Columns("Importe").DisplayFormat.FormatString = "{0:C2}"
        'grvSender.Columns("Importe").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'grvSender.Columns("Importe").SummaryItem.DisplayFormat = "{0:C2}"

        'grvSender.OptionsView.ShowFooter = True
    End Sub

    Private Sub grvArrendamiento_MasterRowExpanded(sender As Object, e As CustomMasterRowEventArgs) Handles grvArrendamientoNANSA.MasterRowExpanded, grvArrendamientoFERTIGOLFO.MasterRowExpanded, grvArrendamientoLOGICPRO.MasterRowExpanded
        Dim grvSender As GridView = CType(sender.GetDetailView(e.RowHandle, e.RelationIndex), GridView)

        grvSender.Columns("Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        grvSender.Columns("Total").DisplayFormat.FormatString = "{0:C2}"
        grvSender.Columns("Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        grvSender.Columns("Total").SummaryItem.DisplayFormat = "{0:C2}"

        grvSender.OptionsView.ShowFooter = True
    End Sub

#End Region
End Class
