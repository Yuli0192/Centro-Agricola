Imports DataAccess.ClsDataAccess
Public Class ClsSocioPersist
    Dim _dataAccess As New DataAccess.ClsDataAccess

    ''' <summary>
    ''' Metodo que registra un nuevo socio a la Base de datos
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <param name="pcedula"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="pdireccionFinca"></param>
    ''' <param name="pdireccionCasa"></param>
    ''' <param name="ptelefono"></param>
    ''' <param name="pcorreo"></param>
    ''' <param name="pfechaIngreso"></param>
    ''' <param name="pcodFerias"></param>
    ''' <remarks></remarks>
    Public Sub registrar(ByVal pcod As String, ByVal pcedula As String, ByVal pnombre As String, _
                              ByVal pdireccionFinca As String, ByVal pdireccionCasa As String, ByVal ptelefono As String, _
                              ByVal pcorreo As String, ByVal pfechaIngreso As Date, ByVal pcodFerias As ArrayList)

        Try
            _dataAccess.agregarSocio(pcod, pcedula, pnombre, pdireccionFinca, pdireccionCasa, ptelefono, pcorreo, pfechaIngreso)
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
    ''' Metodo que modificar un socio a la Base de datos
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <param name="pcedula"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="pdireccionFinca"></param>
    ''' <param name="pdireccionCasa"></param>
    ''' <param name="ptelefono"></param>
    ''' <param name="pcorreo"></param>
    ''' <param name="pfechaIngreso"></param>
    ''' <remarks></remarks>
    Public Sub modificar(ByVal pcod As String, ByVal pcedula As String, ByVal pnombre As String, _
                              ByVal pdireccionFinca As String, ByVal pdireccionCasa As String, ByVal ptelefono As String, _
                              ByVal pcorreo As String, ByVal pfechaIngreso As Date)

        Try
            _dataAccess.modificarSocio(pcod, pcedula, pnombre, pdireccionFinca, pdireccionCasa, ptelefono, pcorreo, pfechaIngreso)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que elimina un socio a la Base de datos
    ''' </summary>
    ''' <param name="pcodigo"></param>
    ''' <remarks></remarks>
    Public Sub eliminar(ByVal pcodigo As String)

        Try
            _dataAccess.eliminarSocio(pcodigo)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que activa un socio a la Base de datos
    ''' </summary>
    ''' <param name="pcodigo"></param>
    ''' <remarks></remarks>
    Public Sub activar(ByVal pcodigo As String)

        Try
            _dataAccess.activarSocio(pcodigo)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de socio a la DB
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <remarks></remarks>
    Public Function buscarPorCriterio(ByVal pcriterio As String) As List(Of ClsSocio)

        Dim _drSocio As IDataReader 'instanciar un lector de datos genérico

        Dim _listaSocios As New List(Of ClsSocio) 'declarar e instanciar una lista genérica del tipo ClsSocio

        Try
            _drSocio = _dataAccess.buscarCriterioSocio(pcriterio) 'asignar al lector de datos el resultado de la consulta

            While _drSocio.Read()
                _listaSocios.Add(New ClsSocio(_drSocio.GetString(0), _drSocio.GetString(1), _drSocio.GetString(2), _drSocio.GetString(3), _drSocio.GetString(4), _drSocio.GetString(5), _drSocio.GetString(6), _drSocio.GetDateTime(7))) 'cargar a la lista genérica el resultado de la consulta.

            End While


            Return _listaSocios 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Socio... " & ex.Message)
        End Try

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de socio a la DB
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <remarks></remarks>
    Public Function buscarPorCriterioInactivo(ByVal pcriterio As String) As List(Of ClsSocio)

        Dim _drSocio As IDataReader 'instanciar un lector de datos genérico

        Dim _listaSocios As New List(Of ClsSocio) 'declarar e instanciar una lista genérica del tipo ClsSocio

        Try
            _drSocio = _dataAccess.buscarCriterioSocioInactivo(pcriterio) 'asignar al lector de datos el resultado de la consulta

            While _drSocio.Read()
                _listaSocios.Add(New ClsSocio(_drSocio.GetString(0), _drSocio.GetString(1), _drSocio.GetString(2), _drSocio.GetString(3), _drSocio.GetString(4), _drSocio.GetString(5), _drSocio.GetString(6), _drSocio.GetDateTime(7))) 'cargar a la lista genérica el resultado de la consulta.

            End While


            Return _listaSocios 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Socio... " & ex.Message)
        End Try

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de socio por medio del producto a la DB
    ''' </summary>
    ''' <param name="pproducto"></param>
    ''' <remarks></remarks>
    Public Function buscarPorProducto(ByVal pproducto As String) As List(Of ClsSocio)

        Dim _drSocio As IDataReader 'instanciar un lector de datos genérico

        Dim _listaSocios As New List(Of ClsSocio) 'declarar e instanciar una lista genérica del tipo ClsSocio

        Try
            _drSocio = _dataAccess.buscarSocioProducto(pproducto) 'asignar al lector de datos el resultado de la consulta

            While _drSocio.Read()
                _listaSocios.Add(New ClsSocio(_drSocio.GetString(0), _drSocio.GetString(1), _drSocio.GetString(2))) 'cargar a la lista genérica el resultado de la consulta.

            End While


            Return _listaSocios 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Socio... " & ex.Message)
        End Try

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los socios en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listar() As List(Of ClsSocio)
        Dim _drSocio As IDataReader 'instanciar un lector de datos genérico

        Dim _listaSocios As New List(Of ClsSocio) 'declarar e instanciar una lista genérica del tipo ClsSocio

        Try
            _drSocio = _dataAccess.listarSocios() 'asignar al lector de datos el resultado de la consulta

            While _drSocio.Read()
                _listaSocios.Add(New ClsSocio(_drSocio.GetString(0), _drSocio.GetString(1), _drSocio.GetString(2), _drSocio.GetString(3), _drSocio.GetString(4), _drSocio.GetString(5), _drSocio.GetString(6), _drSocio.GetDateTime(7))) 'cargar a la lista genérica el resultado de la consulta.
            End While


            Return _listaSocios 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Socio... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los socios en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarInactivo() As List(Of ClsSocio)
        Dim _drSocio As IDataReader 'instanciar un lector de datos genérico

        Dim _listaSocios As New List(Of ClsSocio) 'declarar e instanciar una lista genérica del tipo ClsSocio

        Try
            _drSocio = _dataAccess.listarSociosInactivo() 'asignar al lector de datos el resultado de la consulta

            While _drSocio.Read()
                _listaSocios.Add(New ClsSocio(_drSocio.GetString(0), _drSocio.GetString(1), _drSocio.GetString(2), _drSocio.GetString(3), _drSocio.GetString(4), _drSocio.GetString(5), _drSocio.GetString(6), _drSocio.GetDateTime(7))) 'cargar a la lista genérica el resultado de la consulta.
            End While


            Return _listaSocios 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Socio... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Obtiene la cantidad de socios activos registrados en la base de datos
    ''' </summary>
    ''' <returns>cantidad socio</returns>
    ''' <remarks></remarks>
    Public Function obtenerCantSocioActivo() As Integer
        Dim cantSocio As Integer
        Try
            cantSocio = _dataAccess.obtenerCantidadSocioActivo()
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
        Return cantSocio
    End Function
End Class
