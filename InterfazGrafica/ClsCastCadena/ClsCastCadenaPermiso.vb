Public Class ClsCastCadenaPermiso

    Private codPermiso As Int32
    Private nomSocio As String
    Private codAux As String
    Private fechaCrea As Date
    Private fechaVence As Date

    Public Property codigoPermiso() As Int32
        Get
            Return codPermiso
        End Get
        Set(ByVal value As Int32)
            codPermiso = value
        End Set
    End Property

    Public Property codigoSocio() As String
        Get
            Return nomSocio
        End Get
        Set(ByVal value As String)
            nomSocio = value
        End Set
    End Property

    Public Property codigoAuxiliar() As String
        Get
            Return codAux
        End Get
        Set(ByVal value As String)
            codAux = value
        End Set
    End Property

    Public Property fechaCreaPerm() As Date
        Get
            Return fechaCrea
        End Get
        Set(ByVal value As Date)
            fechaCrea = value
        End Set
    End Property

    Public Property fechaVencePerm() As Date
        Get
            Return fechaVence
        End Get
        Set(ByVal value As Date)
            fechaVence = value
        End Set
    End Property

    Sub New()
    End Sub

    Sub New(ByVal pcodPermiso As Int32, ByVal pnomSocio As String, ByVal pcodAux As String, _
            ByVal pfechaCrea As Date, ByVal pfechaVence As Date)
        codPermiso = pcodPermiso
        nomSocio = pnomSocio
        codAux = pcodAux
        fechaCrea = pfechaCrea
        fechaVence = pfechaVence
    End Sub

    Sub New(ByVal pcodPermiso As Int32, ByVal pnomSocio As String, ByVal pfechaCrea As Date, ByVal pfechaVence As Date)
        codPermiso = pcodPermiso
        nomSocio = pnomSocio
        fechaCrea = pfechaCrea
        fechaVence = pfechaVence
    End Sub
End Class
