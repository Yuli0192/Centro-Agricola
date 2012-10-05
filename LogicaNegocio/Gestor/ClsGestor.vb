Imports System.Configuration
Imports System.Security.Cryptography
Imports System.Text
Public Class ClsGestor
#Region "Atributos"
    Dim _clsProductoPersist As New ClsProductoPersist 'declacara y instancia una variable tipo producto persistente.
    Dim _clsSocioPersist As New ClsSocioPersist 'declacara y instancia una variable tipo socio persistente.
    Dim _clsAuxiliarPersist As New ClsAuxiliarPersist 'declacara y instancia una variable tipo auxiliar persistente.
    Dim _clsFeriaPersist As New ClsFeriaPersist 'declacara y instancia una variable tipo feria persistente.
    Dim _clsFincaPersist As New ClsFincaPersist 'declacara y instancia una variable tipo finca persistente.
    Dim _clsPermisoPersist As New ClsPermisoPersist 'declacara y instancia una variable tipo permiso persistente.
    Dim _clsInspeccionPersist As New ClsInspeccionPersist 'declacara y instancia una variable tipo inspección persistente.
    Dim _clsClientePersist As New ClsClientePersist 'declacara y instancia una variable tipo cliente persistente.
    Dim _clsOrdenPersist As New ClsOrdenPersist 'declacara y instancia una variable tipo orden persistente.
    Dim _clsUsuarioPersist As New ClsUsuarioPersist 'declacara y instancia una variable tipo usuario persistente.
    Dim _clsReciboPersist As New ClsReciboPersist 'declacara y instancia una variable tipo recibo persistente.
    Dim _productos As New List(Of ClsProducto) 'declarar una variable tipo lista genérica de la clase ClsProducto
    Dim _socios As New List(Of ClsSocio) 'declarar una variable tipo lista genérica de la clase ClsSocio
    Dim _auxiliares As New List(Of ClsAuxiliar) 'declarar una variable tipo lista genérica de la clase ClsAuxiliar
    Dim _ferias As New List(Of ClsFeria) 'declarar una variable tipo lista genérica de la clase ClsFeria
    Dim _fincas As New List(Of ClsFinca) 'declarar una variable tipo lista genérica de la clase ClsFinca
    Dim _permisos As New List(Of ClsPermiso) 'declarar una variable tipo lista genérica de la clase ClsPermiso
    Dim _inspecciones As New List(Of ClsInspeccion) 'declarar una variable tipo lista genérica de la clase ClsInspeccion
    Dim _clientes As New List(Of ClsCliente) 'declarar una variable tipo lista genérica de la clase ClsCliente
    Dim _ordenes As New List(Of ClsOrden) 'declarar una variable tipo lista genérica de la clase ClsOrden
    Dim _usuarios As New List(Of ClsUsuario) 'declarar una variable tipo lista genérica de la clase ClsUsuario

#End Region

