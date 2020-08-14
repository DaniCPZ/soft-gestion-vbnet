Imports Common
Imports Domain
Public Class FormEquipos
    Dim equipoModel As New EquipoModel()
    Dim contadorModel As New ContadorModel()

#Region "ACCIONES DEL FORMULARIO GENERAL - ListarClientes"
    Private Sub FormEquipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarEquipos()
        ListarContadores()
        Seguridad()
    End Sub
    Private Sub ListarEquipos()
        Try
            DataGridView1.DataSource = equipoModel.GetEquipos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ListarContadores()
        Try
            DataGridView2.DataSource = contadorModel.GetContadores()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "CENTRAR DATAGRIDVIEW"
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

#Region "BOTONES BARRA SUPERIOR - Navegacion entre ventanas"
    Private Sub BtnEquipos_Click(sender As Object, e As EventArgs) Handles BtnEquipos.Click
        BunifuPages1.SetPage("TabPage1")
        ColorBtnDefault()
        ChangeColor(1)
    End Sub
    Private Sub btnContadores_Click(sender As Object, e As EventArgs) Handles btnContadores.Click
        BunifuPages1.SetPage("TabPage2")
        ColorBtnDefault()
        ChangeColor(2)
    End Sub

    Private Sub ColorBtnDefault()
        btnContadores.BackColor = Color.FromArgb(0, 136, 255)
        btnContadores.ForeColor = Color.White
        BtnEquipos.BackColor = Color.FromArgb(0, 136, 255)
        BtnEquipos.ForeColor = Color.White
    End Sub
    Private Sub ChangeColor(pos As Integer)
        Select Case pos
            Case 1
                BtnEquipos.BackColor = Color.White
                BtnEquipos.ForeColor = Color.FromArgb(50, 59, 70)
            Case 2
                btnContadores.BackColor = Color.White
                btnContadores.ForeColor = Color.FromArgb(50, 59, 70)

        End Select
    End Sub
#End Region

#Region "VENTANA EQUIPOS"
    Private Sub btnExportarExcel_Click(sender As Object, e As EventArgs) Handles btnExportarExcel.Click
        Dim cE As New ExportarOffice
        Dim save As New SaveFileDialog
        save.Filter = "Archivo Excel | *.xlsx"
        If save.ShowDialog = Windows.Forms.DialogResult.OK Then
            cE.ExportarExcel(Me.DataGridView1, save.FileName)
        End If
    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim formulario As FormNewEquipo
        formulario = New FormNewEquipo
        formulario.ShowDialog()
        If formulario.state Then
            ListarEquipos()
            Dim formSuccess As FormSuccess
            formSuccess = New FormSuccess With {
                    .mensaje = "       Equipo ingresado con exito"
                }
            formSuccess.ShowDialog()
        End If

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim formulario As FormEditEquipo
            formulario = New FormEditEquipo()

            formulario.serial = DataGridView1.CurrentRow.Cells(0).Value.ToString()
            formulario.TxtSerial.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
            formulario.TxtMarca.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
            formulario.TxtModelo.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
            formulario.TxtImpresion.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
            formulario.TxtVelocidad.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
            formulario.TxtCopias.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()

            formulario.ShowDialog()
            If formulario.state Then
                ListarEquipos()
                Dim formSuccess As FormSuccess
                formSuccess = New FormSuccess With {
                    .mensaje = "       Equipo editado con exito"
                }
                formSuccess.ShowDialog()
            End If
        Else
            MsgBox("Seleccione un registro")
        End If
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            equipoModel.Serial = DataGridView1.CurrentRow.Cells(0).Value.ToString()
            equipoModel.State = EntityState.Deleted
            Dim result = equipoModel.SaveChanges()
            MsgBox(result)
            ListarEquipos()
        Else
            MsgBox("Seleccione un registro")
        End If
    End Sub
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Try
            DataGridView1.DataSource = equipoModel.Find(TxtBuscar.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelarLetra_Click(sender As Object, e As EventArgs) Handles btnCancelarLetra.Click
        MenuDesplegable.Visible = False
        BtnSubMenu.BackColor = Color.Transparent
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

    Private Sub BtnSubMenu_Click(sender As Object, e As EventArgs) Handles BtnSubMenu.Click
        If MenuDesplegable.Visible Then
            MenuDesplegable.Visible = False
            BtnSubMenu.BackColor = Color.Transparent
        Else
            MenuDesplegable.Visible = True
            BtnSubMenu.BackColor = Color.FromArgb(240, 240, 240)
        End If
    End Sub
#End Region

#Region "VENTANA DE CONTADORES"
    Private Sub btnNuevoCont_Click(sender As Object, e As EventArgs) Handles btnNuevoCont.Click
        FormNewContador.ShowDialog()
    End Sub

    Private Sub txtBuscar2_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar2.TextChanged

    End Sub
#End Region

#Region "SEGURIDAD"
    Private Sub Seguridad()
        If ActiveUser.Cargo = Cargos.cobrador Then
            BtnNuevo.Enabled = False
            BtnEditar.Enabled = False
            BtnBorrar.Enabled = False
        End If
    End Sub

#End Region
End Class