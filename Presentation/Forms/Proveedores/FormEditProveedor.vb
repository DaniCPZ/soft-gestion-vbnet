Imports Domain
Public Class FormEditProveedor
    Public id_proveedor As String
    Public state As Boolean
    Dim proveedorModel As New ProveedorModel()
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        state = False
        Me.Close()

    End Sub

    Private Sub FormEditProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbCuit.SelectedIndex = 0
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        proveedorModel.Nombre = TxtNombre.Text.Trim.ToUpper

        Dim msgCuit As String
        Dim valido As Boolean
        If TxtCuit.Text = "" Or Not TxtCuit.Text.Count = 9 Then
            msgCuit = "El campo CUIT es requerido"
            valido = False
        Else
            msgCuit = ""
            valido = True
            proveedorModel.Cuit = Convert.ToInt64((cmbCuit.Text + TxtCuit.Text))
        End If
        Dim msgFinal As String = ""
        proveedorModel.Email = TxtEmail.Text.Trim.ToUpper
        proveedorModel.Telefono = TxtTelefono.Text.Trim
        proveedorModel.FechaAlta = DateTime.Today
        proveedorModel.ID_Proveedor = id_proveedor
        proveedorModel.State = EntityState.Modified
        Dim valid = New DataValidation(proveedorModel).validate(msgFinal)

        If valid And valido Then
            Dim result = proveedorModel.SaveChanges()
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