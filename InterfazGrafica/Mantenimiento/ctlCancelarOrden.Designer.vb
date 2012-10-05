<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlCancelarOrden
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlCancelarOrden))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pbRegresar = New System.Windows.Forms.PictureBox
        Me.gpbCancelarOrden = New System.Windows.Forms.GroupBox
        Me.pbImprimir = New System.Windows.Forms.PictureBox
        Me.gpbOrdenesCanceladas = New System.Windows.Forms.GroupBox
        Me.dgvOrden = New System.Windows.Forms.DataGridView
        Me.pbCancelar = New System.Windows.Forms.PictureBox
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
        Me.gpbCancelarOrden.SuspendLayout()
        CType(Me.pbImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbOrdenesCanceladas.SuspendLayout()
        CType(Me.dgvOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbBuscarCliente.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbRegresar)
        Me.Panel1.Controls.Add(Me.gpbCancelarOrden)
        Me.Panel1.Controls.Add(Me.gpbBuscarCliente)
        Me.Panel1.Location = New System.Drawing.Point(3, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1006, 570)
        Me.Panel1.TabIndex = 0
        '
        'pbRegresar
        '
        Me.pbRegresar.BackgroundImage = CType(resources.GetObject("pbRegresar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresar.Location = New System.Drawing.Point(938, 12)
        Me.pbRegresar.Name = "pbRegresar"
        Me.pbRegresar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegresar.TabIndex = 28
        Me.pbRegresar.TabStop = False
        Me.help.SetToolTip(Me.pbRegresar, "Regresar")
        '
        'gpbCancelarOrden
        '
        Me.gpbCancelarOrden.Controls.Add(Me.pbImprimir)
        Me.gpbCancelarOrden.Controls.Add(Me.gpbOrdenesCanceladas)
        Me.gpbCancelarOrden.Controls.Add(Me.pbCancelar)
        Me.gpbCancelarOrden.Controls.Add(Me.txtMonto)
        Me.gpbCancelarOrden.Controls.Add(Me.lblMonto)
        Me.gpbCancelarOrden.Controls.Add(Me.txtAnno)
        Me.gpbCancelarOrden.Controls.Add(Me.lblAnno)
        Me.gpbCancelarOrden.Controls.Add(Me.cmbMes)
        Me.gpbCancelarOrden.Controls.Add(Me.lblMes)
        Me.gpbCancelarOrden.Controls.Add(Me.txtNombre)
        Me.gpbCancelarOrden.Controls.Add(Me.lblNombre)
        Me.gpbCancelarOrden.Controls.Add(Me.txtCedula)
        Me.gpbCancelarOrden.Controls.Add(Me.lblCedula)
        Me.gpbCancelarOrden.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbCancelarOrden.Location = New System.Drawing.Point(507, 48)
        Me.gpbCancelarOrden.Name = "gpbCancelarOrden"
        Me.gpbCancelarOrden.Size = New System.Drawing.Size(461, 506)
        Me.gpbCancelarOrden.TabIndex = 14
        Me.gpbCancelarOrden.TabStop = False
        Me.gpbCancelarOrden.Text = "Cancelar Orden"
        '
        'pbImprimir
        '
        Me.pbImprimir.BackgroundImage = CType(resources.GetObject("pbImprimir.BackgroundImage"), System.Drawing.Image)
        Me.pbImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbImprimir.Enabled = False
        Me.pbImprimir.Location = New System.Drawing.Point(369, 464)
        Me.pbImprimir.Name = "pbImprimir"
        Me.pbImprimir.Size = New System.Drawing.Size(30, 30)
        Me.pbImprimir.TabIndex = 26
        Me.pbImprimir.TabStop = False
        Me.help.SetToolTip(Me.pbImprimir, "Imprimir recibo")
        '
        'gpbOrdenesCanceladas
        '
        Me.gpbOrdenesCanceladas.Controls.Add(Me.dgvOrden)
        Me.gpbOrdenesCanceladas.Location = New System.Drawing.Point(30, 212)
        Me.gpbOrdenesCanceladas.Name = "gpbOrdenesCanceladas"
        Me.gpbOrdenesCanceladas.Size = New System.Drawing.Size(405, 246)
        Me.gpbOrdenesCanceladas.TabIndex = 26
        Me.gpbOrdenesCanceladas.TabStop = False
        Me.gpbOrdenesCanceladas.Text = "Ordenes Canceladas"
        '
        'dgvOrden
        '
        Me.dgvOrden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOrden.BackgroundColor = System.Drawing.Color.White
        Me.dgvOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrden.Location = New System.Drawing.Point(15, 38)
        Me.dgvOrden.Name = "dgvOrden"
        Me.dgvOrden.ReadOnly = True
        Me.dgvOrden.RowHeadersVisible = False
        Me.dgvOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrden.Size = New System.Drawing.Size(380, 202)
        Me.dgvOrden.TabIndex = 0
        '
        'pbCancelar
        '
        Me.pbCancelar.BackgroundImage = CType(resources.GetObject("pbCancelar.BackgroundImage"), System.Drawing.Image)
        Me.pbCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbCancelar.Location = New System.Drawing.Point(405, 464)
        Me.pbCancelar.Name = "pbCancelar"
        Me.pbCancelar.Size = New System.Drawing.Size(30, 30)
        Me.pbCancelar.TabIndex = 25
        Me.pbCancelar.TabStop = False
        Me.help.SetToolTip(Me.pbCancelar, "Cancelar orden")
        '
        'txtMonto
        '
        Me.txtMonto.Enabled = False
        Me.txtMonto.Location = New System.Drawing.Point(176, 179)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(125, 27)
        Me.txtMonto.TabIndex = 20
        Me.help.SetToolTip(Me.txtMonto, "10000")
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(26, 187)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(53, 19)
        Me.lblMonto.TabIndex = 19
        Me.lblMonto.Text = "Monto"
        '
        'txtAnno
        '
        Me.txtAnno.Enabled = False
        Me.txtAnno.Location = New System.Drawing.Point(176, 144)
        Me.txtAnno.Name = "txtAnno"
        Me.txtAnno.Size = New System.Drawing.Size(125, 27)
        Me.txtAnno.TabIndex = 18
        '
        'lblAnno
        '
        Me.lblAnno.AutoSize = True
        Me.lblAnno.Location = New System.Drawing.Point(26, 152)
        Me.lblAnno.Name = "lblAnno"
        Me.lblAnno.Size = New System.Drawing.Size(38, 19)
        Me.lblAnno.TabIndex = 17
        Me.lblAnno.Text = "Año"
        '
        'cmbMes
        '
        Me.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Location = New System.Drawing.Point(176, 106)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(249, 27)
        Me.cmbMes.TabIndex = 16
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Location = New System.Drawing.Point(26, 109)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(36, 19)
        Me.lblMes.TabIndex = 8
        Me.lblMes.Text = "Mes"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(176, 68)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(249, 27)
        Me.txtNombre.TabIndex = 7
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(26, 68)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(136, 19)
        Me.lblNombre.TabIndex = 6
        Me.lblNombre.Text = "Nombre completo"
        '
        'txtCedula
        '
        Me.txtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedula.Enabled = False
        Me.txtCedula.Location = New System.Drawing.Point(176, 29)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(249, 27)
        Me.txtCedula.TabIndex = 5
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Location = New System.Drawing.Point(26, 37)
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
        Me.gpbBuscarCliente.Location = New System.Drawing.Point(18, 48)
        Me.gpbBuscarCliente.Name = "gpbBuscarCliente"
        Me.gpbBuscarCliente.Size = New System.Drawing.Size(466, 506)
        Me.gpbBuscarCliente.TabIndex = 4
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
        Me.dgvDatos.Location = New System.Drawing.Point(6, 96)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.RowHeadersVisible = False
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(442, 398)
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
        'ctlCancelarOrden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlCancelarOrden"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbCancelarOrden.ResumeLayout(False)
        Me.gpbCancelarOrden.PerformLayout()
        CType(Me.pbImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbOrdenesCanceladas.ResumeLayout(False)
        CType(Me.dgvOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbBuscarCliente.ResumeLayout(False)
        Me.gpbBuscarCliente.PerformLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gpbCancelarOrden As System.Windows.Forms.GroupBox
    Friend WithEvents pbCancelar As System.Windows.Forms.PictureBox
    Friend WithEvents help As System.Windows.Forms.ToolTip
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
    Friend WithEvents gpbBuscarCliente As System.Windows.Forms.GroupBox
    Friend WithEvents lblCriterio As System.Windows.Forms.Label
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents txtCriterio As System.Windows.Forms.TextBox
    Friend WithEvents pbRegresar As System.Windows.Forms.PictureBox
    Friend WithEvents gpbOrdenesCanceladas As System.Windows.Forms.GroupBox
    Friend WithEvents dgvOrden As System.Windows.Forms.DataGridView
    Friend WithEvents pbImprimir As System.Windows.Forms.PictureBox

End Class
