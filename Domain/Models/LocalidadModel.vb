Imports DataAccess
Imports System.ComponentModel.DataAnnotations
Public Class LocalidadModel
    ' ATRIBUTOS - CAMPOS

    'Private _Age As Date ---------- esto es un campo calculado
    Private _codigoPostal As Integer
    Private _Nombre As String
    Private _Observacion As String
    Private _State As EntityState
    Private Repository As ILocalidadRepository
    Private ListLocalidadViewModel As List(Of LocalidadModel)


    ' PROPIEDADES O METODOS GET Y SET
#Region "Propiedades, modelos de vista y validacion de datos"
    <Required>
    Public Property CodigoPostal As Integer
        Get
            Return _codigoPostal
        End Get
        Set(value As Integer)
            _codigoPostal = value
        End Set
    End Property
    <Required>
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property
    <Required>
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
        Repository = New LocalidadRepository()
    End Sub

    ' METODOS DEL OBJETO
    Public Function SaveChanges() As String
        Dim message As String = Nothing
        Try
            Dim localidadDataModel As New Localidad()
            localidadDataModel.codigoPostal = CodigoPostal
            localidadDataModel.Nombre = Nombre
            localidadDataModel.Observacion = Observacion

            Select Case State
                Case EntityState.Added
                    Repository.Add(localidadDataModel)
                    message = "Added"
                Case EntityState.Modified
                    Repository.Edit(localidadDataModel)
                    message = "Modified"
                Case EntityState.Deleted
                    Repository.Remove(CodigoPostal)
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

    Public Function GetLocalidades() As List(Of LocalidadModel)
        Dim ListLocalidadDataModel = Repository.GetAll()
        ListLocalidadViewModel = New List(Of LocalidadModel)

        For Each item As Localidad In ListLocalidadDataModel
            ListLocalidadViewModel.Add(New LocalidadModel With {
            .CodigoPostal = item.codigoPostal,
            .Nombre = item.Nombre,
            .Observacion = item.Observacion
            })
        Next
        Return ListLocalidadViewModel
    End Function
    Public Function GetLocalidadesOrderByNombre() As DataTable
        Return Repository.GetAllOrderByNombre()
    End Function

End Class
