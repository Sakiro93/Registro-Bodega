Imports Logica
Module ModInicial
  
    Public logicadatos As New LogDatos
    Private grabarG As String = ""
    Private CodUser As Integer = 0
    Private indiceG As Integer = 0

    Public Property Grabar() As String
        Get
            Return grabarG
        End Get
        Set(ByVal value As String)
            grabarG = value
        End Set
    End Property

    Public Property CodUsuario() As Integer
        Get
            Return CodUser
        End Get
        Set(ByVal value As Integer)
            CodUser = value
        End Set
    End Property
    Public Property IndiceGlobal() As Integer
        Get
            Return indiceG
        End Get
        Set(ByVal value As Integer)
            indiceG = value
        End Set
    End Property

    Public Function ValidaEntrada(ByVal err As ErrorProvider, ByVal grp As GroupBox) As Boolean
        err.Clear()
        Dim er As Boolean = True
        For Each C In grp.Controls 'For que se lo utiliza para leer colecciones
            If TypeOf C Is TextBox And C.Text = "" Then 'TypeOf = tipo
                err.SetError(C, "No ha ingresado informacion en: " + C.Name)
                er = False
            End If
            If TypeOf C Is ComboBox And C.Text = "" Then
                err.SetError(C, "No ha Seleccionado ninguna opcion en: " + C.Name)
                er = False
            End If
        Next
        Return er
    End Function

    Public Sub LimpiarGroupbox(ByVal Grp As GroupBox)
        For Each C In Grp.Controls
            If TypeOf C Is TextBox Then C.Text = ""
            If TypeOf C Is ComboBox Then C.Items.Clear()
            If TypeOf C Is DateTimePicker Then C = Date.Now
        Next
    End Sub
End Module
