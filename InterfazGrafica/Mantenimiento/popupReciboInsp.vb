Public Class popupReciboInsp

    Dim _recibo As Int32
    Public Sub New(ByVal precibo As Int32)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _recibo = precibo
    End Sub
    Private Sub popupReciboInsp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim report As New Recibo
        Dim report As New ReciboPrue
        report.SetParameterValue("recibo", _recibo)
        Me.reciboInsp.ReportSource = report
        Me.reciboInsp.Refresh()
    End Sub
End Class