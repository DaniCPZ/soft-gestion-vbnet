Public Interface IFacturaRepository
    Inherits IGenericRepository(Of Factura)
    Function LastsFacturaByCliente(id As Integer) As DataTable
    Function GetByDate(fI As Date, fF As Date) As DataTable
End Interface
