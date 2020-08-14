Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess
Public Class ClienteRepository
    Inherits MasterRepository
    Implements IClienteRepository

    Private selectAll As String
    Private selectForCobranza As String
    Private selectForCmb As String
    Private selectFilterFecha As String
    Private selectFilterLocalidad As String
    Private selectFilterFechaAndLocalidad As String
    Private insert As String
    Private update As String
    Private delete As String

    Public Sub New()
        selectAll = "select * from Cliente"
        'para la cobranza
        selectForCobranza = "SELECT DISTINCT Cliente.* from Cliente inner join (select * from Alquiler where Alquiler.fechaFinal >= CONVERT(date, GETDATE()))as c on Cliente.ID_Cliente = c.FK_Cliente"
        selectForCmb = "select ID_Cliente, Nombre as DataView from Cliente Order by Nombre"
        selectFilterFecha = " select * from Cliente where FechaAlta between @FechaInicial and @Fechafinal"
        selectFilterLocalidad = " select * from Cliente where FK_CodPostal=@FK_CodPostal"
        selectFilterFechaAndLocalidad = "select * from Cliente where FK_CodPostal=@FK_CodPostal AND FechaAlta between @FechaInicial and @Fechafinal"
        insert = "insert into Cliente values(@Nombre,@Cuit,@Cond_IVA,@Email,@Telefono,@Direccion,@Saldo,@FK_CodPostal,@FechaAlta)"
        update = "update Cliente set Nombre=@Nombre,Cuit=@Cuit,Cond_IVA=@Cond_IVA,Email=@Email,Telefono=@Telefono,Direccion=@Direccion,Saldo=@Saldo,FK_CodPostal=@FK_CodPostal where ID_Cliente=@ID_Cliente"
        delete = "delete from Cliente where ID_Cliente=@ID_Cliente"
    End Sub

    Public Sub ClearListParameters() Implements IClienteRepository.ClearListParameters
        LimpiarParametros()
    End Sub

    Public Function GetAll() As IEnumerable(Of Cliente) Implements IGenericRepository(Of Cliente).GetAll
        Dim resultTable = ExecuteReader(selectAll)
        Dim listClientes = New List(Of Cliente)
        For Each item As DataRow In resultTable.Rows
            listClientes.Add(New Cliente With {
                .ID_Cliente = item(0),
                .Nombre = item(1),
                .Cuit = item(2),
                .Cond_IVA = item(3),
                .Email = item(4),
                .Telefono = item(5),
                .Direccion = item(6),
                .Saldo = item(7),
                .FK_CodPostal = item(8),
                .fechaAlta = item(9)
            })
        Next
        Return listClientes
    End Function

    Public Function Add(entity As Cliente) As Integer Implements IGenericRepository(Of Cliente).Add
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@Nombre", entity.Nombre))
        parameters.Add(New SqlParameter("@Cuit", entity.Cuit))
        parameters.Add(New SqlParameter("@Cond_IVA", entity.Cond_IVA))
        parameters.Add(New SqlParameter("@Email", entity.Email))
        parameters.Add(New SqlParameter("@Telefono", entity.Telefono))
        parameters.Add(New SqlParameter("@Direccion", entity.Direccion))
        parameters.Add(New SqlParameter("@Saldo", entity.Saldo))
        parameters.Add(New SqlParameter("@FK_CodPostal", entity.FK_CodPostal))
        parameters.Add(New SqlParameter("@FechaAlta", entity.fechaAlta))
        Return ExecuteNonQuery(insert)
    End Function

    Public Function Edit(entity As Cliente) As Integer Implements IGenericRepository(Of Cliente).Edit
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@ID_Cliente", entity.ID_Cliente))
        parameters.Add(New SqlParameter("@Nombre", entity.Nombre))
        parameters.Add(New SqlParameter("@Cuit", entity.Cuit))
        parameters.Add(New SqlParameter("@Cond_IVA", entity.Cond_IVA))
        parameters.Add(New SqlParameter("@Email", entity.Email))
        parameters.Add(New SqlParameter("@Telefono", entity.Telefono))
        parameters.Add(New SqlParameter("@Direccion", entity.Direccion))
        parameters.Add(New SqlParameter("@Saldo", entity.Saldo))
        parameters.Add(New SqlParameter("@FK_CodPostal", entity.FK_CodPostal))
        Return ExecuteNonQuery(update)
    End Function

    Public Function Remove(id As Integer) As Integer Implements IGenericRepository(Of Cliente).Remove
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@ID_Cliente", id))
        Return ExecuteNonQuery(delete)
    End Function

    Public Function GetAllForCmb() As DataTable Implements IClienteRepository.GetAllForCmb
        Return ExecuteReader(selectForCmb)
    End Function

    Public Function GetByDate(fI As Date, fF As Date) As IEnumerable(Of Cliente) Implements IClienteRepository.GetByDate
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@FechaInicial", fI))
        parameters.Add(New SqlParameter("@Fechafinal", fF))
        Dim resultTable = ExecuteReader(selectFilterFecha)
        Dim listClientes = New List(Of Cliente)
        For Each item As DataRow In resultTable.Rows
            listClientes.Add(New Cliente With {
                .ID_Cliente = item(0),
                .Nombre = item(1),
                .Cuit = item(2),
                .Cond_IVA = item(3),
                .Email = item(4),
                .Telefono = item(5),
                .Direccion = item(6),
                .Saldo = item(7),
                .FK_CodPostal = item(8),
                .fechaAlta = item(9)
            })
        Next
        Return listClientes
    End Function

    Public Function GetByDateAndCity(fI As Date, fF As Date, idLocalidad As Integer) As IEnumerable(Of Cliente) Implements IClienteRepository.GetByDateAndCity
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@FK_CodPostal", idLocalidad))
        parameters.Add(New SqlParameter("@FechaInicial", fI))
        parameters.Add(New SqlParameter("@Fechafinal", fF))
        Dim resultTable = ExecuteReader(selectFilterFechaAndLocalidad)
        Dim listClientes = New List(Of Cliente)
        For Each item As DataRow In resultTable.Rows
            listClientes.Add(New Cliente With {
                .ID_Cliente = item(0),
               .Nombre = item(1),
                .Cuit = item(2),
                .Cond_IVA = item(3),
                .Email = item(4),
                .Telefono = item(5),
                .Direccion = item(6),
                .Saldo = item(7),
                .FK_CodPostal = item(8),
                .fechaAlta = item(9)
            })
        Next
        Return listClientes
    End Function

    Public Function GetByCity(idLocalidad As Integer) As IEnumerable(Of Cliente) Implements IClienteRepository.GetByCity
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@FK_CodPostal", idLocalidad))
        Dim resultTable = ExecuteReader(selectFilterLocalidad)
        Dim listClientes = New List(Of Cliente)
        For Each item As DataRow In resultTable.Rows
            listClientes.Add(New Cliente With {
                .ID_Cliente = item(0),
                .Nombre = item(1),
                .Cuit = item(2),
                .Cond_IVA = item(3),
                .Email = item(4),
                .Telefono = item(5),
                .Direccion = item(6),
                .Saldo = item(7),
                .FK_CodPostal = item(8),
                .fechaAlta = item(9)
            })
        Next
        Return listClientes
    End Function

    Public Function GetFotCobranza() As IEnumerable(Of Cliente) Implements IClienteRepository.GetForCobranza
        Dim resultTable = ExecuteReader(selectForCobranza)
        Dim listClientes = New List(Of Cliente)
        For Each item As DataRow In resultTable.Rows
            listClientes.Add(New Cliente With {
                .ID_Cliente = item(0),
                .Nombre = item(1),
                .Cuit = item(2),
                .Cond_IVA = item(3),
                .Email = item(4),
                .Telefono = item(5),
                .Direccion = item(6),
                .Saldo = item(7),
                .FK_CodPostal = item(8),
                .fechaAlta = item(9)
            })
        Next
        Return listClientes
    End Function
End Class
