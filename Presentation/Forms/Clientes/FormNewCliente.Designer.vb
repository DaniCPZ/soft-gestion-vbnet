<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNewCliente
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
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtCuit = New System.Windows.Forms.TextBox()
        Me.TxtIva = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.PanelFormCampos = New System.Windows.Forms.Panel()
        Me.cmbCuit = New System.Windows.Forms.ComboBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.CmbLocalidad = New System.Windows.Forms.ComboBox()
        Me.LblLocalidad = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblIva = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.LblCuit = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DragControlVentana = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.PanelFormCampos.SuspendLayout()
        Me.SuspendLayout()
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
        Me.BtnGuardar.Location = New System.Drawing.Point(362, 298)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(100, 32)
        Me.BtnGuardar.TabIndex = 0
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
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
        Me.BtnCancelar.Location = New System.Drawing.Point(507, 298)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(103, 32)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'TxtNombre
        '
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombre.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(52, 48)
        Me.TxtNombre.MaxLength = 50
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(110, 18)
        Me.TxtNombre.TabIndex = 2
        '
        'TxtCuit
        '
        Me.TxtCuit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCuit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCuit.Location = New System.Drawing.Point(93, 127)
        Me.TxtCuit.MaxLength = 9
        Me.TxtCuit.Name = "TxtCuit"
        Me.TxtCuit.Size = New System.Drawing.Size(99, 18)
        Me.TxtCuit.TabIndex = 4
        '
        'TxtIva
        '
        Me.TxtIva.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtIva.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIva.Location = New System.Drawing.Point(272, 48)
        Me.TxtIva.MaxLength = 50
        Me.TxtIva.Name = "TxtIva"
        Me.TxtIva.Size = New System.Drawing.Size(110, 18)
        Me.TxtIva.TabIndex = 5
        '
        'TxtEmail
        '
        Me.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtEmail.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(272, 132)
        Me.TxtEmail.MaxLength = 150
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(110, 18)
        Me.TxtEmail.TabIndex = 6
        '
        'TxtTelefono
        '
        Me.TxtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTelefono.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefono.Location = New System.Drawing.Point(52, 212)
        Me.TxtTelefono.MaxLength = 20
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(110, 18)
        Me.TxtTelefono.TabIndex = 7
        '
        'PanelFormCampos
        '
        Me.PanelFormCampos.BackColor = System.Drawing.Color.White
        Me.PanelFormCampos.Controls.Add(Me.Panel1)
        Me.PanelFormCampos.Controls.Add(Me.Label2)
        Me.PanelFormCampos.Controls.Add(Me.txtSaldo)
        Me.PanelFormCampos.Controls.Add(Me.cmbCuit)
        Me.PanelFormCampos.Controls.Add(Me.Panel8)
        Me.PanelFormCampos.Controls.Add(Me.Panel7)
        Me.PanelFormCampos.Controls.Add(Me.Panel6)
        Me.PanelFormCampos.Controls.Add(Me.Panel5)
        Me.PanelFormCampos.Controls.Add(Me.Panel4)
        Me.PanelFormCampos.Controls.Add(Me.TxtDireccion)
        Me.PanelFormCampos.Controls.Add(Me.BtnCancelar)
        Me.PanelFormCampos.Controls.Add(Me.Panel2)
        Me.PanelFormCampos.Controls.Add(Me.BtnGuardar)
        Me.PanelFormCampos.Controls.Add(Me.LblDireccion)
        Me.PanelFormCampos.Controls.Add(Me.TxtNombre)
        Me.PanelFormCampos.Controls.Add(Me.CmbLocalidad)
        Me.PanelFormCampos.Controls.Add(Me.LblLocalidad)
        Me.PanelFormCampos.Controls.Add(Me.LblNombre)
        Me.PanelFormCampos.Controls.Add(Me.LblIva)
        Me.PanelFormCampos.Controls.Add(Me.LblEmail)
        Me.PanelFormCampos.Controls.Add(Me.LblTelefono)
        Me.PanelFormCampos.Controls.Add(Me.TxtIva)
        Me.PanelFormCampos.Controls.Add(Me.TxtTelefono)
        Me.PanelFormCampos.Controls.Add(Me.TxtEmail)
        Me.PanelFormCampos.Controls.Add(Me.LblCuit)
        Me.PanelFormCampos.Controls.Add(Me.TxtCuit)
        Me.PanelFormCampos.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelFormCampos.Location = New System.Drawing.Point(1, 30)
        Me.PanelFormCampos.Name = "PanelFormCampos"
        Me.PanelFormCampos.Size = New System.Drawing.Size(648, 369)
        Me.PanelFormCampos.TabIndex = 11
        '
        'cmbCuit
        '
        Me.cmbCuit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCuit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCuit.FormattingEnabled = True
        Me.cmbCuit.Items.AddRange(New Object() {"20", "27", "30"})
        Me.cmbCuit.Location = New System.Drawing.Point(49, 124)
        Me.cmbCuit.Name = "cmbCuit"
        Me.cmbCuit.Size = New System.Drawing.Size(39, 25)
        Me.cmbCuit.TabIndex = 53
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Silver
        Me.Panel8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel8.Location = New System.Drawing.Point(486, 154)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(120, 1)
        Me.Panel8.TabIndex = 29
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Silver
        Me.Panel7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel7.Location = New System.Drawing.Point(50, 235)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(120, 1)
        Me.Panel7.TabIndex = 28
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Silver
        Me.Panel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(270, 154)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(120, 1)
        Me.Panel6.TabIndex = 27
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(270, 70)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(120, 1)
        Me.Panel5.TabIndex = 26
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(50, 154)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(140, 1)
        Me.Panel4.TabIndex = 25
        '
        'TxtDireccion
        '
        Me.TxtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDireccion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.Location = New System.Drawing.Point(489, 132)
        Me.TxtDireccion.MaxLength = 50
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(110, 18)
        Me.TxtDireccion.TabIndex = 21
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(50, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(120, 1)
        Me.Panel2.TabIndex = 23
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.BackColor = System.Drawing.Color.White
        Me.LblDireccion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDireccion.Location = New System.Drawing.Point(486, 104)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(62, 17)
        Me.LblDireccion.TabIndex = 19
        Me.LblDireccion.Text = "Direccion"
        '
        'CmbLocalidad
        '
        Me.CmbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbLocalidad.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbLocalidad.FormattingEnabled = True
        Me.CmbLocalidad.Location = New System.Drawing.Point(485, 48)
        Me.CmbLocalidad.Name = "CmbLocalidad"
        Me.CmbLocalidad.Size = New System.Drawing.Size(121, 25)
        Me.CmbLocalidad.TabIndex = 10
        '
        'LblLocalidad
        '
        Me.LblLocalidad.AllowDrop = True
        Me.LblLocalidad.AutoSize = True
        Me.LblLocalidad.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLocalidad.Location = New System.Drawing.Point(486, 25)
        Me.LblLocalidad.Name = "LblLocalidad"
        Me.LblLocalidad.Size = New System.Drawing.Size(64, 17)
        Me.LblLocalidad.TabIndex = 18
        Me.LblLocalidad.Text = "Localidad"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(52, 25)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(146, 17)
        Me.LblNombre.TabIndex = 12
        Me.LblNombre.Text = "Nombre o Razon social"
        '
        'LblIva
        '
        Me.LblIva.AutoSize = True
        Me.LblIva.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIva.Location = New System.Drawing.Point(272, 25)
        Me.LblIva.Name = "LblIva"
        Me.LblIva.Size = New System.Drawing.Size(88, 17)
        Me.LblIva.TabIndex = 15
        Me.LblIva.Text = "Condicion IVA"
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmail.Location = New System.Drawing.Point(272, 104)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(39, 17)
        Me.LblEmail.TabIndex = 16
        Me.LblEmail.Text = "Email"
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTelefono.Location = New System.Drawing.Point(52, 191)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(58, 17)
        Me.LblTelefono.TabIndex = 17
        Me.LblTelefono.Text = "Telefono"
        '
        'LblCuit
        '
        Me.LblCuit.AutoSize = True
        Me.LblCuit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCuit.Location = New System.Drawing.Point(52, 104)
        Me.LblCuit.Name = "LblCuit"
        Me.LblCuit.Size = New System.Drawing.Size(30, 17)
        Me.LblCuit.TabIndex = 14
        Me.LblCuit.Text = "Cuit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nuevo"
        '
        'DragControlVentana
        '
        Me.DragControlVentana.Fixed = True
        Me.DragControlVentana.Horizontal = True
        Me.DragControlVentana.TargetControl = Me
        Me.DragControlVentana.Vertical = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(270, 235)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(120, 1)
        Me.Panel1.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(272, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Saldo"
        '
        'txtSaldo
        '
        Me.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSaldo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(272, 212)
        Me.txtSaldo.MaxLength = 20
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(110, 18)
        Me.txtSaldo.TabIndex = 54
        '
        'FormNewCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(650, 400)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelFormCampos)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormNewCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormNewCliente"
        Me.PanelFormCampos.ResumeLayout(False)
        Me.PanelFormCampos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtCuit As TextBox
    Friend WithEvents TxtIva As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents PanelFormCampos As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblCuit As Label
    Friend WithEvents LblIva As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblTelefono As Label
    Friend WithEvents DragControlVentana As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents LblDireccion As Label
    Friend WithEvents CmbLocalidad As ComboBox
    Friend WithEvents LblLocalidad As Label
    Friend WithEvents cmbCuit As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSaldo As TextBox
End Class
