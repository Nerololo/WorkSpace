Public Class Form6
    Dim cantidadTiposMunicionCompatibles As Integer
    Dim numeroMunicion As Integer
    'Cierra el form
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles bntAtras.Click
        Close()
    End Sub
    'permite volver transparente un form y carga la informacion del form anterior a este form
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles Me.Load
        LabelTipoArma.Text = tipoArma
        LabelNombreArma.Text = nombreArma
        PictureArma.Image = imagenArmas
        abrir()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
        simboloCombobox(ComboTipoMunicion, "tipo_municion", "tipm_str_nombre")
    End Sub
    'guarda la informacion del arma en la base de datos
    Private Sub btnGuardarArma_Click(sender As Object, e As EventArgs) Handles btnGuardarArma.Click
        If TextPais.Text = "" Or TextCosto.Text = "" Or TextEmpresa.Text = "" Or TextSistemaDisparo.Text = "" Or TextCadenciaTiro.Text = "" Or TextLongitud.Text = "" Or TextLongitudCanon.Text = "" Or TextVolumen.Text = "" Or TextPeso.Text = "" Or ComboCalibre.Text = "" Or TextAlcanceMax.Text = "" Or TextAlcanceMin.Text = "" Or TextVelocidadProyectil.Text = "" Or TextTipoCargador.Text = "" Or TextPesoCargador.Text = "" Or TextCapacidadMunicion.Text = "" Then
            MsgBox("Le falta algunos datos del arma por llenar", MsgBoxStyle.Information)
        Else
            If Val(ComboCantidadMunicionPermitida.Text) < 1 Then
                MsgBox("Debe ingresar almenos un tipo de municion", MsgBoxStyle.Information)
            Else
                Dim myImg As Image 'Objeto Image para guardar la imagen del Picture 
                myImg = PictureArma.Image 'Guardar la imagen del PictureBox en el objeto Image
                botonAgregarArma(LabelTipoArma.Text, LabelNombreArma.Text, bytesToString(ImagenToBytes(myImg)), TextPais.Text, TextEmpresa.Text, TextCosto.Text, TextLongitud.Text, TextLongitudCanon.Text, TextVolumen.Text, TextPeso.Text, ComboCalibre.Text, TextAlcanceMax.Text, TextAlcanceMin.Text, TextVelocidadProyectil.Text, TextTipoCargador.Text, TextPesoCargador.Text, TextCapacidadMunicion.Text, TextSistemaDisparo.Text, TextCadenciaTiro.Text, ComboCantidadMunicionPermitida.Text)
                Me.Close()
            End If
        End If
    End Sub
    'desbloquea el panel donde se encuentra el tipo de municion que se va a permitir en el arma
    Private Sub btnCantidadMunicionPermitida_Click(sender As Object, e As EventArgs) Handles btnCantidadMunicionPermitida.Click
        Dim confirmacion As String = MessageBox.Show("esta seguro de que quiere crear " & cantidadTiposMunicionCompatibles & " tipo/s de municion para esta arma", "Confirme", MessageBoxButtons.YesNo)
        If confirmacion = vbYes Then
            If cantidadTiposMunicionCompatibles > 0 Then
                numeroMunicion = 1
                TextNumeroMunicion.Text = numeroMunicion
                PanelTipoMunicion.Enabled = True
                btnCantidadMunicionPermitida.Enabled = False
                ComboCantidadMunicionPermitida.Enabled = False
            Else
                PanelTipoMunicion.Enabled = False
            End If
        End If
    End Sub
    'variable de la cantidad de municion que va permitir el arma
    Private Sub ComboCantidadMunicionPermitida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCantidadMunicionPermitida.SelectedIndexChanged
        cantidadTiposMunicionCompatibles = Val(ComboCantidadMunicionPermitida.Text)
    End Sub
    'guarda el tipo de municion que es permitida para el arma en la base de datos
    Private Sub btnGuardarMunicion_Click(sender As Object, e As EventArgs) Handles btnGuardarMunicion.Click
        If ComboTipoMunicion.Text = "" Or ComboNombreMunicion.Text = "" Then
            MsgBox("Le falta algunos datos de la municion por llenar", MsgBoxStyle.Information)
        Else
            'botonAgregarMunicionArma(ComboTipoMunicion.Text, ComboNombreMunicion.Text)
            cantidadTiposMunicionCompatibles = cantidadTiposMunicionCompatibles - 1
            If cantidadTiposMunicionCompatibles > 0 Then
                PanelTipoMunicion.Enabled = True
                numeroMunicion = numeroMunicion + 1
                TextNumeroMunicion.Text = numeroMunicion
                ComboTipoMunicion.Text = ""
                ComboNombreMunicion.Text = ""
            Else
                PanelTipoMunicion.Enabled = False
            End If
        End If
    End Sub
    'no permite escribir en ningun combobox
    Private Sub ComboCalibre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboCalibre.KeyPress, ComboTipoMunicion.KeyPress, ComboNombreMunicion.KeyPress
        'e.Handled = True
    End Sub
    'permite solo escribir numero es los textbox 
    Private Sub TextCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextCosto.KeyPress, TextSistemaDisparo.KeyPress, TextCadenciaTiro.KeyPress, TextLongitud.KeyPress, TextLongitudCanon.KeyPress, TextVolumen.KeyPress, TextPeso.KeyPress, TextAlcanceMax.KeyPress, TextAlcanceMin.KeyPress, TextVelocidadProyectil.KeyPress, TextPesoCargador.KeyPress, TextCapacidadMunicion.KeyPress
        Dim key As Integer = AscW(e.KeyChar)
        If (key >= 48 And key <= 57) Or key = 8 Or key = 44 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    ' al seleccionar un tipo de municion aparecen en el combo todos los nombre de municion que hay en este tipo
    Private Sub ComboTipoMunicion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTipoMunicion.SelectedIndexChanged
        condicionCombobox(ComboNombreMunicion, "arma", "arm_str_tipo_arma", ComboTipoMunicion.Text, "arm_str_nombre_arma")
    End Sub
End Class