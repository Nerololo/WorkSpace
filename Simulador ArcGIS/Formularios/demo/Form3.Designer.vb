<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboTipoEntida = New System.Windows.Forms.ComboBox()
        Me.TipoentidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SimulacionDataSet = New demo.SimulacionDataSet()
        Me.TipoentidadesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextNombreEntidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboSimboloEntidad = New System.Windows.Forms.ComboBox()
        Me.SimboloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SimulacionDataSet2 = New demo.SimulacionDataSet2()
        Me.PictureSimboloEntidad = New System.Windows.Forms.PictureBox()
        Me.btnAgregarSimbolo = New System.Windows.Forms.Button()
        Me.btnCrarSimbolo = New System.Windows.Forms.Button()
        Me.Tipo_entidadesTableAdapter = New demo.SimulacionDataSetTableAdapters.tipo_entidadesTableAdapter()
        Me.SimboloTableAdapter1 = New demo.SimulacionDataSet2TableAdapters.simboloTableAdapter()
        CType(Me.TipoentidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimulacionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoentidadesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimboloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimulacionDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureSimboloEntidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(413, 323)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 33)
        Me.Button1.TabIndex = 140
        Me.Button1.Text = "Atras"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.ForeColor = System.Drawing.Color.Black
        Me.btnSiguiente.Location = New System.Drawing.Point(546, 323)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(116, 33)
        Me.btnSiguiente.TabIndex = 139
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(43, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 20)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = "Simbolo de la entidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(86, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 20)
        Me.Label6.TabIndex = 135
        Me.Label6.Text = "Tipo de entidad"
        '
        'ComboTipoEntida
        '
        Me.ComboTipoEntida.FormattingEnabled = True
        Me.ComboTipoEntida.Location = New System.Drawing.Point(294, 115)
        Me.ComboTipoEntida.Name = "ComboTipoEntida"
        Me.ComboTipoEntida.Size = New System.Drawing.Size(281, 21)
        Me.ComboTipoEntida.TabIndex = 134
        '
        'TipoentidadesBindingSource
        '
        Me.TipoentidadesBindingSource.DataMember = "tipo_entidades"
        Me.TipoentidadesBindingSource.DataSource = Me.SimulacionDataSet
        '
        'SimulacionDataSet
        '
        Me.SimulacionDataSet.DataSetName = "SimulacionDataSet"
        Me.SimulacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextNombreEntidad
        '
        Me.TextNombreEntidad.Location = New System.Drawing.Point(294, 158)
        Me.TextNombreEntidad.Name = "TextNombreEntidad"
        Me.TextNombreEntidad.Size = New System.Drawing.Size(281, 20)
        Me.TextNombreEntidad.TabIndex = 133
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(44, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 20)
        Me.Label3.TabIndex = 132
        Me.Label3.Text = "Nombre de la entidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(222, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 24)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "Editor De Entidades"
        '
        'ComboSimboloEntidad
        '
        Me.ComboSimboloEntidad.FormattingEnabled = True
        Me.ComboSimboloEntidad.Location = New System.Drawing.Point(294, 202)
        Me.ComboSimboloEntidad.Name = "ComboSimboloEntidad"
        Me.ComboSimboloEntidad.Size = New System.Drawing.Size(281, 21)
        Me.ComboSimboloEntidad.TabIndex = 141
        '
        'SimboloBindingSource
        '
        Me.SimboloBindingSource.DataMember = "simbolo"
        Me.SimboloBindingSource.DataSource = Me.SimulacionDataSet2
        '
        'SimulacionDataSet2
        '
        Me.SimulacionDataSet2.DataSetName = "SimulacionDataSet2"
        Me.SimulacionDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureSimboloEntidad
        '
        Me.PictureSimboloEntidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureSimboloEntidad.Location = New System.Drawing.Point(584, 203)
        Me.PictureSimboloEntidad.Name = "PictureSimboloEntidad"
        Me.PictureSimboloEntidad.Size = New System.Drawing.Size(92, 68)
        Me.PictureSimboloEntidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureSimboloEntidad.TabIndex = 136
        Me.PictureSimboloEntidad.TabStop = False
        '
        'btnAgregarSimbolo
        '
        Me.btnAgregarSimbolo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarSimbolo.ForeColor = System.Drawing.Color.Black
        Me.btnAgregarSimbolo.Location = New System.Drawing.Point(441, 229)
        Me.btnAgregarSimbolo.Name = "btnAgregarSimbolo"
        Me.btnAgregarSimbolo.Size = New System.Drawing.Size(137, 33)
        Me.btnAgregarSimbolo.TabIndex = 142
        Me.btnAgregarSimbolo.Text = "Agregar Simbolo"
        Me.btnAgregarSimbolo.UseVisualStyleBackColor = True
        '
        'btnCrarSimbolo
        '
        Me.btnCrarSimbolo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrarSimbolo.ForeColor = System.Drawing.Color.Black
        Me.btnCrarSimbolo.Location = New System.Drawing.Point(294, 229)
        Me.btnCrarSimbolo.Name = "btnCrarSimbolo"
        Me.btnCrarSimbolo.Size = New System.Drawing.Size(137, 33)
        Me.btnCrarSimbolo.TabIndex = 143
        Me.btnCrarSimbolo.Text = "Crear Simbolo"
        Me.btnCrarSimbolo.UseVisualStyleBackColor = True
        '
        'Tipo_entidadesTableAdapter
        '
        Me.Tipo_entidadesTableAdapter.ClearBeforeFill = True
        '
        'SimboloTableAdapter1
        '
        Me.SimboloTableAdapter1.ClearBeforeFill = True
        '
        'Form3
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(708, 375)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCrarSimbolo)
        Me.Controls.Add(Me.btnAgregarSimbolo)
        Me.Controls.Add(Me.ComboSimboloEntidad)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureSimboloEntidad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboTipoEntida)
        Me.Controls.Add(Me.TextNombreEntidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form3"
        Me.Opacity = 0.4R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entidades"
        Me.TransparencyKey = System.Drawing.Color.Black
        CType(Me.TipoentidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimulacionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoentidadesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimboloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimulacionDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureSimboloEntidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureSimboloEntidad As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboTipoEntida As ComboBox
    Friend WithEvents TextNombreEntidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboSimboloEntidad As ComboBox
    Friend WithEvents btnAgregarSimbolo As Button
    Friend WithEvents btnCrarSimbolo As Button
    Friend WithEvents SimboloTableAdapter As SimulacionDataSet2TableAdapters.simboloTableAdapter
    Friend WithEvents TipoentidadesBindingSource1 As BindingSource
    Friend WithEvents SimulacionDataSet As SimulacionDataSet
    Friend WithEvents TipoentidadesBindingSource As BindingSource
    Friend WithEvents Tipo_entidadesTableAdapter As SimulacionDataSetTableAdapters.tipo_entidadesTableAdapter
    Friend WithEvents SimulacionDataSet2 As SimulacionDataSet2
    Friend WithEvents SimboloBindingSource As BindingSource
    Friend WithEvents SimboloTableAdapter1 As SimulacionDataSet2TableAdapters.simboloTableAdapter
End Class
