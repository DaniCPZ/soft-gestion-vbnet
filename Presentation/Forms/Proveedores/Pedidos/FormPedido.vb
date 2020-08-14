Imports Domain
Imports Microsoft
Public Class FormPedido
    Public idProv As Integer
    Dim listadoPedido As New List(Of Pedido)
    Dim repuestoModel As New RepuestoModel
    Private Sub FormPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarRepuestos()
    End Sub
    Private Sub ListarRepuestos()
        Try
            DataGridView1.DataSource = repuestoModel.GetRepuestosByProv(idProv)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim indice As Integer
        Dim nroRepuesto As String
        Try
            If Not e.RowIndex = -1 Then
                nroRepuesto = DataGridView1.CurrentRow.Cells(0).Value.ToString()

                Dim formulario As FormCantRepuestos
                formulario = New FormCantRepuestos
                formulario.lblRepuesto.Text = nroRepuesto
                formulario.ShowDialog()
                If formulario.state Then
                    If Not listadoPedido.Any(Function(emp) emp.NroRepuesto = nroRepuesto) Then
                        listadoPedido.Add(New Pedido With {
                        .NroRepuesto = nroRepuesto,
                        .Cantidad = Convert.ToInt32(formulario.txtCantidad.Text),
                        .Descripcion = DataGridView1.CurrentRow.Cells(5).Value.ToString()
                        })
                    Else
                        indice = listadoPedido.IndexOf(listadoPedido.Find(Function(emp) emp.NroRepuesto = nroRepuesto))
                        listadoPedido.RemoveAt(indice)
                        listadoPedido.Insert(indice, New Pedido With {
                        .NroRepuesto = nroRepuesto,
                        .Cantidad = Convert.ToInt32(formulario.txtCantidad.Text),
                        .Descripcion = DataGridView1.CurrentRow.Cells(5).Value.ToString()
                        })
                    End If
                End If
            End If
            DataGridView2.DataSource = Nothing
            DataGridView2.DataSource = listadoPedido
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If listadoPedido.Any() Then
            Dim formulario As FormOpcionesFormato
            formulario = New FormOpcionesFormato With {
               .dgv = DataGridView2
            }
            formulario.ShowDialog()
            If formulario.state Then
                Dim formularioMsg As FormSuccess
                formularioMsg = New FormSuccess With {
                    .mensaje = "       Pedido exportado con exito"
                }
                formularioMsg.ShowDialog()
                Me.Close()
            End If
        End If

    End Sub

End Class