<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmM2701005
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
        Me.AtxIdContrato = New ADSUM.AdsumTextBoxAdvanced()
        Me.AtxDescripcion = New ADSUM.AdsumTextBoxAdvanced()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblRequerimiento = New System.Windows.Forms.Label()
        Me.grdDocumentosRequeridos = New DevExpress.XtraGrid.GridControl()
        Me.grvDocumentosRequeridos = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.grdDocumentosRequeridos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDocumentosRequeridos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblToolTip
        '
        Me.lblToolTip.Size = New System.Drawing.Size(19, 25)
        '
        'AtxIdContrato
        '
        Me.AtxIdContrato.BlancoEsValorInvalido = True
        Me.AtxIdContrato.CadenaDescripcionNoValida = "Codigo no existe"
        Me.AtxIdContrato.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AtxIdContrato.CatalogoBase = Nothing
        Me.AtxIdContrato.CatalogoPrincipal = False
        Me.AtxIdContrato.ColorDesactivado = System.Drawing.Color.Empty
        Me.AtxIdContrato.ControlDestinoDescripcion = Nothing
        Me.AtxIdContrato.DescripcionElementoInvalido = "Codigo no existe"
        Me.AtxIdContrato.EnPantalla = False
        Me.AtxIdContrato.FiltroExtendido = ""
        Me.AtxIdContrato.LanzarMensajeError = False
        Me.AtxIdContrato.Location = New System.Drawing.Point(122, 22)
        Me.AtxIdContrato.MaxLength = 2
        Me.AtxIdContrato.Multiple = False
        Me.AtxIdContrato.Name = "AtxIdContrato"
        Me.AtxIdContrato.PermiteAvanceElementoInvalido = False
        Me.AtxIdContrato.PermiteAyudaRapida = True
        Me.AtxIdContrato.PermiteSoloCapturarAlfanumericos = False
        Me.AtxIdContrato.Size = New System.Drawing.Size(68, 22)
        Me.AtxIdContrato.TabIndex = 76
        Me.AtxIdContrato.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.AtxIdContrato.TituloMensaje = "Sistema Integral Agroindustrias del Norte"
        Me.AtxIdContrato.ValorValido = False
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
        Me.AtxDescripcion.Enabled = False
        Me.AtxDescripcion.EnPantalla = False
        Me.AtxDescripcion.FiltroExtendido = ""
        Me.AtxDescripcion.LanzarMensajeError = False
        Me.AtxDescripcion.Location = New System.Drawing.Point(122, 56)
        Me.AtxDescripcion.MaxLength = 50
        Me.AtxDescripcion.Multiple = False
        Me.AtxDescripcion.Name = "AtxDescripcion"
        Me.AtxDescripcion.PermiteAvanceElementoInvalido = False
        Me.AtxDescripcion.PermiteAyudaRapida = True
        Me.AtxDescripcion.PermiteSoloCapturarAlfanumericos = True
        Me.AtxDescripcion.Size = New System.Drawing.Size(415, 22)
        Me.AtxDescripcion.TabIndex = 77
        Me.AtxDescripcion.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.AtxDescripcion.TituloMensaje = "Sistema Integral Agroindustrias del Norte"
        Me.AtxDescripcion.ValorValido = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(21, 56)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(72, 14)
        Me.lblDescripcion.TabIndex = 79
        Me.lblDescripcion.Text = "Descripción:"
        '
        'lblRequerimiento
        '
        Me.lblRequerimiento.AutoSize = True
        Me.lblRequerimiento.Location = New System.Drawing.Point(5, 27)
        Me.lblRequerimiento.Name = "lblRequerimiento"
        Me.lblRequerimiento.Size = New System.Drawing.Size(104, 14)
        Me.lblRequerimiento.TabIndex = 78
        Me.lblRequerimiento.Text = "Tipo de contrato:"
        '
        'grdDocumentosRequeridos
        '
        Me.grdDocumentosRequeridos.Location = New System.Drawing.Point(24, 94)
        Me.grdDocumentosRequeridos.MainView = Me.grvDocumentosRequeridos
        Me.grdDocumentosRequeridos.Name = "grdDocumentosRequeridos"
        Me.grdDocumentosRequeridos.Size = New System.Drawing.Size(513, 439)
        Me.grdDocumentosRequeridos.TabIndex = 81
        Me.grdDocumentosRequeridos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDocumentosRequeridos})
        '
        'grvDocumentosRequeridos
        '
        Me.grvDocumentosRequeridos.GridControl = Me.grdDocumentosRequeridos
        Me.grvDocumentosRequeridos.Name = "grvDocumentosRequeridos"
        '
        'FrmM2701005
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 554)
        Me.Controls.Add(Me.grdDocumentosRequeridos)
        Me.Controls.Add(Me.AtxIdContrato)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblRequerimiento)
        Me.Controls.Add(Me.AtxDescripcion)
        Me.Name = "FrmM2701005"
        Me.ReferenciaRapidaVisible = True
        Me.Text = "Documentación requerida por contrato"
        Me.Controls.SetChildIndex(Me.AtxDescripcion, 0)
        Me.Controls.SetChildIndex(Me.lblRequerimiento, 0)
        Me.Controls.SetChildIndex(Me.lblDescripcion, 0)
        Me.Controls.SetChildIndex(Me.AtxIdContrato, 0)
        Me.Controls.SetChildIndex(Me.grdDocumentosRequeridos, 0)
        Me.Controls.SetChildIndex(Me.lblToolTip, 0)
        CType(Me.grdDocumentosRequeridos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDocumentosRequeridos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AtxIdContrato As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents AtxDescripcion As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblRequerimiento As Label
    Friend WithEvents grdDocumentosRequeridos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDocumentosRequeridos As DevExpress.XtraGrid.Views.Grid.GridView
End Class
