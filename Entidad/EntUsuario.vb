Public Class EntUsuario
    Private usuCodigo As Integer
    Private usuLogin As String
    Private usuPassword As String
    Private usuNombre As String
    Private usuFecReg As DateTime
    Private usuFecMod As DateTime

    Sub New()
        Me.usuCodigo = 0
        Me.usuLogin = ""
        Me.usuPassword = ""
        Me.usuNombre = ""
        Me.usuFecReg = Date.Now
        Me.usuFecMod = Date.Now
    End Sub

    Sub New(ByVal usuCodigo As Integer, ByVal usuLogin As String, ByVal usuPassword As String, ByVal usuNombre As String, ByVal usuFecReg As DateTime, ByVal usuFecMod As DateTime)
        Me.usuCodigo = usuCodigo
        Me.usuLogin = usuLogin
        Me.usuPassword = usuPassword
        Me.usuNombre = usuNombre
        Me.usuFecReg = usuFecReg
        Me.usuFecMod = usuFecMod
    End Sub

    Public Property CodigoUsuario() As Integer
        Get
            Return usuCodigo
        End Get
        Set(ByVal value As Integer)
            usuCodigo = value
        End Set
    End Property

    Public Property Login() As String
        Get
            Return usuLogin
        End Get
        Set(ByVal value As String)
            usuLogin = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return usuPassword
        End Get
        Set(ByVal value As String)
            usuPassword = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return usuNombre
        End Get
        Set(ByVal value As String)
            usuNombre = value
        End Set
    End Property

    Public Property FechaRegistro() As DateTime
        Get
            Return usuFecReg
        End Get
        Set(ByVal value As DateTime)
            usuFecReg = value
        End Set
    End Property

    Public Property FechaModificacion() As DateTime
        Get
            Return usuFecMod
        End Get
        Set(ByVal value As DateTime)
            usuFecMod = value
        End Set
    End Property
End Class
