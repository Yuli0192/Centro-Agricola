<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlBuscarSocio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlBuscarSocio))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pbRegresar = New System.Windows.Forms.PictureBox
        Me.gpbModificarSocio = New System.Windows.Forms.GroupBox
        Me.gpbFerias = New System.Windows.Forms.GroupBox
        Me.txtNombreBuscar = New System.Windows.Forms.TextBox
        Me.pbQuitar = New System.Windows.Forms.PictureBox
        Me.pbInsertar = New System.Windows.Forms.PictureBox
        Me.lblFeriaAsiste = New System.Windows.Forms.Label
        Me.ltbFeriaAsiste = New System.Windows.Forms.ListBox
        Me.ltbFeria = New System.Windows.Forms.ListBox
        Me.lblFeria = New System.Windows.Forms.Label
        Me.pbConfirmar = New System.Windows.Forms.PictureBox
        Me.txtFechaIngreso = New System.Windows.Forms.TextBox
        Me.lblFechaIngreso = New System.Windows.Forms.Label
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
        Me.gpbBuscarSocio = New System.Windows.Forms.GroupBox
        Me.txtCantSocio = New System.Windows.Forms.TextBox
        Me.lblCantSocio = New System.Windows.Forms.Label
        Me.pbVerTotalArea = New System.Windows.Forms.PictureBox
        Me.lblCriterio = New System.Windows.Forms.Label
        Me.pbModificar = New System.Windows.Forms.PictureBox
        Me.pbEliminar = New System.Windows.Forms.PictureBox
        Me.dgvDatos = New System.Windows.Forms.DataGridView
        Me.txtCriterio = New System.Windows.Forms.TextBox
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbModificarSocio.SuspendLayout()
        Me.gpbFerias.SuspendLayout()
        CType(Me.pbQuitar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbInsertar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbConfirmar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbBuscarSocio.SuspendLayout()
        CType(Me.pbVerTotalArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbRegresar)
        Me.Panel1.Controls.Add(Me.gpbModificarSocio)
        Me.Panel1.Controls.Add(Me.gpbBuscarSocio)
        Me.Panel1.Location = New System.Drawing.Point(0, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1034, 616)
        Me.Panel1.TabIndex = 0
        '
        'pbRegresar
        '
        Me.pbRegresar.BackgroundImage = CType(resources.GetObject("pbRegresar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresar.Location = New System.Drawing.Point(974, 15)
        Me.pbRegresar.Name = "pbRegresar"
        Me.pbRegresar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegresar.TabIndex = 3
        Me.pbRegresar.TabStop = False
        Me.help.SetToolTip(Me.pbRegresar, "Regresar")
        '
        'gpbModificarSocio
        '
        Me.gpbModificarSocio.Controls.Add(Me.gpbFerias)
        Me.gpbModificarSocio.Controls.Add(Me.pbConfirmar)
        Me.gpbModificarSocio.Controls.Add(Me.txtFechaIngreso)
        Me.gpbModificarSocio.Controls.Add(Me.lblFechaIngreso)
        Me.gpbModificarSocio.Controls.Add(Me.txtCodigo)
        Me.gpbModificarSocio.Controls.Add(Me.lblCodigo)
        Me.gpbModificarSocio.Controls.Add(Me.txtCorreo)
        Me.gpbModificarSocio.Controls.Add(Me.lblCorreo)
        Me.gpbModificarSocio.Controls.Add(Me.txtTelefono)
        Me.gpbModificarSocio.Controls.Add(Me.lblTelefono)
        Me.gpbModificarSocio.Controls.Add(Me.txtDireccionCasa)
        Me.gpbModificarSocio.Controls.Add(Me.lblDireccionCasa)
        Me.gpbModificarSocio.Controls.Add(Me.txtDireccionFinca)
        Me.gpbModificarSocio.Controls.Add(Me.lblDireccionFinca)
        Me.gpbModificarSocio.Controls.Add(Me.txtNombre)
        Me.gpbModificarSocio.Controls.Add(Me.lblNombre)
        Me.gpbModificarSocio.Controls.Add(Me.txtCedula)
        Me.gpbModificarSocio.Controls.Add(Me.lblCedula)
        Me.gpbModificarSocio.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbModificarSocio.Location = New System.Drawing.Point(589, 36)
        Me.gpbModificarSocio.Name = "gpbModificarSocio"
        Me.gpbModificarSocio.Size = New System.Drawing.Size(421, 564)
        Me.gpbModificarSocio.TabIndex = 1
        Me.gpbModificarSocio.TabStop = False
        Me.gpbModificarSocio.Text = "Modificar Socio"
        Me.gpbModificarSocio.Visible = False
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
        Me.gpbFerias.Location = New System.Drawing.Point(50, 385)
        Me.gpbFerias.Name = "gpbFerias"
        Me.gpbFerias.Size = New System.Drawing.Size(365, 137)
        Me.gpbFerias.TabIndex = 38
        Me.gpbFerias.TabStop = False
        Me.gpbFerias.Text = "Ferias"
        '
        'txtNombreBuscar
        '
        Me.txtNombreBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreBuscar.Location = New System.Drawing.Point(55, 15)
        Me.txtNombreBuscar.Name = "txtNombreBuscar"
        Me.txtNombreBuscar.Size = New System.Drawing.Size(139, 27)
        Me.txtNombreBuscar.TabIndex = 6
        Me.help.SetToolTip(Me.txtNombreBuscar, "Paraíso")
        '
        'pbQuitar
        '
        Me.pbQuitar.BackgroundImage = CType(resources.GetObject("pbQuitar.BackgroundImage"), System.Drawing.Image)
        Me.pbQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbQuitar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbQuitar.Location = New System.Drawing.Point(178, 88)
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
        Me.pbInsertar.Location = New System.Drawing.Point(178, 54)
        Me.pbInsertar.Name = "pbInsertar"
        Me.pbInsertar.Size = New System.Drawing.Size(30, 30)
        Me.pbInsertar.TabIndex = 4
        Me.pbInsertar.TabStop = False
        Me.help.SetToolTip(Me.pbInsertar, "Asignar feria al socio")
        '
        'lblFeriaAsiste
        '
        Me.lblFeriaAsiste.AutoSize = True
        Me.lblFeriaAsiste.Location = New System.Drawing.Point(200, 23)
        Me.lblFeriaAsiste.Name = "lblFeriaAsiste"
        Me.lblFeriaAsiste.Size = New System.Drawing.Size(155, 19)
        Me.lblFeriaAsiste.TabIndex = 3
        Me.lblFeriaAsiste.Text = "Feria a las que asiste"
        '
        'ltbFeriaAsiste
        '
        Me.ltbFeriaAsiste.FormattingEnabled = True
        Me.ltbFeriaAsiste.ItemHeight = 19
        Me.ltbFeriaAsiste.Location = New System.Drawing.Point(214, 45)
        Me.ltbFeriaAsiste.Name = "ltbFeriaAsiste"
        Me.ltbFeriaAsiste.Size = New System.Drawing.Size(141, 80)
        Me.ltbFeriaAsiste.TabIndex = 2
        '
        'ltbFeria
        '
        Me.ltbFeria.FormattingEnabled = True
        Me.ltbFeria.ItemHeight = 19
        Me.ltbFeria.Location = New System.Drawing.Point(10, 45)
        Me.ltbFeria.Name = "ltbFeria"
        Me.ltbFeria.Size = New System.Drawing.Size(162, 80)
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
        'pbConfirmar
        '
        Me.pbConfirmar.BackgroundImage = CType(resources.GetObject("pbConfirmar.BackgroundImage"), System.Drawing.Image)
        Me.pbConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbConfirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbConfirmar.Location = New System.Drawing.Point(375, 528)
        Me.pbConfirmar.Name = "pbConfirmar"
        Me.pbConfirmar.Size = New System.Drawing.Size(30, 30)
        Me.pbConfirmar.TabIndex = 17
        Me.pbConfirmar.TabStop = False
        Me.help.SetToolTip(Me.pbConfirmar, "Confirmar modificación")
        '
        'txtFechaIngreso
        '
        Me.txtFechaIngreso.Enabled = False
        Me.txtFechaIngreso.Location = New System.Drawing.Point(168, 355)
        Me.txtFechaIngreso.Name = "txtFechaIngreso"
        Me.txtFechaIngreso.ReadOnly = True
        Me.txtFechaIngreso.Size = New System.Drawing.Size(219, 27)
        Me.txtFechaIngreso.TabIndex = 37
        Me.help.SetToolTip(Me.txtFechaIngreso, "09/10/2011")
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.AutoSize = True
        Me.lblFechaIngreso.Location = New System.Drawing.Point(45, 363)
        Me.lblFechaIngreso.Name = "lblFechaIngreso"
        Me.lblFechaIngreso.Size = New System.Drawing.Size(108, 19)
        Me.lblFechaIngreso.TabIndex = 36
        Me.lblFechaIngreso.Text = "Fecha Ingreso"
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(183, 15)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(232, 27)
        Me.txtCodigo.TabIndex = 34
        Me.help.SetToolTip(Me.txtCodigo, "30202458")
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(45, 23)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(59, 19)
        Me.lblCodigo.TabIndex = 33
        Me.lblCodigo.Text = "Código"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(183, 158)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(232, 27)
        Me.txtCorreo.TabIndex = 32
        Me.help.SetToolTip(Me.txtCorreo, "manuel@gmail.com")
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(45, 166)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(57, 19)
        Me.lblCorreo.TabIndex = 31
        Me.lblCorreo.Text = "Correo"
        '
        'txtTelefono
        '
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefono.Location = New System.Drawing.Point(183, 123)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(232, 27)
        Me.txtTelefono.TabIndex = 30
        Me.help.SetToolTip(Me.txtTelefono, "2575-8912")
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(45, 126)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(71, 19)
        Me.lblTelefono.TabIndex = 29
        Me.lblTelefono.Text = "Teléfono"
        '
        'txtDireccionCasa
        '
        Me.txtDireccionCasa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccionCasa.Location = New System.Drawing.Point(49, 294)
        Me.txtDireccionCasa.Multiline = True
        Me.txtDireccionCasa.Name = "txtDireccionCasa"
        Me.txtDireccionCasa.Size = New System.Drawing.Size(366, 54)
        Me.txtDireccionCasa.TabIndex = 28
        Me.help.SetToolTip(Me.txtDireccionCasa, "100mts norte de la antigua estación")
        '
        'lblDireccionCasa
        '
        Me.lblDireccionCasa.AutoSize = True
        Me.lblDireccionCasa.Location = New System.Drawing.Point(45, 272)
        Me.lblDireccionCasa.Name = "lblDireccionCasa"
        Me.lblDireccionCasa.Size = New System.Drawing.Size(148, 19)
        Me.lblDireccionCasa.TabIndex = 27
        Me.lblDireccionCasa.Text = "Dirección de la casa"
        '
        'txtDireccionFinca
        '
        Me.txtDireccionFinca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccionFinca.Location = New System.Drawing.Point(49, 219)
        Me.txtDireccionFinca.Multiline = True
        Me.txtDireccionFinca.Name = "txtDireccionFinca"
        Me.txtDireccionFinca.Size = New System.Drawing.Size(366, 50)
        Me.txtDireccionFinca.TabIndex = 26
        Me.help.SetToolTip(Me.txtDireccionFinca, "ujarras 175mts oeste de la entrada de las ruinas ")
        '
        'lblDireccionFinca
        '
        Me.lblDireccionFinca.AutoSize = True
        Me.lblDireccionFinca.Location = New System.Drawing.Point(45, 197)
        Me.lblDireccionFinca.Name = "lblDireccionFinca"
        Me.lblDireccionFinca.Size = New System.Drawing.Size(115, 19)
        Me.lblDireccionFinca.TabIndex = 25
        Me.lblDireccionFinca.Text = "Dirección Finca"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(183, 88)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(232, 27)
        Me.txtNombre.TabIndex = 24
        Me.help.SetToolTip(Me.txtNombre, "Manuel Mata Solano")
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(45, 91)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(139, 19)
        Me.lblNombre.TabIndex = 23
        Me.lblNombre.Text = "Nombre Completo"
        '
        'txtCedula
        '
        Me.txtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedula.Location = New System.Drawing.Point(183, 51)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(232, 27)
        Me.txtCedula.TabIndex = 22
        Me.help.SetToolTip(Me.txtCedula, "104020075")
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Location = New System.Drawing.Point(45, 59)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(57, 19)
        Me.lblCedula.TabIndex = 21
        Me.lblCedula.Text = "Cédula"
        '
        'gpbBuscarSocio
        '
        Me.gpbBuscarSocio.Controls.Add(Me.txtCantSocio)
        Me.gpbBuscarSocio.Controls.Add(Me.lblCantSocio)
        Me.gpbBuscarSocio.Controls.Add(Me.pbVerTotalArea)
        Me.gpbBuscarSocio.Controls.Add(Me.lblCriterio)
        Me.gpbBuscarSocio.Controls.Add(Me.pbModificar)
        Me.gpbBuscarSocio.Controls.Add(Me.pbEliminar)
        Me.gpbBuscarSocio.Controls.Add(Me.dgvDatos)
        Me.gpbBuscarSocio.Controls.Add(Me.txtCriterio)
        Me.gpbBuscarSocio.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBuscarSocio.Location = New System.Drawing.Point(14, 36)
        Me.gpbBuscarSocio.Name = "gpbBuscarSocio"
        Me.gpbBuscarSocio.Size = New System.Drawing.Size(569, 558)
        Me.gpbBuscarSocio.TabIndex = 0
        Me.gpbBuscarSocio.TabStop = False
        Me.gpbBuscarSocio.Text = "Buscar Socio"
        '
        'txtCantSocio
        '
        Me.txtCantSocio.Enabled = False
        Me.txtCantSocio.Location = New System.Drawing.Point(132, 506)
        Me.txtCantSocio.Name = "txtCantSocio"
        Me.txtCantSocio.ReadOnly = True
        Me.txtCantSocio.Size = New System.Drawing.Size(94, 27)
        Me.txtCantSocio.TabIndex = 23
        Me.txtCantSocio.Visible = False
        '
        'lblCantSocio
        '
        Me.lblCantSocio.AutoSize = True
        Me.lblCantSocio.Location = New System.Drawing.Point(6, 509)
        Me.lblCantSocio.Name = "lblCantSocio"
        Me.lblCantSocio.Size = New System.Drawing.Size(121, 19)
        Me.lblCantSocio.TabIndex = 22
        Me.lblCantSocio.Text = "Cantidad Socios"
        Me.lblCantSocio.Visible = False
        '
        'pbVerTotalArea
        '
        Me.pbVerTotalArea.BackgroundImage = CType(resources.GetObject("pbVerTotalArea.BackgroundImage"), System.Drawing.Image)
        Me.pbVerTotalArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbVerTotalArea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbVerTotalArea.Location = New System.Drawing.Point(495, 509)
        Me.pbVerTotalArea.Name = "pbVerTotalArea"
        Me.pbVerTotalArea.Size = New System.Drawing.Size(30, 30)
        Me.pbVerTotalArea.TabIndex = 20
        Me.pbVerTotalArea.TabStop = False
        Me.help.SetToolTip(Me.pbVerTotalArea, "Ver cantidad socios activos")
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
        'pbModificar
        '
        Me.pbModificar.BackgroundImage = CType(resources.GetObject("pbModificar.BackgroundImage"), System.Drawing.Image)
        Me.pbModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbModificar.Location = New System.Drawing.Point(459, 509)
        Me.pbModificar.Name = "pbModificar"
        Me.pbModificar.Size = New System.Drawing.Size(30, 30)
        Me.pbModificar.TabIndex = 10
        Me.pbModificar.TabStop = False
        Me.help.SetToolTip(Me.pbModificar, "Modificar")
        '
        'pbEliminar
        '
        Me.pbEliminar.BackgroundImage = CType(resources.GetObject("pbEliminar.BackgroundImage"), System.Drawing.Image)
        Me.pbEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbEliminar.Location = New System.Drawing.Point(531, 509)
        Me.pbEliminar.Name = "pbEliminar"
        Me.pbEliminar.Size = New System.Drawing.Size(30, 30)
        Me.pbEliminar.TabIndex = 9
        Me.pbEliminar.TabStop = False
        Me.help.SetToolTip(Me.pbEliminar, "Eliminar")
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
        Me.dgvDatos.Size = New System.Drawing.Size(556, 382)
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
        'ctlBuscarSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlBuscarSocio"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbModificarSocio.ResumeLayout(False)
        Me.gpbModificarSocio.PerformLayout()
        Me.gpbFerias.ResumeLayout(False)
        Me.gpbFerias.PerformLayout()
        CType(Me.pbQuitar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbInsertar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbConfirmar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbBuscarSocio.ResumeLayout(False)
        Me.gpbBuscarSocio.PerformLayout()
        CType(Me.pbVerTotalArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gpbBuscarSocio As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents txtCriterio As System.Windows.Forms.TextBox
    Friend WithEvents gpbModificarSocio As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents lblCorreo As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtDireccionCasa As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccionCasa As System.Windows.Forms.Label
    Friend WithEvents txtDireccionFinca As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccionFinca As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents txtFechaIngreso As System.Windows.Forms.TextBox
    Friend WithEvents lblFechaIngreso As System.Windows.Forms.Label
    Friend WithEvents pbModificar As System.Windows.Forms.PictureBox
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents pbEliminar As System.Windows.Forms.PictureBox
    Friend WithEvents pbRegresar As System.Windows.Forms.PictureBox
    Friend WithEvents pbConfirmar As System.Windows.Forms.PictureBox
    Friend WithEvents gpbFerias As System.Windows.Forms.GroupBox
    Friend WithEvents pbQuitar As System.Windows.Forms.PictureBox
    Friend WithEvents pbInsertar As System.Windows.Forms.PictureBox
    Friend WithEvents lblFeriaAsiste As System.Windows.Forms.Label
    Friend WithEvents ltbFeriaAsiste As System.Windows.Forms.ListBox
    Friend WithEvents ltbFeria As System.Windows.Forms.ListBox
    Friend WithEvents lblFeria As System.Windows.Forms.Label
    Friend WithEvents lblCriterio As System.Windows.Forms.Label
    Friend WithEvents pbVerTotalArea As System.Windows.Forms.PictureBox
    Friend WithEvents txtCantSocio As System.Windows.Forms.TextBox
    Friend WithEvents lblCantSocio As System.Windows.Forms.Label
    Friend WithEvents txtNombreBuscar As System.Windows.Forms.TextBox

End Class
