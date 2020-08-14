<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNewAlquiler
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNewAlquiler))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelFormCampos = New System.Windows.Forms.Panel()
        Me.BunifuDatePicker1 = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbEquipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.TxtMinAlquiler = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.LblMinAlquiler = New System.Windows.Forms.Label()
        Me.CmbCliente = New System.Windows.Forms.ComboBox()
        Me.LblCliente = New System.Windows.Forms.Label()
        Me.DragControlVentana = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PanelFormCampos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nuevo"
        '
        'PanelFormCampos
        '
        Me.PanelFormCampos.BackColor = System.Drawing.Color.White
        Me.PanelFormCampos.Controls.Add(Me.BunifuDatePicker1)
        Me.PanelFormCampos.Controls.Add(Me.Label3)
        Me.PanelFormCampos.Controls.Add(Me.CmbEquipo)
        Me.PanelFormCampos.Controls.Add(Me.Label2)
        Me.PanelFormCampos.Controls.Add(Me.Panel8)
        Me.PanelFormCampos.Controls.Add(Me.TxtMinAlquiler)
        Me.PanelFormCampos.Controls.Add(Me.BtnCancelar)
        Me.PanelFormCampos.Controls.Add(Me.BtnGuardar)
        Me.PanelFormCampos.Controls.Add(Me.LblMinAlquiler)
        Me.PanelFormCampos.Controls.Add(Me.CmbCliente)
        Me.PanelFormCampos.Controls.Add(Me.LblCliente)
        Me.PanelFormCampos.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelFormCampos.Location = New System.Drawing.Point(1, 30)
        Me.PanelFormCampos.Name = "PanelFormCampos"
        Me.PanelFormCampos.Size = New System.Drawing.Size(618, 369)
        Me.PanelFormCampos.TabIndex = 13
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
        Me.BunifuDatePicker1.Location = New System.Drawing.Point(360, 193)
        Me.BunifuDatePicker1.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.BunifuDatePicker1.MinimumSize = New System.Drawing.Size(217, 32)
        Me.BunifuDatePicker1.Name = "BunifuDatePicker1"
        Me.BunifuDatePicker1.Size = New System.Drawing.Size(217, 32)
        Me.BunifuDatePicker1.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(357, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 17)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Fecha de finalizacion"
        '
        'CmbEquipo
        '
        Me.CmbEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbEquipo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEquipo.FormattingEnabled = True
        Me.CmbEquipo.Location = New System.Drawing.Point(357, 67)
        Me.CmbEquipo.Name = "CmbEquipo"
        Me.CmbEquipo.Size = New System.Drawing.Size(196, 25)
        Me.CmbEquipo.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AllowDrop = True
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(357, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Equipo"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Silver
        Me.Panel8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel8.Location = New System.Drawing.Point(72, 215)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(120, 1)
        Me.Panel8.TabIndex = 29
        '
        'TxtMinAlquiler
        '
        Me.TxtMinAlquiler.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMinAlquiler.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMinAlquiler.Location = New System.Drawing.Point(75, 193)
        Me.TxtMinAlquiler.MaxLength = 9
        Me.TxtMinAlquiler.Name = "TxtMinAlquiler"
        Me.TxtMinAlquiler.Size = New System.Drawing.Size(110, 18)
        Me.TxtMinAlquiler.TabIndex = 21
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Location = New System.Drawing.Point(471, 303)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(103, 32)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Location = New System.Drawing.Point(342, 303)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(100, 32)
        Me.BtnGuardar.TabIndex = 0
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'LblMinAlquiler
        '
        Me.LblMinAlquiler.AutoSize = True
        Me.LblMinAlquiler.BackColor = System.Drawing.Color.White
        Me.LblMinAlquiler.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMinAlquiler.Location = New System.Drawing.Point(72, 165)
        Me.LblMinAlquiler.Name = "LblMinAlquiler"
        Me.LblMinAlquiler.Size = New System.Drawing.Size(118, 17)
        Me.LblMinAlquiler.TabIndex = 19
        Me.LblMinAlquiler.Text = "Minimo de alquiler"
        '
        'CmbCliente
        '
        Me.CmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCliente.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCliente.FormattingEnabled = True
        Me.CmbCliente.Location = New System.Drawing.Point(72, 67)
        Me.CmbCliente.Name = "CmbCliente"
        Me.CmbCliente.Size = New System.Drawing.Size(196, 25)
        Me.CmbCliente.TabIndex = 10
        '
        'LblCliente
        '
        Me.LblCliente.AllowDrop = True
        Me.LblCliente.AutoSize = True
        Me.LblCliente.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCliente.Location = New System.Drawing.Point(72, 44)
        Me.LblCliente.Name = "LblCliente"
        Me.LblCliente.Size = New System.Drawing.Size(47, 17)
        Me.LblCliente.TabIndex = 18
        Me.LblCliente.Text = "Cliente"
        '
        'DragControlVentana
        '
        Me.DragControlVentana.Fixed = True
        Me.DragControlVentana.Horizontal = True
        Me.DragControlVentana.TargetControl = Me
        Me.DragControlVentana.Vertical = True
        '
        'FormNewAlquiler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(620, 400)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelFormCampos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormNewAlquiler"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormNewAlquiler"
        Me.PanelFormCampos.ResumeLayout(False)
        Me.PanelFormCampos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PanelFormCampos As Panel
    Friend WithEvents BunifuDatePicker1 As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbEquipo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents TxtMinAlquiler As TextBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents LblMinAlquiler As Label
    Friend WithEvents CmbCliente As ComboBox
    Friend WithEvents LblCliente As Label
    Friend WithEvents DragControlVentana As Bunifu.Framework.UI.BunifuDragControl
End Class
