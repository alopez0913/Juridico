Imports Microsoft.Office.Interop
Imports System.Text.RegularExpressions
Imports Tools.Comun.Tools
Imports ADSUM
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Drawing

Public Class Utilerias
#Region "Publicas"
#Region "Generales"
    Public Shared Sub DestruirObjeto(ByRef obj As Object)
        If obj IsNot Nothing Then
            If TypeOf obj Is SqlClient.SqlConnection Then
                With CType(obj, SqlClient.SqlConnection)
                    If .State = ConnectionState.Open Then
                        .Close()
                    End If
                End With
            End If

            If TypeOf obj Is Form Then
                CType(obj, Form).Close()
            End If

            If TypeOf obj Is IDisposable Then
                CType(obj, IDisposable).Dispose()
            End If

            obj = Nothing
        End If
    End Sub
#End Region
#Region "Validaciones"
    Public Shared Sub ValidarPortapapelesSoloNumero(sender As Object, e As KeyEventArgs)
        If (e.KeyCode = Keys.V AndAlso e.Control) OrElse (e.Shift AndAlso e.KeyCode = Keys.Insert) Then
            If Not IsNumeric(My.Computer.Clipboard.GetText()) Then
                My.Computer.Clipboard.Clear()
            End If
        End If
    End Sub
    Public Shared Sub ValidarTeclearSoloNumeros(ByRef sender As Object, ByRef e As KeyPressEventArgs, decimales As Integer)
        If TypeOf sender Is TextBox Then
            Dim c As TextBox = CType(sender, TextBox)

            If c Is Nothing Then Exit Sub

            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8) AndAlso Not e.KeyChar = Chr(13) AndAlso Not e.KeyChar = "."c) OrElse
                    (e.KeyChar = "."c AndAlso c.Text.LastIndexOf("."c) > -1) OrElse
                    (e.KeyChar = "."c AndAlso decimales <= 0) OrElse
                (c.SelectionStart > c.Text.LastIndexOf("."c) AndAlso c.Text.LastIndexOf("."c) > -1 AndAlso
                    IsNumeric(e.KeyChar) AndAlso
                    c.Text.Substring(c.Text.LastIndexOf("."c) + 1).Length = decimales AndAlso decimales > 0) Then
                e.Handled = True
            End If
        ElseIf TypeOf sender Is DevExpress.XtraEditors.TextEdit OrElse TypeOf sender Is DevExpress.XtraGrid.GridControl Then
            Dim c As DevExpress.XtraEditors.TextEdit

            If TypeOf sender Is DevExpress.XtraEditors.TextEdit Then
                c = CType(sender, DevExpress.XtraEditors.TextEdit)
            Else
                c = CType(sender, DevExpress.XtraGrid.GridControl).MainView.ActiveEditor
            End If

            If c Is Nothing Then Exit Sub

            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8) AndAlso Not e.KeyChar = Chr(13) AndAlso Not e.KeyChar = "."c) OrElse
                    (e.KeyChar = "."c AndAlso c.Text.LastIndexOf("."c) > -1) OrElse
                    (e.KeyChar = "."c AndAlso decimales <= 0) OrElse
                (c.SelectionStart > c.Text.LastIndexOf("."c) AndAlso c.Text.LastIndexOf("."c) > -1 AndAlso
                    IsNumeric(e.KeyChar) AndAlso
                    c.Text.Substring(c.Text.LastIndexOf("."c) + 1).Length = decimales AndAlso decimales > 0) Then
                e.Handled = True
            End If
        End If
    End Sub
    ''' <summary>
    ''' Esta funcion realiza la validacion que el <paramref name="row"/> no sea Nothing y el valor de la columna en caso de ser
    ''' DbNull regrese el valor por Default.
    ''' </summary>
    ''' <typeparam name="T">Tipo de datos a regresar</typeparam>
    ''' <param name="row"><see cref="DataRow"/> donde estan los datos.</param>
    ''' <param name="nombreColumna">Nombre de la columna</param>
    ''' <param name="valorDefault">Valor que retornara la funcion en caso de no pasar las validaciones</param>
    ''' <returns></returns>
    Public Shared Function DefaultDbNull(Of T)(ByRef row As DataRow, ByVal nombreColumna As String, valorDefault As T) As T
        If row Is Nothing Then
            Return valorDefault
        Else
            If IsDBNull(row(nombreColumna)) Then
                Return valorDefault
            End If

            Return CType(row(nombreColumna), T)
        End If
    End Function
#End Region
#Region "Archivos"
    Public Shared Function TamañoArchivoMB(dirArchivo As String) As Decimal
        Dim tamaño As Decimal = IO.File.ReadAllBytes(dirArchivo).Length

        Return tamaño / 1024 / 1024
    End Function
    Public Shared Function ArchivoABase64(dirArchivo As String) As String
        Return ArchivoABase64(IO.File.ReadAllBytes(dirArchivo))
    End Function
    Public Shared Function ArchivoABase64(bytes() As Byte) As String
        Return Convert.ToBase64String(bytes)
    End Function

    Public Shared Function ComprimirPDF(archivoOriginal As Byte(), calidad As Integer) As Byte()
        Using msOriginal As New MemoryStream(archivoOriginal)
            Dim reader As New PdfReader(msOriginal)

            Using msComprimido As New MemoryStream()
                Dim pdfStamper As New PdfStamper(reader, msComprimido)

                ' Aplicar compresión
                pdfStamper.Writer.CompressionLevel = calidad ' calidad entre 0 (mínima) y 9 (máxima)

                ' Cierra el PdfStamper y los streams
                pdfStamper.Close()

                ' Obtener el archivo comprimido como un array de bytes
                Dim archivoComprimido As Byte() = msComprimido.ToArray()

                Return archivoComprimido
            End Using
        End Using
    End Function

    Public Shared Function ComprimirImagen(archivoOriginal As Byte(), calidad As Long, formato As Imaging.ImageFormat) As Byte()
        Using msOriginal As New MemoryStream(archivoOriginal)
            Dim imgOriginal As Image = Image.FromStream(msOriginal)
            Dim encoderInfo As ImageCodecInfo = GetEncoderInfo(formato)
            Dim encoderParams As New EncoderParameters(1)

            encoderParams.Param(0) = New EncoderParameter(Encoder.Quality, calidad)

            ' Crear un nuevo MemoryStream para la imagen comprimida
            Using msComprimido As New MemoryStream()
                ' Guardar la imagen comprimida en el nuevo MemoryStream
                imgOriginal.Save(msComprimido, encoderInfo, encoderParams)

                ' Obtener la imagen comprimida como un array de bytes
                Dim imagenComprimida As Byte() = msComprimido.ToArray()

                Return imagenComprimida
            End Using
        End Using
    End Function

    Public Shared Function GetEncoderInfo(formato As Imaging.ImageFormat) As ImageCodecInfo
        Dim codecs As ImageCodecInfo() = ImageCodecInfo.GetImageEncoders()

        For Each codec As ImageCodecInfo In codecs
            If codec.FormatID = formato.Guid Then
                Return codec
            End If
        Next

        Return Nothing
    End Function

#End Region
#Region "Validaciones de cadenas"
    Public Shared Function ValidarCorreo(correo As String) As Boolean
        If correo Is Nothing Then correo = ""
        Return Regex.IsMatch(correo, "^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$") '"^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function
    Public Shared Function ValidarRFC(RFC As String) As Boolean
        If RFC Is Nothing Then RFC = ""
        Return Regex.IsMatch(RFC, "^([A-ZÑ\x26]{3,4}([0-9]{2})(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1]))([A-Z\d]{3})?$")
        'Return Regex.IsMatch(RFC, "^(([ÑA-Z|ña-z|&]{3}|[A-Z|a-z]{4})\d{2}((0[1-9]|1[012])(0[1-9]|1\d|2[0-8])|(0[13456789]|1[012])(29|30)|(0[13578]|1[02])31)(\w{2})([A|a|0-9]{1}))$|")
    End Function
#End Region
#Region "Funcionalidades Grid"
    Public Shared Sub CargarColumnasGrid(ByRef grv As DevExpress.XtraGrid.Views.Grid.GridView, Optional columnasOcultas As String() = Nothing,
                                         Optional columnAutoWidth As Boolean = False, Optional columnasEditables As String() = Nothing,
                                         Optional desactivarOrdenamiento As Boolean = False)
        grv.Columns.Clear()
        grv.PopulateColumns()
        grv.OptionsView.ColumnAutoWidth = columnAutoWidth

        Utilerias.FormatearColumnasGrid(grv)
        Utilerias.AjustarTamañoColumnasGrid(grv)

        If columnasOcultas IsNot Nothing Then
            For Each colNombre As String In columnasOcultas
                If grv.Columns(colNombre) IsNot Nothing Then grv.Columns(colNombre).Visible = False
            Next
        End If

        If columnasEditables IsNot Nothing Then
            For Each col As DevExpress.XtraGrid.Columns.GridColumn In grv.Columns
                col.OptionsColumn.AllowEdit = columnasEditables.Contains(col.FieldName)
            Next
        End If

        If desactivarOrdenamiento Then
            For Each col As DevExpress.XtraGrid.Columns.GridColumn In grv.Columns
                col.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Next
        End If
    End Sub
    Public Shared Sub CargarColumnasGrid(ByRef grv As DevExpress.XtraGrid.Views.Grid.GridView, columnasOcultas As String(),
                                         columnAutoWidth As Boolean, columnasEditables As Object(,), Optional desactivarOrdenamiento As Boolean = False)
        Dim colsEdit As New List(Of String)

        If columnasEditables IsNot Nothing AndAlso columnasEditables.Length > 0 Then
            For i As Integer = 0 To columnasEditables.GetLength(0) - 1
                If columnasEditables(i, 1) IsNot Nothing AndAlso Not TypeOf columnasEditables(i, 1) Is DevExpress.XtraEditors.Repository.RepositoryItem Then
                    Throw New InvalidCastException("La columna editable {" & columnasEditables(i, 0) & "} el control para su edición en el Grid no es valido.")
                End If

                colsEdit.Add(CStr(columnasEditables(i, 0)))
            Next
        End If

        CargarColumnasGrid(grv, columnasOcultas, columnAutoWidth, colsEdit.ToArray(), desactivarOrdenamiento)

        If columnasEditables IsNot Nothing Then
            For i As Integer = 0 To columnasEditables.GetLength(0) - 1
                If columnasEditables(i, 1) IsNot Nothing Then grv.Columns(CStr(columnasEditables(i, 0))).ColumnEdit = columnasEditables(i, 1)
            Next
        End If
    End Sub
    Public Shared Sub ConfigurarColumnasGrid(ByRef grv As DevExpress.XtraGrid.Views.Grid.GridView)
        Utilerias.FormatearColumnasGrid(grv)
        Utilerias.AjustarTamañoColumnasGrid(grv)
    End Sub
    Public Shared Function SumarColumnaGridView(grd As DevExpress.XtraGrid.Views.Grid.GridView, fieldName As String) As Decimal
        Dim valor As Object

        SumarColumnaGridView = 0D

        For i As Integer = 0 To grd.RowCount - 1
            valor = grd.GetRowCellValue(i, fieldName)
            If IsNumeric(valor) Then
                SumarColumnaGridView += CDec(valor)
            End If
        Next
    End Function
    Public Shared Sub AjustarTamañoColumnasGrid(ByRef grd As DevExpress.XtraGrid.Views.Grid.GridView)
        If grd Is Nothing Then Throw New ArgumentNullException("grd", "Debe ingresar un control ya inicializado")

        grd.BestFitColumns(True)
        For Each col As DevExpress.XtraGrid.Columns.GridColumn In grd.Columns
            Select Case col.ColumnType.Name
                Case "String", "DateTime", "Date"
                    col.Width += 22
                Case "Decimal"
                    col.Width += 6
                Case "Byte[]"
                    col.Width = 150
            End Select
        Next
    End Sub
    Public Shared Sub FormatearColumnasGrid(ByRef grd As DevExpress.XtraGrid.Views.Grid.GridView)
        If grd Is Nothing Then Throw New ArgumentNullException("grd", "Debe ingresar un control ya inicializado")

        Dim row As Integer
        Dim colsR As Integer
        Dim colsGrd As Integer

        If grd.RowCount > 0 Then
            row = 0

            Dim r As DataRow = grd.GetDataRow(row)

            If r Is Nothing Then Exit Sub

            colsR = r.ItemArray.Count
            colsGrd = grd.Columns.Count

            If colsGrd > colsR Then
                For i As Integer = colsGrd - 1 To colsR - 1 Step -1
                    grd.Columns.RemoveAt(i)
                Next
            End If

            For Each col As DevExpress.XtraGrid.Columns.GridColumn In grd.Columns
                Select Case r(col.FieldName).GetType.Name
                    Case "Decimal", "Double", "Single"
                        col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom

                        If col.FieldName = "Tipo Cambio" Then
                            col.DisplayFormat.FormatString = "N4"
                        Else
                            col.DisplayFormat.FormatString = "N2"
                        End If
                End Select
            Next
            'Dominio.FabricaCompras.ObtenerDisponibleDeProductosPorZonaParaDistribucion()
        End If
    End Sub
#End Region
#Region "Funcionalidades Outlook"
    ''' <summary>
    ''' Crea un nuevo Email utilizando la configuracion local del Outlook, mostrando el nuevo Email creado antes de ser enviado.
    ''' </summary>
    ''' <param name="correosDestinoVisible">Listado de correos para los destinatarios visibles. <see cref="List(Of String)"/></param>
    ''' <param name="asunto">Texto que se mostrara como asunto. <see cref="String"/></param>
    ''' <param name="correosDestinoOcultos">Listado de correos para los destinatarios ocultos. <see cref="List(Of String)"/></param>
    ''' <param name="contenido">Texto que se mostrara en el correo. <see cref="String"/></param>
    ''' <param name="archivosAdjuntos">Listado de archivos que se adjuntaran. <see cref="List(Of String)"/></param>
    ''' <param name="imagenesIncrustadas">Listado de imagenes que se agregaran como parte del cuerpo. <see cref="List(Of String)"/></param>
    ''' <example>EnviarCorreoOutlook()</example>
    ''' <example>
    ''' Dim destinatarios As New List(Of String)
    ''' Dim imagenesIncrustadas As New List(Of String)
    ''' Dim archivosAdjuntos As New List(Of String)
    ''' Dim destinatariosOcultos As New List(Of String)
    ''' Dim asunto As String
    ''' Dim contenido As String
    ''' 
    ''' destinatarios.Add("ejemplo@ejemplo.com")
    ''' destinatariosOcultos.Add("ejemploOculto@ejemplo.com")
    ''' archivosAdjuntos.Add("c:\Libro01.xlsx")
    ''' imagenesIncrustadas.Add("c:\Imagen01.jpg")
    ''' asunto = "Correo de ejemplo"
    ''' 
    ''' EnviarCorreoOutlook(destinatarios, asunto, destinatariosOcultos, contenido, archivosAdjuntos, imagenesIncrustadas)
    ''' </example>
    Public Shared Sub EnviarCorreoOutlook(Optional correosDestinoVisible As List(Of String) = Nothing,
                                          Optional asunto As String = "",
                                          Optional correosDestinoOcultos As List(Of String) = Nothing,
                                          Optional contenido As String = "",
                                          Optional archivosAdjuntos As List(Of String) = Nothing,
                                          Optional imagenesIncrustadas As List(Of String) = Nothing,
                                          Optional mostrarCorreo As Boolean = False)
        Dim outApp As Outlook.Application
        Dim mail As Outlook.MailItem
        'Correos de los destinatarios (To)
        Dim correosVisibles As String = String.Empty
        'Correos de los destinatarios ocultos (CCO o BCC)
        Dim correosOcultos As String = String.Empty
        'Estructura en HTML del cuerpo del correo
        Dim cuerpoHTML As String = "<html><body>{0}<p>{1}</p></body></html>"
        'Instruccion HTML para incrustar imagenes en el cuerpo
        Dim imagenHTML As String = "<img src=""{0}"">"
        'Contenedor de todas las imagenes que seran incrustadas
        Dim imagenesHTML As String = String.Empty
        'Validar los correos ingresados
        If correosDestinoVisible IsNot Nothing Then
            For Each correo As String In correosDestinoVisible
                If ValidarCorreo(correo) Then
                    If correosVisibles = "" Then
                        correosVisibles = correo
                    Else
                        correosVisibles &= ";" & correo
                    End If
                Else
                    MuestraMensaje(String.Format("El correo [{0}] no es valido", correo), MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Next
        End If

        'Validar los correos ingresados
        If correosDestinoOcultos IsNot Nothing Then
            For Each correo As String In correosDestinoOcultos
                If ValidarCorreo(correo) Then
                    If correosOcultos = "" Then
                        correosOcultos = correo
                    Else
                        correosOcultos &= ";" & correo
                    End If
                Else
                    MuestraMensaje(String.Format("El correo {0} no es valido", correo), MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Next
        End If

        'Validar que existan los archivos adjuntados
        If archivosAdjuntos IsNot Nothing Then
            For Each archivo As String In archivosAdjuntos
                If Not IO.File.Exists(archivo) Then
                    MuestraMensaje(String.Format("El archivo [{0}] no existe.", archivo), MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Next
        End If

        'Validar que existan las imagenes incrustadas
        If imagenesIncrustadas IsNot Nothing Then
            For Each rutaImagen As String In imagenesIncrustadas
                If Not IO.File.Exists(rutaImagen) Then
                    MuestraMensaje(String.Format("La imagen [{0}] no existe.", rutaImagen), MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Next
        End If

        'Se realizan todas las validaciones posibles antes de empezar a crear el correo para evitar cancelaciones
        'Se obtiene la instancia de la aplicacion
        outApp = New Outlook.Application
        'Se genera un nuevo Email
        mail = outApp.CreateItem(Outlook.OlItemType.olMailItem)
        mail.To = correosVisibles
        mail.BCC = correosOcultos
        mail.Subject = asunto

        'Agregar las imagenes como elemento incorporado al correo (No se muestra como adjunto)
        'y crear las instrucciones HTML para incrustar las imagenes
        If imagenesIncrustadas IsNot Nothing Then
            For Each rutaImagen As String In imagenesIncrustadas
                'Outlook.OlAttachmentType.olEmbeddeditem este tipo indica que es un elemento incorporado
                'al correo (No se muestra como adjunto) solo cuando se muetra un Email con cuerpo HTML
                mail.Attachments.Add(rutaImagen, Outlook.OlAttachmentType.olEmbeddeditem)
                'Obtener nombre de la imagen
                Dim nombreImagen As String = rutaImagen.Substring(rutaImagen.LastIndexOf("\") + 1)
                imagenesHTML &= String.Format(imagenHTML, nombreImagen)
            Next
        End If

        'Crear cuerpo HTML
        cuerpoHTML = String.Format(cuerpoHTML, contenido, imagenesHTML)
        'mail.Body = cuerpoHTML
        mail.HTMLBody = cuerpoHTML
        mail.BodyFormat = Outlook.OlBodyFormat.olFormatHTML
        'Obtener la autenticacion de la sesion de Outlook ya configurada en la PC local.
        'Dim v As String = outApp.Version

        'If v >= "14" Then
        '    mail.Sender = outApp.Session.CurrentUser.AddressEntry
        'End If

        'Agregar archivos adjuntos
        If archivosAdjuntos IsNot Nothing Then
            For Each archivo As String In archivosAdjuntos
                mail.Attachments.Add(archivo, Outlook.OlAttachmentType.olByValue)
            Next
        End If

        'Activar aplicacion de Outlook y mostrar la ventana del Email creado.
        If mostrarCorreo Then
            outApp.ActiveWindow()
            mail.Display()
        Else
            mail.Send()
        End If
    End Sub
#End Region
#Region "Funcionalidades Excel"
    Public Shared Function ValidarExtensionExcel(archivo As String) As Boolean
        Dim ext As String = archivo.Substring(archivo.LastIndexOf("."c) + 1)

        Select Case ext.ToUpper
            Case "XLS", "XLSX"
                Return True
            Case Else
                Return False
        End Select
    End Function
    Public Shared Sub DragEnterArchivoExcel(e As DragEventArgs)
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim archivos() As String = e.Data.GetData(DataFormats.FileDrop)

            If archivos.Length > 1 Then
                e.Effect = DragDropEffects.None
                'Me.Cursor = Cursors.NoMove2D
            Else
                Dim archivo As String = archivos(0)
                'Dim ext As String = archivo.Substring(archivo.LastIndexOf("."c) + 1)

                If ValidarExtensionExcel(archivo) Then
                    e.Effect = DragDropEffects.All
                Else
                    e.Effect = DragDropEffects.None
                End If
            End If
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Public Shared Function DragDropArchivoExcel(e As DragEventArgs) As String
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim archivos() As String = e.Data.GetData(DataFormats.FileDrop)

            If archivos.Length = 1 Then
                Return archivos(0)
            End If
        End If

        Return ""
    End Function
    Public Shared Function ExcelADataTable(dirArchivo As String, Optional indexHoja As Integer = 0) As DataTable
        Dim tb As DataTable = Nothing
        'Dim conexion As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dirArchivo + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';"
        'Dim con As OleDbConnection '= New OleDbConnection(conexion)
        'Dim tabla As String = ""
        'Dim da As OleDbDataAdapter 'New OleDbDataAdapter("select * from [" + tabla + "]", con)
        Dim exApp As Excel.Application = Nothing
        Dim exLibro As Excel.Workbook = Nothing
        Dim exHoja As Excel.Worksheet = Nothing
        Dim exRango As Excel.Range = Nothing
        Dim cols As Integer = 0
        Dim filas As Integer = 0
        Dim col As Integer = 0
        Dim fila As Integer = 0
        Dim valor As Object
        Dim salir As Boolean = False
        Dim columnasAgregadas As New Dictionary(Of String, Integer)
        Dim nombreCol As String
        Dim row As DataRow

        Try
            If Not IO.File.Exists(dirArchivo) Then
                Throw New IO.FileNotFoundException("El archivo [" & dirArchivo & "] no existe.")
            End If

            If Not ValidarExtensionExcel(dirArchivo) Then
                Throw New IO.FileLoadException("El tipo de archivo no es EXCEL")
            End If

            exApp = New Excel.Application
            exLibro = exApp.Workbooks.Open(dirArchivo)
            exHoja = exLibro.Worksheets.Item(indexHoja + 1)
            'tabla = exHoja.Name

            'con = New OleDbConnection(conexion)
            'da = New OleDbDataAdapter("Select * From [" & tabla & "]", con)
            'da.Fill(tb)

            tb = New DataTable
            fila = 1

            'Crear Columnas
            While Not salir
                col += 1
                valor = exHoja.Cells(fila, col).Value

                If valor IsNot Nothing AndAlso valor.ToString.Trim <> "" Then
                    If columnasAgregadas.ContainsKey(valor) Then
                        columnasAgregadas(valor) += 1
                        nombreCol = valor & "_" & columnasAgregadas(valor)
                    Else
                        nombreCol = Trim(valor)
                        columnasAgregadas.Add(valor, 1)
                    End If

                    tb.Columns.Add(nombreCol, GetType(String))
                Else
                    salir = True
                End If
            End While

            cols = col - 1

            salir = False

            While Not salir
                fila += 1

                row = tb.NewRow

                For col = 1 To cols
                    valor = exHoja.Cells(fila, col).Value

                    If valor Is Nothing OrElse IsDBNull(valor) Then
                        valor = ""

                        If col = 1 Then
                            salir = True
                            Exit For
                        End If
                    End If

                    row(col - 1) = valor
                Next

                If col > cols Then tb.Rows.Add(row)
            End While

            exLibro.Close()
        Catch ex As Exception
            Throw
        Finally
            ReleaseObject(exHoja)
            ReleaseObject(exLibro)
            ReleaseObject(exApp)
        End Try

        Return tb
    End Function
#End Region
#Region "Funcionalidades LINQ"
    ''' <summary>
    ''' Esta funcion solo es para asignar valores de una columna en un DataRow a otro DataRow. 
    ''' Para poder usar esta funcion se raliza un cruce entre DataTables como un INNER JOIN del SQL, pero con LINQ
    ''' y en la seccion Select por cada columna a modificar se usa esta funcion.
    ''' Ejemplo: Dim res = (From po In tablaDatosOriginales.Rows
    '''                     Group Join pi In tablaDatosImportar.Rows On CInt(po!CodProd) Equals CInt(pi!CodProd) Into Group
    '''                     From pp In Group
    '''                     Select noImportaNomrbreColumna = Utilerias.ColocarDatos(po, "PlanUnidades", pp),
    '''                            noImportaNomrbreColumna2 = Utilerias.ColocarDatos(po, "Precio", pp) ).ToList()
    ''' </summary>
    ''' <param name="rowDestino"><see cref="DataRow"/> que recibira el valor.</param>
    ''' <param name="columna">Nombre de la columna destino. En caso de que ambos DataRow tengan el mismo nomrbe de columna no se requiere el parametro
    ''' <paramref name="colOrigen"/></param>
    ''' <param name="rowOrigen"><see cref="DataRow"/> que contiene el valor requerido.</param>
    ''' <param name="NoAsignarValor">Se utiliza para condicionar cuando hacer la asignación del valor. Ejemplo: si se tiene un estatus
    ''' diferente a 3 entonces no lo asignes, en el la llamada de la funcion podria quedar asi,
    ''' noImportaNombreColumna = Utilerias.ColocarDatos(po, "PlanUnidades", pp, Not CInt(po!nEstatus) = 3).
    ''' Cuando se cumpla esta condicion Not CInt(po!nEstatus) = 3, no se asignara el valor al DataRow destino.</param>
    ''' <param name="colOrigen">Este parametro solo es necesario undicarlo cuando la columna del DataRow origen no tiene
    ''' el mismo nomrbe del DataRow destino.</param>
    ''' <returns>Regresa el valor con el tipo <see cref="String"/></returns>
    Public Shared Function ColocarDatos(rowDestino As DataRow, columna As String, rowOrigen As DataRow,
                                        Optional NoAsignarValor As Boolean = False, Optional colOrigen As String = "") As String
        Dim valor As Object
        If colOrigen = "" Then colOrigen = columna

        valor = rowOrigen(colOrigen)

        If NoAsignarValor Then
            Return valor
        End If

        If Not IsDBNull(valor) Then
            rowDestino(columna) = valor
        Else
            valor = ""
        End If

        Return valor.ToString()
    End Function

