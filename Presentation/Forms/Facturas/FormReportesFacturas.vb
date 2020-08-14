Imports Domain
Imports Microsoft.Reporting.WinForms

Public Class FormReportesFacturas
    Private Sub FormReportesFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ocultarPanel()
    End Sub

    Private Sub getSalesReport(ByVal startDate As DateTime, ByVal endDate As DateTime)
        Dim informeModel As New ReportesFacturas()
        informeModel.crearReporteDeFacturas(startDate, endDate)
        ReportesFacturasBindingSource.DataSource = informeModel
        ListadoFacturasBindingSource.DataSource = informeModel.ListadoFacturas
        FacturasPorPeriodoBindingSource.DataSource = informeModel.FacturacionPorPeriodo
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub OcultarPanel()
        pnlCustom.Visible = False
    End Sub
    Private Sub MostrarPanel(pnl As Panel)
        If pnl.Visible = False Then
            OcultarPanel()
            pnl.Visible = True
        Else
            pnl.Visible = False
        End If
    End Sub

    Private Sub btnCustom_Click(sender As Object, e As EventArgs) Handles btnCustom.Click
        mostrarPanel(pnlCustom)
    End Sub

    Private Sub btnHoy_Click(sender As Object, e As EventArgs) Handles btnHoy.Click
        Dim fromDate = Date.Today
        Dim toDate = Date.Now
        getSalesReport(fromDate, toDate)
        ocultarPanel()
    End Sub

    Private Sub btn7dias_Click(sender As Object, e As EventArgs) Handles btn7dias.Click
        Dim fromDate = DateTime.Today.AddDays(-7)
        Dim toDate = DateTime.Now
        getSalesReport(fromDate, toDate)
        ocultarPanel()
    End Sub

    Private Sub btnMes_Click(sender As Object, e As EventArgs) Handles btnMes.Click
        Dim fromDate = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
        Dim toDate = DateTime.Now
        getSalesReport(fromDate, toDate)
        ocultarPanel()
    End Sub

    Private Sub btnUltimos30dias_Click(sender As Object, e As EventArgs) Handles btnUltimos30dias.Click
        Dim fromDate = DateTime.Today.AddDays(-30)
        Dim toDate = DateTime.Now
        getSalesReport(fromDate, toDate)
    End Sub
    Private Sub btnAño_Click(sender As Object, e As EventArgs) Handles btnAño.Click
        Dim fromDate = New DateTime(DateTime.Now.Year, 1, 1)
        Dim toDate = DateTime.Now
        getSalesReport(fromDate, toDate)
        ocultarPanel()
    End Sub

    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        Dim fromDate = BunifuDatePicker1.Value
        Dim toDate = BunifuDatePicker2.Value
        getSalesReport(fromDate, New DateTime(toDate.Year, toDate.Month, toDate.Day, 23, 59, 59))
    End Sub

End Class