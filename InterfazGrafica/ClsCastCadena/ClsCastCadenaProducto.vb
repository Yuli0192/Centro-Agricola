Public Class ClsCastCadenaProducto
#Region "Atributos"
    Private cod As Int32
    Private nombre As String
    Private unidad As Int32
    Private nomunidad As String
#End Region

#Region "Propiedades"
    Public Property Codigo() As Int32
        Get
            Return cod
        End Get
        Set(ByVal value As Int32)
            cod = value
        End Set
    End Property

    Public Property nombreProd() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property

    Public Property unidadProd() As Int32
        Get
            Return unidad
        End Get
        Set(ByVal value As Int32)
            unidad = value
        End Set
    End Property

    Public Property nombreUnidad() As String
        Get
            Return nomunidad
        End Get
        Set(ByVal value As String)
            nomunidad = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Sub New()
    End Sub

    Sub New(ByVal pcod As Int32, ByVal pnombre As String)
        cod = pcod
        nombre = pnombre
    End Sub

    Sub New(ByVal pcod As Int32, ByVal pnombre As String, ByVal punidad As String)
        cod = pcod
        nombre = pnombre
        nomunidad = punidad
    End Sub
#End Region
End Class
