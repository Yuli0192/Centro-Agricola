Public Class ClsCastCadenaOrden
    Private cod As Int32
    Private cedCliente As String
    Private nomCliente As String
    Private mes As String
    Private anno As Int32
    Private fechaCrea As Date
    Private fechaVence As Date
    Private fechaPago As Date
    Private monto As Int32
    Private salario As Int32
    Private multa As Int32
    Private montoPagar As Int32
    Private estado As String

    Public Property codigo() As Int32
        Get
            Return cod
        End Get
        Set(ByVal value As Int32)
            cod = value
        End Set
    End Property

    Public Property cedulaCliente() As String
        Get
            Return cedCliente
        End Get
        Set(ByVal value As String)
            cedCliente = value
        End Set
    End Property

    Public Property nombreCliente() As String
        Get
            Return nomCliente
        End Get
        Set(ByVal value As String)
            nomCliente = value
        End Set
    End Property

    Public Property mesOrden() As String
        Get
            Return mes
        End Get
        Set(ByVal value As String)
            mes = value
        End Set
    End Property

    Public Property annoOrden() As Int32
        Get
            Return anno
        End Get
        Set(ByVal value As Int32)
            anno = value
        End Set
    End Property

    Public Property fechaCreaorden() As Date
        Get
            Return fechaCrea
        End Get
        Set(ByVal value As Date)
            fechaCrea = value
        End Set
    End Property

    Public Property fechaVenceOrden() As Date
        Get
            Return fechaVence
        End Get
        Set(ByVal value As Date)
            fechaVence = value
        End Set
    End Property
    Public Property fechaPagoOrden() As Date
        Get
            Return fechaPago
        End Get
        Set(ByVal value As Date)
            fechaPago = value
        End Set
    End Property

    Public Property montoOrden() As Int32
        Get
            Return monto
        End Get
        Set(ByVal value As Int32)
            monto = value
        End Set
    End Property

    Public Property salarioBase() As Int32
        Get
            Return salario
        End Get
        Set(ByVal value As Int32)
            salario = value
        End Set
    End Property

    Public Property multaOrden() As Int32
        Get
            Return multa
        End Get
        Set(ByVal value As Int32)
            multa = value
        End Set
    End Property

    Public Property montoPagarOrden() As Int32
        Get
            Return montoPagar
        End Get
        Set(ByVal value As Int32)
            montoPagar = value
        End Set
    End Property

    Public Property estadoOrden() As String
        Get
            Return estado
        End Get
        Set(ByVal value As String)
            estado = value
        End Set
    End Property

    Sub New()
    End Sub

    Sub New(ByVal pcod As Int32, ByVal pcedulaCliente As String, ByVal pmes As String, ByVal panno As Int32, _
            ByVal pfechaCrea As Date, ByVal pfechaVence As Date, ByVal pfechaPago As Date, ByVal pmonto As Int32, _
            ByVal psalario As Int32, ByVal pmulta As Int32, ByVal pmontoPagar As Int32, ByVal pestado As String)

        cod = pcod
        cedCliente = pcedulaCliente
        mes = pmes
        anno = panno
        fechaCrea = pfechaCrea
        fechaVence = pfechaVence
        fechaPago = pfechaPago
        monto = pmonto
        salario = psalario
        multa = pmulta
        montoPagar = pmontoPagar
        estado = pestado
    End Sub

    Sub New(ByVal pcedulaCliente As String, ByVal pnombreCliente As String, ByVal pmes As String, ByVal panno As Int32, _
           ByVal pfechaCrea As Date, ByVal pfechaVence As Date, ByVal pfechaPago As Date, ByVal pmontoPagar As Int32)

        cedCliente = pcedulaCliente
        nomCliente = pnombreCliente
        mes = pmes
        anno = panno
        fechaCrea = pfechaCrea
        fechaVence = pfechaVence
        fechaPago = pfechaPago
        montoPagar = pmontoPagar

    End Sub
End Class
