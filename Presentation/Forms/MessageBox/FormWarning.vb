Public Class FormWarning
    Public State As Boolean
    Public mensaje As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        State = True
        Me.Close()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        State = False
        Me.Close()
    End Sub

    Private Sub TimerOpacity_Tick(sender As Object, e As EventArgs) Handles TimerOpacity.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.15
        Else
            TimerOpacity.Stop()
        End If
    End Sub

    Private Sub FormImportant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblMessage.Text = mensaje
        Me.Opacity = 0
        TimerOpacity.Start()
    End Sub

End Class