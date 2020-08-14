<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRepuestos
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
        Dim Animation1 As Utilities.BunifuPages.BunifuAnimatorNS.Animation = New Utilities.BunifuPages.BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRepuestos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuPages1 = New Bunifu.UI.WinForms.BunifuPages()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MenuDesplegable = New System.Windows.Forms.Panel()
        Me.btnCancelarLetra = New System.Windows.Forms.Button()
        Me.btnCambiarLetra = New System.Windows.Forms.Button()
        Me.RbLarge = New System.Windows.Forms.RadioButton()
        Me.RbMedium = New System.Windows.Forms.RadioButton()
        Me.RbSmall = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnSubMenu = New System.Windows.Forms.Button()
        Me.btnExportarExcel = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.panelFilter = New System.Windows.Forms.Panel()
        Me.btnFilter1 = New System.Windows.Forms.PictureBox()
        Me.pnlFilterStock = New System.Windows.Forms.Panel()
        Me.rbSup = New System.Windows.Forms.RadioButton()
        Me.rbInf = New System.Windows.Forms.RadioButton()
        Me.btnAplicarFiltro = New System.Windows.Forms.Button()
        Me.cbStock = New System.Windows.Forms.CheckBox()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtBuscar1 = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnBorrar2 = New System.Windows.Forms.Button()
        Me.btnEditar2 = New System.Windows.Forms.Button()
        Me.btnNuevo2 = New System.Windows.Forms.Button()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnProveedores = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.BtnRepuestos = New System.Windows.Forms.Button()
        Me.ElipseTarget1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuPages1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.MenuDesplegable.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelFilter.SuspendLayout()
        CType(Me.btnFilter1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFilterStock.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuPages1
        '
        Me.BunifuPages1.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.BunifuPages1.AllowTransitions = True
        Me.BunifuPages1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuPages1.Controls.Add(Me.TabPage1)
        Me.BunifuPages1.Controls.Add(Me.TabPage3)
        Me.BunifuPages1.Location = New System.Drawing.Point(15, 37)
        Me.BunifuPages1.Multiline = True
        Me.BunifuPages1.Name = "BunifuPages1"
        Me.BunifuPages1.Page = Me.TabPage3
        Me.BunifuPages1.PageIndex = 1
        Me.BunifuPages1.PageName = "TabPage3"
        Me.BunifuPages1.PageTitle = "TabPage3"
        Me.BunifuPages1.SelectedIndex = 0
        Me.BunifuPages1.Size = New System.Drawing.Size(730, 555)
        Me.BunifuPages1.TabIndex = 7
        Animation1.AnimateOnlyDifferences = False
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
        Me.BunifuPages1.Transition = Animation1
        Me.BunifuPages1.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.MenuDesplegable)
        Me.TabPage1.Controls.Add(Me.BtnSubMenu)
        Me.TabPage1.Controls.Add(Me.btnExportarExcel)
        Me.TabPage1.Controls.Add(Me.btnBorrar)
        Me.TabPage1.Controls.Add(Me.btnEditar)
        Me.TabPage1.Controls.Add(Me.btnNuevo)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.txtBuscar)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.panelFilter)
        Me.TabPage1.Controls.Add(Me.Panel14)
        Me.TabPage1.Controls.Add(Me.Panel5)
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(722, 529)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'MenuDesplegable
        '
        Me.MenuDesplegable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuDesplegable.BackColor = System.Drawing.SystemColors.Control
        Me.MenuDesplegable.Controls.Add(Me.btnCancelarLetra)
        Me.MenuDesplegable.Controls.Add(Me.btnCambiarLetra)
        Me.MenuDesplegable.Controls.Add(Me.RbLarge)
        Me.MenuDesplegable.Controls.Add(Me.RbMedium)
        Me.MenuDesplegable.Controls.Add(Me.RbSmall)
        Me.MenuDesplegable.Controls.Add(Me.Label4)
        Me.MenuDesplegable.Location = New System.Drawing.Point(511, 44)
        Me.MenuDesplegable.Name = "MenuDesplegable"
        Me.MenuDesplegable.Size = New System.Drawing.Size(200, 100)
        Me.MenuDesplegable.TabIndex = 64
        Me.MenuDesplegable.Visible = False
        '
        'btnCancelarLetra
        '
        Me.btnCancelarLetra.Location = New System.Drawing.Point(110, 65)
        Me.btnCancelarLetra.Name = "btnCancelarLetra"
        Me.btnCancelarLetra.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarLetra.TabIndex = 5
        Me.btnCancelarLetra.Text = "Cancelar"
        Me.btnCancelarLetra.UseVisualStyleBackColor = True
        '
        'btnCambiarLetra
        '
        Me.btnCambiarLetra.Location = New System.Drawing.Point(29, 65)
        Me.btnCambiarLetra.Name = "btnCambiarLetra"
        Me.btnCambiarLetra.Size = New System.Drawing.Size(75, 23)
        Me.btnCambiarLetra.TabIndex = 4
        Me.btnCambiarLetra.Text = "Aplicar"
        Me.btnCambiarLetra.UseVisualStyleBackColor = True
        '
        'RbLarge
        '
        Me.RbLarge.AutoSize = True
        Me.RbLarge.Location = New System.Drawing.Point(129, 33)
        Me.RbLarge.Name = "RbLarge"
        Me.RbLarge.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RbLarge.Size = New System.Drawing.Size(31, 17)
        Me.RbLarge.TabIndex = 3
        Me.RbLarge.TabStop = True
        Me.RbLarge.Text = "L"
        Me.RbLarge.UseVisualStyleBackColor = True
        '
        'RbMedium
        '
        Me.RbMedium.AutoSize = True
        Me.RbMedium.Location = New System.Drawing.Point(72, 33)
        Me.RbMedium.Name = "RbMedium"
        Me.RbMedium.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RbMedium.Size = New System.Drawing.Size(34, 17)
        Me.RbMedium.TabIndex = 2
        Me.RbMedium.TabStop = True
        Me.RbMedium.Text = "M"
        Me.RbMedium.UseVisualStyleBackColor = True
        '
        'RbSmall
        '
        Me.RbSmall.AutoSize = True
        Me.RbSmall.Location = New System.Drawing.Point(14, 33)
        Me.RbSmall.Name = "RbSmall"
        Me.RbSmall.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RbSmall.Size = New System.Drawing.Size(32, 17)
        Me.RbSmall.TabIndex = 1
        Me.RbSmall.TabStop = True
        Me.RbSmall.Text = "S"
        Me.RbSmall.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Tamaño de fuente"
        '
        'BtnSubMenu
        '
        Me.BtnSubMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSubMenu.BackColor = System.Drawing.Color.White
        Me.BtnSubMenu.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnSubMenu.FlatAppearance.BorderSize = 0
        Me.BtnSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSubMenu.ForeColor = System.Drawing.Color.Black
        Me.BtnSubMenu.Image = CType(resources.GetObject("BtnSubMenu.Image"), System.Drawing.Image)
        Me.BtnSubMenu.Location = New System.Drawing.Point(679, 12)
        Me.BtnSubMenu.Name = "BtnSubMenu"
        Me.BtnSubMenu.Size = New System.Drawing.Size(32, 32)
        Me.BtnSubMenu.TabIndex = 63
        Me.BtnSubMenu.UseVisualStyleBackColor = False
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportarExcel.BackColor = System.Drawing.Color.White
        Me.btnExportarExcel.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExportarExcel.FlatAppearance.BorderSize = 0
        Me.btnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportarExcel.ForeColor = System.Drawing.Color.Black
        Me.btnExportarExcel.Image = CType(resources.GetObject("btnExportarExcel.Image"), System.Drawing.Image)
        Me.btnExportarExcel.Location = New System.Drawing.Point(492, 12)
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(32, 32)
        Me.btnExportarExcel.TabIndex = 46
        Me.btnExportarExcel.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBorrar.BackColor = System.Drawing.Color.White
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnBorrar.FlatAppearance.BorderSize = 0
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.ForeColor = System.Drawing.Color.Black
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.Location = New System.Drawing.Point(631, 12)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(32, 32)
        Me.btnBorrar.TabIndex = 45
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.BackColor = System.Drawing.Color.White
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.ForeColor = System.Drawing.Color.Black
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(583, 12)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(32, 32)
        Me.btnEditar.TabIndex = 44
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.BackColor = System.Drawing.Color.White
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(537, 12)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(32, 32)
        Me.btnNuevo.TabIndex = 43
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(187, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'txtBuscar
        '
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(36, 19)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(147, 18)
        Me.txtBuscar.TabIndex = 41
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(24, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(198, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 40
        Me.PictureBox2.TabStop = False
        '
        'panelFilter
        '
        Me.panelFilter.BackColor = System.Drawing.SystemColors.Control
        Me.panelFilter.Controls.Add(Me.btnFilter1)
        Me.panelFilter.Controls.Add(Me.pnlFilterStock)
        Me.panelFilter.Controls.Add(Me.btnAplicarFiltro)
        Me.panelFilter.Controls.Add(Me.cbStock)
        Me.panelFilter.Location = New System.Drawing.Point(229, 9)
        Me.panelFilter.Name = "panelFilter"
        Me.panelFilter.Size = New System.Drawing.Size(40, 40)
        Me.panelFilter.TabIndex = 15
        '
        'btnFilter1
        '
        Me.btnFilter1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFilter1.Image = CType(resources.GetObject("btnFilter1.Image"), System.Drawing.Image)
        Me.btnFilter1.Location = New System.Drawing.Point(5, 5)
        Me.btnFilter1.Name = "btnFilter1"
        Me.btnFilter1.Size = New System.Drawing.Size(30, 30)
        Me.btnFilter1.TabIndex = 63
        Me.btnFilter1.TabStop = False
        '
        'pnlFilterStock
        '
        Me.pnlFilterStock.Controls.Add(Me.rbSup)
        Me.pnlFilterStock.Controls.Add(Me.rbInf)
        Me.pnlFilterStock.Enabled = False
        Me.pnlFilterStock.Location = New System.Drawing.Point(5, 68)
        Me.pnlFilterStock.Name = "pnlFilterStock"
        Me.pnlFilterStock.Size = New System.Drawing.Size(190, 68)
        Me.pnlFilterStock.TabIndex = 58
        '
        'rbSup
        '
        Me.rbSup.AutoSize = True
        Me.rbSup.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbSup.Checked = True
        Me.rbSup.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSup.Location = New System.Drawing.Point(10, 12)
        Me.rbSup.Name = "rbSup"
        Me.rbSup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rbSup.Size = New System.Drawing.Size(172, 17)
        Me.rbSup.TabIndex = 57
        Me.rbSup.TabStop = True
        Me.rbSup.Text = "Superior al punto de pedido"
        Me.rbSup.UseVisualStyleBackColor = True
        '
        'rbInf
        '
        Me.rbInf.AutoSize = True
        Me.rbInf.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbInf.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbInf.Location = New System.Drawing.Point(10, 40)
        Me.rbInf.Name = "rbInf"
        Me.rbInf.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rbInf.Size = New System.Drawing.Size(172, 17)
        Me.rbInf.TabIndex = 56
        Me.rbInf.Text = "Inferior al punto de pedido  "
        Me.rbInf.UseVisualStyleBackColor = True
        '
        'btnAplicarFiltro
        '
        Me.btnAplicarFiltro.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnAplicarFiltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAplicarFiltro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnAplicarFiltro.FlatAppearance.BorderSize = 0
        Me.btnAplicarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAplicarFiltro.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAplicarFiltro.ForeColor = System.Drawing.Color.White
        Me.btnAplicarFiltro.Location = New System.Drawing.Point(66, 154)
        Me.btnAplicarFiltro.Name = "btnAplicarFiltro"
        Me.btnAplicarFiltro.Size = New System.Drawing.Size(80, 28)
        Me.btnAplicarFiltro.TabIndex = 55
        Me.btnAplicarFiltro.Text = "Filtrar"
        Me.btnAplicarFiltro.UseVisualStyleBackColor = False
        '
        'cbStock
        '
        Me.cbStock.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbStock.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStock.Location = New System.Drawing.Point(24, 46)
        Me.cbStock.Name = "cbStock"
        Me.cbStock.Size = New System.Drawing.Size(158, 24)
        Me.cbStock.TabIndex = 53
        Me.cbStock.Text = "Filtrar por stock"
        Me.cbStock.UseVisualStyleBackColor = True
        '
        'Panel14
        '
        Me.Panel14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Panel14.Location = New System.Drawing.Point(530, 9)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1, 40)
        Me.Panel14.TabIndex = 36
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(671, 9)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1, 40)
        Me.Panel5.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(624, 9)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 40)
        Me.Panel4.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(576, 9)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 40)
        Me.Panel3.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(720, 1)
        Me.Panel2.TabIndex = 3
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(15, 77)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(174, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(696, 436)
        Me.DataGridView1.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PictureBox3)
        Me.TabPage3.Controls.Add(Me.txtBuscar1)
        Me.TabPage3.Controls.Add(Me.PictureBox4)
        Me.TabPage3.Controls.Add(Me.btnBorrar2)
        Me.TabPage3.Controls.Add(Me.btnEditar2)
        Me.TabPage3.Controls.Add(Me.btnNuevo2)
        Me.TabPage3.Controls.Add(Me.Panel11)
        Me.TabPage3.Controls.Add(Me.Panel12)
        Me.TabPage3.Controls.Add(Me.Panel13)
        Me.TabPage3.Controls.Add(Me.DataGridView3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(722, 529)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(188, 15)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 39
        Me.PictureBox3.TabStop = False
        '
        'txtBuscar1
        '
        Me.txtBuscar1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscar1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar1.Location = New System.Drawing.Point(37, 19)
        Me.txtBuscar1.Name = "txtBuscar1"
        Me.txtBuscar1.Size = New System.Drawing.Size(147, 18)
        Me.txtBuscar1.TabIndex = 38
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(25, 7)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(198, 40)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 37
        Me.PictureBox4.TabStop = False
        '
        'btnBorrar2
        '
        Me.btnBorrar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBorrar2.BackColor = System.Drawing.Color.White
        Me.btnBorrar2.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnBorrar2.FlatAppearance.BorderSize = 0
        Me.btnBorrar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar2.ForeColor = System.Drawing.Color.Black
        Me.btnBorrar2.Image = CType(resources.GetObject("btnBorrar2.Image"), System.Drawing.Image)
        Me.btnBorrar2.Location = New System.Drawing.Point(679, 13)
        Me.btnBorrar2.Name = "btnBorrar2"
        Me.btnBorrar2.Size = New System.Drawing.Size(32, 32)
        Me.btnBorrar2.TabIndex = 36
        Me.btnBorrar2.UseVisualStyleBackColor = False
        '
        'btnEditar2
        '
        Me.btnEditar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar2.BackColor = System.Drawing.Color.White
        Me.btnEditar2.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEditar2.FlatAppearance.BorderSize = 0
        Me.btnEditar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar2.ForeColor = System.Drawing.Color.Black
        Me.btnEditar2.Image = CType(resources.GetObject("btnEditar2.Image"), System.Drawing.Image)
        Me.btnEditar2.Location = New System.Drawing.Point(632, 13)
        Me.btnEditar2.Name = "btnEditar2"
        Me.btnEditar2.Size = New System.Drawing.Size(32, 32)
        Me.btnEditar2.TabIndex = 35
        Me.btnEditar2.UseVisualStyleBackColor = False
        '
        'btnNuevo2
        '
        Me.btnNuevo2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo2.BackColor = System.Drawing.Color.White
        Me.btnNuevo2.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnNuevo2.FlatAppearance.BorderSize = 0
        Me.btnNuevo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo2.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo2.Image = CType(resources.GetObject("btnNuevo2.Image"), System.Drawing.Image)
        Me.btnNuevo2.Location = New System.Drawing.Point(585, 13)
        Me.btnNuevo2.Name = "btnNuevo2"
        Me.btnNuevo2.Size = New System.Drawing.Size(32, 32)
        Me.btnNuevo2.TabIndex = 34
        Me.btnNuevo2.UseVisualStyleBackColor = False
        '
        'Panel11
        '
        Me.Panel11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Panel11.Location = New System.Drawing.Point(671, 9)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1, 40)
        Me.Panel11.TabIndex = 27
        '
        'Panel12
        '
        Me.Panel12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Panel12.Location = New System.Drawing.Point(623, 9)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1, 40)
        Me.Panel12.TabIndex = 26
        '
        'Panel13
        '
        Me.Panel13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Panel13.Location = New System.Drawing.Point(0, 55)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(720, 1)
        Me.Panel13.TabIndex = 25
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView3.ColumnHeadersHeight = 30
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView3.EnableHeadersVisualStyles = False
        Me.DataGridView3.Location = New System.Drawing.Point(10, 62)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(174, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView3.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(701, 451)
        Me.DataGridView3.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnProveedores)
        Me.Panel1.Controls.Add(Me.BtnCerrar)
        Me.Panel1.Controls.Add(Me.BtnRepuestos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(760, 37)
        Me.Panel1.TabIndex = 6
        '
        'BtnProveedores
        '
        Me.BtnProveedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnProveedores.FlatAppearance.BorderSize = 0
        Me.BtnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProveedores.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProveedores.ForeColor = System.Drawing.Color.White
        Me.BtnProveedores.Location = New System.Drawing.Point(178, 0)
        Me.BtnProveedores.Name = "BtnProveedores"
        Me.BtnProveedores.Size = New System.Drawing.Size(151, 37)
        Me.BtnProveedores.TabIndex = 7
        Me.BtnProveedores.Text = "Determinar prov."
        Me.BtnProveedores.UseVisualStyleBackColor = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(0, 3)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(30, 31)
        Me.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnCerrar.TabIndex = 4
        Me.BtnCerrar.TabStop = False
        '
        'BtnRepuestos
        '
        Me.BtnRepuestos.BackColor = System.Drawing.Color.White
        Me.BtnRepuestos.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnRepuestos.FlatAppearance.BorderSize = 0
        Me.BtnRepuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRepuestos.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRepuestos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnRepuestos.Location = New System.Drawing.Point(74, 0)
        Me.BtnRepuestos.Name = "BtnRepuestos"
        Me.BtnRepuestos.Size = New System.Drawing.Size(95, 37)
        Me.BtnRepuestos.TabIndex = 5
        Me.BtnRepuestos.Text = "Repuestos"
        Me.BtnRepuestos.UseVisualStyleBackColor = False
        '
        'ElipseTarget1
        '
        Me.ElipseTarget1.ElipseRadius = 7
        Me.ElipseTarget1.TargetControl = Me.panelFilter
        '
        'FormRepuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 610)
        Me.Controls.Add(Me.BunifuPages1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormRepuestos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRepuestos"
        Me.BunifuPages1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.MenuDesplegable.ResumeLayout(False)
        Me.MenuDesplegable.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelFilter.ResumeLayout(False)
        CType(Me.btnFilter1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFilterStock.ResumeLayout(False)
        Me.pnlFilterStock.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuPages1 As Bunifu.UI.WinForms.BunifuPages
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents BtnRepuestos As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents BtnProveedores As Button
    Friend WithEvents Panel14 As Panel
    Friend WithEvents panelFilter As Panel
    Friend WithEvents btnAplicarFiltro As Button
    Friend WithEvents cbStock As CheckBox
    Friend WithEvents rbSup As RadioButton
    Friend WithEvents rbInf As RadioButton
    Friend WithEvents pnlFilterStock As Panel
    Friend WithEvents ElipseTarget1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnFilter1 As PictureBox
    Friend WithEvents btnNuevo2 As Button
    Friend WithEvents btnEditar2 As Button
    Friend WithEvents btnBorrar2 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtBuscar1 As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnExportarExcel As Button
    Friend WithEvents MenuDesplegable As Panel
    Friend WithEvents btnCancelarLetra As Button
    Friend WithEvents btnCambiarLetra As Button
    Friend WithEvents RbLarge As RadioButton
    Friend WithEvents RbMedium As RadioButton
    Friend WithEvents RbSmall As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnSubMenu As Button
End Class
