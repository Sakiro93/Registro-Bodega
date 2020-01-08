Imports Entidad
Public Class FrmConProveedor
    Public Sub cargar(ByVal Buscar As String)
        Dg.Rows.Clear()
        Dim sexo As String = ""
        For Each pro In logicadatos.BuscarProveedores(Buscar)
            If pro.Sexo = 0 Then
                sexo = "Masculino"
            Else
                sexo = "Femenino"
            End If
            Dg.Rows.Add(pro.CodigoProveedor, pro.Nombre, pro.Cedula, pro.Direccion, pro.Telefono, sexo, pro.FechaRegistro)
        Next
    End Sub
    Private Sub FrmConProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        IndiceGlobal = 0
        FrmManProveedor.Show()
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
            If Dg.CurrentCell.ColumnIndex = 7 Then
                IndiceGlobal = codbuscar
                Grabar = "M"
                FrmManProveedor.ShowDialog()
                txtBuscar.Clear()
                cargar("")
            Else
                If Dg.CurrentCell.ColumnIndex = 8 Then
                    If MessageBox.Show("Esta Seguro De Eliminar Al Proveedor" + Chr(13) + Chr(13) + cad, "Sistema de Bodega", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                        logicadatos.eliminar("ELIPRO", codbuscar)
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