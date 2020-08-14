Imports Domain
Public Class FormEditCliente
    Public id_cliente As String
    Public state As Boolean
    Dim clienteModel As New ClienteModel()

    Private Sub FormEditCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarLocalidades()
        cmbCuit.SelectedIndex = 0
    End Sub
    Private Sub ListarLocalidades()
        Dim localidadModel As New LocalidadModel()
        CmbLocalidad.DataSource = localidadModel.GetLocalidadesOrderByNombre
        CmbLocalidad.DisplayMember = "Nombre"
        CmbLocalidad.ValueMember = "codigoPostal"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        state = False
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        Dim msgCuit As String
        Dim valido As Boolean
        Dim msgFinal As String = ""
        If TxtCuit.Text = "" Or Not TxtCuit.Text.Count = 9 Then
            msgCuit = "El campo CUIT es requerido"
            valido = False
        Else
            msgCuit = ""
            valido = True
            clienteModel.Cuit = Convert.ToInt64((cmbCuit.Text + TxtCuit.Text))
        End If

        clienteModel.ID_Cliente = Convert.ToInt32(id_cliente)
        clienteModel.Nombre = TxtNombre.Text
        clienteModel.Cond_IVA = TxtIva.Text
        clienteModel.Email = TxtEmail.Text
        clienteModel.Telefono = TxtTelefono.Text
        clienteModel.FK_CodPostal = Convert.ToInt32(CmbLocalidad.SelectedValue)
        clienteModel.Direccion = TxtDireccion.Text
        clienteModel.Saldo = Convert.ToDecimal(txtSaldo.Text)
        clienteModel.State = EntityState.Modified

        Dim valid = New DataValidation(clienteModel).validate(msgFinal)
        If valid And valido Then
            Dim result = clienteModel.SaveChanges()
            state = True
            Me.Close()
        Else
            If Not valido Then msgFinal += vbNewLine + msgCuit
            Dim formularioMsg As FormError
            formularioMsg = New FormError With {
                .mensaje = msgFinal
            }
            formularioMsg.ShowDialog()
        End If
    End Sub

    Private Sub TxtCuit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCuit.KeyPress
        If Not IsNumeric(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.KeyChar = ""
        End If
    End Sub
End Class