#End Region
#Region "Reportes"
    Public Shared Function GenerarPDF(reporte As ReportClass, nombreArchivo As String) As String
        Dim nuevoArchivo As String

        nuevoArchivo = My.Computer.FileSystem.SpecialDirectories.Temp
        nuevoArchivo = String.Format("{0}\{1}.pdf", nuevoArchivo, nombreArchivo)

        If IO.File.Exists(nuevoArchivo) Then
            IO.File.Delete(nuevoArchivo)
        End If

        reporte.ExportToDisk(ExportFormatType.PortableDocFormat, nuevoArchivo)

        Return nuevoArchivo
    End Function
    Public Shared Sub ConfigurarConexionReporte(ByRef reporte As ReportDocument)
        Dim servidor As String
        Dim baseDatos As String
        Dim cnx As String
        Dim password As String
        Dim usuario As String

        ADDA = AsistenteDeDatos_Base.DevuelveInstancia

        servidor = ADDA.GetNombreServidor
        baseDatos = ADDA.GetNombreBaseDeDatos
        cnx = ADDA.DameStringDeConexion

        usuario = cnx.Substring(cnx.IndexOf("User ID=") + 8).Trim
        usuario = usuario.Substring(0, usuario.IndexOf(";")).Trim
        password = cnx.Substring(cnx.IndexOf("Pwd=") + 4).Trim
        password = password.Substring(0, password.IndexOf(";")).Trim

        reporte.SetDatabaseLogon(usuario, password.Trim, servidor, baseDatos, True)
        reporte.DataSourceConnections.Item(0).IntegratedSecurity = False

        Try
            If reporte.Subreports.Count > 0 Then
                For i As Integer = 0 To reporte.Subreports.Count - 1
                    ConfigurarConexionReporte(reporte.Subreports.Item(i))
                Next
            End If
        Catch ex As Exception
            'No mostar error
        End Try

        'CrystalReportLogOn(reporte, servidor, baseDatos, usuario, password)

        ''Set login info
        'Dim myLogin As CrystalDecisions.Shared.TableLogOnInfo

        ''Dim cn As New CrystalDecisions.Shared.ConnectionInfo


        'Dim myTable As CrystalDecisions.CrystalReports.Engine.Table
        'For Each myTable In reporte.Database.Tables
        '    myLogin = myTable.LogOnInfo

        '    'cn.ServerName = servidor
        '    'cn.DatabaseName = baseDatos
        '    'cn.Type = ConnectionInfoType.Query
        '    'cn.IntegratedSecurity = True

        '    myLogin.ConnectionInfo.IntegratedSecurity = True
        '    'myLogin.ConnectionInfo.ServerName = "PRUEBAS_DO\DO"
        '    'myLogin.ConnectionInfo.DatabaseName = "NANSAERP_FORECAST"
        '    myLogin.ConnectionInfo.ServerName = servidor.ToUpper.Trim '"JARVIS"
        '    myLogin.ConnectionInfo.DatabaseName = baseDatos.ToUpper.Trim '"NANSAERP"
        '    'myLogin.ConnectionInfo.ServerName = "LAP_EHERNANDEZ"
        '    'myLogin.ConnectionInfo.DatabaseName = "NANSAERP_CG_20190305"
        '    'myLogin.ConnectionInfo.UserID = ""
        '    'myLogin.ConnectionInfo.Password = ""
        '    'myLogin.ConnectionInfo = cn
        '    myLogin.ConnectionInfo.Type = ConnectionInfoType.SQL
        '    myLogin.ConnectionInfo.AllowCustomConnection = True
        '    myTable.ApplyLogOnInfo(myLogin)

        '    'MsgBox(myTable.Location & " " & myLogin.ConnectionInfo.ServerName & " " & myLogin.ConnectionInfo.DatabaseName & "  " & myLogin.ConnectionInfo.IntegratedSecurity)

        '    myTable.Location = baseDatos & ".dbo." & myTable.Location '"NANSAERP.dbo." & myTable.Location

        '    'MsgBox(myTable.Location & " " & myLogin.ConnectionInfo.ServerName & " " & myLogin.ConnectionInfo.DatabaseName & "  " & myLogin.ConnectionInfo.IntegratedSecurity)
        'Next

        'Try
        '    If reporte.Subreports.Count > 0 Then
        '        For i As Integer = 0 To reporte.Subreports.Count - 1
        '            ConfigurarConexionReporte(reporte.Subreports.Item(i))
        '        Next
        '    End If
        'Catch ex As Exception
        '    'No mostar error
        'End Try

        'Dim cnx As String = ADDA.DameStringDeConexion

        'usuario = cnx.Substring(cnx.IndexOf("User ID=") + 8)
        'usuario = usuario.Substring(0, usuario.IndexOf(";"))
        'password = cnx.Substring(cnx.IndexOf("Pwd=") + 4)
        'password = password.Substring(0, password.IndexOf(";"))

        ''Set login info
        'Dim myLogin As CrystalDecisions.Shared.TableLogOnInfo
        'Dim myTable As CrystalDecisions.CrystalReports.Engine.Table

        'For Each myTable In reporte.Database.Tables
        '    myLogin = myTable.LogOnInfo
        '    myLogin.ConnectionInfo.ServerName = servidor
        '    myLogin.ConnectionInfo.DatabaseName = baseDatos
        '    myLogin.ConnectionInfo.UserID = usuario
        '    myLogin.ConnectionInfo.Password = password
        '    myLogin.ConnectionInfo.Type = ConnectionInfoType.Query
        '    myLogin.ConnectionInfo.IntegratedSecurity = True
        '    myLogin.ConnectionInfo.AllowCustomConnection = True

        '    myTable.ApplyLogOnInfo(myLogin)
        '    myTable.Location = baseDatos & ".dbo." & myTable.Location
        'Next
    End Sub
    Public Shared Sub CrystalReportLogOn(reportParameters As ReportDocument, serverName As String, databaseName As String, userName As String, password As String)
        Dim logOnInfo As TableLogOnInfo
        Dim subRd As ReportDocument
        Dim sects As Sections
        Dim ros As ReportObjects
        Dim sro As SubreportObject

        If (reportParameters Is Nothing) Then
            Throw New ArgumentNullException("reportParameters")
        End If

        reportParameters.SetDatabaseLogon(userName, password.Trim, serverName, databaseName, False)
        reportParameters.DataSourceConnections.Item(0).IntegratedSecurity = False
        Exit Sub

        Try
            For Each t As CrystalDecisions.CrystalReports.Engine.Table In reportParameters.Database.Tables
                logOnInfo = t.LogOnInfo
                logOnInfo.ReportName = reportParameters.Name
                logOnInfo.ConnectionInfo.ServerName = serverName
                logOnInfo.ConnectionInfo.DatabaseName = databaseName
                logOnInfo.ConnectionInfo.UserID = userName
                logOnInfo.ConnectionInfo.Password = password
                logOnInfo.ConnectionInfo.IntegratedSecurity = False
                logOnInfo.TableName = t.Name
                t.ApplyLogOnInfo(logOnInfo)
                t.Location = t.Name
            Next
        Catch ex As Exception
            Throw
        End Try

        sects = reportParameters.ReportDefinition.Sections
        For Each sect As Section In sects
            ros = sect.ReportObjects
            For Each ro As ReportObject In ros
                If ro.Kind = ReportObjectKind.SubreportObject Then
                    sro = CType(ro, SubreportObject)
                    subRd = sro.OpenSubreport(sro.SubreportName)

                    Try
                        For Each t As CrystalDecisions.CrystalReports.Engine.Table In subRd.Database.Tables
                            logOnInfo = t.LogOnInfo
                            logOnInfo.ReportName = reportParameters.Name
                            logOnInfo.ConnectionInfo.ServerName = serverName
                            logOnInfo.ConnectionInfo.DatabaseName = databaseName
                            logOnInfo.ConnectionInfo.UserID = userName
                            logOnInfo.ConnectionInfo.Password = password
                            logOnInfo.TableName = t.Name
                            t.ApplyLogOnInfo(logOnInfo)
                        Next
                    Catch ex As Exception
                        Throw
                    End Try
                End If
            Next
        Next
    End Sub
