Imports Domain
Public Class FormProveedores
    Dim proveedorModel As New ProveedorModel()
#Region "ACCIONES DEL FORMULARIO GENERAL - ListarClientes"
    Private Sub FormProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarProveedores()
    End Sub
    Private Sub ListarProveedores()
        Try
            DataGridView1.DataSource = ProveedorModel.GetProveedores()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

#End Region

#Region "CENTRAR DATAGRIDVIEW"
    Private Sub Centrar()
        Dim w As Integer
        w = DataGridView1.Columns.GetColumnsWidth(DataGridViewElementStates.None)
        If Not ((w - 5) > DataGridView1.Parent.Size.Width) Then
            DataGridView1.Width = w
            DataGridView1.Left = (DataGridView1.Parent.Size.Width - DataGridView1.Width) / 2
        End If
    End Sub
    Private Sub DataGridView1_Resize(sender As Object, e As EventArgs) Handles DataGridView1.Resize
        If (DataGridView1.Columns.GetColumnsWidth(DataGridViewElementStates.None) > 0) Then
            Centrar()
        End If
    End Sub

#End Region

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim formulario As FormNewProveedor
        formulario = New FormNewProveedor
        formulario.ShowDialog()
        If formulario.state Then
            ListarProveedores()
            Dim formSuccess As FormSuccess
            formSuccess = New FormSuccess With {
                    .mensaje = "       Proveedor ingresado con exito"
                }
            formSuccess.ShowDialog()

        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If DataGridView1.SelectedRows.Count > 0 Then

            Dim cuit As String
            Dim formulario As FormEditProveedor
            formulario = New FormEditProveedor()
            formulario.id_proveedor = DataGridView1.CurrentRow.Cells(0).Value.ToString()
            formulario.TxtNombre.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
            cuit = DataGridView1.CurrentRow.Cells(2).Value.ToString()
            formulario.cmbCuit.Text = Microsoft.VisualBasic.Left(cuit, 2)
            formulario.TxtCuit.Text = Microsoft.VisualBasic.Right(cuit, 9)
            formulario.TxtEmail.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
            formulario.TxtTelefono.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
            formulario.ShowDialog()
            If formulario.state Then
                ListarProveedores()
                Dim formSuccess As FormSuccess
                formSuccess = New FormSuccess With {
                        .mensaje = "       Proveedor editado con exito"
                    }
                formSuccess.ShowDialog()
            End If
        Else
            MsgBox("Seleccione un registro")
        End If
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim formulario As FormWarning
            formulario = New FormWarning
            formulario.mensaje = " ¿ Seguro desea eliminar este registro ?"
            formulario.ShowDialog()
            If formulario.State Then
                proveedorModel.ID_Proveedor = DataGridView1.CurrentRow.Cells(0).Value
                proveedorModel.State = EntityState.Deleted
                Dim result = proveedorModel.SaveChanges()
                If result = "Remove" Then
                    Dim formSuccess As FormSuccess
                    formSuccess = New FormSuccess With {
                        .mensaje = "     Proveedor eliminado con exito"
                    }
                    formSuccess.ShowDialog()
                    ListarProveedores()
                Else
                    Dim formError As FormError
                    formError = New FormError With {
                        .mensaje = result
                    }
                    formError.ShowDialog()
                End If

            End If

        Else
                MsgBox("Seleccione un registro")
        End If
    End Sub

    Private Sub btnPedido_Click(sender As Object, e As EventArgs) Handles btnPedido.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim formulario As FormPedido
            formulario = New FormPedido
            formulario.idProv = DataGridView1.CurrentRow.Cells(0).Value
            formulario.ShowDialog()
        End If

    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Dim resultado As Long
        If Long.TryParse(TxtBuscar.Text, resultado) Then
            DataGridView1.DataSource = proveedorModel.FindbyCuit(TxtBuscar.Text)
        Else
            DataGridView1.DataSource = proveedorModel.FindbyNombre(TxtBuscar.Text)
        End If
    End Sub

    Private Sub BtnSubMenu_Click(sender As Object, e As EventArgs) Handles BtnSubMenu.Click
        If MenuDesplegable.Visible Then
            MenuDesplegable.Visible = False
            BtnSubMenu.BackColor = Color.Transparent
        Else
            MenuDesplegable.Visible = True
            BtnSubMenu.BackColor = Color.FromArgb(240, 240, 240)
        End If
    End Sub

    Private Sub BtnAplicarCambios_Click(sender As Object, e As EventArgs) Handles BtnAplicarCambios.Click
        If RbSmall.Checked Then
            DataGridView1.RowsDefaultCellStyle.Font = New Font("Segoe UI Semibold", 9, FontStyle.Bold)
        ElseIf RbMedium.Checked Then
            DataGridView1.RowsDefaultCellStyle.Font = New Font("Segoe UI Semibold", 12, FontStyle.Bold)
        ElseIf RbLarge.Checked Then
            DataGridView1.RowsDefaultCellStyle.Font = New Font("Segoe UI Semibold", 15, FontStyle.Bold)
        End If
        MenuDesplegable.Visible = False
        BtnSubMenu.BackColor = Color.Transparent
    End Sub

    Private Sub BtnCancelarCambios_Click(sender As Object, e As EventArgs) Handles BtnCancelarCambios.Click
        MenuDesplegable.Visible = False
        BtnSubMenu.BackColor = Color.Transparent
    End Sub

End Class