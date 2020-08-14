Imports Domain
Public Class FormNewFactura
    Public state As Boolean
    Dim facturaModel As New FacturaModel()
#Region "ACCIONES DEL FORMULARIO GENERAL"
    Private Sub FormNewFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarClientes()
        ComboBox1.SelectedIndex = 0
    End Sub
    Private Sub ListarClientes()
        Dim clienteModel As New ClienteModel()
        CmbCliente.DataSource = clienteModel.GetClientesForCmb
        CmbCliente.DisplayMember = "DataView"
        CmbCliente.ValueMember = "ID_Cliente"
    End Sub

#End Region
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim resultado As Decimal
        Dim resultado1 As Integer
        Dim msgPrecio As String = "Precio por copia"
        Dim msgCant As String = "Cantidad"
        Dim msgFinal As String = ""

        facturaModel.FK_Cliente = CmbCliente.SelectedValue
        facturaModel.Letra = ComboBox1.Text
        facturaModel.Fecha = BunifuDatePicker1.Value.Date
        facturaModel.State = EntityState.Added

        Dim valido = New ValidacionesExtras(txtPrecioUnitario.Text).ToDecimal(msgPrecio, resultado)
        Dim valido1 = New ValidacionesExtras(txtCantidad.Text).ToInteger(msgCant, resultado1)
        facturaModel.Total = resultado * resultado1

        If valido And valido1 Then
            facturaModel.PrecioUnitario = resultado
            facturaModel.Cantidad = resultado1
            Dim result = facturaModel.SaveChanges()
            MsgBox(result)
            Me.Close()
        Else
            If Not valido Then msgFinal += msgPrecio + vbNewLine
            If Not valido1 Then msgFinal += msgCant
            MsgBox(msgFinal)
        End If
    End Sub


    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Not IsNumeric(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        Dim resultado As Integer
        Dim resultado1 As Decimal
        If Integer.TryParse(txtCantidad.Text, resultado) And Decimal.TryParse(txtPrecioUnitario.Text, resultado1) Then
            txtTotal.Text = (resultado * resultado1).ToString()
        Else
            txtTotal.Text = "0"
        End If
    End Sub

    Private Sub txtPrecioUnitario_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioUnitario.TextChanged
        Dim resultado As Integer
        Dim resultado1 As Decimal
        If Integer.TryParse(txtCantidad.Text, resultado) And Decimal.TryParse(txtPrecioUnitario.Text, resultado1) Then
            txtTotal.Text = (resultado * resultado1).ToString()
        Else
            txtTotal.Text = "0"
        End If
    End Sub
End Class