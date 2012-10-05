Imports LogicaNegocio.ClsGestor
Public Class ctlRegistrarOrden

    Dim _gestor As New LogicaNegocio.ClsGestor
    Dim _listaCliente As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
    Dim _tempArray As Array 'declarar una variable tipo Array
    Dim _criterio As String
    Dim _resul As Boolean
    Dim _mesNum As Int32

    Private Sub ctlRegistrarOrden_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCriterio.Focus()
        limpiarForm()
        nombrarColumnas()
        invisible()
        txtCedula.Text = dgvDatos.SelectedCells(0).Value
        txtNombre.Text = dgvDatos.SelectedCells(1).Value
        txtAnno.Text = Now.Year
    End Sub

    Private Sub txtCriterio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriterio.TextChanged
        evaluar()
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
        Me.cmbMes.SelectedIndex = 0
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
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de poner invisible algunas calumnas al datagridview
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub invisible()
        dgvDatos.Columns(2).Visible = False
        dgvDatos.Columns(3).Visible = False
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

    Public Sub limpiar()
        txtAnno.Text = Now.Year
        cmbMes.SelectedIndex = 0
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function evaluarEspacion() As Boolean
        _resul = False
        If Me.txtCedula.Text = "" Then
            MsgBox("La cédula del cliente es un dato requerido.", MsgBoxStyle.Information, "Registrar Orden")
            Me.txtCedula.Focus()

        ElseIf Me.txtNombre.Text = "" Then
            MsgBox("El nombre del auxiliar es un dato requerido.", MsgBoxStyle.Information, "Registrar Orden")
            Me.txtNombre.Focus()

        ElseIf Me.cmbMes.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar un mes de la orden.", MsgBoxStyle.Information, "Registrar Orden")

        ElseIf Me.txtAnno.Text = "" Then
            MsgBox("El año de la orden es un dato requerido.", MsgBoxStyle.Information, "Registrar Orden")
            Me.txtAnno.Focus()

        ElseIf Me.txtMonto.Text = "" Then
            MsgBox("El monto de la orden es un dato requerido.", MsgBoxStyle.Information, "Registrar Orden")
            Me.txtMonto.Focus()

        ElseIf Me.txtSalarioBase.Text = "" Then
            MsgBox("El salario de la orden es un dato requerido.", MsgBoxStyle.Information, "Registrar Orden")
            Me.txtSalarioBase.Focus()


        Else
            _resul = True
        End If

        Return _resul
    End Function

    Public Function obtenerFechaVence(ByVal pfechaCrea As Date) As Date
        'Dim _fechaVence As Date

        Dim annoVence As Integer = pfechaCrea.Year
        Dim mesVence As Integer = pfechaCrea.Month + 1
        Dim diaVence As Integer = 10

        'Si es diciembre el mes es 12 + 1 = 13, tenemos que poner enero 1
        If (mesVence = 13) Then
            mesVence = 1
            annoVence = pfechaCrea.Year + 1
        End If

        Dim _fechaVence As New Date(annoVence, mesVence, diaVence)


        '_fechaVence.AddDays(10)
        '_fechaVence.AddMonths(pfechaCrea.Month + 1)
        '_fechaVence.AddYears(pfechaCrea.Year)
        '_fechaVence = pfechaCrea.AddDays(10)
        '_fechaVence = pfechaCrea.AddMonths(1)

        Return _fechaVence

    End Function

    Private Sub pbLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbLimpiar.Click
        limpiar()
    End Sub

    Private Sub pbRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegistrar.Click
        'declarar variables tipo
        Dim _ced As String
        Dim _mes As String
        Dim _anno As Int32
        Dim _fechaCrea As Date
        Dim _fechaVence As Date
        Dim _monto As Int32
        Dim _salario As Int32
        Dim _estado As String

        _resul = evaluarEspacion()
        If _resul = True Then

            _ced = txtCedula.Text
            _mes = cmbMes.SelectedItem.ToString
            _mesNum = obtenerNumeroMes(_mes)
            _anno = txtAnno.Text
            _fechaCrea = Now.Date
            _fechaVence = obtenerFechaVence(_fechaCrea)
            _monto = txtMonto.Text
            _salario = txtSalarioBase.Text
            _estado = "PENDIENTE"
            Try
                _gestor.registrarOrden(_ced, _mes, _mesNum, _anno, _fechaCrea, _fechaVence, _monto, _salario, _estado) 'invocar el método indicado enviando los argumentos requeridos.
                MsgBox("Los datos de la orden se ha registrado correctamente.", MsgBoxStyle.Information, "Registrar Orden")

            Catch ex As Exception
                MsgBox("Los datos ingresados ya existen en la base de datos." & ex.Message, MsgBoxStyle.Information, "Registrar Orden")
            End Try
        End If
    End Sub

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
        CType(Me.ParentForm, frmCentroAgricola).cargarUserControl(New ctlPrincipal)
    End Sub

    Private Sub dgvDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        txtCedula.Text = dgvDatos.SelectedCells(0).Value
        txtNombre.Text = dgvDatos.SelectedCells(1).Value
    End Sub

    Private Function obtenerNumeroMes(ByVal pmes As String) As Int32
        Dim _numMes As Int32

        If pmes = "ENERO" Then
            _numMes = 1
        ElseIf pmes = "FEBRERO" Then
            _numMes = 2
        ElseIf pmes = "MARZO" Then
            _numMes = 3
        ElseIf pmes = "ABRIL" Then
            _numMes = 4
        ElseIf pmes = "MAYO" Then
            _numMes = 5
        ElseIf pmes = "JUNIO" Then
            _numMes = 6
        ElseIf pmes = "JULIO" Then
            _numMes = 7
        ElseIf pmes = "AGOSTO" Then
            _numMes = 8
        ElseIf pmes = "SETIEMBRE" Then
            _numMes = 9
        ElseIf pmes = "OCTUBRE" Then
            _numMes = 10
        ElseIf pmes = "NOVIEMBRE" Then
            _numMes = 11
        ElseIf pmes = "DICIEMBRE" Then
            _numMes = 12
        End If

        Return _numMes
    End Function

    Private Sub pbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbImprimir.Click

        Try
            'Dim reporte As New OrdenesMes
            Dim reporte As New OrdenesMesPrue
            Dim _mes As Int32 = _mesNum
            Dim _anno As Int32 = txtAnno.Text
            reporte.SetParameterValue("mes", _mes)
            reporte.SetParameterValue("anno", _anno)
            reporte.PrintToPrinter(1, False, 1, 100)
            limpiar() 'invocar a la subrutina dedicada a limpiar los controles indicados.
            'reporte.Refresh()
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al tratar de imprimir" & ex.Message)
        End Try
    End Sub
End Class
