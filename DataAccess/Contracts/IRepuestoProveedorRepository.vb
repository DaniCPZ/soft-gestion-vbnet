Public Interface IRepuestoProveedorRepository
    Function GetAll() As IEnumerable(Of RepuestoProveedor)
    Function GetProveedoresForCmb(nroRepuesto As String) As DataTable
    Function Add(entity As RepuestoProveedor) As Integer
    Function Edit(entity As RepuestoProveedor) As Integer
    Function Remove(id_Repuesto As Integer, id_Proveedor As Integer) As Integer
End Interface
