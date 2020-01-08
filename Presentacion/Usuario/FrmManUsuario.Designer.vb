<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManUsuario
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
        Me.TooMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GboxUsuario = New System.Windows.Forms.GroupBox()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.ErrDatos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GboxUsuario.SuspendLayout()
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Location = New System.Drawing.Point(556, 86)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.Size = New System.Drawing.Size(170, 20)
        Me.TxtContraseña.TabIndex = 9
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.BackColor = System.Drawing.Color.DarkCyan
        Me.BtnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.BtnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.BtnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrar.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.ForeColor = System.Drawing.Color.White
        Me.BtnRegistrar.Location = New System.Drawing.Point(122, 231)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(106, 38)
        Me.BtnRegistrar.TabIndex = 80
        Me.BtnRegistrar.Text = "REGISTRAR"
        Me.BtnRegistrar.UseVisualStyleBackColor = False
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
        Me.BtnSalir.Location = New System.Drawing.Point(512, 231)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(106, 38)
        Me.BtnSalir.TabIndex = 81
        Me.BtnSalir.Text = "SALIR"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(371, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "CONTRASEÑA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Teal
        Me.Label7.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(227, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(357, 31)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "REGISTRO DE USUARIO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(371, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "USUARIO"
        '
        'GboxUsuario
        '
        Me.GboxUsuario.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GboxUsuario.Controls.Add(Me.TxtContraseña)
        Me.GboxUsuario.Controls.Add(Me.Label5)
        Me.GboxUsuario.Controls.Add(Me.Label4)
        Me.GboxUsuario.Controls.Add(Me.TxtUsuario)
        Me.GboxUsuario.Controls.Add(Me.TxtNombre)
        Me.GboxUsuario.Controls.Add(Me.Label2)
        Me.GboxUsuario.Controls.Add(Me.Label1)
        Me.GboxUsuario.Controls.Add(Me.TxtCodigo)
        Me.GboxUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GboxUsuario.Location = New System.Drawing.Point(8, 72)
        Me.GboxUsuario.Name = "GboxUsuario"
        Me.GboxUsuario.Size = New System.Drawing.Size(784, 144)
        Me.GboxUsuario.TabIndex = 78
        Me.GboxUsuario.TabStop = False
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(556, 34)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(170, 20)
        Me.TxtUsuario.TabIndex = 5
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(114, 86)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(170, 20)
        Me.TxtNombre.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NOMBRE"
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
        Me.TxtCodigo.Location = New System.Drawing.Point(114, 32)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(106, 20)
        Me.TxtCodigo.TabIndex = 1
        '
        'ErrDatos
        '
        Me.ErrDatos.ContainerControl = Me
        '
        'FrmManUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(811, 283)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GboxUsuario)
        Me.Name = "FrmManUsuario"
        Me.Text = "FrmManUsuario"
        Me.GboxUsuario.ResumeLayout(False)
        Me.GboxUsuario.PerformLayout()
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TooMensaje As System.Windows.Forms.ToolTip
    Friend WithEvents TxtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents BtnRegistrar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GboxUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents TxtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents ErrDatos As System.Windows.Forms.ErrorProvider
End Class
