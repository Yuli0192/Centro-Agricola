Imports DataAccess.ClsDataAccess
Public Class ClsFeriaPersist

    Dim _dataAccess As New DataAccess.ClsDataAccess

    ''' <summary>
    ''' Metodo que registra una nueva feria a la Base de datos
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <param name="pnombre"></param>
    ''' <remarks></remarks>
    Public Sub registrar(ByVal pcod As Int32, ByVal pnombre As String)

        Try
            _dataAccess.agregarFeria(pcod, pnombre)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    '''  Método de la clase encargada de buscar un registro de feria a la base de datos 
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarPorNombre(ByVal pnombre As String) As List(Of ClsFeria)

        Dim _drFeria As IDataReader 'instanciar un lector de datos genérico

        Dim _listaFerias As New List(Of ClsFeria) 'declarar e instanciar una lista genérica del tipo ClsFeria

        Try
            _drFeria = _dataAccess.buscarFeriaNombre(pnombre) 'asignar al lector de datos el resultado de la consulta

            While _drFeria.Read()
                _listaFerias.Add(New ClsFeria(_drFeria.GetInt32(0), _drFeria.GetString(1))) 'cargar a la lista genérica el resultado de la consulta.
            End While


            Return _listaFerias 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Feria... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    '''  Método de la clase encargada de buscar un registro de feria a la base de datos 
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarPorAprox(ByVal pcod As String, ByVal pnombre As String) As List(Of ClsFeria)

        Dim _drFeria As IDataReader 'instanciar un lector de datos genérico

        Dim _listaFerias As New List(Of ClsFeria) 'declarar e instanciar una lista genérica del tipo ClsFeria

        Try
            _drFeria = _dataAccess.buscarFeriasNoAsisteSocio(pcod, pnombre) 'asignar al lector de datos el resultado de la consulta

            While _drFeria.Read()
                _listaFerias.Add(New ClsFeria(_drFeria.GetInt32(0), _drFeria.GetString(1))) 'cargar a la lista genérica el resultado de la consulta.
            End While


            Return _listaFerias 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Feria... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los productos en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listar() As List(Of ClsFeria)
        Dim _drFeria As IDataReader 'instanciar un lector de datos genérico

        Dim _listaFerias As New List(Of ClsFeria) 'declarar e instanciar una lista genérica del tipo ClsFeria

        Try
            _drFeria = _dataAccess.listarFerias() 'asignar al lector de datos el resultado de la consulta

            While _drFeria.Read()
                _listaFerias.Add(New ClsFeria(_drFeria.GetInt32(0), _drFeria.GetString(1))) 'cargar a la lista genérica el resultado de la consulta.
            End While


            Return _listaFerias 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Feria... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos las ferias que asiste el socio en la DB
    ''' </summary>
    ''' <param name="pcodigo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarFeriaPorSocio(ByVal pcodigo As String) As List(Of ClsFeria)
        Dim _drFeria As IDataReader 'instanciar un lector de datos genérico

        Dim _listaFerias As New List(Of ClsFeria) 'declarar e instanciar una lista genérica del tipo ClsFeria

        Try
            _drFeria = _dataAccess.listarFeriasAsisteSocio(pcodigo) 'asignar al lector de datos el resultado de la consulta

            While _drFeria.Read()
                _listaFerias.Add(New ClsFeria(_drFeria.GetInt32(0), _drFeria.GetString(1))) 'cargar a la lista genérica el resultado de la consulta.
            End While


            Return _listaFerias 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Feria... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos las ferias que no asiste el socio en la DB
    ''' </summary>
    ''' <param name="pcedula"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarFeriaSinSocio(ByVal pcedula As String) As List(Of ClsFeria)
        Dim _drFeria As IDataReader 'instanciar un lector de datos genérico

        Dim _listaFerias As New List(Of ClsFeria) 'declarar e instanciar una lista genérica del tipo ClsFeria

        Try
            _drFeria = _dataAccess.listarFeriasNoAsisteSocio(pcedula) 'asignar al lector de datos el resultado de la consulta

            While _drFeria.Read()
                _listaFerias.Add(New ClsFeria(_drFeria.GetInt32(0), _drFeria.GetString(1))) 'cargar a la lista genérica el resultado de la consulta.
            End While


            Return _listaFerias 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Feria... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Metodo que elimina una feria que asiste el socio a la Base de datos
    ''' </summary>
    ''' <param name="pcodFeria"></param>
    ''' <param name="pcodSocio"></param>
    ''' <remarks></remarks>
    Public Sub eliminarFeriaSocio(ByVal pcodFeria As Int32, ByVal pcodSocio As String)

        Try
            _dataAccess.eliminarFeriaSocio(pcodFeria, pcodSocio)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que elimina una feria que asiste el auxiliar a la Base de datos
    ''' </summary>
    ''' <param name="pcodFeria"></param>
    ''' <param name="pcodAux"></param>
    ''' <remarks></remarks>
    Public Sub eliminarFeriaAux(ByVal pcodFeria As Int32, ByVal pcodAux As String)

        Try
            _dataAccess.eliminarFeriaSocio(pcodFeria, pcodAux)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que agrega una feria que asiste el socio a la Base de datos
    ''' </summary>
    ''' <param name="pcodFeria"></param>
    ''' <param name="pcodSocio"></param>
    ''' <remarks></remarks>
    Public Sub agregarFeriaSocio(ByVal pcodFeria As Int32, ByVal pcodSocio As String)

        Try
            _dataAccess.asignarFeriaSocio(pcodSocio, pcodFeria)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que agrega una feria que asiste el socio a la Base de datos
    ''' </summary>
    ''' <param name="pcodFeria"></param>
    ''' <param name="pcodAux"></param>
    ''' <remarks></remarks>
    Public Sub agregarFeriaAux(ByVal pcodFeria As Int32, ByVal pcodAux As String)

        Try
            _dataAccess.asignarFeriaSocio(pcodAux, pcodFeria)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Funcion que se encarga de buscar el maximo id en la tabla de ferias en la base de datos.
    ''' </summary>
    ''' <returns>Maximo id</returns>
    Public Function obtenerMayorIdFeria() As Integer
        Dim idMax As Integer
        Try
            idMax = _dataAccess.obtenerMayorIdFeria()
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
        Return idMax
    End Function
End Class
