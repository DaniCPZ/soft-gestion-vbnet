Imports Domain
Public Class FormListadoCobranzas
    Dim clienteModel As New ClienteModel()
    Dim ListCobranza As New List(Of ListadoCobranzas)
    Private Sub FormListadoCobranzas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarClientes()
    End Sub
    Private Sub ListarClientes()
        Try
            DataGridView1.DataSource = clienteModel.GetClientes()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If Not e.RowIndex = -1 Then
            Dim nroCliente As String
            Dim nombre As String
            Dim direccion As String
            Dim telefono As String
            Dim saldo As String
            nroCliente = DataGridView1.CurrentRow.Cells(0).Value.ToString()
            nombre = DataGridView1.CurrentRow.Cells(1).Value.ToString()
            direccion = DataGridView1.CurrentRow.Cells(6).Value.ToString() + " - " + DataGridView1.CurrentRow.Cells(7).Value.ToString()
            telefono = DataGridView1.CurrentRow.Cells(5).Value.ToString()
            saldo = DataGridView1.CurrentRow.Cells(8).Value.ToString()

            Dim formulario As FormClienteCobranza
            formulario = New FormClienteCobranza
            formulario.txtNombre.Text = nombre
            formulario.txtSaldo.Text = saldo
            formulario.ShowDialog()
            If formulario.state Then
                If Not ListCobranza.Any(Function(emp) emp.nroCliente = nroCliente) Then
                    ListCobranza.Add(New ListadoCobranzas With {
                        .nroCliente = nroCliente,
                        .Nombre = nombre,
                        .Direccion = direccion,
                        .Telefono = telefono,
                        .Saldo = saldo,
                        .Observaciones = formulario.TxtObservacion.Text
                    })
                End If
            End If
        End If
        DataGridView2.DataSource = Nothing
        DataGridView2.DataSource = ListCobranza
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If DataGridView2.Rows.Count > 0 Then
            Dim cE As New ExportarOffice
            cE.ExportarWord(DataGridView2, "Listado de cobranzas")
        End If

    End Sub
End Class