Imports DataAccess
Imports System.ComponentModel.DataAnnotations
Public Class AlquilerModel
    Private _nroAlquiler As Integer
    Private _Cliente As String
    Private _FK_Cliente As Integer
    Private _FK_Equipo As String
    Private _fechaInicio As Date
    Private _fechaFinal As Date
    Private _minAlquiler As Integer
    Private _State As EntityState

    Private Repository As IAlquilerRepository
    Private ListAlquilerViewModel As List(Of AlquilerModel)
    Private ListClienteViewModel As List(Of ClienteModel)

#Region "Propiedades, modelos de vista y validacion de datos"
    Public Property NroAlquiler As Integer
        Get
            Return _nroAlquiler
        End Get
        Set(value As Integer)
            _nroAlquiler = value
        End Set
    End Property
    <Required>
    Public Property FK_Cliente As Integer
        Private Get
            Return _FK_Cliente
        End Get
        Set(value As Integer)
            _FK_Cliente = value
        End Set
    End Property
    Public Property Cliente As String
        Get
            Return _Cliente
        End Get
        Set(value As String)
            _Cliente = value
        End Set
    End Property

    <Required>
    Public Property FK_Equipo As String
        Get
            Return _FK_Equipo
        End Get
        Set(value As String)
            _FK_Equipo = value
        End Set
    End Property

    Public Property FechaInicio As Date
        Get
            Return _fechaInicio
        End Get
        Set(value As Date)
            _fechaInicio = value
        End Set
    End Property

    Public Property FechaFinal As Date
        Get
            Return _fechaFinal
        End Get
        Set(value As Date)
            _fechaFinal = value
        End Set
    End Property

    Public Property MinAlquiler As Integer
        Get
            Return _minAlquiler
        End Get
        Set(value As Integer)
            _minAlquiler = value
        End Set
    End Property

    Public Property State As EntityState
        Private Get
            Return _State
        End Get
        Set(value As EntityState)
            _State = value
        End Set
    End Property


