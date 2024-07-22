<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmM2702007
    ' Inherits System.Windows.Forms.Form
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
        Me.btnVerArchivo = New System.Windows.Forms.Button()
        Me.btnArchivo = New System.Windows.Forms.Button()
        Me.txtCoreo = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.grbClasificacion = New System.Windows.Forms.GroupBox()
        Me.txtClasificacion = New System.Windows.Forms.TextBox()
        Me.lblClasificacion = New System.Windows.Forms.Label()
        Me.txtSubTipoActo = New System.Windows.Forms.TextBox()
        Me.lblSubTipoActo = New System.Windows.Forms.Label()
        Me.atxSubTipoActo = New ADSUM.AdsumTextBoxAdvanced()
        Me.txtTipoActo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGrupo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCantidadPenalidades = New System.Windows.Forms.TextBox()
        Me.cmbMoneda = New System.Windows.Forms.ComboBox()
        Me.lblPenalidades = New System.Windows.Forms.Label()
        Me.lblClave = New System.Windows.Forms.Label()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.grboxVigencia = New System.Windows.Forms.GroupBox()
        Me.DTPFechaFirma = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFirma = New System.Windows.Forms.Label()
        Me.DTPFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.DTPFechaini = New System.Windows.Forms.DateTimePicker()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.lblIni = New System.Windows.Forms.Label()
        Me.GridProveedores = New DevExpress.XtraGrid.GridControl()
        Me.Grvprovedores = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtTipoPersona = New System.Windows.Forms.TextBox()
        Me.txtRFCProv = New System.Windows.Forms.TextBox()
        Me.txtDescProveedor = New System.Windows.Forms.TextBox()
        Me.txtEstatus = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.txtSolicitante = New System.Windows.Forms.TextBox()
        Me.lblProv = New System.Windows.Forms.Label()
        Me.atxProveedor = New ADSUM.AdsumTextBoxAdvanced()
        Me.lblSolicitante = New System.Windows.Forms.Label()
        Me.lblDepa = New System.Windows.Forms.Label()
        Me.atxDepartamento = New ADSUM.AdsumTextBoxAdvanced()
        Me.lblFolio = New System.Windows.Forms.Label()
        Me.atxCodigo = New ADSUM.AdsumTextBoxAdvanced()
        Me.txtretro = New System.Windows.Forms.TextBox()
        Me.lblRetro = New System.Windows.Forms.Label()
        Me.lblespecificaciones = New System.Windows.Forms.Label()
        Me.txtPenalidades = New System.Windows.Forms.TextBox()
        Me.txtEspecificaciones = New System.Windows.Forms.TextBox()
        Me.lblAccion = New System.Windows.Forms.Label()
        Me.cmbsolicitar = New System.Windows.Forms.ComboBox()
        Me.txtcorreo2 = New System.Windows.Forms.TextBox()
        Me.lblEstatusRenoExt = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.grbClasificacion.SuspendLayout()
        Me.grboxVigencia.SuspendLayout()
        CType(Me.GridProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grvprovedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblToolTip
        '
        Me.lblToolTip.Size = New System.Drawing.Size(19, 25)
        '
        'btnVerArchivo
        '
        Me.btnVerArchivo.Location = New System.Drawing.Point(754, 289)
        Me.btnVerArchivo.Name = "btnVerArchivo"
        Me.btnVerArchivo.Size = New System.Drawing.Size(105, 59)
        Me.btnVerArchivo.TabIndex = 107
        Me.btnVerArchivo.Text = "Ver Archivo"
        Me.btnVerArchivo.UseVisualStyleBackColor = True
        '
        'btnArchivo
        '
        Me.btnArchivo.Location = New System.Drawing.Point(751, 221)
        Me.btnArchivo.Name = "btnArchivo"
        Me.btnArchivo.Size = New System.Drawing.Size(108, 57)
        Me.btnArchivo.TabIndex = 106
        Me.btnArchivo.Text = "Subir Archivo"
        Me.btnArchivo.UseVisualStyleBackColor = True
        '
        'txtCoreo
        '
        Me.txtCoreo.Location = New System.Drawing.Point(646, 105)
        Me.txtCoreo.Name = "txtCoreo"
        Me.txtCoreo.Size = New System.Drawing.Size(218, 22)
        Me.txtCoreo.TabIndex = 105
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(705, 81)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(106, 14)
        Me.lblCorreo.TabIndex = 104
        Me.lblCorreo.Text = "Correos a Notificar"
        '
        'grbClasificacion
        '
        Me.grbClasificacion.Controls.Add(Me.txtClasificacion)
        Me.grbClasificacion.Controls.Add(Me.lblClasificacion)
        Me.grbClasificacion.Controls.Add(Me.txtSubTipoActo)
        Me.grbClasificacion.Controls.Add(Me.lblSubTipoActo)
        Me.grbClasificacion.Controls.Add(Me.atxSubTipoActo)
        Me.grbClasificacion.Controls.Add(Me.txtTipoActo)
        Me.grbClasificacion.Controls.Add(Me.Label6)
        Me.grbClasificacion.Controls.Add(Me.Label2)
        Me.grbClasificacion.Controls.Add(Me.txtGrupo)
        Me.grbClasificacion.Controls.Add(Me.Label4)
        Me.grbClasificacion.Controls.Add(Me.Label3)
        Me.grbClasificacion.Location = New System.Drawing.Point(11, 274)
        Me.grbClasificacion.Name = "grbClasificacion"
        Me.grbClasificacion.Size = New System.Drawing.Size(739, 55)
        Me.grbClasificacion.TabIndex = 103
        Me.grbClasificacion.TabStop = False
        Me.grbClasificacion.Text = "Clasificacion de Contrato"
        '
        'txtClasificacion
        '
        Me.txtClasificacion.Location = New System.Drawing.Point(195, 23)
        Me.txtClasificacion.Name = "txtClasificacion"
        Me.txtClasificacion.Size = New System.Drawing.Size(526, 22)
        Me.txtClasificacion.TabIndex = 27
        '
        'lblClasificacion
        '
        Me.lblClasificacion.AutoSize = True
        Me.lblClasificacion.Location = New System.Drawing.Point(0, 26)
        Me.lblClasificacion.Name = "lblClasificacion"
        Me.lblClasificacion.Size = New System.Drawing.Size(81, 14)
        Me.lblClasificacion.TabIndex = 26
        Me.lblClasificacion.Text = "Clasificacion   "
        '
        'txtSubTipoActo
        '
        Me.txtSubTipoActo.Location = New System.Drawing.Point(248, 23)
        Me.txtSubTipoActo.Name = "txtSubTipoActo"
        Me.txtSubTipoActo.Size = New System.Drawing.Size(473, 22)
        Me.txtSubTipoActo.TabIndex = 15
        '
        'lblSubTipoActo
        '
        Me.lblSubTipoActo.AutoSize = True
        Me.lblSubTipoActo.Location = New System.Drawing.Point(0, 26)
        Me.lblSubTipoActo.Name = "lblSubTipoActo"
        Me.lblSubTipoActo.Size = New System.Drawing.Size(78, 14)
        Me.lblSubTipoActo.TabIndex = 14
        Me.lblSubTipoActo.Text = "SubTipoActo"
        '
        'atxSubTipoActo
        '
        Me.atxSubTipoActo.BlancoEsValorInvalido = True
        Me.atxSubTipoActo.CadenaDescripcionNoValida = "Codigo no existe"
        Me.atxSubTipoActo.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.atxSubTipoActo.CatalogoBase = Nothing
        Me.atxSubTipoActo.CatalogoPrincipal = False
        Me.atxSubTipoActo.ColorDesactivado = System.Drawing.Color.Empty
        Me.atxSubTipoActo.ControlDestinoDescripcion = Nothing
        Me.atxSubTipoActo.DescripcionElementoInvalido = "Codigo no existe"
        Me.atxSubTipoActo.EnPantalla = False
        Me.atxSubTipoActo.FiltroExtendido = ""
        Me.atxSubTipoActo.LanzarMensajeError = False
        Me.atxSubTipoActo.Location = New System.Drawing.Point(70, 21)
        Me.atxSubTipoActo.MaxLength = 5
        Me.atxSubTipoActo.Multiple = False
        Me.atxSubTipoActo.Name = "atxSubTipoActo"
        Me.atxSubTipoActo.PermiteAvanceElementoInvalido = True
        Me.atxSubTipoActo.PermiteAyudaRapida = True
        Me.atxSubTipoActo.PermiteSoloCapturarAlfanumericos = False
        Me.atxSubTipoActo.Size = New System.Drawing.Size(119, 22)
        Me.atxSubTipoActo.TabIndex = 13
        Me.atxSubTipoActo.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.atxSubTipoActo.TituloMensaje = "Sistema de Juridico"
        Me.atxSubTipoActo.ValorValido = False
        '
        'txtTipoActo
        '
        Me.txtTipoActo.Location = New System.Drawing.Point(226, 86)
        Me.txtTipoActo.Name = "txtTipoActo"
        Me.txtTipoActo.Size = New System.Drawing.Size(473, 22)
        Me.txtTipoActo.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(287, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 14)
        Me.Label6.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(287, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 14)
        Me.Label2.TabIndex = 11
        '
        'txtGrupo
        '
        Me.txtGrupo.Location = New System.Drawing.Point(226, 56)
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(473, 22)
        Me.txtGrupo.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(286, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 14)
        Me.Label4.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(286, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 14)
        Me.Label3.TabIndex = 7
        '
        'txtCantidadPenalidades
        '
        Me.txtCantidadPenalidades.Location = New System.Drawing.Point(654, 333)
        Me.txtCantidadPenalidades.Name = "txtCantidadPenalidades"
        Me.txtCantidadPenalidades.Size = New System.Drawing.Size(96, 22)
        Me.txtCantidadPenalidades.TabIndex = 102
        '
        'cmbMoneda
        '
        Me.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMoneda.FormattingEnabled = True
        Me.cmbMoneda.Location = New System.Drawing.Point(505, 331)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(143, 22)
        Me.cmbMoneda.TabIndex = 101
        '
        'lblPenalidades
        '
        Me.lblPenalidades.AutoSize = True
        Me.lblPenalidades.Location = New System.Drawing.Point(429, 339)
        Me.lblPenalidades.Name = "lblPenalidades"
        Me.lblPenalidades.Size = New System.Drawing.Size(70, 14)
        Me.lblPenalidades.TabIndex = 100
        Me.lblPenalidades.Text = "Penalidades"
        '
        'lblClave
        '
        Me.lblClave.AutoSize = True
        Me.lblClave.Location = New System.Drawing.Point(195, 81)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New System.Drawing.Size(35, 14)
        Me.lblClave.TabIndex = 99
        Me.lblClave.Text = "Clave"
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(236, 73)
        Me.txtClave.MaxLength = 10
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(245, 22)
        Me.txtClave.TabIndex = 98
        '
        'grboxVigencia
        '
        Me.grboxVigencia.Controls.Add(Me.DTPFechaFirma)
        Me.grboxVigencia.Controls.Add(Me.lblFechaFirma)
        Me.grboxVigencia.Controls.Add(Me.DTPFechaFin)
        Me.grboxVigencia.Controls.Add(Me.DTPFechaini)
        Me.grboxVigencia.Controls.Add(Me.lblFinal)
        Me.grboxVigencia.Controls.Add(Me.lblIni)
        Me.grboxVigencia.Location = New System.Drawing.Point(8, 221)
        Me.grboxVigencia.Name = "grboxVigencia"
        Me.grboxVigencia.Size = New System.Drawing.Size(734, 46)
        Me.grboxVigencia.TabIndex = 97
        Me.grboxVigencia.TabStop = False
        Me.grboxVigencia.Text = "Vigencia"
        '
        'DTPFechaFirma
        '
        Me.DTPFechaFirma.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFechaFirma.Location = New System.Drawing.Point(557, 17)
        Me.DTPFechaFirma.Name = "DTPFechaFirma"
        Me.DTPFechaFirma.Size = New System.Drawing.Size(154, 22)
        Me.DTPFechaFirma.TabIndex = 25
        '
        'lblFechaFirma
        '
        Me.lblFechaFirma.AutoSize = True
        Me.lblFechaFirma.Location = New System.Drawing.Point(480, 24)
        Me.lblFechaFirma.Name = "lblFechaFirma"
        Me.lblFechaFirma.Size = New System.Drawing.Size(71, 14)
        Me.lblFechaFirma.TabIndex = 24
        Me.lblFechaFirma.Text = "Fecha Firma"
        '
        'DTPFechaFin
        '
        Me.DTPFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFechaFin.Location = New System.Drawing.Point(278, 18)
        Me.DTPFechaFin.Name = "DTPFechaFin"
        Me.DTPFechaFin.Size = New System.Drawing.Size(154, 22)
        Me.DTPFechaFin.TabIndex = 21
        '
        'DTPFechaini
        '
        Me.DTPFechaini.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFechaini.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DTPFechaini.Location = New System.Drawing.Point(66, 17)
        Me.DTPFechaini.Name = "DTPFechaini"
        Me.DTPFechaini.Size = New System.Drawing.Size(154, 22)
        Me.DTPFechaini.TabIndex = 21
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Location = New System.Drawing.Point(236, 23)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(30, 14)
        Me.lblFinal.TabIndex = 18
        Me.lblFinal.Text = "Final"
        '
        'lblIni
        '
        Me.lblIni.AutoSize = True
        Me.lblIni.Location = New System.Drawing.Point(20, 24)
        Me.lblIni.Name = "lblIni"
        Me.lblIni.Size = New System.Drawing.Size(36, 14)
        Me.lblIni.TabIndex = 17
        Me.lblIni.Text = "Inicial"
        '
        'GridProveedores
        '
        Me.GridProveedores.Location = New System.Drawing.Point(8, 98)
        Me.GridProveedores.MainView = Me.Grvprovedores
        Me.GridProveedores.Name = "GridProveedores"
        Me.GridProveedores.Size = New System.Drawing.Size(630, 117)
        Me.GridProveedores.TabIndex = 96
        Me.GridProveedores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Grvprovedores})
        '
        'Grvprovedores
        '
        Me.Grvprovedores.GridControl = Me.GridProveedores
        Me.Grvprovedores.Name = "Grvprovedores"
        '
        'txtTipoPersona
        '
        Me.txtTipoPersona.Location = New System.Drawing.Point(457, 104)
        Me.txtTipoPersona.Name = "txtTipoPersona"
        Me.txtTipoPersona.Size = New System.Drawing.Size(125, 22)
        Me.txtTipoPersona.TabIndex = 95
        '
        'txtRFCProv
        '
        Me.txtRFCProv.Location = New System.Drawing.Point(422, 104)
        Me.txtRFCProv.Name = "txtRFCProv"
        Me.txtRFCProv.Size = New System.Drawing.Size(181, 22)
        Me.txtRFCProv.TabIndex = 94
        '
        'txtDescProveedor
        '
        Me.txtDescProveedor.Location = New System.Drawing.Point(93, 132)
        Me.txtDescProveedor.Name = "txtDescProveedor"
        Me.txtDescProveedor.Size = New System.Drawing.Size(481, 22)
        Me.txtDescProveedor.TabIndex = 93
        '
        'txtEstatus
        '
        Me.txtEstatus.Location = New System.Drawing.Point(239, 15)
        Me.txtEstatus.Name = "txtEstatus"
        Me.txtEstatus.Size = New System.Drawing.Size(147, 22)
        Me.txtEstatus.TabIndex = 92
        '
        'txtColor
        '
        Me.txtColor.BackColor = System.Drawing.Color.White
        Me.txtColor.Location = New System.Drawing.Point(184, 15)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(46, 22)
        Me.txtColor.TabIndex = 91
        '
        'DTPFecha
        '
        Me.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecha.Location = New System.Drawing.Point(799, 9)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(73, 22)
        Me.DTPFecha.TabIndex = 90
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Location = New System.Drawing.Point(486, 37)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(277, 22)
        Me.txtDepartamento.TabIndex = 89
        '
        'txtSolicitante
        '
        Me.txtSolicitante.Location = New System.Drawing.Point(486, 9)
        Me.txtSolicitante.Name = "txtSolicitante"
        Me.txtSolicitante.Size = New System.Drawing.Size(277, 22)
        Me.txtSolicitante.TabIndex = 88
        '
        'lblProv
        '
        Me.lblProv.AutoSize = True
        Me.lblProv.Location = New System.Drawing.Point(5, 78)
        Me.lblProv.Name = "lblProv"
        Me.lblProv.Size = New System.Drawing.Size(82, 14)
        Me.lblProv.TabIndex = 87
        Me.lblProv.Text = "Contratantes:"
        '
        'atxProveedor
        '
        Me.atxProveedor.BlancoEsValorInvalido = True
        Me.atxProveedor.CadenaDescripcionNoValida = "Codigo no existe"
        Me.atxProveedor.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.atxProveedor.CatalogoBase = Nothing
        Me.atxProveedor.CatalogoPrincipal = False
        Me.atxProveedor.ColorDesactivado = System.Drawing.Color.Empty
        Me.atxProveedor.ControlDestinoDescripcion = Nothing
        Me.atxProveedor.DescripcionElementoInvalido = "Codigo no existe"
        Me.atxProveedor.EnPantalla = False
        Me.atxProveedor.FiltroExtendido = ""
        Me.atxProveedor.LanzarMensajeError = False
        Me.atxProveedor.Location = New System.Drawing.Point(93, 73)
        Me.atxProveedor.MaxLength = 5
        Me.atxProveedor.Multiple = False
        Me.atxProveedor.Name = "atxProveedor"
        Me.atxProveedor.PermiteAvanceElementoInvalido = True
        Me.atxProveedor.PermiteAyudaRapida = True
        Me.atxProveedor.PermiteSoloCapturarAlfanumericos = False
        Me.atxProveedor.Size = New System.Drawing.Size(84, 22)
        Me.atxProveedor.TabIndex = 86
        Me.atxProveedor.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.atxProveedor.TituloMensaje = "Sistema de Juridico"
        Me.atxProveedor.ValorValido = False
        '
        'lblSolicitante
        '
        Me.lblSolicitante.AutoSize = True
        Me.lblSolicitante.Location = New System.Drawing.Point(406, 15)
        Me.lblSolicitante.Name = "lblSolicitante"
        Me.lblSolicitante.Size = New System.Drawing.Size(63, 14)
        Me.lblSolicitante.TabIndex = 85
        Me.lblSolicitante.Text = "Solicitante"
        '
        'lblDepa
        '
        Me.lblDepa.AutoSize = True
        Me.lblDepa.Location = New System.Drawing.Point(432, 45)
        Me.lblDepa.Name = "lblDepa"
        Me.lblDepa.Size = New System.Drawing.Size(41, 14)
        Me.lblDepa.TabIndex = 84
        Me.lblDepa.Text = "Depto"
        '
        'atxDepartamento
        '
        Me.atxDepartamento.BlancoEsValorInvalido = True
        Me.atxDepartamento.CadenaDescripcionNoValida = "Codigo no existe"
        Me.atxDepartamento.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.atxDepartamento.CatalogoBase = Nothing
        Me.atxDepartamento.CatalogoPrincipal = False
        Me.atxDepartamento.ColorDesactivado = System.Drawing.Color.Empty
        Me.atxDepartamento.ControlDestinoDescripcion = Nothing
        Me.atxDepartamento.DescripcionElementoInvalido = "Codigo no existe"
        Me.atxDepartamento.EnPantalla = False
        Me.atxDepartamento.FiltroExtendido = ""
        Me.atxDepartamento.LanzarMensajeError = False
        Me.atxDepartamento.Location = New System.Drawing.Point(532, 37)
        Me.atxDepartamento.MaxLength = 5
        Me.atxDepartamento.Multiple = False
        Me.atxDepartamento.Name = "atxDepartamento"
        Me.atxDepartamento.PermiteAvanceElementoInvalido = True
        Me.atxDepartamento.PermiteAyudaRapida = True
        Me.atxDepartamento.PermiteSoloCapturarAlfanumericos = False
        Me.atxDepartamento.Size = New System.Drawing.Size(86, 22)
        Me.atxDepartamento.TabIndex = 83
        Me.atxDepartamento.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.atxDepartamento.TituloMensaje = "Sistema de Juridico"
        Me.atxDepartamento.ValorValido = False
        '
        'lblFolio
        '
        Me.lblFolio.AutoSize = True
        Me.lblFolio.Location = New System.Drawing.Point(14, 24)
        Me.lblFolio.Name = "lblFolio"
        Me.lblFolio.Size = New System.Drawing.Size(63, 14)
        Me.lblFolio.TabIndex = 82
        Me.lblFolio.Text = "Folio Solic."
        '
        'atxCodigo
        '
        Me.atxCodigo.BlancoEsValorInvalido = True
        Me.atxCodigo.CadenaDescripcionNoValida = "Codigo no existe"
        Me.atxCodigo.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.atxCodigo.CatalogoBase = Nothing
        Me.atxCodigo.CatalogoPrincipal = False
        Me.atxCodigo.ColorDesactivado = System.Drawing.Color.Empty
        Me.atxCodigo.ControlDestinoDescripcion = Nothing
        Me.atxCodigo.DescripcionElementoInvalido = "Codigo no existe"
        Me.atxCodigo.EnPantalla = False
        Me.atxCodigo.FiltroExtendido = ""
        Me.atxCodigo.LanzarMensajeError = False
        Me.atxCodigo.Location = New System.Drawing.Point(94, 15)
        Me.atxCodigo.MaxLength = 5
        Me.atxCodigo.Multiple = False
        Me.atxCodigo.Name = "atxCodigo"
        Me.atxCodigo.PermiteAvanceElementoInvalido = True
        Me.atxCodigo.PermiteAyudaRapida = True
        Me.atxCodigo.PermiteSoloCapturarAlfanumericos = False
        Me.atxCodigo.Size = New System.Drawing.Size(83, 22)
        Me.atxCodigo.TabIndex = 81
        Me.atxCodigo.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.atxCodigo.TituloMensaje = "Sistema de Juridico"
        Me.atxCodigo.ValorValido = False
        '
        'txtretro
        '
        Me.txtretro.Location = New System.Drawing.Point(9, 499)
        Me.txtretro.Multiline = True
        Me.txtretro.Name = "txtretro"
        Me.txtretro.Size = New System.Drawing.Size(850, 74)
        Me.txtretro.TabIndex = 112
        '
        'lblRetro
        '
        Me.lblRetro.AutoSize = True
        Me.lblRetro.Location = New System.Drawing.Point(11, 480)
        Me.lblRetro.Name = "lblRetro"
        Me.lblRetro.Size = New System.Drawing.Size(173, 14)
        Me.lblRetro.TabIndex = 111
        Me.lblRetro.Text = "Retroalimentación a Propuesta"
        '
        'lblespecificaciones
        '
        Me.lblespecificaciones.AutoSize = True
        Me.lblespecificaciones.Location = New System.Drawing.Point(8, 341)
        Me.lblespecificaciones.Name = "lblespecificaciones"
        Me.lblespecificaciones.Size = New System.Drawing.Size(217, 14)
        Me.lblespecificaciones.TabIndex = 110
        Me.lblespecificaciones.Text = "Especificaciones adicionales al contrato"
        '
        'txtPenalidades
        '
        Me.txtPenalidades.Location = New System.Drawing.Point(432, 356)
        Me.txtPenalidades.Multiline = True
        Me.txtPenalidades.Name = "txtPenalidades"
        Me.txtPenalidades.Size = New System.Drawing.Size(427, 117)
        Me.txtPenalidades.TabIndex = 109
        '
        'txtEspecificaciones
        '
        Me.txtEspecificaciones.Location = New System.Drawing.Point(11, 358)
        Me.txtEspecificaciones.Multiline = True
        Me.txtEspecificaciones.Name = "txtEspecificaciones"
        Me.txtEspecificaciones.Size = New System.Drawing.Size(405, 117)
        Me.txtEspecificaciones.TabIndex = 108
        '
        'lblAccion
        '
        Me.lblAccion.AutoSize = True
        Me.lblAccion.Location = New System.Drawing.Point(664, 171)
        Me.lblAccion.Name = "lblAccion"
        Me.lblAccion.Size = New System.Drawing.Size(123, 14)
        Me.lblAccion.TabIndex = 148
        Me.lblAccion.Text = "Acceptar o Rechazar:"
        '
        'cmbsolicitar
        '
        Me.cmbsolicitar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsolicitar.FormattingEnabled = True
        Me.cmbsolicitar.Location = New System.Drawing.Point(648, 188)
        Me.cmbsolicitar.Name = "cmbsolicitar"
        Me.cmbsolicitar.Size = New System.Drawing.Size(150, 22)
        Me.cmbsolicitar.TabIndex = 147
        '
        'txtcorreo2
        '
        Me.txtcorreo2.Location = New System.Drawing.Point(646, 132)
        Me.txtcorreo2.Name = "txtcorreo2"
        Me.txtcorreo2.Size = New System.Drawing.Size(218, 22)
        Me.txtcorreo2.TabIndex = 151
        '
        'lblEstatusRenoExt
        '
        Me.lblEstatusRenoExt.AutoSize = True
        Me.lblEstatusRenoExt.Location = New System.Drawing.Point(793, 171)
        Me.lblEstatusRenoExt.Name = "lblEstatusRenoExt"
        Me.lblEstatusRenoExt.Size = New System.Drawing.Size(0, 14)
        Me.lblEstatusRenoExt.TabIndex = 152
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmM2702007
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 604)
        Me.Controls.Add(Me.lblEstatusRenoExt)
        Me.Controls.Add(Me.txtcorreo2)
        Me.Controls.Add(Me.lblAccion)
        Me.Controls.Add(Me.cmbsolicitar)
        Me.Controls.Add(Me.txtretro)
        Me.Controls.Add(Me.lblRetro)
        Me.Controls.Add(Me.lblespecificaciones)
        Me.Controls.Add(Me.txtPenalidades)
        Me.Controls.Add(Me.txtEspecificaciones)
        Me.Controls.Add(Me.btnVerArchivo)
        Me.Controls.Add(Me.btnArchivo)
        Me.Controls.Add(Me.txtCoreo)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.grbClasificacion)
        Me.Controls.Add(Me.txtCantidadPenalidades)
        Me.Controls.Add(Me.cmbMoneda)
        Me.Controls.Add(Me.lblPenalidades)
        Me.Controls.Add(Me.lblClave)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.grboxVigencia)
        Me.Controls.Add(Me.GridProveedores)
        Me.Controls.Add(Me.txtTipoPersona)
        Me.Controls.Add(Me.txtRFCProv)
        Me.Controls.Add(Me.txtDescProveedor)
        Me.Controls.Add(Me.txtEstatus)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.DTPFecha)
        Me.Controls.Add(Me.txtDepartamento)
        Me.Controls.Add(Me.txtSolicitante)
        Me.Controls.Add(Me.lblProv)
        Me.Controls.Add(Me.atxProveedor)
        Me.Controls.Add(Me.lblSolicitante)
        Me.Controls.Add(Me.lblDepa)
        Me.Controls.Add(Me.atxDepartamento)
        Me.Controls.Add(Me.lblFolio)
        Me.Controls.Add(Me.atxCodigo)
        Me.Name = "FrmM2702007"
        Me.ReferenciaRapidaVisible = True
        Me.Text = "Extención ó Renovación De Contrato"
        Me.Controls.SetChildIndex(Me.atxCodigo, 0)
        Me.Controls.SetChildIndex(Me.lblFolio, 0)
        Me.Controls.SetChildIndex(Me.atxDepartamento, 0)
        Me.Controls.SetChildIndex(Me.lblDepa, 0)
        Me.Controls.SetChildIndex(Me.lblSolicitante, 0)
        Me.Controls.SetChildIndex(Me.atxProveedor, 0)
        Me.Controls.SetChildIndex(Me.lblProv, 0)
        Me.Controls.SetChildIndex(Me.txtSolicitante, 0)
        Me.Controls.SetChildIndex(Me.txtDepartamento, 0)
        Me.Controls.SetChildIndex(Me.DTPFecha, 0)
        Me.Controls.SetChildIndex(Me.txtColor, 0)
        Me.Controls.SetChildIndex(Me.txtEstatus, 0)
        Me.Controls.SetChildIndex(Me.txtDescProveedor, 0)
        Me.Controls.SetChildIndex(Me.txtRFCProv, 0)
        Me.Controls.SetChildIndex(Me.txtTipoPersona, 0)
        Me.Controls.SetChildIndex(Me.GridProveedores, 0)
        Me.Controls.SetChildIndex(Me.grboxVigencia, 0)
        Me.Controls.SetChildIndex(Me.txtClave, 0)
        Me.Controls.SetChildIndex(Me.lblClave, 0)
        Me.Controls.SetChildIndex(Me.lblPenalidades, 0)
        Me.Controls.SetChildIndex(Me.cmbMoneda, 0)
        Me.Controls.SetChildIndex(Me.txtCantidadPenalidades, 0)
        Me.Controls.SetChildIndex(Me.grbClasificacion, 0)
        Me.Controls.SetChildIndex(Me.lblCorreo, 0)
        Me.Controls.SetChildIndex(Me.txtCoreo, 0)
        Me.Controls.SetChildIndex(Me.btnArchivo, 0)
        Me.Controls.SetChildIndex(Me.btnVerArchivo, 0)
        Me.Controls.SetChildIndex(Me.txtEspecificaciones, 0)
        Me.Controls.SetChildIndex(Me.txtPenalidades, 0)
        Me.Controls.SetChildIndex(Me.lblespecificaciones, 0)
        Me.Controls.SetChildIndex(Me.lblRetro, 0)
        Me.Controls.SetChildIndex(Me.txtretro, 0)
        Me.Controls.SetChildIndex(Me.cmbsolicitar, 0)
        Me.Controls.SetChildIndex(Me.lblAccion, 0)
        Me.Controls.SetChildIndex(Me.lblToolTip, 0)
        Me.Controls.SetChildIndex(Me.txtcorreo2, 0)
        Me.Controls.SetChildIndex(Me.lblEstatusRenoExt, 0)
        Me.grbClasificacion.ResumeLayout(False)
        Me.grbClasificacion.PerformLayout()
        Me.grboxVigencia.ResumeLayout(False)
        Me.grboxVigencia.PerformLayout()
        CType(Me.GridProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grvprovedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVerArchivo As Button
    Friend WithEvents btnArchivo As Button
    Friend WithEvents txtCoreo As TextBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents grbClasificacion As GroupBox
    Friend WithEvents txtClasificacion As TextBox
    Friend WithEvents lblClasificacion As Label
    Friend WithEvents txtSubTipoActo As TextBox
    Friend WithEvents lblSubTipoActo As Label
    Friend WithEvents atxSubTipoActo As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents txtTipoActo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGrupo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCantidadPenalidades As TextBox
    Friend WithEvents cmbMoneda As ComboBox
    Friend WithEvents lblPenalidades As Label
    Friend WithEvents lblClave As Label
    Friend WithEvents txtClave As TextBox
    Friend WithEvents grboxVigencia As GroupBox
    Friend WithEvents DTPFechaFirma As DateTimePicker
    Friend WithEvents lblFechaFirma As Label
    Friend WithEvents DTPFechaFin As DateTimePicker
    Friend WithEvents DTPFechaini As DateTimePicker
    Friend WithEvents lblFinal As Label
    Friend WithEvents lblIni As Label
    Friend WithEvents GridProveedores As DevExpress.XtraGrid.GridControl
    Friend WithEvents Grvprovedores As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtTipoPersona As TextBox
    Friend WithEvents txtRFCProv As TextBox
    Friend WithEvents txtDescProveedor As TextBox
    Friend WithEvents txtEstatus As TextBox
    Friend WithEvents txtColor As TextBox
    Friend WithEvents DTPFecha As DateTimePicker
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents txtSolicitante As TextBox
    Friend WithEvents lblProv As Label
    Friend WithEvents atxProveedor As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents lblSolicitante As Label
    Friend WithEvents lblDepa As Label
    Friend WithEvents atxDepartamento As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents lblFolio As Label
    Friend WithEvents atxCodigo As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents txtretro As TextBox
    Friend WithEvents lblRetro As Label
    Friend WithEvents lblespecificaciones As Label
    Friend WithEvents txtPenalidades As TextBox
    Friend WithEvents txtEspecificaciones As TextBox
    Friend WithEvents lblAccion As Label
    Friend WithEvents cmbsolicitar As ComboBox
    Friend WithEvents txtcorreo2 As TextBox
    Friend WithEvents lblEstatusRenoExt As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
