Imports Domain
Public Class FormLogin
#Region "Botonos de la ventana"
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region
#Region "Modificando los controles"
    Private Sub CustomizeControls()
        TxtPass.AutoSize = False
        TxtUser.AutoSize = False
        TxtPass.Size = New Size(200, 26)
        TxtUser.Size = New Size(200, 26)
        TxtPass.UseSystemPasswordChar = True
    End Sub

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CustomizeControls()
    End Sub
#End Region

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim userModel As New UserModel()
        Dim validLogin = userModel.GetUser(TxtUser.Text.Trim, TxtPass.Text.Trim)
        If validLogin = True Then
            Dim frm As New FormHome
            frm.Show()
            AddHandler frm.FormClosed, AddressOf Me.Logout
            Me.Hide()
        Else
            Dim formulario As FormError
            formulario = New FormError With {
                .mensaje = "Username o password incorrectos" + vbNewLine + "Intentelo de nuevo",
                .formato = True
                }
            formulario.ShowDialog()
            TxtPass.Clear()
            TxtUser.Focus()
        End If
    End Sub
    Private Sub Logout(sender As Object, e As FormClosedEventArgs)
        TxtUser.Clear()
        TxtPass.Clear()
        Me.Show()
        TxtUser.Focus()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim frm As FormRecuperarContraseña
        frm = New FormRecuperarContraseña
        frm.ShowDialog()
    End Sub

End Class