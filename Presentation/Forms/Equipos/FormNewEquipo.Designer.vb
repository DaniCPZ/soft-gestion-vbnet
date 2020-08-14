<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNewEquipo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelFormCampos = New System.Windows.Forms.Panel()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtSerial = New System.Windows.Forms.TextBox()
        Me.LblSerial = New System.Windows.Forms.Label()
        Me.LblImpresion = New System.Windows.Forms.Label()
        Me.LblVelocidad = New System.Windows.Forms.Label()
        Me.LblCopias = New System.Windows.Forms.Label()
        Me.TxtImpresion = New System.Windows.Forms.TextBox()
        Me.TxtCopias = New System.Windows.Forms.TextBox()
        Me.LblMarca = New System.Windows.Forms.Label()
        Me.TxtVelocidad = New System.Windows.Forms.TextBox()
        Me.LblModelo = New System.Windows.Forms.Label()
        Me.TxtModelo = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PanelFormCampos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nuevo"
        '
        'PanelFormCampos
        '
        Me.PanelFormCampos.BackColor = System.Drawing.Color.White
        Me.PanelFormCampos.Controls.Add(Me.TxtMarca)
        Me.PanelFormCampos.Controls.Add(Me.Panel7)
        Me.PanelFormCampos.Controls.Add(Me.Panel6)
        Me.PanelFormCampos.Controls.Add(Me.Panel5)
        Me.PanelFormCampos.Controls.Add(Me.Panel4)
        Me.PanelFormCampos.Controls.Add(Me.Panel3)
        Me.PanelFormCampos.Controls.Add(Me.Panel2)
        Me.PanelFormCampos.Controls.Add(Me.TxtSerial)
        Me.PanelFormCampos.Controls.Add(Me.LblSerial)
        Me.PanelFormCampos.Controls.Add(Me.LblImpresion)
        Me.PanelFormCampos.Controls.Add(Me.LblVelocidad)
        Me.PanelFormCampos.Controls.Add(Me.LblCopias)
        Me.PanelFormCampos.Controls.Add(Me.TxtImpresion)
        Me.PanelFormCampos.Controls.Add(Me.TxtCopias)
        Me.PanelFormCampos.Controls.Add(Me.LblMarca)
        Me.PanelFormCampos.Controls.Add(Me.TxtVelocidad)
        Me.PanelFormCampos.Controls.Add(Me.LblModelo)
        Me.PanelFormCampos.Controls.Add(Me.TxtModelo)
        Me.PanelFormCampos.Controls.Add(Me.BtnCancelar)
        Me.PanelFormCampos.Controls.Add(Me.BtnGuardar)
        Me.PanelFormCampos.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelFormCampos.Location = New System.Drawing.Point(1, 28)
        Me.PanelFormCampos.Name = "PanelFormCampos"
        Me.PanelFormCampos.Size = New System.Drawing.Size(448, 369)
        Me.PanelFormCampos.TabIndex = 13
        '
        'TxtMarca
        '
        Me.TxtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMarca.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMarca.Location = New System.Drawing.Point(46, 136)
        Me.TxtMarca.MaxLength = 20
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(110, 18)
        Me.TxtMarca.TabIndex = 30
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Silver
        Me.Panel7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel7.Location = New System.Drawing.Point(264, 247)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(120, 1)
        Me.Panel7.TabIndex = 46
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Silver
        Me.Panel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(264, 158)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(120, 1)
        Me.Panel6.TabIndex = 45
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(264, 74)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(120, 1)
        Me.Panel5.TabIndex = 44
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(44, 247)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(120, 1)
        Me.Panel4.TabIndex = 43
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(44, 158)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(120, 1)
        Me.Panel3.TabIndex = 42
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(44, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(120, 1)
        Me.Panel2.TabIndex = 41
        '
        'TxtSerial
        '
        Me.TxtSerial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtSerial.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSerial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtSerial.Location = New System.Drawing.Point(46, 52)
        Me.TxtSerial.MaxLength = 20
        Me.TxtSerial.Name = "TxtSerial"
        Me.TxtSerial.Size = New System.Drawing.Size(110, 18)
        Me.TxtSerial.TabIndex = 29
        '
        'LblSerial
        '
        Me.LblSerial.AutoSize = True
        Me.LblSerial.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSerial.Location = New System.Drawing.Point(46, 29)
        Me.LblSerial.Name = "LblSerial"
        Me.LblSerial.Size = New System.Drawing.Size(40, 17)
        Me.LblSerial.TabIndex = 35
        Me.LblSerial.Text = "Serial"
        '
        'LblImpresion
        '
        Me.LblImpresion.AutoSize = True
        Me.LblImpresion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblImpresion.Location = New System.Drawing.Point(266, 29)
        Me.LblImpresion.Name = "LblImpresion"
        Me.LblImpresion.Size = New System.Drawing.Size(115, 17)
        Me.LblImpresion.TabIndex = 38
        Me.LblImpresion.Text = "Tipo de impresion"
        '
        'LblVelocidad
        '
        Me.LblVelocidad.AutoSize = True
        Me.LblVelocidad.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVelocidad.Location = New System.Drawing.Point(266, 108)
        Me.LblVelocidad.Name = "LblVelocidad"
        Me.LblVelocidad.Size = New System.Drawing.Size(65, 17)
        Me.LblVelocidad.TabIndex = 39
        Me.LblVelocidad.Text = "Velocidad"
        '
        'LblCopias
        '
        Me.LblCopias.AutoSize = True
        Me.LblCopias.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCopias.Location = New System.Drawing.Point(266, 203)
        Me.LblCopias.Name = "LblCopias"
        Me.LblCopias.Size = New System.Drawing.Size(121, 17)
        Me.LblCopias.TabIndex = 40
        Me.LblCopias.Text = "Cantidad de copias"
        '
        'TxtImpresion
        '
        Me.TxtImpresion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtImpresion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImpresion.Location = New System.Drawing.Point(266, 52)
        Me.TxtImpresion.MaxLength = 20
        Me.TxtImpresion.Name = "TxtImpresion"
        Me.TxtImpresion.Size = New System.Drawing.Size(110, 18)
        Me.TxtImpresion.TabIndex = 32
        '
        'TxtCopias
        '
        Me.TxtCopias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCopias.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCopias.Location = New System.Drawing.Point(266, 224)
        Me.TxtCopias.MaxLength = 9
        Me.TxtCopias.Name = "TxtCopias"
        Me.TxtCopias.Size = New System.Drawing.Size(110, 18)
        Me.TxtCopias.TabIndex = 34
        '
        'LblMarca
        '
        Me.LblMarca.AutoSize = True
        Me.LblMarca.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMarca.Location = New System.Drawing.Point(46, 108)
        Me.LblMarca.Name = "LblMarca"
        Me.LblMarca.Size = New System.Drawing.Size(45, 17)
        Me.LblMarca.TabIndex = 36
        Me.LblMarca.Text = "Marca"
        '
        'TxtVelocidad
        '
        Me.TxtVelocidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtVelocidad.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVelocidad.Location = New System.Drawing.Point(266, 136)
        Me.TxtVelocidad.MaxLength = 20
        Me.TxtVelocidad.Name = "TxtVelocidad"
        Me.TxtVelocidad.Size = New System.Drawing.Size(110, 18)
        Me.TxtVelocidad.TabIndex = 33
        '
        'LblModelo
        '
        Me.LblModelo.AutoSize = True
        Me.LblModelo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblModelo.Location = New System.Drawing.Point(46, 203)
        Me.LblModelo.Name = "LblModelo"
        Me.LblModelo.Size = New System.Drawing.Size(54, 17)
        Me.LblModelo.TabIndex = 37
        Me.LblModelo.Text = "Modelo"
        '
        'TxtModelo
        '
        Me.TxtModelo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtModelo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtModelo.Location = New System.Drawing.Point(46, 225)
        Me.TxtModelo.MaxLength = 20
        Me.TxtModelo.Name = "TxtModelo"
        Me.TxtModelo.Size = New System.Drawing.Size(110, 18)
        Me.TxtModelo.TabIndex = 31
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
        Me.BtnCancelar.Location = New System.Drawing.Point(311, 300)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(81, 32)
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
        Me.BtnGuardar.Location = New System.Drawing.Point(201, 300)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(78, 32)
        Me.BtnGuardar.TabIndex = 0
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'FormNewEquipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(450, 400)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelFormCampos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormNewEquipo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormNewEquipo"
        Me.PanelFormCampos.ResumeLayout(False)
        Me.PanelFormCampos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PanelFormCampos As Panel
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents TxtMarca As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtSerial As TextBox
    Friend WithEvents LblSerial As Label
    Friend WithEvents LblImpresion As Label
    Friend WithEvents LblVelocidad As Label
    Friend WithEvents LblCopias As Label
    Friend WithEvents TxtImpresion As TextBox
    Friend WithEvents TxtCopias As TextBox
    Friend WithEvents LblMarca As Label
    Friend WithEvents TxtVelocidad As TextBox
    Friend WithEvents LblModelo As Label
    Friend WithEvents TxtModelo As TextBox
End Class
