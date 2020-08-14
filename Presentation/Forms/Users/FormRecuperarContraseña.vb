Imports Domain
Public Class FormRecuperarContraseña
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim userModel As New UserModel
        Dim result = userModel.RecuperarContraseña(txtBox.Text)
        lblMsg.Text = result
        If result.Length > 90 Then Me.Height = 230 Else Me.Height = 190
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class