Public Class Form14
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub proteccionPasiva2_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, TabPage1.MouseMove

        Label1.Text = tipoProteccion1
        Label5.Text = nombreProteccion1
        PictureBox1.Image = imagenProteccion
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class