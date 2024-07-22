Imports QNGuarda
Imports ADSUM
Imports Tools.Comun.Tools


Namespace Dominio
    Partial Public Class FabricaJuridico
        Inherits Fabrica

        Public Shared Function ObtenerDocumentacionSolicitable() As DataTable
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim vDt As New DataTable

            ADDA.RegresaConsultaSQL("exec dbo.PA_JUR_DocumentacionSolicitable ", vDt)

            Return vDt
        End Function

        Public Shared Function ObtenerDocumentacionContrato(p_nIdContrato) As DataTable
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim vDt As New DataTable

            ADDA.RegresaConsultaSQL("exec dbo.PA_JUR_DocumentacionContrato " + p_nIdContrato.ToString, vDt)

            Return vDt
        End Function



    End Class

End Namespace

