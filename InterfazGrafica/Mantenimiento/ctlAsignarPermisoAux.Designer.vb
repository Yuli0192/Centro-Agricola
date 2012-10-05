<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlAsignarPermisoAux
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlAsignarPermisoAux))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pbRegresarBuscarFinca = New System.Windows.Forms.PictureBox
        Me.gpbAsignarPermisoAux = New System.Windows.Forms.GroupBox
        Me.pbImprimir = New System.Windows.Forms.PictureBox
        Me.pbConfirmar = New System.Windows.Forms.PictureBox
        Me.txtCodigoPermiso = New System.Windows.Forms.TextBox
        Me.lblCodigoPermiso = New System.Windows.Forms.Label
        Me.lblFechaVence = New System.Windows.Forms.Label
        Me.txtFechaVence = New System.Windows.Forms.TextBox
        Me.txtFechaCrea = New System.Windows.Forms.TextBox
        Me.lblFechaCrea = New System.Windows.Forms.Label
        Me.txtCodigoAux = New System.Windows.Forms.TextBox
        Me.lblCodigoAux = New System.Windows.Forms.Label
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.lblTelefono = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.txtCedula = New System.Windows.Forms.TextBox
        Me.lblCedula = New System.Windows.Forms.Label
        Me.gpbBuscarPermiso = New System.Windows.Forms.GroupBox
        Me.lblCriterio = New System.Windows.Forms.Label
        Me.dgvDatos = New System.Windows.Forms.DataGridView
        Me.txtCriterio = New System.Windows.Forms.TextBox
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.permisoAux1 = New InterfazGrafica.PermisoAux
        Me.Panel1.SuspendLayout()
        CType(Me.pbRegresarBuscarFinca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbAsignarPermisoAux.SuspendLayout()
        CType(Me.pbImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbConfirmar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbBuscarPermiso.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbRegresarBuscarFinca)
        Me.Panel1.Controls.Add(Me.gpbAsignarPermisoAux)
        Me.Panel1.Controls.Add(Me.gpbBuscarPermiso)
        Me.Panel1.Location = New System.Drawing.Point(3, 129)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1021, 584)
        Me.Panel1.TabIndex = 0
        '
        'pbRegresarBuscarFinca
        '
        Me.pbRegresarBuscarFinca.BackgroundImage = CType(resources.GetObject("pbRegresarBuscarFinca.BackgroundImage"), System.Drawing.Image)
        Me.pbRegresarBuscarFinca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbRegresarBuscarFinca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresarBuscarFinca.Location = New System.Drawing.Point(973, 3)
        Me.pbRegresarBuscarFinca.Name = "pbRegresarBuscarFinca"
        Me.pbRegresarBuscarFinca.Size = New System.Drawing.Size(30, 30)
        Me.pbRegresarBuscarFinca.TabIndex = 3
        Me.pbRegresarBuscarFinca.TabStop = False
        Me.help.SetToolTip(Me.pbRegresarBuscarFinca, "Regresar bucar finca")
        '
        'gpbAsignarPermisoAux
        '
        Me.gpbAsignarPermisoAux.Controls.Add(Me.pbImprimir)
        Me.gpbAsignarPermisoAux.Controls.Add(Me.pbConfirmar)
        Me.gpbAsignarPermisoAux.Controls.Add(Me.txtCodigoPermiso)
        Me.gpbAsignarPermisoAux.Controls.Add(Me.lblCodigoPermiso)
        Me.gpbAsignarPermisoAux.Controls.Add(Me.lblFechaVence)
        Me.gpbAsignarPermisoAux.Controls.Add(Me.txtFechaVence)
        Me.gpbAsignarPermisoAux.Controls.Add(Me.txtFechaCrea)
        Me.gpbAsignarPermisoAux.Controls.Add(Me.lblFechaCrea)
        Me.gpbAsignarPermisoAux.Controls.Add(Me.txtCodigoAux)
        Me.gpbAsignarPermisoAux.Controls.Add(Me.lblCodigoAux)
        Me.gpbAsignarPermisoAux.Controls.Add(Me.txtTelefono)
        Me.gpbAsignarPermisoAux.Controls.Add(Me.lblTelefono)
        Me.gpbAsignarPermisoAux.Controls.Add(Me.txtNombre)
        Me.gpbAsignarPermisoAux.Controls.Add(Me.lblNombre)
        Me.gpbAsignarPermisoAux.Controls.Add(Me.txtCedula)
        Me.gpbAsignarPermisoAux.Controls.Add(Me.lblCedula)
        Me.gpbAsignarPermisoAux.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbAsignarPermisoAux.Location = New System.Drawing.Point(556, 30)
        Me.gpbAsignarPermisoAux.Name = "gpbAsignarPermisoAux"
        Me.gpbAsignarPermisoAux.Size = New System.Drawing.Size(453, 413)
        Me.gpbAsignarPermisoAux.TabIndex = 1
        Me.gpbAsignarPermisoAux.TabStop = False
        Me.gpbAsignarPermisoAux.Text = "Asignar Permiso Auxiliar"
        '
        'pbImprimir
        '
        Me.pbImprimir.BackgroundImage = CType(resources.GetObject("pbImprimir.BackgroundImage"), System.Drawing.Image)
        Me.pbImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbImprimir.Enabled = False
        Me.pbImprimir.Location = New System.Drawing.Point(345, 356)
        Me.pbImprimir.Name = "pbImprimir"
        Me.pbImprimir.Size = New System.Drawing.Size(30, 30)
        Me.pbImprimir.TabIndex = 26
        Me.pbImprimir.TabStop = False
        Me.help.SetToolTip(Me.pbImprimir, "Imprimir")
        '
        'pbConfirmar
        '
        Me.pbConfirmar.BackgroundImage = CType(resources.GetObject("pbConfirmar.BackgroundImage"), System.Drawing.Image)
        Me.pbConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbConfirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbConfirmar.Location = New System.Drawing.Point(391, 356)
        Me.pbConfirmar.Name = "pbConfirmar"
        Me.pbConfirmar.Size = New System.Drawing.Size(30, 30)
        Me.pbConfirmar.TabIndex = 39
        Me.pbConfirmar.TabStop = False
        Me.help.SetToolTip(Me.pbConfirmar, "Asignar permiso")
        '
        'txtCodigoPermiso
        '
        Me.txtCodigoPermiso.Location = New System.Drawing.Point(186, 228)
        Me.txtCodigoPermiso.Name = "txtCodigoPermiso"
        Me.txtCodigoPermiso.Size = New System.Drawing.Size(235, 27)
        Me.txtCodigoPermiso.TabIndex = 38
        '
        'lblCodigoPermiso
        '
        Me.lblCodigoPermiso.AutoSize = True
        Me.lblCodigoPermiso.Location = New System.Drawing.Point(19, 231)
        Me.lblCodigoPermiso.Name = "lblCodigoPermiso"
        Me.lblCodigoPermiso.Size = New System.Drawing.Size(121, 19)
        Me.lblCodigoPermiso.TabIndex = 37
        Me.lblCodigoPermiso.Text = "Código permiso"
        '
        'lblFechaVence
        '
        Me.lblFechaVence.AutoSize = True
        Me.lblFechaVence.Location = New System.Drawing.Point(19, 331)
        Me.lblFechaVence.Name = "lblFechaVence"
        Me.lblFechaVence.Size = New System.Drawing.Size(94, 19)
        Me.lblFechaVence.TabIndex = 36
        Me.lblFechaVence.Text = "Fecha vence"
        '
        'txtFechaVence
        '
        Me.txtFechaVence.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFechaVence.Location = New System.Drawing.Point(186, 323)
        Me.txtFechaVence.Name = "txtFechaVence"
        Me.txtFechaVence.Size = New System.Drawing.Size(235, 27)
        Me.txtFechaVence.TabIndex = 35
        '
        'txtFechaCrea
        '
        Me.txtFechaCrea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFechaCrea.Location = New System.Drawing.Point(186, 273)
        Me.txtFechaCrea.Name = "txtFechaCrea"
        Me.txtFechaCrea.Size = New System.Drawing.Size(235, 27)
        Me.txtFechaCrea.TabIndex = 34
        '
        'lblFechaCrea
        '
        Me.lblFechaCrea.AutoSize = True
        Me.lblFechaCrea.Location = New System.Drawing.Point(19, 276)
        Me.lblFechaCrea.Name = "lblFechaCrea"
        Me.lblFechaCrea.Size = New System.Drawing.Size(83, 19)
        Me.lblFechaCrea.TabIndex = 33
        Me.lblFechaCrea.Text = "Fecha crea"
        '
        'txtCodigoAux
        '
        Me.txtCodigoAux.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoAux.Location = New System.Drawing.Point(186, 30)
        Me.txtCodigoAux.Name = "txtCodigoAux"
        Me.txtCodigoAux.Size = New System.Drawing.Size(235, 27)
        Me.txtCodigoAux.TabIndex = 32
        '
        'lblCodigoAux
        '
        Me.lblCodigoAux.AutoSize = True
        Me.lblCodigoAux.Location = New System.Drawing.Point(19, 38)
        Me.lblCodigoAux.Name = "lblCodigoAux"
        Me.lblCodigoAux.Size = New System.Drawing.Size(115, 19)
        Me.lblCodigoAux.TabIndex = 31
        Me.lblCodigoAux.Text = "Código auxiliar"
        '
        'txtTelefono
        '
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefono.Location = New System.Drawing.Point(186, 174)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(235, 27)
        Me.txtTelefono.TabIndex = 30
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(19, 177)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(71, 19)
        Me.lblTelefono.TabIndex = 29
        Me.lblTelefono.Text = "Teléfono"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(186, 128)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(235, 27)
        Me.txtNombre.TabIndex = 28
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(19, 136)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(136, 19)
        Me.lblNombre.TabIndex = 27
        Me.lblNombre.Text = "Nombre completo"
        '
        'txtCedula
        '
        Me.txtCedula.BackColor = System.Drawing.SystemColors.Window
        Me.txtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedula.Location = New System.Drawing.Point(186, 79)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(235, 27)
        Me.txtCedula.TabIndex = 26
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Location = New System.Drawing.Point(19, 87)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(103, 19)
        Me.lblCedula.TabIndex = 25
        Me.lblCedula.Text = "Identificación"
        '
        'gpbBuscarPermiso
        '
        Me.gpbBuscarPermiso.Controls.Add(Me.lblCriterio)
        Me.gpbBuscarPermiso.Controls.Add(Me.dgvDatos)
        Me.gpbBuscarPermiso.Controls.Add(Me.txtCriterio)
        Me.gpbBuscarPermiso.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBuscarPermiso.Location = New System.Drawing.Point(15, 30)
        Me.gpbBuscarPermiso.Name = "gpbBuscarPermiso"
        Me.gpbBuscarPermiso.Size = New System.Drawing.Size(535, 413)
        Me.gpbBuscarPermiso.TabIndex = 0
        Me.gpbBuscarPermiso.TabStop = False
        Me.gpbBuscarPermiso.Text = "Buscar Permiso"
        '
        'lblCriterio
        '
        Me.lblCriterio.AutoSize = True
        Me.lblCriterio.Location = New System.Drawing.Point(6, 41)
        Me.lblCriterio.Name = "lblCriterio"
        Me.lblCriterio.Size = New System.Drawing.Size(134, 19)
        Me.lblCriterio.TabIndex = 15
        Me.lblCriterio.Text = "Criterio búsqueda"
        '
        'dgvDatos
        '
        Me.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDatos.BackgroundColor = System.Drawing.Color.White
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Location = New System.Drawing.Point(10, 102)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.RowHeadersVisible = False
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(519, 278)
        Me.dgvDatos.TabIndex = 14
        '
        'txtCriterio
        '
        Me.txtCriterio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCriterio.Location = New System.Drawing.Point(146, 38)
        Me.txtCriterio.Name = "txtCriterio"
        Me.txtCriterio.Size = New System.Drawing.Size(234, 27)
        Me.txtCriterio.TabIndex = 13
        '
        'ctlAsignarPermisoAux
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlAsignarPermisoAux"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbRegresarBuscarFinca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbAsignarPermisoAux.ResumeLayout(False)
        Me.gpbAsignarPermisoAux.PerformLayout()
        CType(Me.pbImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbConfirmar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbBuscarPermiso.ResumeLayout(False)
        Me.gpbBuscarPermiso.PerformLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gpbBuscarPermiso As System.Windows.Forms.GroupBox
    Friend WithEvents lblCriterio As System.Windows.Forms.Label
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents txtCriterio As System.Windows.Forms.TextBox
    Friend WithEvents gpbAsignarPermisoAux As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodigoAux As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigoAux As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents txtFechaCrea As System.Windows.Forms.TextBox
    Friend WithEvents lblFechaCrea As System.Windows.Forms.Label
    Friend WithEvents txtFechaVence As System.Windows.Forms.TextBox
    Friend WithEvents lblFechaVence As System.Windows.Forms.Label
    Friend WithEvents txtCodigoPermiso As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigoPermiso As System.Windows.Forms.Label
    Friend WithEvents pbConfirmar As System.Windows.Forms.PictureBox
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents pbRegresarBuscarFinca As System.Windows.Forms.PictureBox
    Friend WithEvents pbImprimir As System.Windows.Forms.PictureBox
    Friend WithEvents permisoAux1 As InterfazGrafica.PermisoAux

End Class
