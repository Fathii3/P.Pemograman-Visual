Public Class FormLogin
    Private Sub FromLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRole.SelectedIndex = 0 'Event saat form pertama kali dimuat dan pilihan default ComboBox ke Staff
    End Sub

    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        If cmbRole.SelectedItem.ToString() = "Staff" Then
            picImage.Image = System.Drawing.Image.FromFile("assets\staff.png")
        ElseIf cmbRole.SelectedItem.ToString() = "Manager" Then
            picImage.Image = System.Drawing.Image.FromFile("assets\manager.png")
        End If
    End Sub

    Private Sub txtNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIM.KeyPress
        'Membatasi ketikan di TextBox NIM agar hanya bisa angka dan backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim rawNama As String = txtNama.Text.Trim()
        Dim rawNIM As String = txtNIM.Text.Trim()
        Dim roleTerpilih As String = If(cmbRole.SelectedItem IsNot Nothing, cmbRole.SelectedItem.ToString(), "")

        If String.IsNullOrWhiteSpace(roleTerpilih) Then
            MessageBox.Show("Silakan pilih Role terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbRole.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(rawNama) OrElse String.IsNullOrWhiteSpace(rawNIM) Then
            MessageBox.Show("Nama dan NIM tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not System.Text.RegularExpressions.Regex.IsMatch(rawNama, "^[a-zA-Z\s]+$") Then
            MessageBox.Show("Nama tidak valid! Tidak boleh menggunakan angka atau simbol seperti @.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
            Return
        End If

        If Not IsNumeric(rawNIM) Then
            MessageBox.Show("NIM hanya boleh berisi angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNIM.Focus()
            Return
        End If

        'Format nama agar huruf awal kapital (Proper Case), contoh: "FATHi FadHIl" jadi "Fathi Fadhil"
        Dim namaRapi As String = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(rawNama.ToLower())
        txtNama.Text = namaRapi

        'ponytail: hardcoded accounts ceiling; upgrade to database/store when user accounts become dynamic
        Dim isValidUser As Boolean = (roleTerpilih = "Staff" AndAlso namaRapi = "Fathi" AndAlso rawNIM = "241712019") OrElse
                                     (roleTerpilih = "Manager" AndAlso namaRapi = "Fadhil" AndAlso rawNIM = "241712019")

        If Not isValidUser Then
            MessageBox.Show("Nama atau NIM tidak sesuai dengan Role yang dipilih!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Tampilkan informasi validasi login (Nama, NIM, Role)
        Dim infoLogin As String = "Login Berhasil!" & vbCrLf &
                                  "Nama : " & namaRapi & vbCrLf &
                                  "NIM  : " & rawNIM & vbCrLf &
                                  "Role : " & roleTerpilih
        MessageBox.Show(infoLogin, "Informasi Login", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Hide()
        FormPajak.Show()
    End Sub
End Class

