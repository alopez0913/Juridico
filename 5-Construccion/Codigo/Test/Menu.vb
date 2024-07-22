Imports ADSUM

Public Class Menu
    Private archivoIni As IniFileController.IniFileController
    Dim gbPreguntaCerrarSistema As Boolean = True
    Dim vTread As Threading.Thread

    Private Declare Auto Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal procHandle As IntPtr, ByVal min As Int32, ByVal max As Int32) As Boolean

#Region "Procedimientos"
    Private Sub LiberarMemoria(ByVal nIntervaloSegundos As Integer)
        Dim nTimeSpan As New TimeSpan(0, 0, nIntervaloSegundos)

        Do
            Try
                Dim Mem As Process
                Mem = Process.GetCurrentProcess()
                SetProcessWorkingSetSize(Mem.Handle, -1, -1)
                Threading.Thread.Sleep(nTimeSpan)
            Catch ex As Exception
                'Control de errores
            End Try
        Loop
    End Sub

    Private Sub CargaContextosNavegador()
        Dim ADDA As ADSUM.AsistenteDeDatos_Base = ADSUM.AsistenteDeDatos_Base.DevuelveInstancia
        Dim vlsql As String = ""
        Dim DTContextos As New DataTable
        Dim vnSucursal As Integer = 0


        '17-Agosto-09
        'César Octavio Niebla Manjarrez
        '   Se realiza el cargado del contexto segun los derechos con que cuente el usuario del inicio de sesión,
        '   En base al siguiente criterio:
        ' 1 - Primeramente validamos si se trata de un usuario que tenga derecho a accesar opciones no permitidas
        '     en caso de que así sea procedemos a cargar todos los contextos
        ' 2 - Caso contrario realizamos la carga en base a las opciones a las que tenga derecho el usuario en cuestión

        '1:
        vlsql = "SELECT * FROM ADSUM_Usuarios" & vbCr
        vlsql &= "WHERE bMostrarOpcionesNoPermitidas=1 and cLogin='" & ADDA.GetLoginUsuario.ToUpper().Trim() & "'"



        If ADDA.ExistenDatosEnConsultaSQL(vlsql) Then
            '1:
            vlsql = "SELECT DISTINCT cContexto,nValor  FROM ADSUM_Contextos AC(NOLOCK)" & vbCr
            vlsql &= "INNER JOIN ADSUM_TiposDatos TD (NOLOCK) ON (AC.cContexto=TD.cValor)" & vbCr
            vlsql &= "WHERE cLlave='ADSUM_CONTEXTO'"
        Else
            '2:
            vlsql = "SELECT distinct cContexto,nValor  FROM Adsum_Usuarios_X_Perfil AUP(NOLOCK)" & vbCr
            vlsql &= "INNER JOIN ADSUM_Derechos_X_Perfil ADP (NOLOCK) ON (AUP.cLogin=AUP.cLogin AND AUP.nPerfil=ADP.nPerfil)" & vbCr
            vlsql &= "INNER JOIN ADSUM_Navegador N(NOLOCK) ON (N.nRama=ADP.nRama)" & vbCr
            vlsql &= "INNER JOIN ADSUM_TiposDatos TD (NOLOCK) ON (N.cContexto=TD.cValor)" & vbCr
            vlsql &= "WHERE cLlave='ADSUM_CONTEXTO' AND upper(rtrim(ltrim(cLogin)))='" & ADDA.GetLoginUsuario.ToUpper().Trim() & "'"
        End If

        ADDA.RegresaConsultaSQL(vlsql, DTContextos)


        If DTContextos.Rows.Count = 0 Then
            MessageBox.Show("El usuario ingresado no cuenta con derecho a ninguna" & vbCr & "opción del sistema", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            RemoveHandler Me.FormClosing, AddressOf Menu_FormClosing
            'atrCerrarApp = True
            Application.Exit()
            MyBase.Close()
        End If

        'VALIDAMOS DE QUE CONTEXTOS OBTENDREMOS RAMAS, PARA NO AGREGAR AL NAVEGADOR AQUELLOS A LOS QUE SI SE TENGA PERMISO, PERO QUE TODAS LAS RAMAS ESTÉN CANCELADAS.
        '*********************************************************************************************************
        Dim vbMostrarTodasLasOpciones As Boolean = False
        vbMostrarTodasLasOpciones = ADDA.RegresaDatoSQL("SELECT ISNULL(bMostrarOpcionesNoPermitidas,0) FROM ADSUM_Usuarios (NOLOCK) WHERE cLogin = '" & ADDA.GetLoginUsuario.Trim & "'")

        Dim vDtContextosConRamasActivas As New DataTable

        Select Case vbMostrarTodasLasOpciones
            Case False
                vlsql = "SELECT N.cContexto FROM Adsum_Usuarios_X_Perfil UP (NOLOCK) " & vbCr
                vlsql &= "      INNER JOIN ADSUM_Derechos_X_Perfil DP (NOLOCK) ON UP.nPerfil=DP.nPerfil " & vbCr
                vlsql &= "      INNER JOIN ADSUM_Navegador N (NOLOCK) ON N.nRama = DP.nRama AND NOT N.cEstatus_Rama = 'C' " & vbCr
                vlsql &= "      LEFT JOIN ADSUM_Formas F (NOLOCK) ON F.cForma = N.cForma AND NOT F.cEstatus = 'C' " & vbCr
                vlsql &= "WHERE UP.cLogin = '" & ADDA.GetLoginUsuario.Trim & "' " & vbCr
                vlsql &= "GROUP BY N.cContexto "
                ADDA.RegresaConsultaSQL(vlsql, vDtContextosConRamasActivas)
            Case True
                vlsql = "SELECT cContexto FROM adsum_contextos (NOLOCK) " & vbCr
                vlsql &= "GROUP BY cContexto "
                ADDA.RegresaConsultaSQL(vlsql, vDtContextosConRamasActivas)
        End Select
        '********************************************************************************************************
        If DTContextos.Rows.Count > 0 Then
            If Not vDtContextosConRamasActivas Is Nothing Then
                For Each vRowContexto As DataRow In DTContextos.Select("", "nValor")
                    If vDtContextosConRamasActivas.Select("cContexto ='" & vRowContexto("cContexto") & "'").Length > 0 Then
                        Me.Contextos.Agregar(Trim(vRowContexto("cContexto")))
                    End If
                Next
            Else
                For Each vRowContexto As DataRow In DTContextos.Select("", "nValor")
                    Me.Contextos.Agregar(Trim(vRowContexto("cContexto")))
                Next
            End If
        End If


        Dim Contexto As String = "" '= ADDA.ParametrosTerminal.ParametroContextoInicial.Valor

        If Trim(Contexto) = "" Then
            Contexto = "JURI"
        End If

        Me.ContextoPrimario = Contexto
    End Sub

    Private Sub Calculadora()
        Dim vobjCalculadora As New Tools.FrmCalculadora(False)

        ' Si ya existe abierta una forma de calculadora la trae al frente   y elimina el objeto sobre el que hiba a crear una nueva
        For Each objF As Form In Application.OpenForms
            If objF.Name.ToUpper = vobjCalculadora.Name.ToUpper Then
                objF.BringToFront()
                vobjCalculadora = Nothing
                Exit Sub
            End If
        Next
        vobjCalculadora.Show() '.ShowDialog()
    End Sub
#End Region

#Region "Funciones"
    Public Function FgParametroObtieneValor(ByVal prmNombreParametroIni As String) As Object
        ADDA = AsistenteDeDatos_Base.DevuelveInstancia
        archivoIni.OpenINIFile(ADDA.GetRutaArchivoIni)
        Dim vObjResultado As Object
        vObjResultado = archivoIni.GetEntry(prmNombreParametroIni.Trim)
        archivoIni.CloseINIFile()

        Return vObjResultado
    End Function
#End Region

#Region "Eventos"
    Private Sub Menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not ADDA Is Nothing Then
            If e.CloseReason = CloseReason.UserClosing Then
                If MessageBox.Show("¿Confirma salir del sistema?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    If ADDA.ParametroAdministradoObtener("CNF", "ACTIVAR_LIBERADOR_DE_MEMORIA") = 1 Then
                        Try
                            vTread.Interrupt()
                            vTread.Abort()
                        Catch ex As Exception

                        End Try
                    End If
                    e.Cancel = False
                Else
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub Menu_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.Control And e.KeyCode = Keys.L Then
            Calculadora()
        End If
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            ADDA = ADSUM.AsistenteDeDatos_Base.DevuelveInstancia
            ADDA.ParametroAdministradoAgregar("CNF", "INTERVALO_PARA_LIBERAR_MEMORIA_SEGUNDOS", AsistenteDeDatos_Base.TipoDeParametroAdministrado.Numero, _
                                        "Intervalo en segundos para liberar memoria", 60)

            ADDA.ParametroAdministradoAgregar("CNF", "ACTIVAR_LIBERADOR_DE_MEMORIA", AsistenteDeDatos_Base.TipoDeParametroAdministrado.Numero, _
                                      "ACTIVAR LIBERACION DE MEMORIA", 0)

            Dim vnIntervaloParaLiberarMemoria As Integer = CInt(ADDA.ParametroAdministradoObtener("CNF", "INTERVALO_PARA_LIBERAR_MEMORIA_SEGUNDOS"))

            'QNCatalogos.QNComun.ClsTools.Inicializar()
            If ADDA.ParametroAdministradoObtener("CNF", "ACTIVAR_LIBERADOR_DE_MEMORIA") = 1 Then
                vTread = New Threading.Thread(AddressOf LiberarMemoria)
                Application.DoEvents()
                vTread.Start(vnIntervaloParaLiberarMemoria)
            End If
            CargaContextosNavegador()

            Me.LLenaMenu()

            Me.statVersion.Text = Application.ProductVersion.ToString
            Me.statusTipoArticulo.Text = "<Ctrl L>Calculadora"
        Catch ex As Exception
            MessageBox.Show("error:" & ex.Message)
        End Try
    End Sub
#End Region
    
End Class