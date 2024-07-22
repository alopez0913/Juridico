<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmM2702002_CambioFechas
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFechaFinal = New System.Windows.Forms.Label()
        Me.lblFechaInicial = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblClasificacion = New System.Windows.Forms.Label()
        Me.btnAceptarClasificacion = New System.Windows.Forms.Button()
        Me.gpoClasificacion.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpoClasificacion
        '
        Me.gpoClasificacion.BackColor = System.Drawing.Color.Silver
        Me.gpoClasificacion.Controls.Add(Me.GroupBox2)
        Me.gpoClasificacion.Controls.Add(Me.GroupBox1)
        Me.gpoClasificacion.Controls.Add(Me.btnAceptarClasificacion)
        Me.gpoClasificacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpoClasificacion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gpoClasificacion.Location = New System.Drawing.Point(0, 0)
        Me.gpoClasificacion.Name = "gpoClasificacion"
        Me.gpoClasificacion.Size = New System.Drawing.Size(352, 297)
        Me.gpoClasificacion.TabIndex = 0
        Me.gpoClasificacion.TabStop = False
        Me.gpoClasificacion.Text = "Cambio de Fechas"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.dtpFechaFinal)
        Me.GroupBox2.Controls.Add(Me.dtpFechaInicial)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(324, 103)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fecha Nueva"
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(207, 57)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(99, 22)
        Me.dtpFechaFinal.TabIndex = 2
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(20, 57)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(99, 22)
        Me.dtpFechaInicial.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(223, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 14)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Fecha Final"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(33, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 14)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Fecha Inicial"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.lblFechaFinal)
        Me.GroupBox1.Controls.Add(Me.lblFechaInicial)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblClasificacion)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 103)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fecha Original"
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblFechaFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFechaFinal.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblFechaFinal.Location = New System.Drawing.Point(207, 57)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(99, 22)
        Me.lblFechaFinal.TabIndex = 48
        Me.lblFechaFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblFechaInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFechaInicial.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblFechaInicial.Location = New System.Drawing.Point(20, 57)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(99, 22)
        Me.lblFechaInicial.TabIndex = 48
        Me.lblFechaInicial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(223, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 14)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Fecha Final"
        '
        'lblClasificacion
        '
        Me.lblClasificacion.AutoSize = True
        Me.lblClasificacion.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblClasificacion.Location = New System.Drawing.Point(33, 28)
        Me.lblClasificacion.Name = "lblClasificacion"
        Me.lblClasificacion.Size = New System.Drawing.Size(72, 14)
        Me.lblClasificacion.TabIndex = 26
        Me.lblClasificacion.Text = "Fecha Inicial"
        '
        'btnAceptarClasificacion
        '
        Me.btnAceptarClasificacion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarClasificacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAceptarClasificacion.Location = New System.Drawing.Point(144, 259)
        Me.btnAceptarClasificacion.Name = "btnAceptarClasificacion"
        Me.btnAceptarClasificacion.Size = New System.Drawing.Size(65, 30)
        Me.btnAceptarClasificacion.TabIndex = 2
        Me.btnAceptarClasificacion.Text = "Aceptar"
        Me.btnAceptarClasificacion.UseVisualStyleBackColor = True
        '
        'FrmM2702002_CambioFechas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 297)
        Me.Controls.Add(Me.gpoClasificacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FrmM2702002_CambioFechas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cambio de Fechas"
        Me.gpoClasificacion.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpoClasificacion As GroupBox
    Friend WithEvents btnAceptarClasificacion As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblClasificacion As Label
    Friend WithEvents lblFechaFinal As Label
    Friend WithEvents lblFechaInicial As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpFechaFinal As DateTimePicker
    Friend WithEvents dtpFechaInicial As DateTimePicker

    Public Sub New(prmFolio As Integer, prmFechaInicial As Date, prmFechaFinal As Date)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        vlnFolio = prmFolio
        vldFechaInicial = prmFechaInicial
        vldFechaFinal = prmFechaFinal
    End Sub
End Class
