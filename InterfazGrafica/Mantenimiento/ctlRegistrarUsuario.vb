Imports LogicaNegocio.ClsGestor
Public Class ctlRegistrarUsuario

    Dim _gestor As New LogicaNegocio.ClsGestor
    Dim _resul As Boolean
    Private Sub ctlRegistrarUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCedula.Focus()
        limpiar()
    End Sub

    Public Sub limpiar()
        txtCedula.Text = ""
        txtNombre.Text = ""
        txtApellido1.Text = ""
        txtApellido2.Text = ""
        txtContrasenna.Text = ""
        cmbRol.SelectedIndex = 0
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function evaluarEspacion() As Boolean
        _resul = False
        If Me.txtCedula.Text = "" Then
            MsgBox("La cédula del usuario es un dato requerido.", MsgBoxStyle.Information, "Registrar Usuario")
            Me.txtCedula.Focus()

        ElseIf Me.txtNombre.Text = "" Then
            MsgBox("El nombre del usuario es un dato requerido.", MsgBoxStyle.Information, "Registrar Usuario")
            Me.txtNombre.Focus()

        ElseIf Me.txtApellido1.Text = "" Then
            MsgBox("El primer apellido del usuario es un dato requerido.", MsgBoxStyle.Information, "Registrar Usuario")
            Me.txtApellido1.Focus()

        ElseIf Me.txtApellido2.Text = "" Then
            MsgBox("El segundo apellido del usuario es un dato requerido.", MsgBoxStyle.Information, "Registrar Usuario")
            Me.txtApellido2.Focus()

        ElseIf Me.txtContrasenna.Text = "" Then
            MsgBox("La contraseña del usuario es un dato requerido.", MsgBoxStyle.Information, "Registrar Usuario")
            Me.txtContrasenna.Focus()

        ElseIf Me.cmbRol.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar un rol del usuario.", MsgBoxStyle.Information, "Registrar Usuario")

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
        Dim _apellido1 As String
        Dim _apellido2 As String
        Dim _contrasenna As String
        Dim _rol As String

        _resul = evaluarEspacion()
        If _resul = True Then
            _ced = txtCedula.Text
            _nombre = txtNombre.Text
            _apellido1 = txtApellido1.Text
            _apellido2 = txtApellido2.Text
            _contrasenna = txtContrasenna.Text
            _rol = cmbRol.SelectedItem.ToString()

            Try
                _gestor.registrarUsuario(_ced, _nombre, _apellido1, _apellido2, _contrasenna, _rol) 'invocar el método indicado enviando los argumentos requeridos.
                MsgBox("Los datos del usuario se ha registrado correctamente.", MsgBoxStyle.Information, "Registrar Usuario")
                limpiar() 'invocar a la subrutina dedicada a limpiar los controles indicados.

            Catch ex As Exception
                MsgBox("Los datos ingresados ya existen en la base de datos." & ex.Message, MsgBoxStyle.Information, "Registrar Usuario")
            End Try
        End If
    End Sub

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
        CType(Me.ParentForm, frmCentroAgricola).cargarUserControl(New ctlPrincipal)
    End Sub
End Class
