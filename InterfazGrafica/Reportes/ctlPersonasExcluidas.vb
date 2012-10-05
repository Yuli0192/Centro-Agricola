Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports LogicaNegocio.ClsGestor
Public Class ctlPersonasExcluidas

    Dim _gestor As New LogicaNegocio.ClsGestor

    Private Sub ctlPersonasExcluidas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _gestor.modificarMultaOrdenPendiente()
        'Dim reporte As New ClientesExcluidos
        Dim reporte As New ClientesExcluidosPrue
        listarPersonasExcluidas.ReportSource = reporte
        listarPersonasExcluidas.Refresh()
    End Sub

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
        CType(Me.ParentForm, frmCentroAgricola).cargarUserControl(New ctlPrincipal)
    End Sub
End Class
