Public Class Pares
    Dim Limite, i As Integer

    Private Sub BtnCalculat_Click(sender As Object, e As EventArgs) Handles BtnCalculat.Click
        Limite = txtLimite.Text
        Dim x(Limite, 1) As Integer
        x.Initialize()
        For index = 1 To Limite
            For index2 = 0 To 1
                Dim LlenadoForm = New Llenado
                If index2 = 0 Then
                    LlenadoForm.Label1.Text = "Ingrese X(" + (index - 1).ToString() + ")"
                Else
                    LlenadoForm.Label1.Text = "Ingrese Y(" + (index - 1).ToString() + ")"
                End If
                If LlenadoForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    x(index - 1, index2) = LlenadoForm.txtValor.Text
                End If
            Next
        Next
        For index = 1 To x.Length \ 2 - 1
            Salida.Rows.Add(index - 1, x(index - 1, 0), x(index - 1, 1))
        Next
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        Salida.Rows.Clear()
        txtLimite.Text = ""
        i = 0
        LBLIngrese.Text = "Ingrese cuantas filas"
    End Sub

End Class