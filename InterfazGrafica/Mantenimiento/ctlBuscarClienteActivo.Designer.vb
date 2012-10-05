<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlBuscarClienteActivo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlBuscarClienteActivo))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pbRegresar = New System.Windows.Forms.PictureBox
        Me.gpbModificarCliente = New System.Windows.Forms.GroupBox
        Me.pbConfirmar = New System.Windows.Forms.PictureBox
        Me.txtFechaIngreso = New System.Windows.Forms.TextBox
        Me.lblFechaIngreso = New System.Windows.Forms.Label
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.lblTelefono = New System.Windows.Forms.Label
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.lblDireccion = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.txtCedula = New System.Windows.Forms.TextBox
        Me.lblCedula = New System.Windows.Forms.Label
        Me.gpbBuscarCliente = New System.Windows.Forms.GroupBox
        Me.lblCriterio = New System.Windows.Forms.Label
        Me.pbModificar = New System.Windows.Forms.PictureBox
        Me.pbEliminar = New System.Windows.Forms.PictureBox
        Me.dgvDatos = New System.Windows.Forms.DataGridView
        Me.txtCriterio = New System.Windows.Forms.TextBox
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbModificarCliente.SuspendLayout()
        CType(Me.pbConfirmar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbBuscarCliente.SuspendLayout()
        CType(Me.pbModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbRegresar)
        Me.Panel1.Controls.Add(Me.gpbModificarCliente)
        Me.Panel1.Controls.Add(Me.gpbBuscarCliente)
        Me.Panel1.Location = New System.Drawing.Point(3, 116)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1018, 559)
        Me.Panel1.TabIndex = 0
        '
        'pbRegresar
        '
        Me.pbRegresar.BackgroundImage = CType(resources.GetObject("pbRegresar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresar.Location = New System.Drawing.Point(976, 3)
        Me.pbRegresar.Name = "pbRegresar"
        Me.pbRegresar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegresar.TabIndex = 30
        Me.pbRegresar.TabStop = False
        Me.help.SetToolTip(Me.pbRegresar, "Regresar")
        '
        'gpbModificarCliente
        '
        Me.gpbModificarCliente.Controls.Add(Me.pbConfirmar)
        Me.gpbModificarCliente.Controls.Add(Me.txtFechaIngreso)
        Me.gpbModificarCliente.Controls.Add(Me.lblFechaIngreso)
        Me.gpbModificarCliente.Controls.Add(Me.txtTelefono)
        Me.gpbModificarCliente.Controls.Add(Me.lblTelefono)
        Me.gpbModificarCliente.Controls.Add(Me.txtDireccion)
        Me.gpbModificarCliente.Controls.Add(Me.lblDireccion)
        Me.gpbModificarCliente.Controls.Add(Me.txtNombre)
        Me.gpbModificarCliente.Controls.Add(Me.lblNombre)
        Me.gpbModificarCliente.Controls.Add(Me.txtCedula)
        Me.gpbModificarCliente.Controls.Add(Me.lblCedula)
        Me.gpbModificarCliente.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbModificarCliente.Location = New System.Drawing.Point(540, 32)
        Me.gpbModificarCliente.Name = "gpbModificarCliente"
        Me.gpbModificarCliente.Size = New System.Drawing.Size(466, 386)
        Me.gpbModificarCliente.TabIndex = 2
        Me.gpbModificarCliente.TabStop = False
        Me.gpbModificarCliente.Text = "Modificar Cliente"
        Me.gpbModificarCliente.Visible = False
        '
        'pbConfirmar
        '
        Me.pbConfirmar.BackgroundImage = CType(resources.GetObject("pbConfirmar.BackgroundImage"), System.Drawing.Image)
        Me.pbConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbConfirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbConfirmar.Location = New System.Drawing.Point(404, 297)
        Me.pbConfirmar.Name = "pbConfirmar"
        Me.pbConfirmar.Size = New System.Drawing.Size(30, 30)
        Me.pbConfirmar.TabIndex = 29
        Me.pbConfirmar.TabStop = False
        Me.help.SetToolTip(Me.pbConfirmar, "Confirmar modificación")
        '
        'txtFechaIngreso
        '
        Me.txtFechaIngreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFechaIngreso.Enabled = False
        Me.txtFechaIngreso.Location = New System.Drawing.Point(193, 248)
        Me.txtFechaIngreso.Name = "txtFechaIngreso"
        Me.txtFechaIngreso.Size = New System.Drawing.Size(241, 27)
        Me.txtFechaIngreso.TabIndex = 24
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.AutoSize = True
        Me.lblFechaIngreso.Location = New System.Drawing.Point(43, 251)
        Me.lblFechaIngreso.Name = "lblFechaIngreso"
        Me.lblFechaIngreso.Size = New System.Drawing.Size(106, 19)
        Me.lblFechaIngreso.TabIndex = 23
        Me.lblFechaIngreso.Text = "Fecha ingreso"
        '
        'txtTelefono
        '
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefono.Location = New System.Drawing.Point(193, 123)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(241, 27)
        Me.txtTelefono.TabIndex = 9
        Me.help.SetToolTip(Me.txtTelefono, "2574-0000")
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(43, 126)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(71, 19)
        Me.lblTelefono.TabIndex = 8
        Me.lblTelefono.Text = "Teléfono"
        '
        'txtDireccion
        '
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Location = New System.Drawing.Point(47, 184)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(387, 53)
        Me.txtDireccion.TabIndex = 5
        Me.help.SetToolTip(Me.txtDireccion, "SAN BLAS CARTAGO, FRENTE A SANDOVAL")
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(43, 162)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(79, 19)
        Me.lblDireccion.TabIndex = 4
        Me.lblDireccion.Text = "Dirección "
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(193, 84)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(241, 27)
        Me.txtNombre.TabIndex = 3
        Me.help.SetToolTip(Me.txtNombre, "CASTILLO GUTIERREZ JUVER")
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(43, 84)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(136, 19)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre completo"
        '
        'txtCedula
        '
        Me.txtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedula.Enabled = False
        Me.txtCedula.Location = New System.Drawing.Point(193, 42)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(241, 27)
        Me.txtCedula.TabIndex = 1
        Me.help.SetToolTip(Me.txtCedula, "301870158")
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Location = New System.Drawing.Point(43, 50)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(103, 19)
        Me.lblCedula.TabIndex = 0
        Me.lblCedula.Text = "Identificación"
        '
        'gpbBuscarCliente
        '
        Me.gpbBuscarCliente.Controls.Add(Me.lblCriterio)
        Me.gpbBuscarCliente.Controls.Add(Me.pbModificar)
        Me.gpbBuscarCliente.Controls.Add(Me.pbEliminar)
        Me.gpbBuscarCliente.Controls.Add(Me.dgvDatos)
        Me.gpbBuscarCliente.Controls.Add(Me.txtCriterio)
        Me.gpbBuscarCliente.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBuscarCliente.Location = New System.Drawing.Point(12, 32)
        Me.gpbBuscarCliente.Name = "gpbBuscarCliente"
        Me.gpbBuscarCliente.Size = New System.Drawing.Size(522, 452)
        Me.gpbBuscarCliente.TabIndex = 1
        Me.gpbBuscarCliente.TabStop = False
        Me.gpbBuscarCliente.Text = "Buscar Cliente"
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
        'pbModificar
        '
        Me.pbModificar.BackgroundImage = CType(resources.GetObject("pbModificar.BackgroundImage"), System.Drawing.Image)
        Me.pbModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbModificar.Location = New System.Drawing.Point(439, 405)
        Me.pbModificar.Name = "pbModificar"
        Me.pbModificar.Size = New System.Drawing.Size(30, 30)
        Me.pbModificar.TabIndex = 10
        Me.pbModificar.TabStop = False
        '
        'pbEliminar
        '
        Me.pbEliminar.BackgroundImage = CType(resources.GetObject("pbEliminar.BackgroundImage"), System.Drawing.Image)
        Me.pbEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbEliminar.Location = New System.Drawing.Point(486, 405)
        Me.pbEliminar.Name = "pbEliminar"
        Me.pbEliminar.Size = New System.Drawing.Size(30, 30)
        Me.pbEliminar.TabIndex = 9
        Me.pbEliminar.TabStop = False
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
        Me.dgvDatos.Size = New System.Drawing.Size(509, 278)
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
        'ctlBuscarClienteActivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlBuscarClienteActivo"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbModificarCliente.ResumeLayout(False)
        Me.gpbModificarCliente.PerformLayout()
        CType(Me.pbConfirmar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbBuscarCliente.ResumeLayout(False)
        Me.gpbBuscarCliente.PerformLayout()
        CType(Me.pbModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gpbBuscarCliente As System.Windows.Forms.GroupBox
    Friend WithEvents lblCriterio As System.Windows.Forms.Label
    Friend WithEvents pbModificar As System.Windows.Forms.PictureBox
    Friend WithEvents pbEliminar As System.Windows.Forms.PictureBox
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents txtCriterio As System.Windows.Forms.TextBox
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents gpbModificarCliente As System.Windows.Forms.GroupBox
    Friend WithEvents txtFechaIngreso As System.Windows.Forms.TextBox
    Friend WithEvents lblFechaIngreso As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents pbConfirmar As System.Windows.Forms.PictureBox
    Friend WithEvents pbRegresar As System.Windows.Forms.PictureBox

End Class
