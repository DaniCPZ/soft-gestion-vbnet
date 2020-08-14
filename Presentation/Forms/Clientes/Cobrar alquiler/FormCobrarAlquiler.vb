Imports Domain
Public Class FormCobrarAlquiler
    Dim alquilerModel As New AlquilerModel()
    Dim ListContadores As New List(Of ContadorCliente)
    Dim facturaModel As New FacturaModel()
    Dim pagoModel As New PagoModel()
    Dim IngresarPago As Boolean
    Dim cantidadDeCopias As Integer
    Public cliente As Integer

#Region "ACCIONES DEL FORMULARIO EN GENERAL "
    Private Sub FormCobrarAlquiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        redondearCheckBox()
        ListarAlquileres()
        ComboBox1.SelectedIndex = 0
        CmbTipoPago.SelectedIndex = 0
    End Sub
    Private Sub ListarAlquileres()
        Try
            DataGridView1.DataSource = alquilerModel.GetAlquileresForDgvByCliente(cliente)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

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

        BunifuCheckBox4.OnCheck.BorderRadius = 17
        BunifuCheckBox4.OnDisable.BorderRadius = 17
        BunifuCheckBox4.OnHoverChecked.BorderRadius = 17
        BunifuCheckBox4.OnHoverUnchecked.BorderRadius = 17
        BunifuCheckBox4.OnUncheck.BorderRadius = 17
    End Sub
#End Region

#Region "VENTANA CONTADORES"
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            Dim indice As Integer
            Dim nroAlq As Integer
            Dim min As Boolean
            Dim minAlquiler As Integer
            Dim contador As Integer
            Dim copiasRealizadas As Integer
            Dim copiasRealizadasAnt As Integer
            Dim contadorAnterior As Boolean

            If Not e.RowIndex = -1 Then
                nroAlq = Convert.ToInt32(DataGridView1.CurrentRow.Cells(0).Value.ToString())
                'equipo = DataGridView1.CurrentRow.Cells(1).Value.ToString()

                Dim formulario As FormNuevoContador
                formulario = New FormNuevoContador
                formulario.nroAlquiler = nroAlq
                formulario.ShowDialog()
                If formulario.state Then
                    min = formulario.cbCobrarMinimo.Checked
                    minAlquiler = Convert.ToInt32(formulario.lblMinAlquiler.Text)
                    contador = Convert.ToInt32(formulario.TextBox1.Text)
                    copiasRealizadas = Convert.ToInt32(formulario.lblCopiasRealizadas.Text)
                    If Not ListContadores.Any(Function(emp) emp.nroAlquiler = nroAlq) Then
                        ListContadores.Add(New ContadorCliente With {
                             .nroAlquiler = nroAlq,
                             .cantCopias = contador,
                             .CobrarMinimo = formulario.cbCobrarMinimo.Checked
                            })
                        If min Then
                            cantidadDeCopias += minAlquiler
                        Else
                            cantidadDeCopias += copiasRealizadas
                        End If
                    Else
                        indice = ListContadores.IndexOf(ListContadores.Find(Function(emp) emp.nroAlquiler = nroAlq))
                        contadorAnterior = ListContadores.ElementAt(indice).CobrarMinimo
                        copiasRealizadasAnt = ListContadores.ElementAt(indice).cantCopias - Convert.ToInt32(formulario.Label2.Text)

                        ListContadores.RemoveAt(indice)
                        ListContadores.Insert(indice, New ContadorCliente With {
                            .nroAlquiler = nroAlq,
                            .cantCopias = contador,
                            .CobrarMinimo = formulario.cbCobrarMinimo.Checked
                        })
                        MsgBox(cantidadDeCopias)
                        If Not min Then
                            If contadorAnterior Then
                                cantidadDeCopias += copiasRealizadas - minAlquiler
                            Else
                                cantidadDeCopias += copiasRealizadas - copiasRealizadasAnt
                            End If
                        Else
                            If Not contadorAnterior Then
                                cantidadDeCopias += minAlquiler - copiasRealizadasAnt
                            End If
                        End If
                        MsgBox(cantidadDeCopias)
                    End If

                End If
            End If
            DataGridView2.DataSource = Nothing
            DataGridView2.DataSource = ListContadores
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnSiguiente1_Click(sender As Object, e As EventArgs) Handles btnSiguiente1.Click
        If DataGridView2.Rows.Count > 0 Then
            BunifuPage1.SetPage("Factura")
            txtCantidad.Text = cantidadDeCopias.ToString
            Label1.ForeColor = Color.FromArgb(28, 158, 117)
            BunifuCheckBox1.Enabled = True
            BunifuCheckBox1.Checked = True
        End If
    End Sub
