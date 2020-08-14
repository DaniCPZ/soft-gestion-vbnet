Imports Common
Imports Domain
Public Class FormUser
    Dim userModel As New UserModel()
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarUser()
        InicializarControles()
    End Sub
    Private Sub CargarUser()
        lblLoginName.Text = ActiveUser.LoginName
        lblNombre.Text = ActiveUser.Nombre
        lblApellido.Text = ActiveUser.Apellido
        lblEmail.Text = ActiveUser.Email
        lblCargo.Text = ActiveUser.Cargo

        txtLoginName.Text = ActiveUser.LoginName
        txtNombre.Text = ActiveUser.Nombre
        txtApellido.Text = ActiveUser.Apellido
        txtEmail.Text = ActiveUser.Email
        txtContraseña.Text = ActiveUser.Password
        txtConfirmarContraseña.Text = ActiveUser.Password
    End Sub
    Private Sub InicializarControles()
        LinkLabel1.Text = "Editar"
        txtContraseña.UseSystemPasswordChar = True
        txtContraseña.Enabled = False
        txtConfirmarContraseña.UseSystemPasswordChar = True
        txtConfirmarContraseña.Enabled = False
        txtContraseñaActual.UseSystemPasswordChar = True
    End Sub
    Private Sub reset()
        CargarUser()
        InicializarControles()
        Me.Size = New Size(502, 542)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If LinkLabel1.Text = "Editar" Then
            LinkLabel1.Text = "Cancelar"
            txtContraseña.Text = ""
            txtContraseña.Enabled = True
            txtConfirmarContraseña.Text = ""
            txtConfirmarContraseña.Enabled = True
        ElseIf LinkLabel1.Text = "Cancelar" Then
            reset()
        End If
    End Sub

    Private Sub linkEditar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkEditar.LinkClicked
        pnlEditarPerfil.Visible = True
        Me.Size = New Size(822, 542)
        CargarUser()
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim mensaje As String
        Dim valid As Boolean
        If txtContraseña.Text = txtConfirmarContraseña.Text Then
            If txtContraseñaActual.Text = ActiveUser.Password Then
                userModel.ID_User = ActiveUser.idUser
                userModel.LoginName = txtLoginName.Text
                userModel.Nombre = txtNombre.Text
                userModel.Apellido = txtApellido.Text
                userModel.Email = txtEmail.Text
                userModel.Password = txtContraseña.Text
                mensaje = userModel.EditarPerfil()
                pnlEditarPerfil.Visible = False
                reset()
                valid = True
            Else
                mensaje = "Contraseña actual incorrecta"
                valid = False
            End If
        Else
            mensaje = "Las contraseñas no coinciden, intentelo de nuevo"
            valid = False
        End If
        If valid Then
            Dim formulario As FormSuccess
            formulario = New FormSuccess With {
                    .mensaje = mensaje
                }
            formulario.ShowDialog()
        Else
            Dim formulario As FormError
            formulario = New FormError With {
                    .mensaje = mensaje
                }
            formulario.ShowDialog()
        End If

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        pnlEditarPerfil.Visible = False
        reset()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class