Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Public Class OrdenMes

    Private Sub OrdenMes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbMes.SelectedIndex = 0
    End Sub

    Private Sub pbReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbReporte.Click
        Dim resul As Boolean = evaluarEspacio()
        If resul Then
            'Dim reporte As New OrdenesCanceladas
            Dim reporte As New OrdenesMesPrueba
            Dim _mes As String = cmbMes.SelectedItem.ToString
            Dim _mesNum As Int32 = obtenerNumeroMes(_mes)
            Dim _anno As Int32 = txtAnno.Text
            reporte.SetParameterValue("mes", _mesNum)
            reporte.SetParameterValue("anno", _anno)
            listadoOrdenesCanceladas.ReportSource = reporte
            listadoOrdenesCanceladas.Refresh()
        End If
    End Sub

    Private Function obtenerNumeroMes(ByVal pmes As String) As Int32
        Dim _numMes As Int32

        If pmes = "ENERO" Then
            _numMes = 1
        ElseIf pmes = "FEBRERO" Then
            _numMes = 2
        ElseIf pmes = "MARZO" Then
            _numMes = 3
        ElseIf pmes = "ABRIL" Then
            _numMes = 4
        ElseIf pmes = "MAYO" Then
            _numMes = 5
        ElseIf pmes = "JUNIO" Then
            _numMes = 6
        ElseIf pmes = "JULIO" Then
            _numMes = 7
        ElseIf pmes = "AGOSTO" Then
            _numMes = 8
        ElseIf pmes = "SETIEMBRE" Then
            _numMes = 9
        ElseIf pmes = "OCTUBRE" Then
            _numMes = 10
        ElseIf pmes = "NOVIEMBRE" Then
            _numMes = 11
        ElseIf pmes = "DICIEMBRE" Then
            _numMes = 12
        End If

        Return _numMes
    End Function
    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningun componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function evaluarEspacio() As Boolean
        Dim _resul As Boolean

        If Me.cmbMes.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar un mes.", MsgBoxStyle.Information, "Aviso")

        ElseIf Me.txtAnno.Text = "" Then
            MsgBox("Debe ingresar un año.", MsgBoxStyle.Information, "Aviso")
            txtAnno.Focus()
        Else
            _resul = True
        End If
        Return _resul
    End Function

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
        CType(Me.ParentForm, frmCentroAgricola).cargarUserControl(New ctlPrincipal)
    End Sub
End Class
