Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports LogicaNegocio.ClsGestor
Public Class ctlListadoSocio

    Dim _gestor As New LogicaNegocio.ClsGestor

    Private Sub ctlListadoSocio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim reporte As New ListarSocio
        reporteSocio.ReportSource = reporte
        reporteSocio.Refresh()
    End Sub

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
        CType(Me.ParentForm, frmCentroAgricola).cargarUserControl(New ctlPrincipal)
    End Sub
End Class
