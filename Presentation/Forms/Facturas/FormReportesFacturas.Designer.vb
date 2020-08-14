<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReportesFacturas
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReportesFacturas))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.pnlCustom = New System.Windows.Forms.Panel()
        Me.btnAplicar = New System.Windows.Forms.Button()
        Me.BunifuDatePicker2 = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.BunifuDatePicker1 = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCustom = New System.Windows.Forms.Button()
        Me.btnAño = New System.Windows.Forms.Button()
        Me.btnUltimos30dias = New System.Windows.Forms.Button()
        Me.btnMes = New System.Windows.Forms.Button()
        Me.btn7dias = New System.Windows.Forms.Button()
        Me.btnHoy = New System.Windows.Forms.Button()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ReportesFacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListadoFacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturasPorPeriodoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlMenu.SuspendLayout()
        Me.pnlCustom.SuspendLayout()
        Me.pnlLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportesFacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListadoFacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasPorPeriodoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "reportesFacturas"
        ReportDataSource1.Value = Me.ReportesFacturasBindingSource
        ReportDataSource2.Name = "listadoFacturas"
        ReportDataSource2.Value = Me.ListadoFacturasBindingSource
        ReportDataSource3.Name = "facturasPorPeriodo"
        ReportDataSource3.Value = Me.FacturasPorPeriodoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Presentation.InformeFactura.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(236, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(816, 894)
        Me.ReportViewer1.TabIndex = 0
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.pnlCustom)
        Me.pnlMenu.Controls.Add(Me.btnCustom)
        Me.pnlMenu.Controls.Add(Me.btnAño)
        Me.pnlMenu.Controls.Add(Me.btnUltimos30dias)
        Me.pnlMenu.Controls.Add(Me.btnMes)
        Me.pnlMenu.Controls.Add(Me.btn7dias)
        Me.pnlMenu.Controls.Add(Me.btnHoy)
        Me.pnlMenu.Controls.Add(Me.pnlLogo)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(230, 903)
        Me.pnlMenu.TabIndex = 1
        '
        'pnlCustom
        '
        Me.pnlCustom.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.pnlCustom.Controls.Add(Me.btnAplicar)
        Me.pnlCustom.Controls.Add(Me.BunifuDatePicker2)
        Me.pnlCustom.Controls.Add(Me.BunifuDatePicker1)
        Me.pnlCustom.Controls.Add(Me.Label2)
        Me.pnlCustom.Controls.Add(Me.Label1)
        Me.pnlCustom.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCustom.Location = New System.Drawing.Point(0, 374)
        Me.pnlCustom.Name = "pnlCustom"
        Me.pnlCustom.Size = New System.Drawing.Size(230, 167)
        Me.pnlCustom.TabIndex = 9
        '
        'btnAplicar
        '
        Me.btnAplicar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnAplicar.Location = New System.Drawing.Point(0, 132)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(230, 35)
        Me.btnAplicar.TabIndex = 52
        Me.btnAplicar.Text = "btnAplicarCustom"
        Me.btnAplicar.UseVisualStyleBackColor = True
        '
        'BunifuDatePicker2
        '
        Me.BunifuDatePicker2.BorderRadius = 1
        Me.BunifuDatePicker2.Color = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuDatePicker2.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick
        Me.BunifuDatePicker2.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.BunifuDatePicker2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuDatePicker2.DisplayWeekNumbers = False
        Me.BunifuDatePicker2.DPHeight = 0
        Me.BunifuDatePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.BunifuDatePicker2.FillDatePicker = False
        Me.BunifuDatePicker2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuDatePicker2.ForeColor = System.Drawing.Color.Black
        Me.BunifuDatePicker2.Icon = CType(resources.GetObject("BunifuDatePicker2.Icon"), System.Drawing.Image)
        Me.BunifuDatePicker2.IconColor = System.Drawing.Color.Black
        Me.BunifuDatePicker2.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.BunifuDatePicker2.Location = New System.Drawing.Point(15, 96)
        Me.BunifuDatePicker2.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.BunifuDatePicker2.MinimumSize = New System.Drawing.Size(200, 30)
        Me.BunifuDatePicker2.Name = "BunifuDatePicker2"
        Me.BunifuDatePicker2.Size = New System.Drawing.Size(200, 30)
        Me.BunifuDatePicker2.TabIndex = 51
        '
        'BunifuDatePicker1
        '
        Me.BunifuDatePicker1.BorderRadius = 1
        Me.BunifuDatePicker1.Color = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuDatePicker1.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick
        Me.BunifuDatePicker1.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.BunifuDatePicker1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuDatePicker1.DisplayWeekNumbers = False
        Me.BunifuDatePicker1.DPHeight = 0
        Me.BunifuDatePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.BunifuDatePicker1.FillDatePicker = False
        Me.BunifuDatePicker1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuDatePicker1.ForeColor = System.Drawing.Color.Black
        Me.BunifuDatePicker1.Icon = CType(resources.GetObject("BunifuDatePicker1.Icon"), System.Drawing.Image)
        Me.BunifuDatePicker1.IconColor = System.Drawing.Color.Black
        Me.BunifuDatePicker1.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.BunifuDatePicker1.Location = New System.Drawing.Point(15, 32)
        Me.BunifuDatePicker1.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.BunifuDatePicker1.MinimumSize = New System.Drawing.Size(200, 30)
        Me.BunifuDatePicker1.Name = "BunifuDatePicker1"
        Me.BunifuDatePicker1.Size = New System.Drawing.Size(200, 30)
        Me.BunifuDatePicker1.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 30)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Hasta:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Desde:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCustom
        '
        Me.btnCustom.BackColor = System.Drawing.Color.Transparent
        Me.btnCustom.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCustom.Location = New System.Drawing.Point(0, 334)
        Me.btnCustom.Name = "btnCustom"
        Me.btnCustom.Size = New System.Drawing.Size(230, 40)
        Me.btnCustom.TabIndex = 7
        Me.btnCustom.Text = "Personalizado"
        Me.btnCustom.UseVisualStyleBackColor = False
        '
        'btnAño
        '
        Me.btnAño.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAño.Location = New System.Drawing.Point(0, 295)
        Me.btnAño.Name = "btnAño"
        Me.btnAño.Size = New System.Drawing.Size(230, 39)
        Me.btnAño.TabIndex = 6
        Me.btnAño.Text = "Este año"
        Me.btnAño.UseVisualStyleBackColor = True
        '
        'btnUltimos30dias
        '
        Me.btnUltimos30dias.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUltimos30dias.Location = New System.Drawing.Point(0, 255)
        Me.btnUltimos30dias.Name = "btnUltimos30dias"
        Me.btnUltimos30dias.Size = New System.Drawing.Size(230, 40)
        Me.btnUltimos30dias.TabIndex = 5
        Me.btnUltimos30dias.Text = "Ultimos 30 dias"
        Me.btnUltimos30dias.UseVisualStyleBackColor = True
        '
        'btnMes
        '
        Me.btnMes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMes.Location = New System.Drawing.Point(0, 215)
        Me.btnMes.Name = "btnMes"
        Me.btnMes.Size = New System.Drawing.Size(230, 40)
        Me.btnMes.TabIndex = 4
        Me.btnMes.Text = "Este mes"
        Me.btnMes.UseVisualStyleBackColor = True
        '
        'btn7dias
        '
        Me.btn7dias.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn7dias.Location = New System.Drawing.Point(0, 175)
        Me.btn7dias.Name = "btn7dias"
        Me.btn7dias.Size = New System.Drawing.Size(230, 40)
        Me.btn7dias.TabIndex = 3
        Me.btn7dias.Text = "Ultimos 7 dias"
        Me.btn7dias.UseVisualStyleBackColor = True
        '
        'btnHoy
        '
        Me.btnHoy.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHoy.Location = New System.Drawing.Point(0, 135)
        Me.btnHoy.Name = "btnHoy"
        Me.btnHoy.Size = New System.Drawing.Size(230, 40)
        Me.btnHoy.TabIndex = 2
        Me.btnHoy.Text = "Hoy"
        Me.btnHoy.UseVisualStyleBackColor = True
        '
        'pnlLogo
        '
        Me.pnlLogo.Controls.Add(Me.PictureBox1)
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(230, 135)
        Me.pnlLogo.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(64, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ReportesFacturasBindingSource
        '
        Me.ReportesFacturasBindingSource.DataSource = GetType(Domain.ReportesFacturas)
        '
        'ListadoFacturasBindingSource
        '
        Me.ListadoFacturasBindingSource.DataSource = GetType(Domain.ListadoFacturas)
        '
        'FacturasPorPeriodoBindingSource
        '
        Me.FacturasPorPeriodoBindingSource.DataSource = GetType(Domain.FacturasPorPeriodo)
        '
        'FormReportesFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 903)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormReportesFacturas"
        Me.Text = "FormReportesFacturas"
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlCustom.ResumeLayout(False)
        Me.pnlLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportesFacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListadoFacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasPorPeriodoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportesFacturasBindingSource As BindingSource
    Friend WithEvents ListadoFacturasBindingSource As BindingSource
    Friend WithEvents FacturasPorPeriodoBindingSource As BindingSource
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents btnCustom As Button
    Friend WithEvents btnAño As Button
    Friend WithEvents btnUltimos30dias As Button
    Friend WithEvents btnMes As Button
    Friend WithEvents btn7dias As Button
    Friend WithEvents btnHoy As Button
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlCustom As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAplicar As Button
    Friend WithEvents BunifuDatePicker2 As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents BunifuDatePicker1 As Bunifu.UI.WinForms.BunifuDatePicker
End Class