#Region "Producto"
    ''' <summary>
    ''' Método de la clase, encargada de registrar los datos de un producto.
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <param name="punidad"></param>
    ''' <remarks></remarks>
    Public Sub registrarProducto(ByVal pcod As Int32, ByVal pnombre As String, ByVal punidad As Int32)
        Try
            _clsProductoPersist.registrar(pcod, pnombre, punidad) 'llama el método registrar de la clase producto persistente pasandole los datos del producto.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    '''' <summary>
    '''' Método que asigna productos al socio a la Base de datos
    '''' </summary>
    '''' <param name="pcodSocio"></param>
    '''' <param name="pcodProducto"></param>
    '''' <param name="pcodPermiso"></param>
    '''' <remarks></remarks>
    'Public Sub asignarProductoSocio(ByVal pcodSocio As Int32, ByVal pcodProducto As Int32, ByVal pcodPermiso As Int32)
    '    Try
    '        _clsProductoPersist.asignarProducto(pcodSocio, pcodProducto, pcodPermiso) 'llama el método registrar de la clase producto persistente pasandole los datos del producto.
    '    Catch ex As Exception
    '        Throw New System.Exception(ex.Message)
    '    End Try
    'End Sub

    ''' <summary>
    ''' Método de la clase, encargada de modificar los datos de un producto.
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <param name="punidad"></param>
    ''' <remarks></remarks>
    Public Sub modificarProducto(ByVal pcod As Int32, ByVal pnombre As String, ByVal punidad As Int32)
        Try
            _clsProductoPersist.modificar(pcod, pnombre, punidad) 'llama el método modificar de la clase producto persistente pasandole los datos del producto.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase, encargada de eliminar los datos de un producto.
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <remarks></remarks>
    Public Sub eliminarProducto(ByVal pcod As Int32)
        Try
            _clsProductoPersist.eliminar(pcod) 'llama el método eliminar de la clase producto persistente pasandole los datos del producto.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de un producto 
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <remarks></remarks>
    Public Function buscarProductoPorNombre(ByVal pnombre As String) As List(Of Array)

        Dim _arreglo As New List(Of Array)()

        _productos = _clsProductoPersist.buscarPorNombre(pnombre) 'llama el método buscar por nombre de la clase producto persistente pasandole el dato del producto.

        For Each _producto As ClsProducto In _productos
            Dim _datos As String() = {_producto.Codigo.ToString(), _producto.nombreProd.ToString(), _producto.nombreUnidad.ToString()} 'declarar e instanciar cada producto existente en la colección...
            _arreglo.Add(_datos) 'agregar cada socio de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los productos 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarProductos() As List(Of Array)
        Dim _arreglo As New List(Of Array)
        _productos = _clsProductoPersist.listar() 'llama el método listar de la clase producto persistente.

        For Each _producto As ClsProducto In _productos
            Dim _datos As String() = {_producto.Codigo.ToString(), _producto.nombreProd.ToString(), _producto.nombreUnidad.ToString()} 'declarar e instanciar cada producto existente en la colección...
            _arreglo.Add(_datos) 'agregar cada producto de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los productos 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarProductosSocio(ByVal ppermiso As Int32) As List(Of Array)
        Dim _arreglo As New List(Of Array)
        _productos = _clsProductoPersist.cargarProductoSocio(ppermiso) 'llama el método listar de la clase producto persistente.

        For Each _producto As ClsProducto In _productos
            Dim _datos As String() = {_producto.Codigo.ToString(), _producto.nombreProd.ToString()} 'declarar e instanciar cada producto existente en la colección...
            _arreglo.Add(_datos) 'agregar cada producto de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function

#End Region

#Region "Socio"
    ''' <summary>
    ''' Método de la clase, encargada de registrar los datos de un socio.
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
    Public Sub registrarSocio(ByVal pcod As String, ByVal pcedula As String, ByVal pnombre As String, _
                              ByVal pdireccionFinca As String, ByVal pdireccionCasa As String, ByVal ptelefono As String, _
                              ByVal pcorreo As String, ByVal pfechaIngreso As Date, ByVal pcodFerias As ArrayList)
        Try
            _clsSocioPersist.registrar(pcod, pcedula, pnombre, pdireccionFinca, pdireccionCasa, ptelefono, pcorreo, pfechaIngreso, pcodFerias) 'llama el método registrar de la clase socio persistente pasandole los datos del socio.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase, encargada de modificar los datos de un socio.
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
    Public Sub modificarSocio(ByVal pcod As String, ByVal pcedula As String, ByVal pnombre As String, _
                              ByVal pdireccionFinca As String, ByVal pdireccionCasa As String, ByVal ptelefono As String, _
                              ByVal pcorreo As String, ByVal pfechaIngreso As Date)
        Try
            _clsSocioPersist.modificar(pcod, pcedula, pnombre, pdireccionFinca, pdireccionCasa, ptelefono, pcorreo, pfechaIngreso) 'llama el método registrar de la clase socio persistente pasandole los datos del socio.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase, encargada de eliminar los datos de un socio.
    ''' </summary>
    ''' <param name="pcodigo"></param>
    ''' <remarks></remarks>
    Public Sub eliminarSocio(ByVal pcodigo As String)
        Try
            _clsSocioPersist.eliminar(pcodigo) 'llama el método eliminar de la clase socio persistente pasandole los datos del socio.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase, encargada de activar los datos de un socio.
    ''' </summary>
    ''' <param name="pcodigo"></param>
    ''' <remarks></remarks>
    Public Sub activarSocio(ByVal pcodigo As String)
        Try
            _clsSocioPersist.activar(pcodigo) 'llama el método activar de la clase socio persistente pasandole los datos del socio.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de un socio 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <remarks></remarks>
    Public Function buscarCriterioSocio(ByVal pcriterio As String) As List(Of Array)
        Dim _arreglo As New List(Of Array)()

        _socios = _clsSocioPersist.buscarPorCriterio(pcriterio) 'llama el método buscar por nombre de la clase socio persistente pasandole el dato del socio.

        For Each _socio As ClsSocio In _socios
            Dim _datos As String() = {_socio.codigo.ToString(), _socio.cedula.ToString(), _socio.nombreSocio.ToString(), _socio.direccionFincaSocio.ToString(), _socio.direccionCasaSocio.ToString(), _socio.telefono.ToString(), _socio.correoSocio.ToString(), _socio.fechaIngreso.ToString()} 'declarar e instanciar cada socio existente en la colección...
            _arreglo.Add(_datos) 'agregar cada socio de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de un socio que no este activo
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <remarks></remarks>
    Public Function buscarCriterioSocioInactivo(ByVal pcriterio As String) As List(Of Array)
        Dim _arreglo As New List(Of Array)()

        _socios = _clsSocioPersist.buscarPorCriterioInactivo(pcriterio) 'llama el método buscar por nombre de la clase socio persistente pasandole el dato del socio.

        For Each _socio As ClsSocio In _socios
            Dim _datos As String() = {_socio.codigo.ToString(), _socio.cedula.ToString(), _socio.nombreSocio.ToString(), _socio.direccionFincaSocio.ToString(), _socio.direccionCasaSocio.ToString(), _socio.telefono.ToString(), _socio.correoSocio.ToString(), _socio.fechaIngreso.ToString()} 'declarar e instanciar cada socio existente en la colección...
            _arreglo.Add(_datos) 'agregar cada socio de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de un socio por producto
    ''' </summary>
    ''' <param name="pproducto"></param>
    ''' <remarks></remarks>
    Public Function buscarSocioPorProducto(ByVal pproducto As String) As List(Of Array)
        Dim _arreglo As New List(Of Array)()

        _socios = _clsSocioPersist.buscarPorProducto(pproducto) 'llama el método buscar por nombre de la clase socio persistente pasandole el dato del socio.

        For Each _socio As ClsSocio In _socios
            Dim _datos As String() = {_socio.codigo.ToString(), _socio.cedula.ToString(), _socio.nombreSocio.ToString()} 'declarar e instanciar cada socio existente en la colección...
            _arreglo.Add(_datos) 'agregar cada socio de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los socios 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarSocios() As List(Of Array)
        Dim _arreglo As New List(Of Array)
        _socios = _clsSocioPersist.listar() 'llama el método listar de la clase socio persistente.

        For Each _socio As ClsSocio In _socios
            Dim _datos As String() = {_socio.codigo.ToString(), _socio.cedula.ToString(), _socio.nombreSocio.ToString(), _socio.direccionFincaSocio.ToString(), _socio.direccionCasaSocio.ToString(), _socio.telefono.ToString(), _socio.correoSocio.ToString(), _socio.fechaIngreso.ToString()} 'declarar e instanciar cada socio existente en la colección...
            _arreglo.Add(_datos) 'agregar cada producto de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los socios 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarSociosInactivo() As List(Of Array)
        Dim _arreglo As New List(Of Array)
        _socios = _clsSocioPersist.listarInactivo() 'llama el método listar de la clase socio persistente.

        For Each _socio As ClsSocio In _socios
            Dim _datos As String() = {_socio.codigo.ToString(), _socio.cedula.ToString(), _socio.nombreSocio.ToString(), _socio.direccionFincaSocio.ToString(), _socio.direccionCasaSocio.ToString(), _socio.telefono.ToString(), _socio.correoSocio.ToString(), _socio.fechaIngreso.ToString()} 'declarar e instanciar cada socio existente en la colección...
            _arreglo.Add(_datos) 'agregar cada producto de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function

    Public Function obtenerCantSocio() As Integer
        Dim cantSocio As Integer
        Try
            cantSocio = _clsSocioPersist.obtenerCantSocioActivo()
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
        Return cantSocio
    End Function
#End Region

