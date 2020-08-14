Public Interface IPagoRepository
    Inherits IGenericRepository(Of Pago)
    Function GetByDate(fI As Date, fF As Date) As DataTable
    Function LastsPagoByCliente(id As Integer) As DataTable
End Interface
