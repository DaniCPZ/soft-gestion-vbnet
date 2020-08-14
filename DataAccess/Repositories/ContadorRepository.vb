Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess
Public Class ContadorRepository
    Inherits MasterRepository
    Implements IContadorRepository

    Private selectAll As String
    Private selectLast As String
    Private insert As String
    Private update As String
    Private delete As String

    Public Sub New()
        selectAll = "select * from Contador"
        selectLast = "select top 1 * from Contador where FK_Alquiler=@FK_Alquiler order by nroContador desc"
        insert = "insert into Contador values(@FK_Alquiler,@fecha,@cantCopias)"
        update = "update Contador set FK_Alquiler=@FK_Alquiler,fecha=@fecha,cantCopias=@cantCopias where nroContador=@nroContador"
        delete = "delete from Contador where nroContador=@nroContador"
    End Sub

    Public Function GetAll() As IEnumerable(Of Contador) Implements IGenericRepository(Of Contador).GetAll
        Dim resultTable = ExecuteReader(selectAll)
        Dim listContador = New List(Of Contador)
        For Each item As DataRow In resultTable.Rows
            listContador.Add(New Contador With {
                .nroContador = item(0),
                .FK_Alquiler = item(1),
                .fecha = item(2),
                .cantCopias = item(3)
            })
        Next
        Return listContador
        Throw New NotImplementedException()
    End Function

    Public Function Add(entity As Contador) As Integer Implements IGenericRepository(Of Contador).Add
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@FK_Alquiler", entity.FK_Alquiler))
        parameters.Add(New SqlParameter("@fecha", entity.fecha))
        parameters.Add(New SqlParameter("@cantCopias", entity.cantCopias))
        Return ExecuteNonQuery(insert)
    End Function

    Public Function Edit(entity As Contador) As Integer Implements IGenericRepository(Of Contador).Edit
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@nroContador", entity.nroContador))
        parameters.Add(New SqlParameter("@FK_Alquiler", entity.FK_Alquiler))
        parameters.Add(New SqlParameter("@fecha", entity.fecha))
        parameters.Add(New SqlParameter("@cantCopias", entity.cantCopias))
        Return ExecuteNonQuery(update)
    End Function

    Public Function Remove(id As Integer) As Integer Implements IGenericRepository(Of Contador).Remove
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@nroContador", id))
        Return ExecuteNonQuery(delete)
    End Function

    Public Function GetContadorForAlquiler(id As Integer) As Integer Implements IContadorRepository.GetContadorForAlquiler
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@FK_Alquiler", id))
        Dim resultTable = ExecuteReader(selectLast)
        Return resultTable.Rows(0).Item(3)
    End Function
End Class
