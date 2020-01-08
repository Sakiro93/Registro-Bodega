<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManMarca
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
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GboxMarca = New System.Windows.Forms.GroupBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TooMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.ErrDatos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GboxMarca.SuspendLayout()
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Firebrick
        Me.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Location = New System.Drawing.Point(334, 231)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(106, 38)
        Me.BtnSalir.TabIndex = 88
        Me.BtnSalir.Text = "SALIR"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DESCRIPCION"
        '
        'GboxMarca
        '
        Me.GboxMarca.BackColor = System.Drawing.Color.Moccasin
        Me.GboxMarca.Controls.Add(Me.TxtDescripcion)
        Me.GboxMarca.Controls.Add(Me.Label2)
        Me.GboxMarca.Controls.Add(Me.Label1)
        Me.GboxMarca.Controls.Add(Me.TxtCodigo)
        Me.GboxMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GboxMarca.Location = New System.Drawing.Point(14, 54)
        Me.GboxMarca.Name = "GboxMarca"
        Me.GboxMarca.Size = New System.Drawing.Size(467, 144)
        Me.GboxMarca.TabIndex = 85
        Me.GboxMarca.TabStop = False
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(212, 86)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(170, 20)
        Me.TxtDescripcion.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CODIGO"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Enabled = False
        Me.TxtCodigo.Location = New System.Drawing.Point(212, 35)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(117, 20)
        Me.TxtCodigo.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label7.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(82, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(328, 31)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "REGISTRO DE MARCA"
        '
        'BtnGrabar
        '
        Me.BtnGrabar.BackColor = System.Drawing.Color.Goldenrod
        Me.BtnGrabar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnGrabar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BurlyWood
        Me.BtnGrabar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod
        Me.BtnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrabar.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGrabar.ForeColor = System.Drawing.Color.White
        Me.BtnGrabar.Location = New System.Drawing.Point(47, 231)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(106, 38)
        Me.BtnGrabar.TabIndex = 87
        Me.BtnGrabar.Text = "GRABAR"
        Me.BtnGrabar.UseVisualStyleBackColor = False
        '
        'ErrDatos
        '
        Me.ErrDatos.ContainerControl = Me
        '
        'FrmManMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.ClientSize = New System.Drawing.Size(497, 281)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.GboxMarca)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Name = "FrmManMarca"
        Me.Text = "FrmManMarca"
        Me.GboxMarca.ResumeLayout(False)
        Me.GboxMarca.PerformLayout()
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GboxMarca As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TooMensaje As System.Windows.Forms.ToolTip
    Friend WithEvents BtnGrabar As System.Windows.Forms.Button
    Friend WithEvents ErrDatos As System.Windows.Forms.ErrorProvider
End Class
