Public Class Form1

    Dim palabra As String
    Dim palabra_a_mostrar As String
    Dim palabra2() As String
    Dim longitud As Integer
    Dim letra As String
    Dim i As Integer = 0
    Dim x As Integer = 0
    Dim ñ As Integer = 0
    Dim cont_lose As Integer = 1
    Dim letras_incorrectas() As String 'CAPAZ QUE PUEDO HACERLO SOLO CON ESTE VECTOR Y NO NECESITARÍA "letras_incorrectas"
    Dim a As Integer = 0
    Dim letras_incorrectas_mostrar As String

    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click



        If (ñ < 1) Then
            palabra = LCase(txt1.Text)

            longitud = Len(palabra)

            lbl2.Text = longitud

            ReDim palabra2(longitud)

            For i = 0 To longitud
                palabra2(i) = "_"
            Next

            For i = 0 To (longitud - 1)
                palabra_a_mostrar = palabra_a_mostrar + palabra2(i)
            Next

            lbl1.Text = palabra_a_mostrar
            ñ = 1
        End If


        'MsgBox(palabra)
        'MsgBox(longitud)
        'MsgBox(palabra_a_mostrar)
        'MsgBox(palabra(0))

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        letra = LCase(txt2.Text)

        If (palabra.Contains(letra)) Then
            For i = 0 To longitud - 1
                If (palabra(i) = letra) Then
                    palabra2(i) = letra
                    palabra_a_mostrar = ""
                    txt2.Text = ""

                    For j = 0 To (longitud - 1)
                        palabra_a_mostrar = palabra_a_mostrar + palabra2(j)
                    Next

                    lbl1.Text = palabra_a_mostrar

                Else

                    palabra_a_mostrar = ""
                    txt2.Text = ""

                    For l = 0 To (longitud - 1)
                        palabra_a_mostrar = palabra_a_mostrar + palabra2(l)
                    Next

                    lbl1.Text = palabra_a_mostrar



                End If
            Next

            If (palabra = palabra_a_mostrar) Then
                MsgBox("ganaste")
                'ACÁ DEBERÍA LIMPIAR LA INTERFAZ Y LAS VARIABLES Y LA BANDERA (ñ) DEL PRIMER BOTON

            End If

        Else

            txt2.Text = ""

            Select Case cont_lose
                Case 1
                    Me.imagen.Image = Image.FromFile("C:\Users\ignacio\Desktop\img_ahorcado\a_2.jpg")
                Case 2
                    Me.imagen.Image = Image.FromFile("C:\Users\ignacio\Desktop\img_ahorcado\a_3.jpg")
                Case 3
                    Me.imagen.Image = Image.FromFile("C:\Users\ignacio\Desktop\img_ahorcado\a_4.jpg")
                Case 4
                    Me.imagen.Image = Image.FromFile("C:\Users\ignacio\Desktop\img_ahorcado\a_5.jpg")
                Case 5
                    Me.imagen.Image = Image.FromFile("C:\Users\ignacio\Desktop\img_ahorcado\a_6.jpg")
                Case 6
                    Me.imagen.Image = Image.FromFile("C:\Users\ignacio\Desktop\img_ahorcado\a_7.jpg")
                Case Else


            End Select

            cont_lose = cont_lose + 1

            ReDim Preserve letras_incorrectas(a)
            letras_incorrectas(a) = letra

            letras_incorrectas_mostrar = letras_incorrectas_mostrar + " " + letras_incorrectas(a)

            lbl4.Text = letras_incorrectas_mostrar
            a = a + 1

            If (cont_lose = 7) Then

                MsgBox("perdiste")

            End If

        End If

        'MsgBox(letra)
    End Sub

    Private Sub pasar_Click(sender As Object, e As EventArgs) Handles pasar.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
