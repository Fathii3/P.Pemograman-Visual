# PEMROGRAMAN VISUAL

# TUGAS 1: Aplikasi Login & Perhitungan Pajak (VB.NET)

---

## 1. Deskripsi Program

Aplikasi desktop berbasis **Windows Forms (VB.NET)** yang mengintegrasikan alur autentikasi dan perhitungan pajak penghasilan dalam dua form terpisah:
1. **`FormLogin`**: Form autentikasi yang dilengkapi pemfilteran karakter input secara *real-time*, validasi format string (Regex), pemformatan teks (*Proper Case*), dan pergantian avatar/gambar dinamis sesuai pilihan *role*.
2. **`FormPajak`**: Form kalkulator perpajakan berbasis aturan tingkatan pendapatan (*tiering*), dilengkapi normalisasi format angka ribuan dan kalkulasi gaji bersih.

---

## 2. Desain Antarmuka & Kontrol Form

### 2.1 FormLogin (`FormLogin.vb`)

* **Properti Form:**
  * `Text`: `Form Login`
  * `StartPosition`: `CenterScreen`

| Kontrol | Nama Objek (`Name`) | Properti Utama | Fungsi |
| :--- | :--- | :--- | :--- |
| **PictureBox** | `picImage` | `SizeMode = Zoom` | Menampilkan avatar (*Staff* / *Manager*) secara proporsional |
| **ComboBox** | `cmbRole` | `DropDownStyle = DropDownList`<br>`Items = Staff, Manager` | Pilihan role pengguna tanpa input manual |
| **Label** | `lblNama` | `Text = "Nama :"` | Label teks field Nama |
| **TextBox** | `txtNama` | `(Default)` | Input nama pengguna |
| **Label** | `lblNIM` | `Text = "NIM :"` | Label teks field NIM |
| **TextBox** | `txtNIM` | `MaxLength = 12` | Input NIM (dibatasi 12 karakter digit) |
| **Button** | `btnLogin` | `Text = "Login"` | Eksekusi validasi data dan pembukaan form berikutnya |

> **Konfigurasi Aset Gambar:**
> File `staff.png` dan `manager.png` diletakkan di dalam folder `assets/`. Properti file pada Solution Explorer diatur:
> - **Copy to Output Directory:** `Copy if newer`

---

### 2.2 FormPajak (`FormPajak.vb`)

* **Properti Form:**
  * `Text`: `Perhitungan Pajak` (atau default form)
  * `StartPosition`: `CenterScreen`

| Kontrol | Nama Objek (`Name`) | Properti Utama | Fungsi |
| :--- | :--- | :--- | :--- |
| **Label** | `lblPajak` | `Text = Pendapatan > 5 juta = 10% Pajak...` | Menampilkan ketentuan tarif pajak |
| **Label** | `lblPendapat` | `Text = "Masukkan Pendapatanmu"` | Petunjuk input nominal |
| **Label** | `lblRp` | `Text = "Rp."` | Simbol mata uang |
| **TextBox** | `txtPendapatan` | `(Default)` | Input nominal pendapatan |
| **Button** | `btnHitung` | `Text = "Hitung"` | Memicu kalkulasi pajak |

---

## 3. Logika Program & Implementasi Kode

### 3.1 `FormLogin.vb`

Logika pada form login menangani inisialisasi default, penggantian gambar dinamis, pencegahan input karakter non-digit, serta validasi kelayakan data sebelum navigasi ke form pajak.

```vb
Public Class FormLogin
    ' Inisialisasi awal saat form dimuat
    Private Sub FromLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRole.SelectedIndex = 0 ' Set pilihan default ComboBox ke "Staff"
    End Sub

    ' Pergantian gambar avatar berdasarkan role yang dipilih
    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        If cmbRole.SelectedItem.ToString() = "Staff" Then
            picImage.Image = System.Drawing.Image.FromFile("assets\staff.png")
        ElseIf cmbRole.SelectedItem.ToString() = "Manager" Then
            picImage.Image = System.Drawing.Image.FromFile("assets\manager.png")
        End If
    End Sub

    ' Filter keyboard: hanya mengizinkan digit (0-9) dan kontrol (Backspace) pada input NIM
    Private Sub txtNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIM.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Validasi menyeluruh dan proses login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim rawNama As String = txtNama.Text.Trim()
        Dim rawNIM As String = txtNIM.Text.Trim()
        Dim roleTerpilih As String = If(cmbRole.SelectedItem IsNot Nothing, cmbRole.SelectedItem.ToString(), "")

        ' 1. Validasi: Role harus dipilih
        If String.IsNullOrWhiteSpace(roleTerpilih) Then
            MessageBox.Show("Silakan pilih Role terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbRole.Focus()
            Return
        End If

        ' 2. Validasi: Field tidak boleh kosong
        If String.IsNullOrWhiteSpace(rawNama) OrElse String.IsNullOrWhiteSpace(rawNIM) Then
            MessageBox.Show("Nama dan NIM tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 3. Validasi: Nama hanya boleh huruf dan spasi
        If Not System.Text.RegularExpressions.Regex.IsMatch(rawNama, "^[a-zA-Z\s]+$") Then
            MessageBox.Show("Nama tidak valid! Tidak boleh menggunakan angka atau simbol seperti @.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
            Return
        End If

        ' 4. Validasi: NIM harus numerik murni
        If Not IsNumeric(rawNIM) Then
            MessageBox.Show("NIM hanya boleh berisi angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNIM.Focus()
            Return
        End If

        ' Format nama ke Proper Case (contoh: "fathi fadhil" -> "Fathi Fadhil")
        Dim namaRapi As String = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(rawNama.ToLower())
        txtNama.Text = namaRapi

        ' Dialog konfirmasi login berhasil
        Dim infoLogin As String = "Login Berhasil!" & vbCrLf &
                                  "Nama : " & namaRapi & vbCrLf &
                                  "NIM  : " & rawNIM & vbCrLf &
                                  "Role : " & roleTerpilih
        MessageBox.Show(infoLogin, "Informasi Login", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Pindah ke FormPajak
        Me.Hide()
        FormPajak.Show()
    End Sub
End Class
```

