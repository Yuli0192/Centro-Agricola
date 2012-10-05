Imports DataAccess.ClsDataAccess
Public Class ClsProductoPersist
    Dim _dataAccess As New DataAccess.ClsDataAccess

    ''' <summary>
    ''' Metodo que registra un nuevo producto a la Base de datos
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <param name="punidad"></param>
    ''' <remarks></remarks>
    Public Sub registrar(ByVal pcod As Int32, ByVal pnombre As String, ByVal punidad As Int32)

        Try
            _dataAccess.agregarProducto(pcod, pnombre, punidad)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que modificar un producto a la Base de datos
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <param name="punidad"></param>
    ''' <remarks></remarks>
    Public Sub modificar(ByVal pcod As Int32, ByVal pnombre As String, ByVal punidad As Int32)

        Try
            _dataAccess.modificarProducto(pcod, pnombre, punidad)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que elimina un producto a la Base de datos
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <remarks></remarks>
    Public Sub eliminar(ByVal pcod As Int32)

        Try
            _dataAccess.eliminarProducto(pcod)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    '''  Método de la clase encargada de buscar un registro de producto a la base de datos 
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarPorNombre(ByVal pnombre As String) As List(Of ClsProducto)

        Dim _drProducto As IDataReader 'instanciar un lector de datos genérico

        Dim _listaProductos As New List(Of ClsProducto) 'declarar e instanciar una lista genérica del tipo ClsProducto

        Try
            _drProducto = _dataAccess.buscarProductoNombre(pnombre) 'asignar al lector de datos el resultado de la consulta

            While _drProducto.Read()
                _listaProductos.Add(New ClsProducto(_drProducto.GetInt32(0), _drProducto.GetString(1), _drProducto.GetString(2))) 'cargar a la lista genérica el resultado de la consulta.
            End While


            Return _listaProductos 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Producto... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los productos en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listar() As List(Of ClsProducto)
        Dim _drProducto As IDataReader 'instanciar un lector de datos genérico

        Dim _listaProductos As New List(Of ClsProducto) 'declarar e instanciar una lista genérica del tipo ClsProducto

        Try
            _drProducto = _dataAccess.listarProductos() 'asignar al lector de datos el resultado de la consulta

            While _drProducto.Read()
                _listaProductos.Add(New ClsProducto(_drProducto.GetInt32(0), _drProducto.GetString(1), _drProducto.GetString(2))) 'cargar a la lista genérica el resultado de la consulta.
            End While


            Return _listaProductos 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Producto... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    '''  Método de la clase encargada de buscar un registro de producto a la base de datos 
    ''' </summary>
    ''' <param name="ppermiso"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function cargarProductoSocio(ByVal ppermiso As Int32) As List(Of ClsProducto)

        Dim _drProducto As IDataReader 'instanciar un lector de datos genérico

        Dim _listaProductos As New List(Of ClsProducto) 'declarar e instanciar una lista genérica del tipo ClsProducto

        Try
            _drProducto = _dataAccess.listarProductoSocio(ppermiso) 'asignar al lector de datos el resultado de la consulta

            While _drProducto.Read()
                _listaProductos.Add(New ClsProducto(_drProducto.GetInt32(0), _drProducto.GetString(1), _drProducto.GetInt32(2))) 'cargar a la lista genérica el resultado de la consulta.
            End While


            Return _listaProductos 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Producto... " & ex.Message)
        End Try
    End Function
End Class
