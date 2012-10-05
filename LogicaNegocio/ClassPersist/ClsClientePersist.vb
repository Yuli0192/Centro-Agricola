Imports DataAccess.ClsDataAccess
Public Class ClsClientePersist
    Dim _dataAccess As New DataAccess.ClsDataAccess

    ''' <summary>
    ''' Metodo que registra un nuevo cliente a la Base de datos
    ''' </summary>
    ''' <param name="pcedula"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="pdireccion"></param>
    ''' <param name="ptelefono"></param>
    ''' <param name="pfechaIngreso"></param>
    ''' <remarks></remarks>
    Public Sub registrar(ByVal pcedula As String, ByVal pnombre As String, ByVal pdireccion As String, _
                              ByVal ptelefono As String, ByVal pfechaIngreso As Date)

        Try
            _dataAccess.agregarCliente(pcedula, pnombre, pdireccion, ptelefono, pfechaIngreso)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que modificar un cliente a la Base de datos
    ''' </summary>
    ''' <param name="pcedula"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="pdireccion"></param>
    ''' <param name="ptelefono"></param>
    ''' <param name="pfechaIngreso"></param>
    ''' <param name="psalarioBase"></param>
    ''' <param name="pcuota"></param>
    ''' <remarks></remarks>
    Public Sub modificar(ByVal pcedula As String, ByVal pnombre As String, ByVal pdireccion As String, _
                              ByVal ptelefono As String, ByVal pfechaIngreso As Date, ByVal psalarioBase As Int32, _
                              ByVal pcuota As Int32)

        Try
            _dataAccess.modificarCliente(pcedula, pnombre, pdireccion, ptelefono, pfechaIngreso, psalarioBase, pcuota)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que elimina un cliente a la Base de datos
    ''' </summary>
    ''' <param name="pcedula"></param>
    ''' <remarks></remarks>
    Public Sub eliminar(ByVal pcedula As String)

        Try
            _dataAccess.eliminarCliente(pcedula)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que activa un cliente a la Base de datos
    ''' </summary>
    ''' <param name="pcedula"></param>
    ''' <param name="pcantIngreso"></param>
    ''' <remarks></remarks>
    Public Sub activar(ByVal pcedula As String, ByVal pcantIngreso As Int32)

        Try
            _dataAccess.activarCliente(pcedula, pcantIngreso)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de cliente a la DB
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <remarks></remarks>
    Public Function buscarPorCriterio(ByVal pcriterio As String) As List(Of ClsCliente)

        Dim _drCliente As IDataReader 'instanciar un lector de datos genérico

        Dim _listaClientes As New List(Of ClsCliente) 'declarar e instanciar una lista genérica del tipo ClsCliente

        Try
            _drCliente = _dataAccess.buscarCriterioCliente(pcriterio) 'asignar al lector de datos el resultado de la consulta

            While _drCliente.Read()
                _listaClientes.Add(New ClsCliente(_drCliente.GetString(0), _drCliente.GetString(1), _drCliente.GetString(2), _drCliente.GetString(3), _drCliente.GetDateTime(4), _drCliente.GetInt32(5), _drCliente.GetInt32(6), _drCliente.GetInt32(7))) 'cargar a la lista genérica el resultado de la consulta.

            End While


            Return _listaClientes 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Cliente... " & ex.Message)
        End Try

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de cliente a la DB
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <remarks></remarks>
    Public Function buscarPorCriterioInactivo(ByVal pcriterio As String) As List(Of ClsCliente)

        Dim _drCliente As IDataReader 'instanciar un lector de datos genérico

        Dim _listaClientes As New List(Of ClsCliente) 'declarar e instanciar una lista genérica del tipo ClsCliente

        Try
            _drCliente = _dataAccess.buscarCriterioClienteInactivo(pcriterio) 'asignar al lector de datos el resultado de la consulta

            While _drCliente.Read()
                _listaClientes.Add(New ClsCliente(_drCliente.GetString(0), _drCliente.GetString(1), _drCliente.GetString(2), _drCliente.GetString(3), _drCliente.GetDateTime(4), _drCliente.GetInt32(5), _drCliente.GetInt32(6), _drCliente.GetInt32(7))) 'cargar a la lista genérica el resultado de la consulta.

            End While


            Return _listaClientes 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Cliente... " & ex.Message)
        End Try

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los cliente en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listar() As List(Of ClsCliente)
        Dim _drCliente As IDataReader 'instanciar un lector de datos genérico

        Dim _listaClientes As New List(Of ClsCliente) 'declarar e instanciar una lista genérica del tipo ClsCliente

        Try
            _drCliente = _dataAccess.listarClientes() 'asignar al lector de datos el resultado de la consulta

            While _drCliente.Read()
                _listaClientes.Add(New ClsCliente(_drCliente.GetString(0), _drCliente.GetString(1), _drCliente.GetString(2), _drCliente.GetString(3), _drCliente.GetDateTime(4), _drCliente.GetInt32(5), _drCliente.GetInt32(6), _drCliente.GetInt32(7))) 'cargar a la lista genérica el resultado de la consulta.

            End While


            Return _listaClientes 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Cliente... " & ex.Message)
        End Try

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los clientes en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarInactivo() As List(Of ClsCliente)
        Dim _drCliente As IDataReader 'instanciar un lector de datos genérico

        Dim _listaClientes As New List(Of ClsCliente) 'declarar e instanciar una lista genérica del tipo ClsCliente

        Try
            _drCliente = _dataAccess.listarClientesInactivo() 'asignar al lector de datos el resultado de la consulta

            While _drCliente.Read()
                _listaClientes.Add(New ClsCliente(_drCliente.GetString(0), _drCliente.GetString(1), _drCliente.GetString(2), _drCliente.GetString(3), _drCliente.GetDateTime(4), _drCliente.GetInt32(5), _drCliente.GetInt32(6), _drCliente.GetInt32(7))) 'cargar a la lista genérica el resultado de la consulta.

            End While


            Return _listaClientes 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Cliente... " & ex.Message)
        End Try

    End Function
End Class
