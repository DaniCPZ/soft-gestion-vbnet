﻿Imports Domain
Public Class FormEditRepuesto
    Public nroRepuesto As String
    Dim repuestoModel As New RepuestoModel()
    Public state As Boolean
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim coste As Decimal
        Dim pp As Integer
        Dim loc As Integer
        Dim stock As Integer
        Dim msgCosto As String = "Costo unitario"
        Dim msgPp As String = "Punto de pedido"
        Dim msgLoc As String = "Lote de compra"
        Dim msgStock As String = "Stock"
        Dim msgFinal As String = ""

        repuestoModel.State = EntityState.Modified
        repuestoModel.NroRepuesto = TxtNroRepuesto.Text.Trim.ToUpper
        repuestoModel.Descripcion = TxtDesc.Text.Trim.ToUpper

        Dim validoCoste = New ValidacionesExtras(TxtCostoUnitario.Text).ToDecimal(msgCosto, coste)
        Dim validoPp = New ValidacionesExtras(TxtPP.Text).ToInteger(msgPp, pp)
        Dim validoLoc = New ValidacionesExtras(TxtLoteCompra.Text).ToInteger(msgLoc, loc)
        Dim validoStock = New ValidacionesExtras(TxtStock.Text).ToInteger(msgStock, stock)
        Dim valid = New DataValidation(repuestoModel).validate(msgFinal)

        If validoCoste And validoPp And validoLoc And validoStock And valid Then
            repuestoModel.CostoUnitario = coste
            repuestoModel.PuntoPedido = pp
            repuestoModel.LoteCompra = loc
            repuestoModel.Stock = stock
            Dim result = repuestoModel.SaveChanges()
            If result = "Modified" Then
                state = True
                Me.Close()
            End If
        Else
            If Not validoCoste Then msgFinal += msgCosto + vbNewLine
            If Not validoPp Then msgFinal += msgPp + vbNewLine
            If Not validoLoc Then msgFinal += msgLoc + vbNewLine
            If Not validoStock Then msgFinal += msgStock + vbNewLine
            MsgBox(msgFinal)
        End If
    End Sub
End Class