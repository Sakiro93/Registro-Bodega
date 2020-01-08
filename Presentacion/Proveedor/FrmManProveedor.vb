Imports Entidad
Public Class FrmManProveedor
    Dim fecha As Date = Date.Now
    Dim fecMod As Date = Date.Now
    Public Sub CargarDatos()
        Dim sexo As String = ""
        For Each i In logicadatos.BuscarProveedores("")
            If (i.CodigoProveedor.Equals(IndiceGlobal)) Then
                TxtNombre.Text = i.Nombre
                TxtCodigo.Text = i.CodigoProveedor
                TxtCedula.Text = i.Cedula
                TxtDireccion.Text = i.Direccion
                TxtTelefono.Text = i.Telefono
                If i.Sexo = 1 Then
                    rdFemenino.Checked = True
                Else
                    rdMasculino.Checked = True
                End If
                fecha = i.FechaRegistro
            End If
        Next
    End Sub

    Public Sub limpiardatos()
        LimpiarGroupbox(GboxProveedor)
        TxtCodigo.Text = logicadatos.MaxCodigo("SIGPRO")
        rdMasculino.Checked = True
    End Sub
    Private Sub FrmManProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
        limpiardatos()
        If IndiceGlobal <> 0 Then
            CargarDatos()
        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        Dim sexo As Integer
        If rdFemenino.Checked = True Then
            sexo = 1
        Else
            sexo = 0
        End If
        If MessageBox.Show("Esta Seguro de Grabar la Marca", "Sistema de Bodega", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If ValidaEntrada(ErrDatos, GboxProveedor) Then
                Dim datos = New EntProveedores(Convert.ToInt32(TxtCodigo.Text), TxtNombre.Text, TxtCedula.Text, TxtDireccion.Text, TxtTelefono.Text, sexo, fecha, fecMod, CodUsuario)
                If Grabar = "N" Then
                    logicadatos.ingresarPro(datos)
                    MessageBox.Show("Registro Grabado Correctamente")
                    limpiardatos()
            Else
                    logicadatos.modificarPro(datos)
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