<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlBuscarInspeccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlBuscarInspeccion))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pbRegresar = New System.Windows.Forms.PictureBox
        Me.gpbPermiso = New System.Windows.Forms.GroupBox
        Me.txtFechaVence = New System.Windows.Forms.TextBox
        Me.txtFechaCrea = New System.Windows.Forms.TextBox
        Me.txtCedula = New System.Windows.Forms.TextBox
        Me.lblCedula = New System.Windows.Forms.Label
        Me.txtCodPermiso = New System.Windows.Forms.TextBox
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.pbImprimir = New System.Windows.Forms.PictureBox
        Me.lblFechaVencePermiso = New System.Windows.Forms.Label
        Me.lblFechaCreaPermiso = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.gpbBuscarSocio = New System.Windows.Forms.GroupBox
        Me.lblCriterio = New System.Windows.Forms.Label
        Me.dgvDatos = New System.Windows.Forms.DataGridView
        Me.txtCriterio = New System.Windows.Forms.TextBox
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbPermiso.SuspendLayout()
        CType(Me.pbImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbBuscarSocio.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbRegresar)
        Me.Panel1.Controls.Add(Me.gpbPermiso)
        Me.Panel1.Controls.Add(Me.gpbBuscarSocio)
        Me.Panel1.Location = New System.Drawing.Point(3, 104)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1021, 607)
        Me.Panel1.TabIndex = 0
        '
        'pbRegresar
        '
        Me.pbRegresar.BackgroundImage = CType(resources.GetObject("pbRegresar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresar.Location = New System.Drawing.Point(980, 3)
        Me.pbRegresar.Name = "pbRegresar"
        Me.pbRegresar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegresar.TabIndex = 15
        Me.pbRegresar.TabStop = False
        Me.help.SetToolTip(Me.pbRegresar, "Regresar")
        '
        'gpbPermiso
        '
        Me.gpbPermiso.Controls.Add(Me.txtFechaVence)
        Me.gpbPermiso.Controls.Add(Me.txtFechaCrea)
        Me.gpbPermiso.Controls.Add(Me.txtCedula)
        Me.gpbPermiso.Controls.Add(Me.lblCedula)
        Me.gpbPermiso.Controls.Add(Me.txtCodPermiso)
        Me.gpbPermiso.Controls.Add(Me.lblCodigo)
        Me.gpbPermiso.Controls.Add(Me.pbImprimir)
        Me.gpbPermiso.Controls.Add(Me.lblFechaVencePermiso)
        Me.gpbPermiso.Controls.Add(Me.lblFechaCreaPermiso)
        Me.gpbPermiso.Controls.Add(Me.txtNombre)
        Me.gpbPermiso.Controls.Add(Me.lblNombre)
        Me.gpbPermiso.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbPermiso.Location = New System.Drawing.Point(558, 28)
        Me.gpbPermiso.Name = "gpbPermiso"
        Me.gpbPermiso.Size = New System.Drawing.Size(452, 396)
        Me.gpbPermiso.TabIndex = 5
        Me.gpbPermiso.TabStop = False
        Me.gpbPermiso.Text = "Inspección"
        '
        'txtFechaVence
        '
        Me.txtFechaVence.Location = New System.Drawing.Point(168, 262)
        Me.txtFechaVence.Name = "txtFechaVence"
        Me.txtFechaVence.Size = New System.Drawing.Size(133, 27)
        Me.txtFechaVence.TabIndex = 31
        '
        'txtFechaCrea
        '
        Me.txtFechaCrea.Location = New System.Drawing.Point(168, 210)
        Me.txtFechaCrea.Name = "txtFechaCrea"
        Me.txtFechaCrea.Size = New System.Drawing.Size(133, 27)
        Me.txtFechaCrea.TabIndex = 30
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(168, 104)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(223, 27)
        Me.txtCedula.TabIndex = 29
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Location = New System.Drawing.Point(18, 107)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(103, 19)
        Me.lblCedula.TabIndex = 28
        Me.lblCedula.Text = "Identificación"
        '
        'txtCodPermiso
        '
        Me.txtCodPermiso.Location = New System.Drawing.Point(168, 51)
        Me.txtCodPermiso.Name = "txtCodPermiso"
        Me.txtCodPermiso.Size = New System.Drawing.Size(223, 27)
        Me.txtCodPermiso.TabIndex = 27
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(18, 59)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(69, 19)
        Me.lblCodigo.TabIndex = 26
        Me.lblCodigo.Text = "Solicitud"
        '
        'pbImprimir
        '
        Me.pbImprimir.BackgroundImage = CType(resources.GetObject("pbImprimir.BackgroundImage"), System.Drawing.Image)
        Me.pbImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbImprimir.Location = New System.Drawing.Point(412, 330)
        Me.pbImprimir.Name = "pbImprimir"
        Me.pbImprimir.Size = New System.Drawing.Size(30, 30)
        Me.pbImprimir.TabIndex = 25
        Me.pbImprimir.TabStop = False
        Me.help.SetToolTip(Me.pbImprimir, "Imprimir")
        '
        'lblFechaVencePermiso
        '
        Me.lblFechaVencePermiso.AutoSize = True
        Me.lblFechaVencePermiso.Location = New System.Drawing.Point(18, 268)
        Me.lblFechaVencePermiso.Name = "lblFechaVencePermiso"
        Me.lblFechaVencePermiso.Size = New System.Drawing.Size(99, 19)
        Me.lblFechaVencePermiso.TabIndex = 22
        Me.lblFechaVencePermiso.Text = "Fecha vence "
        '
        'lblFechaCreaPermiso
        '
        Me.lblFechaCreaPermiso.AutoSize = True
        Me.lblFechaCreaPermiso.Location = New System.Drawing.Point(18, 213)
        Me.lblFechaCreaPermiso.Name = "lblFechaCreaPermiso"
        Me.lblFechaCreaPermiso.Size = New System.Drawing.Size(88, 19)
        Me.lblFechaCreaPermiso.TabIndex = 20
        Me.lblFechaCreaPermiso.Text = "Fecha crea "
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(168, 156)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(274, 27)
        Me.txtNombre.TabIndex = 13
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(18, 156)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(139, 19)
        Me.lblNombre.TabIndex = 12
        Me.lblNombre.Text = "Nombre Completo"
        '
        'gpbBuscarSocio
        '
        Me.gpbBuscarSocio.Controls.Add(Me.lblCriterio)
        Me.gpbBuscarSocio.Controls.Add(Me.dgvDatos)
        Me.gpbBuscarSocio.Controls.Add(Me.txtCriterio)
        Me.gpbBuscarSocio.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBuscarSocio.Location = New System.Drawing.Point(13, 28)
        Me.gpbBuscarSocio.Name = "gpbBuscarSocio"
        Me.gpbBuscarSocio.Size = New System.Drawing.Size(539, 449)
        Me.gpbBuscarSocio.TabIndex = 4
        Me.gpbBuscarSocio.TabStop = False
        Me.gpbBuscarSocio.Text = "Buscar Inspección"
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
        Me.dgvDatos.Location = New System.Drawing.Point(0, 84)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.RowHeadersVisible = False
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(533, 355)
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
        'ctlBuscarInspeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlBuscarInspeccion"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbPermiso.ResumeLayout(False)
        Me.gpbPermiso.PerformLayout()
        CType(Me.pbImprimir, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents gpbPermiso As System.Windows.Forms.GroupBox
    Friend WithEvents txtFechaVence As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaCrea As System.Windows.Forms.TextBox
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents txtCodPermiso As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents pbImprimir As System.Windows.Forms.PictureBox
    Friend WithEvents lblFechaVencePermiso As System.Windows.Forms.Label
    Friend WithEvents lblFechaCreaPermiso As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents pbRegresar As System.Windows.Forms.PictureBox

End Class
