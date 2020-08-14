Public Class FormClienteCobranza
    Public state As Boolean

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        state = False
        Me.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        state = True
        Me.Close()
    End Sub
End Class