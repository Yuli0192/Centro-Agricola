Public Class frmCentroAgricola

    Private _frmIniciar As frmIniciarSesion

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal pfrmIniciar As frmIniciarSesion)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _frmIniciar = pfrmIniciar

        'Informacion
        'Me.Text = " Bienvenid@ " & DATOS_USUARIO(0) & " " & DATOS_USUARIO(1) & " " & DATOS_USUARIO(2) & " al Sistema Educativo S.A  |  Rol: " & DATOS_USUARIO(4)

    End Sub
    ''Cargar un control
    'Public Sub cargarUserControl(ByVal userControl As UserControl)
    '    userControl.Location = point
    '    quitarUserControl(userControl)
    '    Me.Controls.Add(userControl)
    'End Sub

    'Cargar un control
    Sub cargarUserControl(ByVal userControl As UserControl)
        quitarUserControl(userControl)
        Me.Controls.Add(userControl)
    End Sub

    'Quitar un control
    Sub quitarUserControl(ByVal p_uc As UserControl)
        For Each uc As Control In Me.Controls
            If TypeOf uc Is UserControl Then
                uc.Visible = False
            End If
        Next
        p_uc.Visible = True
    End Sub

    Private Sub frmCentroAgricola_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarUserControl(New ctlPrincipal)
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductoToolStripMenuItem.Click
        cargarUserControl(New ctlRegistrarProducto)
    End Sub

    Private Sub SocioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SocioToolStripMenuItem.Click
        cargarUserControl(New ctlRegistrarSocio)
    End Sub

    Private Sub AuxiliarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuxiliarToolStripMenuItem.Click
        cargarUserControl(New ctlRegistrarAuxiliar)
    End Sub

    Private Sub SocioToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SocioToolStripMenuItem1.Click
        cargarUserControl(New ctlBuscarSocio)
    End Sub

    Private Sub AuxiliarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuxiliarToolStripMenuItem1.Click
        cargarUserControl(New ctlBuscarAuxiliar)
    End Sub

    Private Sub FeriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeriaToolStripMenuItem.Click
        'Ve y aqui nos sale error por que ahora pide que le mande el parametro en el constructor.
        'pero aqui no se necesita enviarselo... entonces usted puede sobrecargar el constructor.
        'Un constructor que reciba el formularioa de socio... y otro que no reciba nada...
        cargarUserControl(New ctlRegistrarFeria)
    End Sub

    Private Sub FincaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FincaToolStripMenuItem.Click
        cargarUserControl(New ctlRegistrarFinca)
    End Sub

    Private Sub FincaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FincaToolStripMenuItem1.Click
        cargarUserControl(New ctlBuscarFinca)
    End Sub

    Private Sub SocioInactivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SocioInactivoToolStripMenuItem.Click
        cargarUserControl(New ctlBuscarSocioInactivo)
    End Sub

    Private Sub AuxiliarInactivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuxiliarInactivoToolStripMenuItem.Click
        cargarUserControl(New ctlBuscarAuxiliarInactivo)
    End Sub

    Private Sub InspecciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InspecciónToolStripMenuItem.Click
        cargarUserControl(New ctlRegistrarInspeccion)
    End Sub

    Private Sub SocioPorProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SocioPorProductoToolStripMenuItem.Click
        cargarUserControl(New ctlBuscarSocioProducto)
    End Sub

    Private Sub AuxiliarPorProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuxiliarPorProductoToolStripMenuItem.Click
        cargarUserControl(New ctlBuscarAuxProducto)
    End Sub

    Private Sub CarnetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CarnetToolStripMenuItem.Click
        cargarUserControl(New ctlCarnetVencido)
    End Sub

    Private Sub PermisosVencidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermisosVencidosToolStripMenuItem.Click
        cargarUserControl(New ctlPermisoVencido)
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteToolStripMenuItem.Click
        cargarUserControl(New ctlRegistrarCliente)
    End Sub

    Private Sub ClienteActivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteActivoToolStripMenuItem.Click
        cargarUserControl(New ctlBuscarClienteActivo)
    End Sub

    Private Sub ClienteInactivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteInactivoToolStripMenuItem.Click
        cargarUserControl(New ctlBuscarClienteInactivo)
    End Sub

    Private Sub OrdenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenToolStripMenuItem.Click
        cargarUserControl(New ctlRegistrarOrden)
    End Sub

    Private Sub CancelarOrdenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarOrdenToolStripMenuItem.Click
        cargarUserControl(New ctlCancelarOrden)
    End Sub

    Private Sub frmSiscove_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmIniciarSesion.Show()
        frmIniciarSesion.txtContrasenna.Text = ""
        frmIniciarSesion.txtusuario.Text = ""
        frmIniciarSesion.txtusuario.Focus()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuarioToolStripMenuItem.Click
        cargarUserControl(New ctlRegistrarUsuario)
    End Sub

    Private Sub OrdenesPendientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenesPendientesToolStripMenuItem.Click
        cargarUserControl(New ctlListadoOrdenesPendientes)
    End Sub

    Private Sub RecibosOrdenesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecibosOrdenesToolStripMenuItem.Click
        cargarUserControl(New ctlListadoReciboOrden)
    End Sub

    Private Sub RecibosDiarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecibosDiarioToolStripMenuItem.Click
        cargarUserControl(New ctlListarReciboDiario)
    End Sub

    Private Sub OrdenesPendientesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenesPendientesToolStripMenuItem1.Click
        cargarUserControl(New ctlOrdenPendiente)
    End Sub

    Private Sub OrdenesCanceladasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenesCanceladasToolStripMenuItem.Click
        cargarUserControl(New ctlBuscarOrdenCancelada)
    End Sub

    Private Sub PersonasExcluidasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonasExcluidasToolStripMenuItem.Click
        cargarUserControl(New ctlPersonasExcluidas)
    End Sub

    Private Sub OrdenesCanceladasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenesCanceladasToolStripMenuItem1.Click
        cargarUserControl(New ctlListadoOrdenesCanceladas)
    End Sub

    Private Sub PermisoSemanalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermisoSemanalToolStripMenuItem.Click
        cargarUserControl(New ctlPermisoSemanal)
    End Sub

    Private Sub InspecciónSemanalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InspecciónSemanalToolStripMenuItem.Click
        cargarUserControl(New ctlInspeccionSemanal)
    End Sub

    Private Sub PermisosPendienteSocioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermisosPendienteSocioToolStripMenuItem.Click
        cargarUserControl(New ctlBuscarPermisoSocioPendiente)
    End Sub

    Private Sub PermisoAuxiliarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermisoAuxiliarToolStripMenuItem.Click
        cargarUserControl(New ctlBuscarPermisoAuxPendiente)
    End Sub

    Private Sub InspecciónToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InspecciónToolStripMenuItem1.Click
        cargarUserControl(New ctlBuscarInspeccion)
    End Sub

    Private Sub CarneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CarneToolStripMenuItem.Click
        cargarUserControl(New ctlInspeccionMes)
    End Sub

    Private Sub OrdenesMesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenesMesToolStripMenuItem.Click
        cargarUserControl(New OrdenMes)
    End Sub

    Private Sub SocioToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SocioToolStripMenuItem2.Click
        cargarUserControl(New ctlRegistrarPermiso)
    End Sub

    Private Sub AuxiliarToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuxiliarToolStripMenuItem2.Click
        cargarUserControl(New ctlRegistrarPermisoAux)
    End Sub

    Private Sub FacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaToolStripMenuItem.Click
        cargarUserControl(New ctlFactura)
    End Sub

    Private Sub SocioPorProductoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SocioPorProductoToolStripMenuItem1.Click
        cargarUserControl(New ctlListadoSocioProducto)
    End Sub

    Private Sub AuxiliarPorProductoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuxiliarPorProductoToolStripMenuItem1.Click
        cargarUserControl(New ctlListadoAuxProducto)
    End Sub

    Private Sub SociosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SociosToolStripMenuItem.Click
        cargarUserControl(New ctlListadoSocio)
    End Sub

    Private Sub RecibosInscripciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecibosInscripciónToolStripMenuItem.Click
        cargarUserControl(New ctlListarInscripcion)
    End Sub
End Class