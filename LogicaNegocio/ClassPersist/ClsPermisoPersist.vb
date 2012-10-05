Imports DataAccess.ClsDataAccess
Public Class ClsPermisoPersist
    Dim _dataAccess As New DataAccess.ClsDataAccess

    ''' <summary>
    ''' Método de la clase, encargada de registrar los datos de un permiso.
    ''' </summary>
    ''' <param name="pcodPermiso"></param>
    ''' <param name="pcodSocio"></param>
    ''' <param name="pfechaCrea"></param>
    ''' <param name="pfechaVence"></param>
    ''' <remarks></remarks>
    Public Sub registrar(ByVal pcodPermiso As Int32, ByVal pcodSocio As String, ByVal pfechaCrea As Date, _
                         ByVal pfechaVence As Date, ByVal pcodProductos As ArrayList)
        Try
            _dataAccess.agregarPermiso(pcodPermiso, pcodSocio, pfechaCrea, pfechaVence)
            For Each codProducto In pcodProductos
                asignarProducto(pcodSocio, codProducto, pcodPermiso)
            Next
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase, encargada de registrar los datos de un permiso.
    ''' </summary>
    ''' <param name="pcodPermiso"></param>
    ''' <param name="pcodAux"></param>
    ''' <param name="pfechaCrea"></param>
    ''' <param name="pfechaVence"></param>
    ''' <remarks></remarks>
    Public Sub registrarPerAux(ByVal pcodPermiso As Int32, ByVal pcodSocio As String, _
                               ByVal pcodAux As String, ByVal pnombreAux As String, ByVal pfechaCrea As Date, _
                         ByVal pfechaVence As Date, ByVal pcodProductos As ArrayList)
        Try
            _dataAccess.agregarPermisoAux(pcodPermiso, pcodSocio, pcodAux, pnombreAux, pfechaCrea, pfechaVence)
            For Each codProducto In pcodProductos
                asignarProducto(pcodSocio, codProducto, pcodPermiso)
            Next
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que asigna productos al socio a la Base de datos
    ''' </summary>
    ''' <param name="pcodSocio"></param>
    ''' <param name="pcodProducto"></param>
    ''' <param name="pcodPermiso"></param>
    ''' <remarks></remarks>
    Public Sub asignarProducto(ByVal pcodSocio As String, ByVal pcodProducto As Int32, ByVal pcodPermiso As Int32)

        Try
            _dataAccess.asignarProductoSocio(pcodSocio, pcodProducto, pcodPermiso)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Funcion que se encarga de buscar el maximo id en la tabla de permiso en la base de datos.
    ''' </summary>
    ''' <returns>Maximo id</returns>
    Public Function obtenerMayorIdPermiso() As Integer
        Dim idMax As Integer
        Try
            idMax = _dataAccess.obtenerMayorIdPermiso()
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
        Return idMax
    End Function

    ''' <summary>
    ''' Método de la clase, encargada de asignar un permiso al auxiliar.
    ''' </summary>
    ''' <param name="pcodPermiso"></param>
    ''' <param name="pcodAuxiliar"></param>
    ''' <remarks></remarks>
    Public Sub asignarPermisoAux(ByVal pcodPermiso As Int32, ByVal pcodAuxiliar As String, ByVal pnombreAux As String)
        Try
            _dataAccess.agregarPermisoAuxiliar(pcodPermiso, pcodAuxiliar, pnombreAux)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    '''  Método de la clase encargada de buscar un registro de un permiso a la base de datos 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarPorCriterio(ByVal pcriterio As Int32) As List(Of ClsPermiso)

        Dim _drPermiso As IDataReader 'instanciar un lector de datos genérico

        Dim _listaPermisos As New List(Of ClsPermiso) 'declarar e instanciar una lista genérica del tipo ClsPermiso

        Try
            _dataAccess.modificarEstadoPermiso()
            _drPermiso = _dataAccess.buscarCriterioPermiso(pcriterio) 'asignar al lector de datos el resultado de la consulta

            While _drPermiso.Read()
                _listaPermisos.Add(New ClsPermiso(_drPermiso.GetInt32(0), _drPermiso.GetString(1), _drPermiso.GetDateTime(2), _drPermiso.GetDateTime(3))) 'cargar a la lista genérica el resultado de la consulta.
            End While


            Return _listaPermisos 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Permiso... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    '''  Método de la clase encargada de buscar todos los permiso a la base de datos 
    ''' </summary>
    ''' <returns>listaPermisos</returns>
    ''' <remarks></remarks>
    Public Function listar() As List(Of ClsPermiso)

        Dim _drPermiso As IDataReader 'instanciar un lector de datos genérico

        Dim _listaPermisos As New List(Of ClsPermiso) 'declarar e instanciar una lista genérica del tipo ClsPermiso

        Try
            _dataAccess.modificarEstadoPermiso()
            _drPermiso = _dataAccess.listarPermisos() 'asignar al lector de datos el resultado de la consulta

            While _drPermiso.Read()
                _listaPermisos.Add(New ClsPermiso(_drPermiso.GetInt32(0), _drPermiso.GetString(1), _drPermiso.GetDateTime(2), _drPermiso.GetDateTime(3))) 'cargar a la lista genérica el resultado de la consulta.
            End While


            Return _listaPermisos 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Permiso... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    '''  Método de la clase encargada de buscar un registro de un permiso a la base de datos 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarPorCriterioPendienteSocio(ByVal pcriterio As String) As List(Of ClsPermiso)

        Dim _drPermiso As IDataReader 'instanciar un lector de datos genérico

        Dim _listaPermisos As New List(Of ClsPermiso) 'declarar e instanciar una lista genérica del tipo ClsPermiso

        Try
            _dataAccess.modificarEstadoPermiso()
            _drPermiso = _dataAccess.buscarCriterioPermisoSocioPendiente(pcriterio) 'asignar al lector de datos el resultado de la consulta

            While _drPermiso.Read()
                _listaPermisos.Add(New ClsPermiso(_drPermiso.GetInt32(0), _drPermiso.GetString(1), _drPermiso.GetString(2), _drPermiso.GetDateTime(3), _drPermiso.GetDateTime(4))) 'cargar a la lista genérica el resultado de la consulta.
            End While


            Return _listaPermisos 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Permiso... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    '''  Método de la clase encargada de buscar todos los permiso a la base de datos 
    ''' </summary>
    ''' <returns>listaPermisos</returns>
    ''' <remarks></remarks>
    Public Function listarPendienteSocio() As List(Of ClsPermiso)

        Dim _drPermiso As IDataReader 'instanciar un lector de datos genérico

        Dim _listaPermisos As New List(Of ClsPermiso) 'declarar e instanciar una lista genérica del tipo ClsPermiso

        Try
            _dataAccess.modificarEstadoPermiso()
            _drPermiso = _dataAccess.listarPermisosSocioPendiente() 'asignar al lector de datos el resultado de la consulta

            While _drPermiso.Read()
                _listaPermisos.Add(New ClsPermiso(_drPermiso.GetInt32(0), _drPermiso.GetString(1), _drPermiso.GetString(2), _drPermiso.GetDateTime(3), _drPermiso.GetDateTime(4))) 'cargar a la lista genérica el resultado de la consulta.
            End While


            Return _listaPermisos 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Permiso... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    '''  Método de la clase encargada de buscar un registro de un permiso a la base de datos 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarPorCriterioPendienteAux(ByVal pcriterio As String) As List(Of ClsPermiso)

        Dim _drPermiso As IDataReader 'instanciar un lector de datos genérico

        Dim _listaPermisos As New List(Of ClsPermiso) 'declarar e instanciar una lista genérica del tipo ClsPermiso

        Try
            _dataAccess.modificarEstadoPermiso()
            _drPermiso = _dataAccess.buscarCriterioPermisoAuxPendiente(pcriterio) 'asignar al lector de datos el resultado de la consulta

            While _drPermiso.Read()
                _listaPermisos.Add(New ClsPermiso(_drPermiso.GetInt32(0), _drPermiso.GetString(1), _drPermiso.GetString(2), _drPermiso.GetDateTime(3), _drPermiso.GetDateTime(4))) 'cargar a la lista genérica el resultado de la consulta.
            End While


            Return _listaPermisos 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Permiso... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    '''  Método de la clase encargada de buscar todos los permiso a la base de datos 
    ''' </summary>
    ''' <returns>listaPermisos</returns>
    ''' <remarks></remarks>
    Public Function listarPendienteAux() As List(Of ClsPermiso)

        Dim _drPermiso As IDataReader 'instanciar un lector de datos genérico

        Dim _listaPermisos As New List(Of ClsPermiso) 'declarar e instanciar una lista genérica del tipo ClsPermiso

        Try
            _dataAccess.modificarEstadoPermiso()
            _drPermiso = _dataAccess.listarPermisosAuxPendiente() 'asignar al lector de datos el resultado de la consulta

            While _drPermiso.Read()
                _listaPermisos.Add(New ClsPermiso(_drPermiso.GetInt32(0), _drPermiso.GetString(1), _drPermiso.GetString(2), _drPermiso.GetDateTime(3), _drPermiso.GetDateTime(4))) 'cargar a la lista genérica el resultado de la consulta.
            End While


            Return _listaPermisos 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Permiso... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar los permisos vencidos a la DB
    ''' </summary>
    ''' <remarks></remarks>
    Public Function buscarPermisoVencido() As List(Of ClsSocio)

        Dim _drSocio As IDataReader 'instanciar un lector de datos genérico

        Dim _listaSocios As New List(Of ClsSocio) 'declarar e instanciar una lista genérica del tipo ClsSocio

        Try
            _dataAccess.modificarEstadoPermiso()
            _drSocio = _dataAccess.buscarPermisoVencidos() 'asignar al lector de datos el resultado de la consulta

            While _drSocio.Read()
                _listaSocios.Add(New ClsSocio(_drSocio.GetString(0), _drSocio.GetString(1), _drSocio.GetString(2), _drSocio.GetString(3), _drSocio.GetString(4), _drSocio.GetString(5), _drSocio.GetString(6), _drSocio.GetDateTime(7))) 'cargar a la lista genérica el resultado de la consulta.

            End While


            Return _listaSocios 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Socio... " & ex.Message)
        End Try

    End Function
End Class
