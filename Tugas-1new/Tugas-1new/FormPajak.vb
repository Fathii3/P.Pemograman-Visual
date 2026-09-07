Public Class FormPajak
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim pendapatan As Double
        Dim persenPajak As Double = 0
        Dim totalPajak As Double = 0

        'Hilangkan titik jika pengguna mengetik angka seperti 10.000.000
        Dim nilaiInput As String = txtPendapatan.Text.Replace(".", "").Trim()

        If String.IsNullOrWhiteSpace(nilaiInput) Then
            MessageBox.Show("Silakan masukkan pendapatan/gaji terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPendapatan.Focus()
            Return
        End If

        'Validasi input harus angka dan lebih dari 0
        If Double.TryParse(nilaiInput, pendapatan) AndAlso pendapatan > 0 Then
            If pendapatan > 100000000 Then
                persenPajak = 0.3
            ElseIf pendapatan > 30000000 Then
                persenPajak = 0.2
            ElseIf pendapatan > 5000000 Then
                persenPajak = 0.1
            Else
                persenPajak = 0.0
            End If

            totalPajak = pendapatan * persenPajak
            Dim persenTeks As String = (persenPajak * 100).ToString() & "%"

            'Tampilkan detail informasi gaji diinput, persen pajak, dan harga pajak
            '(Teks tombol hitung tidak diubah)
            Dim pesan As String = "Informasi Pajak:" & vbCrLf &
                                  "Gaji yang Diinput: Rp " & pendapatan.ToString("N0") & vbCrLf &
                                  "Persentase Pajak: " & persenTeks & vbCrLf &
                                  "Total Harga Pajak: Rp " & totalPajak.ToString("N0") & vbCrLf &
                                  "Gaji Bersih: Rp " & (pendapatan - totalPajak).ToString("N0")

            MessageBox.Show(pesan, "Informasi Perhitungan Pajak", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Masukkan angka gaji yang benar (harus lebih dari 0)!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPendapatan.Focus()
        End If
    End Sub

    Private Sub FormPajak_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class