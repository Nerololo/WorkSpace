<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureSensor = New System.Windows.Forms.PictureBox()
        Me.LabelNombreSensor = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelTipoSensor = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextRepetitividad = New System.Windows.Forms.TextBox()
        Me.ComboResolucion = New System.Windows.Forms.ComboBox()
        Me.TextRapidezRespuesta = New System.Windows.Forms.TextBox()
        Me.TextSensibilidad = New System.Windows.Forms.TextBox()
        Me.TextCorrecionLineal = New System.Windows.Forms.TextBox()
        Me.TextDesviacionCero = New System.Windows.Forms.TextBox()
        Me.TextPrecision = New System.Windows.Forms.TextBox()
        Me.TextRangoMedida = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.TextCosto = New System.Windows.Forms.TextBox()
        Me.TextEmpresa = New System.Windows.Forms.TextBox()
        Me.TextPais = New System.Windows.Forms.TextBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureSensor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnAtras)
        Me.Panel1.Controls.Add(Me.BtnGuardar)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1166, 465)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(495, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 20)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "Editor De Sensores"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(477, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 20)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Características Técnicas"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.PictureSensor)
        Me.Panel2.Controls.Add(Me.LabelNombreSensor)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.LabelTipoSensor)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(322, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(497, 154)
        Me.Panel2.TabIndex = 108
        '
        'PictureSensor
        '
        Me.PictureSensor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureSensor.Location = New System.Drawing.Point(200, 15)
        Me.PictureSensor.Name = "PictureSensor"
        Me.PictureSensor.Size = New System.Drawing.Size(92, 68)
        Me.PictureSensor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureSensor.TabIndex = 83
        Me.PictureSensor.TabStop = False
        '
        'LabelNombreSensor
        '
        Me.LabelNombreSensor.AutoSize = True
        Me.LabelNombreSensor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombreSensor.ForeColor = System.Drawing.Color.Black
        Me.LabelNombreSensor.Location = New System.Drawing.Point(264, 106)
        Me.LabelNombreSensor.Name = "LabelNombreSensor"
        Me.LabelNombreSensor.Size = New System.Drawing.Size(14, 20)
        Me.LabelNombreSensor.TabIndex = 89
        Me.LabelNombreSensor.Text = "."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(90, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 20)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Nombre de sensor."
        '
        'LabelTipoSensor
        '
        Me.LabelTipoSensor.AutoSize = True
        Me.LabelTipoSensor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTipoSensor.ForeColor = System.Drawing.Color.Black
        Me.LabelTipoSensor.Location = New System.Drawing.Point(264, 86)
        Me.LabelTipoSensor.Name = "LabelTipoSensor"
        Me.LabelTipoSensor.Size = New System.Drawing.Size(14, 20)
        Me.LabelTipoSensor.TabIndex = 88
        Me.LabelTipoSensor.Text = "."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(116, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 20)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Tipo de sensor."
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.ForeColor = System.Drawing.Color.Black
        Me.btnAtras.Location = New System.Drawing.Point(825, 134)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(116, 33)
        Me.btnAtras.TabIndex = 107
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.Black
        Me.BtnGuardar.Location = New System.Drawing.Point(825, 173)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(145, 33)
        Me.BtnGuardar.TabIndex = 106
        Me.BtnGuardar.Text = "Guardar Sensor"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(121, 25)
        Me.TabControl1.Location = New System.Drawing.Point(9, 219)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1143, 235)
        Me.TabControl1.TabIndex = 105
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.Panel10)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1135, 202)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Características de sensor"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.TextRepetitividad)
        Me.Panel3.Controls.Add(Me.ComboResolucion)
        Me.Panel3.Controls.Add(Me.TextRapidezRespuesta)
        Me.Panel3.Controls.Add(Me.TextSensibilidad)
        Me.Panel3.Controls.Add(Me.TextCorrecionLineal)
        Me.Panel3.Controls.Add(Me.TextDesviacionCero)
        Me.Panel3.Controls.Add(Me.TextPrecision)
        Me.Panel3.Controls.Add(Me.TextRangoMedida)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(300, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(829, 191)
        Me.Panel3.TabIndex = 113
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(765, 53)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(19, 13)
        Me.Label18.TabIndex = 120
        Me.Label18.Text = "N°"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(301, 131)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(18, 15)
        Me.Label16.TabIndex = 119
        Me.Label16.Text = "%"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(301, 79)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(19, 13)
        Me.Label20.TabIndex = 118
        Me.Label20.Text = "N°"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(301, 53)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(15, 13)
        Me.Label15.TabIndex = 117
        Me.Label15.Text = "%"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(301, 27)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(20, 13)
        Me.Label17.TabIndex = 116
        Me.Label17.Text = "Kg"
        '
        'TextRepetitividad
        '
        Me.TextRepetitividad.BackColor = System.Drawing.Color.Gainsboro
        Me.TextRepetitividad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextRepetitividad.ForeColor = System.Drawing.Color.Black
        Me.TextRepetitividad.Location = New System.Drawing.Point(644, 51)
        Me.TextRepetitividad.Name = "TextRepetitividad"
        Me.TextRepetitividad.Size = New System.Drawing.Size(115, 20)
        Me.TextRepetitividad.TabIndex = 115
        '
        'ComboResolucion
        '
        Me.ComboResolucion.BackColor = System.Drawing.Color.Gainsboro
        Me.ComboResolucion.FormattingEnabled = True
        Me.ComboResolucion.Items.AddRange(New Object() {"1", "2", "4", "8", "12", "20", "30"})
        Me.ComboResolucion.Location = New System.Drawing.Point(180, 152)
        Me.ComboResolucion.Name = "ComboResolucion"
        Me.ComboResolucion.Size = New System.Drawing.Size(115, 21)
        Me.ComboResolucion.TabIndex = 114
        '
        'TextRapidezRespuesta
        '
        Me.TextRapidezRespuesta.BackColor = System.Drawing.Color.Gainsboro
        Me.TextRapidezRespuesta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextRapidezRespuesta.Location = New System.Drawing.Point(644, 22)
        Me.TextRapidezRespuesta.Name = "TextRapidezRespuesta"
        Me.TextRapidezRespuesta.Size = New System.Drawing.Size(115, 20)
        Me.TextRapidezRespuesta.TabIndex = 113
        '
        'TextSensibilidad
        '
        Me.TextSensibilidad.BackColor = System.Drawing.Color.Gainsboro
        Me.TextSensibilidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextSensibilidad.Location = New System.Drawing.Point(180, 126)
        Me.TextSensibilidad.Name = "TextSensibilidad"
        Me.TextSensibilidad.Size = New System.Drawing.Size(115, 20)
        Me.TextSensibilidad.TabIndex = 112
        '
        'TextCorrecionLineal
        '
        Me.TextCorrecionLineal.BackColor = System.Drawing.Color.Gainsboro
        Me.TextCorrecionLineal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextCorrecionLineal.Location = New System.Drawing.Point(180, 100)
        Me.TextCorrecionLineal.Name = "TextCorrecionLineal"
        Me.TextCorrecionLineal.Size = New System.Drawing.Size(115, 20)
        Me.TextCorrecionLineal.TabIndex = 111
        '
        'TextDesviacionCero
        '
        Me.TextDesviacionCero.BackColor = System.Drawing.Color.Gainsboro
        Me.TextDesviacionCero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextDesviacionCero.Location = New System.Drawing.Point(180, 74)
        Me.TextDesviacionCero.Name = "TextDesviacionCero"
        Me.TextDesviacionCero.Size = New System.Drawing.Size(115, 20)
        Me.TextDesviacionCero.TabIndex = 110
        '
        'TextPrecision
        '
        Me.TextPrecision.BackColor = System.Drawing.Color.Gainsboro
        Me.TextPrecision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextPrecision.Location = New System.Drawing.Point(180, 48)
        Me.TextPrecision.Name = "TextPrecision"
        Me.TextPrecision.Size = New System.Drawing.Size(115, 20)
        Me.TextPrecision.TabIndex = 109
        '
        'TextRangoMedida
        '
        Me.TextRangoMedida.BackColor = System.Drawing.Color.Gainsboro
        Me.TextRangoMedida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextRangoMedida.Location = New System.Drawing.Point(180, 22)
        Me.TextRangoMedida.Name = "TextRangoMedida"
        Me.TextRangoMedida.Size = New System.Drawing.Size(115, 20)
        Me.TextRangoMedida.TabIndex = 108
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(521, 54)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 20)
        Me.Label14.TabIndex = 97
        Me.Label14.Text = "Repetitividad"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(464, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(165, 20)
        Me.Label13.TabIndex = 96
        Me.Label13.Text = "Rapidez de respuesta"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(75, 152)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 20)
        Me.Label12.TabIndex = 95
        Me.Label12.Text = "Resolución"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(69, 126)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 20)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = "Sensibilidad"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(46, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 20)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Correción lineal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(24, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 20)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Desviación de cero"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(87, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 20)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Precisión"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(33, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 20)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Rango de medida"
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel10.Controls.Add(Me.Label64)
        Me.Panel10.Controls.Add(Me.TextCosto)
        Me.Panel10.Controls.Add(Me.TextEmpresa)
        Me.Panel10.Controls.Add(Me.TextPais)
        Me.Panel10.Controls.Add(Me.Label65)
        Me.Panel10.Controls.Add(Me.Label66)
        Me.Panel10.Controls.Add(Me.Label67)
        Me.Panel10.Controls.Add(Me.Label68)
        Me.Panel10.Location = New System.Drawing.Point(6, 6)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(288, 136)
        Me.Panel10.TabIndex = 112
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(233, 97)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(43, 13)
        Me.Label64.TabIndex = 107
        Me.Label64.Text = "Dólares"
        '
        'TextCosto
        '
        Me.TextCosto.BackColor = System.Drawing.Color.Gainsboro
        Me.TextCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextCosto.Location = New System.Drawing.Point(113, 91)
        Me.TextCosto.Name = "TextCosto"
        Me.TextCosto.Size = New System.Drawing.Size(115, 20)
        Me.TextCosto.TabIndex = 105
        '
        'TextEmpresa
        '
        Me.TextEmpresa.BackColor = System.Drawing.Color.Gainsboro
        Me.TextEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextEmpresa.Location = New System.Drawing.Point(113, 63)
        Me.TextEmpresa.Name = "TextEmpresa"
        Me.TextEmpresa.Size = New System.Drawing.Size(115, 20)
        Me.TextEmpresa.TabIndex = 104
        '
        'TextPais
        '
        Me.TextPais.BackColor = System.Drawing.Color.Gainsboro
        Me.TextPais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextPais.Location = New System.Drawing.Point(113, 34)
        Me.TextPais.Name = "TextPais"
        Me.TextPais.Size = New System.Drawing.Size(115, 20)
        Me.TextPais.TabIndex = 103
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.Color.Black
        Me.Label65.Location = New System.Drawing.Point(21, 66)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(73, 20)
        Me.Label65.TabIndex = 102
        Me.Label65.Text = "Empresa"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.Color.Black
        Me.Label66.Location = New System.Drawing.Point(41, 94)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(51, 20)
        Me.Label66.TabIndex = 90
        Me.Label66.Text = "Costo"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.Color.Black
        Me.Label67.Location = New System.Drawing.Point(50, 35)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(39, 20)
        Me.Label67.TabIndex = 89
        Me.Label67.Text = "País"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.Color.Black
        Me.Label68.Location = New System.Drawing.Point(61, 1)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(141, 20)
        Me.Label68.TabIndex = 88
        Me.Label68.Text = "Casa Fabricante"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(303, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "Pixel"
        '
        'Form10
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1166, 465)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form10"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sensores2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureSensor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureSensor As PictureBox
    Friend WithEvents LabelNombreSensor As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelTipoSensor As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAtras As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label64 As Label
    Friend WithEvents TextCosto As TextBox
    Friend WithEvents TextEmpresa As TextBox
    Friend WithEvents TextPais As TextBox
    Friend WithEvents Label65 As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents TextRapidezRespuesta As TextBox
    Friend WithEvents TextSensibilidad As TextBox
    Friend WithEvents TextCorrecionLineal As TextBox
    Friend WithEvents TextDesviacionCero As TextBox
    Friend WithEvents TextPrecision As TextBox
    Friend WithEvents TextRangoMedida As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextRepetitividad As TextBox
    Friend WithEvents ComboResolucion As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label1 As Label
End Class
