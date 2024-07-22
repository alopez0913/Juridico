Imports System.Net
Imports System.Net.Mail
Imports System.ComponentModel

Public Class clsEnviarEmail
#Region "Declaraciones"

    Private _Nombre As String = "Control de Gastos"
    Private _Correo As String = "controldegastos"
    Private _Dominio As String = "@adelnor.com"
    Private _UsuarioCorreo As String = "apikey"
    Private _Contraseña As String = "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" '"F#6yfgsPOp"

    Private _Para As String = ""
    Private _ConCopia As String = ""
    Private _ConCopiaOculta As String = ""
    Private _Asunto As String = ""
    Private _Mensaje As String = ""
    Private _RutasArchivos As String = ""

    Private _SMTP_Host As String = "smtp.sendgrid.net" ' "secure.emailsrvr.com"
    Private _SMTP_Port As String = 587 '465 '25 '
    Private _SMTP_EnableSSL As Boolean = False  'True

    Private _ListaArchivosAdjuntar As List(Of String)

    Private Const _PieMensaje1 As String = "Este es un correo automático, no es necesario que lo conteste; si tiene o necesita alguna aclaración respecto al mismo por favor comuníquese con la persona responsable del área donde con gusto lo atenderemos. De antemano gracias."
    Private Const _PieAvisoLegal As String = vbCrLf & vbCrLf & "Aviso legal:" & vbCrLf & vbCrLf &
        "El contenido de este mensaje de correo electrónico, incluidos los ficheros adjuntos, es confidencial. Si usted recibe este mensaje por error, por favor póngase en contacto con el remitente para informarle de este hecho, y no difunda su contenido ni haga copias. " &
        "Los derechos de privacidad y confidencialidad de la información en este mensaje no deben perderse por el hecho de haberse trasmitido erróneamente o por causas de interferencias en el funcionamiento de los sistemas de correo y canales de comunicación." & vbCrLf & vbCrLf &
        "Toda opinión que se expresa en este mensaje pertenece a la persona remitente por lo que no debe entenderse necesariamente como una opinión de Nueva Agroindustrias del Norte y/o de las entidades que lo integran, a menos que el remitente este autorizado para hacerlo o " &
        "expresamente lo diga en el mismo mensaje. En consideración a que los mensajes enviados de manera electrónica pueden ser interceptados y manipulados, Nueva Agroindustrias del Norte y las entidades que lo integran no se hacen responsables si los mensajes llegan con demora, " &
        "incompletos, eliminados o con algún programa malicioso denominado como virus informático. Este mensaje no debe interpretarse por ningún motivo como una oferta de venta o de compra de valores ni de instrumentos financieros relacionados."

    Private Shared MensajeEnviado As Boolean = False

    'Enum EstatusEnvio As Integer
    '    Falla = -1
    '    Cancelado = 0
    '    Enviado = 1
    'End Enum

#End Region

#Region "Overrides"

#End Region

