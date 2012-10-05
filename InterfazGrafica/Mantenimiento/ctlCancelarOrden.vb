Imports LogicaNegocio.ClsGestor
Public Class ctlCancelarOrden

    Dim _gestor As New LogicaNegocio.ClsGestor
    Dim _listaCliente As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
    Dim _listaMeses As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
    Dim _listaOrdenes As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
    Dim _tempArray As Array 'declarar una variable tipo Array
    Dim _criterio As String
    Dim _resul As Boolean
    Dim _montoTem As Int32
    Dim _annoTem As Int32
    Dim _mesTem As String
    Dim _recibo As Int32

    Private Sub ctlCancelarOrden_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCriterio.Focus()
        limpiarForm()
        nombrarColumnas()
        invisible()
        txtCedula.Text = dgvDatos.SelectedCells(0).Value
        txtNombre.Text = dgvDatos.SelectedCells(1).Value
        cargarMesesPendiente(dgvDatos.SelectedCells(0).Value)
        cargarMesesCancelados(dgvDatos.SelectedCells(0).Value)
        nombrarColumnasOrden()
        invisibleOrden()
        _gestor.modificarMultaOrdenPendiente()
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
    ''' Método de clase, encarga de renombrar los encabezados al datagridview
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub nombrarColumnasOrden()
        dgvOrden.Columns(3).HeaderText = "Mes"
        dgvOrden.Columns(4).HeaderText = "Año"
        dgvOrden.Columns(7).HeaderText = "Fecha Pago"
        dgvOrden.Columns(11).HeaderText = "Pago"
        dgvOrden.Columns(3).MinimumWidth = 40
        dgvOrden.Columns(7).MinimumWidth = 40

    End Sub

    ''' <summary>
    ''' Método de clase, encarga de poner invisible algunas calumnas al datagridview
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub invisibleOrden()
        dgvOrden.Columns(0).Visible = False
        dgvOrden.Columns(1).Visible = False
        dgvOrden.Columns(2).Visible = False
        dgvOrden.Columns(5).Visible = False
        dgvOrden.Columns(6).Visible = False
        dgvOrden.Columns(8).Visible = False
        dgvOrden.Columns(9).Visible = False
        dgvOrden.Columns(10).Visible = False
        dgvOrden.Columns(12).Visible = False
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

    ''' <summary>
    ''' Método de clase, encargado de cargar los meses existentes en la DB con el nombre suministado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargarMesesPendiente(ByVal pced As String)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaOrden) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaMeses = _gestor.buscarOrdenesVencidas(pced) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaMeses.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaMeses(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaOrden(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString(), _tempCast(7).ToString(), _tempCast(8).ToString(), _tempCast(9).ToString(), _tempCast(10).ToString(), _tempCast(11).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            'asignar el fuente de dato para un control tipo ComboBox la lista genérica wrappeada
            Me.cmbMes.DataSource = _listTemp
            Me.cmbMes.ValueMember = "codigo"
            Me.cmbMes.DisplayMember = "mesOrden"

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Cliente")
        End Try
    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar los meses existentes en la DB con el nombre suministado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargarMesesCancelados(ByVal pced As String)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaOrden) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaOrdenes = _gestor.buscarOrdenesCanceladas(pced) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaOrdenes.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaOrdenes(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaOrden(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString(), _tempCast(7).ToString(), _tempCast(8).ToString(), _tempCast(9).ToString(), _tempCast(10).ToString(), _tempCast(11).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            'asignar el fuente de dato para un control tipo ComboBox la lista genérica wrappeada
            Me.dgvOrden.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Cliente")
        End Try
    End Sub

    Private Sub cmbMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMes.SelectedIndexChanged
        txtAnno.Text = CType(Me.cmbMes.SelectedItem, ClsCastCadenaOrden).annoOrden
        obtenerMontoOrden()
    End Sub

    Public Sub obtenerMontoOrden()

        Dim _cod As Int32 = CType(Me.cmbMes.SelectedItem, ClsCastCadenaOrden).codigo
        Dim _monto As Double = _gestor.obtenerMontoTotal(_cod)
        txtMonto.Text = _monto
    End Sub


    Private Sub pbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbCancelar.Click
        Dim _result As DialogResult
        Dim _cod As Int32
        Dim _fechaPago As Date
        Dim _montoPagar As Int32
        Dim _estado As String

        If Not cmbMes.Items.Count = 0 Then
            'asignar a cada variable los valores indicados
            _cod = CType(Me.cmbMes.SelectedItem, ClsCastCadenaOrden).codigo
            _fechaPago = Now.Date
            _montoPagar = txtMonto.Text
            _estado = "CANCELADO"
            _result = MessageBox.Show("¿Está seguro que desea cancelar la orden del cliente?", "Cancelar Orden", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)

            Try
                If _result = Windows.Forms.DialogResult.Yes Then
                    _gestor.cancelarOrden(_cod, _fechaPago, _montoPagar, _estado) 'invocar el método indicado enviando los argumentos requeridos.
                    MsgBox("La orden se ha cancelado correctamente.", MsgBoxStyle.Information, "Cancelar Orden")
                    _mesTem = CType(Me.cmbMes.SelectedItem, ClsCastCadenaOrden).mesOrden
                    _annoTem = CType(Me.cmbMes.SelectedItem, ClsCastCadenaOrden).annoOrden
                    _montoTem = txtMonto.Text
                    cargarMesesPendiente(txtCedula.Text)
                    _gestor.modificarMultaOrdenPendiente()
                    registrarRecibo()
                    If Not cmbMes.Items.Count = 0 Then
                        txtAnno.Text = CType(Me.cmbMes.SelectedItem, ClsCastCadenaOrden).annoOrden
                        obtenerMontoOrden()
                    Else
                        txtAnno.Clear()
                        txtMonto.Clear()
                    End If 
                    cargarMesesCancelados(dgvDatos.SelectedCells(0).Value)
                    nombrarColumnasOrden()
                    invisibleOrden()
                    pbImprimir.Enabled = True
                Else
                    MsgBox("La orden no pudo ser cancelada.", MsgBoxStyle.Information, "Cancelar Orden")
                End If
            Catch ex As Exception
                MsgBox("Los datos ingresados ya existen en la base de datos.", MsgBoxStyle.Information, "Cancelar Orden")
            End Try
        Else
            MsgBox("No existen orden pendientes.", MsgBoxStyle.Information, "Cancelar Orden")
        End If
            

    End Sub

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
        CType(Me.ParentForm, frmCentroAgricola).cargarUserControl(New ctlPrincipal)
    End Sub


    Private Sub dgvDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        txtCedula.Text = dgvDatos.SelectedCells(0).Value
        txtNombre.Text = dgvDatos.SelectedCells(1).Value
        txtMonto.Clear()
        txtAnno.Clear()
        cargarMesesPendiente(dgvDatos.SelectedCells(0).Value)
        cargarMesesCancelados(dgvDatos.SelectedCells(0).Value)
        nombrarColumnasOrden()
        invisibleOrden()
        pbImprimir.Enabled = False
    End Sub

    Private Sub registrarRecibo()
        _recibo = _gestor.obtenerMayorIdRecibo + 1
        Dim _fecha As Date = Now().Date
        Dim _hora As String = Format(Now, "hh:mm:ss tt")
        Dim _monto As Int32 = _montoTem
        Dim _mesNum As Int32 = obtenerNumeroMes()
        Dim _concepto As String = "CUOTA MENSUAL POR ORDEN PATRONAL" & " " & _mesTem & " " & _annoTem
        Try
            _gestor.registrarReciboOrden(_recibo, txtNombre.Text, _fecha, _hora, _monto, _concepto, _mesTem, _mesNum, _annoTem)

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al tratar de registrar la factura" & ex.Message)
        End Try
    End Sub
    Private Sub pbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbImprimir.Click
        imprimirRecibo()
        'Dim _popupRecibo As New popupReciboOrden(_recibo)
        '_popupRecibo.ShowDialog()
    End Sub

    Public Sub imprimirRecibo()
        Try
            'Dim report As New ReciboOrden
            Dim report As New ReciboOrdenPrue
            report.SetParameterValue("recibo", _recibo)
            report.PrintOptions.PrinterName = "EPSON FX-890 ESC/P"
            report.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperEnvelopeB6
            report.PrintToPrinter(1, False, 1, 1)
            report.Refresh()
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al tratar de imprimir" & ex.Message)
        End Try
    End Sub

    Private Function obtenerNumeroMes() As Int32
        Dim _numMes As Int32

        If _mesTem = "ENERO" Then
            _numMes = 1
        ElseIf _mesTem = "FEBRERO" Then
            _numMes = 2
        ElseIf _mesTem = "MARZO" Then
            _numMes = 3
        ElseIf _mesTem = "ABRIL" Then
            _numMes = 4
        ElseIf _mesTem = "MAYO" Then
            _numMes = 5
        ElseIf _mesTem = "JUNIO" Then
            _numMes = 6
        ElseIf _mesTem = "JULIO" Then
            _numMes = 7
        ElseIf _mesTem = "AGOSTO" Then
            _numMes = 8
        ElseIf _mesTem = "SETIEMBRE" Then
            _numMes = 9
        ElseIf _mesTem = "OCTUBRE" Then
            _numMes = 10
        ElseIf _mesTem = "NOVIEMBRE" Then
            _numMes = 11
        ElseIf _mesTem = "DICIEMBRE" Then
            _numMes = 12
        End If

        Return _numMes
    End Function
End Class
