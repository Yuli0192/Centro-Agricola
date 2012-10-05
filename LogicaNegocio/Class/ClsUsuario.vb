Public Class ClsUsuario
#Region "Atributos"
    Private ced As String
    Private nombre As String
    Private apellido1 As String
    Private apellido2 As String
    Private contrasenna As String
    Private rol As String
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

    Public Property nombreUsuario() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property

    Public Property apellido1Usuario() As String
        Get
            Return apellido1
        End Get
        Set(ByVal value As String)
            apellido1 = value
        End Set
    End Property

    Public Property apellido2Usuario() As String
        Get
            Return apellido2
        End Get
        Set(ByVal value As String)
            apellido2 = value
        End Set
    End Property

    Public Property contrasennaUsuario() As String
        Get
            Return contrasenna
        End Get
        Set(ByVal value As String)
            contrasenna = value
        End Set
    End Property

    Public Property rolUsuario() As String
        Get
            Return rol
        End Get
        Set(ByVal value As String)
            rol = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Sub New()
    End Sub

    Sub New(ByVal pcedula As String, ByVal pnombre As String, ByVal papellido1 As String, _
            ByVal papellido2 As String, ByVal pcontrasenna As String, ByVal prol As String)

        ced = pcedula
        nombre = pnombre
        apellido1 = papellido1
        apellido2 = papellido2
        contrasenna = pcontrasenna
        rol = prol
    End Sub
#End Region
End Class
