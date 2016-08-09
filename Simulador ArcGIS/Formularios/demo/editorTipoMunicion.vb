Public Class Form17
    'permite ver el formulario transparente
    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
        abrir()
        conectarTabla(tablaDatos, "tipo_municiones", "nombre")
    End Sub
    'boton atras
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MDIParent1.BackgroundImage = My.Resources.inicioGRIS
        MDIParent1.MenuStrip.Enabled = True
        Close()
    End Sub
    'permite agregar un tipo de municion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        botonAgregar("tipo_municiones", "nombre", "Municion")
        conectarTabla(tablaDatos, "tipo_municiones", "nombre")
    End Sub
    'se asumen los valores que se van a editar 
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = tablaDatos.CurrentRow.Cells.Item("nombre").Value.ToString()
        campollave = tablaDatos.CurrentRow.Cells.Item("nombre").Value.ToString()
        TextBox1.Enabled = True
    End Sub
    'guarda los cambios de la edicion
    Private Sub guardarCambios_Click(sender As Object, e As EventArgs) Handles guardarCambios.Click
        botonEditar(TextBox1, tablaDatos, campollave, "Municion", "tipo_municiones", "nombre")
        conectarTabla(tablaDatos, "tipo_municiones", "nombre")
    End Sub
    'elimina un tipo de la tabla
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        campollave = tablaDatos.CurrentRow.Cells.Item("nombre").Value.ToString()
        eliminare(tablaDatos, campollave, "Municion", "tipo_municiones", "nombre")
        conectarTabla(tablaDatos, "tipo_municiones", "nombre")
    End Sub
End Class