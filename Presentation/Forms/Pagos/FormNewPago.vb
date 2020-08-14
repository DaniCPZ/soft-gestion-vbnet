Imports Domain
Public Class FormNewPago
    Public state As Boolean
    Dim pagoModel As New PagoModel()

#Region "ACCIONES DEL FORMULARIO GENERAL"
    Private Sub FormNewPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbTipoPago.SelectedIndex = 0
        CargarClientes()
    End Sub
    Private Sub CargarClientes()
        Dim clienteModel As New ClienteModel()
        CmbCliente.DataSource = clienteModel.GetClientesForCmb
        CmbCliente.DisplayMember = "DataView"
        CmbCliente.ValueMember = "ID_Cliente"
    End Sub

#End Region


#Region "NUEVO PAGO"
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim resultado As Decimal
        Dim msgImporte As String = "Importe"
        Dim msgFinal As String = ""

        pagoModel.FK_Cliente = CmbCliente.SelectedValue
        pagoModel.tipoPago = CmbTipoPago.SelectedItem
        pagoModel.Fecha = BunifuDatePicker1.Value.Date
        pagoModel.State = EntityState.Added

        Dim valido = New ValidacionesExtras(txtImporte.Text).ToDecimal(msgImporte, resultado)
        Dim valid = New DataValidation(pagoModel).validate(msgFinal)
        If valid = True Then
            If valido = True Then
                pagoModel.Importe = resultado
                pagoModel.SaveChanges()
                state = True
                Me.Close()
            Else
                MsgBox(msgImporte)
            End If
        Else
            If Not valido Then MsgBox(msgFinal + vbNewLine + msgImporte) Else MsgBox(msgFinal)
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        state = False
        Me.Close()
    End Sub

#End Region
End Class