#Region "Auxiliar"

    ''' <summary>
    ''' Método de la clase, encargada de registrar los datos de un auxiliar.
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <param name="pcedula"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="ptelefono"></param>
    ''' <param name="pparentesco"></param>
    ''' <remarks></remarks>
    Public Sub registrarAuxiliar(ByVal pcod As String, ByVal pcedula As String, ByVal pnombre As String, _
                                 ByVal ptelefono As String, ByVal pparentesco As String, ByVal pcodFerias As ArrayList)
        Try
            _clsAuxiliarPersist.registrar(pcod, pcedula, pnombre, ptelefono, pparentesco, pcodFerias) 'llama el método registrar de la clase auxiliar persistente pasandole los datos del auxiliar.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase, encargada de modificar los datos de un auxiliar.
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <param name="pcedula"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="ptelefono"></param>
    ''' <param name="pparentesco"></param>
    ''' <remarks></remarks>
    Public Sub modificarAuxiliar(ByVal pcod As String, ByVal pcedula As String, ByVal pnombre As String, _
                                 ByVal ptelefono As String, ByVal pparentesco As String)
        Try
            _clsAuxiliarPersist.modificar(pcod, pcedula, pnombre, ptelefono, pparentesco) 'llama el método registrar de la clase auxiliar persistente pasandole los datos del auxiliar.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase, encargada de eliminar los datos de un auxiliar.
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <remarks></remarks>
    Public Sub eliminarAuxiliar(ByVal pcod As String)
        Try
            _clsAuxiliarPersist.eliminar(pcod) 'llama el método eliminar de la clase auxiliar persistente pasandole los datos del socio.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase, encargada de activar los datos de un auxiliar.
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <remarks></remarks>
    Public Sub ActivarAuxiliar(ByVal pcod As String)
        Try
            _clsAuxiliarPersist.activar(pcod) 'llama el método activar de la clase auxiliar persistente pasandole los datos del socio.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de un auxiliar 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <remarks></remarks>
    Public Function buscarAuxiliarPorCriterio(ByVal pcriterio As String) As List(Of Array)

        Dim _arreglo As New List(Of Array)()

        _auxiliares = _clsAuxiliarPersist.buscarPorCriterio(pcriterio) 'llama el método buscar por nombre de la clase auxiliar persistente pasandole el dato del auxiliar.

        For Each _auxiliar As ClsAuxiliar In _auxiliares
            Dim _datos As String() = {_auxiliar.codigo.ToString(), _auxiliar.cedula.ToString(), _auxiliar.nombreAuxiliar.ToString(), _auxiliar.telefono.ToString(), _auxiliar.parentescoAux.ToString()} 'declarar e instanciar cada auxiliar existente en la colección...
            _arreglo.Add(_datos) 'agregar cada auxiliar de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de un auxiliar inactivo
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <remarks></remarks>
    Public Function buscarAuxiliarPorCriterioInactivo(ByVal pcriterio As String) As List(Of Array)

        Dim _arreglo As New List(Of Array)()

        _auxiliares = _clsAuxiliarPersist.buscarPorCriterioInactivo(pcriterio) 'llama el método buscar por nombre de la clase auxiliar persistente pasandole el dato del auxiliar.

        For Each _auxiliar As ClsAuxiliar In _auxiliares
            Dim _datos As String() = {_auxiliar.codigo.ToString(), _auxiliar.cedula.ToString(), _auxiliar.nombreAuxiliar.ToString(), _auxiliar.telefono.ToString(), _auxiliar.parentescoAux.ToString()} 'declarar e instanciar cada auxiliar existente en la colección...
            _arreglo.Add(_datos) 'agregar cada auxiliar de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de un auxiliar por producto 
    ''' </summary>
    ''' <param name="pproducto"></param>
    ''' <remarks></remarks>
    Public Function buscarAuxiliarPorProducto(ByVal pproducto As String) As List(Of Array)

        Dim _arreglo As New List(Of Array)()

        _auxiliares = _clsAuxiliarPersist.buscarPorProducto(pproducto) 'llama el método buscar por nombre de la clase auxiliar persistente pasandole el dato del auxiliar.

        For Each _auxiliar As ClsAuxiliar In _auxiliares
            Dim _datos As String() = {_auxiliar.codigo.ToString(), _auxiliar.cedula.ToString(), _auxiliar.nombreAuxiliar.ToString()} 'declarar e instanciar cada auxiliar existente en la colección...
            _arreglo.Add(_datos) 'agregar cada auxiliar de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los auxiliares 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarAuxiliares() As List(Of Array)
        Dim _arreglo As New List(Of Array)
        _auxiliares = _clsAuxiliarPersist.listar() 'llama el método listar de la clase auxiliar persistente.

        For Each _auxiliar As ClsAuxiliar In _auxiliares
            Dim _datos As String() = {_auxiliar.codigo.ToString(), _auxiliar.cedula.ToString(), _auxiliar.nombreAuxiliar.ToString(), _auxiliar.telefono.ToString(), _auxiliar.parentescoAux.ToString()} 'declarar e instanciar cada auxiliar existente en la colección...
            _arreglo.Add(_datos) 'agregar cada auxiliar de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los auxiliares inactivos
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarAuxiliaresInactivo() As List(Of Array)
        Dim _arreglo As New List(Of Array)
        _auxiliares = _clsAuxiliarPersist.listarInactivo() 'llama el método listar de la clase auxiliar persistente.

        For Each _auxiliar As ClsAuxiliar In _auxiliares
            Dim _datos As String() = {_auxiliar.codigo.ToString(), _auxiliar.cedula.ToString(), _auxiliar.nombreAuxiliar.ToString(), _auxiliar.telefono.ToString(), _auxiliar.parentescoAux.ToString()} 'declarar e instanciar cada auxiliar existente en la colección...
            _arreglo.Add(_datos) 'agregar cada auxiliar de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function
#End Region

#Region "Feria"
    ''' <summary>
    ''' Método de la clase, encargada de registrar los datos de una feria.
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <param name="pnombre"></param>
    ''' <remarks></remarks>
    Public Sub registrarFeria(ByVal pcod As Int32, ByVal pnombre As String)
        Try
            _clsFeriaPersist.registrar(pcod, pnombre) 'llama el método registrar de la clase feria persistente pasandole los datos de la feria.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de una feria 
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <remarks></remarks>
    Public Function buscarFeriaPorNombre(ByVal pnombre As String) As List(Of Array)

        Dim _arreglo As New List(Of Array)()

        _ferias = _clsFeriaPersist.buscarPorNombre(pnombre) 'llama el método buscar por nombre de la clase feria persistente pasandole el dato de la feria.

        For Each _feria As ClsFeria In _ferias
            Dim _datos As String() = {_feria.codigo.ToString(), _feria.nombreFeria.ToString()} 'declarar e instanciar cada feria existente en la colección...
            _arreglo.Add(_datos) 'agregar cada feria de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de una feria 
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <remarks></remarks>
    Public Function buscarFeriaPorAprox(ByVal pcod As String, ByVal pnombre As String) As List(Of Array)

        Dim _arreglo As New List(Of Array)()

        _ferias = _clsFeriaPersist.buscarPorAprox(pcod, pnombre) 'llama el método buscar por nombre de la clase feria persistente pasandole el dato de la feria.

        For Each _feria As ClsFeria In _ferias
            Dim _datos As String() = {_feria.codigo.ToString(), _feria.nombreFeria.ToString()} 'declarar e instanciar cada feria existente en la colección...
            _arreglo.Add(_datos) 'agregar cada feria de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos las ferias 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarFerias() As List(Of Array)
        Dim _arreglo As New List(Of Array)
        _ferias = _clsFeriaPersist.listar() 'llama el método listar de la clase feria persistente.

        For Each _feria As ClsFeria In _ferias
            Dim _datos As String() = {_feria.codigo.ToString(), _feria.nombreFeria.ToString()} 'declarar e instanciar cada feria existente en la colección...
            _arreglo.Add(_datos) 'agregar cada feria de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar las ferias que asiste el socio 
    ''' </summary>
    ''' <param name="pcodigo"></param>
    ''' <remarks></remarks>
    Public Function buscarFeriaPorSocio(ByVal pcodigo As String) As List(Of Array)

        Dim _arreglo As New List(Of Array)()

        _ferias = _clsFeriaPersist.buscarFeriaPorSocio(pcodigo) 'llama el método buscar por cedula del socio de la clase feria persistente pasandole el dato del socio.

        For Each _feria As ClsFeria In _ferias

            Dim _datos As String() = {_feria.codigo.ToString(), _feria.nombreFeria.ToString()} 'declarar e instanciar cada feria existente en la colección...

            _arreglo.Add(_datos) 'agregar cada feria de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar las ferias que no asiste el socio 
    ''' </summary>
    ''' <param name="pcodigo"></param>
    ''' <remarks></remarks>
    Public Function buscarFeriaSinSocio(ByVal pcodigo As String) As List(Of Array)

        Dim _arreglo As New List(Of Array)()

        _ferias = _clsFeriaPersist.buscarFeriaSinSocio(pcodigo) 'llama el método buscar por cedula del socio de la clase feria persistente pasandole el dato del socio.

        For Each _feria As ClsFeria In _ferias

            Dim _datos As String() = {_feria.codigo.ToString(), _feria.nombreFeria.ToString()} 'declarar e instanciar cada feria existente en la colección...

            _arreglo.Add(_datos) 'agregar cada feria de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function

    ''' <summary>
    ''' Método de la clase, encargada de eliminar una feria que asiste el socio.
    ''' </summary>
    ''' <param name="pcodFeria"></param>
    ''' <param name="pcodSocio"></param>
    ''' <remarks></remarks>
    Public Sub eliminarFeriaSocio(ByVal pcodFeria As Int32, ByVal pcodSocio As String)
        Try
            _clsFeriaPersist.eliminarFeriaSocio(pcodFeria, pcodSocio) 'llama el método eliminar de la clase feria persistente pasandole los datos del socio.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' Método de la clase, encargada de eliminar una feria que asiste el socio.
    ''' </summary>
    ''' <param name="pcodFeria"></param>
    ''' <param name="pcodAux"></param>
    ''' <remarks></remarks>
    Public Sub eliminarFeriaAuxiliar(ByVal pcodFeria As Int32, ByVal pcodAux As String)
        Try
            _clsFeriaPersist.eliminarFeriaAux(pcodFeria, pcodAux) 'llama el método eliminar de la clase feria persistente pasandole los datos del socio.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' Método de la clase, encargada de agregar una feria que asiste el socio.
    ''' </summary>
    ''' <param name="pcodFeria"></param>
    ''' <param name="pcodSocio"></param>
    ''' <remarks></remarks>
    Public Sub modificarFeriaSocio(ByVal pcodFeria As Int32, ByVal pcodSocio As String)
        Try
            _clsFeriaPersist.agregarFeriaSocio(pcodFeria, pcodSocio) 'llama el método eliminar de la clase feria persistente pasandole los datos del socio.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' Método de la clase, encargada de agregar una feria que asiste el auxiliar.
    ''' </summary>
    ''' <param name="pcodFeria"></param>
    ''' <param name="pcodAux"></param>
    ''' <remarks></remarks>
    Public Sub modificarFeriaAux(ByVal pcodFeria As Int32, ByVal pcodAux As String)
        Try
            _clsFeriaPersist.agregarFeriaAux(pcodFeria, pcodAux) 'llama el método eliminar de la clase feria persistente pasandole los datos del socio.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' Funcion que se encarga de buscar el maximo id en la tabla de ferias en la base de datos.
    ''' </summary>
    ''' <returns>Maximo id</returns>
    Public Function obtenerMayorIdFeria() As Integer
        Dim idMax As Integer
        Try
            idMax = _clsFeriaPersist.obtenerMayorIdFeria()
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
        Return idMax
    End Function

