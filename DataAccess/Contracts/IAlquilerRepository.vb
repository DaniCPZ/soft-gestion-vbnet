Public Interface IAlquilerRepository
    Inherits IGenericRepository(Of Alquiler)
    Function GetAllForCmbByCliente(id As Integer) As DataTable
    Function GetAllForContador() As DataTable
    Function GetAllForDgvByCliente(id As Integer) As DataTable
    Function GetAllActivos() As IEnumerable(Of Alquiler)
    Function GetAllVencidos() As IEnumerable(Of Alquiler)
    Function GetAllByFechaInicio(fromDate As Date, toDate As Date) As IEnumerable(Of Alquiler)
    Function GetAllByFechaFinal(fromDate As Date, toDate As Date) As IEnumerable(Of Alquiler)
    Function GetAllActivosAndFf(fromDate As Date, toDate As Date) As IEnumerable(Of Alquiler)
    Function GetAllVencidosAndFf(fromDate As Date, toDate As Date) As IEnumerable(Of Alquiler)
    Function GetAllActivosAndFi(fromDate As Date, toDate As Date) As IEnumerable(Of Alquiler)
    Function GetAllVencidosAndFi(fromDate As Date, toDate As Date) As IEnumerable(Of Alquiler)

End Interface
