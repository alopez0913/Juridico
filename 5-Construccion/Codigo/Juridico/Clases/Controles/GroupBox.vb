Imports System.Windows
Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO

Namespace Controles
    Public Class GroupBox
        Inherits System.Windows.Forms.GroupBox

        ''' <summary>
        ''' Obtiene o establece el valor del RadioButton seleccionado. 
        ''' Al establecer el valor, el RadioButton con el valor ingresado se selecciona.
        ''' </summary>
        ''' <returns></returns>
        <System.ComponentModel.Description("Valor que representa el RadioButton seleccionado dentro del GroupBox.")>
        Public Property Valor As Object
            Get
                For Each control As System.Windows.Forms.Control In MyClass.Controls
                    If TypeOf control Is RadioButton Then
                        With CType(control, System.Windows.Forms.RadioButton)
                            If .Checked Then
                                Return .Tag
                            End If
                        End With
                    End If
                Next

                Return Nothing
            End Get
            Set(value As Object)
                For Each control As System.Windows.Forms.Control In MyClass.Controls
                    If TypeOf control Is RadioButton Then
                        With CType(control, System.Windows.Forms.RadioButton)
                            If .Tag = value Then
                                .Checked = True
                                Exit For
                            Else
                                .Checked = False
                            End If
                        End With
                    End If
                Next
            End Set
        End Property
    End Class
End Namespace