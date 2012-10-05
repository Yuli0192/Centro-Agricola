<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlRegistrarFeria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlRegistrarFeria))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.gpbBuscarFeria = New System.Windows.Forms.GroupBox
        Me.dgvDato = New System.Windows.Forms.DataGridView
        Me.txtNombreBuscar = New System.Windows.Forms.TextBox
        Me.lblNombreBuscar = New System.Windows.Forms.Label
        Me.pbRegresar = New System.Windows.Forms.PictureBox
        Me.gpbRegistrarFeria = New System.Windows.Forms.GroupBox
        Me.pbIrRegistrarSocio = New System.Windows.Forms.PictureBox
        Me.pbLimpiar = New System.Windows.Forms.PictureBox
        Me.pbRegistrar = New System.Windows.Forms.PictureBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.gpbBuscarFeria.SuspendLayout()
        CType(Me.dgvDato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbRegistrarFeria.SuspendLayout()
        CType(Me.pbIrRegistrarSocio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.gpbBuscarFeria)
        Me.Panel1.Controls.Add(Me.pbRegresar)
        Me.Panel1.Controls.Add(Me.gpbRegistrarFeria)
        Me.Panel1.Location = New System.Drawing.Point(141, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(703, 525)
        Me.Panel1.TabIndex = 0
        '
        'gpbBuscarFeria
        '
        Me.gpbBuscarFeria.Controls.Add(Me.dgvDato)
        Me.gpbBuscarFeria.Controls.Add(Me.txtNombreBuscar)
        Me.gpbBuscarFeria.Controls.Add(Me.lblNombreBuscar)
        Me.gpbBuscarFeria.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBuscarFeria.Location = New System.Drawing.Point(101, 217)
        Me.gpbBuscarFeria.Name = "gpbBuscarFeria"
        Me.gpbBuscarFeria.Size = New System.Drawing.Size(489, 293)
        Me.gpbBuscarFeria.TabIndex = 15
        Me.gpbBuscarFeria.TabStop = False
        Me.gpbBuscarFeria.Text = "Buscar Feria"
        '
        'dgvDato
        '
        Me.dgvDato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDato.BackgroundColor = System.Drawing.Color.White
        Me.dgvDato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDato.Location = New System.Drawing.Point(37, 63)
        Me.dgvDato.Name = "dgvDato"
        Me.dgvDato.RowHeadersVisible = False
        Me.dgvDato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDato.Size = New System.Drawing.Size(415, 214)
        Me.dgvDato.TabIndex = 4
        '
        'txtNombreBuscar
        '
        Me.txtNombreBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreBuscar.Location = New System.Drawing.Point(122, 30)
        Me.txtNombreBuscar.Name = "txtNombreBuscar"
        Me.txtNombreBuscar.Size = New System.Drawing.Size(225, 27)
        Me.txtNombreBuscar.TabIndex = 3
        Me.help.SetToolTip(Me.txtNombreBuscar, "Paraíso")
        '
        'lblNombreBuscar
        '
        Me.lblNombreBuscar.AutoSize = True
        Me.lblNombreBuscar.Location = New System.Drawing.Point(33, 38)
        Me.lblNombreBuscar.Name = "lblNombreBuscar"
        Me.lblNombreBuscar.Size = New System.Drawing.Size(71, 19)
        Me.lblNombreBuscar.TabIndex = 2
        Me.lblNombreBuscar.Text = "Nombre "
        '
        'pbRegresar
        '
        Me.pbRegresar.BackgroundImage = CType(resources.GetObject("pbRegresar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresar.Location = New System.Drawing.Point(670, 3)
        Me.pbRegresar.Name = "pbRegresar"
        Me.pbRegresar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegresar.TabIndex = 14
        Me.pbRegresar.TabStop = False
        Me.help.SetToolTip(Me.pbRegresar, "Regresar")
        '
        'gpbRegistrarFeria
        '
        Me.gpbRegistrarFeria.Controls.Add(Me.pbIrRegistrarSocio)
        Me.gpbRegistrarFeria.Controls.Add(Me.pbLimpiar)
        Me.gpbRegistrarFeria.Controls.Add(Me.pbRegistrar)
        Me.gpbRegistrarFeria.Controls.Add(Me.txtNombre)
        Me.gpbRegistrarFeria.Controls.Add(Me.lblNombre)
        Me.gpbRegistrarFeria.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbRegistrarFeria.Location = New System.Drawing.Point(101, 39)
        Me.gpbRegistrarFeria.Name = "gpbRegistrarFeria"
        Me.gpbRegistrarFeria.Size = New System.Drawing.Size(489, 172)
        Me.gpbRegistrarFeria.TabIndex = 0
        Me.gpbRegistrarFeria.TabStop = False
        Me.gpbRegistrarFeria.Text = "Registrar Feria"
        '
        'pbIrRegistrarSocio
        '
        Me.pbIrRegistrarSocio.BackgroundImage = CType(resources.GetObject("pbIrRegistrarSocio.BackgroundImage"), System.Drawing.Image)
        Me.pbIrRegistrarSocio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbIrRegistrarSocio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbIrRegistrarSocio.Location = New System.Drawing.Point(453, 13)
        Me.pbIrRegistrarSocio.Name = "pbIrRegistrarSocio"
        Me.pbIrRegistrarSocio.Size = New System.Drawing.Size(30, 30)
        Me.pbIrRegistrarSocio.TabIndex = 14
        Me.pbIrRegistrarSocio.TabStop = False
        Me.help.SetToolTip(Me.pbIrRegistrarSocio, "Ir a  registrar socio")
        '
        'pbLimpiar
        '
        Me.pbLimpiar.BackgroundImage = CType(resources.GetObject("pbLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.pbLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbLimpiar.Location = New System.Drawing.Point(390, 103)
        Me.pbLimpiar.Name = "pbLimpiar"
        Me.pbLimpiar.Size = New System.Drawing.Size(30, 30)
        Me.pbLimpiar.TabIndex = 13
        Me.pbLimpiar.TabStop = False
        Me.help.SetToolTip(Me.pbLimpiar, "Limpiar")
        '
        'pbRegistrar
        '
        Me.pbRegistrar.BackgroundImage = CType(resources.GetObject("pbRegistrar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegistrar.Location = New System.Drawing.Point(341, 103)
        Me.pbRegistrar.Name = "pbRegistrar"
        Me.pbRegistrar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegistrar.TabIndex = 12
        Me.pbRegistrar.TabStop = False
        Me.help.SetToolTip(Me.pbRegistrar, "Registrar")
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(162, 60)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(257, 27)
        Me.txtNombre.TabIndex = 1
        Me.help.SetToolTip(Me.txtNombre, "PARAISO")
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(67, 68)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(66, 19)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'ctlRegistrarFeria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlRegistrarFeria"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.Panel1.ResumeLayout(False)
        Me.gpbBuscarFeria.ResumeLayout(False)
        Me.gpbBuscarFeria.PerformLayout()
        CType(Me.dgvDato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbRegistrarFeria.ResumeLayout(False)
        Me.gpbRegistrarFeria.PerformLayout()
        CType(Me.pbIrRegistrarSocio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gpbRegistrarFeria As System.Windows.Forms.GroupBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents pbLimpiar As System.Windows.Forms.PictureBox
    Friend WithEvents pbRegistrar As System.Windows.Forms.PictureBox
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents pbRegresar As System.Windows.Forms.PictureBox
    Friend WithEvents gpbBuscarFeria As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDato As System.Windows.Forms.DataGridView
    Friend WithEvents txtNombreBuscar As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreBuscar As System.Windows.Forms.Label
    Friend WithEvents pbIrRegistrarSocio As System.Windows.Forms.PictureBox

End Class
