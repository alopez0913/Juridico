Imports Tools.Comun.Tools
Imports ADSUM
Imports Juridico.Dominio

Public Class FrmM2701002
#Region "Declaraciones"
    'Public ADDA = AsistenteDeDatos_Base.DevuelveInstancia
    Private ADDA As AsistenteDeDatos_Base
    Public bClickBtnLimpiar As Boolean = True
#End Region
#Region "Eventos"
    Private Sub FrmM2701002_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        PlLlenaComboGrupos()
        dtpFechaInicial.Value = ADDA.RegresaFechaDelSistema
    End Sub
    Private Sub AtxFolioActos_CambioElemento(sender As Object, e As SelectedElementArgs) Handles AtxFolioActos.CambioElemento
        If AtxFolioActos.Text.Trim = "*" Then
            lblOperacion.Text = "REGISTRANDO"
            Return
        End If
        Try
            If AtxFolioActos.Text <> " * " AndAlso ElementoValidoATX(AtxFolioActos) Then
                If AtxFolioActos.Text = "" Then
                    AtxFolioActos.Text = " * "
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
                If AtxFolioActos.Text <> "" Then AtxFolioActos.Enabled = False
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
        AtxFolioActos.CatalogoBase = New Catalogo(New MetaCatalogo("JurGpoContratoActos"))
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
    Private Sub PlObtieneDatos(ByVal CodActo As Int32)
        Dim dt As DataTable = FabricaJuridico.FcObtieneActos(CodActo)
        AtxDescripcion.Text = dt.Rows(0).Item("cDescActo").ToString
        'AtxObservaciones.Text = dt.Rows(0).Item("cObservaciones").ToString
        'chckButtonActivo.Checked = dt.Rows(0).Item("bActivo")
        AtxDescCorta.Text = dt.Rows(0).Item("cDescCorta").ToString
        cmbGrupo.SelectedValue = dt.Rows(0).Item("nIDGrupo").ToString
        dtpFechaInicial.Value = dt.Rows(0).Item("dFecha_Registro").ToString
    End Sub

    Private Sub PlLlenaComboGrupos()
        Dim dt As DataTable = FabricaJuridico.FcObtieneTodosLosGrupos()
        Try
            'Añadimos una nueva fila al objeto DataTable
            Dim row As DataRow = dt.NewRow
            'Establecemos el valor del campo Nombre
            row("cDescGrupo") = "SELECCIONAR GRUPO"
            ''Establecemos el valor de otro Campo
            row("nIdGrupo") = 0
            ''Insertamos la fila en la primera posición
            dt.Rows.InsertAt(row, 0)
            'Se cambia el indice para que aparezca el título "SELECCIONAR POSICIÓN"
            cmbGrupo.SelectedIndex = -1
            cmbGrupo.DataSource = dt
            cmbGrupo.DisplayMember = "cDescGrupo"
            cmbGrupo.ValueMember = "nIdGrupo"
        Catch ex As Exception
            MsgBox("Falló:" + ex.Message)
        End Try

    End Sub
#End Region
#Region "Overrides"
    Protected Overrides Sub ClickBotonNuevo()
        MyBase.ClickBotonNuevo()
        If bClickBtnLimpiar Then
            If MensajeConfirmaLimpiarPantalla() = Windows.Forms.DialogResult.No Then Return
        End If
        PlLimpiarTexto(gpBoxGrupos)
        AtxFolioActos.Enabled = True
        lblOperacion.Text = String.Empty
        'chckButtonActivo.Checked = True
        With Me.ToolBarButtons
            .Guardar = False
        End With
        cmbGrupo.SelectedIndex = 0
        AtxFolioActos.Select()
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
#Region "Funciones"
    Private Function FlGuardar() As Boolean
        Dim obj(5) As Object
        Dim vRes As Integer = 0
        If AtxDescripcion.Text = String.Empty Or cmbGrupo.SelectedIndex = 0 Then
            MsgBox("Favor de llenar el formulario.")
            Return False
        End If
        Try
            obj(0) = AtxFolioActos.Text
            obj(1) = lblOperacion.Text
            obj(2) = AtxDescripcion.Text
            obj(3) = cmbGrupo.SelectedValue
            obj(4) = AtxDescCorta.Text
            'obj(5) = AtxObservaciones.Text
            'obj(6) = chckButtonActivo.Checked
            ADDA.AbreTransaccion()
            vRes = EscribanoJuridico.GuardarActos(obj)
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


End Class