Imports DataAccess

Public Class ReportesCobros
    Public Property FechaReporte As Date
    Public Property FechaInicio As Date
    Public Property FechaFinal As Date
    Public Property ListadoCobros As List(Of ListadoCobros)
    Public Property CobranzaPorPeriodo As List(Of CobrosPorPeriodo)
    Public Property CobranzaTotal As Double
    Public Sub crearReporteDeCobros(fI As Date, fF As Date)
        'implement dates
        FechaReporte = Date.Now
        FechaInicio = fI
        FechaFinal = fF

        'crear lista de cobros
        Dim pagoDataModel = New PagoRepository()

        Dim result = pagoDataModel.GetByDate(fI, fF)

        ListadoCobros = New List(Of ListadoCobros)

        For Each item As DataRow In result.Rows
            Dim pagoModel = New ListadoCobros With {
                .nroPago = item(0),
                .FK_Cliente = item(1),
                .tipoPago = item(2),
                .Fecha = item(3),
                .Importe = item(4)
            }
            ListadoCobros.Add(pagoModel)
            CobranzaTotal += Convert.ToDecimal(item(4))
        Next

        'crear ventas netas por período
        'crear lista temporal de ventas netas por fecha
        Dim listCobrosByDate = (From cobro In ListadoCobros
                                Group cobro By keyDateGroup = cobro.Fecha
                                    Into listCobros =
                                    Group Select New With {
                                        .date = keyDateGroup,
                                        .amount = listCobros.Sum(Function(emp) emp.Importe)
                                    }
                                ).AsEnumerable
        Dim diasTotales = Convert.ToInt32((fF - fI).Days)

        If diasTotales <= 7 Then

            CobranzaPorPeriodo = (From cobros In listCobrosByDate
                                  Group cobros By keyDateGroup = cobros.date.ToString("dd-MMM-yyyy")
                                    Into listCobros =
                                    Group Select New CobrosPorPeriodo With {
                                        .Periodo = keyDateGroup,
                                        .CobranzaNeta = listCobros.Sum(Function(item) item.amount)
                                    }
                                ).ToList

        ElseIf diasTotales <= 30 Then

            CobranzaPorPeriodo = (From cobros In listCobrosByDate
                                  Group cobros By keyDateGroup = System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                    cobros.date, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                  Into listCobros =
                                    Group Select New CobrosPorPeriodo With {
                                        .Periodo = "Semana" + keyDateGroup.ToString,
                                        .CobranzaNeta = listCobros.Sum(Function(item) item.amount)
                                    }
                                ).ToList

        ElseIf diasTotales <= 365 Then

            CobranzaPorPeriodo = (From cobros In listCobrosByDate
                                  Group cobros By keyDateGroup = cobros.date.ToString("MMM-yyyy")
                                    Into listCobros =
                                    Group Select New CobrosPorPeriodo With {
                                        .Periodo = keyDateGroup,
                                        .CobranzaNeta = listCobros.Sum(Function(item) item.amount)
                                    }
                                ).ToList

        Else

            CobranzaPorPeriodo = (From cobros In listCobrosByDate
                                  Group cobros By keyDateGroup = cobros.date.ToString("yyyy")
                                    Into listCobros =
                                    Group Select New CobrosPorPeriodo With {
                                        .Periodo = keyDateGroup,
                                        .CobranzaNeta = listCobros.Sum(Function(item) item.amount)
                                    }
                                ).ToList

        End If
    End Sub
End Class
