Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports LogicaNegocio.ClsGestor
Public Class ctlListadoSocioProducto
    Dim _gestor As New LogicaNegocio.ClsGestor
    Dim _listaProducto As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
    Dim _tempArray As Array 'declarar una variable tipo Array
    Private Sub ctlListadoSocioProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarProductos()
    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar los productos existentes en la DB con el nombre suministado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargarProductos()
        Try
            Dim _listTemp As New List(Of ClsCastCadenaProducto) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaProducto = _gestor.listarProductos() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaProducto.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaProducto(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaProducto(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            'asignar el fuente de dato para un control tipo listbox la lista genérica wrappeada
            Me.cmbProducto.DataSource = _listTemp
            Me.cmbProducto.DisplayMember = "nombreProd"
            Me.cmbProducto.ValueMember = "Codigo"
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar producto")
        End Try

    End Sub

    Private Sub pbReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbReporte.Click
        Dim reporte As New ProductoSocio
        Dim producto As Integer = Me.cmbProducto.SelectedValue.ToString()
        reporte.SetParameterValue("producto", producto)
        reporteSocioProducto.ReportSource = reporte
        reporteSocioProducto.Refresh()
    End Sub

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
        CType(Me.ParentForm, frmCentroAgricola).cargarUserControl(New ctlPrincipal)
    End Sub
End Class
