<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlBuscarAuxiliar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlBuscarAuxiliar))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pbRegresar = New System.Windows.Forms.PictureBox
        Me.gpbModificarAuxiliar = New System.Windows.Forms.GroupBox
        Me.gpbFerias = New System.Windows.Forms.GroupBox
        Me.pbQuitar = New System.Windows.Forms.PictureBox
        Me.pbInsertar = New System.Windows.Forms.PictureBox
        Me.lblFeriaAsiste = New System.Windows.Forms.Label
        Me.ltbFeriaAsiste = New System.Windows.Forms.ListBox
        Me.ltbFeria = New System.Windows.Forms.ListBox
        Me.lblFeria = New System.Windows.Forms.Label
        Me.cmbParentesco = New System.Windows.Forms.ComboBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.pbConfirmar = New System.Windows.Forms.PictureBox
        Me.lblParentesco = New System.Windows.Forms.Label
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.lblTelefono = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.txtCedula = New System.Windows.Forms.TextBox
        Me.lblCedula = New System.Windows.Forms.Label
        Me.gpbAuxiliar = New System.Windows.Forms.GroupBox
        Me.pbAsignarPermiso = New System.Windows.Forms.PictureBox
        Me.lblCriterio = New System.Windows.Forms.Label
        Me.pbModificar = New System.Windows.Forms.PictureBox
        Me.pbEliminar = New System.Windows.Forms.PictureBox
        Me.dgvDatos = New System.Windows.Forms.DataGridView
        Me.txtCriterio = New System.Windows.Forms.TextBox
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtNombreBuscar = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbModificarAuxiliar.SuspendLayout()
        Me.gpbFerias.SuspendLayout()
        CType(Me.pbQuitar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbInsertar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbConfirmar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbAuxiliar.SuspendLayout()
        CType(Me.pbAsignarPermiso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbRegresar)
        Me.Panel1.Controls.Add(Me.gpbModificarAuxiliar)
        Me.Panel1.Controls.Add(Me.gpbAuxiliar)
        Me.Panel1.Location = New System.Drawing.Point(0, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 575)
        Me.Panel1.TabIndex = 0
        '
        'pbRegresar
        '
        Me.pbRegresar.BackgroundImage = CType(resources.GetObject("pbRegresar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresar.Location = New System.Drawing.Point(970, 58)
        Me.pbRegresar.Name = "pbRegresar"
        Me.pbRegresar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegresar.TabIndex = 9
        Me.pbRegresar.TabStop = False
        Me.help.SetToolTip(Me.pbRegresar, "Regresar")
        '
        'gpbModificarAuxiliar
        '
        Me.gpbModificarAuxiliar.Controls.Add(Me.gpbFerias)
        Me.gpbModificarAuxiliar.Controls.Add(Me.cmbParentesco)
        Me.gpbModificarAuxiliar.Controls.Add(Me.txtCodigo)
        Me.gpbModificarAuxiliar.Controls.Add(Me.lblCodigo)
        Me.gpbModificarAuxiliar.Controls.Add(Me.pbConfirmar)
        Me.gpbModificarAuxiliar.Controls.Add(Me.lblParentesco)
        Me.gpbModificarAuxiliar.Controls.Add(Me.txtTelefono)
        Me.gpbModificarAuxiliar.Controls.Add(Me.lblTelefono)
        Me.gpbModificarAuxiliar.Controls.Add(Me.txtNombre)
        Me.gpbModificarAuxiliar.Controls.Add(Me.lblNombre)
        Me.gpbModificarAuxiliar.Controls.Add(Me.txtCedula)
        Me.gpbModificarAuxiliar.Controls.Add(Me.lblCedula)
        Me.gpbModificarAuxiliar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbModificarAuxiliar.Location = New System.Drawing.Point(562, 95)
        Me.gpbModificarAuxiliar.Name = "gpbModificarAuxiliar"
        Me.gpbModificarAuxiliar.Size = New System.Drawing.Size(450, 415)
        Me.gpbModificarAuxiliar.TabIndex = 1
        Me.gpbModificarAuxiliar.TabStop = False
        Me.gpbModificarAuxiliar.Text = "Modificar Auxiliar"
        Me.gpbModificarAuxiliar.Visible = False
        '
        'gpbFerias
        '
        Me.gpbFerias.Controls.Add(Me.txtNombreBuscar)
        Me.gpbFerias.Controls.Add(Me.pbQuitar)
        Me.gpbFerias.Controls.Add(Me.pbInsertar)
        Me.gpbFerias.Controls.Add(Me.lblFeriaAsiste)
        Me.gpbFerias.Controls.Add(Me.ltbFeriaAsiste)
        Me.gpbFerias.Controls.Add(Me.ltbFeria)
        Me.gpbFerias.Controls.Add(Me.lblFeria)
        Me.gpbFerias.Location = New System.Drawing.Point(20, 206)
        Me.gpbFerias.Name = "gpbFerias"
        Me.gpbFerias.Size = New System.Drawing.Size(398, 167)
        Me.gpbFerias.TabIndex = 39
        Me.gpbFerias.TabStop = False
        Me.gpbFerias.Text = "Ferias"
        '
        'pbQuitar
        '
        Me.pbQuitar.BackgroundImage = CType(resources.GetObject("pbQuitar.BackgroundImage"), System.Drawing.Image)
        Me.pbQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbQuitar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbQuitar.Location = New System.Drawing.Point(188, 108)
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
        Me.pbInsertar.Location = New System.Drawing.Point(188, 74)
        Me.pbInsertar.Name = "pbInsertar"
        Me.pbInsertar.Size = New System.Drawing.Size(30, 30)
        Me.pbInsertar.TabIndex = 4
        Me.pbInsertar.TabStop = False
        Me.help.SetToolTip(Me.pbInsertar, "Asignar feria al auxiliar")
        '
        'lblFeriaAsiste
        '
        Me.lblFeriaAsiste.AutoSize = True
        Me.lblFeriaAsiste.Location = New System.Drawing.Point(237, 23)
        Me.lblFeriaAsiste.Name = "lblFeriaAsiste"
        Me.lblFeriaAsiste.Size = New System.Drawing.Size(155, 19)
        Me.lblFeriaAsiste.TabIndex = 3
        Me.lblFeriaAsiste.Text = "Feria a las que asiste"
        '
        'ltbFeriaAsiste
        '
        Me.ltbFeriaAsiste.FormattingEnabled = True
        Me.ltbFeriaAsiste.ItemHeight = 19
        Me.ltbFeriaAsiste.Location = New System.Drawing.Point(237, 58)
        Me.ltbFeriaAsiste.Name = "ltbFeriaAsiste"
        Me.ltbFeriaAsiste.Size = New System.Drawing.Size(155, 99)
        Me.ltbFeriaAsiste.TabIndex = 2
        '
        'ltbFeria
        '
        Me.ltbFeria.FormattingEnabled = True
        Me.ltbFeria.ItemHeight = 19
        Me.ltbFeria.Location = New System.Drawing.Point(15, 58)
        Me.ltbFeria.Name = "ltbFeria"
        Me.ltbFeria.Size = New System.Drawing.Size(155, 99)
        Me.ltbFeria.TabIndex = 1
        '
        'lblFeria
        '
        Me.lblFeria.AutoSize = True
        Me.lblFeria.Location = New System.Drawing.Point(11, 23)
        Me.lblFeria.Name = "lblFeria"
        Me.lblFeria.Size = New System.Drawing.Size(50, 19)
        Me.lblFeria.TabIndex = 0
        Me.lblFeria.Text = "Ferias"
        '
        'cmbParentesco
        '
        Me.cmbParentesco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbParentesco.FormattingEnabled = True
        Me.cmbParentesco.Items.AddRange(New Object() {"--SELECCIONAR--", "HERMANO", "CONYUGUE", "SUSTITUTO", "HIJO", "PADRE"})
        Me.cmbParentesco.Location = New System.Drawing.Point(183, 173)
        Me.cmbParentesco.Name = "cmbParentesco"
        Me.cmbParentesco.Size = New System.Drawing.Size(235, 27)
        Me.cmbParentesco.TabIndex = 25
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(183, 24)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(235, 27)
        Me.txtCodigo.TabIndex = 24
        Me.help.SetToolTip(Me.txtCodigo, "30201343")
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(16, 32)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(59, 19)
        Me.lblCodigo.TabIndex = 23
        Me.lblCodigo.Text = "Código"
        '
        'pbConfirmar
        '
        Me.pbConfirmar.BackgroundImage = CType(resources.GetObject("pbConfirmar.BackgroundImage"), System.Drawing.Image)
        Me.pbConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbConfirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbConfirmar.Location = New System.Drawing.Point(388, 379)
        Me.pbConfirmar.Name = "pbConfirmar"
        Me.pbConfirmar.Size = New System.Drawing.Size(30, 30)
        Me.pbConfirmar.TabIndex = 16
        Me.pbConfirmar.TabStop = False
        Me.help.SetToolTip(Me.pbConfirmar, "Confirmar modificación")
        '
        'lblParentesco
        '
        Me.lblParentesco.AutoSize = True
        Me.lblParentesco.Location = New System.Drawing.Point(16, 181)
        Me.lblParentesco.Name = "lblParentesco"
        Me.lblParentesco.Size = New System.Drawing.Size(85, 19)
        Me.lblParentesco.TabIndex = 14
        Me.lblParentesco.Text = "Parentesco"
        '
        'txtTelefono
        '
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefono.Location = New System.Drawing.Point(183, 141)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(235, 27)
        Me.txtTelefono.TabIndex = 13
        Me.help.SetToolTip(Me.txtTelefono, "2552-5410")
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(16, 144)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(71, 19)
        Me.lblTelefono.TabIndex = 12
        Me.lblTelefono.Text = "Teléfono"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(183, 101)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(235, 27)
        Me.txtNombre.TabIndex = 7
        Me.help.SetToolTip(Me.txtNombre, "Pablo Cantillo Soto")
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(16, 109)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(139, 19)
        Me.lblNombre.TabIndex = 6
        Me.lblNombre.Text = "Nombre Completo"
        '
        'txtCedula
        '
        Me.txtCedula.BackColor = System.Drawing.SystemColors.Window
        Me.txtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedula.Location = New System.Drawing.Point(183, 63)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(235, 27)
        Me.txtCedula.TabIndex = 5
        Me.help.SetToolTip(Me.txtCedula, "303520324")
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Location = New System.Drawing.Point(16, 71)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(103, 19)
        Me.lblCedula.TabIndex = 4
        Me.lblCedula.Text = "Identificación"
        '
        'gpbAuxiliar
        '
        Me.gpbAuxiliar.Controls.Add(Me.pbAsignarPermiso)
        Me.gpbAuxiliar.Controls.Add(Me.lblCriterio)
        Me.gpbAuxiliar.Controls.Add(Me.pbModificar)
        Me.gpbAuxiliar.Controls.Add(Me.pbEliminar)
        Me.gpbAuxiliar.Controls.Add(Me.dgvDatos)
        Me.gpbAuxiliar.Controls.Add(Me.txtCriterio)
        Me.gpbAuxiliar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbAuxiliar.Location = New System.Drawing.Point(3, 95)
        Me.gpbAuxiliar.Name = "gpbAuxiliar"
        Me.gpbAuxiliar.Size = New System.Drawing.Size(553, 415)
        Me.gpbAuxiliar.TabIndex = 0
        Me.gpbAuxiliar.TabStop = False
        Me.gpbAuxiliar.Text = "Buscar Auxiliar"
        '
        'pbAsignarPermiso
        '
        Me.pbAsignarPermiso.BackgroundImage = CType(resources.GetObject("pbAsignarPermiso.BackgroundImage"), System.Drawing.Image)
        Me.pbAsignarPermiso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAsignarPermiso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAsignarPermiso.Location = New System.Drawing.Point(445, 359)
        Me.pbAsignarPermiso.Name = "pbAsignarPermiso"
        Me.pbAsignarPermiso.Size = New System.Drawing.Size(30, 30)
        Me.pbAsignarPermiso.TabIndex = 14
        Me.pbAsignarPermiso.TabStop = False
        Me.help.SetToolTip(Me.pbAsignarPermiso, "Asignar permiso")
        '
        'lblCriterio
        '
        Me.lblCriterio.AutoSize = True
        Me.lblCriterio.Location = New System.Drawing.Point(24, 56)
        Me.lblCriterio.Name = "lblCriterio"
        Me.lblCriterio.Size = New System.Drawing.Size(134, 19)
        Me.lblCriterio.TabIndex = 13
        Me.lblCriterio.Text = "Criterio búsqueda"
        '
        'pbModificar
        '
        Me.pbModificar.BackgroundImage = CType(resources.GetObject("pbModificar.BackgroundImage"), System.Drawing.Image)
        Me.pbModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbModificar.Location = New System.Drawing.Point(481, 359)
        Me.pbModificar.Name = "pbModificar"
        Me.pbModificar.Size = New System.Drawing.Size(30, 30)
        Me.pbModificar.TabIndex = 8
        Me.pbModificar.TabStop = False
        Me.help.SetToolTip(Me.pbModificar, "Modificar")
        '
        'pbEliminar
        '
        Me.pbEliminar.BackgroundImage = CType(resources.GetObject("pbEliminar.BackgroundImage"), System.Drawing.Image)
        Me.pbEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbEliminar.Location = New System.Drawing.Point(517, 359)
        Me.pbEliminar.Name = "pbEliminar"
        Me.pbEliminar.Size = New System.Drawing.Size(30, 30)
        Me.pbEliminar.TabIndex = 7
        Me.pbEliminar.TabStop = False
        Me.help.SetToolTip(Me.pbEliminar, "Eliminar")
        '
        'dgvDatos
        '
        Me.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDatos.BackgroundColor = System.Drawing.Color.White
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Location = New System.Drawing.Point(19, 131)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.RowHeadersVisible = False
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(528, 222)
        Me.dgvDatos.TabIndex = 6
        '
        'txtCriterio
        '
        Me.txtCriterio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCriterio.Location = New System.Drawing.Point(164, 53)
        Me.txtCriterio.Name = "txtCriterio"
        Me.txtCriterio.Size = New System.Drawing.Size(234, 27)
        Me.txtCriterio.TabIndex = 5
        Me.help.SetToolTip(Me.txtCriterio, "657567567 o SOTO ARCE ANDREA")
        '
        'txtNombreBuscar
        '
        Me.txtNombreBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreBuscar.Location = New System.Drawing.Point(67, 20)
        Me.txtNombreBuscar.Name = "txtNombreBuscar"
        Me.txtNombreBuscar.Size = New System.Drawing.Size(139, 27)
        Me.txtNombreBuscar.TabIndex = 7
        Me.help.SetToolTip(Me.txtNombreBuscar, "Paraíso")
        '
        'ctlBuscarAuxiliar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlBuscarAuxiliar"
        Me.Size = New System.Drawing.Size(1030, 700)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbModificarAuxiliar.ResumeLayout(False)
        Me.gpbModificarAuxiliar.PerformLayout()
        Me.gpbFerias.ResumeLayout(False)
        Me.gpbFerias.PerformLayout()
        CType(Me.pbQuitar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbInsertar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbConfirmar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbAuxiliar.ResumeLayout(False)
        Me.gpbAuxiliar.PerformLayout()
        CType(Me.pbAsignarPermiso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gpbAuxiliar As System.Windows.Forms.GroupBox
    Friend WithEvents txtCriterio As System.Windows.Forms.TextBox
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents pbEliminar As System.Windows.Forms.PictureBox
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents pbModificar As System.Windows.Forms.PictureBox
    Friend WithEvents gpbModificarAuxiliar As System.Windows.Forms.GroupBox
    Friend WithEvents lblParentesco As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents pbConfirmar As System.Windows.Forms.PictureBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents pbRegresar As System.Windows.Forms.PictureBox
    Friend WithEvents cmbParentesco As System.Windows.Forms.ComboBox
    Friend WithEvents lblCriterio As System.Windows.Forms.Label
    Friend WithEvents pbAsignarPermiso As System.Windows.Forms.PictureBox
    Friend WithEvents gpbFerias As System.Windows.Forms.GroupBox
    Friend WithEvents pbQuitar As System.Windows.Forms.PictureBox
    Friend WithEvents pbInsertar As System.Windows.Forms.PictureBox
    Friend WithEvents lblFeriaAsiste As System.Windows.Forms.Label
    Friend WithEvents ltbFeriaAsiste As System.Windows.Forms.ListBox
    Friend WithEvents ltbFeria As System.Windows.Forms.ListBox
    Friend WithEvents lblFeria As System.Windows.Forms.Label
    Friend WithEvents txtNombreBuscar As System.Windows.Forms.TextBox

End Class
