<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmM2702013
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grdExpedientes = New DevExpress.XtraGrid.GridControl()
        Me.grvExpedientes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.grdDocumentos = New DevExpress.XtraGrid.GridControl()
        Me.grvDocumentos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.grdArchivos = New DevExpress.XtraGrid.GridControl()
        Me.grvArchivos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gbFiltros = New System.Windows.Forms.GroupBox()
        Me.rbPorClienteEmpleado = New System.Windows.Forms.RadioButton()
        Me.gbFecha = New System.Windows.Forms.GroupBox()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.gbClienteEmpleado = New System.Windows.Forms.GroupBox()
        Me.lblNombreClienteEmpleado = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.atxClienteEmpleado = New ADSUM.AdsumTextBoxAdvanced()
        Me.rbPorFecha = New System.Windows.Forms.RadioButton()
        Me.rbPorActividad = New System.Windows.Forms.RadioButton()
        Me.gbActividad = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbActividad = New System.Windows.Forms.ComboBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdExpedientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvExpedientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.grdArchivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvArchivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFiltros.SuspendLayout()
        Me.gbFecha.SuspendLayout()
        Me.gbClienteEmpleado.SuspendLayout()
        Me.gbActividad.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.grdExpedientes)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 138)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1013, 335)
        Me.GroupBox2.TabIndex = 83
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Expedientes"
        '
        'grdExpedientes
        '
        Me.grdExpedientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdExpedientes.Location = New System.Drawing.Point(3, 18)
        Me.grdExpedientes.MainView = Me.grvExpedientes
        Me.grdExpedientes.Name = "grdExpedientes"
        Me.grdExpedientes.Size = New System.Drawing.Size(1007, 314)
        Me.grdExpedientes.TabIndex = 84
        Me.grdExpedientes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvExpedientes})
        '
        'grvExpedientes
        '
        Me.grvExpedientes.GridControl = Me.grdExpedientes
        Me.grvExpedientes.Name = "grvExpedientes"
        Me.grvExpedientes.OptionsView.ColumnAutoWidth = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 482)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer1.Size = New System.Drawing.Size(1035, 249)
        Me.SplitContainer1.SplitterDistance = 419
        Me.SplitContainer1.TabIndex = 85
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.grdDocumentos)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(419, 249)
        Me.GroupBox3.TabIndex = 85
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Documentos"
        '
        'grdDocumentos
        '
        Me.grdDocumentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDocumentos.Location = New System.Drawing.Point(3, 18)
        Me.grdDocumentos.MainView = Me.grvDocumentos
        Me.grdDocumentos.Name = "grdDocumentos"
        Me.grdDocumentos.Size = New System.Drawing.Size(413, 228)
        Me.grdDocumentos.TabIndex = 83
        Me.grdDocumentos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDocumentos})
        '
        'grvDocumentos
        '
        Me.grvDocumentos.GridControl = Me.grdDocumentos
        Me.grvDocumentos.Name = "grvDocumentos"
        Me.grvDocumentos.OptionsView.ColumnAutoWidth = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.grdArchivos)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(612, 249)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Archivos"
        '
        'grdArchivos
        '
        Me.grdArchivos.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.grdArchivos.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.grdArchivos.Location = New System.Drawing.Point(3, 18)
        Me.grdArchivos.MainView = Me.grvArchivos
        Me.grdArchivos.Name = "grdArchivos"
        Me.grdArchivos.Size = New System.Drawing.Size(606, 228)
        Me.grdArchivos.TabIndex = 83
        Me.grdArchivos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvArchivos})
        '
        'grvArchivos
        '
        Me.grvArchivos.GridControl = Me.grdArchivos
        Me.grvArchivos.Name = "grvArchivos"
        Me.grvArchivos.OptionsView.ColumnAutoWidth = False
        '
        'gbFiltros
        '
        Me.gbFiltros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFiltros.Controls.Add(Me.rbPorClienteEmpleado)
        Me.gbFiltros.Controls.Add(Me.gbFecha)
        Me.gbFiltros.Controls.Add(Me.gbClienteEmpleado)
        Me.gbFiltros.Controls.Add(Me.rbPorFecha)
        Me.gbFiltros.Controls.Add(Me.rbPorActividad)
        Me.gbFiltros.Controls.Add(Me.gbActividad)
        Me.gbFiltros.Location = New System.Drawing.Point(12, 12)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(1011, 120)
        Me.gbFiltros.TabIndex = 86
        Me.gbFiltros.TabStop = False
        Me.gbFiltros.Text = "Búsqueda"
        '
        'rbPorClienteEmpleado
        '
        Me.rbPorClienteEmpleado.AutoSize = True
        Me.rbPorClienteEmpleado.Location = New System.Drawing.Point(430, 20)
        Me.rbPorClienteEmpleado.Name = "rbPorClienteEmpleado"
        Me.rbPorClienteEmpleado.Size = New System.Drawing.Size(142, 18)
        Me.rbPorClienteEmpleado.TabIndex = 19
        Me.rbPorClienteEmpleado.Text = "Por Cliente/Empleado"
        Me.rbPorClienteEmpleado.UseVisualStyleBackColor = True
        '
        'gbFecha
        '
        Me.gbFecha.Controls.Add(Me.dtpFin)
        Me.gbFecha.Controls.Add(Me.Label2)
        Me.gbFecha.Controls.Add(Me.dtpInicio)
        Me.gbFecha.Location = New System.Drawing.Point(771, 36)
        Me.gbFecha.Name = "gbFecha"
        Me.gbFecha.Size = New System.Drawing.Size(233, 74)
        Me.gbFecha.TabIndex = 5
        Me.gbFecha.TabStop = False
        '
        'dtpFin
        '
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(119, 35)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(105, 22)
        Me.dtpFin.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha Registro:"
        '
        'dtpInicio
        '
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(8, 35)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(105, 22)
        Me.dtpInicio.TabIndex = 1
        '
        'gbClienteEmpleado
        '
        Me.gbClienteEmpleado.Controls.Add(Me.lblNombreClienteEmpleado)
        Me.gbClienteEmpleado.Controls.Add(Me.Label7)
        Me.gbClienteEmpleado.Controls.Add(Me.atxClienteEmpleado)
        Me.gbClienteEmpleado.Location = New System.Drawing.Point(430, 37)
        Me.gbClienteEmpleado.Name = "gbClienteEmpleado"
        Me.gbClienteEmpleado.Size = New System.Drawing.Size(335, 74)
        Me.gbClienteEmpleado.TabIndex = 6
        Me.gbClienteEmpleado.TabStop = False
        '
        'lblNombreClienteEmpleado
        '
        Me.lblNombreClienteEmpleado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNombreClienteEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblNombreClienteEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNombreClienteEmpleado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblNombreClienteEmpleado.Location = New System.Drawing.Point(62, 35)
        Me.lblNombreClienteEmpleado.Name = "lblNombreClienteEmpleado"
        Me.lblNombreClienteEmpleado.Size = New System.Drawing.Size(267, 22)
        Me.lblNombreClienteEmpleado.TabIndex = 12
        Me.lblNombreClienteEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 14)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Código:"
        '
        'atxClienteEmpleado
        '
        Me.atxClienteEmpleado.BlancoEsValorInvalido = False
        Me.atxClienteEmpleado.CadenaDescripcionNoValida = "Codigo no existe"
        Me.atxClienteEmpleado.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.atxClienteEmpleado.CatalogoBase = Nothing
        Me.atxClienteEmpleado.CatalogoPrincipal = False
        Me.atxClienteEmpleado.ColorDesactivado = System.Drawing.Color.Empty
        Me.atxClienteEmpleado.ControlDestinoDescripcion = Me.lblNombreClienteEmpleado
        Me.atxClienteEmpleado.DescripcionElementoInvalido = "Codigo no existe"
        Me.atxClienteEmpleado.EnPantalla = False
        Me.atxClienteEmpleado.FiltroExtendido = ""
        Me.atxClienteEmpleado.LanzarMensajeError = False
        Me.atxClienteEmpleado.Location = New System.Drawing.Point(6, 35)
        Me.atxClienteEmpleado.MaxLength = 5
        Me.atxClienteEmpleado.Multiple = False
        Me.atxClienteEmpleado.Name = "atxClienteEmpleado"
        Me.atxClienteEmpleado.PermiteAvanceElementoInvalido = False
        Me.atxClienteEmpleado.PermiteAyudaRapida = True
        Me.atxClienteEmpleado.PermiteSoloCapturarAlfanumericos = False
        Me.atxClienteEmpleado.Size = New System.Drawing.Size(50, 22)
        Me.atxClienteEmpleado.TabIndex = 11
        Me.atxClienteEmpleado.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.atxClienteEmpleado.TituloMensaje = ""
        Me.atxClienteEmpleado.ValorValido = False
        '
        'rbPorFecha
        '
        Me.rbPorFecha.AutoSize = True
        Me.rbPorFecha.Location = New System.Drawing.Point(771, 20)
        Me.rbPorFecha.Name = "rbPorFecha"
        Me.rbPorFecha.Size = New System.Drawing.Size(79, 18)
        Me.rbPorFecha.TabIndex = 4
        Me.rbPorFecha.Text = "Por Fecha"
        Me.rbPorFecha.UseVisualStyleBackColor = True
        '
        'rbPorActividad
        '
        Me.rbPorActividad.AutoSize = True
        Me.rbPorActividad.Location = New System.Drawing.Point(6, 21)
        Me.rbPorActividad.Name = "rbPorActividad"
        Me.rbPorActividad.Size = New System.Drawing.Size(96, 18)
        Me.rbPorActividad.TabIndex = 0
        Me.rbPorActividad.Text = "Por Actividad"
        Me.rbPorActividad.UseVisualStyleBackColor = True
        '
        'gbActividad
        '
        Me.gbActividad.Controls.Add(Me.Label1)
        Me.gbActividad.Controls.Add(Me.cmbActividad)
        Me.gbActividad.Location = New System.Drawing.Point(6, 37)
        Me.gbActividad.Name = "gbActividad"
        Me.gbActividad.Size = New System.Drawing.Size(418, 74)
        Me.gbActividad.TabIndex = 1
        Me.gbActividad.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 14)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Seleccionar:"
        '
        'cmbActividad
        '
        Me.cmbActividad.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmbActividad.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbActividad.FormattingEnabled = True
        Me.cmbActividad.Location = New System.Drawing.Point(6, 34)
        Me.cmbActividad.Name = "cmbActividad"
        Me.cmbActividad.Size = New System.Drawing.Size(350, 22)
        Me.cmbActividad.TabIndex = 9
        '
        'FrmM2702013
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 749)
        Me.Controls.Add(Me.gbFiltros)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FrmM2702013"
        Me.ReferenciaRapidaVisible = True
        Me.Text = "Consulta Banco de Datos"
        Me.Controls.SetChildIndex(Me.lblToolTip, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.Controls.SetChildIndex(Me.gbFiltros, 0)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grdExpedientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvExpedientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.grdDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.grdArchivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvArchivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFiltros.ResumeLayout(False)
        Me.gbFiltros.PerformLayout()
        Me.gbFecha.ResumeLayout(False)
        Me.gbFecha.PerformLayout()
        Me.gbClienteEmpleado.ResumeLayout(False)
        Me.gbClienteEmpleado.PerformLayout()
        Me.gbActividad.ResumeLayout(False)
        Me.gbActividad.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents grdExpedientes As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvExpedientes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents grdDocumentos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDocumentos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents grdArchivos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvArchivos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gbFiltros As GroupBox
    Friend WithEvents rbPorClienteEmpleado As RadioButton
    Friend WithEvents gbFecha As GroupBox
    Friend WithEvents dtpFin As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpInicio As DateTimePicker
    Friend WithEvents gbClienteEmpleado As GroupBox
    Friend WithEvents lblNombreClienteEmpleado As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents atxClienteEmpleado As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents rbPorFecha As RadioButton
    Friend WithEvents rbPorActividad As RadioButton
    Friend WithEvents gbActividad As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbActividad As ComboBox
End Class