#End Region

#Region "Finca"
    ''' <summary>
    ''' Método de la clase, encargada de registrar los datos de una finca.
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <param name="pdireccion"></param>
    ''' <param name="parea"></param>
    ''' <remarks></remarks>
    Public Sub registrarFinca(ByVal pnombre As String, _
                              ByVal pdireccion As String, ByVal parea As Int32)
        Try
            _clsFincaPersist.registrar(pnombre, pdireccion, parea) 'llama el método registrar de la clase finca persistente pasandole los datos de la finca.
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
            _clsFincaPersist.asignarFincaSocio(pcodFinca, pcodSocio, ptipoContrato, pfechaContrato, pfechaVenceContrato) 'llama el método asignarle la finca a un socio.
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
    Public Sub modificarFinca(ByVal pcod As Int32, ByVal pnombre As String, _
                              ByVal pdireccion As String, ByVal parea As Int32)

        Try
            _clsFincaPersist.modificar(pcod, pnombre, pdireccion, parea) 'llama el método registrar de la clase finca persistente pasandole los datos de la finca.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los datos de la finca 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarFincaPorCriterio(ByVal pcriterio As String) As List(Of Array)
        Dim _arreglo As New List(Of Array)
        _fincas = _clsFincaPersist.buscarPorCriterio(pcriterio) 'llama el método listar de la clase finca persistente.

        For Each _finca As ClsFinca In _fincas
            Dim _datos As String() = {_finca.codigo.ToString(), _finca.nombreFinca.ToString(), _finca.direccionFinca.ToString(), _finca.areaFinca.ToString()} 'declarar e instanciar cada finca existente en la colección...
            _arreglo.Add(_datos) 'agregar cada finca de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos las finca 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarFinca() As List(Of Array)
        Dim _arreglo As New List(Of Array)
        _fincas = _clsFincaPersist.listar() 'llama el método listar de la clase auxiliar persistente.

        For Each _finca As ClsFinca In _fincas
            Dim _datos As String() = {_finca.codigo.ToString(), _finca.nombreFinca.ToString(), _finca.direccionFinca.ToString(), _finca.areaFinca.ToString()} 'declarar e instanciar cada finca existente en la colección...
            _arreglo.Add(_datos) 'agregar cada finca de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function

    ''' <summary>
    ''' Funcion que se encarga de obtener el total del área de las fincas en la base de datos.
    ''' </summary>
    ''' <returns>Total área</returns>
    Public Function obtenerTotalAreaFinca() As Integer
        Dim totalArea As Integer
        Try
            totalArea = _clsFincaPersist.obtenerTotalArea()
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
        Return totalArea
    End Function
#End Region

