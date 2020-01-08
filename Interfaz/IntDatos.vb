Imports Entidad
Imports System.Windows.Forms
Public Interface IntDatos
    Sub ingresarArt(ByVal Articulo As EntArticulos)
    Sub modificarArt(ByVal Articulo As EntArticulos)
    Sub ingresarCat(ByVal Categoria As EntCategoria)
    Sub modificarCat(ByVal Categoria As EntCategoria)
    Sub ingresarMar(ByVal Marca As EntMarca)
    Sub modificarMar(ByVal Marca As EntMarca)
    Sub ingresarPro(ByVal Proveedor As EntProveedores)
    Sub modificarPro(ByVal Proveedor As EntProveedores)
    Sub ingresarHis(ByVal Historial As EntHistorial)
    Sub ingresarUsu(ByVal Usuario As EntUsuario)
    Sub modificarUsu(ByVal Usuario As EntUsuario)
    Function BuscarUsuario(ByVal Buscar As String) As List(Of EntUsuario)
    Function BuscarCategoria(ByVal Buscar As String) As List(Of EntCategoria)
    Function BuscarMarca(ByVal Buscar As String) As List(Of EntMarca)
    Function BuscarProveedores(ByVal Buscar As String) As List(Of EntProveedores)
    Function BuscarArticulo(ByVal Buscar As String) As List(Of EntArticulos)
    Function BuscarHistorial(ByVal Buscar As String) As List(Of EntHistorial)
    Sub eliminar(ByVal opcion As String, ByVal codigo As Integer)
    Function MaxCodigo(ByVal opcion As String) As String
    Sub Foto(ByVal Imagen As PictureBox)
End Interface
