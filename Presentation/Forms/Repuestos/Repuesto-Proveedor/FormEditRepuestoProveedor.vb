Imports Domain

Public Class FormEditRepuestoProveedor
    Dim repProvModel As New RepuestoProveedorModel
    Public state As Boolean
    Public repuesto As String
    Public proveedor As Integer

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Not TxtObs.Text = "" Then
            repProvModel.FK_Proveedor = proveedor
            repProvModel.FK_Repuesto = repuesto
            repProvModel.Observacion = TxtObs.Text
            repProvModel.State = EntityState.Modified
            repProvModel.SaveChanges()
            state = True
            Me.Close()
        Else
            Dim formulario As FormError
            formulario = New FormError With {
                .mensaje = "       El campo Observacion es requerido"
            }
            formulario.ShowDialog()
        End If
    End Sub
End Class