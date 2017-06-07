Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombre As String = NobrePanel.Text
        Dim contraseña As String = ContraseñaPanel.Text

        If nombre = "Root" Then
            If contraseña = "Nahueputo" Then
                Graficas.Show()
                Me.Hide()
            End If
        End If
    End Sub
End Class
