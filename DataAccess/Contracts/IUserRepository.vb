Public Interface IUserRepository
    Inherits IGenericRepository(Of User)
    Function Login(user As String, pass As String) As Boolean
    Function EditCargo(id As Integer, Cargo As String) As Integer
    Function SolicitarContraseña(solicitante As String) As String
End Interface
