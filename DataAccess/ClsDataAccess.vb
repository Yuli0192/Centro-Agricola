Imports System.Data.OleDb
''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class ClsDataAccess
    Public comand As OleDb.OleDbCommand

    Private conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BDCentroAgricola\BDCentroAgricola.mdb;")
    'Private conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDCentroAgricola\BDCentroAgricola.accdb;Persist Security Info=False")

#Region "Producto"
    ''' <summary>
    ''' Metodo que registra un nuevo producto a la Base de datos
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <param name="punidad"></param>
    ''' <remarks></remarks>
    Public Sub agregarProducto(ByVal pcod As Int32, ByVal pnombre As String, ByVal punidad As Int32)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = " INSERT INTO TProducto(codigo, nombre, unidad ) "
        sql &= "VALUES(" & pcod & ", '" & pnombre & "', " & punidad & ") "

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Metodo que registra un nuevo producto al socio a la Base de datos
    ''' </summary>
    ''' <param name="pcodSocio"></param>
    ''' <param name="pcodProducto"></param>
    ''' <param name="pcodPermiso"></param>
    ''' <remarks></remarks>
    Public Sub asignarProductoSocio(ByVal pcodSocio As String, ByVal pcodProducto As Int32, ByVal pcodPermiso As Int32)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = " INSERT INTO TProductoSocio(codsocio, codproducto, codpermiso ) "
        sql &= "VALUES('" & pcodSocio & "', " & pcodProducto & ", " & pcodPermiso & ") "

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Metodo que modificar un nuevo producto a la Base de datos
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <param name="punidad"></param>
    ''' <remarks></remarks>
    Public Sub modificarProducto(ByVal pcod As Int32, ByVal pnombre As String, ByVal punidad As Int32)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = " UPDATE TProducto "
        sql &= "SET nombre = '" & pnombre & "', unidad = " & punidad & " "
        sql &= "WHERE codigo = " & pcod & ";"

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Metodo que elimina un producto a la Base de datos
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <remarks></remarks>
    Public Sub eliminarProducto(ByVal pcod As Int32)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = " DELETE "
        sql &= "FROM TProducto "
        sql &= "WHERE codigo = " & pcod & ";"

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de producto a la base de datos 
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarProductoNombre(ByVal pnombre As String) As IDataReader
        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        'sql = "SELECT p.codigo, p.nombre, u.nombre FROM TProducto as p  INNER JOIN TUnidad as u on p.unidad = u.id Where p.nombre LIKE '" & pnombre & "%' order by p.nombre ASC"
        sql += " SELECT p.codigo, p.nombre, u.nombre "
        sql += " FROM TProducto as p  INNER JOIN TUnidad as u on p.unidad = u.id "
        sql += " Where p.nombre LIKE '" & pnombre & "%' or u.nombre LIKE '" & pnombre & "%' order by p.nombre ASC "

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        'comand.Connection.Close()
        Return dr
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los productos en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarProductos() As IDataReader

        Dim sql As String
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = "SELECT p.codigo, p.nombre, u.nombre FROM TProducto as p  INNER JOIN TUnidad as u on p.unidad = u.id order by p.nombre ASC"

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return dr
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos las ferias que asiste el socio en la DB
    ''' </summary>
    ''' <param name="ppermiso"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarProductoSocio(ByVal ppermiso As Int32) As IDataReader

        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT  pr.codigo, pr.nombre, pr.unidad "
        sql += "FROM  TProducto AS pr INNER JOIN TProductoSocio AS ps ON pr.codigo=ps.codproducto "
        sql += "WHERE  ps.codpermiso= " & ppermiso & " order by pr.nombre ASC "
        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return dr
    End Function
#End Region

#Region "Socio"
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
    ''' <remarks></remarks>
    Public Sub agregarSocio(ByVal pcod As String, ByVal pcedula As String, ByVal pnombre As String, _
                              ByVal pdireccionFinca As String, ByVal pdireccionCasa As String, ByVal ptelefono As String, _
                              ByVal pcorreo As String, ByVal pfechaIngreso As Date)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = " INSERT INTO TSocio(codigo, cedula, nombre, direccionfinca, direccioncasa, telefono, correo, fechaingreso, activo) "
        sql &= "VALUES('" & pcod & "', '" & pcedula & "', '" & pnombre & "', '" & pdireccionFinca & "', '" & pdireccionCasa & "', '" & ptelefono & "', '" & pcorreo & "', '" & pfechaIngreso & "', " & 1 & ") "

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Metodo para asignar una feria al socio a la Base de datos
    ''' </summary>
    ''' <param name="pcodSocio"></param>
    ''' <param name="pcodFeria"></param>
    ''' <remarks></remarks>
    Public Sub asignarFeriaSocio(ByVal pcodSocio As String, ByVal pcodFeria As Int32)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = " INSERT INTO TFeriaSocio(codFeria, codSocio) "
        sql &= "VALUES(" & pcodFeria & ", '" & pcodSocio & "') "

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Metodo que registra un nuevo socio a la Base de datos
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <param name="pcedula"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="ptelefono"></param>
    ''' <param name="pcorreo"></param>
    ''' <param name="pfechaIngreso"></param>
    ''' <remarks></remarks>
    Public Sub modificarSocio(ByVal pcod As String, ByVal pcedula As String, ByVal pnombre As String, _
                              ByVal pdireccionFinca As String, ByVal pdireccionCasa As String, ByVal ptelefono As String, _
                              ByVal pcorreo As String, ByVal pfechaIngreso As Date)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        sql = " UPDATE TSocio "
        sql &= "SET cedula = '" & pcedula & "', nombre = '" & pnombre & "', direccionfinca = '" & pdireccionFinca & "',direccioncasa = '" & pdireccionCasa & "', telefono = '" & ptelefono & "', correo = '" & pcorreo & "', fechaingreso = '" & pfechaIngreso & "', activo = " & 1 & " "
        sql &= "WHERE codigo = '" & pcod & "';"

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Metodo que elimina un socio a la Base de datos
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <remarks></remarks>
    Public Sub eliminarSocio(ByVal pcod As String)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        sql = " UPDATE TSocio "
        sql &= "SET activo = " & 0 & " "
        sql &= "WHERE codigo = '" & pcod & "';"

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Metodo que activa un socio a la Base de datos
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <remarks></remarks>
    Public Sub activarSocio(ByVal pcod As String)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        sql = " UPDATE TSocio "
        sql &= "SET activo = " & 1 & " "
        sql &= "WHERE codigo = '" & pcod & "';"

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de socio a la base de datos 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarCriterioSocio(ByVal pcriterio As String) As IDataReader
        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT codigo, cedula, nombre, direccionfinca, direccioncasa, telefono, correo, fechaingreso "
        sql += " FROM TSocio "
        sql += "Where activo = " & 1 & " and nombre LIKE '" & pcriterio & "%' or  cedula LIKE '" & pcriterio & "%' and activo = " & 1 & " order by nombre ASC "

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        'comand.Connection.Close()
        Return dr
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de socio a la base de datos 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarCriterioSocioInactivo(ByVal pcriterio As String) As IDataReader
        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT codigo, cedula, nombre, direccionfinca, direccioncasa, telefono, correo, fechaingreso "
        sql += " FROM TSocio "
        sql += "Where activo = " & 0 & " and nombre LIKE '" & pcriterio & "%' or  cedula LIKE '" & pcriterio & "%' and activo = " & 0 & " order by nombre ASC "

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        'comand.Connection.Close()
        Return dr
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de socio por medio del producto a la base de datos 
    ''' </summary>
    ''' <param name="pproducto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarSocioProducto(ByVal pproducto As String) As IDataReader
        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT min(s.codigo), min(s.cedula), min(s.nombre) "
        sql += "FROM  ((TProducto AS pr INNER JOIN TProductoSocio AS ps ON pr.codigo=ps.codproducto) INNER JOIN TSocio AS s ON ps.codsocio=s.codigo) INNER JOIN TPermiso AS p ON s.codigo=p.codsocio "
        sql += "WHERE pr.nombre LIKE '" & pproducto & "%' and s.activo = " & 1 & " "
        sql += " GROUP BY s.nombre "

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        'comand.Connection.Close()
        Return dr
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los socios en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarSocios() As IDataReader

        Dim sql As String
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = "SELECT codigo, cedula, nombre, direccionfinca, direccioncasa, telefono, correo, fechaingreso FROM TSocio Where activo = " & 1 & " order by nombre ASC"

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return dr
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los socios en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarSociosInactivo() As IDataReader

        Dim sql As String
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = "SELECT codigo, cedula, nombre, direccionfinca, direccioncasa, telefono, correo, fechaingreso FROM TSocio Where activo = " & 0 & " order by nombre ASC"

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return dr
    End Function

    ''' <summary>
    ''' Obtiene la cantidad de socios activos que estan registrados en el sistema
    ''' </summary>
    ''' <returns>Cantidad socios</returns>
    ''' <remarks></remarks>
    Public Function obtenerCantidadSocioActivo() As Integer
        Dim _cantSocio As Integer
        Dim sql As String
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = "SELECT COUNT(codigo) as [Codigo socio]FROM(TSocio)WHERE activo = 1;"
        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
            If dr.Read Then
                Dim resul As Object = dr.GetValue(0)
                _cantSocio = Convert.ToInt32(resul)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return _cantSocio
    End Function
