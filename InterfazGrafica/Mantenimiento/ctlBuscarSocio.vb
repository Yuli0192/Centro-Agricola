Imports LogicaNegocio.ClsGestor
Public Class ctlBuscarSocio

    Dim _gestor As New LogicaNegocio.ClsGestor
    Dim _listaSocio As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
    Dim _tempArray As Array 'declarar una variable tipo Array
    Dim _listaFeria As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
    Dim _resul As Boolean
    Dim _criterio As String
    'declarar variables tipo
    Dim _cod As String
    Dim _ced As String
    Dim _nombre As String
    Dim _direccionFinca As String
    Dim _direccionCasa As String
    Dim _telefono As String
    Dim _correo As String
    Dim _fechaIngreso As Date

    Private Sub ctlBuscarSocio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCriterio.Focus()
        limpiarForm()
        nombrarColumnas()
        invisible()
    End Sub

    Private Sub txtCriterio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriterio.TextChanged
        evaluar()
        QuitarControles()
        If txtCriterio.Text = "" Then
            cargarSocios()
            nombrarColumnas()
            invisible()
        Else
            buscarCriterioSocio(txtCriterio.Text)
        End If
    End Sub

    Private Sub limpiarForm()
        Me.dgvDatos.DataSource = ""
        Me.txtCriterio.Text = ""
        cargarSocios()
    End Sub

    Private Sub evaluar()

        If txtCriterio.Text.Equals("") Then
            cargarSocios()
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
        dgvDatos.Columns(0).HeaderText = "Código"
        dgvDatos.Columns(1).HeaderText = "Identificación"
        dgvDatos.Columns(2).HeaderText = "Nombre"
        dgvDatos.Columns(2).MinimumWidth = 125
        dgvDatos.Columns(5).HeaderText = "Teléfono"
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de poner invisible algunas calumnas al datagridview
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub invisible()
        dgvDatos.Columns(3).Visible = False
        dgvDatos.Columns(4).Visible = False
        dgvDatos.Columns(6).Visible = False
        dgvDatos.Columns(7).Visible = False
    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar los socios existentes en la DB con el nombre suministado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargarSocios()
        Try
            Dim _listTemp As New List(Of ClsCastCadenaSocio) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaSocio = _gestor.listarSocios() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaSocio.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaSocio(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaSocio(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString(), _tempCast(7).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            Me.dgvDatos.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            'nombrarColumnas()
            'invisible()
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Socio")
        End Try

    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar el socio existente en la DB con el id suministado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub buscarCriterioSocio(ByVal pcriterio As String)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaSocio) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaSocio = _gestor.buscarCriterioSocio(pcriterio) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaSocio.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaSocio(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next
                _listTemp.Add(New ClsCastCadenaSocio(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString(), _tempCast(7).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next
            Me.dgvDatos.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            nombrarColumnas()
            invisible()
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Socio")
        End Try
    End Sub

    Private Sub pbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbEliminar.Click
        If Not dgvDatos.RowCount = 0 Then
            _cod = Me.dgvDatos.SelectedCells(0).Value
            Dim _result As DialogResult
            _result = MessageBox.Show("¿Está seguro que desea eliminar el socio?", "Eliminar Socio", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)
            Try
                If _result = Windows.Forms.DialogResult.Yes Then
                    _gestor.eliminarSocio(_cod) 'invocar el método indicado enviando los argumentos requeridos.
                    MsgBox("Los datos del socio se han eliminado.", MsgBoxStyle.Information, "Eliminar Socio")
                Else
                    MsgBox("Los datos del socio no se pueden eliminar.", MsgBoxStyle.Information, "Eliminar Socio")
                End If
            Catch ex As Exception
                MsgBox("Los datos del socio no se pueden eliminar." & ex.Message, MsgBoxStyle.Information, "Eliminar Socio")
            End Try
            limpiarForm()
            nombrarColumnas()
            invisible()
        End If
    End Sub

    Private Sub pbModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbModificar.Click
        If Not dgvDatos.RowCount = 0 Then
            visibleControl()
            _cod = Me.dgvDatos.SelectedCells(0).Value
            _ced = Me.dgvDatos.SelectedCells(1).Value
            _nombre = Me.dgvDatos.SelectedCells(2).Value
            _direccionFinca = Me.dgvDatos.SelectedCells(3).Value
            _direccionCasa = Me.dgvDatos.SelectedCells(4).Value
            _telefono = Me.dgvDatos.SelectedCells(5).Value
            _correo = Me.dgvDatos.SelectedCells(6).Value
            _fechaIngreso = Me.dgvDatos.SelectedCells(7).Value

            modificar(_cod, _ced, _nombre, _direccionFinca, _direccionCasa, _telefono, _correo, _fechaIngreso)
            cargarFeriaSocio()
            cargarFeriaSinAsignarSocio()
        End If
    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar las ferias que asiste el socio existente en la DB con el id suministado
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub cargarFeriaSocio()
        Try
            'declarar una variable tipo lista genérica de Array
            Dim _listaFeria As List(Of Array) = New List(Of Array)()

            'asignar el resultado de la búsqueda devuelto por un método del Gestor
            _listaFeria = _gestor.buscarFeriaPorSocio(Me.txtCodigo.Text)
            'declarar una variable tipo Array
            Dim _tempArray As Array
            'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _listTemp As New List(Of ClsCastCadenaFeria)

            'declarar una variable tipo arreglo de String
            Dim _tempCast() As String

            'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado
            For i As Integer = 0 To _listaFeria.Count - 1
                'clonar a un Array temporal la FILA (ROW) de la consulta
                _tempArray = _listaFeria(i)
                'redimensionar el arreglo a un tamaño indicado
                ReDim _tempCast(_tempArray.Length() - 1)

                'recorrer la parte interna de la matriz, columna (COLUMN)
                For j As Integer = 0 To _tempArray.Length - 1
                    'asignar el valor de cada celda 
                    _tempCast(j) = _tempArray.GetValue(j).ToString()
                Next

                'agregar a la lista genérica una colección de la clase wrapper
                _listTemp.Add(New ClsCastCadenaFeria(_tempCast(0).ToString(), _tempCast(1).ToString()))

            Next

            'asignar el fuente de dato para un control tipo ComboBox la lista genérica wrappeada
            Me.ltbFeriaAsiste.DataSource = _listTemp
            Me.ltbFeriaAsiste.DisplayMember = "nombreFeria"
            Me.ltbFeriaAsiste.ValueMember = "codigo"

        Catch ex As Exception
            MessageBox.Show("Error en la operación ... " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar las ferias que no asiste el socio existente en la DB con el id suministado
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub cargarFeriaSinAsignarSocio()
        Try
            'declarar una variable tipo lista genérica de Array
            Dim _listaFeria As List(Of Array) = New List(Of Array)()

            'asignar el resultado de la búsqueda devuelto por un método del Gestor
            _listaFeria = _gestor.buscarFeriaSinSocio(Me.txtCodigo.Text)
            'declarar una variable tipo Array
            Dim _tempArray As Array
            'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _listTemp As New List(Of ClsCastCadenaFeria)

            'declarar una variable tipo arreglo de String
            Dim _tempCast() As String

            'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado
            For i As Integer = 0 To _listaFeria.Count - 1
                'clonar a un Array temporal la FILA (ROW) de la consulta
                _tempArray = _listaFeria(i)
                'redimensionar el arreglo a un tamaño indicado
                ReDim _tempCast(_tempArray.Length() - 1)

                'recorrer la parte interna de la matriz, columna (COLUMN)
                For j As Integer = 0 To _tempArray.Length - 1
                    'asignar el valor de cada celda 
                    _tempCast(j) = _tempArray.GetValue(j).ToString()
                Next

                'agregar a la lista genérica una colección de la clase wrapper
                _listTemp.Add(New ClsCastCadenaFeria(_tempCast(0).ToString(), _tempCast(1).ToString()))

            Next

            'asignar el fuente de dato para un control tipo listbox la lista genérica wrappeada
            Me.ltbFeria.DataSource = _listTemp
            Me.ltbFeria.DisplayMember = "nombreFeria"
            Me.ltbFeria.ValueMember = "codigo"

        Catch ex As Exception
            MessageBox.Show("Error en la operación ... " & ex.Message)
        End Try
    End Sub

    Private Sub pbQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbQuitar.Click
        Dim _codFeria As Int32 = Me.ltbFeriaAsiste.SelectedValue
        Dim _codigoSocio As String = Me.txtCodigo.Text
        _gestor.eliminarFeriaSocio(_codFeria, _codigoSocio)
        cargarFeriaSocio()
        cargarFeriaSinAsignarSocio()
       
    End Sub

    Private Sub pbInsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbInsertar.Click
        Dim _codFeria As Int32 = Me.ltbFeria.SelectedValue
        Dim _codigoSocio As String = Me.txtCodigo.Text
        _gestor.modificarFeriaSocio(_codFeria, _codigoSocio)
        cargarFeriaSocio()
        cargarFeriaSinAsignarSocio()

    End Sub

    ''' <summary>
    ''' Método d clase, encargado de hacer visible componentes
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub visibleControl()
        Me.gpbModificarSocio.Visible = True
    End Sub

    ''' <summary>
    ''' Método d clase, encargado de hacer invisible componentes
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub QuitarControles()
        Me.gpbModificarSocio.Visible = False
    End Sub


    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function evaluarEspacion() As Boolean
        _resul = False
        If Me.txtCedula.Text = "" Then
            MsgBox("La cédula del socio es un dato requerido.", MsgBoxStyle.Information, "Modificar Socio")
            Me.txtCedula.Focus()
        ElseIf Me.txtNombre.Text = "" Then
            MsgBox("El nombre del socio es un dato requerido.", MsgBoxStyle.Information, "Modificar Socio")
            Me.txtNombre.Focus()

        ElseIf Me.txtTelefono.Text = "" Then
            MsgBox("El teléfono del socio es un dato requerido.", MsgBoxStyle.Information, "Modificar Socio")
            Me.txtTelefono.Focus()

        ElseIf Me.txtDireccionFinca.Text = "" Then
            MsgBox("La dirección de la finca del socio es un dato requerido.", MsgBoxStyle.Information, "Modificar Socio")
            Me.txtDireccionFinca.Focus()

        ElseIf Me.txtDireccionCasa.Text = "" Then
            MsgBox("La dirección de la casa del socio es un dato requerido.", MsgBoxStyle.Information, "Modificar Socio")
            Me.txtDireccionCasa.Focus()

        Else
            _resul = True
        End If

        Return _resul
    End Function


    ''' <summary>
    ''' Método de clase, encarga de asignarle los valores a cada componente
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub modificar(ByVal pcod As String, ByVal pced As String, ByVal pnombre As String, ByVal pdireccionFinca As String, ByVal pdireccionCasa As String, ByVal ptelefono As String, ByVal pcorreo As String, ByVal pfechaIngreso As Date)
        With Me
            .txtCodigo.Text = pcod
            .txtCodigo.ReadOnly = True
            .txtCedula.Text = pced
            .txtNombre.Text = pnombre
            .txtDireccionFinca.Text = pdireccionFinca
            .txtDireccionCasa.Text = pdireccionCasa
            .txtTelefono.Text = ptelefono
            .txtCorreo.Text = pcorreo
            .txtFechaIngreso.Text = pfechaIngreso
            .txtFechaIngreso.ReadOnly = True
        End With

    End Sub

    Private Sub pbConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbConfirmar.Click
        Dim _result As DialogResult
        _resul = evaluarEspacion()
        '_numero = False
        If _resul = True Then

            'asignar a cada variable los valores indicados
            _cod = Me.txtCodigo.Text
            _ced = Me.txtCedula.Text
            _nombre = Me.txtNombre.Text
            _direccionFinca = Me.txtDireccionFinca.Text
            _direccionCasa = Me.txtDireccionCasa.Text
            _telefono = Me.txtTelefono.Text
            _correo = Me.txtCorreo.Text
            _fechaIngreso = Me.txtFechaIngreso.Text

            _result = MessageBox.Show("¿Está seguro que desea modificar los datos del socio?", "Modificar Socio", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)

            Try
                If _result = Windows.Forms.DialogResult.Yes Then
                    _gestor.modificarSocio(_cod, _ced, _nombre, _direccionFinca, _direccionCasa, _telefono, _correo, _fechaIngreso) 'invocar el método indicado enviando los argumentos requeridos.
                    MsgBox("Los datos del socio son modificados.", MsgBoxStyle.Information, "Modificar Socio")
                    QuitarControles()
                Else
                    MsgBox("Los datos del socio no son modificados.", MsgBoxStyle.Information, "Modificar Socio")
                End If
            Catch ex As Exception
                MsgBox("Los datos ingresados ya existen en la base de datos.", MsgBoxStyle.Information, "Modificar Socio")
            End Try
        End If
        cargarSocios()
        nombrarColumnas()
        invisible()
    End Sub

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
        CType(Me.ParentForm, frmCentroAgricola).cargarUserControl(New ctlPrincipal)
    End Sub

    Private Sub pbVerTotalArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbVerTotalArea.Click
        Dim cantSocio As Integer
        cantSocio = _gestor.obtenerCantSocio()
        lblCantSocio.Visible = True
        txtCantSocio.Visible = True
        txtCantSocio.Text = cantSocio
    End Sub

    Private Sub txtNombreBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreBuscar.TextChanged

        If txtNombreBuscar.Text = "" Then
            cargarFeriaSinAsignarSocio()
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

            _listaFeria = _gestor.buscarFeriaPorAprox(txtCodigo.Text, pnombre) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

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
            ltbFeria.Refresh()
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Feria")
        End Try

    End Sub

End Class
