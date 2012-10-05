<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlPermisoSemanal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlPermisoSemanal))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.pbReporte = New System.Windows.Forms.PictureBox
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.lblFechaInicio = New System.Windows.Forms.Label
        Me.dtpFin = New System.Windows.Forms.DateTimePicker
        Me.lblFechaFin = New System.Windows.Forms.Label
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker
        Me.pbRegresar = New System.Windows.Forms.PictureBox
        Me.permisoSemanal1 = New InterfazGrafica.PermisoSemanal
        Me.reportePermisoSemanal = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Panel1.SuspendLayout()
        CType(Me.pbReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.reportePermisoSemanal)
        Me.Panel1.Controls.Add(Me.pbRegresar)
        Me.Panel1.Controls.Add(Me.pbReporte)
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Controls.Add(Me.lblFechaInicio)
        Me.Panel1.Controls.Add(Me.dtpFin)
        Me.Panel1.Controls.Add(Me.lblFechaFin)
        Me.Panel1.Controls.Add(Me.dtpInicio)
        Me.Panel1.Location = New System.Drawing.Point(12, 105)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(994, 592)
        Me.Panel1.TabIndex = 0
        '
        'pbReporte
        '
        Me.pbReporte.BackgroundImage = CType(resources.GetObject("pbReporte.BackgroundImage"), System.Drawing.Image)
        Me.pbReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbReporte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbReporte.Location = New System.Drawing.Point(746, 72)
        Me.pbReporte.Name = "pbReporte"
        Me.pbReporte.Size = New System.Drawing.Size(30, 30)
        Me.pbReporte.TabIndex = 48
        Me.pbReporte.TabStop = False
        Me.help.SetToolTip(Me.pbReporte, "Generar reporte")
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(428, 23)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(193, 29)
        Me.lblTitulo.TabIndex = 43
        Me.lblTitulo.Text = "Permiso semanal"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblFechaInicio.Location = New System.Drawing.Point(260, 82)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(85, 18)
        Me.lblFechaInicio.TabIndex = 45
        Me.lblFechaInicio.Text = "Fecha Inicio"
        '
        'dtpFin
        '
        Me.dtpFin.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(608, 76)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(119, 26)
        Me.dtpFin.TabIndex = 47
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblFechaFin.Location = New System.Drawing.Point(520, 80)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(70, 18)
        Me.lblFechaFin.TabIndex = 46
        Me.lblFechaFin.Text = "Fecha Fin"
        '
        'dtpInicio
        '
        Me.dtpInicio.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(363, 78)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(117, 26)
        Me.dtpInicio.TabIndex = 44
        '
        'pbRegresar
        '
        Me.pbRegresar.BackgroundImage = CType(resources.GetObject("pbRegresar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresar.Location = New System.Drawing.Point(945, 12)
        Me.pbRegresar.Name = "pbRegresar"
        Me.pbRegresar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegresar.TabIndex = 49
        Me.pbRegresar.TabStop = False
        Me.help.SetToolTip(Me.pbRegresar, "Regresar")
        '
        'reportePermisoSemanal
        '
        Me.reportePermisoSemanal.ActiveViewIndex = -1
        Me.reportePermisoSemanal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reportePermisoSemanal.DisplayGroupTree = False
        Me.reportePermisoSemanal.Location = New System.Drawing.Point(13, 124)
        Me.reportePermisoSemanal.Name = "reportePermisoSemanal"
        Me.reportePermisoSemanal.SelectionFormula = ""
        Me.reportePermisoSemanal.Size = New System.Drawing.Size(962, 457)
        Me.reportePermisoSemanal.TabIndex = 50
        Me.reportePermisoSemanal.ViewTimeSelectionFormula = ""
        '
        'ctlPermisoSemanal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlPermisoSemanal"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbReporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pbReporte As System.Windows.Forms.PictureBox
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents pbRegresar As System.Windows.Forms.PictureBox
    Friend WithEvents reportePermisoSemanal As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents permisoSemanal1 As InterfazGrafica.PermisoSemanal

End Class
