<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlRegistrarProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlRegistrarProducto))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pbRegresar = New System.Windows.Forms.PictureBox
        Me.gpbBuscarProducto = New System.Windows.Forms.GroupBox
        Me.dgvDato = New System.Windows.Forms.DataGridView
        Me.txtNombreBuscar = New System.Windows.Forms.TextBox
        Me.lblNombreBuscar = New System.Windows.Forms.Label
        Me.gpbRegistrarProducto = New System.Windows.Forms.GroupBox
        Me.pbLimpiar = New System.Windows.Forms.PictureBox
        Me.pbRegistrar = New System.Windows.Forms.PictureBox
        Me.rbtKilogramo = New System.Windows.Forms.RadioButton
        Me.rbtRacimo = New System.Windows.Forms.RadioButton
        Me.rbtUnidad = New System.Windows.Forms.RadioButton
        Me.rbtRollo = New System.Windows.Forms.RadioButton
        Me.rbtJava = New System.Windows.Forms.RadioButton
        Me.lblUnidad = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbBuscarProducto.SuspendLayout()
        CType(Me.dgvDato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbRegistrarProducto.SuspendLayout()
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.pbRegresar)
        Me.Panel1.Controls.Add(Me.gpbBuscarProducto)
        Me.Panel1.Controls.Add(Me.gpbRegistrarProducto)
        Me.Panel1.Location = New System.Drawing.Point(164, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(703, 611)
        Me.Panel1.TabIndex = 0
        '
        'pbRegresar
        '
        Me.pbRegresar.BackgroundImage = CType(resources.GetObject("pbRegresar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresar.Location = New System.Drawing.Point(670, 20)
        Me.pbRegresar.Name = "pbRegresar"
        Me.pbRegresar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegresar.TabIndex = 5
        Me.pbRegresar.TabStop = False
        Me.help.SetToolTip(Me.pbRegresar, "Regresar")
        '
        'gpbBuscarProducto
        '
        Me.gpbBuscarProducto.Controls.Add(Me.dgvDato)
        Me.gpbBuscarProducto.Controls.Add(Me.txtNombreBuscar)
        Me.gpbBuscarProducto.Controls.Add(Me.lblNombreBuscar)
        Me.gpbBuscarProducto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBuscarProducto.Location = New System.Drawing.Point(71, 244)
        Me.gpbBuscarProducto.Name = "gpbBuscarProducto"
        Me.gpbBuscarProducto.Size = New System.Drawing.Size(556, 346)
        Me.gpbBuscarProducto.TabIndex = 1
        Me.gpbBuscarProducto.TabStop = False
        Me.gpbBuscarProducto.Text = "Buscar Producto"
        '
        'dgvDato
        '
        Me.dgvDato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDato.BackgroundColor = System.Drawing.Color.White
        Me.dgvDato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDato.Location = New System.Drawing.Point(37, 74)
        Me.dgvDato.Name = "dgvDato"
        Me.dgvDato.RowHeadersVisible = False
        Me.dgvDato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDato.Size = New System.Drawing.Size(415, 228)
        Me.dgvDato.TabIndex = 4
        '
        'txtNombreBuscar
        '
        Me.txtNombreBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreBuscar.Location = New System.Drawing.Point(177, 30)
        Me.txtNombreBuscar.Name = "txtNombreBuscar"
        Me.txtNombreBuscar.Size = New System.Drawing.Size(225, 27)
        Me.txtNombreBuscar.TabIndex = 3
        Me.help.SetToolTip(Me.txtNombreBuscar, "Papa")
        '
        'lblNombreBuscar
        '
        Me.lblNombreBuscar.AutoSize = True
        Me.lblNombreBuscar.Location = New System.Drawing.Point(33, 38)
        Me.lblNombreBuscar.Name = "lblNombreBuscar"
        Me.lblNombreBuscar.Size = New System.Drawing.Size(138, 19)
        Me.lblNombreBuscar.TabIndex = 2
        Me.lblNombreBuscar.Text = "Buscar por criterio"
        '
        'gpbRegistrarProducto
        '
        Me.gpbRegistrarProducto.Controls.Add(Me.pbLimpiar)
        Me.gpbRegistrarProducto.Controls.Add(Me.pbRegistrar)
        Me.gpbRegistrarProducto.Controls.Add(Me.rbtKilogramo)
        Me.gpbRegistrarProducto.Controls.Add(Me.rbtRacimo)
        Me.gpbRegistrarProducto.Controls.Add(Me.rbtUnidad)
        Me.gpbRegistrarProducto.Controls.Add(Me.rbtRollo)
        Me.gpbRegistrarProducto.Controls.Add(Me.rbtJava)
        Me.gpbRegistrarProducto.Controls.Add(Me.lblUnidad)
        Me.gpbRegistrarProducto.Controls.Add(Me.txtNombre)
        Me.gpbRegistrarProducto.Controls.Add(Me.lblNombre)
        Me.gpbRegistrarProducto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbRegistrarProducto.Location = New System.Drawing.Point(71, 20)
        Me.gpbRegistrarProducto.Name = "gpbRegistrarProducto"
        Me.gpbRegistrarProducto.Size = New System.Drawing.Size(567, 218)
        Me.gpbRegistrarProducto.TabIndex = 0
        Me.gpbRegistrarProducto.TabStop = False
        Me.gpbRegistrarProducto.Text = "Registrar Producto"
        '
        'pbLimpiar
        '
        Me.pbLimpiar.BackgroundImage = CType(resources.GetObject("pbLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.pbLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbLimpiar.Location = New System.Drawing.Point(86, 142)
        Me.pbLimpiar.Name = "pbLimpiar"
        Me.pbLimpiar.Size = New System.Drawing.Size(30, 30)
        Me.pbLimpiar.TabIndex = 11
        Me.pbLimpiar.TabStop = False
        Me.help.SetToolTip(Me.pbLimpiar, "Limpiar")
        '
        'pbRegistrar
        '
        Me.pbRegistrar.BackgroundImage = CType(resources.GetObject("pbRegistrar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegistrar.Location = New System.Drawing.Point(37, 142)
        Me.pbRegistrar.Name = "pbRegistrar"
        Me.pbRegistrar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegistrar.TabIndex = 10
        Me.pbRegistrar.TabStop = False
        Me.help.SetToolTip(Me.pbRegistrar, "Registrar")
        '
        'rbtKilogramo
        '
        Me.rbtKilogramo.AutoSize = True
        Me.rbtKilogramo.Location = New System.Drawing.Point(193, 101)
        Me.rbtKilogramo.Name = "rbtKilogramo"
        Me.rbtKilogramo.Size = New System.Drawing.Size(99, 23)
        Me.rbtKilogramo.TabIndex = 9
        Me.rbtKilogramo.TabStop = True
        Me.rbtKilogramo.Text = "Kilogramo"
        Me.rbtKilogramo.UseVisualStyleBackColor = True
        '
        'rbtRacimo
        '
        Me.rbtRacimo.AutoSize = True
        Me.rbtRacimo.Location = New System.Drawing.Point(472, 103)
        Me.rbtRacimo.Name = "rbtRacimo"
        Me.rbtRacimo.Size = New System.Drawing.Size(86, 23)
        Me.rbtRacimo.TabIndex = 6
        Me.rbtRacimo.Text = "Racimos"
        Me.rbtRacimo.UseVisualStyleBackColor = True
        '
        'rbtUnidad
        '
        Me.rbtUnidad.AutoSize = True
        Me.rbtUnidad.Location = New System.Drawing.Point(374, 101)
        Me.rbtUnidad.Name = "rbtUnidad"
        Me.rbtUnidad.Size = New System.Drawing.Size(92, 23)
        Me.rbtUnidad.TabIndex = 5
        Me.rbtUnidad.Text = "Unidades"
        Me.rbtUnidad.UseVisualStyleBackColor = True
        '
        'rbtRollo
        '
        Me.rbtRollo.AutoSize = True
        Me.rbtRollo.Location = New System.Drawing.Point(298, 101)
        Me.rbtRollo.Name = "rbtRollo"
        Me.rbtRollo.Size = New System.Drawing.Size(70, 23)
        Me.rbtRollo.TabIndex = 4
        Me.rbtRollo.Text = "Rollos"
        Me.rbtRollo.UseVisualStyleBackColor = True
        '
        'rbtJava
        '
        Me.rbtJava.AutoSize = True
        Me.rbtJava.Checked = True
        Me.rbtJava.Location = New System.Drawing.Point(122, 99)
        Me.rbtJava.Name = "rbtJava"
        Me.rbtJava.Size = New System.Drawing.Size(65, 23)
        Me.rbtJava.TabIndex = 3
        Me.rbtJava.TabStop = True
        Me.rbtJava.Text = "Javas"
        Me.rbtJava.UseVisualStyleBackColor = True
        '
        'lblUnidad
        '
        Me.lblUnidad.AutoSize = True
        Me.lblUnidad.Location = New System.Drawing.Point(33, 103)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(59, 19)
        Me.lblUnidad.TabIndex = 2
        Me.lblUnidad.Text = "Unidad"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(122, 48)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(225, 27)
        Me.txtNombre.TabIndex = 1
        Me.help.SetToolTip(Me.txtNombre, "Papa")
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(33, 56)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(71, 19)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre "
        '
        'ctlRegistrarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlRegistrarProducto"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbBuscarProducto.ResumeLayout(False)
        Me.gpbBuscarProducto.PerformLayout()
        CType(Me.dgvDato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbRegistrarProducto.ResumeLayout(False)
        Me.gpbRegistrarProducto.PerformLayout()
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gpbRegistrarProducto As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents rbtJava As System.Windows.Forms.RadioButton
    Friend WithEvents lblUnidad As System.Windows.Forms.Label
    Friend WithEvents rbtRollo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtRacimo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtUnidad As System.Windows.Forms.RadioButton
    Friend WithEvents gpbBuscarProducto As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDato As System.Windows.Forms.DataGridView
    Friend WithEvents txtNombreBuscar As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreBuscar As System.Windows.Forms.Label
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents rbtKilogramo As System.Windows.Forms.RadioButton
    Friend WithEvents pbRegistrar As System.Windows.Forms.PictureBox
    Friend WithEvents pbLimpiar As System.Windows.Forms.PictureBox
    Friend WithEvents pbRegresar As System.Windows.Forms.PictureBox

End Class
