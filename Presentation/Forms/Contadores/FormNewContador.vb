Imports Domain
Public Class FormNewContador
    Public state As Boolean
    Dim contadorModel As New ContadorModel()
    Private Sub FormNewContador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarAlquileres()
    End Sub
    Private Sub ListarAlquileres()
        Dim alquilerModel As New AlquilerModel()
        CmbAlquiler.DataSource = alquilerModel.GetAllForContador
        CmbAlquiler.DisplayMember = "Datos"
        CmbAlquiler.ValueMember = "NroAlquiler"
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        state = False
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If contadorModel.LastContador(CmbAlquiler.SelectedValue) < Convert.ToInt32(txtCantidad.Text) Then
            contadorModel.nroAlquiler = CmbAlquiler.SelectedValue
            contadorModel.Fecha = Date.Today
            contadorModel.CantCopias = Convert.ToInt32(txtCantidad.Text)
            contadorModel.State = EntityState.Added
            contadorModel.SaveChanges()
            state = True
        Else
            Dim formulario As FormError
            formulario = New FormError With {
                .mensaje = "       El nuevo contador debe superar al anterior"
            }
            formulario.ShowDialog()
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Not IsNumeric(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.KeyChar = ""
        End If
    End Sub
End Class