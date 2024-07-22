Public Class frmTrabajando
    'Public WithEvents hilo As Threading.Thread

    Public Property Cerrar As Boolean = False
    Dim cerrado As Boolean = False
    Private Sub frmTrabajando_Load(sender As Object, e As EventArgs) Handles Me.Load
        CenterToScreen()
    End Sub

    Public Sub CerrarForma()
        Me.DialogResult = Windows.Forms.DialogResult.Abort
        Cerrar = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Cerrar Then
            If Not cerrado Then Me.Close()
            cerrado = True
            Timer1.Enabled = False
            Timer1.Dispose()
            Exit Sub
        End If
    End Sub

    Private Sub frmTrabajando_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        'If Me.Owner IsNot Nothing Then
        '    Me.Activate()
        '    Me.PictureBox1.Focus()
        'End If
    End Sub
End Class