#Region "Procedimientos"

    Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Property Correo As String
        Get
            Return _Correo
        End Get
        Set(ByVal value As String)
            _Correo = value
        End Set
    End Property

    Property Dominio As String
        Get
            Return _Dominio
        End Get
        Set(ByVal value As String)
            _Dominio = value
        End Set
    End Property

    Property Contraseña As String
        Get
            Return _Contraseña
        End Get
        Set(ByVal value As String)
            _Contraseña = value
        End Set
    End Property

    Property Para As String
        Get
            Return _Para
        End Get
        Set(ByVal value As String)
            _Para = value
        End Set
    End Property

    Property ConCopia As String
        Get
            Return _ConCopia
        End Get
        Set(ByVal value As String)
            _ConCopia = value
        End Set
    End Property

    Property ConCopiaOculta As String
        Get
            Return _ConCopiaOculta
        End Get
        Set(ByVal value As String)
            _ConCopiaOculta = value
        End Set
    End Property

    Property Asunto As String
        Get
            Return _Asunto
        End Get
        Set(ByVal value As String)
            _Asunto = value
        End Set
    End Property

    Property Mensaje As String
        Get
            Return _Mensaje
        End Get
        Set(ByVal value As String)
            _Mensaje = value
        End Set
    End Property

    Property SMTP_Host As String
        Get
            Return _SMTP_Host
        End Get
        Set(ByVal value As String)
            _SMTP_Host = value
        End Set
    End Property

    Property SMTP_Port As String
        Get
            Return _SMTP_Port
        End Get
        Set(ByVal value As String)
            _SMTP_Port = value
        End Set
    End Property

    Property SMTP_EnableSSL As String
        Get
            Return _SMTP_EnableSSL
        End Get
        Set(ByVal value As String)
            _SMTP_EnableSSL = value
        End Set
    End Property

    Property ListaArchivosAdjuntar As List(Of String)
        Get
            Return _ListaArchivosAdjuntar
        End Get
        Set(ByVal value As List(Of String))
            _ListaArchivosAdjuntar = value
        End Set
    End Property

    Sub New()

    End Sub
    Sub New(pNombreEnvia As String, pCorreoEnvia As String, pDominio As String, pContraseña As String)
        _Nombre = pNombreEnvia
        _Correo = pCorreoEnvia
        _Dominio = pDominio
        _Contraseña = pContraseña
    End Sub

    Sub New(pNombreEnvia As String, pCorreoEnvia As String, pDominio As String, pContraseña As String, pSMTP_Host As String, pSMTP_Port As String, pSMTP_EnableSSL As String)
        _Nombre = pNombreEnvia
        _Correo = pCorreoEnvia
        _Dominio = pDominio
        _Contraseña = pContraseña
        _SMTP_Host = pSMTP_Host
        _SMTP_Port = pSMTP_Port
        _SMTP_EnableSSL = pSMTP_EnableSSL
    End Sub

    'Private Shared Sub SendCompletedCallback(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
    '    ' Get the unique identifier for this asynchronous operation.
    '    Dim token As String = CStr(e.UserState)

    '    If e.Cancelled Then
    '        Console.WriteLine("[{0}] Send canceled.", token)
    '    End If
    '    If e.Error IsNot Nothing Then
    '        Console.WriteLine("[{0}] {1}", token, e.Error.ToString())
    '    Else
    '        Console.WriteLine("Message sent.")
    '    End If
    '    MensajeEnviado = True
    'End Sub



#End Region

#Region "Funciones"
    Public Function Enviar_Correo() As Boolean
        Dim _Message As New System.Net.Mail.MailMessage()
        Dim _SMTP As New System.Net.Mail.SmtpClient

        Try

            _Message.From = New System.Net.Mail.MailAddress(_Correo + _Dominio, _Nombre, System.Text.Encoding.UTF8) 'Quien lo envía 

            ' CONFIGURACION_DEL_MENSAJE() 
            _Message.[To].Add(_Para) 'Cuenta de Correo al que se le quiere enviar el e-mail 
            If _ConCopia <> "" Then
                _Message.CC.Add(_ConCopia)
            End If

            If _ConCopiaOculta <> "" Then
                _Message.Bcc.Add(_ConCopiaOculta)
            End If

            _Message.Subject = _Asunto 'Sujeto del e-mail 
            _Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion 
            _Message.IsBodyHtml = True 'False
            _Message.BodyEncoding = System.Text.Encoding.UTF8
            _Message.Body = _Mensaje & "<br><br>" '& _PieMensaje1 & "<br><br>" & _PieAvisoLegal 'contenido del mail 
            _Message.Priority = System.Net.Mail.MailPriority.Normal


            If _ListaArchivosAdjuntar IsNot Nothing Then
                For Each _RutaArchivo In _ListaArchivosAdjuntar
                    Dim vAdjunto = New System.Net.Mail.Attachment(_RutaArchivo)
                    _Message.Attachments.Add(vAdjunto)
                Next
            End If

            _Message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure

            'ENVIO() 

            _SMTP.Host = _SMTP_Host
            _SMTP.Port = _SMTP_Port
            _SMTP.EnableSsl = _SMTP_EnableSSL
            ' _SMTP.UseDefaultCredentials = False
            _SMTP.Credentials = New System.Net.NetworkCredential(_UsuarioCorreo, _Contraseña) '_SMTP.Credentials = New System.Net.NetworkCredential(_Correo + _Dominio, _Contraseña)


            'AddHandler _SMTP.SendCompleted, AddressOf SendCompletedCallback

            _SMTP.Send(_Message)

            _SMTP.Dispose()

            Return True
            'MessageBox.Show("Mensaje enviado correctamene", "Exito!", MessageBoxButtons.OK)
        Catch ex As System.Net.Mail.SmtpException
            Throw ex
        Finally
            _Message = Nothing
            _SMTP = Nothing
        End Try

    End Function

#End Region

#Region "Eventos"

#End Region

End Class
