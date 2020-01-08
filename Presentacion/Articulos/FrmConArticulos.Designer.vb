<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConArticulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConArticulos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.TooMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CboCategoria = New System.Windows.Forms.ComboBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Dg = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Foto = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Detalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecReg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecCad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecMod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Editar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Devolver = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(567, 16)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(377, 29)
        Me.TxtBuscar.TabIndex = 62
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(297, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 27)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Buscar:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel2.Controls.Add(Me.BtnSalir)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1088, 167)
        Me.Panel2.TabIndex = 66
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalir.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.75!)
        Me.BtnSalir.ForeColor = System.Drawing.Color.Black
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(1000, 3)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(73, 77)
        Me.BtnSalir.TabIndex = 67
        Me.BtnSalir.Text = "SALIR"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(28, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(342, 111)
        Me.Label4.TabIndex = 66
        '
        'Label3
        '
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(644, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(300, 152)
        Me.Label3.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(430, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 111)
        Me.Label2.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Goudy Stout", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(2, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(505, 28)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "CONSULTA DE ARTICULOS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.CboCategoria)
        Me.Panel1.Controls.Add(Me.BtnNuevo)
        Me.Panel1.Controls.Add(Me.TxtBuscar)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(12, 200)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1088, 86)
        Me.Panel1.TabIndex = 65
        '
        'CboCategoria
        '
        Me.CboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboCategoria.FormattingEnabled = True
        Me.CboCategoria.Location = New System.Drawing.Point(415, 21)
        Me.CboCategoria.Name = "CboCategoria"
        Me.CboCategoria.Size = New System.Drawing.Size(130, 21)
        Me.CboCategoria.TabIndex = 64
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(7, 4)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(119, 52)
        Me.BtnNuevo.TabIndex = 63
        Me.BtnNuevo.Text = "NUEVO"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'Dg
        '
        Me.Dg.AllowUserToAddRows = False
        Me.Dg.AllowUserToDeleteRows = False
        Me.Dg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Dg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.Dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Tomato
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Foto, Me.Descripción, Me.Detalle, Me.Categoria, Me.Marca, Me.Precio, Me.Stock, Me.IVA, Me.FecReg, Me.FecCad, Me.FecMod, Me.Estado, Me.Editar, Me.Devolver})
        Me.Dg.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.Dg.Location = New System.Drawing.Point(12, 304)
        Me.Dg.Name = "Dg"
        Me.Dg.ReadOnly = True
        Me.Dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Tomato
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg.Size = New System.Drawing.Size(1088, 260)
        Me.Dg.TabIndex = 64
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Foto
        '
        Me.Foto.HeaderText = "Foto"
        Me.Foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Foto.Name = "Foto"
        Me.Foto.ReadOnly = True
        '
        'Descripción
        '
        Me.Descripción.HeaderText = "Descripcion"
        Me.Descripción.Name = "Descripción"
        Me.Descripción.ReadOnly = True
        '
        'Detalle
        '
        Me.Detalle.HeaderText = "Detalle"
        Me.Detalle.Name = "Detalle"
        Me.Detalle.ReadOnly = True
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        Me.Categoria.ReadOnly = True
        '
        'Marca
        '
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        Me.Marca.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Stock
        '
        Me.Stock.HeaderText = "Stock"
        Me.Stock.Name = "Stock"
        Me.Stock.ReadOnly = True
        '
        'IVA
        '
        Me.IVA.HeaderText = "IVA"
        Me.IVA.Name = "IVA"
        Me.IVA.ReadOnly = True
        '
        'FecReg
        '
        Me.FecReg.HeaderText = "Fec-Reg"
        Me.FecReg.Name = "FecReg"
        Me.FecReg.ReadOnly = True
        '
        'FecCad
        '
        Me.FecCad.HeaderText = "Fec-Cad"
        Me.FecCad.Name = "FecCad"
        Me.FecCad.ReadOnly = True
        '
        'FecMod
        '
        Me.FecMod.HeaderText = "Fec-Mod"
        Me.FecMod.Name = "FecMod"
        Me.FecMod.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'Editar
        '
        Me.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Editar.HeaderText = "Accion"
        Me.Editar.Name = "Editar"
        Me.Editar.ReadOnly = True
        Me.Editar.Text = "Editar"
        Me.Editar.ToolTipText = "Click para Modificar"
        Me.Editar.UseColumnTextForButtonValue = True
        Me.Editar.Width = 50
        '
        'Devolver
        '
        Me.Devolver.HeaderText = "Accion"
        Me.Devolver.Name = "Devolver"
        Me.Devolver.ReadOnly = True
        Me.Devolver.Text = "Devolver"
        Me.Devolver.ToolTipText = "Click para Devolver Registro"
        Me.Devolver.UseColumnTextForButtonValue = True
        '
        'FrmConArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(1113, 586)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Dg)
        Me.Name = "FrmConArticulos"
        Me.Text = "FrmConArticulos"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents TooMensaje As System.Windows.Forms.ToolTip
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Dg As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents CboCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Foto As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Descripción As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Detalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Categoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FecReg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FecCad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FecMod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Editar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Devolver As System.Windows.Forms.DataGridViewButtonColumn
End Class
