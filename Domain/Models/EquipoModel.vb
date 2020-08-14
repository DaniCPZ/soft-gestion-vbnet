Imports DataAccess
Imports System.ComponentModel.DataAnnotations
Public Class EquipoModel
    ' ATRIBUTOS - CAMPOS
    Private _Serial As String
    Private _Marca As String
    Private _Modelo As String
    Private _tipoImpresion As String
    Private _Velocidad As String
    Private _cantCopias As Integer
    Private _State As EntityState

    Private Repository As IEquipoRepository
    Private ListEquipoViewModel As List(Of EquipoModel)

#Region "Propiedades, modelos de vista y validacion de datos"

    <Required>
    Public Property Serial As String
        Get
            Return _Serial
        End Get
        Set(value As String)
            _Serial = value
        End Set
    End Property

    <Required>
    Public Property Marca As String
        Get
            Return _Marca
        End Get
        Set(value As String)
            _Marca = value
        End Set
    End Property

    <Required>
    Public Property Modelo As String
        Get
            Return _Modelo
        End Get
        Set(value As String)
            _Modelo = value
        End Set
    End Property

    <Required>
    Public Property TipoImpresion As String
        Get
            Return _tipoImpresion
        End Get
        Set(value As String)
            _tipoImpresion = value
        End Set
    End Property

    <Required>
    Public Property Velocidad As String
        Get
            Return _Velocidad
        End Get
        Set(value As String)
            _Velocidad = value
        End Set
    End Property

    <Required>
    Public Property CantCopias As Integer
        Get
            Return _cantCopias
        End Get
        Set(value As Integer)
            _cantCopias = value
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
        Repository = New EquipoRepository()
    End Sub

    'METODOS DEL OBJETO

    Public Function SaveChanges() As String
        Dim message As String = Nothing
        Try
            Dim equipoDataModel As New Equipo()

            equipoDataModel.Serial = Serial
            equipoDataModel.Marca = Marca
            equipoDataModel.Modelo = Modelo
            equipoDataModel.tipoImpresion = TipoImpresion
            equipoDataModel.Velocidad = Velocidad
            equipoDataModel.cantCopias = CantCopias
            Select Case State
                Case EntityState.Added
                    Repository.Add(equipoDataModel)
                    message = "Added"
                Case EntityState.Modified
                    Repository.Edit(equipoDataModel)
                    message = "Modified"
                Case EntityState.Deleted
                    Repository.Remove(Serial)
                    message = "Remove"
            End Select
        Catch ex As Exception
            Repository.ClearListParameters()
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
    Public Function GetEquipos() As List(Of EquipoModel)
        Dim ListEquipoDataModel = Repository.GetAll()
        ListEquipoViewModel = New List(Of EquipoModel)

        For Each item As Equipo In ListEquipoDataModel
            ListEquipoViewModel.Add(New EquipoModel With {
            .Serial = item.Serial,
            .Marca = item.Marca,
            .Modelo = item.Modelo,
            .TipoImpresion = item.tipoImpresion,
            .Velocidad = item.Velocidad,
            .CantCopias = item.cantCopias
            })
        Next
        Return ListEquipoViewModel
    End Function
    Public Function Find(filter As String) As IEnumerable(Of EquipoModel)
        Return ListEquipoViewModel.FindAll(Function(emp) emp.Serial.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0 OrElse emp.Marca.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
    End Function
    Public Function GetEquiposDisponibles() As DataTable
        Return Repository.GetAllForCmb()
    End Function

End Class
