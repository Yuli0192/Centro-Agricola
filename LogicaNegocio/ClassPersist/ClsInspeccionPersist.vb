Imports DataAccess.ClsDataAccess
Public Class ClsInspeccionPersist
    Dim _dataAccess As New DataAccess.ClsDataAccess

    ''' <summary>
    ''' Método de la clase, encargada de registrar los datos de una inspeccion.
    ''' </summary>
    ''' <param name="pcodInsp"></param>
    ''' <param name="pcodSocio"></param>
    ''' <param name="pfechaCrea"></param>
    ''' <param name="pfechaVence"></param>
    ''' <remarks></remarks>
    Public Sub registrar(ByVal pcodInsp As Int32, ByVal pfechaCrea As Date, _
                         ByVal pfechaVence As Date, ByVal pcodSocio As String)
        Try
            _dataAccess.agregarInspeccion(pcodInsp, pfechaCrea, pfechaVence, pcodSocio)

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Funcion que se encarga de buscar el maximo id en la tabla de inspeccion en la base de datos.
    ''' </summary>
    ''' <returns>Maximo id</returns>
    Public Function obtenerMayorIdInspeccion() As Integer
        Dim idMax As Integer
        Try
            idMax = _dataAccess.obtenerMayorIdInspeccion()
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
        Return idMax
    End Function


    ''' <summary>
    ''' Método de la clase encargada de buscar los carnet vencidos a la DB
    ''' </summary>
    ''' <remarks></remarks>
    Public Function buscarCarnetVencido() As List(Of ClsSocio)

        Dim _drSocio As IDataReader 'instanciar un lector de datos genérico

        Dim _listaSocios As New List(Of ClsSocio) 'declarar e instanciar una lista genérica del tipo ClsSocio

        Try
            _drSocio = _dataAccess.buscarCarnetVencidos() 'asignar al lector de datos el resultado de la consulta

            While _drSocio.Read()
                _listaSocios.Add(New ClsSocio(_drSocio.GetString(0), _drSocio.GetString(1), _drSocio.GetString(2), _drSocio.GetString(3), _drSocio.GetString(4), _drSocio.GetString(5), _drSocio.GetString(6), _drSocio.GetDateTime(7))) 'cargar a la lista genérica el resultado de la consulta.

            End While


            Return _listaSocios 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Socio... " & ex.Message)
        End Try

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar los carnet pendiente a la DB
    ''' </summary>
    ''' <remarks></remarks>
    Public Function buscarCarnetPendiente(ByVal pcriterio As String) As List(Of ClsInspeccion)

        Dim _drSocio As IDataReader 'instanciar un lector de datos genérico

        Dim _listaInspeccion As New List(Of ClsInspeccion) 'declarar e instanciar una lista genérica del tipo ClsSocio

        Try
            _dataAccess.modificarEstadoInspeccion()
            _drSocio = _dataAccess.buscarCriterioInspeccionSocioPendiente(pcriterio) 'asignar al lector de datos el resultado de la consulta

            While _drSocio.Read()
                _listaInspeccion.Add(New ClsInspeccion(_drSocio.GetInt32(0), _drSocio.GetDateTime(1), _drSocio.GetDateTime(2), _drSocio.GetString(3), _drSocio.GetString(4))) 'cargar a la lista genérica el resultado de la consulta.

            End While


            Return _listaInspeccion 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Inspeccion... " & ex.Message)
        End Try

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar los carnet pendiente a la DB
    ''' </summary>
    ''' <remarks></remarks>
    Public Function listarCarnetPendiente() As List(Of ClsInspeccion)

        Dim _drSocio As IDataReader 'instanciar un lector de datos genérico

        Dim _listaInspeccion As New List(Of ClsInspeccion) 'declarar e instanciar una lista genérica del tipo ClsSocio

        Try
            _dataAccess.modificarEstadoInspeccion()
            _drSocio = _dataAccess.listarInspeccionSocioPendiente() 'asignar al lector de datos el resultado de la consulta

            While _drSocio.Read()
                _listaInspeccion.Add(New ClsInspeccion(_drSocio.GetInt32(0), _drSocio.GetDateTime(1), _drSocio.GetDateTime(2), _drSocio.GetString(3), _drSocio.GetString(4))) 'cargar a la lista genérica el resultado de la consulta.

            End While


            Return _listaInspeccion 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Inspeccion... " & ex.Message)
        End Try

    End Function
End Class
