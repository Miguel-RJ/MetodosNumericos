Imports info.lundin.math

Public Class PrimerParcial
    Dim a As Single
    Dim b As Single
    Dim c As Integer
    Dim x(50) As Single
    Dim err(50) As Single
    Dim ec As Single
    Dim i As Integer
    Dim redon As Integer
    Dim formula As Integer


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
        Limpiar.Enabled = True
        c = tc.Text
        ec = 0.5 * 10 ^ (-c)
        redon = c + 2
        err(i) = 1
        Select Case CBOpe.SelectedItem
            Case "Bisección"
                a = ta.Text
                b = tb.Text
                x(i) = (a + b) / 2
                Salida.Rows.Add(i, Math.Round(a, redon), Math.Round(x(i), redon),
                    Math.Round(b, redon), Math.Round(f(a), redon),
                    Math.Round(f(x(i)), redon), Math.Round(f(b), redon),
                    "-------------")

            Case "Regla Falsa"
                a = ta.Text
                b = tb.Text
                x(i) = (((a * f(b)) - (b * f(a))) / (f(b) - f(a)))
                Salida.Rows.Add(i, Math.Round(a, redon), Math.Round(x(i), redon),
                    Math.Round(b, redon), Math.Round(f(a), redon),
                    Math.Round(f(x(i)), redon), Math.Round(f(b), redon),
                    "-------------")

            Case "Newton-Raphson"
                x(i) = ti.Text
                Salida.Rows.Add(i, Math.Round(x(i), redon), Math.Round(err(i), redon), "-------",
                                    "--------", "--------", "--------", "--------")
            Case Else

        End Select

        Do While err(i) > ec
            Select Case CBOpe.SelectedItem
                Case "Bisección"
                    If f(a) * f(x(i)) < 0 Then
                        b = x(i)
                    Else
                        a = x(i)
                    End If

                    i = i + 1
                    x(i) = (a + b) / 2
                    err(i) = Math.Abs((x(i) - x(i - 1)) / x(i))

                    Salida.Rows.Add(i, Math.Round(a, redon), Math.Round(x(i), redon),
                        Math.Round(b, redon), Math.Round(f(a), redon),
                        Math.Round(f(x(i)), redon), Math.Round(f(b), redon),
                        Math.Round(err(i), redon))
                Case "Regla Falsa"
                    If f(a) * f(x(i)) < 0 Then
                        b = x(i)
                    Else
                        a = x(i)
                    End If

                    i = i + 1
                    x(i) = (((a * f(b)) - (b * f(a))) / (f(b) - f(a)))
                    err(i) = Math.Abs((x(i) - x(i - 1)) / x(i))

                    Salida.Rows.Add(i, Math.Round(a, redon), Math.Round(x(i), redon),
                        Math.Round(b, redon), Math.Round(f(a), redon),
                        Math.Round(f(x(i)), redon), Math.Round(f(b), redon),
                        Math.Round(err(i), redon))
                Case "Newton-Raphson"
                    i = i + 1
                    x(i) = x(i - 1) - (f(x(i - 1)) / fd(x(i - 1)))
                    err(i) = Math.Abs((x(i) - x(i - 1)) / x(i))

                    Salida.Rows.Add(i, Math.Round(x(i), redon), Math.Round(err(i), redon), "------",
                            "--------", "--------", "--------", "--------")
                Case Else

            End Select
            salida2.Text = "La aproximación de raíz es: " + Math.Round(x(i), redon).ToString() + ", con un error de control de: " + Math.Round(err(i), redon).ToString()
        Loop
        salida2.Visible = True
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Process.Start("http://test.cua.uam.mx/MN/Methods/Raices/Biseccion/Biseccion.php")
    End Sub

    Private Sub CBOpe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOpe.SelectedIndexChanged
        Select Case CBOpe.SelectedItem
            Case "Bisección"
                ta.Enabled = True
                tb.Enabled = True
                td.Enabled = False
                ti.Enabled = False
                Calcular.Enabled = True
            Case "Regla Falsa"
                ta.Enabled = True
                tb.Enabled = True
                td.Enabled = False
                ti.Enabled = False
                Calcular.Enabled = True
            Case "Newton-Raphson"
                ta.Enabled = False
                tb.Enabled = False
                td.Enabled = True
                ti.Enabled = True
                Calcular.Enabled = True
            Case Else
                Calcular.Enabled = False
        End Select
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        tf.Clear()
        ta.Clear()
        tb.Clear()
        tc.Clear()
        td.Clear()
        ti.Clear()
        Salida.Rows.Clear()

    End Sub

    Private Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        ActiveForm.Hide()
        Dim MenuForm As New Menu()
        MenuForm.Show()
    End Sub
End Class
