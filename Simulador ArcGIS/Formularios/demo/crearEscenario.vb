Public Class crearEscenario
    Dim tabla As String
    Dim tabla2 As String
    Dim columna As String
    Dim columnaEvaluar As String
    Dim columnaMostrar As String
    'boton atras
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MDIParent1.MenuStrip.Enabled = True
        Close()
    End Sub
    'permite volver un form transparente 
    Private Sub crearEscenario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
        abrir()
    End Sub
    'asigna un listado de los tipos que hay dependiendo de la seleccion de lo que va crear
    Private Sub ListCrear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListCrear.SelectedIndexChanged
        If ListCrear.SelectedItem = "Entidades" Then
            tabla = "tipo_entidad"
            columna = "nombre"
        ElseIf (ListCrear.SelectedItem = "Armas") Then
            tabla = "tipo_arma"
            columna = "nombre"
        ElseIf (ListCrear.SelectedItem = "Municion") Then
            tabla = "tipo_municiones"
            columna = "nombre"
        ElseIf (ListCrear.SelectedItem = "Sensores") Then
            tabla = "tipo_sensores"
            columna = "nombre"
        ElseIf (ListCrear.SelectedItem = "Proteccion") Then
            tabla = "tipo_proteccion"
            columna = "nombre"
        ElseIf (ListCrear.SelectedItem = "Sistema de Comunicacion") Then
            tabla = "tipo_comunicacion"
            columna = "nombre"
        End If
        escojeList(ListTipo, tabla, columna)
    End Sub

    Private Sub ListTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListTipo.SelectedIndexChanged
        If tabla = "tipo_entidad" Then
            tabla2 = "entidad"
            columnaMostrar = "ent_str_nombre_entidad"
            columnaEvaluar = "ent_str_tipo_entidad"
        ElseIf (tabla = "tipo_arma") Then
            tabla2 = "armas"
            columnaMostrar = "arm_str_nombre_arma"
            columnaEvaluar = "arm_str_tipo_arma"
        ElseIf (tabla = "tipo_municiones") Then
            tabla2 = "municiones"
            columnaMostrar = "mun_str_nombre_municion"
            columnaEvaluar = "mun_str_tipo_municion"
        ElseIf (tabla = "tipo_sensores") Then
            tabla2 = "sensor"
            columnaMostrar = "sen_str_nombre_sensor"
            columnaEvaluar = "sen_str_tipo_sensor"
        ElseIf (tabla = "tipo_proteccion") Then

        ElseIf (tabla = "tipo_comunicacion") Then
            tabla2 = "comunicacion"
            columnaMostrar = "com_str_nombre_comunicacion"
            columnaEvaluar = "com_str_tipo_comunicacion"
        End If
        condicionLisbox(ListNombre, tabla2, columnaEvaluar, ListTipo.Text, columnaMostrar)

    End Sub
    'guarda la informacion del escenario en una base de datos 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextNombreEscenario.Text = "" Or ListCrear.Text = "" Or ListTipo.Text = "" Or ListNombre.Text = "" Or ListBando.Text = "" Or TextLatitudGrados.Text = "" Or TextlongitudGrados.Text = "" Then
            MsgBox("le hace falta un dato por ingresar", MsgBoxStyle.Information)
        Else
            botonAgregarescenario(TextNombreEscenario.Text, ListCrear.Text, ListTipo.Text, ListNombre.Text, ListBando.Text, ubicacionLat.Text, TextLatitudGrados.Text, TextLatitudMin.Text, TextLatitudSeg.Text, ubicacionLong.Text, TextlongitudGrados.Text, TextLongitudMin.Text, TextLongitudSeg.Text)
            conectarTablaColumnas(tablaDatos, TextNombreEscenario)
            TextNombreEscenario.Enabled = False
        End If
    End Sub
    'permite llamar el mapa de argis
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As ArcGISRuntime.Samples.Desktop.SimuladorMain = New ArcGISRuntime.Samples.Desktop.SimuladorMain()
        a.Visibility = System.Windows.Visibility.Visible
        Me.Hide()
    End Sub

End Class