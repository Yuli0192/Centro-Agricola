Imports LogicaNegocio.ClsGestor
Public Class ctlFactura
    Dim _gestor As New LogicaNegocio.ClsGestor
    Dim _resul As Boolean
    Dim _recibo As Int32
    Private Sub ctlFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _recibo = _gestor.obtenerMayorIdRecibo + 1
        cmbTipo.SelectedIndex = 0
        txtNombre.Focus()
        txtFactura.Text = _recibo
        Dim _fecha As Date = Now().Date
        txtFecha.Text = _fecha
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function evaluarEspacion() As Boolean
        _resul = False
        If Me.txtFactura.Text = "" Then
            MsgBox("El número de factura es un dato requerido.", MsgBoxStyle.Information, "Registrar Factura")
            Me.txtFactura.Focus()

        ElseIf Me.txtNombre.Text = "" Then
            MsgBox("El nombre es un dato requerido.", MsgBoxStyle.Information, "Registrar Factura")
            Me.txtNombre.Focus()

        ElseIf Me.txtFecha.Text = "" Then
            MsgBox("La fecha de la factura es un dato requerido.", MsgBoxStyle.Information, "Registrar Factura")
            Me.txtFecha.Focus()

        ElseIf Me.cmbTipo.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar un tipo de factura.", MsgBoxStyle.Information, "Registrar Factura")

        ElseIf Me.txtConcepto.Text = "" Then
            MsgBox("El concepto de la factura es un dato requerido.", MsgBoxStyle.Information, "Registrar Factura")
            Me.txtConcepto.Focus()

        ElseIf Me.txtMonto.Text = "" Then
            MsgBox("El monto de la factura es un dato requerido.", MsgBoxStyle.Information, "Registrar Factura")
            Me.txtMonto.Focus()
        Else
            _resul = True
        End If

        Return _resul
    End Function

    Private Sub pbRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegistrar.Click
        _resul = evaluarEspacion()
        If _resul = True Then
            Dim _fecha As Date = Now().Date
            Dim _tipoR As String = cmbTipo.SelectedItem.ToString
            Dim _hora As String = Format(Now, "hh:mm:ss tt")
            Dim _monto As Int32 = txtMonto.Text
            Dim _concepto As String = txtConcepto.Text
            Dim _tipo As Int32
            If _tipoR = "INSPECCIÓN" Then
                _tipo = 1
            Else
                _tipo = 3
            End If
            Try
                _gestor.registrarReciboCarne(_recibo, txtNombre.Text, _fecha, _hora, _monto, _concepto, _tipo)
                MsgBox("Los datos de la factura se ha registrado correctamente.", MsgBoxStyle.Information, "Registrar Factura")
                pbImprimirRecibo.Enabled = True
            Catch ex As Exception
                MessageBox.Show("Ocurrio un error al tratar de registrar la factura" & ex.Message)
            End Try
        End If
    End Sub

    Public Sub imprimirRecibo()
        Try
            Dim _tipoR As String = cmbTipo.SelectedItem.ToString
            Dim report
            If _tipoR = "INSPECCIÓN" Then
                report = New Recibo
            Else
                report = New ReciboPrue
            End If

            report.SetParameterValue("recibo", _recibo)
            report.PrintOptions.PrinterName = "EPSON FX-890 ESC/P"
            report.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperEnvelopeB6
            report.PrintToPrinter(1, False, 1, 1)
            report.Refresh()
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al tratar de imprimir" & ex.Message)
        End Try
    End Sub

    Private Sub pbImprimirRecibo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbImprimirRecibo.Click
        imprimirRecibo()
        _recibo = _gestor.obtenerMayorIdRecibo + 1
    End Sub

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
        CType(Me.ParentForm, frmCentroAgricola).cargarUserControl(New ctlPrincipal)
    End Sub

    Private Sub limpiar()
        txtNombre.Clear()
        txtConcepto.Clear()
        txtMonto.Clear()
        cmbTipo.SelectedIndex = 0
    End Sub
    Private Sub pbLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbLimpiar.Click
        limpiar()
    End Sub

    Private Sub cmbTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipo.SelectedIndexChanged
        Dim _tipoR As String = cmbTipo.SelectedItem.ToString
        Dim _concepto As String
        If _tipoR = "INSPECCIÓN" Then
            _concepto = "CUOTA PERTENECIENTE A INSPECCIÓN Y EMISIÓN DE CARNE DE FERIA DEL AGRICULTOR"
        ElseIf _tipoR = "CONVENIO CCSS" Then
            _concepto = "CONVENIO CCSS"
        Else
            _concepto = ""
        End If
        txtConcepto.Text = _concepto
    End Sub
End Class
