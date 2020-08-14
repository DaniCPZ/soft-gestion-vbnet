<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHome))
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.pnlExtra = New System.Windows.Forms.Panel()
        Me.btnExtras = New System.Windows.Forms.Button()
        Me.pnlFactura = New System.Windows.Forms.Panel()
        Me.BtnFacturas = New System.Windows.Forms.Button()
        Me.pnlCobranza = New System.Windows.Forms.Panel()
        Me.BtnCobranzas = New System.Windows.Forms.Button()
        Me.PanelLinea = New System.Windows.Forms.Panel()
        Me.BtnMenu = New System.Windows.Forms.PictureBox()
        Me.pnlServicio = New System.Windows.Forms.Panel()
        Me.BtnServicios = New System.Windows.Forms.Button()
        Me.pnlAlquiler = New System.Windows.Forms.Panel()
        Me.BtnProveedores = New System.Windows.Forms.Button()
        Me.pnlEquipo = New System.Windows.Forms.Panel()
        Me.BtnEquipos = New System.Windows.Forms.Button()
        Me.pnlRepuesto = New System.Windows.Forms.Panel()
        Me.BtnAlquileres = New System.Windows.Forms.Button()
        Me.pnlProveedor = New System.Windows.Forms.Panel()
        Me.BtnRepuestos = New System.Windows.Forms.Button()
        Me.pblCliente = New System.Windows.Forms.Panel()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnLogout = New System.Windows.Forms.PictureBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.btnEditarPerfil = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnMaximizar = New System.Windows.Forms.PictureBox()
        Me.BtnRestaurar = New System.Windows.Forms.PictureBox()
        Me.BtnMinimizar = New System.Windows.Forms.PictureBox()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PanelContenedor.SuspendLayout()
        Me.PanelFormularios.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        CType(Me.BtnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBarraTitulo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BtnLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEditarPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelContenedor.Controls.Add(Me.PanelFormularios)
        Me.PanelContenedor.Controls.Add(Me.PanelMenu)
        Me.PanelContenedor.Controls.Add(Me.PanelBarraTitulo)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1000, 600)
        Me.PanelContenedor.TabIndex = 0
        '
        'PanelFormularios
        '
        Me.PanelFormularios.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelFormularios.Controls.Add(Me.PictureBox3)
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(240, 40)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(760, 560)
        Me.PanelFormularios.TabIndex = 2
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(294, 170)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.pnlExtra)
        Me.PanelMenu.Controls.Add(Me.btnExtras)
        Me.PanelMenu.Controls.Add(Me.pnlFactura)
        Me.PanelMenu.Controls.Add(Me.BtnFacturas)
        Me.PanelMenu.Controls.Add(Me.pnlCobranza)
        Me.PanelMenu.Controls.Add(Me.BtnCobranzas)
        Me.PanelMenu.Controls.Add(Me.PanelLinea)
        Me.PanelMenu.Controls.Add(Me.BtnMenu)
        Me.PanelMenu.Controls.Add(Me.pnlServicio)
        Me.PanelMenu.Controls.Add(Me.BtnServicios)
        Me.PanelMenu.Controls.Add(Me.pnlAlquiler)
        Me.PanelMenu.Controls.Add(Me.BtnProveedores)
        Me.PanelMenu.Controls.Add(Me.pnlEquipo)
        Me.PanelMenu.Controls.Add(Me.BtnEquipos)
        Me.PanelMenu.Controls.Add(Me.pnlRepuesto)
        Me.PanelMenu.Controls.Add(Me.BtnAlquileres)
        Me.PanelMenu.Controls.Add(Me.pnlProveedor)
        Me.PanelMenu.Controls.Add(Me.BtnRepuestos)
        Me.PanelMenu.Controls.Add(Me.pblCliente)
        Me.PanelMenu.Controls.Add(Me.BtnClientes)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(240, 560)
        Me.PanelMenu.TabIndex = 1
        '
        'pnlExtra
        '
        Me.pnlExtra.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlExtra.Location = New System.Drawing.Point(0, 450)
        Me.pnlExtra.Name = "pnlExtra"
        Me.pnlExtra.Size = New System.Drawing.Size(5, 50)
        Me.pnlExtra.TabIndex = 23
        '
        'btnExtras
        '
        Me.btnExtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExtras.FlatAppearance.BorderSize = 0
        Me.btnExtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnExtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExtras.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExtras.ForeColor = System.Drawing.Color.White
        Me.btnExtras.Image = CType(resources.GetObject("btnExtras.Image"), System.Drawing.Image)
        Me.btnExtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExtras.Location = New System.Drawing.Point(5, 450)
        Me.btnExtras.Name = "btnExtras"
        Me.btnExtras.Size = New System.Drawing.Size(235, 50)
        Me.btnExtras.TabIndex = 22
        Me.btnExtras.Text = "   Soporte extra"
        Me.btnExtras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExtras.UseVisualStyleBackColor = True
        '
        'pnlFactura
        '
        Me.pnlFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlFactura.Location = New System.Drawing.Point(0, 399)
        Me.pnlFactura.Name = "pnlFactura"
        Me.pnlFactura.Size = New System.Drawing.Size(5, 50)
        Me.pnlFactura.TabIndex = 21
        '
        'BtnFacturas
        '
        Me.BtnFacturas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFacturas.FlatAppearance.BorderSize = 0
        Me.BtnFacturas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFacturas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFacturas.ForeColor = System.Drawing.Color.White
        Me.BtnFacturas.Image = CType(resources.GetObject("BtnFacturas.Image"), System.Drawing.Image)
        Me.BtnFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFacturas.Location = New System.Drawing.Point(5, 399)
        Me.BtnFacturas.Name = "BtnFacturas"
        Me.BtnFacturas.Size = New System.Drawing.Size(235, 50)
        Me.BtnFacturas.TabIndex = 20
        Me.BtnFacturas.Text = "   Facturas"
        Me.BtnFacturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnFacturas.UseVisualStyleBackColor = True
        '
        'pnlCobranza
        '
        Me.pnlCobranza.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlCobranza.Location = New System.Drawing.Point(0, 348)
        Me.pnlCobranza.Name = "pnlCobranza"
        Me.pnlCobranza.Size = New System.Drawing.Size(5, 50)
        Me.pnlCobranza.TabIndex = 19
        '
        'BtnCobranzas
        '
        Me.BtnCobranzas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCobranzas.FlatAppearance.BorderSize = 0
        Me.BtnCobranzas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCobranzas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnCobranzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCobranzas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCobranzas.ForeColor = System.Drawing.Color.White
        Me.BtnCobranzas.Image = CType(resources.GetObject("BtnCobranzas.Image"), System.Drawing.Image)
        Me.BtnCobranzas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCobranzas.Location = New System.Drawing.Point(5, 348)
        Me.BtnCobranzas.Name = "BtnCobranzas"
        Me.BtnCobranzas.Size = New System.Drawing.Size(235, 50)
        Me.BtnCobranzas.TabIndex = 18
        Me.BtnCobranzas.Text = "   Cobranzas"
        Me.BtnCobranzas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCobranzas.UseVisualStyleBackColor = True
        '
        'PanelLinea
        '
        Me.PanelLinea.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.PanelLinea.Location = New System.Drawing.Point(0, 37)
        Me.PanelLinea.Name = "PanelLinea"
        Me.PanelLinea.Size = New System.Drawing.Size(240, 1)
        Me.PanelLinea.TabIndex = 17
        '
        'BtnMenu
        '
        Me.BtnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMenu.Image = CType(resources.GetObject("BtnMenu.Image"), System.Drawing.Image)
        Me.BtnMenu.Location = New System.Drawing.Point(194, 1)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(35, 35)
        Me.BtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnMenu.TabIndex = 16
        Me.BtnMenu.TabStop = False
        '
        'pnlServicio
        '
        Me.pnlServicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlServicio.Location = New System.Drawing.Point(0, 297)
        Me.pnlServicio.Name = "pnlServicio"
        Me.pnlServicio.Size = New System.Drawing.Size(5, 50)
        Me.pnlServicio.TabIndex = 13
        '
        'BtnServicios
        '
        Me.BtnServicios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnServicios.FlatAppearance.BorderSize = 0
        Me.BtnServicios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnServicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnServicios.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnServicios.ForeColor = System.Drawing.Color.White
        Me.BtnServicios.Image = CType(resources.GetObject("BtnServicios.Image"), System.Drawing.Image)
        Me.BtnServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnServicios.Location = New System.Drawing.Point(5, 297)
        Me.BtnServicios.Name = "BtnServicios"
        Me.BtnServicios.Size = New System.Drawing.Size(235, 50)
        Me.BtnServicios.TabIndex = 12
        Me.BtnServicios.Text = "   Servicios"
        Me.BtnServicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnServicios.UseVisualStyleBackColor = True
        '
        'pnlAlquiler
        '
        Me.pnlAlquiler.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlAlquiler.Location = New System.Drawing.Point(0, 246)
        Me.pnlAlquiler.Name = "pnlAlquiler"
        Me.pnlAlquiler.Size = New System.Drawing.Size(5, 50)
        Me.pnlAlquiler.TabIndex = 11
        '
        'BtnProveedores
        '
        Me.BtnProveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProveedores.FlatAppearance.BorderSize = 0
        Me.BtnProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProveedores.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProveedores.ForeColor = System.Drawing.Color.White
        Me.BtnProveedores.Image = CType(resources.GetObject("BtnProveedores.Image"), System.Drawing.Image)
        Me.BtnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProveedores.Location = New System.Drawing.Point(5, 93)
        Me.BtnProveedores.Name = "BtnProveedores"
        Me.BtnProveedores.Size = New System.Drawing.Size(235, 50)
        Me.BtnProveedores.TabIndex = 10
        Me.BtnProveedores.Text = "   Proveedores"
        Me.BtnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnProveedores.UseVisualStyleBackColor = True
        '
        'pnlEquipo
        '
        Me.pnlEquipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlEquipo.Location = New System.Drawing.Point(0, 195)
        Me.pnlEquipo.Name = "pnlEquipo"
        Me.pnlEquipo.Size = New System.Drawing.Size(5, 50)
        Me.pnlEquipo.TabIndex = 9
        '
        'BtnEquipos
        '
        Me.BtnEquipos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEquipos.FlatAppearance.BorderSize = 0
        Me.BtnEquipos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnEquipos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEquipos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEquipos.ForeColor = System.Drawing.Color.White
        Me.BtnEquipos.Image = CType(resources.GetObject("BtnEquipos.Image"), System.Drawing.Image)
        Me.BtnEquipos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEquipos.Location = New System.Drawing.Point(5, 195)
        Me.BtnEquipos.Name = "BtnEquipos"
        Me.BtnEquipos.Size = New System.Drawing.Size(235, 50)
        Me.BtnEquipos.TabIndex = 8
        Me.BtnEquipos.Text = "   Equipos"
        Me.BtnEquipos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEquipos.UseVisualStyleBackColor = True
        '
        'pnlRepuesto
        '
        Me.pnlRepuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlRepuesto.Location = New System.Drawing.Point(0, 144)
        Me.pnlRepuesto.Name = "pnlRepuesto"
        Me.pnlRepuesto.Size = New System.Drawing.Size(5, 50)
        Me.pnlRepuesto.TabIndex = 7
        '
        'BtnAlquileres
        '
        Me.BtnAlquileres.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAlquileres.FlatAppearance.BorderSize = 0
        Me.BtnAlquileres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAlquileres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnAlquileres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAlquileres.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlquileres.ForeColor = System.Drawing.Color.White
        Me.BtnAlquileres.Image = CType(resources.GetObject("BtnAlquileres.Image"), System.Drawing.Image)
        Me.BtnAlquileres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAlquileres.Location = New System.Drawing.Point(5, 246)
        Me.BtnAlquileres.Name = "BtnAlquileres"
        Me.BtnAlquileres.Size = New System.Drawing.Size(235, 50)
        Me.BtnAlquileres.TabIndex = 6
        Me.BtnAlquileres.Text = "   Alquileres"
        Me.BtnAlquileres.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAlquileres.UseVisualStyleBackColor = True
        '
        'pnlProveedor
        '
        Me.pnlProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlProveedor.Location = New System.Drawing.Point(0, 93)
        Me.pnlProveedor.Name = "pnlProveedor"
        Me.pnlProveedor.Size = New System.Drawing.Size(5, 50)
        Me.pnlProveedor.TabIndex = 5
        '
        'BtnRepuestos
        '
        Me.BtnRepuestos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRepuestos.FlatAppearance.BorderSize = 0
        Me.BtnRepuestos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnRepuestos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnRepuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRepuestos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRepuestos.ForeColor = System.Drawing.Color.White
        Me.BtnRepuestos.Image = CType(resources.GetObject("BtnRepuestos.Image"), System.Drawing.Image)
        Me.BtnRepuestos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRepuestos.Location = New System.Drawing.Point(5, 144)
        Me.BtnRepuestos.Name = "BtnRepuestos"
        Me.BtnRepuestos.Size = New System.Drawing.Size(235, 50)
        Me.BtnRepuestos.TabIndex = 4
        Me.BtnRepuestos.Text = "   Repuestos"
        Me.BtnRepuestos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnRepuestos.UseVisualStyleBackColor = True
        '
        'pblCliente
        '
        Me.pblCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pblCliente.Location = New System.Drawing.Point(0, 42)
        Me.pblCliente.Name = "pblCliente"
        Me.pblCliente.Size = New System.Drawing.Size(5, 50)
        Me.pblCliente.TabIndex = 3
        '
        'BtnClientes
        '
        Me.BtnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClientes.FlatAppearance.BorderSize = 0
        Me.BtnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClientes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientes.ForeColor = System.Drawing.Color.White
        Me.BtnClientes.Image = CType(resources.GetObject("BtnClientes.Image"), System.Drawing.Image)
        Me.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClientes.Location = New System.Drawing.Point(5, 42)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(235, 50)
        Me.BtnClientes.TabIndex = 2
        Me.BtnClientes.Text = "   Clientes"
        Me.BtnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnClientes.UseVisualStyleBackColor = True
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.PanelBarraTitulo.Controls.Add(Me.Panel1)
        Me.PanelBarraTitulo.Controls.Add(Me.Label1)
        Me.PanelBarraTitulo.Controls.Add(Me.PictureBox1)
        Me.PanelBarraTitulo.Controls.Add(Me.BtnMaximizar)
        Me.PanelBarraTitulo.Controls.Add(Me.BtnRestaurar)
        Me.PanelBarraTitulo.Controls.Add(Me.BtnMinimizar)
        Me.PanelBarraTitulo.Controls.Add(Me.BtnCerrar)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(1000, 40)
        Me.PanelBarraTitulo.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnLogout)
        Me.Panel1.Controls.Add(Me.lblUserName)
        Me.Panel1.Controls.Add(Me.btnEditarPerfil)
        Me.Panel1.Location = New System.Drawing.Point(577, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(302, 35)
        Me.Panel1.TabIndex = 6
        '
        'BtnLogout
        '
        Me.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogout.Image = CType(resources.GetObject("BtnLogout.Image"), System.Drawing.Image)
        Me.BtnLogout.Location = New System.Drawing.Point(270, 4)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(25, 25)
        Me.BtnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnLogout.TabIndex = 2
        Me.BtnLogout.TabStop = False
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.White
        Me.lblUserName.Location = New System.Drawing.Point(45, 13)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(40, 13)
        Me.lblUserName.TabIndex = 1
        Me.lblUserName.Text = "Label2"
        '
        'btnEditarPerfil
        '
        Me.btnEditarPerfil.Image = CType(resources.GetObject("btnEditarPerfil.Image"), System.Drawing.Image)
        Me.btnEditarPerfil.Location = New System.Drawing.Point(3, 0)
        Me.btnEditarPerfil.Name = "btnEditarPerfil"
        Me.btnEditarPerfil.Size = New System.Drawing.Size(35, 35)
        Me.btnEditarPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnEditarPerfil.TabIndex = 0
        Me.btnEditarPerfil.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(53, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "PHOTOCOPYING RENTALS MANAGER"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'BtnMaximizar
        '
        Me.BtnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMaximizar.Image = CType(resources.GetObject("BtnMaximizar.Image"), System.Drawing.Image)
        Me.BtnMaximizar.Location = New System.Drawing.Point(926, 6)
        Me.BtnMaximizar.Name = "BtnMaximizar"
        Me.BtnMaximizar.Size = New System.Drawing.Size(28, 28)
        Me.BtnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnMaximizar.TabIndex = 3
        Me.BtnMaximizar.TabStop = False
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRestaurar.Image = CType(resources.GetObject("BtnRestaurar.Image"), System.Drawing.Image)
        Me.BtnRestaurar.Location = New System.Drawing.Point(926, 6)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(28, 28)
        Me.BtnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnRestaurar.TabIndex = 2
        Me.BtnRestaurar.TabStop = False
        Me.BtnRestaurar.Visible = False
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimizar.Image = CType(resources.GetObject("BtnMinimizar.Image"), System.Drawing.Image)
        Me.BtnMinimizar.Location = New System.Drawing.Point(892, 6)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(28, 28)
        Me.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnMinimizar.TabIndex = 1
        Me.BtnMinimizar.TabStop = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(960, 6)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(28, 28)
        Me.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.TabStop = False
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.PanelBarraTitulo
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 50
        Me.BunifuElipse2.TargetControl = Me.btnEditarPerfil
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "FormHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelFormularios.ResumeLayout(False)
        Me.PanelFormularios.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.BtnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BtnLogout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEditarPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents BtnMaximizar As PictureBox
    Friend WithEvents BtnRestaurar As PictureBox
    Friend WithEvents BtnMinimizar As PictureBox
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlServicio As Panel
    Friend WithEvents BtnServicios As Button
    Friend WithEvents pnlAlquiler As Panel
    Friend WithEvents BtnProveedores As Button
    Friend WithEvents pnlEquipo As Panel
    Friend WithEvents BtnEquipos As Button
    Friend WithEvents pnlRepuesto As Panel
    Friend WithEvents BtnAlquileres As Button
    Friend WithEvents pnlProveedor As Panel
    Friend WithEvents BtnRepuestos As Button
    Friend WithEvents pblCliente As Panel
    Friend WithEvents BtnClientes As Button
    Friend WithEvents PanelLinea As Panel
    Friend WithEvents BtnMenu As PictureBox
    Friend WithEvents pnlCobranza As Panel
    Friend WithEvents BtnCobranzas As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnEditarPerfil As PictureBox
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents lblUserName As Label
    Friend WithEvents BtnLogout As PictureBox
    Friend WithEvents pnlFactura As Panel
    Friend WithEvents BtnFacturas As Button
    Friend WithEvents pnlExtra As Panel
    Friend WithEvents btnExtras As Button
End Class
