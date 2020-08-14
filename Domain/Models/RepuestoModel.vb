Imports DataAccess
Imports System.ComponentModel.DataAnnotations
Public Class RepuestoModel
    Private _nroRepuesto As String
    Private _costoUnitario As Decimal
    Private _puntoPedido As Integer
    Private _loteCompra As Integer
    Private _Stock As Integer
    Private _Descripcion As String
    Private _State As EntityState
    Private Repository As IRepuestoRepository
    Private ListRepuestoViewModel As List(Of RepuestoModel)

#Region "Propiedades, modelos de vista y validacion de datos"
    <Required>
    Public Property NroRepuesto As String
        Get
            Return _nroRepuesto
        End Get
        Set(value As String)
            _nroRepuesto = value
        End Set
    End Property
    <Required>
    Public Property CostoUnitario As Decimal
        Get
            Return _costoUnitario
        End Get
        Set(value As Decimal)
            _costoUnitario = value
        End Set
    End Property
    <Required>
    Public Property PuntoPedido As Integer
        Get
            Return _puntoPedido
        End Get
        Set(value As Integer)
            _puntoPedido = value
        End Set
    End Property
    <Required>
    Public Property LoteCompra As Integer
        Get
            Return _loteCompra
        End Get
        Set(value As Integer)
            _loteCompra = value
        End Set
    End Property
    <Required>
    Public Property Stock As Integer
        Get
            Return _Stock
        End Get
        Set(value As Integer)
            _Stock = value
        End Set
    End Property
    <Required>
    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
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

    ' CONTRUCTORES 
    Public Sub New()
        Repository = New RepuestoRepository()
    End Sub

    'METODOS DEL OBJETO
    Public Function SaveChanges() As String
        Dim message As String = Nothing
        Try
            Dim repuestoDataModel As New Repuesto()
            repuestoDataModel.nroRepuesto = NroRepuesto
            repuestoDataModel.costoUnitario = Convert.ToDecimal(CostoUnitario)
            repuestoDataModel.puntoPedido = PuntoPedido
            repuestoDataModel.loteCompra = LoteCompra
            repuestoDataModel.Stock = Stock
            repuestoDataModel.Descripcion = Descripcion

            Select Case State
                Case EntityState.Added
                    Repository.Add(repuestoDataModel)
                    message = "Added"
                Case EntityState.Modified
                    Repository.Edit(repuestoDataModel)
                    message = "Modified"
                Case EntityState.Deleted
                    Repository.Remove(NroRepuesto)
                    message = "Remove"
            End Select
        Catch ex As Exception
            Repository.ClearListParameters()
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
    Public Function GetRepuestos() As List(Of RepuestoModel)
        Dim ListRepuestoDataModel = Repository.GetAll()
        ListRepuestoViewModel = New List(Of RepuestoModel)

        For Each item As Repuesto In ListRepuestoDataModel
            ListRepuestoViewModel.Add(New RepuestoModel With {
            .NroRepuesto = item.nroRepuesto,
                .CostoUnitario = item.costoUnitario,
                .PuntoPedido = item.puntoPedido,
                .LoteCompra = item.loteCompra,
                .Stock = item.Stock,
                .Descripcion = item.Descripcion
            })
        Next
        Return ListRepuestoViewModel
    End Function
    Public Function GetRepuestosByProv(idProv As Integer) As List(Of RepuestoModel)
        Dim ListRepuestoDataModel = Repository.GetAllByProv(idProv)
        ListRepuestoViewModel = New List(Of RepuestoModel)

        For Each item As Repuesto In ListRepuestoDataModel
            ListRepuestoViewModel.Add(New RepuestoModel With {
            .NroRepuesto = item.nroRepuesto,
                .CostoUnitario = item.costoUnitario,
                .PuntoPedido = item.puntoPedido,
                .LoteCompra = item.loteCompra,
                .Stock = item.Stock,
                .Descripcion = item.Descripcion
            })
        Next
        Return ListRepuestoViewModel
    End Function
    Public Function GetRepuestoForEquipo(Serial As String) As DataTable
        Return Repository.GetAllForList(Serial)
    End Function
    Public Function Find(filter As String) As IEnumerable(Of RepuestoModel)
        Return ListRepuestoViewModel.FindAll(Function(emp) emp.NroRepuesto.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0 OrElse emp.Descripcion.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
    End Function
    Public Function GetPrice(nroRepuesto As String) As Decimal
        Return Repository.GetPrice(nroRepuesto)
    End Function

#Region "Metodos del filtro"
    ' --- con Stock para el filtro
    Public Function GetRepSinStock() As List(Of RepuestoModel)
        Dim ListRepuestoDataModel = Repository.GetAllSinStock()
        ListRepuestoViewModel = New List(Of RepuestoModel)

        For Each item As Repuesto In ListRepuestoDataModel
            ListRepuestoViewModel.Add(New RepuestoModel With {
            .NroRepuesto = item.nroRepuesto,
                .CostoUnitario = item.costoUnitario,
                .PuntoPedido = item.puntoPedido,
                .LoteCompra = item.loteCompra,
                .Stock = item.Stock,
                .Descripcion = item.Descripcion
            })
        Next
        Return ListRepuestoViewModel
    End Function
    ' --- sin Stock para el filtro
    Public Function GetRepConStock() As List(Of RepuestoModel)
        Dim ListRepuestoDataModel = Repository.GetAllConStock()
        ListRepuestoViewModel = New List(Of RepuestoModel)

        For Each item As Repuesto In ListRepuestoDataModel
            ListRepuestoViewModel.Add(New RepuestoModel With {
            .NroRepuesto = item.nroRepuesto,
                .CostoUnitario = item.costoUnitario,
                .PuntoPedido = item.puntoPedido,
                .LoteCompra = item.loteCompra,
                .Stock = item.Stock,
                .Descripcion = item.Descripcion
            })
        Next
        Return ListRepuestoViewModel
    End Function
#End Region
End Class
