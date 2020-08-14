<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAlquileres
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAlquileres))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Animation1 As Utilities.BunifuPages.BunifuAnimatorNS.Animation = New Utilities.BunifuPages.BunifuAnimatorNS.Animation()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.BtnAlquileres = New System.Windows.Forms.Button()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.panelFilter = New System.Windows.Forms.Panel()
        Me.pblEstado = New System.Windows.Forms.Panel()
        Me.rBtnEnCurso = New System.Windows.Forms.RadioButton()
        Me.rBtnVencido = New System.Windows.Forms.RadioButton()
        Me.pnlFecha = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dpFechaFinal = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.dpFechaInicio = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.rBtnInicio = New System.Windows.Forms.RadioButton()
        Me.rBtnFinal = New System.Windows.Forms.RadioButton()
        Me.btnAplicarFiltro = New System.Windows.Forms.Button()
        Me.cbEstado = New System.Windows.Forms.CheckBox()
        Me.cbFecha = New System.Windows.Forms.CheckBox()
        Me.btnFilter1 = New System.Windows.Forms.PictureBox()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuPages1 = New Bunifu.UI.WinForms.BunifuPages()
        Me.ToolAyuda = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuDesplegable = New System.Windows.Forms.Panel()
        Me.btnCancelarLetra = New System.Windows.Forms.Button()
        Me.btnCambiarLetra = New System.Windows.Forms.Button()
        Me.RbLarge = New System.Windows.Forms.RadioButton()
        Me.RbMedium = New System.Windows.Forms.RadioButton()
        Me.RbSmall = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnSubMenu = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelFilter.SuspendLayout()
        Me.pblEstado.SuspendLayout()
        Me.pnlFecha.SuspendLayout()
        CType(Me.btnFilter1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuPages1.SuspendLayout()
        Me.MenuDesplegable.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnCerrar)
        Me.Panel1.Controls.Add(Me.BtnAlquileres)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(760, 37)
        Me.Panel1.TabIndex = 4
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
        'BtnAlquileres
        '
        Me.BtnAlquileres.BackColor = System.Drawing.Color.White
        Me.BtnAlquileres.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnAlquileres.FlatAppearance.BorderSize = 0
        Me.BtnAlquileres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAlquileres.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlquileres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnAlquileres.Location = New System.Drawing.Point(74, 0)
        Me.BtnAlquileres.Name = "BtnAlquileres"
        Me.BtnAlquileres.Size = New System.Drawing.Size(91, 37)
        Me.BtnAlquileres.TabIndex = 5
        Me.BtnAlquileres.Text = "Alquileres"
        Me.BtnAlquileres.UseVisualStyleBackColor = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 7
        Me.BunifuElipse1.TargetControl = Me.panelFilter
        '
        'panelFilter
        '
        Me.panelFilter.BackColor = System.Drawing.SystemColors.Control
        Me.panelFilter.Controls.Add(Me.pblEstado)
        Me.panelFilter.Controls.Add(Me.pnlFecha)
        Me.panelFilter.Controls.Add(Me.btnAplicarFiltro)
        Me.panelFilter.Controls.Add(Me.cbEstado)
        Me.panelFilter.Controls.Add(Me.cbFecha)
        Me.panelFilter.Controls.Add(Me.btnFilter1)
        Me.panelFilter.Location = New System.Drawing.Point(240, 9)
        Me.panelFilter.Name = "panelFilter"
        Me.panelFilter.Size = New System.Drawing.Size(40, 40)
        Me.panelFilter.TabIndex = 15
        '
        'pblEstado
        '
        Me.pblEstado.Controls.Add(Me.rBtnEnCurso)
        Me.pblEstado.Controls.Add(Me.rBtnVencido)
        Me.pblEstado.Enabled = False
        Me.pblEstado.Location = New System.Drawing.Point(50, 228)
        Me.pblEstado.Name = "pblEstado"
        Me.pblEstado.Size = New System.Drawing.Size(129, 62)
        Me.pblEstado.TabIndex = 61
        '
        'rBtnEnCurso
        '
        Me.rBtnEnCurso.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rBtnEnCurso.Checked = True
        Me.rBtnEnCurso.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rBtnEnCurso.Location = New System.Drawing.Point(3, 3)
        Me.rBtnEnCurso.Name = "rBtnEnCurso"
        Me.rBtnEnCurso.Size = New System.Drawing.Size(119, 24)
        Me.rBtnEnCurso.TabIndex = 56
        Me.rBtnEnCurso.TabStop = True
        Me.rBtnEnCurso.Text = "Alquiler en curso"
        Me.rBtnEnCurso.UseVisualStyleBackColor = True
        '
        'rBtnVencido
        '
        Me.rBtnVencido.AutoSize = True
        Me.rBtnVencido.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rBtnVencido.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rBtnVencido.Location = New System.Drawing.Point(3, 33)
        Me.rBtnVencido.Name = "rBtnVencido"
        Me.rBtnVencido.Size = New System.Drawing.Size(119, 17)
        Me.rBtnVencido.TabIndex = 57
        Me.rBtnVencido.Text = "Alquiler finalizado"
        Me.rBtnVencido.UseVisualStyleBackColor = True
        '
        'pnlFecha
        '
        Me.pnlFecha.Controls.Add(Me.Label9)
        Me.pnlFecha.Controls.Add(Me.Label10)
        Me.pnlFecha.Controls.Add(Me.dpFechaFinal)
        Me.pnlFecha.Controls.Add(Me.dpFechaInicio)
        Me.pnlFecha.Controls.Add(Me.rBtnInicio)
        Me.pnlFecha.Controls.Add(Me.rBtnFinal)
        Me.pnlFecha.Enabled = False
        Me.pnlFecha.Location = New System.Drawing.Point(15, 74)
        Me.pnlFecha.Name = "pnlFecha"
        Me.pnlFecha.Size = New System.Drawing.Size(200, 120)
        Me.pnlFecha.TabIndex = 60
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 15)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Desde:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 15)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Hasta:"
        '
        'dpFechaFinal
        '
        Me.dpFechaFinal.BorderRadius = 1
        Me.dpFechaFinal.Color = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.dpFechaFinal.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick
        Me.dpFechaFinal.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.dpFechaFinal.DisabledColor = System.Drawing.Color.Gray
        Me.dpFechaFinal.DisplayWeekNumbers = False
        Me.dpFechaFinal.DPHeight = 0
        Me.dpFechaFinal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dpFechaFinal.FillDatePicker = False
        Me.dpFechaFinal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpFechaFinal.ForeColor = System.Drawing.Color.Black
        Me.dpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpFechaFinal.Icon = CType(resources.GetObject("dpFechaFinal.Icon"), System.Drawing.Image)
        Me.dpFechaFinal.IconColor = System.Drawing.Color.Black
        Me.dpFechaFinal.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.dpFechaFinal.Location = New System.Drawing.Point(77, 78)
        Me.dpFechaFinal.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dpFechaFinal.MinimumSize = New System.Drawing.Size(100, 32)
        Me.dpFechaFinal.Name = "dpFechaFinal"
        Me.dpFechaFinal.Size = New System.Drawing.Size(100, 32)
        Me.dpFechaFinal.TabIndex = 61
        '
        'dpFechaInicio
        '
        Me.dpFechaInicio.BorderRadius = 1
        Me.dpFechaInicio.Color = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.dpFechaInicio.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick
        Me.dpFechaInicio.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.dpFechaInicio.DisabledColor = System.Drawing.Color.Gray
        Me.dpFechaInicio.DisplayWeekNumbers = False
        Me.dpFechaInicio.DPHeight = 0
        Me.dpFechaInicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dpFechaInicio.FillDatePicker = False
        Me.dpFechaInicio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpFechaInicio.ForeColor = System.Drawing.Color.Black
        Me.dpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpFechaInicio.Icon = CType(resources.GetObject("dpFechaInicio.Icon"), System.Drawing.Image)
        Me.dpFechaInicio.IconColor = System.Drawing.Color.Black
        Me.dpFechaInicio.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.dpFechaInicio.Location = New System.Drawing.Point(77, 30)
        Me.dpFechaInicio.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dpFechaInicio.MinimumSize = New System.Drawing.Size(100, 32)
        Me.dpFechaInicio.Name = "dpFechaInicio"
        Me.dpFechaInicio.Size = New System.Drawing.Size(100, 32)
        Me.dpFechaInicio.TabIndex = 60
        '
        'rBtnInicio
        '
        Me.rBtnInicio.AutoSize = True
        Me.rBtnInicio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rBtnInicio.Checked = True
        Me.rBtnInicio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rBtnInicio.Location = New System.Drawing.Point(4, 3)
        Me.rBtnInicio.Name = "rBtnInicio"
        Me.rBtnInicio.Size = New System.Drawing.Size(70, 17)
        Me.rBtnInicio.TabIndex = 58
        Me.rBtnInicio.TabStop = True
        Me.rBtnInicio.Text = "De inicio"
        Me.rBtnInicio.UseVisualStyleBackColor = True
        '
        'rBtnFinal
        '
        Me.rBtnFinal.AutoSize = True
        Me.rBtnFinal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rBtnFinal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rBtnFinal.Location = New System.Drawing.Point(87, 3)
        Me.rBtnFinal.Name = "rBtnFinal"
        Me.rBtnFinal.Size = New System.Drawing.Size(101, 17)
        Me.rBtnFinal.TabIndex = 59
        Me.rBtnFinal.Text = "De finalizacion"
        Me.rBtnFinal.UseVisualStyleBackColor = True
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
        Me.btnAplicarFiltro.Location = New System.Drawing.Point(74, 298)
        Me.btnAplicarFiltro.Name = "btnAplicarFiltro"
        Me.btnAplicarFiltro.Size = New System.Drawing.Size(80, 28)
        Me.btnAplicarFiltro.TabIndex = 55
        Me.btnAplicarFiltro.Text = "Filtrar"
        Me.btnAplicarFiltro.UseVisualStyleBackColor = False
        '
        'cbEstado
        '
        Me.cbEstado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbEstado.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstado.Location = New System.Drawing.Point(19, 200)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(193, 24)
        Me.cbEstado.TabIndex = 54
        Me.cbEstado.Text = "Filtrar por estado"
        Me.cbEstado.UseVisualStyleBackColor = True
        '
        'cbFecha
        '
        Me.cbFecha.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbFecha.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFecha.Location = New System.Drawing.Point(19, 45)
        Me.cbFecha.Name = "cbFecha"
        Me.cbFecha.Size = New System.Drawing.Size(193, 24)
        Me.cbFecha.TabIndex = 53
        Me.cbFecha.Text = "Filtrar por fecha"
        Me.cbFecha.UseVisualStyleBackColor = True
        '
        'btnFilter1
        '
        Me.btnFilter1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFilter1.Image = CType(resources.GetObject("btnFilter1.Image"), System.Drawing.Image)
        Me.btnFilter1.Location = New System.Drawing.Point(5, 5)
        Me.btnFilter1.Name = "btnFilter1"
        Me.btnFilter1.Size = New System.Drawing.Size(30, 30)
        Me.btnFilter1.TabIndex = 0
        Me.btnFilter1.TabStop = False
        Me.ToolAyuda.SetToolTip(Me.btnFilter1, "Filtrar")
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 7
        Me.BunifuElipse2.TargetControl = Me.btnAplicarFiltro
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.MenuDesplegable)
        Me.TabPage1.Controls.Add(Me.BtnSubMenu)
        Me.TabPage1.Controls.Add(Me.panelFilter)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.TxtBuscar)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Controls.Add(Me.BtnEditar)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.BtnNuevo)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(722, 529)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(188, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'TxtBuscar
        '
        Me.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBuscar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(39, 19)
        Me.TxtBuscar.MaxLength = 50
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(150, 18)
        Me.TxtBuscar.TabIndex = 8
        Me.ToolAyuda.SetToolTip(Me.TxtBuscar, "Ingrese el nombre del cliente")
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
        Me.DataGridView1.Size = New System.Drawing.Size(701, 446)
        Me.DataGridView1.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(672, 9)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 40)
        Me.Panel4.TabIndex = 5
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEditar.BackColor = System.Drawing.Color.White
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.ForeColor = System.Drawing.Color.Black
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.Location = New System.Drawing.Point(633, 12)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(32, 32)
        Me.BtnEditar.TabIndex = 6
        Me.ToolAyuda.SetToolTip(Me.BtnEditar, "Editar alquiler")
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(624, 9)
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
        'BtnNuevo
        '
        Me.BtnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNuevo.BackColor = System.Drawing.Color.White
        Me.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.ForeColor = System.Drawing.Color.Black
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.Location = New System.Drawing.Point(585, 13)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(32, 32)
        Me.BtnNuevo.TabIndex = 2
        Me.ToolAyuda.SetToolTip(Me.BtnNuevo, "Nuevo alquiler")
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(25, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(198, 41)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'BunifuPages1
        '
        Me.BunifuPages1.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.BunifuPages1.AllowTransitions = True
        Me.BunifuPages1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuPages1.Controls.Add(Me.TabPage1)
        Me.BunifuPages1.Location = New System.Drawing.Point(15, 37)
        Me.BunifuPages1.Multiline = True
        Me.BunifuPages1.Name = "BunifuPages1"
        Me.BunifuPages1.Page = Me.TabPage1
        Me.BunifuPages1.PageIndex = 0
        Me.BunifuPages1.PageName = "TabPage1"
        Me.BunifuPages1.PageTitle = "TabPage1"
        Me.BunifuPages1.SelectedIndex = 0
        Me.BunifuPages1.Size = New System.Drawing.Size(730, 555)
        Me.BunifuPages1.TabIndex = 5
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
        'ToolAyuda
        '
        Me.ToolAyuda.AutoPopDelay = 5000
        Me.ToolAyuda.InitialDelay = 200
        Me.ToolAyuda.ReshowDelay = 100
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
        Me.MenuDesplegable.Location = New System.Drawing.Point(511, 46)
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
        Me.BtnSubMenu.Location = New System.Drawing.Point(679, 14)
        Me.BtnSubMenu.Name = "BtnSubMenu"
        Me.BtnSubMenu.Size = New System.Drawing.Size(32, 32)
        Me.BtnSubMenu.TabIndex = 63
        Me.ToolAyuda.SetToolTip(Me.BtnSubMenu, "Ajustar tamaño de fuente")
        Me.BtnSubMenu.UseVisualStyleBackColor = False
        '
        'FormAlquileres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(760, 610)
        Me.Controls.Add(Me.BunifuPages1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAlquileres"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAlquileres"
        Me.Panel1.ResumeLayout(False)
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelFilter.ResumeLayout(False)
        Me.pblEstado.ResumeLayout(False)
        Me.pblEstado.PerformLayout()
        Me.pnlFecha.ResumeLayout(False)
        Me.pnlFecha.PerformLayout()
        CType(Me.btnFilter1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuPages1.ResumeLayout(False)
        Me.MenuDesplegable.ResumeLayout(False)
        Me.MenuDesplegable.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents BtnAlquileres As Button
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents panelFilter As Panel
    Friend WithEvents pblEstado As Panel
    Friend WithEvents rBtnEnCurso As RadioButton
    Friend WithEvents rBtnVencido As RadioButton
    Friend WithEvents pnlFecha As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dpFechaFinal As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents dpFechaInicio As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents rBtnInicio As RadioButton
    Friend WithEvents rBtnFinal As RadioButton
    Friend WithEvents btnAplicarFiltro As Button
    Friend WithEvents cbEstado As CheckBox
    Friend WithEvents cbFecha As CheckBox
    Friend WithEvents btnFilter1 As PictureBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnEditar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BunifuPages1 As Bunifu.UI.WinForms.BunifuPages
    Friend WithEvents ToolAyuda As ToolTip
    Friend WithEvents MenuDesplegable As Panel
    Friend WithEvents btnCancelarLetra As Button
    Friend WithEvents btnCambiarLetra As Button
    Friend WithEvents RbLarge As RadioButton
    Friend WithEvents RbMedium As RadioButton
    Friend WithEvents RbSmall As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnSubMenu As Button
End Class
