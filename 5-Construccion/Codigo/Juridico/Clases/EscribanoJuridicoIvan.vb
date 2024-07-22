Imports QNGuarda
Imports ADSUM
Imports Tools.Comun.Tools


Namespace Dominio
    Partial Public Class EscribanoJuridico
        Inherits Escribano

#Region "Digitalización de Documentos del Solicitante"
        Public Shared Function GuardarDocumentos(FolioSol As Integer, xml As String) As Boolean
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia

            Try
                If Not ADDA.TieneTransaccionAbierta Then ADDA.AbreTransaccion()

                If Not ADDA.EjecutaComandoSQL(String.Format("EXEC PA_JUR_DoctosDigitalizados_Guardar '{0}','{1}','{2}'",
                                                            FolioSol, xml, ADDA.GetLoginUsuario())) Then
                    If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
                    Return False
                End If

                If ADDA.TieneTransaccionAbierta Then ADDA.CierraTransaccion()

                Return True
            Catch ex As Exception
                If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)

                Return False
            End Try
        End Function

        Public Shared Function GuardarContratos(Objecto() As Object) As Boolean
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim dsDatos As New DataSet

            Try
                If Not ADDA.RegresaConsultaSQL("PA_JUR_ContratosDigitalizados_Guardar", dsDatos, Objecto) Then

                    Return False
                End If

                Return True
            Catch ex As Exception
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)

                Return False
            End Try
        End Function

        Public Shared Function ValidaContratos(Objecto() As Object) As Boolean
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim dsDatos As New DataSet

            Try
                If Not ADDA.RegresaConsultaSQL("PA_JUR_ContratosDigitalizados_Validar", dsDatos, Objecto) Then

                    Return False
                End If

                Return True
            Catch ex As Exception
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)

                Return False
            End Try
        End Function

        Public Shared Function GuardarAutorizacionRequerimientos(IDSolContrato As Integer, Valor As Boolean, Motivo As String, IDReq As Integer) As Boolean
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia

            Try
                If Not ADDA.EjecutaComandoSQL(String.Format("EXEC PA_JUR_DoctosDigitalizados_Autorizar '{0}', '{1}', '{2}', '{3}', '{4}'",
                                                            IDSolContrato, Valor, IDReq, Motivo, ADDA.GetLoginUsuario())) Then
                    Return False
                End If

                Return True
            Catch ex As Exception
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)

                Return False
            End Try
        End Function

        Public Shared Function LiberaContrato(Objecto() As Object) As Boolean
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim dsDatos As New DataSet

            Try
                If Not ADDA.TieneTransaccionAbierta Then ADDA.AbreTransaccion()

                If Not ADDA.RegresaConsultaSQL("PA_JUR_ContratosFirmados_Guardar", dsDatos, Objecto) Then

                    If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()

                    Return False
                End If

                If ADDA.TieneTransaccionAbierta Then ADDA.CierraTransaccion()

                Return True
            Catch ex As Exception
                If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)

                Return False
            End Try
        End Function

        Public Shared Function FinalizaContrato(Objecto() As Object) As Boolean
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim dsDatos As New DataSet

            Try
                If Not ADDA.RegresaConsultaSQL("PA_JUR_ContratosDigitalizados_Finalizar", dsDatos, Objecto) Then

                    Return False
                End If

                Return True
            Catch ex As Exception
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)

                Return False
            End Try
        End Function

        Public Shared Function ActualizaFolioSeguimiento(Objecto() As Object) As Integer
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim dsDatos As New DataSet
            Dim nFolioContrato As Integer

            Try
                If Not ADDA.RegresaConsultaSQL("PA_JUR_ActualizaFolioSeguimiento", dsDatos, Objecto) Then

                    Return False
                End If

                nFolioContrato = dsDatos.Tables(0).Rows(0)(0)
                Return nFolioContrato

            Catch ex As Exception
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)

                Return False
            End Try
        End Function

        Public Shared Function ObtenFolioConsecutivo() As String
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim dtDatos As New DataTable

            Try
                If Not ADDA.RegresaConsultaSQL("EXEC dbo.PA_JUR_ObtenFolioConsecutivo", dtDatos) Then
                    Return Nothing
                End If

                Return dtDatos.Rows(0)("FolioConsecutivo")
            Catch ex As Exception
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)

                Return Nothing
            End Try
        End Function

        Public Shared Function GuardaSolicitud(xmlGuardar As String) As Integer
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim dtDatos As New DataTable
            Dim Folio As Integer = 0

            Dim vcSQL As String = "EXEC PA_JUR_ABCSolicitudes  {0}, '{1}', '{2}', '{3}'"

            Try
                vcSQL = String.Format(vcSQL, 0, "Guardar", xmlGuardar, ADDA.GetLoginUsuario)

                If Not ADDA.RegresaConsultaSQL(vcSQL, dtDatos) Then Return 0

                Folio = dtDatos(0)("codigo")
                Utilerias.DestruirObjeto(dtDatos)

                Return Folio
            Catch ex As Exception
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)

                Return 0
            End Try
        End Function

        Public Shared Function ActualizaSolicitud(xmlGuardar As String, Folio As Integer) As Boolean
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim dtDatos As New DataTable
            Dim vcSQL As String = "EXEC PA_JUR_ABCSolicitudes  {0}, '{1}', '{2}', '{3}'"

            Try
                vcSQL = String.Format(vcSQL, Folio, "Actualizar", xmlGuardar, ADDA.GetLoginUsuario)

                If Not ADDA.RegresaConsultaSQL(vcSQL, dtDatos) Then

                    Return False
                End If

                Utilerias.DestruirObjeto(dtDatos)

                Return True
            Catch ex As Exception
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)

                Return False
            End Try
        End Function

        Public Shared Function RetroAlimentacionSolicitud(Retro As String, Folio As Integer) As Boolean
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim dtDatos As New DataTable
            Dim vcSQL As String = "EXEC PA_JUR_ActualizaRetroalimentacionSolicitud  {0}, '{1}'"

            Try
                vcSQL = String.Format(vcSQL, Folio, Retro)

                If Not ADDA.RegresaConsultaSQL(vcSQL, dtDatos) Then

                    Return False
                End If

                Utilerias.DestruirObjeto(dtDatos)

                Return True
            Catch ex As Exception
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)

                Return False
            End Try

        End Function

        Public Shared Function ClasificaSolicitud(Folio As Integer, Clasificacion As Integer) As Boolean
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim dtDatos As New DataTable

            Dim vcSQL As String = "EXEC PA_JUR_ClasificaSolicitudes  {0}, '{1}', {2}, '{3}'"

            Try
                vcSQL = String.Format(vcSQL, Folio, "Clasificar", Clasificacion, ADDA.GetLoginUsuario)

                If Not ADDA.RegresaConsultaSQL(vcSQL, dtDatos) Then

                    Return False
                End If

                Utilerias.DestruirObjeto(dtDatos)

                Return True
            Catch ex As Exception
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)

                Return False
            End Try
        End Function

        Public Shared Function CancelaSolicitud(Folio As Integer) As Boolean
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim dtDatos As New DataTable

            Dim vcSQL As String = "EXEC PA_JUR_ABCSolicitudes  {0}, '{1}', '{2}', '{3}'"

            Try
                vcSQL = String.Format(vcSQL, Folio, "Cancelar", "", ADDA.GetLoginUsuario)
                If Not ADDA.TieneTransaccionAbierta Then ADDA.AbreTransaccion()

                If Not ADDA.RegresaConsultaSQL(vcSQL, dtDatos) Then

                    If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
                    Return False
                End If

                If ADDA.TieneTransaccionAbierta Then ADDA.CierraTransaccion()
                Utilerias.DestruirObjeto(dtDatos)

                Return True
            Catch ex As Exception
                If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)

                Return False
            End Try

        End Function

        Public Shared Function ActualizarSolicitudesContrato(Folio As Integer, Estatus As Integer, Comentarios As String, Optional CodigoClasificacion As Integer = 0) As Boolean
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim dtDatos As New DataTable

            Dim vcSQL As String = "EXEC dbo.PA_JUR_Actualizar_SolicitudesContrato {0}, {1}, '{2}', '{3}', {4}"

            Try
                vcSQL = String.Format(vcSQL, Folio, Estatus, ADDA.GetLoginUsuario, Comentarios, CodigoClasificacion)

                If Not ADDA.RegresaConsultaSQL(vcSQL, dtDatos) Then

                    Return False
                End If

                Utilerias.DestruirObjeto(dtDatos)

                Return True
            Catch ex As Exception
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)

                Return False
            End Try
        End Function

        Public Shared Function GuardarArchivoPropuesta(folioSol As Integer, datosArchivo As DataRow) As Boolean
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim cSQL As String = "EXEC dbo.PA_JUR_GuardaArchivoPropuesta {0}, '{1}', '{2}', '{3}', '{4}'"

            Try
                cSQL = String.Format(cSQL, folioSol, datosArchivo("cNombreImg"), datosArchivo("cExtension"), Utilerias.ArchivoABase64(datosArchivo("bArchivo")), ADDA.GetLoginUsuario())

                Return ADDA.EjecutaComandoSQL(cSQL)
            Catch ex As Exception
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)

                Return False
            End Try
        End Function
