Imports Domain
Imports Transitions
Public Class FormNuevoContador
    Dim contadorModel As New ContadorModel()
    Public nroAlquiler As Integer
    Dim ultimocontador As Integer
    Public state As Boolean

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim resultado As Integer
        If Integer.TryParse(TextBox1.Text, resultado) Then
            lblCopiasRealizadas.Text = (resultado - Convert.ToInt32(Label2.Text)).ToString()
        Else
            lblCopiasRealizadas.Text = "0"
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not IsNumeric(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub FormNuevoContador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarControler()
    End Sub
    Private Sub cargarControler()
        ultimocontador = contadorModel.LastContador(nroAlquiler)
        Label2.Text = ultimocontador.ToString
        TextBox1.AutoSize = False
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        TextBox1.AutoSize = False
        Dim t As New Transition(New TransitionType_Flash(2, 400))
        If TextBox1.Text = "" Then
            t.add(Me.TextBox1, "Height", 35)
            t.add(Me.TextBox1, "Width", 110)
            '102; 179
            t.add(Me.TextBox1, "Left", 95)
            t.add(Me.TextBox1, "Top", 175)
            t.run()
            TextBox1.Focus()
        ElseIf Convert.ToInt32(TextBox1.Text) <= ultimocontador Then
            Dim formulario As FormError
            formulario = New FormError With {
                .mensaje = "    El valor del contador actual debe superar al anterior"
            }
            formulario.ShowDialog()
        Else
            state = True
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        state = False
        Me.Close()
    End Sub
End Class