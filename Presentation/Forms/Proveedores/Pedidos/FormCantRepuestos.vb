Public Class FormCantRepuestos
    Public state As Boolean
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        state = False
        Me.Close()
    End Sub
    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtCantidad.Text = "" Then
                Dim formulario As FormError
                formulario = New FormError With {
                    .mensaje = "       El campo cantidad es requerido"
                }
                formulario.ShowDialog()
            Else
                state = True
                Me.Close()
            End If
        ElseIf Not IsNumeric(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.KeyChar = ""
        End If
    End Sub

End Class