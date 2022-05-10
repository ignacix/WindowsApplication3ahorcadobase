Public Class Form1
    Dim palabra As String
    Dim palabra_a_mostrar As String
    Dim palabra2() As String
    Dim longitud As Integer
    Dim letra As String
    Dim i As Integer = 0
    Dim x As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click
        palabra = txt1.Text
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


        'MsgBox(palabra)
        'MsgBox(longitud)
        'MsgBox(palabra_a_mostrar)
        'MsgBox(palabra(0))

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        letra = txt2.Text
        For i = 0 To longitud - 1
            If (palabra(i) = letra) Then
                palabra2(i) = letra
                palabra_a_mostrar = ""
                txt2.Text = ""
            End If
        Next

        For i = 0 To (longitud - 1)
            palabra_a_mostrar = palabra_a_mostrar + palabra2(i)
        Next

        lbl1.Text = palabra_a_mostrar


        'MsgBox(letra)
    End Sub
End Class
