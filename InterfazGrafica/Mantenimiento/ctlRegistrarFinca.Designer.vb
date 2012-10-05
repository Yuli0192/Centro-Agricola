<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlRegistrarFinca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlRegistrarFinca))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.gpbRegistrarFinca = New System.Windows.Forms.GroupBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblDireccion = New System.Windows.Forms.Label
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.lblArea = New System.Windows.Forms.Label
        Me.txtArea = New System.Windows.Forms.TextBox
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.pbLimpiar = New System.Windows.Forms.PictureBox
        Me.pbRegistrar = New System.Windows.Forms.PictureBox
        Me.pbRegresar = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        Me.gpbRegistrarFinca.SuspendLayout()
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbRegresar)
        Me.Panel1.Controls.Add(Me.gpbRegistrarFinca)
        Me.Panel1.Location = New System.Drawing.Point(188, 119)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(703, 533)
        Me.Panel1.TabIndex = 0
        '
        'gpbRegistrarFinca
        '
        Me.gpbRegistrarFinca.Controls.Add(Me.pbLimpiar)
        Me.gpbRegistrarFinca.Controls.Add(Me.pbRegistrar)
        Me.gpbRegistrarFinca.Controls.Add(Me.txtArea)
        Me.gpbRegistrarFinca.Controls.Add(Me.lblArea)
        Me.gpbRegistrarFinca.Controls.Add(Me.txtDireccion)
        Me.gpbRegistrarFinca.Controls.Add(Me.lblDireccion)
        Me.gpbRegistrarFinca.Controls.Add(Me.txtNombre)
        Me.gpbRegistrarFinca.Controls.Add(Me.lblNombre)
        Me.gpbRegistrarFinca.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbRegistrarFinca.Location = New System.Drawing.Point(104, 49)
        Me.gpbRegistrarFinca.Name = "gpbRegistrarFinca"
        Me.gpbRegistrarFinca.Size = New System.Drawing.Size(512, 365)
        Me.gpbRegistrarFinca.TabIndex = 0
        Me.gpbRegistrarFinca.TabStop = False
        Me.gpbRegistrarFinca.Text = "Registrar Finca"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(80, 69)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(66, 19)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(171, 66)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(229, 27)
        Me.txtNombre.TabIndex = 1
        Me.help.SetToolTip(Me.txtNombre, "EL YAS")
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(80, 126)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(74, 19)
        Me.lblDireccion.TabIndex = 2
        Me.lblDireccion.Text = "Dirección"
        '
        'txtDireccion
        '
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Location = New System.Drawing.Point(84, 148)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(316, 67)
        Me.txtDireccion.TabIndex = 3
        Me.help.SetToolTip(Me.txtDireccion, "200 METROS SUR DELEGACION DEL YAS.")
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(80, 270)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(42, 19)
        Me.lblArea.TabIndex = 4
        Me.lblArea.Text = "Area"
        '
        'txtArea
        '
        Me.txtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArea.Location = New System.Drawing.Point(171, 262)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(229, 27)
        Me.txtArea.TabIndex = 5
        Me.help.SetToolTip(Me.txtArea, "1500")
        '
        'pbLimpiar
        '
        Me.pbLimpiar.BackgroundImage = CType(resources.GetObject("pbLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.pbLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbLimpiar.Location = New System.Drawing.Point(370, 295)
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
        Me.pbRegistrar.Location = New System.Drawing.Point(334, 295)
        Me.pbRegistrar.Name = "pbRegistrar"
        Me.pbRegistrar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegistrar.TabIndex = 25
        Me.pbRegistrar.TabStop = False
        Me.help.SetToolTip(Me.pbRegistrar, "Registrar")
        '
        'pbRegresar
        '
        Me.pbRegresar.BackgroundImage = CType(resources.GetObject("pbRegresar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresar.Location = New System.Drawing.Point(670, 13)
        Me.pbRegresar.Name = "pbRegresar"
        Me.pbRegresar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegresar.TabIndex = 3
        Me.pbRegresar.TabStop = False
        Me.help.SetToolTip(Me.pbRegresar, "Regresar")
        '
        'ctlRegistrarFinca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlRegistrarFinca"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.Panel1.ResumeLayout(False)
        Me.gpbRegistrarFinca.ResumeLayout(False)
        Me.gpbRegistrarFinca.PerformLayout()
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gpbRegistrarFinca As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtArea As System.Windows.Forms.TextBox
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents pbLimpiar As System.Windows.Forms.PictureBox
    Friend WithEvents pbRegistrar As System.Windows.Forms.PictureBox
    Friend WithEvents pbRegresar As System.Windows.Forms.PictureBox

End Class
