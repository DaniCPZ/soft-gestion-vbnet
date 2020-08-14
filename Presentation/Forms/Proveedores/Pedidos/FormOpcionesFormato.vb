Imports Domain
Public Class FormOpcionesFormato
    Public dgv As New DataGridView
    Public state As Boolean
    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim cE As New ExportarOffice
        Dim save As New SaveFileDialog
        save.Filter = "Archivo Excel | *.xlsx"
        If save.ShowDialog = Windows.Forms.DialogResult.OK Then
            cE.ExportarExcel(Me.dgv, save.FileName)
            state = True
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        state = False
        Me.Close()
    End Sub

    Private Sub btnWord_Click(sender As Object, e As EventArgs) Handles btnWord.Click
        Dim cE As New ExportarOffice
        cE.ExportarWord(dgv, "PEDIDO")
        state = True
        Me.Close()
    End Sub


End Class