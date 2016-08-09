<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDIParent1
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.inicio = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.editorEntidades = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorDeTipoDeEntidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorDeEntidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.editorArmas = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorTipoDeArmasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorDeArmasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.editorMunicion = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorTipoDeMunicionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorDeMunicionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorDeSensores = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorTipoDeSensoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorDeSensoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorProteccionPasiva = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorDeTiposDeProteccionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorProteccionActivaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorProteccionPasivaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComunicacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorDeTiposDeComunicacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorDeComunicacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.CrearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelecionarEscenarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Gray
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.inicio, Me.editorEntidades, Me.editorArmas, Me.editorMunicion, Me.EditorDeSensores, Me.EditorProteccionPasiva, Me.ComunicacionesToolStripMenuItem, Me.Salir})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(3, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(1238, 33)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'inicio
        '
        Me.inicio.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator9, Me.CrearToolStripMenuItem, Me.SelecionarEscenarioToolStripMenuItem})
        Me.inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inicio.ForeColor = System.Drawing.Color.White
        Me.inicio.Image = Global.demo.My.Resources.Resources.icono_inicio_30px
        Me.inicio.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.inicio.Name = "inicio"
        Me.inicio.Size = New System.Drawing.Size(140, 29)
        Me.inicio.Text = "&Escenario"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(285, 6)
        '
        'editorEntidades
        '
        Me.editorEntidades.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditorDeTipoDeEntidadesToolStripMenuItem, Me.EditorDeEntidadesToolStripMenuItem})
        Me.editorEntidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editorEntidades.ForeColor = System.Drawing.Color.White
        Me.editorEntidades.Image = Global.demo.My.Resources.Resources._4
        Me.editorEntidades.Name = "editorEntidades"
        Me.editorEntidades.Size = New System.Drawing.Size(140, 29)
        Me.editorEntidades.Text = "&Entidades"
        '
        'EditorDeTipoDeEntidadesToolStripMenuItem
        '
        Me.EditorDeTipoDeEntidadesToolStripMenuItem.Image = Global.demo.My.Resources.Resources.editor_30px
        Me.EditorDeTipoDeEntidadesToolStripMenuItem.Name = "EditorDeTipoDeEntidadesToolStripMenuItem"
        Me.EditorDeTipoDeEntidadesToolStripMenuItem.Size = New System.Drawing.Size(360, 30)
        Me.EditorDeTipoDeEntidadesToolStripMenuItem.Text = "Editor De Tipo De Entidades"
        '
        'EditorDeEntidadesToolStripMenuItem
        '
        Me.EditorDeEntidadesToolStripMenuItem.Image = Global.demo.My.Resources.Resources.const_30px
        Me.EditorDeEntidadesToolStripMenuItem.Name = "EditorDeEntidadesToolStripMenuItem"
        Me.EditorDeEntidadesToolStripMenuItem.Size = New System.Drawing.Size(360, 30)
        Me.EditorDeEntidadesToolStripMenuItem.Text = "Editor De Entidades"
        '
        'editorArmas
        '
        Me.editorArmas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditorTipoDeArmasToolStripMenuItem, Me.EditorDeArmasToolStripMenuItem})
        Me.editorArmas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editorArmas.ForeColor = System.Drawing.Color.White
        Me.editorArmas.Image = Global.demo.My.Resources.Resources._3
        Me.editorArmas.Name = "editorArmas"
        Me.editorArmas.Size = New System.Drawing.Size(105, 29)
        Me.editorArmas.Text = "&Armas"
        '
        'EditorTipoDeArmasToolStripMenuItem
        '
        Me.EditorTipoDeArmasToolStripMenuItem.Image = Global.demo.My.Resources.Resources.editor_30px
        Me.EditorTipoDeArmasToolStripMenuItem.Name = "EditorTipoDeArmasToolStripMenuItem"
        Me.EditorTipoDeArmasToolStripMenuItem.Size = New System.Drawing.Size(288, 30)
        Me.EditorTipoDeArmasToolStripMenuItem.Text = "Editor Tipo De Armas"
        '
        'EditorDeArmasToolStripMenuItem
        '
        Me.EditorDeArmasToolStripMenuItem.Image = Global.demo.My.Resources.Resources.const_30px
        Me.EditorDeArmasToolStripMenuItem.Name = "EditorDeArmasToolStripMenuItem"
        Me.EditorDeArmasToolStripMenuItem.Size = New System.Drawing.Size(288, 30)
        Me.EditorDeArmasToolStripMenuItem.Text = "Editor De Armas"
        '
        'editorMunicion
        '
        Me.editorMunicion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditorTipoDeMunicionesToolStripMenuItem, Me.EditorDeMunicionesToolStripMenuItem})
        Me.editorMunicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editorMunicion.ForeColor = System.Drawing.Color.White
        Me.editorMunicion.Image = Global.demo.My.Resources.Resources._1
        Me.editorMunicion.Name = "editorMunicion"
        Me.editorMunicion.Size = New System.Drawing.Size(154, 29)
        Me.editorMunicion.Text = "&Municiones"
        '
        'EditorTipoDeMunicionesToolStripMenuItem
        '
        Me.EditorTipoDeMunicionesToolStripMenuItem.Image = Global.demo.My.Resources.Resources.editor_30px
        Me.EditorTipoDeMunicionesToolStripMenuItem.Name = "EditorTipoDeMunicionesToolStripMenuItem"
        Me.EditorTipoDeMunicionesToolStripMenuItem.Size = New System.Drawing.Size(337, 30)
        Me.EditorTipoDeMunicionesToolStripMenuItem.Text = "Editor Tipo De Municiones"
        '
        'EditorDeMunicionesToolStripMenuItem
        '
        Me.EditorDeMunicionesToolStripMenuItem.Image = Global.demo.My.Resources.Resources.const_30px
        Me.EditorDeMunicionesToolStripMenuItem.Name = "EditorDeMunicionesToolStripMenuItem"
        Me.EditorDeMunicionesToolStripMenuItem.Size = New System.Drawing.Size(337, 30)
        Me.EditorDeMunicionesToolStripMenuItem.Text = "Editor De Municiones"
        '
        'EditorDeSensores
        '
        Me.EditorDeSensores.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditorTipoDeSensoresToolStripMenuItem, Me.EditorDeSensoresToolStripMenuItem})
        Me.EditorDeSensores.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditorDeSensores.ForeColor = System.Drawing.Color.White
        Me.EditorDeSensores.Image = Global.demo.My.Resources.Resources._2
        Me.EditorDeSensores.Name = "EditorDeSensores"
        Me.EditorDeSensores.Size = New System.Drawing.Size(135, 29)
        Me.EditorDeSensores.Text = "&Sensores"
        '
        'EditorTipoDeSensoresToolStripMenuItem
        '
        Me.EditorTipoDeSensoresToolStripMenuItem.Image = Global.demo.My.Resources.Resources.editor_30px
        Me.EditorTipoDeSensoresToolStripMenuItem.Name = "EditorTipoDeSensoresToolStripMenuItem"
        Me.EditorTipoDeSensoresToolStripMenuItem.Size = New System.Drawing.Size(318, 30)
        Me.EditorTipoDeSensoresToolStripMenuItem.Text = "Editor Tipo De Sensores"
        '
        'EditorDeSensoresToolStripMenuItem
        '
        Me.EditorDeSensoresToolStripMenuItem.Image = Global.demo.My.Resources.Resources.const_30px
        Me.EditorDeSensoresToolStripMenuItem.Name = "EditorDeSensoresToolStripMenuItem"
        Me.EditorDeSensoresToolStripMenuItem.Size = New System.Drawing.Size(318, 30)
        Me.EditorDeSensoresToolStripMenuItem.Text = "Editor De Sensores"
        '
        'EditorProteccionPasiva
        '
        Me.EditorProteccionPasiva.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditorDeTiposDeProteccionToolStripMenuItem, Me.EditorProteccionActivaToolStripMenuItem, Me.EditorProteccionPasivaToolStripMenuItem})
        Me.EditorProteccionPasiva.Enabled = False
        Me.EditorProteccionPasiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditorProteccionPasiva.ForeColor = System.Drawing.Color.White
        Me.EditorProteccionPasiva.Image = Global.demo.My.Resources.Resources._6
        Me.EditorProteccionPasiva.Name = "EditorProteccionPasiva"
        Me.EditorProteccionPasiva.Size = New System.Drawing.Size(152, 29)
        Me.EditorProteccionPasiva.Text = "&Proteccion "
        '
        'EditorDeTiposDeProteccionToolStripMenuItem
        '
        Me.EditorDeTiposDeProteccionToolStripMenuItem.Image = Global.demo.My.Resources.Resources.editor_30px
        Me.EditorDeTiposDeProteccionToolStripMenuItem.Name = "EditorDeTiposDeProteccionToolStripMenuItem"
        Me.EditorDeTiposDeProteccionToolStripMenuItem.Size = New System.Drawing.Size(373, 30)
        Me.EditorDeTiposDeProteccionToolStripMenuItem.Text = "Editor De Tipos De Proteccion"
        '
        'EditorProteccionActivaToolStripMenuItem
        '
        Me.EditorProteccionActivaToolStripMenuItem.Image = Global.demo.My.Resources.Resources.const_30px
        Me.EditorProteccionActivaToolStripMenuItem.Name = "EditorProteccionActivaToolStripMenuItem"
        Me.EditorProteccionActivaToolStripMenuItem.Size = New System.Drawing.Size(373, 30)
        Me.EditorProteccionActivaToolStripMenuItem.Text = "Editor Proteccion Activa"
        '
        'EditorProteccionPasivaToolStripMenuItem
        '
        Me.EditorProteccionPasivaToolStripMenuItem.Image = Global.demo.My.Resources.Resources.const_30px
        Me.EditorProteccionPasivaToolStripMenuItem.Name = "EditorProteccionPasivaToolStripMenuItem"
        Me.EditorProteccionPasivaToolStripMenuItem.Size = New System.Drawing.Size(373, 30)
        Me.EditorProteccionPasivaToolStripMenuItem.Text = "Editor Proteccion Pasiva"
        '
        'ComunicacionesToolStripMenuItem
        '
        Me.ComunicacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditorDeTiposDeComunicacionesToolStripMenuItem, Me.EditorDeComunicacionToolStripMenuItem})
        Me.ComunicacionesToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.ComunicacionesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ComunicacionesToolStripMenuItem.Image = Global.demo.My.Resources.Resources._5
        Me.ComunicacionesToolStripMenuItem.Name = "ComunicacionesToolStripMenuItem"
        Me.ComunicacionesToolStripMenuItem.Size = New System.Drawing.Size(307, 29)
        Me.ComunicacionesToolStripMenuItem.Text = "&Sistemas De Comunicacion"
        '
        'EditorDeTiposDeComunicacionesToolStripMenuItem
        '
        Me.EditorDeTiposDeComunicacionesToolStripMenuItem.Image = Global.demo.My.Resources.Resources.editor_30px
        Me.EditorDeTiposDeComunicacionesToolStripMenuItem.Name = "EditorDeTiposDeComunicacionesToolStripMenuItem"
        Me.EditorDeTiposDeComunicacionesToolStripMenuItem.Size = New System.Drawing.Size(534, 30)
        Me.EditorDeTiposDeComunicacionesToolStripMenuItem.Text = "Editor De Tipos De Sistemas De Comunicacion"
        '
        'EditorDeComunicacionToolStripMenuItem
        '
        Me.EditorDeComunicacionToolStripMenuItem.Image = Global.demo.My.Resources.Resources.const_30px
        Me.EditorDeComunicacionToolStripMenuItem.Name = "EditorDeComunicacionToolStripMenuItem"
        Me.EditorDeComunicacionToolStripMenuItem.Size = New System.Drawing.Size(534, 30)
        Me.EditorDeComunicacionToolStripMenuItem.Text = "Editor De Sistemas De Comunicacion "
        '
        'Salir
        '
        Me.Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir.ForeColor = System.Drawing.Color.White
        Me.Salir.Image = Global.demo.My.Resources.Resources.icono_salir_30px
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(87, 29)
        Me.Salir.Text = "&Salir"
        '
        'CrearToolStripMenuItem
        '
        Me.CrearToolStripMenuItem.Name = "CrearToolStripMenuItem"
        Me.CrearToolStripMenuItem.Size = New System.Drawing.Size(288, 30)
        Me.CrearToolStripMenuItem.Text = "Crear Escenario"
        '
        'SelecionarEscenarioToolStripMenuItem
        '
        Me.SelecionarEscenarioToolStripMenuItem.Name = "SelecionarEscenarioToolStripMenuItem"
        Me.SelecionarEscenarioToolStripMenuItem.Size = New System.Drawing.Size(288, 30)
        Me.SelecionarEscenarioToolStripMenuItem.Text = "Selecionar Escenario"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.demo.My.Resources.Resources.inicioGRIS
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1238, 726)
        Me.Controls.Add(Me.MenuStrip)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MDIParent1"
        Me.Text = "MDIParent1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents inicio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents editorEntidades As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents editorArmas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents editorMunicion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditorDeSensores As ToolStripMenuItem
    Friend WithEvents EditorProteccionPasiva As ToolStripMenuItem
    Friend WithEvents Salir As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents EditorTipoDeArmasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditorDeArmasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditorDeTipoDeEntidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditorDeEntidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditorTipoDeMunicionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditorDeMunicionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditorTipoDeSensoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditorDeSensoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditorDeTiposDeProteccionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditorProteccionActivaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditorProteccionPasivaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComunicacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditorDeTiposDeComunicacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditorDeComunicacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelecionarEscenarioToolStripMenuItem As ToolStripMenuItem
End Class
