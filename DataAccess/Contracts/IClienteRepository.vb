Public Interface IClienteRepository
    Inherits IGenericRepository(Of Cliente)
    Function GetForCobranza() As IEnumerable(Of Cliente)
    Function GetByDate(fI As Date, fF As Date) As IEnumerable(Of Cliente)
    Function GetByDateAndCity(fI As Date, fF As Date, idLocalidad As Integer) As IEnumerable(Of Cliente)
    Function GetByCity(idLocalidad As Integer) As IEnumerable(Of Cliente)
    Function GetAllForCmb() As DataTable
    Sub ClearListParameters()
End Interface
