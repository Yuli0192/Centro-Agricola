<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popupReciboInsp
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
        Me.reciboPrue1 = New InterfazGrafica.ReciboPrue
        Me.reciboInsp = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'reciboInsp
        '
        Me.reciboInsp.ActiveViewIndex = -1
        Me.reciboInsp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reciboInsp.DisplayGroupTree = False
        Me.reciboInsp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reciboInsp.Location = New System.Drawing.Point(0, 0)
        Me.reciboInsp.Name = "reciboInsp"
        Me.reciboInsp.SelectionFormula = ""
        Me.reciboInsp.Size = New System.Drawing.Size(811, 453)
        Me.reciboInsp.TabIndex = 0
        Me.reciboInsp.ViewTimeSelectionFormula = ""
        '
        'popupReciboInsp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 453)
        Me.Controls.Add(Me.reciboInsp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "popupReciboInsp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "popupReciboInsp"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents reciboPrue1 As InterfazGrafica.ReciboPrue
    Friend WithEvents reciboInsp As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
