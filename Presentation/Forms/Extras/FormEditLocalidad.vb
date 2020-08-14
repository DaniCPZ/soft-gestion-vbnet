Imports Domain

Public Class FormEditLocalidad
    Dim localidadModel As New LocalidadModel
    Public state As Boolean
    Public CodPostal As Integer

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim msgFinal = ""
        localidadModel.CodigoPostal = CodPostal
        localidadModel.Nombre = txtNombre.Text
        localidadModel.Observacion = txtObs.Text
        localidadModel.State = EntityState.Modified

        Dim valid = New DataValidation(localidadModel).validate(msgfinal)
        If valid = True Then
            localidadModel.SaveChanges()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        state = False
        Me.Close()
    End Sub
End Class