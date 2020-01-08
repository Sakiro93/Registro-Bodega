Public Class EntCategoria
    Private catCodigo As Integer
    Private catDescripcion As String
    Private catFecReg As DateTime
    Private catFecMod As DateTime
    Private usuCodigo As Integer

    Sub New()
        Me.catCodigo = 0
        Me.catDescripcion = ""
        Me.catFecReg = Date.Now
        Me.catFecMod = Date.Now
        Me.usuCodigo = 0
    End Sub

    Sub New(ByVal catCodigo As Integer, ByVal catDescripcion As String, ByVal catFecReg As DateTime, ByVal catFecMod As DateTime, ByVal usuCodigo As Integer)
        Me.catCodigo = catCodigo
        Me.catDescripcion = catDescripcion
        Me.catFecReg = catFecReg
        Me.catFecMod = catFecMod
        Me.usuCodigo = usuCodigo
    End Sub

    Public Property CodigoCategoria() As Integer
        Get
            Return catCodigo
        End Get
        Set(ByVal value As Integer)
            catCodigo = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return catDescripcion
        End Get
        Set(ByVal value As String)
            catDescripcion = value
        End Set
    End Property

    Public Property FechaRegistro() As DateTime
        Get
            Return catFecReg
        End Get
        Set(ByVal value As DateTime)
            catFecReg = value
        End Set
    End Property
    Public Property FechaModificacion() As DateTime
        Get
            Return catFecMod
        End Get
        Set(ByVal value As DateTime)
            catFecMod = value
        End Set
    End Property

    Public Property CodigoUsuario() As Integer
        Get
            Return usuCodigo
        End Get
        Set(ByVal value As Integer)
            usuCodigo = value
        End Set
    End Property
End Class
