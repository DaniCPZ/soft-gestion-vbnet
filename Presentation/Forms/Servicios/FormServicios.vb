Imports Domain
Imports Transitions

Public Class FormServicios
    Dim servicioModel As New ServicioModel()
    Dim detalleModel As New DetalleServicioModel()

#Region "ACCIONES DEL FORMULARIO GENERAL - ListarClientes"
    Private Sub FormServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarServicios()
        ListarDetalles()
    End Sub
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
    Private Sub ListarServicios()
        Try
            DataGridView1.DataSource = servicioModel.GetServicios()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ListarDetalles()
        Try
            DataGridView2.DataSource = detalleModel.GetDetalles()
        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "BOTONES BARRA SUPERIOR - Navegacion entre ventanas"
    Private Sub BtnServicios_Click(sender As Object, e As EventArgs) Handles BtnServicios.Click
        BunifuPages1.SetPage("TabPage1")
        ColorBtnDefault()
        ChangeColor(1)
    End Sub
    Private Sub btnDetalle_Click(sender As Object, e As EventArgs) Handles btnDetalle.Click
        BunifuPages1.SetPage("TabPage2")
        ColorBtnDefault()
        ChangeColor(2)
    End Sub
    Private Sub ColorBtnDefault()
        BtnServicios.BackColor = Color.FromArgb(0, 136, 255)
        BtnServicios.ForeColor = Color.White
        btnDetalle.BackColor = Color.FromArgb(0, 136, 255)
        btnDetalle.ForeColor = Color.White
    End Sub
    Private Sub ChangeColor(pos As Integer)
        Select Case pos
            Case 1
                BtnServicios.BackColor = Color.White
                BtnServicios.ForeColor = Color.FromArgb(50, 59, 70)
            Case 2
                btnDetalle.BackColor = Color.White
                btnDetalle.ForeColor = Color.FromArgb(50, 59, 70)
            Case 3
                MsgBox("3")
        End Select
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
    Private Sub Centrar2()
        Dim w As Integer
        w = DataGridView2.Columns.GetColumnsWidth(DataGridViewElementStates.None)
        If Not ((w - 5) > DataGridView2.Parent.Size.Width) Then
            DataGridView2.Width = w
            DataGridView2.Left = (DataGridView2.Parent.Size.Width - DataGridView2.Width) / 2
        End If
    End Sub
    Private Sub DataGridView2_Resize(sender As Object, e As EventArgs) Handles DataGridView2.Resize
        If (DataGridView2.Columns.GetColumnsWidth(DataGridViewElementStates.None) > 0) Then
            Centrar2()
        End If
    End Sub
#End Region

#Region "VENTANA DE SERVICIOS"

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim formulario As FormNewServicio
        formulario = New FormNewServicio
        formulario.ShowDialog()
        If formulario.state Then
            Dim formSuccess As FormSuccess
            formSuccess = New FormSuccess With {
                    .mensaje = "       Servicio registrado con exito"
                }
            formSuccess.ShowDialog()
            ListarServicios()
            ListarDetalles()
        End If
    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim formulario As FormEditServicio
            formulario = New FormEditServicio()
            formulario.idServicio = DataGridView1.CurrentRow.Cells(0).Value.ToString()
            formulario.TxtObservacion.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
            formulario.ShowDialog()
            If formulario.state Then
                Dim formSuccess As FormSuccess
                formSuccess = New FormSuccess With {
                        .mensaje = "            Servicio editado con exito"
                    }
                formSuccess.ShowDialog()
                ListarServicios()
            End If
        Else
            MsgBox("Seleccione un registro")
        End If

    End Sub
    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Try
            DataGridView1.DataSource = servicioModel.Find(TxtBuscar.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim i As Integer
        Dim f As String
        f = DataGridView1.CurrentRow.Cells(3).Value.ToString
        Try
            If Not e.RowIndex = -1 Then
                i = DataGridView1.CurrentRow.Cells(0).Value
                Dim formDetalles As FormDetalles
                formDetalles = New FormDetalles With {
                        .nroServicio = i,
                        .cliente = DataGridView1.CurrentRow.Cells(1).Value.ToString,
                        .serial = DataGridView1.CurrentRow.Cells(2).Value.ToString,
                        .fecha = Format(CDate(f), "ddd d 'del' M/yyyy"),
                        .observaciones = DataGridView1.CurrentRow.Cells(4).Value.ToString
                    }
                formDetalles.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
    Private Sub btnCambiarLetra_Click(sender As Object, e As EventArgs) Handles btnCambiarLetra.Click
        Dim font As Font
        If RbLarge.Checked Then
            font = New Font("Segoe UI Semibold", 15, FontStyle.Bold)
        ElseIf RbMedium.Checked Then
            font = New Font("Segoe UI Semibold", 12, FontStyle.Bold)
        Else
            font = New Font("Segoe UI Semibold", 9, FontStyle.Bold)
        End If
        DataGridView1.RowsDefaultCellStyle.Font = font
        DataGridView2.RowsDefaultCellStyle.Font = font
        MenuDesplegable.Visible = False
        BtnSubMenu.BackColor = Color.Transparent
    End Sub
    Private Sub btnCancelarLetra_Click(sender As Object, e As EventArgs) Handles btnCancelarLetra.Click
        MenuDesplegable.Visible = False
        BtnSubMenu.BackColor = Color.Transparent
    End Sub
    Private Sub ListarServiciosPorFecha()
        Try
            DataGridView1.DataSource = servicioModel.getServiciosByFecha(dpFechaInicio.Value.Date, dpFechaFinal.Value.Date)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnFilter1_Click(sender As Object, e As EventArgs) Handles btnFilter1.Click
        Dim t As New Transition(New TransitionType_EaseInEaseOut(1000))
        If panelFilter.Width <= 40 Then
            t.add(Me.panelFilter, "Width", 220)
            t.add(Me.panelFilter, "Height", 230)
            t.add(Me.btnFilter1, "Left", 86)
            panelFilter.BackColor = Color.FromArgb(240, 240, 240)
        ElseIf panelFilter.Width >= 220 Then
            t.add(Me.panelFilter, "Width", 40)
            t.add(Me.panelFilter, "Height", 40)
            t.add(Me.btnFilter1, "Left", 5)
        End If
        t.run()
        panelFilter.BackColor = Color.FromArgb(240, 240, 240)
    End Sub
    Private Sub btnAplicarFiltro_Click(sender As Object, e As EventArgs) Handles btnAplicarFiltro.Click
        If cbFecha.Checked Then
            ListarServiciosPorFecha()
        Else
            ListarServicios()
        End If
    End Sub

    Private Sub cbFecha_CheckedChanged(sender As Object, e As EventArgs) Handles cbFecha.CheckedChanged
        If cbFecha.Checked Then
            dpFechaFinal.Enabled = True
            dpFechaInicio.Enabled = True
        Else
            dpFechaFinal.Enabled = False
            dpFechaInicio.Enabled = False
        End If
    End Sub

#End Region

#Region "VENTANA DE DETALLE - SERVICIO"
    Private Sub txtbuscar2_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar2.TextChanged
        DataGridView2.DataSource = detalleModel.FindByService(txtbuscar2.Text)

    End Sub



#End Region


End Class