#End Region

#Region "Auxiliar"
    ''' <summary>
    ''' Metodo que registra un nuevo auxiliar a la Base de datos
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <param name="pcedula"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="ptelefono"></param>
    ''' <param name="pparentesco"></param>
    ''' <remarks></remarks>
    Public Sub agregarAuxiliar(ByVal pcod As String, ByVal pcedula As String, ByVal pnombre As String, _
                               ByVal ptelefono As String, ByVal pparentesco As String)

        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = " INSERT INTO TAuxiliar(codigo, cedula, nombre, telefono, parentesco, activo) "
        sql &= "VALUES('" & pcod & "', '" & pcedula & "', '" & pnombre & "', '" & ptelefono & "', '" & pparentesco & "', " & 1 & ") "

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Metodo que modifica un auxiliar a la Base de datos
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <param name="pcedula"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="ptelefono"></param>
    ''' <param name="pparentesco"></param>
    ''' <remarks></remarks>
    Public Sub modificarAuxiliar(ByVal pcod As String, ByVal pcedula As String, ByVal pnombre As String, _
                              ByVal ptelefono As String, ByVal pparentesco As String)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        sql = " UPDATE TAuxiliar "
        sql &= "SET cedula = '" & pcedula & "', nombre = '" & pnombre & "', telefono = '" & ptelefono & "', parentesco = '" & pparentesco & "', activo = " & 1 & " "
        sql &= "WHERE codigo = '" & pcod & "';"

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Metodo que elimina un auxiliar a la Base de datos
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <remarks></remarks>
    Public Sub eliminarAuxiliar(ByVal pcod As String)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        sql = " UPDATE TAuxiliar "
        sql &= "SET activo = " & 0 & " "
        sql &= "WHERE codigo = '" & pcod & "';"

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Metodo que activa un auxiliar a la Base de datos
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <remarks></remarks>
    Public Sub activarAuxiliar(ByVal pcod As String)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        sql = " UPDATE TAuxiliar "
        sql &= "SET activo = " & 1 & " "
        sql &= "WHERE codigo = '" & pcod & "';"

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de auxiliar a la base de datos 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarCriterioAuxiliar(ByVal pcriterio As String) As IDataReader
        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT codigo, cedula, nombre, telefono, parentesco "
        sql += " FROM TAuxiliar "
        sql += "Where activo = " & 1 & " and nombre LIKE '" & pcriterio & "%' or  cedula LIKE '" & pcriterio & "%' and activo = " & 1 & " order by nombre ASC "

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        'comand.Connection.Close()
        Return dr
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de auxiliar inactivo a la base de datos 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarCriterioAuxiliarInactivo(ByVal pcriterio As String) As IDataReader
        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT codigo, cedula, nombre, telefono, parentesco "
        sql += " FROM TAuxiliar "
        sql += "Where activo = " & 0 & " and nombre LIKE '" & pcriterio & "%' or  cedula LIKE '" & pcriterio & "%' and activo = " & 0 & " order by nombre ASC "

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        'comand.Connection.Close()
        Return dr
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de auxiliar a la base de datos 
    ''' </summary>
    ''' <param name="pproducto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarAuxiliarProducto(ByVal pproducto As String) As IDataReader
        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT min(a.codigo), min(a.cedula), min(a.nombre) "
        sql += "FROM ((((TProducto AS pr INNER JOIN TProductoSocio AS ps ON pr.codigo = ps.codproducto) INNER JOIN TSocio AS s ON ps.codsocio = s.codigo) INNER JOIN TPermiso AS p ON s.codigo = p.codsocio) INNER JOIN TAuxiliar AS a ON p.codauxiliar = a.codigo) "
        sql += "Where pr.nombre  LIKE '" & pproducto & "%' and a.activo = " & 1 & " "
        sql += "GROUP BY a.nombre "
        sql += "ORDER BY a.nombre ASC "

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        'comand.Connection.Close()
        Return dr
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los auxiliares en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarAuxiliares() As IDataReader

        Dim sql As String
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = "SELECT codigo, cedula, nombre, telefono, parentesco FROM TAuxiliar Where activo = " & 1 & " order by nombre ASC"

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return dr
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los auxiliares inactivo en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarAuxiliaresInactivo() As IDataReader

        Dim sql As String
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = "SELECT codigo, cedula, nombre, telefono, parentesco FROM TAuxiliar Where activo = " & 0 & " order by nombre ASC"

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return dr
    End Function
