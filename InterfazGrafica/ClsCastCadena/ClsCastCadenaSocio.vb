Public Class ClsCastCadenaSocio

    Private cod As String
    Private ced As String
    Private nombre As String
    Private direccionFinca As String
    Private direccionCasa As String
    Private tel As String
    Private correo As String
    Private fechaIng As Date

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

    Public Property nombreSocio() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property

    Public Property direccionFincaSocio() As String
        Get
            Return direccionFinca
        End Get
        Set(ByVal value As String)
            direccionFinca = value
        End Set
    End Property

    Public Property direccionCasaSocio() As String
        Get
            Return direccionCasa
        End Get
        Set(ByVal value As String)
            direccionCasa = value
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

    Public Property correoSocio() As String
        Get
            Return correo
        End Get
        Set(ByVal value As String)
            correo = value
        End Set
    End Property

    Public Property fechaIngreso() As Date
        Get
            Return fechaIng
        End Get
        Set(ByVal value As Date)
            fechaIng = value
        End Set
    End Property


    Sub New()
    End Sub

    Sub New(ByVal pcod As String, ByVal pcedula As String, ByVal pnombre As String, ByVal pdireccionFinca As String, _
            ByVal pdireccionCasa As String, ByVal ptelefono As String, ByVal pcorreo As String, ByVal pfechaIngreso As Date)
        cod = pcod
        ced = pcedula
        nombre = pnombre
        direccionFinca = pdireccionFinca
        direccionCasa = pdireccionCasa
        tel = ptelefono
        correo = pcorreo
        fechaIng = pfechaIngreso
    End Sub

    Sub New(ByVal pcod As String, ByVal pcedula As String, ByVal pnombre As String, ByVal pdireccionFinca As String, _
            ByVal pdireccionCasa As String, ByVal ptelefono As String, ByVal pfechaIngreso As Date)
        cod = pcod
        ced = pcedula
        nombre = pnombre
        direccionFinca = pdireccionFinca
        direccionCasa = pdireccionCasa
        tel = ptelefono
        fechaIng = pfechaIngreso
    End Sub

    Sub New(ByVal pcod As String, ByVal pcedula As String, ByVal pnombre As String)
        cod = pcod
        ced = pcedula
        nombre = pnombre
    End Sub
End Class
