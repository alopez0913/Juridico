<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmM2701003
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gpBoxGrupos = New System.Windows.Forms.GroupBox()
        Me.cmbTipoActo = New System.Windows.Forms.ComboBox()
        Me.lblTipoActo = New System.Windows.Forms.Label()
        Me.cmbGrupo = New System.Windows.Forms.ComboBox()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.lblOperacion = New System.Windows.Forms.Label()
        Me.lblAsterisco2 = New System.Windows.Forms.Label()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.lblAsterisco1 = New System.Windows.Forms.Label()
        Me.AtxSubTipo = New ADSUM.AdsumTextBoxAdvanced()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblSubTipo = New System.Windows.Forms.Label()
        Me.AtxDescripcion = New ADSUM.AdsumTextBoxAdvanced()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.gpBoxGrupos.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpBoxGrupos
        '
        Me.gpBoxGrupos.Controls.Add(Me.cmbTipoActo)
        Me.gpBoxGrupos.Controls.Add(Me.lblTipoActo)
        Me.gpBoxGrupos.Controls.Add(Me.cmbGrupo)
        Me.gpBoxGrupos.Controls.Add(Me.lblGrupo)
        Me.gpBoxGrupos.Controls.Add(Me.lblOperacion)
        Me.gpBoxGrupos.Controls.Add(Me.lblAsterisco2)
        Me.gpBoxGrupos.Controls.Add(Me.dtpFechaInicial)
        Me.gpBoxGrupos.Controls.Add(Me.lblAsterisco1)
        Me.gpBoxGrupos.Controls.Add(Me.AtxSubTipo)
        Me.gpBoxGrupos.Controls.Add(Me.lblDescripcion)
        Me.gpBoxGrupos.Controls.Add(Me.lblSubTipo)
        Me.gpBoxGrupos.Controls.Add(Me.AtxDescripcion)
        Me.gpBoxGrupos.Controls.Add(Me.lblFecha)
        Me.gpBoxGrupos.Location = New System.Drawing.Point(4, 17)
        Me.gpBoxGrupos.Name = "gpBoxGrupos"
        Me.gpBoxGrupos.Size = New System.Drawing.Size(776, 390)
        Me.gpBoxGrupos.TabIndex = 80
        Me.gpBoxGrupos.TabStop = False
        '
        'cmbTipoActo
        '
        Me.cmbTipoActo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoActo.FormattingEnabled = True
        Me.cmbTipoActo.Location = New System.Drawing.Point(116, 119)
        Me.cmbTipoActo.Name = "cmbTipoActo"
        Me.cmbTipoActo.Size = New System.Drawing.Size(356, 22)
        Me.cmbTipoActo.TabIndex = 15
        '
        'lblTipoActo
        '
        Me.lblTipoActo.AutoSize = True
        Me.lblTipoActo.Location = New System.Drawing.Point(36, 119)
        Me.lblTipoActo.Name = "lblTipoActo"
        Me.lblTipoActo.Size = New System.Drawing.Size(61, 14)
        Me.lblTipoActo.TabIndex = 84
        Me.lblTipoActo.Text = "Tipo Acto"
        '
        'cmbGrupo
        '
        Me.cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGrupo.FormattingEnabled = True
        Me.cmbGrupo.Location = New System.Drawing.Point(116, 81)
        Me.cmbGrupo.Name = "cmbGrupo"
        Me.cmbGrupo.Size = New System.Drawing.Size(356, 22)
        Me.cmbGrupo.TabIndex = 10
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.Location = New System.Drawing.Point(57, 81)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(40, 14)
        Me.lblGrupo.TabIndex = 82
        Me.lblGrupo.Text = "Grupo"
        '
        'lblOperacion
        '
        Me.lblOperacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOperacion.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblOperacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOperacion.ForeColor = System.Drawing.Color.White
        Me.lblOperacion.Location = New System.Drawing.Point(343, 12)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(129, 22)
        Me.lblOperacion.TabIndex = 79
        Me.lblOperacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAsterisco2
        '
        Me.lblAsterisco2.AutoSize = True
        Me.lblAsterisco2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsterisco2.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisco2.Location = New System.Drawing.Point(99, 44)
        Me.lblAsterisco2.Name = "lblAsterisco2"
        Me.lblAsterisco2.Size = New System.Drawing.Size(15, 14)
        Me.lblAsterisco2.TabIndex = 78
        Me.lblAsterisco2.Text = "*"
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaInicial.Enabled = False
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaInicial.Location = New System.Drawing.Point(663, 13)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(107, 22)
        Me.dtpFechaInicial.TabIndex = 71
        Me.dtpFechaInicial.Value = New Date(2019, 7, 15, 0, 0, 0, 0)
        '
        'lblAsterisco1
        '
        Me.lblAsterisco1.AutoSize = True
        Me.lblAsterisco1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsterisco1.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisco1.Location = New System.Drawing.Point(99, 19)
        Me.lblAsterisco1.Name = "lblAsterisco1"
        Me.lblAsterisco1.Size = New System.Drawing.Size(15, 14)
        Me.lblAsterisco1.TabIndex = 70
        Me.lblAsterisco1.Text = "*"
        '
        'AtxSubTipo
        '
        Me.AtxSubTipo.BlancoEsValorInvalido = True
        Me.AtxSubTipo.CadenaDescripcionNoValida = "Codigo no existe"
        Me.AtxSubTipo.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AtxSubTipo.CatalogoBase = Nothing
        Me.AtxSubTipo.CatalogoPrincipal = False
        Me.AtxSubTipo.ColorDesactivado = System.Drawing.Color.Empty
        Me.AtxSubTipo.ControlDestinoDescripcion = Nothing
        Me.AtxSubTipo.DescripcionElementoInvalido = "Codigo no existe"
        Me.AtxSubTipo.EnPantalla = False
        Me.AtxSubTipo.FiltroExtendido = ""
        Me.AtxSubTipo.LanzarMensajeError = False
        Me.AtxSubTipo.Location = New System.Drawing.Point(116, 12)
        Me.AtxSubTipo.MaxLength = 2
        Me.AtxSubTipo.Multiple = False
        Me.AtxSubTipo.Name = "AtxSubTipo"
        Me.AtxSubTipo.PermiteAvanceElementoInvalido = False
        Me.AtxSubTipo.PermiteAyudaRapida = True
        Me.AtxSubTipo.PermiteSoloCapturarAlfanumericos = False
        Me.AtxSubTipo.Size = New System.Drawing.Size(104, 22)
        Me.AtxSubTipo.TabIndex = 1
        Me.AtxSubTipo.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.AtxSubTipo.TituloMensaje = "Sistema Integral Agroindustrias del Norte"
        Me.AtxSubTipo.ValorValido = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(29, 44)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(68, 14)
        Me.lblDescripcion.TabIndex = 75
        Me.lblDescripcion.Text = "Descripción"
        '
        'lblSubTipo
        '
        Me.lblSubTipo.AutoSize = True
        Me.lblSubTipo.Location = New System.Drawing.Point(45, 17)
        Me.lblSubTipo.Name = "lblSubTipo"
        Me.lblSubTipo.Size = New System.Drawing.Size(52, 14)
        Me.lblSubTipo.TabIndex = 69
        Me.lblSubTipo.Text = "SubTipo"
        '
        'AtxDescripcion
        '
        Me.AtxDescripcion.BlancoEsValorInvalido = True
        Me.AtxDescripcion.CadenaDescripcionNoValida = "Codigo no existe"
        Me.AtxDescripcion.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AtxDescripcion.CatalogoBase = Nothing
        Me.AtxDescripcion.CatalogoPrincipal = False
        Me.AtxDescripcion.ColorDesactivado = System.Drawing.Color.Empty
        Me.AtxDescripcion.ControlDestinoDescripcion = Nothing
        Me.AtxDescripcion.DescripcionElementoInvalido = "Codigo no existe"
        Me.AtxDescripcion.EnPantalla = False
        Me.AtxDescripcion.FiltroExtendido = ""
        Me.AtxDescripcion.LanzarMensajeError = False
        Me.AtxDescripcion.Location = New System.Drawing.Point(116, 44)
        Me.AtxDescripcion.MaxLength = 50
        Me.AtxDescripcion.Multiple = False
        Me.AtxDescripcion.Name = "AtxDescripcion"
        Me.AtxDescripcion.PermiteAvanceElementoInvalido = False
        Me.AtxDescripcion.PermiteAyudaRapida = True
        Me.AtxDescripcion.PermiteSoloCapturarAlfanumericos = True
        Me.AtxDescripcion.Size = New System.Drawing.Size(356, 22)
        Me.AtxDescripcion.TabIndex = 5
        Me.AtxDescripcion.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.AtxDescripcion.TituloMensaje = "Sistema Integral Agroindustrias del Norte"
        Me.AtxDescripcion.ValorValido = False
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(618, 18)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(43, 14)
        Me.lblFecha.TabIndex = 72
        Me.lblFecha.Text = "Fecha:"
        '
        'FrmM2701003
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gpBoxGrupos)
        Me.Name = "FrmM2701003"
        Me.ReferenciaRapidaVisible = True
        Me.Text = "Subtipo de Actos"
        Me.Controls.SetChildIndex(Me.gpBoxGrupos, 0)
        Me.Controls.SetChildIndex(Me.lblToolTip, 0)
        Me.gpBoxGrupos.ResumeLayout(False)
        Me.gpBoxGrupos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpBoxGrupos As GroupBox
    Friend WithEvents cmbGrupo As ComboBox
    Friend WithEvents lblGrupo As Label
    Friend WithEvents lblOperacion As Label
    Friend WithEvents lblAsterisco2 As Label
    Friend WithEvents dtpFechaInicial As DateTimePicker
    Friend WithEvents lblAsterisco1 As Label
    Friend WithEvents AtxSubTipo As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblSubTipo As Label
    Friend WithEvents AtxDescripcion As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents lblFecha As Label
    Friend WithEvents cmbTipoActo As ComboBox
    Friend WithEvents lblTipoActo As Label
End Class
