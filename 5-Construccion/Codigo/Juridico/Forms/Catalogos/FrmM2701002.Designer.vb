<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmM2701002
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
        Me.cmbGrupo = New System.Windows.Forms.ComboBox()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.lblDescCorta = New System.Windows.Forms.Label()
        Me.AtxDescCorta = New ADSUM.AdsumTextBoxAdvanced()
        Me.lblOperacion = New System.Windows.Forms.Label()
        Me.lblAsterisco2 = New System.Windows.Forms.Label()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.lblAsterisco1 = New System.Windows.Forms.Label()
        Me.AtxFolioActos = New ADSUM.AdsumTextBoxAdvanced()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblActos = New System.Windows.Forms.Label()
        Me.AtxDescripcion = New ADSUM.AdsumTextBoxAdvanced()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.gpBoxGrupos.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpBoxGrupos
        '
        Me.gpBoxGrupos.Controls.Add(Me.cmbGrupo)
        Me.gpBoxGrupos.Controls.Add(Me.lblGrupo)
        Me.gpBoxGrupos.Controls.Add(Me.lblDescCorta)
        Me.gpBoxGrupos.Controls.Add(Me.AtxDescCorta)
        Me.gpBoxGrupos.Controls.Add(Me.lblOperacion)
        Me.gpBoxGrupos.Controls.Add(Me.lblAsterisco2)
        Me.gpBoxGrupos.Controls.Add(Me.dtpFechaInicial)
        Me.gpBoxGrupos.Controls.Add(Me.lblAsterisco1)
        Me.gpBoxGrupos.Controls.Add(Me.AtxFolioActos)
        Me.gpBoxGrupos.Controls.Add(Me.lblDescripcion)
        Me.gpBoxGrupos.Controls.Add(Me.lblActos)
        Me.gpBoxGrupos.Controls.Add(Me.AtxDescripcion)
        Me.gpBoxGrupos.Controls.Add(Me.lblFecha)
        Me.gpBoxGrupos.Location = New System.Drawing.Point(12, 12)
        Me.gpBoxGrupos.Name = "gpBoxGrupos"
        Me.gpBoxGrupos.Size = New System.Drawing.Size(776, 347)
        Me.gpBoxGrupos.TabIndex = 0
        Me.gpBoxGrupos.TabStop = False
        '
        'cmbGrupo
        '
        Me.cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGrupo.FormattingEnabled = True
        Me.cmbGrupo.Location = New System.Drawing.Point(116, 81)
        Me.cmbGrupo.Name = "cmbGrupo"
        Me.cmbGrupo.Size = New System.Drawing.Size(356, 22)
        Me.cmbGrupo.TabIndex = 2
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.Location = New System.Drawing.Point(57, 81)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(44, 14)
        Me.lblGrupo.TabIndex = 82
        Me.lblGrupo.Text = "Grupo:"
        '
        'lblDescCorta
        '
        Me.lblDescCorta.AutoSize = True
        Me.lblDescCorta.Location = New System.Drawing.Point(29, 121)
        Me.lblDescCorta.Name = "lblDescCorta"
        Me.lblDescCorta.Size = New System.Drawing.Size(74, 14)
        Me.lblDescCorta.TabIndex = 81
        Me.lblDescCorta.Text = "Desc. Corta:"
        '
        'AtxDescCorta
        '
        Me.AtxDescCorta.BlancoEsValorInvalido = True
        Me.AtxDescCorta.CadenaDescripcionNoValida = "Codigo no existe"
        Me.AtxDescCorta.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AtxDescCorta.CatalogoBase = Nothing
        Me.AtxDescCorta.CatalogoPrincipal = False
        Me.AtxDescCorta.ColorDesactivado = System.Drawing.Color.Empty
        Me.AtxDescCorta.ControlDestinoDescripcion = Nothing
        Me.AtxDescCorta.DescripcionElementoInvalido = "Codigo no existe"
        Me.AtxDescCorta.EnPantalla = False
        Me.AtxDescCorta.FiltroExtendido = ""
        Me.AtxDescCorta.LanzarMensajeError = False
        Me.AtxDescCorta.Location = New System.Drawing.Point(116, 121)
        Me.AtxDescCorta.MaxLength = 10
        Me.AtxDescCorta.Multiple = False
        Me.AtxDescCorta.Name = "AtxDescCorta"
        Me.AtxDescCorta.PermiteAvanceElementoInvalido = False
        Me.AtxDescCorta.PermiteAyudaRapida = True
        Me.AtxDescCorta.PermiteSoloCapturarAlfanumericos = True
        Me.AtxDescCorta.Size = New System.Drawing.Size(104, 22)
        Me.AtxDescCorta.TabIndex = 3
        Me.AtxDescCorta.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.AtxDescCorta.TituloMensaje = "Sistema Integral Agroindustrias del Norte"
        Me.AtxDescCorta.ValorValido = False
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
        Me.dtpFechaInicial.Location = New System.Drawing.Point(657, 13)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(113, 22)
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
        'AtxFolioActos
        '
        Me.AtxFolioActos.BlancoEsValorInvalido = True
        Me.AtxFolioActos.CadenaDescripcionNoValida = "Codigo no existe"
        Me.AtxFolioActos.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AtxFolioActos.CatalogoBase = Nothing
        Me.AtxFolioActos.CatalogoPrincipal = False
        Me.AtxFolioActos.ColorDesactivado = System.Drawing.Color.Empty
        Me.AtxFolioActos.ControlDestinoDescripcion = Nothing
        Me.AtxFolioActos.DescripcionElementoInvalido = "Codigo no existe"
        Me.AtxFolioActos.EnPantalla = False
        Me.AtxFolioActos.FiltroExtendido = ""
        Me.AtxFolioActos.LanzarMensajeError = False
        Me.AtxFolioActos.Location = New System.Drawing.Point(116, 12)
        Me.AtxFolioActos.MaxLength = 2
        Me.AtxFolioActos.Multiple = False
        Me.AtxFolioActos.Name = "AtxFolioActos"
        Me.AtxFolioActos.PermiteAvanceElementoInvalido = False
        Me.AtxFolioActos.PermiteAyudaRapida = True
        Me.AtxFolioActos.PermiteSoloCapturarAlfanumericos = False
        Me.AtxFolioActos.Size = New System.Drawing.Size(104, 22)
        Me.AtxFolioActos.TabIndex = 0
        Me.AtxFolioActos.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.AtxFolioActos.TituloMensaje = "Sistema Integral Agroindustrias del Norte"
        Me.AtxFolioActos.ValorValido = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(29, 44)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(72, 14)
        Me.lblDescripcion.TabIndex = 75
        Me.lblDescripcion.Text = "Descripción:"
        '
        'lblActos
        '
        Me.lblActos.AutoSize = True
        Me.lblActos.Location = New System.Drawing.Point(62, 21)
        Me.lblActos.Name = "lblActos"
        Me.lblActos.Size = New System.Drawing.Size(37, 14)
        Me.lblActos.TabIndex = 69
        Me.lblActos.Text = "Acto:"
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
        Me.AtxDescripcion.TabIndex = 1
        Me.AtxDescripcion.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.AtxDescripcion.TituloMensaje = "Sistema Integral Agroindustrias del Norte"
        Me.AtxDescripcion.ValorValido = False
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(612, 18)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(39, 14)
        Me.lblFecha.TabIndex = 72
        Me.lblFecha.Text = "Fecha"
        '
        'FrmM2701002
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gpBoxGrupos)
        Me.Name = "FrmM2701002"
        Me.ReferenciaRapidaVisible = True
        Me.Text = "Tipos de Actos"
        Me.Controls.SetChildIndex(Me.lblToolTip, 0)
        Me.Controls.SetChildIndex(Me.gpBoxGrupos, 0)
        Me.gpBoxGrupos.ResumeLayout(False)
        Me.gpBoxGrupos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpBoxGrupos As GroupBox
    Friend WithEvents lblOperacion As Label
    Friend WithEvents lblAsterisco2 As Label
    Friend WithEvents dtpFechaInicial As DateTimePicker
    Friend WithEvents lblAsterisco1 As Label
    Friend WithEvents AtxFolioActos As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblActos As Label
    Friend WithEvents AtxDescripcion As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents lblFecha As Label
    Friend WithEvents cmbGrupo As ComboBox
    Friend WithEvents lblGrupo As Label
    Friend WithEvents lblDescCorta As Label
    Friend WithEvents AtxDescCorta As ADSUM.AdsumTextBoxAdvanced
End Class
