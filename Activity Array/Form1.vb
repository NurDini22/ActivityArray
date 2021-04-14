Public Class lbl
    Private Sub lblNamaHari_Click(sender As Object, e As EventArgs) Handles lblNamaHari.Click
        Dim strNamaHari(6) As String

        strNamaHari(0) = "Ahad"
        strNamaHari(1) = "Isnin"
        strNamaHari(2) = "Selasa"
        strNamaHari(3) = "Rabu"
        strNamaHari(4) = "Khamis"
        strNamaHari(5) = "Jumaat"
        strNamaHari(6) = "Sabtu"

        lblNamaHari.Text = strNamaHari(1)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblNamaHariInitialize.Click
        Dim strNamaHariInitialize() As String = {"Ahad", "Isnin", "Selasa"}

        lblNamaHariInitialize.Text = strNamaHariInitialize(0)
    End Sub

    Private Sub btnPapar_Click(sender As Object, e As EventArgs) Handles btnPapar.Click
        Dim strNamaHariNew() As String = {"Ahad", "Isnin", "Selasa", "Rabu", "Khamis", "Jumaat", "Sabtu"}
        Dim a As Integer

        Array.Reverse(strNamaHariNew)
        For a = 0 To 6
            ListBox1.Items.Add(strNamaHariNew(a))
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
