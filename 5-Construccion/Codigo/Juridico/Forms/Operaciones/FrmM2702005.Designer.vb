<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmM2702005
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmM2702005))
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblColorStatus = New System.Windows.Forms.Label()
        Me.lblFolio = New System.Windows.Forms.Label()
        Me.ATXFolio = New ADSUM.AdsumTextBoxAdvanced()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFolioSeguimiento = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblClasificacion = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblNomBeneficiario = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblNomSolicitante = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNomDepto = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grdDocumentos = New DevExpress.XtraGrid.GridControl()
        Me.grvDocumentos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ofdArchivo = New System.Windows.Forms.OpenFileDialog()
        Me.grdContratosFirmados = New DevExpress.XtraGrid.GridControl()
        Me.grvContratosFirmados = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ilIconos = New System.Windows.Forms.ImageList(Me.components)
        Me.btnAñadeLiberaPropuesta = New System.Windows.Forms.Button()
        Me.gpoRespuestaPropuesta = New System.Windows.Forms.GroupBox()
        Me.lblRutaDetallePropuesta = New System.Windows.Forms.Label()
        Me.btnAdjuntarMasDetalle = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ATXObservacion = New ADSUM.AdsumTextBoxAdvanced()
        Me.optRechazar = New System.Windows.Forms.RadioButton()
        Me.optAceptar = New System.Windows.Forms.RadioButton()
        Me.gpoContratos = New System.Windows.Forms.GroupBox()
        Me.lvContratos = New System.Windows.Forms.ListView()
        Me.gpoContratosFirmados = New System.Windows.Forms.GroupBox()
        Me.lvContratosFirmados = New System.Windows.Forms.ListView()
        Me.grboxVigencia = New System.Windows.Forms.GroupBox()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaini = New System.Windows.Forms.DateTimePicker()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.lblIni = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdContratosFirmados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvContratosFirmados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoRespuestaPropuesta.SuspendLayout()
        Me.gpoContratos.SuspendLayout()
        Me.gpoContratosFirmados.SuspendLayout()
        Me.grboxVigencia.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus.Location = New System.Drawing.Point(182, 8)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(248, 22)
        Me.lblStatus.TabIndex = 12
        Me.lblStatus.Visible = False
        '
        'lblColorStatus
        '
        Me.lblColorStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblColorStatus.Location = New System.Drawing.Point(136, 8)
        Me.lblColorStatus.Name = "lblColorStatus"
        Me.lblColorStatus.Size = New System.Drawing.Size(40, 22)
        Me.lblColorStatus.TabIndex = 13
        Me.lblColorStatus.Visible = False
        '
        'lblFolio
        '
        Me.lblFolio.AutoSize = True
        Me.lblFolio.Location = New System.Drawing.Point(12, 12)
        Me.lblFolio.Name = "lblFolio"
        Me.lblFolio.Size = New System.Drawing.Size(35, 14)
        Me.lblFolio.TabIndex = 10
        Me.lblFolio.Text = "Folio:"
        '
        'ATXFolio
        '
        Me.ATXFolio.BlancoEsValorInvalido = True
        Me.ATXFolio.CadenaDescripcionNoValida = "Codigo no existe"
        Me.ATXFolio.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ATXFolio.CatalogoBase = Nothing
        Me.ATXFolio.CatalogoPrincipal = False
        Me.ATXFolio.ColorDesactivado = System.Drawing.Color.Empty
        Me.ATXFolio.ControlDestinoDescripcion = Nothing
        Me.ATXFolio.DescripcionElementoInvalido = "Codigo no existe"
        Me.ATXFolio.EnPantalla = False
        Me.ATXFolio.FiltroExtendido = ""
        Me.ATXFolio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ATXFolio.LanzarMensajeError = False
        Me.ATXFolio.Location = New System.Drawing.Point(53, 8)
        Me.ATXFolio.Multiple = False
        Me.ATXFolio.Name = "ATXFolio"
        Me.ATXFolio.PermiteAvanceElementoInvalido = True
        Me.ATXFolio.PermiteAyudaRapida = True
        Me.ATXFolio.PermiteSoloCapturarAlfanumericos = False
        Me.ATXFolio.Size = New System.Drawing.Size(77, 22)
        Me.ATXFolio.TabIndex = 0
        Me.ATXFolio.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.ATXFolio.TituloMensaje = "Sistema Integral Panama"
        Me.ATXFolio.ValorValido = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtFolioSeguimiento)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblClasificacion)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblNomBeneficiario)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblNomSolicitante)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblNomDepto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(767, 133)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'txtFolioSeguimiento
        '
        Me.txtFolioSeguimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.txtFolioSeguimiento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtFolioSeguimiento.Location = New System.Drawing.Point(102, 104)
        Me.txtFolioSeguimiento.Name = "txtFolioSeguimiento"
        Me.txtFolioSeguimiento.ReadOnly = True
        Me.txtFolioSeguimiento.Size = New System.Drawing.Size(542, 22)
        Me.txtFolioSeguimiento.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 14)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Seguimiento:"
        '
        'lblClasificacion
        '
        Me.lblClasificacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblClasificacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClasificacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblClasificacion.Location = New System.Drawing.Point(102, 74)
        Me.lblClasificacion.Name = "lblClasificacion"
        Me.lblClasificacion.Size = New System.Drawing.Size(542, 22)
        Me.lblClasificacion.TabIndex = 6
        Me.lblClasificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 14)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Clasificación:"
        '
        'lblNomBeneficiario
        '
        Me.lblNomBeneficiario.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblNomBeneficiario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNomBeneficiario.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblNomBeneficiario.Location = New System.Drawing.Point(102, 44)
        Me.lblNomBeneficiario.Name = "lblNomBeneficiario"
        Me.lblNomBeneficiario.Size = New System.Drawing.Size(313, 22)
        Me.lblNomBeneficiario.TabIndex = 6
        Me.lblNomBeneficiario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 14)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Beneficiario:"
        '
        'lblNomSolicitante
        '
        Me.lblNomSolicitante.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblNomSolicitante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNomSolicitante.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblNomSolicitante.Location = New System.Drawing.Point(102, 14)
        Me.lblNomSolicitante.Name = "lblNomSolicitante"
        Me.lblNomSolicitante.Size = New System.Drawing.Size(313, 22)
        Me.lblNomSolicitante.TabIndex = 6
        Me.lblNomSolicitante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 14)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Solicitante:"
        '
        'lblNomDepto
        '
        Me.lblNomDepto.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblNomDepto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNomDepto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblNomDepto.Location = New System.Drawing.Point(517, 14)
        Me.lblNomDepto.Name = "lblNomDepto"
        Me.lblNomDepto.Size = New System.Drawing.Size(244, 52)
        Me.lblNomDepto.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(421, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Departamento:"
        '
        'grdDocumentos
        '
        Me.grdDocumentos.Location = New System.Drawing.Point(15, 186)
        Me.grdDocumentos.MainView = Me.grvDocumentos
        Me.grdDocumentos.Name = "grdDocumentos"
        Me.grdDocumentos.Size = New System.Drawing.Size(511, 142)
        Me.grdDocumentos.TabIndex = 22
        Me.grdDocumentos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDocumentos})
        Me.grdDocumentos.Visible = False
        '
        'grvDocumentos
        '
        Me.grvDocumentos.GridControl = Me.grdDocumentos
        Me.grvDocumentos.Name = "grvDocumentos"
        Me.grvDocumentos.OptionsView.ShowGroupPanel = False
        '
        'ofdArchivo
        '
        Me.ofdArchivo.FileName = "OpenFileDialog1"
        Me.ofdArchivo.Filter = "Documento PDF|*.pdf"
        '
        'grdContratosFirmados
        '
        Me.grdContratosFirmados.Location = New System.Drawing.Point(15, 347)
        Me.grdContratosFirmados.MainView = Me.grvContratosFirmados
        Me.grdContratosFirmados.Name = "grdContratosFirmados"
        Me.grdContratosFirmados.Size = New System.Drawing.Size(511, 133)
        Me.grdContratosFirmados.TabIndex = 41
        Me.grdContratosFirmados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvContratosFirmados})
        Me.grdContratosFirmados.Visible = False
        '
        'grvContratosFirmados
        '
        Me.grvContratosFirmados.GridControl = Me.grdContratosFirmados
        Me.grvContratosFirmados.Name = "grvContratosFirmados"
        Me.grvContratosFirmados.OptionsView.ShowGroupPanel = False
        '
        'ilIconos
        '
        Me.ilIconos.ImageStream = CType(resources.GetObject("ilIconos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilIconos.TransparentColor = System.Drawing.Color.Transparent
        Me.ilIconos.Images.SetKeyName(0, "pdf-48.ico")
        Me.ilIconos.Images.SetKeyName(1, "picture-2-48.ico")
        Me.ilIconos.Images.SetKeyName(2, "microsoft-word-48.ico")
        Me.ilIconos.Images.SetKeyName(3, "start-48.ico")
        Me.ilIconos.Images.SetKeyName(4, "warning-4-48.ico")
        '
        'btnAñadeLiberaPropuesta
        '
        Me.btnAñadeLiberaPropuesta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAñadeLiberaPropuesta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnAñadeLiberaPropuesta.Image = CType(resources.GetObject("btnAñadeLiberaPropuesta.Image"), System.Drawing.Image)
        Me.btnAñadeLiberaPropuesta.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAñadeLiberaPropuesta.Location = New System.Drawing.Point(532, 186)
        Me.btnAñadeLiberaPropuesta.Name = "btnAñadeLiberaPropuesta"
        Me.btnAñadeLiberaPropuesta.Size = New System.Drawing.Size(127, 97)
        Me.btnAñadeLiberaPropuesta.TabIndex = 44
        Me.btnAñadeLiberaPropuesta.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAñadeLiberaPropuesta.UseVisualStyleBackColor = True
        Me.btnAñadeLiberaPropuesta.Visible = False
        '
        'gpoRespuestaPropuesta
        '
        Me.gpoRespuestaPropuesta.Controls.Add(Me.lblRutaDetallePropuesta)
        Me.gpoRespuestaPropuesta.Controls.Add(Me.btnAdjuntarMasDetalle)
        Me.gpoRespuestaPropuesta.Controls.Add(Me.Label2)
        Me.gpoRespuestaPropuesta.Controls.Add(Me.ATXObservacion)
        Me.gpoRespuestaPropuesta.Controls.Add(Me.optRechazar)
        Me.gpoRespuestaPropuesta.Controls.Add(Me.optAceptar)
        Me.gpoRespuestaPropuesta.Location = New System.Drawing.Point(15, 507)
        Me.gpoRespuestaPropuesta.Name = "gpoRespuestaPropuesta"
        Me.gpoRespuestaPropuesta.Size = New System.Drawing.Size(511, 168)
        Me.gpoRespuestaPropuesta.TabIndex = 1
        Me.gpoRespuestaPropuesta.TabStop = False
        Me.gpoRespuestaPropuesta.Text = "Aceptar / Rechazar Propuesta"
        Me.gpoRespuestaPropuesta.Visible = False
        '
        'lblRutaDetallePropuesta
        '
        Me.lblRutaDetallePropuesta.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblRutaDetallePropuesta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRutaDetallePropuesta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblRutaDetallePropuesta.Location = New System.Drawing.Point(3, 132)
        Me.lblRutaDetallePropuesta.Name = "lblRutaDetallePropuesta"
        Me.lblRutaDetallePropuesta.Size = New System.Drawing.Size(505, 22)
        Me.lblRutaDetallePropuesta.TabIndex = 55
        '
        'btnAdjuntarMasDetalle
        '
        Me.btnAdjuntarMasDetalle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdjuntarMasDetalle.Location = New System.Drawing.Point(226, 106)
        Me.btnAdjuntarMasDetalle.Name = "btnAdjuntarMasDetalle"
        Me.btnAdjuntarMasDetalle.Size = New System.Drawing.Size(45, 23)
        Me.btnAdjuntarMasDetalle.TabIndex = 4
        Me.btnAdjuntarMasDetalle.Text = "..."
        Me.btnAdjuntarMasDetalle.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Adjuntar mas detalle a la propuesta:"
        '
        'ATXObservacion
        '
        Me.ATXObservacion.BlancoEsValorInvalido = True
        Me.ATXObservacion.CadenaDescripcionNoValida = "Codigo no existe"
        Me.ATXObservacion.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ATXObservacion.CatalogoBase = Nothing
        Me.ATXObservacion.CatalogoPrincipal = False
        Me.ATXObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ATXObservacion.ColorDesactivado = System.Drawing.Color.Empty
        Me.ATXObservacion.ControlDestinoDescripcion = Nothing
        Me.ATXObservacion.DescripcionElementoInvalido = "Codigo no existe"
        Me.ATXObservacion.EnPantalla = False
        Me.ATXObservacion.FiltroExtendido = ""
        Me.ATXObservacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ATXObservacion.LanzarMensajeError = False
        Me.ATXObservacion.Location = New System.Drawing.Point(3, 46)
        Me.ATXObservacion.Multiline = True
        Me.ATXObservacion.Multiple = False
        Me.ATXObservacion.Name = "ATXObservacion"
        Me.ATXObservacion.PermiteAvanceElementoInvalido = True
        Me.ATXObservacion.PermiteAyudaRapida = True
        Me.ATXObservacion.PermiteSoloCapturarAlfanumericos = True
        Me.ATXObservacion.Size = New System.Drawing.Size(505, 52)
        Me.ATXObservacion.TabIndex = 2
        Me.ATXObservacion.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.ATXObservacion.TituloMensaje = "Sistema Integral Panama"
        Me.ATXObservacion.ValorValido = False
        '
        'optRechazar
        '
        Me.optRechazar.AutoSize = True
        Me.optRechazar.Checked = True
        Me.optRechazar.Location = New System.Drawing.Point(102, 22)
        Me.optRechazar.Name = "optRechazar"
        Me.optRechazar.Size = New System.Drawing.Size(73, 18)
        Me.optRechazar.TabIndex = 1
        Me.optRechazar.TabStop = True
        Me.optRechazar.Text = "Rechazar"
        Me.optRechazar.UseVisualStyleBackColor = True
        '
        'optAceptar
        '
        Me.optAceptar.AutoSize = True
        Me.optAceptar.Location = New System.Drawing.Point(29, 22)
        Me.optAceptar.Name = "optAceptar"
        Me.optAceptar.Size = New System.Drawing.Size(68, 18)
        Me.optAceptar.TabIndex = 0
        Me.optAceptar.Text = "Aceptar"
        Me.optAceptar.UseVisualStyleBackColor = True
        '
        'gpoContratos
        '
        Me.gpoContratos.Controls.Add(Me.lvContratos)
        Me.gpoContratos.Location = New System.Drawing.Point(15, 175)
        Me.gpoContratos.Name = "gpoContratos"
        Me.gpoContratos.Size = New System.Drawing.Size(511, 160)
        Me.gpoContratos.TabIndex = 45
        Me.gpoContratos.TabStop = False
        Me.gpoContratos.Text = "Contratos"
        '
        'lvContratos
        '
        Me.lvContratos.HideSelection = False
        Me.lvContratos.LargeImageList = Me.ilIconos
        Me.lvContratos.Location = New System.Drawing.Point(6, 17)
        Me.lvContratos.Name = "lvContratos"
        Me.lvContratos.Size = New System.Drawing.Size(499, 133)
        Me.lvContratos.SmallImageList = Me.ilIconos
        Me.lvContratos.TabIndex = 43
        Me.lvContratos.UseCompatibleStateImageBehavior = False
        '
        'gpoContratosFirmados
        '
        Me.gpoContratosFirmados.Controls.Add(Me.lvContratosFirmados)
        Me.gpoContratosFirmados.Location = New System.Drawing.Point(15, 341)
        Me.gpoContratosFirmados.Name = "gpoContratosFirmados"
        Me.gpoContratosFirmados.Size = New System.Drawing.Size(511, 160)
        Me.gpoContratosFirmados.TabIndex = 46
        Me.gpoContratosFirmados.TabStop = False
        Me.gpoContratosFirmados.Text = "Contratos Firmados"
        Me.gpoContratosFirmados.Visible = False
        '
        'lvContratosFirmados
        '
        Me.lvContratosFirmados.HideSelection = False
        Me.lvContratosFirmados.LargeImageList = Me.ilIconos
        Me.lvContratosFirmados.Location = New System.Drawing.Point(6, 17)
        Me.lvContratosFirmados.Name = "lvContratosFirmados"
        Me.lvContratosFirmados.Size = New System.Drawing.Size(499, 133)
        Me.lvContratosFirmados.SmallImageList = Me.ilIconos
        Me.lvContratosFirmados.TabIndex = 44
        Me.lvContratosFirmados.UseCompatibleStateImageBehavior = False
        Me.lvContratosFirmados.Visible = False
        '
        'grboxVigencia
        '
        Me.grboxVigencia.Controls.Add(Me.dtpFechaFin)
        Me.grboxVigencia.Controls.Add(Me.dtpFechaini)
        Me.grboxVigencia.Controls.Add(Me.lblFinal)
        Me.grboxVigencia.Controls.Add(Me.lblIni)
        Me.grboxVigencia.Location = New System.Drawing.Point(788, 36)
        Me.grboxVigencia.Name = "grboxVigencia"
        Me.grboxVigencia.Size = New System.Drawing.Size(190, 133)
        Me.grboxVigencia.TabIndex = 48
        Me.grboxVigencia.TabStop = False
        Me.grboxVigencia.Text = "Vigencia"
        Me.grboxVigencia.Visible = False
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaFin.Location = New System.Drawing.Point(60, 81)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(89, 22)
        Me.dtpFechaFin.TabIndex = 1
        '
        'dtpFechaini
        '
        Me.dtpFechaini.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaini.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpFechaini.Location = New System.Drawing.Point(60, 27)
        Me.dtpFechaini.Name = "dtpFechaini"
        Me.dtpFechaini.Size = New System.Drawing.Size(89, 22)
        Me.dtpFechaini.TabIndex = 0
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Location = New System.Drawing.Point(28, 85)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(26, 14)
        Me.lblFinal.TabIndex = 18
        Me.lblFinal.Text = "Fin:"
        '
        'lblIni
        '
        Me.lblIni.AutoSize = True
        Me.lblIni.Location = New System.Drawing.Point(15, 31)
        Me.lblIni.Name = "lblIni"
        Me.lblIni.Size = New System.Drawing.Size(39, 14)
        Me.lblIni.TabIndex = 17
        Me.lblIni.Text = "Inicio:"
        '
        'FrmM2702005
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 732)
        Me.Controls.Add(Me.grboxVigencia)
        Me.Controls.Add(Me.gpoContratosFirmados)
        Me.Controls.Add(Me.gpoContratos)
        Me.Controls.Add(Me.gpoRespuestaPropuesta)
        Me.Controls.Add(Me.btnAñadeLiberaPropuesta)
        Me.Controls.Add(Me.grdContratosFirmados)
        Me.Controls.Add(Me.grdDocumentos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblColorStatus)
        Me.Controls.Add(Me.lblFolio)
        Me.Controls.Add(Me.ATXFolio)
        Me.Name = "FrmM2702005"
        Me.ReferenciaRapidaVisible = True
        Me.Text = "Generación de Contrato"
        Me.Controls.SetChildIndex(Me.ATXFolio, 0)
        Me.Controls.SetChildIndex(Me.lblFolio, 0)
        Me.Controls.SetChildIndex(Me.lblColorStatus, 0)
        Me.Controls.SetChildIndex(Me.lblStatus, 0)
        Me.Controls.SetChildIndex(Me.lblToolTip, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.grdDocumentos, 0)
        Me.Controls.SetChildIndex(Me.grdContratosFirmados, 0)
        Me.Controls.SetChildIndex(Me.btnAñadeLiberaPropuesta, 0)
        Me.Controls.SetChildIndex(Me.gpoRespuestaPropuesta, 0)
        Me.Controls.SetChildIndex(Me.gpoContratos, 0)
        Me.Controls.SetChildIndex(Me.gpoContratosFirmados, 0)
        Me.Controls.SetChildIndex(Me.grboxVigencia, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdContratosFirmados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvContratosFirmados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoRespuestaPropuesta.ResumeLayout(False)
        Me.gpoRespuestaPropuesta.PerformLayout()
        Me.gpoContratos.ResumeLayout(False)
        Me.gpoContratosFirmados.ResumeLayout(False)
        Me.grboxVigencia.ResumeLayout(False)
        Me.grboxVigencia.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStatus As Label
    Friend WithEvents lblColorStatus As Label
    Friend WithEvents lblFolio As Label
    Friend WithEvents ATXFolio As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblClasificacion As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblNomBeneficiario As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblNomSolicitante As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNomDepto As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents grdDocumentos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDocumentos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ofdArchivo As OpenFileDialog

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        gnPantalla = EN_Pantallas.GeneraVersion
    End Sub
    Friend WithEvents grdContratosFirmados As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvContratosFirmados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ilIconos As ImageList
    Friend WithEvents btnAñadeLiberaPropuesta As Button
    Friend WithEvents gpoRespuestaPropuesta As GroupBox
    Friend WithEvents ATXObservacion As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents optRechazar As RadioButton
    Friend WithEvents optAceptar As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents gpoContratos As GroupBox
    Friend WithEvents lvContratos As ListView
    Friend WithEvents gpoContratosFirmados As GroupBox
    Friend WithEvents lvContratosFirmados As ListView
    Friend WithEvents txtFolioSeguimiento As TextBox
    Friend WithEvents grboxVigencia As GroupBox
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents dtpFechaini As DateTimePicker
    Friend WithEvents lblFinal As Label
    Friend WithEvents lblIni As Label
    Friend WithEvents btnAdjuntarMasDetalle As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblRutaDetallePropuesta As Label
End Class
