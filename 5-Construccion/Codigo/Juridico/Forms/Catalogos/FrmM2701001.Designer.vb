<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmM2701001
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
        Me.gpBoxGrupos = New System.Windows.Forms.GroupBox()
        Me.lblOperacion = New System.Windows.Forms.Label()
        Me.lblAsterisco2 = New System.Windows.Forms.Label()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.lblAsterisco1 = New System.Windows.Forms.Label()
        Me.AtxFolioGrupos = New ADSUM.AdsumTextBoxAdvanced()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblGrupos = New System.Windows.Forms.Label()
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
        Me.gpBoxGrupos.Controls.Add(Me.AtxFolioGrupos)
        Me.gpBoxGrupos.Controls.Add(Me.lblDescripcion)
        Me.gpBoxGrupos.Controls.Add(Me.lblGrupos)
        Me.gpBoxGrupos.Controls.Add(Me.AtxDescripcion)
        Me.gpBoxGrupos.Controls.Add(Me.lblFecha)
        Me.gpBoxGrupos.Location = New System.Drawing.Point(12, 17)
        Me.gpBoxGrupos.Name = "gpBoxGrupos"
        Me.gpBoxGrupos.Size = New System.Drawing.Size(823, 391)
        Me.gpBoxGrupos.TabIndex = 0
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
        Me.lblOperacion.TabIndex = 2
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
        Me.dtpFechaInicial.Location = New System.Drawing.Point(528, 13)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(109, 22)
        Me.dtpFechaInicial.TabIndex = 3
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
        'AtxFolioGrupos
        '
        Me.AtxFolioGrupos.BlancoEsValorInvalido = True
        Me.AtxFolioGrupos.CadenaDescripcionNoValida = "Codigo no existe"
        Me.AtxFolioGrupos.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AtxFolioGrupos.CatalogoBase = Nothing
        Me.AtxFolioGrupos.CatalogoPrincipal = False
        Me.AtxFolioGrupos.ColorDesactivado = System.Drawing.Color.Empty
        Me.AtxFolioGrupos.ControlDestinoDescripcion = Nothing
        Me.AtxFolioGrupos.DescripcionElementoInvalido = "Codigo no existe"
        Me.AtxFolioGrupos.EnPantalla = False
        Me.AtxFolioGrupos.FiltroExtendido = ""
        Me.AtxFolioGrupos.LanzarMensajeError = False
        Me.AtxFolioGrupos.Location = New System.Drawing.Point(116, 12)
        Me.AtxFolioGrupos.MaxLength = 2
        Me.AtxFolioGrupos.Multiple = False
        Me.AtxFolioGrupos.Name = "AtxFolioGrupos"
        Me.AtxFolioGrupos.PermiteAvanceElementoInvalido = False
        Me.AtxFolioGrupos.PermiteAyudaRapida = True
        Me.AtxFolioGrupos.PermiteSoloCapturarAlfanumericos = False
        Me.AtxFolioGrupos.Size = New System.Drawing.Size(104, 22)
        Me.AtxFolioGrupos.TabIndex = 0
        Me.AtxFolioGrupos.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.AtxFolioGrupos.TituloMensaje = "Sistema Integral Agroindustrias del Norte"
        Me.AtxFolioGrupos.ValorValido = False
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
        'lblGrupos
        '
        Me.lblGrupos.AutoSize = True
        Me.lblGrupos.Location = New System.Drawing.Point(48, 21)
        Me.lblGrupos.Name = "lblGrupos"
        Me.lblGrupos.Size = New System.Drawing.Size(44, 14)
        Me.lblGrupos.TabIndex = 69
        Me.lblGrupos.Text = "Grupo:"
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
        Me.lblFecha.Location = New System.Drawing.Point(483, 18)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(43, 14)
        Me.lblFecha.TabIndex = 72
        Me.lblFecha.Text = "Fecha:"
        '
        'FrmM2701001
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 450)
        Me.Controls.Add(Me.gpBoxGrupos)
        Me.Name = "FrmM2701001"
        Me.ReferenciaRapidaVisible = True
        Me.Text = "Grupos de contratos"
        Me.Controls.SetChildIndex(Me.lblToolTip, 0)
        Me.Controls.SetChildIndex(Me.gpBoxGrupos, 0)
        Me.gpBoxGrupos.ResumeLayout(False)
        Me.gpBoxGrupos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtpFechaInicial As DateTimePicker
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblGrupos As Label
    Friend WithEvents AtxFolioGrupos As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents lblAsterisco1 As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents AtxDescripcion As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents gpBoxGrupos As GroupBox
    Friend WithEvents lblAsterisco2 As Label
    Friend WithEvents lblOperacion As Label
End Class
