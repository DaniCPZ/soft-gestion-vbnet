Public Interface IServicioRepository
    Inherits IGenericRepository(Of Servicio)
    Function GetByDate(fI As Date, fF As Date) As IEnumerable(Of Servicio)
    Function LastServicio() As Integer
    Function GetAllForCmb() As DataTable
End Interface
