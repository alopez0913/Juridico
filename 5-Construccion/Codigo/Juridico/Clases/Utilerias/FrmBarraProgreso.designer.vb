Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBarraProgreso
    Inherits System.Windows.Forms.Form

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
        Me.pbrBarra = New System.Windows.Forms.ProgressBar()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pbrBarra
        '
        Me.pbrBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbrBarra.Location = New System.Drawing.Point(0, 0)
        Me.pbrBarra.Name = "pbrBarra"
        Me.pbrBarra.Size = New System.Drawing.Size(572, 42)
        Me.pbrBarra.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbrBarra.TabIndex = 0
        '
        'lblMensaje
        '
        Me.lblMensaje.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMensaje.Location = New System.Drawing.Point(0, 42)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(572, 38)
        Me.lblMensaje.TabIndex = 1
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmBarraProgreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 83)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.pbrBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmBarraProgreso"
        Me.Text = "FrmBarraProgreso"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbrBarra As ProgressBar
    Friend WithEvents lblMensaje As Label
End Class