#End Region

#Region "Banco de Datos"
        Public Shared Function GuardaExpedientes(xml As String) As Boolean
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia

            Try
                If Not ADDA.TieneTransaccionAbierta Then ADDA.AbreTransaccion()

                If Not ADDA.EjecutaComandoSQL(String.Format("EXEC PA_JUR_ExpedientesBancoDatos_Guardar '{0}','{1}'",
                                                            xml, ADDA.GetLoginUsuario())) Then
                    If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
                    Return False
                End If

                If ADDA.TieneTransaccionAbierta Then ADDA.CierraTransaccion()

                Return True
            Catch ex As Exception
                If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)

                Return False
            End Try
        End Function

        Public Shared Function CancelaExpedientes(xml As String) As Boolean
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia

            Try
                If Not ADDA.TieneTransaccionAbierta Then ADDA.AbreTransaccion()

                If Not ADDA.EjecutaComandoSQL(String.Format("EXEC PA_JUR_ExpedientesBancoDatos_Cancelar '{0}','{1}'",
                                                            xml, ADDA.GetLoginUsuario())) Then
                    If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
                    Return False
                End If

                If ADDA.TieneTransaccionAbierta Then ADDA.CierraTransaccion()

                Return True
            Catch ex As Exception
                If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)

                Return False
            End Try
        End Function

        Public Shared Function EliminaArchivoSolicitud(FolioSolicitud As Integer) As Boolean
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia

            Try
                If Not ADDA.EjecutaComandoSQL("EXEC dbo.PA_JUR_EliminaArchivoPropuesta " & FolioSolicitud) Then

                    Return False
                End If

                Return True
            Catch ex As Exception
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)

                Return False
            End Try
        End Function

        Public Shared Function EliminaArchivosRequerimientos(FolioSolicitud As Integer) As Boolean
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia

            Try
                If Not ADDA.EjecutaComandoSQL("EXEC dbo.PA_JUR_EliminaArchivosRequerimientos " & FolioSolicitud) Then

                    Return False
                End If

                Return True
            Catch ex As Exception
                MuestraMensaje(ex.Message, MessageBoxIcon.Error)

                Return False
            End Try
        End Function

#End Region

    End Class
End Namespace

