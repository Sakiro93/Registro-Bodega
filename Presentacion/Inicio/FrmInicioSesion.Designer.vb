<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInicioSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInicioSesion))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ErrDatos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GBoxInicio = New System.Windows.Forms.GroupBox()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TooMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBoxInicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(25, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 21)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "CONTRASEÑA"
        '
        'ErrDatos
        '
        Me.ErrDatos.ContainerControl = Me
        '
        'GBoxInicio
        '
        Me.GBoxInicio.Controls.Add(Me.TxtContraseña)
        Me.GBoxInicio.Controls.Add(Me.TxtUsuario)
        Me.GBoxInicio.Controls.Add(Me.Label3)
        Me.GBoxInicio.Controls.Add(Me.Label2)
        Me.GBoxInicio.Location = New System.Drawing.Point(26, 72)
        Me.GBoxInicio.Name = "GBoxInicio"
        Me.GBoxInicio.Size = New System.Drawing.Size(443, 144)
        Me.GBoxInicio.TabIndex = 90
        Me.GBoxInicio.TabStop = False
        Me.GBoxInicio.Text = "Ingresar"
        '
        'TxtContraseña
        '
        Me.TxtContraseña.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TxtContraseña.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContraseña.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TxtContraseña.Location = New System.Drawing.Point(219, 94)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtContraseña.Size = New System.Drawing.Size(198, 25)
        Me.TxtContraseña.TabIndex = 75
        '
        'TxtUsuario
        '
        Me.TxtUsuario.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.TxtUsuario.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TxtUsuario.Location = New System.Drawing.Point(219, 26)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(198, 26)
        Me.TxtUsuario.TabIndex = 74
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(25, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 21)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "USUARIO"
        '
        'Label7
        '
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(363, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 60)
        Me.Label7.TabIndex = 89
        '
        'Label6
        '
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(204, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 60)
        Me.Label6.TabIndex = 88
        '
        'Label5
        '
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 60)
        Me.Label5.TabIndex = 87
        '
        'Label4
        '
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(40, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 60)
        Me.Label4.TabIndex = 86
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Firebrick
        Me.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Location = New System.Drawing.Point(363, 282)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(106, 38)
        Me.BtnCancelar.TabIndex = 85
        Me.BtnCancelar.Text = "CANCELAR"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnIngresar
        '
        Me.BtnIngresar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.BtnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIngresar.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresar.ForeColor = System.Drawing.Color.White
        Me.BtnIngresar.Location = New System.Drawing.Point(40, 282)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(106, 38)
        Me.BtnIngresar.TabIndex = 84
        Me.BtnIngresar.Text = "INGRESAR"
        Me.BtnIngresar.UseVisualStyleBackColor = False
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.BackColor = System.Drawing.Color.Teal
        Me.BtnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.BtnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.BtnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrar.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.ForeColor = System.Drawing.Color.White
        Me.BtnRegistrar.Location = New System.Drawing.Point(204, 282)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(106, 38)
        Me.BtnRegistrar.TabIndex = 83
        Me.BtnRegistrar.Text = "REGISTRARSE"
        Me.BtnRegistrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(124, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 31)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "INICIO DE SESION"
        '
        'FrmInicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(503, 357)
        Me.Controls.Add(Me.GBoxInicio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnIngresar)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmInicioSesion"
        Me.Text = "FrmInicioSesion"
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBoxInicio.ResumeLayout(False)
        Me.GBoxInicio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ErrDatos As System.Windows.Forms.ErrorProvider
    Friend WithEvents GBoxInicio As System.Windows.Forms.GroupBox
    Friend WithEvents TxtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents TxtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnIngresar As System.Windows.Forms.Button
    Friend WithEvents BtnRegistrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TooMensaje As System.Windows.Forms.ToolTip
End Class
