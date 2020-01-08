Imports System.Windows.Forms
Imports Entidad
Imports Interfaz
Imports AccesoDatos
Public Class LogDatos
    Implements IntDatos

    Dim logicadatos As New AccDatos()
    Public Function BuscarArticulo(ByVal Buscar As String) As System.Collections.Generic.List(Of Entidad.EntArticulos) Implements Interfaz.IntDatos.BuscarArticulo
        Return logicadatos.BuscarArticulo(Buscar)
    End Function

    Public Function BuscarCategoria(ByVal Buscar As String) As System.Collections.Generic.List(Of Entidad.EntCategoria) Implements Interfaz.IntDatos.BuscarCategoria
        Return logicadatos.BuscarCategoria(Buscar)
    End Function

    Public Function BuscarHistorial(ByVal Buscar As String) As System.Collections.Generic.List(Of Entidad.EntHistorial) Implements Interfaz.IntDatos.BuscarHistorial
        Return logicadatos.BuscarHistorial(Buscar)
    End Function

    Public Function BuscarMarca(ByVal Buscar As String) As System.Collections.Generic.List(Of Entidad.EntMarca) Implements Interfaz.IntDatos.BuscarMarca
        Return logicadatos.BuscarMarca(Buscar)
    End Function

    Public Function BuscarProveedores(ByVal Buscar As String) As System.Collections.Generic.List(Of Entidad.EntProveedores) Implements Interfaz.IntDatos.BuscarProveedores
        Return logicadatos.BuscarProveedores(Buscar)
    End Function

    Public Sub eliminar(ByVal opcion As String, ByVal codigo As Integer) Implements Interfaz.IntDatos.eliminar
        logicadatos.eliminar(opcion, codigo)
    End Sub

    Public Sub Foto(ByVal Imagen As System.Windows.Forms.PictureBox) Implements Interfaz.IntDatos.Foto
        logicadatos.Foto(Imagen)
    End Sub

    Public Sub ingresarArt(ByVal Articulo As Entidad.EntArticulos) Implements Interfaz.IntDatos.ingresarArt
        logicadatos.ingresarArt(Articulo)
    End Sub

    Public Sub ingresarCat(ByVal Categoria As Entidad.EntCategoria) Implements Interfaz.IntDatos.ingresarCat
        logicadatos.ingresarCat(Categoria)
    End Sub

    Public Sub ingresarHis(ByVal Historial As Entidad.EntHistorial) Implements Interfaz.IntDatos.ingresarHis
        logicadatos.ingresarHis(Historial)
    End Sub

    Public Sub ingresarMar(ByVal Marca As Entidad.EntMarca) Implements Interfaz.IntDatos.ingresarMar
        logicadatos.ingresarMar(Marca)
    End Sub

    Public Sub ingresarPro(ByVal Proveedor As Entidad.EntProveedores) Implements Interfaz.IntDatos.ingresarPro
        logicadatos.ingresarPro(Proveedor)
    End Sub

    Public Sub ingresarUsu(ByVal Usuario As Entidad.EntUsuario) Implements Interfaz.IntDatos.ingresarUsu
        logicadatos.ingresarUsu(Usuario)
    End Sub

    Public Function MaxCodigo(ByVal opcion As String) As String Implements Interfaz.IntDatos.MaxCodigo
        Return logicadatos.MaxCodigo(opcion)
    End Function

    Public Sub modificarArt(ByVal Articulo As Entidad.EntArticulos) Implements Interfaz.IntDatos.modificarArt
        logicadatos.modificarArt(Articulo)
    End Sub

    Public Sub modificarCat(ByVal Categoria As Entidad.EntCategoria) Implements Interfaz.IntDatos.modificarCat
        logicadatos.modificarCat(Categoria)
    End Sub

    Public Sub modificarMar(ByVal Marca As Entidad.EntMarca) Implements Interfaz.IntDatos.modificarMar
        logicadatos.modificarMar(Marca)
    End Sub

    Public Sub modificarPro(ByVal Proveedor As Entidad.EntProveedores) Implements Interfaz.IntDatos.modificarPro
        logicadatos.modificarPro(Proveedor)
    End Sub

    Public Sub modificarUsu(ByVal Usuario As Entidad.EntUsuario) Implements Interfaz.IntDatos.modificarUsu
        logicadatos.modificarUsu(Usuario)
    End Sub

    Public Function BuscarUsuario(ByVal Buscar As String) As System.Collections.Generic.List(Of Entidad.EntUsuario) Implements Interfaz.IntDatos.BuscarUsuario
        Return logicadatos.BuscarUsuario(Buscar)
    End Function
End Class
