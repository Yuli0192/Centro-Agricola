<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popupReciboOrden
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.reciboOrdenPrue1 = New InterfazGrafica.ReciboOrdenPrue
        Me.reciboOrden = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'reciboOrden
        '
        Me.reciboOrden.ActiveViewIndex = -1
        Me.reciboOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reciboOrden.DisplayGroupTree = False
        Me.reciboOrden.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reciboOrden.Location = New System.Drawing.Point(0, 0)
        Me.reciboOrden.Name = "reciboOrden"
        Me.reciboOrden.SelectionFormula = ""
        Me.reciboOrden.Size = New System.Drawing.Size(821, 463)
        Me.reciboOrden.TabIndex = 0
        Me.reciboOrden.ViewTimeSelectionFormula = ""
        '
        'popupReciboOrden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 463)
        Me.Controls.Add(Me.reciboOrden)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "popupReciboOrden"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Imprimir recibo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents reciboOrdenPrue1 As InterfazGrafica.ReciboOrdenPrue
    Friend WithEvents reciboOrden As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
