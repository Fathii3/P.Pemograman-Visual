Public Class FormLogin

    ' Data akun terdaftar: (Role, Nama, NIM)
    ' ponytail: hardcoded list suffices for assignment; replace with db query when backend exists
    Private ReadOnly akunTerdaftar As New List(Of (Role As String, Nama As String, NIM As String)) From {
        ("Staff", "staff", "12345"),
        ("Manager", "manager", "67890"),
        ("Staff", "budi", "12345"),
        ("Manager", "andi", "67890"),
        ("Staff", "fathi", "12345"),
        ("Manager", "fathi", "12345")
    }

    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        If cmbRole.SelectedItem Is Nothing Then
            If picAvatar.Image IsNot Nothing Then
                picAvatar.Image.Dispose()
                picAvatar.Image = Nothing
            End If
            Return
        End If

        Dim role As String = cmbRole.SelectedItem.ToString()
        Dim fileName As String = If(role = "Manager", "manager.png", "staff.png")
        Dim pathsToTry() As String = {
            IO.Path.Combine(Application.StartupPath, "assets", fileName),
            IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "assets", fileName),
            IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "assets", fileName),
            IO.Path.Combine("assets", fileName)
        }

        For Each p As String In pathsToTry
            If IO.File.Exists(p) Then
                If picAvatar.Image IsNot Nothing Then
                    picAvatar.Image.Dispose()
                End If
                picAvatar.Image = Image.FromFile(p)
                Exit For
            End If
        Next
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim roleInput As String = If(cmbRole.SelectedItem IsNot Nothing, cmbRole.SelectedItem.ToString(), "")
        Dim namaInput As String = txtNama.Text.Trim().ToLower()
        Dim nimInput As String = txtNIM.Text.Trim()

        ' Validasi pencocokan akun (Role, Nama dengan .ToLower(), NIM)
        Dim isValid As Boolean = akunTerdaftar.Any(Function(acc) _
            acc.Role.Equals(roleInput, StringComparison.OrdinalIgnoreCase) AndAlso
            acc.Nama.ToLower() = namaInput AndAlso
            acc.NIM = nimInput)

        If Not isValid Then
            MessageBox.Show("Masukkan Akun dengan Benar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Login berhasil: buka FormPajak dan sembunyikan FormLogin
        FormPajak.Show()
        Me.Hide()
    End Sub

End Class
