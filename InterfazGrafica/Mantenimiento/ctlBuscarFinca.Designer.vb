<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlBuscarFinca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlBuscarFinca))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pbRegresar = New System.Windows.Forms.PictureBox
        Me.gpbModificarFinca = New System.Windows.Forms.GroupBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.pbConfirmar = New System.Windows.Forms.PictureBox
        Me.txtArea = New System.Windows.Forms.TextBox
        Me.lblArea = New System.Windows.Forms.Label
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.lblDireccion = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.gpbBuscarFinca = New System.Windows.Forms.GroupBox
        Me.pbAsignarFincaSocio = New System.Windows.Forms.PictureBox
        Me.txtTotalArea = New System.Windows.Forms.TextBox
        Me.lblTotalArea = New System.Windows.Forms.Label
        Me.pbVerTotalArea = New System.Windows.Forms.PictureBox
        Me.pbModificar = New System.Windows.Forms.PictureBox
        Me.lblCriterio = New System.Windows.Forms.Label
        Me.dgvDatos = New System.Windows.Forms.DataGridView
        Me.txtCriterio = New System.Windows.Forms.TextBox
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbModificarFinca.SuspendLayout()
        CType(Me.pbConfirmar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbBuscarFinca.SuspendLayout()
        CType(Me.pbAsignarFincaSocio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbVerTotalArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbRegresar)
        Me.Panel1.Controls.Add(Me.gpbModificarFinca)
        Me.Panel1.Controls.Add(Me.gpbBuscarFinca)
        Me.Panel1.Location = New System.Drawing.Point(3, 96)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1027, 544)
        Me.Panel1.TabIndex = 0
        '
        'pbRegresar
        '
        Me.pbRegresar.BackgroundImage = CType(resources.GetObject("pbRegresar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresar.Location = New System.Drawing.Point(969, 3)
        Me.pbRegresar.Name = "pbRegresar"
        Me.pbRegresar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegresar.TabIndex = 11
        Me.pbRegresar.TabStop = False
        Me.help.SetToolTip(Me.pbRegresar, "Regresar")
        '
        'gpbModificarFinca
        '
        Me.gpbModificarFinca.Controls.Add(Me.txtCodigo)
        Me.gpbModificarFinca.Controls.Add(Me.lblCodigo)
        Me.gpbModificarFinca.Controls.Add(Me.pbConfirmar)
        Me.gpbModificarFinca.Controls.Add(Me.txtArea)
        Me.gpbModificarFinca.Controls.Add(Me.lblArea)
        Me.gpbModificarFinca.Controls.Add(Me.txtDireccion)
        Me.gpbModificarFinca.Controls.Add(Me.lblDireccion)
        Me.gpbModificarFinca.Controls.Add(Me.txtNombre)
        Me.gpbModificarFinca.Controls.Add(Me.lblNombre)
        Me.gpbModificarFinca.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbModificarFinca.Location = New System.Drawing.Point(577, 29)
        Me.gpbModificarFinca.Name = "gpbModificarFinca"
        Me.gpbModificarFinca.Size = New System.Drawing.Size(428, 392)
        Me.gpbModificarFinca.TabIndex = 1
        Me.gpbModificarFinca.TabStop = False
        Me.gpbModificarFinca.Text = "Modificar Finca"
        Me.gpbModificarFinca.Visible = False
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(119, 47)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(235, 27)
        Me.txtCodigo.TabIndex = 26
        Me.help.SetToolTip(Me.txtCodigo, "30201343")
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(28, 47)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(59, 19)
        Me.lblCodigo.TabIndex = 25
        Me.lblCodigo.Text = "Código"
        '
        'pbConfirmar
        '
        Me.pbConfirmar.BackgroundImage = CType(resources.GetObject("pbConfirmar.BackgroundImage"), System.Drawing.Image)
        Me.pbConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbConfirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbConfirmar.Location = New System.Drawing.Point(324, 309)
        Me.pbConfirmar.Name = "pbConfirmar"
        Me.pbConfirmar.Size = New System.Drawing.Size(30, 30)
        Me.pbConfirmar.TabIndex = 17
        Me.pbConfirmar.TabStop = False
        Me.help.SetToolTip(Me.pbConfirmar, "Confirmar modificación")
        '
        'txtArea
        '
        Me.txtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArea.Location = New System.Drawing.Point(119, 247)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(235, 27)
        Me.txtArea.TabIndex = 5
        Me.help.SetToolTip(Me.txtArea, "1500")
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(28, 255)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(42, 19)
        Me.lblArea.TabIndex = 4
        Me.lblArea.Text = "Area"
        '
        'txtDireccion
        '
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Location = New System.Drawing.Point(32, 160)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(322, 67)
        Me.txtDireccion.TabIndex = 3
        Me.help.SetToolTip(Me.txtDireccion, "200 METROS SUR DELEGACION DEL YAS.")
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(28, 138)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(74, 19)
        Me.lblDireccion.TabIndex = 2
        Me.lblDireccion.Text = "Dirección"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(119, 95)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(235, 27)
        Me.txtNombre.TabIndex = 1
        Me.help.SetToolTip(Me.txtNombre, "EL YAS")
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(28, 98)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(66, 19)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'gpbBuscarFinca
        '
        Me.gpbBuscarFinca.Controls.Add(Me.pbAsignarFincaSocio)
        Me.gpbBuscarFinca.Controls.Add(Me.txtTotalArea)
        Me.gpbBuscarFinca.Controls.Add(Me.lblTotalArea)
        Me.gpbBuscarFinca.Controls.Add(Me.pbVerTotalArea)
        Me.gpbBuscarFinca.Controls.Add(Me.pbModificar)
        Me.gpbBuscarFinca.Controls.Add(Me.lblCriterio)
        Me.gpbBuscarFinca.Controls.Add(Me.dgvDatos)
        Me.gpbBuscarFinca.Controls.Add(Me.txtCriterio)
        Me.gpbBuscarFinca.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBuscarFinca.Location = New System.Drawing.Point(16, 29)
        Me.gpbBuscarFinca.Name = "gpbBuscarFinca"
        Me.gpbBuscarFinca.Size = New System.Drawing.Size(539, 465)
        Me.gpbBuscarFinca.TabIndex = 0
        Me.gpbBuscarFinca.TabStop = False
        Me.gpbBuscarFinca.Text = "Buscar Finca"
        '
        'pbAsignarFincaSocio
        '
        Me.pbAsignarFincaSocio.BackgroundImage = CType(resources.GetObject("pbAsignarFincaSocio.BackgroundImage"), System.Drawing.Image)
        Me.pbAsignarFincaSocio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAsignarFincaSocio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAsignarFincaSocio.Location = New System.Drawing.Point(488, 399)
        Me.pbAsignarFincaSocio.Name = "pbAsignarFincaSocio"
        Me.pbAsignarFincaSocio.Size = New System.Drawing.Size(30, 30)
        Me.pbAsignarFincaSocio.TabIndex = 22
        Me.pbAsignarFincaSocio.TabStop = False
        Me.help.SetToolTip(Me.pbAsignarFincaSocio, "Asignar Finca Socio")
        '
        'txtTotalArea
        '
        Me.txtTotalArea.Enabled = False
        Me.txtTotalArea.Location = New System.Drawing.Point(156, 424)
        Me.txtTotalArea.Name = "txtTotalArea"
        Me.txtTotalArea.ReadOnly = True
        Me.txtTotalArea.Size = New System.Drawing.Size(211, 27)
        Me.txtTotalArea.TabIndex = 21
        Me.txtTotalArea.Visible = False
        '
        'lblTotalArea
        '
        Me.lblTotalArea.AutoSize = True
        Me.lblTotalArea.Location = New System.Drawing.Point(30, 427)
        Me.lblTotalArea.Name = "lblTotalArea"
        Me.lblTotalArea.Size = New System.Drawing.Size(106, 19)
        Me.lblTotalArea.TabIndex = 20
        Me.lblTotalArea.Text = "Total del área"
        Me.lblTotalArea.Visible = False
        '
        'pbVerTotalArea
        '
        Me.pbVerTotalArea.BackgroundImage = CType(resources.GetObject("pbVerTotalArea.BackgroundImage"), System.Drawing.Image)
        Me.pbVerTotalArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbVerTotalArea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbVerTotalArea.Location = New System.Drawing.Point(449, 399)
        Me.pbVerTotalArea.Name = "pbVerTotalArea"
        Me.pbVerTotalArea.Size = New System.Drawing.Size(30, 30)
        Me.pbVerTotalArea.TabIndex = 19
        Me.pbVerTotalArea.TabStop = False
        Me.help.SetToolTip(Me.pbVerTotalArea, "Ver total del área")
        '
        'pbModificar
        '
        Me.pbModificar.BackgroundImage = CType(resources.GetObject("pbModificar.BackgroundImage"), System.Drawing.Image)
        Me.pbModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbModificar.Location = New System.Drawing.Point(413, 399)
        Me.pbModificar.Name = "pbModificar"
        Me.pbModificar.Size = New System.Drawing.Size(30, 30)
        Me.pbModificar.TabIndex = 18
        Me.pbModificar.TabStop = False
        Me.help.SetToolTip(Me.pbModificar, "Modificar")
        '
        'lblCriterio
        '
        Me.lblCriterio.AutoSize = True
        Me.lblCriterio.Location = New System.Drawing.Point(39, 42)
        Me.lblCriterio.Name = "lblCriterio"
        Me.lblCriterio.Size = New System.Drawing.Size(134, 19)
        Me.lblCriterio.TabIndex = 16
        Me.lblCriterio.Text = "Criterio búsqueda"
        '
        'dgvDatos
        '
        Me.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDatos.BackgroundColor = System.Drawing.Color.White
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Location = New System.Drawing.Point(34, 117)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.RowHeadersVisible = False
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(484, 276)
        Me.dgvDatos.TabIndex = 15
        '
        'txtCriterio
        '
        Me.txtCriterio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCriterio.Location = New System.Drawing.Point(179, 39)
        Me.txtCriterio.Name = "txtCriterio"
        Me.txtCriterio.Size = New System.Drawing.Size(234, 27)
        Me.txtCriterio.TabIndex = 14
        Me.help.SetToolTip(Me.txtCriterio, "CACHI")
        '
        'ctlBuscarFinca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlBuscarFinca"
        Me.Size = New System.Drawing.Size(1030, 700)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbModificarFinca.ResumeLayout(False)
        Me.gpbModificarFinca.PerformLayout()
        CType(Me.pbConfirmar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbBuscarFinca.ResumeLayout(False)
        Me.gpbBuscarFinca.PerformLayout()
        CType(Me.pbAsignarFincaSocio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbVerTotalArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gpbBuscarFinca As System.Windows.Forms.GroupBox
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents lblCriterio As System.Windows.Forms.Label
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents txtCriterio As System.Windows.Forms.TextBox
    Friend WithEvents gpbModificarFinca As System.Windows.Forms.GroupBox
    Friend WithEvents txtArea As System.Windows.Forms.TextBox
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents pbModificar As System.Windows.Forms.PictureBox
    Friend WithEvents pbConfirmar As System.Windows.Forms.PictureBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents pbVerTotalArea As System.Windows.Forms.PictureBox
    Friend WithEvents lblTotalArea As System.Windows.Forms.Label
    Friend WithEvents txtTotalArea As System.Windows.Forms.TextBox
    Friend WithEvents pbAsignarFincaSocio As System.Windows.Forms.PictureBox
    Friend WithEvents pbRegresar As System.Windows.Forms.PictureBox

End Class
