Public Class FrmInicioSesion

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngresar.Click
        If ValidaEntrada(ErrDatos, GBoxInicio) Then
            Dim valor As Boolean = False
            For Each Fila In logicadatos.BuscarUsuario("")
                If TxtUsuario.Text.Trim() = Fila.Login And TxtContraseña.Text.Trim() = Fila.Password Then
                    CodUsuario = Fila.CodigoUsuario
                    valor = True
                End If
            Next
            If valor Then
                FrmInicio.Show()
                Me.Close()
                Me.Dispose()
            Else
                MessageBox.Show("Digite su Usuario y Contraseña Correctamente")
            End If
        Else
            MessageBox.Show("Error. Llene los Campos")
        End If
    End Sub

    Private Sub BtnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegistrar.Click
        Grabar = "N"
        IndiceGlobal = 0
        FrmManUsuario.ShowDialog()
    End Sub

    Private Sub FrmInicioSesion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LimpiarGroupbox(GBoxInicio)
        CenterToScreen()
    End Sub
End Class