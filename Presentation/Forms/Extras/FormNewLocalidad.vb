Imports Domain

Public Class FormNewLocalidad
    Public state As Boolean
    Dim localidadModel As New LocalidadModel
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim resultado As Integer
        Dim msgCP As String = "Codigo postal"
        Dim msgfinal As String = ""
        localidadModel.Nombre = txtNombre.Text
        localidadModel.Observacion = txtObs.Text
        localidadModel.State = EntityState.Added

        Dim valido = New ValidacionesExtras(txtCP.Text).ToInteger(msgCP, resultado)
        Dim valid = New DataValidation(localidadModel).validate(msgfinal)
        If valid = True Then
            If valido = True Then
                localidadModel.CodigoPostal = resultado
                localidadModel.SaveChanges()
                state = True
                Me.Close()
            Else
                Dim formularioMsg As FormError
                formularioMsg = New FormError With {
                .mensaje = msgCP
            }
                formularioMsg.ShowDialog()
            End If
        Else
            If Not valido Then msgfinal += msgCP
            Dim formularioMsg As FormError
            formularioMsg = New FormError With {
                .mensaje = msgfinal
            }
            formularioMsg.ShowDialog()
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCP.KeyPress
        If Not IsNumeric(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.KeyChar = ""
        End If
    End Sub
End Class