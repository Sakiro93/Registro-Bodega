Imports Entidad
Public Class FrmManCategoria
    Private fecha As Date = Date.Now
    Private fecMod As Date = Date.Now
    Public Sub CargarDatos()
        For Each i In logicadatos.BuscarCategoria("")
            If (i.CodigoCategoria.Equals(IndiceGlobal)) Then
                TxtCodigo.Text = i.CodigoCategoria
                TxtDescripcion.Text = i.Descripcion
                fecha = i.FechaRegistro
            End If
        Next
    End Sub
    Private Sub FrmManCategoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
        TxtCodigo.Text = logicadatos.MaxCodigo("SIGCAT")
        TxtDescripcion.Clear()
        If IndiceGlobal <> 0 Then
            CargarDatos()
        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        If MessageBox.Show("Esta Seguro de Grabar la Categoria", "Sistema de Bodega", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If ValidaEntrada(ErrDatos, GboxCategoria) Then
                Dim datos = New EntCategoria(TxtCodigo.Text, TxtDescripcion.Text, fecha, fecMod, CodUsuario)
                If Grabar = "N" Then
                    logicadatos.ingresarCat(datos)
                    MessageBox.Show("Registro Grabado Correctamente")
                    TxtDescripcion.Clear()
                    TxtCodigo.Text = logicadatos.MaxCodigo("SIGCAT")
                Else
                    logicadatos.modificarCat(datos)
                    MessageBox.Show("Registro Modificado Correctamente")
                    Me.Close()
                End If
            Else
                MessageBox.Show("Error. Llene los Campos")
            End If
        Else
            MessageBox.Show("Operacion Cancelada")
        End If
    End Sub
End Class