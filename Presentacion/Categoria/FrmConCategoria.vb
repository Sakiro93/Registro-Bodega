Imports Entidad
Public Class FrmConCategoria
    Public Sub cargar(ByVal Buscar As String)
        Dg.Rows.Clear()
        For Each cat In logicadatos.BuscarCategoria(Buscar)
            Dg.Rows.Add(cat.CodigoCategoria, cat.Descripcion, cat.FechaRegistro)
        Next
    End Sub
    Private Sub FrmConCategoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
        txtBuscar.Clear()
        cargar("")
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        FrmInicio.Show()
        Me.Close()
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Grabar = "N"
        FrmManCategoria.ShowDialog()
        cargar("")
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        cargar(txtBuscar.Text)
    End Sub

    Private Sub Dg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dg.Click
        If Dg.Rows.Count > 0 Then
            Dim ind As Integer = Dg.CurrentRow.Index
            Dim cad As String = Dg.Rows(ind).Cells(1).Value.ToString
            Dim codbuscar As String = Dg.Rows(ind).Cells(0).Value.ToString
            If Dg.CurrentCell.ColumnIndex = 3 Then
                IndiceGlobal = codbuscar
                Grabar = "M"
                FrmManCategoria.ShowDialog()
                cargar("")
                txtBuscar.Clear()
            Else
                If Dg.CurrentCell.ColumnIndex = 4 Then
                    If MessageBox.Show("Esta Seguro De Eliminar la Categoria" + Chr(13) + Chr(13) + cad, "Sistema de Bodega", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                        logicadatos.eliminar("ELICAT", codbuscar)
                        txtBuscar.Clear()
                        MessageBox.Show("Registro Eliminado Correctamente")
                        cargar("")
                    Else
                        MessageBox.Show("Operacion Cancelada")
                        cargar("")
                    End If
                End If
            End If
        End If
    End Sub
End Class