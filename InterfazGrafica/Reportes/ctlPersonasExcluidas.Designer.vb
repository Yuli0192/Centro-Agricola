<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlPersonasExcluidas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlPersonasExcluidas))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.listarPersonasExcluidas = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.pbRegresar = New System.Windows.Forms.PictureBox
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.clientesExcluidos1 = New InterfazGrafica.ClientesExcluidos
        Me.Panel1.SuspendLayout()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.listarPersonasExcluidas)
        Me.Panel1.Controls.Add(Me.pbRegresar)
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Location = New System.Drawing.Point(27, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(994, 588)
        Me.Panel1.TabIndex = 0
        '
        'listarPersonasExcluidas
        '
        Me.listarPersonasExcluidas.ActiveViewIndex = -1
        Me.listarPersonasExcluidas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listarPersonasExcluidas.DisplayGroupTree = False
        Me.listarPersonasExcluidas.Location = New System.Drawing.Point(15, 47)
        Me.listarPersonasExcluidas.Name = "listarPersonasExcluidas"
        Me.listarPersonasExcluidas.SelectionFormula = ""
        Me.listarPersonasExcluidas.Size = New System.Drawing.Size(957, 522)
        Me.listarPersonasExcluidas.TabIndex = 39
        Me.listarPersonasExcluidas.ViewTimeSelectionFormula = ""
        '
        'pbRegresar
        '
        Me.pbRegresar.BackgroundImage = CType(resources.GetObject("pbRegresar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresar.Location = New System.Drawing.Point(942, 3)
        Me.pbRegresar.Name = "pbRegresar"
        Me.pbRegresar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegresar.TabIndex = 8
        Me.pbRegresar.TabStop = False
        Me.help.SetToolTip(Me.pbRegresar, "Regresar")
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(386, 15)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(221, 29)
        Me.lblTitulo.TabIndex = 38
        Me.lblTitulo.Text = "Personas Excluidas "
        '
        'ctlPersonasExcluidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlPersonasExcluidas"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents pbRegresar As System.Windows.Forms.PictureBox
    Friend WithEvents listarPersonasExcluidas As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents clientesExcluidos1 As InterfazGrafica.ClientesExcluidos

End Class
