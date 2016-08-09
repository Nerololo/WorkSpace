Public Class Form20
    'cierra el form
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        MDIParent1.BackgroundImage = My.Resources.inicioGRIS
        MDIParent1.MenuStrip.Enabled = True
        Close()
    End Sub
    'abre el form donde se encuentra las caracteristicas tecnicas del sistema de comunicacion
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        tipoComunicacion = ComboTipoComunicacion.Text
        nombreComunicacion = TextNombreComunicacion.Text
        If ComboTipoComunicacion.Text = "" Or TextNombreComunicacion.Text = "" Then
            MsgBox("Falta completar algunos datos", MsgBoxStyle.Information)
        Else
            Form21.MdiParent = MDIParent1
            Form21.Show()
        End If
    End Sub
    'perimite seleccionar una imagen del pc
    Private Sub btnCargarImagen_Click(sender As Object, e As EventArgs) Handles btnCargarImagen.Click
        cargarImagen(OpenFileDialog1, PictureComunicacion)
        imagenComunicacion = PictureComunicacion.Image
    End Sub
    'vuelve transparente un form
    Private Sub Form20_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir()
        simboloCombobox(ComboTipoComunicacion, "tipo_comunicacion", "nombre")
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
        MDIParent1.IsMdiContainer = True
    End Sub
    'no permite escribir en el combobox
    Private Sub ComboTipoComunicacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboTipoComunicacion.KeyPress
        e.Handled = True
    End Sub
End Class