Imports LogicaNegocio.ClsGestor
Public Class ctlOrdenPendiente

    Dim _gestor As New LogicaNegocio.ClsGestor
    Dim _listaOrdenes As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
    Dim _tempArray As Array 'declarar una variable tipo Array
    Dim _criterio As String
    Dim _resul As Boolean

    Private Sub ctlOrdenPendiente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCriterio.Focus()
        limpiarForm()
        nombrarColumnas()
        invisible()
    End Sub

    Private Sub txtCriterio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriterio.TextChanged
        evaluar()
        If txtCriterio.Text = "" Then
            cargarOrdenes()
            nombrarColumnas()
            invisible()
        Else
            buscarCriterioOrden(txtCriterio.Text)
        End If
    End Sub

    Private Sub limpiarForm()
        Me.dgvOrden.DataSource = ""
        Me.txtCriterio.Text = ""
        cargarOrdenes()
    End Sub

    Private Sub evaluar()

        If txtCriterio.Text.Equals("") Then
            cargarOrdenes()
            nombrarColumnas()
            invisible()
        Else
            Me.dgvOrden.DataSource = ""
        End If

    End Sub

    ''' <summary>
    ''' Método de clase, encarga de renombrar los encabezados al datagridview
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub nombrarColumnas()
        dgvOrden.Columns(1).HeaderText = "Cédula"
        dgvOrden.Columns(2).HeaderText = "Nombre"
        dgvOrden.Columns(3).HeaderText = "Mes"
        dgvOrden.Columns(4).HeaderText = "Año"
        dgvOrden.Columns(5).HeaderText = "Fecha Creo"
        dgvOrden.Columns(6).HeaderText = "Fecha Vence"
        dgvOrden.Columns(11).HeaderText = "Pago"
        dgvOrden.Columns(3).MinimumWidth = 40
        dgvOrden.Columns(2).MinimumWidth = 170
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de poner invisible algunas calumnas al datagridview
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub invisible()
        dgvOrden.Columns(0).Visible = False
        dgvOrden.Columns(7).Visible = False
        dgvOrden.Columns(8).Visible = False
        dgvOrden.Columns(9).Visible = False
        dgvOrden.Columns(10).Visible = False
        dgvOrden.Columns(12).Visible = False
    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar las ordenes canceladas existentes en la DB con el nombre suministado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargarOrdenes()
        Try
            Dim _listTemp As New List(Of ClsCastCadenaOrden) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaOrdenes = _gestor.listarOrdenesPendientes() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaOrdenes.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaOrdenes(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaOrden(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString(), _tempCast(7).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            'asignar el fuente de dato para un control tipo ComboBox la lista genérica wrappeada
            Me.dgvOrden.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Orden")
        End Try
    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar las ordenes canceladas existentes en la DB con el nombre suministado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub buscarCriterioOrden(ByVal pcriterio As String)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaOrden) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaOrdenes = _gestor.listarOrdenesPendienteCriterio(pcriterio) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaOrdenes.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaOrdenes(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaOrden(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString(), _tempCast(7).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            'asignar el fuente de dato para un control tipo ComboBox la lista genérica wrappeada
            Me.dgvOrden.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            nombrarColumnas()
            invisible()
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Orden")
        End Try
    End Sub

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
        CType(Me.ParentForm, frmCentroAgricola).cargarUserControl(New ctlPrincipal)
    End Sub
End Class
