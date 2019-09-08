Imports info.lundin.math

Public Class Form1
    Dim a As Single
    Dim b As Single
    Dim c As Integer
    Dim x(50) As Single
    Dim err(50) As Single
    Dim ec As Single
    Dim i As Integer
    Dim redon As Integer

    Function f(x As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser()
        parser.Values.Clear()
        parser.Values.Add("x", x)
        Return parser.Parse(tf.Text)
    End Function

    Function fd(x As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser()
        parser.Values.Clear()
        parser.Values.Add("x", x)
        Return parser.Parse(td.Text)
    End Function

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        'a = ta.Text
        'b = tb.Text
        c = tc.Text
        ec = 0.5 * 10 ^ (-c)
        redon = c + 2
        'x(i) = (a + b) / 2
        'x(i) = (((a * f(b)) - (b * f(a))) / ((f(b) - f(a))))
        x(i) = ti.Text
        err(i) = 1
        'Salida.Rows.Add(i, Math.Round(a, redon), Math.Round(x(i), redon),
        '                    Math.Round(b, redon), Math.Round(f(a), redon),
        '                    Math.Round(f(x(i)), redon), Math.Round(f(b), redon),
        '                    "-------------")
        Salida.Rows.Add(i, Math.Round(x(i), redon), Math.Round(err(i), redon), "-------",
                            "--------", "--------",
                            "--------", "--------"
                            )

        Do While err(i) > ec
            'If f(a) * f(x(i)) < 0 Then
            '    b = x(i)
            'Else
            '    a = x(i)
            'End If
            i = i + 1
            'x(i) = (a + b) / 2
            'x(i) = (((a * f(b)) - (b * f(a))) / (f(b) - f(a)))
            x(i) = x(i - 1) - (f(x(i - 1)) / fd(x(i - 1)))
            err(i) = Math.Abs((x(i) - x(i - 1)) / x(i))

            'Salida.Rows.Add(i, Math.Round(a, redon), Math.Round(x(i), redon),
            '                Math.Round(b, redon), Math.Round(f(a), redon),
            '                Math.Round(f(x(i)), redon), Math.Round(f(b), redon),
            '                Math.Round(err(i), redon))
            Salida.Rows.Add(i, Math.Round(x(i), redon), Math.Round(err(i), redon), "------",
                            "--------", "--------",
                            "--------", "--------"
                            )
            salida2.Text = "La aproximación de raíz es: " + Math.Round(x(i), redon).ToString() + ", con un error de control de: " + Math.Round(err(i), redon).ToString()
        Loop
        salida2.Visible = True
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start("http://test.cua.uam.mx/MN/Methods/Raices/Biseccion/Biseccion.php")
    End Sub
End Class
