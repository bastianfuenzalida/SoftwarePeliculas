Public Class Form1


    Private Sub txtNumero_Validating()

        Dim val As Integer = 0

        If Not Int32.TryParse(TextBox2.Text, val) Then
            ErrorProvider1.SetError(TextBox2, "El campo solo acepta numeros.")

        Else
            ErrorProvider1.SetError(TextBox2, "")
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Ingrese el Titulo de la Pelicula", MsgBoxStyle.Information, "Atencion")
            Return
        End If
        If ComboBox1.Text = "" Then
            MsgBox("Escoja una Categoria para la Pelicula", MsgBoxStyle.Information, "Atencion")
            Return
        End If
        If TextBox2.Text = "" Then
            MsgBox("Ingrese el Año de la Pelicula", MsgBoxStyle.Information, "Atencion")
            Return
        End If
        If TextBox3.Text = "" Then
            MsgBox("Ingrese la descripcion de la Pelicula", MsgBoxStyle.Information, "Atencion")
            Return
        End If

        If TextBox3.TextLength < 10 Then
            MsgBox("Se necesita mas descripcion para la pelicula")
            TextBox3.Focus()
            Return
        End If
        Dim val As Integer = 0

        If Not Int32.TryParse(TextBox2.Text, val) Then
            ErrorProvider1.SetError(TextBox2, "El campo solo acepta numeros.")

        Else

            MsgBox("Guardado con Exito")
            Form2.ListBox1.Items.Add("DETALLES")
            Form2.ListBox1.Items.Add("TITULO PELICULA: " + TextBox1.Text)
            Form2.ListBox1.Items.Add("CATEGORIA PELICULA: " + ComboBox1.Text)
            Form2.ListBox1.Items.Add("AÑO PELICULA: " + TextBox2.Text)
            Form2.ListBox1.Items.Add("DESCRIPCION PELICULA: " + TextBox3.Text)
            Form2.Show()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            ComboBox1.Items.Clear()
            ErrorProvider1.Clear()

        End If



    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Items.Add("Accion")
        ComboBox1.Items.Add("Terror")
        ComboBox1.Items.Add("Romantica")
        ComboBox1.Items.Add("Drama")
        ComboBox1.Items.Add("Comedia")
        ComboBox1.Items.Add("Docuental")


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
