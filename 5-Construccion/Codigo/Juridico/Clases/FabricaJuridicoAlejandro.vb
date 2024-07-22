Imports QNGuarda
Imports ADSUM
Imports Tools.Comun.Tools

Namespace Dominio
    Partial Public Class FabricaJuridico
        Inherits Fabrica

        Public Shared Function FcObtieneGrupos(ByRef CodGrupo As Int32) As DataTable
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim dts As New DataTable

            Try
                ADDA.RegresaConsultaSQL(String.Format("SP_ObtieneGruposJuridico {0}", CodGrupo), dts)
                If dts.Rows.Count = 0 Then
                    Return Nothing
                Else
                    Return dts
                End If
            Catch ex As Exception
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)
                Return Nothing
            End Try
        End Function
        Public Shared Function FcObtieneActos(ByRef CodActo As Int32) As DataTable
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim dts As New DataTable

            Try
                ADDA.RegresaConsultaSQL(String.Format("SP_ObtieneActosJuridico {0}", CodActo), dts)
                If dts.Rows.Count = 0 Then
                    Return Nothing
                Else
                    Return dts
                End If
            Catch ex As Exception
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)
                Return Nothing
            End Try
        End Function
        Public Shared Function FcObtieneTodosLosGrupos() As DataTable
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim dts As New DataTable

            Try
                ADDA.RegresaConsultaSQL(String.Format("SP_ObtieneTodosLosGruposJuridico"), dts)
                If dts.Rows.Count = 0 Then
                    Return Nothing
                Else
                    Return dts
                End If
            Catch ex As Exception
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)
                Return Nothing
            End Try
        End Function
        Public Shared Function FcObtieneTodosLosActos() As DataTable
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim dts As New DataTable

            Try
                ADDA.RegresaConsultaSQL(String.Format("SP_ObtieneTodosLosActosJuridico"), dts)
                If dts.Rows.Count = 0 Then
                    Return Nothing
                Else
                    Return dts
                End If
            Catch ex As Exception
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)
                Return Nothing
            End Try
        End Function
        Public Shared Function FcObtieneSubActos(ByRef CodSubActo As Int32) As DataTable
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim dts As New DataTable

            Try
                ADDA.RegresaConsultaSQL(String.Format("SP_ObtieneSubActosJuridico {0}", CodSubActo), dts)
                If dts.Rows.Count = 0 Then
                    Return Nothing
                Else
                    Return dts
                End If
            Catch ex As Exception
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)
                Return Nothing
            End Try
        End Function
        Public Shared Function FcObtieneActosFiltrados(ByRef CodGrupo As Int32) As DataTable
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim dts As New DataTable

            Try
                ADDA.RegresaConsultaSQL(String.Format("SP_ObtieneActosFiltrados {0}", CodGrupo), dts)
                If dts.Rows.Count = 0 Then
                    Return Nothing
                Else
                    Return dts
                End If
            Catch ex As Exception
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)
                Return Nothing
            End Try
        End Function
        Public Shared Function FcObtieneReqDocumentacion(ByRef IdReq As Int32) As DataTable
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim dts As New DataTable

            Try
                ADDA.RegresaConsultaSQL(String.Format("SP_ObtieneReqDocumentacionJUR {0}", IdReq), dts)
                If dts.Rows.Count = 0 Then
                    Return Nothing
                Else
                    Return dts
                End If
            Catch ex As Exception
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)
                Return Nothing
            End Try
        End Function
        Public Shared Function FcObtieneTipoPersona() As DataTable
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim dts As New DataTable

            Try
                ADDA.RegresaConsultaSQL(String.Format("SP_ObtieneTipoPersonasJUR"), dts)
                If dts.Rows.Count = 0 Then
                    Return Nothing
                Else
                    Return dts
                End If
            Catch ex As Exception
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)
                Return Nothing
            End Try
        End Function
    End Class
End Namespace