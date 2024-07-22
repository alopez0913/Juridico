Imports ADSUM
Imports Tools.Comun.Tools
Imports Juridico.Dominio
Imports DevExpress.XtraGrid.Views
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Imaging

Public Class FrmM2702001_CargaDocumentos
#Region "Declaraciones"
    Private WithEvents Manejador As ManejadorXtraGridAdvanced
    Private WithEvents ManejadorArchivos As ManejadorXtraGridAdvanced

    Public gnFolioSolicitud As Integer
    Public gnIDSubActo As Integer
    Public gnTipoPersona As Integer
    Public gbHayDatos As Boolean
    Public gbNuevoReclasifica As Boolean

    Private ADDA As AsistenteDeDatos_Base

    Public dtDDRequerimientos As New DataTable
    Public dtArchivos As New DataTable
    Private dtAuxArchivos As New DataTable

    Private gcComentariosRechazo As String = ""

    'Private dsDatos As DataSet
    'Private dsDatosArchivos As DataSet
#End Region

#Region "Funciones y Procedimientos"
    Private Sub plObtenRequerimientos()
        plCargaRequerimientos()
        plCargaEstructuraArchivos()

        lblClasificacion.Text = FabricaJuridico.ConsultaClasificacion(gnIDSubActo)

        gpoComentariosRechazo.Visible = False
        gcComentariosRechazo = ""
        ATXComentarios.Text = ""
    End Sub

    Private Sub plCargaRequerimientos()
        Dim resultado As Boolean
        Dim dtExistenRequerimientos As DataTable
        Dim xBoton As New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit

        xBoton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor

        If gnFolioSolicitud = 0 OrElse gbNuevoReclasifica Then
            dtDDRequerimientos = FabricaJuridico.ObtenRequerimientos(gnIDSubActo, dtDDRequerimientos)
        Else
            dtDDRequerimientos = FabricaJuridico.ObtenRequerimientosPendientes(gnFolioSolicitud, dtDDRequerimientos)
            'dtDDRequerimientos = FabricaJuridico.ObtenDocumentosDigitalizadosCliente(gnFolioSolicitud)
        End If

        If dtDDRequerimientos Is Nothing AndAlso gnIDSubActo <> -1 Then
            MuestraMensaje("Ocurrio un error al consultar los datos. Vuelva a intentarlo..", MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf dtDDRequerimientos.Rows.Count = 0 Then
            MuestraMensaje("La clasificación seleccionada, no cuenta con requerimientos registrados. Favor de contactar al departamento de Jurídico.", MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        resultado = ExistenRequerimientos(Sub()
                                              dtExistenRequerimientos = dtDDRequerimientos.Select("nIDReq IN(1,2)").CopyToDataTable
                                          End Sub)

        If gnTipoPersona = 1 Then
            If Not resultado Then
                dtDDRequerimientos.Rows.Add(1, "Acta Constitutiva", 0, 0, "", False, DBNull.Value)
                dtDDRequerimientos.Rows.Add(2, "Poder Representante Legal", 0, 0, "", False, DBNull.Value)
                dtDDRequerimientos.AcceptChanges()

                Dim dv As New DataView(dtDDRequerimientos)
                dv.Sort = "nIDReq ASC"
                dtDDRequerimientos = dv.ToTable
            End If
        Else
            If resultado Then
                dtDDRequerimientos = dtDDRequerimientos.Select("nIDReq NOT IN(1,2)").CopyToDataTable
                dtDDRequerimientos.AcceptChanges()
            End If
        End If

        With dtDDRequerimientos
            .Columns("nIDReq").Caption = "IdReq"
            .Columns("cDescripcion").Caption = "Documento"
            .Columns("nGuardado").Caption = "Almacenado"
            .Columns("nUltimoNum").Caption = "Ult. Versión"
            .Columns("cCargar").Caption = "Cargar"
            .Columns("bAutorizado").Caption = "Autorizar"
            .Columns("cMotivo").Caption = "Observación"
        End With

        grdDocumentos.DataSource = dtDDRequerimientos

        Utilerias.CargarColumnasGrid(grvDocumentos, {"bAutorizado"}, False)

        grdDocumentos.RepositoryItems.Add(xBoton)
        With grvDocumentos
            .Columns("nIDReq").OptionsColumn.AllowEdit = False ' 
            .Columns("nIDReq").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            .Columns("cDescripcion").OptionsColumn.AllowEdit = False
            .Columns("cDescripcion").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            .Columns("nGuardado").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            .Columns("nUltimoNum").OptionsColumn.AllowEdit = False
            .Columns("nUltimoNum").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            .Columns("bAutorizado").OptionsColumn.AllowEdit = False
            .Columns("cCargar").ColumnEdit = xBoton
            .Columns("cCargar").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            .Columns("nGuardado").OptionsColumn.AllowEdit = False
            .Columns("cMotivo").OptionsColumn.AllowEdit = False
        End With
    End Sub

    Private Sub plCargaEstructuraArchivos()
        dtArchivos = FabricaJuridico.ObtenArchivosDigitalizadosCliente(0, 0)

        With dtArchivos
            .Columns("nIDReq").Caption = "IDReq"
            .Columns("nConsecutivo").Caption = "Versión"
            .Columns("cNombreArchivo").Caption = "Nombre Archivo"
            .Columns("cExtencion").Caption = "Extensión"
            .Columns("cVisualizar").Caption = "Visualizar"
        End With

        dtAuxArchivos = dtArchivos.Clone
        grdArchivos.DataSource = dtAuxArchivos

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

    Private Function ValidaTodosArchivosTodosRequerimientos() As Boolean
        ' Crear un diccionario para realizar un seguimiento de qué documentos tienen al menos un archivo.
        Dim documentosConArchivos As New Dictionary(Of Integer, Boolean)()

        ' Inicializar el diccionario con todos los documentos como falsos.
        For Each documentoRow As DataRow In dtDDRequerimientos.Rows
            Dim idDocumento As Integer = CInt(documentoRow("nIDReq"))
            documentosConArchivos(idDocumento) = False
        Next

        ' Recorrer la tabla de archivos y actualizar el diccionario.
        For Each archivoRow As DataRow In dtArchivos.Rows
            Dim idDocumento As Integer = CInt(archivoRow("nIDReq"))
            If documentosConArchivos.ContainsKey(idDocumento) Then
                documentosConArchivos(idDocumento) = True
            End If
        Next

        ' Verificar si todos los documentos tienen al menos un archivo.
        Return documentosConArchivos.All(Function(kvp) kvp.Value)
    End Function

    Private Function ExistenRequerimientos(metodo As Action) As Boolean
        Try
            metodo.Invoke()

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#Region "Eventos"
    Private Sub FrmM2702001_CargaDocumentos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            ADDA = AsistenteDeDatos_Base.DevuelveInstancia()
            Manejador = New ManejadorXtraGridAdvanced(grdDocumentos)
            Manejador.Estilo = ManejadorXtraGridAdvanced.Estilos.Captura
            ManejadorArchivos = New ManejadorXtraGridAdvanced(grdArchivos)
            ManejadorArchivos.Estilo = ManejadorXtraGridAdvanced.Estilos.Captura

            plObtenRequerimientos()

        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmM2702001_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If Not MuestraMensajeConfirmacion("¿Desea cancelar la carga de documentos?") Then Return

            Utilerias.DestruirObjeto(dtDDRequerimientos)
            Utilerias.DestruirObjeto(dtArchivos)

            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If
    End Sub

    Private Sub grvDocumentos_ButtonClick(sender As Object, e As Grid.RowCellClickEventArgs) Handles grvDocumentos.RowCellClick
        Dim nIDRequerimiento As Integer
        Dim ultimoDoc As Integer
        Dim row As DataRow = grvDocumentos.GetDataRow(grvDocumentos.FocusedRowHandle)

        If row!nGuardado > 0 Then
            If dtAuxArchivos Is Nothing Then
                dtAuxArchivos = dtArchivos.Clone
            End If

            dtAuxArchivos.Clear()

            For Each vdRow As DataRow In dtArchivos.Select("nIDReq = " & CInt(row!nIDReq))
                dtAuxArchivos.Rows.Add(vdRow.ItemArray)
                ultimoDoc = vdRow!nConsecutivo
            Next
        Else
            dtAuxArchivos.Clear()
        End If

        If e.Column.FieldName = "cCargar" Then
            Try
                nIDRequerimiento = CInt(row!nIDReq)

                If ofdArchivo.ShowDialog = DialogResult.OK Then
                    Dim nombreArchivo As String
                    Dim extencionArchivo As String
                    Dim dirArchivo As String
                    Dim rowArchivos = row.GetChildRows("Archivos")
                    Dim rowArchivo As DataRow
                    Dim archivo As Byte()

                    dirArchivo = ofdArchivo.FileName

                    extencionArchivo = dirArchivo.Substring(dirArchivo.LastIndexOf("."c) + 1).ToLower

                    If Not {"pdf", "jpg", "jpeg"}.Contains(extencionArchivo) Then
                        MuestraMensaje("El tipo de archivo seleccionado no es permitido dentro del sistema. Verifique.",
                                       MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                    If Not {"1", "2"}.Contains(nIDRequerimiento.ToString()) Then
                        If Utilerias.TamañoArchivoMB(dirArchivo) > 4.5D Then
                            MuestraMensaje("El tamaño del archivo es mayor a 5 MB, intente con un archivo de menor tamaño. Puede cambiar la calidad para reducir el tamaño.",
                                           MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    End If

                    If {"jpg", "jpeg"}.Contains(extencionArchivo) Then
                        Dim formatoImagen As ImageFormat = ImageFormat.Jpeg

                        archivo = Utilerias.ComprimirImagen(IO.File.ReadAllBytes(dirArchivo), 50, formatoImagen)
                    End If

                    archivo = IO.File.ReadAllBytes(dirArchivo)
                    'ultimoDoc = row!nUltimoNum

                    nombreArchivo = dirArchivo.Substring(dirArchivo.LastIndexOf("\"c) + 1).Replace("."c, "").Replace(CStr(extencionArchivo), "")
                    nombreArchivo = nombreArchivo.Replace("""", "&quot;")
                    nombreArchivo = nombreArchivo.Replace("&", "&amp;")

                    If rowArchivos.Length > 0 Then
                        rowArchivo = rowArchivos(0)

                        With rowArchivo
                            !cNombreArchivo = nombreArchivo
                            !cExtencion = extencionArchivo
                            !vArchivo = archivo   'IO.File.ReadAllBytes(dirArchivo)
                            !bGuardar = True
                        End With
                        MuestraMensaje("Archivo actualizado.", MessageBoxIcon.Information)
                    Else
                        dtArchivos.Rows.Add({0, nIDRequerimiento, 0, ultimoDoc + 1, nombreArchivo, extencionArchivo,
                                        True, True, archivo, dirArchivo})
                        dtAuxArchivos.Rows.Add({0, nIDRequerimiento, 0, ultimoDoc + 1, nombreArchivo, extencionArchivo,
                                        True, True, archivo, dirArchivo})     'Nueva línea

                        dtArchivos.AcceptChanges()
                        dtAuxArchivos.AcceptChanges()

                        row!nGuardado += 1

                        If CInt(row!nGuardado) = 1 Then dtDDRequerimientos.AcceptChanges()
                    End If
                End If

            Catch ex As Exception
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub ButtonVisualizar_ButtonClick(sender As Object, e As Grid.RowCellClickEventArgs) Handles grvArchivos.RowCellClick
        Dim row As DataRow = grvArchivos.GetDataRow(grvArchivos.FocusedRowHandle)
        Dim frm As New FrmVisualizarArchivos
        Dim dirArchivo As String
        Dim extencion As String
        Dim bArchivo As Byte()

        If e.Column.FieldName = "cVisualizar" Then
            Try

                extencion = CStr(row!cExtencion)
                dirArchivo = My.Computer.FileSystem.GetTempFileName
                dirArchivo = dirArchivo.Replace(".tmp", "." & extencion)

                bArchivo = row!vArchivo

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
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click, btnCancelar.Click
        dtDDRequerimientos.AcceptChanges()
        dtArchivos.AcceptChanges()

        If dtArchivos.Rows.Count = 0 Then
            MuestraMensaje("Es necesario cargar por lo menos un archivo de los requerimientos. Favor de verificar..", MessageBoxIcon.Information)

            Return
        End If

        If Not ValidaTodosArchivosTodosRequerimientos() Then
            MuestraMensaje("Es necesario realizar la carga completa de archivos en cada uno de los requerimientos. Favor de verificar..", MessageBoxIcon.Information)

            Return
        End If

        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If Not MuestraMensajeConfirmacion("¿Desea cancelar la carga de documentos?") Then Return

        Utilerias.DestruirObjeto(dtDDRequerimientos)
        Utilerias.DestruirObjeto(dtArchivos)

        Me.DialogResult = DialogResult.Cancel
    End Sub

#End Region
End Class