Imports LogicaNegocio.ClsGestor
Public Class ctlBuscarAuxiliar
    Dim _gestor As New LogicaNegocio.ClsGestor
    Dim _listaAuxiliar As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
    Dim _listaFeria As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
    Dim _tempArray As Array 'declarar una variable tipo Array
    Dim _criterio As String
    Dim _resul As Boolean
    'declarar variables tipo
    Dim _cod As String
    Dim _ced As String
    Dim _nombre As String
    Dim _primerApellido As String
    Dim _segundoApellido As String
    Dim _telefono As String
    Dim _parentesco As String

    Private Sub ctlBuscarAuxiliar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCriterio.Focus()
        limpiarForm()
        nombrarColumnas()
    End Sub

    Private Sub txtCriterio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriterio.TextChanged
        evaluar()
        QuitarControles()
        If txtCriterio.Text = "" Then
            cargarAuxiliares()
            nombrarColumnas()
        Else
            buscarAuxiliarPorCriterio(txtCriterio.Text)
        End If
    End Sub

    Private Sub limpiarForm()
        Me.dgvDatos.DataSource = ""
        Me.txtCriterio.Text = ""
        cargarAuxiliares()
    End Sub

    Private Sub evaluar()

        If txtCriterio.Text.Equals("") Then
            cargarAuxiliares()
            nombrarColumnas()
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
        dgvDatos.Columns(3).HeaderText = "Teléfono"
        dgvDatos.Columns(2).MinimumWidth = 155
        'dgvDatos.Columns(4).HeaderText = "Parentesco"
        dgvDatos.Columns(4).Visible = False
    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar los auxiliares existentes en la DB con el nombre suministado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargarAuxiliares()
        Try
            Dim _listTemp As New List(Of ClsCastCadenaAuxiliar) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaAuxiliar = _gestor.listarAuxiliares() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaAuxiliar.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaAuxiliar(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaAuxiliar(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            Me.dgvDatos.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Auxiliar")
        End Try

    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar el auxiliar existente en la DB con el id suministado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub buscarAuxiliarPorCriterio(ByVal pcriterio As String)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaAuxiliar) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaAuxiliar = _gestor.buscarAuxiliarPorCriterio(pcriterio) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaAuxiliar.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaAuxiliar(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next
                _listTemp.Add(New ClsCastCadenaAuxiliar(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next
            Me.dgvDatos.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            nombrarColumnas()
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Auxiliar")
        End Try
    End Sub

    Private Sub pbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbEliminar.Click
        If Not dgvDatos.RowCount = 0 Then
            _cod = Me.dgvDatos.SelectedCells(0).Value
            Dim _result As DialogResult
            _result = MessageBox.Show("¿Está seguro que desea eliminar el auxiliar?", "Eliminar Auxiliar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)
            Try
                If _result = Windows.Forms.DialogResult.Yes Then
                    _gestor.eliminarAuxiliar(_cod) 'invocar el método indicado enviando los argumentos requeridos.
                    MsgBox("Los datos del auxiliar se han eliminado.", MsgBoxStyle.Information, "Eliminar Auxiliar")
                Else
                    MsgBox("Los datos del auxiliar no se pueden eliminar.", MsgBoxStyle.Information, "Eliminar Auxiliar")
                End If
            Catch ex As Exception
                MsgBox("Los datos del auxiliar no se pueden eliminar." & ex.Message, MsgBoxStyle.Information, "Eliminar Auxiliar")
            End Try
            limpiarForm()
            nombrarColumnas()
        End If
    End Sub

    Private Sub pbModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbModificar.Click
        If Not dgvDatos.RowCount = 0 Then
            visibleControl()
            _cod = Me.dgvDatos.SelectedCells(0).Value
            _ced = Me.dgvDatos.SelectedCells(1).Value
            _nombre = Me.dgvDatos.SelectedCells(2).Value
            _telefono = Me.dgvDatos.SelectedCells(3).Value
            _parentesco = Me.dgvDatos.SelectedCells(4).Value

            modificar(_cod, _ced, _nombre, _telefono, _parentesco)
            cargarFeriaAux()
            cargarFeriaSinAsignarAux()
        End If
    End Sub

    ''' <summary>
    ''' Método d clase, encargado de hacer visible componentes
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub visibleControl()
        Me.gpbModificarAuxiliar.Visible = True
    End Sub

    ''' <summary>
    ''' Método d clase, encargado de hacer invisible componentes
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub QuitarControles()
        Me.gpbModificarAuxiliar.Visible = False
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function evaluarEspacion() As Boolean
        _resul = False
        If Me.txtCodigo.Text = "" Then
            MsgBox("El código del auxiliar es un dato requerido.", MsgBoxStyle.Information, "Modificar Auxiliar")
            Me.txtCodigo.Focus()

        ElseIf Me.txtCedula.Text = "" Then
            MsgBox("La cédula del auxiliar es un dato requerido.", MsgBoxStyle.Information, "Modificar Auxiliar")
            Me.txtCedula.Focus()

        ElseIf Me.txtNombre.Text = "" Then
            MsgBox("El nombre del auxiliar es un dato requerido.", MsgBoxStyle.Information, "Modificar Auxiliar")
            Me.txtNombre.Focus()

        ElseIf Me.txtTelefono.Text = "" Then
            MsgBox("El teléfono del auxiliar es un dato requerido.", MsgBoxStyle.Information, "Modificar Auxiliar")
            Me.txtTelefono.Focus()

        ElseIf Me.cmbParentesco.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar un parentesco del auxiliar.", MsgBoxStyle.Information, "Registrar Auxiliar")

        Else
            _resul = True
        End If

        Return _resul
    End Function


    ''' <summary>
    ''' Método de clase, encarga de asignarle los valores a cada componente
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub modificar(ByVal pcod As String, ByVal pced As String, ByVal pnombre As String, ByVal ptelefono As String, ByVal pparentesco As String)
        With Me
            .txtCodigo.Text = pcod
            .txtCodigo.ReadOnly = True
            .txtCedula.Text = pced
            .txtNombre.Text = pnombre
            .txtTelefono.Text = ptelefono
            .cmbParentesco.Text = pparentesco
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
            _telefono = Me.txtTelefono.Text
            _parentesco = Me.cmbParentesco.Text
            _result = MessageBox.Show("¿Está seguro que desea modificar los datos del auxiliar?", "Modificar Auxiliar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)

            Try
                If _result = Windows.Forms.DialogResult.Yes Then
                    _gestor.modificarAuxiliar(_cod, _ced, _nombre, _telefono, _parentesco) 'invocar el método indicado enviando los argumentos requeridos.
                    MsgBox("Los datos del auxiliar son modificados.", MsgBoxStyle.Information, "Modificar Auxiliar")
                    QuitarControles()
                Else
                    MsgBox("Los datos del auxiliar no son modificados.", MsgBoxStyle.Information, "Modificar Auxiliar")
                End If
            Catch ex As Exception
                MsgBox("Los datos ingresados ya existen en la base de datos.", MsgBoxStyle.Information, "Modificar Auxiliar")
            End Try
        End If
        cargarAuxiliares()
        nombrarColumnas()

    End Sub

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
        CType(Me.ParentForm, frmCentroAgricola).cargarUserControl(New ctlPrincipal)
    End Sub

    Private Sub pbAsignarPermiso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbAsignarPermiso.Click
        _cod = Me.dgvDatos.SelectedCells(0).Value
        _ced = Me.dgvDatos.SelectedCells(1).Value
        _nombre = Me.dgvDatos.SelectedCells(2).Value
        _telefono = Me.dgvDatos.SelectedCells(3).Value

        CType(Me.ParentForm, frmCentroAgricola).cargarUserControl(New ctlAsignarPermisoAux(_cod, _ced, _nombre, _telefono))

    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar las ferias que asiste el socio existente en la DB con el id suministado
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub cargarFeriaAux()
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
    Public Sub cargarFeriaSinAsignarAux()
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
        Dim _codigoAux As String = Me.txtCodigo.Text
        _gestor.eliminarFeriaAuxiliar(_codFeria, _codigoAux)
        cargarFeriaAux()
        cargarFeriaSinAsignarAux()
    End Sub

    Private Sub pbInsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbInsertar.Click
        Dim _codFeria As Int32 = Me.ltbFeria.SelectedValue
        Dim _codigoAux As String = Me.txtCodigo.Text
        _gestor.modificarFeriaAux(_codFeria, _codigoAux)
        cargarFeriaAux()
        cargarFeriaSinAsignarAux()
    End Sub

    Private Sub txtNombreBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreBuscar.TextChanged
        If txtNombreBuscar.Text = "" Then
            cargarFeriaSinAsignarAux()
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
