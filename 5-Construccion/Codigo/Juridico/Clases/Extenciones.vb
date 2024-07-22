Imports System.Runtime.CompilerServices

Module Extenciones
#Region "String"
    <Extension()>
    Public Function ValorNumero(ByVal texto As String) As Decimal
        Dim valor As String

        valor = texto.QuitarComasSignos()

        If IsNumeric(valor) Then
            Return CDec(valor)
        Else
            Return 0D
        End If
    End Function
    <Extension()>
    Public Function NewLine(ByVal texto As String, Optional saltos As Integer = 1) As String
        If texto IsNot Nothing Then
            Return texto.PadRight(texto.Length + saltos, vbNewLine)
        Else
            Return ""
        End If
    End Function
    <Extension()>
    Public Function QuitarComasSignos(ByVal texto As String) As String
        If texto IsNot Nothing Then
            Return texto.Replace("$", "").Replace(",", "").Replace(" ", "").Replace("%", "")
        Else
            Return ""
        End If
    End Function
#End Region
#Region "Decimal"
    <Extension()>
    Public Function GetMyNumberToWords(ByVal pValue As Decimal) As String
        Dim str As String = String.Empty
        Dim value As Decimal

        value = Math.Truncate(pValue)

        Select Case value
            Case 0D : str = “CERO”
            Case 1D
                str = “UNO”
            Case 2D : str = “DOS”
            Case 3D : str = “TRES”
            Case 4D : str = “CUATRO”
            Case 5D : str = “CINCO”
            Case 6D : str = “SEIS”
            Case 7D : str = “SIETE”
            Case 8D : str = “OCHO”
            Case 9D : str = “NUEVE”
            Case 10D : str = “DIEZ”
            Case 11D : str = “ONCE”
            Case 12D : str = “DOCE”
            Case 13D : str = “TRECE”
            Case 14D : str = “CATORCE”
            Case 15D : str = “QUINCE”
            Case Is < 20D : str = “DIECI” & GetMyNumberToWords(value - 10D)
            Case 20D : str = “VEINTE”
            Case Is < 30D
                If value - 20D = 1 Then
                    str = “VEINTIUN”
                Else
                    str = “VEINTI” & GetMyNumberToWords(value - 20D)
                End If
            Case 30D : str = “TREINTA”
            Case 40D : str = “CUARENTA”
            Case 50D : str = “CINCUENTA”
            Case 60D : str = “SESENTA”
            Case 70D : str = “SETENTA”
            Case 80D : str = “OCHENTA”
            Case 90D : str = “NOVENTA”
            Case Is < 100D : str = GetMyNumberToWords(Int(value \ 10D) * 10D) & ” Y ” & GetMyNumberToWords(value Mod 10D)
            Case 100D : str = “CIEN”
            Case Is < 200D
                str = “CIENTO ” & GetMyNumberToWords((value - 100D))
            Case 200D, 300D, 400D, 600D, 800D
                str = GetMyNumberToWords(Int(value \ 100D)) & “CIENTOS”
            Case 500D : str = “QUINIENTOS”
            Case 700D : str = “SETECIENTOS”
            Case 900D : str = “NOVECIENTOS”
            Case Is < 1000D : str = GetMyNumberToWords(Int(value \ 100D) * 100D) & ” ” & GetMyNumberToWords(value Mod 100D)
            Case 1000D : str = “MIL”
            Case Is < 2000D : str = “MIL ” & GetMyNumberToWords(value Mod 1000D)
            Case Is < 1000000D
                str = GetMyNumberToWords(Int(value \ 1000D)) & ” MIL”

                If ((value \ 1000D) Mod 100) = 1 Then
                    str = str.Replace("UNO", "UN")
                End If

                If value Mod 1000D Then
                    If (value Mod 1000D) = 1 Then
                        str = str & ” UNO”
                    Else
                        str = str & ” ” & GetMyNumberToWords(value Mod 1000D)
                    End If
                End If
            Case 1000000D : str = “UN MILLON”
            Case Is < 2000000D : str = “UN MILLON ” & GetMyNumberToWords(value Mod 1000000D)
            Case Is < 1000000000000D
                str = GetMyNumberToWords(Int(value / 1000000D)) & ” MILLONES ”

                If (Math.Truncate(value / 1000000D)) Mod 1000D = 1 Then
                    str = str.Replace("UNO", "UN")
                End If

                If (value - Int(value / 1000000D) * 1000000D) Then
                    str = str & ” ” & GetMyNumberToWords(value - Int(value / 1000000D) * 1000000D)
                End If
            Case 1000000000000D : str = “UN BILLON”
            Case Is < 2000000000000D : str = “UN BILLON ” & GetMyNumberToWords(value - Int(value / 1000000000000D) * 1000000000000D)
            Case Else
                str = GetMyNumberToWords(Int(value / 1000000000000D)) & ” BILLONES”

                If Int(value / 1000000000000D) Mod 100D = 1 Then
                    str = str.Replace("UNO", "UN")
                End If

                If (value - Int(value / 1000000000000D) * 1000000000000D) Then
                    str = str & ” ” & GetMyNumberToWords(value - Int(value / 1000000000000D) * 1000000000000D)
                End If
        End Select

        Return str
    End Function
#End Region
#Region "Boolean"
    <Extension()>
    Public Function ValorBD(valor As Boolean) As Char
        If valor Then
            Return "1"
        Else
            Return "0"
        End If
    End Function
#End Region
#Region "ADDA"
    <Extension()>
    Public Function GetNombreUsuario(pADDA As ADSUM.AsistenteDeDatos_Base) As String
        Return pADDA.RegresaDatoSQL("SELECT LTRIM(RTRIM(cNombre)) AS cNombre FROM dbo.ADSUM_Usuarios WITH (NOLOCK) where cLogin='" & pADDA.GetLoginUsuario() & "'")
    End Function
#End Region
#Region "List(OF T)"
    ''' <summary>
    ''' Esta funcion solo aplica para los tipos de datos siples, Integer, Sort, Long, Decimal, Stringm Byte
    ''' </summary>
    ''' <typeparam name="T">Tipo de datos que contiene la lista</typeparam>
    ''' <param name="lista">Lisa que contiene los datos que se quiere concatenar</param>
    ''' <param name="separador">Por default es ","</param>
    ''' <returns></returns>
    <Extension()>
    Public Function ConcatenarDatos(Of T)(lista As List(Of T), Optional separador As String = ",") As String
        Dim cadena As String = ""

        If lista.Count > 0 Then
            cadena = lista(0).ToString()

            For i As Integer = 1 To lista.Count - 1
                cadena &= separador & lista(i).ToString()
            Next
        End If

        Return cadena
    End Function
    <Extension()>
    Public Function Add2(Of T)(lista As List(Of T), item As T) As T
        lista.Add(item)
        Return item
    End Function
#End Region
End Module