Public Class Form13
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MDIParent1.MenuStrip.Enabled = True
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tipoProteccion1 = ComboBox1.Text
        nombreProteccion1 = TextBox1.Text
        If ComboBox1.Text = "" Or TextBox1.Text = "" Then
            MsgBox("Falta completar algunos datos", MsgBoxStyle.Information)
        Else
            Form14.Show()
        End If
    End Sub
    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cargarImagen(OpenFileDialog1, PictureBox1)
        imagenProteccion = PictureBox1.Image
    End Sub

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class