Namespace Dominio
    Public Enum OrigenDocumentosBinarios
        Propuesta_Contrato = -1
        Solicitud_Contrato = 1
        Contratos = 9
        Documentos_Digitalizados_Cliente = 8
        Documentos_Digitalizados_BancoDatos = 3
        ContratosFirmados = 10
    End Enum

    Public Enum EstatusSolicitudes As Integer
        RetroAlimentacion
        Solicitado = 1
        Suspendido = 2
        Clasificado = 3
        RevisionDocumentos = 4
        GeneracionContratos = 5
        LiberacionContrato = 6
        Finalizado = 7
        Cancelado = 8
    End Enum

    Public Enum EstatusSolicitudes_New As Integer
        Cancelado = 0
        SolicitudEnRevision
        Rechazado
        SolicitadoConAjuste
        GeneracionContratos
        RevisionContrato
        ModificacionContrato
        FirmaPorTercero
        FirmaADELNOR
        Completo
        Cerrado
    End Enum
End Namespace