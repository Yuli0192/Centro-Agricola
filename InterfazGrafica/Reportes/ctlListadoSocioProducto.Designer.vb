<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlListadoSocioProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlListadoSocioProducto))
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.pbReporte = New System.Windows.Forms.PictureBox
        Me.pbRegresar = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.reporteSocioProducto = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.cmbProducto = New System.Windows.Forms.ComboBox
        Me.lblProducto = New System.Windows.Forms.Label
        Me.productoSocio1 = New InterfazGrafica.ProductoSocio
        CType(Me.pbReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbReporte
        '
        Me.pbReporte.BackgroundImage = CType(resources.GetObject("pbReporte.BackgroundImage"), System.Drawing.Image)
        Me.pbReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbReporte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbReporte.Location = New System.Drawing.Point(648, 61)
        Me.pbReporte.Name = "pbReporte"
        Me.pbReporte.Size = New System.Drawing.Size(30, 30)
        Me.pbReporte.TabIndex = 49
        Me.pbReporte.TabStop = False
        Me.help.SetToolTip(Me.pbReporte, "Generar reporte")
        '
        'pbRegresar
        '
        Me.pbRegresar.BackgroundImage = CType(resources.GetObject("pbRegresar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresar.Location = New System.Drawing.Point(843, 10)
        Me.pbRegresar.Name = "pbRegresar"
        Me.pbRegresar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegresar.TabIndex = 50
        Me.pbRegresar.TabStop = False
        Me.help.SetToolTip(Me.pbRegresar, "Regresar")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.reporteSocioProducto)
        Me.Panel1.Controls.Add(Me.pbRegresar)
        Me.Panel1.Controls.Add(Me.pbReporte)
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Controls.Add(Me.cmbProducto)
        Me.Panel1.Controls.Add(Me.lblProducto)
        Me.Panel1.Location = New System.Drawing.Point(47, 135)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(953, 562)
        Me.Panel1.TabIndex = 0
        '
        'reporteSocioProducto
        '
        Me.reporteSocioProducto.ActiveViewIndex = -1
        Me.reporteSocioProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reporteSocioProducto.DisplayGroupTree = False
        Me.reporteSocioProducto.Location = New System.Drawing.Point(13, 105)
        Me.reporteSocioProducto.Name = "reporteSocioProducto"
        Me.reporteSocioProducto.SelectionFormula = ""
        Me.reporteSocioProducto.Size = New System.Drawing.Size(902, 443)
        Me.reporteSocioProducto.TabIndex = 51
        Me.reporteSocioProducto.ViewTimeSelectionFormula = ""
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(327, 10)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(304, 29)
        Me.lblTitulo.TabIndex = 46
        Me.lblTitulo.Text = "Listado socios por producto"
        '
        'cmbProducto
        '
        Me.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProducto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(392, 64)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(250, 27)
        Me.cmbProducto.TabIndex = 48
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.Location = New System.Drawing.Point(319, 67)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(72, 19)
        Me.lblProducto.TabIndex = 47
        Me.lblProducto.Text = "Producto"
        '
        'ctlListadoSocioProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlListadoSocioProducto"
        Me.Size = New System.Drawing.Size(1024, 700)
        CType(Me.pbReporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pbReporte As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents cmbProducto As System.Windows.Forms.ComboBox
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents pbRegresar As System.Windows.Forms.PictureBox
    Friend WithEvents reporteSocioProducto As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents productoSocio1 As InterfazGrafica.ProductoSocio

End Class
