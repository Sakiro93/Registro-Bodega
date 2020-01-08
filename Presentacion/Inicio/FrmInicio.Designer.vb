<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInicio))
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnConPro = New System.Windows.Forms.Button()
        Me.BtnConCat = New System.Windows.Forms.Button()
        Me.BtnRevHist = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.LblTiempo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnConProd = New System.Windows.Forms.Button()
        Me.BtnConMar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnConfi = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.White
        Me.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose
        Me.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(598, 388)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(92, 73)
        Me.BtnSalir.TabIndex = 146
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnConPro
        '
        Me.BtnConPro.BackColor = System.Drawing.Color.White
        Me.BtnConPro.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnConPro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Linen
        Me.BtnConPro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff
        Me.BtnConPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConPro.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConPro.ForeColor = System.Drawing.Color.White
        Me.BtnConPro.Image = CType(resources.GetObject("BtnConPro.Image"), System.Drawing.Image)
        Me.BtnConPro.Location = New System.Drawing.Point(241, 388)
        Me.BtnConPro.Name = "BtnConPro"
        Me.BtnConPro.Size = New System.Drawing.Size(92, 73)
        Me.BtnConPro.TabIndex = 145
        Me.BtnConPro.UseVisualStyleBackColor = False
        '
        'BtnConCat
        '
        Me.BtnConCat.BackColor = System.Drawing.Color.White
        Me.BtnConCat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnConCat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Linen
        Me.BtnConCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite
        Me.BtnConCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConCat.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConCat.ForeColor = System.Drawing.Color.White
        Me.BtnConCat.Image = CType(resources.GetObject("BtnConCat.Image"), System.Drawing.Image)
        Me.BtnConCat.Location = New System.Drawing.Point(46, 388)
        Me.BtnConCat.Name = "BtnConCat"
        Me.BtnConCat.Size = New System.Drawing.Size(92, 73)
        Me.BtnConCat.TabIndex = 144
        Me.BtnConCat.UseVisualStyleBackColor = False
        '
        'BtnRevHist
        '
        Me.BtnRevHist.BackColor = System.Drawing.Color.White
        Me.BtnRevHist.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnRevHist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AntiqueWhite
        Me.BtnRevHist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff
        Me.BtnRevHist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRevHist.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRevHist.ForeColor = System.Drawing.Color.White
        Me.BtnRevHist.Image = CType(resources.GetObject("BtnRevHist.Image"), System.Drawing.Image)
        Me.BtnRevHist.Location = New System.Drawing.Point(46, 263)
        Me.BtnRevHist.Name = "BtnRevHist"
        Me.BtnRevHist.Size = New System.Drawing.Size(92, 73)
        Me.BtnRevHist.TabIndex = 143
        Me.BtnRevHist.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(622, 474)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 18)
        Me.Label14.TabIndex = 140
        Me.Label14.Text = "Salir"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(202, 476)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(164, 18)
        Me.Label12.TabIndex = 139
        Me.Label12.Text = "Consultar Proveedor"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(40, 339)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(113, 15)
        Me.Label16.TabIndex = 138
        Me.Label16.Text = "Revisar Historial"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(21, 476)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 18)
        Me.Label10.TabIndex = 137
        Me.Label10.Text = "Consultar Categoria"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(135, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 80)
        Me.Label6.TabIndex = 135
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label9.Location = New System.Drawing.Point(11, 370)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(709, 138)
        Me.Label9.TabIndex = 136
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(285, 75)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 21)
        Me.Label7.TabIndex = 134
        Me.Label7.Text = "HORA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(285, 31)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 21)
        Me.Label5.TabIndex = 133
        Me.Label5.Text = "FECHA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label8.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(28, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 31)
        Me.Label8.TabIndex = 132
        Me.Label8.Text = "MENÚ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 212)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 15)
        Me.Label3.TabIndex = 130
        Me.Label3.Text = "Consultar Articulos"
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.BackColor = System.Drawing.Color.White
        Me.LblFecha.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.Location = New System.Drawing.Point(387, 31)
        Me.LblFecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(73, 21)
        Me.LblFecha.TabIndex = 129
        Me.LblFecha.Text = "Label1"
        '
        'LblTiempo
        '
        Me.LblTiempo.AutoSize = True
        Me.LblTiempo.BackColor = System.Drawing.Color.White
        Me.LblTiempo.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTiempo.Location = New System.Drawing.Point(387, 75)
        Me.LblTiempo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTiempo.Name = "LblTiempo"
        Me.LblTiempo.Size = New System.Drawing.Size(73, 21)
        Me.LblTiempo.TabIndex = 128
        Me.LblTiempo.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(709, 105)
        Me.Label1.TabIndex = 127
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(391, 136)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(329, 218)
        Me.PictureBox1.TabIndex = 126
        Me.PictureBox1.TabStop = False
        '
        'BtnConProd
        '
        Me.BtnConProd.BackColor = System.Drawing.Color.White
        Me.BtnConProd.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnConProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaShell
        Me.BtnConProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff
        Me.BtnConProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConProd.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConProd.ForeColor = System.Drawing.Color.White
        Me.BtnConProd.Image = CType(resources.GetObject("BtnConProd.Image"), System.Drawing.Image)
        Me.BtnConProd.Location = New System.Drawing.Point(46, 136)
        Me.BtnConProd.Name = "BtnConProd"
        Me.BtnConProd.Size = New System.Drawing.Size(92, 73)
        Me.BtnConProd.TabIndex = 142
        Me.BtnConProd.UseVisualStyleBackColor = False
        '
        'BtnConMar
        '
        Me.BtnConMar.BackColor = System.Drawing.Color.White
        Me.BtnConMar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnConMar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.BtnConMar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnConMar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConMar.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConMar.ForeColor = System.Drawing.Color.White
        Me.BtnConMar.Image = CType(resources.GetObject("BtnConMar.Image"), System.Drawing.Image)
        Me.BtnConMar.Location = New System.Drawing.Point(435, 388)
        Me.BtnConMar.Name = "BtnConMar"
        Me.BtnConMar.Size = New System.Drawing.Size(92, 73)
        Me.BtnConMar.TabIndex = 148
        Me.BtnConMar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(412, 476)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 18)
        Me.Label2.TabIndex = 147
        Me.Label2.Text = "Consultar Marca"
        '
        'BtnConfi
        '
        Me.BtnConfi.BackColor = System.Drawing.Color.White
        Me.BtnConfi.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnConfi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaShell
        Me.BtnConfi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff
        Me.BtnConfi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfi.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfi.ForeColor = System.Drawing.Color.White
        Me.BtnConfi.Image = CType(resources.GetObject("BtnConfi.Image"), System.Drawing.Image)
        Me.BtnConfi.Location = New System.Drawing.Point(241, 212)
        Me.BtnConfi.Name = "BtnConfi"
        Me.BtnConfi.Size = New System.Drawing.Size(92, 73)
        Me.BtnConfi.TabIndex = 150
        Me.BtnConfi.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(221, 288)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 15)
        Me.Label4.TabIndex = 149
        Me.Label4.Text = "Configurar Usuario"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(571, 31)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 21)
        Me.Label11.TabIndex = 151
        Me.Label11.Text = "USUARIO"
        '
        'LblNombre
        '
        Me.LblNombre.BackColor = System.Drawing.SystemColors.HotTrack
        Me.LblNombre.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.ForeColor = System.Drawing.Color.White
        Me.LblNombre.Location = New System.Drawing.Point(545, 75)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(154, 21)
        Me.LblNombre.TabIndex = 152
        Me.LblNombre.Text = "NOMBRE"
        Me.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(732, 517)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BtnConfi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnConMar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnConPro)
        Me.Controls.Add(Me.BtnConCat)
        Me.Controls.Add(Me.BtnRevHist)
        Me.Controls.Add(Me.BtnConProd)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.LblTiempo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FrmInicio"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnConPro As System.Windows.Forms.Button
    Friend WithEvents BtnConCat As System.Windows.Forms.Button
    Friend WithEvents BtnRevHist As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Friend WithEvents LblTiempo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnConProd As System.Windows.Forms.Button
    Friend WithEvents BtnConMar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnConfi As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label

End Class
