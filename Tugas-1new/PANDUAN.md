# Panduan Lengkap Pembuatan Aplikasi Login & Hitung Pajak (VB.NET)
*Dari Nol (Langkah IDE di Luar Kode + Penjelasan Kode Program)*

---

## DAFTAR ISI
1. [Langkah 1: Membuat Proyek Baru di Visual Studio](#langkah-1-membuat-proyek-baru-di-visual-studio)
2. [Langkah 2: Menyiapkan Folder & File Gambar Aset](#langkah-2-menyiapkan-folder--file-gambar-aset)
3. [Langkah 3: Mendesain FormLogin (Drag & Drop Komponen)](#langkah-3-mendesain-formlogin-drag--drop-komponen)
4. [Langkah 4: Menghubungkan Event & Menulis Kode FormLogin](#langkah-4-menghubungkan-event--menulis-kode-formlogin)
5. [Langkah 5: Membuat & Mendesain FormPajak](#langkah-5-membuat--mendesain-formpajak)
6. [Langkah 6: Menulis Kode FormPajak](#langkah-6-menulis-kode-formpajak)
7. [Langkah 7: Menjalankan & Mengetes Program](#langkah-7-menjalankan--mengetes-program)
8. [Kamus Singkat Fungsi Kode VB](#kamus-singkat-fungsi-kode-vb)

---

## Langkah 1: Membuat Proyek Baru di Visual Studio
*(Di luar kode)*

1. Buka aplikasi **Visual Studio**.
2. Di layar awal, klik tombol **Create a new project**.
3. Di kolom pencarian atas:
   * Pilih bahasa: **Visual Basic**.
   * Pilih platform: **Windows**.
   * Pilih tipe: **Desktop**.
4. Pilih template bernama **Windows Forms App** (pastikan ikonnya bertuliskan **VB**). Klik **Next**.
5. Beri nama proyek (contoh: `Tugas-1new`), lalu klik **Next** → pilih Framework (contoh: `.NET 8.0` atau `.NET 10.0`) → klik **Create**.
6. Proyek baru akan terbuka dan menampilkan form kosong bernama `Form1.vb [Design]`.

---

## Langkah 2: Menyiapkan Folder & File Gambar Aset
*(Di luar kode)*

1. Cari panel **Solution Explorer** di sebelah kanan layar.
2. Klik kanan pada **nama proyek kamu** → arahkan ke **Add** → klik **New Folder**.
3. Beri nama folder tersebut: `assets`.
4. Buka File Explorer di Windows, cari gambar `staff.png` dan `manager.png`.
5. Copy kedua file gambar tersebut, lalu kembali ke Visual Studio, klik kanan folder `assets` → klik **Paste**.
6. **PENTING (Agar gambar tidak hilang saat aplikasi dijalankan):**
   * Klik file `staff.png` di Solution Explorer.
   * Di jendela **Properties** (kanan bawah), cari baris **Copy to Output Directory**.
   * Ubah nilainya menjadi **Copy if newer** (atau *PreserveNewest*).
   * Lakukan hal yang sama untuk file `manager.png`.

---

## Langkah 3: Mendesain FormLogin (Drag & Drop Komponen)
*(Di luar kode)*

1. Buka `Form1.vb [Design]`.
2. Jika panel **Toolbox** di sebelah kiri belum muncul, klik menu atas: **View** → **Toolbox**.
3. Tarik (drag & drop) komponen-komponen berikut dari Toolbox ke dalam Form:

| No | Komponen Toolbox | Nama di Properties (`(Name)`) | Pengaturan Properties Lainnya |
|:---|:---|:---|:---|
| 1 | **PictureBox** | `picImage` | • `SizeMode` = **Zoom** *(wajib agar gambar pas di kotak)*<br>• `Size` = `125, 113` |
| 2 | **ComboBox** | `cmbRole` | • `DropDownStyle` = **DropDownList** *(agar user tidak bisa mengetik teks sendiri)*<br>• `Items` = Klik tombol `(...)`, ketik dua baris:<br>&nbsp;&nbsp;`Staff`<br>&nbsp;&nbsp;`Manager` |
| 3 | **Label** | `lblNama` | • `Text` = `Nama :` |
| 4 | **TextBox** | `txtNama` | - |
| 5 | **Label** | `lblNIM` | • `Text` = `NIM :` |
| 6 | **TextBox** | `txtNIM` | • `MaxLength` = `12` *(maksimal digit NIM)* |
| 7 | **Button** | `btnLogin` | • `Text` = `Login` |

4. Pada area kosong Form, klik jendela **Properties**:
   * Ubah `Text` = `Form Login`.
   * Ubah `StartPosition` = `CenterScreen` *(agar form muncul di tengah layar)*.

---

## Langkah 4: Menghubungkan Event & Menulis Kode FormLogin
*(Langkah menghubungkan tombol ke kode)*

1. **Membuat Event Load:**
   * Double-click area kosong pada form → jendela kode akan terbuka dengan sub `FromLogin_Load`.
2. **Membuat Event Ganti Dropdown:**
   * Kembali ke tab Design, double-click pada komponen `cmbRole` → terbuka sub `cmbRole_SelectedIndexChanged`.
3. **Membuat Event Batasan Ketik NIM:**
   * Di tab Design, klik satu kali kotak `txtNIM`.
   * Di jendela Properties, klik ikon **Petir (Events)** di bagian atas.
   * Cari event bernama **KeyPress**, lalu double-click di kolom sebelahnya → terbuka sub `txtNIM_KeyPress`.
4. **Membuat Event Klik Tombol Login:**
   * Di tab Design, double-click tombol **Login** (`btnLogin`) → terbuka sub `btnLogin_Click`.

5. **Salin seluruh isi kode berikut ke `FormLogin.vb`:**

```vb
Public Class FormLogin

    ' Dijalankan otomatis saat form pertama kali dibuka
    Private Sub FromLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRole.SelectedIndex = 0 ' Pilihan default dropdown diarahkan ke "Staff"
    End Sub

    ' Dijalankan setiap kali user mengganti pilihan di dropdown
    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        If cmbRole.SelectedItem.ToString() = "Staff" Then
            picImage.Image = System.Drawing.Image.FromFile("assets\staff.png")
        ElseIf cmbRole.SelectedItem.ToString() = "Manager" Then
            picImage.Image = System.Drawing.Image.FromFile("assets\manager.png")
        End If
    End Sub

    ' Membatasi keyboard agar kotak NIM hanya bisa diketik angka dan Backspace
    Private Sub txtNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIM.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Batalkan input jika yang ditekan huruf/simbol
        End If
    End Sub

    ' Proses validasi saat tombol Login diklik
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

        ' 2. Validasi: Nama dan NIM tidak boleh kosong
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

        ' 4. Validasi: NIM harus angka murni
        If Not IsNumeric(rawNIM) Then
            MessageBox.Show("NIM hanya boleh berisi angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNIM.Focus()
            Return
        End If

        ' Format nama agar huruf depan tiap kata kapital (Proper Case): "FATHi FadHIl" -> "Fathi Fadhil"
        Dim namaRapi As String = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(rawNama.ToLower())
        txtNama.Text = namaRapi

        ' Tampilkan pop-up informasi hasil validasi login
        Dim infoLogin As String = "Login Berhasil!" & vbCrLf &
                                  "Nama : " & namaRapi & vbCrLf &
                                  "NIM  : " & rawNIM & vbCrLf &
                                  "Role : " & roleTerpilih
        MessageBox.Show(infoLogin, "Informasi Login", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Tutup/sembunyikan FormLogin dan buka FormPajak
        Me.Hide()
        FormPajak.Show()
    End Sub

End Class
```

---

## Langkah 5: Membuat & Mendesain FormPajak
*(Di luar kode)*

1. Di **Solution Explorer**, klik kanan pada nama proyek → **Add** → **Form (Windows Forms)...**
2. Beri nama file: `FormPajak.vb` → klik tombol **Add**.
3. Di tab `FormPajak.vb [Design]`, tarik komponen dari Toolbox:

| No | Komponen Toolbox | Nama di Properties (`(Name)`) | Pengaturan Properties Lainnya |
|:---|:---|:---|:---|
| 1 | **Label** | `lblPajak` | `Text` = `Pendapatan > 5 juta = 10% Pajak`<br>`Pendapatan > 30 juta = 20% Pajak`<br>`Pendapatan > 100 juta = 30% Pajak` |
| 2 | **Label** | `lblPendapat` | `Text` = `Masukkan Pendapatanmu` |
| 3 | **Label** | `lblRp` | `Text` = `Rp.` |
| 4 | **TextBox** | `txtPendapatan` | - |
| 5 | **Button** | `btnHitung` | `Text` = `Hitung` |

---

## Langkah 6: Menulis Kode FormPajak

1. Di tab `FormPajak.vb [Design]`, double-click tombol **Hitung** (`btnHitung`) untuk membuka jendela kodenya.
2. Salin kode berikut ke dalam `FormPajak.vb`:

```vb
Public Class FormPajak

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim pendapatan As Double
        Dim persenPajak As Double = 0
        Dim totalPajak As Double = 0

        ' Bersihkan titik agar angka ribuan seperti 10.000.000 tetap bisa dihitung
        Dim nilaiInput As String = txtPendapatan.Text.Replace(".", "").Trim()

        ' 1. Validasi: Gaji tidak boleh kosong
        If String.IsNullOrWhiteSpace(nilaiInput) Then
            MessageBox.Show("Silakan masukkan pendapatan/gaji terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPendapatan.Focus()
            Return
        End If

        ' 2. Validasi: Input harus angka dan lebih besar dari 0
        If Double.TryParse(nilaiInput, pendapatan) AndAlso pendapatan > 0 Then
            ' Logika percabangan persentase pajak
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

            ' Tampilkan informasi detail tanpa mengubah teks tombol Hitung
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

## Langkah 7: Menjalankan & Mengetes Program
*(Di luar kode)*

1. Klik tombol hijau segitiga **Start** di toolbar atas (atau tekan tombol **F5** di keyboard).
2. **Uji Form Login:**
   * Ubah dropdown dari *Staff* ke *Manager* → Gambar otomatis berganti dan tampil pas di kotak.
   * Masukkan nama dengan huruf acak (contoh: `FATHi FadHIl`).
   * Coba ketik huruf di kotak NIM → Otomatis tidak bisa diketik, hanya angka yang masuk (contoh: `12345`).
   * Klik tombol **Login** → Muncul kotak informasi dengan nama rapi: `Fathi Fadhil`, NIM `12345`, dan Role `Manager`.
   * Klik OK → FormLogin tertutup dan FormPajak otomatis terbuka.
3. **Uji Form Pajak:**
   * Ketik nominal gaji (contoh: `10.000.000` atau `10000000`).
   * Klik tombol **Hitung** → Teks tombol tetap "Hitung", dan muncul pop-up informasi lengkap berisi rincian: Gaji diinput, Persen Pajak (10%), Total Pajak (Rp 1.000.000), dan Gaji Bersih (Rp 9.000.000).

---

## Kamus Singkat Fungsi Kode VB

* **`picImage.SizeMode = PictureBoxSizeMode.Zoom`**  
  Menyusutkan gambar berukuran besar secara proporsional agar pas di dalam kotak PictureBox tanpa gepeng atau terpotong.
* **`IsNumeric(variabel)`**  
  Fungsi bawaan VB untuk mengecek apakah isi teks adalah angka valid (`True`) atau bukan (`False`).
* **`Char.IsDigit(e.KeyChar)` & `Char.IsControl(e.KeyChar)`**  
  Mendeteksi tombol keyboard: `IsDigit` mengecek angka 0-9, sedangkan `IsControl` mendeteksi tombol fungsi seperti Backspace/Delete.
* **`e.Handled = True`**  
  Membatalkan ketikan tombol keyboard sehingga karakter yang tidak diinginkan tidak akan muncul di layar.
* **`ToTitleCase(rawNama.ToLower())`**  
  Mengecilkan seluruh huruf terlebih dahulu, lalu membuat huruf pertama di setiap kata menjadi huruf kapital (Proper Case).
* **`.Replace(".", "")`**  
  Menghapus karakter titik dari teks input agar format ribuan (seperti `10.000.000`) bisa dihitung sebagai angka biasa (`10000000`).
* **`Double.TryParse(input, hasil)`**  
  Mengubah teks menjadi angka desimal/double secara aman tanpa memicu crash program bila teks salah format.
* **`.ToString("N0")`**  
  Memformat angka menjadi format ribuan dengan titik pemisah tanpa angka di belakang koma (contoh: `5000000` $\rightarrow$ `5.000.000`).
