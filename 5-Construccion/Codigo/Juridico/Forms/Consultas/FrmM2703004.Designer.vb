<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmM2703004
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDescDepto = New System.Windows.Forms.Label()
        Me.lblDescContratante = New System.Windows.Forms.Label()
        Me.atxCodDepto = New ADSUM.AdsumTextBoxAdvanced()
        Me.atxCodContratante = New ADSUM.AdsumTextBoxAdvanced()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grdContratos = New DevExpress.XtraGrid.GridControl()
        Me.grvContratos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDescDepto)
        Me.GroupBox1.Controls.Add(Me.lblDescContratante)
        Me.GroupBox1.Controls.Add(Me.atxCodDepto)
        Me.GroupBox1.Controls.Add(Me.atxCodContratante)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1070, 129)
        Me.GroupBox1.TabIndex = 83
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'lblDescDepto
        '
        Me.lblDescDepto.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblDescDepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescDepto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblDescDepto.Location = New System.Drawing.Point(194, 56)
        Me.lblDescDepto.Name = "lblDescDepto"
        Me.lblDescDepto.Size = New System.Drawing.Size(311, 22)
        Me.lblDescDepto.TabIndex = 100
        Me.lblDescDepto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescContratante
        '
        Me.lblDescContratante.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblDescContratante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescContratante.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblDescContratante.Location = New System.Drawing.Point(194, 18)
        Me.lblDescContratante.Name = "lblDescContratante"
        Me.lblDescContratante.Size = New System.Drawing.Size(311, 22)
        Me.lblDescContratante.TabIndex = 95
        Me.lblDescContratante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'atxCodDepto
        '
        Me.atxCodDepto.BlancoEsValorInvalido = True
        Me.atxCodDepto.CadenaDescripcionNoValida = "Codigo no existe"
        Me.atxCodDepto.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.atxCodDepto.CatalogoBase = Nothing
        Me.atxCodDepto.CatalogoPrincipal = False
        Me.atxCodDepto.ColorDesactivado = System.Drawing.Color.Empty
        Me.atxCodDepto.ControlDestinoDescripcion = Me.lblDescDepto
        Me.atxCodDepto.DescripcionElementoInvalido = "Codigo no existe"
        Me.atxCodDepto.EnPantalla = False
        Me.atxCodDepto.FiltroExtendido = ""
        Me.atxCodDepto.LanzarMensajeError = False
        Me.atxCodDepto.Location = New System.Drawing.Point(98, 56)
        Me.atxCodDepto.MaxLength = 12
        Me.atxCodDepto.Multiple = False
        Me.atxCodDepto.Name = "atxCodDepto"
        Me.atxCodDepto.PermiteAvanceElementoInvalido = False
        Me.atxCodDepto.PermiteAyudaRapida = True
        Me.atxCodDepto.PermiteSoloCapturarAlfanumericos = False
        Me.atxCodDepto.Size = New System.Drawing.Size(90, 22)
        Me.atxCodDepto.TabIndex = 13
        Me.atxCodDepto.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.atxCodDepto.TituloMensaje = "Sistema Integral Panama"
        Me.atxCodDepto.ValorValido = False
        '
        'atxCodContratante
        '
        Me.atxCodContratante.BlancoEsValorInvalido = True
        Me.atxCodContratante.CadenaDescripcionNoValida = "Codigo no existe"
        Me.atxCodContratante.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.atxCodContratante.CatalogoBase = Nothing
        Me.atxCodContratante.CatalogoPrincipal = False
        Me.atxCodContratante.ColorDesactivado = System.Drawing.Color.Empty
        Me.atxCodContratante.ControlDestinoDescripcion = Nothing
        Me.atxCodContratante.DescripcionElementoInvalido = "Codigo no existe"
        Me.atxCodContratante.EnPantalla = False
        Me.atxCodContratante.FiltroExtendido = ""
        Me.atxCodContratante.LanzarMensajeError = False
        Me.atxCodContratante.Location = New System.Drawing.Point(98, 18)
        Me.atxCodContratante.MaxLength = 12
        Me.atxCodContratante.Multiple = False
        Me.atxCodContratante.Name = "atxCodContratante"
        Me.atxCodContratante.PermiteAvanceElementoInvalido = False
        Me.atxCodContratante.PermiteAyudaRapida = True
        Me.atxCodContratante.PermiteSoloCapturarAlfanumericos = False
        Me.atxCodContratante.Size = New System.Drawing.Size(90, 22)
        Me.atxCodContratante.TabIndex = 12
        Me.atxCodContratante.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.atxCodContratante.TituloMensaje = "Sistema Integral Panama"
        Me.atxCodContratante.ValorValido = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 14)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Departamento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 14)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Contratante:"
        '
        'grdContratos
        '
        Me.grdContratos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdContratos.Location = New System.Drawing.Point(13, 147)
        Me.grdContratos.MainView = Me.grvContratos
        Me.grdContratos.Name = "grdContratos"
        Me.grdContratos.Size = New System.Drawing.Size(1069, 357)
        Me.grdContratos.TabIndex = 84
        Me.grdContratos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvContratos})
        '
        'grvContratos
        '
        Me.grvContratos.GridControl = Me.grdContratos
        Me.grvContratos.Name = "grvContratos"
        Me.grvContratos.OptionsView.ColumnAutoWidth = False
        '
        'FrmM2703004
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1258, 525)
        Me.Controls.Add(Me.grdContratos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmM2703004"
        Me.ReferenciaRapidaVisible = True
        Me.Text = "Contratos por Tipo"
        Me.Controls.SetChildIndex(Me.lblToolTip, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.grdContratos, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvContratos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblDescDepto As Label
    Friend WithEvents lblDescContratante As Label
    Friend WithEvents atxCodDepto As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents atxCodContratante As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents grdContratos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvContratos As DevExpress.XtraGrid.Views.Grid.GridView
End Class
