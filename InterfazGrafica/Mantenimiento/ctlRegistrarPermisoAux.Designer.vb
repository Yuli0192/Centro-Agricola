<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlRegistrarPermisoAux
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlRegistrarPermisoAux))
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtCriterio = New System.Windows.Forms.TextBox
        Me.txtNombreBuscar = New System.Windows.Forms.TextBox
        Me.pbImprimir = New System.Windows.Forms.PictureBox
        Me.pbLimpiar = New System.Windows.Forms.PictureBox
        Me.pbQuitar = New System.Windows.Forms.PictureBox
        Me.pbInsertar = New System.Windows.Forms.PictureBox
        Me.pbRegistrar = New System.Windows.Forms.PictureBox
        Me.pbRegresar = New System.Windows.Forms.PictureBox
        Me.txtCriterioSocio = New System.Windows.Forms.TextBox
        Me.gpbBuscarAux = New System.Windows.Forms.GroupBox
        Me.lblCriterio = New System.Windows.Forms.Label
        Me.dgvDatos = New System.Windows.Forms.DataGridView
        Me.gpbPermiso = New System.Windows.Forms.GroupBox
        Me.txtCodigoAux = New System.Windows.Forms.TextBox
        Me.lblCodigoAux = New System.Windows.Forms.Label
        Me.txtCodigoSocio = New System.Windows.Forms.TextBox
        Me.lblCodigoSocio = New System.Windows.Forms.Label
        Me.txtNombreSocio = New System.Windows.Forms.TextBox
        Me.lblNombreSocio = New System.Windows.Forms.Label
        Me.gpbProducto = New System.Windows.Forms.GroupBox
        Me.lblProductoAsignado = New System.Windows.Forms.Label
        Me.ltbProductoAsignado = New System.Windows.Forms.ListBox
        Me.ltbProducto = New System.Windows.Forms.ListBox
        Me.lblProducto = New System.Windows.Forms.Label
        Me.dtpFechaVence = New System.Windows.Forms.DateTimePicker
        Me.lblFechaVencePermiso = New System.Windows.Forms.Label
        Me.dtpFechaCrea = New System.Windows.Forms.DateTimePicker
        Me.lblFechaCreaPermiso = New System.Windows.Forms.Label
        Me.txtNombreAux = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.gpbBuscarSocio = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgvDatosSocio = New System.Windows.Forms.DataGridView
        CType(Me.pbImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbQuitar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbInsertar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbBuscarAux.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbPermiso.SuspendLayout()
        Me.gpbProducto.SuspendLayout()
        Me.gpbBuscarSocio.SuspendLayout()
        CType(Me.dgvDatosSocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCriterio
        '
        Me.txtCriterio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCriterio.Location = New System.Drawing.Point(163, 23)
        Me.txtCriterio.Name = "txtCriterio"
        Me.txtCriterio.Size = New System.Drawing.Size(234, 27)
        Me.txtCriterio.TabIndex = 2
        Me.help.SetToolTip(Me.txtCriterio, "301920349 o SOLANO QUESADA DANIEL")
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
        'pbImprimir
        '
        Me.pbImprimir.BackgroundImage = CType(resources.GetObject("pbImprimir.BackgroundImage"), System.Drawing.Image)
        Me.pbImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbImprimir.Enabled = False
        Me.pbImprimir.Location = New System.Drawing.Point(354, 481)
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
        Me.pbLimpiar.Location = New System.Drawing.Point(442, 481)
        Me.pbLimpiar.Name = "pbLimpiar"
        Me.pbLimpiar.Size = New System.Drawing.Size(30, 30)
        Me.pbLimpiar.TabIndex = 24
        Me.pbLimpiar.TabStop = False
        Me.help.SetToolTip(Me.pbLimpiar, "Limpiar")
        '
        'pbQuitar
        '
        Me.pbQuitar.BackgroundImage = CType(resources.GetObject("pbQuitar.BackgroundImage"), System.Drawing.Image)
        Me.pbQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbQuitar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbQuitar.Location = New System.Drawing.Point(218, 181)
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
        Me.pbInsertar.Location = New System.Drawing.Point(218, 131)
        Me.pbInsertar.Name = "pbInsertar"
        Me.pbInsertar.Size = New System.Drawing.Size(30, 30)
        Me.pbInsertar.TabIndex = 6
        Me.pbInsertar.TabStop = False
        Me.help.SetToolTip(Me.pbInsertar, "Asignar producto al socio")
        '
        'pbRegistrar
        '
        Me.pbRegistrar.BackgroundImage = CType(resources.GetObject("pbRegistrar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegistrar.Location = New System.Drawing.Point(395, 481)
        Me.pbRegistrar.Name = "pbRegistrar"
        Me.pbRegistrar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegistrar.TabIndex = 23
        Me.pbRegistrar.TabStop = False
        Me.help.SetToolTip(Me.pbRegistrar, "Registrar")
        '
        'pbRegresar
        '
        Me.pbRegresar.BackgroundImage = CType(resources.GetObject("pbRegresar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresar.Location = New System.Drawing.Point(981, 90)
        Me.pbRegresar.Name = "pbRegresar"
        Me.pbRegresar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegresar.TabIndex = 11
        Me.pbRegresar.TabStop = False
        Me.help.SetToolTip(Me.pbRegresar, "Regresar")
        '
        'txtCriterioSocio
        '
        Me.txtCriterioSocio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCriterioSocio.Location = New System.Drawing.Point(163, 20)
        Me.txtCriterioSocio.Name = "txtCriterioSocio"
        Me.txtCriterioSocio.Size = New System.Drawing.Size(234, 27)
        Me.txtCriterioSocio.TabIndex = 2
        Me.help.SetToolTip(Me.txtCriterioSocio, "301920349 o SOLANO QUESADA DANIEL")
        '
        'gpbBuscarAux
        '
        Me.gpbBuscarAux.Controls.Add(Me.lblCriterio)
        Me.gpbBuscarAux.Controls.Add(Me.dgvDatos)
        Me.gpbBuscarAux.Controls.Add(Me.txtCriterio)
        Me.gpbBuscarAux.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBuscarAux.Location = New System.Drawing.Point(14, 411)
        Me.gpbBuscarAux.Name = "gpbBuscarAux"
        Me.gpbBuscarAux.Size = New System.Drawing.Size(498, 271)
        Me.gpbBuscarAux.TabIndex = 4
        Me.gpbBuscarAux.TabStop = False
        Me.gpbBuscarAux.Text = "Buscar Auxiliar"
        '
        'lblCriterio
        '
        Me.lblCriterio.AutoSize = True
        Me.lblCriterio.Location = New System.Drawing.Point(23, 26)
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
        Me.dgvDatos.Location = New System.Drawing.Point(6, 56)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.RowHeadersVisible = False
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(486, 209)
        Me.dgvDatos.TabIndex = 3
        '
        'gpbPermiso
        '
        Me.gpbPermiso.Controls.Add(Me.txtCodigoAux)
        Me.gpbPermiso.Controls.Add(Me.lblCodigoAux)
        Me.gpbPermiso.Controls.Add(Me.txtCodigoSocio)
        Me.gpbPermiso.Controls.Add(Me.lblCodigoSocio)
        Me.gpbPermiso.Controls.Add(Me.txtNombreSocio)
        Me.gpbPermiso.Controls.Add(Me.lblNombreSocio)
        Me.gpbPermiso.Controls.Add(Me.pbImprimir)
        Me.gpbPermiso.Controls.Add(Me.pbLimpiar)
        Me.gpbPermiso.Controls.Add(Me.gpbProducto)
        Me.gpbPermiso.Controls.Add(Me.pbRegistrar)
        Me.gpbPermiso.Controls.Add(Me.dtpFechaVence)
        Me.gpbPermiso.Controls.Add(Me.lblFechaVencePermiso)
        Me.gpbPermiso.Controls.Add(Me.dtpFechaCrea)
        Me.gpbPermiso.Controls.Add(Me.lblFechaCreaPermiso)
        Me.gpbPermiso.Controls.Add(Me.txtNombreAux)
        Me.gpbPermiso.Controls.Add(Me.lblNombre)
        Me.gpbPermiso.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbPermiso.Location = New System.Drawing.Point(518, 111)
        Me.gpbPermiso.Name = "gpbPermiso"
        Me.gpbPermiso.Size = New System.Drawing.Size(493, 529)
        Me.gpbPermiso.TabIndex = 3
        Me.gpbPermiso.TabStop = False
        Me.gpbPermiso.Text = "Permiso"
        '
        'txtCodigoAux
        '
        Me.txtCodigoAux.Location = New System.Drawing.Point(175, 97)
        Me.txtCodigoAux.Name = "txtCodigoAux"
        Me.txtCodigoAux.Size = New System.Drawing.Size(207, 27)
        Me.txtCodigoAux.TabIndex = 31
        '
        'lblCodigoAux
        '
        Me.lblCodigoAux.AutoSize = True
        Me.lblCodigoAux.Location = New System.Drawing.Point(25, 100)
        Me.lblCodigoAux.Name = "lblCodigoAux"
        Me.lblCodigoAux.Size = New System.Drawing.Size(118, 19)
        Me.lblCodigoAux.TabIndex = 30
        Me.lblCodigoAux.Text = "Código Auxiliar"
        '
        'txtCodigoSocio
        '
        Me.txtCodigoSocio.Location = New System.Drawing.Point(175, 28)
        Me.txtCodigoSocio.Name = "txtCodigoSocio"
        Me.txtCodigoSocio.Size = New System.Drawing.Size(207, 27)
        Me.txtCodigoSocio.TabIndex = 29
        '
        'lblCodigoSocio
        '
        Me.lblCodigoSocio.AutoSize = True
        Me.lblCodigoSocio.Location = New System.Drawing.Point(25, 31)
        Me.lblCodigoSocio.Name = "lblCodigoSocio"
        Me.lblCodigoSocio.Size = New System.Drawing.Size(102, 19)
        Me.lblCodigoSocio.TabIndex = 28
        Me.lblCodigoSocio.Text = "Código Socio"
        '
        'txtNombreSocio
        '
        Me.txtNombreSocio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreSocio.Location = New System.Drawing.Point(175, 65)
        Me.txtNombreSocio.Name = "txtNombreSocio"
        Me.txtNombreSocio.Size = New System.Drawing.Size(302, 27)
        Me.txtNombreSocio.TabIndex = 27
        '
        'lblNombreSocio
        '
        Me.lblNombreSocio.AutoSize = True
        Me.lblNombreSocio.Location = New System.Drawing.Point(25, 65)
        Me.lblNombreSocio.Name = "lblNombreSocio"
        Me.lblNombreSocio.Size = New System.Drawing.Size(109, 19)
        Me.lblNombreSocio.TabIndex = 26
        Me.lblNombreSocio.Text = "Nombre Socio"
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
        Me.gpbProducto.Location = New System.Drawing.Point(29, 193)
        Me.gpbProducto.Name = "gpbProducto"
        Me.gpbProducto.Size = New System.Drawing.Size(448, 282)
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
        Me.ltbProductoAsignado.Size = New System.Drawing.Size(187, 194)
        Me.ltbProductoAsignado.TabIndex = 8
        '
        'ltbProducto
        '
        Me.ltbProducto.FormattingEnabled = True
        Me.ltbProducto.ItemHeight = 19
        Me.ltbProducto.Location = New System.Drawing.Point(16, 77)
        Me.ltbProducto.Name = "ltbProducto"
        Me.ltbProducto.Size = New System.Drawing.Size(196, 194)
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
        'dtpFechaVence
        '
        Me.dtpFechaVence.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVence.Location = New System.Drawing.Point(354, 165)
        Me.dtpFechaVence.Name = "dtpFechaVence"
        Me.dtpFechaVence.Size = New System.Drawing.Size(123, 27)
        Me.dtpFechaVence.TabIndex = 23
        '
        'lblFechaVencePermiso
        '
        Me.lblFechaVencePermiso.AutoSize = True
        Me.lblFechaVencePermiso.Location = New System.Drawing.Point(249, 168)
        Me.lblFechaVencePermiso.Name = "lblFechaVencePermiso"
        Me.lblFechaVencePermiso.Size = New System.Drawing.Size(99, 19)
        Me.lblFechaVencePermiso.TabIndex = 22
        Me.lblFechaVencePermiso.Text = "Fecha vence "
        '
        'dtpFechaCrea
        '
        Me.dtpFechaCrea.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCrea.Location = New System.Drawing.Point(119, 168)
        Me.dtpFechaCrea.Name = "dtpFechaCrea"
        Me.dtpFechaCrea.Size = New System.Drawing.Size(124, 27)
        Me.dtpFechaCrea.TabIndex = 21
        '
        'lblFechaCreaPermiso
        '
        Me.lblFechaCreaPermiso.AutoSize = True
        Me.lblFechaCreaPermiso.Location = New System.Drawing.Point(25, 171)
        Me.lblFechaCreaPermiso.Name = "lblFechaCreaPermiso"
        Me.lblFechaCreaPermiso.Size = New System.Drawing.Size(88, 19)
        Me.lblFechaCreaPermiso.TabIndex = 20
        Me.lblFechaCreaPermiso.Text = "Fecha crea "
        '
        'txtNombreAux
        '
        Me.txtNombreAux.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreAux.Location = New System.Drawing.Point(175, 134)
        Me.txtNombreAux.Name = "txtNombreAux"
        Me.txtNombreAux.Size = New System.Drawing.Size(302, 27)
        Me.txtNombreAux.TabIndex = 13
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(25, 134)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(125, 19)
        Me.lblNombre.TabIndex = 12
        Me.lblNombre.Text = "Nombre Auxiliar"
        '
        'gpbBuscarSocio
        '
        Me.gpbBuscarSocio.Controls.Add(Me.Label1)
        Me.gpbBuscarSocio.Controls.Add(Me.dgvDatosSocio)
        Me.gpbBuscarSocio.Controls.Add(Me.txtCriterioSocio)
        Me.gpbBuscarSocio.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBuscarSocio.Location = New System.Drawing.Point(14, 111)
        Me.gpbBuscarSocio.Name = "gpbBuscarSocio"
        Me.gpbBuscarSocio.Size = New System.Drawing.Size(498, 294)
        Me.gpbBuscarSocio.TabIndex = 12
        Me.gpbBuscarSocio.TabStop = False
        Me.gpbBuscarSocio.Text = "Buscar Socio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Criterio búsqueda"
        '
        'dgvDatosSocio
        '
        Me.dgvDatosSocio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDatosSocio.BackgroundColor = System.Drawing.Color.White
        Me.dgvDatosSocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatosSocio.Location = New System.Drawing.Point(6, 53)
        Me.dgvDatosSocio.Name = "dgvDatosSocio"
        Me.dgvDatosSocio.ReadOnly = True
        Me.dgvDatosSocio.RowHeadersVisible = False
        Me.dgvDatosSocio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatosSocio.Size = New System.Drawing.Size(486, 235)
        Me.dgvDatosSocio.TabIndex = 3
        '
        'ctlRegistrarPermisoAux
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.gpbBuscarSocio)
        Me.Controls.Add(Me.pbRegresar)
        Me.Controls.Add(Me.gpbBuscarAux)
        Me.Controls.Add(Me.gpbPermiso)
        Me.Name = "ctlRegistrarPermisoAux"
        Me.Size = New System.Drawing.Size(1024, 700)
        CType(Me.pbImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbQuitar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbInsertar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbBuscarAux.ResumeLayout(False)
        Me.gpbBuscarAux.PerformLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbPermiso.ResumeLayout(False)
        Me.gpbPermiso.PerformLayout()
        Me.gpbProducto.ResumeLayout(False)
        Me.gpbProducto.PerformLayout()
        Me.gpbBuscarSocio.ResumeLayout(False)
        Me.gpbBuscarSocio.PerformLayout()
        CType(Me.dgvDatosSocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents gpbBuscarAux As System.Windows.Forms.GroupBox
    Friend WithEvents lblCriterio As System.Windows.Forms.Label
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents txtCriterio As System.Windows.Forms.TextBox
    Friend WithEvents gpbPermiso As System.Windows.Forms.GroupBox
    Friend WithEvents pbImprimir As System.Windows.Forms.PictureBox
    Friend WithEvents pbLimpiar As System.Windows.Forms.PictureBox
    Friend WithEvents gpbProducto As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombreBuscar As System.Windows.Forms.TextBox
    Friend WithEvents lblProductoAsignado As System.Windows.Forms.Label
    Friend WithEvents ltbProductoAsignado As System.Windows.Forms.ListBox
    Friend WithEvents pbQuitar As System.Windows.Forms.PictureBox
    Friend WithEvents pbInsertar As System.Windows.Forms.PictureBox
    Friend WithEvents ltbProducto As System.Windows.Forms.ListBox
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents pbRegistrar As System.Windows.Forms.PictureBox
    Friend WithEvents dtpFechaVence As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaVencePermiso As System.Windows.Forms.Label
    Friend WithEvents dtpFechaCrea As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaCreaPermiso As System.Windows.Forms.Label
    Friend WithEvents txtNombreAux As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents pbRegresar As System.Windows.Forms.PictureBox
    Friend WithEvents txtCodigoSocio As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigoSocio As System.Windows.Forms.Label
    Friend WithEvents txtNombreSocio As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreSocio As System.Windows.Forms.Label
    Friend WithEvents txtCodigoAux As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigoAux As System.Windows.Forms.Label
    Friend WithEvents gpbBuscarSocio As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvDatosSocio As System.Windows.Forms.DataGridView
    Friend WithEvents txtCriterioSocio As System.Windows.Forms.TextBox

End Class
