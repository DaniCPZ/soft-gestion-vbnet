<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditRepuesto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditRepuesto))
        Me.PanelFormCampos = New System.Windows.Forms.Panel()
        Me.TxtDesc = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblNroRepuesto = New System.Windows.Forms.Label()
        Me.lblLoteCompra = New System.Windows.Forms.Label()
        Me.LblStock = New System.Windows.Forms.Label()
        Me.LblDesc = New System.Windows.Forms.Label()
        Me.LblCostoUnitario = New System.Windows.Forms.Label()
        Me.LblPuntoPedido = New System.Windows.Forms.Label()
        Me.TxtCostoUnitario = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxtNroRepuesto = New System.Windows.Forms.TextBox()
        Me.TxtLoteCompra = New System.Windows.Forms.TextBox()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.TxtPP = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.DragControlVentana = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PanelFormCampos.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelFormCampos
        '
        Me.PanelFormCampos.BackColor = System.Drawing.Color.White
        Me.PanelFormCampos.Controls.Add(Me.TxtDesc)
        Me.PanelFormCampos.Controls.Add(Me.PictureBox1)
        Me.PanelFormCampos.Controls.Add(Me.LblNroRepuesto)
        Me.PanelFormCampos.Controls.Add(Me.lblLoteCompra)
        Me.PanelFormCampos.Controls.Add(Me.LblStock)
        Me.PanelFormCampos.Controls.Add(Me.LblDesc)
        Me.PanelFormCampos.Controls.Add(Me.LblCostoUnitario)
        Me.PanelFormCampos.Controls.Add(Me.LblPuntoPedido)
        Me.PanelFormCampos.Controls.Add(Me.TxtCostoUnitario)
        Me.PanelFormCampos.Controls.Add(Me.Panel6)
        Me.PanelFormCampos.Controls.Add(Me.Panel5)
        Me.PanelFormCampos.Controls.Add(Me.Panel4)
        Me.PanelFormCampos.Controls.Add(Me.Panel3)
        Me.PanelFormCampos.Controls.Add(Me.BtnCancelar)
        Me.PanelFormCampos.Controls.Add(Me.Panel2)
        Me.PanelFormCampos.Controls.Add(Me.BtnGuardar)
        Me.PanelFormCampos.Controls.Add(Me.TxtNroRepuesto)
        Me.PanelFormCampos.Controls.Add(Me.TxtLoteCompra)
        Me.PanelFormCampos.Controls.Add(Me.TxtStock)
        Me.PanelFormCampos.Controls.Add(Me.TxtPP)
        Me.PanelFormCampos.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelFormCampos.Location = New System.Drawing.Point(1, 27)
        Me.PanelFormCampos.Name = "PanelFormCampos"
        Me.PanelFormCampos.Size = New System.Drawing.Size(478, 389)
        Me.PanelFormCampos.TabIndex = 16
        '
        'TxtDesc
        '
        Me.TxtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDesc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDesc.Location = New System.Drawing.Point(278, 237)
        Me.TxtDesc.MaxLength = 150
        Me.TxtDesc.Multiline = True
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(175, 38)
        Me.TxtDesc.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(270, 228)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
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
        Me.lblLoteCompra.Location = New System.Drawing.Point(269, 32)
        Me.lblLoteCompra.Name = "lblLoteCompra"
        Me.lblLoteCompra.Size = New System.Drawing.Size(101, 17)
        Me.lblLoteCompra.TabIndex = 32
        Me.lblLoteCompra.Text = "Lote de compra"
        '
        'LblStock
        '
        Me.LblStock.AutoSize = True
        Me.LblStock.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStock.Location = New System.Drawing.Point(269, 111)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(39, 17)
        Me.LblStock.TabIndex = 33
        Me.LblStock.Text = "Stock"
        '
        'LblDesc
        '
        Me.LblDesc.AutoSize = True
        Me.LblDesc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDesc.Location = New System.Drawing.Point(269, 206)
        Me.LblDesc.Name = "LblDesc"
        Me.LblDesc.Size = New System.Drawing.Size(76, 17)
        Me.LblDesc.TabIndex = 34
        Me.LblDesc.Text = "Descripcion"
        '
        'LblCostoUnitario
        '
        Me.LblCostoUnitario.AutoSize = True
        Me.LblCostoUnitario.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCostoUnitario.Location = New System.Drawing.Point(49, 111)
        Me.LblCostoUnitario.Name = "LblCostoUnitario"
        Me.LblCostoUnitario.Size = New System.Drawing.Size(90, 17)
        Me.LblCostoUnitario.TabIndex = 30
        Me.LblCostoUnitario.Text = "Costo unitario"
        '
        'LblPuntoPedido
        '
        Me.LblPuntoPedido.AutoSize = True
        Me.LblPuntoPedido.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPuntoPedido.Location = New System.Drawing.Point(49, 206)
        Me.LblPuntoPedido.Name = "LblPuntoPedido"
        Me.LblPuntoPedido.Size = New System.Drawing.Size(106, 17)
        Me.LblPuntoPedido.TabIndex = 31
        Me.LblPuntoPedido.Text = "Punto de pedido"
        '
        'TxtCostoUnitario
        '
        Me.TxtCostoUnitario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCostoUnitario.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCostoUnitario.Location = New System.Drawing.Point(52, 139)
        Me.TxtCostoUnitario.MaxLength = 13
        Me.TxtCostoUnitario.Name = "TxtCostoUnitario"
        Me.TxtCostoUnitario.Size = New System.Drawing.Size(110, 18)
        Me.TxtCostoUnitario.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Silver
        Me.Panel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(270, 161)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(120, 1)
        Me.Panel6.TabIndex = 27
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(270, 77)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(120, 1)
        Me.Panel5.TabIndex = 26
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(50, 250)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(120, 1)
        Me.Panel4.TabIndex = 25
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(50, 161)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(120, 1)
        Me.Panel3.TabIndex = 24
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
        Me.BtnCancelar.Location = New System.Drawing.Point(368, 338)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(81, 32)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(50, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(120, 1)
        Me.Panel2.TabIndex = 23
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Location = New System.Drawing.Point(258, 338)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(78, 32)
        Me.BtnGuardar.TabIndex = 0
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'TxtNroRepuesto
        '
        Me.TxtNroRepuesto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNroRepuesto.Enabled = False
        Me.TxtNroRepuesto.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNroRepuesto.Location = New System.Drawing.Point(52, 55)
        Me.TxtNroRepuesto.Name = "TxtNroRepuesto"
        Me.TxtNroRepuesto.ReadOnly = True
        Me.TxtNroRepuesto.Size = New System.Drawing.Size(110, 18)
        Me.TxtNroRepuesto.TabIndex = 2
        '
        'TxtLoteCompra
        '
        Me.TxtLoteCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtLoteCompra.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLoteCompra.Location = New System.Drawing.Point(272, 55)
        Me.TxtLoteCompra.MaxLength = 9
        Me.TxtLoteCompra.Name = "TxtLoteCompra"
        Me.TxtLoteCompra.Size = New System.Drawing.Size(110, 18)
        Me.TxtLoteCompra.TabIndex = 5
        '
        'TxtStock
        '
        Me.TxtStock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtStock.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStock.Location = New System.Drawing.Point(272, 139)
        Me.TxtStock.MaxLength = 9
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(110, 18)
        Me.TxtStock.TabIndex = 6
        '
        'TxtPP
        '
        Me.TxtPP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPP.Location = New System.Drawing.Point(52, 228)
        Me.TxtPP.MaxLength = 9
        Me.TxtPP.Name = "TxtPP"
        Me.TxtPP.Size = New System.Drawing.Size(110, 18)
        Me.TxtPP.TabIndex = 4
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(8, 5)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(44, 17)
        Me.lblTitulo.TabIndex = 15
        Me.lblTitulo.Text = "Editar"
        '
        'DragControlVentana
        '
        Me.DragControlVentana.Fixed = True
        Me.DragControlVentana.Horizontal = True
        Me.DragControlVentana.TargetControl = Me
        Me.DragControlVentana.Vertical = True
        '
        'FormEditRepuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(480, 417)
        Me.Controls.Add(Me.PanelFormCampos)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormEditRepuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormEditRepuesto"
        Me.PanelFormCampos.ResumeLayout(False)
        Me.PanelFormCampos.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelFormCampos As Panel
    Friend WithEvents TxtDesc As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblNroRepuesto As Label
    Friend WithEvents lblLoteCompra As Label
    Friend WithEvents LblStock As Label
    Friend WithEvents LblDesc As Label
    Friend WithEvents LblCostoUnitario As Label
    Friend WithEvents LblPuntoPedido As Label
    Friend WithEvents TxtCostoUnitario As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents TxtNroRepuesto As TextBox
    Friend WithEvents TxtLoteCompra As TextBox
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents TxtPP As TextBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents DragControlVentana As Bunifu.Framework.UI.BunifuDragControl
End Class
