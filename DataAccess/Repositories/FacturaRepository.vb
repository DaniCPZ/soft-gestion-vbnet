Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess
Public Class FacturaRepository
    Inherits MasterRepository
    Implements IFacturaRepository

    Private selectAll As String
    Private selectLastFive As String
    Private selectFilterFecha As String
    Private insert As String
    Private update As String
    Private delete As String

    Public Sub New()
        selectAll = "select * from Factura ORDER BY nroFactura DESC"
        selectLastFive = "select top 8 * from Factura where FK_Cliente=@FK_Cliente order by Fecha desc "
        selectFilterFecha = " select * from Factura where Fecha between @FechaInicial and @Fechafinal"
        insert = "insert into Factura values(@FK_Cliente,@Letra,@Fecha,@Cantidad,@precioUnitario,@Total)"
        update = "update Factura set FK_Cliente=@FK_Cliente,Letra=@Letra,Fecha=@Fecha,Cantidad=@Cantidad,precioUnitario=@precioUnitario,Total=@Total where nroFactura=@nroFactura"
        delete = "delete from Factura where nroFactura=@nroFactura"
    End Sub

    Public Function GetAll() As IEnumerable(Of Factura) Implements IGenericRepository(Of Factura).GetAll
        Dim resultTable = ExecuteReader(selectAll)
        Dim listFacturas = New List(Of Factura)
        For Each item As DataRow In resultTable.Rows
            listFacturas.Add(New Factura With {
                .nroFactura = item(0),
                .FK_Cliente = item(1),
                .Letra = item(2),
                .Fecha = item(3),
                .Cantidad = item(4),
                .precioUnitario = item(5),
                .Total = item(6)
            })
        Next
        Return listFacturas
    End Function

    Public Function Add(entity As Factura) As Integer Implements IGenericRepository(Of Factura).Add
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@FK_Cliente", entity.FK_Cliente))
        parameters.Add(New SqlParameter("@Letra", entity.Letra))
        parameters.Add(New SqlParameter("@Fecha", entity.Fecha))
        parameters.Add(New SqlParameter("@Cantidad", entity.Cantidad))
        parameters.Add(New SqlParameter("@precioUnitario", entity.precioUnitario))
        parameters.Add(New SqlParameter("@Total", entity.Total))
        Return ExecuteNonQuery(insert)
    End Function

    Public Function Edit(entity As Factura) As Integer Implements IGenericRepository(Of Factura).Edit
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@nroFactura", entity.nroFactura))
        parameters.Add(New SqlParameter("@FK_Cliente", entity.FK_Cliente))
        parameters.Add(New SqlParameter("@Letra", entity.Letra))
        parameters.Add(New SqlParameter("@Fecha", entity.Fecha))
        parameters.Add(New SqlParameter("@Cantidad", entity.Cantidad))
        parameters.Add(New SqlParameter("@precioUnitario", entity.precioUnitario))
        parameters.Add(New SqlParameter("@Total", entity.Total))
        Return ExecuteNonQuery(update)
    End Function

    Public Function Remove(id As Integer) As Integer Implements IGenericRepository(Of Factura).Remove
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@nroFactura", id))
        Return ExecuteNonQuery(delete)
    End Function

    Public Function LastsFacturaByCliente(id As Integer) As DataTable Implements IFacturaRepository.LastsFacturaByCliente
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@FK_Cliente", id))
        Return ExecuteReader(selectLastFive)
    End Function

    Public Function GetByDate(fI As Date, fF As Date) As DataTable Implements IFacturaRepository.GetByDate
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@FechaInicial", fI))
        parameters.Add(New SqlParameter("@Fechafinal", fF))
        Return ExecuteReader(selectFilterFecha)
    End Function

End Class
