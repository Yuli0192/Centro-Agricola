<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlRegistrarPermiso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlRegistrarPermiso))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pbRegresar = New System.Windows.Forms.PictureBox
        Me.gpbBuscarSocio = New System.Windows.Forms.GroupBox
        Me.lblCriterio = New System.Windows.Forms.Label
        Me.dgvDatos = New System.Windows.Forms.DataGridView
        Me.txtCriterio = New System.Windows.Forms.TextBox
        Me.gpbPermiso = New System.Windows.Forms.GroupBox
        Me.pbImprimir = New System.Windows.Forms.PictureBox
        Me.pbLimpiar = New System.Windows.Forms.PictureBox
        Me.gpbProducto = New System.Windows.Forms.GroupBox
        Me.lblProductoAsignado = New System.Windows.Forms.Label
        Me.ltbProductoAsignado = New System.Windows.Forms.ListBox
        Me.pbQuitar = New System.Windows.Forms.PictureBox
        Me.pbInsertar = New System.Windows.Forms.PictureBox
        Me.ltbProducto = New System.Windows.Forms.ListBox
        Me.lblProducto = New System.Windows.Forms.Label
        Me.pbRegistrar = New System.Windows.Forms.PictureBox
        Me.dtpFechaVence = New System.Windows.Forms.DateTimePicker
        Me.lblFechaVencePermiso = New System.Windows.Forms.Label
        Me.dtpFechaCrea = New System.Windows.Forms.DateTimePicker
        Me.lblFechaCreaPermiso = New System.Windows.Forms.Label
        Me.txtDireccionFinca = New System.Windows.Forms.TextBox
        Me.lblDireccionFinca = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.permisoSocio1 = New InterfazGrafica.PermisoSocio
        Me.txtNombreBuscar = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbBuscarSocio.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbPermiso.SuspendLayout()
        CType(Me.pbImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbProducto.SuspendLayout()
        CType(Me.pbQuitar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbInsertar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbRegresar)
        Me.Panel1.Controls.Add(Me.gpbBuscarSocio)
        Me.Panel1.Controls.Add(Me.gpbPermiso)
        Me.Panel1.Location = New System.Drawing.Point(0, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1021, 564)
        Me.Panel1.TabIndex = 0
        '
        'pbRegresar
        '
        Me.pbRegresar.BackgroundImage = CType(resources.GetObject("pbRegresar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresar.Location = New System.Drawing.Point(979, 22)
        Me.pbRegresar.Name = "pbRegresar"
        Me.pbRegresar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegresar.TabIndex = 10
        Me.pbRegresar.TabStop = False
        Me.help.SetToolTip(Me.pbRegresar, "Regresar")
        '
        'gpbBuscarSocio
        '
        Me.gpbBuscarSocio.Controls.Add(Me.lblCriterio)
        Me.gpbBuscarSocio.Controls.Add(Me.dgvDatos)
        Me.gpbBuscarSocio.Controls.Add(Me.txtCriterio)
        Me.gpbBuscarSocio.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBuscarSocio.Location = New System.Drawing.Point(12, 58)
        Me.gpbBuscarSocio.Name = "gpbBuscarSocio"
        Me.gpbBuscarSocio.Size = New System.Drawing.Size(498, 449)
        Me.gpbBuscarSocio.TabIndex = 2
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
        Me.dgvDatos.Size = New System.Drawing.Size(486, 294)
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
        'gpbPermiso
        '
        Me.gpbPermiso.Controls.Add(Me.pbImprimir)
        Me.gpbPermiso.Controls.Add(Me.pbLimpiar)
        Me.gpbPermiso.Controls.Add(Me.gpbProducto)
        Me.gpbPermiso.Controls.Add(Me.pbRegistrar)
        Me.gpbPermiso.Controls.Add(Me.dtpFechaVence)
        Me.gpbPermiso.Controls.Add(Me.lblFechaVencePermiso)
        Me.gpbPermiso.Controls.Add(Me.dtpFechaCrea)
        Me.gpbPermiso.Controls.Add(Me.lblFechaCreaPermiso)
        Me.gpbPermiso.Controls.Add(Me.txtDireccionFinca)
        Me.gpbPermiso.Controls.Add(Me.lblDireccionFinca)
        Me.gpbPermiso.Controls.Add(Me.txtNombre)
        Me.gpbPermiso.Controls.Add(Me.lblNombre)
        Me.gpbPermiso.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbPermiso.Location = New System.Drawing.Point(516, 58)
        Me.gpbPermiso.Name = "gpbPermiso"
        Me.gpbPermiso.Size = New System.Drawing.Size(493, 449)
        Me.gpbPermiso.TabIndex = 0
        Me.gpbPermiso.TabStop = False
        Me.gpbPermiso.Text = "Permiso"
        '
        'pbImprimir
        '
        Me.pbImprimir.BackgroundImage = CType(resources.GetObject("pbImprimir.BackgroundImage"), System.Drawing.Image)
        Me.pbImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbImprimir.Enabled = False
        Me.pbImprimir.Location = New System.Drawing.Point(354, 409)
        Me.pbImprimir.Name = "pbImprimir"
        Me.pbImprimir.Size = New System.Drawing.Size(30, 30)
        Me.pbImprimir.TabIndex = 25
        Me.pbImprimir.TabStop = False
        Me.help.SetToolTip(Me.pbImprimir, "Imprimir")
        '
        'pbLimpiar
        '
        Me.pbLimpiar.BackgroundImage = CType(resources.GetObject("pbLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.pbLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbLimpiar.Location = New System.Drawing.Point(442, 409)
        Me.pbLimpiar.Name = "pbLimpiar"
        Me.pbLimpiar.Size = New System.Drawing.Size(30, 30)
        Me.pbLimpiar.TabIndex = 24
        Me.pbLimpiar.TabStop = False
        Me.help.SetToolTip(Me.pbLimpiar, "Limpiar")
        '
        'gpbProducto
        '
        Me.gpbProducto.Controls.Add(Me.txtNombreBuscar)
        Me.gpbProducto.Controls.Add(Me.lblProductoAsignado)
        Me.gpbProducto.Controls.Add(Me.ltbProductoAsignado)
        Me.gpbProducto.Controls.Add(Me.pbQuitar)
        Me.gpbProducto.Controls.Add(Me.pbInsertar)
        Me.gpbProducto.Controls.Add(Me.ltbProducto)
        Me.gpbProducto.Controls.Add(Me.lblProducto)
        Me.gpbProducto.Location = New System.Drawing.Point(29, 163)
        Me.gpbProducto.Name = "gpbProducto"
        Me.gpbProducto.Size = New System.Drawing.Size(448, 240)
        Me.gpbProducto.TabIndex = 24
        Me.gpbProducto.TabStop = False
        Me.gpbProducto.Text = "Producto"
        '
        'lblProductoAsignado
        '
        Me.lblProductoAsignado.AutoSize = True
        Me.lblProductoAsignado.Location = New System.Drawing.Point(279, 23)
        Me.lblProductoAsignado.Name = "lblProductoAsignado"
        Me.lblProductoAsignado.Size = New System.Drawing.Size(140, 19)
        Me.lblProductoAsignado.TabIndex = 9
        Me.lblProductoAsignado.Text = "Producto asignado"
        '
        'ltbProductoAsignado
        '
        Me.ltbProductoAsignado.FormattingEnabled = True
        Me.ltbProductoAsignado.ItemHeight = 19
        Me.ltbProductoAsignado.Location = New System.Drawing.Point(254, 77)
        Me.ltbProductoAsignado.Name = "ltbProductoAsignado"
        Me.ltbProductoAsignado.Size = New System.Drawing.Size(187, 156)
        Me.ltbProductoAsignado.TabIndex = 8
        '
        'pbQuitar
        '
        Me.pbQuitar.BackgroundImage = CType(resources.GetObject("pbQuitar.BackgroundImage"), System.Drawing.Image)
        Me.pbQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbQuitar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbQuitar.Location = New System.Drawing.Point(218, 152)
        Me.pbQuitar.Name = "pbQuitar"
        Me.pbQuitar.Size = New System.Drawing.Size(30, 30)
        Me.pbQuitar.TabIndex = 7
        Me.pbQuitar.TabStop = False
        Me.help.SetToolTip(Me.pbQuitar, "Quitar producto al socio")
        '
        'pbInsertar
        '
        Me.pbInsertar.BackgroundImage = CType(resources.GetObject("pbInsertar.BackgroundImage"), System.Drawing.Image)
        Me.pbInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbInsertar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbInsertar.Location = New System.Drawing.Point(218, 116)
        Me.pbInsertar.Name = "pbInsertar"
        Me.pbInsertar.Size = New System.Drawing.Size(30, 30)
        Me.pbInsertar.TabIndex = 6
        Me.pbInsertar.TabStop = False
        Me.help.SetToolTip(Me.pbInsertar, "Asignar producto al socio")
        '
        'ltbProducto
        '
        Me.ltbProducto.FormattingEnabled = True
        Me.ltbProducto.ItemHeight = 19
        Me.ltbProducto.Location = New System.Drawing.Point(16, 77)
        Me.ltbProducto.Name = "ltbProducto"
        Me.ltbProducto.Size = New System.Drawing.Size(196, 156)
        Me.ltbProducto.TabIndex = 1
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(63, 23)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(72, 19)
        Me.lblProducto.TabIndex = 0
        Me.lblProducto.Text = "Producto"
        '
        'pbRegistrar
        '
        Me.pbRegistrar.BackgroundImage = CType(resources.GetObject("pbRegistrar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegistrar.Location = New System.Drawing.Point(395, 409)
        Me.pbRegistrar.Name = "pbRegistrar"
        Me.pbRegistrar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegistrar.TabIndex = 23
        Me.pbRegistrar.TabStop = False
        Me.help.SetToolTip(Me.pbRegistrar, "Registrar")
        '
        'dtpFechaVence
        '
        Me.dtpFechaVence.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVence.Location = New System.Drawing.Point(354, 127)
        Me.dtpFechaVence.Name = "dtpFechaVence"
        Me.dtpFechaVence.Size = New System.Drawing.Size(123, 27)
        Me.dtpFechaVence.TabIndex = 23
        '
        'lblFechaVencePermiso
        '
        Me.lblFechaVencePermiso.AutoSize = True
        Me.lblFechaVencePermiso.Location = New System.Drawing.Point(249, 130)
        Me.lblFechaVencePermiso.Name = "lblFechaVencePermiso"
        Me.lblFechaVencePermiso.Size = New System.Drawing.Size(99, 19)
        Me.lblFechaVencePermiso.TabIndex = 22
        Me.lblFechaVencePermiso.Text = "Fecha vence "
        '
        'dtpFechaCrea
        '
        Me.dtpFechaCrea.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCrea.Location = New System.Drawing.Point(119, 130)
        Me.dtpFechaCrea.Name = "dtpFechaCrea"
        Me.dtpFechaCrea.Size = New System.Drawing.Size(124, 27)
        Me.dtpFechaCrea.TabIndex = 21
        '
        'lblFechaCreaPermiso
        '
        Me.lblFechaCreaPermiso.AutoSize = True
        Me.lblFechaCreaPermiso.Location = New System.Drawing.Point(25, 133)
        Me.lblFechaCreaPermiso.Name = "lblFechaCreaPermiso"
        Me.lblFechaCreaPermiso.Size = New System.Drawing.Size(88, 19)
        Me.lblFechaCreaPermiso.TabIndex = 20
        Me.lblFechaCreaPermiso.Text = "Fecha crea "
        '
        'txtDireccionFinca
        '
        Me.txtDireccionFinca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccionFinca.Location = New System.Drawing.Point(29, 73)
        Me.txtDireccionFinca.Multiline = True
        Me.txtDireccionFinca.Name = "txtDireccionFinca"
        Me.txtDireccionFinca.Size = New System.Drawing.Size(448, 57)
        Me.txtDireccionFinca.TabIndex = 15
        '
        'lblDireccionFinca
        '
        Me.lblDireccionFinca.AutoSize = True
        Me.lblDireccionFinca.Location = New System.Drawing.Point(25, 51)
        Me.lblDireccionFinca.Name = "lblDireccionFinca"
        Me.lblDireccionFinca.Size = New System.Drawing.Size(115, 19)
        Me.lblDireccionFinca.TabIndex = 14
        Me.lblDireccionFinca.Text = "Dirección Finca"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(175, 23)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(302, 27)
        Me.txtNombre.TabIndex = 13
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(25, 23)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(139, 19)
        Me.lblNombre.TabIndex = 12
        Me.lblNombre.Text = "Nombre Completo"
        '
        'txtNombreBuscar
        '
        Me.txtNombreBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreBuscar.Location = New System.Drawing.Point(16, 45)
        Me.txtNombreBuscar.Name = "txtNombreBuscar"
        Me.txtNombreBuscar.Size = New System.Drawing.Size(198, 27)
        Me.txtNombreBuscar.TabIndex = 11
        Me.help.SetToolTip(Me.txtNombreBuscar, "Papa")
        '
        'ctlRegistrarPermiso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlRegistrarPermiso"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbBuscarSocio.ResumeLayout(False)
        Me.gpbBuscarSocio.PerformLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbPermiso.ResumeLayout(False)
        Me.gpbPermiso.PerformLayout()
        CType(Me.pbImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbProducto.ResumeLayout(False)
        Me.gpbProducto.PerformLayout()
        CType(Me.pbQuitar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbInsertar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gpbPermiso As System.Windows.Forms.GroupBox
    Friend WithEvents gpbBuscarSocio As System.Windows.Forms.GroupBox
    Friend WithEvents lblCriterio As System.Windows.Forms.Label
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents txtCriterio As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccionFinca As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccionFinca As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents dtpFechaVence As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaVencePermiso As System.Windows.Forms.Label
    Friend WithEvents dtpFechaCrea As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaCreaPermiso As System.Windows.Forms.Label
    Friend WithEvents gpbProducto As System.Windows.Forms.GroupBox
    Friend WithEvents ltbProducto As System.Windows.Forms.ListBox
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents ltbProductoAsignado As System.Windows.Forms.ListBox
    Friend WithEvents pbQuitar As System.Windows.Forms.PictureBox
    Friend WithEvents pbInsertar As System.Windows.Forms.PictureBox
    Friend WithEvents lblProductoAsignado As System.Windows.Forms.Label
    Friend WithEvents pbLimpiar As System.Windows.Forms.PictureBox
    Friend WithEvents pbRegistrar As System.Windows.Forms.PictureBox
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents pbRegresar As System.Windows.Forms.PictureBox
    Friend WithEvents pbImprimir As System.Windows.Forms.PictureBox
    Friend WithEvents permisoSocio1 As InterfazGrafica.PermisoSocio
    Friend WithEvents txtNombreBuscar As System.Windows.Forms.TextBox

End Class
