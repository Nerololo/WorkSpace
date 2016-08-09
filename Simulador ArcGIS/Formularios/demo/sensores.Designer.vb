<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form9
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
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCargarImagen = New System.Windows.Forms.Button()
        Me.PictureImagenSensor = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboTipoSensor = New System.Windows.Forms.ComboBox()
        Me.TextNombreSensor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureImagenSensor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.ForeColor = System.Drawing.Color.Black
        Me.btnAtras.Location = New System.Drawing.Point(413, 323)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(116, 33)
        Me.btnAtras.TabIndex = 110
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.ForeColor = System.Drawing.Color.Black
        Me.btnSiguiente.Location = New System.Drawing.Point(546, 323)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(116, 33)
        Me.btnSiguiente.TabIndex = 109
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(48, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 20)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Imagen de sensores"
        '
        'btnCargarImagen
        '
        Me.btnCargarImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarImagen.ForeColor = System.Drawing.Color.Black
        Me.btnCargarImagen.Location = New System.Drawing.Point(367, 224)
        Me.btnCargarImagen.Name = "btnCargarImagen"
        Me.btnCargarImagen.Size = New System.Drawing.Size(183, 33)
        Me.btnCargarImagen.TabIndex = 107
        Me.btnCargarImagen.Text = "Cargar imagen"
        Me.btnCargarImagen.UseVisualStyleBackColor = True
        '
        'PictureImagenSensor
        '
        Me.PictureImagenSensor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureImagenSensor.Location = New System.Drawing.Point(269, 211)
        Me.PictureImagenSensor.Name = "PictureImagenSensor"
        Me.PictureImagenSensor.Size = New System.Drawing.Size(92, 68)
        Me.PictureImagenSensor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureImagenSensor.TabIndex = 106
        Me.PictureImagenSensor.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(72, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 20)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Tipo de sensores"
        '
        'ComboTipoSensor
        '
        Me.ComboTipoSensor.FormattingEnabled = True
        Me.ComboTipoSensor.Location = New System.Drawing.Point(269, 125)
        Me.ComboTipoSensor.Name = "ComboTipoSensor"
        Me.ComboTipoSensor.Size = New System.Drawing.Size(281, 21)
        Me.ComboTipoSensor.TabIndex = 104
        '
        'TextNombreSensor
        '
        Me.TextNombreSensor.Location = New System.Drawing.Point(269, 180)
        Me.TextNombreSensor.Name = "TextNombreSensor"
        Me.TextNombreSensor.Size = New System.Drawing.Size(281, 20)
        Me.TextNombreSensor.TabIndex = 103
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(46, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 20)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Nombre de sensores"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.Color.Black
        Me.Label.Location = New System.Drawing.Point(227, 18)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(191, 24)
        Me.Label.TabIndex = 101
        Me.Label.Text = "Editor De Sensores"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form9
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(708, 375)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCargarImagen)
        Me.Controls.Add(Me.PictureImagenSensor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboTipoSensor)
        Me.Controls.Add(Me.TextNombreSensor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form9"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sensores"
        CType(Me.PictureImagenSensor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAtras As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCargarImagen As Button
    Friend WithEvents PictureImagenSensor As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboTipoSensor As ComboBox
    Friend WithEvents TextNombreSensor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
