Public Class SegundoParcial
    Dim X(50), Y(60), Z(60), ec, ex(60), ey(60), ez(60) As Single
    Dim i, k, redon, c As Integer

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        c = tc.Text
        redon = c + 2
        ec = 0.5 * 10 ^ (-c)
        ex(i) = 1
        ey(i) = 1
        ez(i) = 1
        Do While ex(i) > ec Or ey(i) > ec Or ez(i) > ec
            i = i + 1

            X(i) = (b1.Text - a12.Text * Y(i - 1) - a13.Text * Z(i - 1)) / a11.Text
            Y(i) = (b2.Text - a21.Text * X(i - 1) - a23.Text * Z(i - 1)) / a22.Text
            Z(i) = (b3.Text - a31.Text * X(i - 1) - a32.Text * Y(i - 1)) / a33.Text

            ex(i) = Math.Abs((X(i) - X(i - 1)) / X(i))
            ey(i) = Math.Abs((Y(i) - Y(i - 1)) / Y(i))
            ez(i) = Math.Abs((Z(i) - Z(i - 1)) / Z(i))

            Salida.Rows.Add(i, Math.Round(X(i), redon), Math.Round(Y(i), redon), Math.Round(Z(i), redon),
                            Math.Round(ex(i), redon), Math.Round(ey(i), redon), Math.Round(ez(i), redon))

        Loop
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub SegundoParcial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        Salida.Rows.Clear()
        a11.Clear()
        a12.Clear()
        a13.Clear()
        a21.Clear()
        a22.Clear()
        a23.Clear()
        a31.Clear()
        a32.Clear()
        a33.Clear()
        b1.Clear()
        b2.Clear()
        b3.Clear()
        tc.Clear()
        X.Initialize()
        Y.Initialize()
        Z.Initialize()
        ex.Initialize()
        ey.Initialize()
        ez.Initialize()
        ec = 0
        i = 0
    End Sub
End Class

