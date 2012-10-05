Imports LogicaNegocio.ClsGestor
Public Class ctlRegistrarAuxiliar

    Dim _gestor As New LogicaNegocio.ClsGestor
    Dim _popudRegistrarFeria As New PopupRegistrarFeriaAux
    Dim _resul As Boolean
    Dim _listaFeria As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
    Dim _tempArray As Array 'declarar una variable tipo Array


    Private Sub ctlRegistrarAuxiliar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCodigo.Focus()
        limpiar()
        cargarFerias()
    End Sub

    Public Sub limpiar()
        txtCodigo.Text = ""
        txtCedula.Text = ""
        txtNombre.Text = ""
        txtTelefono.Text = ""
        cmbParentesco.SelectedIndex = 0
        ltbFeriaAsiste.Items.Clear()
    End Sub
    ''' <summary>
    ''' Método de clase, encargado de cargar todos las ferias existentes en la DB
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub cargarFerias() 'Lo tenemos que hacer public para que la otra clase pueda acceder al cargarFerias
        Try
            Dim _listaFerias As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array

            _listaFerias = _gestor.listarFerias() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            Dim _tempArray As Array 'declarar una variable tipo Array

            Dim _listTemp As New List(Of ClsCastCadenaFeria) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)

            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado
            For i As Integer = 0 To _listaFerias.Count - 1
                _tempArray = _listaFerias(i) 'clonar a un Array temporal la FILA (ROW) de la consulta

                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)

                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next
                _listTemp.Add(New ClsCastCadenaFeria(_tempCast(0).ToString(), _tempCast(1).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next
            'asignar el fuente de dato para un control tipo listbox la lista genérica wrappeada
            Me.ltbFeria.DataSource = _listTemp
            Me.ltbFeria.DisplayMember = "nombreFeria"
            Me.ltbFeria.ValueMember = "codigo"

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Registrar Socio")
        End Try
    End Sub
    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function evaluarEspacion() As Boolean
        _resul = False
        If Me.txtCodigo.Text = "" Then
            MsgBox("El código del auxiliar es un dato requerido.", MsgBoxStyle.Information, "Registrar Auxiliar")
            Me.txtCodigo.Focus()

        ElseIf Me.txtCedula.Text = "" Then
            MsgBox("La cédula del auxiliar es un dato requerido.", MsgBoxStyle.Information, "Registrar Auxiliar")
            Me.txtCedula.Focus()

        ElseIf Me.txtNombre.Text = "" Then
            MsgBox("El nombre del auxiliar es un dato requerido.", MsgBoxStyle.Information, "Registrar Auxiliar")
            Me.txtNombre.Focus()

        ElseIf Me.txtTelefono.Text = "" Then
            MsgBox("El teléfono del auxiliar es un dato requerido.", MsgBoxStyle.Information, "Registrar Auxiliar")
            Me.txtTelefono.Focus()

        ElseIf Me.cmbParentesco.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar un parentesco del auxiliar.", MsgBoxStyle.Information, "Registrar Auxiliar")

        ElseIf ltbFeriaAsiste.Items.Count = 0 Then
            MsgBox("Debe de asignarle una feria al auxiliar", MsgBoxStyle.Information, "Registrar Auxiliar")

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
        Dim _cod As String
        Dim _ced As String
        Dim _nombre As String
        Dim _telefono As String
        Dim _parentesco As String
        Dim _codFerias As New ArrayList
        _resul = evaluarEspacion()
        If _resul = True Then

            _cod = txtCodigo.Text
            _ced = txtCedula.Text
            _nombre = txtNombre.Text
            _telefono = txtTelefono.Text
            _parentesco = cmbParentesco.SelectedItem.ToString

            For Each feria In ltbFeriaAsiste.Items
                _codFerias.Add(CType(feria, ClsCastCadenaFeria).codigo)
            Next
            Try
                _gestor.registrarAuxiliar(_cod, _ced, _nombre, _telefono, _parentesco, _codFerias) 'invocar el método indicado enviando los argumentos requeridos.
                MsgBox("Los datos del auxiliar se ha registrado correctamente.", MsgBoxStyle.Information, "Registrar Auxiliar")
                limpiar() 'invocar a la subrutina dedicada a limpiar los controles indicados.

            Catch ex As Exception
                MsgBox("Los datos ingresados ya existen en la base de datos." & ex.Message, MsgBoxStyle.Information, "Registrar Auxiliar")
            End Try
        End If
    End Sub

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
        CType(Me.ParentForm, frmCentroAgricola).cargarUserControl(New ctlPrincipal)
    End Sub

    Private Sub pbInsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbInsertar.Click
        For Each i In ltbFeria.SelectedIndices
            ltbFeriaAsiste.Items.Add(ltbFeria.Items(i))
            ltbFeriaAsiste.DisplayMember = "nombreFeria"
            ltbFeriaAsiste.ValueMember = "codigo"

            Dim _listTemp As List(Of ClsCastCadenaFeria) = CType(ltbFeria.DataSource, List(Of ClsCastCadenaFeria))
            _listTemp.RemoveAt(i)

            Dim _listTemp2 As New List(Of ClsCastCadenaFeria)
            For x As Integer = 0 To _listTemp.Count - 1
                _listTemp2.Add(_listTemp.Item(x))
            Next

            ltbFeria.DataSource = _listTemp2
            ltbFeria.DisplayMember = "nombreFeria"
            ltbFeria.ValueMember = "codigo"
            ltbFeria.Refresh()

        Next
    End Sub

    Private Sub pbQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbQuitar.Click
        For Each i In ltbFeriaAsiste.SelectedIndices

            Dim _listTemp As List(Of ClsCastCadenaFeria) = CType(ltbFeria.DataSource, List(Of ClsCastCadenaFeria))
            _listTemp.Add(ltbFeriaAsiste.Items(i))

            Dim _listTemp2 As New List(Of ClsCastCadenaFeria)

            For x As Integer = 0 To _listTemp.Count - 1
                _listTemp2.Add(_listTemp.Item(x))
            Next

            ltbFeria.DataSource = _listTemp2
            ltbFeria.DisplayMember = "nombreFeria"
            ltbFeria.ValueMember = "codigo"

            ltbFeriaAsiste.Items.RemoveAt(i)

        Next
    End Sub

    Private Sub pbIrRegistrarFeria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbIrRegistrarFeria.Click
        _popudRegistrarFeria.PantallaSocioConDatosAux = Me
        _popudRegistrarFeria.ShowDialog()
    End Sub

    Private Sub txtNombreBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreBuscar.TextChanged
        If txtNombreBuscar.Text = "" Then
            cargarFerias()
        Else
            buscarFeriaPorNombre(Me.txtNombreBuscar.Text)
        End If
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

            Me.ltbFeria.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            ltbFeria.DisplayMember = "nombreFeria"
            ltbFeria.ValueMember = "codigo"
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Feria")
        End Try

    End Sub
End Class
