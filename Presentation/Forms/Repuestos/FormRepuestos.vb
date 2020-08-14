Imports Common
Imports Domain
Imports Transitions

Public Class FormRepuestos
    Dim repuestoModel As New RepuestoModel()
    Dim repProvModel As New RepuestoProveedorModel

#Region "ACCIONES DEL FORMULARIO GENERAL - ListarClientes"
    Private Sub FormRepuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarRepuestos()
        ListarRepuestosProveedores()
        Seguridad()
    End Sub
    Private Sub ListarRepuestos()
        Try
            DataGridView1.DataSource = repuestoModel.GetRepuestos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ListarRepuestosProveedores()
        Try
            DataGridView3.DataSource = repProvModel.GetRepuestosProveedores()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If DataGridView1.Columns(e.ColumnIndex).Name = "Stock" Then
            If (e.Value <= DataGridView1.Rows(e.RowIndex).Cells(2).Value) Then
                e.CellStyle.BackColor = Color.FromArgb(221, 80, 68)
                e.CellStyle.ForeColor = Color.FromArgb(255, 255, 255)
            End If

        End If
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

    Private Sub Centrar3()
        Dim w As Integer
        w = DataGridView3.Columns.GetColumnsWidth(DataGridViewElementStates.None)
        If Not ((w - 5) > DataGridView1.Parent.Size.Width) Then
            DataGridView3.Width = w
            DataGridView3.Left = (DataGridView3.Parent.Size.Width - DataGridView3.Width) / 2
        End If

    End Sub
    Private Sub DataGridView3_Resize(sender As Object, e As EventArgs) Handles DataGridView3.Resize
        If (DataGridView3.Columns.GetColumnsWidth(DataGridViewElementStates.None) > 0) Then
            Centrar3()
        End If
    End Sub
#End Region

#Region "BOTONES BARRA SUPERIOR - Navegacion entre ventanas"
    Private Sub BtnRepuestos_Click(sender As Object, e As EventArgs) Handles BtnRepuestos.Click
        BunifuPages1.SetPage("TabPage1")
        ColorBtnDefault()
        ChangeColor(1)
    End Sub
    Private Sub BtnEquipos_Click(sender As Object, e As EventArgs)
        BunifuPages1.SetPage("TabPage2")
        ColorBtnDefault()
        ChangeColor(2)
    End Sub
    Private Sub BtnProveedores_Click(sender As Object, e As EventArgs) Handles BtnProveedores.Click
        BunifuPages1.SetPage("TabPage3")
        ColorBtnDefault()
        ChangeColor(3)
    End Sub
    Private Sub ColorBtnDefault()
        BtnRepuestos.BackColor = Color.FromArgb(0, 136, 255)
        BtnRepuestos.ForeColor = Color.White
        BtnProveedores.BackColor = Color.FromArgb(0, 136, 255)
        BtnProveedores.ForeColor = Color.White
    End Sub
    Private Sub ChangeColor(pos As Integer)
        Select Case pos
            Case 1
                BtnRepuestos.BackColor = Color.White
                BtnRepuestos.ForeColor = Color.FromArgb(50, 59, 70)
            Case 3
                BtnProveedores.BackColor = Color.White
                BtnProveedores.ForeColor = Color.FromArgb(50, 59, 70)
        End Select
    End Sub
#End Region

