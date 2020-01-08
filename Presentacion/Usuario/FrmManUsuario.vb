Imports Entidad
Imports Logica
Imports System.Windows.Forms
Public Class FrmManUsuario
    Dim fecha As Date = Date.Now
    Public Sub CargarDatos()
        For Each i In logicadatos.BuscarUsuario("")
            If (i.CodigoUsuario.Equals(IndiceGlobal)) Then
                TxtCodigo.Text = i.CodigoUsuario
                TxtContraseña.Text = i.Password
                TxtUsuario.Text = i.Login
                TxtNombre.Text = i.Nombre
                fecha = i.FechaRegistro
            End If
        Next
    End Sub

    Private Sub BtnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegistrar.Click
        If MessageBox.Show("Esta Seguro de Registrarse", "Sistema de Compras", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If ValidaEntrada(ErrDatos, GboxUsuario) Then
                Dim datos As New EntUsuario(Convert.ToInt32(TxtCodigo.Text), TxtUsuario.Text, TxtContraseña.Text, TxtNombre.Text, fecha, Date.Now)
                If Grabar = "N" Then
                    logicadatos.ingresarUsu(datos)
                    MessageBox.Show("Registro Grabado Correctamente")
                Else
                    logicadatos.modificarUsu(datos)
                    MessageBox.Show("Registro Modificado Correctamente")
                End If
                Me.Close()
            Else
                MessageBox.Show("Error. Llene los Campos")
            End If
        Else
            MessageBox.Show("Operacion Cancelada")
        End If

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmManUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
        LimpiarGroupbox(GboxUsuario)
        TxtCodigo.Text = logicadatos.MaxCodigo("SIGUSU")
        If IndiceGlobal <> 0 Then
            CargarDatos()
        End If
    End Sub
End Class