Imports DataAccess
Imports System
Public Class ReportesFacturas
    Public Property FechaReporte As Date
    Public Property FechaInicio As Date
    Public Property FechaFinal As Date
    Public Property ListadoFacturas As List(Of ListadoFacturas)
    Public Property FacturacionPorPeriodo As List(Of FacturasPorPeriodo)
    Public Property FacturacionTotal As Double

    Public Sub crearReporteDeFacturas(fI As Date, fF As Date)
        'implement dates
        FechaReporte = Date.Now
        FechaInicio = fI
        FechaFinal = fF

        'create sales listing
        Dim facturaDataModel = New FacturaRepository()

        Dim result = facturaDataModel.GetByDate(fI, fF)

        ListadoFacturas = New List(Of ListadoFacturas)

        For Each item As DataRow In result.Rows
            Dim facturaModel = New ListadoFacturas With {
                .NroFactura = item(0),
                .FK_Cliente = item(1),
                .Letra = item(2),
                .Fecha = item(3),
                .Cantidad = item(4),
                .PrecioUnitario = item(5),
                .Total = item(6)
            }
            ListadoFacturas.Add(facturaModel)
            'calculate total net sales
            FacturacionTotal += Convert.ToDecimal(item(6))
        Next

        'create net sales by period
        'create temp list net sales by date
        Dim listFacturasByDate = (From factura In ListadoFacturas
                                  Group factura By keyDateGroup = factura.Fecha
                                      Into listFacturas =
                                     Group Select New With {
                                           .date = keyDateGroup,
                                           .amount = listFacturas.Sum(Function(emp) emp.Total)
                                     }
                                 ).AsEnumerable

        Dim diasTotales = Convert.ToInt32((fF - fI).Days)
        If diasTotales <= 7 Then
            FacturacionPorPeriodo = (From facturas In listFacturasByDate
                                     Group facturas By keyDateGroup = facturas.date.ToString("dd-MMM-yyyy")
                                             Into listFacturas =
                                             Group Select New FacturasPorPeriodo With {
                         .Periodo = keyDateGroup,
                         .FacturacionNeta = listFacturas.Sum(Function(item) item.amount)
                     }).ToList
        ElseIf diasTotales <= 30 Then
            FacturacionPorPeriodo = (From facturas In listFacturasByDate
                                     Group facturas By keyDateGroup = System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                        facturas.date, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                    Into listFacturas =
                                             Group Select New FacturasPorPeriodo With {
                                                 .Periodo = "Semana " + keyDateGroup.ToString,
                                                 .FacturacionNeta = listFacturas.Sum(Function(item) item.amount)
                                             }).ToList
        ElseIf diasTotales <= 365 Then
            FacturacionPorPeriodo = (From facturas In listFacturasByDate
                                     Group facturas By keyDateGroup = facturas.date.ToString("MMM-yyyy")
                                             Into listFacturas =
                                             Group Select New FacturasPorPeriodo With {
                         .Periodo = keyDateGroup,
                         .FacturacionNeta = listFacturas.Sum(Function(item) item.amount)
                     }).ToList
        Else
            FacturacionPorPeriodo = (From facturas In listFacturasByDate
                                     Group facturas By keyDateGroup = facturas.date.ToString("yyyy")
                                             Into listFacturas =
                                             Group Select New FacturasPorPeriodo With {
                         .Periodo = keyDateGroup,
                         .FacturacionNeta = listFacturas.Sum(Function(item) item.amount)
                     }).ToList
        End If
    End Sub
End Class
