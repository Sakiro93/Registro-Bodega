<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManProveedor
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GboxProveedor = New System.Windows.Forms.GroupBox()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rdFemenino = New System.Windows.Forms.RadioButton()
        Me.rdMasculino = New System.Windows.Forms.RadioButton()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.ErrDatos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.TooMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.GboxProveedor.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label8.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(181, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(440, 31)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "REGISTRO DE PROVEEDORES"
        '
        'GboxProveedor
        '
        Me.GboxProveedor.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GboxProveedor.Controls.Add(Me.TxtCedula)
        Me.GboxProveedor.Controls.Add(Me.Panel3)
        Me.GboxProveedor.Controls.Add(Me.TxtDireccion)
        Me.GboxProveedor.Controls.Add(Me.Label7)
        Me.GboxProveedor.Controls.Add(Me.Label5)
        Me.GboxProveedor.Controls.Add(Me.Label4)
        Me.GboxProveedor.Controls.Add(Me.TxtTelefono)
        Me.GboxProveedor.Controls.Add(Me.TxtNombre)
        Me.GboxProveedor.Controls.Add(Me.Label3)
        Me.GboxProveedor.Controls.Add(Me.Label2)
        Me.GboxProveedor.Controls.Add(Me.Label1)
        Me.GboxProveedor.Controls.Add(Me.TxtCodigo)
        Me.GboxProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GboxProveedor.Location = New System.Drawing.Point(11, 60)
        Me.GboxProveedor.Name = "GboxProveedor"
        Me.GboxProveedor.Size = New System.Drawing.Size(784, 226)
        Me.GboxProveedor.TabIndex = 82
        Me.GboxProveedor.TabStop = False
        '
        'TxtCedula
        '
        Me.TxtCedula.Location = New System.Drawing.Point(114, 139)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(170, 20)
        Me.TxtCedula.TabIndex = 90
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.PowderBlue
        Me.Panel3.Controls.Add(Me.rdFemenino)
        Me.Panel3.Controls.Add(Me.rdMasculino)
        Me.Panel3.Location = New System.Drawing.Point(556, 126)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(105, 46)
        Me.Panel3.TabIndex = 89
        '
        'rdFemenino
        '
        Me.rdFemenino.AutoSize = True
        Me.rdFemenino.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rdFemenino.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdFemenino.Location = New System.Drawing.Point(-1, 25)
        Me.rdFemenino.Name = "rdFemenino"
        Me.rdFemenino.Size = New System.Drawing.Size(107, 23)
        Me.rdFemenino.TabIndex = 1
        Me.rdFemenino.Text = "Femenino"
        Me.rdFemenino.UseVisualStyleBackColor = False
        '
        'rdMasculino
        '
        Me.rdMasculino.AutoSize = True
        Me.rdMasculino.BackColor = System.Drawing.SystemColors.Highlight
        Me.rdMasculino.Checked = True
        Me.rdMasculino.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdMasculino.Location = New System.Drawing.Point(-1, 1)
        Me.rdMasculino.Name = "rdMasculino"
        Me.rdMasculino.Size = New System.Drawing.Size(110, 23)
        Me.rdMasculino.TabIndex = 0
        Me.rdMasculino.TabStop = True
        Me.rdMasculino.Text = "Masculino"
        Me.rdMasculino.UseVisualStyleBackColor = False
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(555, 32)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(170, 20)
        Me.TxtDireccion.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(405, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "DIRECCION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(407, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "SEXO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(405, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "TELEFONO"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(555, 83)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(170, 20)
        Me.TxtTelefono.TabIndex = 5
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(114, 86)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(170, 20)
        Me.TxtNombre.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CEDULA"
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
        Me.TxtCodigo.Size = New System.Drawing.Size(108, 20)
        Me.TxtCodigo.TabIndex = 1
        '
        'ErrDatos
        '
        Me.ErrDatos.ContainerControl = Me
        '
        'BtnGrabar
        '
        Me.BtnGrabar.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnGrabar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.BtnGrabar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnGrabar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrabar.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGrabar.ForeColor = System.Drawing.Color.White
        Me.BtnGrabar.Location = New System.Drawing.Point(150, 306)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(106, 38)
        Me.BtnGrabar.TabIndex = 84
        Me.BtnGrabar.Text = "Grabar"
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
        Me.BtnSalir.Location = New System.Drawing.Point(531, 306)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(106, 38)
        Me.BtnSalir.TabIndex = 85
        Me.BtnSalir.Text = "SALIR"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'FrmManProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(809, 356)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GboxProveedor)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Name = "FrmManProveedor"
        Me.Text = "FrmManProveedor"
        Me.GboxProveedor.ResumeLayout(False)
        Me.GboxProveedor.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GboxProveedor As System.Windows.Forms.GroupBox
    Friend WithEvents TxtCedula As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rdFemenino As System.Windows.Forms.RadioButton
    Friend WithEvents rdMasculino As System.Windows.Forms.RadioButton
    Friend WithEvents TxtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents ErrDatos As System.Windows.Forms.ErrorProvider
    Friend WithEvents BtnGrabar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents TooMensaje As System.Windows.Forms.ToolTip
End Class
