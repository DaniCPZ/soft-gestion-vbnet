Imports Domain
Imports Common
Public Class FormEditAlquiler
    Dim alquilerModel As New AlquilerModel()
    Public nroAlquiler As Integer
    Public cliente As Integer
    Public equipo As String
    Public state As Boolean
    Private Sub FormEditAlquiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Seguirdad()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim resultado As Integer
        Dim msgMin As String = "Minimo de alquiler"
        Dim msgFinal As String = ""

        alquilerModel.NroAlquiler = nroAlquiler
        alquilerModel.FK_Cliente = cliente
        alquilerModel.FK_Equipo = equipo
        alquilerModel.FechaFinal = BunifuDatePicker1.Value.Date
        alquilerModel.State = EntityState.Modified
        Dim valido = New ValidacionesExtras(TxtMinAlquiler.Text).ToInteger(msgMin, resultado)
        Dim valid = New DataValidation(alquilerModel).validate(msgFinal)
        If valid = True Then
            If valido = True Then
                alquilerModel.MinAlquiler = resultado
                Dim result = alquilerModel.SaveChanges()
                state = True
                Me.Close()
            Else
                Dim formularioMsg As FormError
                formularioMsg = New FormError With {
                .mensaje = msgMin
                }
                formularioMsg.ShowDialog()

            End If
        Else
            If Not valido Then msgFinal = +msgMin
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
    Private Sub Seguirdad()
        If ActiveUser.Cargo = Cargos.administrador Then

        End If
    End Sub
End Class