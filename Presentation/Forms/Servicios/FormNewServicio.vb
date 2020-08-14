Imports Domain
Public Class FormNewServicio
    Dim ListDatallesServicios As New List(Of DetalleServicioModel)
    Public state As Boolean

#Region "ACCIONES DEL FORMULARIO EN GENERAL "
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        state = False
        Me.Close()
    End Sub

    Private Sub FormNewServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        redondearCheckBox()
        cargarAlquileres()
    End Sub

    ' Redondear los cheackbox
    Private Sub redondearCheckBox()
        BunifuCheckBox1.OnCheck.BorderRadius = 17
        BunifuCheckBox1.OnDisable.BorderRadius = 17
        BunifuCheckBox1.OnHoverChecked.BorderRadius = 17
        BunifuCheckBox1.OnHoverUnchecked.BorderRadius = 17
        BunifuCheckBox1.OnUncheck.BorderRadius = 17

        BunifuCheckBox2.OnCheck.BorderRadius = 17
        BunifuCheckBox2.OnDisable.BorderRadius = 17
        BunifuCheckBox2.OnHoverChecked.BorderRadius = 17
        BunifuCheckBox2.OnHoverUnchecked.BorderRadius = 17
        BunifuCheckBox2.OnUncheck.BorderRadius = 17

        BunifuCheckBox3.OnCheck.BorderRadius = 17
        BunifuCheckBox3.OnDisable.BorderRadius = 17
        BunifuCheckBox3.OnHoverChecked.BorderRadius = 17
        BunifuCheckBox3.OnHoverUnchecked.BorderRadius = 17
        BunifuCheckBox3.OnUncheck.BorderRadius = 17
    End Sub
    Private Sub cargarAlquileres()
        Dim alquilerModel As New AlquilerModel()
        CmbAlquiler.DataSource = alquilerModel.GetAllForContador
        CmbAlquiler.DisplayMember = "Datos"
        CmbAlquiler.ValueMember = "NroAlquiler"
    End Sub
#End Region
    Private Sub btnSiguiente1_Click_1(sender As Object, e As EventArgs) Handles btnSiguiente1.Click
        Dim msgFinal As String
        If TxtObservacion.Text <> "" And IsNumeric(CmbAlquiler.SelectedValue) Then
            BunifuPage1.SetPage("DetalleServicio")
            Label1.ForeColor = Color.FromArgb(28, 158, 117)
            BunifuCheckBox1.Enabled = True
            BunifuCheckBox1.Checked = True
            Dim repuestoModel As New RepuestoModel()
            DataGridView1.DataSource = repuestoModel.GetRepuestos
        Else
            msgFinal = "Ambos campos son requeridos"
            MsgBox(msgFinal)
        End If
    End Sub

    Private Sub btnAnterior_Click_1(sender As Object, e As EventArgs) Handles btnAnterior.Click
        BunifuPage1.SetPage("NuevoServicio")
    End Sub

    Private Sub btnSiguiente2_Click_1(sender As Object, e As EventArgs) Handles btnSiguiente2.Click
        If DataGridView2.Rows.Count > 0 Then
            BunifuPage1.SetPage("Final")
            Label2.ForeColor = Color.FromArgb(28, 158, 117)
            BunifuCheckBox2.Enabled = True
            BunifuCheckBox2.Checked = True
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim indice As Integer
        Dim repuesto As String

        If Not e.RowIndex = -1 Then
            repuesto = DataGridView1.CurrentRow.Cells(0).Value.ToString()
            Dim formulario As FormCantRep
            formulario = New FormCantRep With {
                    .limit = DataGridView1.CurrentRow.Cells(1).Value
                }
            formulario.lblRepuesto.Text = repuesto
            formulario.ShowDialog()
            If formulario.state Then
                If Not ListDatallesServicios.Any(Function(emp) emp.Repuesto = repuesto) Then
                    ListDatallesServicios.Add(New DetalleServicioModel With {
                        .Servicio = 0,
                        .Repuesto = DataGridView1.CurrentRow.Cells(0).Value.ToString(),
                        .CostoUnitario = Convert.ToDecimal(DataGridView1.CurrentRow.Cells(2).Value.ToString),
                        .Cantidad = Convert.ToInt32(formulario.txtCantidad.Text)
                    })
                Else
                    indice = ListDatallesServicios.IndexOf(ListDatallesServicios.Find(Function(emp) emp.Repuesto = repuesto))
                    ListDatallesServicios.RemoveAt(indice)
                    ListDatallesServicios.Insert(indice, New DetalleServicioModel With {
                            .Servicio = 0,
                            .Repuesto = DataGridView1.CurrentRow.Cells(0).Value.ToString(),
                            .CostoUnitario = Convert.ToDecimal(DataGridView1.CurrentRow.Cells(2).Value.ToString),
                            .Cantidad = Convert.ToInt32(formulario.txtCantidad.Text)
                        })
                End If
            End If
        End If
        DataGridView2.DataSource = Nothing
        DataGridView2.DataSource = ListDatallesServicios
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        Dim servicioModel As New ServicioModel()
        servicioModel.FK_Alquiler = CmbAlquiler.SelectedValue
        servicioModel.Observacion = TxtObservacion.Text
        servicioModel.Fecha = DateTime.Today
        servicioModel.State = EntityState.Added
        servicioModel.SaveChanges()
        For Each item As DetalleServicioModel In ListDatallesServicios
            item.Servicio = servicioModel.GetLastServicio
            item.State = EntityState.Added
            item.SaveChanges()
            state = True
            Me.Close()
        Next
    End Sub


End Class