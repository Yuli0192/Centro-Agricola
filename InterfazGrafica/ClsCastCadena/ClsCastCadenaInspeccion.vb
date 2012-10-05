Public Class ClsCastCadenaInspeccion
    Private solicitud As Int32
    Private fechaCrea As Date
    Private fechaVence As Date
    Private codSocio As String
    Private nomSocio As String

    Public Property solicitudIns() As Int32
        Get
            Return solicitud
        End Get
        Set(ByVal value As Int32)
            solicitud = value
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

    Sub New()
    End Sub

    Sub New(ByVal psolicitud As Int32, ByVal pfechaCrea As Date, ByVal pfechaVence As Date, ByVal pcodSocio As String)
        solicitud = psolicitud
        fechaCrea = pfechaCrea
        fechaVence = pfechaVence
        codSocio = pcodSocio
    End Sub

    Sub New(ByVal psolicitud As Int32, ByVal pcodSocio As String, ByVal pnombreSocio As String, ByVal pfechaCrea As Date, ByVal pfechaVence As Date)
        solicitud = psolicitud
        codSocio = pcodSocio
        nomSocio = pnombreSocio
        fechaCrea = pfechaCrea
        fechaVence = pfechaVence
    End Sub
End Class
