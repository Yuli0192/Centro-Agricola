Public Class ClsInspeccion
#Region "Atributos"
    Private solicitud As Int32
    Private fechaCrea As Date
    Private fechaVence As Date
    Private codSocio As String
    Private nomSocio As String
#End Region

#Region "Propiedades"
    Public Property solicitudIns() As Int32
        Get
            Return solicitud
        End Get
        Set(ByVal value As Int32)
            solicitud = value
        End Set
    End Property

    Public Property fechaCreaIns() As Date
        Get
            Return fechaCrea
        End Get
        Set(ByVal value As Date)
            fechaCrea = value
        End Set
    End Property

    Public Property fechaVenceIns() As Date
        Get
            Return fechaVence
        End Get
        Set(ByVal value As Date)
            fechaVence = value
        End Set
    End Property

    Public Property codigoSocio() As String
        Get
            Return codSocio
        End Get
        Set(ByVal value As String)
            codSocio = value
        End Set
    End Property

    Public Property nombreSocio() As String
        Get
            Return nomSocio
        End Get
        Set(ByVal value As String)
            nomSocio = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Sub New()
    End Sub

    Sub New(ByVal psolicitud As Int32, ByVal pfechaCrea As Date, ByVal pfechaVence As Date, ByVal pcodSocio As String)
        solicitud = psolicitud
        fechaCrea = pfechaCrea
        fechaVence = pfechaVence
        codSocio = pcodSocio
    End Sub

    Sub New(ByVal psolicitud As Int32, ByVal pfechaCrea As Date, ByVal pfechaVence As Date, ByVal pcodSocio As String, _
            ByVal pnombreSocio As String)
        solicitud = psolicitud
        fechaCrea = pfechaCrea
        fechaVence = pfechaVence
        codSocio = pcodSocio
        nomSocio = pnombreSocio
    End Sub
#End Region
End Class
