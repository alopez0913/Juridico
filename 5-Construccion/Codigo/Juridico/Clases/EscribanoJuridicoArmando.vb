Imports QNGuarda
Imports ADSUM

Namespace Dominio
    Partial Public Class EscribanoJuridico
        Inherits Escribano

        Public Shared Function EliminarDocumentacionPorContrato(nContrato As Integer) As Boolean
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim cSql As String

            Try
                cSql = String.Format("DELETE dbo.JUR_DocumentacionPorContrato WHERE nIDSubActo= {0}", nContrato)

                Return ADDA.EjecutaComandoSQL(cSql)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function GuardarListaDocumentoParaContrato(nIDSubActo As Integer, nIDReq As Integer, nEsRequerido As Integer) As Boolean
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim cSql As String

            Try
                cSql = String.Format("EXEC dbo.PA_JUR_GuardarDocumentacionRequeridaPorContrato {0}, {1}, {2}, '{3}' ", nIDSubActo, nIDReq, nEsRequerido, ADDA.GetLoginUsuario)

                Return ADDA.EjecutaComandoSQL(cSql)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function GuardarAsignacionUsuarioSeguimiento(nSolContrato As Integer) As Boolean
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim cSql As String

            Try
                cSql = String.Format("EXEC dbo.PA_JUR_Asigna_Usuario_Seg {0}, '{1}'", nSolContrato, ADDA.GetLoginUsuario)

                Return ADDA.EjecutaComandoSQL(cSql)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function GrabarArchivo_DetallePropuesta(nFolio As Integer, cNombre As String, cExt As String, bArchivo As Byte()) As Boolean
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim cSql As String
            '@nFolioSolicitud AS INT, @cNombre AS VARCHAR(100), @cExt AS VARCHAR(5), @bArchivo AS VARCHAR(MAX)
            Try
                cSql = String.Format("EXEC dbo.PA_TES_GuardaArchivo_SolicitudOtrosPagos {0}, '{1}', '{2}', '{3}'",
                                     nFolio, cNombre, cExt, Utilerias.ArchivoABase64(bArchivo))

                Return ADDA.EjecutaComandoSQL(cSql)

                'Return True
            Catch ex As Exception
                'MuestraMensaje(ex.Message, MessageBoxIcon.Error)
                'Return False
                Throw
            End Try
        End Function

    End Class
End Namespace