#Region "Permiso"
    ''' <summary>
    ''' Método de la clase, encargada de registrar los datos de un permiso.
    ''' </summary>
    ''' <param name="pcodPermiso"></param>
    ''' <param name="pcodSocio"></param>
    ''' <param name="pfechaCrea"></param>
    ''' <param name="pfechaVence"></param>
    ''' <remarks></remarks>
    Public Sub registrarPermiso(ByVal pcodPermiso As Int32, ByVal pcodSocio As String, ByVal pfechaCrea As Date, _
                                ByVal pfechaVence As Date, ByVal pcodProductos As ArrayList)
        Try
            _clsPermisoPersist.registrar(pcodPermiso, pcodSocio, pfechaCrea, pfechaVence, pcodProductos)
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
    Public Sub registrarPermisoAux(ByVal pcodPermiso As Int32, ByVal pcodSocio As String, _
                                   ByVal pcodAux As String, ByVal pnombreAux As String, ByVal pfechaCrea As Date, _
                                ByVal pfechaVence As Date, ByVal pcodProductos As ArrayList)
        Try
            _clsPermisoPersist.registrarPerAux(pcodPermiso, pcodSocio, pcodAux, pnombreAux, pfechaCrea, pfechaVence, pcodProductos)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase, encargada de asignar un permiso al auxiliar.
    ''' </summary>
    ''' <param name="pcodPermiso"></param>
    ''' <param name="pcodAuxiliar"></param>
    ''' <remarks></remarks>
    Public Sub asignarPermisoAux(ByVal pcodPermiso As Int32, ByVal pcodAuxiliar As String, ByVal pnombreAux As String)
        Try
            _clsPermisoPersist.asignarPermisoAux(pcodPermiso, pcodAuxiliar, pnombreAux)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Funcion que se encarga de buscar el maximo id en la tabla de permiso en la base de datos.
    ''' </summary>
    ''' <returns>Maximo id</returns>
    Public Function obtenerMayorIdPermiso() As Integer
        Dim idMax As Integer
        Try
            idMax = _clsPermisoPersist.obtenerMayorIdPermiso()
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
        Return idMax
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de un permiso
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <remarks></remarks>
    Public Function buscarPermisoPorCriterio(ByVal pcriterio As Int32) As List(Of Array)

        Dim _arreglo As New List(Of Array)()

        _permisos = _clsPermisoPersist.buscarPorCriterio(pcriterio) 'llama el método buscar por nombre de la clase permiso persistente pasandole el dato del permiso.

        For Each _permiso As ClsPermiso In _permisos
            Dim _datos As String() = {_permiso.codigoPermiso.ToString(), _permiso.codigoSocio.ToString(), _permiso.fechaCreaPerm.ToString(), _permiso.fechaVencePerm.ToString()} 'declarar e instanciar cada auxiliar existente en la colección...
            _arreglo.Add(_datos) 'agregar cada permiso de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los permisos 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarPermisos() As List(Of Array)
        Dim _arreglo As New List(Of Array)()

        _permisos = _clsPermisoPersist.listar() 'llama el método buscar por nombre de la clase permiso persistente pasandole el dato del permiso.

        For Each _permiso As ClsPermiso In _permisos
            Dim _datos As String() = {_permiso.codigoPermiso.ToString(), _permiso.codigoSocio.ToString(), _permiso.fechaCreaPerm.ToString(), _permiso.fechaVencePerm.ToString()} 'declarar e instanciar cada auxiliar existente en la colección...
            _arreglo.Add(_datos) 'agregar cada permiso de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function


    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de un permiso
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <remarks></remarks>
    Public Function buscarPermisoPorCriterioSocio(ByVal pcriterio As String) As List(Of Array)

        Dim _arreglo As New List(Of Array)()

        _permisos = _clsPermisoPersist.buscarPorCriterioPendienteSocio(pcriterio) 'llama el método buscar por nombre de la clase permiso persistente pasandole el dato del permiso.

        For Each _permiso As ClsPermiso In _permisos
            Dim _datos As String() = {_permiso.codigoPermiso.ToString(), _permiso.codigoSocio.ToString(), _permiso.codigoAuxiliar.ToString(), _permiso.fechaCreaPerm.ToString(), _permiso.fechaVencePerm.ToString()} 'declarar e instanciar cada auxiliar existente en la colección...
            _arreglo.Add(_datos) 'agregar cada permiso de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los permisos 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarPermisosSocio() As List(Of Array)
        Dim _arreglo As New List(Of Array)()

        _permisos = _clsPermisoPersist.listarPendienteSocio() 'llama el método buscar por nombre de la clase permiso persistente pasandole el dato del permiso.

        For Each _permiso As ClsPermiso In _permisos
            Dim _datos As String() = {_permiso.codigoPermiso.ToString(), _permiso.codigoSocio.ToString(), _permiso.codigoAuxiliar.ToString(), _permiso.fechaCreaPerm.ToString(), _permiso.fechaVencePerm.ToString()} 'declarar e instanciar cada auxiliar existente en la colección...
            _arreglo.Add(_datos) 'agregar cada permiso de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de un permiso
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <remarks></remarks>
    Public Function buscarPermisoPorCriterioAux(ByVal pcriterio As String) As List(Of Array)

        Dim _arreglo As New List(Of Array)()

        _permisos = _clsPermisoPersist.buscarPorCriterioPendienteAux(pcriterio) 'llama el método buscar por nombre de la clase permiso persistente pasandole el dato del permiso.

        For Each _permiso As ClsPermiso In _permisos
            Dim _datos As String() = {_permiso.codigoPermiso.ToString(), _permiso.codigoSocio.ToString(), _permiso.codigoAuxiliar.ToString(), _permiso.fechaCreaPerm.ToString(), _permiso.fechaVencePerm.ToString()} 'declarar e instanciar cada auxiliar existente en la colección...
            _arreglo.Add(_datos) 'agregar cada permiso de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los permisos 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarPermisosAux() As List(Of Array)
        Dim _arreglo As New List(Of Array)()

        _permisos = _clsPermisoPersist.listarPendienteAux() 'llama el método buscar por nombre de la clase permiso persistente pasandole el dato del permiso.

        For Each _permiso As ClsPermiso In _permisos
            Dim _datos As String() = {_permiso.codigoPermiso.ToString(), _permiso.codigoSocio.ToString(), _permiso.codigoAuxiliar.ToString(), _permiso.fechaCreaPerm.ToString(), _permiso.fechaVencePerm.ToString()} 'declarar e instanciar cada auxiliar existente en la colección...
            _arreglo.Add(_datos) 'agregar cada permiso de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar los permisos vencidos 
    ''' </summary>
    ''' <remarks></remarks>
    Public Function buscarPermisoVencidos() As List(Of Array)
        Dim _arreglo As New List(Of Array)()

        _socios = _clsPermisoPersist.buscarPermisoVencido() 'llama el método buscar por nombre de la clase permiso persistente pasandole el dato del socio.

        For Each _socio As ClsSocio In _socios
            Dim _datos As String() = {_socio.codigo.ToString(), _socio.cedula.ToString(), _socio.nombreSocio.ToString(), _socio.direccionFincaSocio.ToString(), _socio.direccionCasaSocio.ToString(), _socio.telefono.ToString(), _socio.correoSocio.ToString(), _socio.fechaIngreso.ToString()} 'declarar e instanciar cada socio existente en la colección...
            _arreglo.Add(_datos) 'agregar cada socio de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function
#End Region

