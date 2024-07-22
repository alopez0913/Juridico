<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmM2703003
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
        Me.grdContratos = New DevExpress.XtraGrid.GridControl()
        Me.grvContratos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.atxSolicitante = New ADSUM.AdsumTextBoxAdvanced()
        Me.lblDescSolicitante = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblDescContratante = New System.Windows.Forms.Label()
        Me.cmbEstatus = New System.Windows.Forms.ComboBox()
        Me.atxCodContratante = New ADSUM.AdsumTextBoxAdvanced()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSolicitado = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSuspendido = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtClasificado = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtRevisadoSinDoc = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtRevisadoConDoc = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtLiberado = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtFinalizado = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCancelado = New System.Windows.Forms.TextBox()
        CType(Me.grdContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblToolTip
        '
        Me.lblToolTip.Size = New System.Drawing.Size(19, 25)
        '
        'grdContratos
        '
        Me.grdContratos.Location = New System.Drawing.Point(14, 179)
        Me.grdContratos.MainView = Me.grvContratos
        Me.grdContratos.Name = "grdContratos"
        Me.grdContratos.Size = New System.Drawing.Size(1063, 459)
        Me.grdContratos.TabIndex = 80
        Me.grdContratos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvContratos})
        '
        'grvContratos
        '
        Me.grvContratos.GridControl = Me.grdContratos
        Me.grvContratos.Name = "grvContratos"
        Me.grvContratos.OptionsView.ColumnAutoWidth = False
        '
        'atxSolicitante
        '
        Me.atxSolicitante.BlancoEsValorInvalido = True
        Me.atxSolicitante.CadenaDescripcionNoValida = "Codigo no existe"
        Me.atxSolicitante.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.atxSolicitante.CatalogoBase = Nothing
        Me.atxSolicitante.CatalogoPrincipal = False
        Me.atxSolicitante.ColorDesactivado = System.Drawing.Color.Empty
        Me.atxSolicitante.ControlDestinoDescripcion = Me.lblDescSolicitante
        Me.atxSolicitante.DescripcionElementoInvalido = "Codigo no existe"
        Me.atxSolicitante.EnPantalla = False
        Me.atxSolicitante.FiltroExtendido = ""
        Me.atxSolicitante.LanzarMensajeError = False
        Me.atxSolicitante.Location = New System.Drawing.Point(98, 18)
        Me.atxSolicitante.MaxLength = 12
        Me.atxSolicitante.Multiple = False
        Me.atxSolicitante.Name = "atxSolicitante"
        Me.atxSolicitante.PermiteAvanceElementoInvalido = False
        Me.atxSolicitante.PermiteAyudaRapida = True
        Me.atxSolicitante.PermiteSoloCapturarAlfanumericos = False
        Me.atxSolicitante.Size = New System.Drawing.Size(86, 22)
        Me.atxSolicitante.TabIndex = 11
        Me.atxSolicitante.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.atxSolicitante.TituloMensaje = "Sistema Integral Panama"
        Me.atxSolicitante.ValorValido = False
        '
        'lblDescSolicitante
        '
        Me.lblDescSolicitante.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblDescSolicitante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescSolicitante.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblDescSolicitante.Location = New System.Drawing.Point(190, 18)
        Me.lblDescSolicitante.Name = "lblDescSolicitante"
        Me.lblDescSolicitante.Size = New System.Drawing.Size(275, 22)
        Me.lblDescSolicitante.TabIndex = 102
        Me.lblDescSolicitante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDescSolicitante)
        Me.GroupBox1.Controls.Add(Me.dtpFecFin)
        Me.GroupBox1.Controls.Add(Me.dtpFecIni)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lblDescContratante)
        Me.GroupBox1.Controls.Add(Me.cmbEstatus)
        Me.GroupBox1.Controls.Add(Me.atxCodContratante)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.atxSolicitante)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1070, 129)
        Me.GroupBox1.TabIndex = 82
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'dtpFecFin
        '
        Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecFin.Location = New System.Drawing.Point(553, 48)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(107, 22)
        Me.dtpFecFin.TabIndex = 19
        '
        'dtpFecIni
        '
        Me.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIni.Location = New System.Drawing.Point(553, 18)
        Me.dtpFecIni.Name = "dtpFecIni"
        Me.dtpFecIni.Size = New System.Drawing.Size(107, 22)
        Me.dtpFecIni.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(477, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 14)
        Me.Label8.TabIndex = 101
        Me.Label8.Text = "Fecha Final:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(471, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 14)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "Fecha Inicial:"
        '
        'lblDescContratante
        '
        Me.lblDescContratante.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblDescContratante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescContratante.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblDescContratante.Location = New System.Drawing.Point(190, 48)
        Me.lblDescContratante.Name = "lblDescContratante"
        Me.lblDescContratante.Size = New System.Drawing.Size(275, 22)
        Me.lblDescContratante.TabIndex = 95
        Me.lblDescContratante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbEstatus
        '
        Me.cmbEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstatus.FormattingEnabled = True
        Me.cmbEstatus.Location = New System.Drawing.Point(190, 78)
        Me.cmbEstatus.Name = "cmbEstatus"
        Me.cmbEstatus.Size = New System.Drawing.Size(148, 22)
        Me.cmbEstatus.TabIndex = 14
        '
        'atxCodContratante
        '
        Me.atxCodContratante.BlancoEsValorInvalido = True
        Me.atxCodContratante.CadenaDescripcionNoValida = "Codigo no existe"
        Me.atxCodContratante.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.atxCodContratante.CatalogoBase = Nothing
        Me.atxCodContratante.CatalogoPrincipal = False
        Me.atxCodContratante.ColorDesactivado = System.Drawing.Color.Empty
        Me.atxCodContratante.ControlDestinoDescripcion = Me.lblDescContratante
        Me.atxCodContratante.DescripcionElementoInvalido = "Codigo no existe"
        Me.atxCodContratante.EnPantalla = False
        Me.atxCodContratante.FiltroExtendido = ""
        Me.atxCodContratante.LanzarMensajeError = False
        Me.atxCodContratante.Location = New System.Drawing.Point(98, 48)
        Me.atxCodContratante.MaxLength = 12
        Me.atxCodContratante.Multiple = False
        Me.atxCodContratante.Name = "atxCodContratante"
        Me.atxCodContratante.PermiteAvanceElementoInvalido = False
        Me.atxCodContratante.PermiteAyudaRapida = True
        Me.atxCodContratante.PermiteSoloCapturarAlfanumericos = False
        Me.atxCodContratante.Size = New System.Drawing.Size(86, 22)
        Me.atxCodContratante.TabIndex = 12
        Me.atxCodContratante.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.atxCodContratante.TituloMensaje = "Sistema Integral Panama"
        Me.atxCodContratante.ValorValido = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(133, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 14)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Estatus:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 14)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Contratante:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 14)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Solicitante:"
        '
        'txtSolicitado
        '
        Me.txtSolicitado.BackColor = System.Drawing.Color.White
        Me.txtSolicitado.Location = New System.Drawing.Point(53, 147)
        Me.txtSolicitado.Name = "txtSolicitado"
        Me.txtSolicitado.Size = New System.Drawing.Size(31, 22)
        Me.txtSolicitado.TabIndex = 83
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(86, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 14)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "Solicitado"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(195, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 14)
        Me.Label10.TabIndex = 86
        Me.Label10.Text = "Suspendido"
        '
        'txtSuspendido
        '
        Me.txtSuspendido.Location = New System.Drawing.Point(162, 147)
        Me.txtSuspendido.Name = "txtSuspendido"
        Me.txtSuspendido.Size = New System.Drawing.Size(31, 22)
        Me.txtSuspendido.TabIndex = 85
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(316, 150)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 14)
        Me.Label12.TabIndex = 88
        Me.Label12.Text = "Clasificado"
        '
        'txtClasificado
        '
        Me.txtClasificado.Location = New System.Drawing.Point(283, 147)
        Me.txtClasificado.Name = "txtClasificado"
        Me.txtClasificado.Size = New System.Drawing.Size(31, 22)
        Me.txtClasificado.TabIndex = 87
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(428, 150)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(123, 14)
        Me.Label13.TabIndex = 90
        Me.Label13.Text = "Revisión Documentos"
        '
        'txtRevisadoSinDoc
        '
        Me.txtRevisadoSinDoc.Location = New System.Drawing.Point(395, 147)
        Me.txtRevisadoSinDoc.Name = "txtRevisadoSinDoc"
        Me.txtRevisadoSinDoc.Size = New System.Drawing.Size(31, 22)
        Me.txtRevisadoSinDoc.TabIndex = 89
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(602, 150)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(107, 14)
        Me.Label14.TabIndex = 92
        Me.Label14.Text = "Revisión Contratos"
        '
        'txtRevisadoConDoc
        '
        Me.txtRevisadoConDoc.Location = New System.Drawing.Point(569, 147)
        Me.txtRevisadoConDoc.Name = "txtRevisadoConDoc"
        Me.txtRevisadoConDoc.Size = New System.Drawing.Size(31, 22)
        Me.txtRevisadoConDoc.TabIndex = 91
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(760, 150)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 14)
        Me.Label15.TabIndex = 94
        Me.Label15.Text = "Liberado"
        '
        'txtLiberado
        '
        Me.txtLiberado.Location = New System.Drawing.Point(727, 147)
        Me.txtLiberado.Name = "txtLiberado"
        Me.txtLiberado.Size = New System.Drawing.Size(31, 22)
        Me.txtLiberado.TabIndex = 93
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(864, 150)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 14)
        Me.Label16.TabIndex = 96
        Me.Label16.Text = "Finalizado"
        '
        'txtFinalizado
        '
        Me.txtFinalizado.Location = New System.Drawing.Point(831, 147)
        Me.txtFinalizado.Name = "txtFinalizado"
        Me.txtFinalizado.Size = New System.Drawing.Size(31, 22)
        Me.txtFinalizado.TabIndex = 95
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(972, 150)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 14)
        Me.Label17.TabIndex = 98
        Me.Label17.Text = "Cancelado"
        '
        'txtCancelado
        '
        Me.txtCancelado.Location = New System.Drawing.Point(939, 147)
        Me.txtCancelado.Name = "txtCancelado"
        Me.txtCancelado.Size = New System.Drawing.Size(31, 22)
        Me.txtCancelado.TabIndex = 97
        '
        'FrmM2703003
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1089, 656)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtCancelado)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtFinalizado)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtLiberado)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtRevisadoConDoc)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtRevisadoSinDoc)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtClasificado)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSuspendido)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSolicitado)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grdContratos)
        Me.Name = "FrmM2703003"
        Me.ReferenciaRapidaVisible = True
        Me.Text = "Estatus de Contratos"
        Me.Controls.SetChildIndex(Me.grdContratos, 0)
        Me.Controls.SetChildIndex(Me.lblToolTip, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.txtSolicitado, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.txtSuspendido, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.txtClasificado, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.txtRevisadoSinDoc, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.txtRevisadoConDoc, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.txtLiberado, 0)
        Me.Controls.SetChildIndex(Me.Label15, 0)
        Me.Controls.SetChildIndex(Me.txtFinalizado, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.txtCancelado, 0)
        Me.Controls.SetChildIndex(Me.Label17, 0)
        CType(Me.grdContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvContratos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdContratos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvContratos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents atxSolicitante As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbEstatus As ComboBox
    Friend WithEvents atxCodContratante As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblDescContratante As Label
    Friend WithEvents dtpFecFin As DateTimePicker
    Friend WithEvents dtpFecIni As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSolicitado As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSuspendido As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtClasificado As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtRevisadoSinDoc As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtRevisadoConDoc As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtLiberado As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtFinalizado As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtCancelado As TextBox
    Friend WithEvents lblDescSolicitante As Label
End Class
