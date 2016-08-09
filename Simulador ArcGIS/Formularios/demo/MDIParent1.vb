Imports System.Windows.Forms
Public Class MDIParent1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub
    'Permite el ingreso al editor de entidades
    Private Sub EditorDeEntidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditorDeEntidadesToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.entidadesGRIS
        MenuStrip.Enabled = False
        Form3.MdiParent = Me
        Form3.Show()
    End Sub
    'permite el ingreso al editor de armas
    Private Sub EditorDeArmasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditorDeArmasToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.armasGRIS
        MenuStrip.Enabled = False
        Form5.MdiParent = Me
        Form5.Show()
    End Sub
    'permite el ingreso al editor de Municion
    Private Sub EditorDeMunicionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditorDeMunicionesToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.municionesGRIS
        MenuStrip.Enabled = False
        Form7.MdiParent = Me
        Form7.Show()
    End Sub
    ''permite el ingreso al editor de sensores
    Private Sub EditorDeSensoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditorDeSensoresToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.sensoresGRIS
        MenuStrip.Enabled = False
        Form9.MdiParent = Me
        Form9.Show()
    End Sub
    Private Sub EditorProteccionActivaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditorProteccionActivaToolStripMenuItem.Click
        MenuStrip.Enabled = False
        Form11.MdiParent = Me
        Form11.Show()
    End Sub
    Private Sub EditorProteccionPasivaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditorProteccionPasivaToolStripMenuItem.Click
        MenuStrip.Enabled = False
        'Form13.MdiParent = Me
        Form13.Show()
    End Sub
    'permite el ingreso al editor de tipo de entidades
    Private Sub EditorDeTipoDeEntidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditorDeTipoDeEntidadesToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.entidadesGRIS
        MenuStrip.Enabled = False
        editorTipoEntidad.MdiParent = Me
        editorTipoEntidad.Show()
    End Sub
    'permite el ingreso al editor de tipo de arma
    Private Sub EditorTipoDeArmasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditorTipoDeArmasToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.armasGRIS
        MenuStrip.Enabled = False
        Form16.MdiParent = Me
        Form16.Show()
    End Sub
    'permite el ingreso al editor de tipo de municion
    Private Sub EditorTipoDeMunicionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditorTipoDeMunicionesToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.municionesGRIS
        MenuStrip.Enabled = False
        Form17.MdiParent = Me
        Form17.Show()
    End Sub
    'permite el ingreso al editor de tipo de sensores
    Private Sub EditorTipoDeSensoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditorTipoDeSensoresToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.sensoresGRIS
        MenuStrip.Enabled = False
        Form18.MdiParent = Me
        Form18.Show()
    End Sub
    Private Sub EditorDeTiposDeProteccionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditorDeTiposDeProteccionToolStripMenuItem.Click
        MenuStrip.Enabled = False
        'Form19.MdiParent = Me
        Form19.Show()
    End Sub

    Private Sub EditorDeComunicacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditorDeComunicacionToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.comunicacionGRIS
        MenuStrip.Enabled = False
        Form20.MdiParent = Me
        Form20.Show()
    End Sub

    Private Sub EditorDeTiposDeComunicacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditorDeTiposDeComunicacionesToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.comunicacionGRIS
        MenuStrip.Enabled = False
        editorTipoComunicacion.MdiParent = Me
        editorTipoComunicacion.Show()
    End Sub

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width
        Me.WindowState = FormWindowState.Maximized
    End Sub
    'moviemiento de borrar label en la pantalla
    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs)
        'LabelEntidad.Visible = False
        'LabelArma.Visible = False
        'labelMunicion.Visible = False
        'LabelSensores.Visible = False
        'LabelProteccion.Visible = False
        'LabelComunicacion.Visible = False
    End Sub
    'ingresa al mapa de argis
    Private Sub inicio_Click(sender As Object, e As EventArgs) Handles inicio.Click
        'Dim a As ArcGISRuntime.Samples.Desktop.SimuladorMain = New ArcGISRuntime.Samples.Desktop.SimuladorMain()
        'a.Visibility = System.Windows.Visibility.Visible
        'Me.Hide()
    End Sub
    ' ingresa al formulario de crear escenarios
    Private Sub CrearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearToolStripMenuItem.Click
        MenuStrip.Enabled = False
        crearEscenario.MdiParent = Me
        crearEscenario.Show()
    End Sub
End Class
