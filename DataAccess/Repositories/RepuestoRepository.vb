Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess
Public Class RepuestoRepository
    Inherits MasterRepository
    Implements IRepuestoRepository

    Private selectAll As String
    Private selectAllByProv As String
    Private selectAllForList As String
    Private selectSinStock As String
    Private selectConStock As String
    Private selectPrice As String
    Private insert As String
    Private update As String
    Private delete As String

    Public Sub New()
        selectAll = "select * from Repuesto"
        selectAllByProv = "select Repuesto.* from Repuesto inner join (select FK_Repuesto from RepuestoProveedor where FK_Proveedor = @FK_Proveedor)as c on c.FK_Repuesto = Repuesto.nroRepuesto"
        'consultas para el filtro
        selectSinStock = "select * from Repuesto where Stock <= puntoPedido"
        selectConStock = "select * from Repuesto where Stock > puntoPedido"
        selectAllForList = "select nroRepuesto,Stock,costoUnitario as Precio,Descripcion from repuesto inner join
                            (select a.FK_Repuesto from RepuestoEquipo as A inner join
                            (select Serial from Equipo where Serial = @Serial) as B on a.FK_Equipo = b.Serial) as C 
                            on Repuesto.nroRepuesto = c.FK_Repuesto"

        selectPrice = "select costoUnitario from Repuesto where nroRepuesto=@nroRepuesto"

        insert = "insert into Repuesto values(@nroRepuesto,@costoUnitario,@puntoPedido,@loteCompra,@Stock,@Descripcion)"
        update = "update Repuesto set costoUnitario=@costoUnitario,puntoPedido=@puntoPedido,loteCompra=@loteCompra,Stock=@Stock,Descripcion=@Descripcion where nroRepuesto=@nroRepuesto"
        delete = "delete from Repuesto where nroRepuesto=@nroRepuesto"
    End Sub

    Public Sub ClearListParameters() Implements IRepuestoRepository.ClearListParameters
        LimpiarParametros()
    End Sub

    Public Function GetAll() As IEnumerable(Of Repuesto) Implements IRepuestoRepository.GetAll
        Dim resultTable = ExecuteReader(selectAll)
        Dim listRepuesto = New List(Of Repuesto)
        For Each item As DataRow In resultTable.Rows
            listRepuesto.Add(New Repuesto With {
                .nroRepuesto = item(0),
                .costoUnitario = item(1),
                .puntoPedido = item(2),
                .loteCompra = item(3),
                .Stock = item(4),
                .Descripcion = item(5)
            })
        Next
        Return listRepuesto
    End Function

    Public Function Add(entity As Repuesto) As Integer Implements IRepuestoRepository.Add
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@nroRepuesto", entity.nroRepuesto))
        parameters.Add(New SqlParameter("@costoUnitario", entity.costoUnitario))
        parameters.Add(New SqlParameter("@puntoPedido", entity.puntoPedido))
        parameters.Add(New SqlParameter("@loteCompra", entity.loteCompra))
        parameters.Add(New SqlParameter("@Stock", entity.Stock))
        parameters.Add(New SqlParameter("@Descripcion", entity.Descripcion))
        Return ExecuteNonQuery(insert)
    End Function

    Public Function Edit(entity As Repuesto) As Integer Implements IRepuestoRepository.Edit
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@nroRepuesto", entity.nroRepuesto))
        parameters.Add(New SqlParameter("@costoUnitario", entity.costoUnitario))
        parameters.Add(New SqlParameter("@puntoPedido", entity.puntoPedido))
        parameters.Add(New SqlParameter("@loteCompra", entity.loteCompra))
        parameters.Add(New SqlParameter("@Stock", entity.Stock))
        parameters.Add(New SqlParameter("@Descripcion", entity.Descripcion))
        Return ExecuteNonQuery(update)
    End Function

    Public Function Remove(nroRepuesto As String) As Integer Implements IRepuestoRepository.Remove
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@nroRepuesto", nroRepuesto))
        Return ExecuteNonQuery(delete)
    End Function

    Public Function GetAllForList(Serial As String) As DataTable Implements IRepuestoRepository.GetAllForList
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@Serial", Serial))
        Return ExecuteReader(selectAllForList)
    End Function

    Public Function GetPrice(nroRepuesto As String) As Decimal Implements IRepuestoRepository.GetPrice
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@nroRepuesto", nroRepuesto))
        Dim resultTable = ExecuteReader(selectPrice)
        Return resultTable.Rows(0).Item(0)
    End Function

    Public Function GetAllSinStock() As IEnumerable(Of Repuesto) Implements IRepuestoRepository.GetAllSinStock
        Dim resultTable = ExecuteReader(selectSinStock)
        Dim listRepuesto = New List(Of Repuesto)
        For Each item As DataRow In resultTable.Rows
            listRepuesto.Add(New Repuesto With {
                .nroRepuesto = item(0),
                .costoUnitario = item(1),
                .puntoPedido = item(2),
                .loteCompra = item(3),
                .Stock = item(4),
                .Descripcion = item(5)
            })
        Next
        Return listRepuesto
    End Function

    Public Function GetAllConStock() As IEnumerable(Of Repuesto) Implements IRepuestoRepository.GetAllConStock
        Dim resultTable = ExecuteReader(selectConStock)
        Dim listRepuesto = New List(Of Repuesto)
        For Each item As DataRow In resultTable.Rows
            listRepuesto.Add(New Repuesto With {
                .nroRepuesto = item(0),
                .costoUnitario = item(1),
                .puntoPedido = item(2),
                .loteCompra = item(3),
                .Stock = item(4),
                .Descripcion = item(5)
            })
        Next
        Return listRepuesto
    End Function

    Public Function GetAllByProv(FK_Proveedor As Integer) As IEnumerable(Of Repuesto) Implements IRepuestoRepository.GetAllByProv
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@FK_Proveedor", FK_Proveedor))

        Dim resultTable = ExecuteReader(selectAllByProv)
        Dim listRepuesto = New List(Of Repuesto)
        For Each item As DataRow In resultTable.Rows
            listRepuesto.Add(New Repuesto With {
                .nroRepuesto = item(0),
                .costoUnitario = item(1),
                .puntoPedido = item(2),
                .loteCompra = item(3),
                .Stock = item(4),
                .Descripcion = item(5)
            })
        Next
        Return listRepuesto
    End Function
End Class
