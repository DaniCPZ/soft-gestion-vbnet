Imports DataAccess
Imports System.ComponentModel.DataAnnotations
Public Class DetalleServicioModel
    Private _Servicio As Integer
    Private _Repuesto As String
    Private _Cantidad As Integer
    Private _costoUnitario As Decimal
    Private _State As EntityState

    Private Repository As IDetalleServicioRepository
    Private ListDetalleViewModel As List(Of DetalleServicioModel)

#Region "Propiedades, modelos de vista y validacion de datos"
    <Required>
    Public Property Servicio As Integer
        Get
            Return _Servicio
        End Get
        Set(value As Integer)
            _Servicio = value
        End Set
    End Property
    <Required>
    Public Property Repuesto As String
        Get
            Return _Repuesto
        End Get
        Set(value As String)
            _Repuesto = value
        End Set
    End Property
    Public Property Cantidad As Integer
        Get
            Return _Cantidad
        End Get
        Set(value As Integer)
            _Cantidad = value
        End Set
    End Property

    Public Property CostoUnitario As Decimal
        Get
            Return _costoUnitario
        End Get
        Set(value As Decimal)
            _costoUnitario = value
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

    'CONSTRUCTOR
    Public Sub New()
        Repository = New DetalleServicioRepository
    End Sub

    'METODOS DEL OBJETO
    Public Function SaveChanges() As String
        Dim message As String = Nothing
        Try
            Dim detalleDataModel As New DetalleServicio()
            detalleDataModel.FK_Repuesto = Repuesto
            detalleDataModel.FK_Servicio = Servicio
            detalleDataModel.costoUnitario = CostoUnitario
            detalleDataModel.Cantidad = Cantidad

            Select Case State
                Case EntityState.Added
                    Repository.Add(detalleDataModel)
                    message = "Added"
                Case EntityState.Modified
                    Repository.Edit(detalleDataModel)
                    message = "Modified"
                Case EntityState.Deleted
                    Repository.Remove(Repuesto)
                    message = "Remove"
            End Select
        Catch ex As Exception
            Dim sqlEx As System.Data.SqlClient.SqlException = TryCast(ex, System.Data.SqlClient.SqlException)
            If sqlEx IsNot Nothing AndAlso sqlEx.Number = 2627 Then
                message = "Duplicate record"
            ElseIf sqlEx.Number = 547 Then
                message = "Registro con informacion relacionada"
            Else
                message = ex.ToString
            End If
        End Try
        Return message
    End Function

    Public Function GetDetalles() As List(Of DetalleServicioModel)
        Dim ListDetalleDataModel = Repository.GetAll()
        ListDetalleViewModel = New List(Of DetalleServicioModel)
        For Each item As DetalleServicio In ListDetalleDataModel
            ListDetalleViewModel.Add(New DetalleServicioModel With {
                .Servicio = item.FK_Servicio,
                .Repuesto = item.FK_Repuesto,
                .Cantidad = item.Cantidad,
                .CostoUnitario = item.costoUnitario
            })
        Next
        Return ListDetalleViewModel
    End Function
    Public Function FindByService(nroServicio As String) As IEnumerable(Of DetalleServicioModel)
        Return ListDetalleViewModel.FindAll(Function(emp) emp.Servicio.ToString.Contains(nroServicio))
    End Function
    'Private Function FindCliente(i As Integer) As String
    '    Dim Cliente As String
    '    Cliente = ListClienteViewModel.Find(Function(emp) emp.ID_Cliente = i).Nombre
    '    Return Cliente
    'End Function
    'Public Function Find(filter As String) As IEnumerable(Of ServicioModel)
    '    Return ListServicioViewModel.FindAll(Function(emp) emp.Cliente.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0 OrElse emp.Serial.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
    'End Function
    'Public Function GetLastServicio() As Integer
    '    Return Repository.LastServicio()
    'End Function
End Class
