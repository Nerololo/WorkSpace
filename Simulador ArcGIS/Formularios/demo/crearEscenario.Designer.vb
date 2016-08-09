<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class crearEscenario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextNombreEscenario = New System.Windows.Forms.TextBox()
        Me.ListCrear = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListTipo = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListNombre = New System.Windows.Forms.ListBox()
        Me.Bando = New System.Windows.Forms.Label()
        Me.ListBando = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextLatitudGrados = New System.Windows.Forms.TextBox()
        Me.TextlongitudGrados = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tablaDatos = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextLatitudMin = New System.Windows.Forms.TextBox()
        Me.TextLatitudSeg = New System.Windows.Forms.TextBox()
        Me.TextLongitudMin = New System.Windows.Forms.TextBox()
        Me.TextLongitudSeg = New System.Windows.Forms.TextBox()
        Me.ubicacionLat = New System.Windows.Forms.ComboBox()
        Me.ubicacionLong = New System.Windows.Forms.ComboBox()
        CType(Me.tablaDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(457, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Crear Escenario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(80, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "nombre del Escenario"
        '
        'TextNombreEscenario
        '
        Me.TextNombreEscenario.Location = New System.Drawing.Point(301, 76)
        Me.TextNombreEscenario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextNombreEscenario.Name = "TextNombreEscenario"
        Me.TextNombreEscenario.Size = New System.Drawing.Size(280, 22)
        Me.TextNombreEscenario.TabIndex = 2
        '
        'ListCrear
        '
        Me.ListCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListCrear.FormattingEnabled = True
        Me.ListCrear.ItemHeight = 25
        Me.ListCrear.Items.AddRange(New Object() {"Entidades", "Armas", "Municion", "Sensores", "Proteccion", "Sistema de Comunicacion"})
        Me.ListCrear.Location = New System.Drawing.Point(49, 158)
        Me.ListCrear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListCrear.Name = "ListCrear"
        Me.ListCrear.Size = New System.Drawing.Size(259, 154)
        Me.ListCrear.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(381, 126)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tipo "
        '
        'ListTipo
        '
        Me.ListTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListTipo.FormattingEnabled = True
        Me.ListTipo.ItemHeight = 25
        Me.ListTipo.Location = New System.Drawing.Point(387, 158)
        Me.ListTipo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListTipo.Name = "ListTipo"
        Me.ListTipo.Size = New System.Drawing.Size(325, 204)
        Me.ListTipo.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(776, 126)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nombre"
        '
        'ListNombre
        '
        Me.ListNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListNombre.ForeColor = System.Drawing.Color.Black
        Me.ListNombre.FormattingEnabled = True
        Me.ListNombre.ItemHeight = 25
        Me.ListNombre.Location = New System.Drawing.Point(781, 158)
        Me.ListNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListNombre.Name = "ListNombre"
        Me.ListNombre.Size = New System.Drawing.Size(325, 204)
        Me.ListNombre.TabIndex = 7
        '
        'Bando
        '
        Me.Bando.AutoSize = True
        Me.Bando.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bando.ForeColor = System.Drawing.Color.Black
        Me.Bando.Location = New System.Drawing.Point(1168, 126)
        Me.Bando.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Bando.Name = "Bando"
        Me.Bando.Size = New System.Drawing.Size(58, 24)
        Me.Bando.TabIndex = 8
        Me.Bando.Text = "Bando"
        '
        'ListBando
        '
        Me.ListBando.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBando.FormattingEnabled = True
        Me.ListBando.ItemHeight = 25
        Me.ListBando.Items.AddRange(New Object() {"Neutral", "Amigo", "Enemigo", "Desconocido"})
        Me.ListBando.Location = New System.Drawing.Point(1173, 158)
        Me.ListBando.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBando.Name = "ListBando"
        Me.ListBando.Size = New System.Drawing.Size(259, 79)
        Me.ListBando.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(1168, 281)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Coordenadas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(1168, 311)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Lat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(1168, 361)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 24)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Long."
        '
        'TextLatitudGrados
        '
        Me.TextLatitudGrados.Location = New System.Drawing.Point(1319, 314)
        Me.TextLatitudGrados.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextLatitudGrados.Name = "TextLatitudGrados"
        Me.TextLatitudGrados.Size = New System.Drawing.Size(76, 22)
        Me.TextLatitudGrados.TabIndex = 13
        '
        'TextlongitudGrados
        '
        Me.TextlongitudGrados.Location = New System.Drawing.Point(1319, 363)
        Me.TextlongitudGrados.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextlongitudGrados.Name = "TextlongitudGrados"
        Me.TextlongitudGrados.Size = New System.Drawing.Size(76, 22)
        Me.TextlongitudGrados.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1239, 395)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(281, 36)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Crear Escenario"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tablaDatos
        '
        Me.tablaDatos.AllowUserToAddRows = False
        Me.tablaDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tablaDatos.BackgroundColor = System.Drawing.Color.White
        Me.tablaDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tablaDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaDatos.ColumnHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tablaDatos.DefaultCellStyle = DataGridViewCellStyle2
        Me.tablaDatos.Location = New System.Drawing.Point(49, 475)
        Me.tablaDatos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tablaDatos.MultiSelect = False
        Me.tablaDatos.Name = "tablaDatos"
        Me.tablaDatos.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tablaDatos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.tablaDatos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.tablaDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tablaDatos.Size = New System.Drawing.Size(1267, 229)
        Me.tablaDatos.TabIndex = 21
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1324, 668)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(281, 36)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Guardar Escenario"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1324, 628)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(273, 33)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Atras"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextLatitudMin
        '
        Me.TextLatitudMin.Location = New System.Drawing.Point(1404, 314)
        Me.TextLatitudMin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextLatitudMin.Name = "TextLatitudMin"
        Me.TextLatitudMin.Size = New System.Drawing.Size(76, 22)
        Me.TextLatitudMin.TabIndex = 24
        '
        'TextLatitudSeg
        '
        Me.TextLatitudSeg.Location = New System.Drawing.Point(1489, 314)
        Me.TextLatitudSeg.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextLatitudSeg.Name = "TextLatitudSeg"
        Me.TextLatitudSeg.Size = New System.Drawing.Size(76, 22)
        Me.TextLatitudSeg.TabIndex = 25
        '
        'TextLongitudMin
        '
        Me.TextLongitudMin.Location = New System.Drawing.Point(1404, 363)
        Me.TextLongitudMin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextLongitudMin.Name = "TextLongitudMin"
        Me.TextLongitudMin.Size = New System.Drawing.Size(76, 22)
        Me.TextLongitudMin.TabIndex = 26
        '
        'TextLongitudSeg
        '
        Me.TextLongitudSeg.Location = New System.Drawing.Point(1489, 363)
        Me.TextLongitudSeg.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextLongitudSeg.Name = "TextLongitudSeg"
        Me.TextLongitudSeg.Size = New System.Drawing.Size(76, 22)
        Me.TextLongitudSeg.TabIndex = 27
        '
        'ubicacionLat
        '
        Me.ubicacionLat.FormattingEnabled = True
        Me.ubicacionLat.Items.AddRange(New Object() {"Norte ", "Sur"})
        Me.ubicacionLat.Location = New System.Drawing.Point(1248, 315)
        Me.ubicacionLat.Name = "ubicacionLat"
        Me.ubicacionLat.Size = New System.Drawing.Size(68, 24)
        Me.ubicacionLat.TabIndex = 28
        '
        'ubicacionLong
        '
        Me.ubicacionLong.FormattingEnabled = True
        Me.ubicacionLong.Items.AddRange(New Object() {"Este", "Oeste"})
        Me.ubicacionLong.Location = New System.Drawing.Point(1248, 361)
        Me.ubicacionLong.Name = "ubicacionLong"
        Me.ubicacionLong.Size = New System.Drawing.Size(68, 24)
        Me.ubicacionLong.TabIndex = 29
        '
        'crearEscenario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1613, 735)
        Me.ControlBox = False
        Me.Controls.Add(Me.ubicacionLong)
        Me.Controls.Add(Me.ubicacionLat)
        Me.Controls.Add(Me.TextLongitudSeg)
        Me.Controls.Add(Me.TextLongitudMin)
        Me.Controls.Add(Me.TextLatitudSeg)
        Me.Controls.Add(Me.TextLatitudMin)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.tablaDatos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextlongitudGrados)
        Me.Controls.Add(Me.TextLatitudGrados)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListBando)
        Me.Controls.Add(Me.Bando)
        Me.Controls.Add(Me.ListNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListTipo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListCrear)
        Me.Controls.Add(Me.TextNombreEscenario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "crearEscenario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "crearEscenario"
        CType(Me.tablaDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextNombreEscenario As TextBox
    Friend WithEvents ListCrear As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ListTipo As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ListNombre As ListBox
    Friend WithEvents Bando As Label
    Friend WithEvents ListBando As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextLatitudGrados As TextBox
    Friend WithEvents TextlongitudGrados As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents tablaDatos As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextLatitudMin As TextBox
    Friend WithEvents TextLatitudSeg As TextBox
    Friend WithEvents TextLongitudMin As TextBox
    Friend WithEvents TextLongitudSeg As TextBox
    Friend WithEvents ubicacionLat As ComboBox
    Friend WithEvents ubicacionLong As ComboBox
End Class