#End Region
#Region "DataTable"
    Public Shared Function PortapapelesADataTable() As DataTable
        Dim texto As String
        Dim filas() As String
        Dim columnas() As String
        Dim colCreadas As Boolean
        Dim nColCreadas As Integer
        Dim tb As DataTable = Nothing
        Dim row As DataRow
        Dim columnasAgregadas As New Dictionary(Of String, Integer)

        texto = My.Computer.Clipboard.GetText().Replace(vbLf, "")
        filas = texto.Split(vbNewLine)

        If filas.Length > 0 Then
            tb = New DataTable
        End If

        For Each fila As String In filas
            columnas = fila.Split(vbTab)

            If Not colCreadas Then
                For Each col As String In columnas
                    col = col.Trim

                    If columnasAgregadas.Keys.Contains(col) Then
                        columnasAgregadas(col) += 1
                        col &= "_" & columnasAgregadas(col)
                    Else
                        columnasAgregadas.Add(col, 1)
                    End If

                    tb.Columns.Add(col, GetType(String))
                Next

                colCreadas = True
                nColCreadas = columnas.Length
                Continue For
            End If

            If columnas.Length <> nColCreadas Then
                Continue For
            End If

            row = tb.NewRow

            For i As Integer = 0 To columnas.Length - 1
                row(i) = columnas(i)
            Next

            tb.Rows.Add(row)
        Next

        Return tb
    End Function
    Public Shared Function DataTableAXml(tb As DataTable, Optional columnasIgnorar() As String = Nothing,
                                         Optional nombreItem As String = "item") As String
        Dim xmlItem As String ' = "<" & nombreItem
        Dim xml As String = ""

        For Each row As DataRow In tb.Rows
            xmlItem = "<" & nombreItem

            For i As Integer = 0 To tb.Columns.Count - 1
                If columnasIgnorar Is Nothing OrElse Not columnasIgnorar.Contains(tb.Columns(i).ColumnName) Then
                    If IsDBNull(row(i)) Then Continue For

                    Select Case tb.Columns(i).DataType.Name
                        Case "Byte[]"
                            xmlItem &= String.Format(" {0}=""{1}""", tb.Columns(i).ColumnName, Utilerias.ArchivoABase64(row(i)))
                        Case "DateTime", "Date"
                            'If IsDBNull(row(i)) Then
                            '    xmlItem &= String.Format(" {0}=""01-01-1900""", tb.Columns(i).ColumnName)
                            'Else
                            xmlItem &= String.Format(" {0}=""{1}""", tb.Columns(i).ColumnName, CDate(row(i)).ToString("yyyyMMdd"))
                            'End If
                        Case Else
                            xmlItem &= String.Format(" {0}=""{1}""", tb.Columns(i).ColumnName, row(i))
                    End Select
                End If
            Next

            xmlItem &= "/>".NewLine()
            xml &= xmlItem
        Next

        Return xml
    End Function
    Public Shared Function ListADataTable(Of T)(ByVal list As IList(Of T)) As DataTable
        Dim td As New DataTable
        Dim entityType As Type = GetType(T)
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(entityType)

        For Each prop As PropertyDescriptor In properties
            td.Columns.Add(prop.Name, prop.PropertyType)
        Next

        For Each item As T In list
            Dim row As DataRow = td.NewRow()

            For Each prop As PropertyDescriptor In properties
                row(prop.Name) = prop.GetValue(item)
            Next

            td.Rows.Add(row)
        Next

        Return td
    End Function