#End Region

    Public Sub New()
        Repository = New AlquilerRepository()
    End Sub

    Public Function SaveChanges() As String
        Dim message As String = Nothing
        Try
            Dim alquilerDataModel As New Alquiler()
            alquilerDataModel.nroAlquiler = NroAlquiler
            alquilerDataModel.FK_Cliente = FK_Cliente
            alquilerDataModel.FK_Equipo = FK_Equipo
            alquilerDataModel.fechaInicio = FechaInicio
            alquilerDataModel.fechaFinal = FechaFinal
            alquilerDataModel.minAlquiler = MinAlquiler

            Select Case State
                Case EntityState.Added
                    Repository.Add(alquilerDataModel)
                    message = "Added"
                Case EntityState.Modified
                    Repository.Edit(alquilerDataModel)
                    message = "Modified"
                Case EntityState.Deleted
                    Repository.Remove(NroAlquiler)
                    message = "Remove"
            End Select
        Catch ex As Exception
            Dim sqlEx As System.Data.SqlClient.SqlException = TryCast(ex, System.Data.SqlClient.SqlException)
            If sqlEx IsNot Nothing AndAlso sqlEx.Number = 2627 Then
                message = "Duplicate record"
            ElseIf sqlEx.Number = 547 Then
                message = "Registro con informacion relacionada"
            Else
                message = ex.ToString
            End If
        End Try
        Return message
    End Function
    Public Function GetAlquileres() As List(Of AlquilerModel)
        Dim clienteModel = New ClienteModel()
        ListClienteViewModel = clienteModel.GetClientes()

        Dim ListAlquilerDataModel = Repository.GetAll()
        ListAlquilerViewModel = New List(Of AlquilerModel)
        For Each item As Alquiler In ListAlquilerDataModel
            ListAlquilerViewModel.Add(New AlquilerModel With {
            .NroAlquiler = item.nroAlquiler,
            .FK_Cliente = item.FK_Cliente,
            .Cliente = FindCliente(item.FK_Cliente),
            .FK_Equipo = item.FK_Equipo,
            .FechaInicio = item.fechaInicio,
            .FechaFinal = item.fechaFinal,
            .MinAlquiler = item.minAlquiler
            })
        Next
        Return ListAlquilerViewModel
    End Function
    Public Function FindbyNombre(filter As String) As IEnumerable(Of AlquilerModel)
        'Mi_Cadena.Equals(Parametro, StringComparison.InvariantCultureIgnoreCase)
        Return ListAlquilerViewModel.FindAll(Function(emp) emp.Cliente.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
    End Function

#Region "Metodos del filtro"
    ' --- Alquileres activos para el filtro
    Public Function GetAlquileresActivos() As List(Of AlquilerModel)
        Dim clienteModel = New ClienteModel()
        ListClienteViewModel = clienteModel.GetClientes()

        Dim ListAlquilerDataModel = Repository.GetAllActivos()
        ListAlquilerViewModel = New List(Of AlquilerModel)
        For Each item As Alquiler In ListAlquilerDataModel
            ListAlquilerViewModel.Add(New AlquilerModel With {
            .NroAlquiler = item.nroAlquiler,
            .Cliente = FindCliente(item.FK_Cliente),
            .FK_Equipo = item.FK_Equipo,
            .FechaInicio = item.fechaInicio,
            .FechaFinal = item.fechaFinal,
            .MinAlquiler = item.minAlquiler
            })
        Next
        Return ListAlquilerViewModel
    End Function

    ' --- Alquileres activos para el filtro
    Public Function GetAlquileresVencidos() As List(Of AlquilerModel)
        Dim clienteModel = New ClienteModel()
        ListClienteViewModel = clienteModel.GetClientes()

        Dim ListAlquilerDataModel = Repository.GetAllVencidos()
        ListAlquilerViewModel = New List(Of AlquilerModel)
        For Each item As Alquiler In ListAlquilerDataModel
            ListAlquilerViewModel.Add(New AlquilerModel With {
            .NroAlquiler = item.nroAlquiler,
            .Cliente = FindCliente(item.FK_Cliente),
            .FK_Equipo = item.FK_Equipo,
            .FechaInicio = item.fechaInicio,
            .FechaFinal = item.fechaFinal,
            .MinAlquiler = item.minAlquiler
            })
        Next
        Return ListAlquilerViewModel
    End Function
    ' --- Alquileres activos para el filtro
    Public Function GetAllActivosAndFf(fromDate As Date, toDate As Date) As List(Of AlquilerModel)
        Dim clienteModel = New ClienteModel()
        ListClienteViewModel = clienteModel.GetClientes()

        Dim ListAlquilerDataModel = Repository.GetAllActivosAndFf(fromDate, toDate)
        ListAlquilerViewModel = New List(Of AlquilerModel)
        For Each item As Alquiler In ListAlquilerDataModel
            ListAlquilerViewModel.Add(New AlquilerModel With {
            .NroAlquiler = item.nroAlquiler,
            .Cliente = FindCliente(item.FK_Cliente),
            .FK_Equipo = item.FK_Equipo,
            .FechaInicio = item.fechaInicio,
            .FechaFinal = item.fechaFinal,
            .MinAlquiler = item.minAlquiler
            })
        Next
        Return ListAlquilerViewModel
    End Function
    ' --- Alquileres activos para el filtro
    Public Function GetAllActivosAndFi(fromDate As Date, toDate As Date) As List(Of AlquilerModel)
        Dim clienteModel = New ClienteModel()
        ListClienteViewModel = clienteModel.GetClientes()

        Dim ListAlquilerDataModel = Repository.GetAllActivosAndFi(fromDate, toDate)
        ListAlquilerViewModel = New List(Of AlquilerModel)
        For Each item As Alquiler In ListAlquilerDataModel
            ListAlquilerViewModel.Add(New AlquilerModel With {
            .NroAlquiler = item.nroAlquiler,
            .Cliente = FindCliente(item.FK_Cliente),
            .FK_Equipo = item.FK_Equipo,
            .FechaInicio = item.fechaInicio,
            .FechaFinal = item.fechaFinal,
            .MinAlquiler = item.minAlquiler
            })
        Next
        Return ListAlquilerViewModel
    End Function
    ' --- Alquileres activos para el filtro
    Public Function GetAllVencidosAndFf(fromDate As Date, toDate As Date) As List(Of AlquilerModel)
        Dim clienteModel = New ClienteModel()
        ListClienteViewModel = clienteModel.GetClientes()

        Dim ListAlquilerDataModel = Repository.GetAllVencidosAndFf(fromDate, toDate)
        ListAlquilerViewModel = New List(Of AlquilerModel)
        For Each item As Alquiler In ListAlquilerDataModel
            ListAlquilerViewModel.Add(New AlquilerModel With {
            .NroAlquiler = item.nroAlquiler,
            .Cliente = FindCliente(item.FK_Cliente),
            .FK_Equipo = item.FK_Equipo,
            .FechaInicio = item.fechaInicio,
            .FechaFinal = item.fechaFinal,
            .MinAlquiler = item.minAlquiler
            })
        Next
        Return ListAlquilerViewModel
    End Function
    ' --- Alquileres activos para el filtro
    Public Function GetAllVencidosAndFi(fromDate As Date, toDate As Date) As List(Of AlquilerModel)
        Dim clienteModel = New ClienteModel()
        ListClienteViewModel = clienteModel.GetClientes()

        Dim ListAlquilerDataModel = Repository.GetAllVencidosAndFi(fromDate, toDate)
        ListAlquilerViewModel = New List(Of AlquilerModel)
        For Each item As Alquiler In ListAlquilerDataModel
            ListAlquilerViewModel.Add(New AlquilerModel With {
            .NroAlquiler = item.nroAlquiler,
            .Cliente = FindCliente(item.FK_Cliente),
            .FK_Equipo = item.FK_Equipo,
            .FechaInicio = item.fechaInicio,
            .FechaFinal = item.fechaFinal,
            .MinAlquiler = item.minAlquiler
            })
        Next
        Return ListAlquilerViewModel
    End Function
    ' --- Alquileres activos para el filtro
    Public Function GetAllByFechaFinal(fromDate As Date, toDate As Date) As List(Of AlquilerModel)
        Dim clienteModel = New ClienteModel()
        ListClienteViewModel = clienteModel.GetClientes()

        Dim ListAlquilerDataModel = Repository.GetAllByFechaFinal(fromDate, toDate)
        ListAlquilerViewModel = New List(Of AlquilerModel)
        For Each item As Alquiler In ListAlquilerDataModel
            ListAlquilerViewModel.Add(New AlquilerModel With {
            .NroAlquiler = item.nroAlquiler,
            .Cliente = FindCliente(item.FK_Cliente),
            .FK_Equipo = item.FK_Equipo,
            .FechaInicio = item.fechaInicio,
            .FechaFinal = item.fechaFinal,
            .MinAlquiler = item.minAlquiler
            })
        Next
        Return ListAlquilerViewModel
    End Function
    ' --- Alquileres activos para el filtro
    Public Function GetAllByFechaInicio(fromDate As Date, toDate As Date) As List(Of AlquilerModel)
        Dim clienteModel = New ClienteModel()
        ListClienteViewModel = clienteModel.GetClientes()

        Dim ListAlquilerDataModel = Repository.GetAllByFechaInicio(fromDate, toDate)
        ListAlquilerViewModel = New List(Of AlquilerModel)
        For Each item As Alquiler In ListAlquilerDataModel
            ListAlquilerViewModel.Add(New AlquilerModel With {
            .NroAlquiler = item.nroAlquiler,
            .Cliente = FindCliente(item.FK_Cliente),
            .FK_Equipo = item.FK_Equipo,
            .FechaInicio = item.fechaInicio,
            .FechaFinal = item.fechaFinal,
            .MinAlquiler = item.minAlquiler
            })
        Next
        Return ListAlquilerViewModel
    End Function
#End Region
    Public Function GetAllForContador() As DataTable
        Return Repository.GetAllForContador()
    End Function
    Public Function GetAlquileresForCmbByCliente(id As Integer) As DataTable
        Return Repository.GetAllForCmbByCliente(id)
    End Function
    Public Function GetAlquileresForDgvByCliente(id As Integer) As DataTable
        Return Repository.GetAllForDgvByCliente(id)
    End Function
    Private Function FindCliente(i As Integer) As String
        Dim Cliente As String
        Cliente = ListClienteViewModel.Find(Function(emp) emp.ID_Cliente = i).Nombre
        Return Cliente
    End Function
    Public Function findIdCliente(nroAlquiler As Integer) As Integer
        Dim idCliente As Integer
        idCliente = ListAlquilerViewModel.Find(Function(emp) emp.NroAlquiler = nroAlquiler).FK_Cliente
        Return idCliente
    End Function
End Class
