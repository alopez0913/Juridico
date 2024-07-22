Imports QNGuarda
Imports ADSUM
Imports Tools.Comun.Tools

Namespace Dominio
    Public Class FabricaJuridico
        Inherits Fabrica
        Public Shared Function ConsultarContratos(cSolicitate As String, nContratante As Integer, nCodDepto As Integer, nEstatus As Integer,
                                                  nGrupo As Integer, nActo As Integer, dFecIni As Date, dFecFin As Date) As DataSet
            Dim ADDA As AsistenteDeDatos_Base = AsistenteDeDatos_Base.DevuelveInstancia
            Dim vDs As New DataSet
            Dim params(7) As Object
            'Dim cSql As String

            params(0) = cSolicitate
            params(1) = nContratante
            params(2) = nCodDepto
            params(3) = nEstatus
            params(4) = nGrupo
            params(5) = nActo
            params(6) = FechaEnFormatoYYYYMMDD(dFecIni)
            params(7) = FechaEnFormatoYYYYMMDD(dFecFin)

            If ADDA.RegresaConsultaSQL("dbo.PA_JUR_ConsultaContratos", vDs, params) Then
                vDs.Tables(0).TableName = "Cabecero"
                vDs.Tables(1).TableName = "Detalle"

                Return vDs
            Else
                Utilerias.DestruirObjeto(vDs)
                Return Nothing
            End If
        End Function
    End Class
End Namespace