#End Region
#Region "Excel"
    '' <summary>
    '' Exporta un DataSet a Excel, se toma en cuenta todas las tablas que contenga
    '' , si hay relaciones entre dos tablas se tomaran como una sola fila, si hay tablas sin relaciones
    '' cada tabla estara en una hoja independiente.
    '' </summary>
    '' <param name="dst">DataSet que contiene los datos a exportar</param>
    '' <param name="nombreArchivo">Nombre del archivo que se quiere crear</param>
    Public Shared Function ExportarDataSetToExcel(dst As DataSet, Optional ByVal dirArchivo As String = "",
                                                  Optional nombreHoja As String = "Exportar",
                                                  Optional decimales As Integer = 4) As Excel.Workbook
        Dim exApp As Excel.Application = Nothing
        Dim exLibro As Excel.Workbook = Nothing
        Dim exHoja As Excel.Worksheet = Nothing
        Dim tbN1 As DataTable = Nothing
        Dim tbN2 As DataTable = Nothing
        Dim tbN3 As DataTable = Nothing
        Dim tbN4 As DataTable = Nothing
        Dim relN1 As String = String.Empty
        Dim relN2 As String = String.Empty
        Dim relN3 As String = String.Empty
        Dim relN4 As String = String.Empty
        Dim frmBar As New FrmBarraProgreso
        Dim tbTemp As New DataTable
        Dim numCol As Integer
        Dim rows As Integer
        Dim c1 As Excel.Range
        Dim c2 As Excel.Range
        Dim range As Excel.Range
        Dim ultimoPaso As Integer
        Dim totalCols As Integer = 0
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0

        'Validar que se hayan ingresado los parametros
        If dst Is Nothing Then Throw New ArgumentNullException("dst", "Debe ingresar un dataser ya inicializado")
        If dst.Tables.Count = 0 Then Throw New ArgumentOutOfRangeException("dst", "El DataSet ingresado no contiene tablas")
        'If nombreArchivo.Trim = "" Then Throw New ArgumentNullException("nombreArchivo", "Debe ingresar un nombre de archivo")

        Try
            If dst.Tables.Count = 4 Then
                tbN4 = dst.Tables(3)
                If tbN4.ChildRelations.Count > 0 Then relN4 = tbN4.ChildRelations(0).RelationName
                totalCols = tbN4.Columns.Count
            End If
            If dst.Tables.Count >= 3 Then
                tbN3 = dst.Tables(2)
                If tbN3.ChildRelations.Count > 0 Then relN3 = tbN3.ChildRelations(0).RelationName
                totalCols += tbN3.Columns.Count
            End If
            If dst.Tables.Count >= 2 Then
                tbN2 = dst.Tables(1)
                If tbN2.ChildRelations.Count > 0 Then relN2 = tbN2.ChildRelations(0).RelationName
                totalCols += tbN2.Columns.Count
            End If
            If dst.Tables.Count >= 1 Then
                tbN1 = dst.Tables(0)
                If tbN1.ChildRelations.Count > 0 Then relN1 = tbN1.ChildRelations(0).RelationName
                totalCols += tbN1.Columns.Count
            End If

            ultimoPaso = CInt((tbN1.Rows.Count * 2 + totalCols) * 0.2)
            frmBar.pbrBarra.Minimum = 0
            frmBar.pbrBarra.Maximum = (tbN1.Rows.Count * 2 + totalCols) + ultimoPaso * 3
            frmBar.lblMensaje.Text = "CREANDO ESTRUCTURA Y OBTENIENDO DATOS"
            frmBar.Show()

            frmBar.Activate()

            For Each tb As DataTable In dst.Tables
                For Each col As DataColumn In tb.Columns
                    If dst.Tables.Count = 1 Then
                        tbTemp.Columns.Add(col.Caption, col.DataType)
                    Else
                        tbTemp.Columns.Add(String.Format("{0}_{1}", tb.TableName, col.Caption), col.DataType)
                    End If

                    frmBar.pbrBarra.Increment(1)
                    frmBar.Activate()
                Next
            Next

            tbTemp.Rows.Add(tbTemp.NewRow)
            rowIndex = 0
            colIndex = 0

            For Each rowN1 As DataRow In tbN1.Rows
                frmBar.pbrBarra.Increment(1)
                frmBar.Activate()

                If relN1 = "" Then
                    FilaExcel(tbTemp, rowN1, colIndex, rowIndex)

                    tbTemp.Rows.Add(tbTemp.NewRow)
                    rowIndex += 1
                    colIndex = 0
                Else
                    Dim rowsN2 As DataRow()
                    rowsN2 = rowN1.GetChildRows(relN1)

                    If rowsN2.Length > 0 Then
                        'Agregar filas nivel 1 y 2
                        For Each rowN2 As DataRow In rowsN2
                            Dim rowsN3 As DataRow()
                            rowsN3 = rowN2.GetChildRows(relN2)

                            If rowsN3.Length > 0 Then
                                'Agregar filas nivel 1, 2 y 3
                                For Each rowN3 As DataRow In rowsN3
                                    Dim rowsN4 As DataRow()
                                    rowsN4 = rowN3.GetChildRows(relN3)

                                    If rowsN4.Length > 0 Then
                                        'Agregar filas nivel 1, 2, 3 y 4
                                        For Each rowN4 As DataRow In rowsN4
                                            Dim rowsN5 As DataRow()
                                            rowsN5 = rowN4.GetChildRows(relN4)

                                            If rowsN5.Length > 0 Then
                                                'Agregar filas nivel 1, 2, 3, 4 y 5
                                                For Each rowN5 As DataRow In rowsN5
                                                    FilaExcel(tbTemp, rowN1, colIndex, rowIndex)
                                                    FilaExcel(tbTemp, rowN2, colIndex, rowIndex)
                                                    FilaExcel(tbTemp, rowN3, colIndex, rowIndex)
                                                    FilaExcel(tbTemp, rowN4, colIndex, rowIndex)
                                                    FilaExcel(tbTemp, rowN5, colIndex, rowIndex)

                                                    tbTemp.Rows.Add(tbTemp.NewRow)
                                                    rowIndex += 1
                                                    colIndex = 0
                                                Next
                                            Else
                                                'Agregar solo filas nivel 1, 2, 3 y 4
                                                FilaExcel(tbTemp, rowN1, colIndex, rowIndex)
                                                FilaExcel(tbTemp, rowN2, colIndex, rowIndex)
                                                FilaExcel(tbTemp, rowN3, colIndex, rowIndex)
                                                FilaExcel(tbTemp, rowN4, colIndex, rowIndex)

                                                tbTemp.Rows.Add(tbTemp.NewRow)
                                                rowIndex += 1
                                                colIndex = 0
                                            End If
                                        Next
                                    Else
                                        'Agregar solo filas nivel 1, 2 y 3
                                        FilaExcel(tbTemp, rowN1, colIndex, rowIndex)
                                        FilaExcel(tbTemp, rowN2, colIndex, rowIndex)
                                        FilaExcel(tbTemp, rowN3, colIndex, rowIndex)

                                        tbTemp.Rows.Add(tbTemp.NewRow)
                                        rowIndex += 1
                                        colIndex = 0
                                    End If
                                Next
                            Else
                                'Agregar solo filas nivel 1 y 2
                                FilaExcel(tbTemp, rowN1, colIndex, rowIndex)
                                FilaExcel(tbTemp, rowN2, colIndex, rowIndex)

                                tbTemp.Rows.Add(tbTemp.NewRow)
                                rowIndex += 1
                                colIndex = 0
                            End If
                        Next
                    Else
                        'Agregar solo filas nivel 1
                        FilaExcel(tbTemp, rowN1, colIndex, rowIndex)

                        tbTemp.Rows.Add(tbTemp.NewRow)
                        rowIndex += 1
                        colIndex = 0
                    End If
                End If
            Next

            numCol = tbTemp.Columns.Count
            rows = tbTemp.Rows.Count

            Dim datos(rows + 1, numCol) As Object

            rowIndex = 0
            colIndex = 0

            frmBar.lblMensaje.Text = "COPIANDO DATOS"

            For Each col As DataColumn In tbTemp.Columns
                datos(rowIndex, colIndex) = col.ColumnName
                colIndex += 1
            Next

            rowIndex += 1

            For Each row As DataRow In tbTemp.Rows
                frmBar.pbrBarra.Increment(1)
                frmBar.Activate()

                colIndex = 0

                For Each col As DataColumn In tbTemp.Columns
                    datos(rowIndex, colIndex) = row(col)
                    colIndex += 1
                Next

                rowIndex += 1
            Next

            frmBar.pbrBarra.Increment(ultimoPaso)
            frmBar.Activate()

            exApp = New Excel.Application
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add

            c1 = exHoja.Cells(1, 1)
            c2 = exHoja.Cells(rows, numCol)
            range = exHoja.Range(c1, c2)

            frmBar.lblMensaje.Text = "MOSTRANDO DATOS"
            frmBar.Update()
            frmBar.Refresh()

            range.Value2 = datos

            frmBar.pbrBarra.Increment(ultimoPaso)
            frmBar.Activate()

            c1 = exHoja.Cells(1, 1)
            c2 = exHoja.Cells(1, numCol)
            range = exHoja.Range(c1, c2)

            range.Font.Bold = True
            range.Interior.ColorIndex = 15

            exHoja.Columns.AutoFit()

            colIndex = 1

            frmBar.lblMensaje.Text = "CONFIGURANDO COLUMNAS"
            frmBar.Update()
            frmBar.Refresh()

            For Each col As DataColumn In tbTemp.Columns
                c1 = exHoja.Cells(2, colIndex)
                c2 = exHoja.Cells(rows, colIndex)

                range = exHoja.Range(c1, c2)

                Select Case col.DataType.Name
                    Case "Decimal"
                        If decimales = 0 Then
                            range.NumberFormat = "#,##0"
                        Else
                            range.NumberFormat = "#,##0." & "".PadLeft(decimales, "0")
                        End If
                    Case "Date", "DateTime"
                        range.NumberFormat = "dd/mm/yyyy;@"
                End Select

                colIndex += 1
            Next

            frmBar.pbrBarra.Increment(ultimoPaso)
            frmBar.Activate()

            'frmBar.lblMensaje.Text = "TERMINADO"
            frmBar.Visible = False
            Tools.Comun.Tools.MuestraMensaje("Archivo exportado correctamente", MessageBoxIcon.Information)

            exApp.Visible = True
            exApp.ActiveWindow.Activate()
            exApp.WindowState = Excel.XlWindowState.xlMaximized
            exLibro.Activate()

            If dirArchivo <> "" Then
                exLibro.SaveAs(dirArchivo)
            End If

            Return exLibro
        Catch ex As Exception
            MsgBox(ex.Message)

            If exHoja IsNot Nothing Then ReleaseObject(exHoja)
            If exLibro IsNot Nothing Then
                exLibro.Close(False)
                ReleaseObject(exLibro)
            End If
            If exApp IsNot Nothing Then
                exApp.Quit()
                ReleaseObject(exApp)
            End If

            Return Nothing
        Finally
            frmBar.Close()
            frmBar.Dispose()
            DestruirObjeto(tbTemp)
            GC.Collect()
        End Try
    End Function
    Private Shared Sub FilaExcel(ByRef tb As DataTable, row As DataRow, ByRef colIndex As Integer, ByRef rowIndex As Integer)
        Dim rowTb As DataRow = tb(rowIndex)

        If rowTb IsNot Nothing Then
            For Each valor As Object In row.ItemArray
                rowTb(colIndex) = valor
                colIndex += 1
            Next
        End If
    End Sub
    Private Shared Sub ReleaseObject(ByVal o As Object)
        Try
            While (System.Runtime.InteropServices.Marshal.ReleaseComObject(o) > 0)
            End While
        Catch
        Finally
            o = Nothing
        End Try
    End Sub
#End Region
#End Region
End Class