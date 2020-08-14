Imports DataAccess
Imports System.ComponentModel.DataAnnotations
Public Class FacturaModel
    Private _nroFactura As Integer
    Private _FK_Cliente As Integer
    Private _Letra As Char
    Private _Fecha As Date
    Private _Cantidad As Integer
    Private _precioUnitario As Decimal
    Private _Total As Decimal
    Private _State As EntityState

    Private Repository As IFacturaRepository
    Private ListFacturaViewModel As List(Of FacturaModel)

#Region "Propiedades, modelos de vista y validacion de datos"
    <Required>
    Public Property NroFactura As Integer
        Get
            Return _nroFactura
        End Get
        Set(value As Integer)
            _nroFactura = value
        End Set
    End Property

    <Required>
    Public Property FK_Cliente As Integer
        Get
            Return _FK_Cliente
        End Get
        Set(value As Integer)
            _FK_Cliente = value
        End Set
    End Property

    <Required>
    Public Property Letra As Char
        Get
            Return _Letra
        End Get
        Set(value As Char)
            _Letra = value
        End Set
    End Property

    <Required>
    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(value As Date)
            _Fecha = value
        End Set
    End Property

    <Required>
    Public Property Cantidad As Integer
        Get
            Return _Cantidad
        End Get
        Set(value As Integer)
            _Cantidad = value
        End Set
    End Property

    <Required>
    Public Property PrecioUnitario As Decimal
        Get
            Return _precioUnitario
        End Get
        Set(value As Decimal)
            _precioUnitario = value
        End Set
    End Property

    <Required>
    Public Property Total As Decimal
        Get
            Return _Total
        End Get
        Set(value As Decimal)
            _Total = value
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
        Repository = New FacturaRepository()
    End Sub
    Public Function SaveChanges() As String
        Dim message As String = Nothing
        Try
            Dim facturaDataModel As New Factura()

            facturaDataModel.nroFactura = NroFactura
            facturaDataModel.FK_Cliente = FK_Cliente
            facturaDataModel.Letra = Letra
            facturaDataModel.Fecha = Fecha
            facturaDataModel.Cantidad = Cantidad
            facturaDataModel.precioUnitario = PrecioUnitario
            facturaDataModel.Total = Total

            Select Case State
                Case EntityState.Added
                    Repository.Add(facturaDataModel)
                    message = "Success Added"
                Case EntityState.Modified
                    Repository.Edit(facturaDataModel)
                    message = "Success Modified"
                Case EntityState.Deleted
                    Repository.Remove(NroFactura)
                    message = "Success Remove"
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
    Public Function GetFacturas() As List(Of FacturaModel)
        Dim ListFacturarDataModel = Repository.GetAll()
        ListFacturaViewModel = New List(Of FacturaModel)

        For Each item As Factura In ListFacturarDataModel
            ListFacturaViewModel.Add(New FacturaModel With {
            .NroFactura = item.nroFactura,
            .FK_Cliente = item.FK_Cliente,
            .Letra = item.Letra,
            .Fecha = item.Fecha,
            .Cantidad = item.Cantidad,
            .PrecioUnitario = item.precioUnitario,
            .Total = item.Total
            })
        Next
        Return ListFacturaViewModel
    End Function
    Public Function GetLastFacturas(id As Integer) As DataTable
        Return Repository.LastsFacturaByCliente(id)
    End Function

End Class
