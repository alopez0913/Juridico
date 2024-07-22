<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmM2702011
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.ATXCliente = New ADSUM.AdsumTextBoxAdvanced()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.GroupBox1.SuspendLayout()
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
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNombreCliente)
        Me.GroupBox1.Controls.Add(Me.ATXCliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(843, 102)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        Me.GroupBox1.Visible = False
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNombreCliente.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblNombreCliente.Location = New System.Drawing.Point(125, 25)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(311, 22)
        Me.lblNombreCliente.TabIndex = 98
        Me.lblNombreCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ATXCliente
        '
        Me.ATXCliente.BlancoEsValorInvalido = True
        Me.ATXCliente.CadenaDescripcionNoValida = "Codigo no existe"
        Me.ATXCliente.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ATXCliente.CatalogoBase = Nothing
        Me.ATXCliente.CatalogoPrincipal = False
        Me.ATXCliente.ColorDesactivado = System.Drawing.Color.Empty
        Me.ATXCliente.ControlDestinoDescripcion = Me.lblNombreCliente
        Me.ATXCliente.DescripcionElementoInvalido = "Codigo no existe"
        Me.ATXCliente.EnPantalla = False
        Me.ATXCliente.FiltroExtendido = ""
        Me.ATXCliente.LanzarMensajeError = False
        Me.ATXCliente.Location = New System.Drawing.Point(69, 25)
        Me.ATXCliente.MaxLength = 12
        Me.ATXCliente.Multiple = False
        Me.ATXCliente.Name = "ATXCliente"
        Me.ATXCliente.PermiteAvanceElementoInvalido = False
        Me.ATXCliente.PermiteAyudaRapida = True
        Me.ATXCliente.PermiteSoloCapturarAlfanumericos = False
        Me.ATXCliente.Size = New System.Drawing.Size(50, 22)
        Me.ATXCliente.TabIndex = 96
        Me.ATXCliente.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.ATXCliente.TituloMensaje = "Sistema Integral Panama"
        Me.ATXCliente.ValorValido = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 14)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Cliente:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.grdExpedientes)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(970, 393)
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
        Me.grdExpedientes.Size = New System.Drawing.Size(964, 372)
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
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 414)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer1.Size = New System.Drawing.Size(994, 249)
        Me.SplitContainer1.SplitterDistance = 402
        Me.SplitContainer1.TabIndex = 85
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.grdDocumentos)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(402, 249)
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
        Me.grdDocumentos.Size = New System.Drawing.Size(396, 228)
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
        Me.GroupBox4.Size = New System.Drawing.Size(588, 249)
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
        Me.grdArchivos.Size = New System.Drawing.Size(582, 228)
        Me.grdArchivos.TabIndex = 83
        Me.grdArchivos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvArchivos})
        '
        'grvArchivos
        '
        Me.grvArchivos.GridControl = Me.grdArchivos
        Me.grvArchivos.Name = "grvArchivos"
        Me.grvArchivos.OptionsView.ColumnAutoWidth = False
        '
        'FrmM2702011
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 681)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmM2702011"
        Me.ReferenciaRapidaVisible = True
        Me.Text = "Banco de Datos (General)"
        Me.Controls.SetChildIndex(Me.lblToolTip, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents ATXCliente As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grdExpedientes As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvExpedientes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents grdDocumentos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDocumentos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents grdArchivos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvArchivos As DevExpress.XtraGrid.Views.Grid.GridView
End Class
