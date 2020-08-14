Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess
Public Class RepuestoProveedorRepository
    Inherits MasterRepository
    Implements IRepuestoProveedorRepository

    Private selectAll As String
    Private selectProveedoresForCmb As String
    Private insert As String
    Private update As String
    Private delete As String

    Public Sub New()
        selectAll = "select * from RepuestoProveedor"
        selectProveedoresForCmb = "select ID_Proveedor,( 'Cuit: '+ cast(cuit as varchar) + ' - '+ Nombre) as Dataview from Proveedor left join (Select * from RepuestoProveedor where RepuestoProveedor.FK_Repuesto = @FK_Repuesto) as s on Proveedor.ID_Proveedor = s.FK_Proveedor where s.FK_Proveedor is null"
        insert = "insert into RepuestoProveedor values(@FK_Repuesto,@FK_Proveedor,@Observacion)"
        update = "update RepuestoProveedor set Observacion=@Observacion where FK_Repuesto=@FK_Repuesto and FK_Proveedor=@FK_Proveedor"
        delete = "delete from RepuestoProveedor where FK_Repuesto=@FK_Repuesto and FK_Proveedor=@FK_Proveedor"
    End Sub

    Public Function GetAll() As IEnumerable(Of RepuestoProveedor) Implements IRepuestoProveedorRepository.GetAll
        Dim resultTable = ExecuteReader(selectAll)
        Dim listRepuestoProveedor = New List(Of RepuestoProveedor)
        For Each item As DataRow In resultTable.Rows
            listRepuestoProveedor.Add(New RepuestoProveedor With {
                .FK_Repuesto = item(0),
                .FK_Proveedor = item(1),
                .Observacion = item(2)
            })
        Next
        Return listRepuestoProveedor
    End Function

    Public Function Add(entity As RepuestoProveedor) As Integer Implements IRepuestoProveedorRepository.Add
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@FK_Repuesto", entity.FK_Repuesto))
        parameters.Add(New SqlParameter("@FK_Proveedor", entity.FK_Proveedor))
        parameters.Add(New SqlParameter("@Observacion", entity.Observacion))
        Return ExecuteNonQuery(insert)
    End Function

    Public Function Edit(entity As RepuestoProveedor) As Integer Implements IRepuestoProveedorRepository.Edit
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@FK_Repuesto", entity.FK_Repuesto))
        parameters.Add(New SqlParameter("@FK_Proveedor", entity.FK_Proveedor))
        parameters.Add(New SqlParameter("@Observacion", entity.Observacion))
        Return ExecuteNonQuery(update)
    End Function

    Public Function Remove(id_Repuesto As Integer, id_Proveedor As Integer) As Integer Implements IRepuestoProveedorRepository.Remove
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@FK_Repuesto", id_Repuesto))
        parameters.Add(New SqlParameter("@FK_Proveedor", id_Proveedor))
        Return ExecuteNonQuery(insert)
    End Function

    Public Function GetProveedoresForCmb(nroRepuesto As String) As DataTable Implements IRepuestoProveedorRepository.GetProveedoresForCmb
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@FK_Repuesto", nroRepuesto))
        Return ExecuteReader(selectProveedoresForCmb)
    End Function
End Class
