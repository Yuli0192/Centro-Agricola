<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlRegistrarSocio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlRegistrarSocio))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pbRegresar = New System.Windows.Forms.PictureBox
        Me.gpbRegistrarSocio = New System.Windows.Forms.GroupBox
        Me.gpbFerias = New System.Windows.Forms.GroupBox
        Me.pbIrRegistrarFeria = New System.Windows.Forms.PictureBox
        Me.pbQuitar = New System.Windows.Forms.PictureBox
        Me.pbInsertar = New System.Windows.Forms.PictureBox
        Me.lblFeriaAsiste = New System.Windows.Forms.Label
        Me.ltbFeriaAsiste = New System.Windows.Forms.ListBox
        Me.ltbFeria = New System.Windows.Forms.ListBox
        Me.lblFeria = New System.Windows.Forms.Label
        Me.pbLimpiar = New System.Windows.Forms.PictureBox
        Me.pbRegistrar = New System.Windows.Forms.PictureBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.txtCorreo = New System.Windows.Forms.TextBox
        Me.lblCorreo = New System.Windows.Forms.Label
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.lblTelefono = New System.Windows.Forms.Label
        Me.txtDireccionCasa = New System.Windows.Forms.TextBox
        Me.lblDireccionCasa = New System.Windows.Forms.Label
        Me.txtDireccionFinca = New System.Windows.Forms.TextBox
        Me.lblDireccionFinca = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.txtCedula = New System.Windows.Forms.TextBox
        Me.lblCedula = New System.Windows.Forms.Label
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtNombreBuscar = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbRegistrarSocio.SuspendLayout()
        Me.gpbFerias.SuspendLayout()
        CType(Me.pbIrRegistrarFeria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbQuitar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbInsertar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.pbRegresar)
        Me.Panel1.Controls.Add(Me.gpbRegistrarSocio)
        Me.Panel1.Location = New System.Drawing.Point(150, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(703, 611)
        Me.Panel1.TabIndex = 0
        '
        'pbRegresar
        '
        Me.pbRegresar.BackgroundImage = CType(resources.GetObject("pbRegresar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresar.Location = New System.Drawing.Point(670, 15)
        Me.pbRegresar.Name = "pbRegresar"
        Me.pbRegresar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegresar.TabIndex = 1
        Me.pbRegresar.TabStop = False
        Me.help.SetToolTip(Me.pbRegresar, "Regresar")
        '
        'gpbRegistrarSocio
        '
        Me.gpbRegistrarSocio.Controls.Add(Me.gpbFerias)
        Me.gpbRegistrarSocio.Controls.Add(Me.pbLimpiar)
        Me.gpbRegistrarSocio.Controls.Add(Me.pbRegistrar)
        Me.gpbRegistrarSocio.Controls.Add(Me.txtCodigo)
        Me.gpbRegistrarSocio.Controls.Add(Me.lblCodigo)
        Me.gpbRegistrarSocio.Controls.Add(Me.txtCorreo)
        Me.gpbRegistrarSocio.Controls.Add(Me.lblCorreo)
        Me.gpbRegistrarSocio.Controls.Add(Me.txtTelefono)
        Me.gpbRegistrarSocio.Controls.Add(Me.lblTelefono)
        Me.gpbRegistrarSocio.Controls.Add(Me.txtDireccionCasa)
        Me.gpbRegistrarSocio.Controls.Add(Me.lblDireccionCasa)
        Me.gpbRegistrarSocio.Controls.Add(Me.txtDireccionFinca)
        Me.gpbRegistrarSocio.Controls.Add(Me.lblDireccionFinca)
        Me.gpbRegistrarSocio.Controls.Add(Me.txtNombre)
        Me.gpbRegistrarSocio.Controls.Add(Me.lblNombre)
        Me.gpbRegistrarSocio.Controls.Add(Me.txtCedula)
        Me.gpbRegistrarSocio.Controls.Add(Me.lblCedula)
        Me.gpbRegistrarSocio.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbRegistrarSocio.Location = New System.Drawing.Point(78, 15)
        Me.gpbRegistrarSocio.Name = "gpbRegistrarSocio"
        Me.gpbRegistrarSocio.Size = New System.Drawing.Size(516, 574)
        Me.gpbRegistrarSocio.TabIndex = 0
        Me.gpbRegistrarSocio.TabStop = False
        Me.gpbRegistrarSocio.Text = "Registrar Socio"
        '
        'gpbFerias
        '
        Me.gpbFerias.Controls.Add(Me.txtNombreBuscar)
        Me.gpbFerias.Controls.Add(Me.pbIrRegistrarFeria)
        Me.gpbFerias.Controls.Add(Me.pbQuitar)
        Me.gpbFerias.Controls.Add(Me.pbInsertar)
        Me.gpbFerias.Controls.Add(Me.lblFeriaAsiste)
        Me.gpbFerias.Controls.Add(Me.ltbFeriaAsiste)
        Me.gpbFerias.Controls.Add(Me.ltbFeria)
        Me.gpbFerias.Controls.Add(Me.lblFeria)
        Me.gpbFerias.Location = New System.Drawing.Point(48, 367)
        Me.gpbFerias.Name = "gpbFerias"
        Me.gpbFerias.Size = New System.Drawing.Size(404, 165)
        Me.gpbFerias.TabIndex = 23
        Me.gpbFerias.TabStop = False
        Me.gpbFerias.Text = "Ferias"
        '
        'pbIrRegistrarFeria
        '
        Me.pbIrRegistrarFeria.BackgroundImage = CType(resources.GetObject("pbIrRegistrarFeria.BackgroundImage"), System.Drawing.Image)
        Me.pbIrRegistrarFeria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbIrRegistrarFeria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbIrRegistrarFeria.Location = New System.Drawing.Point(368, 12)
        Me.pbIrRegistrarFeria.Name = "pbIrRegistrarFeria"
        Me.pbIrRegistrarFeria.Size = New System.Drawing.Size(30, 30)
        Me.pbIrRegistrarFeria.TabIndex = 6
        Me.pbIrRegistrarFeria.TabStop = False
        Me.help.SetToolTip(Me.pbIrRegistrarFeria, "Registrar Feria")
        '
        'pbQuitar
        '
        Me.pbQuitar.BackgroundImage = CType(resources.GetObject("pbQuitar.BackgroundImage"), System.Drawing.Image)
        Me.pbQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbQuitar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbQuitar.Location = New System.Drawing.Point(194, 105)
        Me.pbQuitar.Name = "pbQuitar"
        Me.pbQuitar.Size = New System.Drawing.Size(30, 30)
        Me.pbQuitar.TabIndex = 5
        Me.pbQuitar.TabStop = False
        Me.help.SetToolTip(Me.pbQuitar, "Quitar feria al socio")
        '
        'pbInsertar
        '
        Me.pbInsertar.BackgroundImage = CType(resources.GetObject("pbInsertar.BackgroundImage"), System.Drawing.Image)
        Me.pbInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbInsertar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbInsertar.Location = New System.Drawing.Point(194, 71)
        Me.pbInsertar.Name = "pbInsertar"
        Me.pbInsertar.Size = New System.Drawing.Size(30, 30)
        Me.pbInsertar.TabIndex = 4
        Me.pbInsertar.TabStop = False
        Me.help.SetToolTip(Me.pbInsertar, "Asignar feria al socio")
        '
        'lblFeriaAsiste
        '
        Me.lblFeriaAsiste.AutoSize = True
        Me.lblFeriaAsiste.Location = New System.Drawing.Point(209, 23)
        Me.lblFeriaAsiste.Name = "lblFeriaAsiste"
        Me.lblFeriaAsiste.Size = New System.Drawing.Size(155, 19)
        Me.lblFeriaAsiste.TabIndex = 3
        Me.lblFeriaAsiste.Text = "Feria a las que asiste"
        '
        'ltbFeriaAsiste
        '
        Me.ltbFeriaAsiste.FormattingEnabled = True
        Me.ltbFeriaAsiste.ItemHeight = 19
        Me.ltbFeriaAsiste.Location = New System.Drawing.Point(230, 57)
        Me.ltbFeriaAsiste.Name = "ltbFeriaAsiste"
        Me.ltbFeriaAsiste.Size = New System.Drawing.Size(153, 99)
        Me.ltbFeriaAsiste.TabIndex = 2
        '
        'ltbFeria
        '
        Me.ltbFeria.FormattingEnabled = True
        Me.ltbFeria.ItemHeight = 19
        Me.ltbFeria.Location = New System.Drawing.Point(6, 57)
        Me.ltbFeria.Name = "ltbFeria"
        Me.ltbFeria.Size = New System.Drawing.Size(171, 99)
        Me.ltbFeria.TabIndex = 1
        '
        'lblFeria
        '
        Me.lblFeria.AutoSize = True
        Me.lblFeria.Location = New System.Drawing.Point(6, 23)
        Me.lblFeria.Name = "lblFeria"
        Me.lblFeria.Size = New System.Drawing.Size(43, 19)
        Me.lblFeria.TabIndex = 0
        Me.lblFeria.Text = "Feria"
        '
        'pbLimpiar
        '
        Me.pbLimpiar.BackgroundImage = CType(resources.GetObject("pbLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.pbLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbLimpiar.Location = New System.Drawing.Point(423, 532)
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
        Me.pbRegistrar.Location = New System.Drawing.Point(376, 532)
        Me.pbRegistrar.Name = "pbRegistrar"
        Me.pbRegistrar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegistrar.TabIndex = 21
        Me.pbRegistrar.TabStop = False
        Me.help.SetToolTip(Me.pbRegistrar, "Registrar")
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(193, 26)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(219, 27)
        Me.txtCodigo.TabIndex = 20
        Me.help.SetToolTip(Me.txtCodigo, "30202458")
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(43, 34)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(59, 19)
        Me.lblCodigo.TabIndex = 19
        Me.lblCodigo.Text = "Código"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(193, 169)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(219, 27)
        Me.txtCorreo.TabIndex = 11
        Me.help.SetToolTip(Me.txtCorreo, "manuel@gmail.com")
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(43, 177)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(57, 19)
        Me.lblCorreo.TabIndex = 10
        Me.lblCorreo.Text = "Correo"
        '
        'txtTelefono
        '
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefono.Location = New System.Drawing.Point(193, 134)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(219, 27)
        Me.txtTelefono.TabIndex = 9
        Me.help.SetToolTip(Me.txtTelefono, "2575-8912")
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(43, 137)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(71, 19)
        Me.lblTelefono.TabIndex = 8
        Me.lblTelefono.Text = "Teléfono"
        '
        'txtDireccionCasa
        '
        Me.txtDireccionCasa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccionCasa.Location = New System.Drawing.Point(47, 308)
        Me.txtDireccionCasa.Multiline = True
        Me.txtDireccionCasa.Name = "txtDireccionCasa"
        Me.txtDireccionCasa.Size = New System.Drawing.Size(365, 53)
        Me.txtDireccionCasa.TabIndex = 7
        Me.help.SetToolTip(Me.txtDireccionCasa, "100mts norte de la antigua estación")
        '
        'lblDireccionCasa
        '
        Me.lblDireccionCasa.AutoSize = True
        Me.lblDireccionCasa.Location = New System.Drawing.Point(43, 286)
        Me.lblDireccionCasa.Name = "lblDireccionCasa"
        Me.lblDireccionCasa.Size = New System.Drawing.Size(148, 19)
        Me.lblDireccionCasa.TabIndex = 6
        Me.lblDireccionCasa.Text = "Dirección de la casa"
        '
        'txtDireccionFinca
        '
        Me.txtDireccionFinca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccionFinca.Location = New System.Drawing.Point(47, 230)
        Me.txtDireccionFinca.Multiline = True
        Me.txtDireccionFinca.Name = "txtDireccionFinca"
        Me.txtDireccionFinca.Size = New System.Drawing.Size(365, 53)
        Me.txtDireccionFinca.TabIndex = 5
        Me.help.SetToolTip(Me.txtDireccionFinca, "ujarras 175mts oeste de la entrada de las ruinas ")
        '
        'lblDireccionFinca
        '
        Me.lblDireccionFinca.AutoSize = True
        Me.lblDireccionFinca.Location = New System.Drawing.Point(43, 208)
        Me.lblDireccionFinca.Name = "lblDireccionFinca"
        Me.lblDireccionFinca.Size = New System.Drawing.Size(115, 19)
        Me.lblDireccionFinca.TabIndex = 4
        Me.lblDireccionFinca.Text = "Dirección Finca"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(193, 99)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(219, 27)
        Me.txtNombre.TabIndex = 3
        Me.help.SetToolTip(Me.txtNombre, "Manuel Mata Solano")
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(43, 99)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(139, 19)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre Completo"
        '
        'txtCedula
        '
        Me.txtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedula.Location = New System.Drawing.Point(193, 62)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(219, 27)
        Me.txtCedula.TabIndex = 1
        Me.help.SetToolTip(Me.txtCedula, "104020075")
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Location = New System.Drawing.Point(43, 70)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(103, 19)
        Me.lblCedula.TabIndex = 0
        Me.lblCedula.Text = "Identificación"
        '
        'txtNombreBuscar
        '
        Me.txtNombreBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreBuscar.Location = New System.Drawing.Point(62, 24)
        Me.txtNombreBuscar.Name = "txtNombreBuscar"
        Me.txtNombreBuscar.Size = New System.Drawing.Size(141, 27)
        Me.txtNombreBuscar.TabIndex = 7
        Me.help.SetToolTip(Me.txtNombreBuscar, "Paraíso")
        '
        'ctlRegistrarSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlRegistrarSocio"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbRegistrarSocio.ResumeLayout(False)
        Me.gpbRegistrarSocio.PerformLayout()
        Me.gpbFerias.ResumeLayout(False)
        Me.gpbFerias.PerformLayout()
        CType(Me.pbIrRegistrarFeria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbQuitar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbInsertar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gpbRegistrarSocio As System.Windows.Forms.GroupBox
    Friend WithEvents lblDireccionFinca As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents txtDireccionFinca As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtDireccionCasa As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccionCasa As System.Windows.Forms.Label
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents lblCorreo As System.Windows.Forms.Label
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents pbRegistrar As System.Windows.Forms.PictureBox
    Friend WithEvents pbLimpiar As System.Windows.Forms.PictureBox
    Friend WithEvents pbRegresar As System.Windows.Forms.PictureBox
    Friend WithEvents gpbFerias As System.Windows.Forms.GroupBox
    Friend WithEvents ltbFeria As System.Windows.Forms.ListBox
    Friend WithEvents lblFeria As System.Windows.Forms.Label
    Friend WithEvents pbInsertar As System.Windows.Forms.PictureBox
    Friend WithEvents lblFeriaAsiste As System.Windows.Forms.Label
    Friend WithEvents ltbFeriaAsiste As System.Windows.Forms.ListBox
    Friend WithEvents pbQuitar As System.Windows.Forms.PictureBox
    Friend WithEvents pbIrRegistrarFeria As System.Windows.Forms.PictureBox
    Friend WithEvents txtNombreBuscar As System.Windows.Forms.TextBox

End Class
