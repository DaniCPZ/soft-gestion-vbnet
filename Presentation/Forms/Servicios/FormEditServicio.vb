Imports Domain
Public Class FormEditServicio
    Public state As Boolean
    Public idServicio As String
    Dim servicioModel As New ServicioModel()
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim msgFinal As String = ""

        servicioModel.NroServicio = Convert.ToInt32(idServicio)

        If TxtObservacion.Text <> "" Then
            servicioModel.Observacion = TxtObservacion.Text
            servicioModel.State = EntityState.Modified
            servicioModel.SaveChanges()
            state = True
            Me.Close()
        Else
            msgFinal = "El campo Observacion es requerido"
            MsgBox(msgFinal)
        End If

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        state = False
        Me.Close()
    End Sub
End Class