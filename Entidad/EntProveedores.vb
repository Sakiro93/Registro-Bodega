Public Class EntProveedores
    Private proCodigo As Integer
    Private proNombre As String
    Private proCedula As String
    Private proDireccion As String
    Private proTelefono As String
    Private proSexo As Integer
    Private proFecReg As DateTime
    Private proFecMod As DateTime
    Private usuCodigo As Integer

    Sub New()
        Me.proCodigo = 0
        Me.proNombre = ""
        Me.proCedula = ""
        Me.proDireccion = ""
        Me.proTelefono = ""
        Me.proSexo = 0
        Me.proFecReg = Date.Now
        Me.proFecMod = Date.Now
        Me.usuCodigo = 0
    End Sub

    Sub New(ByVal proCodigo As Integer, ByVal proNombre As String, ByVal proCedula As String, ByVal proDireccion As String, ByVal proTelefono As String, ByVal proSexo As Integer, ByVal proFecReg As DateTime, ByVal proFecMod As DateTime, ByVal usuCodigo As Integer)
        Me.proCodigo = proCodigo
        Me.proNombre = proNombre
        Me.proCedula = proCedula
        Me.proDireccion = proDireccion
        Me.proTelefono = proTelefono
        Me.proSexo = proSexo
        Me.proFecReg = proFecReg
        Me.proFecMod = proFecMod
        Me.usuCodigo = usuCodigo
    End Sub

    Public Property CodigoProveedor() As Integer
        Get
            Return proCodigo
        End Get
        Set(ByVal value As Integer)
            proCodigo = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return proNombre
        End Get
        Set(ByVal value As String)
            proNombre = value
        End Set
    End Property

    Public Property Cedula() As String
        Get
            Return proCedula
        End Get
        Set(ByVal value As String)
            proCedula = value
        End Set
    End Property

    Public Property Direccion() As String
        Get
            Return proDireccion
        End Get
        Set(ByVal value As String)
            proDireccion = value
        End Set
    End Property

    Public Property Telefono() As String
        Get
            Return proTelefono
        End Get
        Set(ByVal value As String)
            proTelefono = value
        End Set
    End Property

    Public Property Sexo() As Integer
        Get
            Return proSexo
        End Get
        Set(ByVal value As Integer)
            proSexo = value
        End Set
    End Property

    Public Property FechaRegistro() As DateTime
        Get
            Return proFecReg
        End Get
        Set(ByVal value As DateTime)
            proFecReg = value
        End Set
    End Property

    Public Property FechaModificacion() As DateTime
        Get
            Return proFecMod
        End Get
        Set(ByVal value As DateTime)
            proFecMod = value
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
