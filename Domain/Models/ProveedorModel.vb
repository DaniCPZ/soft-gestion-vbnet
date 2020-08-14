Imports DataAccess
Imports System.ComponentModel.DataAnnotations
Public Class ProveedorModel
    Private _ID_Proveedor As Integer
    Private _Nombre As String
    Private _Cuit As Long
    Private _Email As String
    Private _Telefono As String
    Private _fechaAlta As Date
    Private _State As EntityState

    Private Repository As IProveedorRepository
    Private ListProveedorViewModel As List(Of ProveedorModel)

#Region "Propiedades, modelos de vista y validacion de datos"
    Public Property ID_Proveedor As Integer
        Get
            Return _ID_Proveedor
        End Get
        Set(value As Integer)
            _ID_Proveedor = value
        End Set
    End Property
    <Required>
    <RegularExpression("^[a-zA-Z\s]+$", ErrorMessage:="El campo Nombre debe contener solo letras")>
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property


    Public Property Cuit As Long
        Get
            Return _Cuit
        End Get
        Set(value As Long)
            _Cuit = value
        End Set
    End Property

    <Required>
    <EmailAddress>
    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property
    <Required>
    <Phone>
    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property

    Public Property FechaAlta As Date
        Get
            Return _fechaAlta
        End Get
        Set(value As Date)
            _fechaAlta = value
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

    'CONSTRUCTOR
    Public Sub New()
        Repository = New ProveedorRepository
    End Sub

    'METODOS DEL OBJETO
    Public Function SaveChanges() As String
        Dim message As String = Nothing
        Try
            Dim proveedorDataModel As New Proveedor()
            proveedorDataModel.ID_Proveedor = ID_Proveedor
            proveedorDataModel.Nombre = Nombre
            proveedorDataModel.Cuit = Cuit
            proveedorDataModel.Email = Email
            proveedorDataModel.Telefono = Telefono
            proveedorDataModel.fechaAlta = FechaAlta
            Select Case State
                Case EntityState.Added
                    Repository.Add(proveedorDataModel)
                    message = "Added"
                Case EntityState.Modified
                    Repository.Edit(proveedorDataModel)
                    message = "Modified"
                Case EntityState.Deleted
                    Repository.Remove(ID_Proveedor)
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
    Public Function GetProveedores() As List(Of ProveedorModel)
        Dim ListProveedorDataModel = Repository.GetAll()
        ListProveedorViewModel = New List(Of ProveedorModel)

        For Each item As Proveedor In ListProveedorDataModel
            ListProveedorViewModel.Add(New ProveedorModel With {
            .ID_Proveedor = item.ID_Proveedor,
            .Nombre = item.Nombre,
            .Cuit = item.Cuit,
            .Email = item.Email,
            .Telefono = item.Telefono,
            .FechaAlta = item.fechaAlta
            })
        Next
        Return ListProveedorViewModel
    End Function
    Public Function FindbyNombre(filter As String) As IEnumerable(Of ProveedorModel)
        Return ListProveedorViewModel.FindAll(Function(emp) emp.Nombre.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
    End Function
    Public Function FindbyCuit(filter As String) As IEnumerable(Of ProveedorModel)
        Return ListProveedorViewModel.FindAll(Function(emp) emp.Cuit.ToString.Contains(filter))
    End Function
End Class
