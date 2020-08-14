Public Interface IEquipoRepository
    Function GetAll() As IEnumerable(Of Equipo)
    Function Add(entity As Equipo) As Integer
    Function Edit(entity As Equipo) As Integer
    Function Remove(Serial As String) As Integer
    Function GetAllForCmb() As DataTable
    Sub ClearListParameters()
End Interface
