<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlListadoAuxProducto
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlListadoAuxProducto))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.reporteAuxProducto = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.pbRegresar = New System.Windows.Forms.PictureBox
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.pbReporte = New System.Windows.Forms.PictureBox
        Me.lblProducto = New System.Windows.Forms.Label
        Me.cmbProducto = New System.Windows.Forms.ComboBox
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.productoAux1 = New InterfazGrafica.ProductoAux
        Me.Panel1.SuspendLayout()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.reporteAuxProducto)
        Me.Panel1.Controls.Add(Me.pbRegresar)
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Controls.Add(Me.pbReporte)
        Me.Panel1.Controls.Add(Me.lblProducto)
        Me.Panel1.Controls.Add(Me.cmbProducto)
        Me.Panel1.Location = New System.Drawing.Point(17, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(979, 574)
        Me.Panel1.TabIndex = 0
        '
        'reporteAuxProducto
        '
        Me.reporteAuxProducto.ActiveViewIndex = -1
        Me.reporteAuxProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reporteAuxProducto.DisplayGroupTree = False
        Me.reporteAuxProducto.Location = New System.Drawing.Point(15, 120)
        Me.reporteAuxProducto.Name = "reporteAuxProducto"
        Me.reporteAuxProducto.SelectionFormula = ""
        Me.reporteAuxProducto.Size = New System.Drawing.Size(950, 438)
        Me.reporteAuxProducto.TabIndex = 56
        Me.reporteAuxProducto.ViewTimeSelectionFormula = ""
        '
        'pbRegresar
        '
        Me.pbRegresar.BackgroundImage = CType(resources.GetObject("pbRegresar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresar.Location = New System.Drawing.Point(890, 31)
        Me.pbRegresar.Name = "pbRegresar"
        Me.pbRegresar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegresar.TabIndex = 55
        Me.pbRegresar.TabStop = False
        Me.help.SetToolTip(Me.pbRegresar, "Regresar")
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(298, 19)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(339, 29)
        Me.lblTitulo.TabIndex = 51
        Me.lblTitulo.Text = "Listado auxiliares por producto"
        '
        'pbReporte
        '
        Me.pbReporte.BackgroundImage = CType(resources.GetObject("pbReporte.BackgroundImage"), System.Drawing.Image)
        Me.pbReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbReporte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbReporte.Location = New System.Drawing.Point(625, 70)
        Me.pbReporte.Name = "pbReporte"
        Me.pbReporte.Size = New System.Drawing.Size(30, 30)
        Me.pbReporte.TabIndex = 54
        Me.pbReporte.TabStop = False
        Me.help.SetToolTip(Me.pbReporte, "Reporte")
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.Location = New System.Drawing.Point(290, 76)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(72, 19)
        Me.lblProducto.TabIndex = 52
        Me.lblProducto.Text = "Producto"
        '
        'cmbProducto
        '
        Me.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProducto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(368, 73)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(251, 27)
        Me.cmbProducto.TabIndex = 53
        '
        'ctlListadoAuxProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlListadoAuxProducto"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pbRegresar As System.Windows.Forms.PictureBox
    Friend WithEvents pbReporte As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents cmbProducto As System.Windows.Forms.ComboBox
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents reporteAuxProducto As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents productoAux1 As InterfazGrafica.ProductoAux

End Class
