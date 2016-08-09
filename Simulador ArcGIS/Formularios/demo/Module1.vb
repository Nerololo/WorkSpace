Module Module1
    Public tipoEntidad As String
    Public nombreEntidad As String
    Public tipoArma As String
    Public nombreArma As String
    Public tipoMunicion As String
    Public nombreMunicion As String
    Public tipoSensor As String
    Public nombreSensor As String
    Public tipoProteccion As String
    Public nombreProteccion As String
    Public tipoProteccion1 As String
    Public nombreProteccion1 As String
    Public tipoComunicacion As String
    Public nombreComunicacion As String
    Public editores As String
    Public imagenEntidad As Image
    Public imagenArmas As Image
    Public imagenMunicion As Image
    Public imagenSensor As Image
    Public imagenProteccion As Image
    Public imagenComunicacion As Image



    'permite cargaruna imagen en un picturebox
    Sub cargarImagen(ByVal cargar As OpenFileDialog, ByVal imagen As PictureBox)
        cargar.Filter = "Archivo JPG|*.jpg"
        cargar.InitialDirectory() = "C:\Users\Public\Pictures"
        If cargar.ShowDialog() = DialogResult.OK Then
            imagen.Image = Image.FromFile(cargar.FileName)
            Dim bmp As New Bitmap(imagen.Image)
            imagen.Image = New Bitmap(bmp, 128, 128)
        End If
    End Sub
    ' permite activar un panel con un checkbox
    Sub botonActivar(ByVal boton As CheckBox, ByVal elemento As Panel)
        If boton.Checked = True Then
            boton.Text = "Activado"
            elemento.Enabled = True
        Else
            elemento.Enabled = False
            boton.Text = "Desactivado"
        End If
    End Sub

    Sub comboCombo(ByVal combo As ComboBox, ByVal combo1 As ComboBox, ByVal combo2 As ComboBox, ByVal numero As Integer)
        If Val(combo.Text) > numero Then
            combo1.Enabled = True
            combo2.Enabled = True
        Else
            combo1.Enabled = False
            combo2.Enabled = False
        End If
    End Sub
End Module



