Public Class Menu
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub Ir_Click(sender As Object, e As EventArgs) Handles Ir.Click
        Select Case CBSelect.SelectedItem
            Case "Primer Parcial"
                ActiveForm.Hide()
                Dim PrimerParcialForm As New PrimerParcial()
                PrimerParcialForm.Show()
            Case "Segundo Parcial"
                ActiveForm.Hide()
                Dim SegundoParcialForm As New SegundoParcial()
                SegundoParcialForm.Show()
            Case Else

        End Select
    End Sub
End Class