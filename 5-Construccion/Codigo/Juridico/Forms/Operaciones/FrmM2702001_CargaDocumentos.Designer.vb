<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmM2702001_CargaDocumentos
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
        Me.grdDocumentos = New DevExpress.XtraGrid.GridControl()
        Me.grvDocumentos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.gpoComentariosRechazo = New System.Windows.Forms.GroupBox()
        Me.ATXComentarios = New System.Windows.Forms.TextBox()
        Me.BtnCerrarComentario = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.grdArchivos = New DevExpress.XtraGrid.GridControl()
        Me.grvArchivos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblClasificacion = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ofdArchivo = New System.Windows.Forms.OpenFileDialog()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.grdDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.gpoComentariosRechazo.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdArchivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvArchivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdDocumentos
        '
        Me.grdDocumentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDocumentos.Location = New System.Drawing.Point(3, 18)
        Me.grdDocumentos.MainView = Me.grvDocumentos
        Me.grdDocumentos.Name = "grdDocumentos"
        Me.grdDocumentos.Size = New System.Drawing.Size(761, 251)
        Me.grdDocumentos.TabIndex = 0
        Me.grdDocumentos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDocumentos})
        '
        'grvDocumentos
        '
        Me.grvDocumentos.GridControl = Me.grdDocumentos
        Me.grvDocumentos.Name = "grvDocumentos"
        Me.grvDocumentos.OptionsView.ShowGroupPanel = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.gpoComentariosRechazo)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 536)
        Me.Panel1.TabIndex = 2
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(564, 497)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 30)
        Me.btnGuardar.TabIndex = 39
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'gpoComentariosRechazo
        '
        Me.gpoComentariosRechazo.BackColor = System.Drawing.Color.Transparent
        Me.gpoComentariosRechazo.Controls.Add(Me.ATXComentarios)
        Me.gpoComentariosRechazo.Controls.Add(Me.BtnCerrarComentario)
        Me.gpoComentariosRechazo.Location = New System.Drawing.Point(7, 243)
        Me.gpoComentariosRechazo.Name = "gpoComentariosRechazo"
        Me.gpoComentariosRechazo.Size = New System.Drawing.Size(770, 214)
        Me.gpoComentariosRechazo.TabIndex = 38
        Me.gpoComentariosRechazo.TabStop = False
        Me.gpoComentariosRechazo.Text = "Comentarios de Rechazo"
        Me.gpoComentariosRechazo.Visible = False
        '
        'ATXComentarios
        '
        Me.ATXComentarios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ATXComentarios.Location = New System.Drawing.Point(16, 25)
        Me.ATXComentarios.MaxLength = 300
        Me.ATXComentarios.Multiline = True
        Me.ATXComentarios.Name = "ATXComentarios"
        Me.ATXComentarios.Size = New System.Drawing.Size(738, 128)
        Me.ATXComentarios.TabIndex = 14
        Me.ATXComentarios.Tag = "Concepto"
        '
        'BtnCerrarComentario
        '
        Me.BtnCerrarComentario.ForeColor = System.Drawing.Color.Black
        Me.BtnCerrarComentario.Location = New System.Drawing.Point(339, 169)
        Me.BtnCerrarComentario.Name = "BtnCerrarComentario"
        Me.BtnCerrarComentario.Size = New System.Drawing.Size(106, 26)
        Me.BtnCerrarComentario.TabIndex = 2
        Me.BtnCerrarComentario.Text = "Cerrar"
        Me.BtnCerrarComentario.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.grdArchivos)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 331)
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grdDocumentos)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(767, 272)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Documentos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblClasificacion)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(767, 47)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'lblClasificacion
        '
        Me.lblClasificacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblClasificacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClasificacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblClasificacion.Location = New System.Drawing.Point(112, 14)
        Me.lblClasificacion.Name = "lblClasificacion"
        Me.lblClasificacion.Size = New System.Drawing.Size(542, 22)
        Me.lblClasificacion.TabIndex = 6
        Me.lblClasificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 14)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Clasificación:"
        '
        'ofdArchivo
        '
        Me.ofdArchivo.FileName = "OpenFileDialog1"
        Me.ofdArchivo.Filter = "Imagenes|*.jpg;*.jpeg;*.png|Documento PDF|*.pdf|Todas los archivos PDF e Imagenes" &
    "|*.jpg;*.jpeg;*.png,*.pdf"
        Me.ofdArchivo.Title = "Cargar Documento"
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(670, 497)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelar.TabIndex = 39
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'FrmM2702001_CargaDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 569)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmM2702001_CargaDocumentos"
        Me.ReferenciaRapidaVisible = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Captura de Documentos"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.lblToolTip, 0)
        CType(Me.grdDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.gpoComentariosRechazo.ResumeLayout(False)
        Me.gpoComentariosRechazo.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.grdArchivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvArchivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents lblClasificacion As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents grdDocumentos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDocumentos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ofdArchivo As OpenFileDialog
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents grdArchivos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvArchivos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gpoComentariosRechazo As GroupBox
    Friend WithEvents ATXComentarios As TextBox
    Friend WithEvents BtnCerrarComentario As Button

    Public Sub New(IDSubActo As Integer, TipoPersona As Integer, FolioSolicitud As Integer, EsNuevoOReclasifica As Boolean)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        gnIDSubActo = IDSubActo
        gnTipoPersona = TipoPersona
        gnFolioSolicitud = FolioSolicitud
        gbNuevoReclasifica = EsNuevoOReclasifica
    End Sub
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
End Class
