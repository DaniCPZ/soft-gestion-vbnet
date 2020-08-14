Imports Domain
Public Class FormNewUser
    Public state As Boolean
    Dim userModel As New UserModel
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        userModel.Nombre = TxtNombre.Text
        userModel.Apellido = txtApellido.Text
        userModel.LoginName = txtLoginName.Text
        userModel.Password = txtPass.Text
        userModel.Email = txtEmail.Text
        userModel.Cargo = CmbCargo.Text
        userModel.State = EntityState.Added

        Dim msgFinal As String = ""
        Dim valid = New DataValidation(userModel).validate(msgFinal)

        If valid = True Then
            Dim result = userModel.SaveChanges()
            state = True
            Me.Close()
        Else
            Dim formularioMsg As FormError
            formularioMsg = New FormError With {
               .mensaje = msgFinal
            }
            formularioMsg.ShowDialog()
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        state = False
        Me.Close()
    End Sub

    Private Sub FormNewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciarControles()
    End Sub
    Private Sub iniciarControles()
        CmbCargo.SelectedIndex = 0
    End Sub
End Class