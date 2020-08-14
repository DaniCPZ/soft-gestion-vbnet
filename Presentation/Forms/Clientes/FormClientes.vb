Imports Domain
Imports Common
Imports Transitions
Public Class FormClientes
    Dim clienteModel As New ClienteModel()
    Dim clienteModel2 As New ClienteModel()

#Region "ACCIONES DEL FORMULARIO GENERAL "
    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarClientes()
        ListarClientesCobranza()
        ListarLocalidades()
        Seguridad()
    End Sub
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
    Private Sub ListarClientesCobranza()
        Try
            DataGridView3.DataSource = clienteModel2.GetClienteForCobranza()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ListarClientes()
        Try
            DataGridView1.DataSource = clienteModel.GetClientes()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ListarLocalidades()
        Dim localidadModel As New LocalidadModel()
        CmbLocalidad.DataSource = localidadModel.GetLocalidadesOrderByNombre
        CmbLocalidad.DisplayMember = "Nombre"
        CmbLocalidad.ValueMember = "codigoPostal"
    End Sub

#End Region

#Region "BOTONES BARRA SUPERIOR - Navegacion entre ventanas"
    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        BunifuPages1.SetPage("TabPage1")
        ColorBtnDefault()
        ChangeColor(1)
    End Sub

    Private Sub BtnEstadisticas_Click(sender As Object, e As EventArgs)
        BunifuPages1.SetPage("TabPage2")
        ColorBtnDefault()
        ChangeColor(2)
    End Sub
    Private Sub BtnAlquiler_Click(sender As Object, e As EventArgs) Handles BtnAlquiler.Click
        BunifuPages1.SetPage("TabPage3")
        ColorBtnDefault()
        ChangeColor(3)
    End Sub
    Private Sub ColorBtnDefault()
        BtnClientes.BackColor = Color.FromArgb(0, 136, 255)
        BtnClientes.ForeColor = Color.White
        BtnAlquiler.BackColor = Color.FromArgb(0, 136, 255)
        BtnAlquiler.ForeColor = Color.White
    End Sub
    Private Sub ChangeColor(pos As Integer)
        Select Case pos
            Case 1
                BtnClientes.BackColor = Color.White
                BtnClientes.ForeColor = Color.FromArgb(50, 59, 70)
            Case 3
                BtnAlquiler.BackColor = Color.White
                BtnAlquiler.ForeColor = Color.FromArgb(50, 59, 70)
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
    Private Sub Centrar3()
        Dim w As Integer
        w = DataGridView3.Columns.GetColumnsWidth(DataGridViewElementStates.None)
        If Not ((w - 5) > DataGridView3.Parent.Size.Width) Then
            DataGridView3.Width = w
            DataGridView3.Left = (DataGridView3.Parent.Size.Width - DataGridView3.Width) / 2
        End If
    End Sub
    Private Sub DataGridView3_Resize(sender As Object, e As EventArgs) Handles DataGridView3.Resize
        If (DataGridView3.Columns.GetColumnsWidth(DataGridViewElementStates.None) > 0) Then
            Centrar3()
        End If
    End Sub

    Private Sub DataGridView1_Resize(sender As Object, e As EventArgs) Handles DataGridView1.Resize
        If (DataGridView1.Columns.GetColumnsWidth(DataGridViewElementStates.None) > 0) Then
            Centrar()
        End If
    End Sub
#End Region

