Imports Entidad
Public Class FrmManMarca
    Private fecha As Date = Date.Now
    Private fecMod As Date = Date.Now
    Public Sub CargarDatos()
        For Each i In logicadatos.BuscarMarca("")
            If (i.CodigoMarca.Equals(IndiceGlobal)) Then
                TxtCodigo.Text = i.CodigoMarca
                TxtDescripcion.Text = i.Descripcion
                fecha = i.FechaRegistro
            End If
        Next
    End Sub
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmManMarca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
        TxtDescripcion.Clear()
        TxtCodigo.Text = logicadatos.MaxCodigo("SIGMAR")
        If IndiceGlobal <> 0 Then
            CargarDatos()
        End If
    End Sub


    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        If MessageBox.Show("Esta Seguro de Grabar la Marca", "Sistema de Bodega", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If ValidaEntrada(ErrDatos, GboxMarca) Then
                Dim datos = New EntMarca(Convert.ToInt32(TxtCodigo.Text), TxtDescripcion.Text, fecha, fecMod, CodUsuario)
                If Grabar = "N" Then
                    logicadatos.ingresarMar(datos)
                    MessageBox.Show("Registro Grabado Correctamente")
                    TxtDescripcion.Clear()
                    TxtCodigo.Text = logicadatos.MaxCodigo("SIGMAR")
                Else
                    logicadatos.modificarMar(datos)
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