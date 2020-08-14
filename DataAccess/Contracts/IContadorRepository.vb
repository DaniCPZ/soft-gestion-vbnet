Public Interface IContadorRepository
    Inherits IGenericRepository(Of Contador)
    Function GetContadorForAlquiler(id As Integer) As Integer
End Interface
