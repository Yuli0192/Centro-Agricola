<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlRegistrarOrden
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlRegistrarOrden))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pbRegresar = New System.Windows.Forms.PictureBox
        Me.gpbRegistrarOrden = New System.Windows.Forms.GroupBox
        Me.pbImprimir = New System.Windows.Forms.PictureBox
        Me.txtSalarioBase = New System.Windows.Forms.TextBox
        Me.lblSalarioBase = New System.Windows.Forms.Label
        Me.pbLimpiar = New System.Windows.Forms.PictureBox
        Me.pbRegistrar = New System.Windows.Forms.PictureBox
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.lblMonto = New System.Windows.Forms.Label
        Me.txtAnno = New System.Windows.Forms.TextBox
        Me.lblAnno = New System.Windows.Forms.Label
        Me.cmbMes = New System.Windows.Forms.ComboBox
        Me.lblMes = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.txtCedula = New System.Windows.Forms.TextBox
        Me.lblCedula = New System.Windows.Forms.Label
        Me.gpbBuscarCliente = New System.Windows.Forms.GroupBox
        Me.lblCriterio = New System.Windows.Forms.Label
        Me.dgvDatos = New System.Windows.Forms.DataGridView
        Me.txtCriterio = New System.Windows.Forms.TextBox
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbRegistrarOrden.SuspendLayout()
        CType(Me.pbImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbBuscarCliente.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbRegresar)
        Me.Panel1.Controls.Add(Me.gpbRegistrarOrden)
        Me.Panel1.Controls.Add(Me.gpbBuscarCliente)
        Me.Panel1.Location = New System.Drawing.Point(18, 127)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(991, 492)
        Me.Panel1.TabIndex = 0
        '
        'pbRegresar
        '
        Me.pbRegresar.BackgroundImage = CType(resources.GetObject("pbRegresar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresar.Location = New System.Drawing.Point(936, 3)
        Me.pbRegresar.Name = "pbRegresar"
        Me.pbRegresar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegresar.TabIndex = 27
        Me.pbRegresar.TabStop = False
        Me.help.SetToolTip(Me.pbRegresar, "Regresar")
        '
        'gpbRegistrarOrden
        '
        Me.gpbRegistrarOrden.Controls.Add(Me.pbImprimir)
        Me.gpbRegistrarOrden.Controls.Add(Me.txtSalarioBase)
        Me.gpbRegistrarOrden.Controls.Add(Me.lblSalarioBase)
        Me.gpbRegistrarOrden.Controls.Add(Me.pbLimpiar)
        Me.gpbRegistrarOrden.Controls.Add(Me.pbRegistrar)
        Me.gpbRegistrarOrden.Controls.Add(Me.txtMonto)
        Me.gpbRegistrarOrden.Controls.Add(Me.lblMonto)
        Me.gpbRegistrarOrden.Controls.Add(Me.txtAnno)
        Me.gpbRegistrarOrden.Controls.Add(Me.lblAnno)
        Me.gpbRegistrarOrden.Controls.Add(Me.cmbMes)
        Me.gpbRegistrarOrden.Controls.Add(Me.lblMes)
        Me.gpbRegistrarOrden.Controls.Add(Me.txtNombre)
        Me.gpbRegistrarOrden.Controls.Add(Me.lblNombre)
        Me.gpbRegistrarOrden.Controls.Add(Me.txtCedula)
        Me.gpbRegistrarOrden.Controls.Add(Me.lblCedula)
        Me.gpbRegistrarOrden.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbRegistrarOrden.Location = New System.Drawing.Point(505, 49)
        Me.gpbRegistrarOrden.Name = "gpbRegistrarOrden"
        Me.gpbRegistrarOrden.Size = New System.Drawing.Size(461, 397)
        Me.gpbRegistrarOrden.TabIndex = 4
        Me.gpbRegistrarOrden.TabStop = False
        Me.gpbRegistrarOrden.Text = "Orden"
        '
        'pbImprimir
        '
        Me.pbImprimir.BackgroundImage = CType(resources.GetObject("pbImprimir.BackgroundImage"), System.Drawing.Image)
        Me.pbImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbImprimir.Location = New System.Drawing.Point(303, 357)
        Me.pbImprimir.Name = "pbImprimir"
        Me.pbImprimir.Size = New System.Drawing.Size(30, 30)
        Me.pbImprimir.TabIndex = 29
        Me.pbImprimir.TabStop = False
        Me.help.SetToolTip(Me.pbImprimir, "Imprimir lista")
        '
        'txtSalarioBase
        '
        Me.txtSalarioBase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSalarioBase.Location = New System.Drawing.Point(176, 288)
        Me.txtSalarioBase.Name = "txtSalarioBase"
        Me.txtSalarioBase.Size = New System.Drawing.Size(139, 27)
        Me.txtSalarioBase.TabIndex = 28
        Me.txtSalarioBase.Text = "110000"
        Me.help.SetToolTip(Me.txtSalarioBase, "72017")
        '
        'lblSalarioBase
        '
        Me.lblSalarioBase.AutoSize = True
        Me.lblSalarioBase.Location = New System.Drawing.Point(26, 296)
        Me.lblSalarioBase.Name = "lblSalarioBase"
        Me.lblSalarioBase.Size = New System.Drawing.Size(62, 19)
        Me.lblSalarioBase.TabIndex = 27
        Me.lblSalarioBase.Text = "Salario "
        '
        'pbLimpiar
        '
        Me.pbLimpiar.BackgroundImage = CType(resources.GetObject("pbLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.pbLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbLimpiar.Location = New System.Drawing.Point(397, 357)
        Me.pbLimpiar.Name = "pbLimpiar"
        Me.pbLimpiar.Size = New System.Drawing.Size(30, 30)
        Me.pbLimpiar.TabIndex = 26
        Me.pbLimpiar.TabStop = False
        Me.help.SetToolTip(Me.pbLimpiar, "Limpiar")
        '
        'pbRegistrar
        '
        Me.pbRegistrar.BackgroundImage = CType(resources.GetObject("pbRegistrar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegistrar.Location = New System.Drawing.Point(350, 357)
        Me.pbRegistrar.Name = "pbRegistrar"
        Me.pbRegistrar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegistrar.TabIndex = 25
        Me.pbRegistrar.TabStop = False
        Me.help.SetToolTip(Me.pbRegistrar, "Registrar")
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(176, 246)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(139, 27)
        Me.txtMonto.TabIndex = 20
        Me.txtMonto.Text = "11000"
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(26, 254)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(53, 19)
        Me.lblMonto.TabIndex = 19
        Me.lblMonto.Text = "Monto"
        '
        'txtAnno
        '
        Me.txtAnno.Location = New System.Drawing.Point(176, 195)
        Me.txtAnno.Name = "txtAnno"
        Me.txtAnno.Size = New System.Drawing.Size(139, 27)
        Me.txtAnno.TabIndex = 18
        '
        'lblAnno
        '
        Me.lblAnno.AutoSize = True
        Me.lblAnno.Location = New System.Drawing.Point(26, 203)
        Me.lblAnno.Name = "lblAnno"
        Me.lblAnno.Size = New System.Drawing.Size(38, 19)
        Me.lblAnno.TabIndex = 17
        Me.lblAnno.Text = "Año"
        '
        'cmbMes
        '
        Me.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Items.AddRange(New Object() {"--SELECCIONAR--", "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SETIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cmbMes.Location = New System.Drawing.Point(176, 145)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(249, 27)
        Me.cmbMes.TabIndex = 16
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Location = New System.Drawing.Point(26, 148)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(36, 19)
        Me.lblMes.TabIndex = 8
        Me.lblMes.Text = "Mes"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(176, 95)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(249, 27)
        Me.txtNombre.TabIndex = 7
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(26, 95)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(136, 19)
        Me.lblNombre.TabIndex = 6
        Me.lblNombre.Text = "Nombre completo"
        '
        'txtCedula
        '
        Me.txtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedula.Enabled = False
        Me.txtCedula.Location = New System.Drawing.Point(178, 44)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(249, 27)
        Me.txtCedula.TabIndex = 5
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Location = New System.Drawing.Point(28, 52)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(103, 19)
        Me.lblCedula.TabIndex = 4
        Me.lblCedula.Text = "Identificación"
        '
        'gpbBuscarCliente
        '
        Me.gpbBuscarCliente.Controls.Add(Me.lblCriterio)
        Me.gpbBuscarCliente.Controls.Add(Me.dgvDatos)
        Me.gpbBuscarCliente.Controls.Add(Me.txtCriterio)
        Me.gpbBuscarCliente.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBuscarCliente.Location = New System.Drawing.Point(14, 49)
        Me.gpbBuscarCliente.Name = "gpbBuscarCliente"
        Me.gpbBuscarCliente.Size = New System.Drawing.Size(466, 404)
        Me.gpbBuscarCliente.TabIndex = 3
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
        Me.dgvDatos.Size = New System.Drawing.Size(442, 266)
        Me.dgvDatos.TabIndex = 3
        '
        'txtCriterio
        '
        Me.txtCriterio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCriterio.Location = New System.Drawing.Point(166, 51)
        Me.txtCriterio.Name = "txtCriterio"
        Me.txtCriterio.Size = New System.Drawing.Size(234, 27)
        Me.txtCriterio.TabIndex = 2
        Me.help.SetToolTip(Me.txtCriterio, "3224567 o ARIAS VARELA MANUEL")
        '
        'ctlRegistrarOrden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlRegistrarOrden"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbRegistrarOrden.ResumeLayout(False)
        Me.gpbRegistrarOrden.PerformLayout()
        CType(Me.pbImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbBuscarCliente.ResumeLayout(False)
        Me.gpbBuscarCliente.PerformLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gpbBuscarCliente As System.Windows.Forms.GroupBox
    Friend WithEvents lblCriterio As System.Windows.Forms.Label
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents txtCriterio As System.Windows.Forms.TextBox
    Friend WithEvents gpbRegistrarOrden As System.Windows.Forms.GroupBox
    Friend WithEvents pbLimpiar As System.Windows.Forms.PictureBox
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents pbRegistrar As System.Windows.Forms.PictureBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents txtAnno As System.Windows.Forms.TextBox
    Friend WithEvents lblAnno As System.Windows.Forms.Label
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents lblMes As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents pbRegresar As System.Windows.Forms.PictureBox
    Friend WithEvents txtSalarioBase As System.Windows.Forms.TextBox
    Friend WithEvents lblSalarioBase As System.Windows.Forms.Label
    Friend WithEvents pbImprimir As System.Windows.Forms.PictureBox

End Class
