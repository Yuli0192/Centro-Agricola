<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PopupRegistrarFeria
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PopupRegistrarFeria))
        Me.gpbRegistrarFeria = New System.Windows.Forms.GroupBox
        Me.pbCancelar = New System.Windows.Forms.PictureBox
        Me.pbRegistrar = New System.Windows.Forms.PictureBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.gpbRegistrarFeria.SuspendLayout()
        CType(Me.pbCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpbRegistrarFeria
        '
        Me.gpbRegistrarFeria.BackColor = System.Drawing.Color.Transparent
        Me.gpbRegistrarFeria.Controls.Add(Me.pbCancelar)
        Me.gpbRegistrarFeria.Controls.Add(Me.pbRegistrar)
        Me.gpbRegistrarFeria.Controls.Add(Me.txtNombre)
        Me.gpbRegistrarFeria.Controls.Add(Me.lblNombre)
        Me.gpbRegistrarFeria.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbRegistrarFeria.Location = New System.Drawing.Point(5, 5)
        Me.gpbRegistrarFeria.Name = "gpbRegistrarFeria"
        Me.gpbRegistrarFeria.Size = New System.Drawing.Size(489, 172)
        Me.gpbRegistrarFeria.TabIndex = 16
        Me.gpbRegistrarFeria.TabStop = False
        Me.gpbRegistrarFeria.Text = "Registrar Feria"
        '
        'pbCancelar
        '
        Me.pbCancelar.BackgroundImage = CType(resources.GetObject("pbCancelar.BackgroundImage"), System.Drawing.Image)
        Me.pbCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbCancelar.Location = New System.Drawing.Point(277, 93)
        Me.pbCancelar.Name = "pbCancelar"
        Me.pbCancelar.Size = New System.Drawing.Size(30, 30)
        Me.pbCancelar.TabIndex = 14
        Me.pbCancelar.TabStop = False
        Me.help.SetToolTip(Me.pbCancelar, "Cancelar")
        '
        'pbRegistrar
        '
        Me.pbRegistrar.BackgroundImage = CType(resources.GetObject("pbRegistrar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegistrar.Location = New System.Drawing.Point(207, 93)
        Me.pbRegistrar.Name = "pbRegistrar"
        Me.pbRegistrar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegistrar.TabIndex = 12
        Me.pbRegistrar.TabStop = False
        Me.help.SetToolTip(Me.pbRegistrar, "Registrar")
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(123, 60)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(296, 27)
        Me.txtNombre.TabIndex = 1
        Me.help.SetToolTip(Me.txtNombre, "PARAISO")
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(40, 63)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(66, 19)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'PopupRegistrarFeria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(500, 183)
        Me.Controls.Add(Me.gpbRegistrarFeria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(506, 211)
        Me.Name = "PopupRegistrarFeria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registrar una nueva feria"
        Me.gpbRegistrarFeria.ResumeLayout(False)
        Me.gpbRegistrarFeria.PerformLayout()
        CType(Me.pbCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpbRegistrarFeria As System.Windows.Forms.GroupBox
    Friend WithEvents pbRegistrar As System.Windows.Forms.PictureBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents pbCancelar As System.Windows.Forms.PictureBox
    Friend WithEvents help As System.Windows.Forms.ToolTip
End Class