#Region "Inspeccion"
    ''' <summary>
    ''' Método de la clase, encargada de registrar los datos de una inspeccion.
    ''' </summary>
    ''' <param name="pcodInsp"></param>
    ''' <param name="pcodSocio"></param>
    ''' <param name="pfechaCrea"></param>
    ''' <param name="pfechaVence"></param>
    ''' <remarks></remarks>
    Public Sub registrarInspeccion(ByVal pcodInsp As Int32, ByVal pfechaCrea As Date, _
                                ByVal pfechaVence As Date, ByVal pcodSocio As String)
        Try
            _clsInspeccionPersist.registrar(pcodInsp, pfechaCrea, pfechaVence, pcodSocio)
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
            idMax = _clsInspeccionPersist.obtenerMayorIdInspeccion()
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
        Return idMax
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar los carnet vencidos 
    ''' </summary>
    ''' <remarks></remarks>
    Public Function buscarCarnetVencidos() As List(Of Array)
        Dim _arreglo As New List(Of Array)()

        _socios = _clsInspeccionPersist.buscarCarnetVencido() 'llama el método buscar por nombre de la clase inspeccion persistente pasandole el dato del socio.

        For Each _socio As ClsSocio In _socios
            Dim _datos As String() = {_socio.codigo.ToString(), _socio.cedula.ToString(), _socio.nombreSocio.ToString(), _socio.direccionFincaSocio.ToString(), _socio.direccionCasaSocio.ToString(), _socio.telefono.ToString(), _socio.correoSocio.ToString(), _socio.fechaIngreso.ToString()} 'declarar e instanciar cada socio existente en la colección...
            _arreglo.Add(_datos) 'agregar cada socio de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar los carnet vencidos 
    ''' </summary>
    ''' <remarks></remarks>
    Public Function buscarCarnetPendiente(ByVal pcriterio As String) As List(Of Array)
        Dim _arreglo As New List(Of Array)()

        _inspecciones = _clsInspeccionPersist.buscarCarnetPendiente(pcriterio) 'llama el método buscar por nombre de la clase inspeccion persistente pasandole el dato del socio.

        For Each _inspeccion As ClsInspeccion In _inspecciones
            Dim _datos As String() = {_inspeccion.solicitudIns.ToString(), _inspeccion.codigoSocio.ToString(), _inspeccion.nombreSocio.ToString(), _inspeccion.fechaCreaIns.ToString(), _inspeccion.fechaVenceIns.ToString()} 'declarar e instanciar cada socio existente en la colección...
            _arreglo.Add(_datos) 'agregar cada socio de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar los carnet vencidos 
    ''' </summary>
    ''' <remarks></remarks>
    Public Function listarCarnetPendiente() As List(Of Array)
        Dim _arreglo As New List(Of Array)()

        _inspecciones = _clsInspeccionPersist.listarCarnetPendiente() 'llama el método buscar por nombre de la clase inspeccion persistente pasandole el dato del socio.

        For Each _inspeccion As ClsInspeccion In _inspecciones
            Dim _datos As String() = {_inspeccion.solicitudIns.ToString(), _inspeccion.codigoSocio.ToString(), _inspeccion.nombreSocio.ToString(), _inspeccion.fechaCreaIns.ToString(), _inspeccion.fechaVenceIns.ToString()} 'declarar e instanciar cada socio existente en la colección...
            _arreglo.Add(_datos) 'agregar cada socio de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function
#End Region

#Region "Cliente"
    ''' <summary>
    ''' Método de la clase, encargada de registrar los datos de un cliente.
    ''' </summary>
    ''' <param name="pcedula"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="pdireccion"></param>
    ''' <param name="ptelefono"></param>
    ''' <param name="pfechaIngreso"></param>
    ''' <remarks></remarks>
    Public Sub registrarCliente(ByVal pcedula As String, ByVal pnombre As String, ByVal pdireccion As String, _
                              ByVal ptelefono As String, ByVal pfechaIngreso As Date)
        Try
            _clsClientePersist.registrar(pcedula, pnombre, pdireccion, ptelefono, pfechaIngreso) 'llama el método registrar de la clase cliente persistente pasandole los datos del cliente.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que modificar un cliente a la Base de datos
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
        Try
            _clsClientePersist.modificar(pcedula, pnombre, pdireccion, ptelefono, pfechaIngreso, psalarioBase, pcuota) 'llama el método registrar de la clase cliente persistente pasandole los datos del cliente.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que elimina un cliente a la Base de datos
    ''' </summary>
    ''' <param name="pcedula"></param>
    ''' <remarks></remarks>
    Public Sub eliminarCliente(ByVal pcedula As String)
        Try
            _clsClientePersist.eliminar(pcedula) 'llama el método eliminar de la clase cliente persistente pasandole los datos del cliente.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase, encargada de activar los datos de un cliente.
    ''' </summary>
    ''' <param name="pcedula"></param>
    ''' <param name="pcantIngreso"></param>
    ''' <remarks></remarks>
    Public Sub activarCliente(ByVal pcedula As String, ByVal pcantIngreso As Int32)
        Try
            _clsClientePersist.activar(pcedula, pcantIngreso) 'llama el método activar de la clase cliente persistente pasandole los datos del cliente.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de un cliente 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <remarks></remarks>
    Public Function buscarCriterioCliente(ByVal pcriterio As String) As List(Of Array)
        Dim _arreglo As New List(Of Array)()

        _clientes = _clsClientePersist.buscarPorCriterio(pcriterio) 'llama el método buscar por nombre de la clase cliente persistente pasandole el dato del cliente.

        For Each _cliente As ClsCliente In _clientes
            Dim _datos As String() = {_cliente.cedula.ToString(), _cliente.nombreCliente.ToString(), _cliente.direccionCliente.ToString(), _cliente.telefono.ToString(), _cliente.fechaIngresoCliente.ToString(), _cliente.salarioBase.ToString(), _cliente.cuotaOrden.ToString(), _cliente.cantidadIngreso.ToString} 'declarar e instanciar cada socio existente en la colección...
            _arreglo.Add(_datos) 'agregar cada cliente de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de un cliente que no este activo
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <remarks></remarks>
    Public Function buscarCriterioClienteInactivo(ByVal pcriterio As String) As List(Of Array)
        Dim _arreglo As New List(Of Array)()

        _clientes = _clsClientePersist.buscarPorCriterioInactivo(pcriterio) 'llama el método buscar por nombre de la clase cliente persistente pasandole el dato del cliente.

        For Each _cliente As ClsCliente In _clientes
            Dim _datos As String() = {_cliente.cedula.ToString(), _cliente.nombreCliente.ToString(), _cliente.direccionCliente.ToString(), _cliente.telefono.ToString(), _cliente.fechaIngresoCliente.ToString(), _cliente.salarioBase.ToString(), _cliente.cuotaOrden.ToString(), _cliente.cantidadIngreso.ToString} 'declarar e instanciar cada socio existente en la colección...
            _arreglo.Add(_datos) 'agregar cada cliente de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los clientes 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarClientes() As List(Of Array)
        Dim _arreglo As New List(Of Array)()

        _clientes = _clsClientePersist.listar() 'llama el método buscar por nombre de la clase cliente persistente pasandole el dato del cliente.

        For Each _cliente As ClsCliente In _clientes
            Dim _datos As String() = {_cliente.cedula.ToString(), _cliente.nombreCliente.ToString(), _cliente.direccionCliente.ToString(), _cliente.telefono.ToString(), _cliente.fechaIngresoCliente.ToString(), _cliente.salarioBase.ToString(), _cliente.cuotaOrden.ToString(), _cliente.cantidadIngreso.ToString} 'declarar e instanciar cada socio existente en la colección...
            _arreglo.Add(_datos) 'agregar cada cliente de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los socios 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarClientesInactivo() As List(Of Array)
        Dim _arreglo As New List(Of Array)()

        _clientes = _clsClientePersist.listarInactivo() 'llama el método buscar por nombre de la clase cliente persistente pasandole el dato del cliente.

        For Each _cliente As ClsCliente In _clientes
            Dim _datos As String() = {_cliente.cedula.ToString(), _cliente.nombreCliente.ToString(), _cliente.direccionCliente.ToString(), _cliente.telefono.ToString(), _cliente.fechaIngresoCliente.ToString(), _cliente.salarioBase.ToString(), _cliente.cuotaOrden.ToString(), _cliente.cantidadIngreso.ToString} 'declarar e instanciar cada socio existente en la colección...
            _arreglo.Add(_datos) 'agregar cada cliente de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo

    End Function
