Public Class inicioSistema2
    Dim tiempo As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (tiempo < 3) Then
            tiempo = tiempo + 1
        Else
            Form2.Show()
            Me.Hide()
            Timer1.Stop()
        End If
    End Sub

End Class