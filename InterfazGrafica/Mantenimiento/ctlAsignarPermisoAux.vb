Imports LogicaNegocio.ClsGestor
Public Class ctlAsignarPermisoAux
    Dim _gestor As New LogicaNegocio.ClsGestor
    Dim _listaPermiso As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
    Dim _tempArray As Array 'declarar una variable tipo Array
    Dim _criterio As Int32
    Dim _resul As Boolean
    Dim _codAux As String
    Dim _identificacion As String
    Dim _nombreAux As String
    Dim _telefono As String
    Dim _codPermiso As Int32

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByRef pcodAux As String, ByVal pidentificacion As String, ByVal pnombreAux As String, ByVal ptelefono As String)

        InitializeComponent()

        _codAux = pcodAux
        _identificacion = pidentificacion
        _nombreAux = pnombreAux
        _telefono = ptelefono
    End Sub

    Private Sub ctlAsignarPermisoAux_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCriterio.Focus()
        limpiarForm()
        nombrarColumnas()
        invisible()
        limpiar()
    End Sub

    Private Sub txtCriterio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriterio.TextChanged
        Dim _numero As Boolean
        evaluar()
        If txtCriterio.Text = "" Then
            cargarPermisos()
            nombrarColumnas()
            invisible()
        ElseIf _numero = evaluarnumero() Then 'Valida el formato 

            MsgBox("El criterio ingresado debe ser solo número", MsgBoxStyle.Information, "Buscar permiso")
            Me.txtCriterio.SelectAll()
        Else
            buscarCriterioPermiso(txtCriterio.Text)
        End If
    End Sub

    Private Sub limpiarForm()
        Me.dgvDatos.DataSource = ""
        Me.txtCriterio.Text = ""
        cargarPermisos()
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de evaluar que tenga el formato correcto
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function evaluarnumero() As Boolean
        Dim _numero As Boolean
        _numero = IsNumeric(txtCriterio.Text)
        Return _numero
    End Function

    Private Sub evaluar()

        If txtCriterio.Text.Equals("") Then
            cargarPermisos()
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
        dgvDatos.Columns(1).HeaderText = "Nombre socio"
        dgvDatos.Columns(3).HeaderText = "Fecha crea"
        dgvDatos.Columns(4).HeaderText = "Fecha vence"
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de poner invisible algunas calumnas al datagridview
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub invisible()
        dgvDatos.Columns(2).Visible = False
    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar los permisos existentes en la DB con el nombre suministado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargarPermisos()
        Try
            Dim _listTemp As New List(Of ClsCastCadenaPermiso) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaPermiso = _gestor.listarPermisos() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaPermiso.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaPermiso(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaPermiso(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            Me.dgvDatos.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Permiso")
        End Try

    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar el permiso existente en la DB con el id suministado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub buscarCriterioPermiso(ByVal pcriterio As Int32)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaPermiso) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaPermiso = _gestor.buscarPermisoPorCriterio(pcriterio) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaPermiso.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaPermiso(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next
                _listTemp.Add(New ClsCastCadenaPermiso(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next
            Me.dgvDatos.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            nombrarColumnas()
            invisible()
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Permiso")
        End Try
    End Sub

    Public Sub limpiar()
        txtCodigoAux.Text = _codAux
        txtCedula.Text = _identificacion
        txtNombre.Text = _nombreAux
        txtTelefono.Text = _telefono
        If Not dgvDatos.RowCount = 0 Then
            txtCodigoPermiso.Text = dgvDatos.SelectedCells(0).Value
            txtFechaCrea.Text = dgvDatos.SelectedCells(3).Value
            txtFechaVence.Text = dgvDatos.SelectedCells(4).Value
        End If
        
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function evaluarEspacion() As Boolean
        _resul = False
        If Me.txtCodigoAux.Text = "" Then
            MsgBox("El código del auxiliar es un dato requerido.", MsgBoxStyle.Information, "Asignar Permiso Auxiliar")
            Me.txtCodigoAux.Focus()

        ElseIf Me.txtCodigoPermiso.Text = "" Then
            MsgBox("El código del permiso es un dato requerido .", MsgBoxStyle.Information, "Asignar Permiso Auxiliar")

        Else
            _resul = True
        End If

        Return _resul
    End Function

    Private Sub pbConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbConfirmar.Click
        'declarar variables tipo
        Dim _result As DialogResult
        Dim _codAux As String
        Dim _nombreAux As String
        If Not dgvDatos.RowCount = 0 Then
            _resul = evaluarEspacion()
            If _resul = True Then
                _codPermiso = txtCodigoPermiso.Text
                _codAux = txtCodigoAux.Text
                _nombreAux = txtNombre.Text
                _result = MessageBox.Show("¿Está seguro que desea asignarle el permiso al auxiliar?", "Asignar Permiso Auxiliar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)

                Try
                    If _result = Windows.Forms.DialogResult.Yes Then
                        _gestor.asignarPermisoAux(_codPermiso, _codAux, _nombreAux) 'invocar el método indicado enviando los argumentos requeridos.
                        MsgBox("Los datos de asignar el permiso auxiliar se ha registrado correctamente.", MsgBoxStyle.Information, "Asignar Permiso Auxiliar")
                        limpiar() 'invocar a la subrutina dedicada a limpiar los controles indicados.
                        pbImprimir.Enabled = True
                    Else
                        MsgBox("Los datos de asignar el permiso auxiliar no son registrados.", MsgBoxStyle.Information, "Asignar Permiso Auxiliar")
                    End If
                Catch ex As Exception
                    MsgBox("Los datos ingresados ya existen en la base de datos." & ex.Message, MsgBoxStyle.Information, "Asignar Permiso Auxiliar")
                End Try
            End If
        Else
            MsgBox("No hay permisos para asignarle al auxiliar .", MsgBoxStyle.Information, "Asignar Permiso Auxiliar")
        End If
        
    End Sub

    Private Sub pbRegresarBuscarFinca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresarBuscarFinca.Click
        CType(Me.ParentForm, frmCentroAgricola).cargarUserControl(New ctlBuscarAuxiliar)
    End Sub

    Private Sub dgvDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        If Not dgvDatos.RowCount = 0 Then
            txtCodigoPermiso.Text = dgvDatos.SelectedCells(0).Value
            txtFechaCrea.Text = dgvDatos.SelectedCells(3).Value
            txtFechaVence.Text = dgvDatos.SelectedCells(4).Value
            pbImprimir.Enabled = False
       End If
        
    End Sub

    Public Sub imprimirReporte()
        Try
            'Dim report As New PermisoAux
            Dim report As New PermisoAuxPrue
            report.SetParameterValue("codpermiso", _codPermiso)
            report.PrintToPrinter(1, False, 1, 20)
            report.Refresh()
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al tratar de imprimir" & ex.Message)
        End Try
    End Sub

    Private Sub pbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbImprimir.Click
        imprimirReporte()
    End Sub
End Class
