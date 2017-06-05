Public Class Form3
    Dim Labels As New List(Of Label)
    Dim Boxes As New List(Of TextBox)
    Dim Check As New List(Of CheckBox)
    Dim cajas As New List(Of String)
    Dim cosas As New List(Of String)
    Dim pluscajas As New List(Of String)
    Dim pluscosas As New List(Of String)
    Public Apartamento As New List(Of List(Of String))
    Public Casa As New List(Of List(Of String))
    Public Veiculo As New List(Of List(Of String))
    Public Usuario As New List(Of List(Of String))
    Public Paquete As New List(Of List(Of String))


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub Apartamentos_CheckedChanged(sender As Object, e As EventArgs) Handles Apartamentos.CheckedChanged


        Dim cositas As New List(Of String)({"Superficie", "Cantidad de baños", "Cantidad de dormitorios", "Otras habitaciones", "Piso", "Seguridad", "Espacio exterior", "Ubicación", "Precio", "Estado"})

        Titulo(Apartamento, cositas)

        cosas.Clear()
        cosas.AddRange(cositas)
        Dim checkis As New List(Of String)({"Disponible", "Cocina", "Cochera"})
        cajas.Clear()
        cajas.AddRange(checkis)

        Graficas.Igualar(cosas, cajas)


    End Sub

    Private Sub Casa_CheckedChanged(sender As Object, e As EventArgs) Handles Casas.CheckedChanged

        Dim cositas As New List(Of String)({"Superficie", "Material de piso", "Material de techo", "Cantidad de Baños", "Dormitorios", "Otras habitacione", "Ubicación", "Plantas", "Precio", "Estado"})

        Titulo(Casa, cositas)

        cosas.Clear()
        cosas.AddRange(cositas)
        Dim checkis As New List(Of String)({"Disponible", "Cocina", "Cochera", "Parillero", "Barbacoa"})
        cajas.Clear()
        cajas.AddRange(checkis)

        Graficas.Igualar(cosas, cajas)


    End Sub

    Private Sub Veiculos_CheckedChanged(sender As Object, e As EventArgs) Handles Veiculos.CheckedChanged
        Dim cositas As New List(Of String)({"Marca", "Kilometraje", "Modelo", "Año", "Cantidad puertas", "Baúl", "Capacidad del cubículo", "Cilindros", "Otras características", "Precio", "Estado"})

        Titulo(Veiculo, cositas)

        cosas.Clear()
        cosas.AddRange(cositas)
        Dim checkis As New List(Of String)({"Disponible", "Cocina", "Cochera", "Parillero", "Barbacoa"})
        cajas.Clear()
        cajas.AddRange(checkis)

        Graficas.Igualar(cosas, cajas)

    End Sub

    Private Sub Paquetes_CheckedChanged(sender As Object, e As EventArgs) Handles Paquetes.CheckedChanged
        Dim cositas As New List(Of String)({"Nombre", "ID", "Nomre Casa", "Nombre Apartamento", "Nombre Veiculo", "Precio"})

        Titulo(Paquete, cositas)

        cosas.Clear()
        cosas.AddRange(cositas)
        Dim checkis As New List(Of String)({"Disponible"})
        cajas.Clear()
        cajas.AddRange(checkis)

        Graficas.Igualar(cosas, cajas)

    End Sub
    Private Sub Usuarios_CheckedChanged(sender As Object, e As EventArgs) Handles Usuarios.CheckedChanged
        Dim cositas As New List(Of String)({"Nombre", "Privilegios", "Cedula", "Direccion", "Telefono", "Cargo"})

        Titulo(Usuario, cositas)

        cosas.Clear()
        cosas.AddRange(cositas)
        Dim checkis As New List(Of String)({})
        cajas.Clear()
        cajas.AddRange(checkis)

        Graficas.Igualar(cosas, cajas)


    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Graficas.Enabled = True
        Me.Hide()
    End Sub

    Private Sub Crear_Click(sender As Object, e As EventArgs) Handles Crear.Click
        Dim contador As Integer = Labels.Count - 1

        While contador >= 0
            If Apartamento(contador).Equals(Labels.Item(contador).Text) Then

            End If
        End While


    End Sub
    Function Titulo(ByVal Arreglo As List(Of List(Of String)), ByVal Titulos As List(Of String))
        If Arreglo.Count = 0 Then
            Arreglo.AddRange(Titulos)
        End If

    End Function
End Class
