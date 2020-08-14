Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess
Imports Common
Public Class UserRepository
    Inherits MasterRepository
    Implements IUserRepository

    Private selectAll As String
    Private recoverPassword As String
    Private insert As String
    Private update As String
    Private updateCargo As String
    Private delete As String
    Private selectOne As String
    Public Sub New()
        selectAll = " select * from Users"
        recoverPassword = "select * from Users where loginName=@loginName or Email=@Email"
        insert = "insert into Users values(@LoginName,@Password,@Nombre,@Apellido,@Cargo,@Email)"
        update = "update Users set LoginName=@LoginName,Password=@Password,Nombre=@Nombre,Apellido=@Apellido,Email=@Email where ID_User=@ID_User"
        updateCargo = "update Users set Cargo=@Cargo where ID_User=@ID_User"
        delete = "delete from Users where ID_User=@ID_User"
        selectOne = "select * from Users where loginName=@user and password=@pass"
    End Sub
    Public Function Login(user As String, pass As String) As Boolean Implements IUserRepository.Login
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@user", user))
        parameters.Add(New SqlParameter("@pass", pass))
        Using table = ExecuteReader(selectOne)
            If table.Rows.Count = 0 Then
                Return False
            Else
                For Each item As DataRow In table.Rows
                    ActiveUser.idUser = item(0)
                    ActiveUser.LoginName = item(1)
                    ActiveUser.Password = item(2)
                    ActiveUser.Nombre = item(3)
                    ActiveUser.Apellido = item(4)
                    ActiveUser.Cargo = item(5)
                    ActiveUser.Email = item(6)
                Next
                Return True
            End If
        End Using
    End Function

    Public Function GetAll() As IEnumerable(Of User) Implements IGenericRepository(Of User).GetAll
        Dim resultTable = ExecuteReader(selectAll)
        Dim listUsers = New List(Of User)
        For Each item As DataRow In resultTable.Rows
            listUsers.Add(New User With {
                .ID_User = item(0),
                .Password = "",
                .LoginName = item(1),
                .Nombre = item(3),
                .Apellido = item(4),
                .Cargo = item(5),
                .Email = item(6)
            })
        Next
        Return listUsers
    End Function

    Public Function Add(entity As User) As Integer Implements IGenericRepository(Of User).Add
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@LoginName", entity.LoginName))
        parameters.Add(New SqlParameter("@Password", entity.Password))
        parameters.Add(New SqlParameter("@Nombre", entity.Nombre))
        parameters.Add(New SqlParameter("@Apellido", entity.Apellido))
        parameters.Add(New SqlParameter("@Email", entity.Email))
        parameters.Add(New SqlParameter("@Cargo", entity.Cargo))
        Return ExecuteNonQuery(insert)
    End Function

    Public Function Edit(entity As User) As Integer Implements IGenericRepository(Of User).Edit
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@LoginName", entity.LoginName))
        parameters.Add(New SqlParameter("@Password", entity.Password))
        parameters.Add(New SqlParameter("@Nombre", entity.Nombre))
        parameters.Add(New SqlParameter("@Apellido", entity.Apellido))
        parameters.Add(New SqlParameter("@Email", entity.Email))
        parameters.Add(New SqlParameter("@ID_User", entity.ID_User))
        Return ExecuteNonQuery(update)

    End Function

    Public Function Remove(id As Integer) As Integer Implements IGenericRepository(Of User).Remove
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@ID_User", id))
        Return ExecuteNonQuery(delete)
    End Function

    Public Function EditCargo(id As Integer, Cargo As String) As Integer Implements IUserRepository.EditCargo
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@ID_User", id))
        parameters.Add(New SqlParameter("@Cargo", Cargo))
        Return ExecuteNonQuery(updateCargo)
    End Function

    Public Function SolicitarContraseña(solicitante As String) As String Implements IUserRepository.SolicitarContraseña

        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@loginName", solicitante))
        parameters.Add(New SqlParameter("@Email", solicitante))
        Using table = ExecuteReader(recoverPassword)
            If table.Rows.Count > 0 Then
                Dim userName = table.Rows(0)(3).ToString() & ", " & table.Rows(0)(4).ToString()

                Dim userMail = table.Rows(0)(6).ToString()
                Dim userPassword = table.Rows(0)(2).ToString()

                Dim supportEmail As New SystemSupportEmail
                supportEmail.enviarCorreo(asunto:="SISTEMA DE SOPORTE: Solicitud de recuperacion de contraseña",
                                          cuerpo:="Hola, " & userName & vbNewLine & "Solicitaste recuperar tu contraseña." & vbNewLine &
                                          "Tu constraseña es: " & userPassword & vbNewLine &
                                          "Le pedimos que cambie su contraseña inmediatamente ingrese al sistema.",
                                          destinatarios:=New List(Of String) From {userMail})
                Return "Hola, " & userName & vbNewLine & "Solicitaste recuperar tu contraseña." & vbNewLine &
                                          "Por favor revise su correo electrónico: " & userMail & vbNewLine &
                                          "Le pedimos que cambie su contraseña inmediatamente ingrese al sistema."

            Else
                Return "Lo sentimos, usted no tiene una cuenta con este nombre de usuario o correo electronico"
            End If
        End Using
    End Function
End Class
