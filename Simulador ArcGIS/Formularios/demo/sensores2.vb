Public Class Form10
    'cierra el form
    Private Sub btnAtras_Click_1(sender As Object, e As EventArgs) Handles btnAtras.Click
        Close()
        Form9.Show()
    End Sub
    'le ingresa un valor a los label de tipo de sensor y nombre de sensor 
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove, TabPage1.MouseMove
        LabelTipoSensor.Text = tipoSensor
        LabelNombreSensor.Text = nombreSensor
        PictureSensor.Image = imagenSensor
    End Sub
    'solo permite escribir en los textbox numeros y puntos
    Private Sub TextCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextCosto.KeyPress, TextRangoMedida.KeyPress, TextPrecision.KeyPress, TextDesviacionCero.KeyPress, TextCorrecionLineal.KeyPress, TextSensibilidad.KeyPress, TextRapidezRespuesta.KeyPress, TextRepetitividad.KeyPress
        Dim key As Integer = AscW(e.KeyChar)
        If (key >= 48 And key <= 57) Or key = 8 Or key = 44 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'no permite escribir en un combobox
    Private Sub ComboResolucion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboResolucion.KeyPress
        'e.Handled = True
    End Sub
    'guarda la informacion del sensor en la base de datos
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If TextPais.Text = "" Or TextEmpresa.Text = "" Or TextRangoMedida.Text = "" Or TextPrecision.Text = "" Or TextDesviacionCero.Text = "" Or TextCorrecionLineal.Text = "" Or TextSensibilidad.Text = "" Or ComboResolucion.Text = "" Or TextRapidezRespuesta.Text = "" Or TextRepetitividad.Text = "" Then
            MsgBox("Le falta algunos datos del Sensor por llenar", MsgBoxStyle.Information)
        Else
            Dim myImg As Image 'Objeto Image para guardar la imagen del Picture 
            myImg = PictureSensor.Image 'Guardar la imagen del PictureBox en el objeto Image
            botonAgregarSensor(LabelTipoSensor.Text, LabelNombreSensor.Text, bytesToString(ImagenToBytes(myImg)), TextPais.Text, TextEmpresa.Text, TextCosto.Text, TextRangoMedida.Text, TextPrecision.Text, TextDesviacionCero.Text, TextCorrecionLineal.Text, TextSensibilidad.Text, ComboResolucion.Text, TextRapidezRespuesta.Text, TextRepetitividad.Text)
            Me.Close()
        End If
    End Sub
    'vuelve un form transparente
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
    End Sub
End Class