Public Class Form9
    'cierra el formulario
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        MDIParent1.BackgroundImage = My.Resources.inicioGRIS
        MDIParent1.MenuStrip.Enabled = True
        Close()
    End Sub
    'abre el formulario donde se encuentran las caracteristicas tecnicas del sensor 
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        tipoSensor = ComboTipoSensor.Text
        nombreSensor = TextNombreSensor.Text
        If ComboTipoSensor.Text = "" Or TextNombreSensor.Text = "" Then
            MsgBox("Falta completar algunos datos", MsgBoxStyle.Information)
        Else
            Form10.MdiParent = MDIParent1
            Form10.Show()
        End If
    End Sub
    'no permite escribir en el combobox
    Private Sub ComboTipoSensor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboTipoSensor.KeyPress
        e.Handled = True
    End Sub
    'carga la imagen que el usuario quiera y la coloca en el picturebox
    Private Sub btnCargarImagen_Click(sender As Object, e As EventArgs) Handles btnCargarImagen.Click
        cargarImagen(OpenFileDialog1, PictureImagenSensor)
        imagenSensor = PictureImagenSensor.Image
    End Sub
    'permite volver un form transparente
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir()
        simboloCombobox(ComboTipoSensor, "tipo_sensores", "nombre")
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
        MDIParent1.IsMdiContainer = True
    End Sub

End Class