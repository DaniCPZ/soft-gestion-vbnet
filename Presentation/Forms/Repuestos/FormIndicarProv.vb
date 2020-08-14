Imports Domain
Public Class FormIndicarProv
    Dim equipoModel As New EquipoModel
    Dim proveedorModel As New ProveedorModel()
    Dim ListadoProveedores As New List(Of Proveedores)

    Public repuesto As String
    Private Sub FormEquiposCompatibles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarProveedores()
    End Sub
    Private Sub ListarProveedores()
        Dim proveedores As List(Of ProveedorModel)
        proveedores = proveedorModel.GetProveedores()
        For Each item As ProveedorModel In proveedores
            ListadoProveedores.Add(New Proveedores With {
            .ID_Proveedor = item.ID_Proveedor,
            .Cuit = item.Cuit,
            .Email = item.Email,
            .Nombre = item.Nombre,
            .Telefono = item.Telefono,
            .Seleccionar = False
            })
        Next
        DataGridView2.DataSource = ListadoProveedores
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim repProvModel As RepuestoProveedorModel
        For Each item As Proveedores In ListadoProveedores
            If item.Seleccionar Then
                repProvModel = New RepuestoProveedorModel With {
                    .FK_Proveedor = item.ID_Proveedor,
                    .FK_Repuesto = repuesto,
                    .Observacion = "Sin observacion",
                    .State = EntityState.Added
                    }
                repProvModel.SaveChanges()
            End If
        Next
        Me.Close()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        If Not e.RowIndex = -1 Then
            If e.ColumnIndex = 5 Then
                If ListadoProveedores.ElementAt(e.RowIndex).Seleccionar Then
                    ListadoProveedores.ElementAt(e.RowIndex).Seleccionar = False
                Else
                    ListadoProveedores.ElementAt(e.RowIndex).Seleccionar = True
                End If
            End If

        End If
    End Sub
End Class