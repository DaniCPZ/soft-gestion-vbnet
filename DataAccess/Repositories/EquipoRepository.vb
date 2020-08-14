Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess
Public Class EquipoRepository
    Inherits MasterRepository
    Implements IEquipoRepository

    Private selectAll As String
    Private selectForCmb As String
    Private insert As String
    Private update As String
    Private delete As String

    Public Sub New()
        selectAll = "select * from Equipo"
        selectForCmb = "select Serial,cantCopias from Equipo left join (select * from Alquiler where (Alquiler.fechaFinal >= CONVERT(date, GETDATE())) ) as C on Equipo.Serial = c.FK_Equipo where (c.FK_Equipo is null)"

        insert = "insert into Equipo values(@Serial,@Marca,@Modelo,@tipoImpresion,@Velocidad,@cantCopias)"
        update = "update Equipo set Marca=@Marca,Modelo=@Modelo,tipoImpresion=@tipoImpresion,Velocidad=@Velocidad,cantCopias=@cantCopias where Serial=@Serial"
        delete = "delete from Equipo where Serial=@Serial"
    End Sub

    Public Sub ClearListParameters() Implements IEquipoRepository.ClearListParameters
        LimpiarParametros()
    End Sub

    Public Function GetAll() As IEnumerable(Of Equipo) Implements IEquipoRepository.GetAll
        Dim resultTable = ExecuteReader(selectAll)
        Dim listEquipos = New List(Of Equipo)
        For Each item As DataRow In resultTable.Rows
            listEquipos.Add(New Equipo With {
                .Serial = item(0),
                .Marca = item(1),
                .Modelo = item(2),
                .tipoImpresion = item(3),
                .Velocidad = item(4),
                .cantCopias = item(5)
            })
        Next
        Return listEquipos
    End Function

    Public Function Add(entity As Equipo) As Integer Implements IEquipoRepository.Add
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@Serial", entity.Serial))
        parameters.Add(New SqlParameter("@Marca", entity.Marca))
        parameters.Add(New SqlParameter("@Modelo", entity.Modelo))
        parameters.Add(New SqlParameter("@tipoImpresion", entity.tipoImpresion))
        parameters.Add(New SqlParameter("@Velocidad", entity.Velocidad))
        parameters.Add(New SqlParameter("@cantCopias", entity.cantCopias))
        Return ExecuteNonQuery(insert)
    End Function

    Public Function Edit(entity As Equipo) As Integer Implements IEquipoRepository.Edit
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@Serial", entity.Serial))
        parameters.Add(New SqlParameter("@Marca", entity.Marca))
        parameters.Add(New SqlParameter("@Modelo", entity.Modelo))
        parameters.Add(New SqlParameter("@tipoImpresion", entity.tipoImpresion))
        parameters.Add(New SqlParameter("@Velocidad", entity.Velocidad))
        parameters.Add(New SqlParameter("@cantCopias", entity.cantCopias))
        Return ExecuteNonQuery(update)
    End Function

    Public Function Remove(Serial As String) As Integer Implements IEquipoRepository.Remove
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@Serial", Serial))
        Return ExecuteNonQuery(delete)
    End Function

    Public Function GetAllForCmb() As DataTable Implements IEquipoRepository.GetAllForCmb
        Return ExecuteReader(selectForCmb)
    End Function

End Class
