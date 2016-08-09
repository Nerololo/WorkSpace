Public Class Form7
    'cierra el formulario 
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        MDIParent1.BackgroundImage = My.Resources.inicioGRIS
        MDIParent1.MenuStrip.Enabled = True
        Close()
    End Sub
    'ingresa al formulario donde sen encuentran las caracteristicas tecnicas de la municion
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click
        tipoMunicion = ComboTipoMunicion.Text
        nombreMunicion = TextNombreMunicion.Text
        If ComboTipoMunicion.Text = "" Or TextNombreMunicion.Text = "" Then
            MsgBox("Falta completar algunos datos", MsgBoxStyle.Information)
        Else
            Form8.MdiParent = MDIParent1
            Form8.Show()
        End If
    End Sub
    'no permite escribir en nungun combo voz
    Private Sub comboTipoMunicion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboTipoMunicion.KeyPress
        e.Handled = True
    End Sub
    'busca la imagen que va a colocar en el picturebox
    Private Sub btnCargarImagen_Click(sender As Object, e As EventArgs) Handles btnCargarImagen.Click
        cargarImagen(OpenFileDialog1, PictureMunicion)
        imagenMunicion = PictureMunicion.Image
    End Sub
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir()
        simboloCombobox(ComboTipoMunicion, "tipo_municiones", "nombre")
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
        MDIParent1.IsMdiContainer = True
    End Sub

End Class