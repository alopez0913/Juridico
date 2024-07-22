Public Class FrmBarraProgreso
    Private Sub FrmBarraProgreso_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        CenterToScreen()
        pbrBarra.Refresh()
        Update()
        Refresh()
    End Sub

    Private Sub FrmBarraProgreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class