#End Region

#Region "Feria"
    ''' <summary>
    ''' Metodo que registra una nueva feria a la Base de datos
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <param name="pnombre"></param>
    ''' <remarks></remarks>
    Public Sub agregarFeria(ByVal pcod As Int32, ByVal pnombre As String)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = " INSERT INTO TFeria(cod, nombre) "
        sql &= "VALUES(" & pcod & ", '" & pnombre & "') "

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

   
    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de la feria a la base de datos 
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarFeriaNombre(ByVal pnombre As String) As IDataReader
        Dim sql As String
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = "SELECT cod, nombre FROM TFeria Where nombre LIKE '" & pnombre & "%' order by nombre ASC"

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        'comand.Connection.Close()
        Return dr
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos las ferias en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarFerias() As IDataReader

        Dim sql As String
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = "SELECT cod, nombre FROM TFeria order by nombre ASC"

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return dr
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos las ferias que asiste el socio en la DB
    ''' </summary>
    ''' <param name="pcodigo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarFeriasAsisteSocio(ByVal pcodigo As String) As IDataReader

        Dim sql As String
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = "SELECT f.cod, f.nombre FROM TFeriaSocio as fs INNER JOIN TFeria as f on fs.codferia = f.cod Where fs.codsocio = '" & pcodigo & "' order by f.nombre ASC"

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return dr
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos las ferias que no asiste el socio en la DB
    ''' </summary>
    ''' <param name="pcodigo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarFeriasNoAsisteSocio(ByVal pcodigo As String) As IDataReader

        Dim sql As String
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = "SELECT f.cod, f.nombre FROM TFeria as f Where f.cod not in (select f.cod  FROM TFeriaSocio as fs INNER JOIN TFeria as f on fs.codferia = f.cod where fs.codsocio = '" & pcodigo & "')  order by f.nombre ASC"

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return dr
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos las ferias que no asiste el socio en la DB
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarFeriasNoAsisteSocio(ByVal pcodigo As String, ByVal pnombre As String) As IDataReader

        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT f.cod, f.nombre "
        sql += "FROM TFeria as f "
        sql += "Where f.cod not in (select f.cod  FROM TFeriaSocio as fs INNER JOIN TFeria as f on fs.codferia = f.cod where fs.codsocio = '" & pcodigo & "')  and f.nombre Like '" & pnombre & "%' order by f.nombre ASC "

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return dr
    End Function

    ''' <summary>
    ''' Metodo que elimina una feria que asiste el socio a la Base de datos
    ''' </summary>
    ''' <param name="pcodFeria"></param>
    ''' <param name="pcodSocio"></param>
    ''' <remarks></remarks>
    Public Sub eliminarFeriaSocio(ByVal pcodFeria As Int32, ByVal pcodSocio As String)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = " DELETE "
        sql &= "FROM TFeriaSocio "
        sql &= "WHERE codferia = " & pcodFeria & " and codsocio = '" & pcodSocio & "';"

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Funcion que se encarga de buscar el maximo id en la tabla de ferias en la base de datos.
    ''' </summary>
    ''' <returns>Maximo id</returns>
    Public Function obtenerMayorIdFeria() As Integer
        Dim idMax As Integer

        Dim sql As String
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = "SELECT MAX(cod) as MaxId FROM TFeria;"

        comand = New OleDbCommand(Sql, conn)

        Try
            dr = comand.ExecuteReader

            If dr.Read Then
                idMax = dr.GetInt32(0)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return idMax
    End Function
#End Region

#Region "Finca"
    ''' <summary>
    ''' Metodo que registra un nuevo socio a la Base de datos
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <param name="pdireccion"></param>
    ''' <param name="parea"></param>
    ''' <remarks></remarks>
    Public Sub agregarFinca(ByVal pnombre As String, ByVal pdireccion As String, _
                            ByVal parea As Int32)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = " INSERT INTO TFinca(nombre, direccion, area) "
        sql &= "VALUES('" & pnombre & "', '" & pdireccion & "', " & parea & ") "

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
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

        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = " INSERT INTO TAsignarFinca(codfinca, codsocio, tipocontrato, fechacontrato, fechavence) "
        sql &= "VALUES(" & pcodFinca & ", '" & pcodSocio & "','" & ptipoContrato & "', '" & pfechaContrato & "', '" & pfechaVenceContrato & "') "

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Metodo que modifica una finca a la Base de datos
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="pdireccion"></param>
    ''' <param name="parea"></param>
    ''' <remarks></remarks>
    Public Sub modificarFinca(ByVal pcod As Int32, ByVal pnombre As String, ByVal pdireccion As String, _
                            ByVal parea As Int32)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        sql = " UPDATE TFinca "
        sql &= "SET nombre = '" & pnombre & "', direccion = '" & pdireccion & "', area = " & parea & " "
        sql &= "WHERE codigo = " & pcod & ";"

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de la finca a la base de datos 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarCriterioFinca(ByVal pcriterio As String) As IDataReader
        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT codigo, nombre, direccion, area "
        sql += " FROM TFinca "
        sql += "Where nombre LIKE '" & pcriterio & "%' order by nombre ASC "

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        'comand.Connection.Close()
        Return dr
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todas las fincas en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarFincas() As IDataReader

        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT codigo, nombre, direccion, area "
        sql += " FROM TFinca "
        sql += "order by nombre ASC "
        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return dr
    End Function

    ''' <summary>
    ''' Funcion que se encarga de obtener el total del area de las fincas en la base de datos.
    ''' </summary>
    ''' <returns>Total área</returns>
    Public Function obtenerTotalAreaFinca() As Integer
        Dim totalArea As Integer

        Dim sql As String
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = "SELECT SUM(area) as totalArea FROM TFinca;"

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader

            If dr.Read Then
                'El error ese or que no esta devolviendo un Int32 y usted
                'no puede decirle getInt por eso se cae... y tenemos q ver
                'Cual es el tipo real q devuelve... En el Debug no podemos ver el tipo
                'vamos a tener que sacarlos. jajaja no salio el tipo mi amor jajajaj
                ' yo me acuerdo q un metodo em devuelve el tipo pero no es este... vaos a ver jajajaj :p
                'Di ni modo mi amor no le pude esnseñar ese toque de ver el tipo no me acuerdo jajaja
                'pero vamos a solucionarlo asi mi princesa... vea..
                'Probemos una ultima cosa jajaja antes de explicarle es q quede picado de no poder sacar el tipo 
                'jajaja :p

                'GetValue(indice de la columna) , ese metodo nos devuelve el resultado como Object
                'Vea aqui lo puede ver. ve ahi donde decias AS Object???sip
                'Entonces yo lo que hago abajo

                ''me devuelve el tipo q retorna
                ''Dim tipoDato As String = dr.GetValue(0).GetType.ToString()

                'lo que hago aqui es lo siguiente, ve el resultado que me lo devuelve
                'como Object yo lo convierto a entero... entonces si el resultaod
                'es un double como este 1100.34, al yo hacer el convet.ToInte32 l equita
                'lso decimales y entonces le pone 1100... y se puede almacenar en totalArea.. 
                'me entendio mi amor???sip amor :) ve por eso es bueno leer los metodos
                'leer lo que recibe y lo q retorna... no aprendernos de memoria todo.. si no 
                'leer q metodos ofrecen las clase... como esa variable dr que ofrece ese metod 
                'GetValue... :P y muchos mas...
                'lastiama q esta en ingles jajajajajaj... ajaja verdad jajaja 
                'convierto el dato q me retorna a object y lo convierto en entero
                ''Dim result As Object = dr.GetValue(0)
                ''totalArea = Convert.ToInt32(result)
                totalArea = dr.GetDouble(0)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return totalArea
    End Function
#End Region

#Region "Permiso"
    ''' <summary>
    ''' Metodo que registra una nuevo permiso a la Base de datos
    ''' </summary>
    ''' <param name="pcodPermiso"></param>
    ''' <param name="pcodSocio"></param>
    ''' <param name="pfechacrea"></param>
    ''' <param name="pfechavence"></param>
    ''' <remarks></remarks>
    Public Sub agregarPermiso(ByVal pcodPermiso As Int32, ByVal pcodSocio As String, ByVal pfechacrea As Date, ByVal pfechavence As Date)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = " INSERT INTO TPermiso(codpermiso, codsocio, codauxiliar, nombreaux, fechacrea, fechavence, estado) "
        sql &= "VALUES(" & pcodPermiso & ", '" & pcodSocio & "', '" & "0" & "', '" & "" & "', '" & pfechacrea & "', '" & pfechavence & "', '" & "pendiente" & "') "

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Metodo que registra una nuevo permiso a la Base de datos
    ''' </summary>
    ''' <param name="pcodPermiso"></param>
    ''' <param name="pcodAux"></param>
    ''' <param name="pfechacrea"></param>
    ''' <param name="pfechavence"></param>
    ''' <remarks></remarks>
    Public Sub agregarPermisoAux(ByVal pcodPermiso As Int32, ByVal pcodSocio As String, _
                                 ByVal pcodAux As String, ByVal pnombreAux As String, ByVal pfechacrea As Date, ByVal pfechavence As Date)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = " INSERT INTO TPermiso(codpermiso, codsocio, codauxiliar, nombreaux, fechacrea, fechavence, estado) "
        sql &= "VALUES(" & pcodPermiso & ", '" & pcodSocio & "', '" & pcodAux & "', '" & pnombreAux & "', '" & pfechacrea & "', '" & pfechavence & "', '" & "pendiente" & "') "

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Metodo que asignar permiso al auxiliar a la Base de datos
    ''' </summary>
    ''' <param name="pcodPermiso"></param>
    ''' <param name="pcodAuxiliar"></param>
    ''' <remarks></remarks>
    Public Sub agregarPermisoAuxiliar(ByVal pcodPermiso As Int32, ByVal pcodAuxiliar As String, ByVal pnombreAux As String)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = " UPDATE TPermiso "
        sql &= "SET codauxiliar = '" & pcodAuxiliar & "', nombreaux = '" & pnombreAux & "' "
        sql &= "WHERE codpermiso = " & pcodPermiso & ";"

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Funcion que se encarga de buscar el maximo id en la tabla de permiso en la base de datos.
    ''' </summary>
    ''' <returns>Maximo id</returns>
    Public Function obtenerMayorIdPermiso() As Integer
        Dim idMax As Integer

        Dim sql As String
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = "SELECT MAX(codpermiso) as MaxId FROM TPermiso;"

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader

            If dr.Read Then
                idMax = dr.GetInt32(0)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return idMax
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de un permiso a la base de datos 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarCriterioPermiso(ByVal pcriterio As Int32) As IDataReader
        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT p.codpermiso, s.nombre, p.fechacrea, p.fechavence "
        sql += " FROM  TPermiso as p INNER JOIN TSocio as s on p.codsocio = s.codigo "
        sql += "Where p.codpermiso LIKE '" & pcriterio & "%' and p.codauxiliar = '" & "0" & "' and p.estado = '" & "pendiente" & "' order by p.codpermiso DESC "

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        'comand.Connection.Close()
        Return dr
    End Function


    ''' <summary>
    ''' Método de la clase encargada de buscar todos los permisos en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarPermisos() As IDataReader

        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT p.codpermiso, s.nombre, p.fechacrea, p.fechavence "
        sql += "FROM  TPermiso as p INNER JOIN TSocio as s on p.codsocio = s.codigo "
        sql += "WHERE p.codauxiliar= '" & "0" & "' and p.estado = '" & "pendiente" & "' order by p.codpermiso DESC "
        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return dr
    End Function

    ''' <summary>
    ''' Metodo que modifica el estado del permiso a la Base de datos
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub modificarEstadoPermiso()
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        sql = " UPDATE TPermiso "
        sql &= "SET  estado = '" & "vencido" & "' "
        sql &= "WHERE (SELECT MAX(p.fechavence) from TPermiso p INNER JOIN TSocio s  on p.codsocio = s.codigo WHERE p.codsocio = s.codigo)  < Date() and estado = '" & "pendiente" & "';"

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar los permisos vencidos a la base de datos 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarPermisoVencidos() As IDataReader
        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT  s.codigo, s.cedula, s.nombre, s.direccionfinca, s.direccioncasa, s.telefono, s.correo, (SELECT MAX(p.fechavence) from TPermiso p WHERE p.codsocio = s.codigo) "
        sql += "FROM Tsocio AS s "
        sql += "Where (SELECT MAX(p.fechavence) from TPermiso p WHERE p.codsocio = s.codigo)  < Date() "

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        'comand.Connection.Close()
        Return dr
    End Function


    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de un permiso a la base de datos 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarCriterioPermisoSocioPendiente(ByVal pcriterio As String) As IDataReader
        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT p.codpermiso, s.cedula, s.nombre, p.fechacrea, p.fechavence "
        sql += " FROM  TPermiso as p INNER JOIN TSocio as s on p.codsocio = s.codigo "
        sql += "Where s.cedula LIKE '" & pcriterio & "%' and p.estado = '" & "pendiente" & "' or s.nombre LIKE '" & pcriterio & "%' and p.estado = '" & "pendiente" & "' order by s.nombre ASC "

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        'comand.Connection.Close()
        Return dr
    End Function


    ''' <summary>
    ''' Método de la clase encargada de buscar todos los permisos en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarPermisosSocioPendiente() As IDataReader

        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        'sql += "SELECT p.codpermiso, s.cedula, s.nombre, p.fechacrea, p.fechavence "
        'sql += "FROM  TPermiso as p INNER JOIN TSocio as s on p.codsocio = s.codigo "
        'sql += "WHERE p.codauxiliar= '" & "0" & "' and p.estado = '" & "pendiente" & "' order by s.nombre ASC "
        'comand = New OleDbCommand(sql, conn)

        sql += "SELECT p.codpermiso, s.cedula, s.nombre, p.fechacrea, p.fechavence "
        sql += "FROM  TPermiso as p INNER JOIN TSocio as s on p.codsocio = s.codigo "
        sql += "WHERE p.estado = '" & "pendiente" & "' order by s.nombre ASC "
        comand = New OleDbCommand(sql, conn)
        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return dr
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de un permiso a la base de datos 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarCriterioPermisoAuxPendiente(ByVal pcriterio As String) As IDataReader
        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT p.codpermiso, a.cedula, a.nombre, p.fechacrea, p.fechavence "
        sql += " FROM  TPermiso as p INNER JOIN TAuxiliar as a on p.codauxiliar = a.codigo "
        sql += "Where a.cedula LIKE '" & pcriterio & "%' and p.estado = '" & "pendiente" & "' or a.nombre LIKE '" & pcriterio & "%' and p.estado = '" & "pendiente" & "' order by a.nombre ASC "

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        'comand.Connection.Close()
        Return dr
    End Function


    ''' <summary>
    ''' Método de la clase encargada de buscar todos los permisos en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarPermisosAuxPendiente() As IDataReader

        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT p.codpermiso, a.cedula, a.nombre, p.fechacrea, p.fechavence "
        sql += "FROM  TPermiso as p INNER JOIN TAuxiliar as a on p.codauxiliar = a.codigo "
        sql += "WHERE p.codauxiliar <> '" & "0" & "' and p.estado = '" & "pendiente" & "' order by a.nombre ASC "
        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return dr
    End Function
#End Region

#Region "Inspeccion"
    ''' <summary>
    ''' Metodo que registra una nueva inspeccion a la Base de datos
    ''' </summary>
    ''' <param name="pcodInsp"></param>
    ''' <param name="pcodSocio"></param>
    ''' <param name="pfechacrea"></param>
    ''' <param name="pfechavence"></param>
    ''' <remarks></remarks>
    Public Sub agregarInspeccion(ByVal pcodInsp As Int32, ByVal pfechacrea As Date, ByVal pfechavence As Date, ByVal pcodSocio As String)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = " INSERT INTO TInspeccion(solicitud, fechacrea, fechavence, codsocio, estado) "
        sql &= "VALUES(" & pcodInsp & ", '" & pfechacrea & "', '" & pfechavence & "', '" & pcodSocio & "', '" & "pendiente" & "') "

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Funcion que se encarga de buscar el maximo id en la tabla de inspeccion en la base de datos.
    ''' </summary>
    ''' <returns>Maximo id</returns>
    Public Function obtenerMayorIdInspeccion() As Integer
        Dim idMax As Integer

        Dim sql As String
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = "SELECT MAX(solicitud) as MaxId FROM TInspeccion;"

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader

            If dr.Read Then
                idMax = dr.GetInt32(0)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return idMax
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar los carnet vencidos a la base de datos 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarCarnetVencidos() As IDataReader
        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT  s.codigo, s.cedula, s.nombre, s.direccionfinca, s.direccioncasa, s.telefono, s.correo, (SELECT MAX(i.fechavence) from TInspeccion i WHERE i.codsocio = s.codigo) "
        sql += "FROM Tsocio AS s "
        sql += "Where (SELECT MAX(i.fechavence) from TInspeccion i WHERE i.codsocio = s.codigo)  < Date() "

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        'comand.Connection.Close()
        Return dr
    End Function

    ''' <summary>
    ''' Metodo que modifica el estado del permiso a la Base de datos
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub modificarEstadoInspeccion()
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        sql = " UPDATE TInspeccion "
        sql &= "SET  estado = '" & "vencido" & "' "
        sql &= "WHERE (SELECT MAX(i.fechavence) from TInspeccion i INNER JOIN TSocio s  on i.codsocio = s.codigo WHERE i.codsocio = s.codigo)  < Date() and estado = '" & "pendiente" & "';"

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de una inspeccion a la base de datos 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarCriterioInspeccionSocioPendiente(ByVal pcriterio As String) As IDataReader
        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT i.solicitud, i.fechacrea, i.fechavence, s.cedula, s.nombre "
        sql += " FROM  TInspeccion as i INNER JOIN TSocio as s on i.codsocio = s.codigo "
        sql += "Where s.cedula LIKE '" & pcriterio & "%' and i.estado = '" & "pendiente" & "' or s.nombre LIKE '" & pcriterio & "%' and i.estado = '" & "pendiente" & "' order by s.nombre ASC "

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        'comand.Connection.Close()
        Return dr
    End Function


    ''' <summary>
    ''' Método de la clase encargada de buscar todos los inspecciones en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarInspeccionSocioPendiente() As IDataReader

        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT i.solicitud, i.fechacrea, i.fechavence, s.cedula, s.nombre  "
        sql += "FROM  TInspeccion as i INNER JOIN TSocio as s on i.codsocio = s.codigo "
        sql += "WHERE i.estado = '" & "pendiente" & "' order by s.nombre ASC "
        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return dr
    End Function
#End Region

#Region "Cliente"
    ''' <summary>
    ''' Metodo que registra un nuevo cliente a la Base de datos
    ''' </summary>
    ''' <param name="pcedula"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="pdireccion"></param>
    ''' <param name="ptelefono"></param>
    ''' <param name="pfechaIngreso"></param>
    ''' <remarks></remarks>
    Public Sub agregarCliente(ByVal pcedula As String, ByVal pnombre As String, ByVal pdireccion As String, _
                              ByVal ptelefono As String, ByVal pfechaIngreso As Date)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = " INSERT INTO TCliente(cedula, nombre, direccion, telefono, fechaingreso, salariobase, cuota, activo, cantingreso) "
        sql &= "VALUES('" & pcedula & "', '" & pnombre & "', '" & pdireccion & "', '" & ptelefono & "', '" & pfechaIngreso & "', " & 0 & ", " & 0 & ", " & 1 & ", " & 1 & ") "

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Metodo que registra un nuevo cliente a la Base de datos
    ''' </summary>
    ''' <param name="pcedula"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="pdireccion"></param>
    ''' <param name="ptelefono"></param>
    ''' <param name="pfechaIngreso"></param>
    ''' <param name="psalarioBase"></param>
    ''' <param name="pcuota"></param>
    ''' <remarks></remarks>
    Public Sub modificarCliente(ByVal pcedula As String, ByVal pnombre As String, ByVal pdireccion As String, _
                              ByVal ptelefono As String, ByVal pfechaIngreso As Date, ByVal psalarioBase As Int32, _
                              ByVal pcuota As Int32)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        sql = " UPDATE TCliente "
        sql &= "SET nombre = '" & pnombre & "', direccion = '" & pdireccion & "', telefono = '" & ptelefono & "', fechaingreso = '" & pfechaIngreso & "', salariobase = " & psalarioBase & ", cuota = " & pcuota & " "
        sql &= "WHERE cedula = '" & pcedula & "';"

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Metodo que elimina un cliente a la Base de datos
    ''' </summary>
    ''' <param name="pcedula"></param>
    ''' <remarks></remarks>
    Public Sub eliminarCliente(ByVal pcedula As String)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        sql = " UPDATE TCliente "
        sql &= "SET activo = " & 0 & " "
        sql &= "WHERE cedula = '" & pcedula & "';"

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Metodo que activa un cliente a la Base de datos
    ''' </summary>
    ''' <param name="pcedula"></param>
    ''' <param name="pcantiIng"></param>
    ''' <remarks></remarks>
    Public Sub activarCliente(ByVal pcedula As String, ByVal pcantiIng As Int32)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        sql = " UPDATE TCliente "
        sql &= "SET activo = " & 1 & ", cantingreso = " & pcantiIng & " "
        sql &= "WHERE cedula = '" & pcedula & "';"

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de cliente a la base de datos 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarCriterioCliente(ByVal pcriterio As String) As IDataReader
        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT cedula, nombre, direccion, telefono, fechaingreso, salariobase, cuota, cantingreso "
        sql += " FROM TCliente "
        sql += "Where activo = " & 1 & " and nombre LIKE '" & pcriterio & "%' or  cedula LIKE '" & pcriterio & "%' and activo = " & 1 & " order by nombre ASC "

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        'comand.Connection.Close()
        Return dr
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de cliente a la base de datos 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarCriterioClienteInactivo(ByVal pcriterio As String) As IDataReader
        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT cedula, nombre, direccion, telefono, fechaingreso, salariobase, cuota, cantingreso "
        sql += " FROM TCliente "
        sql += "Where activo = " & 0 & " and nombre LIKE '" & pcriterio & "%' or  cedula LIKE '" & pcriterio & "%' and activo = " & 0 & " order by nombre ASC "

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        'comand.Connection.Close()
        Return dr
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los cliente en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarClientes() As IDataReader

        Dim sql As String
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = "SELECT cedula, nombre, direccion, telefono, fechaingreso, salariobase, cuota, cantingreso FROM TCliente Where activo = " & 1 & " order by nombre ASC"

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return dr
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los clientes en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarClientesInactivo() As IDataReader

        Dim sql As String
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = "SELECT cedula, nombre, direccion, telefono, fechaingreso, salariobase, cuota, cantingreso FROM TCliente Where activo = " & 0 & " order by nombre ASC"

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return dr
    End Function
