Imports ADSUM
Imports Tools.Comun.Tools
Imports DevExpress.XtraGrid.Views.Grid
Imports Juridico.Dominio
Imports DevExpress.XtraGrid.Views
Imports System.Drawing

Public Class FrmM2702011    '   Banco de Datos (General)

#Region "Declaraciones"
    Private dtDocumentos As DataTable
    Private dtArchivos As DataTable
    Private dtExpedientes As DataTable

    Private dsDatos As DataSet

    Private WithEvents MXAExpedientes As ManejadorXtraGridAdvanced
    Private WithEvents MXADocumentos As ManejadorXtraGridAdvanced
    Private WithEvents MXAArchivos As ManejadorXtraGridAdvanced

    Protected gnTipoPantalla As Integer
    Private nTipoCatalogo As Integer
    Private nEmpresa As Integer
#End Region

#Region "Overrides"
    Protected Overrides Sub ClickBotonNuevo()
        MyBase.ClickBotonNuevo()

        If MensajeConfirmaLimpiarPantalla() = DialogResult.No Then Return

        plNuevo(False)
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
        nTipoCatalogo = 0
        nEmpresa = 0
        plConsultaExpedientes(gnTipoPantalla)

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

        MXAExpedientes.Estilo = Manejador_XtraGrid.Estilos.Seleccion
        MXADocumentos.Estilo = Manejador_XtraGrid.Estilos.Seleccion
        MXAArchivos.Estilo = Manejador_XtraGrid.Estilos.Seleccion
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
            .Columns.Add("Codigo", GetType(Integer)).Caption = "Código"
            .Columns.Add("RazonSocial", GetType(String)).Caption = "Nombre / Razón Social"
            .Columns.Add("RFC", GetType(String)).Caption = "RFC"
            .Columns.Add("Ciudad", GetType(String)).Caption = "Ciudad"
            .Columns.Add("NombreRubro", GetType(String)).Caption = "Catalogo"
            .Columns.Add("TipoCatalogo", GetType(Integer))
            .Columns.Add("NombreSubRubro", GetType(String)).Caption = "Tipo"
            .Columns.Add("Empresa", GetType(Integer))
            .Columns.Add("NombreEmpresa", GetType(String)).Caption = "Empresa"
            .Columns.Add("FechaBaja", GetType(Date)).Caption = "Fecha Baja"
            .Columns.Add("BorrarInformacion", GetType(Date)).Caption = "Borrar Información"
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
            .Columns.Add("FechaDocumento", GetType(String)).Caption = "Fecha Documento"
        End With

        grdExpedientes.DataSource = dtExpedientes
        grdDocumentos.DataSource = dtDocumentos
        grdArchivos.DataSource = dtArchivos

        'COLUMNAS OCULTAS
        grvExpedientes.Columns("Empresa").Visible = False
        grvExpedientes.Columns("TipoCatalogo").Visible = False

        grvArchivos.Columns("nIDDocumentoDig").Visible = False
        grvArchivos.Columns("nIDDocumento").Visible = False
        grvArchivos.Columns("Archivo").Visible = False
        grvArchivos.Columns("DirArchivo").Visible = False

        Utilerias.ConfigurarColumnasGrid(grvExpedientes)
        Utilerias.ConfigurarColumnasGrid(grvDocumentos)
        Utilerias.ConfigurarColumnasGrid(grvArchivos)
    End Sub

    Private Sub plConsultaDocumentacion(prmCatalogo As Integer, prmCodigo As Integer, prmEmpresa As Integer)
        Dim dsTemp As DataSet

        Try
            dtDocumentos.Rows.Clear()
            dtArchivos.Rows.Clear()
            dsTemp = FabricaJuridico.ObtenDocumentacionBancoDatosGeneral(prmCatalogo, prmCodigo, prmEmpresa)

            If dsTemp Is Nothing AndAlso prmCodigo <> -1 Then
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

    Private Sub plConsultaDocumentos(prmCatalogo As Integer, prmCodigo As Integer)
        Dim dsTemp As DataSet

        Try
            dtDocumentos.Rows.Clear()
            dtArchivos.Rows.Clear()
            dsTemp = FabricaJuridico.ObtenDocumentosBancoDatos(prmCatalogo, prmCodigo)

            If dsTemp Is Nothing AndAlso prmCodigo <> -1 Then
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

    Private Sub plConsultaExpedientes(prmPantalla As Integer)
        Dim dsTemp As DataSet

        Try
            dtExpedientes.Rows.Clear()
            dsTemp = FabricaJuridico.ObtenBancoDatosGeneral()

            dtExpedientes.Merge(dsTemp.Tables(0), False, MissingSchemaAction.Ignore)

            grdExpedientes.DataSource = dtExpedientes
            grdExpedientes.DataMember = dtExpedientes.TableName

            With grvExpedientes
                .Columns("RazonSocial").Width = 350
                .Columns("RFC").Width = 120
                .Columns("Ciudad").Width = 120
                .Columns("NombreRubro").Width = 150
                .Columns("NombreSubRubro").Width = 200
            End With

            Utilerias.FormatearColumnasGrid(grvExpedientes)
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
        Try
            nTipoCatalogo = grvExpedientes.GetRowCellValue(e.RowHandle, grvExpedientes.Columns("TipoCatalogo"))
            nEmpresa = grvExpedientes.GetRowCellValue(e.RowHandle, grvExpedientes.Columns("Empresa"))

            plConsultaDocumentacion(grvExpedientes.GetRowCellValue(e.RowHandle, grvExpedientes.Columns("TipoCatalogo")),
                                    grvExpedientes.GetRowCellValue(e.RowHandle, grvExpedientes.Columns("Codigo")),
                                    grvExpedientes.GetRowCellValue(e.RowHandle, grvExpedientes.Columns("Empresa")))

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

                Select Case nTipoCatalogo
                    Case 1
                        bArchivo = FabricaJuridico.ObtenerBinarioDocumento(nIDDocumento, OrigenDocumentosBinarios.Documentos_Digitalizados_BancoDatos)

                    Case 2
                        bArchivo = FabricaJuridico.ObtenerBinarioBancoDatosGeneral(nIDDocumento, CInt(row!Num), nEmpresa)
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

    Private Sub grvExpedientes_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles grvExpedientes.RowCellStyle
        Dim grdView As GridView = sender
        Dim fechaBaja As String

        fechaBaja = grdView.GetRowCellDisplayText(e.RowHandle, grdView.Columns("FechaBaja"))
        If fechaBaja <> "" Then
            e.Appearance.BackColor = Color.FromArgb(225, 141, 135)
            e.Appearance.BackColor2 = Color.FromArgb(225, 141, 135)
        End If
    End Sub

#End Region

End Class