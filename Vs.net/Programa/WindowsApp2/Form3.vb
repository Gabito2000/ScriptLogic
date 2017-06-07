Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Superficie"
        Label2.Text = "Material de piso"
        Label3.Text = "Material de techo"
        Label4.Text = "Cantidad de Baños"
        Label5.Text = "Dormitorios"
        Label6.Text = "Otras habitaciones"
        Label7.Text = "Ubicación"
        Label8.Text = "Tipo"
        Label9.Text = "Precio"
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Form2.Enabled = True
        Me.Hide()
    End Sub

End Class