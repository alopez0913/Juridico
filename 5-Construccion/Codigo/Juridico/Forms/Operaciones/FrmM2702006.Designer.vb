<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmM2702006
    '  Inherits System.Windows.Forms.Form
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
        Me.txtretro = New System.Windows.Forms.TextBox()
        Me.lblRetro = New System.Windows.Forms.Label()
        Me.lblespecificaciones = New System.Windows.Forms.Label()
        Me.txtPenalidades = New System.Windows.Forms.TextBox()
        Me.txtEspecificaciones = New System.Windows.Forms.TextBox()
        Me.btnVerArchivo = New System.Windows.Forms.Button()
        Me.btnArchivo = New System.Windows.Forms.Button()
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
        Me.cmbSolicitar = New System.Windows.Forms.ComboBox()
        Me.lblAccion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtcorreo2 = New System.Windows.Forms.TextBox()
        Me.txtCoreo = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblEstatusRenoExt = New System.Windows.Forms.Label()
        Me.grbClasificacion.SuspendLayout()
        Me.grboxVigencia.SuspendLayout()
        CType(Me.GridProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grvprovedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblToolTip
        '
        Me.lblToolTip.Location = New System.Drawing.Point(-13, 16)
        Me.lblToolTip.Size = New System.Drawing.Size(19, 25)
        '
        'txtretro
        '
        Me.txtretro.Location = New System.Drawing.Point(6, 470)
        Me.txtretro.Multiline = True
        Me.txtretro.Name = "txtretro"
        Me.txtretro.Size = New System.Drawing.Size(848, 63)
        Me.txtretro.TabIndex = 144
        '
        'lblRetro
        '
        Me.lblRetro.AutoSize = True
        Me.lblRetro.Location = New System.Drawing.Point(3, 453)
        Me.lblRetro.Name = "lblRetro"
        Me.lblRetro.Size = New System.Drawing.Size(173, 14)
        Me.lblRetro.TabIndex = 143
        Me.lblRetro.Text = "Retroalimentación a Propuesta"
        '
        'lblespecificaciones
        '
        Me.lblespecificaciones.AutoSize = True
        Me.lblespecificaciones.Location = New System.Drawing.Point(3, 315)
        Me.lblespecificaciones.Name = "lblespecificaciones"
        Me.lblespecificaciones.Size = New System.Drawing.Size(217, 14)
        Me.lblespecificaciones.TabIndex = 142
        Me.lblespecificaciones.Text = "Especificaciones adicionales al contrato"
        '
        'txtPenalidades
        '
        Me.txtPenalidades.Location = New System.Drawing.Point(426, 333)
        Me.txtPenalidades.Multiline = True
        Me.txtPenalidades.Name = "txtPenalidades"
        Me.txtPenalidades.Size = New System.Drawing.Size(425, 117)
        Me.txtPenalidades.TabIndex = 141
        '
        'txtEspecificaciones
        '
        Me.txtEspecificaciones.Location = New System.Drawing.Point(3, 333)
        Me.txtEspecificaciones.Multiline = True
        Me.txtEspecificaciones.Name = "txtEspecificaciones"
        Me.txtEspecificaciones.Size = New System.Drawing.Size(413, 117)
        Me.txtEspecificaciones.TabIndex = 140
        '
        'btnVerArchivo
        '
        Me.btnVerArchivo.Location = New System.Drawing.Point(789, 270)
        Me.btnVerArchivo.Name = "btnVerArchivo"
        Me.btnVerArchivo.Size = New System.Drawing.Size(105, 59)
        Me.btnVerArchivo.TabIndex = 139
        Me.btnVerArchivo.Text = "Ver Archivo"
        Me.btnVerArchivo.UseVisualStyleBackColor = True
        '
        'btnArchivo
        '
        Me.btnArchivo.Location = New System.Drawing.Point(789, 211)
        Me.btnArchivo.Name = "btnArchivo"
        Me.btnArchivo.Size = New System.Drawing.Size(105, 57)
        Me.btnArchivo.TabIndex = 138
        Me.btnArchivo.Text = "Subir Archivo"
        Me.btnArchivo.UseVisualStyleBackColor = True
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
        Me.grbClasificacion.Location = New System.Drawing.Point(3, 259)
        Me.grbClasificacion.Name = "grbClasificacion"
        Me.grbClasificacion.Size = New System.Drawing.Size(777, 45)
        Me.grbClasificacion.TabIndex = 135
        Me.grbClasificacion.TabStop = False
        Me.grbClasificacion.Text = "Clasificacion de Contrato"
        '
        'txtClasificacion
        '
        Me.txtClasificacion.Location = New System.Drawing.Point(219, 18)
        Me.txtClasificacion.Name = "txtClasificacion"
        Me.txtClasificacion.Size = New System.Drawing.Size(548, 22)
        Me.txtClasificacion.TabIndex = 27
        '
        'lblClasificacion
        '
        Me.lblClasificacion.AutoSize = True
        Me.lblClasificacion.Location = New System.Drawing.Point(12, 26)
        Me.lblClasificacion.Name = "lblClasificacion"
        Me.lblClasificacion.Size = New System.Drawing.Size(81, 14)
        Me.lblClasificacion.TabIndex = 26
        Me.lblClasificacion.Text = "Clasificacion   "
        '
        'txtSubTipoActo
        '
        Me.txtSubTipoActo.Location = New System.Drawing.Point(246, 18)
        Me.txtSubTipoActo.Name = "txtSubTipoActo"
        Me.txtSubTipoActo.Size = New System.Drawing.Size(473, 22)
        Me.txtSubTipoActo.TabIndex = 15
        '
        'lblSubTipoActo
        '
        Me.lblSubTipoActo.AutoSize = True
        Me.lblSubTipoActo.Location = New System.Drawing.Point(15, 26)
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
        Me.atxSubTipoActo.Location = New System.Drawing.Point(94, 18)
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
        Me.txtCantidadPenalidades.Location = New System.Drawing.Point(659, 306)
        Me.txtCantidadPenalidades.Name = "txtCantidadPenalidades"
        Me.txtCantidadPenalidades.Size = New System.Drawing.Size(108, 22)
        Me.txtCantidadPenalidades.TabIndex = 134
        '
        'cmbMoneda
        '
        Me.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMoneda.FormattingEnabled = True
        Me.cmbMoneda.Location = New System.Drawing.Point(490, 306)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(163, 22)
        Me.cmbMoneda.TabIndex = 133
        '
        'lblPenalidades
        '
        Me.lblPenalidades.AutoSize = True
        Me.lblPenalidades.Location = New System.Drawing.Point(423, 311)
        Me.lblPenalidades.Name = "lblPenalidades"
        Me.lblPenalidades.Size = New System.Drawing.Size(70, 14)
        Me.lblPenalidades.TabIndex = 132
        Me.lblPenalidades.Text = "Penalidades"
        '
        'lblClave
        '
        Me.lblClave.AutoSize = True
        Me.lblClave.Location = New System.Drawing.Point(192, 76)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New System.Drawing.Size(35, 14)
        Me.lblClave.TabIndex = 131
        Me.lblClave.Text = "Clave"
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(233, 68)
        Me.txtClave.MaxLength = 10
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(304, 22)
        Me.txtClave.TabIndex = 130
        '
        'grboxVigencia
        '
        Me.grboxVigencia.Controls.Add(Me.DTPFechaFirma)
        Me.grboxVigencia.Controls.Add(Me.lblFechaFirma)
        Me.grboxVigencia.Controls.Add(Me.DTPFechaFin)
        Me.grboxVigencia.Controls.Add(Me.DTPFechaini)
        Me.grboxVigencia.Controls.Add(Me.lblFinal)
        Me.grboxVigencia.Controls.Add(Me.lblIni)
        Me.grboxVigencia.Location = New System.Drawing.Point(3, 207)
        Me.grboxVigencia.Name = "grboxVigencia"
        Me.grboxVigencia.Size = New System.Drawing.Size(780, 46)
        Me.grboxVigencia.TabIndex = 129
        Me.grboxVigencia.TabStop = False
        Me.grboxVigencia.Text = "Vigencia"
        '
        'DTPFechaFirma
        '
        Me.DTPFechaFirma.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFechaFirma.Location = New System.Drawing.Point(594, 21)
        Me.DTPFechaFirma.Name = "DTPFechaFirma"
        Me.DTPFechaFirma.Size = New System.Drawing.Size(154, 22)
        Me.DTPFechaFirma.TabIndex = 25
        '
        'lblFechaFirma
        '
        Me.lblFechaFirma.AutoSize = True
        Me.lblFechaFirma.Location = New System.Drawing.Point(517, 24)
        Me.lblFechaFirma.Name = "lblFechaFirma"
        Me.lblFechaFirma.Size = New System.Drawing.Size(71, 14)
        Me.lblFechaFirma.TabIndex = 24
        Me.lblFechaFirma.Text = "Fecha Firma"
        '
        'DTPFechaFin
        '
        Me.DTPFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFechaFin.Location = New System.Drawing.Point(303, 18)
        Me.DTPFechaFin.Name = "DTPFechaFin"
        Me.DTPFechaFin.Size = New System.Drawing.Size(154, 22)
        Me.DTPFechaFin.TabIndex = 21
        '
        'DTPFechaini
        '
        Me.DTPFechaini.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFechaini.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DTPFechaini.Location = New System.Drawing.Point(98, 18)
        Me.DTPFechaini.Name = "DTPFechaini"
        Me.DTPFechaini.Size = New System.Drawing.Size(154, 22)
        Me.DTPFechaini.TabIndex = 21
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Location = New System.Drawing.Point(260, 23)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(30, 14)
        Me.lblFinal.TabIndex = 18
        Me.lblFinal.Text = "Final"
        '
        'lblIni
        '
        Me.lblIni.AutoSize = True
        Me.lblIni.Location = New System.Drawing.Point(52, 25)
        Me.lblIni.Name = "lblIni"
        Me.lblIni.Size = New System.Drawing.Size(36, 14)
        Me.lblIni.TabIndex = 17
        Me.lblIni.Text = "Inicial"
        '
        'GridProveedores
        '
        Me.GridProveedores.Location = New System.Drawing.Point(15, 94)
        Me.GridProveedores.MainView = Me.Grvprovedores
        Me.GridProveedores.Name = "GridProveedores"
        Me.GridProveedores.Size = New System.Drawing.Size(630, 107)
        Me.GridProveedores.TabIndex = 128
        Me.GridProveedores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Grvprovedores})
        '
        'Grvprovedores
        '
        Me.Grvprovedores.GridControl = Me.GridProveedores
        Me.Grvprovedores.Name = "Grvprovedores"
        '
        'txtTipoPersona
        '
        Me.txtTipoPersona.Location = New System.Drawing.Point(479, 143)
        Me.txtTipoPersona.Name = "txtTipoPersona"
        Me.txtTipoPersona.Size = New System.Drawing.Size(125, 22)
        Me.txtTipoPersona.TabIndex = 127
        '
        'txtRFCProv
        '
        Me.txtRFCProv.Location = New System.Drawing.Point(445, 115)
        Me.txtRFCProv.Name = "txtRFCProv"
        Me.txtRFCProv.Size = New System.Drawing.Size(181, 22)
        Me.txtRFCProv.TabIndex = 126
        '
        'txtDescProveedor
        '
        Me.txtDescProveedor.Location = New System.Drawing.Point(102, 134)
        Me.txtDescProveedor.Name = "txtDescProveedor"
        Me.txtDescProveedor.Size = New System.Drawing.Size(481, 22)
        Me.txtDescProveedor.TabIndex = 125
        '
        'txtEstatus
        '
        Me.txtEstatus.Location = New System.Drawing.Point(222, 13)
        Me.txtEstatus.Name = "txtEstatus"
        Me.txtEstatus.Size = New System.Drawing.Size(147, 22)
        Me.txtEstatus.TabIndex = 124
        '
        'txtColor
        '
        Me.txtColor.BackColor = System.Drawing.Color.White
        Me.txtColor.Location = New System.Drawing.Point(170, 13)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(46, 22)
        Me.txtColor.TabIndex = 123
        '
        'DTPFecha
        '
        Me.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecha.Location = New System.Drawing.Point(771, 8)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(108, 22)
        Me.DTPFecha.TabIndex = 122
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Location = New System.Drawing.Point(466, 38)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(277, 22)
        Me.txtDepartamento.TabIndex = 121
        '
        'txtSolicitante
        '
        Me.txtSolicitante.Location = New System.Drawing.Point(466, 10)
        Me.txtSolicitante.Name = "txtSolicitante"
        Me.txtSolicitante.Size = New System.Drawing.Size(277, 22)
        Me.txtSolicitante.TabIndex = 120
        '
        'lblProv
        '
        Me.lblProv.AutoSize = True
        Me.lblProv.Location = New System.Drawing.Point(10, 76)
        Me.lblProv.Name = "lblProv"
        Me.lblProv.Size = New System.Drawing.Size(86, 14)
        Me.lblProv.TabIndex = 119
        Me.lblProv.Text = "Contratantes: "
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
        Me.atxProveedor.Location = New System.Drawing.Point(97, 68)
        Me.atxProveedor.MaxLength = 5
        Me.atxProveedor.Multiple = False
        Me.atxProveedor.Name = "atxProveedor"
        Me.atxProveedor.PermiteAvanceElementoInvalido = True
        Me.atxProveedor.PermiteAyudaRapida = True
        Me.atxProveedor.PermiteSoloCapturarAlfanumericos = False
        Me.atxProveedor.Size = New System.Drawing.Size(83, 22)
        Me.atxProveedor.TabIndex = 118
        Me.atxProveedor.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.atxProveedor.TituloMensaje = "Sistema de Juridico"
        Me.atxProveedor.ValorValido = False
        '
        'lblSolicitante
        '
        Me.lblSolicitante.AutoSize = True
        Me.lblSolicitante.Location = New System.Drawing.Point(397, 16)
        Me.lblSolicitante.Name = "lblSolicitante"
        Me.lblSolicitante.Size = New System.Drawing.Size(63, 14)
        Me.lblSolicitante.TabIndex = 117
        Me.lblSolicitante.Text = "Solicitante"
        '
        'lblDepa
        '
        Me.lblDepa.AutoSize = True
        Me.lblDepa.Location = New System.Drawing.Point(419, 47)
        Me.lblDepa.Name = "lblDepa"
        Me.lblDepa.Size = New System.Drawing.Size(41, 14)
        Me.lblDepa.TabIndex = 116
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
        Me.atxDepartamento.Location = New System.Drawing.Point(519, 39)
        Me.atxDepartamento.MaxLength = 5
        Me.atxDepartamento.Multiple = False
        Me.atxDepartamento.Name = "atxDepartamento"
        Me.atxDepartamento.PermiteAvanceElementoInvalido = True
        Me.atxDepartamento.PermiteAyudaRapida = True
        Me.atxDepartamento.PermiteSoloCapturarAlfanumericos = False
        Me.atxDepartamento.Size = New System.Drawing.Size(86, 22)
        Me.atxDepartamento.TabIndex = 115
        Me.atxDepartamento.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.atxDepartamento.TituloMensaje = "Sistema de Juridico"
        Me.atxDepartamento.ValorValido = False
        '
        'lblFolio
        '
        Me.lblFolio.AutoSize = True
        Me.lblFolio.Location = New System.Drawing.Point(12, 16)
        Me.lblFolio.Name = "lblFolio"
        Me.lblFolio.Size = New System.Drawing.Size(63, 14)
        Me.lblFolio.TabIndex = 114
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
        Me.atxCodigo.Location = New System.Drawing.Point(81, 11)
        Me.atxCodigo.MaxLength = 5
        Me.atxCodigo.Multiple = False
        Me.atxCodigo.Name = "atxCodigo"
        Me.atxCodigo.PermiteAvanceElementoInvalido = True
        Me.atxCodigo.PermiteAyudaRapida = True
        Me.atxCodigo.PermiteSoloCapturarAlfanumericos = False
        Me.atxCodigo.Size = New System.Drawing.Size(83, 22)
        Me.atxCodigo.TabIndex = 113
        Me.atxCodigo.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.atxCodigo.TituloMensaje = "Sistema de Juridico"
        Me.atxCodigo.ValorValido = False
        '
        'cmbSolicitar
        '
        Me.cmbSolicitar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSolicitar.FormattingEnabled = True
        Me.cmbSolicitar.Location = New System.Drawing.Point(661, 169)
        Me.cmbSolicitar.Name = "cmbSolicitar"
        Me.cmbSolicitar.Size = New System.Drawing.Size(150, 22)
        Me.cmbSolicitar.TabIndex = 145
        '
        'lblAccion
        '
        Me.lblAccion.AutoSize = True
        Me.lblAccion.Location = New System.Drawing.Point(663, 151)
        Me.lblAccion.Name = "lblAccion"
        Me.lblAccion.Size = New System.Drawing.Size(142, 14)
        Me.lblAccion.TabIndex = 146
        Me.lblAccion.Text = "Extención ó Renovación:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(709, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 14)
        Me.Label1.TabIndex = 147
        Me.Label1.Text = "Solicitar"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtcorreo2
        '
        Me.txtcorreo2.Location = New System.Drawing.Point(661, 113)
        Me.txtcorreo2.Name = "txtcorreo2"
        Me.txtcorreo2.Size = New System.Drawing.Size(218, 22)
        Me.txtcorreo2.TabIndex = 150
        '
        'txtCoreo
        '
        Me.txtCoreo.Location = New System.Drawing.Point(661, 85)
        Me.txtCoreo.Name = "txtCoreo"
        Me.txtCoreo.Size = New System.Drawing.Size(218, 22)
        Me.txtCoreo.TabIndex = 149
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(709, 68)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(106, 14)
        Me.lblCorreo.TabIndex = 148
        Me.lblCorreo.Text = "Correos a Notificar"
        '
        'lblEstatusRenoExt
        '
        Me.lblEstatusRenoExt.AutoSize = True
        Me.lblEstatusRenoExt.Location = New System.Drawing.Point(812, 151)
        Me.lblEstatusRenoExt.Name = "lblEstatusRenoExt"
        Me.lblEstatusRenoExt.Size = New System.Drawing.Size(0, 14)
        Me.lblEstatusRenoExt.TabIndex = 151
        '
        'FrmM2702006
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 566)
        Me.Controls.Add(Me.lblEstatusRenoExt)
        Me.Controls.Add(Me.txtcorreo2)
        Me.Controls.Add(Me.txtCoreo)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAccion)
        Me.Controls.Add(Me.cmbSolicitar)
        Me.Controls.Add(Me.txtretro)
        Me.Controls.Add(Me.lblRetro)
        Me.Controls.Add(Me.lblespecificaciones)
        Me.Controls.Add(Me.txtPenalidades)
        Me.Controls.Add(Me.txtEspecificaciones)
        Me.Controls.Add(Me.btnVerArchivo)
        Me.Controls.Add(Me.btnArchivo)
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
        Me.Name = "FrmM2702006"
        Me.ReferenciaRapidaVisible = True
        Me.Text = "Solicitud de Renovacion ó Extención de Contrato"
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
        Me.Controls.SetChildIndex(Me.btnArchivo, 0)
        Me.Controls.SetChildIndex(Me.btnVerArchivo, 0)
        Me.Controls.SetChildIndex(Me.txtEspecificaciones, 0)
        Me.Controls.SetChildIndex(Me.txtPenalidades, 0)
        Me.Controls.SetChildIndex(Me.lblespecificaciones, 0)
        Me.Controls.SetChildIndex(Me.lblRetro, 0)
        Me.Controls.SetChildIndex(Me.txtretro, 0)
        Me.Controls.SetChildIndex(Me.cmbSolicitar, 0)
        Me.Controls.SetChildIndex(Me.lblAccion, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.lblToolTip, 0)
        Me.Controls.SetChildIndex(Me.lblCorreo, 0)
        Me.Controls.SetChildIndex(Me.txtCoreo, 0)
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

    Friend WithEvents txtretro As TextBox
    Friend WithEvents lblRetro As Label
    Friend WithEvents lblespecificaciones As Label
    Friend WithEvents txtPenalidades As TextBox
    Friend WithEvents txtEspecificaciones As TextBox
    Friend WithEvents btnVerArchivo As Button
    Friend WithEvents btnArchivo As Button
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
    Friend WithEvents cmbSolicitar As ComboBox
    Friend WithEvents lblAccion As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtcorreo2 As TextBox
    Friend WithEvents txtCoreo As TextBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblEstatusRenoExt As Label
End Class
