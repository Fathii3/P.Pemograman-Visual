# PEMROGRAMAN VISUAL

# PERTEMUAN 3: Struktur Kontrol Percabangan (If-Else), Validasi Input & PictureBox (VB.NET)

---

## 1. Pengertian & Konsep Dasar

### 1.1 Struktur Kontrol Percabangan (*Conditional Statement*)
**Percabangan (*Decision Making / Branching*)** adalah struktur logika dalam pemrograman yang memungkinkan alur eksekusi program memilih blok kode yang akan dijalankan berdasarkan evaluasi kondisi tertentu (bernilai `True` atau `False`).
* **`If...Then`**: Mengeksekusi blok kode jika kondisi terpenuhi (`True`).
* **`ElseIf`**: Menguji kondisi alternatif jika kondisi sebelumnya tidak terpenuhi.
* **`Else`**: Blok tindakan bawaan (*default*) jika seluruh kondisi pengujian bernilai salah (`False`).

### 1.2 Validasi Input (*Input Validation*)
**Validasi Input** adalah proses pengecekan dan penyaringan data masukan dari pengguna sebelum data tersebut diproses oleh logika sistem. Tujuannya untuk memastikan data sesuai dengan format, tipe data, serta batasan nilai yang diizinkan sehingga mencegah *runtime exception* atau *crash*.

### 1.3 Kontrol PictureBox
**PictureBox** adalah komponen kontrol grafis pada Windows Forms yang berfungsi untuk memuat, menampilkan, dan mengatur tata letak gambar (format `.jpg`, `.png`, `.gif`, dll.) di dalam form aplikasi secara dinamis saat program berjalan (*runtime*).

---

## 2. Ringkasan Praktikum

Pada praktikum pertemuan ke-3 ini, dipelajari implementasi gabungan antara **struktur percabangan**, **validasi input data berlapis**, dan **manipulasi kontrol grafis (`PictureBox`)** pada aplikasi Windows Forms (VB.NET).

Studi kasus yang dibuat adalah aplikasi **Evaluasi Nilai**:
* Pengguna memasukkan data nilai berupa angka (0–100).
* Sistem melakukan validasi karakter dan validasi rentang nilai secara otomatis.
* Sistem menampilkan gambar ilustrasi yang berbeda pada `PictureBox` sesuai kategori rentang nilai yang dimasukkan.

---

## 3. Komponen Kontrol yang Digunakan (Form Controls)

Aplikasi terdiri dari beberapa kontrol utama:

| Kontrol | Nama Objek (*Control Name*) | Properti Utama | Fungsi |
| :--- | :--- | :--- | :--- |
| **PictureBox** | `picImage` | `SizeMode = Zoom` | Menampilkan gambar/ilustrasi secara dinamis berdasarkan rentang nilai |
| **TextBox** | `txtNilai` | `Name = txtNilai` | Menerima input data nilai dari pengguna |
| **Button** | `btnInput` | `Text = "Input"` | Memicu proses validasi data dan penentuan gambar yang ditampilkan |

---

## 4. Logika Program & Event Handling (`Form1.vb`)

Berikut adalah penjelasan fungsi logika dan alur program:

### 4.1 Validasi Karakter Saat Pengetikan (`txtNilai_KeyPress`)
Mencegah pengguna mengetik karakter selain angka (digit) dan tombol kontrol (seperti *Backspace*) secara *real-time*.
```vb
Private Sub txtNilai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilai.KeyPress
    If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
        e.Handled = True
    End If
End Sub
```
> **Konsep Penting:**
> - `Char.IsDigit(e.KeyChar)`: Memeriksa apakah tombol yang ditekan adalah angka (0-9).
> - `Char.IsControl(e.KeyChar)`: Memeriksa tombol kontrol sistem (seperti Backspace/Delete).
> - `e.Handled = True`: Membatalkan input karakter jika bukan angka atau tombol kontrol, sehingga karakter tidak akan muncul pada TextBox.

---

### 4.2 Validasi Nilai & Percabangan Kondisi (`btnInput_Click`)
Memproses nilai yang dimasukkan dengan beberapa tahap pemeriksaan sebelum menampilkan gambar:

```vb
Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
    Dim nilai As Integer

    ' 1. Validasi apakah input berupa angka
    If Not Integer.TryParse(txtNilai.Text, nilai) Then
        MessageBox.Show("Masukan dalam bentuk angka")
        Return
    End If

    ' 2. Validasi batas rentang nilai (0 - 100)
    If nilai < 0 OrElse nilai > 100 Then
        MessageBox.Show("Masukkan Nilai 0-100")
        txtNilai.Focus()
        Return
    End If

    ' 3. Percabangan kondisi penentuan gambar
    If nilai <= 50 Then
        picImage.Image = Image.FromFile("asset\kc.jpg")
    ElseIf nilai <= 75 Then
        picImage.Image = Image.FromFile("asset\kc2.jpg")
    Else
        picImage.Image = Image.FromFile("asset\kc1.jpg")
    End If
End Sub
```

> **Alur Logika & Penjelasan:**
> 1. **`Integer.TryParse(txtNilai.Text, nilai)`**: Mengonversi teks ke bilangan bulat (*Integer*) dengan aman tanpa memicu *runtime exception* jika format salah.
> 2. **`OrElse`**: Operator logika disjungsi *short-circuit*; jika nilai kurang dari 0 atau lebih dari 100, pesan peringatan muncul dan kursor difokuskan kembali menggunakan `txtNilai.Focus()`.
> 3. **`Image.FromFile(...)`**: Memuat file gambar dari path direktori `asset` secara dinamis sesuai kategori nilai:
>    - `0 - 50` : Memuat `asset\kc.jpg`
>    - `51 - 75`: Memuat `asset\kc2.jpg`
>    - `76 - 100`: Memuat `asset\kc1.jpg`

---

## 5. Poin-Poin Kunci yang Dipelajari

1. **Struktur Percabangan (`If...ElseIf...Else...End If`):** Mengarahkan alur eksekusi program berdasarkan evaluasi kondisi logika.
2. **Validasi Input Multi-Level:** 
   - Validasi tingkat karakter pada event `KeyPress`.
   - Validasi tipe data numerik menggunakan `Integer.TryParse()`.
   - Validasi batasan rentang nilai (*range validation*).
3. **Pengelolaan State & Kontrol Form:** Menggunakan `Focus()` untuk mengarahkan pengguna langsung ke input yang bermasalah.
4. **Manipulasi Kontrol `PictureBox`:** Memuat dan mengganti gambar saat aplikasi berjalan (*runtime*) serta menyesuaikan skala tampilan gambar (`PictureBoxSizeMode.Zoom`).
