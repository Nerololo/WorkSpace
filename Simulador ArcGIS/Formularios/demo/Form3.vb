Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir()
        conectarCombobox(ComboTipoEntida, "tipo_entidad", "nombre")
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
        MDIParent1.IsMdiContainer = True
        Me.Opacity = 0.75
    End Sub
    'envia al usuario a paint para crear un simbolo
    Private Sub btnCrarSimbolo_Click(sender As Object, e As EventArgs) Handles btnCrarSimbolo.Click
        Shell("mspaint.exe", AppWinStyle.MaximizedFocus)
    End Sub
    'abre el formulario que agrega los simbolos
    Private Sub btnAgregarSimbolo_Click(sender As Object, e As EventArgs) Handles btnAgregarSimbolo.Click
        Form22.MdiParent = MDIParent1
        Form22.Show()
    End Sub
    'envia al usuario al form de la entidad
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Module1.tipoEntidad = ComboTipoEntida.Text
        Module1.nombreEntidad = TextNombreEntidad.Text
        imagenEntidad = PictureSimboloEntidad.Image

        If ComboTipoEntida.Text = "" Or TextNombreEntidad.Text = "" Then
            MsgBox("Falta completar algunos datos", MsgBoxStyle.Information)
        Else
            Form4.MdiParent = MDIParent1
            Form4.Show()
        End If
    End Sub
    'cierra el formulario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MDIParent1.BackgroundImage = My.Resources.inicioGRIS
        MDIParent1.MenuStrip.Enabled = True
        Close()
    End Sub
    'no permite escribir en los combobox del form
    Private Sub ComboTipoEntida_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboTipoEntida.KeyPress, ComboSimboloEntidad.KeyPress
        e.Handled = True
    End Sub
    'llamar una imagen de la base de datos para picturebox solo sirve en el demo
    Private Sub ComboSimboloEntidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboSimboloEntidad.SelectedIndexChanged
        PictureSimboloEntidad.Image = Nothing
        Dim myImagenConsulta As Image
        myImagenConsulta = BytesToImagen(consultaByte(ComboSimboloEntidad.Text))
        Try
            PictureSimboloEntidad.Image = myImagenConsulta
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    'actualiza el listado del combobox del simbolo de entidades
    Private Sub ComboTipoEntida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTipoEntida.SelectedIndexChanged
        condicionCombobox(ComboSimboloEntidad, "simbolos", "sim_str_tipo_simbolo", ComboTipoEntida.Text, "sim_str_nombre")
    End Sub
End Class