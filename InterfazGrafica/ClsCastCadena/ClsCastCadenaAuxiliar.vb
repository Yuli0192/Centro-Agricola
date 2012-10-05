Public Class ClsCastCadenaAuxiliar

    Private cod As String
    Private ced As String
    Private nombre As String
    Private tel As String
    Private parentesco As String

    Public Property codigo() As String
        Get
            Return cod
        End Get
        Set(ByVal value As String)
            cod = value
        End Set
    End Property

    Public Property cedula() As String
        Get
            Return ced
        End Get
        Set(ByVal value As String)
            ced = value
        End Set
    End Property

    Public Property nombreAuxiliar() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
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

    Public Property parentescoAux() As String
        Get
            Return parentesco
        End Get
        Set(ByVal value As String)
            parentesco = value
        End Set
    End Property

    Sub New()
    End Sub

    Sub New(ByVal pcod As String, ByVal pcedula As String, ByVal pnombre As String, ByVal ptelefono As String, _
            ByVal pparentesco As String)
        cod = pcod
        ced = pcedula
        nombre = pnombre
        tel = ptelefono
        parentesco = pparentesco
    End Sub

    Sub New(ByVal pcod As String, ByVal pcedula As String, ByVal pnombre As String)
        cod = pcod
        ced = pcedula
        nombre = pnombre
    End Sub

End Class
