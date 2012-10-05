Imports DataAccess.ClsDataAccess
Public Class ClsAuxiliarPersist

    Dim _dataAccess As New DataAccess.ClsDataAccess

    ''' <summary>
    ''' Metodo que registra un nuevo auxiliar a la Base de datos
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <param name="pcedula"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="ptelefono"></param>
    ''' <param name="pparentesco"></param>
    ''' <remarks></remarks>
    Public Sub registrar(ByVal pcod As String, ByVal pcedula As String, ByVal pnombre As String, _
                         ByVal ptelefono As String, ByVal pparentesco As String, ByVal pcodFerias As ArrayList)

        Try
            _dataAccess.agregarAuxiliar(pcod, pcedula, pnombre, ptelefono, pparentesco)
            For Each codFeria In pcodFerias
                agregarFeriaSocio(pcod, codFeria)
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que asigna una feria que asiste el socio a la Base de datos
    ''' </summary>
    ''' <param name="pcodSocio"></param>
    ''' <param name="pcodFeria"></param>
    ''' <remarks></remarks>
    Public Sub agregarFeriaSocio(ByVal pcodSocio As String, ByVal pcodFeria As Int32)

        Try
            _dataAccess.asignarFeriaSocio(pcodSocio, pcodFeria)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que modificar un auxiliar a la Base de datos
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <param name="pcedula"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="ptelefono"></param>
    ''' <param name="pparentesco"></param>
    ''' <remarks></remarks>
    Public Sub modificar(ByVal pcod As String, ByVal pcedula As String, ByVal pnombre As String, _
                          ByVal ptelefono As String, ByVal pparentesco As String)

        Try
            _dataAccess.modificarAuxiliar(pcod, pcedula, pnombre, ptelefono, pparentesco)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que elimina un auxiliar a la Base de datos
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <remarks></remarks>
    Public Sub eliminar(ByVal pcod As String)

        Try
            _dataAccess.eliminarAuxiliar(pcod)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que activa un auxiliar a la Base de datos
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <remarks></remarks>
    Public Sub activar(ByVal pcod As String)

        Try
            _dataAccess.activarAuxiliar(pcod)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    '''  Método de la clase encargada de buscar un registro de auxiliar a la base de datos 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarPorCriterio(ByVal pcriterio As String) As List(Of ClsAuxiliar)

        Dim _drAuxiliar As IDataReader 'instanciar un lector de datos genérico

        Dim _listaAuxiliares As New List(Of ClsAuxiliar) 'declarar e instanciar una lista genérica del tipo ClsAuxiliar

        Try
            _drAuxiliar = _dataAccess.buscarCriterioAuxiliar(pcriterio) 'asignar al lector de datos el resultado de la consulta

            While _drAuxiliar.Read()
                _listaAuxiliares.Add(New ClsAuxiliar(_drAuxiliar.GetString(0), _drAuxiliar.GetString(1), _drAuxiliar.GetString(2), _drAuxiliar.GetString(3), _drAuxiliar.GetString(4))) 'cargar a la lista genérica el resultado de la consulta.
            End While


            Return _listaAuxiliares 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Auxiliar... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    '''  Método de la clase encargada de buscar un registro de auxiliar inactivo a la base de datos 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarPorCriterioInactivo(ByVal pcriterio As String) As List(Of ClsAuxiliar)

        Dim _drAuxiliar As IDataReader 'instanciar un lector de datos genérico

        Dim _listaAuxiliares As New List(Of ClsAuxiliar) 'declarar e instanciar una lista genérica del tipo ClsAuxiliar

        Try
            _drAuxiliar = _dataAccess.buscarCriterioAuxiliarInactivo(pcriterio) 'asignar al lector de datos el resultado de la consulta

            While _drAuxiliar.Read()
                _listaAuxiliares.Add(New ClsAuxiliar(_drAuxiliar.GetString(0), _drAuxiliar.GetString(1), _drAuxiliar.GetString(2), _drAuxiliar.GetString(3), _drAuxiliar.GetString(4))) 'cargar a la lista genérica el resultado de la consulta.
            End While


            Return _listaAuxiliares 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Auxiliar... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    '''  Método de la clase encargada de buscar un registro de auxiliar a la base de datos 
    ''' </summary>
    ''' <param name="pproducto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarPorProducto(ByVal pproducto As String) As List(Of ClsAuxiliar)

        Dim _drAuxiliar As IDataReader 'instanciar un lector de datos genérico

        Dim _listaAuxiliares As New List(Of ClsAuxiliar) 'declarar e instanciar una lista genérica del tipo ClsAuxiliar

        Try
            _drAuxiliar = _dataAccess.buscarAuxiliarProducto(pproducto) 'asignar al lector de datos el resultado de la consulta

            While _drAuxiliar.Read()
                _listaAuxiliares.Add(New ClsAuxiliar(_drAuxiliar.GetString(0), _drAuxiliar.GetString(1), _drAuxiliar.GetString(2))) 'cargar a la lista genérica el resultado de la consulta.
            End While

            Return _listaAuxiliares 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Auxiliar... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los auxiliares en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listar() As List(Of ClsAuxiliar)
        Dim _drAuxiliar As IDataReader 'instanciar un lector de datos genérico

        Dim _listaAuxiliares As New List(Of ClsAuxiliar) 'declarar e instanciar una lista genérica del tipo ClsAuxiliar

        Try
            _drAuxiliar = _dataAccess.listarAuxiliares() 'asignar al lector de datos el resultado de la consulta

            While _drAuxiliar.Read()
                _listaAuxiliares.Add(New ClsAuxiliar(_drAuxiliar.GetString(0), _drAuxiliar.GetString(1), _drAuxiliar.GetString(2), _drAuxiliar.GetString(3), _drAuxiliar.GetString(4))) 'cargar a la lista genérica el resultado de la consulta.
            End While


            Return _listaAuxiliares 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Auxiliar... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los auxiliares inactivos en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarInactivo() As List(Of ClsAuxiliar)
        Dim _drAuxiliar As IDataReader 'instanciar un lector de datos genérico

        Dim _listaAuxiliares As New List(Of ClsAuxiliar) 'declarar e instanciar una lista genérica del tipo ClsAuxiliar

        Try
            _drAuxiliar = _dataAccess.listarAuxiliaresInactivo() 'asignar al lector de datos el resultado de la consulta

            While _drAuxiliar.Read()
                _listaAuxiliares.Add(New ClsAuxiliar(_drAuxiliar.GetString(0), _drAuxiliar.GetString(1), _drAuxiliar.GetString(2), _drAuxiliar.GetString(3), _drAuxiliar.GetString(4))) 'cargar a la lista genérica el resultado de la consulta.
            End While


            Return _listaAuxiliares 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Auxiliar... " & ex.Message)
        End Try
    End Function
End Class
