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



        cosas.Clear()
        cosas.AddRange(cositas)
        Dim checkis As New List(Of String)({"Disponible", "Cocina", "Cochera"})
        cajas.Clear()
        cajas.AddRange(checkis)


        Igualar(cosas, cajas)


    End Sub

    Private Sub Casa_CheckedChanged(sender As Object, e As EventArgs) Handles Casas.CheckedChanged

        Dim cositas As New List(Of String)({"Superficie", "Material de piso", "Material de techo", "Cantidad de Baños", "Dormitorios", "Otras habitacione", "Ubicación", "Plantas", "Precio", "Estado"})


        cosas.Clear()
        cosas.AddRange(cositas)
        Dim checkis As New List(Of String)({"Disponible", "Cocina", "Cochera", "Parillero", "Barbacoa"})
        cajas.Clear()
        cajas.AddRange(checkis)

        Igualar(cosas, cajas)


    End Sub

    Private Sub Veiculos_CheckedChanged(sender As Object, e As EventArgs) Handles Veiculos.CheckedChanged
        Dim cositas As New List(Of String)({"Marca", "Kilometraje", "Modelo", "Año", "Cantidad puertas", "Baúl", "Capacidad del cubículo", "Cilindros", "Otras características", "Precio", "Estado"})


        cosas.Clear()
        cosas.AddRange(cositas)
        Dim checkis As New List(Of String)({"Disponible", "Cocina", "Cochera", "Parillero", "Barbacoa"})
        cajas.Clear()
        cajas.AddRange(checkis)

        Igualar(cosas, cajas)

    End Sub

    Private Sub Paquetes_CheckedChanged(sender As Object, e As EventArgs) Handles Paquetes.CheckedChanged
        Dim cositas As New List(Of String)({"Nombre", "ID", "Nomre Casa", "Nombre Apartamento", "Nombre Veiculo", "Precio"})


        cosas.Clear()
        cosas.AddRange(cositas)
        Dim checkis As New List(Of String)({"Disponible"})
        cajas.Clear()
        cajas.AddRange(checkis)

        Igualar(cosas, cajas)

    End Sub
    Private Sub Usuarios_CheckedChanged(sender As Object, e As EventArgs) Handles Usuarios.CheckedChanged
        Dim cositas As New List(Of String)({"Nombre", "Privilegios", "Cedula", "Direccion", "Telefono", "Cargo"})


        cosas.Clear()
        cosas.AddRange(cositas)
        Dim checkis As New List(Of String)({})
        cajas.Clear()
        cajas.AddRange(checkis)

        Igualar(cosas, cajas)


    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Enabled = True
        Me.Hide()
    End Sub

    Private Sub Crear_Click(sender As Object, e As EventArgs) Handles Crear.Click
        Dim contador As Integer = Labels.Count - 1

        While contador >= 0
            If Apartamento(contador).Equals(Labels.Item(contador).Text) Then

            End If
        End While


    End Sub
    Function Igualar(ByVal Textos As List(Of String), ByVal cajas As List(Of String))

        Check.Clear()
        Labels.Clear()
        Boxes.Clear()

        Check.Add(CheckBox1)
        Check.Add(CheckBox2)
        Check.Add(CheckBox3)
        Check.Add(CheckBox4)
        Check.Add(CheckBox5)

        Labels.Add(Label1)
        Labels.Add(Label2)
        Labels.Add(Label3)
        Labels.Add(Label4)
        Labels.Add(Label5)
        Labels.Add(Label6)
        Labels.Add(Label7)
        Labels.Add(Label8)
        Labels.Add(Label9)
        Labels.Add(Label10)
        Labels.Add(Label11)
        Labels.Add(Label12)
        Labels.Add(Label13)
        Labels.Add(Label14)

        Boxes.Add(TextBox1)
        Boxes.Add(TextBox2)
        Boxes.Add(TextBox3)
        Boxes.Add(TextBox4)
        Boxes.Add(TextBox5)
        Boxes.Add(TextBox6)
        Boxes.Add(TextBox7)
        Boxes.Add(TextBox8)
        Boxes.Add(TextBox9)
        Boxes.Add(TextBox10)
        Boxes.Add(TextBox11)
        Boxes.Add(TextBox12)
        Boxes.Add(TextBox13)
        Boxes.Add(TextBox14)

        Textos.AddRange(pluscosas)
        cajas.AddRange(pluscajas)

        Dim numerito As Integer = Labels.Count - 1
        Dim contador As Integer = Textos.Count - 1

        While numerito >= 0
            If (numerito <= contador) Then
                Labels.Item(numerito).Show()
                Boxes.Item(numerito).Show()
            Else
                Labels.Item(numerito).Hide()
                Boxes.Item(numerito).Hide()
            End If
            numerito = numerito - 1
        End While

        While contador >= 0
            Labels.Item(contador).Text = Textos(contador)
            contador = contador - 1
        End While

        numerito = Check.Count - 1
        contador = cajas.Count - 1
        While (numerito >= 0)
            If (numerito <= contador) Then
                Check.Item(numerito).Show()
            Else
                Check.Item(numerito).Hide()
            End If
            numerito = numerito - 1
        End While

        contador = cajas.Count - 1
        While contador >= 0
            Check.Item(contador).Text = Textos(contador)
            contador = contador - 1
        End While

        Textos.RemoveRange(Textos.Count - pluscosas.Count, pluscosas.Count)
        cajas.RemoveRange(cajas.Count - pluscajas.Count, pluscajas.Count)


    End Function
End Class
