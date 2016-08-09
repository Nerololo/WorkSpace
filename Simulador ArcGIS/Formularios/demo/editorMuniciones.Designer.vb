<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCargarImagen = New System.Windows.Forms.Button()
        Me.PictureMunicion = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboTipoMunicion = New System.Windows.Forms.ComboBox()
        Me.TextNombreMunicion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnSiguiente = New System.Windows.Forms.Button()
        CType(Me.PictureMunicion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.ForeColor = System.Drawing.Color.Black
        Me.btnAtras.Location = New System.Drawing.Point(413, 323)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(116, 33)
        Me.btnAtras.TabIndex = 100
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(48, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 20)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "Imagen de municion"
        '
        'btnCargarImagen
        '
        Me.btnCargarImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarImagen.ForeColor = System.Drawing.Color.Black
        Me.btnCargarImagen.Location = New System.Drawing.Point(367, 224)
        Me.btnCargarImagen.Name = "btnCargarImagen"
        Me.btnCargarImagen.Size = New System.Drawing.Size(183, 33)
        Me.btnCargarImagen.TabIndex = 97
        Me.btnCargarImagen.Text = "Cargar imagen"
        Me.btnCargarImagen.UseVisualStyleBackColor = True
        '
        'PictureMunicion
        '
        Me.PictureMunicion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureMunicion.Location = New System.Drawing.Point(269, 211)
        Me.PictureMunicion.Name = "PictureMunicion"
        Me.PictureMunicion.Size = New System.Drawing.Size(92, 68)
        Me.PictureMunicion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureMunicion.TabIndex = 96
        Me.PictureMunicion.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(72, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 20)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "Tipo de municion"
        '
        'ComboTipoMunicion
        '
        Me.ComboTipoMunicion.FormattingEnabled = True
        Me.ComboTipoMunicion.Location = New System.Drawing.Point(269, 125)
        Me.ComboTipoMunicion.Name = "ComboTipoMunicion"
        Me.ComboTipoMunicion.Size = New System.Drawing.Size(281, 21)
        Me.ComboTipoMunicion.TabIndex = 94
        '
        'TextNombreMunicion
        '
        Me.TextNombreMunicion.Location = New System.Drawing.Point(269, 180)
        Me.TextNombreMunicion.Name = "TextNombreMunicion"
        Me.TextNombreMunicion.Size = New System.Drawing.Size(281, 20)
        Me.TextNombreMunicion.TabIndex = 93
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(46, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 20)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Nombre de municion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(227, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 24)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Editor De Municiones"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSiguiente.ForeColor = System.Drawing.Color.Black
        Me.BtnSiguiente.Location = New System.Drawing.Point(546, 323)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(116, 33)
        Me.BtnSiguiente.TabIndex = 99
        Me.BtnSiguiente.Text = "Siguiente"
        Me.BtnSiguiente.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(708, 375)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.BtnSiguiente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCargarImagen)
        Me.Controls.Add(Me.PictureMunicion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboTipoMunicion)
        Me.Controls.Add(Me.TextNombreMunicion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Municiones"
        CType(Me.PictureMunicion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAtras As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCargarImagen As Button
    Friend WithEvents PictureMunicion As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboTipoMunicion As ComboBox
    Friend WithEvents TextNombreMunicion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BtnSiguiente As Button
End Class
