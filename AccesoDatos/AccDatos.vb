Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Data.SqlClient
Imports Interfaz
Imports Entidad
Imports System.Windows.Forms
Public Class AccDatos
    Implements IntDatos


    Public Sub Catgrabar(ByVal opc As String, ByVal Categoria As Entidad.EntCategoria)
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Pro_Categoria"
        With cmd.Parameters
            .Add("@Opcion", SqlDbType.VarChar).Value = opc
            .Add("@catCodigo", SqlDbType.Int).Value = Categoria.CodigoCategoria
            .Add("@catDescripcion", SqlDbType.VarChar).Value = Categoria.Descripcion
            .Add("@catFecReg", SqlDbType.DateTime).Value = Categoria.FechaRegistro
            .Add("@catFecMod", SqlDbType.DateTime).Value = Categoria.FechaModificacion
            .Add("@usuCodigo", SqlDbType.Int).Value = Categoria.CodigoUsuario
        End With
        sql.Ejecutar(cmd)
    End Sub

    Public Sub Margrabar(ByVal opc As String, ByVal Marca As Entidad.EntMarca)
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Pro_Marca"
        With cmd.Parameters
            .Add("@opcion", SqlDbType.VarChar).Value = opc
            .Add("@marCodigo", SqlDbType.Int).Value = Marca.CodigoMarca
            .Add("@marDescripcion", SqlDbType.VarChar).Value = Marca.Descripcion
            .Add("@marFecReg", SqlDbType.DateTime).Value = Marca.FechaRegistro
            .Add("@marFecMod", SqlDbType.DateTime).Value = Marca.FechaModificacion
            .Add("@usuCodigo", SqlDbType.Int).Value = Marca.CodigoUsuario
        End With
        sql.Ejecutar(cmd)
    End Sub

    Public Sub Prograbar(ByVal opc As String, ByVal Proveedor As Entidad.EntProveedores)
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Pro_Proveedores"
        With cmd.Parameters
            .Add("@opcion", SqlDbType.VarChar).Value = opc
            .Add("@proCodigo", SqlDbType.Int).Value = Proveedor.CodigoProveedor
            .Add("@proNombre", SqlDbType.VarChar).Value = Proveedor.Nombre
            .Add("@proCedula", SqlDbType.VarChar).Value = Proveedor.Cedula
            .Add("@proDireccion", SqlDbType.VarChar).Value = Proveedor.Direccion
            .Add("@proTelefono", SqlDbType.VarChar).Value = Proveedor.Telefono
            .Add("@proSexo", SqlDbType.Int).Value = Proveedor.Sexo
            .Add("@proFecReg", SqlDbType.DateTime).Value = Proveedor.FechaRegistro
            .Add("@proFecMod", SqlDbType.DateTime).Value = Proveedor.FechaModificacion
            .Add("@UsuCodigo", SqlDbType.Int).Value = Proveedor.CodigoUsuario
        End With
        sql.Ejecutar(cmd)
    End Sub
    Public Sub Usugrabar(ByVal opc As String, ByVal Usuario As Entidad.EntUsuario)
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Pro_Usuario"
        With cmd.Parameters
            .Add("@Opcion", SqlDbType.VarChar).Value = opc
            .Add("@usuCodigo", SqlDbType.Int).Value = Usuario.CodigoUsuario
            .Add("@usuLogin", SqlDbType.VarChar).Value = Usuario.Login
            .Add("@usuPassword", SqlDbType.VarChar).Value = Usuario.Password
            .Add("@usuNombre", SqlDbType.VarChar).Value = Usuario.Nombre
            .Add("@usuFecReg", SqlDbType.DateTime).Value = Usuario.FechaRegistro
            .Add("@usuFecMod", SqlDbType.DateTime).Value = Usuario.FechaModificacion
        End With
        sql.Ejecutar(cmd)
    End Sub

    Public Sub Artgrabar(ByVal opc As String, ByVal Articulo As Entidad.EntArticulos)
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Pro_Articulo"
        Dim im As System.IO.MemoryStream = New MemoryStream()
        Articulo.Foto.Save(im, ImageFormat.Jpeg)
        With cmd.Parameters
            .Add("@Opcion", SqlDbType.VarChar).Value = opc
            .Add("@artCodigo", SqlDbType.Int).Value = Articulo.CodigoArticulo
            .Add("@artFoto", SqlDbType.Image).Value = im.GetBuffer
            .Add("@artDescripcion", SqlDbType.VarChar).Value = Articulo.Descripcion
            .Add("@artDetalle", SqlDbType.VarChar).Value = Articulo.Detalle
            .Add("@catCodigo", SqlDbType.Int).Value = Articulo.CodigoCategoria
            .Add("@marCodigo", SqlDbType.Int).Value = Articulo.CodigoMarca
            .Add("@artPrecio", SqlDbType.Decimal).Value = Articulo.Precio
            .Add("@artStock", SqlDbType.Int).Value = Articulo.Stock
            .Add("@artIva", SqlDbType.Bit).Value = Articulo.Iva
            .Add("@artFecReg", SqlDbType.DateTime).Value = Articulo.FechaRegistro
            .Add("@artFecCad", SqlDbType.DateTime).Value = Articulo.FechaCaducidad
            .Add("@artFecMod", SqlDbType.DateTime).Value = Articulo.FechaModificacion
            .Add("@artEstado", SqlDbType.Bit).Value = Articulo.Estado
            .Add("@UsuCodigo", SqlDbType.Int).Value = Articulo.CodigoUsuario
        End With
        sql.Ejecutar(cmd)
    End Sub

    Public Sub Hisgrabar(ByVal opc As String, ByVal Historial As Entidad.EntHistorial)
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Pro_Historial"
        With cmd.Parameters
            .Add("@Opcion", SqlDbType.VarChar).Value = opc
            .Add("@hisCodigo", SqlDbType.Int).Value = Historial.CodigoHistorial
            .Add("@hisFoto", SqlDbType.Image).Value = Historial.Foto
            .Add("@hisDescripcion", SqlDbType.VarChar).Value = Historial.Descripcion
            .Add("@hisDetalle", SqlDbType.VarChar).Value = Historial.Detalle
            .Add("@catCodigo", SqlDbType.Int).Value = Historial.CodigoCategoria
            .Add("@marCodigo", SqlDbType.Int).Value = Historial.CodigoMarca
            .Add("@hisPrecio", SqlDbType.Decimal).Value = Historial.Precio
            .Add("@hisStock", SqlDbType.Int).Value = Historial.Stock
            .Add("@hisIva", SqlDbType.Bit).Value = Historial.Iva
            .Add("@hisFecReg", SqlDbType.DateTime).Value = Historial.FechaRegistro
            .Add("@hisFecCad", SqlDbType.DateTime).Value = Historial.FechaCaducidad
            .Add("@hisFecMod", SqlDbType.DateTime).Value = Historial.FechaModificacion
            .Add("@hisEstado", SqlDbType.Bit).Value = Historial.Estado
            .Add("@hisId", SqlDbType.Bit).Value = Historial.Id
            .Add("@UsuCodigo", SqlDbType.Int).Value = Historial.CodigoUsuario
        End With
        sql.Ejecutar(cmd)
    End Sub

    Public Function BuscarArticulo(ByVal Buscar As String) As System.Collections.Generic.List(Of Entidad.EntArticulos) Implements Interfaz.IntDatos.BuscarArticulo
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Pro_CargarTablas"
        With cmd.Parameters
            .Add("@Opcion", SqlDbType.VarChar).Value = "CNART"
            .Add("@descripcion", SqlDbType.VarChar).Value = Buscar
        End With
        Dim LstArticulos As New List(Of EntArticulos)
        Dim Articulos As EntArticulos
        Dim Tabla As New DataTable
        Tabla = sql.Consulta(cmd)
        Dim mstream As New MemoryStream()

        For fila = 0 To Tabla.Rows.Count - 1
            Dim imagen() As Byte = CType(Tabla.Rows(fila).Item(1), Byte())
            mstream = New MemoryStream(imagen)
            Articulos = New EntArticulos(Tabla.Rows(fila).Item(0), Image.FromStream(mstream), Tabla.Rows(fila).Item(2), Tabla.Rows(fila).Item(3), Tabla.Rows(fila).Item(4), Tabla.Rows(fila).Item(5), Tabla.Rows(fila).Item(6), Tabla.Rows(fila).Item(7), Tabla.Rows(fila).Item(8), Tabla.Rows(fila).Item(9), Tabla.Rows(fila).Item(10), Tabla.Rows(fila).Item(11), Tabla.Rows(fila).Item(12), Tabla.Rows(fila).Item(13))
            LstArticulos.Add(Articulos)
        Next
        Return LstArticulos
    End Function

    Public Function BuscarCategoria(ByVal Buscar As String) As System.Collections.Generic.List(Of Entidad.EntCategoria) Implements Interfaz.IntDatos.BuscarCategoria
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Pro_CargarTablas"
        With cmd.Parameters
            .Add("@Opcion", SqlDbType.VarChar).Value = "CNCAT"
            .Add("@descripcion", SqlDbType.VarChar).Value = Buscar
        End With
        Dim LstCategoria As New List(Of EntCategoria)
        Dim Categoria As EntCategoria
        Dim Tabla As New DataTable
        Tabla = sql.Consulta(cmd)
        For fila = 0 To Tabla.Rows.Count - 1
            Categoria = New EntCategoria(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1), Tabla.Rows(fila).Item(2), Tabla.Rows(fila).Item(3), Tabla.Rows(fila).Item(4))
            LstCategoria.Add(Categoria)
        Next
        Return LstCategoria
    End Function

    Public Function BuscarHistorial(ByVal Buscar As String) As System.Collections.Generic.List(Of Entidad.EntHistorial) Implements Interfaz.IntDatos.BuscarHistorial
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Pro_CargarTablas"
        With cmd.Parameters
            .Add("@Opcion", SqlDbType.VarChar).Value = "CNHIS"
            .Add("@descripcion", SqlDbType.VarChar).Value = Buscar
        End With
        Dim LstHistorial As New List(Of EntHistorial)
        Dim Historial As EntHistorial
        Dim Tabla As New DataTable
        Tabla = sql.Consulta(cmd)
        Dim mstream As New MemoryStream()

        For fila = 0 To Tabla.Rows.Count - 1
            Dim imagen() As Byte = CType(Tabla.Rows(fila).Item(1), Byte())
            mstream = New MemoryStream(imagen)
            Historial = New EntHistorial(Tabla.Rows(fila).Item(0), Image.FromStream(mstream), Tabla.Rows(fila).Item(2), Tabla.Rows(fila).Item(3), Tabla.Rows(fila).Item(4), Tabla.Rows(fila).Item(5), Tabla.Rows(fila).Item(6), Tabla.Rows(fila).Item(7), Tabla.Rows(fila).Item(8), Tabla.Rows(fila).Item(9), Tabla.Rows(fila).Item(10), Tabla.Rows(fila).Item(11), Tabla.Rows(fila).Item(12), Tabla.Rows(fila).Item(13), Tabla.Rows(fila).Item(14))
            LstHistorial.Add(Historial)
        Next
        Return LstHistorial
    End Function

    Public Function BuscarMarca(ByVal Buscar As String) As System.Collections.Generic.List(Of Entidad.EntMarca) Implements Interfaz.IntDatos.BuscarMarca
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Pro_CargarTablas"
        With cmd.Parameters
            .Add("@Opcion", SqlDbType.VarChar).Value = "CNMAR"
            .Add("@descripcion", SqlDbType.VarChar).Value = Buscar
        End With
        Dim LstMarca As New List(Of EntMarca)
        Dim Marca As EntMarca
        Dim Tabla As New DataTable
        Tabla = sql.Consulta(cmd)
        For fila = 0 To Tabla.Rows.Count - 1
            Marca = New EntMarca(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1), Tabla.Rows(fila).Item(2), Tabla.Rows(fila).Item(3), Tabla.Rows(fila).Item(4))
            LstMarca.Add(Marca)
        Next
        Return LstMarca
    End Function

    Public Function BuscarProveedores(ByVal Buscar As String) As System.Collections.Generic.List(Of Entidad.EntProveedores) Implements Interfaz.IntDatos.BuscarProveedores
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Pro_CargarTablas"
        With cmd.Parameters
            .Add("@Opcion", SqlDbType.VarChar).Value = "CNPRO"
            .Add("@descripcion", SqlDbType.VarChar).Value = Buscar
        End With
        Dim LstProveedor As New List(Of EntProveedores)
        Dim Proveedor As EntProveedores
        Dim Tabla As New DataTable
        Tabla = sql.Consulta(cmd)
        For fila = 0 To Tabla.Rows.Count - 1
            Proveedor = New EntProveedores(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1), Tabla.Rows(fila).Item(2), Tabla.Rows(fila).Item(3), Tabla.Rows(fila).Item(4), Tabla.Rows(fila).Item(5), Tabla.Rows(fila).Item(6), Tabla.Rows(fila).Item(7), Tabla.Rows(fila).Item(8))
            LstProveedor.Add(Proveedor)
        Next
        Return LstProveedor
    End Function

    Public Sub eliminar(ByVal opcion As String, ByVal codigo As Integer) Implements Interfaz.IntDatos.eliminar
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Pro_ProcesosCortos"
        With cmd.Parameters
            .Add("@opcion", SqlDbType.VarChar).Value = opcion
            .Add("@Codigo", SqlDbType.Int).Value = codigo
        End With
        sql.Ejecutar(cmd)
    End Sub

    Public Sub Foto(ByVal Imagen As System.Windows.Forms.PictureBox) Implements Interfaz.IntDatos.Foto
        Try
            Dim fotos As OpenFileDialog
            fotos = New OpenFileDialog() 'abre una ventana de busqueda
            fotos.DefaultExt = "*.jpg" 'defino la extension que quiero buscar
            fotos.Multiselect = False ' solo puedo seleccionar uno
            fotos.Filter = "Tipo (*.jpg,*.gif,*.bmp)|*.jpg;*.gif;*.bmp" 'filtrar los tipos de archivos
            fotos.Title = "Seleccione una imagen " 'titulo de la ventana
            If fotos.ShowDialog = Windows.Forms.DialogResult.OK Then 'ventana dialogo si quiero o no mandar la foto al pictureBox
                Imagen.Image = Nothing 'Vacio el pictureBox
                Imagen.Image = New Bitmap(fotos.FileName) 'agrego la foto seleccionada
            End If
        Catch ex As Exception
            MessageBox.Show("Error en ----> " + ex.Message)
        End Try
    End Sub

    Public Sub ingresarArt(ByVal Articulo As Entidad.EntArticulos) Implements Interfaz.IntDatos.ingresarArt
        Artgrabar("INS", Articulo)
    End Sub

    Public Sub ingresarCat(ByVal Categoria As Entidad.EntCategoria) Implements Interfaz.IntDatos.ingresarCat
        Catgrabar("INS", Categoria)
    End Sub

    Public Sub ingresarHis(ByVal Historial As Entidad.EntHistorial) Implements Interfaz.IntDatos.ingresarHis
        Hisgrabar("INS", Historial)
    End Sub

    Public Sub ingresarMar(ByVal Marca As Entidad.EntMarca) Implements Interfaz.IntDatos.ingresarMar
        Margrabar("INS", Marca)
    End Sub

    Public Sub ingresarPro(ByVal Proveedor As Entidad.EntProveedores) Implements Interfaz.IntDatos.ingresarPro
        Prograbar("INS", Proveedor)
    End Sub

    Public Sub ingresarUsu(ByVal Usuario As Entidad.EntUsuario) Implements Interfaz.IntDatos.ingresarUsu
        Usugrabar("INS", Usuario)
    End Sub

    Public Function MaxCodigo(ByVal opcion As String) As String Implements Interfaz.IntDatos.MaxCodigo
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Pro_ProcesosCortos"
        With cmd.Parameters
            .Add("@Opcion", SqlDbType.VarChar).Value = opcion
            .Add("@Codigo", SqlDbType.Int).Value = 0
        End With
        Return sql.MaximoCodigo(cmd)
    End Function

    Public Sub modificarArt(ByVal Articulo As Entidad.EntArticulos) Implements Interfaz.IntDatos.modificarArt
        Artgrabar("MOD", Articulo)
    End Sub

    Public Sub modificarCat(ByVal Categoria As Entidad.EntCategoria) Implements Interfaz.IntDatos.modificarCat
        Catgrabar("MOD", Categoria)
    End Sub

    Public Sub modificarMar(ByVal Marca As Entidad.EntMarca) Implements Interfaz.IntDatos.modificarMar
        Margrabar("MOD", Marca)
    End Sub

    Public Sub modificarPro(ByVal Proveedor As Entidad.EntProveedores) Implements Interfaz.IntDatos.modificarPro
        Prograbar("MOD", Proveedor)
    End Sub

    Public Sub modificarUsu(ByVal Usuario As Entidad.EntUsuario) Implements Interfaz.IntDatos.modificarUsu
        Usugrabar("MOD", Usuario)
    End Sub

    Public Function BuscarUsuario(ByVal Buscar As String) As System.Collections.Generic.List(Of Entidad.EntUsuario) Implements Interfaz.IntDatos.BuscarUsuario
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Pro_CargarTablas"
        With cmd.Parameters
            .Add("@Opcion", SqlDbType.VarChar).Value = "CNUSU"
            .Add("@descripcion", SqlDbType.VarChar).Value = Buscar
        End With
        Dim LstUsuario As New List(Of EntUsuario)
        Dim Usuario As EntUsuario
        Dim Tabla As New DataTable
        Tabla = sql.Consulta(cmd)
        For fila = 0 To Tabla.Rows.Count - 1
            Usuario = New EntUsuario(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1), Tabla.Rows(fila).Item(2), Tabla.Rows(fila).Item(3), Tabla.Rows(fila).Item(4), Tabla.Rows(fila).Item(5))
            LstUsuario.Add(Usuario)
        Next
        Return LstUsuario
    End Function
End Class
