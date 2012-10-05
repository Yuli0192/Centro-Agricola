<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlRegistrarUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlRegistrarUsuario))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.gpbRegistrarUsuario = New System.Windows.Forms.GroupBox
        Me.pbLimpiar = New System.Windows.Forms.PictureBox
        Me.cmbRol = New System.Windows.Forms.ComboBox
        Me.pbRegistrar = New System.Windows.Forms.PictureBox
        Me.lblRol = New System.Windows.Forms.Label
        Me.lblCotrasenna = New System.Windows.Forms.Label
        Me.txtContrasenna = New System.Windows.Forms.TextBox
        Me.txtCedula = New System.Windows.Forms.TextBox
        Me.txtApellido1 = New System.Windows.Forms.TextBox
        Me.txtApellido2 = New System.Windows.Forms.TextBox
        Me.lblCedula = New System.Windows.Forms.Label
        Me.lblApellido2 = New System.Windows.Forms.Label
        Me.lblApellido1 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.pbRegresar = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        Me.gpbRegistrarUsuario.SuspendLayout()
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbRegresar)
        Me.Panel1.Controls.Add(Me.gpbRegistrarUsuario)
        Me.Panel1.Location = New System.Drawing.Point(117, 157)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(796, 504)
        Me.Panel1.TabIndex = 0
        '
        'gpbRegistrarUsuario
        '
        Me.gpbRegistrarUsuario.Controls.Add(Me.pbLimpiar)
        Me.gpbRegistrarUsuario.Controls.Add(Me.cmbRol)
        Me.gpbRegistrarUsuario.Controls.Add(Me.pbRegistrar)
        Me.gpbRegistrarUsuario.Controls.Add(Me.lblRol)
        Me.gpbRegistrarUsuario.Controls.Add(Me.lblCotrasenna)
        Me.gpbRegistrarUsuario.Controls.Add(Me.txtContrasenna)
        Me.gpbRegistrarUsuario.Controls.Add(Me.txtCedula)
        Me.gpbRegistrarUsuario.Controls.Add(Me.txtApellido1)
        Me.gpbRegistrarUsuario.Controls.Add(Me.txtApellido2)
        Me.gpbRegistrarUsuario.Controls.Add(Me.lblCedula)
        Me.gpbRegistrarUsuario.Controls.Add(Me.lblApellido2)
        Me.gpbRegistrarUsuario.Controls.Add(Me.lblApellido1)
        Me.gpbRegistrarUsuario.Controls.Add(Me.txtNombre)
        Me.gpbRegistrarUsuario.Controls.Add(Me.lblNombre)
        Me.gpbRegistrarUsuario.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbRegistrarUsuario.Location = New System.Drawing.Point(131, 45)
        Me.gpbRegistrarUsuario.Name = "gpbRegistrarUsuario"
        Me.gpbRegistrarUsuario.Size = New System.Drawing.Size(520, 400)
        Me.gpbRegistrarUsuario.TabIndex = 0
        Me.gpbRegistrarUsuario.TabStop = False
        Me.gpbRegistrarUsuario.Text = "Registrar Usuario"
        '
        'pbLimpiar
        '
        Me.pbLimpiar.BackgroundImage = CType(resources.GetObject("pbLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.pbLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbLimpiar.Location = New System.Drawing.Point(397, 337)
        Me.pbLimpiar.Name = "pbLimpiar"
        Me.pbLimpiar.Size = New System.Drawing.Size(30, 30)
        Me.pbLimpiar.TabIndex = 24
        Me.pbLimpiar.TabStop = False
        Me.help.SetToolTip(Me.pbLimpiar, "Limpiar")
        '
        'cmbRol
        '
        Me.cmbRol.DisplayMember = "Rol de usuario"
        Me.cmbRol.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRol.FormattingEnabled = True
        Me.cmbRol.Items.AddRange(New Object() {"---SELECCIONAR---", "PRESIDENTE", "ADMINISTRADOR", "ASISTENTE"})
        Me.cmbRol.Location = New System.Drawing.Point(238, 294)
        Me.cmbRol.Name = "cmbRol"
        Me.cmbRol.Size = New System.Drawing.Size(190, 27)
        Me.cmbRol.TabIndex = 76
        Me.cmbRol.ValueMember = "Rol de usuario"
        '
        'pbRegistrar
        '
        Me.pbRegistrar.BackgroundImage = CType(resources.GetObject("pbRegistrar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegistrar.Location = New System.Drawing.Point(350, 337)
        Me.pbRegistrar.Name = "pbRegistrar"
        Me.pbRegistrar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegistrar.TabIndex = 23
        Me.pbRegistrar.TabStop = False
        Me.help.SetToolTip(Me.pbRegistrar, "Registrar")
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRol.Location = New System.Drawing.Point(58, 302)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(32, 19)
        Me.lblRol.TabIndex = 83
        Me.lblRol.Text = "Rol"
        '
        'lblCotrasenna
        '
        Me.lblCotrasenna.AutoSize = True
        Me.lblCotrasenna.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCotrasenna.Location = New System.Drawing.Point(58, 247)
        Me.lblCotrasenna.Name = "lblCotrasenna"
        Me.lblCotrasenna.Size = New System.Drawing.Size(88, 19)
        Me.lblCotrasenna.TabIndex = 82
        Me.lblCotrasenna.Text = "Contraseña"
        '
        'txtContrasenna
        '
        Me.txtContrasenna.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasenna.Location = New System.Drawing.Point(238, 239)
        Me.txtContrasenna.MaxLength = 50
        Me.txtContrasenna.Name = "txtContrasenna"
        Me.txtContrasenna.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasenna.Size = New System.Drawing.Size(190, 27)
        Me.txtContrasenna.TabIndex = 75
        Me.txtContrasenna.UseSystemPasswordChar = True
        '
        'txtCedula
        '
        Me.txtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedula.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(238, 44)
        Me.txtCedula.MaxLength = 13
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(190, 27)
        Me.txtCedula.TabIndex = 70
        '
        'txtApellido1
        '
        Me.txtApellido1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellido1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido1.Location = New System.Drawing.Point(238, 139)
        Me.txtApellido1.MaxLength = 13
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(190, 27)
        Me.txtApellido1.TabIndex = 72
        '
        'txtApellido2
        '
        Me.txtApellido2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellido2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido2.Location = New System.Drawing.Point(238, 187)
        Me.txtApellido2.MaxLength = 13
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(190, 27)
        Me.txtApellido2.TabIndex = 73
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(58, 53)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(57, 19)
        Me.lblCedula.TabIndex = 80
        Me.lblCedula.Text = "Cédula"
        '
        'lblApellido2
        '
        Me.lblApellido2.AutoSize = True
        Me.lblApellido2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido2.Location = New System.Drawing.Point(58, 195)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(134, 19)
        Me.lblApellido2.TabIndex = 79
        Me.lblApellido2.Text = "Segundo Apellido"
        '
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido1.Location = New System.Drawing.Point(58, 147)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(119, 19)
        Me.lblApellido1.TabIndex = 78
        Me.lblApellido1.Text = "Primer Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(238, 93)
        Me.txtNombre.MaxLength = 30
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(190, 27)
        Me.txtNombre.TabIndex = 71
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(58, 101)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(66, 19)
        Me.lblNombre.TabIndex = 77
        Me.lblNombre.Text = "Nombre"
        '
        'pbRegresar
        '
        Me.pbRegresar.BackgroundImage = CType(resources.GetObject("pbRegresar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresar.Location = New System.Drawing.Point(621, 9)
        Me.pbRegresar.Name = "pbRegresar"
        Me.pbRegresar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegresar.TabIndex = 84
        Me.pbRegresar.TabStop = False
        Me.help.SetToolTip(Me.pbRegresar, "Regresar")
        '
        'ctlRegistrarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlRegistrarUsuario"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.Panel1.ResumeLayout(False)
        Me.gpbRegistrarUsuario.ResumeLayout(False)
        Me.gpbRegistrarUsuario.PerformLayout()
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gpbRegistrarUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents cmbRol As System.Windows.Forms.ComboBox
    Friend WithEvents lblRol As System.Windows.Forms.Label
    Friend WithEvents lblCotrasenna As System.Windows.Forms.Label
    Friend WithEvents txtContrasenna As System.Windows.Forms.TextBox
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido1 As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents lblApellido2 As System.Windows.Forms.Label
    Friend WithEvents lblApellido1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents pbLimpiar As System.Windows.Forms.PictureBox
    Friend WithEvents pbRegistrar As System.Windows.Forms.PictureBox
    Friend WithEvents pbRegresar As System.Windows.Forms.PictureBox

End Class
