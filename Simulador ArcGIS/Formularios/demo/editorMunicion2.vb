Public Class Form8
    'cierra el form
    Private Sub btnAtras_Click_1(sender As Object, e As EventArgs) Handles bntAtras.Click
        Close()
    End Sub
    'permite asumir a los label el valor de la variable de tipo municion y nombre de la municion
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove, TabPage1.MouseMove
        LabelTipoMunicion.Text = tipoMunicion
        LabelNombreMunicion.Text = nombreMunicion
        PictureMunicion.Image = imagenMunicion
    End Sub
    'Permite guardar la informacion de la municion en la base de datos
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If TextPais.Text = "" Or TextEmpresa.Text = "" Or TextCosto.Text = "" Or TextLongitud.Text = "" Or TextDiametro.Text = "" Or TextVolumen.Text = "" Or TextCalibre.Text = "" Or TextPeso.Text = "" Or TextNivelDano.Text = "" Or TextAlcanceEfectivo.Text = "" Or TextAlcanceMaximo.Text = "" Or TextRadioAccion.Text = "" Then
            MsgBox("Le falta algunos datos de la municion por llenar por llenar", MsgBoxStyle.Information)
        Else
            Dim myImg As Image 'Objeto Image para guardar la imagen del Picture 
            myImg = PictureMunicion.Image 'Guardar la imagen del PictureBox en el objeto Image
            botonAgregarMunicion(LabelTipoMunicion.Text, LabelNombreMunicion.Text, bytesToString(ImagenToBytes(myImg)), TextPais.Text, TextEmpresa.Text, TextCosto.Text, TextLongitud.Text, TextDiametro.Text, TextVolumen.Text, TextCalibre.Text, TextPeso.Text, TextNivelDano.Text, TextAlcanceEfectivo.Text, TextAlcanceMaximo.Text, TextRadioAccion.Text)
            Me.Close()
        End If
    End Sub
    'permite escribir en los textbox solo numeros y punos
    Private Sub TextCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextCosto.KeyPress, TextLongitud.KeyPress, TextDiametro.KeyPress, TextVolumen.KeyPress, TextCalibre.KeyPress, TextPeso.KeyPress, TextNivelDano.KeyPress, TextAlcanceEfectivo.KeyPress, TextAlcanceMaximo.KeyPress, TextRadioAccion.KeyPress
        Dim key As Integer = AscW(e.KeyChar)
        If (key >= 48 And key <= 57) Or key = 8 Or key = 44 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'vuelve transparente un form
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
    End Sub

End Class