#End Region

#Region "Orden"
    ''' <summary>
    ''' Método de la clase, encargada de registrar los datos de una orden.
    ''' </summary>
    ''' <param name="pcedulaCliente"></param>
    ''' <param name="pmes"></param>
    ''' <param name="panno"></param>
    ''' <param name="pfechaCrea"></param>
    ''' <param name="pfechaVence"></param>
    ''' <param name="pmonto"></param>
    ''' <param name="pestado"></param>
    ''' <remarks></remarks>
    Public Sub registrarOrden(ByVal pcedulaCliente As String, ByVal pmes As String, ByVal pmesNum As Int32, _
                            ByVal panno As Int32, ByVal pfechaCrea As Date, ByVal pfechaVence As Date, _
                            ByVal pmonto As Int32, ByVal psalario As Int32, ByVal pestado As String)

        Try
            _clsOrdenPersist.registrar(pcedulaCliente, pmes, pmesNum, panno, pfechaCrea, pfechaVence, pmonto, psalario, pestado)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de una orden pendiente 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <remarks></remarks>
    Public Function buscarOrdenesVencidas(ByVal pcriterio As String) As List(Of Array)
        Dim _arreglo As New List(Of Array)()

        _ordenes = _clsOrdenPersist.buscarOrdenesPendiente(pcriterio) 'llama el método buscar por nombre de la clase orden persistente pasandole el dato de la orden.

        For Each _orden As ClsOrden In _ordenes
            Dim _datos As String() = {_orden.codigo.ToString(), _orden.cedulaCliente.ToString(), _orden.mesOrden.ToString(), _orden.annoOrden.ToString(), _orden.fechaCreaorden.ToString(), _orden.fechaVenceOrden.ToString(), _orden.fechaPagoOrden.ToString(), _orden.montoOrden.ToString(), _orden.salarioBase.ToString(), _orden.multaOrden.ToString(), _orden.montoPagarOrden.ToString(), _orden.estadoOrden.ToString} 'declarar e instanciar cada socio existente en la colección...
            _arreglo.Add(_datos) 'agregar cada orden de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de una orden cancelada 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <remarks></remarks>
    Public Function buscarOrdenesCanceladas(ByVal pcriterio As String) As List(Of Array)
        Dim _arreglo As New List(Of Array)()

        _ordenes = _clsOrdenPersist.buscarOrdenesCancelada(pcriterio) 'llama el método buscar por nombre de la clase orden persistente pasandole el dato de la orden.

        For Each _orden As ClsOrden In _ordenes
            Dim _datos As String() = {_orden.codigo.ToString(), _orden.cedulaCliente.ToString(), _orden.mesOrden.ToString(), _orden.annoOrden.ToString(), _orden.fechaCreaorden.ToString(), _orden.fechaVenceOrden.ToString(), _orden.fechaPagoOrden.ToString(), _orden.montoOrden.ToString(), _orden.salarioBase.ToString(), _orden.multaOrden.ToString(), _orden.montoPagarOrden.ToString(), _orden.estadoOrden.ToString} 'declarar e instanciar cada socio existente en la colección...
            _arreglo.Add(_datos) 'agregar cada orden de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de una orden cancelada 
    ''' </summary>
    ''' <remarks></remarks>
    Public Function listarOrdenesCanceladas() As List(Of Array)
        Dim _arreglo As New List(Of Array)()

        _ordenes = _clsOrdenPersist.listarOrdenesCancelada() 'llama el método buscar por nombre de la clase orden persistente pasandole el dato de la orden.

        For Each _orden As ClsOrden In _ordenes
            Dim _datos As String() = {_orden.cedulaCliente.ToString(), _orden.nombreCliente.ToString(), _orden.mesOrden.ToString(), _orden.annoOrden.ToString(), _orden.fechaCreaorden.ToString(), _orden.fechaVenceOrden.ToString(), _orden.fechaPagoOrden.ToString(), _orden.montoPagarOrden.ToString()} 'declarar e instanciar cada socio existente en la colección...
            _arreglo.Add(_datos) 'agregar cada orden de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de una orden cancelada 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <remarks></remarks>
    Public Function listarOrdenesCanceladasCriterio(ByVal pcriterio As String) As List(Of Array)
        Dim _arreglo As New List(Of Array)()

        _ordenes = _clsOrdenPersist.listarOrdenesCanceladaCriterio(pcriterio) 'llama el método buscar por nombre de la clase orden persistente pasandole el dato de la orden.

        For Each _orden As ClsOrden In _ordenes
            Dim _datos As String() = {_orden.cedulaCliente.ToString(), _orden.nombreCliente.ToString(), _orden.mesOrden.ToString(), _orden.annoOrden.ToString(), _orden.fechaCreaorden.ToString(), _orden.fechaVenceOrden.ToString(), _orden.fechaPagoOrden.ToString(), _orden.montoPagarOrden.ToString()} 'declarar e instanciar cada socio existente en la colección...
            _arreglo.Add(_datos) 'agregar cada orden de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function

    ''' <summary>
    ''' Metodo que modifica la multa a la Base de datos
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <remarks></remarks>
    Public Sub modificarMulta(ByVal pcod As Int32)
        Try
            _clsOrdenPersist.modificarMulta(pcod)
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
            montoTotal = _clsOrdenPersist.obtenerMontoTotal(pcod)
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
            _clsOrdenPersist.cancelarOrden(pcod, pfechaPago, pmontoPagar, pestado)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de una orden cancelada 
    ''' </summary>
    ''' <remarks></remarks>
    Public Function listarOrdenesPendientes() As List(Of Array)
        Dim _arreglo As New List(Of Array)()

        _ordenes = _clsOrdenPersist.listarOrdenesPendiente() 'llama el método buscar por nombre de la clase orden persistente pasandole el dato de la orden.

        For Each _orden As ClsOrden In _ordenes
            Dim _datos As String() = {_orden.cedulaCliente.ToString(), _orden.nombreCliente.ToString(), _orden.mesOrden.ToString(), _orden.annoOrden.ToString(), _orden.fechaCreaorden.ToString(), _orden.fechaVenceOrden.ToString(), _orden.fechaPagoOrden.ToString(), _orden.montoPagarOrden.ToString()} 'declarar e instanciar cada socio existente en la colección...
            _arreglo.Add(_datos) 'agregar cada orden de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de una orden cancelada 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <remarks></remarks>
    Public Function listarOrdenesPendienteCriterio(ByVal pcriterio As String) As List(Of Array)
        Dim _arreglo As New List(Of Array)()

        _ordenes = _clsOrdenPersist.listarOrdenesPendienteCriterio(pcriterio) 'llama el método buscar por nombre de la clase orden persistente pasandole el dato de la orden.

        For Each _orden As ClsOrden In _ordenes
            Dim _datos As String() = {_orden.cedulaCliente.ToString(), _orden.nombreCliente.ToString(), _orden.mesOrden.ToString(), _orden.annoOrden.ToString(), _orden.fechaCreaorden.ToString(), _orden.fechaVenceOrden.ToString(), _orden.fechaPagoOrden.ToString(), _orden.montoPagarOrden.ToString()} 'declarar e instanciar cada socio existente en la colección...
            _arreglo.Add(_datos) 'agregar cada orden de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function

    ''' <summary>
    ''' Metodo que modifica la multa a la Base de datos
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub modificarMultaOrdenPendiente()
        Try
            _clsOrdenPersist.modificarMultaOrdenPendientes()
        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try
    End Sub
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
    Public Sub registrarUsuario(ByVal pcedula As String, ByVal pnombre As String, ByVal papellido1 As String, _
                              ByVal papellido2 As String, ByVal pcontrasenna As String, ByVal prol As String)

        pcontrasenna = encriptarPassword(pcontrasenna) 'Se llama a una función para encontrar la contraseña
        Try
            _clsUsuarioPersist.registrar(pcedula, pnombre, papellido1, papellido2, pcontrasenna, prol)
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
    Public Sub modificarUsuario(ByVal pcedula As String, ByVal pnombre As String, ByVal papellido1 As String, _
                              ByVal papellido2 As String, ByVal prol As String)

        Try
            _clsUsuarioPersist.modificar(pcedula, pnombre, papellido1, papellido2, prol)
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
            _clsUsuarioPersist.eliminar(pcedula)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de un usuario 
    ''' </summary>
    ''' <param name="pcriterio"></param>
    ''' <remarks></remarks>
    Public Function buscarCriterioUsuario(ByVal pcriterio As String) As List(Of Array)
        Dim _arreglo As New List(Of Array)()

        _usuarios = _clsUsuarioPersist.buscarPorCriterio(pcriterio) 'llama el método buscar por nombre de la clase usuario persistente pasandole el dato del usuario.

        For Each _usuario As ClsUsuario In _usuarios
            Dim _datos As String() = {_usuario.cedula.ToString(), _usuario.nombreUsuario.ToString(), _usuario.apellido1Usuario.ToString(), _usuario.apellido2Usuario.ToString(), _usuario.rolUsuario.ToString()} 'declarar e instanciar cada usuario existente en la colección...
            _arreglo.Add(_datos) 'agregar cada usuario de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar los datos de un usuario 
    ''' </summary>
    ''' <remarks></remarks>
    Public Function listarUsuario() As List(Of Array)
        Dim _arreglo As New List(Of Array)()

        _usuarios = _clsUsuarioPersist.listar() 'llama el método buscar por nombre de la clase usuario persistente pasandole el dato del usuario.

        For Each _usuario As ClsUsuario In _usuarios
            Dim _datos As String() = {_usuario.cedula.ToString(), _usuario.nombreUsuario.ToString(), _usuario.apellido1Usuario.ToString(), _usuario.apellido2Usuario.ToString(), _usuario.rolUsuario.ToString()} 'declarar e instanciar cada usuario existente en la colección...
            _arreglo.Add(_datos) 'agregar cada usuario de la colección al arreglo (una lista genérica de Array)
        Next

        Return _arreglo
    End Function
