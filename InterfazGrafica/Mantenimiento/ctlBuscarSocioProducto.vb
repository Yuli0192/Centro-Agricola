Imports LogicaNegocio.ClsGestor
Public Class ctlBuscarSocioProducto

    Dim _gestor As New LogicaNegocio.ClsGestor
    Dim _listaSocio As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
    Dim _tempArray As Array 'declarar una variable tipo Array
    Dim _criterio As String
    Dim _resul As Boolean

    Private Sub ctlBuscarSocioProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCriterio.Focus()
        limpiarForm()
        nombrarColumnas()
        invisible()
    End Sub

    Private Sub txtCriterio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriterio.TextChanged
        evaluar()
        If txtCriterio.Text = "" Then
            cargarSocios()
            nombrarColumnas()
            invisible()
        Else
            buscarSocioProducto(txtCriterio.Text)
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
    Private Sub buscarSocioProducto(ByVal pproducto As String)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaSocio) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaSocio = _gestor.buscarSocioPorProducto(pproducto) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaSocio.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaSocio(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next
                _listTemp.Add(New ClsCastCadenaSocio(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next
            Me.dgvDatos.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            nombrarColumnas()
            invisible()
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Socio")
        End Try
    End Sub

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
        CType(Me.ParentForm, frmCentroAgricola).cargarUserControl(New ctlPrincipal)
    End Sub
End Class
