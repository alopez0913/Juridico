<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmM2701004
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
        Me.lblOperacion = New System.Windows.Forms.Label()
        Me.lblAsterisco2 = New System.Windows.Forms.Label()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.lblAsterisco1 = New System.Windows.Forms.Label()
        Me.AtxIdRequerimiento = New ADSUM.AdsumTextBoxAdvanced()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblRequerimiento = New System.Windows.Forms.Label()
        Me.AtxDescripcion = New ADSUM.AdsumTextBoxAdvanced()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.gpBoxGrupos.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpBoxGrupos
        '
        Me.gpBoxGrupos.Controls.Add(Me.lblOperacion)
        Me.gpBoxGrupos.Controls.Add(Me.lblAsterisco2)
        Me.gpBoxGrupos.Controls.Add(Me.dtpFechaInicial)
        Me.gpBoxGrupos.Controls.Add(Me.lblAsterisco1)
        Me.gpBoxGrupos.Controls.Add(Me.AtxIdRequerimiento)
        Me.gpBoxGrupos.Controls.Add(Me.lblDescripcion)
        Me.gpBoxGrupos.Controls.Add(Me.lblRequerimiento)
        Me.gpBoxGrupos.Controls.Add(Me.AtxDescripcion)
        Me.gpBoxGrupos.Controls.Add(Me.lblFecha)
        Me.gpBoxGrupos.Location = New System.Drawing.Point(12, 26)
        Me.gpBoxGrupos.Name = "gpBoxGrupos"
        Me.gpBoxGrupos.Size = New System.Drawing.Size(776, 390)
        Me.gpBoxGrupos.TabIndex = 81
        Me.gpBoxGrupos.TabStop = False
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
        Me.dtpFechaInicial.Location = New System.Drawing.Point(665, 13)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(105, 22)
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
        'AtxIdRequerimiento
        '
        Me.AtxIdRequerimiento.BlancoEsValorInvalido = True
        Me.AtxIdRequerimiento.CadenaDescripcionNoValida = "Codigo no existe"
        Me.AtxIdRequerimiento.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AtxIdRequerimiento.CatalogoBase = Nothing
        Me.AtxIdRequerimiento.CatalogoPrincipal = False
        Me.AtxIdRequerimiento.ColorDesactivado = System.Drawing.Color.Empty
        Me.AtxIdRequerimiento.ControlDestinoDescripcion = Nothing
        Me.AtxIdRequerimiento.DescripcionElementoInvalido = "Codigo no existe"
        Me.AtxIdRequerimiento.EnPantalla = False
        Me.AtxIdRequerimiento.FiltroExtendido = ""
        Me.AtxIdRequerimiento.LanzarMensajeError = False
        Me.AtxIdRequerimiento.Location = New System.Drawing.Point(116, 12)
        Me.AtxIdRequerimiento.MaxLength = 2
        Me.AtxIdRequerimiento.Multiple = False
        Me.AtxIdRequerimiento.Name = "AtxIdRequerimiento"
        Me.AtxIdRequerimiento.PermiteAvanceElementoInvalido = False
        Me.AtxIdRequerimiento.PermiteAyudaRapida = True
        Me.AtxIdRequerimiento.PermiteSoloCapturarAlfanumericos = False
        Me.AtxIdRequerimiento.Size = New System.Drawing.Size(104, 22)
        Me.AtxIdRequerimiento.TabIndex = 1
        Me.AtxIdRequerimiento.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.AtxIdRequerimiento.TituloMensaje = "Sistema Integral Agroindustrias del Norte"
        Me.AtxIdRequerimiento.ValorValido = False
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
        'lblRequerimiento
        '
        Me.lblRequerimiento.AutoSize = True
        Me.lblRequerimiento.Location = New System.Drawing.Point(15, 17)
        Me.lblRequerimiento.Name = "lblRequerimiento"
        Me.lblRequerimiento.Size = New System.Drawing.Size(86, 14)
        Me.lblRequerimiento.TabIndex = 69
        Me.lblRequerimiento.Text = "Requerimiento"
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
        Me.lblFecha.Location = New System.Drawing.Point(616, 18)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(43, 14)
        Me.lblFecha.TabIndex = 72
        Me.lblFecha.Text = "Fecha:"
        '
        'FrmM2701004
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gpBoxGrupos)
        Me.Name = "FrmM2701004"
        Me.ReferenciaRapidaVisible = True
        Me.Text = "Requerimientos Documentación"
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
    Friend WithEvents AtxIdRequerimiento As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblRequerimiento As Label
    Friend WithEvents AtxDescripcion As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents lblFecha As Label
End Class
