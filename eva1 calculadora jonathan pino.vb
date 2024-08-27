


Public Class form1
    Dim n1 As Double
    Dim n2 As Double
    Dim operation As String
    Private Sub btigual_clic(sender As Object, e As EventArgs) Handles btigual.Click
        If Not String.IsNullOrEmpty(txtDisplay.Text) Then
            n2 = Val(txtDisplay.Text)
            Try
                Select Case operation
                    Case "+"
                        txtDisplay.Text = (n1 + n2).ToString()
                    Case "-"
                        txtDisplay.Text = (n1 - n2).ToString()
                    Case "*"
                        txtDisplay.Text = (n1 * n2).ToString()
                    Case "/"
                        If n2 <> 0 Then
                            txtDisplay.Text = (n1 / n2).ToString()
                        Else
                            MessageBox.Show("Error: División por cero no permitida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Case Else
                        MessageBox.Show("Operación no válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Select
            Catch ex As Exception
                MessageBox.Show("Ocurrió un error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btborrar_clic(sender As Object, e As EventArgs) Handles btborrar.Click
        txtDisplay.Text = ""
        n1 = 0
        n2 = 0
        operation = ""
    End Sub

    Private Sub btcero_Click(sender As Object, e As EventArgs) Handles btcero.Click
        txtDisplay.Text &= "0"
    End Sub

    Private Sub btuno_Click(sender As Object, e As EventArgs) Handles btuno.Click
        txtDisplay.Text &= "1"
    End Sub

    Private Sub btdos_Click(sender As Object, e As EventArgs) Handles btdos.Click
        txtDisplay.Text &= "2"
    End Sub

    Private Sub bttres_Click(sender As Object, e As EventArgs) Handles bttres.Click
        txtDisplay.Text &= "3"
    End Sub

    Private Sub btcuatro_Click(sender As Object, e As EventArgs) Handles btcuatro.Click
        txtDisplay.Text &= "4"
    End Sub

    Private Sub btcinco_Click(sender As Object, e As EventArgs) Handles btcinco.Click
        txtDisplay.Text &= "5"
    End Sub

    Private Sub btseis_Click(sender As Object, e As EventArgs) Handles btseis.Click
        txtDisplay.Text &= "6"
    End Sub

    Private Sub btsiete_Click(sender As Object, e As EventArgs) Handles btsiete.Click
        txtDisplay.Text &= "7"
    End Sub

    Private Sub btocho_Click(sender As Object, e As EventArgs) Handles btocho.Click
        txtDisplay.Text &= "8"
    End Sub

    Private Sub btnueve_Click(sender As Object, e As EventArgs) Handles btnueve.Click
        txtDisplay.Text &= "9"
    End Sub

    Private Sub btsum_Click(sender As Object, e As EventArgs) Handles btsum.Click
        n1 = Val(txtDisplay.Text)
        operation = "+"
        txtDisplay.Text = ""
    End Sub

    Private Sub btrestar_Click(sender As Object, e As EventArgs) Handles btrestar.Click
        n1 = Val(txtDisplay.Text)
        operation = "-"
        txtDisplay.Text = ""
    End Sub

    Private Sub btmult_Click(sender As Object, e As EventArgs) Handles btmult.Click
        n1 = Val(txtDisplay.Text)
        operation = "*"
        txtDisplay.Text = ""
    End Sub

    Private Sub btdiv_Click(sender As Object, e As EventArgs) Handles btdiv.Click
        n1 = Val(txtDisplay.Text)
        operation = "/"
        txtDisplay.Text = ""
    End Sub
End Class