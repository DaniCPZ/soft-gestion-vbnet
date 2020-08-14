Public Interface ILocalidadRepository
    Inherits IGenericRepository(Of Localidad)
    Function GetAllOrderByNombre() As DataTable
    Sub ClearListParameters()
End Interface
