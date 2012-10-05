<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlAsignarFincaSocio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlAsignarFincaSocio))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pbRegresarBuscarFinca = New System.Windows.Forms.PictureBox
        Me.gpbBuscarSocio = New System.Windows.Forms.GroupBox
        Me.lblCriterio = New System.Windows.Forms.Label
        Me.dgvDatos = New System.Windows.Forms.DataGridView
        Me.txtCriterio = New System.Windows.Forms.TextBox
        Me.gpbAsignarFincaSocio = New System.Windows.Forms.GroupBox
        Me.pbLimpiar = New System.Windows.Forms.PictureBox
        Me.pbRegistrar = New System.Windows.Forms.PictureBox
        Me.cmbTipoContrato = New System.Windows.Forms.ComboBox
        Me.lblTipoContrato = New System.Windows.Forms.Label
        Me.txtFechaContrato = New System.Windows.Forms.TextBox
        Me.lblFechaContrato = New System.Windows.Forms.Label
        Me.txtCodSocio = New System.Windows.Forms.TextBox
        Me.lblCodigoSocio = New System.Windows.Forms.Label
        Me.txtCodFinca = New System.Windows.Forms.TextBox
        Me.lblCodigoFinca = New System.Windows.Forms.Label
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.pbRegresarBuscarFinca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbBuscarSocio.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbAsignarFincaSocio.SuspendLayout()
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbRegresarBuscarFinca)
        Me.Panel1.Controls.Add(Me.gpbBuscarSocio)
        Me.Panel1.Controls.Add(Me.gpbAsignarFincaSocio)
        Me.Panel1.Location = New System.Drawing.Point(0, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 533)
        Me.Panel1.TabIndex = 0
        '
        'pbRegresarBuscarFinca
        '
        Me.pbRegresarBuscarFinca.BackgroundImage = CType(resources.GetObject("pbRegresarBuscarFinca.BackgroundImage"), System.Drawing.Image)
        Me.pbRegresarBuscarFinca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbRegresarBuscarFinca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresarBuscarFinca.Location = New System.Drawing.Point(985, 19)
        Me.pbRegresarBuscarFinca.Name = "pbRegresarBuscarFinca"
        Me.pbRegresarBuscarFinca.Size = New System.Drawing.Size(30, 30)
        Me.pbRegresarBuscarFinca.TabIndex = 2
        Me.pbRegresarBuscarFinca.TabStop = False
        Me.help.SetToolTip(Me.pbRegresarBuscarFinca, "Regresar bucar finca")
        '
        'gpbBuscarSocio
        '
        Me.gpbBuscarSocio.Controls.Add(Me.lblCriterio)
        Me.gpbBuscarSocio.Controls.Add(Me.dgvDatos)
        Me.gpbBuscarSocio.Controls.Add(Me.txtCriterio)
        Me.gpbBuscarSocio.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBuscarSocio.Location = New System.Drawing.Point(18, 55)
        Me.gpbBuscarSocio.Name = "gpbBuscarSocio"
        Me.gpbBuscarSocio.Size = New System.Drawing.Size(533, 424)
        Me.gpbBuscarSocio.TabIndex = 1
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
        '
        'gpbAsignarFincaSocio
        '
        Me.gpbAsignarFincaSocio.Controls.Add(Me.pbLimpiar)
        Me.gpbAsignarFincaSocio.Controls.Add(Me.pbRegistrar)
        Me.gpbAsignarFincaSocio.Controls.Add(Me.cmbTipoContrato)
        Me.gpbAsignarFincaSocio.Controls.Add(Me.lblTipoContrato)
        Me.gpbAsignarFincaSocio.Controls.Add(Me.txtFechaContrato)
        Me.gpbAsignarFincaSocio.Controls.Add(Me.lblFechaContrato)
        Me.gpbAsignarFincaSocio.Controls.Add(Me.txtCodSocio)
        Me.gpbAsignarFincaSocio.Controls.Add(Me.lblCodigoSocio)
        Me.gpbAsignarFincaSocio.Controls.Add(Me.txtCodFinca)
        Me.gpbAsignarFincaSocio.Controls.Add(Me.lblCodigoFinca)
        Me.gpbAsignarFincaSocio.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbAsignarFincaSocio.Location = New System.Drawing.Point(557, 55)
        Me.gpbAsignarFincaSocio.Name = "gpbAsignarFincaSocio"
        Me.gpbAsignarFincaSocio.Size = New System.Drawing.Size(452, 302)
        Me.gpbAsignarFincaSocio.TabIndex = 0
        Me.gpbAsignarFincaSocio.TabStop = False
        Me.gpbAsignarFincaSocio.Text = "Asignar Finca al Socio"
        '
        'pbLimpiar
        '
        Me.pbLimpiar.BackgroundImage = CType(resources.GetObject("pbLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.pbLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbLimpiar.Location = New System.Drawing.Point(374, 244)
        Me.pbLimpiar.Name = "pbLimpiar"
        Me.pbLimpiar.Size = New System.Drawing.Size(33, 30)
        Me.pbLimpiar.TabIndex = 28
        Me.pbLimpiar.TabStop = False
        Me.help.SetToolTip(Me.pbLimpiar, "Limpiar")
        '
        'pbRegistrar
        '
        Me.pbRegistrar.BackgroundImage = CType(resources.GetObject("pbRegistrar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegistrar.Location = New System.Drawing.Point(338, 244)
        Me.pbRegistrar.Name = "pbRegistrar"
        Me.pbRegistrar.Size = New System.Drawing.Size(33, 30)
        Me.pbRegistrar.TabIndex = 27
        Me.pbRegistrar.TabStop = False
        Me.help.SetToolTip(Me.pbRegistrar, "Asignar finca al socio")
        '
        'cmbTipoContrato
        '
        Me.cmbTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoContrato.FormattingEnabled = True
        Me.cmbTipoContrato.Items.AddRange(New Object() {"---SELECCIONAR---", "ALQUILADA", "PRESTADA", "DUEÑO"})
        Me.cmbTipoContrato.Location = New System.Drawing.Point(190, 201)
        Me.cmbTipoContrato.Name = "cmbTipoContrato"
        Me.cmbTipoContrato.Size = New System.Drawing.Size(216, 27)
        Me.cmbTipoContrato.TabIndex = 9
        '
        'lblTipoContrato
        '
        Me.lblTipoContrato.AutoSize = True
        Me.lblTipoContrato.Location = New System.Drawing.Point(27, 201)
        Me.lblTipoContrato.Name = "lblTipoContrato"
        Me.lblTipoContrato.Size = New System.Drawing.Size(107, 19)
        Me.lblTipoContrato.TabIndex = 8
        Me.lblTipoContrato.Text = "Tipo Contrato"
        '
        'txtFechaContrato
        '
        Me.txtFechaContrato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFechaContrato.Enabled = False
        Me.txtFechaContrato.Location = New System.Drawing.Point(190, 150)
        Me.txtFechaContrato.Name = "txtFechaContrato"
        Me.txtFechaContrato.Size = New System.Drawing.Size(216, 27)
        Me.txtFechaContrato.TabIndex = 7
        '
        'lblFechaContrato
        '
        Me.lblFechaContrato.AutoSize = True
        Me.lblFechaContrato.Location = New System.Drawing.Point(27, 153)
        Me.lblFechaContrato.Name = "lblFechaContrato"
        Me.lblFechaContrato.Size = New System.Drawing.Size(138, 19)
        Me.lblFechaContrato.TabIndex = 6
        Me.lblFechaContrato.Text = "Fecha del contrato"
        '
        'txtCodSocio
        '
        Me.txtCodSocio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodSocio.Enabled = False
        Me.txtCodSocio.Location = New System.Drawing.Point(190, 89)
        Me.txtCodSocio.Name = "txtCodSocio"
        Me.txtCodSocio.Size = New System.Drawing.Size(216, 27)
        Me.txtCodSocio.TabIndex = 3
        '
        'lblCodigoSocio
        '
        Me.lblCodigoSocio.AutoSize = True
        Me.lblCodigoSocio.Location = New System.Drawing.Point(27, 97)
        Me.lblCodigoSocio.Name = "lblCodigoSocio"
        Me.lblCodigoSocio.Size = New System.Drawing.Size(126, 19)
        Me.lblCodigoSocio.TabIndex = 2
        Me.lblCodigoSocio.Text = "Código del socio"
        '
        'txtCodFinca
        '
        Me.txtCodFinca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodFinca.Enabled = False
        Me.txtCodFinca.Location = New System.Drawing.Point(190, 41)
        Me.txtCodFinca.Name = "txtCodFinca"
        Me.txtCodFinca.Size = New System.Drawing.Size(216, 27)
        Me.txtCodFinca.TabIndex = 1
        '
        'lblCodigoFinca
        '
        Me.lblCodigoFinca.AutoSize = True
        Me.lblCodigoFinca.Location = New System.Drawing.Point(27, 44)
        Me.lblCodigoFinca.Name = "lblCodigoFinca"
        Me.lblCodigoFinca.Size = New System.Drawing.Size(136, 19)
        Me.lblCodigoFinca.TabIndex = 0
        Me.lblCodigoFinca.Text = "Código de la finca"
        '
        'ctlAsignarFincaSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlAsignarFincaSocio"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbRegresarBuscarFinca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbBuscarSocio.ResumeLayout(False)
        Me.gpbBuscarSocio.PerformLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbAsignarFincaSocio.ResumeLayout(False)
        Me.gpbAsignarFincaSocio.PerformLayout()
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gpbAsignarFincaSocio As System.Windows.Forms.GroupBox
    Friend WithEvents lblCodigoSocio As System.Windows.Forms.Label
    Friend WithEvents txtCodFinca As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigoFinca As System.Windows.Forms.Label
    Friend WithEvents txtCodSocio As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaContrato As System.Windows.Forms.TextBox
    Friend WithEvents lblFechaContrato As System.Windows.Forms.Label
    Friend WithEvents cmbTipoContrato As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoContrato As System.Windows.Forms.Label
    Friend WithEvents pbLimpiar As System.Windows.Forms.PictureBox
    Friend WithEvents pbRegistrar As System.Windows.Forms.PictureBox
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents gpbBuscarSocio As System.Windows.Forms.GroupBox
    Friend WithEvents lblCriterio As System.Windows.Forms.Label
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents txtCriterio As System.Windows.Forms.TextBox
    Friend WithEvents pbRegresarBuscarFinca As System.Windows.Forms.PictureBox

End Class
