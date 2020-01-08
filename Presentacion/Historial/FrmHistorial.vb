Public Class FrmHistorial

    Public Sub cargar(ByVal Buscar As String)
        Dg.Rows.Clear()
        Dim iva As String = ""
        For Each his In logicadatos.BuscarHistorial(Buscar)
            If his.Iva = 0 Then
                iva = "0%"
            Else
                iva = "14%"
            End If
            Dg.Rows.Add(his.CodigoHistorial, his.Foto, his.Descripcion, his.Detalle, his.CodigoCategoria, his.CodigoMarca, his.Precio, his.Stock, iva, his.FechaRegistro, his.FechaCaducidad, his.FechaModificacion, his.Estado, CodUsuario)
        Next
    End Sub
    Private Sub FrmHistorial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
        TxtBuscar.Clear()
        cargar("")
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        FrmInicio.Show()
        Me.Close()
    End Sub

    Private Sub TxtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscar.TextChanged
        If TxtBuscar.Text <> "" Then
            cargar(TxtBuscar.Text.Trim())
        Else
            cargar("")
        End If
    End Sub
End Class