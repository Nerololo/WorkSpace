Public Class Form5
    'permite el el ingreso al form caracteristicas tecnicas del arma
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        tipoArma = ComboTipoArma.Text
        nombreArma = TextNombreArma.Text
        If ComboTipoArma.Text = "" Or TextNombreArma.Text = "" Then
            MsgBox("Falta completar algunos datos", MsgBoxStyle.Information)
        Else
            Form6.MdiParent = MDIParent1
            Form6.Show()
        End If
    End Sub
    'cierra el form
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        MDIParent1.BackgroundImage = My.Resources.inicioGRIS
        MDIParent1.MenuStrip.Enabled = True
        Close()
    End Sub
    'no permite escribir en un combobox
    Private Sub CombotipoArma_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboTipoArma.KeyPress
        e.Handled = True
    End Sub
    'carga la imagen del arma
    Private Sub btnCargarImagen_Click(sender As Object, e As EventArgs) Handles BtnCargarImagen.Click
        cargarImagen(OpenFileDialog1, PictureBox1)
        imagenArmas = PictureBox1.Image
    End Sub
    'serve para volver invisible a un formulario
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir()
        simboloCombobox(ComboTipoArma, "tipo_arma", "nombre")
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
        MDIParent1.IsMdiContainer = True
    End Sub
End Class