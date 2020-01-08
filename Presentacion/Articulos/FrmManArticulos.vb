Imports Entidad
Public Class FrmManArticulos
    Private fecha As Date = Date.Now
    Private fecMod As Date = Date.Now
    Dim catcod As Integer = 0
    Dim marcod As Integer = 0

    Private Sub FrmManArticulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
        limpiardatos()
        If IndiceGlobal <> 0 Then
            CargarDatos()
        Else
        End If
    End Sub
    Public Sub limpiardatos()
        LimpiarGroupbox(GrpDatos)
        TxtCodigo.Text = logicadatos.MaxCodigo("SIGART")
        For Each i In logicadatos.BuscarCategoria("")
            CboCategoria.Items.Add(i.Descripcion)
            catcod = i.CodigoCategoria
        Next
        For Each i In logicadatos.BuscarMarca("")
            CboMarca.Items.Add(i.Descripcion)
            marcod = i.CodigoMarca
        Next
        Op0.Checked = True
        ImgFoto.Image = ImgFoto.InitialImage
    End Sub


    Public Sub CargarDatos()
        For Each i In logicadatos.BuscarArticulo("")
            If (i.CodigoArticulo.Equals(IndiceGlobal)) Then
                ImgFoto.Image = i.Foto
                TxtCodigo.Text = i.CodigoArticulo
                TxtDescripcion.Text = i.Descripcion
                TxtDetalle.Text = i.Detalle
                TxtPrecio.Text = i.Precio
                TxtStock.Text = i.Stock
                If CboCategoria.Items.Count >= i.CodigoCategoria And logicadatos.BuscarCategoria("").Count > 0 Then
                    CboCategoria.SelectedIndex = i.CodigoCategoria - 1
                End If
                If CboMarca.Items.Count >= i.CodigoMarca And logicadatos.BuscarMarca("").Count > 0 Then
                    CboMarca.SelectedIndex = i.CodigoMarca - 1
                End If
                DTFecCad.Value = i.FechaCaducidad
                fecha = i.FechaRegistro
                ChkEstado.Checked = i.Estado
                If i.Iva Then
                    Op0.Checked = True
                Else
                    Op14.Checked = True
                End If
            End If
        Next
    End Sub
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        Dim iva As Integer
        If Op0.Checked = True Then
            iva = 0
        Else
            iva = 1
        End If
        If MessageBox.Show("Esta Seguro de Grabar el Articulo", "Sistema de Bodega", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If ValidaEntrada(ErrDatos, GrpDatos) Then
                Dim datos As New EntArticulos(Convert.ToInt32(TxtCodigo.Text), ImgFoto.Image, TxtDescripcion.Text, TxtDetalle.Text, catcod, marcod, TxtPrecio.Text, TxtStock.Text, iva, fecha, DTFecCad.Value, fecMod, ChkEstado.Checked, CodUsuario)
                If Grabar = "N" Then
                    logicadatos.ingresarArt(datos)
                    MessageBox.Show("Registro Grabado Correctamente")
                    limpiardatos()
            Else
                    logicadatos.modificarArt(datos)
                    Me.Close()
                MessageBox.Show("Registro Modificado Correctamente")
                End If
            Else
                MessageBox.Show("Error. Llene los Campos")
            End If
        Else
            MessageBox.Show("Operacion Cancelada")
        End If
    End Sub

    Private Sub BtnSubir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSubir.Click
        logicadatos.Foto(ImgFoto)
    End Sub
End Class