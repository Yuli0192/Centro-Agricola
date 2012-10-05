<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlBuscarSocioInactivo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlBuscarSocioInactivo))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pbRegresar = New System.Windows.Forms.PictureBox
        Me.gpbBuscarSocio = New System.Windows.Forms.GroupBox
        Me.lblCriterio = New System.Windows.Forms.Label
        Me.pbActivar = New System.Windows.Forms.PictureBox
        Me.dgvDatos = New System.Windows.Forms.DataGridView
        Me.txtCriterio = New System.Windows.Forms.TextBox
        Me.Help = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbBuscarSocio.SuspendLayout()
        CType(Me.pbActivar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbRegresar)
        Me.Panel1.Controls.Add(Me.gpbBuscarSocio)
        Me.Panel1.Location = New System.Drawing.Point(141, 111)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(732, 481)
        Me.Panel1.TabIndex = 0
        '
        'pbRegresar
        '
        Me.pbRegresar.BackgroundImage = CType(resources.GetObject("pbRegresar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresar.Location = New System.Drawing.Point(699, 3)
        Me.pbRegresar.Name = "pbRegresar"
        Me.pbRegresar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegresar.TabIndex = 10
        Me.pbRegresar.TabStop = False
        Me.Help.SetToolTip(Me.pbRegresar, "Regresar")
        '
        'gpbBuscarSocio
        '
        Me.gpbBuscarSocio.Controls.Add(Me.lblCriterio)
        Me.gpbBuscarSocio.Controls.Add(Me.pbActivar)
        Me.gpbBuscarSocio.Controls.Add(Me.dgvDatos)
        Me.gpbBuscarSocio.Controls.Add(Me.txtCriterio)
        Me.gpbBuscarSocio.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBuscarSocio.Location = New System.Drawing.Point(35, 17)
        Me.gpbBuscarSocio.Name = "gpbBuscarSocio"
        Me.gpbBuscarSocio.Size = New System.Drawing.Size(658, 440)
        Me.gpbBuscarSocio.TabIndex = 1
        Me.gpbBuscarSocio.TabStop = False
        Me.gpbBuscarSocio.Text = "Buscar Socio"
        '
        'lblCriterio
        '
        Me.lblCriterio.AutoSize = True
        Me.lblCriterio.Location = New System.Drawing.Point(28, 33)
        Me.lblCriterio.Name = "lblCriterio"
        Me.lblCriterio.Size = New System.Drawing.Size(134, 19)
        Me.lblCriterio.TabIndex = 12
        Me.lblCriterio.Text = "Criterio búsqueda"
        '
        'pbActivar
        '
        Me.pbActivar.BackgroundImage = CType(resources.GetObject("pbActivar.BackgroundImage"), System.Drawing.Image)
        Me.pbActivar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbActivar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbActivar.Location = New System.Drawing.Point(622, 404)
        Me.pbActivar.Name = "pbActivar"
        Me.pbActivar.Size = New System.Drawing.Size(30, 30)
        Me.pbActivar.TabIndex = 9
        Me.pbActivar.TabStop = False
        Me.Help.SetToolTip(Me.pbActivar, "Activar")
        '
        'dgvDatos
        '
        Me.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDatos.BackgroundColor = System.Drawing.Color.White
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Location = New System.Drawing.Point(6, 63)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.RowHeadersVisible = False
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(646, 335)
        Me.dgvDatos.TabIndex = 3
        '
        'txtCriterio
        '
        Me.txtCriterio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCriterio.Location = New System.Drawing.Point(168, 30)
        Me.txtCriterio.Name = "txtCriterio"
        Me.txtCriterio.Size = New System.Drawing.Size(234, 27)
        Me.txtCriterio.TabIndex = 2
        Me.Help.SetToolTip(Me.txtCriterio, "301920349 o SOLANO QUESADA DANIEL")
        '
        'ctlBuscarSocioInactivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlBuscarSocioInactivo"
        Me.Size = New System.Drawing.Size(1024, 568)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbBuscarSocio.ResumeLayout(False)
        Me.gpbBuscarSocio.PerformLayout()
        CType(Me.pbActivar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gpbBuscarSocio As System.Windows.Forms.GroupBox
    Friend WithEvents lblCriterio As System.Windows.Forms.Label
    Friend WithEvents pbActivar As System.Windows.Forms.PictureBox
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents txtCriterio As System.Windows.Forms.TextBox
    Friend WithEvents Help As System.Windows.Forms.ToolTip
    Friend WithEvents pbRegresar As System.Windows.Forms.PictureBox

End Class
