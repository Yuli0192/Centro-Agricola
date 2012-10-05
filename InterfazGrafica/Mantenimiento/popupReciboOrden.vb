Public Class popupReciboOrden
    Dim _recibo As Int32
    Public Sub New(ByVal precibo As Int32)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _recibo = precibo
    End Sub

    Private Sub popupReciboOrden_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim report As New ReciboOrden
        Dim report As New ReciboOrdenPrue
        report.SetParameterValue("recibo", _recibo)
        Me.reciboOrden.ReportSource = report
        Me.reciboOrden.Refresh()
    End Sub
End Class