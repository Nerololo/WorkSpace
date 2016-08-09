Imports System.Data.SqlClient
Imports System.IO
Module soloDemo
    'Retorna un String apartir de un arreglo de Bytes. Concatena cada elemento en la variable salida para ser almacenada en la Base de Datos'
    Function bytesToString(ByVal arreglo As Byte()) As String
        Dim salida As String = ""
        Dim x As Integer = 0
        'MsgBox("Tamaño del arreglo: " + arreglo.Length.ToString)
        Try
            For x = 0 To arreglo.Length - 1
                salida += arreglo(x).ToString + ","
            Next
        Catch ex As Exception
            MsgBox("No lo convertio a String por: " + ex.ToString)
        End Try

        Return salida
    End Function
    'Consulta el String que Bytes() almacenados en la base de datos y convierte ese String en un Arreglo de bytes() '
    Function consultaByte(ByVal identificacion As String) As Byte()
        reconectar()
        Dim resultado As String = ""
        Dim x As Integer = 0
        Dim arreglo As Byte() = Nothing
        Dim arregloTexto()
        Try
            enunciado = New SqlCommand("select * from simbolos where sim_str_nombre='" & identificacion & "'", conexion)
            respuesta = enunciado.ExecuteReader()
            While respuesta.Read
                resultado = respuesta.Item("sim_ima_imagen_simbolo")
            End While
            'Llena un arreglo de Texto con los datos de la consulta separados por coma"'
            arregloTexto = resultado.Split(",")
            'Redimenciona el tamaño del arreglo de bytes'
            ReDim arreglo(arregloTexto.Length - 1)
            'Recorre el arreglo para llenar el arreglo de Bytes con el arreglo de la consulta'
            For x = 0 To arregloTexto.Length - 1
                If arregloTexto(x).Equals("") = False Then
                    arreglo(x) = arregloTexto(x)
                End If
            Next
            respuesta.Close()
        Catch ex As Exception
        End Try
        Return arreglo
    End Function
    'Funcion que convierte de Image a Byte()
    Public Function ImagenToBytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        Dim arreglo As Byte() = Nothing
        Try
            If Not Imagen Is Nothing Then
                'variable de datos binarios en stream(flujo)
                Dim Bin As New MemoryStream
                'convertir a bytes
                Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
                'retorna binario
                arreglo = Bin.GetBuffer
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("No ha a seleccionado una imagen")
        End Try
        Return arreglo
    End Function
    Public Function BytesToImagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try

    End Function





    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    'guardar en la base de datos





    'guardar la informacion en la base de datos de la entidad
    Sub botonAgregarEntidad(ByVal tipoEntidad As String, ByVal nombreEntidad As String, ByVal simbolo As String, ByVal pais As String, ByVal empresa As String, ByVal costo As Decimal, ByVal largo As Decimal, ByVal ancho As Decimal, ByVal alto As Decimal, ByVal volumen As Decimal, ByVal peso As Decimal, ByVal tipoMaterial As String, ByVal puntosResistencia As Integer, ByVal cantidadPilotos As Integer, ByVal tiposPilotos As String, ByVal velocidadMin As Decimal, ByVal velocidadMed As Decimal, ByVal velocidadMax As Decimal, ByVal tipoSonido As String, ByVal radioSonido As Decimal, ByVal volumenMax As Decimal, ByVal pesoMax As Decimal, ByVal cantidadPax As Decimal, ByVal radioEntrega As Decimal, ByVal radioRecepcion As Decimal, ByVal tiempoEntrega As Integer, ByVal radioMontar As Decimal, ByVal radioDesmontar As Decimal, ByVal radioArrastre As Decimal, ByVal capacidadArrastreKg As Decimal, ByVal capacidadArrastreM As Decimal, ByVal alturaMin As Decimal, ByVal alturaMed As Decimal, ByVal alturaMax As Decimal, ByVal profundidadMin As Decimal, ByVal profundidadMed As Decimal, ByVal profundidadMax As Decimal, ByVal tipoCombustible As String, ByVal capacidadCombustible As Decimal, ByVal KmL As Decimal, ByVal cantidadSensores As Integer) '
        reconectar()
        Try
            enunciado = New SqlCommand("insert into entidad (ent_str_tipo_entidad, ent_str_nombre_entidad, ent_str_simbolo, ent_str_pais, ent_str_empresa, ent_dec_costo, ent_dec_largo, ent_dec_ancho, ent_dec_alto, ent_dec_volumen, ent_dec_peso, ent_str_tipo_material, ent_int_puntos_resistencia, ent_int_cantidad_pilotos, ent_str_tipos_pilotos, ent_dec_velocidad_min, ent_dec_velocidad_med, ent_dec_velocidad_max, ent_str_tipo_sonido, ent_dec_radio_sonido, ent_dec_volumen_max, ent_dec_peso_max, ent_int_cantidad_pax, ent_dec_radio_entrega, ent_dec_radio_recepcion, ent_int_tiempo_entrega_kg, ent_dec_radio_montar, ent_dec_radio_desmontar, ent_dec_radio_arrastre, ent_dec_capacidad_arrastre_kg, ent_dec_capacidad_arrastre_m, ent_dec_capacidad_altura_min, ent_dec_capacidad_altura_med, ent_dec_capacidad_altura_max, ent_dec_capacidad_profundidad_min, ent_dec_capacidad_profundidad_med, ent_dec_capacidad_profundidad_max, ent_str_tipo_combustible, ent_dec_capacidad_max_combustilble, ent_dec_km_l, ent_int_cantidad_sensores) values('" & tipoEntidad & "','" & nombreEntidad & "','" & simbolo & "','" & pais & "','" & empresa & "'," & costo & "," & largo & "," & ancho & "," & alto & "," & volumen & "," & peso & ",'" & tipoMaterial & "'," & puntosResistencia & "," & cantidadPilotos & ",'" & tiposPilotos & "'," & velocidadMin & "," & velocidadMed & "," & velocidadMax & ",'" & tipoSonido & "'," & radioSonido & "," & volumenMax & "," & pesoMax & "," & cantidadPax & "," & radioEntrega & "," & radioRecepcion & "," & tiempoEntrega & "," & radioMontar & "," & radioDesmontar & "," & radioArrastre & "," & capacidadArrastreKg & "," & capacidadArrastreM & "," & alturaMin & "," & alturaMed & "," & alturaMax & "," & profundidadMin & "," & profundidadMed & "," & profundidadMax & ",'" & tipoCombustible & "'," & capacidadCombustible & "," & KmL & "," & cantidadSensores & ")", conexion) '             
            enunciado.ExecuteNonQuery()
            conexion.Close()
            MsgBox("Se realizo correctamente la insercion", MsgBoxStyle.Information)
        Catch ex As Exception
            conexion.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    'guardar la informacion en la base de datos del arma
    Sub botonAgregarArma(ByVal tipoArma As String, ByVal nombreArma As String, ByVal imagenArma As String, ByVal pais As String, ByVal empresa As String, ByVal costo As Decimal, ByVal longitud As Decimal, ByVal longitudCanon As Decimal, ByVal volumen As Decimal, ByVal peso As Decimal, ByVal calibre As Decimal, ByVal alcanceMax As Decimal, ByVal alcanceMin As Decimal, ByVal velocidadProyectil As String, ByVal tipoCargador As String, ByVal pesoCargador As Decimal, ByVal capacidadMunicion As Integer, ByVal sistemaDisparo As String, ByVal cadenciaTiro As Integer, ByVal tiposMunicion As Integer)
        reconectar()
        Try
            enunciado = New SqlCommand("insert into armas (arm_str_tipo_arma, arm_str_nombre_arma, arm_str_imagen, arm_str_pais, arm_str_empresa, arm_dec_costo, arm_dec_longitud, arm_dec_longitud_canon, arm_dec_volumen, arm_dec_peso, arm_dec_calibre, arm_dec_alcance_max, arm_dec_alcance_min, arm_dec_velocidad_proyectil, arm_str_tipo_cargador, arm_dec_peso_cargador, arm_int_capacidad_municion, arm_str_sistema_disparo, arm_int_cadencia_tiro, arm_cant_tipos_municion) values('" & tipoArma & "','" & nombreArma & "','" & imagenArma & "','" & pais & "','" & empresa & "'," & costo & "," & longitud & "," & longitudCanon & "," & volumen & "," & peso & "," & calibre & "," & alcanceMax & "," & alcanceMin & "," & velocidadProyectil & ",'" & tipoCargador & "'," & pesoCargador & "," & capacidadMunicion & ",'" & sistemaDisparo & "'," & cadenciaTiro & "," & tiposMunicion & ")", conexion)
            enunciado.ExecuteNonQuery()
            conexion.Close()
            MsgBox("Se realizo correctamente la insercion", MsgBoxStyle.Information)
        Catch ex As Exception
            conexion.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    'guardar la informacion en la base de datos de la municion del arma
    Sub botonAgregarMunicionArma(ByVal tipoMunicion As String, ByVal nombreMunicion As String, ByVal idArmas As Integer)
        reconectar()
        Try
            enunciado = New SqlCommand("insert into municion_arma (armm_str_tipo_municion, arr_str_nombre_municion, id_armas) values('" & tipoMunicion & "','" & nombreMunicion & "'," & idArmas & ")", conexion)
            enunciado.ExecuteNonQuery()
            conexion.Close()
            MsgBox("Se realizo correctamente la insercion", MsgBoxStyle.Information)
        Catch ex As Exception
            conexion.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    'permite guardar un escenario en la base de datos
    Sub botonAgregarescenario(ByVal nombreEscenario As String, ByVal Clase As String, ByVal Tipo As String, ByVal Nombre As String, ByVal Bando As String, ByVal latUbicacion As String, ByVal latGrado As Integer, ByVal latMinutos As Integer, ByVal latSegundos As Decimal, ByVal longUbicacion As String, ByVal longGrados As Integer, ByVal longMinutos As Integer, ByVal longSegundo As Decimal)
        reconectar()
        Try
            enunciado = New SqlCommand("insert into crear_escenarios (esc_str_nombre_escenario, esc_str_clase, esc_str_tipo, esc_str_nombre, esc_str_bando, esc_str_lat_ubicacion, esc_int_lat_grados, esc_int_lat_minutos, esc_dec_lat_segundos, esc_str_long_ubicacion, esc_int_long_grados, esc_int_long_minutos, esc_dec_long_segundos) values('" & nombreEscenario & "','" & Clase & "','" & Tipo & "','" & Nombre & "','" & Bando & "','" & latUbicacion & "'," & latGrado & "," & latMinutos & "," & latSegundos & ",'" & longUbicacion & "'," & longGrados & "," & longMinutos & "," & longSegundo & ")", conexion)
            enunciado.ExecuteNonQuery()
            conexion.Close()
            MsgBox("Escenario guardado correctamente", MsgBoxStyle.Information)
        Catch ex As Exception
            conexion.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    'permite guardar un sistema de comunicacion en la base de datos
    Sub botonAgregarComunicacion(ByVal tipoComunicacion As String, ByVal nombreComunicacion As String, ByVal imagen As String, ByVal pais As String, ByVal empresa As String, ByVal costo As Decimal, ByVal largo As Decimal, ByVal ancho As Decimal, ByVal alto As Decimal, ByVal volumen As Decimal, ByVal peso As Decimal, ByVal canalesDesde As Decimal, ByVal canalesHasta As Decimal, ByVal tamanoAntena As Decimal, ByVal cantBateria As Decimal, ByVal tipoCargador As String, ByVal estabilidadFrecuencia As Integer, ByVal potenciaSalida As Decimal, ByVal distorcioAudio As Decimal, ByVal salidaAudio As Decimal, ByVal alcanceMax As Decimal)
        reconectar()
        Try
            enunciado = New SqlCommand("insert into comunicacion (com_str_tipo_comunicacion, com_str_nombre_comunicacion, com_str_imagen, com_str_pais, com_str_empresa, com_dec_costo, com_dec_largo, com_dec_ancho, com_dec_alto, com_dec_volumen, com_dec_peso, com_dec_canales_desde, com_dec_canales_hasta, com_dec_tamano_antena, com_dec_cantidad_baterias, com_str_tipo_cargador, com_int_estabilidad_frecuencia, com_dec_potencia_salida, com_dec_distorcion_audio, com_dec_salida_audio, com_dec_alcance_max) values('" & tipoComunicacion & "','" & nombreComunicacion & "','" & imagen & "','" & pais & "','" & empresa & "'," & costo & "," & largo & "," & ancho & "," & alto & "," & volumen & "," & peso & "," & canalesDesde & "," & canalesHasta & "," & tamanoAntena & "," & cantBateria & ",'" & tipoCargador & "'," & estabilidadFrecuencia & "," & potenciaSalida & "," & distorcioAudio & "," & salidaAudio & "," & alcanceMax & ")", conexion)
            enunciado.ExecuteNonQuery()
            conexion.Close()
            MsgBox("Sistema de comunicacion guardado correctamente", MsgBoxStyle.Information)
        Catch ex As Exception
            conexion.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    'permite guardar un sistema de sensor en la base de datos
    Sub botonAgregarSensor(ByVal tipoSensor As String, ByVal nombreSensor As String, ByVal imagen As String, ByVal pais As String, ByVal empresa As String, ByVal costo As Decimal, ByVal rangoMedida As Decimal, ByVal precision As Integer, ByVal desviacionCero As Decimal, ByVal correcionLinea As Decimal, ByVal sencibilidad As Integer, ByVal resolucion As Integer, ByVal rapidezRespuesta As Integer, ByVal repetitividad As Integer)
        reconectar()
        Try
            enunciado = New SqlCommand("insert into sensor (sen_str_tipo_sensor, sen_str_nombre_sensor, sen_str_imagen, sen_str_pais, sen_str_empresa, sen_dec_costo, sen_dec_rango_mediga, sen_int_precision, sen_dec_desviacion_cero, sen_dec_correccion_linea, sen_int_sencibilidad, sen_int_resolucion, sen_int_rapidez_respuesta, sen_int_repetitividad) values('" & tipoSensor & "','" & nombreSensor & "','" & imagen & "','" & pais & "','" & empresa & "'," & costo & "," & rangoMedida & "," & precision & "," & desviacionCero & "," & correcionLinea & "," & sencibilidad & "," & resolucion & "," & rapidezRespuesta & "," & repetitividad & ")", conexion)
            enunciado.ExecuteNonQuery()
            conexion.Close()
            MsgBox("Sensor guardado correctamente", MsgBoxStyle.Information)
        Catch ex As Exception
            conexion.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    'permite guardar una municion en la base de datos
    Sub botonAgregarMunicion(ByVal tipoMunicion As String, ByVal nombreMunicion As String, ByVal imagen As String, ByVal pais As String, ByVal empresa As String, ByVal costo As Decimal, ByVal longitud As Decimal, ByVal diametro As Decimal, ByVal volumen As Decimal, ByVal calibre As Decimal, ByVal peso As Decimal, ByVal nivelDano As Integer, ByVal alcanceEfectivo As Decimal, ByVal alcanceMaximo As Decimal, ByVal radioAccion As Decimal)
        reconectar()
        Try
            enunciado = New SqlCommand("insert into municiones (mun_str_tipo_municion, mun_str_nombre_municion, mun_str_imagen, mun_str_pais, mun_str_Empresa, mun_dec_costo, mun_dec_longitud, mun_dec_diametro, mun_dec_volumen, mun_dec_calibre, mun_dec_peso, mun_int_nivel_dano, mun_dec_alcance_efectivo, mun_dec_alcance_maximo, mun_dec_radio_accion) values('" & tipoMunicion & "','" & nombreMunicion & "','" & imagen & "','" & pais & "','" & empresa & "'," & costo & "," & longitud & "," & diametro & "," & volumen & "," & calibre & "," & peso & "," & nivelDano & "," & alcanceEfectivo & "," & alcanceMaximo & "," & radioAccion & ")", conexion)
            enunciado.ExecuteNonQuery()
            conexion.Close()
            MsgBox("Municion guardada correctamente", MsgBoxStyle.Information)
        Catch ex As Exception
            conexion.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
End Module
