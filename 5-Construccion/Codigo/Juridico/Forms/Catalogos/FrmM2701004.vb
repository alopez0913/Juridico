Imports Tools.Comun.Tools
Imports ADSUM
Imports Juridico.Dominio

Public Class FrmM2701004
#Region "Declaraciones"
    Public bClickBtnLimpiar As Boolean = True
    'Public ADDA = AsistenteDeDatos_Base.DevuelveInstancia
    Private ADDA As AsistenteDeDatos_Base

#End Region
#Region "Eventos"
    Private Sub FrmM2701004_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub AtxIdRequerimiento_CambioElemento(sender As Object, e As SelectedElementArgs) Handles AtxIdRequerimiento.CambioElemento
        If AtxIdRequerimiento.Text.Trim = "*" Then
            lblOperacion.Text = "REGISTRANDO"
            Return
        End If
        Try
            If AtxIdRequerimiento.Text <> " * " AndAlso ElementoValidoATX(AtxIdRequerimiento) Then
                If AtxIdRequerimiento.Text = "" Then
                    AtxIdRequerimiento.Text = " * "
                    lblOperacion.Text = "REGISTRANDO"
                    With Me.ToolBarButtons
                        .Guardar = True
                    End With
                Else
                    lblOperacion.Text = "CONSULTANDO"
                    With Me.ToolBarButtons
                        .Guardar = True
                    End With
                    If e.Row IsNot Nothing Then
                        PlObtieneDatos(e.Valor)
                    End If

                End If
                If AtxIdRequerimiento.Text <> "" Then AtxIdRequerimiento.Enabled = False
                'Activar pantalla de grabar 
                With Me.ToolBarButtons
                    .Guardar = True
                End With
            End If
        Catch ex As Exception
            MsgBox("Se presentó un problema de metacatálogo." & vbCrLf & " & Favor de Comunicarse con su administrador de sistemas." & ex.Message)
        End Try
    End Sub
#End Region
#Region "Procedimientos"
    Private Sub PlInicializaCatalogos()
        ''lamado a metacatalogo
        AtxIdRequerimiento.CatalogoBase = New Catalogo(New MetaCatalogo("JUR_ReqDocumentacion"))
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
    Private Sub PlObtieneDatos(ByVal IdReq As Int32)
        Dim dt As DataTable = FabricaJuridico.FcObtieneReqDocumentacion(IdReq)
        AtxDescripcion.Text = dt.Rows(0).Item("cDescripcion").ToString
        dtpFechaInicial.Value = dt.Rows(0).Item("dFecha_Registro").ToString
        'AtxDescCorta.Text = dt.Rows(0).Item("cDesCorta").ToString
        'AtxObservaciones.Text = dt.Rows(0).Item("cObservaciones").ToString
        'chckButtonActivo.Checked = dt.Rows(0).Item("bActivo")
        'cmbTipoPersona.SelectedValue = dt.Rows(0).Item("nTipoPersona")
    End Sub

    'Private Sub PlLlenaComboGrupos()
    '    Dim dt As DataTable = FabricaJuridico.FcObtieneTipoPersona()

    '    'Añadimos una nueva fila al objeto DataTable
    '    Dim row As DataRow = dt.NewRow
    '    'Establecemos el valor del campo Nombre
    '    row("cDescripcion") = "SELECCIONAR PERSONA"
    '    ''Establecemos el valor de otro Campo
    '    row("nConsecutivo") = 0
    '    ''Insertamos la fila en la primera posición
    '    dt.Rows.InsertAt(row, 0)
    '    'Se cambia el indice para que aparezca el título "SELECCIONAR POSICIÓN"
    '    'cmbTipoPersona.SelectedIndex = -1
    '    'cmbTipoPersona.DataSource = dt
    '    'cmbTipoPersona.DisplayMember = "cDescripcion"
    '    'cmbTipoPersona.ValueMember = "nConsecutivo"
    'End Sub
#End Region
#Region "Funciones"
    Private Function FlGuardar() As Boolean
        Dim obj(3) As Object
        Dim vRes As Integer = 0
        If AtxDescripcion.Text = String.Empty Then
            MsgBox("Favor de llenar el formulario.")
            Return False
        End If
        Try
            obj(0) = AtxIdRequerimiento.Text
            obj(1) = lblOperacion.Text
            obj(2) = AtxDescripcion.Text

            ADDA.AbreTransaccion()
            vRes = EscribanoJuridico.GuardarDocumentoRequerido(obj)
            If vRes > 0 Then
                ADDA.CierraTransaccion()
                MessageBox.Show("Se ha guardado el registro[" + vRes.ToString + "] correctamente.", GlobalSistemaCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)
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
#Region "Overrides"
    Protected Overrides Sub ClickBotonNuevo()
        MyBase.ClickBotonNuevo()
        If bClickBtnLimpiar Then
            If MensajeConfirmaLimpiarPantalla() = Windows.Forms.DialogResult.No Then Return
        End If
        'cmbTipoPersona.SelectedIndex = 0
        PlLimpiarTexto(gpBoxGrupos)
        AtxIdRequerimiento.Enabled = True
        lblOperacion.Text = String.Empty
        'chckButtonActivo.Checked = True
        With Me.ToolBarButtons
            .Guardar = False
        End With
        AtxIdRequerimiento.Select()
        bClickBtnLimpiar = True
    End Sub

    Protected Overrides Sub ClickBotonGuardar()
        MyBase.ClickBotonGuardar()

        If MensajeConfirmaGuardar() = Windows.Forms.DialogResult.Yes Then
            If FlGuardar() Then

                bClickBtnLimpiar = False
                ClickBotonNuevo()
            Else
                MuestraMensaje("Ocurrió un Error al momento de guardar.", MessageBoxIcon.Information)
            End If
        End If
    End Sub

#End Region

End Class