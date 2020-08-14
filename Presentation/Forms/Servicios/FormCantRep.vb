Public Class FormCantRep
    Public state As Boolean
    Public limit As Integer
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
                If ControlStock(Convert.ToInt32(txtCantidad.Text)) Then
                    state = True
                    Me.Close()
                Else
                    Dim formulario As FormError
                    formulario = New FormError With {
                        .mensaje = "           No hay suficiente stock"
                    }
                    formulario.ShowDialog()
                End If
            End If
        ElseIf Not IsNumeric(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Function ControlStock(i As Integer) As Boolean
        Dim isValid As Boolean
        If (limit >= i) Then
            isValid = True
        Else
            isValid = False
        End If
        Return isValid
    End Function


End Class