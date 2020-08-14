<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNewRepuestoProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNewRepuestoProveedor))
        Me.PanelFormCampos = New System.Windows.Forms.Panel()
        Me.CmbProveedor = New System.Windows.Forms.ComboBox()
        Me.cmbRepuesto = New System.Windows.Forms.ComboBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblNroRepuesto = New System.Windows.Forms.Label()
        Me.lblLoteCompra = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.DragControlVentana = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PanelFormCampos.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelFormCampos
        '
        Me.PanelFormCampos.BackColor = System.Drawing.Color.White
        Me.PanelFormCampos.Controls.Add(Me.CmbProveedor)
        Me.PanelFormCampos.Controls.Add(Me.cmbRepuesto)
        Me.PanelFormCampos.Controls.Add(Me.txtObs)
        Me.PanelFormCampos.Controls.Add(Me.PictureBox2)
        Me.PanelFormCampos.Controls.Add(Me.Label1)
        Me.PanelFormCampos.Controls.Add(Me.LblNroRepuesto)
        Me.PanelFormCampos.Controls.Add(Me.lblLoteCompra)
        Me.PanelFormCampos.Controls.Add(Me.BtnCancelar)
        Me.PanelFormCampos.Controls.Add(Me.BtnGuardar)
        Me.PanelFormCampos.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelFormCampos.Location = New System.Drawing.Point(1, 27)
        Me.PanelFormCampos.Name = "PanelFormCampos"
        Me.PanelFormCampos.Size = New System.Drawing.Size(529, 299)
        Me.PanelFormCampos.TabIndex = 18
        '
        'CmbProveedor
        '
        Me.CmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbProveedor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbProveedor.FormattingEnabled = True
        Me.CmbProveedor.Location = New System.Drawing.Point(283, 62)
        Me.CmbProveedor.Name = "CmbProveedor"
        Me.CmbProveedor.Size = New System.Drawing.Size(213, 25)
        Me.CmbProveedor.TabIndex = 43
        '
        'cmbRepuesto
        '
        Me.cmbRepuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRepuesto.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRepuesto.FormattingEnabled = True
        Me.cmbRepuesto.Location = New System.Drawing.Point(52, 62)
        Me.cmbRepuesto.Name = "cmbRepuesto"
        Me.cmbRepuesto.Size = New System.Drawing.Size(169, 25)
        Me.cmbRepuesto.TabIndex = 42
        '
        'txtObs
        '
        Me.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObs.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObs.Location = New System.Drawing.Point(60, 163)
        Me.txtObs.MaxLength = 150
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(175, 38)
        Me.txtObs.TabIndex = 39
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(52, 154)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(194, 58)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 41
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Observacion"
        '
        'LblNroRepuesto
        '
        Me.LblNroRepuesto.AutoSize = True
        Me.LblNroRepuesto.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNroRepuesto.Location = New System.Drawing.Point(49, 32)
        Me.LblNroRepuesto.Name = "LblNroRepuesto"
        Me.LblNroRepuesto.Size = New System.Drawing.Size(131, 17)
        Me.LblNroRepuesto.TabIndex = 29
        Me.LblNroRepuesto.Text = "Numero de repuesto"
        '
        'lblLoteCompra
        '
        Me.lblLoteCompra.AutoSize = True
        Me.lblLoteCompra.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoteCompra.Location = New System.Drawing.Point(280, 32)
        Me.lblLoteCompra.Name = "lblLoteCompra"
        Me.lblLoteCompra.Size = New System.Drawing.Size(69, 17)
        Me.lblLoteCompra.TabIndex = 32
        Me.lblLoteCompra.Text = "Proveedor"
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
        Me.BtnCancelar.Location = New System.Drawing.Point(392, 245)
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
        Me.BtnGuardar.Location = New System.Drawing.Point(282, 245)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(78, 32)
        Me.BtnGuardar.TabIndex = 0
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(8, 4)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(48, 17)
        Me.lblTitulo.TabIndex = 17
        Me.lblTitulo.Text = "Nuevo"
        '
        'DragControlVentana
        '
        Me.DragControlVentana.Fixed = True
        Me.DragControlVentana.Horizontal = True
        Me.DragControlVentana.TargetControl = Me
        Me.DragControlVentana.Vertical = True
        '
        'FormNewRepuestoProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(531, 328)
        Me.Controls.Add(Me.PanelFormCampos)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormNewRepuestoProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormNewRepuestoProveedor"
        Me.PanelFormCampos.ResumeLayout(False)
        Me.PanelFormCampos.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelFormCampos As Panel
    Friend WithEvents CmbProveedor As ComboBox
    Friend WithEvents cmbRepuesto As ComboBox
    Friend WithEvents txtObs As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblNroRepuesto As Label
    Friend WithEvents lblLoteCompra As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents DragControlVentana As Bunifu.Framework.UI.BunifuDragControl
End Class
