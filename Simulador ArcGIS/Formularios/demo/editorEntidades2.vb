Public Class Form4
    Dim cantidadSensor As Integer
    Dim cantidadArmas As Integer
    Dim numeroSensor As Integer
    Dim cantidadComunicaciones As Integer
    Dim numeroComunicaciones As Integer
    'activa el panel de altura
    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        botonActivar(CheckBox1, PanelAltura)
    End Sub
    'activa el panel de profundidad
    Private Sub CheckBox2_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        botonActivar(CheckBox2, PanelProfundidad)
    End Sub
    'activa el panel de capacidad logistica
    Private Sub CheckBox3_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        botonActivar(CheckBox3, PanelCapacidadLogistica)
    End Sub
    Friend Shared Function MdiParent1() As Form3
        Throw New NotImplementedException()
    End Function
    'activa el panel de capacidad de arrastre
    Private Sub CheckBox5_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        botonActivar(CheckBox5, PanelCapacidadArrastre)
    End Sub
    'cierra el formulario
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub
    'permite colocar el nombre de la entidad el tipo y la imagen en el formulario 
    Private Sub Panel126_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel126.MouseMove, TabPage1.MouseMove
        LabelTipoEntidad.Text = Module1.tipoEntidad
        LabelNombreEntidad.Text = Module1.nombreEntidad
        PictureSimboloEntidad.Image = imagenEntidad
    End Sub
    'desbloquea el panel donde se encuentra la informacion del sensor de una entidad
    Private Sub btnCantidadSensor_Click(sender As Object, e As EventArgs) Handles btnCantidadSensor.Click
        Dim confirmacion As String = MessageBox.Show("esta seguro de que quiere crear " & cantidadSensor & " Sensor/es", "Confirme", MessageBoxButtons.YesNo)
        If confirmacion = vbYes Then
            If cantidadSensor > 0 Then
                numeroSensor = 1
                TextNumeroSensor.Text = numeroSensor
                pamelSensorEntidad.Enabled = True
                btnCantidadSensor.Enabled = False
                comboCantidadSensor.Enabled = False
            Else
                pamelSensorEntidad.Enabled = False
            End If
        End If
    End Sub
    'guarda  en la base de datos el sensor de la entidad que fue creado y avilita el panel de las armas de la entidad
    'y bloquea el boton de aplicar y el panel de los sensores mientras se llena la informacion de la cantidad de armas que va crear 
    Private Sub btnGuardarSensorEntidad_Click(sender As Object, e As EventArgs) Handles btnGuardarSensorEntidad.Click
        If ComboNombreSensor.Text = "" Or TextNumeroSensor.Text = "" Or ComboTipoSensor.Text = "" Or comboCantidadArmas.Text = "" Then
            MsgBox("Le falta algunos datos del sensor por llenar", MsgBoxStyle.Information)
        Else
            cantidadSensor = cantidadSensor - 1
            If cantidadSensor > 0 Then
                pamelSensorEntidad.Enabled = True
            Else
                pamelSensorEntidad.Enabled = False
            End If
            If cantidadArmas > 0 Then
                panelArmasEntidad.Enabled = True
                pamelSensorEntidad.Enabled = False
            Else
                panelArmasEntidad.Enabled = False
            End If
            If comboCantidadArmas.Text = "0" Then
                numeroSensor = numeroSensor + 1
                TextNumeroSensor.Text = numeroSensor
                ComboTipoSensor.Text = ""
                ComboNombreSensor.Text = ""
                comboCantidadArmas.Text = ""
            End If
        End If
    End Sub
    'variable de las armas que se van a crear para cada sensor
    Private Sub comboCantidadArmas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboCantidadArmas.SelectedIndexChanged
        cantidadArmas = Val(comboCantidadArmas.Text)
    End Sub
    'variable de los sensores que se van a crear de la entidad
    Private Sub comboCantidadSensor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboCantidadSensor.SelectedIndexChanged
        cantidadSensor = Val(comboCantidadSensor.Text)
    End Sub
    'guarda  en la base de datos el arma del sensor que fue creado
    Private Sub btnGuardarArmasSensor_Click(sender As Object, e As EventArgs) Handles btnGuardarArmasSensor.Click
        If ComboTipoArma.Text = "" Or ComboSeleccioneArma.Text = "" Or ComboTipoMunicion.Text = "" Or ComboSeleccioneMunicion.Text = "" Or cantidadMunicion.Text = "" Then
            MsgBox("Le falta algunos datos del arma por llenar", MsgBoxStyle.Information)
        Else
            cantidadArmas = cantidadArmas - 1
            If cantidadArmas > 0 Then
                panelArmasEntidad.Enabled = True
            Else
                panelArmasEntidad.Enabled = False
                pamelSensorEntidad.Enabled = True
                ComboTipoSensor.Text = ""
                ComboNombreSensor.Text = ""
                comboCantidadArmas.Text = ""
                numeroSensor = numeroSensor + 1
                TextNumeroSensor.Text = numeroSensor
            End If
            ComboTipoArma.Text = ""
            ComboSeleccioneArma.Text = ""
            ComboTipoMunicion.Text = ""
            ComboSeleccioneMunicion.Text = ""
            cantidadMunicion.Text = ""
        End If
        If cantidadSensor < 1 Then
            pamelSensorEntidad.Enabled = False
        End If
    End Sub
    'desbloquea el panel donde se encuentra la informacion del sistema de comunicaciones de una entidad
    Private Sub ButonCantidadComunicaciones_Click(sender As Object, e As EventArgs) Handles ButonCantidadComunicaciones.Click
        Dim confirmacion As String = MessageBox.Show("esta seguro de que quiere crear " & cantidadComunicaciones & " Sistema/s de Comunicaciones", "Confirme", MessageBoxButtons.YesNo)
        If confirmacion = vbYes Then
            If cantidadComunicaciones > 0 Then
                numeroComunicaciones = 1
                TextComunicacionesNumero.Text = numeroComunicaciones
                PanelSistemaComunicaciones.Enabled = True
                ButonCantidadComunicaciones.Enabled = False
                ComboCantidadComunicaciones.Enabled = False
            Else
                PanelSistemaComunicaciones.Enabled = False
            End If
        End If

    End Sub
    'variable de los sistemas de comunicacion que se van a crear de la entidad
    Private Sub ComboCantidadComunicaciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCantidadComunicaciones.SelectedIndexChanged
        cantidadComunicaciones = Val(ComboCantidadComunicaciones.Text)
    End Sub
    'guarda  en la base de datos el sistema de comunicacion de la entidad que fue creado
    Private Sub ButonGuardarComunicaciones_Click(sender As Object, e As EventArgs) Handles ButonGuardarComunicaciones.Click
        If TextComunicacionesNumero.Text = "" Or ComboTipoComunicaciones.Text = "" Or ComboSeleccionComunicaciones.Text = "" Then
            MsgBox("Le falta algunos datos del sistema de comunicacion por llenar", MsgBoxStyle.Information)
        Else
            cantidadComunicaciones = cantidadComunicaciones - 1
            If cantidadComunicaciones > 0 Then
                PanelSistemaComunicaciones.Enabled = True
                numeroComunicaciones = numeroComunicaciones + 1
                TextComunicacionesNumero.Text = numeroComunicaciones
                ComboTipoComunicaciones.Text = ""
                ComboSeleccionComunicaciones.Text = ""
            Else
                PanelSistemaComunicaciones.Enabled = False
            End If
        End If
    End Sub
    'no permite escribir en ningun combobox del form
    Private Sub ComboTipoPiloto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboTipoPiloto.KeyPress, ComboTipoSonido.KeyPress, comboCantidadSensor.KeyPress, ComboTipoSensor.KeyPress, ComboNombreSensor.KeyPress, ComboTipoSonido.KeyPress, comboCantidadArmas.KeyPress, ComboTipoArma.KeyPress, ComboSeleccioneArma.KeyPress, ComboTipoMunicion.KeyPress, ComboSeleccioneMunicion.KeyPress, ComboCantidadComunicaciones.KeyPress, ComboTipoComunicaciones.KeyPress, ComboSeleccionComunicaciones.KeyPress
        e.Handled = True
    End Sub
    'solo permite escrir numeros y puntos en el textbox
    Private Sub TextCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextCosto.KeyPress, TextLargo.KeyPress, TextAncho.KeyPress, TextAlto.KeyPress, TextVolumen.KeyPress, TextPeso.KeyPress, TextCantidadPilotos.KeyPress, TextPuntosResistencia.KeyPress, TextVelocidadMin.KeyPress, TextVelocidadMed.KeyPress, TextVelocidadMax.KeyPress, TextRadioSonido.KeyPress, TextVolumenMax.KeyPress, TextPesoMax.KeyPress, TextCantidadPax.KeyPress, TextRadioEntrega.KeyPress, TextRadioRecepcion.KeyPress, TextTiempoEntrega.KeyPress, TextRadioMontar.KeyPress, TextRadioDesmontar.KeyPress, TextRadioArrastre.KeyPress, TextCapacidadArrastreKg.KeyPress, TextCapacidadArrastreM.KeyPress, TextAlturaMin.KeyPress, TextAlturaMedia.KeyPress, TextAlturaMax.KeyPress, TextProfundidadMin.KeyPress, TextProfundidadMed.KeyPress, TextProfundidadMax.KeyPress, cantidadMunicion.KeyPress, TextCapacidadCombustible.KeyPress, TextKmporLitro.KeyPress
        Dim key As Integer = AscW(e.KeyChar)
        If (key >= 48 And key <= 57) Or key = 8 Or key = 44 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'Guarda la entidad que fue creada en la base de datos
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnGuardarEntidad.Click
        If TextPais.Text = "" Or TextEmpresa.Text = "" Or TextCosto.Text = "" Or TextLargo.Text = "" Or TextAncho.Text = "" Or TextAlto.Text = "" Or TextVolumen.Text = "" Or TextPeso.Text = "" Or TextTipoMaterial.Text = "" Or TextPuntosResistencia.Text = "" Or TextCantidadPilotos.Text = "" Or ComboTipoPiloto.Text = "" Or TextVelocidadMin.Text = "" Or TextVelocidadMax.Text = "" Or TextVelocidadMed.Text = "" Or ComboTipoSonido.Text = "" Or TextRadioSonido.Text = "" Or TextVolumenMax.Text = "" Or TextPesoMax.Text = "" Or TextCantidadPax.Text = "" Or TextRadioMontar.Text = "" Or TextRadioDesmontar.Text = "" Or TextTipoCombustible.Text = "" Or TextCapacidadCombustible.Text = "" Or TextKmporLitro.Text = "" Then
            ' MsgBox("Le falta algunos datos de la entidad por llenar por llenar", MsgBoxStyle.Information)
            'Else
            'Dim nombreEntidad As String = LabelNombreEntidad.Text
            'Dim tipoEntidad As String = LabelTipoEntidad.Text
            Dim myImg As Image 'Objeto Image para guardar la imagen del Picture 
            myImg = PictureSimboloEntidad.Image 'Guardar la imagen del PictureBox en el objeto Image
            botonAgregarEntidad(LabelTipoEntidad.Text, LabelNombreEntidad.Text, bytesToString(ImagenToBytes(myImg)), TextPais.Text, TextEmpresa.Text, TextCosto.Text, TextLargo.Text, TextAncho.Text, TextAlto.Text, TextVolumen.Text, TextPeso.Text, TextTipoMaterial.Text, TextPuntosResistencia.Text, TextCantidadPilotos.Text, ComboTipoPiloto.Text, TextVelocidadMin.Text, TextVelocidadMed.Text, TextVelocidadMed.Text, ComboTipoSonido.Text, TextRadioSonido.Text, TextVolumenMax.Text, TextPesoMax.Text, TextCantidadPax.Text, TextRadioEntrega.Text, TextRadioRecepcion.Text, TextTiempoEntrega.Text, TextRadioMontar.Text, TextRadioDesmontar.Text, TextRadioArrastre.Text, TextCapacidadArrastreKg.Text, TextCapacidadArrastreM.Text, TextAlturaMin.Text, TextAlturaMedia.Text, TextAlturaMax.Text, TextProfundidadMin.Text, TextProfundidadMed.Text, TextProfundidadMax.Text, TextTipoCombustible.Text, TextCapacidadCombustible.Text, TextKmporLitro.Text, comboCantidadSensor.Text)
            PictureSimboloEntidad.Image = Nothing
            Me.Close()
        End If
    End Sub
    'permite volver un form transparente 
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
        abrir()
        simboloCombobox(ComboTipoSensor, "tipo_sensores", "tips_str_nombre")
        simboloCombobox(ComboTipoArma, "tipo_armas", "tipa_str_nombre")
        simboloCombobox(ComboTipoMunicion, "tipo_municion", "tipm_str_nombre")
        simboloCombobox(ComboTipoComunicaciones, "tipo_comunicacion", "tipc_str_nombre")
        'Dim controlcito As Control
        'Dim controlChild As Control

        'For Each controlcito In Me.TabPage1.Controls
        '    If TypeOf controlcito Is Label Then
        '        controlcito.Font = New Font("Verdana", 8)
        '    ElseIf controlcito.HasChildren Then
        '        For Each controlChild In controlcito.Controls
        '            If TypeOf controlChild Is Label Then
        '                controlChild.Font = New Font("Verdana", 8)
        '            End If
        '        Next
        '    End If
        'Next
    End Sub
    'al seleccionar un tipo de sensor aparecen los nombres de los sensores que hay en ese tipo
    Private Sub ComboTipoSensor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTipoSensor.SelectedIndexChanged
        condicionCombobox(ComboNombreSensor, "sensor", "sen_str_tipo_sensor", ComboTipoSensor.Text, "sen_str_nombre_sensor")
    End Sub
    'al seleccionar un tipo de arma aparecen los nombres de las armas que hay en ese tipo
    Private Sub ComboTipoArma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTipoArma.SelectedIndexChanged
        condicionCombobox(ComboSeleccioneArma, "armas", "arm_str_tipo_arma", ComboTipoArma.Text, "arm_str_nombre_arma")
    End Sub
    'al seleccionar un tipo de municion aparecen los nombres de las municiones que hay en ese tipo
    Private Sub ComboTipoMunicion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTipoMunicion.SelectedIndexChanged
        condicionCombobox(ComboSeleccioneMunicion, "municion", "mun_str_tipo_municion", ComboTipoMunicion.Text, "mun_str_nombre_municion")
    End Sub
    'al seleccionar un tipo de comunicacion aparecen los nombres de comunicacion que hay en ese tipo
    Private Sub ComboTipoComunicaciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTipoComunicaciones.SelectedIndexChanged
        condicionCombobox(ComboSeleccionComunicaciones, "comunicacion", "com_str_tipo_comunicacion", ComboTipoComunicaciones.Text, "com_str_nombre_comunicacion")
    End Sub

    Private Sub Panel126_Paint(sender As Object, e As PaintEventArgs) Handles Panel126.Paint

    End Sub
End Class