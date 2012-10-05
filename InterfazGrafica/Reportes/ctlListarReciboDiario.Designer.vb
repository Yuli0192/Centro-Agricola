<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlListarReciboDiario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlListarReciboDiario))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pbRegresar = New System.Windows.Forms.PictureBox
        Me.ReporteDiario = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.pbReporte = New System.Windows.Forms.PictureBox
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.lblFechaInicio = New System.Windows.Forms.Label
        Me.dtpFin = New System.Windows.Forms.DateTimePicker
        Me.lblFechaFin = New System.Windows.Forms.Label
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker
        Me.listadoReciboDiario1 = New InterfazGrafica.ListadoReciboDiario
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbRegresar)
        Me.Panel1.Controls.Add(Me.ReporteDiario)
        Me.Panel1.Controls.Add(Me.pbReporte)
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Controls.Add(Me.lblFechaInicio)
        Me.Panel1.Controls.Add(Me.dtpFin)
        Me.Panel1.Controls.Add(Me.lblFechaFin)
        Me.Panel1.Controls.Add(Me.dtpInicio)
        Me.Panel1.Location = New System.Drawing.Point(46, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(921, 570)
        Me.Panel1.TabIndex = 0
        '
        'pbRegresar
        '
        Me.pbRegresar.BackgroundImage = CType(resources.GetObject("pbRegresar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresar.Location = New System.Drawing.Point(861, 3)
        Me.pbRegresar.Name = "pbRegresar"
        Me.pbRegresar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegresar.TabIndex = 7
        Me.pbRegresar.TabStop = False
        Me.help.SetToolTip(Me.pbRegresar, "Regresar")
        '
        'ReporteDiario
        '
        Me.ReporteDiario.ActiveViewIndex = -1
        Me.ReporteDiario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReporteDiario.DisplayGroupTree = False
        Me.ReporteDiario.Location = New System.Drawing.Point(45, 109)
        Me.ReporteDiario.Name = "ReporteDiario"
        Me.ReporteDiario.SelectionFormula = ""
        Me.ReporteDiario.Size = New System.Drawing.Size(846, 445)
        Me.ReporteDiario.TabIndex = 43
        Me.ReporteDiario.ViewTimeSelectionFormula = ""
        '
        'pbReporte
        '
        Me.pbReporte.BackgroundImage = CType(resources.GetObject("pbReporte.BackgroundImage"), System.Drawing.Image)
        Me.pbReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbReporte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbReporte.Location = New System.Drawing.Point(699, 60)
        Me.pbReporte.Name = "pbReporte"
        Me.pbReporte.Size = New System.Drawing.Size(30, 30)
        Me.pbReporte.TabIndex = 42
        Me.pbReporte.TabStop = False
        Me.help.SetToolTip(Me.pbReporte, "Generar reporte")
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(344, 14)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(253, 29)
        Me.lblTitulo.TabIndex = 37
        Me.lblTitulo.Text = "Listado recibos  diario "
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblFechaInicio.Location = New System.Drawing.Point(213, 70)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(85, 18)
        Me.lblFechaInicio.TabIndex = 39
        Me.lblFechaInicio.Text = "Fecha Inicio"
        '
        'dtpFin
        '
        Me.dtpFin.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(561, 64)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(119, 26)
        Me.dtpFin.TabIndex = 41
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblFechaFin.Location = New System.Drawing.Point(473, 68)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(70, 18)
        Me.lblFechaFin.TabIndex = 40
        Me.lblFechaFin.Text = "Fecha Fin"
        '
        'dtpInicio
        '
        Me.dtpInicio.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(316, 66)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(117, 26)
        Me.dtpInicio.TabIndex = 38
        '
        'ctlListarReciboDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlListarReciboDiario"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pbReporte As System.Windows.Forms.PictureBox
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents ReporteDiario As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents listadoReciboDiario1 As InterfazGrafica.ListadoReciboDiario
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents pbRegresar As System.Windows.Forms.PictureBox

End Class
