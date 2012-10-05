Imports LogicaNegocio.ClsGestor
Public Class ctlRegistrarFinca

    Dim _gestor As New LogicaNegocio.ClsGestor
    Dim _resul As Boolean

    Private Sub ctlRegistrarFinca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNombre.Focus()
    End Sub

    Public Sub limpiar()
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtArea.Text = ""
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function evaluarEspacion() As Boolean
        _resul = False
        If Me.txtNombre.Text = "" Then
            MsgBox("El nombre de la finca es un dato requerido.", MsgBoxStyle.Information, "Registrar Finca")
            Me.txtNombre.Focus()

        ElseIf Me.txtDireccion.Text = "" Then
            MsgBox("La dirección de la finca es un dato requerido.", MsgBoxStyle.Information, "Registrar Finca")
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
        Dim _nombre As String
        Dim _direccion As String
        Dim _area As Int32

        _resul = evaluarEspacion()
        If _resul = True Then
            _nombre = txtNombre.Text
            _direccion = txtDireccion.Text

            If Me.txtArea.Text = "" Then
                _area = 0
            Else
                _area = txtArea.Text
            End If
            Try
                _gestor.registrarFinca(_nombre, _direccion, _area) 'invocar el método indicado enviando los argumentos requeridos.
                MsgBox("Los datos de la finca se ha registrado correctamente.", MsgBoxStyle.Information, "Registrar Finca")
                limpiar() 'invocar a la subrutina dedicada a limpiar los controles indicados.

            Catch ex As Exception
                MsgBox("Los datos ingresados ya existen en la base de datos." & ex.Message, MsgBoxStyle.Information, "Registrar Finca")
            End Try
        End If
    End Sub

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
        CType(Me.ParentForm, frmCentroAgricola).cargarUserControl(New ctlPrincipal)
    End Sub
End Class
