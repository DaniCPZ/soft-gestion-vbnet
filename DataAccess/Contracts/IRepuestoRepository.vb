Public Interface IRepuestoRepository
    Function GetAll() As IEnumerable(Of Repuesto)
    Function Add(entity As Repuesto) As Integer
    Function Edit(entity As Repuesto) As Integer
    Function Remove(nroRepuesto As String) As Integer
    Function GetAllByProv(FK_Proveedor As Integer) As IEnumerable(Of Repuesto)
    Function GetAllForList(Serial As String) As DataTable
    Function GetPrice(nroRepuesto As String) As Decimal

    'funciones para filtro
    Function GetAllSinStock() As IEnumerable(Of Repuesto)
    Function GetAllConStock() As IEnumerable(Of Repuesto)

    Sub ClearListParameters()
End Interface
