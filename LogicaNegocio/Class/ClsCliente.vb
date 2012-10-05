Public Class ClsCliente

#Region "Atributos"
    Private ced As String
    Private nombre As String
    Private direccion As String
    Private tel As String
    Private fechaIngreso As Date
    Private salario As Int32
    Private cuota As Int32
    Private cantIngreso As Int32
#End Region

#Region "Propiedades"
    Public Property cedula() As String
        Get
            Return ced
        End Get
        Set(ByVal value As String)
            ced = value
        End Set
    End Property

    Public Property nombreCliente() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property

    Public Property direccionCliente() As String
        Get
            Return direccion
        End Get
        Set(ByVal value As String)
            direccion = value
        End Set
    End Property

    Public Property telefono() As String
        Get
            Return tel
        End Get
        Set(ByVal value As String)
            tel = value
        End Set
    End Property

    Public Property fechaIngresoCliente() As Date
        Get
            Return fechaIngreso
        End Get
        Set(ByVal value As Date)
            fechaIngreso = value
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

    Public Property cuotaOrden() As Int32
        Get
            Return cuota
        End Get
        Set(ByVal value As Int32)
            cuota = value
        End Set
    End Property

    Public Property cantidadIngreso() As Int32
        Get
            Return cantIngreso
        End Get
        Set(ByVal value As Int32)
            cantIngreso = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Sub New()
    End Sub

    Sub New(ByVal pcedula As String, ByVal pnombre As String, ByVal pdireccion As String, _
             ByVal ptelefono As String, ByVal pfechaIngreso As Date, ByVal psalario As Int32, ByVal pcuota As Int32, _
             ByVal pcantIng As Int32)
        ced = pcedula
        nombre = pnombre
        direccion = pdireccion
        tel = ptelefono
        fechaIngreso = pfechaIngreso
        salario = psalario
        cuota = pcuota
        cantIngreso = pcantIng
    End Sub
#End Region
End Class
