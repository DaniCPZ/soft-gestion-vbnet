Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess
Public Class ProveedorRepository
    Inherits MasterRepository
    Implements IProveedorRepository

    Private selectAll As String
    Private insert As String
    Private update As String
    Private delete As String

    Public Sub New()
        selectAll = "select * from Proveedor"
        insert = "insert into Proveedor values(@Nombre,@Cuit,@Email,@Telefono,@FechaAlta)"
        update = "update Proveedor set Nombre=@Nombre,Cuit=@Cuit,Email=@Email,Telefono=@Telefono where ID_Proveedor=@ID_Proveedor"
        delete = "delete from Proveedor where ID_Proveedor=@ID_Proveedor"
    End Sub

    Public Sub ClearListParameters() Implements IProveedorRepository.ClearListParameters
        LimpiarParametros()
    End Sub

    Public Function GetAll() As IEnumerable(Of Proveedor) Implements IGenericRepository(Of Proveedor).GetAll
        Dim resultTable = ExecuteReader(selectAll)
        Dim listProveedor = New List(Of Proveedor)
        For Each item As DataRow In resultTable.Rows
            listProveedor.Add(New Proveedor With {
                .ID_Proveedor = item(0),
                .Nombre = item(1),
                .Cuit = item(2),
                .Email = item(3),
                .Telefono = item(4),
                .fechaAlta = item(5)
            })
        Next
        Return listProveedor
    End Function

    Public Function Add(entity As Proveedor) As Integer Implements IGenericRepository(Of Proveedor).Add
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@Nombre", entity.Nombre))
        parameters.Add(New SqlParameter("@Cuit", entity.Cuit))
        parameters.Add(New SqlParameter("@Email", entity.Email))
        parameters.Add(New SqlParameter("@Telefono", entity.Telefono))
        parameters.Add(New SqlParameter("@FechaAlta", entity.fechaAlta))
        Return ExecuteNonQuery(insert)
    End Function

    Public Function Edit(entity As Proveedor) As Integer Implements IGenericRepository(Of Proveedor).Edit
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@ID_Proveedor", entity.ID_Proveedor))
        parameters.Add(New SqlParameter("@Nombre", entity.Nombre))
        parameters.Add(New SqlParameter("@Cuit", entity.Cuit))
        parameters.Add(New SqlParameter("@Email", entity.Email))
        parameters.Add(New SqlParameter("@Telefono", entity.Telefono))
        parameters.Add(New SqlParameter("@FechaAlta", entity.fechaAlta))
        Return ExecuteNonQuery(update)
    End Function

    Public Function Remove(id As Integer) As Integer Implements IGenericRepository(Of Proveedor).Remove
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@ID_Proveedor", id))
        Return ExecuteNonQuery(delete)
    End Function
End Class
