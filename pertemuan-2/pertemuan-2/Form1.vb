Public Class Form1
    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        ' Validasi input sederhana agar lebih ramah pengguna
        If String.IsNullOrWhiteSpace(txtNama.Text) OrElse
           String.IsNullOrWhiteSpace(txtNim.Text) OrElse
           String.IsNullOrWhiteSpace(txtKom.Text) Then

            MessageBox.Show("Mohon lengkapi semua data (Nama, NIM, dan KOM) sebelum menampilkan!",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Return
        End If

        Dim pesan As String = "Informasi Profil Mahasiswa:" & vbCrLf & vbCrLf &
                              "Nama : " & txtNama.Text.Trim() & vbCrLf &
                              "NIM  : " & txtNim.Text.Trim() & vbCrLf &
                              "KOM  : " & txtKom.Text.Trim()

        MessageBox.Show(pesan, "Data Berhasil Dimuat", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        txtNama.Clear()
        txtNim.Clear()
        txtKom.Clear()
        txtNama.Focus()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim konfirmasi = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?",
                                         "Konfirmasi Keluar",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
