Namespace Enumeradores
    Public Enum TipoNotaCredito As Short
        BONIFICACION = 1S
        DEVOLUCION = 2S
        ESPECIAL = 3S
        INTERESES = 4S
    End Enum
    Public Enum TipoCalculoNotaCredito As Short
        AJUSTE_PRECIO = 1S
        VOLUMEN
        DEVOLUCION
        REFACTURACION
    End Enum
    Public Enum TipoFactura As Byte
        NORMAL = 1
        ESPECIAL = 2
        INTERES = 3
        BROKERAJE = 4
        PARAFINANCIERA = 5
    End Enum

    Public Enum CondicionFactura As Byte
        CONTADO = 1
        CREDITO = 2
    End Enum
    Public Enum SolNotaCredEstatusIC As Short
        TODOS = 0S
        PENDIENTE = 1S
        AUTORIZADA
        RECHAZADA
        CANCELADA
    End Enum
    Public Enum RelacionCFDI As Byte
        NOTACREDITODEVOLUCION = 1
        NOTACREDITOREFACTURACION = 4
        APLICACIONANTICIPOS = 7
    End Enum
    Public Enum EstatusNotaCredito As Byte
        VIGENTE = 1
        APLICADO = 2
    End Enum
    Public Enum TipoSalidaImpresionCfdi As Byte
        IMPRESORA = 1
        PDF = 2
    End Enum
End Namespace