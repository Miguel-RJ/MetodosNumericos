Public Class Pares
    Dim Limite As Integer
    Dim x() As Double
    Dim y() As Double

    Private Sub BtnCalculat_Click(sender As Object, e As EventArgs) Handles BtnCalculat.Click
        Limite = txtLimite.Text
        Dim xp(Limite - 1), yp(Limite - 1) As Double

        For index = 1 To Limite
            For index2 = 0 To 1
                Dim LlenadoForm = New Llenado
                If index2 = 0 Then
                    LlenadoForm.Label1.Text = "Ingrese X(" + (index - 1).ToString() + ")"
                Else
                    LlenadoForm.Label1.Text = "Ingrese Y(" + (index - 1).ToString() + ")"
                End If
                If LlenadoForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    If index2 = 0 Then
                        xp(index - 1) = LlenadoForm.txtValor.Text
                    Else
                        yp(index - 1) = LlenadoForm.txtValor.Text
                    End If
                End If
            Next
        Next

        For index = 1 To Limite
            Salida.Rows.Add(index - 1, xp(index - 1), yp(index - 1))
        Next

        x = xp
        y = yp

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim s, m, xi, ib, xii, xia, coef As Double

        xia = Txn.Text

        For index = 1 To Limite
            If xia <= x(index) Then
                xi = x(index - 1)
                xii = x(index)
                ib = index - 1
                Exit For
            End If
        Next

        s = (xia - xi) / (xii - xi)
        m = Limite - (ib + 1)
        listSalidas.Items.Add("S=" + s.ToString())
        listSalidas.Items.Add("M=" + m.ToString())
        listSalidas.Items.Add("i=" + ib.ToString())
        Dim coefs(m) As Double
        For k = 1 To m
            coefs(0) = 1
            coef = 1
            For j = 1 To k
                coef = coef * (s - (j - 1)) / j
            Next
            coefs(k) = coef
            listSalidas.Items.Add("coefs(" + k.ToString() + ")=" + Math.Round(coefs(k), 4).ToString())
        Next

        Dim delta(m), deltaux As Double
        delta(0) = coefs(0)
        For k = 1 To m
            deltaux = 0
            For j = 0 To k
                coef = 1
                For p = 1 To j
                    coef = coef * (k - (j - p)) / p
                Next
                deltaux = deltaux + (-1) ^ j * coef * y(ib + k - j)
                delta(k) = deltaux
            Next
            listSalidas.Items.Add("delta(" + (k - 1).ToString() + ")=" + Math.Round(deltaux, 4).ToString())
        Next
        Dim suma As Double
        suma = y(ib)
        For K = 1 To m
            suma = suma + (coefs(K) * delta(K))
        Next
        listSalidas.Items.Add("Resultado = " + Math.Round(suma, 4).ToString())
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        Salida.Rows.Clear()
        txtLimite.Text = ""
        LBLIngrese.Text = "Ingrese cuantas filas"
    End Sub

End Class