Imports LogicaNegocio.ClsGestor
Public Class ctlBuscarInspeccion
    Dim _gestor As New LogicaNegocio.ClsGestor
    Dim _listaInspeccion As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
    Dim _tempArray As Array 'declarar una variable tipo Array
    Dim _criterio As String
    Dim _resul As Boolean
    Dim _codInsp As Int32

    Private Sub ctlBuscarInspeccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCriterio.Focus()
        limpiarForm()
        nombrarColumnas()
        invisible()
        If Not dgvDatos.RowCount = 0 Then
            txtCodPermiso.Text = dgvDatos.SelectedCells(0).Value
            _codInsp = txtCodPermiso.Text
            txtCedula.Text = dgvDatos.SelectedCells(1).Value
            txtNombre.Text = dgvDatos.SelectedCells(2).Value
            txtFechaCrea.Text = dgvDatos.SelectedCells(3).Value
            txtFechaVence.Text = dgvDatos.SelectedCells(4).Value
        End If
    End Sub

    Private Sub txtCriterio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriterio.TextChanged
        evaluar()
        If txtCriterio.Text = "" Then
            cargarInspeccion()
            nombrarColumnas()
            invisible()
        Else
            buscarCriterioInspeccion(txtCriterio.Text)
        End If
    End Sub

    Private Sub limpiarForm()
        Me.dgvDatos.DataSource = ""
        Me.txtCriterio.Text = ""
        cargarInspeccion()
    End Sub

    Private Sub evaluar()

        If txtCriterio.Text.Equals("") Then
            cargarInspeccion()
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
        dgvDatos.Columns(0).HeaderText = "Solicitud"
        dgvDatos.Columns(1).HeaderText = "Identificación"
        dgvDatos.Columns(2).HeaderText = "Nombre"
        dgvDatos.Columns(4).HeaderText = "Fecha vence"
        dgvDatos.Columns(2).MinimumWidth = 155
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de poner invisible algunas calumnas al datagridview
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub invisible()
        dgvDatos.Columns(3).Visible = False
    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar los permisos existentes en la DB con el nombre suministado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargarInspeccion()
        Try
            Dim _listTemp As New List(Of ClsCastCadenaInspeccion) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaInspeccion = _gestor.listarCarnetPendiente() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaInspeccion.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaInspeccion(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaInspeccion(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            Me.dgvDatos.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Inspección")
        End Try

    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar el permiso existente en la DB con el id suministado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub buscarCriterioInspeccion(ByVal pcriterio As String)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaInspeccion) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaInspeccion = _gestor.buscarCarnetPendiente(pcriterio) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaInspeccion.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaInspeccion(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next
                _listTemp.Add(New ClsCastCadenaInspeccion(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next
            Me.dgvDatos.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            nombrarColumnas()
            invisible()
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Inspección")
        End Try
    End Sub

    Private Sub pbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbImprimir.Click
        Try
            'Dim report As New Inspeccion
            Dim report As New InspeccionPrue
            _codInsp = txtCodPermiso.Text
            report.SetParameterValue("solicitud", _codInsp)
            report.PrintToPrinter(1, False, 1, 1)
            report.Refresh()
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al tratar de imprimir" & ex.Message)
        End Try
    End Sub

    Private Sub dgvDatos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDatos.CellContentClick
        If Not dgvDatos.RowCount = 0 Then
            txtCodPermiso.Text = dgvDatos.SelectedCells(0).Value
            _codInsp = txtCodPermiso.Text
            txtCedula.Text = dgvDatos.SelectedCells(1).Value
            txtNombre.Text = dgvDatos.SelectedCells(2).Value
            txtFechaCrea.Text = dgvDatos.SelectedCells(3).Value
            txtFechaVence.Text = dgvDatos.SelectedCells(4).Value
        End If
    End Sub

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
        CType(Me.ParentForm, frmCentroAgricola).cargarUserControl(New ctlPrincipal)
    End Sub
End Class
