Imports DataAccess
Imports System.ComponentModel.DataAnnotations
Public Class PagoModel

    Private _nroPago As Integer
    Private _FK_Cliente As Integer
    Private _tipoPago As String
    Private _Fecha As Date
    Private _Importe As Decimal
    Private _State As EntityState

    Private Repository As IPagoRepository
    Private ListPagoViewModel As List(Of PagoModel)

#Region "Propiedades, modelos de vista y validacion de datos"
    Public Property NroPago As Integer
        Get
            Return _nroPago
        End Get
        Set(value As Integer)
            _nroPago = value
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
    Public Property tipoPago As String
        Get
            Return _tipoPago
        End Get
        Set(value As String)
            _tipoPago = value
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
    Public Property Importe As Decimal
        Get
            Return _Importe
        End Get
        Set(value As Decimal)
            _Importe = value
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
        Repository = New PagoRepository()
    End Sub

    Public Function SaveChanges() As String
        Dim message As String = Nothing
        Try
            Dim pagoDataModel As New Pago()
            pagoDataModel.nroPago = NroPago
            pagoDataModel.FK_Cliente = FK_Cliente
            pagoDataModel.tipoPago = tipoPago
            pagoDataModel.Fecha = Fecha
            pagoDataModel.Importe = Importe

            Select Case State
                Case EntityState.Added
                    Repository.Add(pagoDataModel)
                    message = "Success Added"
                Case EntityState.Modified
                    Repository.Edit(pagoDataModel)
                    message = "Success Modified"
                Case EntityState.Deleted
                    Repository.Remove(NroPago)
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

    Public Function GetPagos() As List(Of PagoModel)
        Dim ListPagoDataModel = Repository.GetAll()
        ListPagoViewModel = New List(Of PagoModel)
        For Each item As Pago In ListPagoDataModel
            ListPagoViewModel.Add(New PagoModel With {
            .NroPago = item.nroPago,
            .FK_Cliente = item.FK_Cliente,
            .tipoPago = item.tipoPago,
            .Fecha = item.Fecha,
            .Importe = item.Importe
            })
        Next
        Return ListPagoViewModel
    End Function
    Public Function GetLastPagos(id As Integer) As DataTable
        Return Repository.LastsPagoByCliente(id)
    End Function
End Class
