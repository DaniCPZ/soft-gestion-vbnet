Imports DataAccess
Imports System.ComponentModel.DataAnnotations
Public Class ClienteModel

    ' ATRIBUTOS - CAMPOS

    Private _ID_Cliente As Integer
    Private _Nombre As String
    Private _Cuit As Long
    Private _Cond_IVA As String
    Private _Email As String
    Private _Telefono As String
    Private _Localidad As String
    Private _Direccion As String
    Private _Saldo As Decimal
    Private _FK_CodPostal As Integer
    Private _fechaAlta As Date
    Private _State As EntityState
    Private Repository As IClienteRepository
    Private ListClienteViewModel As List(Of ClienteModel)
    Private ListLocalidadViewModel As List(Of LocalidadModel)

    ' PROPIEDADES O METODOS GET Y SET
#Region "Propiedades, modelos de vista y validacion de datos"
    <Required>
    Public Property ID_Cliente As Integer
        Get
            Return _ID_Cliente
        End Get
        Set(value As Integer)
            _ID_Cliente = value
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

    <Required>
    Public Property Cuit As Long
        Get
            Return _Cuit
        End Get
        Set(value As Long)
            _Cuit = value
        End Set
    End Property

    <Required(ErrorMessage:="El campo condicion IVA es obligatorio")>
    <RegularExpression("^[a-zA-Z\s]+$", ErrorMessage:="El campo condicion IVA debe contener solo letras")>
    Public Property Cond_IVA As String
        Get
            Return _Cond_IVA
        End Get
        Set(value As String)
            _Cond_IVA = value
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

    Public Property Localidad As String
        Get
            Return _Localidad
        End Get
        Set(value As String)
            _Localidad = value
        End Set
    End Property

    <Required>
    Public Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(value As String)
            _Direccion = value
        End Set
    End Property
    Public Property Saldo As Decimal
        Get
            Return _Saldo
        End Get
        Set(value As Decimal)
            _Saldo = value
        End Set
    End Property

    <Required>
    Public Property FK_CodPostal As Integer
        Private Get
            Return _FK_CodPostal
        End Get
        Set(value As Integer)
            _FK_CodPostal = value
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


    ' CONTRUCTORES 
    Public Sub New()
        Repository = New ClienteRepository()
    End Sub

    'METODOS DEL OBJETO
    Public Function SaveChanges() As String
        Dim message As String = Nothing
        Try
            Dim clienteDataModel As New Cliente()
            clienteDataModel.ID_Cliente = ID_Cliente
            clienteDataModel.Nombre = Nombre
            clienteDataModel.Cuit = Cuit
            clienteDataModel.Cond_IVA = Cond_IVA
            clienteDataModel.Email = Email
            clienteDataModel.Telefono = Telefono
            clienteDataModel.Direccion = Direccion
            clienteDataModel.Saldo = Saldo
            clienteDataModel.FK_CodPostal = FK_CodPostal
            clienteDataModel.fechaAlta = FechaAlta

            Select Case State
                Case EntityState.Added
                    Repository.Add(clienteDataModel)
                    message = "Added"
                Case EntityState.Modified
                    Repository.Edit(clienteDataModel)
                    message = "Modified"
                Case EntityState.Deleted
                    Repository.Remove(ID_Cliente)
                    message = "Remove"
            End Select
        Catch ex As Exception
            Repository.ClearListParameters()
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
    Public Function GetClientes() As List(Of ClienteModel)
        Dim localidadModel = New LocalidadModel()
        ListLocalidadViewModel = localidadModel.GetLocalidades()

        Dim ListClienteDataModel = Repository.GetAll()
        ListClienteViewModel = New List(Of ClienteModel)

        For Each item As Cliente In ListClienteDataModel
            ListClienteViewModel.Add(New ClienteModel With {
            .ID_Cliente = item.ID_Cliente,
            .Nombre = item.Nombre,
            .Cuit = item.Cuit,
            .Cond_IVA = item.Cond_IVA,
            .Email = item.Email,
            .Telefono = item.Telefono,
            .Localidad = FindLocalidad(item.FK_CodPostal),
            .Direccion = item.Direccion,
            .Saldo = item.Saldo,
            .FechaAlta = item.fechaAlta
            })
        Next
        Return ListClienteViewModel
    End Function
    Public Function GetClienteForCobranza() As List(Of ClienteModel)
        Dim localidadModel = New LocalidadModel()
        ListLocalidadViewModel = localidadModel.GetLocalidades()

        Dim ListClienteDataModel = Repository.GetForCobranza()
        ListClienteViewModel = New List(Of ClienteModel)

        For Each item As Cliente In ListClienteDataModel
            ListClienteViewModel.Add(New ClienteModel With {
            .ID_Cliente = item.ID_Cliente,
            .Nombre = item.Nombre,
            .Cuit = item.Cuit,
            .Cond_IVA = item.Cond_IVA,
            .Email = item.Email,
            .Telefono = item.Telefono,
            .Localidad = FindLocalidad(item.FK_CodPostal),
            .Direccion = item.Direccion,
            .Saldo = item.Saldo,
            .FechaAlta = item.fechaAlta
            })
        Next
        Return ListClienteViewModel
    End Function
    Public Function GetClientesByFecha(fI As Date, fF As Date) As List(Of ClienteModel)
        Dim localidadModel = New LocalidadModel()
        ListLocalidadViewModel = localidadModel.GetLocalidades()

        Dim ListClienteDataModel = Repository.GetByDate(fI, fF)
        ListClienteViewModel = New List(Of ClienteModel)

        For Each item As Cliente In ListClienteDataModel
            ListClienteViewModel.Add(New ClienteModel With {
            .ID_Cliente = item.ID_Cliente,
            .Nombre = item.Nombre,
            .Cuit = item.Cuit,
            .Cond_IVA = item.Cond_IVA,
            .Email = item.Email,
            .Telefono = item.Telefono,
            .Localidad = FindLocalidad(item.FK_CodPostal),
            .Direccion = item.Direccion,
            .Saldo = item.Saldo,
            .FechaAlta = item.fechaAlta
            })
        Next
        Return ListClienteViewModel
    End Function
    Public Function GetClientesByLocalidad(idLocalidad As Integer) As List(Of ClienteModel)
        Dim localidadModel = New LocalidadModel()
        ListLocalidadViewModel = localidadModel.GetLocalidades()

        Dim ListClienteDataModel = Repository.GetByCity(idLocalidad)
        ListClienteViewModel = New List(Of ClienteModel)

        For Each item As Cliente In ListClienteDataModel
            ListClienteViewModel.Add(New ClienteModel With {
            .ID_Cliente = item.ID_Cliente,
            .Nombre = item.Nombre,
            .Cuit = item.Cuit,
            .Cond_IVA = item.Cond_IVA,
            .Email = item.Email,
            .Telefono = item.Telefono,
            .Localidad = FindLocalidad(item.FK_CodPostal),
            .Direccion = item.Direccion,
            .Saldo = item.Saldo,
            .FechaAlta = item.fechaAlta
            })
        Next
        Return ListClienteViewModel
    End Function
    Public Function GetClientesByFechaAndLocalidad(fI As Date, fF As Date, idLocalidad As Integer) As List(Of ClienteModel)
        Dim localidadModel = New LocalidadModel()
        ListLocalidadViewModel = localidadModel.GetLocalidades()

        Dim ListClienteDataModel = Repository.GetByDateAndCity(fI, fF, idLocalidad)
        ListClienteViewModel = New List(Of ClienteModel)

        For Each item As Cliente In ListClienteDataModel
            ListClienteViewModel.Add(New ClienteModel With {
            .ID_Cliente = item.ID_Cliente,
            .Nombre = item.Nombre,
            .Cuit = item.Cuit,
            .Cond_IVA = item.Cond_IVA,
            .Email = item.Email,
            .Telefono = item.Telefono,
            .Localidad = FindLocalidad(item.FK_CodPostal),
            .Direccion = item.Direccion,
            .Saldo = item.Saldo,
            .FechaAlta = item.fechaAlta
            })
        Next
        Return ListClienteViewModel
    End Function

    Private Function FindLocalidad(i As Integer) As String
        Return ListLocalidadViewModel.Find(Function(emp) emp.CodigoPostal = i).Nombre
    End Function
    Public Function FindbyNombre(filter As String) As IEnumerable(Of ClienteModel)
        Return ListClienteViewModel.FindAll(Function(emp) emp.Nombre.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
    End Function
    Public Function FindbyCuit(filter As String) As IEnumerable(Of ClienteModel)
        Return ListClienteViewModel.FindAll(Function(emp) emp.Cuit.ToString.Contains(filter))
    End Function

    Public Function GetClientesForCmb() As DataTable
        Return Repository.GetAllForCmb()
    End Function

End Class
