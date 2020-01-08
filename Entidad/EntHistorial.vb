Imports System.Drawing

Public Class EntHistorial
    Private hisCodigo As Integer
    Private hisFoto As Image
    Private hisDescripcion As String
    Private hisDetalle As String
    Private catCodigo As Integer
    Private marCodigo As Integer
    Private hisPrecio As Double
    Private hisStock As Integer
    Private hisIva As Double
    Private hisFecReg As DateTime
    Private hisFecCad As DateTime
    Private hisFecMod As DateTime
    Private hisEstado As Integer
    Private hisId As Integer
    Private usuCodigo As Integer

    Sub New()
        Me.hisCodigo = 0
        Me.hisFoto = Nothing
        Me.hisDescripcion = ""
        Me.hisDetalle = ""
        Me.catCodigo = 0
        Me.marCodigo = 0
        Me.hisPrecio = 0
        Me.hisStock = 0
        Me.hisIva = 0
        Me.hisFecReg = Date.Now
        Me.hisFecCad = Date.Now
        Me.hisFecMod = Date.Now
        Me.hisEstado = 0
        Me.hisId = 0
        Me.usuCodigo = 0
    End Sub

    Sub New(ByVal hisCodigo As Integer, ByVal hisFoto As Image, ByVal hisDescripcion As String, ByVal hisDetalle As String, ByVal catCodigo As Integer, ByVal marCodigo As Integer, ByVal hisPrecio As Double, ByVal hisStock As Double, ByVal hisIva As Double, ByVal hisFecReg As DateTime, ByVal hisFecCad As DateTime, ByVal hisFecMod As DateTime, ByVal hisEstado As Integer, ByVal hisId As Integer, ByVal usuCodigo As Integer)
        Me.hisCodigo = hisCodigo
        Me.hisFoto = hisFoto
        Me.hisDescripcion = hisDescripcion
        Me.hisDetalle = hisDetalle
        Me.catCodigo = catCodigo
        Me.marCodigo = marCodigo
        Me.hisPrecio = hisPrecio
        Me.hisStock = hisStock
        Me.hisIva = hisIva
        Me.hisFecReg = hisFecReg
        Me.hisFecCad = hisFecCad
        Me.hisFecMod = hisFecMod
        Me.hisEstado = hisEstado
        Me.hisId = hisId
        Me.usuCodigo = usuCodigo
    End Sub

    Public Property CodigoHistorial() As Integer
        Get
            Return hisCodigo
        End Get
        Set(ByVal value As Integer)
            hisCodigo = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return hisDescripcion
        End Get
        Set(ByVal value As String)
            hisDescripcion = value
        End Set
    End Property

    Public Property Detalle() As String
        Get
            Return hisDetalle
        End Get
        Set(ByVal value As String)
            hisDetalle = value
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
            Return hisPrecio
        End Get
        Set(ByVal value As Double)
            hisPrecio = value
        End Set
    End Property

    Public Property Stock() As Integer
        Get
            Return hisStock
        End Get
        Set(ByVal value As Integer)
            hisStock = value
        End Set
    End Property

    Public Property Iva() As Double
        Get
            Return hisIva
        End Get
        Set(ByVal value As Double)
            hisIva = value
        End Set
    End Property

    Public Property FechaRegistro() As DateTime
        Get
            Return hisFecReg
        End Get
        Set(ByVal value As DateTime)
            hisFecReg = value
        End Set
    End Property
    Public Property FechaCaducidad() As DateTime
        Get
            Return hisFecCad
        End Get
        Set(ByVal value As DateTime)
            hisFecCad = value
        End Set
    End Property

    Public Property FechaModificacion() As DateTime
        Get
            Return hisFecMod
        End Get
        Set(ByVal value As DateTime)
            hisFecMod = value
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
            Return hisFoto
        End Get
        Set(ByVal value As Image)
            hisFoto = value
        End Set
    End Property

    Public Property Id() As Integer
        Get
            Return hisId
        End Get
        Set(ByVal value As Integer)
            hisId = value
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
            Return hisEstado
        End Get
        Set(ByVal value As Integer)
            hisEstado = value
        End Set
    End Property
End Class