#End Region

#Region "Orden"
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
    Public Sub agregarOrden(ByVal pcedulaCliente As String, ByVal pmes As String, ByVal pmesNum As Int32, _
                            ByVal panno As Int32, ByVal pfechaCrea As Date, ByVal pfechaVence As Date, _
                            ByVal pmonto As Int32, ByVal psalario As Int32, ByVal pestado As String)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = " INSERT INTO TOrden (cedcliente, mes, mesnum, anno, fechacrea, fechavence, fechapago, monto, salariobase,multa, montopagar,estado) "
        sql &= "VALUES('" & pcedulaCliente & "', '" & pmes & "', " & pmesNum & ", " & panno & ", '" & pfechaCrea & "', '" & pfechaVence & "','" & 1 / 1 / 2000 & "', " & pmonto & ", " & psalario & "," & 0 & ", " & 0 & ", '" & pestado & "') "

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de cliente a la base de datos 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarOrdenesPendientes(ByVal pcriterio As String) As IDataReader
        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT cod, cedcliente, mes, anno, fechacrea, fechavence, fechapago, monto, salariobase, multa, montopagar, estado "
        sql += " FROM TOrden "
        sql += "Where cedcliente = '" & pcriterio & "' and estado = '" & "PENDIENTE" & "'  order by fechacrea ASC "

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        'comand.Connection.Close()
        Return dr
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de cliente a la base de datos 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarOrdenesCanceladas(ByVal pcriterio As String) As IDataReader
        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT cod, cedcliente, mes, anno, fechacrea, fechavence, fechapago, monto, salariobase, multa, montopagar, estado "
        sql += " FROM TOrden "
        sql += "Where cedcliente = '" & pcriterio & "' and estado = '" & "CANCELADO" & "' and anno = Year(Now()) order by fechapago DESC "

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        'comand.Connection.Close()
        Return dr
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de cliente a la base de datos 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarOrdenesCanceladas() As IDataReader
        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT c.cedula, c.nombre, o.mes, o.anno, o.fechacrea, o.fechavence , o.fechapago, o.montopagar, o.estado "
        sql += " FROM  TOrden o INNER JOIN TCliente c on o.cedcliente = c.cedula "
        sql += "Where estado = '" & "CANCELADO" & "' and anno = Year(Now()) order by c.nombre  ASC, o.fechapago DESC "

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        'comand.Connection.Close()
        Return dr
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de cliente a la base de datos 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarOrdenesCanceladasCriterio(ByVal pcriterio As String) As IDataReader
        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT c.cedula, c.nombre, o.mes, o.anno, o.fechacrea, o.fechavence , o.fechapago, o.montopagar, o.estado "
        sql += " FROM  TOrden o INNER JOIN TCliente c on o.cedcliente = c.cedula "
        sql += "Where  c.cedula LIKE '" & pcriterio & "%' and estado = '" & "CANCELADO" & "' and anno = Year(Now()) or c.nombre LIKE '" & pcriterio & "%' and estado = '" & "CANCELADO" & "' and anno = Year(Now()) order by c.nombre  ASC, o.fechapago DESC "

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        'comand.Connection.Close()
        Return dr
    End Function


    ''' <summary>
    ''' Metodo que modifica la multa a la Base de datos
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <remarks></remarks>
    Public Sub modificarMulta(ByVal pcod As Int32)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        sql = " UPDATE TOrden "
        sql &= "SET  multa = " & 1000 & " "
        sql &= "WHERE (Select fechavence From TOrden  where  cod = " & pcod & ")  < Date() and cod = " & pcod & ";"

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Metodo que modifica la multa a la Base de datos
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <remarks></remarks>
    Public Sub modificarMultaOrdenPendiente(ByVal pcod As Int32)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        sql = " UPDATE TOrden "
        sql &= "SET  multa = " & 1000 & " "
        sql &= "WHERE (Select fechavence From TOrden  where  cod = " & pcod & ")  < Date() and cod = " & pcod & ";"

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        'comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Funcion que se encarga de obtener el total del area de las fincas en la base de datos.
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <returns>Monto total</returns>
    Public Function obtenerMontoTotalOrden(ByVal pcod As Int32) As Double
        Dim montoTotal As Double

        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT SUM(monto + multa) as montoTotal "
        sql += "FROM TOrden "
        sql += "WHERE cod = " & pcod & " "

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader

            If dr.Read Then
                montoTotal = dr.GetDouble(0)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
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
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        sql = " UPDATE TOrden "
        sql &= "SET  fechapago = '" & pfechaPago & "', montopagar = " & pmontoPagar & ", estado = '" & pestado & "' "
        sql &= "WHERE cod = " & pcod & ";"

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de cliente a la base de datos 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarOrdenesPendientes() As IDataReader
        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT c.cedula, c.nombre, o.mes, o.anno, o.fechacrea, o.fechavence , o.fechapago, (o.monto + o.multa) AS [Monto a pagar] "
        sql += " FROM  TOrden o INNER JOIN TCliente c on o.cedcliente = c.cedula "
        sql += "Where estado = '" & "PENDIENTE" & "' and c.activo = " & 1 & " order by c.nombre  ASC, o.fechavence DESC "

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        'comand.Connection.Close()
        Return dr
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de cliente a la base de datos 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarOrdenesPendientesCriterio(ByVal pcriterio As String) As IDataReader
        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT c.cedula, c.nombre, o.mes, o.anno, o.fechacrea, o.fechavence , o.fechapago, (o.monto + o.multa) AS [Monto a pagar] "
        sql += "FROM  TOrden o INNER JOIN TCliente c on o.cedcliente = c.cedula "
        sql += "Where  c.cedula LIKE '" & pcriterio & "%' and estado = '" & "PENDIENTE" & "' and c.activo = " & 1 & " or c.nombre LIKE '" & pcriterio & "%' and estado = '" & "PENDIENTE" & "' and c.activo = " & 1 & " order by c.nombre  ASC, o.fechavence DESC "

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        'comand.Connection.Close()
        Return dr
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de cliente a la base de datos 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarOrdenes() As IDataReader
        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT cod "
        sql += " FROM TOrden "
        sql += "Where estado = '" & "PENDIENTE" & "' "

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        'comand.Connection.Close()
        Return dr
    End Function
