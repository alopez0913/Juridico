<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVisualizarArchivos
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
        Me.components = New System.ComponentModel.Container()
        Me.wbrVisualizador = New System.Windows.Forms.WebBrowser()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.pdfvPDF = New DevExpress.XtraPdfViewer.PdfViewer()
        Me.SuspendLayout()
        '
        'wbrVisualizador
        '
        Me.wbrVisualizador.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wbrVisualizador.Location = New System.Drawing.Point(1, 1)
        Me.wbrVisualizador.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbrVisualizador.Name = "wbrVisualizador"
        Me.wbrVisualizador.Size = New System.Drawing.Size(1145, 669)
        Me.wbrVisualizador.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Location = New System.Drawing.Point(1061, 676)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportar.Location = New System.Drawing.Point(980, 676)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(75, 23)
        Me.btnExportar.TabIndex = 2
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'pdfvPDF
        '
        Me.pdfvPDF.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pdfvPDF.Location = New System.Drawing.Point(1, 1)
        Me.pdfvPDF.Name = "pdfvPDF"
        Me.pdfvPDF.Size = New System.Drawing.Size(1145, 669)
        Me.pdfvPDF.TabIndex = 3
        '
        'FrmVisualizarArchivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(1148, 706)
        Me.Controls.Add(Me.pdfvPDF)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.wbrVisualizador)
        Me.MinimizeBox = False
        Me.Name = "FrmVisualizarArchivos"
        Me.Text = "Visualizador de Documentos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents wbrVisualizador As Windows.Forms.WebBrowser
    Friend WithEvents btnCerrar As Windows.Forms.Button
    Friend WithEvents btnExportar As Windows.Forms.Button
    Friend WithEvents pdfvPDF As DevExpress.XtraPdfViewer.PdfViewer
End Class
