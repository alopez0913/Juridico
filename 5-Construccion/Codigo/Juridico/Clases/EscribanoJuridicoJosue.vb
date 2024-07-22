Imports QNGuarda
Imports ADSUM
Imports Tools.Comun.Tools
Imports System.Data.SqlClient

Public Class EscribanoJuridicoJosue
    Public Shared Function InsertarSolContrato(
                                             cClave As String,
                                             cDepartamento As Integer,
                                             dFechaIni As String,
                                             dFechaFin As String,
                                             dFechaFirma As String,
                                             nSubtipoAct As Integer,
                                             cEspecificaciones As String,
                                             cPenalidades As String,
                                             nMonedapena As Integer,
                                             nCantPena As Decimal,
                                             cRetroPropuesta As String,
                                             cUsuario_Registro As String,
                                             ccorreo As String,
                                             ccorreo2 As String) As Integer
        Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
        Dim tb As New DataTable
        Dim nCodSoli As Integer = 0

        Dim vcSQL As String = "EXEC PA_JUR_GuardaSolContratos '{0}',{1},'{2}','{3}','{4}',{5},'{6}','{7}',{8},{9},'{10}','{11}','{12}','{13}'"

        Try

            vcSQL = String.Format(vcSQL, cClave, cDepartamento, dFechaIni, dFechaFin,
             dFechaFirma, nSubtipoAct, cEspecificaciones, cPenalidades, nMonedapena, nCantPena, cRetroPropuesta, cUsuario_Registro, ccorreo, ccorreo2)

            ADDA.AbreTransaccion()

            If ADDA.RegresaConsultaSQL(vcSQL, tb) Then
                nCodSoli = tb(0)(0)
                ADDA.CierraTransaccion()
                Utilerias.DestruirObjeto(tb)
            Else
                ADDA.DeshaceTransaccion()
            End If

            Return nCodSoli
        Catch ex As Exception
            ADDA.DeshaceTransaccion()
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
            InsertarSolContrato = False
        End Try
    End Function

    Public Shared Function InsertarSolRenoExt(
                                             cClave As String,
                                             cDepartamento As Integer,
                                             dFechaIni As String,
                                             dFechaFin As String,
                                             dFechaFirma As String,
                                             nSubtipoAct As Integer,
                                             cEspecificaciones As String,
                                             cPenalidades As String,
                                             nMonedapena As Integer,
                                             nCantPena As Decimal,
                                             cRetroPropuesta As String,'10
                                             cUsuario_Registro As String,
                                             ccorreo As String,
                                             TipoSol As Integer,
                                             SolContrato As Integer,
                                             ccorreo2 As String) As Integer
        Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
        Dim tb As New DataTable
        Dim nCodSoli As Integer = 0

        Dim vcSQL As String = "EXEC PA_JUR_GuardaSolContratos_RenoEx '{0}',{1},'{2}','{3}','{4}',{5},'{6}','{7}',{8},{9},'{10}','{11}','{12}',{13},{14},'{15}'"

        Try

            vcSQL = String.Format(vcSQL, cClave, cDepartamento, dFechaIni, dFechaFin,
             dFechaFirma, nSubtipoAct, cEspecificaciones, cPenalidades, nMonedapena, nCantPena, cRetroPropuesta, cUsuario_Registro, ccorreo, TipoSol, SolContrato, ccorreo2)

            ADDA.AbreTransaccion()

            If ADDA.RegresaConsultaSQL(vcSQL, tb) Then
                nCodSoli = tb(0)(0)
                ADDA.CierraTransaccion()
                Utilerias.DestruirObjeto(tb)
            Else
                ADDA.DeshaceTransaccion()
            End If

            Return nCodSoli
        Catch ex As Exception
            ADDA.DeshaceTransaccion()
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
            InsertarSolRenoExt = False
        End Try
    End Function

    Public Shared Function ACtualizaSolRenoExt(
                                             dFechaIni As String,
                                             dFechaFin As String,
                                             dFechaFirma As String,
                                             cEspecificaciones As String,
                                             cPenalidades As String,
                                             nMonedapena As Integer,
                                             nCantPena As Decimal,
                                             cUsuario_Registro As String,
                                             ccorreo As String,
                                             TipoSol As Integer,
                                             SolContrato As Integer,
                                             ccorreo2 As String) As Integer
        Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
        Dim tb As New DataTable
        Dim nCodSoli As Integer = 0

        Dim vcSQL As String = "EXEC PA_JUR_ActualizaSolContratos_RenoEx '{0}','{1}','{2}','{3}','{4}',{5},{6},'{7}','{8}',{9},{10},'{11}' "

        Try

            vcSQL = String.Format(vcSQL, dFechaIni, dFechaFin, dFechaFirma, cEspecificaciones, cPenalidades, nMonedapena,
                                            nCantPena, cUsuario_Registro, ccorreo, TipoSol, SolContrato, ccorreo2)

            ADDA.AbreTransaccion()

            If ADDA.RegresaConsultaSQL(vcSQL, tb) Then
                nCodSoli = tb(0)(0)
                ADDA.CierraTransaccion()
                Utilerias.DestruirObjeto(tb)
            Else
                ADDA.DeshaceTransaccion()
            End If

            Return nCodSoli
        Catch ex As Exception
            ADDA.DeshaceTransaccion()
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
            ACtualizaSolRenoExt = False
        End Try
    End Function

    Public Shared Function InsertarContraObligadosSol(nIDSolContrato As Integer,
                                                        ntipo As Integer,
                                                        nCodBene As Integer,
                                                        cDescBene As String,
                                                        cRFC As String,
                                                        cTipoPersona As String) As Integer


        Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
        Dim tb As New DataTable

        Dim vcSQL As String = "EXEC PA_JUR_InsertarContraObligadosSol {0},{1},{2},'{3}','{4}','{5}' "

        Try
            cDescBene = cDescBene.Replace("&", "&amp;")
            cDescBene = cDescBene.Replace("""", "&quot;")
            cDescBene = cDescBene.Replace("'", "''")

            vcSQL = String.Format(vcSQL, nIDSolContrato, ntipo, nCodBene, cDescBene.Trim, cRFC, Left(cTipoPersona, 4))

            If ADDA.RegresaConsultaSQL(vcSQL, tb) Then Utilerias.DestruirObjeto(tb)

            Return 1
        Catch ex As Exception
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)

            Return 0
        End Try
    End Function


    Public Shared Function InsertarContraObligadosSol_RenoExt(nIDSolContrato As Integer,
                                                        ntipo As Integer,
                                                        nCodBene As Integer,
                                                        cDescBene As String,
                                                        cRFC As String,
                                                        cTipoPersona As String) As Integer


        Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
        Dim tb As New DataTable
        Dim nCodInsert As Integer = 0

        Dim vcSQL As String = "EXEC PA_JUR_InsertarContraObligadosSol_RenoExt {0},{1},{2},'{3}','{4}','{5}' "

        Try

            vcSQL = String.Format(vcSQL, nIDSolContrato, ntipo, nCodBene, cDescBene, cRFC, cTipoPersona)

            ADDA.AbreTransaccion()

            If ADDA.RegresaConsultaSQL(vcSQL, tb) Then
                nCodInsert = tb(0)(0)
                ADDA.CierraTransaccion()
                Utilerias.DestruirObjeto(tb)
            Else
                ADDA.DeshaceTransaccion()
            End If

            Return nCodInsert
        Catch ex As Exception
            ADDA.DeshaceTransaccion()
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
            InsertarContraObligadosSol_RenoExt = False
        End Try
    End Function

    Public Shared Function ActualizaSolContrato(nIDSolContrato As Integer,
                                             cClave As String,
                                             cDepartamento As Integer,
                                             dFechaIni As String,
                                             dFechaFin As String,
                                             dFechaFirma As String,
                                             nSubtipoAct As Integer,
                                             cEspecificaciones As String,
                                             cPenalidades As String,
                                             nMonedapena As Integer,
                                             nCantPena As Decimal,
                                             cRetroPropuesta As String,
                                             cUsuario_Registro As String,
                                             ccorreo As String,
                                             ccorreo2 As String) As Integer


        Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
        Dim tb As New DataTable
        Dim nCodInsert As Integer = 0

        Dim vcSQL As String = "EXEC PA_JUR_ActualizaSolContratos {0},'{1}',{2},'{3}','{4}','{5}',{6},'{7}','{8}',{9},{10},'{11}','{12}','{13}','{14}' "

        Try

            vcSQL = String.Format(vcSQL, nIDSolContrato, cClave, cDepartamento, dFechaIni, dFechaFin, dFechaFirma, nSubtipoAct, cEspecificaciones,
                                  cPenalidades, nMonedapena, nCantPena, cRetroPropuesta, cUsuario_Registro, ccorreo, ccorreo2)

            ADDA.AbreTransaccion()

            If ADDA.RegresaConsultaSQL(vcSQL, tb) Then
                nCodInsert = tb(0)(0)
                ADDA.CierraTransaccion()
                Utilerias.DestruirObjeto(tb)
            Else
                ADDA.DeshaceTransaccion()
            End If

            Return nCodInsert
        Catch ex As Exception
            ADDA.DeshaceTransaccion()
            MuestraMensaje(ex.Message, MessageBoxIcon.Error)
            ActualizaSolContrato = False
        End Try
    End Function


    Public Shared Function ConsultarDocuContratos1(numDoc As Integer) As Byte()
        Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
        Dim param(0) As Object
        Dim vlDS As New DataSet
        Dim tb As DataTable

        Try
            param(0) = numDoc

            ADDA.RegresaConsultaSQL("SELECT barchivo AS RESUL FROM DOCUMENTOS.dbo.Documentos WHERE ncodorigen = 9 AND CONVERT(INTEGER,SUBSTRING (cnombrearchivo,15,LEN(cnombrearchivo))) = " & numDoc, vlDS, param)
            If vlDS.Tables.Count = 0 Then
                Return Nothing
            Else
                tb = vlDS.Tables(0)
                vlDS.Tables.Remove(tb)
                Return tb(0)("RESUL")
            End If
        Catch ex As Exception
            Throw
        Finally
            Utilerias.DestruirObjeto(vlDS)
        End Try

    End Function


    Public Shared Function InsertarDocuContratos(cnombrearchivo As String, barchivo As Byte()) As Boolean
        Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
        Dim param(1) As Object
        Dim vlDS As New DataSet

        Try
            param(0) = cnombrearchivo
            param(1) = barchivo

            If Not ADDA.RegresaConsultaSQL("PA_JUR_InsertaDocuContratos", vlDS, param) Then
                Return False
            End If


            If vlDS.Tables.Count = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            Utilerias.DestruirObjeto(vlDS)
        End Try

    End Function




End Class
