<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.BtnMinimizar = New System.Windows.Forms.PictureBox()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.PanelLogin = New System.Windows.Forms.Panel()
        Me.LineaUserName = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RememberMe = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.BtnLogin = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.LineaPassword = New System.Windows.Forms.Panel()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblUserName = New System.Windows.Forms.Label()
        Me.Icono = New System.Windows.Forms.PictureBox()
        Me.ElipseLogin = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.DragControlContenedor = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.DragControlFondo = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PanelContenedor.SuspendLayout()
        CType(Me.BtnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLogin.SuspendLayout()
        CType(Me.Icono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.PanelContenedor.Controls.Add(Me.BtnMinimizar)
        Me.PanelContenedor.Controls.Add(Me.BtnCerrar)
        Me.PanelContenedor.Controls.Add(Me.PanelLogin)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelContenedor.Location = New System.Drawing.Point(200, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(400, 450)
        Me.PanelContenedor.TabIndex = 1
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimizar.Image = CType(resources.GetObject("BtnMinimizar.Image"), System.Drawing.Image)
        Me.BtnMinimizar.Location = New System.Drawing.Point(340, 3)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(25, 24)
        Me.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnMinimizar.TabIndex = 2
        Me.BtnMinimizar.TabStop = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(371, 3)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(24, 24)
        Me.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnCerrar.TabIndex = 1
        Me.BtnCerrar.TabStop = False
        '
        'PanelLogin
        '
        Me.PanelLogin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelLogin.BackColor = System.Drawing.Color.White
        Me.PanelLogin.Controls.Add(Me.LineaUserName)
        Me.PanelLogin.Controls.Add(Me.Panel1)
        Me.PanelLogin.Controls.Add(Me.RememberMe)
        Me.PanelLogin.Controls.Add(Me.LinkLabel1)
        Me.PanelLogin.Controls.Add(Me.BtnLogin)
        Me.PanelLogin.Controls.Add(Me.LineaPassword)
        Me.PanelLogin.Controls.Add(Me.TxtPass)
        Me.PanelLogin.Controls.Add(Me.TxtUser)
        Me.PanelLogin.Controls.Add(Me.LblPassword)
        Me.PanelLogin.Controls.Add(Me.LblUserName)
        Me.PanelLogin.Location = New System.Drawing.Point(75, 50)
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.Size = New System.Drawing.Size(250, 350)
        Me.PanelLogin.TabIndex = 0
        '
        'LineaUserName
        '
        Me.LineaUserName.BackColor = System.Drawing.SystemColors.ControlDark
        Me.LineaUserName.Location = New System.Drawing.Point(26, 82)
        Me.LineaUserName.Name = "LineaUserName"
        Me.LineaUserName.Size = New System.Drawing.Size(200, 1)
        Me.LineaUserName.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(45, 289)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(160, 1)
        Me.Panel1.TabIndex = 12
        '
        'RememberMe
        '
        Me.RememberMe.AutoSize = True
        Me.RememberMe.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RememberMe.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RememberMe.Location = New System.Drawing.Point(26, 185)
        Me.RememberMe.Name = "RememberMe"
        Me.RememberMe.Size = New System.Drawing.Size(98, 17)
        Me.RememberMe.TabIndex = 11
        Me.RememberMe.Text = "Remember me"
        Me.RememberMe.UseVisualStyleBackColor = True
        Me.RememberMe.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.DodgerBlue
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DarkGray
        Me.LinkLabel1.Location = New System.Drawing.Point(78, 308)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(91, 13)
        Me.LinkLabel1.TabIndex = 10
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Forgot password?"
        '
        'BtnLogin
        '
        Me.BtnLogin.AllowToggling = False
        Me.BtnLogin.AnimationSpeed = 200
        Me.BtnLogin.AutoGenerateColors = False
        Me.BtnLogin.BackColor = System.Drawing.Color.Transparent
        Me.BtnLogin.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.BtnLogin.BackgroundImage = CType(resources.GetObject("BtnLogin.BackgroundImage"), System.Drawing.Image)
        Me.BtnLogin.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BtnLogin.ButtonText = "Login"
        Me.BtnLogin.ButtonTextMarginLeft = 0
        Me.BtnLogin.ColorContrastOnClick = 45
        Me.BtnLogin.ColorContrastOnHover = 45
        Me.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.BtnLogin.CustomizableEdges = BorderEdges1
        Me.BtnLogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnLogin.DisabledBorderColor = System.Drawing.Color.Empty
        Me.BtnLogin.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnLogin.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BtnLogin.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BtnLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.BtnLogin.ForeColor = System.Drawing.Color.White
        Me.BtnLogin.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogin.IconMarginLeft = 11
        Me.BtnLogin.IconPadding = 10
        Me.BtnLogin.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogin.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.BtnLogin.IdleBorderRadius = 5
        Me.BtnLogin.IdleBorderThickness = 1
        Me.BtnLogin.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.BtnLogin.IdleIconLeftImage = Nothing
        Me.BtnLogin.IdleIconRightImage = Nothing
        Me.BtnLogin.IndicateFocus = False
        Me.BtnLogin.Location = New System.Drawing.Point(50, 227)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLogin.onHoverState.BorderRadius = 5
        Me.BtnLogin.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BtnLogin.onHoverState.BorderThickness = 1
        Me.BtnLogin.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLogin.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BtnLogin.onHoverState.IconLeftImage = Nothing
        Me.BtnLogin.onHoverState.IconRightImage = Nothing
        Me.BtnLogin.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.BtnLogin.OnIdleState.BorderRadius = 5
        Me.BtnLogin.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BtnLogin.OnIdleState.BorderThickness = 1
        Me.BtnLogin.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue
        Me.BtnLogin.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.BtnLogin.OnIdleState.IconLeftImage = Nothing
        Me.BtnLogin.OnIdleState.IconRightImage = Nothing
        Me.BtnLogin.OnPressedState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.BtnLogin.OnPressedState.BorderRadius = 5
        Me.BtnLogin.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BtnLogin.OnPressedState.BorderThickness = 1
        Me.BtnLogin.OnPressedState.FillColor = System.Drawing.Color.DodgerBlue
        Me.BtnLogin.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BtnLogin.OnPressedState.IconLeftImage = Nothing
        Me.BtnLogin.OnPressedState.IconRightImage = Nothing
        Me.BtnLogin.Size = New System.Drawing.Size(150, 35)
        Me.BtnLogin.TabIndex = 9
        Me.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnLogin.TextMarginLeft = 0
        Me.BtnLogin.UseDefaultRadiusAndThickness = True
        '
        'LineaPassword
        '
        Me.LineaPassword.BackColor = System.Drawing.SystemColors.ControlDark
        Me.LineaPassword.Location = New System.Drawing.Point(25, 153)
        Me.LineaPassword.Name = "LineaPassword"
        Me.LineaPassword.Size = New System.Drawing.Size(200, 1)
        Me.LineaPassword.TabIndex = 8
        '
        'TxtPass
        '
        Me.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPass.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtPass.Location = New System.Drawing.Point(25, 131)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(200, 18)
        Me.TxtPass.TabIndex = 7
        '
        'TxtUser
        '
        Me.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUser.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUser.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtUser.Location = New System.Drawing.Point(26, 60)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(200, 18)
        Me.TxtUser.TabIndex = 6
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!)
        Me.LblPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LblPassword.Location = New System.Drawing.Point(22, 103)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(73, 20)
        Me.LblPassword.TabIndex = 4
        Me.LblPassword.Text = "Password"
        '
        'LblUserName
        '
        Me.LblUserName.AutoSize = True
        Me.LblUserName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!)
        Me.LblUserName.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LblUserName.Location = New System.Drawing.Point(22, 32)
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.Size = New System.Drawing.Size(81, 20)
        Me.LblUserName.TabIndex = 3
        Me.LblUserName.Text = "UserName"
        '
        'Icono
        '
        Me.Icono.Image = CType(resources.GetObject("Icono.Image"), System.Drawing.Image)
        Me.Icono.Location = New System.Drawing.Point(0, 120)
        Me.Icono.Name = "Icono"
        Me.Icono.Size = New System.Drawing.Size(200, 200)
        Me.Icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Icono.TabIndex = 2
        Me.Icono.TabStop = False
        '
        'ElipseLogin
        '
        Me.ElipseLogin.ElipseRadius = 7
        Me.ElipseLogin.TargetControl = Me
        '
        'DragControlContenedor
        '
        Me.DragControlContenedor.Fixed = True
        Me.DragControlContenedor.Horizontal = True
        Me.DragControlContenedor.TargetControl = Me.PanelContenedor
        Me.DragControlContenedor.Vertical = True
        '
        'DragControlFondo
        '
        Me.DragControlFondo.Fixed = True
        Me.DragControlFondo.Horizontal = True
        Me.DragControlFondo.TargetControl = Me
        Me.DragControlFondo.Vertical = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 450)
        Me.Controls.Add(Me.Icono)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.PanelContenedor.ResumeLayout(False)
        CType(Me.BtnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLogin.ResumeLayout(False)
        Me.PanelLogin.PerformLayout()
        CType(Me.Icono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PanelLogin As Panel
    Friend WithEvents Icono As PictureBox
    Friend WithEvents ElipseLogin As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents BtnMinimizar As PictureBox
    Friend WithEvents DragControlContenedor As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents DragControlFondo As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents LineaUserName As Panel
    Friend WithEvents LineaPassword As Panel
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblUserName As Label
    Friend WithEvents BtnLogin As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents RememberMe As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Panel1 As Panel
End Class
