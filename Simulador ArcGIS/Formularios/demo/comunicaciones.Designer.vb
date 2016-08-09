<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form20
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
        Me.PictureComunicacion = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboTipoComunicacion = New System.Windows.Forms.ComboBox()
        Me.TextNombreComunicacion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureComunicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.ForeColor = System.Drawing.Color.Black
        Me.btnAtras.Location = New System.Drawing.Point(413, 323)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(116, 33)
        Me.btnAtras.TabIndex = 120
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
        Me.btnSiguiente.TabIndex = 119
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(32, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 20)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "Imagen del sistema de comunicacion"
        '
        'btnCargarImagen
        '
        Me.btnCargarImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarImagen.ForeColor = System.Drawing.Color.Black
        Me.btnCargarImagen.Location = New System.Drawing.Point(447, 224)
        Me.btnCargarImagen.Name = "btnCargarImagen"
        Me.btnCargarImagen.Size = New System.Drawing.Size(183, 33)
        Me.btnCargarImagen.TabIndex = 117
        Me.btnCargarImagen.Text = "Cargar imagen"
        Me.btnCargarImagen.UseVisualStyleBackColor = True
        '
        'PictureComunicacion
        '
        Me.PictureComunicacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureComunicacion.Location = New System.Drawing.Point(338, 224)
        Me.PictureComunicacion.Name = "PictureComunicacion"
        Me.PictureComunicacion.Size = New System.Drawing.Size(92, 68)
        Me.PictureComunicacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureComunicacion.TabIndex = 116
        Me.PictureComunicacion.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(56, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(246, 20)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "Tipo del sistema de comunicacion"
        '
        'ComboTipoComunicacion
        '
        Me.ComboTipoComunicacion.FormattingEnabled = True
        Me.ComboTipoComunicacion.Location = New System.Drawing.Point(338, 124)
        Me.ComboTipoComunicacion.Name = "ComboTipoComunicacion"
        Me.ComboTipoComunicacion.Size = New System.Drawing.Size(281, 21)
        Me.ComboTipoComunicacion.TabIndex = 114
        '
        'TextNombreComunicacion
        '
        Me.TextNombreComunicacion.Location = New System.Drawing.Point(338, 180)
        Me.TextNombreComunicacion.Name = "TextNombreComunicacion"
        Me.TextNombreComunicacion.Size = New System.Drawing.Size(281, 20)
        Me.TextNombreComunicacion.TabIndex = 113
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(32, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(272, 20)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Nombre del sistema de comunicacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(227, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(358, 24)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "Editor De Sistemas De Comunicacion"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form20
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(708, 375)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCargarImagen)
        Me.Controls.Add(Me.PictureComunicacion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboTipoComunicacion)
        Me.Controls.Add(Me.TextNombreComunicacion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form20"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comunicaciones"
        CType(Me.PictureComunicacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAtras As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCargarImagen As Button
    Friend WithEvents PictureComunicacion As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboTipoComunicacion As ComboBox
    Friend WithEvents TextNombreComunicacion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
