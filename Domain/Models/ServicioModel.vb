Imports DataAccess
Imports System.ComponentModel.DataAnnotations
Public Class ServicioModel
    Private _nroServicio As Integer
    Private _FK_Alquiler As Integer
    Private _Serial As String
    Private _Cliente As String
    Private _Fecha As Date
    Private _Observacion As String
    Private _State As EntityState

    Private Repository As IServicioRepository
    Private alquilerModel As AlquilerModel
    Private ListAlquilerViewModel As List(Of AlquilerModel)
    Private ListClienteViewModel As List(Of ClienteModel)
    Private ListServicioViewModel As List(Of ServicioModel)

#Region "Propiedades, modelos de vista y validacion de datos"
    Public Property NroServicio As Integer
        Get
            Return _nroServicio
        End Get
        Set(value As Integer)
            _nroServicio = value
        End Set
    End Property

    Public Property FK_Alquiler As Integer
        Private Get
            Return _FK_Alquiler
        End Get
        Set(value As Integer)
            _FK_Alquiler = value
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
    Public Property Serial As String
        Get
            Return _Serial
        End Get
        Set(value As String)
            _Serial = value
        End Set
    End Property
    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(value As Date)
            _Fecha = value
        End Set
    End Property

    Public Property Observacion As String
        Get
            Return _Observacion
        End Get
        Set(value As String)
            _Observacion = value
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

    ' CONTRUCTORES 
    Public Sub New()
        Repository = New ServicioRepository()
    End Sub
    'METODOS DEL OBJETO
    Public Function SaveChanges() As String
        Dim message As String = Nothing
        Try
            Dim servicoDataModel As New Servicio()

            servicoDataModel.nroServicio = NroServicio
            servicoDataModel.FK_Alquiler = FK_Alquiler
            servicoDataModel.Fecha = Fecha
            servicoDataModel.Observacion = Observacion

            Select Case State
                Case EntityState.Added
                    Repository.Add(servicoDataModel)
                    message = "Added"
                Case EntityState.Modified
                    Repository.Edit(servicoDataModel)
                    message = "Modified"
                Case EntityState.Deleted
                    Repository.Remove(NroServicio)
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
    Public Function GetServicios() As List(Of ServicioModel)
        Dim clienteModel = New ClienteModel()
        ListClienteViewModel = clienteModel.GetClientes()
        alquilerModel = New AlquilerModel()
        ListAlquilerViewModel = alquilerModel.GetAlquileres()



        Dim ListServicioDataModel = Repository.GetAll()
        ListServicioViewModel = New List(Of ServicioModel)

        For Each item As Servicio In ListServicioDataModel
            ListServicioViewModel.Add(New ServicioModel With {
            .NroServicio = item.nroServicio,
            .Cliente = FindCliente(item.FK_Alquiler),
            .Serial = FindSerial(item.FK_Alquiler),
            .Fecha = item.Fecha,
            .Observacion = item.Observacion
            })
        Next
        Return ListServicioViewModel
    End Function
#Region "Metodos del filtro"
    Public Function getServiciosByFecha(fI As Date, fF As Date) As List(Of ServicioModel)
        Dim ListServicioDataModel = Repository.GetByDate(fI, fF)
        ListServicioViewModel = New List(Of ServicioModel)

        For Each item As Servicio In ListServicioDataModel
            ListServicioViewModel.Add(New ServicioModel With {
            .NroServicio = item.nroServicio,
            .Cliente = FindCliente(item.FK_Alquiler),
            .Serial = FindSerial(item.FK_Alquiler),
            .Fecha = item.Fecha,
            .Observacion = item.Observacion
            })
        Next
        Return ListServicioViewModel
    End Function
#End Region
    Private Function FindCliente(i As Integer) As String
        Dim Cliente As String
        Dim id As Integer
        id = alquilerModel.findIdCliente(i)
        Cliente = ListClienteViewModel.Find(Function(emp) emp.ID_Cliente = id).Nombre
        Return Cliente
    End Function
    Private Function FindSerial(i As Integer) As String
        Dim Serial As String
        Serial = ListAlquilerViewModel.Find(Function(emp) emp.NroAlquiler = i).FK_Equipo
        Return Serial
    End Function
    Public Function Find(filter As String) As IEnumerable(Of ServicioModel)

        Return ListServicioViewModel.FindAll(Function(emp) emp.Cliente.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0 OrElse emp.Serial.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
    End Function
    Public Function GetLastServicio() As Integer
        Return Repository.LastServicio()
    End Function
    Public Function getAllForCmb() As DataTable
        Return Repository.GetAllForCmb()
    End Function
End Class
