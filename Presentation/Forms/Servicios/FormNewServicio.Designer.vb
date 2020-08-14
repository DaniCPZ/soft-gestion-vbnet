<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNewServicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNewServicio))
        Dim Animation1 As Utilities.BunifuPages.BunifuAnimatorNS.Animation = New Utilities.BunifuPages.BunifuAnimatorNS.Animation()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ElipseLogin = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnSiguiente1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BunifuCheckBox3 = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.BunifuCheckBox2 = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.BunifuCheckBox1 = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BunifuPage1 = New Bunifu.UI.WinForms.BunifuPages()
        Me.NuevoServicio = New System.Windows.Forms.TabPage()
        Me.TxtObservacion = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblOb = New System.Windows.Forms.Label()
        Me.CmbAlquiler = New System.Windows.Forms.ComboBox()
        Me.LblCliente = New System.Windows.Forms.Label()
        Me.DetalleServicio = New System.Windows.Forms.TabPage()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiente2 = New System.Windows.Forms.Button()
        Me.Final = New System.Windows.Forms.TabPage()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.DragControlVentana = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.BunifuPage1.SuspendLayout()
        Me.NuevoServicio.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DetalleServicio.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Final.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(570, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'ElipseLogin
        '
        Me.ElipseLogin.ElipseRadius = 7
        Me.ElipseLogin.TargetControl = Me.btnSiguiente1
        '
        'btnSiguiente1
        '
        Me.btnSiguiente1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnSiguiente1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSiguiente1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnSiguiente1.FlatAppearance.BorderSize = 0
        Me.btnSiguiente1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguiente1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente1.ForeColor = System.Drawing.Color.White
        Me.btnSiguiente1.Location = New System.Drawing.Point(432, 349)
        Me.btnSiguiente1.Name = "btnSiguiente1"
        Me.btnSiguiente1.Size = New System.Drawing.Size(119, 32)
        Me.btnSiguiente1.TabIndex = 46
        Me.btnSiguiente1.Text = "Siguiente"
        Me.btnSiguiente1.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.BunifuCheckBox3)
        Me.Panel3.Controls.Add(Me.BunifuCheckBox2)
        Me.Panel3.Controls.Add(Me.BunifuCheckBox1)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.BunifuPage1)
        Me.Panel3.Location = New System.Drawing.Point(12, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(583, 486)
        Me.Panel3.TabIndex = 20
        '
        'BunifuCheckBox3
        '
        Me.BunifuCheckBox3.AllowBindingControlAnimation = True
        Me.BunifuCheckBox3.AllowBindingControlColorChanges = False
        Me.BunifuCheckBox3.AllowBindingControlLocation = True
        Me.BunifuCheckBox3.AllowCheckBoxAnimation = False
        Me.BunifuCheckBox3.AllowCheckmarkAnimation = True
        Me.BunifuCheckBox3.AllowOnHoverStates = True
        Me.BunifuCheckBox3.AutoCheck = False
        Me.BunifuCheckBox3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox3.BackgroundImage = CType(resources.GetObject("BunifuCheckBox3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuCheckBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuCheckBox3.BindingControl = Nothing
        Me.BunifuCheckBox3.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right
        Me.BunifuCheckBox3.Checked = True
        Me.BunifuCheckBox3.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked
        Me.BunifuCheckBox3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuCheckBox3.CustomCheckmarkImage = Nothing
        Me.BunifuCheckBox3.Enabled = False
        Me.BunifuCheckBox3.Location = New System.Drawing.Point(444, 10)
        Me.BunifuCheckBox3.MinimumSize = New System.Drawing.Size(17, 17)
        Me.BunifuCheckBox3.Name = "BunifuCheckBox3"
        Me.BunifuCheckBox3.OnCheck.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckBox3.OnCheck.BorderRadius = 2
        Me.BunifuCheckBox3.OnCheck.BorderThickness = 2
        Me.BunifuCheckBox3.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckBox3.OnCheck.CheckmarkColor = System.Drawing.Color.White
        Me.BunifuCheckBox3.OnCheck.CheckmarkThickness = 2
        Me.BunifuCheckBox3.OnDisable.BorderColor = System.Drawing.Color.LightGray
        Me.BunifuCheckBox3.OnDisable.BorderRadius = 2
        Me.BunifuCheckBox3.OnDisable.BorderThickness = 2
        Me.BunifuCheckBox3.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox3.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray
        Me.BunifuCheckBox3.OnDisable.CheckmarkThickness = 2
        Me.BunifuCheckBox3.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckBox3.OnHoverChecked.BorderRadius = 2
        Me.BunifuCheckBox3.OnHoverChecked.BorderThickness = 2
        Me.BunifuCheckBox3.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckBox3.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White
        Me.BunifuCheckBox3.OnHoverChecked.CheckmarkThickness = 2
        Me.BunifuCheckBox3.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckBox3.OnHoverUnchecked.BorderRadius = 2
        Me.BunifuCheckBox3.OnHoverUnchecked.BorderThickness = 1
        Me.BunifuCheckBox3.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox3.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckBox3.OnUncheck.BorderRadius = 2
        Me.BunifuCheckBox3.OnUncheck.BorderThickness = 1
        Me.BunifuCheckBox3.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox3.Size = New System.Drawing.Size(21, 21)
        Me.BunifuCheckBox3.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu
        Me.BunifuCheckBox3.TabIndex = 28
        Me.BunifuCheckBox3.ThreeState = False
        Me.BunifuCheckBox3.ToolTipText = Nothing
        '
        'BunifuCheckBox2
        '
        Me.BunifuCheckBox2.AllowBindingControlAnimation = True
        Me.BunifuCheckBox2.AllowBindingControlColorChanges = False
        Me.BunifuCheckBox2.AllowBindingControlLocation = True
        Me.BunifuCheckBox2.AllowCheckBoxAnimation = False
        Me.BunifuCheckBox2.AllowCheckmarkAnimation = True
        Me.BunifuCheckBox2.AllowOnHoverStates = True
        Me.BunifuCheckBox2.AutoCheck = False
        Me.BunifuCheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox2.BackgroundImage = CType(resources.GetObject("BunifuCheckBox2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuCheckBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuCheckBox2.BindingControl = Nothing
        Me.BunifuCheckBox2.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right
        Me.BunifuCheckBox2.Checked = True
        Me.BunifuCheckBox2.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked
        Me.BunifuCheckBox2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuCheckBox2.CustomCheckmarkImage = Nothing
        Me.BunifuCheckBox2.Enabled = False
        Me.BunifuCheckBox2.Location = New System.Drawing.Point(240, 9)
        Me.BunifuCheckBox2.MinimumSize = New System.Drawing.Size(17, 17)
        Me.BunifuCheckBox2.Name = "BunifuCheckBox2"
        Me.BunifuCheckBox2.OnCheck.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckBox2.OnCheck.BorderRadius = 2
        Me.BunifuCheckBox2.OnCheck.BorderThickness = 2
        Me.BunifuCheckBox2.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckBox2.OnCheck.CheckmarkColor = System.Drawing.Color.White
        Me.BunifuCheckBox2.OnCheck.CheckmarkThickness = 2
        Me.BunifuCheckBox2.OnDisable.BorderColor = System.Drawing.Color.LightGray
        Me.BunifuCheckBox2.OnDisable.BorderRadius = 2
        Me.BunifuCheckBox2.OnDisable.BorderThickness = 2
        Me.BunifuCheckBox2.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox2.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray
        Me.BunifuCheckBox2.OnDisable.CheckmarkThickness = 2
        Me.BunifuCheckBox2.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckBox2.OnHoverChecked.BorderRadius = 2
        Me.BunifuCheckBox2.OnHoverChecked.BorderThickness = 2
        Me.BunifuCheckBox2.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckBox2.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White
        Me.BunifuCheckBox2.OnHoverChecked.CheckmarkThickness = 2
        Me.BunifuCheckBox2.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckBox2.OnHoverUnchecked.BorderRadius = 2
        Me.BunifuCheckBox2.OnHoverUnchecked.BorderThickness = 1
        Me.BunifuCheckBox2.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox2.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckBox2.OnUncheck.BorderRadius = 2
        Me.BunifuCheckBox2.OnUncheck.BorderThickness = 1
        Me.BunifuCheckBox2.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox2.Size = New System.Drawing.Size(21, 21)
        Me.BunifuCheckBox2.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu
        Me.BunifuCheckBox2.TabIndex = 27
        Me.BunifuCheckBox2.ThreeState = False
        Me.BunifuCheckBox2.ToolTipText = Nothing
        '
        'BunifuCheckBox1
        '
        Me.BunifuCheckBox1.AllowBindingControlAnimation = True
        Me.BunifuCheckBox1.AllowBindingControlColorChanges = False
        Me.BunifuCheckBox1.AllowBindingControlLocation = True
        Me.BunifuCheckBox1.AllowCheckBoxAnimation = False
        Me.BunifuCheckBox1.AllowCheckmarkAnimation = True
        Me.BunifuCheckBox1.AllowOnHoverStates = True
        Me.BunifuCheckBox1.AutoCheck = False
        Me.BunifuCheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox1.BackgroundImage = CType(resources.GetObject("BunifuCheckBox1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuCheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuCheckBox1.BindingControl = Nothing
        Me.BunifuCheckBox1.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right
        Me.BunifuCheckBox1.Checked = True
        Me.BunifuCheckBox1.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked
        Me.BunifuCheckBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuCheckBox1.CustomCheckmarkImage = Nothing
        Me.BunifuCheckBox1.Enabled = False
        Me.BunifuCheckBox1.Location = New System.Drawing.Point(35, 11)
        Me.BunifuCheckBox1.MinimumSize = New System.Drawing.Size(17, 17)
        Me.BunifuCheckBox1.Name = "BunifuCheckBox1"
        Me.BunifuCheckBox1.OnCheck.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckBox1.OnCheck.BorderRadius = 2
        Me.BunifuCheckBox1.OnCheck.BorderThickness = 2
        Me.BunifuCheckBox1.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckBox1.OnCheck.CheckmarkColor = System.Drawing.Color.White
        Me.BunifuCheckBox1.OnCheck.CheckmarkThickness = 2
        Me.BunifuCheckBox1.OnDisable.BorderColor = System.Drawing.Color.LightGray
        Me.BunifuCheckBox1.OnDisable.BorderRadius = 2
        Me.BunifuCheckBox1.OnDisable.BorderThickness = 2
        Me.BunifuCheckBox1.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox1.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray
        Me.BunifuCheckBox1.OnDisable.CheckmarkThickness = 2
        Me.BunifuCheckBox1.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckBox1.OnHoverChecked.BorderRadius = 2
        Me.BunifuCheckBox1.OnHoverChecked.BorderThickness = 2
        Me.BunifuCheckBox1.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckBox1.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White
        Me.BunifuCheckBox1.OnHoverChecked.CheckmarkThickness = 2
        Me.BunifuCheckBox1.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckBox1.OnHoverUnchecked.BorderRadius = 2
        Me.BunifuCheckBox1.OnHoverUnchecked.BorderThickness = 1
        Me.BunifuCheckBox1.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox1.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckBox1.OnUncheck.BorderRadius = 2
        Me.BunifuCheckBox1.OnUncheck.BorderThickness = 1
        Me.BunifuCheckBox1.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox1.Size = New System.Drawing.Size(21, 21)
        Me.BunifuCheckBox1.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu
        Me.BunifuCheckBox1.TabIndex = 26
        Me.BunifuCheckBox1.ThreeState = False
        Me.BunifuCheckBox1.ToolTipText = Nothing
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightGray
        Me.Panel4.ForeColor = System.Drawing.Color.Gray
        Me.Panel4.Location = New System.Drawing.Point(17, 43)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(550, 1)
        Me.Panel4.TabIndex = 23
        '
        'BunifuPage1
        '
        Me.BunifuPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.BunifuPage1.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.BunifuPage1.AllowTransitions = True
        Me.BunifuPage1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuPage1.Controls.Add(Me.NuevoServicio)
        Me.BunifuPage1.Controls.Add(Me.DetalleServicio)
        Me.BunifuPage1.Controls.Add(Me.Final)
        Me.BunifuPage1.Location = New System.Drawing.Point(3, 52)
        Me.BunifuPage1.Multiline = True
        Me.BunifuPage1.Name = "BunifuPage1"
        Me.BunifuPage1.Page = Me.NuevoServicio
        Me.BunifuPage1.PageIndex = 0
        Me.BunifuPage1.PageName = "NuevoServicio"
        Me.BunifuPage1.PageTitle = "NuevoServicio"
        Me.BunifuPage1.SelectedIndex = 0
        Me.BunifuPage1.Size = New System.Drawing.Size(577, 431)
        Me.BunifuPage1.TabIndex = 20
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.BunifuPage1.Transition = Animation1
        Me.BunifuPage1.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom
        '
        'NuevoServicio
        '
        Me.NuevoServicio.Controls.Add(Me.btnSiguiente1)
        Me.NuevoServicio.Controls.Add(Me.TxtObservacion)
        Me.NuevoServicio.Controls.Add(Me.PictureBox2)
        Me.NuevoServicio.Controls.Add(Me.lblOb)
        Me.NuevoServicio.Controls.Add(Me.CmbAlquiler)
        Me.NuevoServicio.Controls.Add(Me.LblCliente)
        Me.NuevoServicio.Location = New System.Drawing.Point(4, 4)
        Me.NuevoServicio.Name = "NuevoServicio"
        Me.NuevoServicio.Padding = New System.Windows.Forms.Padding(3)
        Me.NuevoServicio.Size = New System.Drawing.Size(569, 405)
        Me.NuevoServicio.TabIndex = 0
        Me.NuevoServicio.Text = "NuevoServicio"
        Me.NuevoServicio.UseVisualStyleBackColor = True
        '
        'TxtObservacion
        '
        Me.TxtObservacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtObservacion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObservacion.Location = New System.Drawing.Point(34, 199)
        Me.TxtObservacion.MaxLength = 150
        Me.TxtObservacion.Multiline = True
        Me.TxtObservacion.Name = "TxtObservacion"
        Me.TxtObservacion.Size = New System.Drawing.Size(228, 81)
        Me.TxtObservacion.TabIndex = 43
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(26, 190)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(250, 103)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 45
        Me.PictureBox2.TabStop = False
        '
        'lblOb
        '
        Me.lblOb.AutoSize = True
        Me.lblOb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOb.Location = New System.Drawing.Point(25, 168)
        Me.lblOb.Name = "lblOb"
        Me.lblOb.Size = New System.Drawing.Size(81, 17)
        Me.lblOb.TabIndex = 44
        Me.lblOb.Text = "Observacion"
        '
        'CmbAlquiler
        '
        Me.CmbAlquiler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAlquiler.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAlquiler.FormattingEnabled = True
        Me.CmbAlquiler.Location = New System.Drawing.Point(28, 91)
        Me.CmbAlquiler.Name = "CmbAlquiler"
        Me.CmbAlquiler.Size = New System.Drawing.Size(399, 25)
        Me.CmbAlquiler.TabIndex = 34
        '
        'LblCliente
        '
        Me.LblCliente.AllowDrop = True
        Me.LblCliente.AutoSize = True
        Me.LblCliente.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCliente.Location = New System.Drawing.Point(25, 58)
        Me.LblCliente.Name = "LblCliente"
        Me.LblCliente.Size = New System.Drawing.Size(52, 17)
        Me.LblCliente.TabIndex = 35
        Me.LblCliente.Text = "Alquiler"
        '
        'DetalleServicio
        '
        Me.DetalleServicio.AutoScroll = True
        Me.DetalleServicio.Controls.Add(Me.PictureBox3)
        Me.DetalleServicio.Controls.Add(Me.DataGridView2)
        Me.DetalleServicio.Controls.Add(Me.DataGridView1)
        Me.DetalleServicio.Controls.Add(Me.btnAnterior)
        Me.DetalleServicio.Controls.Add(Me.btnSiguiente2)
        Me.DetalleServicio.Location = New System.Drawing.Point(4, 4)
        Me.DetalleServicio.Name = "DetalleServicio"
        Me.DetalleServicio.Padding = New System.Windows.Forms.Padding(3)
        Me.DetalleServicio.Size = New System.Drawing.Size(569, 405)
        Me.DetalleServicio.TabIndex = 1
        Me.DetalleServicio.Text = "DetalleServicio"
        Me.DetalleServicio.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(279, 155)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 51
        Me.PictureBox3.TabStop = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeight = 30
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(317, 24)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(174, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(239, 291)
        Me.DataGridView2.TabIndex = 50
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(15, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(174, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(244, 291)
        Me.DataGridView1.TabIndex = 49
        '
        'btnAnterior
        '
        Me.btnAnterior.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnterior.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnAnterior.FlatAppearance.BorderSize = 0
        Me.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnterior.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.ForeColor = System.Drawing.Color.White
        Me.btnAnterior.Location = New System.Drawing.Point(24, 349)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(119, 32)
        Me.btnAnterior.TabIndex = 48
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'btnSiguiente2
        '
        Me.btnSiguiente2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnSiguiente2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSiguiente2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnSiguiente2.FlatAppearance.BorderSize = 0
        Me.btnSiguiente2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguiente2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente2.ForeColor = System.Drawing.Color.White
        Me.btnSiguiente2.Location = New System.Drawing.Point(432, 349)
        Me.btnSiguiente2.Name = "btnSiguiente2"
        Me.btnSiguiente2.Size = New System.Drawing.Size(119, 32)
        Me.btnSiguiente2.TabIndex = 47
        Me.btnSiguiente2.Text = "Siguiente"
        Me.btnSiguiente2.UseVisualStyleBackColor = False
        '
        'Final
        '
        Me.Final.Controls.Add(Me.btnFinalizar)
        Me.Final.Controls.Add(Me.PictureBox4)
        Me.Final.Location = New System.Drawing.Point(4, 4)
        Me.Final.Name = "Final"
        Me.Final.Padding = New System.Windows.Forms.Padding(3)
        Me.Final.Size = New System.Drawing.Size(569, 405)
        Me.Final.TabIndex = 2
        Me.Final.Text = "Final"
        Me.Final.UseVisualStyleBackColor = True
        '
        'btnFinalizar
        '
        Me.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnFinalizar.FlatAppearance.BorderSize = 0
        Me.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalizar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalizar.ForeColor = System.Drawing.Color.White
        Me.btnFinalizar.Location = New System.Drawing.Point(232, 250)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(119, 32)
        Me.btnFinalizar.TabIndex = 48
        Me.btnFinalizar.Text = "Finalizar"
        Me.btnFinalizar.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(224, 88)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(132, 98)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(482, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 17)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Finalizar"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.ForeColor = System.Drawing.Color.LightGray
        Me.Panel2.Location = New System.Drawing.Point(399, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(50, 1)
        Me.Panel2.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(273, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 17)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Repuestos utilizados"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.ForeColor = System.Drawing.Color.Gray
        Me.Panel1.Location = New System.Drawing.Point(196, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(50, 1)
        Me.Panel1.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(72, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Detalles del servicio"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 7
        Me.BunifuElipse1.TargetControl = Me.btnSiguiente2
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 7
        Me.BunifuElipse2.TargetControl = Me.btnAnterior
        '
        'DragControlVentana
        '
        Me.DragControlVentana.Fixed = True
        Me.DragControlVentana.Horizontal = True
        Me.DragControlVentana.TargetControl = Me
        Me.DragControlVentana.Vertical = True
        '
        'FormNewServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(607, 528)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormNewServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormNewServicio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.BunifuPage1.ResumeLayout(False)
        Me.NuevoServicio.ResumeLayout(False)
        Me.NuevoServicio.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DetalleServicio.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Final.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ElipseLogin As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BunifuPage1 As Bunifu.UI.WinForms.BunifuPages
    Friend WithEvents NuevoServicio As TabPage
    Friend WithEvents btnSiguiente1 As Button
    Friend WithEvents TxtObservacion As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblOb As Label
    Friend WithEvents DetalleServicio As TabPage
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSiguiente2 As Button
    Friend WithEvents Final As TabPage
    Friend WithEvents BunifuCheckBox3 As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents BunifuCheckBox2 As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents BunifuCheckBox1 As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents DragControlVentana As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents CmbAlquiler As ComboBox
    Friend WithEvents LblCliente As Label
End Class
