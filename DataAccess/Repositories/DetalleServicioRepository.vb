Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess
Public Class DetalleServicioRepository
    Inherits MasterRepository
    Implements IDetalleServicioRepository

    Private selectAll As String
    Private insert As String
    Private update As String
    Private delete As String

    Public Sub New()
        selectAll = "select * from DetalleServicio"
        insert = "insert into DetalleServicio values(@FK_Servicio,@FK_Repuesto,@Cantidad,@costoUnitario)"
        update = "update DetalleServicio set FK_Servicio=@FK_Servicio,FK_Repuesto=@FK_Repuesto,Cantidad=@Cantidad,costoUnitario=@costoUnitario where ID_Cliente=@ID_Cliente"
        delete = "delete from DetalleServicio where ID_Cliente=@ID_Cliente"
    End Sub

    Public Function GetAll() As IEnumerable(Of DetalleServicio) Implements IGenericRepository(Of DetalleServicio).GetAll
        Dim resultTable = ExecuteReader(selectAll)
        Dim listDetalles = New List(Of DetalleServicio)
        For Each item As DataRow In resultTable.Rows
            listDetalles.Add(New DetalleServicio With {
                .FK_Servicio = item(0),
                .FK_Repuesto = item(1),
                .Cantidad = item(2),
                .costoUnitario = item(3)
            })
        Next
        Return listDetalles
    End Function

    Public Function Add(entity As DetalleServicio) As Integer Implements IGenericRepository(Of DetalleServicio).Add
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@FK_Servicio", entity.FK_Servicio))
        parameters.Add(New SqlParameter("@FK_Repuesto", entity.FK_Repuesto))
        parameters.Add(New SqlParameter("@Cantidad", entity.Cantidad))
        parameters.Add(New SqlParameter("@costoUnitario", entity.costoUnitario))
        Return ExecuteNonQuery(insert)
    End Function

    Public Function Edit(entity As DetalleServicio) As Integer Implements IGenericRepository(Of DetalleServicio).Edit
        Throw New NotImplementedException()
    End Function

    Public Function Remove(id As Integer) As Integer Implements IGenericRepository(Of DetalleServicio).Remove
        Throw New NotImplementedException()
    End Function


End Class
