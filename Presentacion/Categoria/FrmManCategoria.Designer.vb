<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManCategoria
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
        Me.GboxCategoria = New System.Windows.Forms.GroupBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.TooMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ErrDatos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GboxCategoria.SuspendLayout()
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GboxCategoria
        '
        Me.GboxCategoria.BackColor = System.Drawing.Color.PapayaWhip
        Me.GboxCategoria.Controls.Add(Me.TxtDescripcion)
        Me.GboxCategoria.Controls.Add(Me.Label2)
        Me.GboxCategoria.Controls.Add(Me.Label1)
        Me.GboxCategoria.Controls.Add(Me.TxtCodigo)
        Me.GboxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GboxCategoria.Location = New System.Drawing.Point(9, 54)
        Me.GboxCategoria.Name = "GboxCategoria"
        Me.GboxCategoria.Size = New System.Drawing.Size(467, 142)
        Me.GboxCategoria.TabIndex = 81
        Me.GboxCategoria.TabStop = False
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(212, 86)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(170, 20)
        Me.TxtDescripcion.TabIndex = 4
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
        'BtnGrabar
        '
        Me.BtnGrabar.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.BtnGrabar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnGrabar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BurlyWood
        Me.BtnGrabar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod
        Me.BtnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrabar.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGrabar.ForeColor = System.Drawing.Color.White
        Me.BtnGrabar.Location = New System.Drawing.Point(53, 223)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(106, 38)
        Me.BtnGrabar.TabIndex = 83
        Me.BtnGrabar.Text = "GRABAR"
        Me.BtnGrabar.UseVisualStyleBackColor = False
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
        Me.BtnSalir.Location = New System.Drawing.Point(337, 223)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(106, 38)
        Me.BtnSalir.TabIndex = 84
        Me.BtnSalir.Text = "SALIR"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.BurlyWood
        Me.Label7.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(47, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(396, 31)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "REGISTRO DE CATEGORIA"
        '
        'ErrDatos
        '
        Me.ErrDatos.ContainerControl = Me
        '
        'FrmManCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(487, 274)
        Me.Controls.Add(Me.GboxCategoria)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label7)
        Me.Name = "FrmManCategoria"
        Me.Text = "FrmManCategoria"
        Me.GboxCategoria.ResumeLayout(False)
        Me.GboxCategoria.PerformLayout()
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GboxCategoria As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents BtnGrabar As System.Windows.Forms.Button
    Friend WithEvents TooMensaje As System.Windows.Forms.ToolTip
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ErrDatos As System.Windows.Forms.ErrorProvider
End Class
