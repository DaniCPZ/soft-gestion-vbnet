Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess
Public Class ServicioRepository
    Inherits MasterRepository
    Implements IServicioRepository

    Private selectAll As String
    Private selectAllForCmb As String
    Private selectFilterFecha As String

    Private selectLast As String
    Private insert As String
    Private update As String
    Private delete As String

    Public Sub New()
        selectAll = "select * from Servicio"
        selectAllForCmb = "select nroServicio, ( 'Serv:'+ cast(nroServicio as varchar) +'- Eq:'+ FK_Equipo) as Dataview from Servicio"
        selectLast = "select MAX(nroServicio) from Servicio"
        'Consulta para filtro
        selectFilterFecha = "select * from Servicio where Fecha between @FechaInicial and @Fechafinal"

        insert = "insert into Servicio values(@FK_Alquiler,@Fecha,@Observacion)"
        update = "update Servicio set Observacion=@Observacion where nroServicio=@nroServicio"
        delete = "delete from Servicio where nroServicio=@nroServicio"
    End Sub
    Public Function GetAll() As IEnumerable(Of Servicio) Implements IGenericRepository(Of Servicio).GetAll
        Dim resultTable = ExecuteReader(selectAll)
        Dim listServicios = New List(Of Servicio)
        For Each item As DataRow In resultTable.Rows
            listServicios.Add(New Servicio With {
                .nroServicio = item(0),
                .FK_Alquiler = item(1),
                .Fecha = item(2),
                .Observacion = item(3)
            })
        Next
        Return listServicios
    End Function

    Public Function Add(entity As Servicio) As Integer Implements IGenericRepository(Of Servicio).Add
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@FK_Alquiler", entity.FK_Alquiler))
        parameters.Add(New SqlParameter("@Fecha", entity.Fecha))
        parameters.Add(New SqlParameter("@Observacion", entity.Observacion))
        Return ExecuteNonQuery(insert)
    End Function

    Public Function Edit(entity As Servicio) As Integer Implements IGenericRepository(Of Servicio).Edit
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@nroServicio", entity.nroServicio))
        parameters.Add(New SqlParameter("@Observacion", entity.Observacion))
        Return ExecuteNonQuery(update)
    End Function

    Public Function Remove(id As Integer) As Integer Implements IGenericRepository(Of Servicio).Remove
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@nroServicio", id))
        Return ExecuteNonQuery(delete)
    End Function

    Public Function LastServicio() As Integer Implements IServicioRepository.LastServicio
        Dim resultTable = ExecuteReader(selectLast)
        Return Convert.ToInt32(resultTable.Rows(0).Item(0))
    End Function

    Public Function GetAllForCmb() As DataTable Implements IServicioRepository.GetAllForCmb
        'Return ExecuteReader(selectAllForCmb)
        Return New DataTable
    End Function

    Public Function GetByDate(fI As Date, fF As Date) As IEnumerable(Of Servicio) Implements IServicioRepository.GetByDate
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@FechaInicial", fI))
        parameters.Add(New SqlParameter("@Fechafinal", fF))
        Dim resultTable = ExecuteReader(selectFilterFecha)
        Dim listServicios = New List(Of Servicio)
        For Each item As DataRow In resultTable.Rows
            listServicios.Add(New Servicio With {
                .nroServicio = item(0),
                .FK_Alquiler = item(1),
                .Fecha = item(2),
                .Observacion = item(3)
            })
        Next
        Return listServicios
    End Function
End Class