#End Region

#Region "Usuario"
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
    Public Sub agregarUsuario(ByVal pcedula As String, ByVal pnombre As String, ByVal papellido1 As String, _
                              ByVal papellido2 As String, ByVal pcontrasenna As String, ByVal prol As String)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = " INSERT INTO TUsuario(cedula, nombre, apellido1, apellido2, contrasenna, rol, activo) "
        sql &= "VALUES('" & pcedula & "', '" & pnombre & "', '" & papellido1 & "', '" & papellido2 & "', '" & pcontrasenna & "', '" & prol & "', " & 1 & ") "

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
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
    Public Sub modificarUsuario(ByVal pcedula As String, ByVal pnombre As String, ByVal papellido1 As String, _
                              ByVal papellido2 As String, ByVal prol As String)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        sql = " UPDATE TUsuario "
        sql &= "SET nombre = '" & pnombre & "', apellido1 = '" & papellido1 & "', apellido2 = '" & papellido2 & "', rol = '" & prol & "' "
        sql &= "WHERE cedula = '" & pcedula & "';"

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Metodo que elimina un usuario a la Base de datos
    ''' </summary>
    ''' <param name="pcedula"></param>
    ''' <remarks></remarks>
    Public Sub eliminarUsuario(ByVal pcedula As String)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        sql = " UPDATE TUsuario "
        sql &= "SET activo = " & 0 & " "
        sql &= "WHERE cedula = '" & pcedula & "';"

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de un usuario a la base de datos 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarCriterioUsuario(ByVal pcriterio As String) As IDataReader
        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT cedula, nombre, apellido1, apellido2, contrasenna, rol "
        sql += " FROM TUsuario "
        sql += "Where activo = " & 1 & " and nombre LIKE '" & pcriterio & "%' or  cedula LIKE '" & pcriterio & "%' and activo = " & 1 & " order by nombre ASC "

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        'comand.Connection.Close()
        Return dr
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los usuario en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarUsuarios() As IDataReader

        Dim sql As String
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = "SELECT cedula, nombre, apellido1, apellido2, contrasenna, rol FROM TUsuario Where activo = " & 1 & " order by nombre ASC"

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return dr
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de un usuario a la base de datos 
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <param name="pcontrasenna"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarUsuarioNombreContrasenna(ByVal pnombre As String, ByVal pcontrasenna As String) As IDataReader
        Dim sql As String = ""
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql += "SELECT cedula, nombre, apellido1, apellido2, contrasenna, rol "
        sql += " FROM TUsuario "
        sql += "Where nombre = '" & pnombre & "' and  contrasenna = '" & pcontrasenna & "' "

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        'comand.Connection.Close()
        Return dr
    End Function
#End Region

#Region "Recibo"

    ''' <summary>
    ''' Metodo que registra un nuevo recibo a la Base de datos
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <param name="pfecha"></param>
    ''' <param name="pmonto"></param>
    ''' <param name="pconcepto"></param>
    ''' <remarks></remarks>
    Public Sub agregarRecibo(ByVal precibo As Int32, ByVal pnombre As String, ByVal pfecha As Date, _
                             ByVal phora As String, ByVal pmonto As Int32, ByVal pconcepto As String, ByVal ptipo As Int32)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = " INSERT INTO TRecibo(recibo, nombre, fecha, hora, monto, concepto, tipo) "
        sql &= "VALUES(" & precibo & ", '" & pnombre & "', '" & pfecha & "', '" & phora & "', " & pmonto & ", '" & pconcepto & "', " & ptipo & ") "

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Metodo que registra un nuevo recibo a la Base de datos
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <param name="pfecha"></param>
    ''' <param name="pmonto"></param>
    ''' <param name="pconcepto"></param>
    ''' <remarks></remarks>
    Public Sub agregarReciboOrden(ByVal precibo As Int32, ByVal pnombre As String, ByVal pfecha As Date, _
                             ByVal phora As String, ByVal pmonto As Int32, ByVal pconcepto As String, _
                             ByVal pmes As String, ByVal pmesNum As Int32, ByVal panno As Int32)
        Dim sql As String

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = " INSERT INTO TRecibo(recibo, nombre, fecha, hora, monto, concepto, mes, mesnum, anno, tipo) "
        sql &= "VALUES(" & precibo & ", '" & pnombre & "', '" & pfecha & "', '" & phora & "', " & pmonto & ", '" & pconcepto & "', '" & pmes & "', " & pmesNum & ", " & panno & ", " & 2 & ") "

        comand = New OleDbCommand(sql, conn)
        Try
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        comand.Connection.Close()
    End Sub

    ''' <summary>
    ''' Funcion que se encarga de buscar el maximo id en la tabla de recibo en la base de datos.
    ''' </summary>
    ''' <returns>Maximo id</returns>
    Public Function obtenerMayorIdRecibo() As Integer
        Dim idMax As Integer

        Dim sql As String
        Dim dr As IDataReader

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        sql = "SELECT MAX(recibo) as MaxId FROM TRecibo;"

        comand = New OleDbCommand(sql, conn)

        Try
            dr = comand.ExecuteReader

            If dr.Read Then
                idMax = dr.GetInt32(0)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return idMax
    End Function
#End Region
End Class
