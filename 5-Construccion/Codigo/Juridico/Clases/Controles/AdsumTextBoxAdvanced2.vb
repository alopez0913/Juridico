Imports System.Windows.Forms
Imports ADSUM
Imports Tools.Comun.Tools
Imports System.ComponentModel
Imports System.ComponentModel.Design

Namespace Controles
    <DefaultProperty("Valor"), DefaultEvent("CambioElemento")>
    Public Class AdsumTextBoxAdvanced2
        Inherits ADSUM.AdsumTextBoxAdvanced
        Private WithEvents menuContext As New ContextMenuStrip
#Region "Contructores"
        Sub New()
            MyBase.New()
            MyClass.ContextMenuStrip = MyClass.menuContext
            'Me.Columnas = New ColumnaColeccion()
        End Sub
#End Region
#Region "Propiedades"
        <System.ComponentModel.Description("Cantidad de decimales que tendra el numero ingresado.")>
        Public Property Decimales As Integer = 0
        <System.ComponentModel.Description("Sirve para la validación que se realiza al pegar texto que se encuentra en el protapapeles (Ctrl + V o Shiff + Insert) y para validar los caracteres ingresados por teclado.")>
        Public Property TipoValor As TipoDatos = TipoDatos.TEXTO
        <System.ComponentModel.Description("Sirve para formatear el texto ingresado cuando el control pierde el foco." &
                                           " Solo aplica para cuando la propiedad TipoValor es NUMERO.")>
        Public Property DisplayFormat As String = ""
        Public ReadOnly Property Valor As Object
            Get
                If TipoValor = TipoDatos.TEXTO Then
                    Return MyClass.Text
                Else
                    Return MyClass.Text.ValorNumero()
                End If
            End Get
        End Property
        Public ReadOnly Property ValorDecimal As Decimal
            Get
                Return MyClass.Text.ValorNumero()
            End Get
        End Property
        Public ReadOnly Property ValorInteger As Integer
            Get
                Return CInt(MyClass.Text.ValorNumero())
            End Get
        End Property
        Public ReadOnly Property ValorString As String
            Get
                Return MyClass.Text
            End Get
        End Property
        Public Shadows Property Text As String
            Get
                Return MyBase.Text
            End Get
            Set(value As String)
                If MyClass.DisplayFormat <> "" AndAlso MyClass.TipoValor = TipoDatos.NUMERO Then
                    If MyClass.DisplayFormat.Contains("P") Then
                        MyBase.Text = (value.ValorNumero / 100D).ToString(MyClass.DisplayFormat)
                    Else
                        MyBase.Text = value.ValorNumero.ToString(MyClass.DisplayFormat)
                    End If
                Else
                    MyBase.Text = value
                End If
            End Set
        End Property
        'Public Property Columnas As ColumnaColeccion
#End Region
#Region "Eventos"
        Private Sub AdsumTextBoxAdvanced2_CambioElemento(sender As Object, e As SelectedElementArgs) Handles Me.CambioElemento
            If e.Row IsNot Nothing Then

            End If
        End Sub
        Private Sub AdsumTextBoxAdvanced2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
            If (e.Control AndAlso e.KeyCode = Keys.V) OrElse (e.Shift AndAlso e.KeyCode = Keys.Insert) Then
                Dim texto As String = My.Computer.Clipboard.GetText()

                If Me.TipoValor = TipoDatos.TEXTO Then
                    Me.Text &= texto
                    Me.SelectionStart = Me.Text.Length
                    Me.SelectionLength = 0
                Else
                    texto = texto.Trim()

                    If IsNumeric(texto) Then
                        If Me.Decimales = 0 Then
                            Me.Text = CLng(texto)
                        Else
                            Dim decimalesText As Integer = texto.Substring(texto.LastIndexOf("."c) + 1).Length

                            If decimalesText <= Decimales Then
                                Me.Text = CDec(texto)
                            Else
                                Me.Text = texto.Substring(0, texto.Length - (decimalesText - Me.Decimales))
                            End If
                        End If
                    Else
                        MuestraMensaje("Valor no valido", MessageBoxIcon.Exclamation)
                    End If
                End If

                My.Computer.Clipboard.Clear()
            End If
        End Sub
        Private Sub AdsumTextBoxAdvanced2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
            If MyClass.PermiteSoloCapturarAlfanumericos AndAlso MyClass.TipoValor = TipoDatos.NUMERO AndAlso MyClass.Multiple Then
                If Not e.KeyChar = "*"c Then
                    Utilerias.ValidarTeclearSoloNumeros(sender, e, MyClass.Decimales)
                Else
                    If MyClass.Text.LastIndexOf("*"c) > -1 Then
                        e.Handled = True
                    End If
                End If
            ElseIf MyClass.TipoValor = TipoDatos.NUMERO Then
                Utilerias.ValidarTeclearSoloNumeros(sender, e, MyClass.Decimales)
            End If
        End Sub
        Private Sub AdsumTextBoxAdvanced2_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
            If MyClass.TipoValor = TipoDatos.NUMERO AndAlso MyClass.DisplayFormat.Trim() <> "" Then
                If MyClass.DisplayFormat.Contains("P") Then
                    MyBase.Text = (MyClass.ValorDecimal / 100D).ToString(MyClass.DisplayFormat)
                Else
                    MyBase.Text = MyClass.ValorDecimal.ToString(MyClass.DisplayFormat)
                End If
            End If
        End Sub
        Private Sub AdsumTextBoxAdvanced2_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
            If MyClass.TipoValor = TipoDatos.NUMERO AndAlso MyClass.DisplayFormat.Trim() <> "" Then
                MyBase.Text = MyClass.Text.QuitarComasSignos()
            End If
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