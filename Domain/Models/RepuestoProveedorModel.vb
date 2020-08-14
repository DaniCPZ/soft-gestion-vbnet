Imports System.ComponentModel.DataAnnotations
Imports DataAccess
Public Class RepuestoProveedorModel
    Private _FK_Repuesto As String

    Private _FK_Proveedor As Integer
    Private _Observacion As String

    Private _State As EntityState
    Private Repository As IRepuestoProveedorRepository
    Private ListRepProvViewModel As List(Of RepuestoProveedorModel)

#Region "Propiedades, modelos de vista y validacion de datos"
    <Required>
    Public Property FK_Repuesto As String
        Get
            Return _FK_Repuesto
        End Get
        Set(value As String)
            _FK_Repuesto = value
        End Set
    End Property
    <Required>
    Public Property FK_Proveedor As Integer
        Get
            Return _FK_Proveedor
        End Get
        Set(value As Integer)
            _FK_Proveedor = value
        End Set
    End Property
    <Required>
    Public Property Observacion As String
        Get
            Return _Observacion
        End Get
        Set(value As String)
            _Observacion = value
        End Set
    End Property

    Public Property State As EntityState
        Private Get
            Return _State
        End Get
        Set(value As EntityState)
            _State = value
        End Set
    End Property
#End Region

    Public Sub New()
        Repository = New RepuestoProveedorRepository()
    End Sub
    Public Function SaveChanges() As String
        Dim message As String = Nothing
        Try
            Dim repProvDataModel As New RepuestoProveedor()
            repProvDataModel.FK_Repuesto = FK_Repuesto

            repProvDataModel.FK_Proveedor = FK_Proveedor
            repProvDataModel.Observacion = Observacion

            Select Case State
                Case EntityState.Added
                    Repository.Add(repProvDataModel)
                    message = "Success"
                Case EntityState.Modified
                    Repository.Edit(repProvDataModel)
                    message = "Success"
                Case EntityState.Deleted
                    Repository.Remove(FK_Repuesto, FK_Proveedor)
                    message = "Success"
            End Select
        Catch ex As Exception
            Dim sqlEx As System.Data.SqlClient.SqlException = TryCast(ex, System.Data.SqlClient.SqlException)
            If sqlEx IsNot Nothing AndAlso sqlEx.Number = 2627 Then
                message = "Duplicate record"
            Else
                message = ex.ToString
            End If
        End Try
        Return message
    End Function

    Public Function GetRepuestosProveedores() As List(Of RepuestoProveedorModel)
        Dim ListRepProvDataModel = Repository.GetAll()
        ListRepProvViewModel = New List(Of RepuestoProveedorModel)

        For Each item As RepuestoProveedor In ListRepProvDataModel
            ListRepProvViewModel.Add(New RepuestoProveedorModel With {
            .FK_Repuesto = item.FK_Repuesto,
            .FK_Proveedor = item.FK_Proveedor,
            .Observacion = item.Observacion
            })
        Next
        Return ListRepProvViewModel
    End Function
    Public Function FindByRepuesto(filter As String) As IEnumerable(Of RepuestoProveedorModel)
        Return ListRepProvViewModel.FindAll(Function(emp) emp.FK_Repuesto.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
    End Function
    Public Function GetProveedoresByRepuestos(nroRepuesto As String) As DataTable
        Return Repository.GetProveedoresForCmb(nroRepuesto)
    End Function
    'Public Function FindByProveedor() As IEnumerable(Of RepuestoProveedorModel)
    'Public Function FindbyNombre(filter As String) As IEnumerable(Of ClienteModel)
    '    Return ListClienteViewModel.FindAll(Function(emp) emp.Nombre.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
    'End Function
    'Public Function FindbyCuit(filter As String) As IEnumerable(Of ClienteModel)
    '    Return ListClienteViewModel.FindAll(Function(emp) emp.Cuit.ToString.Contains(filter))
    'End Function
End Class
