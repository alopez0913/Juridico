Imports Tools.Comun.Tools
Imports ADSUM
Imports Juridico.Dominio

Public Class FrmM2701001
#Region "Declaraciones"
    'Public ADDA = AsistenteDeDatos_Base.DevuelveInstancia
    Private ADDA As AsistenteDeDatos_Base
#End Region


#Region "Overrides"
    Protected Overrides Sub ClickBotonNuevo()
        MyBase.ClickBotonNuevo()
        If MensajeConfirmaLimpiarPantalla() = Windows.Forms.DialogResult.No Then Return
        PlLimpiarTexto(gpBoxGrupos)
        AtxFolioGrupos.Enabled = True
        lblOperacion.Text = String.Empty

        With Me.ToolBarButtons
            .Guardar = False
        End With
        AtxFolioGrupos.Focus()

    End Sub
    Protected Overrides Sub ClickBotonGuardar()
        MyBase.ClickBotonGuardar()

        If AtxDescripcion.Text = String.Empty Then
            MsgBox("Favor de agregar una descripción.")
            Exit Sub
        End If

        If MensajeConfirmaGuardar() = Windows.Forms.DialogResult.Yes Then

            If FlGuardar() Then
                'MessageBox.Show(FgGetDatoGuardado(gObjRacks.nNumRack, True), GlobalSistemaCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                PlLimpiarTexto(gpBoxGrupos)
                AtxFolioGrupos.Enabled = True
            Else
                MuestraMensaje("Ocurrió un Error al momento de guardar.", MessageBoxIcon.Information)
            End If
        End If
    End Sub
#End Region
#Region "Eventos"
    Private Sub FrmM2701001_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me.ToolBarButtons
            .Nuevo = True
            .Guardar = False
            .Borrar = False
            .EnvExcel = False
            .Ejecutar = False
            .Imprimir = False
            .Graficar = False
            .Autorizar = False
            .Herramientas = False
            .Invertir = False
            .Cambio_Password = True
        End With

        ADDA = AsistenteDeDatos_Base.DevuelveInstancia
        PlInicializaCatalogos()

        dtpFechaInicial.Value = ADDA.RegresaFechaDelSistema
    End Sub

    Private Sub AtxFolioGrupos_CambioElemento(sender As Object, e As SelectedElementArgs) Handles AtxFolioGrupos.CambioElemento

        Try
            If AtxFolioGrupos.Text.Trim = "" Then
                AtxFolioGrupos.Text = "*"
                AtxFolioGrupos.Enabled = False
                lblOperacion.Text = "REGISTRANDO"
                Return
            Else
                If e.Row IsNot Nothing Then
                    PlObtieneDatos(e.Valor)
                    lblOperacion.Text = "CONSULTANDO"
                    AtxFolioGrupos.Enabled = False
                Else
                    AtxFolioGrupos.Text = "*"
                    AtxFolioGrupos.Enabled = False
                    lblOperacion.Text = "REGISTRANDO"
                    'With Me.ToolBarButtons
                    '    .Guardar = True
                    'End With
                    'Return
                End If
                With Me.ToolBarButtons
                    .Guardar = True
                End With

            End If

        Catch ex As Exception
            MsgBox("Se presentó un problema de metacatálogo." & vbCrLf & " & Favor de Comunicarse con su administrador de sistemas." & ex.Message)
        End Try
    End Sub
#End Region
#Region "Funciones"
    Private Function FlGuardar() As Boolean
        Dim obj(2) As Object

        Try
            obj(0) = lblOperacion.Text
            obj(1) = AtxDescripcion.Text
            'obj(2) = AtxObservaciones.Text
            'obj(3) = chckButtonActivo.Checked
            obj(2) = AtxFolioGrupos.Text
            ADDA.AbreTransaccion()
            If (EscribanoJuridico.GuardarGrupos(obj)) Then
                ADDA.CierraTransaccion()
                Return True
            Else
                If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
                Return False
            End If
        Catch ex As Exception
            If ADDA.TieneTransaccionAbierta Then ADDA.DeshaceTransaccion()
            Return False
        End Try
    End Function
#End Region
#Region "Procedimientos"
    Private Sub PlInicializaCatalogos()
        ''lamado a metacatalogo
        AtxFolioGrupos.CatalogoBase = New Catalogo(New MetaCatalogo("JurGpoContrato"))
    End Sub
    ''' <summary>
    ''' Limpia todos los texbox del groupbox.
    ''' </summary>
    ''' <param name="contenedor"></param>
    Private Sub PlLimpiarTexto(ByVal contenedor As GroupBox)

        'Recorremos todos los controles del formulario que enviamos  
        For Each control As Control In contenedor.Controls

            'Filtramos sólo aquellos de tipo TextBox 
            If TypeOf control Is TextBox Then
                control.Text = String.Empty ' eliminar el texto  
            End If
        Next

    End Sub
    Private Sub PlObtieneDatos(ByVal CodGrupo As Int32)
        Dim dt As DataTable = FabricaJuridico.FcObtieneGrupos(CodGrupo)
        AtxDescripcion.Text = dt.Rows(0).Item("cDescGrupo").ToString
        dtpFechaInicial.Text = dt.Rows(0).Item("dFecha_Registro").ToString
        'AtxObservaciones.Text = dt.Rows(0).Item("cObservaciones").ToString
        'chckButtonActivo.Checked = dt.Rows(0).Item("bActivo")
    End Sub

#End Region

End Class