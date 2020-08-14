Imports Common
Public Class FormHome

#Region "FUNCIONALIDADES DEL FORMULARIO"
    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUserName.Text = ActiveUser.Apellido + " " + ActiveUser.Nombre + ", " + ActiveUser.Cargo
        Seguridad()
    End Sub

    Dim cGrip As Integer = 10
    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL' 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15
    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PanelContenedor.Region = region
        Me.Invalidate()
    End Sub
    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR'
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(244, 244, 244))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Dim lx, ly As Integer
    Dim sw, sh As Integer

    Private Sub BtnMaximizar_Click(sender As Object, e As EventArgs) Handles BtnMaximizar.Click
        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height

        BtnMaximizar.Visible = False
        BtnRestaurar.Visible = True

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub

    Private Sub BtnRestaurar_Click(sender As Object, e As EventArgs) Handles BtnRestaurar.Click
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)

        BtnRestaurar.Visible = False
        BtnMaximizar.Visible = True
    End Sub



#End Region

#Region "BOTONES DEL MENU PRINCIPAL "
    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        AbrirFormEnPanel(Of FormClientes)()
        BtnClientes.BackColor = Color.FromArgb(0, 136, 255)
    End Sub
    Private Sub BtnProveedores_Click(sender As Object, e As EventArgs) Handles BtnProveedores.Click
        AbrirFormEnPanel(Of FormProveedores)()
        BtnProveedores.BackColor = Color.FromArgb(0, 136, 255)
    End Sub
    Private Sub BtnEquipos_Click(sender As Object, e As EventArgs) Handles BtnEquipos.Click
        AbrirFormEnPanel(Of FormEquipos)()
        BtnEquipos.BackColor = Color.FromArgb(0, 136, 255)
    End Sub
    Private Sub BtnAlquileres_Click(sender As Object, e As EventArgs) Handles BtnAlquileres.Click
        AbrirFormEnPanel(Of FormAlquileres)()
        BtnAlquileres.BackColor = Color.FromArgb(0, 136, 255)
    End Sub
    Private Sub BtnRepuestos_Click(sender As Object, e As EventArgs) Handles BtnRepuestos.Click
        AbrirFormEnPanel(Of FormRepuestos)()
        BtnRepuestos.BackColor = Color.FromArgb(0, 136, 255)
    End Sub
    Private Sub BtnServicios_Click(sender As Object, e As EventArgs) Handles BtnServicios.Click
        AbrirFormEnPanel(Of FormServicios)()
        BtnServicios.BackColor = Color.FromArgb(0, 136, 255)
    End Sub
    Private Sub BtnFacturas_Click(sender As Object, e As EventArgs) Handles BtnFacturas.Click
        AbrirFormEnPanel(Of FormFacturas)()
        BtnFacturas.BackColor = Color.FromArgb(0, 136, 255)
    End Sub
    Private Sub BtnCobranzas_Click(sender As Object, e As EventArgs) Handles BtnCobranzas.Click
        AbrirFormEnPanel(Of FormPagos)()
        BtnCobranzas.BackColor = Color.FromArgb(0, 136, 255)
    End Sub
    Private Sub btnExtras_Click(sender As Object, e As EventArgs) Handles btnExtras.Click
        AbrirFormEnPanel(Of FormExtras)()
        btnExtras.BackColor = Color.FromArgb(0, 136, 255)
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        If PanelMenu.Width = 240 Then
            Me.PanelMenu.Width = 60
        ElseIf PanelMenu.Width = 60 Then
            Me.PanelMenu.Width = 240
        End If
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Dim formulario As FormWarning
        formulario = New FormWarning
        formulario.mensaje = "       ¿ Seguro desea cerrar sesion ?"
        formulario.ShowDialog()
        If formulario.State Then
            Me.Close()
        End If
    End Sub

    Private Sub btnEditarPerfil_Click(sender As Object, e As EventArgs) Handles btnEditarPerfil.Click
        Dim formulario As FormUser
        formulario = New FormUser
        formulario.ShowDialog()
    End Sub


    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = PanelFormularios.Controls.OfType(Of Miform)().FirstOrDefault()
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill
            PanelFormularios.Controls.Add(Formulario)
            PanelFormularios.Tag = Formulario
            AddHandler Formulario.FormClosed, AddressOf Me.CerrarFormulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If
    End Sub

    Private Sub CerrarFormulario(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        If (Application.OpenForms("FormClientes") Is Nothing) Then
            BtnClientes.BackColor = Color.FromArgb(50, 59, 70)
        End If
        If (Application.OpenForms("FormEquipos") Is Nothing) Then
            BtnEquipos.BackColor = Color.FromArgb(50, 59, 70)
        End If
        If (Application.OpenForms("FormAlquileres") Is Nothing) Then
            BtnAlquileres.BackColor = Color.FromArgb(50, 59, 70)
        End If
        If (Application.OpenForms("FormRepuestos") Is Nothing) Then
            BtnRepuestos.BackColor = Color.FromArgb(50, 59, 70)
        End If
        If (Application.OpenForms("FormServicios") Is Nothing) Then
            BtnServicios.BackColor = Color.FromArgb(50, 59, 70)
        End If
        If (Application.OpenForms("FormProveedores") Is Nothing) Then
            BtnProveedores.BackColor = Color.FromArgb(50, 59, 70)
        End If
        If (Application.OpenForms("FormFacturas") Is Nothing) Then
            BtnFacturas.BackColor = Color.FromArgb(50, 59, 70)
        End If
        If (Application.OpenForms("FormPagos") Is Nothing) Then
            BtnCobranzas.BackColor = Color.FromArgb(50, 59, 70)
        End If
        If (Application.OpenForms("FormExtras") Is Nothing) Then
            btnExtras.BackColor = Color.FromArgb(50, 59, 70)
        End If
    End Sub
#End Region

#Region "SEGURIDAD SOBRE MODULOS"
    Private Sub Seguridad()
        If ActiveUser.Cargo = Cargos.cobrador Then
            BtnProveedores.Enabled = False
            pnlProveedor.Visible = False

            BtnRepuestos.Enabled = False
            pnlRepuesto.Visible = False

            BtnAlquileres.Enabled = False
            pnlAlquiler.Visible = False

            BtnServicios.Enabled = False
            pnlServicio.Visible = False

            btnExtras.Enabled = False
            pnlExtra.Visible = False
        End If
        If ActiveUser.Cargo = Cargos.administrador Then
            btnExtras.Enabled = False
            pnlExtra.Visible = False
        End If
    End Sub
#End Region
End Class