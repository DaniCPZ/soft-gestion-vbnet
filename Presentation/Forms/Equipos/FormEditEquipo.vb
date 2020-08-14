Imports Domain
Imports Common
Public Class FormEditEquipo
    Public serial As String
    Public state As Boolean
    Dim equipoModel As New EquipoModel()

    Private Sub FormEditEquipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Seguridad()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        state = False
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim resultado As Integer
        Dim msgCopias As String = "Cantidad de copias"
        Dim msgFinal As String = ""

        equipoModel.Serial = serial
        equipoModel.Marca = TxtMarca.Text.Trim
        equipoModel.Modelo = TxtModelo.Text.Trim
        equipoModel.TipoImpresion = TxtImpresion.Text.Trim
        equipoModel.Velocidad = TxtVelocidad.Text.Trim
        equipoModel.State = EntityState.Modified

        Dim valido = New ValidacionesExtras(TxtCopias.Text).ToInteger(msgCopias, resultado)
        Dim valid = New DataValidation(equipoModel).validate(msgFinal)
        If valid = True Then
            If valido = True Then
                equipoModel.CantCopias = resultado
                Dim result = equipoModel.SaveChanges()
                state = True
                Me.Close()
            Else
                Dim formularioMsg As FormError
                formularioMsg = New FormError With {
                .mensaje = msgCopias
                }
                formularioMsg.ShowDialog()
            End If
        Else
            If Not valido Then msgFinal += msgCopias
            Dim formularioMsg As FormError
            formularioMsg = New FormError With {
                .mensaje = msgFinal
            }
            formularioMsg.ShowDialog()
        End If
    End Sub

#Region "SEGURIDAD"
    Private Sub Seguridad()
        If ActiveUser.Cargo = Cargos.gerente Then
            TxtSerial.Enabled = False
        End If
        If ActiveUser.Cargo = Cargos.administrador Then
            TxtSerial.Enabled = False
        End If
    End Sub
#End Region
End Class