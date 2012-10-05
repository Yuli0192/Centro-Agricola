Imports LogicaNegocio.ClsGestor
Public Class ctlBuscarClienteInactivo

    Dim _gestor As New LogicaNegocio.ClsGestor
    Dim _listaCliente As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
    Dim _tempArray As Array 'declarar una variable tipo Array
    Dim _criterio As String
    Dim _resul As Boolean
    'declarar variables tipo
    Dim _ced As String
    Dim _cantIng As Int32
    Private Sub ctlBuscarClienteInactivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCriterio.Focus()
        limpiarForm()
        nombrarColumnas()
        invisible()
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

            _listaCliente = _gestor.listarClientesInactivo() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

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

            _listaCliente = _gestor.buscarCriterioClienteInactivo(pcriterio) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

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

    Public Function evaluarIngreso() As Boolean
        Dim result As Boolean = False
        _cantIng = Me.dgvDatos.SelectedCells(7).Value

        If _cantIng > 2 Then
            result = False
        Else
            result = True
        End If

        Return result
    End Function

    Private Sub pbActivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbActivar.Click
        Dim result As Boolean
        If Not dgvDatos.RowCount = 0 Then
            result = evaluarIngreso()
            If result = True Then
                _ced = Me.dgvDatos.SelectedCells(0).Value
                _cantIng = _cantIng + 1
                Dim _result As DialogResult
                _result = MessageBox.Show("¿Está seguro que desea activar el cliente?", "Activar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)
                Try
                    If _result = Windows.Forms.DialogResult.Yes Then
                        _gestor.activarCliente(_ced, _cantIng) 'invocar el método indicado enviando los argumentos requeridos.
                        MsgBox("El cliente ha sido activado.", MsgBoxStyle.Information, "Activar Cliente")
                    Else
                        MsgBox("Los datos del cliente no se pueden activar.", MsgBoxStyle.Information, "Activar Cliente")
                    End If
                Catch ex As Exception
                    MsgBox("Los datos del cliente no se pueden activar." & ex.Message, MsgBoxStyle.Information, "Activar Cliente")
                End Try
            Else
                MsgBox("El cliente ya no se puede activar por que ya se ha activado más de dos veces.", MsgBoxStyle.Information, "Activar Cliente")
            End If
        End If
        limpiarForm()
        nombrarColumnas()
        invisible()
    End Sub

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
        CType(Me.ParentForm, frmCentroAgricola).cargarUserControl(New ctlPrincipal)
    End Sub
End Class
