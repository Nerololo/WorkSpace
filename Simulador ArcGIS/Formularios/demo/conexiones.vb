Imports System.Data.SqlClient
Module conexiones
    'permite saber que dato de la tabla a sido tomado 
    Public campollave As String
    Public tipoEntidad As String, nombreEntidad As String
    'se encarga de realizar la conexion
    Public conexion As SqlConnection
    'se encarga de permitir realizar sentencias sql 
    Public enunciado As SqlCommand
    'se encarga de permitir correr los registros de una consulta
    Public respuesta As SqlDataReader
    Sub abrir()
        Try
            conexion = New SqlConnection("Data Source=BRYAN\SQLEXPRESS;Initial Catalog=demo;Integrated Security=True")
            conexion.Open()
        Catch ex As Exception

        End Try
    End Sub
    Sub reconectar()
        conexion.Close()
        conexion.Open()
    End Sub
    'mostrar la tabla en una datagridview
    Sub conectarTabla(ByVal tablaDatos As DataGridView, ByVal tabla As String, ByVal columna As String)
        Dim dt As New DataTable
        Dim adaptador As New SqlDataAdapter("select " & columna & " from " & tabla, conexion)
        adaptador.Fill(dt)
        tablaDatos.DataSource = dt
    End Sub
    'mostrar la tabla en una datagridview con algunas columnas
    Sub conectarTablaColumnas(ByVal tablaDatos As DataGridView, ByVal texto As TextBox)
        Dim dt As New DataTable
        Dim adaptador As New SqlDataAdapter("select esc_str_crear, esc_str_tipo, esc_str_nombre, esc_str_bando, esc_int_latitud_grados, esc_int_latitud_minutos, esc_dec_latitud_segundos, esc_int_longitud_grados, esc_int_longitud_minutos, esc_dec_longitud_segundos from crear_escenario where esc_str_nombre_escenario= '" & texto.Text & "'", conexion)
        adaptador.Fill(dt)
        tablaDatos.DataSource = dt
    End Sub
    'permite agregar un dato a una gridview
    Sub botonAgregar(ByVal tabla As String, ByVal columna As String, ByVal tipo As String)

        Dim nuevoTipoEntidad As String
        nuevoTipoEntidad = InputBox("Ingresa el nuevo tipo de " & tipo, "Nuevo tipo de " & tipo)
        reconectar()
        If nuevoTipoEntidad = "" Then
            Exit Sub
        Else
            Try
                enunciado = New SqlCommand("insert into " & tabla & " (" & columna & ") values('" & nuevoTipoEntidad & "')", conexion)
                enunciado.ExecuteNonQuery()
                conexion.Close()
                MsgBox("Tipo de " & tipo & " guardado correctamente", MsgBoxStyle.Information)
            Catch ex As Exception
                conexion.Close()
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try

        End If

    End Sub
    'permite editar una fila de la datagridview
    Public Sub botonEditar(ByVal editador As TextBox, ByVal tablaDeDatos As DataGridView, ByVal texto As String, ByVal tipo As String, ByVal tabla As String, ByVal columna As String)
        reconectar()
        If editador.Text = "" Or editador.Enabled = False Then
            Exit Sub
        Else
            Dim preguntaConfirmacion As String = MsgBox("se encuentra seguro que quiere editar este tipo de " & tipo, MsgBoxStyle.YesNo, "")
            If preguntaConfirmacion = vbYes Then
                Try
                    enunciado = New SqlCommand("UPDATE " & tabla & " SET " & columna & "='" & editador.Text & "' WHERE " & columna & "='" & texto & "'", conexion)
                    enunciado.ExecuteNonQuery()
                    conexion.Close()
                    MsgBox("La edicion del tipo de " & tipo & " se realizo correctamente", MsgBoxStyle.Information)
                    editador.Enabled = False
                Catch ex As Exception
                    conexion.Close()
                    MsgBox(ex.Message, MsgBoxStyle.Information)
                End Try
            Else
                Exit Sub
            End If
        End If
        Return

    End Sub

    '  elimina una fila de la gridview
    Public Sub eliminare(ByVal tablaDeDatos As DataGridView, ByVal texto As String, ByVal tipo As String, ByVal tabla As String, ByVal columna As String)
        reconectar()
        Dim preguntaConfirmacion As String = MsgBox("se encuentra seguro que quiere eliminar este tipo de " & tipo, MsgBoxStyle.YesNo, "")
        If preguntaConfirmacion = vbYes Then
            Try
                enunciado = New SqlCommand("DELETE FROM " & tabla & " WHERE " & columna & "='" & texto & "'", conexion)
                enunciado.ExecuteNonQuery()
                conexion.Close()
                MsgBox("la eliminacion del tipo de " & tipo & " se realizo correctamente", MsgBoxStyle.Information)

            Catch ex As Exception
                conexion.Close()

                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try
        Else
            Exit Sub
        End If
    End Sub
    'mostrar una columna de una tabla de la base de datos en un combobox
    Sub conectarCombobox(ByVal combo As ComboBox, ByVal tabla As String, ByVal columna As String)
        Dim dt As New DataTable
        Dim adaptador As New SqlDataAdapter("select * from " & tabla, conexion)
        adaptador.Fill(dt)
        combo.DataSource = dt
        combo.DisplayMember = columna
    End Sub
    'Guardar la identificacion y la imagen de un tipo de simbolo 
    Function insertarImagen(ByVal tipo As String, ByVal nombre As String, ByVal imagen As String) As String
        Dim resultado As String = ""
        reconectar()
        Try
            enunciado = New SqlCommand("insert into simbolos (sim_str_tipo_simbolo, sim_str_nombre, sim_ima_imagen_simbolo) values('" & tipo & "','" & nombre & "','" & imagen & "')", conexion)
            enunciado.ExecuteNonQuery()
            resultado = "Se realizo correctamente la insercion"
            conexion.Close()

        Catch ex As Exception
            resultado = "No se pudo realizar el registro de manera correcta" + ex.ToString
            conexion.Close()

        End Try
        Return resultado
    End Function
    'mostrar una columna de una tabla de la base de datos en el combobox 
    Sub simboloCombobox(ByVal combo As ComboBox, ByVal tabla As String, ByVal columna As String)
        Dim dt As New DataTable
        Dim adaptador As New SqlDataAdapter("select * from " & tabla, conexion)
        adaptador.Fill(dt)
        combo.DataSource = dt
        combo.DisplayMember = columna
    End Sub
    'mostrar una columna de una tabla de la base de datos en un combobox con una condicion 
    Sub condicionCombobox(ByVal combo As ComboBox, ByVal tabla As String, ByVal columnaEvaluar As String, ByVal opcionBusqueda As String, ByVal columnaMostrar As String)
        Dim dt As New DataTable
        Dim adaptador As New SqlDataAdapter("select * from " & tabla & " Where " & columnaEvaluar & "= '" & opcionBusqueda & "'", conexion)
        adaptador.Fill(dt)
        combo.DataSource = dt
        combo.DisplayMember = columnaMostrar
    End Sub
    'mostrar una columna de una tabla de la base de datos en el listbox
    Sub escojeList(ByVal list As ListBox, ByVal tabla As String, ByVal columna As String)
        Dim dt As New DataTable
        Dim adaptador As New SqlDataAdapter("select * from " & tabla, conexion)
        adaptador.Fill(dt)
        list.DataSource = dt
        list.DisplayMember = columna
    End Sub
    'mostrar una columna de una tabla de la base de datos en un combobox con una condicion 
    Sub condicionLisbox(ByVal lista As ListBox, ByVal tabla As String, ByVal columnaEvaluar As String, ByVal opcionBusqueda As String, ByVal columnaMostrar As String)
        Dim dt As New DataTable
        Dim adaptador As New SqlDataAdapter("select * from " & tabla & " Where " & columnaEvaluar & "= '" & opcionBusqueda & "'", conexion)
        adaptador.Fill(dt)
        lista.DataSource = dt
        lista.DisplayMember = columnaMostrar
    End Sub
End Module
