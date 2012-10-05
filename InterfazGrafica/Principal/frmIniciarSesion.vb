Imports LogicaNegocio.ClsGestor
Public Class frmIniciarSesion
    Dim _gestor As New LogicaNegocio.ClsGestor 'declara e instancia de la clase Gestor
    Private Sub frmIniciarSesion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtusuario.Focus()
    End Sub

    Private Function validarEspacio() As Boolean

        If Me.txtusuario.Text.Equals("") Then

            MessageBox.Show("Debe ingresar el nombre de usuario", "Iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtusuario.Focus()
            Return False

        End If

        If Me.txtContrasenna.Text.Equals("") Then

            MessageBox.Show("Debe ingresar la contraseña", "Iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtContrasenna.Text = ""
            Me.txtContrasenna.Focus()
            Return False

        End If

        Return True

    End Function

    Private Sub iniciarSesion()
        If validarEspacio() Then

            Try
                DATOS_USUARIO = _gestor.iniciarSession(Me.txtusuario.Text, Me.txtContrasenna.Text)

                If DATOS_USUARIO.Count > 0 Then
                    ROL_USUARIO = DATOS_USUARIO(4)

                    Dim frmPrincipal As frmCentroAgricola
                    frmPrincipal = New frmCentroAgricola(Me)
                    frmPrincipal.Show()

                    Me.Hide()
                Else
                    MessageBox.Show("El usuario o contraseña no coinciden.", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MessageBox.Show("Error al tratar de conectar con la base de datos.", "Error con la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Sub pbIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbIngresar.Click
        iniciarSesion()
    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Dim report As New PermisoSocio
    '        report.PrintToPrinter(1, False, 1, 1)
    '    Catch ex As Exception
    '        MessageBox.Show("Ocurrio un error al tratar de imprimir" & ex.Message)
    '    End Try

    'End Sub

    'Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Dim report As New prueba2
    '        report.PrintToPrinter(1, False, 1, 1)
    '    Catch ex As Exception
    '        MessageBox.Show("Ocurrio un error al tratar de imprimir" & ex.Message)
    '    End Try
    'End Sub
End Class