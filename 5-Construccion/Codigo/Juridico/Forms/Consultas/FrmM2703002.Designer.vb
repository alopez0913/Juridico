<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmM2703002
    '  Inherits System.Windows.Forms.Form
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
        Me.cmbTipoConsulta = New System.Windows.Forms.ComboBox()
        Me.lblTipoConsulta = New System.Windows.Forms.Label()
        Me.grbClasificacion = New System.Windows.Forms.GroupBox()
        Me.txtClasificacion = New System.Windows.Forms.TextBox()
        Me.lblClasificacion = New System.Windows.Forms.Label()
        Me.txtSubTipoActo = New System.Windows.Forms.TextBox()
        Me.atxSubTipoActo = New ADSUM.AdsumTextBoxAdvanced()
        Me.txtTipoActo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGrupo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.lblDep = New System.Windows.Forms.Label()
        Me.grboxRangoFechas = New System.Windows.Forms.GroupBox()
        Me.DTPFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.DTPFechaini = New System.Windows.Forms.DateTimePicker()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.lblIni = New System.Windows.Forms.Label()
        Me.txtDepa = New System.Windows.Forms.TextBox()
        Me.txtSubdepa = New System.Windows.Forms.TextBox()
        Me.GridProveedores = New DevExpress.XtraGrid.GridControl()
        Me.Grvprovedores = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtEstatus = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.lblFolio = New System.Windows.Forms.Label()
        Me.atxCodigo = New ADSUM.AdsumTextBoxAdvanced()
        Me.lblsolicitante = New System.Windows.Forms.Label()
        Me.atxSolcitante = New ADSUM.AdsumTextBoxAdvanced()
        Me.txtSolicitante = New System.Windows.Forms.TextBox()
        Me.grbFolio = New System.Windows.Forms.GroupBox()
        Me.grbDepartamento = New System.Windows.Forms.GroupBox()
        Me.grbSolicitante = New System.Windows.Forms.GroupBox()
        Me.grbClasificacion.SuspendLayout()
        Me.grboxRangoFechas.SuspendLayout()
        CType(Me.GridProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grvprovedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbFolio.SuspendLayout()
        Me.grbDepartamento.SuspendLayout()
        Me.grbSolicitante.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblToolTip
        '
        Me.lblToolTip.Size = New System.Drawing.Size(19, 25)
        '
        'cmbTipoConsulta
        '
        Me.cmbTipoConsulta.FormattingEnabled = True
        Me.cmbTipoConsulta.Location = New System.Drawing.Point(99, 17)
        Me.cmbTipoConsulta.Name = "cmbTipoConsulta"
        Me.cmbTipoConsulta.Size = New System.Drawing.Size(238, 22)
        Me.cmbTipoConsulta.TabIndex = 2
        '
        'lblTipoConsulta
        '
        Me.lblTipoConsulta.AutoSize = True
        Me.lblTipoConsulta.Location = New System.Drawing.Point(17, 25)
        Me.lblTipoConsulta.Name = "lblTipoConsulta"
        Me.lblTipoConsulta.Size = New System.Drawing.Size(81, 14)
        Me.lblTipoConsulta.TabIndex = 3
        Me.lblTipoConsulta.Text = "Tipo Consulta"
        '
        'grbClasificacion
        '
        Me.grbClasificacion.Controls.Add(Me.txtClasificacion)
        Me.grbClasificacion.Controls.Add(Me.lblClasificacion)
        Me.grbClasificacion.Controls.Add(Me.txtSubTipoActo)
        Me.grbClasificacion.Controls.Add(Me.atxSubTipoActo)
        Me.grbClasificacion.Controls.Add(Me.txtTipoActo)
        Me.grbClasificacion.Controls.Add(Me.Label6)
        Me.grbClasificacion.Controls.Add(Me.Label2)
        Me.grbClasificacion.Controls.Add(Me.txtGrupo)
        Me.grbClasificacion.Controls.Add(Me.Label4)
        Me.grbClasificacion.Controls.Add(Me.Label3)
        Me.grbClasificacion.Location = New System.Drawing.Point(15, 111)
        Me.grbClasificacion.Name = "grbClasificacion"
        Me.grbClasificacion.Size = New System.Drawing.Size(687, 46)
        Me.grbClasificacion.TabIndex = 104
        Me.grbClasificacion.TabStop = False
        Me.grbClasificacion.Text = "Clasificacion de Contrato"
        '
        'txtClasificacion
        '
        Me.txtClasificacion.Location = New System.Drawing.Point(143, 18)
        Me.txtClasificacion.Name = "txtClasificacion"
        Me.txtClasificacion.Size = New System.Drawing.Size(526, 22)
        Me.txtClasificacion.TabIndex = 27
        '
        'lblClasificacion
        '
        Me.lblClasificacion.AutoSize = True
        Me.lblClasificacion.Location = New System.Drawing.Point(2, 26)
        Me.lblClasificacion.Name = "lblClasificacion"
        Me.lblClasificacion.Size = New System.Drawing.Size(69, 14)
        Me.lblClasificacion.TabIndex = 26
        Me.lblClasificacion.Text = "Clasificacion"
        '
        'txtSubTipoActo
        '
        Me.txtSubTipoActo.Location = New System.Drawing.Point(196, 18)
        Me.txtSubTipoActo.Name = "txtSubTipoActo"
        Me.txtSubTipoActo.Size = New System.Drawing.Size(473, 22)
        Me.txtSubTipoActo.TabIndex = 15
        '
        'atxSubTipoActo
        '
        Me.atxSubTipoActo.BlancoEsValorInvalido = True
        Me.atxSubTipoActo.CadenaDescripcionNoValida = "Codigo no existe"
        Me.atxSubTipoActo.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.atxSubTipoActo.CatalogoBase = Nothing
        Me.atxSubTipoActo.CatalogoPrincipal = False
        Me.atxSubTipoActo.ColorDesactivado = System.Drawing.Color.Empty
        Me.atxSubTipoActo.ControlDestinoDescripcion = Nothing
        Me.atxSubTipoActo.DescripcionElementoInvalido = "Codigo no existe"
        Me.atxSubTipoActo.EnPantalla = False
        Me.atxSubTipoActo.FiltroExtendido = ""
        Me.atxSubTipoActo.LanzarMensajeError = False
        Me.atxSubTipoActo.Location = New System.Drawing.Point(77, 18)
        Me.atxSubTipoActo.MaxLength = 5
        Me.atxSubTipoActo.Multiple = False
        Me.atxSubTipoActo.Name = "atxSubTipoActo"
        Me.atxSubTipoActo.PermiteAvanceElementoInvalido = True
        Me.atxSubTipoActo.PermiteAyudaRapida = True
        Me.atxSubTipoActo.PermiteSoloCapturarAlfanumericos = False
        Me.atxSubTipoActo.Size = New System.Drawing.Size(60, 22)
        Me.atxSubTipoActo.TabIndex = 13
        Me.atxSubTipoActo.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.atxSubTipoActo.TituloMensaje = "Sistema de Juridico"
        Me.atxSubTipoActo.ValorValido = False
        '
        'txtTipoActo
        '
        Me.txtTipoActo.Location = New System.Drawing.Point(226, 86)
        Me.txtTipoActo.Name = "txtTipoActo"
        Me.txtTipoActo.Size = New System.Drawing.Size(473, 22)
        Me.txtTipoActo.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(287, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 14)
        Me.Label6.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(287, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 14)
        Me.Label2.TabIndex = 11
        '
        'txtGrupo
        '
        Me.txtGrupo.Location = New System.Drawing.Point(226, 56)
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(473, 22)
        Me.txtGrupo.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(286, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 14)
        Me.Label4.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(286, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 14)
        Me.Label3.TabIndex = 7
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Location = New System.Drawing.Point(98, 18)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(176, 22)
        Me.cmbDepartamento.TabIndex = 110
        '
        'lblDep
        '
        Me.lblDep.AutoSize = True
        Me.lblDep.Location = New System.Drawing.Point(6, 26)
        Me.lblDep.Name = "lblDep"
        Me.lblDep.Size = New System.Drawing.Size(86, 14)
        Me.lblDep.TabIndex = 109
        Me.lblDep.Text = "Departamento"
        '
        'grboxRangoFechas
        '
        Me.grboxRangoFechas.Controls.Add(Me.DTPFechaFin)
        Me.grboxRangoFechas.Controls.Add(Me.DTPFechaini)
        Me.grboxRangoFechas.Controls.Add(Me.lblFinal)
        Me.grboxRangoFechas.Controls.Add(Me.lblIni)
        Me.grboxRangoFechas.Location = New System.Drawing.Point(15, 225)
        Me.grboxRangoFechas.Name = "grboxRangoFechas"
        Me.grboxRangoFechas.Size = New System.Drawing.Size(454, 46)
        Me.grboxRangoFechas.TabIndex = 111
        Me.grboxRangoFechas.TabStop = False
        Me.grboxRangoFechas.Text = "Rango De Fechas"
        '
        'DTPFechaFin
        '
        Me.DTPFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFechaFin.Location = New System.Drawing.Point(278, 18)
        Me.DTPFechaFin.Name = "DTPFechaFin"
        Me.DTPFechaFin.Size = New System.Drawing.Size(154, 22)
        Me.DTPFechaFin.TabIndex = 21
        '
        'DTPFechaini
        '
        Me.DTPFechaini.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFechaini.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DTPFechaini.Location = New System.Drawing.Point(66, 17)
        Me.DTPFechaini.Name = "DTPFechaini"
        Me.DTPFechaini.Size = New System.Drawing.Size(154, 22)
        Me.DTPFechaini.TabIndex = 21
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Location = New System.Drawing.Point(236, 23)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(30, 14)
        Me.lblFinal.TabIndex = 18
        Me.lblFinal.Text = "Final"
        '
        'lblIni
        '
        Me.lblIni.AutoSize = True
        Me.lblIni.Location = New System.Drawing.Point(20, 24)
        Me.lblIni.Name = "lblIni"
        Me.lblIni.Size = New System.Drawing.Size(36, 14)
        Me.lblIni.TabIndex = 17
        Me.lblIni.Text = "Inicial"
        '
        'txtDepa
        '
        Me.txtDepa.Location = New System.Drawing.Point(280, 18)
        Me.txtDepa.Name = "txtDepa"
        Me.txtDepa.Size = New System.Drawing.Size(100, 22)
        Me.txtDepa.TabIndex = 113
        '
        'txtSubdepa
        '
        Me.txtSubdepa.Location = New System.Drawing.Point(386, 18)
        Me.txtSubdepa.Name = "txtSubdepa"
        Me.txtSubdepa.Size = New System.Drawing.Size(100, 22)
        Me.txtSubdepa.TabIndex = 114
        '
        'GridProveedores
        '
        Me.GridProveedores.Location = New System.Drawing.Point(15, 344)
        Me.GridProveedores.MainView = Me.Grvprovedores
        Me.GridProveedores.Name = "GridProveedores"
        Me.GridProveedores.Size = New System.Drawing.Size(865, 123)
        Me.GridProveedores.TabIndex = 115
        Me.GridProveedores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Grvprovedores})
        '
        'Grvprovedores
        '
        Me.Grvprovedores.GridControl = Me.GridProveedores
        Me.Grvprovedores.Name = "Grvprovedores"
        '
        'txtEstatus
        '
        Me.txtEstatus.Location = New System.Drawing.Point(215, 11)
        Me.txtEstatus.Name = "txtEstatus"
        Me.txtEstatus.Size = New System.Drawing.Size(127, 22)
        Me.txtEstatus.TabIndex = 119
        '
        'txtColor
        '
        Me.txtColor.BackColor = System.Drawing.Color.White
        Me.txtColor.Location = New System.Drawing.Point(159, 11)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(40, 22)
        Me.txtColor.TabIndex = 118
        '
        'lblFolio
        '
        Me.lblFolio.AutoSize = True
        Me.lblFolio.Location = New System.Drawing.Point(14, 18)
        Me.lblFolio.Name = "lblFolio"
        Me.lblFolio.Size = New System.Drawing.Size(63, 14)
        Me.lblFolio.TabIndex = 117
        Me.lblFolio.Text = "Folio Solic."
        '
        'atxCodigo
        '
        Me.atxCodigo.BlancoEsValorInvalido = True
        Me.atxCodigo.CadenaDescripcionNoValida = "Codigo no existe"
        Me.atxCodigo.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.atxCodigo.CatalogoBase = Nothing
        Me.atxCodigo.CatalogoPrincipal = False
        Me.atxCodigo.ColorDesactivado = System.Drawing.Color.Empty
        Me.atxCodigo.ControlDestinoDescripcion = Nothing
        Me.atxCodigo.DescripcionElementoInvalido = "Codigo no existe"
        Me.atxCodigo.EnPantalla = False
        Me.atxCodigo.FiltroExtendido = ""
        Me.atxCodigo.LanzarMensajeError = False
        Me.atxCodigo.Location = New System.Drawing.Point(81, 11)
        Me.atxCodigo.MaxLength = 5
        Me.atxCodigo.Multiple = False
        Me.atxCodigo.Name = "atxCodigo"
        Me.atxCodigo.PermiteAvanceElementoInvalido = True
        Me.atxCodigo.PermiteAyudaRapida = True
        Me.atxCodigo.PermiteSoloCapturarAlfanumericos = False
        Me.atxCodigo.Size = New System.Drawing.Size(72, 22)
        Me.atxCodigo.TabIndex = 116
        Me.atxCodigo.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.atxCodigo.TituloMensaje = "Sistema de Juridico"
        Me.atxCodigo.ValorValido = False
        '
        'lblsolicitante
        '
        Me.lblsolicitante.AutoSize = True
        Me.lblsolicitante.Location = New System.Drawing.Point(6, 24)
        Me.lblsolicitante.Name = "lblsolicitante"
        Me.lblsolicitante.Size = New System.Drawing.Size(63, 14)
        Me.lblsolicitante.TabIndex = 121
        Me.lblsolicitante.Text = "Solicitante"
        '
        'atxSolcitante
        '
        Me.atxSolcitante.BlancoEsValorInvalido = True
        Me.atxSolcitante.CadenaDescripcionNoValida = "Codigo no existe"
        Me.atxSolcitante.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.atxSolcitante.CatalogoBase = Nothing
        Me.atxSolcitante.CatalogoPrincipal = False
        Me.atxSolcitante.ColorDesactivado = System.Drawing.Color.Empty
        Me.atxSolcitante.ControlDestinoDescripcion = Nothing
        Me.atxSolcitante.DescripcionElementoInvalido = "Codigo no existe"
        Me.atxSolcitante.EnPantalla = False
        Me.atxSolcitante.FiltroExtendido = ""
        Me.atxSolcitante.LanzarMensajeError = False
        Me.atxSolcitante.Location = New System.Drawing.Point(75, 16)
        Me.atxSolcitante.MaxLength = 5
        Me.atxSolcitante.Multiple = False
        Me.atxSolcitante.Name = "atxSolcitante"
        Me.atxSolcitante.PermiteAvanceElementoInvalido = True
        Me.atxSolcitante.PermiteAyudaRapida = True
        Me.atxSolcitante.PermiteSoloCapturarAlfanumericos = False
        Me.atxSolcitante.Size = New System.Drawing.Size(88, 22)
        Me.atxSolcitante.TabIndex = 120
        Me.atxSolcitante.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.atxSolcitante.TituloMensaje = "Sistema de Juridico"
        Me.atxSolcitante.ValorValido = False
        '
        'txtSolicitante
        '
        Me.txtSolicitante.Location = New System.Drawing.Point(171, 16)
        Me.txtSolicitante.Name = "txtSolicitante"
        Me.txtSolicitante.Size = New System.Drawing.Size(335, 22)
        Me.txtSolicitante.TabIndex = 122
        '
        'grbFolio
        '
        Me.grbFolio.Controls.Add(Me.lblFolio)
        Me.grbFolio.Controls.Add(Me.atxCodigo)
        Me.grbFolio.Controls.Add(Me.txtColor)
        Me.grbFolio.Controls.Add(Me.txtEstatus)
        Me.grbFolio.Location = New System.Drawing.Point(15, 67)
        Me.grbFolio.Name = "grbFolio"
        Me.grbFolio.Size = New System.Drawing.Size(357, 38)
        Me.grbFolio.TabIndex = 123
        Me.grbFolio.TabStop = False
        Me.grbFolio.Text = "Folio"
        '
        'grbDepartamento
        '
        Me.grbDepartamento.Controls.Add(Me.lblDep)
        Me.grbDepartamento.Controls.Add(Me.cmbDepartamento)
        Me.grbDepartamento.Controls.Add(Me.txtDepa)
        Me.grbDepartamento.Controls.Add(Me.txtSubdepa)
        Me.grbDepartamento.Location = New System.Drawing.Point(15, 171)
        Me.grbDepartamento.Name = "grbDepartamento"
        Me.grbDepartamento.Size = New System.Drawing.Size(499, 48)
        Me.grbDepartamento.TabIndex = 124
        Me.grbDepartamento.TabStop = False
        Me.grbDepartamento.Text = "Departamento"
        '
        'grbSolicitante
        '
        Me.grbSolicitante.Controls.Add(Me.lblsolicitante)
        Me.grbSolicitante.Controls.Add(Me.atxSolcitante)
        Me.grbSolicitante.Controls.Add(Me.txtSolicitante)
        Me.grbSolicitante.Location = New System.Drawing.Point(15, 277)
        Me.grbSolicitante.Name = "grbSolicitante"
        Me.grbSolicitante.Size = New System.Drawing.Size(522, 45)
        Me.grbSolicitante.TabIndex = 125
        Me.grbSolicitante.TabStop = False
        Me.grbSolicitante.Text = "Solicitante"
        '
        'FrmM2703002
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 528)
        Me.Controls.Add(Me.grbSolicitante)
        Me.Controls.Add(Me.grbDepartamento)
        Me.Controls.Add(Me.grbFolio)
        Me.Controls.Add(Me.GridProveedores)
        Me.Controls.Add(Me.grboxRangoFechas)
        Me.Controls.Add(Me.grbClasificacion)
        Me.Controls.Add(Me.lblTipoConsulta)
        Me.Controls.Add(Me.cmbTipoConsulta)
        Me.Name = "FrmM2703002"
        Me.ReferenciaRapidaVisible = True
        Me.Text = "Consulta Historica De Contratos (BITÁCORA)"
        Me.Controls.SetChildIndex(Me.lblToolTip, 0)
        Me.Controls.SetChildIndex(Me.cmbTipoConsulta, 0)
        Me.Controls.SetChildIndex(Me.lblTipoConsulta, 0)
        Me.Controls.SetChildIndex(Me.grbClasificacion, 0)
        Me.Controls.SetChildIndex(Me.grboxRangoFechas, 0)
        Me.Controls.SetChildIndex(Me.GridProveedores, 0)
        Me.Controls.SetChildIndex(Me.grbFolio, 0)
        Me.Controls.SetChildIndex(Me.grbDepartamento, 0)
        Me.Controls.SetChildIndex(Me.grbSolicitante, 0)
        Me.grbClasificacion.ResumeLayout(False)
        Me.grbClasificacion.PerformLayout()
        Me.grboxRangoFechas.ResumeLayout(False)
        Me.grboxRangoFechas.PerformLayout()
        CType(Me.GridProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grvprovedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbFolio.ResumeLayout(False)
        Me.grbFolio.PerformLayout()
        Me.grbDepartamento.ResumeLayout(False)
        Me.grbDepartamento.PerformLayout()
        Me.grbSolicitante.ResumeLayout(False)
        Me.grbSolicitante.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbTipoConsulta As ComboBox
    Friend WithEvents lblTipoConsulta As Label
    Friend WithEvents grbClasificacion As GroupBox
    Friend WithEvents txtClasificacion As TextBox
    Friend WithEvents lblClasificacion As Label
    Friend WithEvents txtSubTipoActo As TextBox
    Friend WithEvents atxSubTipoActo As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents txtTipoActo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGrupo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbDepartamento As ComboBox
    Friend WithEvents lblDep As Label
    Friend WithEvents grboxRangoFechas As GroupBox
    Friend WithEvents DTPFechaFin As DateTimePicker
    Friend WithEvents DTPFechaini As DateTimePicker
    Friend WithEvents lblFinal As Label
    Friend WithEvents lblIni As Label
    Friend WithEvents txtDepa As TextBox
    Friend WithEvents txtSubdepa As TextBox
    Friend WithEvents GridProveedores As DevExpress.XtraGrid.GridControl
    Friend WithEvents Grvprovedores As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtEstatus As TextBox
    Friend WithEvents txtColor As TextBox
    Friend WithEvents lblFolio As Label
    Friend WithEvents atxCodigo As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents lblsolicitante As Label
    Friend WithEvents atxSolcitante As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents txtSolicitante As TextBox
    Friend WithEvents grbFolio As GroupBox
    Friend WithEvents grbDepartamento As GroupBox
    Friend WithEvents grbSolicitante As GroupBox
End Class
