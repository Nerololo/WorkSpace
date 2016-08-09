Public Class Form22
    'permite ver la informacion del combobox tipo de simbolo en un label
    Private Sub ComboTipoSimbolo1_MouseMove(sender As Object, e As MouseEventArgs) Handles ComboTipoSimbolo.MouseMove
        Label8.Visible = True
    End Sub
    'permite ver la informacion deltextbox nombre del simbolo en un label
    Private Sub TextNombreSimbolo_MouseMove(sender As Object, e As MouseEventArgs) Handles TextNombreSimbolo.MouseMove
        Label4.Visible = True
    End Sub
    'permite ver la informacion de este boton cargar en un label
    Private Sub btnCargar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnCargar.MouseMove
        Label1.Visible = True
    End Sub
    'permite ver la informacion de este boton guargar en un label
    Private Sub btnGuardar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnGuardar.MouseMove
        Label2.Visible = True
    End Sub
    Private Sub editorSimbolos_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Label1.Visible = False
        Label2.Visible = False
        Label4.Visible = False
        Label8.Visible = False
    End Sub
    'no permite escribir en el combobox del form
    Private Sub ComboTipoSimbolo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboTipoSimbolo.KeyPress
        e.Handled = True
    End Sub
    'abre una pestana que permite buscar un simbolo y lo carga en el picturebox
    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        cargarImagen(OpenFileDialog1, PictureSimbolo)
    End Sub
    'cierra el form
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        MDIParent1.MenuStrip.Enabled = True
        Close()
    End Sub
    'permite que un formulario sea transparente
    Private Sub Form22_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir()
        conectarCombobox(ComboTipoSimbolo, "tipo_entidad", "nombre")
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
    End Sub
    'guardar la el simbolo solo aplica para el demo
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Dim nuevonombres As String = TextNombreSimbolo.Text
        Dim myImg As Image 'Objeto Image para guardar la imagen del Picture 
        myImg = PictureSimbolo.Image 'Guardar la imagen del PictureBox en el objeto Image
        MsgBox(insertarImagen(ComboTipoSimbolo.Text, TextNombreSimbolo.Text, bytesToString(ImagenToBytes(myImg))))
        PictureSimbolo.Image = Nothing
        MDIParent1.MenuStrip.Enabled = True
        Close()
    End Sub
End Class