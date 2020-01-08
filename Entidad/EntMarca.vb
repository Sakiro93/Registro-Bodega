Public Class EntMarca
    Private marCodigo As Integer
    Private marDescripcion As String
    Private marFecReg As DateTime
    Private marFecMod As DateTime
    Private usuCodigo As Integer

    Sub New()
        Me.marCodigo = 0
        Me.marDescripcion = ""
        Me.marFecReg = Date.Now
        Me.marFecMod = Date.Now
        Me.usuCodigo = 0
    End Sub

    Sub New(ByVal marCodigo As Integer, ByVal marDescripcion As String, ByVal marFecReg As DateTime, ByVal marFecMod As DateTime, ByVal usuCodigo As Integer)
        Me.marCodigo = marCodigo
        Me.marDescripcion = marDescripcion
        Me.marFecReg = marFecReg
        Me.marFecMod = marFecMod
        Me.usuCodigo = usuCodigo
    End Sub

    Public Property CodigoMarca() As Integer
        Get
            Return marCodigo
        End Get
        Set(ByVal value As Integer)
            marCodigo = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return marDescripcion
        End Get
        Set(ByVal value As String)
            marDescripcion = value
        End Set
    End Property

    Public Property FechaRegistro() As DateTime
        Get
            Return marFecReg
        End Get
        Set(ByVal value As DateTime)
            marFecReg = value
        End Set
    End Property
    Public Property FechaModificacion() As DateTime
        Get
            Return marFecMod
        End Get
        Set(ByVal value As DateTime)
            marFecMod = value
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
