Imports LogicaNegocio.ClsGestor
Public Class ctlBuscarFinca
    Dim _gestor As New LogicaNegocio.ClsGestor
    Dim _listaFinca As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
    Dim _tempArray As Array 'declarar una variable tipo Array
    Dim _criterio As String
    Dim _resul As Boolean

    'declarar variables tipo
    Dim _cod As Int32
    Dim _nombre As String
    Dim _direccion As String
    Dim _area As Int32

    Private Sub ctlBuscarFinca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCriterio.Focus()
        limpiarForm()
        nombrarColumnas()
        invisible()
    End Sub

    Private Sub txtCriterio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriterio.TextChanged
        evaluar()
        QuitarControles()
        If txtCriterio.Text = "" Then
            cargarFincas()
            nombrarColumnas()
            invisible()
        Else
            buscarFincaPorCriterio(txtCriterio.Text)
        End If
    End Sub

    Private Sub limpiarForm()
        Me.dgvDatos.DataSource = ""
        Me.txtCriterio.Text = ""
        cargarFincas()
    End Sub

    Private Sub evaluar()

        If txtCriterio.Text.Equals("") Then
            cargarFincas()
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
        dgvDatos.Columns(1).HeaderText = "Nombre"
        dgvDatos.Columns(2).HeaderText = "Dirección"
        dgvDatos.Columns(2).MinimumWidth = 170
        dgvDatos.Columns(3).HeaderText = "Area"
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de poner invisible algunas calumnas al datagridview
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub invisible()
        dgvDatos.Columns(0).Visible = False
    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar las fincas existentes en la DB con el nombre suministado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargarFincas()
        Try
            Dim _listTemp As New List(Of ClsCastCadenaFinca) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaFinca = _gestor.listarFinca() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaFinca.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaFinca(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaFinca(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            Me.dgvDatos.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Finca")
        End Try

    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar la finca existente en la DB con el id suministado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub buscarFincaPorCriterio(ByVal pcriterio As String)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaFinca) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaFinca = _gestor.buscarFincaPorCriterio(pcriterio) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaFinca.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaFinca(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next
                _listTemp.Add(New ClsCastCadenaFinca(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next
            Me.dgvDatos.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            nombrarColumnas()
            invisible()
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Finca")
        End Try
    End Sub

    Private Sub pbVerTotalArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbVerTotalArea.Click
        Dim totalArea As Integer
        totalArea = _gestor.obtenerTotalAreaFinca()
        lblTotalArea.Visible = True
        txtTotalArea.Visible = True
        txtTotalArea.Text = totalArea
    End Sub

    Private Sub pbModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbModificar.Click
        If Not dgvDatos.RowCount = 0 Then
            visibleControl()
            _cod = Me.dgvDatos.SelectedCells(0).Value
            _nombre = Me.dgvDatos.SelectedCells(1).Value
            _direccion = Me.dgvDatos.SelectedCells(2).Value
            _area = Me.dgvDatos.SelectedCells(3).Value

            modificar(_cod, _nombre, _direccion, _area)

        End If
    End Sub

    ''' <summary>
    ''' Método d clase, encargado de hacer visible componentes
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub visibleControl()
        Me.gpbModificarFinca.Visible = True
    End Sub

    ''' <summary>
    ''' Método d clase, encargado de hacer invisible componentes
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub QuitarControles()
        Me.gpbModificarFinca.Visible = False
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function evaluarEspacion() As Boolean
        _resul = False
        If Me.txtCodigo.Text = "" Then
            MsgBox("El código de la finca es un dato requerido.", MsgBoxStyle.Information, "Modificar Finca")
            Me.txtCodigo.Focus()

        ElseIf Me.txtNombre.Text = "" Then
            MsgBox("El nombre de la finca es un dato requerido.", MsgBoxStyle.Information, "Modificar Finca")
            Me.txtNombre.Focus()

        ElseIf Me.txtDireccion.Text = "" Then
            MsgBox("La dirección de la finca es un dato requerido.", MsgBoxStyle.Information, "Modificar Finca")
            Me.txtDireccion.Focus()

        ElseIf Me.txtArea.Text = "" Then
            MsgBox("El área del a finca es un dato requerido.", MsgBoxStyle.Information, "Nodificar Finca")
            Me.txtArea.Focus()
        Else
            _resul = True
        End If

        Return _resul
    End Function


    ''' <summary>
    ''' Método de clase, encarga de asignarle los valores a cada componente
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub modificar(ByVal pcod As Int32, ByVal pnombre As String, ByVal pdireccion As String, ByVal parea As Int32)
        With Me
            .txtCodigo.Text = pcod
            .txtNombre.Text = pnombre
            .txtDireccion.Text = pdireccion
            .txtArea.Text = parea
        End With

    End Sub

    Private Sub pbConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbConfirmar.Click
        Dim _result As DialogResult
        _resul = evaluarEspacion()
        '_numero = False
        If _resul = True Then

            'asignar a cada variable los valores indicados
            _cod = Me.txtCodigo.Text
            _nombre = Me.txtNombre.Text
            _direccion = Me.txtDireccion.Text
            _area = Me.txtArea.Text
            _result = MessageBox.Show("¿Está seguro que desea modificar los datos de la finca?", "Modificar Finca", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)

            Try
                If _result = Windows.Forms.DialogResult.Yes Then
                    _gestor.modificarFinca(_cod, _nombre, _direccion, _area) 'invocar el método indicado enviando los argumentos requeridos.
                    MsgBox("Los datos de la finca son modificados.", MsgBoxStyle.Information, "Modificar Finca")
                    QuitarControles()
                Else
                    MsgBox("Los datos de la finca no son modificados.", MsgBoxStyle.Information, "Modificar Finca")
                End If
            Catch ex As Exception
                MsgBox("Los datos ingresados ya existen en la base de datos.", MsgBoxStyle.Information, "Modificar Finca")
            End Try
        End If
        cargarFincas()
        nombrarColumnas()
        invisible()
    End Sub

    Private Sub pbAsignarFincaSocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbAsignarFincaSocio.Click
        _cod = Me.dgvDatos.SelectedCells(0).Value
        CType(Me.ParentForm, frmCentroAgricola).cargarUserControl(New ctlAsignarFincaSocio(_cod))

    End Sub

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
        CType(Me.ParentForm, frmCentroAgricola).cargarUserControl(New ctlPrincipal)
    End Sub
End Class
