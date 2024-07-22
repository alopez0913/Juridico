<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmM2702001
    Inherits ADSUM.CustomForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmM2702001))
        Me.grboxVigencia = New System.Windows.Forms.GroupBox()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaini = New System.Windows.Forms.DateTimePicker()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.lblIni = New System.Windows.Forms.Label()
        Me.ofdArchivo = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTextoEstatus = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblEstatus = New System.Windows.Forms.Label()
        Me.lblFolio = New System.Windows.Forms.Label()
        Me.ATXFolio = New ADSUM.AdsumTextBoxAdvanced()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.grdProveedores = New DevExpress.XtraGrid.GridControl()
        Me.grvProveedores = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblClave = New System.Windows.Forms.Label()
        Me.lblProv = New System.Windows.Forms.Label()
        Me.ATXProveedor = New ADSUM.AdsumTextBoxAdvanced()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ATXEspecificaciones = New ADSUM.AdsumTextBoxAdvanced()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblNombreClasificacion = New System.Windows.Forms.Label()
        Me.ATXClasificacion = New ADSUM.AdsumTextBoxAdvanced()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ATXCorreo2 = New ADSUM.AdsumTextBoxAdvanced()
        Me.ATXCorreo = New ADSUM.AdsumTextBoxAdvanced()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblDepartamentoJefe = New System.Windows.Forms.Label()
        Me.lblNombreDepartamento = New System.Windows.Forms.Label()
        Me.lblNombreJefe = New System.Windows.Forms.Label()
        Me.lblNombreSolicitante = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lvArchivoPropuesta = New System.Windows.Forms.ListView()
        Me.ilIconos = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCargaArchivo = New System.Windows.Forms.Button()
        Me.gpoDocumentacion = New System.Windows.Forms.GroupBox()
        Me.btnDocumentacion = New System.Windows.Forms.Button()
        Me.gpoRetroalimentacion = New System.Windows.Forms.GroupBox()
        Me.atxRetroalimentacion = New Juridico.Controles.AdsumTextBoxAdvanced2()
        Me.BtnCerrarRetroalimentacion = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.atxCorreoRepresentanteLegal = New ADSUM.AdsumTextBoxAdvanced()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkFirmaElectronica = New System.Windows.Forms.CheckBox()
        Me.grboxVigencia.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.gpoDocumentacion.SuspendLayout()
        Me.gpoRetroalimentacion.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblToolTip
        '
        Me.lblToolTip.Location = New System.Drawing.Point(1, -3)
        Me.lblToolTip.Size = New System.Drawing.Size(26, 22)
        Me.lblToolTip.TabIndex = 0
        '
        'grboxVigencia
        '
        Me.grboxVigencia.Controls.Add(Me.dtpFechaFin)
        Me.grboxVigencia.Controls.Add(Me.dtpFechaini)
        Me.grboxVigencia.Controls.Add(Me.lblFinal)
        Me.grboxVigencia.Controls.Add(Me.lblIni)
        Me.grboxVigencia.Location = New System.Drawing.Point(631, 319)
        Me.grboxVigencia.Name = "grboxVigencia"
        Me.grboxVigencia.Size = New System.Drawing.Size(190, 124)
        Me.grboxVigencia.TabIndex = 5
        Me.grboxVigencia.TabStop = False
        Me.grboxVigencia.Text = "Vigencia"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaFin.Location = New System.Drawing.Point(60, 81)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(89, 22)
        Me.dtpFechaFin.TabIndex = 1
        '
        'dtpFechaini
        '
        Me.dtpFechaini.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaini.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpFechaini.Location = New System.Drawing.Point(60, 27)
        Me.dtpFechaini.Name = "dtpFechaini"
        Me.dtpFechaini.Size = New System.Drawing.Size(89, 22)
        Me.dtpFechaini.TabIndex = 0
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Location = New System.Drawing.Point(28, 85)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(26, 14)
        Me.lblFinal.TabIndex = 18
        Me.lblFinal.Text = "Fin:"
        '
        'lblIni
        '
        Me.lblIni.AutoSize = True
        Me.lblIni.Location = New System.Drawing.Point(15, 31)
        Me.lblIni.Name = "lblIni"
        Me.lblIni.Size = New System.Drawing.Size(39, 14)
        Me.lblIni.TabIndex = 17
        Me.lblIni.Text = "Inicio:"
        '
        'ofdArchivo
        '
        Me.ofdArchivo.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTextoEstatus)
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblEstatus)
        Me.GroupBox1.Controls.Add(Me.lblFolio)
        Me.GroupBox1.Controls.Add(Me.ATXFolio)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(226, 144)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales de la Solicitud"
        '
        'lblTextoEstatus
        '
        Me.lblTextoEstatus.AutoSize = True
        Me.lblTextoEstatus.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblTextoEstatus.Location = New System.Drawing.Point(12, 87)
        Me.lblTextoEstatus.Name = "lblTextoEstatus"
        Me.lblTextoEstatus.Size = New System.Drawing.Size(51, 14)
        Me.lblTextoEstatus.TabIndex = 56
        Me.lblTextoEstatus.Text = "Estatus:"
        Me.lblTextoEstatus.Visible = False
        '
        'lblFecha
        '
        Me.lblFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFecha.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblFecha.Location = New System.Drawing.Point(69, 54)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(77, 20)
        Me.lblFecha.TabIndex = 54
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(20, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 14)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Fecha:"
        '
        'lblEstatus
        '
        Me.lblEstatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblEstatus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblEstatus.Location = New System.Drawing.Point(11, 110)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(205, 22)
        Me.lblEstatus.TabIndex = 50
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEstatus.Visible = False
        '
        'lblFolio
        '
        Me.lblFolio.AutoSize = True
        Me.lblFolio.Location = New System.Drawing.Point(28, 28)
        Me.lblFolio.Name = "lblFolio"
        Me.lblFolio.Size = New System.Drawing.Size(35, 14)
        Me.lblFolio.TabIndex = 49
        Me.lblFolio.Text = "Folio:"
        '
        'ATXFolio
        '
        Me.ATXFolio.BlancoEsValorInvalido = True
        Me.ATXFolio.CadenaDescripcionNoValida = "Codigo no existe"
        Me.ATXFolio.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ATXFolio.CatalogoBase = Nothing
        Me.ATXFolio.CatalogoPrincipal = False
        Me.ATXFolio.ColorDesactivado = System.Drawing.Color.Empty
        Me.ATXFolio.ControlDestinoDescripcion = Nothing
        Me.ATXFolio.DescripcionElementoInvalido = "Codigo no existe"
        Me.ATXFolio.EnPantalla = False
        Me.ATXFolio.FiltroExtendido = ""
        Me.ATXFolio.LanzarMensajeError = False
        Me.ATXFolio.Location = New System.Drawing.Point(69, 24)
        Me.ATXFolio.MaxLength = 6
        Me.ATXFolio.Multiple = False
        Me.ATXFolio.Name = "ATXFolio"
        Me.ATXFolio.PermiteAvanceElementoInvalido = True
        Me.ATXFolio.PermiteAyudaRapida = True
        Me.ATXFolio.PermiteSoloCapturarAlfanumericos = False
        Me.ATXFolio.Size = New System.Drawing.Size(77, 22)
        Me.ATXFolio.TabIndex = 0
        Me.ATXFolio.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.ATXFolio.TituloMensaje = "Sistema de Juridico"
        Me.ATXFolio.ValorValido = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.grdProveedores)
        Me.GroupBox3.Controls.Add(Me.lblClave)
        Me.GroupBox3.Controls.Add(Me.lblProv)
        Me.GroupBox3.Controls.Add(Me.ATXProveedor)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 166)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(612, 147)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contratante(s)"
        '
        'grdProveedores
        '
        Me.grdProveedores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdProveedores.Location = New System.Drawing.Point(9, 52)
        Me.grdProveedores.MainView = Me.grvProveedores
        Me.grdProveedores.Name = "grdProveedores"
        Me.grdProveedores.Size = New System.Drawing.Size(593, 77)
        Me.grdProveedores.TabIndex = 1
        Me.grdProveedores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvProveedores})
        '
        'grvProveedores
        '
        Me.grvProveedores.GridControl = Me.grdProveedores
        Me.grvProveedores.Name = "grvProveedores"
        '
        'lblClave
        '
        Me.lblClave.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblClave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClave.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblClave.Location = New System.Drawing.Point(147, 24)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New System.Drawing.Size(360, 22)
        Me.lblClave.TabIndex = 50
        Me.lblClave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProv
        '
        Me.lblProv.AutoSize = True
        Me.lblProv.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblProv.Location = New System.Drawing.Point(16, 28)
        Me.lblProv.Name = "lblProv"
        Me.lblProv.Size = New System.Drawing.Size(48, 14)
        Me.lblProv.TabIndex = 48
        Me.lblProv.Text = "Código:"
        '
        'ATXProveedor
        '
        Me.ATXProveedor.BlancoEsValorInvalido = True
        Me.ATXProveedor.CadenaDescripcionNoValida = "Codigo no existe"
        Me.ATXProveedor.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ATXProveedor.CatalogoBase = Nothing
        Me.ATXProveedor.CatalogoPrincipal = False
        Me.ATXProveedor.ColorDesactivado = System.Drawing.Color.Empty
        Me.ATXProveedor.ControlDestinoDescripcion = Nothing
        Me.ATXProveedor.DescripcionElementoInvalido = "Codigo no existe"
        Me.ATXProveedor.EnPantalla = False
        Me.ATXProveedor.FiltroExtendido = ""
        Me.ATXProveedor.LanzarMensajeError = False
        Me.ATXProveedor.Location = New System.Drawing.Point(69, 24)
        Me.ATXProveedor.MaxLength = 6
        Me.ATXProveedor.Multiple = False
        Me.ATXProveedor.Name = "ATXProveedor"
        Me.ATXProveedor.PermiteAvanceElementoInvalido = True
        Me.ATXProveedor.PermiteAyudaRapida = True
        Me.ATXProveedor.PermiteSoloCapturarAlfanumericos = False
        Me.ATXProveedor.Size = New System.Drawing.Size(72, 22)
        Me.ATXProveedor.TabIndex = 0
        Me.ATXProveedor.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.ATXProveedor.TituloMensaje = "Sistema de Juridico"
        Me.ATXProveedor.ValorValido = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ATXEspecificaciones)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 319)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(612, 124)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Especificaciones"
        '
        'ATXEspecificaciones
        '
        Me.ATXEspecificaciones.BlancoEsValorInvalido = True
        Me.ATXEspecificaciones.CadenaDescripcionNoValida = "Codigo no existe"
        Me.ATXEspecificaciones.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ATXEspecificaciones.CatalogoBase = Nothing
        Me.ATXEspecificaciones.CatalogoPrincipal = False
        Me.ATXEspecificaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ATXEspecificaciones.ColorDesactivado = System.Drawing.Color.Empty
        Me.ATXEspecificaciones.ControlDestinoDescripcion = Nothing
        Me.ATXEspecificaciones.DescripcionElementoInvalido = "Codigo no existe"
        Me.ATXEspecificaciones.EnPantalla = False
        Me.ATXEspecificaciones.FiltroExtendido = ""
        Me.ATXEspecificaciones.LanzarMensajeError = False
        Me.ATXEspecificaciones.Location = New System.Drawing.Point(9, 28)
        Me.ATXEspecificaciones.MaxLength = 0
        Me.ATXEspecificaciones.Multiline = True
        Me.ATXEspecificaciones.Multiple = False
        Me.ATXEspecificaciones.Name = "ATXEspecificaciones"
        Me.ATXEspecificaciones.PermiteAvanceElementoInvalido = True
        Me.ATXEspecificaciones.PermiteAyudaRapida = True
        Me.ATXEspecificaciones.PermiteSoloCapturarAlfanumericos = True
        Me.ATXEspecificaciones.Size = New System.Drawing.Size(593, 78)
        Me.ATXEspecificaciones.TabIndex = 0
        Me.ATXEspecificaciones.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.ATXEspecificaciones.TituloMensaje = "Sistema Integral Panama"
        Me.ATXEspecificaciones.ValorValido = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblNombreClasificacion)
        Me.GroupBox5.Controls.Add(Me.ATXClasificacion)
        Me.GroupBox5.Location = New System.Drawing.Point(13, 449)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(612, 82)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Clasificación"
        '
        'lblNombreClasificacion
        '
        Me.lblNombreClasificacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblNombreClasificacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNombreClasificacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblNombreClasificacion.Location = New System.Drawing.Point(87, 30)
        Me.lblNombreClasificacion.Name = "lblNombreClasificacion"
        Me.lblNombreClasificacion.Size = New System.Drawing.Size(514, 22)
        Me.lblNombreClasificacion.TabIndex = 49
        Me.lblNombreClasificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ATXClasificacion
        '
        Me.ATXClasificacion.BlancoEsValorInvalido = True
        Me.ATXClasificacion.CadenaDescripcionNoValida = "Codigo no existe"
        Me.ATXClasificacion.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ATXClasificacion.CatalogoBase = Nothing
        Me.ATXClasificacion.CatalogoPrincipal = False
        Me.ATXClasificacion.ColorDesactivado = System.Drawing.Color.Empty
        Me.ATXClasificacion.ControlDestinoDescripcion = Nothing
        Me.ATXClasificacion.DescripcionElementoInvalido = "Codigo no existe"
        Me.ATXClasificacion.EnPantalla = False
        Me.ATXClasificacion.FiltroExtendido = ""
        Me.ATXClasificacion.LanzarMensajeError = False
        Me.ATXClasificacion.Location = New System.Drawing.Point(9, 30)
        Me.ATXClasificacion.MaxLength = 6
        Me.ATXClasificacion.Multiple = False
        Me.ATXClasificacion.Name = "ATXClasificacion"
        Me.ATXClasificacion.PermiteAvanceElementoInvalido = True
        Me.ATXClasificacion.PermiteAyudaRapida = True
        Me.ATXClasificacion.PermiteSoloCapturarAlfanumericos = False
        Me.ATXClasificacion.Size = New System.Drawing.Size(72, 22)
        Me.ATXClasificacion.TabIndex = 48
        Me.ATXClasificacion.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.ATXClasificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ATXClasificacion.TituloMensaje = "Sistema de Juridico"
        Me.ATXClasificacion.ValorValido = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ATXCorreo2)
        Me.GroupBox2.Controls.Add(Me.ATXCorreo)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblDepartamentoJefe)
        Me.GroupBox2.Controls.Add(Me.lblNombreDepartamento)
        Me.GroupBox2.Controls.Add(Me.lblNombreJefe)
        Me.GroupBox2.Controls.Add(Me.lblNombreSolicitante)
        Me.GroupBox2.Location = New System.Drawing.Point(246, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(808, 144)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Generales del Solicitante"
        '
        'ATXCorreo2
        '
        Me.ATXCorreo2.BlancoEsValorInvalido = True
        Me.ATXCorreo2.CadenaDescripcionNoValida = "Codigo no existe"
        Me.ATXCorreo2.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ATXCorreo2.CatalogoBase = Nothing
        Me.ATXCorreo2.CatalogoPrincipal = False
        Me.ATXCorreo2.ColorDesactivado = System.Drawing.Color.Empty
        Me.ATXCorreo2.ControlDestinoDescripcion = Nothing
        Me.ATXCorreo2.DescripcionElementoInvalido = "Codigo no existe"
        Me.ATXCorreo2.EnPantalla = False
        Me.ATXCorreo2.FiltroExtendido = ""
        Me.ATXCorreo2.LanzarMensajeError = False
        Me.ATXCorreo2.Location = New System.Drawing.Point(553, 96)
        Me.ATXCorreo2.Multiple = False
        Me.ATXCorreo2.Name = "ATXCorreo2"
        Me.ATXCorreo2.PermiteAvanceElementoInvalido = True
        Me.ATXCorreo2.PermiteAyudaRapida = True
        Me.ATXCorreo2.PermiteSoloCapturarAlfanumericos = True
        Me.ATXCorreo2.Size = New System.Drawing.Size(246, 22)
        Me.ATXCorreo2.TabIndex = 1
        Me.ATXCorreo2.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.ATXCorreo2.TituloMensaje = "Sistema Integral Panama"
        Me.ATXCorreo2.ValorValido = False
        '
        'ATXCorreo
        '
        Me.ATXCorreo.BlancoEsValorInvalido = True
        Me.ATXCorreo.CadenaDescripcionNoValida = "Codigo no existe"
        Me.ATXCorreo.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ATXCorreo.CatalogoBase = Nothing
        Me.ATXCorreo.CatalogoPrincipal = False
        Me.ATXCorreo.ColorDesactivado = System.Drawing.Color.Empty
        Me.ATXCorreo.ControlDestinoDescripcion = Nothing
        Me.ATXCorreo.DescripcionElementoInvalido = "Codigo no existe"
        Me.ATXCorreo.EnPantalla = False
        Me.ATXCorreo.FiltroExtendido = ""
        Me.ATXCorreo.LanzarMensajeError = False
        Me.ATXCorreo.Location = New System.Drawing.Point(553, 44)
        Me.ATXCorreo.Multiple = False
        Me.ATXCorreo.Name = "ATXCorreo"
        Me.ATXCorreo.PermiteAvanceElementoInvalido = True
        Me.ATXCorreo.PermiteAyudaRapida = True
        Me.ATXCorreo.PermiteSoloCapturarAlfanumericos = True
        Me.ATXCorreo.Size = New System.Drawing.Size(246, 22)
        Me.ATXCorreo.TabIndex = 0
        Me.ATXCorreo.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.ATXCorreo.TituloMensaje = "Sistema Integral Panama"
        Me.ATXCorreo.ValorValido = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label14.Location = New System.Drawing.Point(550, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 14)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "Correo:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(550, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 14)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Correo:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(279, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 14)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Departamento:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(278, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 14)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Departamento:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(6, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 14)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Jefe Inmediato:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(6, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 14)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Nombre:"
        '
        'lblDepartamentoJefe
        '
        Me.lblDepartamentoJefe.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblDepartamentoJefe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDepartamentoJefe.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblDepartamentoJefe.Location = New System.Drawing.Point(282, 96)
        Me.lblDepartamentoJefe.Name = "lblDepartamentoJefe"
        Me.lblDepartamentoJefe.Size = New System.Drawing.Size(265, 22)
        Me.lblDepartamentoJefe.TabIndex = 16
        Me.lblDepartamentoJefe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNombreDepartamento
        '
        Me.lblNombreDepartamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblNombreDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNombreDepartamento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblNombreDepartamento.Location = New System.Drawing.Point(282, 44)
        Me.lblNombreDepartamento.Name = "lblNombreDepartamento"
        Me.lblNombreDepartamento.Size = New System.Drawing.Size(265, 22)
        Me.lblNombreDepartamento.TabIndex = 16
        Me.lblNombreDepartamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNombreJefe
        '
        Me.lblNombreJefe.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblNombreJefe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNombreJefe.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblNombreJefe.Location = New System.Drawing.Point(9, 96)
        Me.lblNombreJefe.Name = "lblNombreJefe"
        Me.lblNombreJefe.Size = New System.Drawing.Size(265, 22)
        Me.lblNombreJefe.TabIndex = 17
        Me.lblNombreJefe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNombreSolicitante
        '
        Me.lblNombreSolicitante.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblNombreSolicitante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNombreSolicitante.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblNombreSolicitante.Location = New System.Drawing.Point(9, 44)
        Me.lblNombreSolicitante.Name = "lblNombreSolicitante"
        Me.lblNombreSolicitante.Size = New System.Drawing.Size(265, 22)
        Me.lblNombreSolicitante.TabIndex = 17
        Me.lblNombreSolicitante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lvArchivoPropuesta)
        Me.GroupBox6.Controls.Add(Me.btnCargaArchivo)
        Me.GroupBox6.Location = New System.Drawing.Point(631, 166)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(190, 147)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Propuesta de Contrato"
        '
        'lvArchivoPropuesta
        '
        Me.lvArchivoPropuesta.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.lvArchivoPropuesta.HideSelection = False
        Me.lvArchivoPropuesta.LargeImageList = Me.ilIconos
        Me.lvArchivoPropuesta.Location = New System.Drawing.Point(6, 21)
        Me.lvArchivoPropuesta.Name = "lvArchivoPropuesta"
        Me.lvArchivoPropuesta.Size = New System.Drawing.Size(178, 79)
        Me.lvArchivoPropuesta.SmallImageList = Me.ilIconos
        Me.lvArchivoPropuesta.TabIndex = 43
        Me.lvArchivoPropuesta.UseCompatibleStateImageBehavior = False
        '
        'ilIconos
        '
        Me.ilIconos.ImageStream = CType(resources.GetObject("ilIconos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilIconos.TransparentColor = System.Drawing.Color.Transparent
        Me.ilIconos.Images.SetKeyName(0, "pdf-48.ico")
        Me.ilIconos.Images.SetKeyName(1, "picture-2-48.ico")
        Me.ilIconos.Images.SetKeyName(2, "microsoft-word-48.ico")
        Me.ilIconos.Images.SetKeyName(3, "start-48.ico")
        Me.ilIconos.Images.SetKeyName(4, "warning-4-48.ico")
        '
        'btnCargaArchivo
        '
        Me.btnCargaArchivo.Enabled = False
        Me.btnCargaArchivo.Location = New System.Drawing.Point(48, 106)
        Me.btnCargaArchivo.Name = "btnCargaArchivo"
        Me.btnCargaArchivo.Size = New System.Drawing.Size(95, 35)
        Me.btnCargaArchivo.TabIndex = 0
        Me.btnCargaArchivo.Text = "Cargar Archivo"
        Me.btnCargaArchivo.UseVisualStyleBackColor = True
        '
        'gpoDocumentacion
        '
        Me.gpoDocumentacion.Controls.Add(Me.btnDocumentacion)
        Me.gpoDocumentacion.Location = New System.Drawing.Point(631, 449)
        Me.gpoDocumentacion.Name = "gpoDocumentacion"
        Me.gpoDocumentacion.Size = New System.Drawing.Size(190, 82)
        Me.gpoDocumentacion.TabIndex = 7
        Me.gpoDocumentacion.TabStop = False
        Me.gpoDocumentacion.Text = "Captura de Documentos"
        '
        'btnDocumentacion
        '
        Me.btnDocumentacion.Enabled = False
        Me.btnDocumentacion.Location = New System.Drawing.Point(26, 22)
        Me.btnDocumentacion.Name = "btnDocumentacion"
        Me.btnDocumentacion.Size = New System.Drawing.Size(139, 46)
        Me.btnDocumentacion.TabIndex = 0
        Me.btnDocumentacion.Text = "Adjuntar Documentación"
        Me.btnDocumentacion.UseVisualStyleBackColor = True
        '
        'gpoRetroalimentacion
        '
        Me.gpoRetroalimentacion.BackColor = System.Drawing.Color.DarkGray
        Me.gpoRetroalimentacion.Controls.Add(Me.atxRetroalimentacion)
        Me.gpoRetroalimentacion.Controls.Add(Me.BtnCerrarRetroalimentacion)
        Me.gpoRetroalimentacion.Location = New System.Drawing.Point(230, 241)
        Me.gpoRetroalimentacion.Name = "gpoRetroalimentacion"
        Me.gpoRetroalimentacion.Size = New System.Drawing.Size(606, 149)
        Me.gpoRetroalimentacion.TabIndex = 39
        Me.gpoRetroalimentacion.TabStop = False
        Me.gpoRetroalimentacion.Text = "Retroalimentacion"
        Me.gpoRetroalimentacion.Visible = False
        '
        'atxRetroalimentacion
        '
        Me.atxRetroalimentacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.atxRetroalimentacion.BlancoEsValorInvalido = True
        Me.atxRetroalimentacion.CadenaDescripcionNoValida = "Codigo no existe"
        Me.atxRetroalimentacion.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.atxRetroalimentacion.CatalogoBase = Nothing
        Me.atxRetroalimentacion.CatalogoPrincipal = False
        Me.atxRetroalimentacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.atxRetroalimentacion.ColorDesactivado = System.Drawing.Color.Empty
        Me.atxRetroalimentacion.ControlDestinoDescripcion = Nothing
        Me.atxRetroalimentacion.Decimales = 0
        Me.atxRetroalimentacion.DescripcionElementoInvalido = "Codigo no existe"
        Me.atxRetroalimentacion.DisplayFormat = ""
        Me.atxRetroalimentacion.EnPantalla = False
        Me.atxRetroalimentacion.FiltroExtendido = ""
        Me.atxRetroalimentacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.atxRetroalimentacion.LanzarMensajeError = False
        Me.atxRetroalimentacion.Location = New System.Drawing.Point(6, 21)
        Me.atxRetroalimentacion.Multiline = True
        Me.atxRetroalimentacion.Multiple = False
        Me.atxRetroalimentacion.Name = "atxRetroalimentacion"
        Me.atxRetroalimentacion.PermiteAvanceElementoInvalido = True
        Me.atxRetroalimentacion.PermiteAyudaRapida = True
        Me.atxRetroalimentacion.PermiteSoloCapturarAlfanumericos = True
        Me.atxRetroalimentacion.ReadOnly = True
        Me.atxRetroalimentacion.Size = New System.Drawing.Size(593, 82)
        Me.atxRetroalimentacion.TabIndex = 3
        Me.atxRetroalimentacion.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.atxRetroalimentacion.TipoValor = Juridico.Controles.AdsumTextBoxAdvanced2.TipoDatos.TEXTO
        Me.atxRetroalimentacion.TituloMensaje = "Sistema Integral Panama"
        Me.atxRetroalimentacion.ValorValido = False
        '
        'BtnCerrarRetroalimentacion
        '
        Me.BtnCerrarRetroalimentacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.BtnCerrarRetroalimentacion.ForeColor = System.Drawing.Color.Black
        Me.BtnCerrarRetroalimentacion.Location = New System.Drawing.Point(250, 109)
        Me.BtnCerrarRetroalimentacion.Name = "BtnCerrarRetroalimentacion"
        Me.BtnCerrarRetroalimentacion.Size = New System.Drawing.Size(106, 26)
        Me.BtnCerrarRetroalimentacion.TabIndex = 2
        Me.BtnCerrarRetroalimentacion.Text = "Cerrar"
        Me.BtnCerrarRetroalimentacion.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.chkFirmaElectronica)
        Me.GroupBox7.Controls.Add(Me.atxCorreoRepresentanteLegal)
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 549)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(612, 82)
        Me.GroupBox7.TabIndex = 40
        Me.GroupBox7.TabStop = False
        '
        'atxCorreoRepresentanteLegal
        '
        Me.atxCorreoRepresentanteLegal.BlancoEsValorInvalido = True
        Me.atxCorreoRepresentanteLegal.CadenaDescripcionNoValida = "Codigo no existe"
        Me.atxCorreoRepresentanteLegal.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.atxCorreoRepresentanteLegal.CatalogoBase = Nothing
        Me.atxCorreoRepresentanteLegal.CatalogoPrincipal = False
        Me.atxCorreoRepresentanteLegal.ColorDesactivado = System.Drawing.Color.Empty
        Me.atxCorreoRepresentanteLegal.ControlDestinoDescripcion = Nothing
        Me.atxCorreoRepresentanteLegal.DescripcionElementoInvalido = "Codigo no existe"
        Me.atxCorreoRepresentanteLegal.EnPantalla = False
        Me.atxCorreoRepresentanteLegal.FiltroExtendido = ""
        Me.atxCorreoRepresentanteLegal.LanzarMensajeError = False
        Me.atxCorreoRepresentanteLegal.Location = New System.Drawing.Point(10, 43)
        Me.atxCorreoRepresentanteLegal.Multiple = False
        Me.atxCorreoRepresentanteLegal.Name = "atxCorreoRepresentanteLegal"
        Me.atxCorreoRepresentanteLegal.PermiteAvanceElementoInvalido = True
        Me.atxCorreoRepresentanteLegal.PermiteAyudaRapida = True
        Me.atxCorreoRepresentanteLegal.PermiteSoloCapturarAlfanumericos = True
        Me.atxCorreoRepresentanteLegal.Size = New System.Drawing.Size(246, 22)
        Me.atxCorreoRepresentanteLegal.TabIndex = 58
        Me.atxCorreoRepresentanteLegal.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.atxCorreoRepresentanteLegal.TituloMensaje = "Sistema Integral Panama"
        Me.atxCorreoRepresentanteLegal.ValorValido = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(7, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 14)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Correo:"
        '
        'chkFirmaElectronica
        '
        Me.chkFirmaElectronica.AutoSize = True
        Me.chkFirmaElectronica.Location = New System.Drawing.Point(10, 0)
        Me.chkFirmaElectronica.Name = "chkFirmaElectronica"
        Me.chkFirmaElectronica.Size = New System.Drawing.Size(140, 18)
        Me.chkFirmaElectronica.TabIndex = 41
        Me.chkFirmaElectronica.Text = "Con firma electrónica"
        Me.chkFirmaElectronica.UseVisualStyleBackColor = True
        '
        'FrmM2702001
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1067, 663)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.gpoRetroalimentacion)
        Me.Controls.Add(Me.gpoDocumentacion)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grboxVigencia)
        Me.Name = "FrmM2702001"
        Me.ReferenciaRapidaVisible = True
        Me.Text = "Solicitud de Contrato"
        Me.Controls.SetChildIndex(Me.grboxVigencia, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.GroupBox5, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox6, 0)
        Me.Controls.SetChildIndex(Me.gpoDocumentacion, 0)
        Me.Controls.SetChildIndex(Me.lblToolTip, 0)
        Me.Controls.SetChildIndex(Me.gpoRetroalimentacion, 0)
        Me.Controls.SetChildIndex(Me.GroupBox7, 0)
        Me.grboxVigencia.ResumeLayout(False)
        Me.grboxVigencia.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.grdProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.gpoDocumentacion.ResumeLayout(False)
        Me.gpoRetroalimentacion.ResumeLayout(False)
        Me.gpoRetroalimentacion.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grboxVigencia As GroupBox
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents dtpFechaini As DateTimePicker
    Friend WithEvents lblFinal As Label
    Friend WithEvents lblIni As Label
    Friend WithEvents ofdArchivo As OpenFileDialog

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Text = "Solicitud de Contratos"
    End Sub

    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblEstatus As Label
    Friend WithEvents lblFolio As Label
    Friend WithEvents ATXFolio As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents lblFecha As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents grdProveedores As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvProveedores As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblClave As Label
    Friend WithEvents lblProv As Label
    Friend WithEvents ATXProveedor As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ATXEspecificaciones As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents lblTextoEstatus As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ATXCorreo2 As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents ATXCorreo As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents Label14 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblDepartamentoJefe As Label
    Friend WithEvents lblNombreDepartamento As Label
    Friend WithEvents lblNombreJefe As Label
    Friend WithEvents lblNombreSolicitante As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnCargaArchivo As Button
    Friend WithEvents gpoDocumentacion As GroupBox
    Friend WithEvents btnDocumentacion As Button
    Friend WithEvents ilIconos As ImageList
    Friend WithEvents lvArchivoPropuesta As ListView
    Friend WithEvents gpoRetroalimentacion As GroupBox
    Friend WithEvents atxRetroalimentacion As Controles.AdsumTextBoxAdvanced2
    Friend WithEvents BtnCerrarRetroalimentacion As Button
    Friend WithEvents lblNombreClasificacion As Label
    Friend WithEvents ATXClasificacion As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents chkFirmaElectronica As CheckBox
    Friend WithEvents atxCorreoRepresentanteLegal As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents Label1 As Label
End Class
