Imports Tools.Comun.Tools
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls

Namespace Controles
    Public Class RepositoryTextBoxItem
        Inherits DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
#Region "Declaraciones"
        Private WithEvents menuContext As New ContextMenuStrip
#End Region
#Region "Constructores"
        Sub New()
            MyBase.New()
            MyClass.ContextMenuStrip = MyClass.menuContext
        End Sub
        Sub New(decimales As Decimal, tipoValor As TipoDatos)
            MyBase.New()
            MyClass.ContextMenuStrip = MyClass.menuContext

            MyClass.Decimales = decimales
            MyClass.TipoValor = tipoValor
        End Sub
#End Region
#Region "Propiedades"
        <System.ComponentModel.Description("Cantidad de decimales que tendra el numero ingresado.")>
        Public Property Decimales As Integer = 0
        <System.ComponentModel.Description("Sirve para la validación que se realiza al pegar texto que se encuentra en el protapapeles (Ctrl + V o Shiff + Insert) y para validar los caracteres ingresados por teclado.")>
        Public Property TipoValor As TipoDatos = TipoDatos.TEXTO
#End Region
#Region "Eventos"
        Private Sub RepositoryTextBoxItem_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
            If (e.Control AndAlso e.KeyCode = Keys.V) OrElse (e.Shift AndAlso e.KeyCode = Keys.Insert) Then
                Dim texto As String = My.Computer.Clipboard.GetText()
                Dim c As DevExpress.XtraEditors.TextEdit

                c = CType(sender, DevExpress.XtraEditors.TextEdit)

                If Me.TipoValor = TipoDatos.TEXTO Then
                    c.Text &= texto
                    c.SelectionStart = c.Text.Length
                    c.SelectionLength = 0
                Else
                    texto = texto.Trim()

                    If IsNumeric(texto) Then
                        If Me.Decimales = 0 Then
                            c.Text = CLng(texto)
                        Else
                            Dim decimalesText As Integer = texto.Substring(texto.LastIndexOf("."c) + 1).Length

                            If decimalesText <= Decimales Then
                                c.Text = CDec(texto)
                            Else
                                c.Text = texto.Substring(0, texto.Length - (decimalesText - Me.Decimales))
                            End If
                        End If
                    Else
                        MuestraMensaje("Valor no valido", MessageBoxIcon.Exclamation)
                    End If
                End If

                My.Computer.Clipboard.Clear()
            End If
        End Sub
        Private Sub RepositoryTextBoxItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
            If MyClass.TipoValor = TipoDatos.NUMERO Then Utilerias.ValidarTeclearSoloNumeros(sender, e, Me.Decimales)
        End Sub
#End Region
#Region "Tipos Anidados"
        Public Enum TipoDatos
            TEXTO
            NUMERO
        End Enum
#End Region
    End Class
End Namespace