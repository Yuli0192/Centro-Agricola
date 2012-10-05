Public Class PopupRegistrarFeria
    Dim _gestor As New LogicaNegocio.ClsGestor
    'vamos a guardar en una variable esa pantalla.
    Dim _pantallaSocioConDatos As ctlRegistrarSocio
    Dim _resul As Boolean

    'Propiedad para el atributo "_pantallaSocioConDatos"
    Public Property PantallaSocioConDatos() As ctlRegistrarSocio
        Get
            Return _pantallaSocioConDatos
        End Get
        Set(ByVal value As ctlRegistrarSocio)
            _pantallaSocioConDatos = value
        End Set
    End Property

    Private Sub pbRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegistrar.Click
        'declarar variables tipo
        Dim _cod As Int32
        Dim _nombre As String
        _resul = evaluarEspacion()
        If _resul = True Then

            'asignar a cada variable los valores indicados
            _cod = _gestor.obtenerMayorIdFeria() + 1
            _nombre = Me.txtNombre.Text
            Try
                _gestor.registrarFeria(_cod, _nombre) 'invocar el método indicado enviando los argumentos requeridos.
                MsgBox("Los datos de la feria se ha registrado correctamente.", MsgBoxStyle.Information, "Registrar Feria")
                Me.limpiar() 'invocar a la subrutina dedicada a limpiar los controles indicados.

                'Despues q se registra la feria lo escondemos y tenemos que actualizar la lista de ferias
                'para que salga la nueva que se registro, y para eso tenemos que acceder al metodo de la
                'clase ctlRegistrarSocio para q actualize esa lista, y vamos hacer lo mismo pasar el formulario
                'a este popud para que el pueda acceder a los metodos de ctlRegistrarSocio.
                'En la primera manera lo pasamos por el constructor... ahora lo vamos usar como una propiedad
                'para que vea de todas las diferentes formas que se puede hacer.
                Me.PantallaSocioConDatos.cargarFerias()
                Me.Hide()

            Catch ex As Exception
                MsgBox("Los datos ingresados ya existen en la base de datos." & ex.Message, MsgBoxStyle.Information, "Registrar Feria")
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function evaluarEspacion() As Boolean
        _resul = False
        If Me.txtNombre.Text = "" Then
            MsgBox("El nombre de la feria es un dato requerido.", MsgBoxStyle.Information, "Registrar Feria")
            Me.txtNombre.Focus()

        Else
            _resul = True
        End If

        Return _resul
    End Function

    Private Sub limpiar()
        Me.txtNombre.Text = ""
    End Sub

    Private Sub pbLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbCancelar.Click
        Me.limpiar()
        Me.Hide()  'HIde lo esconde... :p
    End Sub

    Private Sub PopupRegistrarFeria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class