Imports Domain
Public Class FormNewAlquiler
    Dim alquilerModel As New AlquilerModel()
    Public state As Boolean
#Region "ACCIONES DEL FORMULARIO GENERAL"
    Private Sub FormNewAlquiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarClientes()
        ListarEquipos()
    End Sub
    Private Sub ListarClientes()
        Dim clienteModel As New ClienteModel()
        CmbCliente.DataSource = clienteModel.GetClientesForCmb
        CmbCliente.DisplayMember = "DataView"
        CmbCliente.ValueMember = "ID_Cliente"
    End Sub
    Private Sub ListarEquipos()
        Dim equipoModel As New EquipoModel()
        CmbEquipo.DataSource = equipoModel.GetEquiposDisponibles
        CmbEquipo.DisplayMember = "Serial"
        CmbEquipo.ValueMember = "Serial"
    End Sub
#End Region

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        state = False
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim resultado As Integer
        Dim msgMin As String = "Minimo de alquiler"
        Dim msgFinal As String = ""

        alquilerModel.FK_Cliente = CmbCliente.SelectedValue
        alquilerModel.FK_Equipo = CmbEquipo.SelectedValue
        alquilerModel.FechaInicio = DateTime.Today
        alquilerModel.FechaFinal = BunifuDatePicker1.Value.Date
        alquilerModel.State = EntityState.Added

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

End Class