#Region "VENTANA DE CLIENTES"
    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Dim resultado As Long
        If Long.TryParse(TxtBuscar.Text, resultado) Then
            DataGridView1.DataSource = clienteModel.FindbyCuit(TxtBuscar.Text)
        Else
            DataGridView1.DataSource = clienteModel.FindbyNombre(TxtBuscar.Text)
        End If
    End Sub


    Private Sub btnExportarExcel_Click(sender As Object, e As EventArgs) Handles btnExportarExcel.Click
        Dim cE As New ExportarOffice
        Dim save As New SaveFileDialog
        save.Filter = "Archivo Excel | *.xlsx"
        If save.ShowDialog = Windows.Forms.DialogResult.OK Then
            cE.ExportarExcel(Me.DataGridView1, save.FileName)
        End If
    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim formulario As FormNewCliente
        formulario = New FormNewCliente
        formulario.ShowDialog()
        If formulario.state Then
            ListarClientes()
            Dim formSuccess As FormSuccess
            formSuccess = New FormSuccess With {
                    .mensaje = "       Cliente ingresado con exito"
                }
            formSuccess.ShowDialog()
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim cuit As String
            Dim formulario As FormEditCliente
            formulario = New FormEditCliente()
            formulario.id_cliente = DataGridView1.CurrentRow.Cells(0).Value.ToString()
            formulario.TxtNombre.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
            cuit = DataGridView1.CurrentRow.Cells(2).Value.ToString()
            formulario.cmbCuit.Text = Microsoft.VisualBasic.Left(cuit, 2)
            formulario.TxtCuit.Text = Microsoft.VisualBasic.Right(cuit, 9)
            formulario.TxtEmail.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
            formulario.TxtIva.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
            formulario.TxtTelefono.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
            formulario.CmbLocalidad.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
            formulario.TxtDireccion.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
            formulario.txtSaldo.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
            formulario.ShowDialog()
            If formulario.state = True Then
                ListarClientes()
                Dim formSuccess As FormSuccess
                formSuccess = New FormSuccess With {
                    .mensaje = "            Cliente editado con exito"
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
                clienteModel.ID_Cliente = DataGridView1.CurrentRow.Cells(0).Value
                clienteModel.State = EntityState.Deleted
                Dim result = clienteModel.SaveChanges()
                If result = "Remove" Then
                    Dim formSuccess As FormSuccess
                    formSuccess = New FormSuccess With {
                        .mensaje = "       Cliente eliminado con exito"
                    }
                    formSuccess.ShowDialog()
                    ListarClientes()
                Else
                    Dim formError As FormError
                    formError = New FormError With {
                        .mensaje = result
                    }
                    formError.ShowDialog()
                End If
            End If
        Else
            Dim formError As FormError
            formError = New FormError With {
                        .mensaje = "Seleccione un registro"
                    }
            formError.ShowDialog()
        End If
    End Sub
    '-------------------------------------------
    '|        SUB MENU DE CONFIGURACION        |
    '-------------------------------------------
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
        DataGridView3.RowsDefaultCellStyle.Font = font
        MenuDesplegable.Visible = False
        BtnSubMenu.BackColor = Color.Transparent
    End Sub
    Private Sub btnCancelarLetra_Click(sender As Object, e As EventArgs) Handles btnCancelarLetra.Click
        MenuDesplegable.Visible = False
        BtnSubMenu.BackColor = Color.Transparent
    End Sub


    '-------------------------------------------
    '|           PANEL DE FILTRO               |
    '-------------------------------------------

    Private Sub btnFilter1_Click_1(sender As Object, e As EventArgs) Handles btnFilter1.Click
        Dim t As New Transition(New TransitionType_EaseInEaseOut(1000))
        If panelFilter.Width <= 40 Then
            t.add(Me.panelFilter, "Width", 220)
            t.add(Me.panelFilter, "Height", 300)
            t.add(Me.btnFilter1, "Left", 95)
            panelFilter.BackColor = Color.FromArgb(240, 240, 240)
        ElseIf panelFilter.Width >= 220 Then
            t.add(Me.panelFilter, "Width", 40)
            t.add(Me.panelFilter, "Height", 40)
            t.add(Me.btnFilter1, "Left", 5)
        End If
        t.run()
        panelFilter.BackColor = Color.FromArgb(240, 240, 240)
    End Sub
    Private Sub ListarClientesPorFecha()
        Try
            DataGridView1.DataSource = clienteModel.GetClientesByFecha(dpFechaInicio.Value.Date, dpFechaFinal.Value.Date)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ListarClientesPorFechaYLocalidad()
        Try
            DataGridView1.DataSource = clienteModel.GetClientesByFechaAndLocalidad(dpFechaInicio.Value.Date, dpFechaFinal.Value.Date, CmbLocalidad.SelectedValue)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ListarClientesPorLocalidad()
        Try
            DataGridView1.DataSource = clienteModel.GetClientesByLocalidad(CmbLocalidad.SelectedValue)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbFecha_CheckedChanged(sender As Object, e As EventArgs) Handles cbFecha.CheckedChanged
        If cbFecha.Checked Then
            pnlFecha.Enabled = True
        Else
            pnlFecha.Enabled = False
        End If
    End Sub

    Private Sub btnAplicarFiltro_Click(sender As Object, e As EventArgs) Handles btnAplicarFiltro.Click
        If cbFecha.Checked And cbLocalidad.Checked Then
            ListarClientesPorFechaYLocalidad()
        ElseIf cbFecha.Checked Then
            ListarClientesPorFecha()
        ElseIf cbLocalidad.Checked Then
            ListarClientesPorLocalidad()
        Else
            ListarClientes()
        End If
    End Sub
    Private Sub cbLocalidad_CheckedChanged(sender As Object, e As EventArgs) Handles cbLocalidad.CheckedChanged
        If cbLocalidad.Checked Then
            CmbLocalidad.Enabled = True
        Else
            CmbLocalidad.Enabled = False
        End If
    End Sub
#End Region

#Region "VENTANA CERRAR ALQUILER"
    Private Sub DataGridView3_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellDoubleClick
        If Not e.RowIndex = -1 Then
            Dim formulario As FormCobrarAlquiler
            formulario = New FormCobrarAlquiler
            formulario.cliente = Convert.ToInt32(DataGridView3.CurrentRow.Cells(0).Value.ToString())
            formulario.txtCliente.Text = DataGridView3.CurrentRow.Cells(1).Value.ToString()
            formulario.txtCliente2.Text = DataGridView3.CurrentRow.Cells(1).Value.ToString()
            formulario.ShowDialog()
        End If
    End Sub

    Private Sub txtBuscar3_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar3.TextChanged
        Dim resultado As Long
        If Long.TryParse(txtBuscar3.Text, resultado) Then
            DataGridView3.DataSource = clienteModel2.FindbyCuit(txtBuscar3.Text)
        Else
            DataGridView3.DataSource = clienteModel2.FindbyNombre(txtBuscar3.Text)
        End If
    End Sub

    Private Sub btnLC_Click(sender As Object, e As EventArgs) Handles btnLC.Click
        If DataGridView3.Rows.Count > 0 Then
            Dim formulario As FormListadoCobranzas
            formulario = New FormListadoCobranzas
            formulario.ShowDialog()
        End If
    End Sub
#End Region

#Region "SEGURIDAD"
    Private Sub Seguridad()
        If ActiveUser.Cargo = Cargos.administrador Then
            BtnBorrar.Enabled = False
        ElseIf ActiveUser.Cargo = Cargos.cobrador Then
            BtnEditar.Enabled = False
            BtnBorrar.Enabled = False
            BtnNuevo.Enabled = False
        End If
    End Sub

#End Region

End Class