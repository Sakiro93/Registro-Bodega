Public Class FrmInicio
    Public Sub CargarDatos()
        For Each i In logicadatos.BuscarUsuario("")
            If (i.CodigoUsuario.Equals(CodUsuario)) Then
                LblNombre.Text = i.Nombre
                IndiceGlobal = i.CodigoUsuario
            End If
        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        FrmInicioSesion.Show()
        Me.Close()
    End Sub

    Private Sub FrmInicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
        Grabar = "M"
        CargarDatos()
    End Sub

    Private Sub BtnConProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConProd.Click
        FrmConArticulos.Show()
        Me.Close()
    End Sub

    Private Sub BtnRevHist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRevHist.Click
        FrmHistorial.Show()
        Me.Close()
    End Sub

    Private Sub BtnConCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConCat.Click
        FrmConCategoria.Show()
        Me.Close()
    End Sub

    Private Sub BtnConPro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConPro.Click
        FrmConProveedor.Show()
        Me.Close()
    End Sub

    Private Sub BtnConMar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConMar.Click
        FrmConMarca.Show()
        Me.Close()
    End Sub

    Private Sub BtnConfi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConfi.Click
        FrmManUsuario.ShowDialog()
        CargarDatos()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LblFecha.Text = DateTime.Now.ToShortDateString
        LblTiempo.Text = DateTime.Now.ToLongTimeString
    End Sub
End Class
