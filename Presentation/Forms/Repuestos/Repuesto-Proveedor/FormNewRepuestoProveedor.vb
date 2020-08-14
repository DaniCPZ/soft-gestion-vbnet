Imports Domain
Public Class FormNewRepuestoProveedor
    Dim repProvModel As New RepuestoProveedorModel
    Public state As Boolean
    Private Sub FormNewRepuestoProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarRepuestos()
    End Sub
    Private Sub ListarRepuestos()
        Dim repuestoModel As New RepuestoModel()
        cmbRepuesto.DataSource = repuestoModel.GetRepuestos()
        cmbRepuesto.DisplayMember = "DataView"
        cmbRepuesto.ValueMember = "nroRepuesto"
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim msgFinal As String = ""
        repProvModel.FK_Proveedor = CmbProveedor.SelectedValue
        repProvModel.FK_Repuesto = cmbRepuesto.SelectedValue
        repProvModel.Observacion = txtObs.Text
        repProvModel.State = EntityState.Added
        If txtObs.Text <> "" And cmbRepuesto.SelectedValue <> "" And CmbProveedor.SelectedText <> "" Then
            Dim result = repProvModel.SaveChanges()
            MsgBox(result)
            state = True
            Me.Close()
        Else
            Dim formularioMsg As FormError
            formularioMsg = New FormError With {
                .mensaje = "Todos los campos son obligatorios"
            }
            formularioMsg.ShowDialog()
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmbRepuesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRepuesto.SelectedIndexChanged
        If TypeOf cmbRepuesto.SelectedValue Is String Then
            CmbProveedor.DataSource = repProvModel.GetProveedoresByRepuestos(cmbRepuesto.SelectedValue)
            CmbProveedor.DisplayMember = "DataView"
            CmbProveedor.ValueMember = "ID_Proveedor"
        End If
    End Sub
End Class