#Region "VENTANA DE REPUESTOS"
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            DataGridView1.DataSource = repuestoModel.Find(txtBuscar.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim formulario As FormNewRepuesto
        formulario = New FormNewRepuesto
        formulario.ShowDialog()
        If formulario.state = True Then
            ListarRepuestos()
            Dim formSuccess As FormSuccess
            formSuccess = New FormSuccess With {
                    .mensaje = "         Repuesto ingresado con exito"
                }
            formSuccess.ShowDialog()
        End If
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim formulario As FormEditRepuesto
            formulario = New FormEditRepuesto()
            formulario.nroRepuesto = DataGridView1.CurrentRow.Cells(0).Value.ToString()
            formulario.TxtNroRepuesto.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
            formulario.TxtCostoUnitario.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
            formulario.TxtPP.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
            formulario.TxtLoteCompra.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
            formulario.TxtStock.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
            formulario.TxtDesc.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
            formulario.ShowDialog()
            If formulario.state = True Then
                ListarRepuestos()
                ListarRepuestosProveedores()
                Dim formSuccess As FormSuccess
                formSuccess = New FormSuccess With {
                    .mensaje = "           Repuesto editado con exito"
                }
                formSuccess.ShowDialog()
                ListarRepuestos()
                ListarRepuestosProveedores()
            End If
        Else
            MsgBox("Seleccione un registro")
        End If
    End Sub
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            repuestoModel.NroRepuesto = DataGridView1.CurrentRow.Cells(0).Value.ToString
            repuestoModel.State = EntityState.Deleted
            Dim result = repuestoModel.SaveChanges()
            If result = "Remove" Then
                Dim formSuccess As FormSuccess
                formSuccess = New FormSuccess With {
                        .mensaje = "       Repuesto eliminado con exito"
                    }
                formSuccess.ShowDialog()
                ListarRepuestos()
            Else
                Dim formError As FormError
                formError = New FormError With {
                        .mensaje = result
                    }
                formError.ShowDialog()
            End If

        Else
            MsgBox("Seleccione un registro")
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
            t.add(Me.panelFilter, "Width", 202)
            t.add(Me.panelFilter, "Height", 204)
            t.add(Me.btnFilter1, "Left", 86)
            panelFilter.BackColor = Color.FromArgb(240, 240, 240)
        ElseIf panelFilter.Width >= 202 Then
            t.add(Me.panelFilter, "Width", 40)
            t.add(Me.panelFilter, "Height", 40)
            t.add(Me.btnFilter1, "Left", 5)
        End If
        t.run()
        panelFilter.BackColor = Color.FromArgb(240, 240, 240)
    End Sub

    Private Sub listarRepSinStock()
        Try
            DataGridView1.DataSource = repuestoModel.GetRepSinStock()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub listarRepConStock()
        Try
            DataGridView1.DataSource = repuestoModel.GetRepConStock()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnAplicarFiltro_Click(sender As Object, e As EventArgs) Handles btnAplicarFiltro.Click
        If cbStock.Checked Then
            If rbSup.Checked Then
                listarRepConStock()
            ElseIf rbInf.Checked Then
                listarRepSinStock()
            End If
        Else
            ListarRepuestos()
        End If
    End Sub
    Private Sub cbStock_CheckedChanged(sender As Object, e As EventArgs) Handles cbStock.CheckedChanged
        If cbStock.Checked Then
            pnlFilterStock.Enabled = True
        Else
            pnlFilterStock.Enabled = False
        End If
    End Sub
#End Region

#Region "VENTANA DE DETERMINAR PROVEEDORES / Repuesto - proveedor"
    'Private Sub TxtBuscar3_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar3.TextChanged

    'End Sub
    Private Sub txtBuscar1_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar1.TextChanged
        Try
            DataGridView3.DataSource = repProvModel.FindByRepuesto(txtBuscar1.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnNuevo2_Click(sender As Object, e As EventArgs) Handles btnNuevo2.Click
        Dim formulario As FormNewRepuestoProveedor
        formulario = New FormNewRepuestoProveedor
        formulario.ShowDialog()
        If formulario.state Then
            ListarRepuestosProveedores()
            FormSuccess.ShowDialog()
        End If
    End Sub
    Private Sub btnEditar2_Click(sender As Object, e As EventArgs) Handles btnEditar2.Click
        If DataGridView3.SelectedRows.Count > 0 Then
            Dim formulario As FormEditRepuestoProveedor
            formulario = New FormEditRepuestoProveedor With {
                .repuesto = DataGridView3.CurrentRow.Cells(0).Value.ToString(),
                .proveedor = DataGridView3.CurrentRow.Cells(1).Value
            }
            formulario.TxtObs.Text = DataGridView3.CurrentRow.Cells(2).Value.ToString()
            formulario.ShowDialog()
            If formulario.state Then
                ListarRepuestosProveedores()
            End If

        Else
            MsgBox("Seleccione un registro")
        End If
    End Sub
    Private Sub btnBorrar2_Click(sender As Object, e As EventArgs) Handles btnBorrar2.Click
        If DataGridView3.SelectedRows.Count > 0 Then
            repProvModel.FK_Repuesto = DataGridView3.CurrentRow.Cells(0).Value.ToString
            repProvModel.FK_Proveedor = DataGridView3.CurrentRow.Cells(1).Value
            repProvModel.State = EntityState.Deleted
            Dim result = repProvModel.SaveChanges()
            If result = "Success" Then
                ListarRepuestosProveedores()
            End If
            MsgBox(result)
        Else
            MsgBox("Seleccione un registro")
        End If
    End Sub
#End Region

#Region "SEGURIDAD"
    Private Sub Seguridad()
        If ActiveUser.Cargo = Cargos.administrador Then
            BtnBorrar.Enabled = False
        End If
    End Sub





#End Region
End Class