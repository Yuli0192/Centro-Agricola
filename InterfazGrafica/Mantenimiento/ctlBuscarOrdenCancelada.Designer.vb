<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlBuscarOrdenCancelada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlBuscarOrdenCancelada))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pbRegresar = New System.Windows.Forms.PictureBox
        Me.gpbOrdenCancelada = New System.Windows.Forms.GroupBox
        Me.lblCriterio = New System.Windows.Forms.Label
        Me.txtCriterio = New System.Windows.Forms.TextBox
        Me.dgvOrden = New System.Windows.Forms.DataGridView
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbOrdenCancelada.SuspendLayout()
        CType(Me.dgvOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbRegresar)
        Me.Panel1.Controls.Add(Me.gpbOrdenCancelada)
        Me.Panel1.Location = New System.Drawing.Point(3, 114)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1004, 500)
        Me.Panel1.TabIndex = 1
        '
        'pbRegresar
        '
        Me.pbRegresar.BackgroundImage = CType(resources.GetObject("pbRegresar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresar.Location = New System.Drawing.Point(955, 14)
        Me.pbRegresar.Name = "pbRegresar"
        Me.pbRegresar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegresar.TabIndex = 4
        Me.pbRegresar.TabStop = False
        Me.help.SetToolTip(Me.pbRegresar, "Regresar")
        '
        'gpbOrdenCancelada
        '
        Me.gpbOrdenCancelada.Controls.Add(Me.lblCriterio)
        Me.gpbOrdenCancelada.Controls.Add(Me.txtCriterio)
        Me.gpbOrdenCancelada.Controls.Add(Me.dgvOrden)
        Me.gpbOrdenCancelada.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbOrdenCancelada.Location = New System.Drawing.Point(16, 39)
        Me.gpbOrdenCancelada.Name = "gpbOrdenCancelada"
        Me.gpbOrdenCancelada.Size = New System.Drawing.Size(975, 430)
        Me.gpbOrdenCancelada.TabIndex = 3
        Me.gpbOrdenCancelada.TabStop = False
        Me.gpbOrdenCancelada.Text = "Ordenes Canceladas"
        '
        'lblCriterio
        '
        Me.lblCriterio.AutoSize = True
        Me.lblCriterio.Location = New System.Drawing.Point(24, 57)
        Me.lblCriterio.Name = "lblCriterio"
        Me.lblCriterio.Size = New System.Drawing.Size(134, 19)
        Me.lblCriterio.TabIndex = 14
        Me.lblCriterio.Text = "Criterio búsqueda"
        '
        'txtCriterio
        '
        Me.txtCriterio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCriterio.Location = New System.Drawing.Point(164, 54)
        Me.txtCriterio.Name = "txtCriterio"
        Me.txtCriterio.Size = New System.Drawing.Size(234, 27)
        Me.txtCriterio.TabIndex = 13
        Me.help.SetToolTip(Me.txtCriterio, "301920349 o SOLANO QUESADA DANIEL")
        '
        'dgvOrden
        '
        Me.dgvOrden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOrden.BackgroundColor = System.Drawing.Color.White
        Me.dgvOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrden.Location = New System.Drawing.Point(12, 102)
        Me.dgvOrden.Name = "dgvOrden"
        Me.dgvOrden.ReadOnly = True
        Me.dgvOrden.RowHeadersVisible = False
        Me.dgvOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrden.Size = New System.Drawing.Size(957, 311)
        Me.dgvOrden.TabIndex = 3
        '
        'ctlBuscarOrdenCancelada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlBuscarOrdenCancelada"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbOrdenCancelada.ResumeLayout(False)
        Me.gpbOrdenCancelada.PerformLayout()
        CType(Me.dgvOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pbRegresar As System.Windows.Forms.PictureBox
    Friend WithEvents gpbOrdenCancelada As System.Windows.Forms.GroupBox
    Friend WithEvents dgvOrden As System.Windows.Forms.DataGridView
    Friend WithEvents lblCriterio As System.Windows.Forms.Label
    Friend WithEvents txtCriterio As System.Windows.Forms.TextBox
    Friend WithEvents help As System.Windows.Forms.ToolTip

End Class
