Imports Entidad
Public Class FrmConArticulos
    Public Sub cargar(ByVal Buscar As String)
        Dg.Rows.Clear()
        Dim iva As String = ""
        Dim categoria As String = ""
        Dim marca As String = ""
        For Each ar In logicadatos.BuscarArticulo(Buscar)
            If ar.Iva = 0 Then
                iva = "0%"
            Else
                iva = "14%"
            End If
            For Each i In logicadatos.BuscarCategoria("")
                If ar.CodigoCategoria.Equals(i.CodigoCategoria) Then
                    categoria = i.Descripcion
                End If
            Next
            For Each i In logicadatos.BuscarMarca("")
                If ar.CodigoMarca.Equals(i.CodigoMarca) Then
                    marca = i.Descripcion
                End If
            Next
            Dg.Rows.Add(ar.CodigoArticulo, ar.Foto, ar.Descripcion, ar.Detalle, categoria, marca, ar.Precio, ar.Stock, iva, ar.FechaRegistro, ar.FechaCaducidad, ar.FechaModificacion, ar.Estado, CodUsuario)
        Next
    End Sub
    Private Sub FrmConArticulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
        cargar("")
        CboCategoria.Items.Clear()
        CboCategoria.Items.Add("Mostrar Todo")
        For Each i In logicadatos.BuscarCategoria("")
            CboCategoria.Items.Add(i.Descripcion)
        Next
        CboCategoria.SelectedIndex = 0
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        FrmInicio.Show()
        Me.Close()
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Grabar = "N"
        IndiceGlobal = 0
        FrmManArticulos.ShowDialog()
        cargar("")
    End Sub

    Private Sub Dg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dg.Click
        If Dg.Rows.Count > 0 Then
            Dim ind As Integer = Dg.CurrentRow.Index
            Dim cad As String = Dg.Rows(ind).Cells(2).Value.ToString
            Dim codbuscar As String = Dg.Rows(ind).Cells(0).Value.ToString
            If Dg.CurrentCell.ColumnIndex = 13 Then
                IndiceGlobal = codbuscar
                Grabar = "M"
                FrmManArticulos.ShowDialog()
                TxtBuscar.Clear()
                cargar("")
            Else
                If Dg.CurrentCell.ColumnIndex = 14 Then
                    If MessageBox.Show("Esta Seguro De Devolver El Articulo" + Chr(13) + Chr(13) + cad, "Sistema de Bodega", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                        Dim datos As EntHistorial
                        For Each ar In logicadatos.BuscarArticulo("")
                            If ar.CodigoArticulo.Equals(codbuscar) Then
                                datos = New EntHistorial(ar.CodigoArticulo, ar.Foto, ar.Descripcion, ar.Detalle, ar.CodigoCategoria, ar.CodigoMarca, ar.Precio, ar.Stock, ar.Iva, ar.FechaRegistro, ar.FechaCaducidad, ar.FechaModificacion, ar.Estado, 3, ar.CodigoUsuario)
                                logicadatos.ingresarHis(datos)
                            End If
                        Next
                        logicadatos.eliminar("ELIART", codbuscar)
                        TxtBuscar.Clear()
                        MessageBox.Show("Registro Devuelto Correctamente")
                        cargar("")
                    Else
                        MessageBox.Show("Operacion Cancelada")
                        cargar("")
                    End If
                End If
            End If
        End If    
    End Sub


    Private Sub TxtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscar.TextChanged

    End Sub
End Class