#End Region

#Region "Iniciar Sesion"
    ''' <summary>
    ''' iniciarSesion
    ''' </summary>
    ''' <param name="pnombre"> </param>
    ''' <param name="ppassword"></param>
    ''' <returns name = "_listaPermisos">List(Of String())</returns>
    ''' <remarks></remarks>
    Public Function iniciarSession(ByVal pnombre As String, ByVal ppassword As String) As ArrayList

        Dim _datos As New ArrayList ' se declara variable que sera retornada
        Dim _result As Boolean ' Variable para el resultado de la comprobacion de los credenciales del usuario a ingresar
        Dim _passwordEncript As String

        _passwordEncript = encriptarPassword(ppassword)

        Try
            '_result = identificarUsuario(pcorreo, _passwordEncript)

            'If _result Then
            Dim usuarioActual As ClsUsuario = _clsUsuarioPersist.buscarPorNombreContrasenna(pnombre, _passwordEncript)

            If Not usuarioActual Is Nothing Then

                _datos.Add(usuarioActual.nombreUsuario)
                _datos.Add(usuarioActual.apellido1Usuario)
                _datos.Add(usuarioActual.apellido2Usuario)
                _datos.Add(usuarioActual.cedula)
                _datos.Add(usuarioActual.rolUsuario)
            End If
            ' End If
            Return _datos ' se retorna lista con los permisos del usuario actual.
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function encriptarPassword(ByVal ppassword As String) As String

        Try
            Dim cifrar As New UnicodeEncoding()
            Dim byteTexto() As Byte = cifrar.GetBytes(ppassword)
            Dim md5 As New MD5CryptoServiceProvider()
            Dim byteHash() As Byte = md5.ComputeHash(byteTexto)
            Return Convert.ToBase64String(byteHash)
            'cifrar = Nothing
            'byteTexto = Nothing
        Catch ex As Exception
            Throw New Exception("Error al encriptar contraseña: " + ex.Message)
        End Try

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
    Public Sub registrarReciboCarne(ByVal precibo As Int32, ByVal pnombre As String, ByVal pfecha As Date, _
                             ByVal phora As String, ByVal pmonto As Int32, ByVal pconcepto As String, ByVal ptipo As Int32)

        Try
            _clsReciboPersist.registrarCarne(precibo, pnombre, pfecha, phora, pmonto, pconcepto, ptipo)
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
    ''' <param name="pmes"></param>
    ''' <param name="panno"></param>
    ''' <remarks></remarks>
    Public Sub registrarReciboOrden(ByVal precibo As Int32, ByVal pnombre As String, ByVal pfecha As Date, _
                             ByVal phora As String, ByVal pmonto As Int32, ByVal pconcepto As String, _
                             ByVal pmes As String, ByVal pmesNum As Int32, ByVal panno As Int32)

        Try
            _clsReciboPersist.registrarOrden(precibo, pnombre, pfecha, phora, pmonto, pconcepto, pmes, pmesNum, panno)
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
            idMax = _clsReciboPersist.obtenerMayorIdRecibo()
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
        Return idMax
    End Function
#End Region
End Class
