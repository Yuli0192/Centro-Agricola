Imports DataAccess.ClsDataAccess
Public Class ClsOrdenPersist
    Dim _dataAccess As New DataAccess.ClsDataAccess

    ''' <summary>
    ''' Metodo que registra una nueva orden a la Base de datos
    ''' </summary>
    ''' <param name="pcedulaCliente"></param>
    ''' <param name="pmes"></param>
    ''' <param name="panno"></param>
    ''' <param name="pfechaCrea"></param>
    ''' <param name="pfechaVence"></param>
    ''' <param name="pmonto"></param>
    ''' <param name="pestado"></param>
    ''' <remarks></remarks>
    Public Sub registrar(ByVal pcedulaCliente As String, ByVal pmes As String, ByVal pmesNum As Int32, _
                            ByVal panno As Int32, ByVal pfechaCrea As Date, ByVal pfechaVence As Date, _
                            ByVal pmonto As Int32, ByVal psalario As Int32, ByVal pestado As String)

        Try
            _dataAccess.agregarOrden(pcedulaCliente, pmes, pmesNum, panno, pfechaCrea, pfechaVence, pmonto, psalario, pestado)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de ordenes pendientes a la DB
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <remarks></remarks>
    Public Function buscarOrdenesPendiente(ByVal pcriterio As String) As List(Of ClsOrden)

        Dim _drOrden As IDataReader 'instanciar un lector de datos genérico

        Dim _listaOrdenes As New List(Of ClsOrden) 'declarar e instanciar una lista genérica del tipo ClsOrden

        Try
            _drOrden = _dataAccess.buscarOrdenesPendientes(pcriterio) 'asignar al lector de datos el resultado de la consulta

            While _drOrden.Read()
                _listaOrdenes.Add(New ClsOrden(_drOrden.GetInt32(0), _drOrden.GetString(1), _drOrden.GetString(2), _drOrden.GetInt32(3), _drOrden.GetDateTime(4), _drOrden.GetDateTime(5), _drOrden.GetDateTime(6), _drOrden.GetInt32(7), _drOrden.GetInt32(8), _drOrden.GetInt32(9), _drOrden.GetInt32(10), _drOrden.GetString(11))) 'cargar a la lista genérica el resultado de la consulta.

            End While


            Return _listaOrdenes 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Orden... " & ex.Message)
        End Try

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de ordenes pendientes a la DB
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <remarks></remarks>
    Public Function buscarOrdenesCancelada(ByVal pcriterio As String) As List(Of ClsOrden)

        Dim _drOrden As IDataReader 'instanciar un lector de datos genérico

        Dim _listaOrdenes As New List(Of ClsOrden) 'declarar e instanciar una lista genérica del tipo ClsOrden

        Try
            _drOrden = _dataAccess.buscarOrdenesCanceladas(pcriterio) 'asignar al lector de datos el resultado de la consulta

            While _drOrden.Read()
                _listaOrdenes.Add(New ClsOrden(_drOrden.GetInt32(0), _drOrden.GetString(1), _drOrden.GetString(2), _drOrden.GetInt32(3), _drOrden.GetDateTime(4), _drOrden.GetDateTime(5), _drOrden.GetDateTime(6), _drOrden.GetInt32(7), _drOrden.GetInt32(8), _drOrden.GetInt32(9), _drOrden.GetInt32(10), _drOrden.GetString(11))) 'cargar a la lista genérica el resultado de la consulta.

            End While


            Return _listaOrdenes 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Orden... " & ex.Message)
        End Try

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de ordenes canceladas a la DB
    ''' </summary>
    ''' <remarks></remarks>
    Public Function listarOrdenesCancelada() As List(Of ClsOrden)

        Dim _drOrden As IDataReader 'instanciar un lector de datos genérico

        Dim _listaOrdenes As New List(Of ClsOrden) 'declarar e instanciar una lista genérica del tipo ClsOrden

        Try
            _drOrden = _dataAccess.listarOrdenesCanceladas() 'asignar al lector de datos el resultado de la consulta

            While _drOrden.Read()
                _listaOrdenes.Add(New ClsOrden(_drOrden.GetString(0), _drOrden.GetString(1), _drOrden.GetString(2), _drOrden.GetInt32(3), _drOrden.GetDateTime(4), _drOrden.GetDateTime(5), _drOrden.GetDateTime(6), _drOrden.GetInt32(7))) 'cargar a la lista genérica el resultado de la consulta.

            End While


            Return _listaOrdenes 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Orden... " & ex.Message)
        End Try

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de ordenes canceladas a la DB
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <remarks></remarks>
    Public Function listarOrdenesCanceladaCriterio(ByVal pcriterio As String) As List(Of ClsOrden)

        Dim _drOrden As IDataReader 'instanciar un lector de datos genérico

        Dim _listaOrdenes As New List(Of ClsOrden) 'declarar e instanciar una lista genérica del tipo ClsOrden

        Try
            _drOrden = _dataAccess.listarOrdenesCanceladasCriterio(pcriterio) 'asignar al lector de datos el resultado de la consulta

            While _drOrden.Read()
                _listaOrdenes.Add(New ClsOrden(_drOrden.GetString(0), _drOrden.GetString(1), _drOrden.GetString(2), _drOrden.GetInt32(3), _drOrden.GetDateTime(4), _drOrden.GetDateTime(5), _drOrden.GetDateTime(6), _drOrden.GetInt32(7))) 'cargar a la lista genérica el resultado de la consulta.

            End While


            Return _listaOrdenes 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Orden... " & ex.Message)
        End Try

    End Function


    ''' <summary>
    ''' Metodo que modifica la multa a la Base de datos
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <remarks></remarks>
    Public Sub modificarMulta(ByVal pcod As Int32)

        Try
            _dataAccess.modificarMulta(pcod)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Funcion que se encarga de obtener el monto total de la orden en la base de datos.
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <returns>Monto total</returns>
    Public Function obtenerMontoTotal(ByVal pcod As Int32) As Double
        Dim montoTotal As Double
        Try
            _dataAccess.modificarMulta(pcod)
            montoTotal = _dataAccess.obtenerMontoTotalOrden(pcod)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
        Return montoTotal
    End Function

    ''' <summary>
    ''' Metodo que modifica el estado de la orden  a la Base de datos
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <param name="pfechaPago"></param>
    ''' <param name="pestado"></param>
    ''' <remarks></remarks>
    Public Sub cancelarOrden(ByVal pcod As Int32, ByVal pfechaPago As Date, ByVal pmontoPagar As Int32, ByVal pestado As String)
        Try
            _dataAccess.cancelarOrden(pcod, pfechaPago, pmontoPagar, pestado)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de ordenes canceladas a la DB
    ''' </summary>
    ''' <remarks></remarks>
    Public Function listarOrdenesPendiente() As List(Of ClsOrden)

        Dim _drOrden As IDataReader 'instanciar un lector de datos genérico

        Dim _listaOrdenes As New List(Of ClsOrden) 'declarar e instanciar una lista genérica del tipo ClsOrden

        Try
            modificarMultaOrdenPendientes()
            _drOrden = _dataAccess.listarOrdenesPendientes() 'asignar al lector de datos el resultado de la consulta

            While _drOrden.Read()
                _listaOrdenes.Add(New ClsOrden(_drOrden.GetString(0), _drOrden.GetString(1), _drOrden.GetString(2), _drOrden.GetInt32(3), _drOrden.GetDateTime(4), _drOrden.GetDateTime(5), _drOrden.GetDateTime(6), _drOrden.GetInt32(7))) 'cargar a la lista genérica el resultado de la consulta.

            End While

            Return _listaOrdenes 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Orden... " & ex.Message)
        End Try

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de ordenes canceladas a la DB
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <remarks></remarks>
    Public Function listarOrdenesPendienteCriterio(ByVal pcriterio As String) As List(Of ClsOrden)

        Dim _drOrden As IDataReader 'instanciar un lector de datos genérico

        Dim _listaOrdenes As New List(Of ClsOrden) 'declarar e instanciar una lista genérica del tipo ClsOrden

        Try
            _drOrden = _dataAccess.listarOrdenesPendientesCriterio(pcriterio) 'asignar al lector de datos el resultado de la consulta

            While _drOrden.Read()
                _listaOrdenes.Add(New ClsOrden(_drOrden.GetString(0), _drOrden.GetString(1), _drOrden.GetString(2), _drOrden.GetInt32(3), _drOrden.GetDateTime(4), _drOrden.GetDateTime(5), _drOrden.GetDateTime(6), _drOrden.GetInt32(7))) 'cargar a la lista genérica el resultado de la consulta.

            End While


            Return _listaOrdenes 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Orden... " & ex.Message)
        End Try

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de ordenes canceladas a la DB
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub modificarMultaOrdenPendientes()

        Dim _drOrden As IDataReader 'instanciar un lector de datos genérico
        Try
            _drOrden = _dataAccess.listarOrdenes() 'asignar al lector de datos el resultado de la consulta

            While _drOrden.Read()
                _dataAccess.modificarMultaOrdenPendiente(_drOrden.GetInt32(0))
            End While

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Orden... " & ex.Message)
        End Try

    End Sub
End Class
