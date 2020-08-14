Imports Domain
Public Class FormNewCliente
    Dim clienteModel As New ClienteModel()
    Public state As Boolean
    Private Sub FormNewCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarLocalidades()
        cmbCuit.SelectedIndex = 0
    End Sub
    Private Sub ListarLocalidades()
        Dim localidadModel As New LocalidadModel()
        CmbLocalidad.DataSource = localidadModel.GetLocalidadesOrderByNombre
        CmbLocalidad.DisplayMember = "Nombre"
        CmbLocalidad.ValueMember = "codigoPostal"
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        state = False
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        Dim valido As Boolean
        Dim msgCuit As String
        Dim msgSaldo As String = "Saldo"
        Dim resultado As Decimal
        Dim msgFinal As String = ""

        If TxtCuit.Text = "" Or Not TxtCuit.Text.Count = 9 Then
            msgCuit = "El campo CUIT es requerido"
            valido = False
        Else
            msgCuit = ""
            valido = True
            clienteModel.Cuit = Convert.ToInt64((cmbCuit.Text + TxtCuit.Text))
        End If


        clienteModel.Nombre = TxtNombre.Text
        clienteModel.Cond_IVA = TxtIva.Text
        clienteModel.Email = TxtEmail.Text
        clienteModel.Telefono = TxtTelefono.Text
        clienteModel.FK_CodPostal = Convert.ToInt32(CmbLocalidad.SelectedValue)
        clienteModel.Saldo = resultado
        clienteModel.Direccion = TxtDireccion.Text
        clienteModel.FechaAlta = DateTime.Today
        clienteModel.State = EntityState.Added

        Dim valid = New DataValidation(clienteModel).validate(msgFinal)
        Dim valido1 = New ValidacionesExtras(txtSaldo.Text).ToDecimal(msgSaldo, resultado)

        If valid And valido And valido1 Then
            Dim result = clienteModel.SaveChanges()
            state = True
            Me.Close()
        Else
            If Not valido Then msgFinal += vbNewLine + msgCuit
            If Not valido1 Then msgFinal += vbNewLine + msgSaldo
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