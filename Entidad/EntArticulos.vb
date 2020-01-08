Imports System.Drawing

Public Class EntArticulos
    Private artCodigo As Integer
    Private artFoto As Image
    Private artDescripcion As String
    Private artDetalle As String
    Private catCodigo As Integer
    Private marCodigo As Integer
    Private artPrecio As Double
    Private artStock As Integer
    Private artIva As Integer
    Private artFecReg As DateTime
    Private artFecCad As DateTime
    Private artFecMod As DateTime
    Private artEstado As Integer
    Private usuCodigo As Integer

    Sub New()
        Me.artCodigo = 0
        Me.artFoto = Nothing
        Me.artDescripcion = ""
        Me.artDetalle = ""
        Me.catCodigo = 0
        Me.marCodigo = 0
        Me.artPrecio = 0
        Me.artStock = 0
        Me.artIva = 0
        Me.artFecReg = Date.Now
        Me.artFecCad = Date.Now
        Me.artFecMod = Date.Now
        Me.artEstado = 0
        Me.usuCodigo = 0
    End Sub

    Sub New(ByVal artCodigo As Integer, ByVal artFoto As Image, ByVal artDescripcion As String, ByVal artDetalle As String, ByVal catCodigo As Integer, ByVal marCodigo As Integer, ByVal artPrecio As Double, ByVal artStock As Double, ByVal artIva As Integer, ByVal artFecReg As DateTime, ByVal artFecCad As DateTime, ByVal artFecMod As DateTime, ByVal artEstado As Integer, ByVal usuCodigo As Integer)
        Me.artCodigo = artCodigo
        Me.artFoto = artFoto
        Me.artDescripcion = artDescripcion
        Me.artDetalle = artDetalle
        Me.catCodigo = catCodigo
        Me.marCodigo = marCodigo
        Me.artPrecio = artPrecio
        Me.artStock = artStock
        Me.artIva = artIva
        Me.artFecReg = artFecReg
        Me.artFecCad = artFecCad
        Me.artFecMod = artFecMod
        Me.artEstado = artEstado
        Me.usuCodigo = usuCodigo
    End Sub

    Public Property CodigoArticulo() As Integer
        Get
            Return artCodigo
        End Get
        Set(ByVal value As Integer)
            artCodigo = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return artDescripcion
        End Get
        Set(ByVal value As String)
            artDescripcion = value
        End Set
    End Property

    Public Property Detalle() As String
        Get
            Return artDetalle
        End Get
        Set(ByVal value As String)
            artDetalle = value
        End Set
    End Property

    Public Property CodigoCategoria() As Integer
        Get
            Return catCodigo
        End Get
        Set(ByVal value As Integer)
            catCodigo = value
        End Set
    End Property

    Public Property Precio() As Double
        Get
            Return artPrecio
        End Get
        Set(ByVal value As Double)
            artPrecio = value
        End Set
    End Property

    Public Property Stock() As Integer
        Get
            Return artStock
        End Get
        Set(ByVal value As Integer)
            artStock = value
        End Set
    End Property

    Public Property Iva() As Integer
        Get
            Return artIva
        End Get
        Set(ByVal value As Integer)
            artIva = value
        End Set
    End Property

    Public Property FechaRegistro() As DateTime
        Get
            Return artFecReg
        End Get
        Set(ByVal value As DateTime)
            artFecReg = value
        End Set
    End Property
    Public Property FechaCaducidad() As DateTime
        Get
            Return artFecCad
        End Get
        Set(ByVal value As DateTime)
            artFecCad = value
        End Set
    End Property

    Public Property FechaModificacion() As DateTime
        Get
            Return artFecMod
        End Get
        Set(ByVal value As DateTime)
            artFecMod = value
        End Set
    End Property

    Public Property CodigoMarca() As Integer
        Get
            Return marCodigo
        End Get
        Set(ByVal value As Integer)
            marCodigo = value
        End Set
    End Property

    Public Property Foto() As Image
        Get
            Return artFoto
        End Get
        Set(ByVal value As Image)
            artFoto = value
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

    Public Property Estado() As Integer
        Get
            Return artEstado
        End Get
        Set(ByVal value As Integer)
            artEstado = value
        End Set
    End Property
End Class
