Imports LogicaNegocio.ClsGestor
Public Class ctlBuscarClienteActivo

    Dim _gestor As New LogicaNegocio.ClsGestor
    Dim _listaCliente As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
    Dim _tempArray As Array 'declarar una variable tipo Array
    Dim _criterio As String
    Dim _resul As Boolean
    'declarar variables tipo
    Dim _ced As String
    Dim _nombre As String
    Dim _direccion As String
    Dim _telefono As String
    Dim _fechaIngreso As Date
    Dim _salarioBase As Int32
    Dim _cuota As Int32

    Private Sub ctlBuscarClienteActivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCriterio.Focus()
        limpiarForm()
        nombrarColumnas()
        invisible()
    End Sub

    Private Sub txtCriterio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriterio.TextChanged
        evaluar()
        QuitarControles()
        If txtCriterio.Text = "" Then
            cargarClientes()
            nombrarColumnas()
            invisible()
        Else
            buscarCriterioCliente(txtCriterio.Text)
        End If
    End Sub

    Private Sub limpiarForm()
        Me.dgvDatos.DataSource = ""
        Me.txtCriterio.Text = ""
        cargarClientes()
    End Sub

    Private Sub evaluar()

        If txtCriterio.Text.Equals("") Then
            cargarClientes()
            nombrarColumnas()
            invisible()
        Else
            Me.dgvDatos.DataSource = ""
        End If

    End Sub

    ''' <summary>
    ''' Método de clase, encarga de renombrar los encabezados al datagridview
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub nombrarColumnas()
        dgvDatos.Columns(0).HeaderText = "Identificación"
        dgvDatos.Columns(1).HeaderText = "Nombre"
        dgvDatos.Columns(1).MinimumWidth = 130
        dgvDatos.Columns(3).HeaderText = "Teléfono"
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de poner invisible algunas calumnas al datagridview
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub invisible()
        dgvDatos.Columns(2).Visible = False
        dgvDatos.Columns(4).Visible = False
        dgvDatos.Columns(5).Visible = False
        dgvDatos.Columns(6).Visible = False
        dgvDatos.Columns(7).Visible = False
    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar los clientes existentes en la DB con el nombre suministado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargarClientes()
        Try
            Dim _listTemp As New List(Of ClsCastCadenaCliente) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaCliente = _gestor.listarClientes() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaCliente.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaCliente(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaCliente(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString(), _tempCast(7).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            Me.dgvDatos.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Cliente")
        End Try

    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar el cliente existente en la DB con el id suministado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub buscarCriterioCliente(ByVal pcriterio As String)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaCliente) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaCliente = _gestor.buscarCriterioCliente(pcriterio) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaCliente.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaCliente(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next
                _listTemp.Add(New ClsCastCadenaCliente(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString(), _tempCast(7).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next
            Me.dgvDatos.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            nombrarColumnas()
            invisible()
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Cliente")
        End Try
    End Sub

    Private Sub pbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbEliminar.Click
        If Not dgvDatos.RowCount = 0 Then
            _ced = Me.dgvDatos.SelectedCells(0).Value
            Dim _result As DialogResult
            _result = MessageBox.Show("¿Está seguro que desea eliminar el cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)
            Try
                If _result = Windows.Forms.DialogResult.Yes Then
                    _gestor.eliminarCliente(_ced) 'invocar el método indicado enviando los argumentos requeridos.
                    MsgBox("Los datos del cliente se han eliminado.", MsgBoxStyle.Information, "Eliminar Cliente")
                Else
                    MsgBox("Los datos del cliente no se pueden eliminar.", MsgBoxStyle.Information, "Eliminar Cliente")
                End If
            Catch ex As Exception
                MsgBox("Los datos del cliente no se pueden eliminar." & ex.Message, MsgBoxStyle.Information, "Eliminar Cliente")
            End Try
            limpiarForm()
            nombrarColumnas()
            invisible()
        End If
    End Sub

    Private Sub pbModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbModificar.Click
        If Not dgvDatos.RowCount = 0 Then
            visibleControl()
            _ced = Me.dgvDatos.SelectedCells(0).Value
            _nombre = Me.dgvDatos.SelectedCells(1).Value
            _direccion = Me.dgvDatos.SelectedCells(2).Value
            _telefono = Me.dgvDatos.SelectedCells(3).Value
            _fechaIngreso = Me.dgvDatos.SelectedCells(4).Value
            '_salarioBase = Me.dgvDatos.SelectedCells(5).Value
            '_cuota = Me.dgvDatos.SelectedCells(6).Value

            modificar(_ced, _nombre, _direccion, _telefono, _fechaIngreso)
        End If
    End Sub

    ''' <summary>
    ''' Método d clase, encargado de hacer visible componentes
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub visibleControl()
        Me.gpbModificarCliente.Visible = True
    End Sub

    ''' <summary>
    ''' Método d clase, encargado de hacer invisible componentes
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub QuitarControles()
        Me.gpbModificarCliente.Visible = False
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


    ''' <summary>
    ''' Método de clase, encarga de asignarle los valores a cada componente
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub modificar(ByVal pced As String, ByVal pnombre As String, ByVal pdireccion As String, ByVal ptelefono As String, ByVal pfechaIngreso As Date)
        With Me
            .txtCedula.Text = pced
            .txtNombre.Text = pnombre
            .txtTelefono.Text = ptelefono
            .txtDireccion.Text = pdireccion
            .txtFechaIngreso.Text = pfechaIngreso
        End With

    End Sub

    Private Sub pbConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbConfirmar.Click
        Dim _result As DialogResult
        _resul = evaluarEspacion()
        '_numero = False
        If _resul = True Then

            'asignar a cada variable los valores indicados
            _ced = Me.txtCedula.Text
            _nombre = Me.txtNombre.Text
            _direccion = Me.txtDireccion.Text
            _telefono = Me.txtTelefono.Text
            _fechaIngreso = Me.txtFechaIngreso.Text
            _salarioBase = 0
            _cuota = 0
            _result = MessageBox.Show("¿Está seguro que desea modificar los datos del cliente?", "Modificar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)

            Try
                If _result = Windows.Forms.DialogResult.Yes Then
                    _gestor.modificarCliente(_ced, _nombre, _direccion, _telefono, _fechaIngreso, _salarioBase, _cuota) 'invocar el método indicado enviando los argumentos requeridos.
                    MsgBox("Los datos del cliente son modificados.", MsgBoxStyle.Information, "Modificar Cliente")
                    QuitarControles()
                Else
                    MsgBox("Los datos del cliente no son modificados.", MsgBoxStyle.Information, "Modificar Cliente")
                End If
            Catch ex As Exception
                MsgBox("Los datos ingresados ya existen en la base de datos.", MsgBoxStyle.Information, "Modificar Cliente")
            End Try
        End If
        cargarClientes()
        nombrarColumnas()
        invisible()
    End Sub

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
        CType(Me.ParentForm, frmCentroAgricola).cargarUserControl(New ctlPrincipal)
    End Sub
End Class
