Imports DataAccess.ClsDataAccess
Public Class ClsFincaPersist
    Dim _dataAccess As New DataAccess.ClsDataAccess

    ''' <summary>
    ''' Método de la clase, encargada de registrar los datos de una finca.
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <param name="pdireccion"></param>
    ''' <param name="parea"></param>
    ''' <remarks></remarks>
    Public Sub registrar(ByVal pnombre As String, _
                              ByVal pdireccion As String, ByVal parea As Int32)
        Try
            _dataAccess.agregarFinca(pnombre, pdireccion, parea) 'llama el método registrar de la clase finca persistente pasandole los datos de la finca.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase, encargada de asignar la finca al socio.
    ''' </summary>
    ''' <param name="pcodFinca"></param>
    ''' <param name="pcodSocio"></param>
    ''' <param name="ptipoContrato"></param>
    ''' <param name="pfechaContrato"></param>
    ''' <param name="pfechaVenceContrato"></param>
    ''' <remarks></remarks>
    Public Sub asignarFincaSocio(ByVal pcodFinca As Int32, ByVal pcodSocio As String, _
                              ByVal ptipoContrato As String, ByVal pfechaContrato As Date, ByVal pfechaVenceContrato As Date)

        Try
            _dataAccess.asignarFincaSocio(pcodFinca, pcodSocio, ptipoContrato, pfechaContrato, pfechaVenceContrato) 'llama el método asignarle la finca a un socio.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase, encargada de modificar los datos de una finca.
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="pdireccion"></param>
    ''' <param name="parea"></param>
    ''' <remarks></remarks>
    Public Sub modificar(ByVal pcod As Int32, ByVal pnombre As String, _
                              ByVal pdireccion As String, ByVal parea As Int32)

        Try
            _dataAccess.modificarFinca(pcod, pnombre, pdireccion, parea) 'llama el método registrar pasandole los datos de la finca.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    '''  Método de la clase encargada de buscar un registro de una finca a la base de datos 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarPorCriterio(ByVal pcriterio As String) As List(Of ClsFinca)

        Dim _drFinca As IDataReader 'instanciar un lector de datos genérico

        Dim _listaFincas As New List(Of ClsFinca) 'declarar e instanciar una lista genérica del tipo ClsFinca

        Try
            _drFinca = _dataAccess.buscarCriterioFinca(pcriterio) 'asignar al lector de datos el resultado de la consulta

            While _drFinca.Read()
                _listaFincas.Add(New ClsFinca(_drFinca.GetInt32(0), _drFinca.GetString(1), _drFinca.GetString(2), _drFinca.GetInt32(3))) 'cargar a la lista genérica el resultado de la consulta.
            End While


            Return _listaFincas 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Finca... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    '''  Método de la clase encargada de buscar un registro de una finca a la base de datos 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listar() As List(Of ClsFinca)

        Dim _drFinca As IDataReader 'instanciar un lector de datos genérico

        Dim _listaFincas As New List(Of ClsFinca) 'declarar e instanciar una lista genérica del tipo ClsFinca

        Try
            _drFinca = _dataAccess.listarFincas() 'asignar al lector de datos el resultado de la consulta

            While _drFinca.Read()
                _listaFincas.Add(New ClsFinca(_drFinca.GetInt32(0), _drFinca.GetString(1), _drFinca.GetString(2), _drFinca.GetInt32(3))) 'cargar a la lista genérica el resultado de la consulta.
            End While


            Return _listaFincas 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Finca... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Funcion que se encarga de obtener el total del área en la base de datos.
    ''' </summary>
    ''' <returns>Total área</returns>
    Public Function obtenerTotalArea() As Integer
        Dim totalArea As Integer
        Try
            totalArea = _dataAccess.obtenerTotalAreaFinca()
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
        Return totalArea
    End Function
End Class
