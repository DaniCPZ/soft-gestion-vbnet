Imports DataAccess
Imports System.ComponentModel.DataAnnotations
Public Class ContadorModel
    ' ATRIBUTOS - CAMPOS
    Private _nroContador As Integer
    Private _nroAlquiler As Integer
    Private _Serial As String
    Private _Cliente As String
    Private _fecha As Date
    Private _cantCopias As Integer
    Private _State As EntityState

    Private ListContadorViewModel As List(Of ContadorModel)
    Private ListAlquileViewModel As List(Of AlquilerModel)
    Private ListeClienteViewModel As List(Of ClienteModel)
    Private Repository As IContadorRepository

#Region "Propiedades, modelos de vista y validacion de datos"
    Public Property NroContador As Integer
        Get
            Return _nroContador
        End Get
        Set(value As Integer)
            _nroContador = value
        End Set
    End Property

    Public Property nroAlquiler As Integer
        Get
            Return _nroAlquiler
        End Get
        Set(value As Integer)
            _nroAlquiler = value
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


    Public Property CantCopias As Integer
        Get
            Return _cantCopias
        End Get
        Set(value As Integer)
            _cantCopias = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
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
        Repository = New ContadorRepository()
    End Sub

    Public Function SaveChanges() As String
        Dim message As String = Nothing
        Try
            Dim contadorDataModel As New Contador()
            contadorDataModel.nroContador = NroContador
            contadorDataModel.FK_Alquiler = nroAlquiler
            contadorDataModel.fecha = Fecha
            contadorDataModel.cantCopias = CantCopias

            Select Case State
                Case EntityState.Added
                    Repository.Add(contadorDataModel)
                    message = "Success Added"
                Case EntityState.Modified
                    Repository.Edit(contadorDataModel)
                    message = "Success Modified"
                Case EntityState.Deleted
                    Repository.Remove(NroContador)
                    message = "Success Remove"
            End Select
        Catch ex As Exception
            ' Repository.clear()
            Dim sqlEx As System.Data.SqlClient.SqlException = TryCast(ex, System.Data.SqlClient.SqlException)
            If sqlEx IsNot Nothing AndAlso sqlEx.Number = 2627 Then
                message = "Registro duplicado"
            ElseIf sqlEx.Number = 547 Then
                message = "Registro con informacion relacionada"
            Else
                message = ex.ToString
            End If
        End Try
        Return message
    End Function

    Public Function GetContadores() As List(Of ContadorModel)
        'Alquileres para la parte visual
        Dim alquilerModel = New AlquilerModel()
        ListAlquileViewModel = alquilerModel.GetAlquileres
        ''Clientes para la parte visual
        'Dim clienteModel = New ClienteModel()
        'ListeClienteViewModel = clienteModel.GetClientes

        Dim ListContadorDataModel = Repository.GetAll()
        ListContadorViewModel = New List(Of ContadorModel)

        For Each item As Contador In ListContadorDataModel
            ListContadorViewModel.Add(New ContadorModel With {
            .NroContador = item.nroContador,
            .nroAlquiler = item.FK_Alquiler,
            .Serial = FindSerial(item.FK_Alquiler),
            .Cliente = FindCliente(item.FK_Alquiler),
            .CantCopias = item.cantCopias,
            .Fecha = item.fecha
            })
        Next
        Return ListContadorViewModel
    End Function
    Public Function LastContador(i As Integer) As Integer
        Return Repository.GetContadorForAlquiler(i)
    End Function
    Private Function FindSerial(i As Integer) As String
        ' Return ListLocalidadViewModel.Find(Function(emp) emp.CodigoPostal = i).Nombre
        Return ListAlquileViewModel.Find(Function(emp) emp.NroAlquiler = i).FK_Equipo
    End Function
    Private Function FindCliente(i As Integer) As String
        Return ListAlquileViewModel.Find(Function(emp) emp.NroAlquiler = i).Cliente
    End Function
End Class
