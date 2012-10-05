Public Class ClsCastCadenaFinca

    Private cod As Int32
    Private nombre As String
    Private direccion As String
    Private area As Int32

    Public Property codigo() As Int32
        Get
            Return cod
        End Get
        Set(ByVal value As Int32)
            cod = value
        End Set
    End Property

    Public Property nombreFinca() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property

    Public Property direccionFinca() As String
        Get
            Return direccion
        End Get
        Set(ByVal value As String)
            direccion = value
        End Set
    End Property

    Public Property areaFinca() As Int32
        Get
            Return area
        End Get
        Set(ByVal value As Int32)
            area = value
        End Set
    End Property

    Sub New()
    End Sub

    Sub New(ByVal pcod As Int32, ByVal pnombre As String, ByVal pdireccion As String, ByVal parea As Int32)
        cod = pcod
        nombre = pnombre
        direccion = pdireccion
        area = parea
    End Sub

End Class
