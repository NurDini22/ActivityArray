Public Class Form2
    Private Sub btnPaparTwoDimensi_Click(sender As Object, e As EventArgs) Handles btnPaparTwoDimensi.Click
        Dim strKelas(5, 3) As String

        strKelas(0, 0) = "DDT1A"
        strKelas(0, 1) = "DDT1B"
        strKelas(1, 0) = "DDT2A"
        strKelas(1, 1) = "DDT2B"
        strKelas(1, 2) = "DDT2C"

        lblArrayTwoDimensi.Text = strKelas(0, 1)

    End Sub
End Class