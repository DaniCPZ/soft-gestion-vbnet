Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess
Public Class LocalidadRepository
    Inherits MasterRepository
    Implements ILocalidadRepository

    Private selectAll As String
    Private selectallOrderByNombre As String
    Private insert As String
    Private update As String
    Private delete As String

    Public Sub New()
        selectAll = "select * from Localidad"
        selectallOrderByNombre = "select * from Localidad order by Nombre asc"
        insert = "insert into Localidad values(@CodigoPostal,@Nombre,@Observacion)"
        update = "update Localidad set Nombre=@Nombre,Observacion=@Observacion where CodigoPostal=@CodigoPostal"
        delete = "delete from Localidad where CodigoPostal=@CodigoPostal"
    End Sub

    Public Sub ClearListParameters() Implements ILocalidadRepository.ClearListParameters
        LimpiarParametros()
    End Sub

    Public Function GetAll() As IEnumerable(Of Localidad) Implements IGenericRepository(Of Localidad).GetAll
        Dim resultTable = ExecuteReader(selectAll)
        Dim listLocalidad = New List(Of Localidad)
        For Each item As DataRow In resultTable.Rows
            listLocalidad.Add(New Localidad With {
                .codigoPostal = item(0),
                .Nombre = item(1),
                .Observacion = item(2)
            })
        Next
        Return listLocalidad
    End Function
    Public Function GetAllOrderByNombre() As DataTable Implements ILocalidadRepository.GetAllOrderByNombre
        Return ExecuteReader(selectallOrderByNombre)
    End Function
    Public Function Add(entity As Localidad) As Integer Implements IGenericRepository(Of Localidad).Add
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@CodigoPostal", entity.codigoPostal))
        parameters.Add(New SqlParameter("@Nombre", entity.Nombre))
        parameters.Add(New SqlParameter("@Observacion", entity.Observacion))
        Return ExecuteNonQuery(insert)
    End Function

    Public Function Edit(entity As Localidad) As Integer Implements IGenericRepository(Of Localidad).Edit
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@CodigoPostal", entity.codigoPostal))
        parameters.Add(New SqlParameter("@Nombre", entity.Nombre))
        parameters.Add(New SqlParameter("@Observacion", entity.Observacion))
        Return ExecuteNonQuery(update)
    End Function

    Public Function Remove(id As Integer) As Integer Implements IGenericRepository(Of Localidad).Remove
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@CodigoPostal", id))
        Return ExecuteNonQuery(delete)
    End Function


End Class
