Imports Tools.Comun.Tools
Imports ADSUM
Imports Juridico.Dominio

Public Class FrmM2701003
#Region "Declaraciones"
    'Public ADDA = AsistenteDeDatos_Base.DevuelveInstancia
    Private ADDA As AsistenteDeDatos_Base
    Public bClickBtnLimpiar As Boolean = True
#End Region
#Region "Eventos"
    Private Sub FrmM2701003_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        'PlLlenaComboActos()
        PlLlenaComboGrupos()
        dtpFechaInicial.Value = ADDA.RegresaFechaDelSistema
    End Sub
    Private Sub AtxSubTipo_CambioElemento(sender As Object, e As SelectedElementArgs) Handles AtxSubTipo.CambioElemento
        'PlLlenaComboActos()
        If AtxSubTipo.Text.Trim = "*" Then
            lblOperacion.Text = "REGISTRANDO"
            Return
        End If
        Try
            If AtxSubTipo.Text <> " * " AndAlso ElementoValidoATX(AtxSubTipo) Then
                If AtxSubTipo.Text = "" Then
                    AtxSubTipo.Text = " * "
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
                If AtxSubTipo.Text <> "" Then AtxSubTipo.Enabled = False
                'Activar pantalla de grabar 
                With Me.ToolBarButtons
                    .Guardar = True
                End With
            End If
        Catch ex As Exception
            MsgBox("Se presentó un problema de metacatálogo." & vbCrLf & " & Favor de Comunicarse con su administrador de sistemas." & ex.Message)
        End Try
    End Sub
    Private Sub cmbGrupo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbGrupo.SelectionChangeCommitted
        Dim valor As Int32 = cmbGrupo.SelectedValue
        PlLlenaComboActosFiltrado(valor)
    End Sub

#End Region
#Region "Procedimientos"
    Private Sub PlInicializaCatalogos()
        ''lamado a metacatalogo
        AtxSubTipo.CatalogoBase = New Catalogo(New MetaCatalogo("JUR_GrupoContratoSubActos"))
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
    Private Sub PlObtieneDatos(ByVal CodSubTipo As Int32)
        Dim dt As DataTable = FabricaJuridico.FcObtieneSubActos(CodSubTipo)
        AtxDescripcion.Text = dt.Rows(0).Item("cDescSubActo").ToString
        'AtxObservaciones.Text = dt.Rows(0).Item("cObservaciones").ToString
        'chckButtonActivo.Checked = dt.Rows(0).Item("bActivo")
        cmbGrupo.SelectedValue = dt.Rows(0).Item("nIdGrupo").ToString
        PlLlenaComboActosFiltrado(dt.Rows(0).Item("nIdGrupo"))
        cmbTipoActo.SelectedValue = dt.Rows(0).Item("nIdActo").ToString
        dtpFechaInicial.Value = dt.Rows(0).Item("dFecha_Registro").ToString
    End Sub
    Private Sub PlLlenaComboGrupos()
        Dim dt As DataTable = FabricaJuridico.FcObtieneTodosLosGrupos()

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
    End Sub
    Private Sub PlLlenaComboActos()
        Try
            Dim dt As DataTable = FabricaJuridico.FcObtieneTodosLosActos()

            'Añadimos una nueva fila al objeto DataTable
            Dim row As DataRow = dt.NewRow
            'Establecemos el valor del campo Nombre
            row("cDescActo") = "SELECCIONAR ACTO"
            ''Establecemos el valor de otro Campo
            row("nIdActo") = 0
            ''Insertamos la fila en la primera posición
            dt.Rows.InsertAt(row, 0)
            'Se cambia el indice para que aparezca el título "SELECCIONAR POSICIÓN"
            cmbTipoActo.SelectedIndex = -1
            cmbTipoActo.DataSource = dt
            cmbTipoActo.DisplayMember = "cDescActo"
            cmbTipoActo.ValueMember = "nIdActo"
        Catch ex As Exception
            MuestraMensaje(ex.ToString, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub PlLlenaComboActosFiltrado(ByRef CodGrupo As Int32)
        Try
            Dim dt As DataTable = FabricaJuridico.FcObtieneActosFiltrados(CodGrupo)

            'Añadimos una nueva fila al objeto DataTable
            Dim row As DataRow = dt.NewRow
            'Establecemos el valor del campo Nombre
            row("cDescActo") = "SELECCIONAR ACTO"
            ''Establecemos el valor de otro Campo
            row("nIdActo") = 0
            ''Insertamos la fila en la primera posición
            dt.Rows.InsertAt(row, 0)
            'Se cambia el indice para que aparezca el título "SELECCIONAR POSICIÓN"
            cmbTipoActo.SelectedIndex = -1
            cmbTipoActo.DataSource = dt
            cmbTipoActo.DisplayMember = "cDescActo"
            cmbTipoActo.ValueMember = "nIdActo"

        Catch ex As Exception
            MuestraMensaje(ex.ToString, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "Overrides"
    Protected Overrides Sub ClickBotonNuevo()
        MyBase.ClickBotonNuevo()
        If bClickBtnLimpiar Then
            If MensajeConfirmaLimpiarPantalla() = Windows.Forms.DialogResult.No Then Return
        End If
        'PlLlenaComboActos()
        PlLimpiarTexto(gpBoxGrupos)
        AtxSubTipo.Enabled = True
        lblOperacion.Text = String.Empty
        'chckButtonActivo.Checked = True
        With Me.ToolBarButtons
            .Guardar = False
        End With
        cmbGrupo.SelectedIndex = 0
        If cmbTipoActo.Items.Count > 0 Then
            cmbTipoActo.SelectedIndex = 0
        End If
        AtxSubTipo.Select()
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
            obj(0) = AtxSubTipo.Text
            obj(1) = lblOperacion.Text
            obj(2) = AtxDescripcion.Text
            obj(3) = cmbGrupo.SelectedValue
            obj(4) = cmbTipoActo.SelectedValue
            'obj(5) = AtxObservaciones.Text
            'obj(6) = chckButtonActivo.Checked
            ADDA.AbreTransaccion()
            vRes = EscribanoJuridico.GuardarSubActos(obj)
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