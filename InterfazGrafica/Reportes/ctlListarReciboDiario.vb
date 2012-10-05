Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Public Class ctlListarReciboDiario


    Private Sub pbReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbReporte.Click
        Dim resul As Boolean = evaluarEspacio()
        If resul Then
            'Dim reporte As New ListadoReciboDiario
            Dim reporte As New ListadoReciboDiarioPrue
            reporte.SetParameterValue("fechainicio", dtpInicio.Value.Date)
            reporte.SetParameterValue("fechafin", dtpFin.Value.Date)
            ReporteDiario.ReportSource = reporte
            ReporteDiario.Refresh()
        End If
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningun componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function evaluarEspacio() As Boolean
        Dim _resul As Boolean

        If dtpInicio.Value.Date > dtpFin.Value.Date Then
            MsgBox("la fecha inicio debe ser menor q la fecha fin ", MsgBoxStyle.Information, "Aviso")

        Else
            _resul = True
        End If
        Return _resul
    End Function

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
        CType(Me.ParentForm, frmCentroAgricola).cargarUserControl(New ctlPrincipal)
    End Sub
End Class
