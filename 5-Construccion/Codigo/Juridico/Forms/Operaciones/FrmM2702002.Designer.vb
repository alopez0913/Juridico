<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmM2702002
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
        Me.gbFiltros = New System.Windows.Forms.GroupBox()
        Me.gpoFolio = New System.Windows.Forms.GroupBox()
        Me.atxFolio = New ADSUM.AdsumTextBoxAdvanced()
        Me.rdPorFolio = New System.Windows.Forms.RadioButton()
        Me.gpoFecha = New System.Windows.Forms.GroupBox()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.rdPorFecha = New System.Windows.Forms.RadioButton()
        Me.rdPorSolicitante = New System.Windows.Forms.RadioButton()
        Me.gpoSolicitante = New System.Windows.Forms.GroupBox()
        Me.lblNombreSolicitante = New System.Windows.Forms.Label()
        Me.atxSolicitante = New ADSUM.AdsumTextBoxAdvanced()
        Me.grdSolicitudes = New DevExpress.XtraGrid.GridControl()
        Me.grvSolicitudes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gbFiltros.SuspendLayout()
        Me.gpoFolio.SuspendLayout()
        Me.gpoFecha.SuspendLayout()
        Me.gpoSolicitante.SuspendLayout()
        CType(Me.grdSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblToolTip
        '
        Me.lblToolTip.TabIndex = 0
        '
        'gbFiltros
        '
        Me.gbFiltros.Controls.Add(Me.gpoFolio)
        Me.gbFiltros.Controls.Add(Me.rdPorFolio)
        Me.gbFiltros.Controls.Add(Me.gpoFecha)
        Me.gbFiltros.Controls.Add(Me.rdPorFecha)
        Me.gbFiltros.Controls.Add(Me.rdPorSolicitante)
        Me.gbFiltros.Controls.Add(Me.gpoSolicitante)
        Me.gbFiltros.Location = New System.Drawing.Point(18, 12)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(1274, 120)
        Me.gbFiltros.TabIndex = 1
        Me.gbFiltros.TabStop = False
        Me.gbFiltros.Text = "Búsqueda"
        '
        'gpoFolio
        '
        Me.gpoFolio.Controls.Add(Me.atxFolio)
        Me.gpoFolio.Location = New System.Drawing.Point(690, 36)
        Me.gpoFolio.Name = "gpoFolio"
        Me.gpoFolio.Size = New System.Drawing.Size(150, 74)
        Me.gpoFolio.TabIndex = 7
        Me.gpoFolio.TabStop = False
        '
        'atxFolio
        '
        Me.atxFolio.BlancoEsValorInvalido = True
        Me.atxFolio.CadenaDescripcionNoValida = "Codigo no existe"
        Me.atxFolio.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.atxFolio.CatalogoBase = Nothing
        Me.atxFolio.CatalogoPrincipal = False
        Me.atxFolio.ColorDesactivado = System.Drawing.Color.Empty
        Me.atxFolio.ControlDestinoDescripcion = Nothing
        Me.atxFolio.DescripcionElementoInvalido = "Codigo no existe"
        Me.atxFolio.EnPantalla = False
        Me.atxFolio.FiltroExtendido = ""
        Me.atxFolio.LanzarMensajeError = False
        Me.atxFolio.Location = New System.Drawing.Point(37, 26)
        Me.atxFolio.MaxLength = 12
        Me.atxFolio.Multiple = False
        Me.atxFolio.Name = "atxFolio"
        Me.atxFolio.PermiteAvanceElementoInvalido = False
        Me.atxFolio.PermiteAyudaRapida = True
        Me.atxFolio.PermiteSoloCapturarAlfanumericos = False
        Me.atxFolio.Size = New System.Drawing.Size(77, 22)
        Me.atxFolio.TabIndex = 97
        Me.atxFolio.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.atxFolio.TituloMensaje = "Sistema Integral Panama"
        Me.atxFolio.ValorValido = False
        '
        'rdPorFolio
        '
        Me.rdPorFolio.AutoSize = True
        Me.rdPorFolio.Location = New System.Drawing.Point(690, 20)
        Me.rdPorFolio.Name = "rdPorFolio"
        Me.rdPorFolio.Size = New System.Drawing.Size(71, 18)
        Me.rdPorFolio.TabIndex = 6
        Me.rdPorFolio.Text = "Por Folio"
        Me.rdPorFolio.UseVisualStyleBackColor = True
        '
        'gpoFecha
        '
        Me.gpoFecha.Controls.Add(Me.dtpFechaFin)
        Me.gpoFecha.Controls.Add(Me.dtpFechaInicio)
        Me.gpoFecha.Location = New System.Drawing.Point(448, 36)
        Me.gpoFecha.Name = "gpoFecha"
        Me.gpoFecha.Size = New System.Drawing.Size(236, 74)
        Me.gpoFecha.TabIndex = 5
        Me.gpoFecha.TabStop = False
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(121, 26)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(105, 22)
        Me.dtpFechaFin.TabIndex = 2
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(10, 26)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(105, 22)
        Me.dtpFechaInicio.TabIndex = 1
        '
        'rdPorFecha
        '
        Me.rdPorFecha.AutoSize = True
        Me.rdPorFecha.Location = New System.Drawing.Point(448, 20)
        Me.rdPorFecha.Name = "rdPorFecha"
        Me.rdPorFecha.Size = New System.Drawing.Size(127, 18)
        Me.rdPorFecha.TabIndex = 4
        Me.rdPorFecha.Text = "Por Fecha Registro"
        Me.rdPorFecha.UseVisualStyleBackColor = True
        '
        'rdPorSolicitante
        '
        Me.rdPorSolicitante.AutoSize = True
        Me.rdPorSolicitante.Location = New System.Drawing.Point(6, 21)
        Me.rdPorSolicitante.Name = "rdPorSolicitante"
        Me.rdPorSolicitante.Size = New System.Drawing.Size(103, 18)
        Me.rdPorSolicitante.TabIndex = 0
        Me.rdPorSolicitante.Text = "Por Solicitante"
        Me.rdPorSolicitante.UseVisualStyleBackColor = True
        '
        'gpoSolicitante
        '
        Me.gpoSolicitante.Controls.Add(Me.lblNombreSolicitante)
        Me.gpoSolicitante.Controls.Add(Me.atxSolicitante)
        Me.gpoSolicitante.Location = New System.Drawing.Point(6, 37)
        Me.gpoSolicitante.Name = "gpoSolicitante"
        Me.gpoSolicitante.Size = New System.Drawing.Size(436, 74)
        Me.gpoSolicitante.TabIndex = 1
        Me.gpoSolicitante.TabStop = False
        '
        'lblNombreSolicitante
        '
        Me.lblNombreSolicitante.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblNombreSolicitante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNombreSolicitante.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblNombreSolicitante.Location = New System.Drawing.Point(93, 26)
        Me.lblNombreSolicitante.Name = "lblNombreSolicitante"
        Me.lblNombreSolicitante.Size = New System.Drawing.Size(334, 22)
        Me.lblNombreSolicitante.TabIndex = 97
        Me.lblNombreSolicitante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'atxSolicitante
        '
        Me.atxSolicitante.BlancoEsValorInvalido = True
        Me.atxSolicitante.CadenaDescripcionNoValida = "Codigo no existe"
        Me.atxSolicitante.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.atxSolicitante.CatalogoBase = Nothing
        Me.atxSolicitante.CatalogoPrincipal = False
        Me.atxSolicitante.ColorDesactivado = System.Drawing.Color.Empty
        Me.atxSolicitante.ControlDestinoDescripcion = Me.lblNombreSolicitante
        Me.atxSolicitante.DescripcionElementoInvalido = "Codigo no existe"
        Me.atxSolicitante.EnPantalla = False
        Me.atxSolicitante.FiltroExtendido = ""
        Me.atxSolicitante.LanzarMensajeError = False
        Me.atxSolicitante.Location = New System.Drawing.Point(10, 26)
        Me.atxSolicitante.MaxLength = 12
        Me.atxSolicitante.Multiple = False
        Me.atxSolicitante.Name = "atxSolicitante"
        Me.atxSolicitante.PermiteAvanceElementoInvalido = False
        Me.atxSolicitante.PermiteAyudaRapida = True
        Me.atxSolicitante.PermiteSoloCapturarAlfanumericos = False
        Me.atxSolicitante.Size = New System.Drawing.Size(77, 22)
        Me.atxSolicitante.TabIndex = 96
        Me.atxSolicitante.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.atxSolicitante.TituloMensaje = "Sistema Integral Panama"
        Me.atxSolicitante.ValorValido = False
        '
        'grdSolicitudes
        '
        Me.grdSolicitudes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdSolicitudes.Location = New System.Drawing.Point(18, 138)
        Me.grdSolicitudes.MainView = Me.grvSolicitudes
        Me.grdSolicitudes.Name = "grdSolicitudes"
        Me.grdSolicitudes.Size = New System.Drawing.Size(1274, 564)
        Me.grdSolicitudes.TabIndex = 2
        Me.grdSolicitudes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvSolicitudes})
        '
        'grvSolicitudes
        '
        Me.grvSolicitudes.GridControl = Me.grdSolicitudes
        Me.grvSolicitudes.Name = "grvSolicitudes"
        '
        'FrmM2702002
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1308, 749)
        Me.Controls.Add(Me.grdSolicitudes)
        Me.Controls.Add(Me.gbFiltros)
        Me.Name = "FrmM2702002"
        Me.ReferenciaRapidaVisible = True
        Me.Text = "Bandeja de Solicitudes"
        Me.Controls.SetChildIndex(Me.gbFiltros, 0)
        Me.Controls.SetChildIndex(Me.grdSolicitudes, 0)
        Me.Controls.SetChildIndex(Me.lblToolTip, 0)
        Me.gbFiltros.ResumeLayout(False)
        Me.gbFiltros.PerformLayout()
        Me.gpoFolio.ResumeLayout(False)
        Me.gpoFolio.PerformLayout()
        Me.gpoFecha.ResumeLayout(False)
        Me.gpoSolicitante.ResumeLayout(False)
        Me.gpoSolicitante.PerformLayout()
        CType(Me.grdSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents gpoSolicitante As System.Windows.Forms.GroupBox
    Friend WithEvents grdSolicitudes As DevExpress.XtraGrid.GridControl
    Friend WithEvents rdPorSolicitante As System.Windows.Forms.RadioButton
    Friend WithEvents gpoFecha As System.Windows.Forms.GroupBox
    Friend WithEvents rdPorFecha As System.Windows.Forms.RadioButton
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNombreSolicitante As Label
    Friend WithEvents atxSolicitante As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents gpoFolio As GroupBox
    Friend WithEvents atxFolio As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents rdPorFolio As RadioButton
    Friend WithEvents grvSolicitudes As DevExpress.XtraGrid.Views.Grid.GridView
End Class
