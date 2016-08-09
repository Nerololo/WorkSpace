Public Class Form21
    'Cierra el formulario 
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Close()
    End Sub
    'guarda el sistema de comunicacion en la base de datos
    Private Sub btnGuardarSistemaComunicacion_Click(sender As Object, e As EventArgs) Handles btnGuardarSistemaComunicacion.Click
        If TextPais.Text = "" Or TextEmpresa.Text = "" Or TextCosto.Text = "" Or TextLargo.Text = "" Or TextAncho.Text = "" Or TextAlto.Text = "" Or TextVolumen.Text = "" Or TextPeso.Text = "" Or TextEspecificacionCanalesDesde.Text = "" Or TextEspecificacionCanalesHasta.Text = "" Or TextTamanoAntena.Text = "" Or TextCantidadBaterias.Text = "" Or TextEstabiliodadFrecuencia.Text = "" Or TextPtenciaSalida.Text = "" Or TextDistorcionAudio.Text = "" Or TextSalidaAudio.Text = "" Or TextAlcanceMax.Text = "" Then
            MsgBox("Le falta algunos datos del sitema de comunicacion por llenar", MsgBoxStyle.Information)
        Else
            Dim myImg As Image 'Objeto Image para guardar la imagen del Picture 
            myImg = PictureSistemaComunicacion.Image 'Guardar la imagen del PictureBox en el objeto Image
            botonAgregarComunicacion(LabelTipoSistemaComunicacion.Text, LabelNombreSistemaComunicacion.Text, bytesToString(ImagenToBytes(myImg)), TextPais.Text, TextEmpresa.Text, TextCosto.Text, TextLargo.Text, TextAncho.Text, TextAlto.Text, TextVolumen.Text, TextPeso.Text, TextEspecificacionCanalesDesde.Text, TextEspecificacionCanalesHasta.Text, TextTamanoAntena.Text, TextCantidadBaterias.Text, ComboTipoCargador.Text, TextEstabiliodadFrecuencia.Text, TextPtenciaSalida.Text, TextDistorcionAudio.Text, TextSalidaAudio.Text, TextAlcanceMax.Text)
            Me.Close()
        End If
    End Sub
    'los label asumen el valor de las variables de tipo de comunicacion y nombre de comunicacion
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove, Panel2.MouseMove, TabPage1.MouseMove
        LabelTipoSistemaComunicacion.Text = tipoComunicacion
        LabelNombreSistemaComunicacion.Text = nombreComunicacion
        PictureSistemaComunicacion.Image = imagenComunicacion
    End Sub
    'permite solo escribir numeros y puntos enlos textbox
    Private Sub TextCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextCosto.KeyPress, TextLargo.KeyPress, TextAncho.KeyPress, TextAlto.KeyPress, TextVolumen.KeyPress, TextPeso.KeyPress, TextEspecificacionCanalesDesde.KeyPress, TextEspecificacionCanalesHasta.KeyPress, TextTamanoAntena.KeyPress, TextCantidadBaterias.KeyPress, TextPtenciaSalida.KeyPress, TextDistorcionAudio.KeyPress, TextAlcanceMax.KeyPress
        Dim key As Integer = AscW(e.KeyChar)
        If (key >= 49 And key <= 57) Or key = 8 Or key = 44 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'no deja escribir en el combobox
    Private Sub ComboTipoCargador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboTipoCargador.KeyPress
        'e.Handled = True
    End Sub
    'volver al form transparente
    Private Sub Form21_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
    End Sub
    'permite solo escribir numeros
    Private Sub TextEstabiliodadFrecuencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextEstabiliodadFrecuencia.KeyPress
        Dim key As Integer = AscW(e.KeyChar)
        If (key >= 49 And key <= 57) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class