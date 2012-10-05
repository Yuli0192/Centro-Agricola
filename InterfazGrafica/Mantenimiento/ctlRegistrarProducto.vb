Imports LogicaNegocio.ClsGestor
Public Class ctlRegistrarProducto

    Dim _gestor As New LogicaNegocio.ClsGestor
    Dim _listaProducto As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
    Dim _tempArray As Array 'declarar una variable tipo Array
    Dim _unidad As Int32
    Dim _resul As Boolean

    Private Sub ctlRegistrarProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNombre.Focus()
        limpiar()
        nombrarColumnas()
        invisible()
    End Sub

    Private Sub limpiar()
        Me.dgvDato.DataSource = ""
        Me.txtNombreBuscar.Text = ""
        cargarProductos()
        'Dim datos As String = "carlosquiereayuli"
        'datos = datos.ToUpper()

    End Sub

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function evaluarEspacion() As Boolean
        _resul = False
        If Me.txtNombre.Text = "" Then
            MsgBox("El nombre del producto es un dato requerido.", MsgBoxStyle.Information, "Registrar Producto")
            Me.txtNombre.Focus()

        Else
            _resul = True
        End If

        Return _resul
    End Function

    ''' <summary>
    ''' Método de clase, encarga de evaluar cual radio esta checked
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub evaluarChecked()

        If rbtJava.Checked Then
            _unidad = 1

        ElseIf rbtKilogramo.Checked Then
            _unidad = 2

        ElseIf rbtRollo.Checked Then
            _unidad = 3

        ElseIf rbtUnidad.Checked Then
            _unidad = 4

        ElseIf rbtRacimo.Checked Then
            _unidad = 5
        End If
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de limpiar los componentes 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub limpiarForm()
        txtNombre.Text = ""
        rbtJava.Checked = True
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de limpiar los componentes 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub pbLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbLimpiar.Click
        limpiarForm()
    End Sub

    Private Sub pbRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegistrar.Click
        'declarar variables tipo
        Dim _cod As Int32
        Dim _nombre As String
        _resul = evaluarEspacion()
        If _resul = True Then
            evaluarChecked()
            'asignar a cada variable los valores indicados
            _cod = obtenerMayorId() + 1
            _nombre = Me.txtNombre.Text
            Try
                _gestor.registrarProducto(_cod, _nombre, _unidad) 'invocar el método indicado enviando los argumentos requeridos.
                MsgBox("Los datos del producto se ha registrado correctamente.", MsgBoxStyle.Information, "Registrar Producto")
                Me.limpiarForm() 'invocar a la subrutina dedicada a limpiar los controles indicados.
                cargarProductos()
            Catch ex As Exception
                MsgBox("Los datos ingresados ya existen en la base de datos." & ex.Message, MsgBoxStyle.Information, "Registrar Producto")
            End Try
        End If
    End Sub
   
    Private Function obtenerMayorId() As Int32

        Dim idTemp As Integer
        Dim idMax As Integer = 0

        For i As Integer = 0 To dgvDato.Rows.Count - 1
            idTemp = CInt(dgvDato.Rows.Item(i).Cells("Codigo").Value)

            If idTemp > idMax Then
                idMax = idTemp
            End If
        Next

        Return idMax
    End Function

    Private Sub txtNombreBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreBuscar.TextChanged
        evaluar()
        If txtNombreBuscar.Text = "" Then
            cargarProductos()
        Else
            buscarProductoPorNombre(Me.txtNombreBuscar.Text)
        End If
    End Sub

    Private Sub evaluar()

        If txtNombreBuscar.Text.Equals("") Then
            cargarProductos()
        Else
            Me.dgvDato.DataSource = ""
        End If
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de renombrar los encabezados al datagridview
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub nombrarColumnas()
        dgvDato.Columns(1).HeaderText = "Nombre"
        dgvDato.Columns(3).HeaderText = "Unidad"
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de poner invisible algunas calumnas al datagridview
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub invisible()
        dgvDato.Columns(0).Visible = False
        dgvDato.Columns(2).Visible = False
    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar los productos existentes en la DB con el nombre suministado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub buscarProductoPorNombre(ByVal pnombre As String)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaProducto) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaProducto = _gestor.buscarProductoPorNombre(pnombre) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaProducto.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaProducto(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaProducto(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            Me.dgvDato.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            nombrarColumnas()
            invisible()
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Producto")
        End Try

    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar los productos existentes en la DB con el nombre suministado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargarProductos()
        Try
            Dim _listTemp As New List(Of ClsCastCadenaProducto) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaProducto = _gestor.listarProductos() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaProducto.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaProducto(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaProducto(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            Me.dgvDato.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            nombrarColumnas()
            invisible()
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Producto")
        End Try

    End Sub

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
        CType(Me.ParentForm, frmCentroAgricola).cargarUserControl(New ctlPrincipal)
    End Sub

    Private Sub lblNombreBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNombreBuscar.Click

    End Sub
End Class
