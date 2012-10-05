Imports DataAccess.ClsDataAccess
Public Class ClsUsuarioPersist
    Dim _dataAccess As New DataAccess.ClsDataAccess

    ''' <summary>
    ''' Metodo que registra un nuevo usuario a la Base de datos
    ''' </summary>
    ''' <param name="pcedula"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="papellido1"></param>
    ''' <param name="papellido2"></param>
    ''' <param name="pcontrasenna"></param>
    ''' <param name="prol"></param>
    ''' <remarks></remarks>
    Public Sub registrar(ByVal pcedula As String, ByVal pnombre As String, ByVal papellido1 As String, _
                              ByVal papellido2 As String, ByVal pcontrasenna As String, ByVal prol As String)

        Try
            _dataAccess.agregarUsuario(pcedula, pnombre, papellido1, papellido2, pcontrasenna, prol)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que modifica los datos de un usuario a la Base de datos
    ''' </summary>
    ''' <param name="pcedula"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="papellido1"></param>
    ''' <param name="papellido2"></param>
    ''' <param name="prol"></param>
    ''' <remarks></remarks>
    Public Sub modificar(ByVal pcedula As String, ByVal pnombre As String, ByVal papellido1 As String, _
                              ByVal papellido2 As String, ByVal prol As String)

        Try
            _dataAccess.modificarUsuario(pcedula, pnombre, papellido1, papellido2, prol)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que elimina un usuario a la Base de datos
    ''' </summary>
    ''' <param name="pcedula"></param>
    ''' <remarks></remarks>
    Public Sub eliminar(ByVal pcedula As String)

        Try
            _dataAccess.eliminarUsuario(pcedula)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de un usuario a la DB
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <remarks></remarks>
    Public Function buscarPorCriterio(ByVal pcriterio As String) As List(Of ClsUsuario)

        Dim _drUsuario As IDataReader 'instanciar un lector de datos genérico

        Dim _listaUsuarios As New List(Of ClsUsuario) 'declarar e instanciar una lista genérica del tipo ClsUsuario

        Try
            _drUsuario = _dataAccess.buscarCriterioUsuario(pcriterio) 'asignar al lector de datos el resultado de la consulta

            While _drUsuario.Read()
                _listaUsuarios.Add(New ClsUsuario(_drUsuario.GetString(0), _drUsuario.GetString(1), _drUsuario.GetString(2), _drUsuario.GetString(3), _drUsuario.GetString(4), _drUsuario.GetString(5))) 'cargar a la lista genérica el resultado de la consulta.

            End While


            Return _listaUsuarios 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Usuario... " & ex.Message)
        End Try

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de un usuario a la DB
    ''' </summary>
    ''' <remarks></remarks>
    Public Function listar() As List(Of ClsUsuario)

        Dim _drUsuario As IDataReader 'instanciar un lector de datos genérico

        Dim _listaUsuarios As New List(Of ClsUsuario) 'declarar e instanciar una lista genérica del tipo ClsUsuario

        Try
            _drUsuario = _dataAccess.listarUsuarios() 'asignar al lector de datos el resultado de la consulta

            While _drUsuario.Read()
                _listaUsuarios.Add(New ClsUsuario(_drUsuario.GetString(0), _drUsuario.GetString(1), _drUsuario.GetString(2), _drUsuario.GetString(3), _drUsuario.GetString(4), _drUsuario.GetString(5))) 'cargar a la lista genérica el resultado de la consulta.

            End While


            Return _listaUsuarios 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Usuario... " & ex.Message)
        End Try

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de un usuario a la DB
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <param name="pcontrasenna"></param>
    ''' <remarks></remarks>
    Public Function buscarPorNombreContrasenna(ByVal pnombre As String, ByVal pcontrasenna As String) As ClsUsuario

        Dim _drUsuario As IDataReader 'instanciar un lector de datos genérico

        Dim _usuario As ClsUsuario 'declarar e instanciar una lista genérica del tipo ClsUsuario

        Try
            _drUsuario = _dataAccess.buscarUsuarioNombreContrasenna(pnombre, pcontrasenna) 'asignar al lector de datos el resultado de la consulta

            While _drUsuario.Read()
                _usuario = New ClsUsuario(_drUsuario.GetString(0), _drUsuario.GetString(1), _drUsuario.GetString(2), _drUsuario.GetString(3), _drUsuario.GetString(4), _drUsuario.GetString(5)) 'cargar a la lista genérica el resultado de la consulta.

            End While


            Return _usuario 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Usuario... " & ex.Message)
        End Try

    End Function
End Class
