Imports LogicaNegocio.ClsGestor
'Ve esta es la clase... ctlRegistrarFeria... tenemos que modificar el constructor...
Public Class ctlRegistrarFeria

    Dim _gestor As New LogicaNegocio.ClsGestor
    Dim _listaFeria As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
    Dim _tempArray As Array 'declarar una variable tipo Array
    Dim _resul As Boolean

    'vamos a guardar en una variable esa pantalla.
    Dim _pantallaSocioConDatos As ctlRegistrarSocio

    'Constructor que recibe el formulario de socio cuando se esta registrando para no 
    'Perder los datos
    Public Sub New(ByRef ppantallaSocio As ctlRegistrarSocio) 'Le decimos que va a reciibir un parametro

        'Este Metodo es el que inicializa todos los controles que usted
        'arrastro en la pantalla de ctlRegistrarFeria... y siemrpre tiene que
        'ir de primero en el constructor de los formularios.
        InitializeComponent()

        'Ahora agregamos nuestro codigo.
        _pantallaSocioConDatos = ppantallaSocio
    End Sub


    'Constructor que no recibe nada para cuando se llama en algun otro lugar.. y no se necesta
    'pasar ningun parametro
    Public Sub New()

        'Este Metodo es el que inicializa todos los controles que usted
        'arrastro en la pantalla de ctlRegistrarFeria... y siemrpre tiene que
        'ir de primero en el constructor de los formularios.
        InitializeComponent()
    End Sub

    Private Sub ctlRegistrarFeria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNombre.Focus()
        limpiar()
        nombrarColumnas()
    End Sub

    Private Sub limpiar()
        Me.dgvDato.DataSource = ""
        Me.txtNombreBuscar.Text = ""
        cargarFerias()
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

    ''' <summary>
    ''' Método de clase, encarga de limpiar los componentes 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub limpiarForm()
        txtNombre.Text = ""
        cargarFerias()
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
            'asignar a cada variable los valores indicados
            _cod = obtenerMayorId() + 1
            _nombre = Me.txtNombre.Text
            Try
                _gestor.registrarFeria(_cod, _nombre) 'invocar el método indicado enviando los argumentos requeridos.
                MsgBox("Los datos de la feria se ha registrado correctamente.", MsgBoxStyle.Information, "Registrar Feria")
                Me.limpiarForm() 'invocar a la subrutina dedicada a limpiar los controles indicados.
                cargarFerias()
            Catch ex As Exception
                MsgBox("Los datos ingresados ya existen en la base de datos." & ex.Message, MsgBoxStyle.Information, "Registrar Feria")
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
            cargarFerias()
        Else
            buscarFeriaPorNombre(Me.txtNombreBuscar.Text)
        End If
    End Sub

    Private Sub evaluar()

        If txtNombreBuscar.Text.Equals("") Then
            cargarFerias()
        Else
            Me.dgvDato.DataSource = ""
        End If
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de renombrar los encabezados al datagridview
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub nombrarColumnas()
        dgvDato.Columns(0).HeaderText = "Código"
        dgvDato.Columns(1).HeaderText = "Nombre"
    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar las ferias existentes en la DB con el nombre suministado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub buscarFeriaPorNombre(ByVal pnombre As String)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaFeria) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaFeria = _gestor.buscarFeriaPorNombre(pnombre) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaFeria.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaFeria(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaFeria(_tempCast(0).ToString(), _tempCast(1).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            Me.dgvDato.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            nombrarColumnas()

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Feria")
        End Try

    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar las ferias existentes en la DB con el nombre suministado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargarFerias()
        Try
            Dim _listTemp As New List(Of ClsCastCadenaFeria) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaFeria = _gestor.listarFerias() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaFeria.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaFeria(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaFeria(_tempCast(0).ToString(), _tempCast(1).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            Me.dgvDato.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            nombrarColumnas()
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Producto")
        End Try

    End Sub

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
        CType(Me.ParentForm, frmCentroAgricola).cargarUserControl(New ctlPrincipal)
    End Sub

    Private Sub pbIrRegistrarSocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbIrRegistrarSocio.Click
        'Vea al hacer usted New ctlRegistrarSociio esta creando otro objeto totalmetne nuevo... entonces
        'eso quiere decir que no tiene nada de datos.... por eso le sale en blanco... por que el objeto
        'ctlRegistrarSocio donde usted metio la identificacion se pierde en el momento que usted hace el New.
        'Y para hacer esto hay 2 maneras mi amor... una es que en el constructo de ctlRegistrarFeria pase
        'El objeto ctlRegistrarsocio que tiene los datos... para q no los pierda... 
        'y la otra es tirar una ventanita en el mismo formulario ctlRegistrarSocio.. para q no cambie de 
        'pantalla... vamos hacer las dos... para q aprenda las dos formas... vea todos los movimientos :p
        'ponga mucha atencion mi princesa...
        'Ve y aqui en ves de crear una nueva pantalla... pone la que tiene los datos
        'frmCentroAgricola.cargarUserControl(New ctlRegistrarSocio)
        '_pantallaSocioConDatos.cargarFerias()
        CType(Me.ParentForm, frmCentroAgricola).cargarUserControl(New ctlRegistrarSocio)
    End Sub
End Class
