Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess
Public Class AlquilerRepository
    Inherits MasterRepository
    Implements IAlquilerRepository

    Private selectAll As String
    Private selectForCmbByCliente As String
    Private selectForDgvByCliente As String
    'consulta para contador
    Private selectAllContador As String
    'consultas para el filtro
    Private selectEnCurso As String
    Private selectVencido As String
    Private selectFi As String
    Private selectFf As String
    'consultas para el filtro combinadas
    Private selectFiVencido As String
    Private selectFiEnCurso As String
    Private selectFfVencido As String
    Private selectFfEnCurso As String


    Private insert As String
    Private update As String
    Private delete As String

    Public Sub New()
        selectAll = "select * from Alquiler ORDER BY nroAlquiler DESC"
        selectAllContador = "select nroAlquiler, (Nombre +'-'+ FK_Equipo) as Datos from(select * from Alquiler inner join Cliente on Alquiler.FK_Cliente=Cliente.ID_Cliente)as a where a.fechaFinal >= CONVERT(date, GETDATE())"
        '---- parte cobrar alquiler de la ventana de clientes, trea el alquiler mas el equipo alquilado
        selectForDgvByCliente = "select a.nroAlquiler,a.Equipo,a.AlquilerMinimo from equipo inner join (select nroAlquiler,FK_Equipo as Equipo,minAlquiler as AlquilerMinimo from Alquiler where FK_Cliente=@FK_Cliente and Alquiler.fechaFinal >= CONVERT(date, GETDATE()) ) as a on Equipo.Serial = a.Equipo"
        '----  equipos en alquiler de un cliente 
        selectForCmbByCliente = "select nroAlquiler,FK_Equipo as Equipo,minAlquiler as AlquilerMinimo from Alquiler where FK_Cliente=@FK_Cliente and Alquiler.fechaFinal >= CONVERT(date, GETDATE())"

        'consultas para el filtro
        selectEnCurso = "select * from Alquiler where Alquiler.fechaFinal >= CONVERT(date, GETDATE())"
        selectVencido = "select * from Alquiler where not Alquiler.fechaFinal >= CONVERT(date, GETDATE())"
        selectFi = "select * from Alquiler where fechaInicio between @fromDate and @toDate"
        selectFf = "select * from Alquiler where fechaFinal between @fromDate and @toDate"
        'consultas para el filtro combinadas
        selectFiVencido = "select * from Alquiler where not fechaFinal >= CONVERT(date, GETDATE()) and fechaInicio between  @fromDate and @toDate"
        selectFiEnCurso = "select * from Alquiler where fechaFinal >= CONVERT(date, GETDATE()) and fechaInicio between  @fromDate and @toDate "
        selectFfVencido = "select * from Alquiler where not fechaFinal >= CONVERT(date, GETDATE()) and fechaFinal between  @fromDate and @toDate"
        selectFfEnCurso = "select * from Alquiler where fechaFinal >= CONVERT(date, GETDATE()) and fechaFinal between  @fromDate and @toDate "

        insert = "insert into Alquiler values(@FK_Cliente,@FK_Equipo,@fechaInicio,@fechaFinal,@minAlquiler)"
        update = "update Alquiler set FK_Cliente=@FK_Cliente,FK_Equipo=@FK_Equipo,fechaFinal=@fechaFinal,minAlquiler=@minAlquiler where nroAlquiler=@nroAlquiler"
        delete = "delete from Alquiler where nroAlquiler=@nroAlquiler"
    End Sub
    Public Function GetAll() As IEnumerable(Of Alquiler) Implements IGenericRepository(Of Alquiler).GetAll
        Dim resultTable = ExecuteReader(selectAll)
        Dim listAlquiler = New List(Of Alquiler)
        For Each item As DataRow In resultTable.Rows
            listAlquiler.Add(New Alquiler With {
                .nroAlquiler = item(0),
                .FK_Cliente = item(1),
                .FK_Equipo = item(2),
                .fechaInicio = item(3),
                .fechaFinal = item(4),
                .minAlquiler = item(5)
            })
        Next
        Return listAlquiler
    End Function

    Public Function Add(entity As Alquiler) As Integer Implements IGenericRepository(Of Alquiler).Add
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@FK_Cliente", entity.FK_Cliente))
        parameters.Add(New SqlParameter("@FK_Equipo", entity.FK_Equipo))
        parameters.Add(New SqlParameter("@fechaInicio", entity.fechaInicio))
        parameters.Add(New SqlParameter("@fechaFinal", entity.fechaFinal))
        parameters.Add(New SqlParameter("@minAlquiler", entity.minAlquiler))
        Return ExecuteNonQuery(insert)
    End Function

    Public Function Edit(entity As Alquiler) As Integer Implements IGenericRepository(Of Alquiler).Edit
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@nroAlquiler", entity.nroAlquiler))
        parameters.Add(New SqlParameter("@FK_Cliente", entity.FK_Cliente))
        parameters.Add(New SqlParameter("@FK_Equipo", entity.FK_Equipo))
        parameters.Add(New SqlParameter("@fechaFinal", entity.fechaFinal))
        parameters.Add(New SqlParameter("@minAlquiler", entity.minAlquiler))
        Return ExecuteNonQuery(update)
    End Function

    Public Function Remove(id As Integer) As Integer Implements IGenericRepository(Of Alquiler).Remove
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@nroAlquiler", id))
        Return ExecuteNonQuery(delete)
    End Function

    Public Function GetAllForCmbByCliente(id As Integer) As DataTable Implements IAlquilerRepository.GetAllForCmbByCliente
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@FK_Cliente", id))
        Return ExecuteReader(selectForCmbByCliente)
    End Function

    Public Function GetAllForDgvByCliente(id As Integer) As DataTable Implements IAlquilerRepository.GetAllForDgvByCliente
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@FK_Cliente", id))
        Return ExecuteReader(selectForDgvByCliente)
    End Function

    Public Function GetAllActivos() As IEnumerable(Of Alquiler) Implements IAlquilerRepository.GetAllActivos
        Dim resultTable = ExecuteReader(selectEnCurso)
        Dim listAlquiler = New List(Of Alquiler)
        For Each item As DataRow In resultTable.Rows
            listAlquiler.Add(New Alquiler With {
                .nroAlquiler = item(0),
                .FK_Cliente = item(1),
                .FK_Equipo = item(2),
                .fechaInicio = item(3),
                .fechaFinal = item(4),
                .minAlquiler = item(5)
            })
        Next
        Return listAlquiler
    End Function

    Public Function GetAllVencidos() As IEnumerable(Of Alquiler) Implements IAlquilerRepository.GetAllVencidos
        Dim resultTable = ExecuteReader(selectVencido)
        Dim listAlquiler = New List(Of Alquiler)
        For Each item As DataRow In resultTable.Rows
            listAlquiler.Add(New Alquiler With {
                .nroAlquiler = item(0),
                .FK_Cliente = item(1),
                .FK_Equipo = item(2),
                .fechaInicio = item(3),
                .fechaFinal = item(4),
                .minAlquiler = item(5)
            })
        Next
        Return listAlquiler
    End Function

    Public Function GetAllByFechaInicio(fromDate As Date, toDate As Date) As IEnumerable(Of Alquiler) Implements IAlquilerRepository.GetAllByFechaInicio
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@fromDate", fromDate))
        parameters.Add(New SqlParameter("@toDate", toDate))
        Dim resultTable = ExecuteReader(selectFi)
        Dim listAlquiler = New List(Of Alquiler)
        For Each item As DataRow In resultTable.Rows
            listAlquiler.Add(New Alquiler With {
                .nroAlquiler = item(0),
                .FK_Cliente = item(1),
                .FK_Equipo = item(2),
                .fechaInicio = item(3),
                .fechaFinal = item(4),
                .minAlquiler = item(5)
            })
        Next
        Return listAlquiler
    End Function

    Public Function GetAllByFechaFinal(fromDate As Date, toDate As Date) As IEnumerable(Of Alquiler) Implements IAlquilerRepository.GetAllByFechaFinal
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@fromDate", fromDate))
        parameters.Add(New SqlParameter("@toDate", toDate))
        Dim resultTable = ExecuteReader(selectFf)
        Dim listAlquiler = New List(Of Alquiler)
        For Each item As DataRow In resultTable.Rows
            listAlquiler.Add(New Alquiler With {
                .nroAlquiler = item(0),
                .FK_Cliente = item(1),
                .FK_Equipo = item(2),
                .fechaInicio = item(3),
                .fechaFinal = item(4),
                .minAlquiler = item(5)
            })
        Next
        Return listAlquiler
    End Function
    Public Function GetAllActivosAndFf(fromDate As Date, toDate As Date) As IEnumerable(Of Alquiler) Implements IAlquilerRepository.GetAllActivosAndFf
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@fromDate", fromDate))
        parameters.Add(New SqlParameter("@toDate", toDate))
        Dim resultTable = ExecuteReader(selectFfEnCurso)
        Dim listAlquiler = New List(Of Alquiler)
        For Each item As DataRow In resultTable.Rows
            listAlquiler.Add(New Alquiler With {
                .nroAlquiler = item(0),
                .FK_Cliente = item(1),
                .FK_Equipo = item(2),
                .fechaInicio = item(3),
                .fechaFinal = item(4),
                .minAlquiler = item(5)
            })
        Next
        Return listAlquiler
    End Function

    Public Function GetAllVencidosAndFf(fromDate As Date, toDate As Date) As IEnumerable(Of Alquiler) Implements IAlquilerRepository.GetAllVencidosAndFf
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@fromDate", fromDate))
        parameters.Add(New SqlParameter("@toDate", toDate))
        Dim resultTable = ExecuteReader(selectFfVencido)
        Dim listAlquiler = New List(Of Alquiler)
        For Each item As DataRow In resultTable.Rows
            listAlquiler.Add(New Alquiler With {
                .nroAlquiler = item(0),
                .FK_Cliente = item(1),
                .FK_Equipo = item(2),
                .fechaInicio = item(3),
                .fechaFinal = item(4),
                .minAlquiler = item(5)
            })
        Next
        Return listAlquiler
    End Function

    Public Function GetAllActivosAndFi(fromDate As Date, toDate As Date) As IEnumerable(Of Alquiler) Implements IAlquilerRepository.GetAllActivosAndFi
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@fromDate", fromDate))
        parameters.Add(New SqlParameter("@toDate", toDate))
        Dim resultTable = ExecuteReader(selectFiEnCurso)
        Dim listAlquiler = New List(Of Alquiler)
        For Each item As DataRow In resultTable.Rows
            listAlquiler.Add(New Alquiler With {
                .nroAlquiler = item(0),
                .FK_Cliente = item(1),
                .FK_Equipo = item(2),
                .fechaInicio = item(3),
                .fechaFinal = item(4),
                .minAlquiler = item(5)
            })
        Next
        Return listAlquiler
    End Function

    Public Function GetAllVencidosAndFi(fromDate As Date, toDate As Date) As IEnumerable(Of Alquiler) Implements IAlquilerRepository.GetAllVencidosAndFi
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@fromDate", fromDate))
        parameters.Add(New SqlParameter("@toDate", toDate))
        Dim resultTable = ExecuteReader(selectFiVencido)
        Dim listAlquiler = New List(Of Alquiler)
        For Each item As DataRow In resultTable.Rows
            listAlquiler.Add(New Alquiler With {
                .nroAlquiler = item(0),
                .FK_Cliente = item(1),
                .FK_Equipo = item(2),
                .fechaInicio = item(3),
                .fechaFinal = item(4),
                .minAlquiler = item(5)
            })
        Next
        Return listAlquiler
    End Function

    Public Function GetAllForContador() As DataTable Implements IAlquilerRepository.GetAllForContador
        Return ExecuteReader(selectAllContador)
    End Function
End Class