---

### 3.2 `FormPajak.vb`

Kalkulasi pajak menerapkan ketentuan tarif bertingkat:
* **Pendapatan > Rp 100.000.000**: Tarif **30%**
* **Pendapatan > Rp 30.000.000**: Tarif **20%**
* **Pendapatan > Rp 5.000.000**: Tarif **10%**
* **Pendapatan $\le$ Rp 5.000.000**: Tarif **0%**

```vb
Public Class FormPajak
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim pendapatan As Double
        Dim persenPajak As Double = 0
        Dim totalPajak As Double = 0

        ' Menghilangkan karakter titik pemisah ribuan agar input valid untuk konversi angka
        Dim nilaiInput As String = txtPendapatan.Text.Replace(".", "").Trim()

        ' Validasi input tidak boleh kosong
        If String.IsNullOrWhiteSpace(nilaiInput) Then
            MessageBox.Show("Silakan masukkan pendapatan/gaji terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPendapatan.Focus()
            Return
        End If

        ' Validasi konversi angka numerik dan batas nilai > 0
        If Double.TryParse(nilaiInput, pendapatan) AndAlso pendapatan > 0 Then
            ' Penentuan persentase pajak berdasarkan tiering
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

            ' Rincian hasil perhitungan
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
```

---

## 4. Rangkuman Fungsi & API Utama

| Fungsi / Metode | Kegunaan dalam Program |
| :--- | :--- |
| `System.Drawing.Image.FromFile(path)` | Memuat file citra dari direktori lokal ke kontrol `PictureBox` saat aplikasi berjalan. |
| `picImage.SizeMode = PictureBoxSizeMode.Zoom` | Menyesuaikan rasio gambar secara proporsional sesuai dimensi kontrol tanpa distorsi. |
| `Char.IsDigit(e.KeyChar)` | Memeriksa apakah karakter tombol yang ditekan merupakan digit angka (0–9). |
| `Char.IsControl(e.KeyChar)` | Memeriksa tombol kontrol sistem keyboard (misal: Backspace). |
| `e.Handled = True` | Membatalkan eksekusi pengetikan tombol keyboard sehingga karakter tidak ditampilkan di textbox. |
| `Regex.IsMatch(input, pattern)` | Validasi pola string dengan regular expression (`^[a-zA-Z\s]+$` untuk huruf dan spasi). |
| `TextInfo.ToTitleCase(string)` | Mengubah format penulisan kata menjadi huruf awal kapital (*Proper Case*). |
| `String.Replace(".", "")` | Menghapus tanda titik pemisah ribuan sebelum parsing desimal. |
| `Double.TryParse(input, hasil)` | Mengonversi teks ke numerik bertipe `Double` secara aman tanpa memicu crash. |
| `ToString("N0")` | Format tampilan numerik dengan pemisah ribuan standar (*Number format, 0 desimal*). |

---

## 5. Pengujian & Verifikasi Alur

| Skenario Pengujian | Masukan / Tindakan | Hasil yang Diharapkan |
| :--- | :--- | :--- |
| **Ganti Role** | Pilih `Manager` di ComboBox | Avatar berubah ke `manager.png` secara otomatis. |
| **Input NIM (Karakter Ilegal)** | Mengetik huruf atau simbol pada `txtNIM` | Input ditolak secara langsung (*real-time*). |
| **Input Nama (Format Ilegal)** | Mengisi `F4thi@` | Validasi Regex memicu dialog peringatan nama tidak valid. |
| **Normalisasi Nama** | Mengisi `fAtHi fAdHiL` | Nama diformat otomatis menjadi `Fathi Fadhil` pada MessageBox & TextBox. |
| **Navigasi Form** | Tombol Login diklik dengan data valid | Muncul info login, `FormLogin` disembunyikan, `FormPajak` dibuka. |
| **Normalisasi Titik Gaji** | Mengisi `10.000.000` pada pendapatan | Tanda titik dibersihkan, dihitung sebagai `10000000` (Pajak 10% = Rp 1.000.000, Bersih = Rp 9.000.000). |
| **Input Gaji Negatif / Nol** | Mengisi `-50000` atau `0` | Muncul dialog error "Masukkan angka gaji yang benar (harus lebih dari 0)". |
