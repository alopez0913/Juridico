<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmM2702002_Clasifica
    Inherits System.Windows.Forms.Form

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
        Me.gpoClasificacion = New System.Windows.Forms.GroupBox()
        Me.btnAceptarClasificacion = New System.Windows.Forms.Button()
        Me.lblNombreClasificacion = New System.Windows.Forms.Label()
        Me.lblClasificacion = New System.Windows.Forms.Label()
        Me.ATXClasificacion = New ADSUM.AdsumTextBoxAdvanced()
        Me.gpoClasificacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpoClasificacion
        '
        Me.gpoClasificacion.BackColor = System.Drawing.Color.Silver
        Me.gpoClasificacion.Controls.Add(Me.btnAceptarClasificacion)
        Me.gpoClasificacion.Controls.Add(Me.lblNombreClasificacion)
        Me.gpoClasificacion.Controls.Add(Me.lblClasificacion)
        Me.gpoClasificacion.Controls.Add(Me.ATXClasificacion)
        Me.gpoClasificacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpoClasificacion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gpoClasificacion.Location = New System.Drawing.Point(0, 0)
        Me.gpoClasificacion.Name = "gpoClasificacion"
        Me.gpoClasificacion.Size = New System.Drawing.Size(690, 115)
        Me.gpoClasificacion.TabIndex = 8
        Me.gpoClasificacion.TabStop = False
        Me.gpoClasificacion.Text = "Clasificación"
        '
        'btnAceptarClasificacion
        '
        Me.btnAceptarClasificacion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarClasificacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAceptarClasificacion.Location = New System.Drawing.Point(313, 73)
        Me.btnAceptarClasificacion.Name = "btnAceptarClasificacion"
        Me.btnAceptarClasificacion.Size = New System.Drawing.Size(65, 30)
        Me.btnAceptarClasificacion.TabIndex = 49
        Me.btnAceptarClasificacion.Text = "Aceptar"
        Me.btnAceptarClasificacion.UseVisualStyleBackColor = True
        '
        'lblNombreClasificacion
        '
        Me.lblNombreClasificacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblNombreClasificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNombreClasificacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblNombreClasificacion.Location = New System.Drawing.Point(177, 39)
        Me.lblNombreClasificacion.Name = "lblNombreClasificacion"
        Me.lblNombreClasificacion.Size = New System.Drawing.Size(501, 22)
        Me.lblNombreClasificacion.TabIndex = 47
        Me.lblNombreClasificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblClasificacion
        '
        Me.lblClasificacion.AutoSize = True
        Me.lblClasificacion.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblClasificacion.Location = New System.Drawing.Point(25, 43)
        Me.lblClasificacion.Name = "lblClasificacion"
        Me.lblClasificacion.Size = New System.Drawing.Size(48, 14)
        Me.lblClasificacion.TabIndex = 26
        Me.lblClasificacion.Text = "Código:"
        '
        'ATXClasificacion
        '
        Me.ATXClasificacion.BlancoEsValorInvalido = True
        Me.ATXClasificacion.CadenaDescripcionNoValida = "Codigo no existe"
        Me.ATXClasificacion.CaracterValorNuevo = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ATXClasificacion.CatalogoBase = Nothing
        Me.ATXClasificacion.CatalogoPrincipal = False
        Me.ATXClasificacion.ColorDesactivado = System.Drawing.Color.Empty
        Me.ATXClasificacion.ControlDestinoDescripcion = Nothing
        Me.ATXClasificacion.DescripcionElementoInvalido = "Codigo no existe"
        Me.ATXClasificacion.EnPantalla = False
        Me.ATXClasificacion.FiltroExtendido = ""
        Me.ATXClasificacion.LanzarMensajeError = False
        Me.ATXClasificacion.Location = New System.Drawing.Point(85, 39)
        Me.ATXClasificacion.MaxLength = 6
        Me.ATXClasificacion.Multiple = False
        Me.ATXClasificacion.Name = "ATXClasificacion"
        Me.ATXClasificacion.PermiteAvanceElementoInvalido = True
        Me.ATXClasificacion.PermiteAyudaRapida = True
        Me.ATXClasificacion.PermiteSoloCapturarAlfanumericos = False
        Me.ATXClasificacion.Size = New System.Drawing.Size(86, 22)
        Me.ATXClasificacion.TabIndex = 0
        Me.ATXClasificacion.TeclaAyuda = System.Windows.Forms.Keys.F1
        Me.ATXClasificacion.TituloMensaje = "Sistema de Juridico"
        Me.ATXClasificacion.ValorValido = False
        '
        'FrmM2702002_Clasifica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 115)
        Me.Controls.Add(Me.gpoClasificacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FrmM2702002_Clasifica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clasificación"
        Me.gpoClasificacion.ResumeLayout(False)
        Me.gpoClasificacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpoClasificacion As GroupBox
    Friend WithEvents btnAceptarClasificacion As Button
    Friend WithEvents lblNombreClasificacion As Label
    Friend WithEvents lblClasificacion As Label
    Friend WithEvents ATXClasificacion As ADSUM.AdsumTextBoxAdvanced
End Class
