Imports Domain
Imports Common
Imports Transitions
Public Class FormAlquileres
    Dim alquilerModel As New AlquilerModel()
#Region "ACCIONES DEL FORMULARIO GENERAL - ListarClientes"
    Private Sub FormAlquileres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarAlquileres()
    End Sub
    Private Sub ListarAlquileres()
        Try
            DataGridView1.DataSource = alquilerModel.GetAlquileres()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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


#Region "VENTANA ALQUILERES"
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim formulario As FormNewAlquiler
        formulario = New FormNewAlquiler
        formulario.ShowDialog()
        If formulario.state Then
            ListarAlquileres()
            Dim formSuccess As FormSuccess
            formSuccess = New FormSuccess With {
                    .mensaje = "            Alquiler registrado con exito"
                }
            formSuccess.ShowDialog()
        End If
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If DataGridView1.SelectedRows.Count > 0 Then

            Dim formulario As FormEditAlquiler
            formulario = New FormEditAlquiler()
            formulario.nroAlquiler = DataGridView1.CurrentRow.Cells(0).Value.ToString()
            formulario.cliente = alquilerModel.findIdCliente(DataGridView1.CurrentRow.Cells(0).Value)
            formulario.equipo = DataGridView1.CurrentRow.Cells(2).Value.ToString()
            formulario.BunifuDatePicker1.Value = DataGridView1.CurrentRow.Cells(4).Value
            formulario.TxtMinAlquiler.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
            formulario.ShowDialog()
            If formulario.state Then
                ListarAlquileres()
                Dim formSuccess As FormSuccess
                formSuccess = New FormSuccess With {
                    .mensaje = "            Alquiler editado con exito"
                }
                formSuccess.ShowDialog()
            End If
        Else
            MsgBox("Seleccione un registro")
        End If
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If DataGridView1.Columns(e.ColumnIndex).Name = "FechaFinal" Then
            If (e.Value <= DateTime.Today) Then
                e.CellStyle.BackColor = Color.FromArgb(221, 80, 68)
                e.CellStyle.ForeColor = Color.FromArgb(255, 255, 255)
            End If
        End If
    End Sub

    '-------------------------------------------
    '|           PANEL DE FILTRO               |
    '-------------------------------------------

    Private Sub btnFilter1_Click(sender As Object, e As EventArgs) Handles btnFilter1.Click
        Dim t As New Transition(New TransitionType_EaseInEaseOut(1000))
        If panelFilter.Width <= 40 Then
            t.add(Me.panelFilter, "Width", 230)
            t.add(Me.panelFilter, "Height", 335)
            t.add(Me.btnFilter1, "Left", 100)
            panelFilter.BackColor = Color.FromArgb(240, 240, 240)
        ElseIf panelFilter.Width >= 220 Then
            t.add(Me.panelFilter, "Width", 40)
            t.add(Me.panelFilter, "Height", 40)
            t.add(Me.btnFilter1, "Left", 5)
        End If
        t.run()
        panelFilter.BackColor = Color.FromArgb(240, 240, 240)
    End Sub

    Private Sub cbFecha_CheckedChanged(sender As Object, e As EventArgs) Handles cbFecha.CheckedChanged
        If cbFecha.Checked Then
            pnlFecha.Enabled = True
        Else
            pnlFecha.Enabled = False
        End If
    End Sub

    Private Sub cbEstado_CheckedChanged(sender As Object, e As EventArgs) Handles cbEstado.CheckedChanged
        If cbEstado.Checked Then
            pblEstado.Enabled = True
        Else
            pblEstado.Enabled = False
        End If
    End Sub

    Private Sub btnAplicarFiltro_Click(sender As Object, e As EventArgs) Handles btnAplicarFiltro.Click
        Try
            If cbEstado.Checked And cbFecha.Checked Then
                If rBtnInicio.Checked Then
                    If rBtnEnCurso.Checked Then
                        ' Filtro de fecha incio mas alquiler en curso
                        DataGridView1.DataSource = alquilerModel.GetAllActivosAndFi(dpFechaInicio.Value.Date, dpFechaFinal.Value.Date)
                    Else
                        ' Filtro de fecha incio mas alquiler vencido
                        DataGridView1.DataSource = alquilerModel.GetAllVencidosAndFi(dpFechaInicio.Value.Date, dpFechaFinal.Value.Date)
                    End If
                Else
                    If rBtnEnCurso.Checked Then
                        ' Filtro de fecha final mas alquiler en curso
                        DataGridView1.DataSource = alquilerModel.GetAllActivosAndFf(dpFechaInicio.Value.Date, dpFechaFinal.Value.Date)
                    Else
                        ' Filtro de fecha final mas alquiler vecido
                        DataGridView1.DataSource = alquilerModel.GetAllVencidosAndFf(dpFechaInicio.Value.Date, dpFechaFinal.Value.Date)
                    End If
                End If
            ElseIf cbEstado.Checked Then
                If rBtnEnCurso.Checked Then
                    DataGridView1.DataSource = alquilerModel.GetAlquileresActivos()
                Else
                    DataGridView1.DataSource = alquilerModel.GetAlquileresVencidos()
                End If
            ElseIf cbFecha.Checked Then
                If rBtnInicio.Checked Then
                    DataGridView1.DataSource = alquilerModel.GetAllByFechaInicio(dpFechaInicio.Value.Date, dpFechaFinal.Value.Date)
                Else
                    DataGridView1.DataSource = alquilerModel.GetAllByFechaFinal(dpFechaInicio.Value.Date, dpFechaFinal.Value.Date)
                End If
            Else
                DataGridView1.DataSource = alquilerModel.GetAlquileres()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Try
            DataGridView1.DataSource = alquilerModel.FindbyNombre(TxtBuscar.Text)
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

    Private Sub btnCancelarLetra_Click(sender As Object, e As EventArgs) Handles btnCancelarLetra.Click
        MenuDesplegable.Visible = False
        BtnSubMenu.BackColor = Color.Transparent
    End Sub

    Private Sub btnCambiarLetra_Click(sender As Object, e As EventArgs) Handles btnCambiarLetra.Click
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
#End Region

End Class