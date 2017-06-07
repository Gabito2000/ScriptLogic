


Public Class Graficas

    ' Ventana con privilegio de usuario
    If (Form1.PrivilegiosUsuario = "Usuario") Then
            Comprar.Enabled = False
            Alquilar.Enabled = False
            Reservar.Enabled = False
            Alquilartermino.Enabled = False
            Prereservar.Checked = True
            Usuarios.Enabled = False
            MenuStrip1.Hide()
            Label11.Hide()
            TextBox11.Hide()
        Else
            CheckBox5.Show()
        End If


    Private Sub Apartamentos_CheckedChanged(sender As Object, e As EventArgs) Handles Apartamentos.CheckedChanged
        Label1.Text = "Superficie"
        Label2.Text = "Cantidad de baños"
        Label3.Text = "Cantidad de dormitorios"
        Label4.Text = "Otras habitaciones"
        Label5.Text = "Piso"
        Label6.Text = "Seguridad"
        Label7.Text = "Espacio exterior"
        Label8.Text = "Ubicación"
        Label9.Text = "Precio"

        CheckBox4.Text = "Cocina"
        CheckBox3.Text = "Cochera"

        CheckBox4.Show()
        CheckBox3.Show()

        CheckBox2.Hide()
        CheckBox1.Hide()

        CheckBox5.Text = "Disponible"
        CheckBox5.Show()

        Label1.Show()
        Label2.Show()
        Label3.Show()
        Label4.Show()
        Label5.Show()
        Label6.Show()
        Label7.Show()
        Label8.Show()
        Label9.Show()
        Label10.Hide()

        Label11.Text = "Estado"

        TextBox1.Show()
        TextBox2.Show()
        TextBox3.Show()
        TextBox4.Show()
        TextBox5.Show()
        TextBox6.Show()
        TextBox7.Show()
        TextBox8.Show()
        TextBox9.Show()
        TextBox10.Hide()

    End Sub

    Private Sub Casa_CheckedChanged(sender As Object, e As EventArgs) Handles Casa.CheckedChanged
        Label1.Text = "Superficie"
        Label2.Text = "Material de piso"
        Label3.Text = "Material de techo"
        Label4.Text = "Cantidad de Baños"
        Label5.Text = "Dormitorios"
        Label6.Text = "Otras habitaciones"
        Label7.Text = "Ubicación"
        Label8.Text = "Tipo"
        Label9.Text = "Precio"

        CheckBox4.Text = "Cocina"
        CheckBox3.Text = "Cochera"
        CheckBox1.Text = "Parillero"
        CheckBox2.Text = "Barbacoa"

        CheckBox5.Text = "Disponible"
        CheckBox5.Show()

        CheckBox4.Show()
        CheckBox3.Show()
        CheckBox2.Show()
        CheckBox1.Show()



        Label1.Show()
        Label2.Show()
        Label3.Show()
        Label4.Show()
        Label5.Show()
        Label6.Show()
        Label7.Show()
        Label8.Show()
        Label9.Show()

        Label10.Hide()

        Label11.Text = "Estado"

        TextBox1.Show()
        TextBox2.Show()
        TextBox3.Show()
        TextBox4.Show()
        TextBox5.Show()
        TextBox6.Show()
        TextBox7.Show()
        TextBox8.Show()
        TextBox9.Show()

        TextBox10.Hide()

    End Sub

    Private Sub Veiculos_CheckedChanged(sender As Object, e As EventArgs) Handles Veiculos.CheckedChanged
        Label1.Text = "Marca"
        Label2.Text = "Kilometraje"
        Label3.Text = "Modelo"
        Label4.Text = "Año"
        Label5.Text = "Cantidad puertas"
        Label6.Text = "Baúl"
        Label7.Text = "Capacidad del cubículo"
        Label8.Text = "Cilindros"
        Label9.Text = "Otras características"
        Label10.Text = "Precio"

        CheckBox5.Text = "Disponible"
        CheckBox5.Show()

        CheckBox4.Hide()
        CheckBox3.Hide()
        CheckBox2.Hide()
        CheckBox1.Hide()

        Label1.Show()
        Label2.Show()
        Label3.Show()
        Label4.Show()
        Label5.Show()
        Label6.Show()
        Label7.Show()
        Label8.Show()
        Label9.Show()
        Label10.Hide()

        Label11.Text = "Estado"


        TextBox1.Show()
        TextBox2.Show()
        TextBox3.Show()
        TextBox4.Show()
        TextBox5.Show()
        TextBox6.Show()
        TextBox7.Show()
        TextBox8.Show()
        TextBox9.Show()
        TextBox10.Hide()


    End Sub

    Private Sub Paquetes_CheckedChanged(sender As Object, e As EventArgs) Handles Paquetes.CheckedChanged

        Label1.Text = "Nombre"
        Label4.Text = "ID"
        Label2.Text = "Nomre Casa"
        Label3.Text = "Nombre Apartamento"
        Label4.Text = "Nombre Veiculo"
        Label5.Text = "Precio"

        CheckBox4.Text = "Casa"
        CheckBox3.Text = "Apartamento"
        CheckBox2.Text = "Veiculo"

        CheckBox5.Text = "Disponible"
        CheckBox5.Show()

        CheckBox4.Show()
        CheckBox3.Show()
        CheckBox2.Show()
        CheckBox1.Hide()

        Label1.Show()
        Label2.Show()
        Label3.Show()
        Label4.Show()
        Label5.Show()
        Label6.Hide()
        Label7.Hide()
        Label8.Hide()
        Label9.Hide()
        Label10.Hide()


        TextBox1.Show()
        TextBox2.Show()
        TextBox3.Show()
        TextBox4.Show()
        TextBox5.Show()
        TextBox6.Hide()
        TextBox7.Hide()
        TextBox8.Hide()
        TextBox9.Hide()
        TextBox10.Hide()

    End Sub

    Private Sub CasaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CasaToolStripMenuItem.Click

        Me.Enabled = False
        Form3.Show()

    End Sub


    Private Sub Usuarios_CheckedChanged(sender As Object, e As EventArgs) Handles Usuarios.CheckedChanged
        Label1.Text = "Nombre"
        Label3.Text = "Privilegios"
        Label2.Text = "Cedula"
        Label4.Text = "Direccion"
        Label5.Text = "Telefono"
        CheckBox5.Hide()
        CheckBox4.Hide()
        CheckBox3.Hide()
        CheckBox2.Hide()
        CheckBox1.Hide()

        Label1.Show()
        Label2.Show()
        Label3.Show()
        Label4.Show()
        Label5.Show()
        Label6.Hide()
        Label7.Hide()
        Label8.Hide()
        Label9.Hide()
        Label10.Hide()
        Label11.Hide()

        TextBox1.Show()
        TextBox2.Show()
        TextBox3.Show()
        TextBox4.Show()
        TextBox5.Show()
        TextBox6.Hide()
        TextBox7.Hide()
        TextBox8.Hide()
        TextBox9.Hide()
        TextBox10.Hide()
        TextBox11.Hide()
    End Sub

    Private Sub Alquilar_CheckedChanged(sender As Object, e As EventArgs) Handles Alquilar.CheckedChanged
        If Usuarios.Checked Then

        Else
            Label12.Text = "Inicio del alquiler"
            Label13.Text = "Fin del alquiler"
            If (Usuarios.Checked) Then

            Else
                Label12.Show()
                Label13.Show()
                TextBox12.Show()
                TextBox13.Show()

                If (Alquilar.Checked = False) Then
                    Label12.Hide()
                    Label13.Hide()
                    TextBox12.Hide()
                    TextBox13.Hide()
                End If
            End If
        End If
    End Sub

    Private Sub Alquilartermino_CheckedChanged(sender As Object, e As EventArgs) Handles Alquilartermino.CheckedChanged
        Label12.Text = "Inicio del alquiler"
        Label13.Text = "Fin del alquiler"

        Label12.Show()
        Label13.Show()
        TextBox12.Show()
        TextBox13.Show()

        If (Alquilartermino.Checked = False) Then
            Label12.Hide()
            Label13.Hide()
            TextBox12.Hide()
            TextBox13.Hide()
        End If
    End Sub
End Class