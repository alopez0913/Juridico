<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmM2702001_Old
    Inherits ADSUM.CustomForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
        Me.grboxVigencia = New System.Windows.Forms.GroupBox()
        Me.dtpFechaFirma = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFirma = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaini = New System.Windows.Forms.DateTimePicker()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.lblIni = New System.Windows.Forms.Label()
        Me.grbClasificacion = New System.Windows.Forms.GroupBox()
        Me.lblNombreClasificacion = New System.Windows.Forms.Label()
        Me.lblClasificacion = New System.Windows.Forms.Label()
        Me.txtTipoActo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ofdDocumento = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblVigencia = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
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
        Me.ATXPenalidades = New ADSUM.AdsumTextBoxAdvanced()
        Me.ATXCantidadPenalidades = New ADSUM.AdsumTextBoxAdvanced()
        Me.cmbMoneda = New System.Windows.Forms.ComboBox()
        Me.gpoRetroalimentacion = New System.Windows.Forms.GroupBox()
        Me.lblRetroalimentacion = New System.Windows.Forms.Label()
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
        Me.btnVerArchivo = New System.Windows.Forms.Button()
        Me.btnCargaArchivo = New System.Windows.Forms.Button()
        Me.grboxVigencia.SuspendLayout()
        Me.grbClasificacion.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.gpoRetroalimentacion.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
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
        Me.grboxVigencia.Controls.Add(Me.dtpFechaFirma)
        Me.grboxVigencia.Controls.Add(Me.lblFechaFirma)
        Me.grboxVigencia.Controls.Add(Me.dtpFechaFin)
        Me.grboxVigencia.Controls.Add(Me.dtpFechaini)
        Me.grboxVigencia.Controls.Add(Me.lblFinal)
        Me.grboxVigencia.Controls.Add(Me.lblIni)
        Me.grboxVigencia.Location = New System.Drawing.Point(827, 109)
        Me.grboxVigencia.Name = "grboxVigencia"
        Me.grboxVigencia.Size = New System.Drawing.Size(165, 129)
        Me.grboxVigencia.TabIndex = 3
        Me.grboxVigencia.TabStop = False
        Me.grboxVigencia.Text = "Vigencia"
        '
        'dtpFechaFirma
        '
        Me.dtpFechaFirma.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaFirma.Location = New System.Drawing.Point(61, 92)
        Me.dtpFechaFirma.Name = "dtpFechaFirma"
        Me.dtpFechaFirma.Size = New System.Drawing.Size(89, 22)
        Me.dtpFechaFirma.TabIndex = 2
        '
        'lblFechaFirma
        '
        Me.lblFechaFirma.AutoSize = True
        Me.lblFechaFirma.Location = New System.Drawing.Point(16, 96)
        Me.lblFechaFirma.Name = "lblFechaFirma"
        Me.lblFechaFirma.Size = New System.Drawing.Size(39, 14)
        Me.lblFechaFirma.TabIndex = 24
        Me.lblFechaFirma.Text = "Firma:"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaFin.Location = New System.Drawing.Point(61, 54)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(89, 22)
        Me.dtpFechaFin.TabIndex = 1
        '
        'dtpFechaini
        '
        Me.dtpFechaini.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaini.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpFechaini.Location = New System.Drawing.Point(61, 24)
        Me.dtpFechaini.Name = "dtpFechaini"
        Me.dtpFechaini.Size = New System.Drawing.Size(89, 22)
        Me.dtpFechaini.TabIndex = 0
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Location = New System.Drawing.Point(29, 58)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(26, 14)
        Me.lblFinal.TabIndex = 18
        Me.lblFinal.Text = "Fin:"
        '
        'lblIni
        '
        Me.lblIni.AutoSize = True
        Me.lblIni.Location = New System.Drawing.Point(16, 28)
        Me.lblIni.Name = "lblIni"
        Me.lblIni.Size = New System.Drawing.Size(39, 14)
        Me.lblIni.TabIndex = 17
        Me.lblIni.Text = "Inicio:"
        '
        'grbClasificacion
        '
        Me.grbClasificacion.Controls.Add(Me.lblNombreClasificacion)
        Me.grbClasificacion.Controls.Add(Me.lblClasificacion)
        Me.grbClasificacion.Controls.Add(Me.txtTipoActo)
        Me.grbClasificacion.Controls.Add(Me.Label6)
        Me.grbClasificacion.Controls.Add(Me.Label2)
        Me.grbClasificacion.Controls.Add(Me.Label4)
        Me.grbClasificacion.Controls.Add(Me.Label1)
        Me.grbClasificacion.Location = New System.Drawing.Point(13, 528)
        Me.grbClasificacion.Name = "grbClasificacion"
        Me.grbClasificacion.Size = New System.Drawing.Size(612, 57)
        Me.grbClasificacion.TabIndex = 8
        Me.grbClasificacion.TabStop = False
        Me.grbClasificacion.Text = "Clasificación"
        Me.grbClasificacion.Visible = False
        '
        'lblNombreClasificacion
        '
        Me.lblNombreClasificacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblNombreClasificacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNombreClasificacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblNombreClasificacion.Location = New System.Drawing.Point(67, 24)
        Me.lblNombreClasificacion.Name = "lblNombreClasificacion"
        Me.lblNombreClasificacion.Size = New System.Drawing.Size(535, 22)
        Me.lblNombreClasificacion.TabIndex = 0
        Me.lblNombreClasificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblClasificacion
        '
        Me.lblClasificacion.AutoSize = True
        Me.lblClasificacion.Location = New System.Drawing.Point(16, 28)
        Me.lblClasificacion.Name = "lblClasificacion"
        Me.lblClasificacion.Size = New System.Drawing.Size(48, 14)
        Me.lblClasificacion.TabIndex = 26
        Me.lblClasificacion.Text = "Código:"
        '
        'txtTipoActo
        '
        Me.txtTipoActo.Location = New System.Drawing.Point(194, 80)
        Me.txtTipoActo.Name = "txtTipoActo"
        Me.txtTipoActo.Size = New System.Drawing.Size(406, 22)
        Me.txtTipoActo.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(246, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 14)
        Me.Label6.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(246, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 14)
        Me.Label2.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(245, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 14)
        Me.Label4.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(245, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 14)
        Me.Label1.TabIndex = 7
        '
        'ofdDocumento
        '
        Me.ofdDocumento.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblVigencia)
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.lblFolio)
        Me.GroupBox1.Controls.Add(Me.ATXFolio)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(979, 85)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales de la Solicitud"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(149, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 14)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Estatus:"
        '
        'lblVigencia
        '
        Me.lblVigencia.BackColor = System.Drawing.Color.Black
        Me.lblVigencia.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVigencia.ForeColor = System.Drawing.Color.White
        Me.lblVigencia.Location = New System.Drawing.Point(325, 49)
        Me.lblVigencia.Name = "lblVigencia"
        Me.lblVigencia.Size = New System.Drawing.Size(474, 22)
        Me.lblVigencia.TabIndex = 55
        Me.lblVigencia.Text = "Vigencia"
        Me.lblVigencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblVigencia.Visible = False
        '
        'lblFecha
        '
        Me.lblFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFecha.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblFecha.Location = New System.Drawing.Point(69, 49)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(77, 20)
        Me.lblFecha.TabIndex = 54
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(20, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 14)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Fecha:"
        '
        'lblStatus
        '
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus.Location = New System.Drawing.Point(152, 49)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(167, 22)
        Me.lblStatus.TabIndex = 50
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.GroupBox3.Location = New System.Drawing.Point(13, 245)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(612, 147)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contratante(s)"
        '
        'grdProveedores
        '
        Me.grdProveedores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdProveedores.Location = New System.Drawing.Point(6, 52)
        Me.grdProveedores.MainView = Me.grvProveedores
        Me.grdProveedores.Name = "grdProveedores"
        Me.grdProveedores.Size = New System.Drawing.Size(596, 77)
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
        Me.lblClave.Size = New System.Drawing.Size(455, 22)
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
        Me.GroupBox4.Location = New System.Drawing.Point(13, 398)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(612, 124)
        Me.GroupBox4.TabIndex = 6
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
        Me.GroupBox5.Controls.Add(Me.ATXPenalidades)
        Me.GroupBox5.Controls.Add(Me.ATXCantidadPenalidades)
        Me.GroupBox5.Controls.Add(Me.cmbMoneda)
        Me.GroupBox5.Location = New System.Drawing.Point(631, 398)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(361, 124)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Penalidades"
        '
        'ATXPenalidades
        '
        Me.ATXPenalidades.BlancoEsValorInvalido = True
        Me.ATXPenalidades.CadenaDescripcionNoValida = "Codigo no existe"
        Me.ATXPenalidades.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ATXPenalidades.CatalogoBase = Nothing
        Me.ATXPenalidades.CatalogoPrincipal = False
        Me.ATXPenalidades.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ATXPenalidades.ColorDesactivado = System.Drawing.Color.Empty
        Me.ATXPenalidades.ControlDestinoDescripcion = Nothing
        Me.ATXPenalidades.DescripcionElementoInvalido = "Codigo no existe"
        Me.ATXPenalidades.EnPantalla = False
        Me.ATXPenalidades.FiltroExtendido = ""
        Me.ATXPenalidades.LanzarMensajeError = False
        Me.ATXPenalidades.Location = New System.Drawing.Point(6, 49)
        Me.ATXPenalidades.MaxLength = 0
        Me.ATXPenalidades.Multiline = True
        Me.ATXPenalidades.Multiple = False
        Me.ATXPenalidades.Name = "ATXPenalidades"
        Me.ATXPenalidades.PermiteAvanceElementoInvalido = True
        Me.ATXPenalidades.PermiteAyudaRapida = True
        Me.ATXPenalidades.PermiteSoloCapturarAlfanumericos = True
        Me.ATXPenalidades.Size = New System.Drawing.Size(349, 57)
        Me.ATXPenalidades.TabIndex = 2
        Me.ATXPenalidades.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.ATXPenalidades.TituloMensaje = "Sistema Integral Panama"
        Me.ATXPenalidades.ValorValido = False
        '
        'ATXCantidadPenalidades
        '
        Me.ATXCantidadPenalidades.BlancoEsValorInvalido = True
        Me.ATXCantidadPenalidades.CadenaDescripcionNoValida = "Codigo no existe"
        Me.ATXCantidadPenalidades.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ATXCantidadPenalidades.CatalogoBase = Nothing
        Me.ATXCantidadPenalidades.CatalogoPrincipal = False
        Me.ATXCantidadPenalidades.ColorDesactivado = System.Drawing.Color.Empty
        Me.ATXCantidadPenalidades.ControlDestinoDescripcion = Nothing
        Me.ATXCantidadPenalidades.DescripcionElementoInvalido = "Codigo no existe"
        Me.ATXCantidadPenalidades.EnPantalla = False
        Me.ATXCantidadPenalidades.FiltroExtendido = ""
        Me.ATXCantidadPenalidades.LanzarMensajeError = False
        Me.ATXCantidadPenalidades.Location = New System.Drawing.Point(129, 21)
        Me.ATXCantidadPenalidades.MaxLength = 8
        Me.ATXCantidadPenalidades.Multiple = False
        Me.ATXCantidadPenalidades.Name = "ATXCantidadPenalidades"
        Me.ATXCantidadPenalidades.PermiteAvanceElementoInvalido = True
        Me.ATXCantidadPenalidades.PermiteAyudaRapida = True
        Me.ATXCantidadPenalidades.PermiteSoloCapturarAlfanumericos = False
        Me.ATXCantidadPenalidades.Size = New System.Drawing.Size(142, 22)
        Me.ATXCantidadPenalidades.TabIndex = 1
        Me.ATXCantidadPenalidades.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.ATXCantidadPenalidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ATXCantidadPenalidades.TituloMensaje = "Sistema de Juridico"
        Me.ATXCantidadPenalidades.ValorValido = False
        '
        'cmbMoneda
        '
        Me.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMoneda.FormattingEnabled = True
        Me.cmbMoneda.Location = New System.Drawing.Point(6, 21)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(117, 22)
        Me.cmbMoneda.TabIndex = 0
        '
        'gpoRetroalimentacion
        '
        Me.gpoRetroalimentacion.Controls.Add(Me.lblRetroalimentacion)
        Me.gpoRetroalimentacion.Location = New System.Drawing.Point(13, 588)
        Me.gpoRetroalimentacion.Name = "gpoRetroalimentacion"
        Me.gpoRetroalimentacion.Size = New System.Drawing.Size(613, 84)
        Me.gpoRetroalimentacion.TabIndex = 9
        Me.gpoRetroalimentacion.TabStop = False
        Me.gpoRetroalimentacion.Text = "Retroalimentación"
        Me.gpoRetroalimentacion.Visible = False
        '
        'lblRetroalimentacion
        '
        Me.lblRetroalimentacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblRetroalimentacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRetroalimentacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRetroalimentacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblRetroalimentacion.Location = New System.Drawing.Point(3, 18)
        Me.lblRetroalimentacion.Name = "lblRetroalimentacion"
        Me.lblRetroalimentacion.Size = New System.Drawing.Size(607, 63)
        Me.lblRetroalimentacion.TabIndex = 0
        Me.lblRetroalimentacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.GroupBox2.Location = New System.Drawing.Point(13, 109)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(808, 130)
        Me.GroupBox2.TabIndex = 2
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
        Me.GroupBox6.Controls.Add(Me.btnVerArchivo)
        Me.GroupBox6.Controls.Add(Me.btnCargaArchivo)
        Me.GroupBox6.Location = New System.Drawing.Point(631, 245)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(361, 147)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Archivos de Ejemplo"
        '
        'btnVerArchivo
        '
        Me.btnVerArchivo.Enabled = False
        Me.btnVerArchivo.Location = New System.Drawing.Point(189, 50)
        Me.btnVerArchivo.Name = "btnVerArchivo"
        Me.btnVerArchivo.Size = New System.Drawing.Size(130, 46)
        Me.btnVerArchivo.TabIndex = 1
        Me.btnVerArchivo.Text = "Ver Archivo"
        Me.btnVerArchivo.UseVisualStyleBackColor = True
        '
        'btnCargaArchivo
        '
        Me.btnCargaArchivo.Enabled = False
        Me.btnCargaArchivo.Location = New System.Drawing.Point(42, 50)
        Me.btnCargaArchivo.Name = "btnCargaArchivo"
        Me.btnCargaArchivo.Size = New System.Drawing.Size(139, 46)
        Me.btnCargaArchivo.TabIndex = 0
        Me.btnCargaArchivo.Text = "Cargar Archivo"
        Me.btnCargaArchivo.UseVisualStyleBackColor = True
        '
        'FrmM2702001
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1004, 732)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gpoRetroalimentacion)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grboxVigencia)
        Me.Controls.Add(Me.grbClasificacion)
        Me.Name = "FrmM2702001"
        Me.ReferenciaRapidaVisible = True
        Me.Text = "Solicitud de Contrato"
        Me.Controls.SetChildIndex(Me.grbClasificacion, 0)
        Me.Controls.SetChildIndex(Me.grboxVigencia, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.lblToolTip, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.GroupBox5, 0)
        Me.Controls.SetChildIndex(Me.gpoRetroalimentacion, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox6, 0)
        Me.grboxVigencia.ResumeLayout(False)
        Me.grboxVigencia.PerformLayout()
        Me.grbClasificacion.ResumeLayout(False)
        Me.grbClasificacion.PerformLayout()
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
        Me.gpoRetroalimentacion.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grboxVigencia As GroupBox
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents dtpFechaini As DateTimePicker
    Friend WithEvents lblFinal As Label
    Friend WithEvents lblIni As Label
    Friend WithEvents grbClasificacion As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTipoActo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFechaFirma As DateTimePicker
    Friend WithEvents lblFechaFirma As Label
    Friend WithEvents lblClasificacion As Label
    Friend WithEvents ofdDocumento As OpenFileDialog
    Friend WithEvents lblNombreClasificacion As Label

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Text = "Solicitud de Contratos"
    End Sub

    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblStatus As Label
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
    Friend WithEvents cmbMoneda As ComboBox
    Friend WithEvents gpoRetroalimentacion As System.Windows.Forms.GroupBox
    Friend WithEvents ATXEspecificaciones As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents ATXCantidadPenalidades As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents ATXPenalidades As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents lblVigencia As Label
    Friend WithEvents Label3 As Label
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
    Friend WithEvents lblRetroalimentacion As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnVerArchivo As Button
    Friend WithEvents btnCargaArchivo As Button
End Class
