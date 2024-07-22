Imports QNGuarda
Imports ADSUM
Imports Tools.Comun.Tools

Public Class FabricaJuridicoJosue
    Public Shared Function FgConsultaNombreLogin(prmLogin As String) As DataTable

        Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
        Dim dt As New DataTable
        Dim vcSQL As String

        vcSQL = String.Format(" SELECT usu.cnombre AS nombre, GETDATE() As fechahoy, RTrim(Convert(Char(3), dep.nCodDepto)) + ' .- ' + cNombreSubDepto AS Departamento")
        vcSQL = vcSQL + String.Format(" From ADSUM_usuarios usu (NOLOCK)  ")
        vcSQL = vcSQL + String.Format(" left join CTL_Empleados_Nansa   emp (NOLOCK) ON usu.npersonal = emp.nCodEmpleado ")
        'vcSQL = vcSQL + String.Format(" left join  dbo.CTL_DeptosJuridico dep (NOLOCK) ON emp.ncoddepto = dep.nCodDepto  ")
        vcSQL = vcSQL + String.Format(" left join  dbo.CTL_SubDeptosJuridico dep (NOLOCK) ON emp.ncoddepto = dep.nCodDepto  and  emp.nCodSubDepto = dep.nCodSubDepto  ")
        vcSQL = vcSQL + String.Format(" WHERE usu.clogin = '" & prmLogin & "'")


        ADDA.RegresaConsultaSQL(vcSQL, dt)

        Return dt

    End Function

    Public Shared Function FgConsulta_BitacoraHistdt(prmSol As String) As DataTable

        Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
        Dim dt As New DataTable
        Dim vcSQL As String

        vcSQL = String.Format("EXEC PA_JUR_Consulta_BitacoraHist '" & prmSol & "'")
        ADDA.RegresaConsultaSQL(vcSQL, dt)

        Return dt

    End Function

    Public Shared Function FgConsulta_BitacoraHist(prmSol As String) As DataSet

        Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
        Dim param(0) As Object
        Dim dts As New DataSet


        param(0) = prmSol

        ADDA.RegresaConsultaSQL("PA_JUR_Consulta_BitacoraHist", dts, param)

        Return dts

    End Function

    Public Shared Function FgConsultaMon() As DataTable

        Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
        Dim dt As New DataTable
        Dim vcSQL As String

        vcSQL = String.Format(" SELECT RTRIM(CONVERT(CHAR,nCodMoneda)) + ' .- '+ cDescMoneda AS NombreMoneda FROM CTL_monedas_nansa (NOLOCK) ")

        ADDA.RegresaConsultaSQL(vcSQL, dt)

        Return dt

    End Function

    Public Shared Function FgEliminaContraObliSol(prmSol As Integer) As Integer

        Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
        Dim dt As New DataTable
        Dim vcSQL As String

        vcSQL = String.Format("EXEC PA_JUR_EliminaContraObliSol " & prmSol)

        ADDA.RegresaConsultaSQL(vcSQL, dt)

        Return dt(0)("RESUL")

    End Function

    Public Shared Function FgEliminaContraObliSol_RenoExt(prmSol As Integer) As Integer

        Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
        Dim dt As New DataTable
        Dim vcSQL As String

        vcSQL = String.Format(" Exec PA_JUR_EliminaContraObliSol_RenoExt " & prmSol)

        ADDA.RegresaConsultaSQL(vcSQL, dt)

        Return dt(0)("RESUL")

    End Function

    Public Shared Function FgConsultaSolicitudRenovacion(prmSol As Integer) As Integer

        Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
        Dim dt As New DataTable
        Dim vcSQL As String

        vcSQL = String.Format(" Select  COUNT(ISNULL(nIDSolContrato_hist, 0)) AS RESULT ")
        vcSQL = vcSQL + String.Format(" From JUR_SolContrato_Hist ")
        vcSQL = vcSQL + String.Format(" Where nIDTipoProcesoSol = 2 ")
        vcSQL = vcSQL + String.Format(" And nIDSolContrato = " & prmSol)
        vcSQL = vcSQL + String.Format(" And (SELECT COUNT(ISNULL(nIDSolContrato_hist, 0)) FROM  JUR_SolContrato_Hist WHERE nIDTipoProcesoSol = 2 And nIDSolContrato = " & prmSol & " And nIDSolContrato_hist = 5) = 0 ")

        ADDA.RegresaConsultaSQL(vcSQL, dt)

        Return dt(0)("RESULT")

    End Function

    Public Shared Function FgConsultaDocuContratos(Folio As Integer) As DataTable

        Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
        Dim dt As New DataTable
        Dim vcSQL As String

        vcSQL = String.Format(" SELECT barchivo AS RESUL FROM DOCUMENTOS.dbo.Documentos WHERE ncodorigen = 9 ")
        vcSQL = vcSQL + String.Format(" And  SUBSTRING (CNOMBREARCHIVO,1,13)  = 'Contrato Num:' ")
        vcSQL = vcSQL + String.Format("   And CONVERT(INTEGER,SUBSTRING (cnombrearchivo,15,LEN(cnombrearchivo))) = " & Folio)
        vcSQL = vcSQL + String.Format(" AND niddocumento = (SELECT MAX(niddocumento) FROM DOCUMENTOS.DBO.DOCUMENTOS WHERE NCODORIGEN = 9 ")
        vcSQL = vcSQL + String.Format(" AND CONVERT(INTEGER,SUBSTRING (CNOMBREARCHIVO,15,LEN(CNOMBREARCHIVO))) = " & Folio)
        vcSQL = vcSQL + String.Format(" AND  SUBSTRING (CNOMBREARCHIVO,1,13)  = 'Contrato Num:')  ")

        ADDA.RegresaConsultaSQL(vcSQL, dt)

        Return dt '(0)("RESUL")

    End Function

    Public Shared Function FgExisteDocuContratos(Folio As Integer) As Integer

        Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
        Dim dt As New DataTable
        Dim vcSQL As String

        vcSQL = String.Format(" Select count(niddocumento) As RESUL FROM DOCUMENTOS.dbo.Documentos WHERE ncodorigen = 9 And  SUBSTRING (CNOMBREARCHIVO,1,13)  = 'Contrato Num:' AND CONVERT(INTEGER,SUBSTRING (cnombrearchivo,15,LEN(cnombrearchivo))) = " & Folio)

        ADDA.RegresaConsultaSQL(vcSQL, dt)

        Return dt(0)("RESUL")

    End Function
    Public Shared Function FgConsultaEmpresasNANSA() As DataTable

        Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
        Dim dt As New DataTable
        Dim vcSQL As String

        vcSQL = String.Format("EXEC PA_TES_ConsultaEmpresasNansa ")

        ADDA.RegresaConsultaSQL(vcSQL, dt)

        Return dt

    End Function


    Public Shared Function FgConsultaSolContratos(prmSol As Integer) As DataTable

        Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
        Dim dt As New DataTable
        Dim vcSQL As String

        vcSQL = String.Format("EXEC PA_JUR_ConsultaSolContratos " & prmSol & "'")

        ADDA.RegresaConsultaSQL(vcSQL, dt)

        Return dt

    End Function

    Public Shared Function FgConsultaExistSol(prmSol As Integer) As Integer

        Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
        Dim dt As New DataTable
        Dim vcSQL As String

        vcSQL = String.Format(" SELECT ISNULL(COUNT(Sol.nIDSolContrato),0) AS nIDSolContrato FROM dbo.JUR_SolContrato Sol  (NOLOCK) WHERE nIDSolContrato = " & prmSol)

        ADDA.RegresaConsultaSQL(vcSQL, dt)

        Return dt(0)("nIDSolContrato")

    End Function


    Public Shared Function FgConsultaExistSol_RenoExt(prmSol As Integer) As Integer

        Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
        Dim dt As New DataTable
        Dim vcSQL As String

        vcSQL = String.Format(" Exec PA_JUR_Exists_RenoEXT " & prmSol)

        ADDA.RegresaConsultaSQL(vcSQL, dt)

        Return dt(0)("RESULT")

    End Function
    Public Shared Function FgConsultaContraObliSol(prmSol As Integer) As DataTable

        Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
        Dim dt As New DataTable
        Dim vcSQL As String

        vcSQL = String.Format("EXEC PA_JUR_ConsultaContraObliSol " & prmSol)

        ADDA.RegresaConsultaSQL(vcSQL, dt)

        Return dt

    End Function

    Public Shared Function FgPA_JUR_ConsultaRenoEXT(prmSol As Integer, prmTipo As Integer) As DataTable

        Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
        Dim dt As New DataTable
        Dim vcSQL As String

        vcSQL = String.Format("EXEC PA_JUR_ConsultaRenoEXT " & prmSol & "," & prmTipo)

        ADDA.RegresaConsultaSQL(vcSQL, dt)

        Return dt

    End Function
End Class


