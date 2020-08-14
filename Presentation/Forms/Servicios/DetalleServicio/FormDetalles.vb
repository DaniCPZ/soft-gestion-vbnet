Imports Domain

Public Class FormDetalles
    Public nroServicio As Integer
    Public fecha As String
    Public copias As String
    Public serial As String
    Public cliente As String
    Public observaciones As String

    Dim detalleModel As New DetalleServicioModel()
    Private Sub FormDetalles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDetalle()
        cargarMsg()
    End Sub
    Private Sub cargarDetalle()
        detalleModel.GetDetalles()
        DataGridView1.DataSource = detalleModel.FindByService(nroServicio)
        DataGridView1.ClearSelection()
        DataGridView1.Columns(0).Visible = False
    End Sub

    Private Sub cargarMsg()
        Dim msg As String
        msg = "Servicio numero " + nroServicio.ToString + " realizado el dia " + fecha + " al equipo con serial '" + serial + "', durante el alquiler al señor/a " + cliente + "." + vbNewLine
        msg += "Observaciones: " + observaciones
        lblMessage.Text = msg
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class