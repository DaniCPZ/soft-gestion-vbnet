Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess
Public Class PagoRepository
    Inherits MasterRepository
    Implements IPagoRepository

    Private selectAll As String
    Private selectLastFive As String
    Private selectFilterFecha As String
    Private insert As String
    Private update As String
    Private delete As String

    Public Sub New()
        selectAll = "select * from Pago ORDER BY nroPago DESC"
        selectLastFive = "select top 8 * from Pago where FK_Cliente=@FK_Cliente order by Fecha desc "
        selectFilterFecha = " select * from Pago where Fecha between @FechaInicial and @Fechafinal"
        insert = "insert into Pago values(@FK_Cliente,@tipoPago,@Fecha,@Importe)"
        update = "update Pago set FK_Cliente=@FK_Cliente,tipoPago=@tipoPago,Fecha=@Fecha,Importe=@Importe where nroPago=@nroPago"
        delete = "delete from Pago where nroPago=@nroPago"
    End Sub
    Public Function GetAll() As IEnumerable(Of Pago) Implements IGenericRepository(Of Pago).GetAll
        Dim resultTable = ExecuteReader(selectAll)
        Dim listPagos = New List(Of Pago)
        For Each item As DataRow In resultTable.Rows
            listPagos.Add(New Pago With {
                .nroPago = item(0),
                .FK_Cliente = item(1),
                .tipoPago = item(2),
                .Fecha = item(3),
                .Importe = item(4)
            })
        Next
        Return listPagos
    End Function

    Public Function Add(entity As Pago) As Integer Implements IGenericRepository(Of Pago).Add
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@FK_Cliente", entity.FK_Cliente))
        parameters.Add(New SqlParameter("@tipoPago", entity.tipoPago))
        parameters.Add(New SqlParameter("@Fecha", entity.Fecha))
        parameters.Add(New SqlParameter("@Importe", entity.Importe))
        Return ExecuteNonQuery(insert)
    End Function

    Public Function Edit(entity As Pago) As Integer Implements IGenericRepository(Of Pago).Edit
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@nroPago", entity.nroPago))
        parameters.Add(New SqlParameter("@FK_Cliente", entity.FK_Cliente))
        parameters.Add(New SqlParameter("@tipoPago", entity.tipoPago))
        parameters.Add(New SqlParameter("@Fecha", entity.Fecha))
        parameters.Add(New SqlParameter("@Importe", entity.Importe))
        Return ExecuteNonQuery(update)
    End Function

    Public Function Remove(id As Integer) As Integer Implements IGenericRepository(Of Pago).Remove
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@nroPago", id))
        Return ExecuteNonQuery(delete)
    End Function
    Public Function LastsPagoByCliente(id As Integer) As DataTable Implements IPagoRepository.LastsPagoByCliente
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@FK_Cliente", id))
        Return ExecuteReader(selectLastFive)
    End Function

    Public Function GetByDate(fI As Date, fF As Date) As DataTable Implements IPagoRepository.GetByDate
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@FechaInicial", fI))
        parameters.Add(New SqlParameter("@Fechafinal", fF))
        Return ExecuteReader(selectFilterFecha)
    End Function
End Class
