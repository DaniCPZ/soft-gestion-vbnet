Imports Domain
Imports Transitions

Public Class FormExtras
    Dim userModel As New UserModel
    Dim localidadModel As New LocalidadModel
    Private Sub FormExtras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarUser()
        cargarLocalidad()
    End Sub

    Private Sub cargarUser()
        Try
            DataGridView1.DataSource = userModel.GetAll()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cargarLocalidad()
        Try
            DataGridView2.DataSource = localidadModel.GetLocalidades()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

#Region "CENTRAR DATAGRIDVIEW"

    Private Sub Centrar()
        Dim w As Integer
        w = DataGridView1.Columns.GetColumnsWidth(DataGridViewElementStates.None)
        If Not ((w - 5) > DataGridView1.Parent.Size.Width) Then
            DataGridView1.Width = w
            DataGridView1.Left = (DataGridView1.Parent.Size.Width - DataGridView1.Width) / 2
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

    Private Sub DataGridView1_Resize(sender As Object, e As EventArgs) Handles DataGridView1.Resize
        If (DataGridView1.Columns.GetColumnsWidth(DataGridViewElementStates.None) > 0) Then
            Centrar()
        End If
    End Sub

#End Region

#Region "BOTONES BARRA SUPERIOR - Navegacion entre ventanas"
    Private Sub btnLocalidad_Click(sender As Object, e As EventArgs) Handles btnLocalidad.Click
        BunifuPages1.SetPage("TabPage1")
        ColorBtnDefault()
        ChangeColor(2)
    End Sub
    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        BunifuPages1.SetPage("TabPage2")
        ColorBtnDefault()
        ChangeColor(1)
    End Sub
    Private Sub ColorBtnDefault()
        btnUser.BackColor = Color.FromArgb(0, 136, 255)
        btnUser.ForeColor = Color.White
        btnLocalidad.BackColor = Color.FromArgb(0, 136, 255)
        btnLocalidad.ForeColor = Color.White
    End Sub
    Private Sub ChangeColor(pos As Integer)
        Select Case pos
            Case 1
                btnUser.BackColor = Color.White
                btnUser.ForeColor = Color.FromArgb(50, 59, 70)
            Case 2
                btnLocalidad.BackColor = Color.White
                btnLocalidad.ForeColor = Color.FromArgb(50, 59, 70)
        End Select
    End Sub

#End Region

#Region "VENTANA USER"
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim formulario As FormNewUser
        formulario = New FormNewUser
        formulario.ShowDialog()
        If formulario.state Then
            cargarUser()
        End If
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            If Not (DataGridView1.CurrentRow.Cells(5).Value.ToString() = "GERENTE" Or 1 = Convert.ToInt32(DataGridView1.CurrentRow.Cells(0).Value)) Then
                userModel.ID_User = DataGridView1.CurrentRow.Cells(0).Value
                userModel.State = EntityState.Deleted
                Dim result = userModel.SaveChanges()
                Dim formulario As FormSuccess
                formulario = New FormSuccess With {
                        .mensaje = "            " + result
                    }
                formulario.ShowDialog()
                cargarUser()
            End If
        Else
            Dim formulario1 As FormError
            formulario1 = New FormError With {
                    .mensaje = "            Seleccione un registro"
                }
            formulario1.ShowDialog()
        End If
    End Sub

#End Region

#Region "VENTANA LOCALIDAD"
    Private Sub btnNuevo2_Click(sender As Object, e As EventArgs) Handles btnNuevo2.Click
        Dim formulario As FormNewLocalidad
        formulario = New FormNewLocalidad
        formulario.ShowDialog()
        If formulario.state Then
            cargarLocalidad()

        End If
    End Sub

    Private Sub btnEditar2_Click(sender As Object, e As EventArgs) Handles btnEditar2.Click
        If DataGridView2.SelectedRows.Count > 0 Then
            Dim formulario As FormEditLocalidad
            formulario = New FormEditLocalidad With {
                .CodPostal = DataGridView2.CurrentRow.Cells(0).Value
            }
            formulario.ShowDialog()
            If formulario.state Then
                cargarLocalidad()

            End If
        Else
            MsgBox("Seleccione un registro")
        End If
    End Sub

    Private Sub btnBorrar2_Click(sender As Object, e As EventArgs) Handles btnBorrar2.Click
        If DataGridView2.SelectedRows.Count > 0 Then
            localidadModel.CodigoPostal = DataGridView2.CurrentRow.Cells(0).Value
            localidadModel.State = EntityState.Deleted
            Dim result = localidadModel.SaveChanges()
            MsgBox(result)
            cargarLocalidad()
        Else
            MsgBox("Seleccione un registro")
        End If
    End Sub


#End Region

End Class