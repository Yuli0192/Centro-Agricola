Public Class ClsFeria
#Region "Atributos"
    Private cod As Int32
    Private nombre As String
#End Region

#Region "Propiedades"
    Public Property codigo() As Int32
        Get
            Return cod
        End Get
        Set(ByVal value As Int32)
            cod = value
        End Set
    End Property

    Public Property nombreFeria() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
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
#End Region
End Class
