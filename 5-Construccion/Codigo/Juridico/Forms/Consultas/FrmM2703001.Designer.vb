<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmM2703001
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
        Me.components = New System.ComponentModel.Container()
        Me.grdMovimientos = New DevExpress.XtraGrid.GridControl()
        Me.grvMovimientos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.atxSolicitante = New ADSUM.AdsumTextBoxAdvanced()
        Me.lblDescSolicitante = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblDescDepto = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblDescSubacto = New System.Windows.Forms.Label()
        Me.lblDescActo = New System.Windows.Forms.Label()
        Me.lblDescGrupo = New System.Windows.Forms.Label()
        Me.lblDescContratante = New System.Windows.Forms.Label()
        Me.atxCodGrupo = New ADSUM.AdsumTextBoxAdvanced()
        Me.atxCodSubacto = New ADSUM.AdsumTextBoxAdvanced()
        Me.atxCodActo = New ADSUM.AdsumTextBoxAdvanced()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbEstatus = New System.Windows.Forms.ComboBox()
        Me.atxCodDepto = New ADSUM.AdsumTextBoxAdvanced()
        Me.atxCodContratante = New ADSUM.AdsumTextBoxAdvanced()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrTiempo = New System.Windows.Forms.Timer(Me.components)
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
        CType(Me.grdMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblToolTip
        '
        Me.lblToolTip.Size = New System.Drawing.Size(19, 25)
        '
        'grdMovimientos
        '
        Me.grdMovimientos.Location = New System.Drawing.Point(14, 179)
        Me.grdMovimientos.MainView = Me.grvMovimientos
        Me.grdMovimientos.Name = "grdMovimientos"
        Me.grdMovimientos.Size = New System.Drawing.Size(1063, 459)
        Me.grdMovimientos.TabIndex = 80
        Me.grdMovimientos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvMovimientos})
        '
        'grvMovimientos
        '
        Me.grvMovimientos.GridControl = Me.grdMovimientos
        Me.grvMovimientos.Name = "grvMovimientos"
        Me.grvMovimientos.OptionsView.ColumnAutoWidth = False
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
        Me.GroupBox1.Controls.Add(Me.lblDescDepto)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lblDescSubacto)
        Me.GroupBox1.Controls.Add(Me.lblDescActo)
        Me.GroupBox1.Controls.Add(Me.lblDescGrupo)
        Me.GroupBox1.Controls.Add(Me.lblDescContratante)
        Me.GroupBox1.Controls.Add(Me.atxCodGrupo)
        Me.GroupBox1.Controls.Add(Me.atxCodSubacto)
        Me.GroupBox1.Controls.Add(Me.atxCodActo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbEstatus)
        Me.GroupBox1.Controls.Add(Me.atxCodDepto)
        Me.GroupBox1.Controls.Add(Me.atxCodContratante)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
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
        Me.dtpFecFin.Location = New System.Drawing.Point(954, 45)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(107, 22)
        Me.dtpFecFin.TabIndex = 19
        '
        'dtpFecIni
        '
        Me.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIni.Location = New System.Drawing.Point(954, 18)
        Me.dtpFecIni.Name = "dtpFecIni"
        Me.dtpFecIni.Size = New System.Drawing.Size(107, 22)
        Me.dtpFecIni.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(879, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 14)
        Me.Label8.TabIndex = 101
        Me.Label8.Text = "Fecha Final:"
        '
        'lblDescDepto
        '
        Me.lblDescDepto.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblDescDepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescDepto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblDescDepto.Location = New System.Drawing.Point(154, 75)
        Me.lblDescDepto.Name = "lblDescDepto"
        Me.lblDescDepto.Size = New System.Drawing.Size(311, 22)
        Me.lblDescDepto.TabIndex = 100
        Me.lblDescDepto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(873, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 14)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "Fecha Inicial:"
        '
        'lblDescSubacto
        '
        Me.lblDescSubacto.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblDescSubacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescSubacto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblDescSubacto.Location = New System.Drawing.Point(584, 72)
        Me.lblDescSubacto.Name = "lblDescSubacto"
        Me.lblDescSubacto.Size = New System.Drawing.Size(280, 22)
        Me.lblDescSubacto.TabIndex = 98
        Me.lblDescSubacto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDescSubacto.Visible = False
        '
        'lblDescActo
        '
        Me.lblDescActo.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblDescActo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescActo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblDescActo.Location = New System.Drawing.Point(584, 45)
        Me.lblDescActo.Name = "lblDescActo"
        Me.lblDescActo.Size = New System.Drawing.Size(280, 22)
        Me.lblDescActo.TabIndex = 97
        Me.lblDescActo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescGrupo
        '
        Me.lblDescGrupo.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblDescGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescGrupo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblDescGrupo.Location = New System.Drawing.Point(584, 18)
        Me.lblDescGrupo.Name = "lblDescGrupo"
        Me.lblDescGrupo.Size = New System.Drawing.Size(280, 22)
        Me.lblDescGrupo.TabIndex = 96
        Me.lblDescGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescContratante
        '
        Me.lblDescContratante.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblDescContratante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescContratante.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblDescContratante.Location = New System.Drawing.Point(154, 45)
        Me.lblDescContratante.Name = "lblDescContratante"
        Me.lblDescContratante.Size = New System.Drawing.Size(311, 22)
        Me.lblDescContratante.TabIndex = 95
        Me.lblDescContratante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'atxCodGrupo
        '
        Me.atxCodGrupo.BlancoEsValorInvalido = True
        Me.atxCodGrupo.CadenaDescripcionNoValida = "Codigo no existe"
        Me.atxCodGrupo.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.atxCodGrupo.CatalogoBase = Nothing
        Me.atxCodGrupo.CatalogoPrincipal = False
        Me.atxCodGrupo.ColorDesactivado = System.Drawing.Color.Empty
        Me.atxCodGrupo.ControlDestinoDescripcion = Me.lblDescGrupo
        Me.atxCodGrupo.DescripcionElementoInvalido = "Codigo no existe"
        Me.atxCodGrupo.EnPantalla = False
        Me.atxCodGrupo.FiltroExtendido = ""
        Me.atxCodGrupo.LanzarMensajeError = False
        Me.atxCodGrupo.Location = New System.Drawing.Point(526, 18)
        Me.atxCodGrupo.MaxLength = 12
        Me.atxCodGrupo.Multiple = False
        Me.atxCodGrupo.Name = "atxCodGrupo"
        Me.atxCodGrupo.PermiteAvanceElementoInvalido = False
        Me.atxCodGrupo.PermiteAyudaRapida = True
        Me.atxCodGrupo.PermiteSoloCapturarAlfanumericos = False
        Me.atxCodGrupo.Size = New System.Drawing.Size(52, 22)
        Me.atxCodGrupo.TabIndex = 15
        Me.atxCodGrupo.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.atxCodGrupo.TituloMensaje = "Sistema Integral Panama"
        Me.atxCodGrupo.ValorValido = False
        '
        'atxCodSubacto
        '
        Me.atxCodSubacto.BlancoEsValorInvalido = True
        Me.atxCodSubacto.CadenaDescripcionNoValida = "Codigo no existe"
        Me.atxCodSubacto.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.atxCodSubacto.CatalogoBase = Nothing
        Me.atxCodSubacto.CatalogoPrincipal = False
        Me.atxCodSubacto.ColorDesactivado = System.Drawing.Color.Empty
        Me.atxCodSubacto.ControlDestinoDescripcion = Me.lblDescSubacto
        Me.atxCodSubacto.DescripcionElementoInvalido = "Codigo no existe"
        Me.atxCodSubacto.EnPantalla = False
        Me.atxCodSubacto.FiltroExtendido = ""
        Me.atxCodSubacto.LanzarMensajeError = False
        Me.atxCodSubacto.Location = New System.Drawing.Point(526, 72)
        Me.atxCodSubacto.MaxLength = 12
        Me.atxCodSubacto.Multiple = False
        Me.atxCodSubacto.Name = "atxCodSubacto"
        Me.atxCodSubacto.PermiteAvanceElementoInvalido = False
        Me.atxCodSubacto.PermiteAyudaRapida = True
        Me.atxCodSubacto.PermiteSoloCapturarAlfanumericos = False
        Me.atxCodSubacto.Size = New System.Drawing.Size(52, 22)
        Me.atxCodSubacto.TabIndex = 17
        Me.atxCodSubacto.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.atxCodSubacto.TituloMensaje = "Sistema Integral Panama"
        Me.atxCodSubacto.ValorValido = False
        Me.atxCodSubacto.Visible = False
        '
        'atxCodActo
        '
        Me.atxCodActo.BlancoEsValorInvalido = True
        Me.atxCodActo.CadenaDescripcionNoValida = "Codigo no existe"
        Me.atxCodActo.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.atxCodActo.CatalogoBase = Nothing
        Me.atxCodActo.CatalogoPrincipal = False
        Me.atxCodActo.ColorDesactivado = System.Drawing.Color.Empty
        Me.atxCodActo.ControlDestinoDescripcion = Me.lblDescActo
        Me.atxCodActo.DescripcionElementoInvalido = "Codigo no existe"
        Me.atxCodActo.EnPantalla = False
        Me.atxCodActo.FiltroExtendido = ""
        Me.atxCodActo.LanzarMensajeError = False
        Me.atxCodActo.Location = New System.Drawing.Point(526, 45)
        Me.atxCodActo.MaxLength = 12
        Me.atxCodActo.Multiple = False
        Me.atxCodActo.Name = "atxCodActo"
        Me.atxCodActo.PermiteAvanceElementoInvalido = False
        Me.atxCodActo.PermiteAyudaRapida = True
        Me.atxCodActo.PermiteSoloCapturarAlfanumericos = False
        Me.atxCodActo.Size = New System.Drawing.Size(52, 22)
        Me.atxCodActo.TabIndex = 16
        Me.atxCodActo.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.atxCodActo.TituloMensaje = "Sistema Integral Panama"
        Me.atxCodActo.ValorValido = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(467, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 14)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Subacto:"
        Me.Label7.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(486, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 14)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Acto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(479, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 14)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "Grupo:"
        '
        'cmbEstatus
        '
        Me.cmbEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstatus.FormattingEnabled = True
        Me.cmbEstatus.Location = New System.Drawing.Point(98, 100)
        Me.cmbEstatus.Name = "cmbEstatus"
        Me.cmbEstatus.Size = New System.Drawing.Size(148, 22)
        Me.cmbEstatus.TabIndex = 14
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
        Me.atxCodDepto.Location = New System.Drawing.Point(98, 72)
        Me.atxCodDepto.MaxLength = 12
        Me.atxCodDepto.Multiple = False
        Me.atxCodDepto.Name = "atxCodDepto"
        Me.atxCodDepto.PermiteAvanceElementoInvalido = False
        Me.atxCodDepto.PermiteAyudaRapida = True
        Me.atxCodDepto.PermiteSoloCapturarAlfanumericos = False
        Me.atxCodDepto.Size = New System.Drawing.Size(50, 22)
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
        Me.atxCodContratante.ControlDestinoDescripcion = Me.lblDescContratante
        Me.atxCodContratante.DescripcionElementoInvalido = "Codigo no existe"
        Me.atxCodContratante.EnPantalla = False
        Me.atxCodContratante.FiltroExtendido = ""
        Me.atxCodContratante.LanzarMensajeError = False
        Me.atxCodContratante.Location = New System.Drawing.Point(98, 45)
        Me.atxCodContratante.MaxLength = 12
        Me.atxCodContratante.Multiple = False
        Me.atxCodContratante.Name = "atxCodContratante"
        Me.atxCodContratante.PermiteAvanceElementoInvalido = False
        Me.atxCodContratante.PermiteAyudaRapida = True
        Me.atxCodContratante.PermiteSoloCapturarAlfanumericos = False
        Me.atxCodContratante.Size = New System.Drawing.Size(50, 22)
        Me.atxCodContratante.TabIndex = 12
        Me.atxCodContratante.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.atxCodContratante.TituloMensaje = "Sistema Integral Panama"
        Me.atxCodContratante.ValorValido = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 14)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Estatus:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 14)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Departamento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 14)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Contratante:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 14)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Solicitante:"
        '
        'tmrTiempo
        '
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
        'FrmM2703001
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
        Me.Controls.Add(Me.grdMovimientos)
        Me.Name = "FrmM2703001"
        Me.ReferenciaRapidaVisible = True
        Me.Text = "Consulta de Contratos"
        Me.Controls.SetChildIndex(Me.grdMovimientos, 0)
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
        CType(Me.grdMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdMovimientos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvMovimientos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents atxSolicitante As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbEstatus As ComboBox
    Friend WithEvents atxCodDepto As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents atxCodContratante As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblDescSubacto As Label
    Friend WithEvents lblDescActo As Label
    Friend WithEvents lblDescGrupo As Label
    Friend WithEvents lblDescContratante As Label
    Friend WithEvents atxCodGrupo As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents atxCodSubacto As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents atxCodActo As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDescDepto As Label
    Friend WithEvents dtpFecFin As DateTimePicker
    Friend WithEvents dtpFecIni As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents tmrTiempo As Timer
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
