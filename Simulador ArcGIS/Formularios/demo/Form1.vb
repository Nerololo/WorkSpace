Public Class Form1
    Dim tiempo As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (tiempo < 3) Then
            tiempo = tiempo + 1
        Else
            inicioSistema2.Show()
            Me.Hide()
            Timer1.Stop()
        End If
    End Sub
End Class
