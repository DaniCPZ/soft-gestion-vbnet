Public Class FormError
    Public mensaje As String
    Public formato As Boolean
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Me.Close()
    End Sub

    Private Sub TimerOpacity_Tick(sender As Object, e As EventArgs) Handles TimerOpacity.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.15
        Else
            TimerOpacity.Stop()
        End If
    End Sub

    Private Sub FormError_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If formato Then
            Me.lblMessage.Text = AlinearTexto()
        Else
            Me.lblMessage.Text = mensaje
        End If

        Me.Opacity = 0
        TimerOpacity.Start()

    End Sub
    Private Function AlinearTexto() As String
        Dim font = New Font("Segoe UI", 11.25)
        Dim matriz = mensaje.Split(" ")
        Dim newMsg As String
        Dim lineaMsg As String
        lineaMsg = ""
        newMsg = ""
        For Each cadena As String In matriz
            Dim txtSize = TextRenderer.MeasureText(lineaMsg & cadena & " ", font)
            If txtSize.Width < 260 Then
                lineaMsg = lineaMsg & cadena & " "
            Else
                newMsg = newMsg & lineaMsg & vbNewLine
                lineaMsg = cadena + " "
            End If
        Next
        newMsg = newMsg & lineaMsg
        Return newMsg
    End Function
End Class