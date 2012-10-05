Imports LogicaNegocio.ClsGestor
Public Class ctlRegistrarCliente
    Dim _gestor As New LogicaNegocio.ClsGestor
    Dim _resul As Boolean

    Private Sub ctlRegistrarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCedula.Focus()
        limpiar()
    End Sub

    Public Sub limpiar()
        txtCedula.Text = ""
        txtNombre.Text = ""
        txtTelefono.Text = ""
        txtDireccion.Text = ""
        txtFechaIngreso.Text = Now
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function evaluarEspacion() As Boolean
        _resul = False
        If Me.txtCedula.Text = "" Then
            MsgBox("La cédula del cliente es un dato requerido.", MsgBoxStyle.Information, "Registrar Cliente")
            Me.txtCedula.Focus()

        ElseIf Me.txtNombre.Text = "" Then
            MsgBox("El nombre del cliente es un dato requerido.", MsgBoxStyle.Information, "Registrar Cliente")
            Me.txtNombre.Focus()

        ElseIf Me.txtTelefono.Text = "" Then
            MsgBox("El teléfono del cliente es un dato requerido.", MsgBoxStyle.Information, "Registrar Cliente")
            Me.txtTelefono.Focus()

        ElseIf Me.txtDireccion.Text = "" Then
            MsgBox("La dirección del cliente es un dato requerido.", MsgBoxStyle.Information, "Registrar Cliente")
            Me.txtDireccion.Focus()
        Else
            _resul = True
        End If

        Return _resul
    End Function

    Private Sub pbLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbLimpiar.Click
        limpiar()
    End Sub

    Private Sub pbRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegistrar.Click
        'declarar variables tipo
        Dim _ced As String
        Dim _nombre As String
        Dim _direccion As String
        Dim _telefono As String
        Dim _fechaIngreso As Date

        _resul = evaluarEspacion()
        If _resul = True Then
            _ced = txtCedula.Text
            _nombre = txtNombre.Text
            _telefono = txtTelefono.Text
            _direccion = txtDireccion.Text
            _fechaIngreso = txtFechaIngreso.Text

            Try
                _gestor.registrarCliente(_ced, _nombre, _direccion, _telefono, _fechaIngreso) 'invocar el método indicado enviando los argumentos requeridos.
                MsgBox("Los datos del cliente se ha registrado correctamente.", MsgBoxStyle.Information, "Registrar Cliente")
                limpiar() 'invocar a la subrutina dedicada a limpiar los controles indicados.

            Catch ex As Exception
                MsgBox("Los datos ingresados ya existen en la base de datos." & ex.Message, MsgBoxStyle.Information, "Registrar Cliente")
            End Try
        End If
    End Sub

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
        CType(Me.ParentForm, frmCentroAgricola).cargarUserControl(New ctlPrincipal)
    End Sub
End Class
