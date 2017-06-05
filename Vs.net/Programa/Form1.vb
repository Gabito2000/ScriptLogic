Public Class Form1
    ' usuarios valores
    Public Usuario As New List(Of String)
    Public Contraseña As New List(Of String)
    Public Privilegios As New List(Of String)
    Public PrivilegiosUsuario As String
    ' casa valores
    Public ASuperficie As New List(Of String)
    Public AMaterialdepiso As New List(Of String)
    Public AMaterialdetecho As New List(Of String)
    Public ACantidaddeBaños As New List(Of String)
    Public AOtrashabitaciones As New List(Of String)
    Public ADormitorios As New List(Of String)
    Public AUbicación As New List(Of String)
    Public ATipo As New List(Of String)
    Public APrecio As New List(Of String)



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Usuario.Add("Root")
        Contraseña.Add("Nahueputo")
        Privilegios.Add("Root")
        Usuario.Add("U")
        Contraseña.Add("")
        Privilegios.Add("Usuario")
        Dim nombre As String = NobrePanel.Text
        Dim pass As String = ContraseñaPanel.Text

        Dim contador As Integer = Usuario.Count
        Dim entro As Boolean = True
        Do Until contador = 0

            contador = contador - 1

            If nombre = Usuario(contador) Then

                If Contraseña(contador) = pass Then

                    Graficas.Show()
                    Me.Hide()
                    entro = False
                    PrivilegiosUsuario = Privilegios(contador)

                End If
                If entro Then
                    MsgBox("No existe esa contraseña")
                End If
            End If

        Loop
        If entro Then
            MsgBox("No existe ese nombre")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