#End Region

#Region "VENTANA FACTURAS"
    Private Sub btnSiguiente2_Click(sender As Object, e As EventArgs) Handles btnSiguiente2.Click
        Dim resultado As Decimal
        Dim msgPrecio As String = "Precio por copia"
        Dim valido = New ValidacionesExtras(txtPrecioUnitario.Text).ToDecimal(msgPrecio, resultado)
        If valido Then
            facturaModel.FK_Cliente = cliente
            facturaModel.Letra = ComboBox1.Text
            facturaModel.Fecha = BunifuDatePicker1.Value.Date
            facturaModel.Cantidad = Convert.ToInt32(txtCantidad.Text)
            facturaModel.Total = resultado * Convert.ToInt32(txtCantidad.Text)
            facturaModel.State = EntityState.Added
            facturaModel.PrecioUnitario = resultado
            Label2.ForeColor = Color.FromArgb(28, 158, 117)
            BunifuCheckBox2.Enabled = True
            BunifuCheckBox2.Checked = True
            BunifuPage1.SetPage("Pago")
        Else
            MsgBox(msgPrecio)
        End If

    End Sub

    Private Sub txtPrecioUnitario_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioUnitario.TextChanged
        Dim resultado As Integer
        Dim resultado1 As Decimal
        If Integer.TryParse(txtCantidad.Text, resultado) And Decimal.TryParse(txtPrecioUnitario.Text, resultado1) Then
            txtTotal.Text = (resultado * resultado1).ToString()
        Else
            txtTotal.Text = "0"
        End If
    End Sub
    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        BunifuPage1.SetPage("Contadores")
    End Sub

#End Region

#Region "VENTANA PAGOS"
    Private Sub BtnSiguiente3_Click(sender As Object, e As EventArgs) Handles BtnSiguiente3.Click
        Dim resultado As Decimal
        Dim msgPrecio As String = "Importe"
        Dim valido = New ValidacionesExtras(txtImporte.Text).ToDecimal(msgPrecio, resultado)
        If valido Then
            If resultado > 0 Then
                IngresarPago = True
                pagoModel.FK_Cliente = cliente
                pagoModel.tipoPago = CmbTipoPago.SelectedItem
                pagoModel.Fecha = BunifuDatePicker1.Value.Date
                pagoModel.Importe = resultado
                pagoModel.State = EntityState.Added
            Else
                IngresarPago = False
            End If
            Label3.ForeColor = Color.FromArgb(28, 158, 117)
            BunifuCheckBox3.Enabled = True
            BunifuCheckBox3.Checked = True
            BunifuPage1.SetPage("Final")
        Else
            MsgBox(msgPrecio)
        End If
    End Sub
#End Region

#Region "VENTANA CERRAR FINALIZACION"
    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        Try
            Dim contadorModel As ContadorModel
            For Each item As ContadorCliente In ListContadores
                contadorModel = New ContadorModel With {
                    .nroAlquiler = item.nroAlquiler,
                    .CantCopias = item.cantCopias,
                    .Fecha = DateTime.Today,
                    .State = EntityState.Added
                }
                contadorModel.SaveChanges()
            Next
            facturaModel.SaveChanges()
            If IngresarPago Then
                pagoModel.SaveChanges()
            End If
            Label4.ForeColor = Color.FromArgb(28, 158, 117)
            BunifuCheckBox4.Enabled = True
            BunifuCheckBox4.Checked = True

            Dim formulario As FormSuccess
            formulario = New FormSuccess With {
                    .mensaje = "       Alquiler cobrado con exito"
                }
            formulario.ShowDialog()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnAnterior2_Click(sender As Object, e As EventArgs) Handles BtnAnterior2.Click
        BunifuPage1.SetPage("Factura")
    End Sub
#End Region



End Class