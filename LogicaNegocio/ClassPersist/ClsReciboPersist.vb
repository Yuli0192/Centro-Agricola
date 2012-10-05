Imports DataAccess.ClsDataAccess
Public Class ClsReciboPersist
    Dim _dataAccess As New DataAccess.ClsDataAccess

    ''' <summary>
    ''' Metodo que registra un nuevo recibo a la Base de datos
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <param name="pfecha"></param>
    ''' <param name="pmonto"></param>
    ''' <param name="pconcepto"></param>
    ''' <remarks></remarks>
    Public Sub registrarCarne(ByVal precibo As Int32, ByVal pnombre As String, ByVal pfecha As Date, _
                             ByVal phora As String, ByVal pmonto As Int32, ByVal pconcepto As String, ByVal ptipo As Int32)

        Try
            _dataAccess.agregarRecibo(precibo, pnombre, pfecha, phora, pmonto, pconcepto, ptipo)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que registra un nuevo recibo a la Base de datos
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <param name="pfecha"></param>
    ''' <param name="pmonto"></param>
    ''' <param name="pconcepto"></param>
    ''' <remarks></remarks>
    Public Sub registrarOrden(ByVal precibo As Int32, ByVal pnombre As String, ByVal pfecha As Date, _
                             ByVal phora As String, ByVal pmonto As Int32, ByVal pconcepto As String, _
                             ByVal pmes As String, ByVal pmesNum As Int32, ByVal panno As Int32)

        Try
            _dataAccess.agregarReciboOrden(precibo, pnombre, pfecha, phora, pmonto, pconcepto, pmes, pmesNum, panno)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Funcion que se encarga de buscar el maximo id en la tabla de recibo en la base de datos.
    ''' </summary>
    ''' <returns>Maximo id</returns>
    Public Function obtenerMayorIdRecibo() As Integer
        Dim idMax As Integer
        Try
            idMax = _dataAccess.obtenerMayorIdRecibo()
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
        Return idMax
    End Function
End Class
