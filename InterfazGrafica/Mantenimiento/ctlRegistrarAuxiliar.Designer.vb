<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlRegistrarAuxiliar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlRegistrarAuxiliar))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pbRegresar = New System.Windows.Forms.PictureBox
        Me.gpbRegistrarAuxiliar = New System.Windows.Forms.GroupBox
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
        Me.cmbParentesco = New System.Windows.Forms.ComboBox
        Me.lblParentesco = New System.Windows.Forms.Label
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.lblTelefono = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.txtCedula = New System.Windows.Forms.TextBox
        Me.lblCedula = New System.Windows.Forms.Label
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtNombreBuscar = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbRegistrarAuxiliar.SuspendLayout()
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
        Me.Panel1.Controls.Add(Me.pbRegresar)
        Me.Panel1.Controls.Add(Me.gpbRegistrarAuxiliar)
        Me.Panel1.Location = New System.Drawing.Point(142, 119)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(703, 555)
        Me.Panel1.TabIndex = 0
        '
        'pbRegresar
        '
        Me.pbRegresar.BackgroundImage = CType(resources.GetObject("pbRegresar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresar.Location = New System.Drawing.Point(670, 13)
        Me.pbRegresar.Name = "pbRegresar"
        Me.pbRegresar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegresar.TabIndex = 2
        Me.pbRegresar.TabStop = False
        Me.help.SetToolTip(Me.pbRegresar, "Regresar")
        '
        'gpbRegistrarAuxiliar
        '
        Me.gpbRegistrarAuxiliar.Controls.Add(Me.gpbFerias)
        Me.gpbRegistrarAuxiliar.Controls.Add(Me.pbLimpiar)
        Me.gpbRegistrarAuxiliar.Controls.Add(Me.pbRegistrar)
        Me.gpbRegistrarAuxiliar.Controls.Add(Me.txtCodigo)
        Me.gpbRegistrarAuxiliar.Controls.Add(Me.lblCodigo)
        Me.gpbRegistrarAuxiliar.Controls.Add(Me.cmbParentesco)
        Me.gpbRegistrarAuxiliar.Controls.Add(Me.lblParentesco)
        Me.gpbRegistrarAuxiliar.Controls.Add(Me.txtTelefono)
        Me.gpbRegistrarAuxiliar.Controls.Add(Me.lblTelefono)
        Me.gpbRegistrarAuxiliar.Controls.Add(Me.txtNombre)
        Me.gpbRegistrarAuxiliar.Controls.Add(Me.lblNombre)
        Me.gpbRegistrarAuxiliar.Controls.Add(Me.txtCedula)
        Me.gpbRegistrarAuxiliar.Controls.Add(Me.lblCedula)
        Me.gpbRegistrarAuxiliar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbRegistrarAuxiliar.Location = New System.Drawing.Point(98, 13)
        Me.gpbRegistrarAuxiliar.Name = "gpbRegistrarAuxiliar"
        Me.gpbRegistrarAuxiliar.Size = New System.Drawing.Size(519, 527)
        Me.gpbRegistrarAuxiliar.TabIndex = 0
        Me.gpbRegistrarAuxiliar.TabStop = False
        Me.gpbRegistrarAuxiliar.Text = "Registrar Auxiliar"
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
        Me.gpbFerias.Location = New System.Drawing.Point(56, 273)
        Me.gpbFerias.Name = "gpbFerias"
        Me.gpbFerias.Size = New System.Drawing.Size(398, 212)
        Me.gpbFerias.TabIndex = 25
        Me.gpbFerias.TabStop = False
        Me.gpbFerias.Text = "Ferias"
        '
        'pbIrRegistrarFeria
        '
        Me.pbIrRegistrarFeria.BackgroundImage = CType(resources.GetObject("pbIrRegistrarFeria.BackgroundImage"), System.Drawing.Image)
        Me.pbIrRegistrarFeria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbIrRegistrarFeria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbIrRegistrarFeria.Location = New System.Drawing.Point(364, 12)
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
        Me.pbQuitar.Location = New System.Drawing.Point(194, 122)
        Me.pbQuitar.Name = "pbQuitar"
        Me.pbQuitar.Size = New System.Drawing.Size(30, 30)
        Me.pbQuitar.TabIndex = 5
        Me.pbQuitar.TabStop = False
        Me.help.SetToolTip(Me.pbQuitar, "Quitar feria al auxiliar")
        '
        'pbInsertar
        '
        Me.pbInsertar.BackgroundImage = CType(resources.GetObject("pbInsertar.BackgroundImage"), System.Drawing.Image)
        Me.pbInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbInsertar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbInsertar.Location = New System.Drawing.Point(194, 88)
        Me.pbInsertar.Name = "pbInsertar"
        Me.pbInsertar.Size = New System.Drawing.Size(30, 30)
        Me.pbInsertar.TabIndex = 4
        Me.pbInsertar.TabStop = False
        Me.help.SetToolTip(Me.pbInsertar, "Asignar feria al auxiliar")
        '
        'lblFeriaAsiste
        '
        Me.lblFeriaAsiste.AutoSize = True
        Me.lblFeriaAsiste.Location = New System.Drawing.Point(203, 23)
        Me.lblFeriaAsiste.Name = "lblFeriaAsiste"
        Me.lblFeriaAsiste.Size = New System.Drawing.Size(155, 19)
        Me.lblFeriaAsiste.TabIndex = 3
        Me.lblFeriaAsiste.Text = "Feria a las que asiste"
        '
        'ltbFeriaAsiste
        '
        Me.ltbFeriaAsiste.FormattingEnabled = True
        Me.ltbFeriaAsiste.ItemHeight = 19
        Me.ltbFeriaAsiste.Location = New System.Drawing.Point(230, 71)
        Me.ltbFeriaAsiste.Name = "ltbFeriaAsiste"
        Me.ltbFeriaAsiste.Size = New System.Drawing.Size(162, 118)
        Me.ltbFeriaAsiste.TabIndex = 2
        '
        'ltbFeria
        '
        Me.ltbFeria.FormattingEnabled = True
        Me.ltbFeria.ItemHeight = 19
        Me.ltbFeria.Location = New System.Drawing.Point(18, 69)
        Me.ltbFeria.Name = "ltbFeria"
        Me.ltbFeria.Size = New System.Drawing.Size(170, 118)
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
        Me.pbLimpiar.Location = New System.Drawing.Point(420, 491)
        Me.pbLimpiar.Name = "pbLimpiar"
        Me.pbLimpiar.Size = New System.Drawing.Size(30, 30)
        Me.pbLimpiar.TabIndex = 24
        Me.pbLimpiar.TabStop = False
        Me.help.SetToolTip(Me.pbLimpiar, "Limpiar")
        '
        'pbRegistrar
        '
        Me.pbRegistrar.BackgroundImage = CType(resources.GetObject("pbRegistrar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegistrar.Location = New System.Drawing.Point(373, 491)
        Me.pbRegistrar.Name = "pbRegistrar"
        Me.pbRegistrar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegistrar.TabIndex = 23
        Me.pbRegistrar.TabStop = False
        Me.help.SetToolTip(Me.pbRegistrar, "Registrar")
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(219, 61)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(235, 27)
        Me.txtCodigo.TabIndex = 22
        Me.help.SetToolTip(Me.txtCodigo, "30201343")
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(52, 69)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(59, 19)
        Me.lblCodigo.TabIndex = 21
        Me.lblCodigo.Text = "Código"
        '
        'cmbParentesco
        '
        Me.cmbParentesco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbParentesco.FormattingEnabled = True
        Me.cmbParentesco.Items.AddRange(New Object() {"--SELECCIONAR--", "HERMANO", "CONYUGUE", "SUSTITUTO", "HIJO", "PADRE"})
        Me.cmbParentesco.Location = New System.Drawing.Point(219, 240)
        Me.cmbParentesco.Name = "cmbParentesco"
        Me.cmbParentesco.Size = New System.Drawing.Size(235, 27)
        Me.cmbParentesco.TabIndex = 15
        '
        'lblParentesco
        '
        Me.lblParentesco.AutoSize = True
        Me.lblParentesco.Location = New System.Drawing.Point(52, 243)
        Me.lblParentesco.Name = "lblParentesco"
        Me.lblParentesco.Size = New System.Drawing.Size(85, 19)
        Me.lblParentesco.TabIndex = 14
        Me.lblParentesco.Text = "Parentesco"
        '
        'txtTelefono
        '
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefono.Location = New System.Drawing.Point(219, 196)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(235, 27)
        Me.txtTelefono.TabIndex = 13
        Me.help.SetToolTip(Me.txtTelefono, "2552-5410")
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(52, 199)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(71, 19)
        Me.lblTelefono.TabIndex = 12
        Me.lblTelefono.Text = "Teléfono"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(219, 153)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(235, 27)
        Me.txtNombre.TabIndex = 7
        Me.help.SetToolTip(Me.txtNombre, "Pablo Cantillo Soto")
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(52, 161)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(139, 19)
        Me.lblNombre.TabIndex = 6
        Me.lblNombre.Text = "Nombre Completo"
        '
        'txtCedula
        '
        Me.txtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedula.Location = New System.Drawing.Point(219, 104)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(235, 27)
        Me.txtCedula.TabIndex = 5
        Me.help.SetToolTip(Me.txtCedula, "303520324")
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Location = New System.Drawing.Point(52, 112)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(103, 19)
        Me.lblCedula.TabIndex = 4
        Me.lblCedula.Text = "Identificación"
        '
        'txtNombreBuscar
        '
        Me.txtNombreBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreBuscar.Location = New System.Drawing.Point(55, 20)
        Me.txtNombreBuscar.Name = "txtNombreBuscar"
        Me.txtNombreBuscar.Size = New System.Drawing.Size(141, 27)
        Me.txtNombreBuscar.TabIndex = 8
        Me.help.SetToolTip(Me.txtNombreBuscar, "Paraíso")
        '
        'ctlRegistrarAuxiliar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlRegistrarAuxiliar"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbRegistrarAuxiliar.ResumeLayout(False)
        Me.gpbRegistrarAuxiliar.PerformLayout()
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
    Friend WithEvents gpbRegistrarAuxiliar As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents cmbParentesco As System.Windows.Forms.ComboBox
    Friend WithEvents lblParentesco As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents pbLimpiar As System.Windows.Forms.PictureBox
    Friend WithEvents pbRegistrar As System.Windows.Forms.PictureBox
    Friend WithEvents pbRegresar As System.Windows.Forms.PictureBox
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents gpbFerias As System.Windows.Forms.GroupBox
    Friend WithEvents pbIrRegistrarFeria As System.Windows.Forms.PictureBox
    Friend WithEvents pbQuitar As System.Windows.Forms.PictureBox
    Friend WithEvents pbInsertar As System.Windows.Forms.PictureBox
    Friend WithEvents lblFeriaAsiste As System.Windows.Forms.Label
    Friend WithEvents ltbFeriaAsiste As System.Windows.Forms.ListBox
    Friend WithEvents ltbFeria As System.Windows.Forms.ListBox
    Friend WithEvents lblFeria As System.Windows.Forms.Label
    Friend WithEvents txtNombreBuscar As System.Windows.Forms.TextBox

End Class
