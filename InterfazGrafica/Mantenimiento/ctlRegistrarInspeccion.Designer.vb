<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlRegistrarInspeccion
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlRegistrarInspeccion))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pbRegresar = New System.Windows.Forms.PictureBox
        Me.gpbRegistrarInspeccion = New System.Windows.Forms.GroupBox
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.lblMonto = New System.Windows.Forms.Label
        Me.pbImprimirRecibo = New System.Windows.Forms.PictureBox
        Me.pbImprimir = New System.Windows.Forms.PictureBox
        Me.pbLimpiar = New System.Windows.Forms.PictureBox
        Me.pbRegistrar = New System.Windows.Forms.PictureBox
        Me.ltbFeria = New System.Windows.Forms.ListBox
        Me.lblFeriaAsiste = New System.Windows.Forms.Label
        Me.dtpFechaVence = New System.Windows.Forms.DateTimePicker
        Me.lblFechaVencePermiso = New System.Windows.Forms.Label
        Me.dtpFechaCrea = New System.Windows.Forms.DateTimePicker
        Me.lblFechaCreaPermiso = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtDireccionFinca = New System.Windows.Forms.TextBox
        Me.lblDireccionFinca = New System.Windows.Forms.Label
        Me.lblNombre = New System.Windows.Forms.Label
        Me.txtSolicitud = New System.Windows.Forms.TextBox
        Me.lblSolicitud = New System.Windows.Forms.Label
        Me.gpbBuscarSocio = New System.Windows.Forms.GroupBox
        Me.lblCriterio = New System.Windows.Forms.Label
        Me.dgvDatos = New System.Windows.Forms.DataGridView
        Me.txtCriterio = New System.Windows.Forms.TextBox
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.inspeccion1 = New InterfazGrafica.Inspeccion
        Me.Panel1.SuspendLayout()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbRegistrarInspeccion.SuspendLayout()
        CType(Me.pbImprimirRecibo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbBuscarSocio.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbRegresar)
        Me.Panel1.Controls.Add(Me.gpbRegistrarInspeccion)
        Me.Panel1.Controls.Add(Me.gpbBuscarSocio)
        Me.Panel1.Location = New System.Drawing.Point(3, 121)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1018, 564)
        Me.Panel1.TabIndex = 0
        '
        'pbRegresar
        '
        Me.pbRegresar.BackgroundImage = CType(resources.GetObject("pbRegresar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresar.Location = New System.Drawing.Point(947, 3)
        Me.pbRegresar.Name = "pbRegresar"
        Me.pbRegresar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegresar.TabIndex = 13
        Me.pbRegresar.TabStop = False
        Me.help.SetToolTip(Me.pbRegresar, "Regresar")
        '
        'gpbRegistrarInspeccion
        '
        Me.gpbRegistrarInspeccion.Controls.Add(Me.txtMonto)
        Me.gpbRegistrarInspeccion.Controls.Add(Me.lblMonto)
        Me.gpbRegistrarInspeccion.Controls.Add(Me.pbImprimirRecibo)
        Me.gpbRegistrarInspeccion.Controls.Add(Me.pbImprimir)
        Me.gpbRegistrarInspeccion.Controls.Add(Me.pbLimpiar)
        Me.gpbRegistrarInspeccion.Controls.Add(Me.pbRegistrar)
        Me.gpbRegistrarInspeccion.Controls.Add(Me.ltbFeria)
        Me.gpbRegistrarInspeccion.Controls.Add(Me.lblFeriaAsiste)
        Me.gpbRegistrarInspeccion.Controls.Add(Me.dtpFechaVence)
        Me.gpbRegistrarInspeccion.Controls.Add(Me.lblFechaVencePermiso)
        Me.gpbRegistrarInspeccion.Controls.Add(Me.dtpFechaCrea)
        Me.gpbRegistrarInspeccion.Controls.Add(Me.lblFechaCreaPermiso)
        Me.gpbRegistrarInspeccion.Controls.Add(Me.txtNombre)
        Me.gpbRegistrarInspeccion.Controls.Add(Me.txtDireccionFinca)
        Me.gpbRegistrarInspeccion.Controls.Add(Me.lblDireccionFinca)
        Me.gpbRegistrarInspeccion.Controls.Add(Me.lblNombre)
        Me.gpbRegistrarInspeccion.Controls.Add(Me.txtSolicitud)
        Me.gpbRegistrarInspeccion.Controls.Add(Me.lblSolicitud)
        Me.gpbRegistrarInspeccion.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbRegistrarInspeccion.Location = New System.Drawing.Point(508, 34)
        Me.gpbRegistrarInspeccion.Name = "gpbRegistrarInspeccion"
        Me.gpbRegistrarInspeccion.Size = New System.Drawing.Size(492, 499)
        Me.gpbRegistrarInspeccion.TabIndex = 4
        Me.gpbRegistrarInspeccion.TabStop = False
        Me.gpbRegistrarInspeccion.Text = "Inspección"
        '
        'txtMonto
        '
        Me.txtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMonto.Location = New System.Drawing.Point(124, 404)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(124, 27)
        Me.txtMonto.TabIndex = 34
        Me.help.SetToolTip(Me.txtMonto, "4500")
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(30, 407)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(53, 19)
        Me.lblMonto.TabIndex = 33
        Me.lblMonto.Text = "Monto"
        '
        'pbImprimirRecibo
        '
        Me.pbImprimirRecibo.BackgroundImage = CType(resources.GetObject("pbImprimirRecibo.BackgroundImage"), System.Drawing.Image)
        Me.pbImprimirRecibo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbImprimirRecibo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbImprimirRecibo.Enabled = False
        Me.pbImprimirRecibo.Location = New System.Drawing.Point(298, 449)
        Me.pbImprimirRecibo.Name = "pbImprimirRecibo"
        Me.pbImprimirRecibo.Size = New System.Drawing.Size(30, 30)
        Me.pbImprimirRecibo.TabIndex = 32
        Me.pbImprimirRecibo.TabStop = False
        Me.help.SetToolTip(Me.pbImprimirRecibo, "Imprimir recibo")
        '
        'pbImprimir
        '
        Me.pbImprimir.BackgroundImage = CType(resources.GetObject("pbImprimir.BackgroundImage"), System.Drawing.Image)
        Me.pbImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbImprimir.Enabled = False
        Me.pbImprimir.Location = New System.Drawing.Point(344, 449)
        Me.pbImprimir.Name = "pbImprimir"
        Me.pbImprimir.Size = New System.Drawing.Size(30, 30)
        Me.pbImprimir.TabIndex = 26
        Me.pbImprimir.TabStop = False
        Me.help.SetToolTip(Me.pbImprimir, "Imprimir")
        '
        'pbLimpiar
        '
        Me.pbLimpiar.BackgroundImage = CType(resources.GetObject("pbLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.pbLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbLimpiar.Location = New System.Drawing.Point(443, 449)
        Me.pbLimpiar.Name = "pbLimpiar"
        Me.pbLimpiar.Size = New System.Drawing.Size(30, 30)
        Me.pbLimpiar.TabIndex = 31
        Me.pbLimpiar.TabStop = False
        Me.help.SetToolTip(Me.pbLimpiar, "Limpiar")
        '
        'pbRegistrar
        '
        Me.pbRegistrar.BackgroundImage = CType(resources.GetObject("pbRegistrar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegistrar.Location = New System.Drawing.Point(396, 449)
        Me.pbRegistrar.Name = "pbRegistrar"
        Me.pbRegistrar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegistrar.TabIndex = 30
        Me.pbRegistrar.TabStop = False
        Me.help.SetToolTip(Me.pbRegistrar, "Registrar")
        '
        'ltbFeria
        '
        Me.ltbFeria.FormattingEnabled = True
        Me.ltbFeria.ItemHeight = 19
        Me.ltbFeria.Location = New System.Drawing.Point(174, 252)
        Me.ltbFeria.Name = "ltbFeria"
        Me.ltbFeria.Size = New System.Drawing.Size(252, 137)
        Me.ltbFeria.TabIndex = 29
        '
        'lblFeriaAsiste
        '
        Me.lblFeriaAsiste.AutoSize = True
        Me.lblFeriaAsiste.Location = New System.Drawing.Point(30, 252)
        Me.lblFeriaAsiste.Name = "lblFeriaAsiste"
        Me.lblFeriaAsiste.Size = New System.Drawing.Size(87, 19)
        Me.lblFeriaAsiste.TabIndex = 28
        Me.lblFeriaAsiste.Text = "Feria asiste"
        '
        'dtpFechaVence
        '
        Me.dtpFechaVence.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVence.Location = New System.Drawing.Point(359, 207)
        Me.dtpFechaVence.Name = "dtpFechaVence"
        Me.dtpFechaVence.Size = New System.Drawing.Size(123, 27)
        Me.dtpFechaVence.TabIndex = 27
        '
        'lblFechaVencePermiso
        '
        Me.lblFechaVencePermiso.AutoSize = True
        Me.lblFechaVencePermiso.Location = New System.Drawing.Point(254, 210)
        Me.lblFechaVencePermiso.Name = "lblFechaVencePermiso"
        Me.lblFechaVencePermiso.Size = New System.Drawing.Size(99, 19)
        Me.lblFechaVencePermiso.TabIndex = 26
        Me.lblFechaVencePermiso.Text = "Fecha vence "
        '
        'dtpFechaCrea
        '
        Me.dtpFechaCrea.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCrea.Location = New System.Drawing.Point(124, 210)
        Me.dtpFechaCrea.Name = "dtpFechaCrea"
        Me.dtpFechaCrea.Size = New System.Drawing.Size(124, 27)
        Me.dtpFechaCrea.TabIndex = 25
        '
        'lblFechaCreaPermiso
        '
        Me.lblFechaCreaPermiso.AutoSize = True
        Me.lblFechaCreaPermiso.Location = New System.Drawing.Point(30, 213)
        Me.lblFechaCreaPermiso.Name = "lblFechaCreaPermiso"
        Me.lblFechaCreaPermiso.Size = New System.Drawing.Size(88, 19)
        Me.lblFechaCreaPermiso.TabIndex = 24
        Me.lblFechaCreaPermiso.Text = "Fecha crea "
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(175, 78)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(302, 27)
        Me.txtNombre.TabIndex = 19
        '
        'txtDireccionFinca
        '
        Me.txtDireccionFinca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccionFinca.Location = New System.Drawing.Point(34, 143)
        Me.txtDireccionFinca.Multiline = True
        Me.txtDireccionFinca.Name = "txtDireccionFinca"
        Me.txtDireccionFinca.Size = New System.Drawing.Size(443, 57)
        Me.txtDireccionFinca.TabIndex = 18
        '
        'lblDireccionFinca
        '
        Me.lblDireccionFinca.AutoSize = True
        Me.lblDireccionFinca.Location = New System.Drawing.Point(30, 121)
        Me.lblDireccionFinca.Name = "lblDireccionFinca"
        Me.lblDireccionFinca.Size = New System.Drawing.Size(112, 19)
        Me.lblDireccionFinca.TabIndex = 17
        Me.lblDireccionFinca.Text = "Dirección finca"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(30, 81)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(136, 19)
        Me.lblNombre.TabIndex = 16
        Me.lblNombre.Text = "Nombre completo"
        '
        'txtSolicitud
        '
        Me.txtSolicitud.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSolicitud.Location = New System.Drawing.Point(175, 33)
        Me.txtSolicitud.Name = "txtSolicitud"
        Me.txtSolicitud.Size = New System.Drawing.Size(302, 27)
        Me.txtSolicitud.TabIndex = 1
        '
        'lblSolicitud
        '
        Me.lblSolicitud.AutoSize = True
        Me.lblSolicitud.Location = New System.Drawing.Point(30, 41)
        Me.lblSolicitud.Name = "lblSolicitud"
        Me.lblSolicitud.Size = New System.Drawing.Size(69, 19)
        Me.lblSolicitud.TabIndex = 0
        Me.lblSolicitud.Text = "Solicitud"
        '
        'gpbBuscarSocio
        '
        Me.gpbBuscarSocio.Controls.Add(Me.lblCriterio)
        Me.gpbBuscarSocio.Controls.Add(Me.dgvDatos)
        Me.gpbBuscarSocio.Controls.Add(Me.txtCriterio)
        Me.gpbBuscarSocio.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBuscarSocio.Location = New System.Drawing.Point(3, 34)
        Me.gpbBuscarSocio.Name = "gpbBuscarSocio"
        Me.gpbBuscarSocio.Size = New System.Drawing.Size(499, 499)
        Me.gpbBuscarSocio.TabIndex = 3
        Me.gpbBuscarSocio.TabStop = False
        Me.gpbBuscarSocio.Text = "Buscar Socio"
        '
        'lblCriterio
        '
        Me.lblCriterio.AutoSize = True
        Me.lblCriterio.Location = New System.Drawing.Point(26, 54)
        Me.lblCriterio.Name = "lblCriterio"
        Me.lblCriterio.Size = New System.Drawing.Size(134, 19)
        Me.lblCriterio.TabIndex = 12
        Me.lblCriterio.Text = "Criterio búsqueda"
        '
        'dgvDatos
        '
        Me.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDatos.BackgroundColor = System.Drawing.Color.White
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Location = New System.Drawing.Point(6, 121)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.RowHeadersVisible = False
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(487, 348)
        Me.dgvDatos.TabIndex = 3
        '
        'txtCriterio
        '
        Me.txtCriterio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCriterio.Location = New System.Drawing.Point(166, 51)
        Me.txtCriterio.Name = "txtCriterio"
        Me.txtCriterio.Size = New System.Drawing.Size(234, 27)
        Me.txtCriterio.TabIndex = 2
        Me.help.SetToolTip(Me.txtCriterio, "301920349 o SOLANO QUESADA DANIEL")
        '
        'ctlRegistrarInspeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlRegistrarInspeccion"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbRegistrarInspeccion.ResumeLayout(False)
        Me.gpbRegistrarInspeccion.PerformLayout()
        CType(Me.pbImprimirRecibo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbBuscarSocio.ResumeLayout(False)
        Me.gpbBuscarSocio.PerformLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gpbBuscarSocio As System.Windows.Forms.GroupBox
    Friend WithEvents lblCriterio As System.Windows.Forms.Label
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents txtCriterio As System.Windows.Forms.TextBox
    Friend WithEvents gpbRegistrarInspeccion As System.Windows.Forms.GroupBox
    Friend WithEvents lblSolicitud As System.Windows.Forms.Label
    Friend WithEvents txtSolicitud As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccionFinca As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccionFinca As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents ltbFeria As System.Windows.Forms.ListBox
    Friend WithEvents lblFeriaAsiste As System.Windows.Forms.Label
    Friend WithEvents dtpFechaVence As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaVencePermiso As System.Windows.Forms.Label
    Friend WithEvents dtpFechaCrea As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaCreaPermiso As System.Windows.Forms.Label
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents pbRegistrar As System.Windows.Forms.PictureBox
    Friend WithEvents pbLimpiar As System.Windows.Forms.PictureBox
    Friend WithEvents pbRegresar As System.Windows.Forms.PictureBox
    Friend WithEvents pbImprimir As System.Windows.Forms.PictureBox
    Friend WithEvents inspeccion1 As InterfazGrafica.Inspeccion
    Friend WithEvents pbImprimirRecibo As System.Windows.Forms.PictureBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents lblMonto As System.Windows.Forms.Label

End Class
