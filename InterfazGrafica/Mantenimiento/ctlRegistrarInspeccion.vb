Imports LogicaNegocio.ClsGestor
Imports CrystalDecisions.Shared

Public Class ctlRegistrarInspeccion

    Dim _gestor As New LogicaNegocio.ClsGestor
    Dim _listaSocio As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
    Dim _listaProducto As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
    Dim _tempArray As Array 'declarar una variable tipo Array
    Dim _criterio As String
    Dim _resul As Boolean
    Dim _codInsp As Int32
    Dim _recibo As Int32

    Private Sub ctlRegistrarInspeccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCriterio.Focus()
        limpiarForm()
        nombrarColumnas()
        invisible()
        obtenerFechaVence(dtpFechaCrea.Value)
        txtSolicitud.Text = _gestor.obtenerMayorIdInspeccion() + 1
        txtNombre.Text = dgvDatos.SelectedCells(2).Value
        txtDireccionFinca.Text = dgvDatos.SelectedCells(3).Value
        cargarFeriaSocio()
    End Sub

    Private Sub txtCriterio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriterio.TextChanged
        evaluar()
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
        dgvDatos.Columns(2).MinimumWidth = 120
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de poner invisible algunas calumnas al datagridview
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub invisible()
        dgvDatos.Columns(3).Visible = False
        dgvDatos.Columns(4).Visible = False
        dgvDatos.Columns(5).Visible = False
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

    ''' <summary>
    ''' Método de clase, encargado de cargar las ferias que asiste el socio existente en la DB con el id suministado
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub cargarFeriaSocio()
        Try
            'declarar una variable tipo lista genérica de Array
            Dim _listaFeria As List(Of Array) = New List(Of Array)()

            'asignar el resultado de la búsqueda devuelto por un método del Gestor
            _listaFeria = _gestor.buscarFeriaPorSocio(dgvDatos.SelectedCells(0).Value)
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
            Me.ltbFeria.DataSource = _listTemp
            Me.ltbFeria.DisplayMember = "nombreFeria"
            Me.ltbFeria.ValueMember = "codigo"

        Catch ex As Exception
            MessageBox.Show("Error en la operación ... " & ex.Message)
        End Try
    End Sub

    Public Sub obtenerFechaVence(ByVal pfechaCrea As Date)
        Dim _fechaVence As Date

        _fechaVence = pfechaCrea.AddMonths(3)
        dtpFechaVence.Value = _fechaVence
    End Sub

    Private Sub limpiar()
        dtpFechaCrea.Value = Now
        obtenerFechaVence(dtpFechaCrea.Value)
        txtSolicitud.Text = _gestor.obtenerMayorIdInspeccion() + 1
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function evaluarEspacion() As Boolean
        _resul = False
        If Me.txtSolicitud.Text = "" Then
            MsgBox("La solicitud de la inspección es un dato requerido.", MsgBoxStyle.Information, "Registrar Inspección")
            Me.txtSolicitud.Focus()

        ElseIf Me.txtNombre.Text = "" Then
            MsgBox("El nombre del socio es un dato requerido.", MsgBoxStyle.Information, "Registrar Inspección")
            Me.txtNombre.Focus()

        ElseIf Me.txtDireccionFinca.Text = "" Then
            MsgBox("La dirección de la finca del socio es un dato requerido.", MsgBoxStyle.Information, "Registrar Inspección")
            Me.txtDireccionFinca.Focus()

        ElseIf Me.txtMonto.Text = "" Then
            MsgBox("El monto del carne es un dato requerido.", MsgBoxStyle.Information, "Registrar Inspección")
            Me.txtMonto.Focus()
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
        Dim _codSocio As String
        Dim _fechaCrea As Date
        Dim _fechaVence As Date

        _resul = evaluarEspacion()
        If _resul = True Then
            _codSocio = dgvDatos.SelectedCells(0).Value
            '_codPermiso = 1000
            _codInsp = txtSolicitud.Text
            _fechaCrea = dtpFechaCrea.Value.Date
            _fechaVence = dtpFechaVence.Value.Date

            Try
                _gestor.registrarInspeccion(_codInsp, _fechaCrea, _fechaVence, _codSocio) 'invocar el método indicado enviando los argumentos requeridos.
                MsgBox("Los datos de la inspección se ha registrado correctamente.", MsgBoxStyle.Information, "Registrar Inspección")
                limpiar() 'invocar a la subrutina dedicada a limpiar los controles indicados.
                pbImprimir.Enabled = True
                pbImprimirRecibo.Enabled = True
            Catch ex As Exception
                MsgBox("Los datos ingresados ya existen en la base de datos." & ex.Message, MsgBoxStyle.Information, "Registrar Inspección")
            End Try
        End If
    End Sub

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
        CType(Me.ParentForm, frmCentroAgricola).cargarUserControl(New ctlPrincipal)
    End Sub

    Private Sub dgvDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        txtNombre.Text = dgvDatos.SelectedCells(2).Value
        txtDireccionFinca.Text = dgvDatos.SelectedCells(3).Value
        cargarFeriaSocio()
        pbImprimir.Enabled = False
        pbImprimirRecibo.Enabled = False
    End Sub

    Public Sub imprimirReporte()
        Try
            'Dim report As New Inspeccion
            Dim report As New InspeccionPrue
            report.SetParameterValue("solicitud", _codInsp)
            report.PrintToPrinter(1, False, 1, 1)
            report.Refresh()
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al tratar de imprimir" & ex.Message)
        End Try
    End Sub

    Public Sub imprimirRecibo()
        Try
            Dim report As New Recibo
            'Dim report As New ReciboPrue
            report.SetParameterValue("recibo", _recibo)
            report.PrintOptions.PrinterName = "EPSON FX-890 ESC/P"
            report.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperEnvelopeB6
            'report.PrintOptions.PaperSize = CType(70, PaperSize)
            report.PrintToPrinter(1, False, 1, 1)
            report.Refresh()
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al tratar de imprimir" & ex.Message)
        End Try
    End Sub

    Private Sub pbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbImprimir.Click
        imprimirReporte()
    End Sub

    Private Sub registrarRecibo()
        _recibo = _gestor.obtenerMayorIdRecibo + 1
        Dim _fecha As Date = Now().Date
        Dim _hora As String = Format(Now, "hh:mm:ss tt")
        Dim _monto As Int32 = txtMonto.Text
        Dim _concepto As String = "CUOTA PERTENECIENTE A INSPECCIÓN Y EMISIÓN DE CARNE DE FERIA DEL AGRICULTOR"
        Try
            _gestor.registrarReciboCarne(_recibo, txtNombre.Text, _fecha, _hora, _monto, _concepto, 1)

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al tratar de registrar la factura" & ex.Message)
        End Try
    End Sub

    Private Sub pbImprimirRecibo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbImprimirRecibo.Click
        registrarRecibo()
        imprimirRecibo()
        'Dim _popupRecibo As New popupReciboInsp(_recibo)
        '_popupRecibo.ShowDialog()
    End Sub

    Private Function obtenerHora() As String
        Dim _hora As Integer
        Dim _minutos As Integer
        Dim _segundos As Integer

        Format(Now, "hh.mm.ss.fff tt")
    End Function
End Class
