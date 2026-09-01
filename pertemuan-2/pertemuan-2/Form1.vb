Public Class Form1
    Private Sub spnnama_Click(sender As Object, e As EventArgs) Handles spnnama.Click

    End Sub

    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        MessageBox.Show("Selamat Datang" & vbCrLf &
            "Nama   : " & txtNama.Text & vbCrLf &
            "NIM    : " & txtNim.Text & vbCrLf &
            "KOM    : " & txtKom.Text
            )
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        txtNama.Clear()
        txtNim.Clear()
        txtKom.Clear()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class
