Imports DataAccess
Imports System.ComponentModel.DataAnnotations
Public Class UserModel
    Private _ID_User As Integer
    Private _LoginName As String
    Private _Password As String
    Private _Nombre As String
    Private _Email As String
    Private _Apellido As String
    Private _Cargo As String
    Private _State As EntityState
    Private ListUserViewModel As List(Of UserModel)
    Private Repository As IUserRepository

#Region "Propiedades, modelos de vista y validacion de datos"
    Public Property ID_User As Integer
        Get
            Return _ID_User
        End Get
        Set(value As Integer)
            _ID_User = value
        End Set
    End Property

    <Required(ErrorMessage:="El campo Nombre de usuario es obligatorio")>
    <RegularExpression("^[a-zA-Z]+$", ErrorMessage:="El campo Nombre de usuario debe contener solo letras")>
    Public Property LoginName As String
        Get
            Return _LoginName
        End Get
        Set(value As String)
            _LoginName = value
        End Set
    End Property
    <Required>
    Public Property Password As String
        Private Get
            Return _Password
        End Get
        Set(value As String)
            _Password = value
        End Set
    End Property
    <Required>
    <RegularExpression("^[a-zA-Z]+$")>
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
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
    <RegularExpression("^[a-zA-Z]+$")>
    Public Property Apellido As String
        Get
            Return _Apellido
        End Get
        Set(value As String)
            _Apellido = value
        End Set
    End Property

    Public Property Cargo As String
        Get
            Return _Cargo
        End Get
        Set(value As String)
            _Cargo = value
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
        Repository = New UserRepository()
    End Sub

    'METODOS DEL OBJETO
    Public Function SaveChanges() As String
        Dim message As String = Nothing
        Try
            Dim UserDataModel As New User()
            UserDataModel.ID_User = ID_User
            UserDataModel.LoginName = LoginName
            UserDataModel.Password = Password
            UserDataModel.Nombre = Nombre
            UserDataModel.Apellido = Apellido
            UserDataModel.Email = Email
            UserDataModel.Cargo = Cargo

            Select Case State
                Case EntityState.Added
                    Repository.Add(UserDataModel)
                    message = "Success"
                Case EntityState.Modified
                    Repository.Edit(UserDataModel)
                    Repository.Login(LoginName, Password)
                    message = "Success"
                Case EntityState.Deleted
                    Repository.Remove(ID_User)
                    message = "Success"
            End Select
        Catch ex As Exception
            Dim sqlEx As System.Data.SqlClient.SqlException = TryCast(ex, System.Data.SqlClient.SqlException)
            If sqlEx IsNot Nothing AndAlso sqlEx.Number = 2627 Then
                message = "Duplicate record"
            Else
                message = ex.ToString
            End If
        End Try
        Return message
    End Function

    Public Function EditarPerfil() As String
        Dim message As String
        Try
            Dim UserDataModel As New User()
            UserDataModel.ID_User = ID_User
            UserDataModel.LoginName = LoginName
            UserDataModel.Password = Password
            UserDataModel.Nombre = Nombre
            UserDataModel.Apellido = Apellido
            UserDataModel.Email = Email
            Repository.Edit(UserDataModel)
            Repository.Login(LoginName, Password)
            message = "Success"
        Catch ex As Exception
            message = ex.ToString
        End Try
        Return message
    End Function
    Public Function RecuperarContraseña(Solicitante As String) As String
        Return Repository.SolicitarContraseña(Solicitante)
    End Function
    Public Function GetUser(user As String, pass As String) As Boolean
        Return Repository.Login(user, pass)
    End Function
    Public Function GetAll() As List(Of UserModel)
        Dim ListUserDataModel = Repository.GetAll()
        ListUserViewModel = New List(Of UserModel)

        For Each item As User In ListUserDataModel
            ListUserViewModel.Add(New UserModel With {
            .ID_User = item.ID_User,
            .Nombre = item.Nombre,
            .Apellido = item.Apellido,
            .LoginName = item.LoginName,
            .Email = item.Email,
            .Cargo = item.Cargo
            })
        Next
        Return ListUserViewModel
    End Function

    Public Function EditarCargo(id As Integer, Cargo As String) As String
        Dim message As String
        Try
            Repository.EditCargo(id, Cargo)
            message = "Usuario modificado con exito"
        Catch ex As Exception
            message = ex.ToString
        End Try
        Return message
    End Function
End Class
