<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlFactura))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pbRegresar = New System.Windows.Forms.PictureBox
        Me.gpbRegistrarFactura = New System.Windows.Forms.GroupBox
        Me.cmbTipo = New System.Windows.Forms.ComboBox
        Me.lblTipo = New System.Windows.Forms.Label
        Me.pbImprimirRecibo = New System.Windows.Forms.PictureBox
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.lblMonto = New System.Windows.Forms.Label
        Me.pbLimpiar = New System.Windows.Forms.PictureBox
        Me.pbRegistrar = New System.Windows.Forms.PictureBox
        Me.txtFecha = New System.Windows.Forms.TextBox
        Me.lblFecha = New System.Windows.Forms.Label
        Me.txtConcepto = New System.Windows.Forms.TextBox
        Me.lblConcepto = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.txtFactura = New System.Windows.Forms.TextBox
        Me.lblFactura = New System.Windows.Forms.Label
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbRegistrarFactura.SuspendLayout()
        CType(Me.pbImprimirRecibo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbRegresar)
        Me.Panel1.Controls.Add(Me.gpbRegistrarFactura)
        Me.Panel1.Location = New System.Drawing.Point(65, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(905, 513)
        Me.Panel1.TabIndex = 0
        '
        'pbRegresar
        '
        Me.pbRegresar.BackgroundImage = CType(resources.GetObject("pbRegresar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresar.Location = New System.Drawing.Point(687, 39)
        Me.pbRegresar.Name = "pbRegresar"
        Me.pbRegresar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegresar.TabIndex = 3
        Me.pbRegresar.TabStop = False
        Me.help.SetToolTip(Me.pbRegresar, "Regresar")
        '
        'gpbRegistrarFactura
        '
        Me.gpbRegistrarFactura.Controls.Add(Me.cmbTipo)
        Me.gpbRegistrarFactura.Controls.Add(Me.lblTipo)
        Me.gpbRegistrarFactura.Controls.Add(Me.pbImprimirRecibo)
        Me.gpbRegistrarFactura.Controls.Add(Me.txtMonto)
        Me.gpbRegistrarFactura.Controls.Add(Me.lblMonto)
        Me.gpbRegistrarFactura.Controls.Add(Me.pbLimpiar)
        Me.gpbRegistrarFactura.Controls.Add(Me.pbRegistrar)
        Me.gpbRegistrarFactura.Controls.Add(Me.txtFecha)
        Me.gpbRegistrarFactura.Controls.Add(Me.lblFecha)
        Me.gpbRegistrarFactura.Controls.Add(Me.txtConcepto)
        Me.gpbRegistrarFactura.Controls.Add(Me.lblConcepto)
        Me.gpbRegistrarFactura.Controls.Add(Me.txtNombre)
        Me.gpbRegistrarFactura.Controls.Add(Me.lblNombre)
        Me.gpbRegistrarFactura.Controls.Add(Me.txtFactura)
        Me.gpbRegistrarFactura.Controls.Add(Me.lblFactura)
        Me.gpbRegistrarFactura.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbRegistrarFactura.Location = New System.Drawing.Point(201, 66)
        Me.gpbRegistrarFactura.Name = "gpbRegistrarFactura"
        Me.gpbRegistrarFactura.Size = New System.Drawing.Size(516, 377)
        Me.gpbRegistrarFactura.TabIndex = 2
        Me.gpbRegistrarFactura.TabStop = False
        Me.gpbRegistrarFactura.Text = "Registrar Factura"
        '
        'cmbTipo
        '
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Items.AddRange(New Object() {"--SELECCIONAR--", "INSPECCIÓN", "CONVENIO CCSS"})
        Me.cmbTipo.Location = New System.Drawing.Point(193, 166)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(233, 27)
        Me.cmbTipo.TabIndex = 35
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(43, 174)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(41, 19)
        Me.lblTipo.TabIndex = 34
        Me.lblTipo.Text = "Tipo"
        '
        'pbImprimirRecibo
        '
        Me.pbImprimirRecibo.BackgroundImage = CType(resources.GetObject("pbImprimirRecibo.BackgroundImage"), System.Drawing.Image)
        Me.pbImprimirRecibo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbImprimirRecibo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbImprimirRecibo.Enabled = False
        Me.pbImprimirRecibo.Location = New System.Drawing.Point(303, 329)
        Me.pbImprimirRecibo.Name = "pbImprimirRecibo"
        Me.pbImprimirRecibo.Size = New System.Drawing.Size(30, 30)
        Me.pbImprimirRecibo.TabIndex = 33
        Me.pbImprimirRecibo.TabStop = False
        Me.help.SetToolTip(Me.pbImprimirRecibo, "Imprimir recibo")
        '
        'txtMonto
        '
        Me.txtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMonto.Location = New System.Drawing.Point(193, 296)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(233, 27)
        Me.txtMonto.TabIndex = 24
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(43, 299)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(53, 19)
        Me.lblMonto.TabIndex = 23
        Me.lblMonto.Text = "Monto"
        '
        'pbLimpiar
        '
        Me.pbLimpiar.BackgroundImage = CType(resources.GetObject("pbLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.pbLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbLimpiar.Location = New System.Drawing.Point(396, 329)
        Me.pbLimpiar.Name = "pbLimpiar"
        Me.pbLimpiar.Size = New System.Drawing.Size(30, 30)
        Me.pbLimpiar.TabIndex = 22
        Me.pbLimpiar.TabStop = False
        Me.help.SetToolTip(Me.pbLimpiar, "Limpiar")
        '
        'pbRegistrar
        '
        Me.pbRegistrar.BackgroundImage = CType(resources.GetObject("pbRegistrar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegistrar.Location = New System.Drawing.Point(349, 329)
        Me.pbRegistrar.Name = "pbRegistrar"
        Me.pbRegistrar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegistrar.TabIndex = 21
        Me.pbRegistrar.TabStop = False
        Me.help.SetToolTip(Me.pbRegistrar, "Registrar")
        '
        'txtFecha
        '
        Me.txtFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFecha.Location = New System.Drawing.Point(193, 123)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(233, 27)
        Me.txtFecha.TabIndex = 9
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(43, 126)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(49, 19)
        Me.lblFecha.TabIndex = 8
        Me.lblFecha.Text = "Fecha"
        '
        'txtConcepto
        '
        Me.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConcepto.Enabled = False
        Me.txtConcepto.Location = New System.Drawing.Point(47, 232)
        Me.txtConcepto.Multiline = True
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.ReadOnly = True
        Me.txtConcepto.Size = New System.Drawing.Size(379, 53)
        Me.txtConcepto.TabIndex = 5
        '
        'lblConcepto
        '
        Me.lblConcepto.AutoSize = True
        Me.lblConcepto.Location = New System.Drawing.Point(43, 210)
        Me.lblConcepto.Name = "lblConcepto"
        Me.lblConcepto.Size = New System.Drawing.Size(75, 19)
        Me.lblConcepto.TabIndex = 4
        Me.lblConcepto.Text = "Concepto"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(193, 84)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(233, 27)
        Me.txtNombre.TabIndex = 3
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
        'txtFactura
        '
        Me.txtFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFactura.Location = New System.Drawing.Point(193, 42)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(233, 27)
        Me.txtFactura.TabIndex = 1
        '
        'lblFactura
        '
        Me.lblFactura.AutoSize = True
        Me.lblFactura.Location = New System.Drawing.Point(43, 50)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(60, 19)
        Me.lblFactura.TabIndex = 0
        Me.lblFactura.Text = "Factura"
        '
        'ctlFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlFactura"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbRegistrarFactura.ResumeLayout(False)
        Me.gpbRegistrarFactura.PerformLayout()
        CType(Me.pbImprimirRecibo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gpbRegistrarFactura As System.Windows.Forms.GroupBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents pbLimpiar As System.Windows.Forms.PictureBox
    Friend WithEvents pbRegistrar As System.Windows.Forms.PictureBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents lblConcepto As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtFactura As System.Windows.Forms.TextBox
    Friend WithEvents lblFactura As System.Windows.Forms.Label
    Friend WithEvents pbRegresar As System.Windows.Forms.PictureBox
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents pbImprimirRecibo As System.Windows.Forms.PictureBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox

End Class
