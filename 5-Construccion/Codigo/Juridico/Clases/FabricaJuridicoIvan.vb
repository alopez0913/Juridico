Imports QNGuarda
Imports ADSUM
Imports Tools.Comun.Tools
Imports Juridico.Dominio

Namespace Dominio

    Partial Public Class FabricaJuridico
        Inherits Fabrica

        Public Shared Function ObtenBeneficiarios(FolioSol As Integer) As DataSet
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia()
            Dim dsDatos As New DataSet
            Dim vlObjeto(1) As Object

            vlObjeto(0) = FolioSol
            If ADDA.RegresaConsultaSQL("dbo.PA_JUR_ObtenBeneficiarios", dsDatos, vlObjeto) Then
                dsDatos.Tables(0).TableName = "Beneficiarios"

                Return dsDatos
            Else
                Utilerias.DestruirObjeto(dsDatos)
                Return Nothing
            End If
        End Function

        Public Shared Function ObtenRequerimientos(IDSubActo As Integer, ByRef dtDatos As DataTable) As DataTable
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia()

            If ADDA.RegresaConsultaSQL("EXEC dbo.PA_JUR_ObtenRequerimientos " & IDSubActo, dtDatos) Then
                dtDatos.TableName = "Requerimientos"

                Return dtDatos
            Else
                Utilerias.DestruirObjeto(dtDatos)

                Return Nothing
            End If
        End Function

        Public Shared Function ObtenRequerimientosPendientes(FolioSol As Integer, ByRef dtDatos As DataTable) As DataTable
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia()

            If ADDA.RegresaConsultaSQL("EXEC dbo.PA_JUR_ObtenRequerimientosPendientes " & FolioSol, dtDatos) Then
                dtDatos.TableName = "Requerimientos"

                Return dtDatos
            Else
                Utilerias.DestruirObjeto(dtDatos)

                Return Nothing
            End If
        End Function

        Public Shared Function ObtenArchivosDigitalizadosCliente(FolioSol As Integer, IDReq As Integer) As DataTable
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia()
            Dim dsDatos As New DataSet
            Dim vlObjeto(2) As Object

            vlObjeto(0) = FolioSol
            vlObjeto(1) = IDReq
            If ADDA.RegresaConsultaSQL("dbo.PA_JUR_ObtenArchivosDigitalizados", dsDatos, vlObjeto) Then
                dsDatos.Tables(0).TableName = "Archivos"

                Return dsDatos.Tables(0)
            Else
                Utilerias.DestruirObjeto(dsDatos)
                Return Nothing
            End If
        End Function

        Public Shared Function ObtenDocumentosDigitalizadosCliente(FolioSol As Integer) As DataTable
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia()
            Dim dsDatos As New DataSet
            Dim vlObjeto(1) As Object

            vlObjeto(0) = FolioSol
            If ADDA.RegresaConsultaSQL("dbo.PA_JUR_ObtenDocumentosDigitalizados", dsDatos, vlObjeto) Then
                dsDatos.Tables(0).TableName = "Documentos"
                'dsDatos.Tables(1).TableName = "Archivos"

                Return dsDatos.Tables(0)
            Else
                Utilerias.DestruirObjeto(dsDatos)
                Return Nothing
            End If
        End Function

        Public Shared Function ObtenerBinarioDocumento(IDDocumento As Long, Consecutivo As Integer) As Byte()
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia()
            Dim dst As New DataSet
            Dim prms(1) As Object

            prms(0) = IDDocumento
            prms(1) = Consecutivo

            If ADDA.RegresaConsultaSQL("dbo.PA_JUR_ObtenerBinarioBancoDatos", dst, prms) Then
                Dim valor As Byte() = {}

                If dst.Tables(0).Rows.Count = 1 Then
                    valor = dst.Tables(0)(0)(0)
                End If

                Utilerias.DestruirObjeto(dst)

                Return valor
            Else
                Utilerias.DestruirObjeto(dst)
                Return Nothing
            End If
        End Function

        Public Shared Function ObtenerBinarioBancoDatosGeneral(IDDocumento As Long, Consecutivo As Integer, Empresa As Integer) As Byte()
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia()
            Dim dst As New DataSet
            Dim prms(2) As Object

            prms(0) = IDDocumento
            prms(1) = Consecutivo
            prms(2) = Empresa

            If ADDA.RegresaConsultaSQL("dbo.PA_JUR_ObtenerBinarioBancoDatosGeneral", dst, prms) Then
                Dim valor As Byte() = {}

                If dst.Tables(0).Rows.Count = 1 Then
                    valor = dst.Tables(0)(0)(0)
                End If

                Utilerias.DestruirObjeto(dst)

                Return valor
            Else
                Utilerias.DestruirObjeto(dst)
                Return Nothing
            End If
        End Function

        Public Shared Function ObtenerBinarioDocumento(nIDDocumento As Long, nCodOrigen As OrigenDocumentosBinarios) As Byte()
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia()
            Dim dst As New DataSet
            Dim prms(5) As Object

            prms(0) = nIDDocumento
            prms(1) = CInt(nCodOrigen)

            If ADDA.RegresaConsultaSQL("dbo.PA_CXC_ObtenerBinarioDocumento", dst, prms) Then
                Dim valor As Byte() = {}

                If dst.Tables(0).Rows.Count = 1 Then
                    valor = dst.Tables(0)(0)(0)
                End If

                Utilerias.DestruirObjeto(dst)

                Return valor
            Else
                Utilerias.DestruirObjeto(dst)
                Return Nothing
            End If
        End Function

        Public Shared Function ObtenContratosDigitalizadosCliente(FolioSol As Integer) As DataSet
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia()
            Dim dsDatos As New DataSet
            Dim vlObjeto(1) As Object

            vlObjeto(0) = FolioSol
            If ADDA.RegresaConsultaSQL("dbo.PA_JUR_ObtenContratosDigitalizados", dsDatos, vlObjeto) Then

                Return dsDatos
            Else
                Utilerias.DestruirObjeto(dsDatos)
                Return Nothing
            End If
        End Function

        Public Shared Function ObtenContratosFirmadosDigitalizados(FolioSol As Integer) As DataSet
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia()
            Dim dsDatos As New DataSet
            Dim vlObjeto(1) As Object

            vlObjeto(0) = FolioSol
            If ADDA.RegresaConsultaSQL("dbo.PA_JUR_ObtenContratosFirmadosDigitalizados", dsDatos, vlObjeto) Then

                Return dsDatos
            Else
                Utilerias.DestruirObjeto(dsDatos)
                Return Nothing
            End If
        End Function

        Public Shared Function ObtenArchivoPropuesta(FolioSol As Integer) As DataSet
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia()
            Dim dsDatos As New DataSet
            Dim vlObjeto(1) As Object

            vlObjeto(0) = FolioSol
            If ADDA.RegresaConsultaSQL("dbo.PA_JUR_ObtenArchivoPropuesta", dsDatos, vlObjeto) Then

                Return dsDatos
            Else
                Utilerias.DestruirObjeto(dsDatos)
                Return Nothing
            End If
        End Function

        Public Shared Function ValidaRequerimientos(SolContrato As Long) As Boolean
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia

            Return ADDA.RegresaDatoSQL("SELECT dbo.JUR_ValidaRequerimientos(" & SolContrato & ")")
        End Function

        Public Shared Function ValidaFechaFirmaContrato(SolContrato As Long, IDEstatus As Integer) As Boolean
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia

            Return ADDA.RegresaDatoSQL("SELECT dbo.JUR_ValidaFechaFirmaContrato(" & SolContrato & ", " & IDEstatus & ")")
        End Function

        Public Shared Function ObtenBeneficiario(CodBeneficiario As String, TipoBeneficiario As String) As DataTable
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim param(1) As Object
            Dim dsDatos As New DataSet

            param(0) = CodBeneficiario
            param(1) = Left(TipoBeneficiario, 4)
            ADDA.RegresaConsultaSQL("dbo.PA_JUR_ObtenBeneficiario", dsDatos, param)

            If dsDatos Is Nothing OrElse dsDatos.Tables.Count = 0 Then Return Nothing

            Return dsDatos.Tables(0)
        End Function

        Public Shared Function ObtenBeneficiario(FolioSolicitud As Integer) As DataTable
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim param(0) As Object
            Dim dsDatos As New DataSet

            param(0) = FolioSolicitud
            ADDA.RegresaConsultaSQL("dbo.PA_JUR_ObtenBeneficiarioXFolio", dsDatos, param)

            If dsDatos Is Nothing OrElse dsDatos.Tables.Count = 0 Then Return Nothing

            Return dsDatos.Tables(0)
        End Function

        Public Shared Function ObtenDatosdelEmpleado(cLogin As String) As DataTable
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim dsDatos As New DataSet
            Dim param(1) As Object
            Dim vlCodEmpleado As Integer

            vlCodEmpleado = ADDA.RegresaDatoSQL("SELECT nPersonal FROM ADSUM_Usuarios (NOLOCK) WHERE cLogin = '" & cLogin.Trim & "'")

            param(0) = vlCodEmpleado
            ADDA.RegresaConsultaSQL("dbo.PA_JUR_ConsultaDatosdelEmpleado", dsDatos, param)

            If dsDatos Is Nothing OrElse dsDatos.Tables.Count = 0 Then Return Nothing

            Return dsDatos.Tables(0)
        End Function

        Public Shared Function ConsultaSolicitud(Folio As Integer) As DataTable
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim dsDatos As New DataSet
            Dim param(3) As Object

            param(0) = Folio
            param(1) = "Consultar"
            param(2) = ""
            param(3) = ""

            ADDA.RegresaConsultaSQL("dbo.PA_JUR_ABCSolicitudes", dsDatos, param)

            If dsDatos Is Nothing OrElse dsDatos.Tables.Count = 0 Then Return Nothing

            Return dsDatos.Tables(0)
        End Function

        Public Shared Function ConsultaClasificacion(Folio As Integer) As String
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim vlSQL As String = "SELECT Contrato FROM dbo.mtc_JurGpoContratoSubActos (NOLOCK) WHERE IDSubActo = " & Folio

            Return ADDA.RegresaDatoSQL(vlSQL)
        End Function

        Public Shared Function ObtenDescripcionCortaGrupoActo(Folio As Integer) As String
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim vlSQL As String = "SELECT cDescCorta FROM dbo.mtc_JurGpoContratoActos (NOLOCK) WHERE nIDActo = " & Folio

            Return ADDA.RegresaDatoSQL(vlSQL)
        End Function

        Public Shared Function AutorizaDocumentacion(Folio As Integer) As Boolean
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim param(1) As Object
            Dim dsDatos As New DataSet

            param(0) = Folio
            param(1) = ADDA.GetLoginUsuario

            Return ADDA.RegresaConsultaSQL("dbo.PA_JUR_AutorizaDocumentacion", dsDatos, param)
        End Function

        Public Shared Function ObtenPlantillaCorreo(Obj() As Object) As String
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim dsDatos As New DataSet

            'Dim vlSQL As String = "SELECT cHTML FROM dbo.CTL_ConfiguracionCorreo (NOLOCK) WHERE cNombreConfiguracion = '" &  NombreConfig & "'"
            ADDA.RegresaConsultaSQL("dbo.PA_JUR_ObtenPlantillaCorreos", dsDatos, Obj)

            Return dsDatos.Tables(0).Rows(0)(0)
        End Function

        Public Shared Function ObtenExpedientesBancoDatos(CodCliente As Integer) As DataSet
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim param(0) As Object
            Dim dsDatos As New DataSet

            param(0) = CodCliente
            ADDA.RegresaConsultaSQL("dbo.PA_JUR_ObtenExpedientesBancoDatos", dsDatos, param)

            If dsDatos Is Nothing OrElse dsDatos.Tables.Count = 0 Then Return Nothing

            Return dsDatos
        End Function

        Public Shared Function ObtenExpedientesBancoDatosPLDArrendamiento(IDEmpresa) As DataSet
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim param(0) As Object
            Dim dsDatos As New DataSet

            param(0) = IDEmpresa
            ADDA.RegresaConsultaSQL("dbo.PA_JUR_ObtenExpedientesBancoDatosArrendamiento", dsDatos, param)

            If dsDatos Is Nothing OrElse dsDatos.Tables.Count = 0 Then Return Nothing

            Return dsDatos
        End Function

        Public Shared Function ObtenExpedientesBancoDatosPLDPrestamos(IDEmpresa) As DataSet
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim param(0) As Object
            Dim dsDatos As New DataSet

            param(0) = IDEmpresa
            ADDA.RegresaConsultaSQL("dbo.PA_JUR_ObtenExpedientesBancoDatosPrestamos", dsDatos, param)

            If dsDatos Is Nothing OrElse dsDatos.Tables.Count = 0 Then Return Nothing

            Return dsDatos
        End Function

        Public Shared Function ObtenBancoDatosGeneral() As DataSet
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim param(0) As Object
            Dim dsDatos As New DataSet

            param(0) = Nothing
            ADDA.RegresaConsultaSQL("dbo.PA_JUR_ObtenBancoDatosGeneral", dsDatos, param)

            If dsDatos Is Nothing OrElse dsDatos.Tables.Count = 0 Then Return Nothing

            Return dsDatos

        End Function

        Public Shared Function ObtenDocumentosBancoDatos(Rubro As Integer, SubRubro As Integer, CodCliente As Integer) As DataSet
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim param(2) As Object
            Dim dsDatos As New DataSet

            Try
                param(0) = Rubro
                param(1) = SubRubro
                param(2) = CodCliente
                ADDA.RegresaConsultaSQL("dbo.PA_JUR_ObtenDocumentosBancoDatos", dsDatos, param)

                If dsDatos Is Nothing OrElse dsDatos.Tables.Count = 0 Then Return Nothing

                Return dsDatos
            Catch ex As Exception
                MuestraMensaje(ex.ToString, MessageBoxIcon.Error)

                Return Nothing
            End Try
        End Function

        Public Shared Function ObtenDocumentacionBancoDatosGeneral(Catalogo As Integer, Codigo As Integer, Empresa As Integer) As DataSet
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim param(2) As Object
            Dim dsDatos As New DataSet

            Try
                param(0) = Catalogo
                param(1) = Codigo
                param(2) = Empresa
                ADDA.RegresaConsultaSQL("dbo.PA_JUR_ObtenDocumentacionBancoDatosGeneral", dsDatos, param)

                If dsDatos Is Nothing OrElse dsDatos.Tables.Count = 0 Then Return Nothing

                Return dsDatos
            Catch ex As Exception
                MuestraMensaje(ex.ToString, MessageBoxIcon.Error)

                Return Nothing
            End Try
        End Function

        Public Shared Function ObtenDocumentosBancoDatos(Catalogo As Integer, Codigo As Integer) As DataSet
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim param(1) As Object
            Dim dsDatos As New DataSet

            Try
                param(0) = Catalogo
                param(1) = Codigo
                ADDA.RegresaConsultaSQL("dbo.PA_JUR_ObtenDocumentosBancoDatosGeneral", dsDatos, param)

                If dsDatos Is Nothing OrElse dsDatos.Tables.Count = 0 Then Return Nothing

                Return dsDatos
            Catch ex As Exception
                MuestraMensaje(ex.ToString, MessageBoxIcon.Error)

                Return Nothing
            End Try
        End Function

        Public Shared Function ConsultaExpedientesBancoDatos(nTipo As Byte, nActividad As Integer, nCodigo As Integer,
                                                    Optional Inicio As Date = #1900-01-01#, Optional Fin As Date = #1900-01-01#) As DataSet
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim param(4) As Object
            Dim dsDatos As New DataSet

            param(0) = nTipo
            param(1) = nActividad
            param(2) = nCodigo
            param(3) = Tools.Comun.Tools.FechaEnFormatoYYYYMMDD(Inicio)
            param(4) = Tools.Comun.Tools.FechaEnFormatoYYYYMMDD(Fin)

            ADDA.RegresaConsultaSQL("dbo.PA_JUR_ConsultaExpedientesBancoDatos", dsDatos, param)

            If dsDatos Is Nothing OrElse dsDatos.Tables.Count = 0 Then Return Nothing

            Return dsDatos

        End Function

        Public Shared Function ObtenerConsultaContratosPorVencer(CodigoContratante As String, CodigoDepartamento As Integer) As DataSet
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim dsDatos As New DataSet
            Dim param(2) As Object

            param(0) = CodigoContratante
            param(1) = CodigoDepartamento
            Try
                ADDA.RegresaConsultaSQL("dbo.PA_JUR_ConsultaContratosPorVencer", dsDatos, param)
                If dsDatos.Tables.Count = 0 Then
                    Return Nothing
                Else
                    Return dsDatos
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Shared Function ObtenerSolicitudesSinClasificar(TipoConsulta As Integer, Optional Solicitante As String = "", Optional Inicio As Date = #1900-01-01#, Optional Fin As Date = #1900-01-01#, Optional Folio As Integer = 0) As DataSet
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim dsDatos As New DataSet
            Dim param(4) As Object

            param(0) = TipoConsulta
            param(1) = Solicitante
            param(2) = FechaEnFormatoYYYYMMDD(Inicio)
            param(3) = FechaEnFormatoYYYYMMDD(Fin)
            param(4) = Folio

            Try
                ADDA.RegresaConsultaSQL("dbo.PA_JUR_ConsultaSolicitudesSinClasificar", dsDatos, param)

                If dsDatos.Tables.Count = 0 OrElse dsDatos Is Nothing Then Return Nothing

                Return dsDatos
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Shared Function AcTualizaFechasSolicitudes(Folio As Integer, FechaInicial As Date, FechaFinal As Date) As Boolean
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim param(2) As Object
            Dim dsDatos As New DataSet

            param(0) = Folio
            param(1) = FechaInicial
            param(2) = FechaFinal

            Return ADDA.RegresaConsultaSQL("dbo.PA_JUR_ActualizaFechasSolicitudes", dsDatos, param)
        End Function

        Public Shared Function ObtenGruposParaCombos() As DataTable
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim dtDatos As New DataTable

            ADDA.RegresaConsultaSQL("SELECT cgc.nIDGrupo [IDgrupo], cgc.cDescGrupo [DescGrupo] FROM CTL_GrupoContrato cgc WHERE cgc.bActivo = 1", dtDatos)

            Return dtDatos
        End Function

        Public Shared Function ObtenActosParaCombos(IDGrupo As Integer) As DataTable
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim dtDatos As New DataTable

            ADDA.RegresaConsultaSQL("SELECT cgca.nIDActo [IDActo], cgca.cDescActo [DescActo] FROM CTL_GrupoContratoActos cgca WHERE cgca.nIDGrupo = " & IDGrupo & " AND cgca.bActivo = 1", dtDatos)

            Return dtDatos
        End Function

        Public Shared Function ObtenSubActosParaCombos(IDActo As Integer) As DataTable
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim dtDatos As New DataTable

            ADDA.RegresaConsultaSQL("SELECT cgcsa.nIDSubActo [IDSubActo], cgcsa.cDescSubActo [DescSubActo] FROM CTL_GrupoContratoSubActos cgcsa WHERE cgcsa.nIDActo = " & IDActo & " AND cgcsa.bActivo = 1", dtDatos)

            Return dtDatos
        End Function

    End Class
End Namespace
