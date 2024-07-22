Imports QNGuarda
Imports ADSUM
Imports Tools.Comun.Tools
Imports System.Data.SqlClient

Namespace Dominio
    Partial Public Class EscribanoJuridico
        Inherits Escribano

        Public Shared Function GuardarGrupos(ByVal obj As Object) As Boolean
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim vcSQL As String = ""
            Try
                If obj(0) = "REGISTRANDO" Then

                    vcSQL = String.Format("SP_GuardaYModificaGruposJur {0},{1},'{2}','{3}'",
                                            1, 0, obj(1), ADDA.GetLoginUsuario)

                    If (ADDA.EjecutaComandoSQL(vcSQL)) Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    'ACTUALIZANDO UN CLIENTE
                    vcSQL = String.Format("SP_GuardaYModificaGruposJur {0},{1},'{2}','{3}'",
                                            2, obj(2), obj(1), ADDA.GetLoginUsuario)

                    If (ADDA.EjecutaComandoSQL(vcSQL)) Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Return False
                Throw ex
            End Try
        End Function

        Public Shared Function GuardarActos(ByVal obj As Object) As Integer
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim vcSQL As String = ""
            Dim myDT As New DataTable
            Try
                GuardarActos = -1
                If obj(1) = "REGISTRANDO" Then

                    vcSQL = String.Format("SP_GuardaYModificaActosJur {0},{1},'{2}',{3},'{4}','{5}'",
                                            1, 0, obj(2), obj(3), obj(4), ADDA.GetLoginUsuario)

                    If (ADDA.RegresaConsultaSQL(vcSQL, myDT)) Then
                        GuardarActos = myDT(0)(0)
                        Utilerias.DestruirObjeto(myDT)
                    End If
                Else
                    'ACTUALIZANDO UN CLIENTE
                    vcSQL = String.Format("SP_GuardaYModificaActosJur {0},{1},'{2}',{3},'{4}','{5}'",
                                            2, obj(0), obj(2), obj(3), obj(4), ADDA.GetLoginUsuario)

                    If (ADDA.RegresaConsultaSQL(vcSQL, myDT)) Then
                        GuardarActos = myDT.Rows(0).Item(0)
                        Utilerias.DestruirObjeto(myDT)
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Shared Function GuardarSubActos(ByVal obj As Object) As Integer
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim vcSQL As String = ""
            Dim myDT As New DataTable
            Try
                GuardarSubActos = -1

                If obj(1) = "REGISTRANDO" Then

                    vcSQL = String.Format("SP_GuardaYModificaSubActosJur {0},{1},'{2}',{3},'{4}'",
                                            1, 0, obj(2), obj(4), ADDA.GetLoginUsuario)

                    If (ADDA.RegresaConsultaSQL(vcSQL, myDT)) Then
                        GuardarSubActos = myDT(0)(0)
                        Utilerias.DestruirObjeto(myDT)
                    End If
                Else
                    'ACTUALIZANDO UN CLIENTE
                    vcSQL = String.Format("SP_GuardaYModificaSubActosJur {0},{1},'{2}',{3},'{4}'",
                                            2, obj(0), obj(2), obj(4), ADDA.GetLoginUsuario)

                    If (ADDA.RegresaConsultaSQL(vcSQL, myDT)) Then
                        GuardarSubActos = myDT(0)(0)
                        Utilerias.DestruirObjeto(myDT)
                    End If
                End If
            Catch ex As Exception
                Return False
                Throw ex
            End Try
        End Function

        Public Shared Function GuardarDocumentoRequerido(ByVal obj As Object) As Integer
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim vcSQL As String = ""
            Dim myDT As New DataTable
            Try
                GuardarDocumentoRequerido = -1

                If obj(1) = "REGISTRANDO" Then

                    vcSQL = String.Format("[PA_JUR_GuardarDocumentoRequerido] {0},{1},'{2}','{3}'",
                                            1, 0, obj(2), ADDA.GetLoginUsuario)

                    If (ADDA.RegresaConsultaSQL(vcSQL, myDT)) Then
                        GuardarDocumentoRequerido = myDT(0)(0)
                        Utilerias.DestruirObjeto(myDT)
                    End If
                Else
                    'ACTUALIZANDO UN CLIENTE
                    vcSQL = String.Format("[PA_JUR_GuardarDocumentoRequerido] {0},{1},'{2}',{3}",
                                            2, obj(0), obj(2), ADDA.GetLoginUsuario)

                    If (ADDA.RegresaConsultaSQL(vcSQL, myDT)) Then
                        GuardarDocumentoRequerido = myDT(0)(0)
                        Utilerias.DestruirObjeto(myDT)
                    End If
                End If
            Catch ex As Exception
                Return False
                Throw ex
            End Try
        End Function


    End Class

End Namespace
