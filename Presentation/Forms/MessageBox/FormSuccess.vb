Public Class FormSuccess
    Public mensaje As String
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

    Private Sub FormSuccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label2.Text = mensaje
        Me.Opacity = 0
        TimerOpacity.Start()
    End Sub


End Class