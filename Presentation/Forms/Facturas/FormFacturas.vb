Imports Common
Imports Domain
Public Class FormFacturas
    Dim facturaModel As New FacturaModel()
#Region "ACCIONES DEL FORMULARIO GENERAL - ListarClientes"
    Private Sub FormFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarFacturas()
    End Sub
    Private Sub ListarFacturas()
        Try
            DataGridView1.DataSource = facturaModel.GetFacturas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
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


#Region "VENTANA DE FACTURAS"
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim formulario As FormNewFactura
        formulario = New FormNewFactura
        formulario.ShowDialog()
        If formulario.state = True Then
            ListarFacturas()
            FormSuccess.ShowDialog()
        End If
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        FormReportesFacturas.ShowDialog()
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

    Private Sub btnCancelarLetra_Click(sender As Object, e As EventArgs) Handles btnCancelarLetra.Click
        MenuDesplegable.Visible = False
        BtnSubMenu.BackColor = Color.Transparent
    End Sub

#End Region


End Class