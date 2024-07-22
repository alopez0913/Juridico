<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmM2702003
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
        Me.grdDocumentos = New DevExpress.XtraGrid.GridControl()
        Me.grvDocumentos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblVigencia = New System.Windows.Forms.Label()
        Me.gpoEspecificaciones = New System.Windows.Forms.GroupBox()
        Me.atxEspecificaciones = New Juridico.Controles.AdsumTextBoxAdvanced2()
        Me.btnCerrarEspecificaciones = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.grdArchivos = New DevExpress.XtraGrid.GridControl()
        Me.grvArchivos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblColorStatus = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFecSol = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRFC = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEspecificaciones = New System.Windows.Forms.Button()
        Me.lblClasificacion = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblNomBeneficiario = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblNomSolicitante = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNomDepto = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFolio = New System.Windows.Forms.Label()
        Me.ATXFolio = New ADSUM.AdsumTextBoxAdvanced()
        Me.ofdArchivo = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.atxAsignado = New ADSUM.AdsumTextBoxAdvanced()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.grdDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoEspecificaciones.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdArchivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvArchivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdDocumentos
        '
        Me.grdDocumentos.Location = New System.Drawing.Point(3, 45)
        Me.grdDocumentos.MainView = Me.grvDocumentos
        Me.grdDocumentos.Name = "grdDocumentos"
        Me.grdDocumentos.Size = New System.Drawing.Size(761, 221)
        Me.grdDocumentos.TabIndex = 0
        Me.grdDocumentos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDocumentos})
        '
        'grvDocumentos
        '
        Me.grvDocumentos.GridControl = Me.grdDocumentos
        Me.grvDocumentos.Name = "grvDocumentos"
        Me.grvDocumentos.OptionsView.ShowGroupPanel = False
        '
        'lblVigencia
        '
        Me.lblVigencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblVigencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVigencia.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVigencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblVigencia.Location = New System.Drawing.Point(436, 8)
        Me.lblVigencia.Name = "lblVigencia"
        Me.lblVigencia.Size = New System.Drawing.Size(346, 22)
        Me.lblVigencia.TabIndex = 56
        Me.lblVigencia.Text = "Vigencia"
        Me.lblVigencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gpoEspecificaciones
        '
        Me.gpoEspecificaciones.BackColor = System.Drawing.Color.DarkGray
        Me.gpoEspecificaciones.Controls.Add(Me.atxEspecificaciones)
        Me.gpoEspecificaciones.Controls.Add(Me.btnCerrarEspecificaciones)
        Me.gpoEspecificaciones.Location = New System.Drawing.Point(146, 293)
        Me.gpoEspecificaciones.Name = "gpoEspecificaciones"
        Me.gpoEspecificaciones.Size = New System.Drawing.Size(625, 149)
        Me.gpoEspecificaciones.TabIndex = 38
        Me.gpoEspecificaciones.TabStop = False
        Me.gpoEspecificaciones.Text = "Especificaciones"
        Me.gpoEspecificaciones.Visible = False
        '
        'atxEspecificaciones
        '
        Me.atxEspecificaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.atxEspecificaciones.BlancoEsValorInvalido = True
        Me.atxEspecificaciones.CadenaDescripcionNoValida = "Codigo no existe"
        Me.atxEspecificaciones.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.atxEspecificaciones.CatalogoBase = Nothing
        Me.atxEspecificaciones.CatalogoPrincipal = False
        Me.atxEspecificaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.atxEspecificaciones.ColorDesactivado = System.Drawing.Color.Empty
        Me.atxEspecificaciones.ControlDestinoDescripcion = Nothing
        Me.atxEspecificaciones.Decimales = 0
        Me.atxEspecificaciones.DescripcionElementoInvalido = "Codigo no existe"
        Me.atxEspecificaciones.DisplayFormat = ""
        Me.atxEspecificaciones.EnPantalla = False
        Me.atxEspecificaciones.FiltroExtendido = ""
        Me.atxEspecificaciones.ForeColor = System.Drawing.Color.MidnightBlue
        Me.atxEspecificaciones.LanzarMensajeError = False
        Me.atxEspecificaciones.Location = New System.Drawing.Point(6, 21)
        Me.atxEspecificaciones.Multiline = True
        Me.atxEspecificaciones.Multiple = False
        Me.atxEspecificaciones.Name = "atxEspecificaciones"
        Me.atxEspecificaciones.PermiteAvanceElementoInvalido = True
        Me.atxEspecificaciones.PermiteAyudaRapida = True
        Me.atxEspecificaciones.PermiteSoloCapturarAlfanumericos = True
        Me.atxEspecificaciones.ReadOnly = True
        Me.atxEspecificaciones.Size = New System.Drawing.Size(613, 82)
        Me.atxEspecificaciones.TabIndex = 3
        Me.atxEspecificaciones.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.atxEspecificaciones.TipoValor = Juridico.Controles.AdsumTextBoxAdvanced2.TipoDatos.TEXTO
        Me.atxEspecificaciones.TituloMensaje = "Sistema Integral Panama"
        Me.atxEspecificaciones.ValorValido = False
        '
        'btnCerrarEspecificaciones
        '
        Me.btnCerrarEspecificaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnCerrarEspecificaciones.ForeColor = System.Drawing.Color.Black
        Me.btnCerrarEspecificaciones.Location = New System.Drawing.Point(259, 109)
        Me.btnCerrarEspecificaciones.Name = "btnCerrarEspecificaciones"
        Me.btnCerrarEspecificaciones.Size = New System.Drawing.Size(106, 26)
        Me.btnCerrarEspecificaciones.TabIndex = 2
        Me.btnCerrarEspecificaciones.Text = "Cerrar"
        Me.btnCerrarEspecificaciones.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.grdArchivos)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 437)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(764, 160)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Archivos"
        '
        'grdArchivos
        '
        Me.grdArchivos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdArchivos.Location = New System.Drawing.Point(3, 18)
        Me.grdArchivos.MainView = Me.grvArchivos
        Me.grdArchivos.Name = "grdArchivos"
        Me.grdArchivos.Size = New System.Drawing.Size(758, 139)
        Me.grdArchivos.TabIndex = 0
        Me.grdArchivos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvArchivos, Me.GridView1})
        '
        'grvArchivos
        '
        Me.grvArchivos.GridControl = Me.grdArchivos
        Me.grvArchivos.Name = "grvArchivos"
        Me.grvArchivos.OptionsView.ShowGroupPanel = False
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.grdArchivos
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'lblStatus
        '
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus.Location = New System.Drawing.Point(182, 8)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(248, 22)
        Me.lblStatus.TabIndex = 9
        Me.lblStatus.Visible = False
        '
        'lblColorStatus
        '
        Me.lblColorStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblColorStatus.Location = New System.Drawing.Point(136, 8)
        Me.lblColorStatus.Name = "lblColorStatus"
        Me.lblColorStatus.Size = New System.Drawing.Size(40, 22)
        Me.lblColorStatus.TabIndex = 9
        Me.lblColorStatus.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkTodos)
        Me.GroupBox2.Controls.Add(Me.grdDocumentos)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 159)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(767, 272)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Documentos"
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Enabled = False
        Me.chkTodos.Location = New System.Drawing.Point(6, 21)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(112, 18)
        Me.chkTodos.TabIndex = 58
        Me.chkTodos.Text = "Autorizar Todos"
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFecSol)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblRFC)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnEspecificaciones)
        Me.GroupBox1.Controls.Add(Me.lblClasificacion)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblNomBeneficiario)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblNomSolicitante)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblNomDepto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(767, 103)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'lblFecSol
        '
        Me.lblFecSol.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblFecSol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFecSol.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblFecSol.Location = New System.Drawing.Point(669, 45)
        Me.lblFecSol.Name = "lblFecSol"
        Me.lblFecSol.Size = New System.Drawing.Size(92, 20)
        Me.lblFecSol.TabIndex = 56
        Me.lblFecSol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(620, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 14)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Fec. sol:"
        '
        'lblRFC
        '
        Me.lblRFC.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblRFC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRFC.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblRFC.Location = New System.Drawing.Point(508, 44)
        Me.lblRFC.Name = "lblRFC"
        Me.lblRFC.Size = New System.Drawing.Size(107, 22)
        Me.lblRFC.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(480, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 14)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "RFC:"
        '
        'btnEspecificaciones
        '
        Me.btnEspecificaciones.Enabled = False
        Me.btnEspecificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEspecificaciones.Location = New System.Drawing.Point(650, 71)
        Me.btnEspecificaciones.Name = "btnEspecificaciones"
        Me.btnEspecificaciones.Size = New System.Drawing.Size(111, 25)
        Me.btnEspecificaciones.TabIndex = 7
        Me.btnEspecificaciones.Text = "Especificaciones"
        Me.btnEspecificaciones.UseVisualStyleBackColor = True
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
        Me.lblNomDepto.Location = New System.Drawing.Point(508, 14)
        Me.lblNomDepto.Name = "lblNomDepto"
        Me.lblNomDepto.Size = New System.Drawing.Size(253, 22)
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
        'lblFolio
        '
        Me.lblFolio.AutoSize = True
        Me.lblFolio.Location = New System.Drawing.Point(12, 12)
        Me.lblFolio.Name = "lblFolio"
        Me.lblFolio.Size = New System.Drawing.Size(35, 14)
        Me.lblFolio.TabIndex = 5
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
        Me.ATXFolio.LanzarMensajeError = False
        Me.ATXFolio.Location = New System.Drawing.Point(53, 8)
        Me.ATXFolio.MaxLength = 5
        Me.ATXFolio.Multiple = False
        Me.ATXFolio.Name = "ATXFolio"
        Me.ATXFolio.PermiteAvanceElementoInvalido = True
        Me.ATXFolio.PermiteAyudaRapida = True
        Me.ATXFolio.PermiteSoloCapturarAlfanumericos = False
        Me.ATXFolio.Size = New System.Drawing.Size(77, 22)
        Me.ATXFolio.TabIndex = 1
        Me.ATXFolio.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.ATXFolio.TituloMensaje = "Sistema Integral Panama"
        Me.ATXFolio.ValorValido = False
        '
        'ofdArchivo
        '
        Me.ofdArchivo.FileName = "OpenFileDialog1"
        Me.ofdArchivo.Filter = "Imagenes|*.jpg;*.jpeg;*.png|Documento PDF|*.pdf|Todas los archivos PDF e Imagenes" &
    "|*.jpg;*.jpeg;*.png,*.pdf"
        Me.ofdArchivo.Title = "Cargar Documento"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtNombre)
        Me.GroupBox4.Controls.Add(Me.atxAsignado)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 603)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(764, 54)
        Me.GroupBox4.TabIndex = 57
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Asignado a:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(287, 21)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(319, 22)
        Me.txtNombre.TabIndex = 17
        '
        'atxAsignado
        '
        Me.atxAsignado.BlancoEsValorInvalido = True
        Me.atxAsignado.CadenaDescripcionNoValida = "Codigo no existe"
        Me.atxAsignado.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.atxAsignado.CatalogoBase = Nothing
        Me.atxAsignado.CatalogoPrincipal = False
        Me.atxAsignado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.atxAsignado.ColorDesactivado = System.Drawing.Color.Empty
        Me.atxAsignado.ControlDestinoDescripcion = Me.txtNombre
        Me.atxAsignado.DescripcionElementoInvalido = "Codigo no existe"
        Me.atxAsignado.EnPantalla = False
        Me.atxAsignado.FiltroExtendido = ""
        Me.atxAsignado.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atxAsignado.LanzarMensajeError = False
        Me.atxAsignado.Location = New System.Drawing.Point(102, 21)
        Me.atxAsignado.MaxLength = 15
        Me.atxAsignado.Multiple = False
        Me.atxAsignado.Name = "atxAsignado"
        Me.atxAsignado.PermiteAvanceElementoInvalido = True
        Me.atxAsignado.PermiteAyudaRapida = True
        Me.atxAsignado.PermiteSoloCapturarAlfanumericos = True
        Me.atxAsignado.Size = New System.Drawing.Size(114, 22)
        Me.atxAsignado.TabIndex = 15
        Me.atxAsignado.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.atxAsignado.TituloMensaje = "Sistema de Jurídico"
        Me.atxAsignado.ValorValido = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 14)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Usuario:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(227, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 14)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Nombre:"
        '
        'FrmM2702003
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 734)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lblVigencia)
        Me.Controls.Add(Me.gpoEspecificaciones)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblColorStatus)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblFolio)
        Me.Controls.Add(Me.ATXFolio)
        Me.Name = "FrmM2702003"
        Me.ReferenciaRapidaVisible = True
        Me.Text = "Captura de Documentos"
        Me.Controls.SetChildIndex(Me.ATXFolio, 0)
        Me.Controls.SetChildIndex(Me.lblFolio, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.lblColorStatus, 0)
        Me.Controls.SetChildIndex(Me.lblStatus, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.gpoEspecificaciones, 0)
        Me.Controls.SetChildIndex(Me.lblVigencia, 0)
        Me.Controls.SetChildIndex(Me.lblToolTip, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        CType(Me.grdDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoEspecificaciones.ResumeLayout(False)
        Me.gpoEspecificaciones.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.grdArchivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvArchivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents lblClasificacion As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblNomBeneficiario As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblNomSolicitante As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNomDepto As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblFolio As Label
    Friend WithEvents ATXFolio As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents grdDocumentos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDocumentos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblColorStatus As Label
    Friend WithEvents ofdArchivo As OpenFileDialog

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        gnPantalla = EN_Pantallas.CapturaDocumentos
    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents grdArchivos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvArchivos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gpoEspecificaciones As GroupBox
    Friend WithEvents btnCerrarEspecificaciones As Button
    Friend WithEvents lblVigencia As Label
    Friend WithEvents chkTodos As CheckBox
    Friend WithEvents btnEspecificaciones As Button
    Friend WithEvents atxEspecificaciones As Controles.AdsumTextBoxAdvanced2
    Friend WithEvents lblRFC As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFecSol As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents atxAsignado As ADSUM.AdsumTextBoxAdvanced
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
End Class
