# PEMROGRAMAN VISUAL

# PERTEMUAN 4: Struktur Kontrol Perulangan (For...Next), Parameter Step & ListBox (VB.NET)

---

## 1. Pengertian & Konsep Dasar

### 1.1 Struktur Kontrol Perulangan (*Looping / Iteration*)
**Perulangan (*Looping*)** adalah struktur logika dalam pemrograman yang memungkinkan sekumpulan instruksi dijalankan berulang kali selama kondisi tertentu terpenuhi atau sampai mencapai batas putaran yang ditentukan.
* **`For...To...Next`**: Struktur perulangan terhitung (*counted loop*) yang digunakan ketika jumlah iterasi atau batas awal dan akhir putaran sudah ditentukan.
* **Parameter `Step`**: Kata kunci opsional dalam perulangan `For` yang menentukan besar nilai kenaikan (*increment*) atau penurunan (*decrement*) variabel pencacah (*counter*) di setiap iterasi. Jika parameter ini tidak ditulis, nilai loncatan bawaan (*default*) adalah `1`.

### 1.2 Validasi Input (*Input Validation*)
Memastikan data masukan dari pengguna pada kontrol `TextBox` adalah angka bulat yang valid sebelum perulangan dieksekusi:
* **Event `KeyPress`**: Memfilter ketikan karakter pengguna secara langsung (*real-time*) agar hanya menerima angka dan tombol kendali.
* **Metode `Integer.TryParse()`**: Mengonversi teks string ke tipe data bilangan bulat (*Integer*) secara aman (*safe type parsing*) tanpa menimbulkan galat *unhandled runtime exception*.

### 1.3 Kontrol ListBox
**ListBox** adalah komponen antarmuka grafis pada Windows Forms yang berfungsi untuk menampilkan sekumpulan item atau daftar baris data:
* **Properti `.Items`**: Koleksi objek penampung elemen data di dalam ListBox.
* **Metode `.Items.Clear()`**: Mengosongkan seluruh item yang ada pada ListBox sebelum data baru dimasukkan agar hasil tidak bertumpuk.
* **Metode `.Items.Add(item)`**: Menambahkan elemen baru ke dalam daftar item ListBox.

---

## 2. Ringkasan Praktikum

Pada praktikum pertemuan ke-4 ini, dipelajari implementasi **struktur perulangan `For...Next`**, manipulasi langkah kenaikan menggunakan **parameter `Step`**, validasi input angka bertingkat, dan penyajian data ke kontrol antarmuka **`ListBox`** pada aplikasi Windows Forms (VB.NET).

Studi kasus yang dibuat adalah aplikasi **Form Perulangan (Deret Bilangan Berjarak)**:
* Pengguna menginputkan **Nilai Awal** dan **Nilai Akhir** pada form.
* Sistem memvalidasi kedua nilai input agar berformat angka bulat.
* Sistem membersihkan tampilan `ListBox` dari data sebelumnya (`lsHasil.Items.Clear()`).
* Program menjalankan perulangan dari nilai awal hingga nilai akhir dengan kenaikan langkah sebesar 2 (`Step 2`).
* Setiap angka hasil perulangan langsung dimasukkan dan ditampilkan ke dalam `ListBox` (`lsHasil`).

---

## 3. Komponen Kontrol yang Digunakan (Form Controls)

Aplikasi terdiri dari beberapa kontrol utama:

| Kontrol | Nama Objek (*Control Name*) | Properti Utama | Fungsi |
| :--- | :--- | :--- | :--- |
| **Label** | `lblNilaiAwal` | `Text = "Nilai Awal :"` | Menampilkan label teks instruksi input nilai awal |
| **TextBox** | `txtNilaiAwal` | `Name = txtNilaiAwal` | Menerima masukan nilai awal perulangan dari pengguna |
| **Label** | `lblNilaiAkhir` | `Text = "Nilai Akhir :"` | Menampilkan label teks instruksi input nilai akhir |
| **TextBox** | `txtNilaiAkhir` | `Name = txtNilaiAkhir` | Menerima masukan batas nilai akhir perulangan dari pengguna |
| **Button** | `btnInput` | `Text = "Input"` | Memicu proses validasi data dan eksekusi perulangan |
| **ListBox** | `lsHasil` | `Name = lsHasil` | Menampilkan deret angka hasil iterasi perulangan |

---

## 4. Logika Program & Event Handling (`FormPerulangan.vb`)

Berikut adalah penjelasan fungsi logika dan alur program:

### 4.1 Validasi Karakter Saat Pengetikan (`KeyPress`)
Mencegah pengetikan selain karakter angka (digit) dan tombol kontrol (seperti *Backspace*) secara *real-time* pada kolom nilai awal maupun nilai akhir:

```vb
Private Sub txtNilaiAwal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilaiAwal.KeyPress
    If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
        e.Handled = True
    End If
End Sub

Private Sub txtNilaiAkhir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilaiAkhir.KeyPress
    If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
        e.Handled = True
    End If
End Sub
```

> **Konsep Penting:**
> - `Char.IsDigit(e.KeyChar)`: Memeriksa apakah karakter yang ditekan adalah angka (0–9).
> - `Char.IsControl(e.KeyChar)`: Memeriksa apakah karakter adalah tombol kontrol sistem (seperti Backspace).
> - `e.Handled = True`: Membatalkan input karakter jika bukan angka atau tombol kontrol sehingga karakter tidak muncul di TextBox.

---

### 4.2 Pemrosesan Data & Eksekusi Perulangan (`btnInput_Click`)
Memproses nilai awal dan akhir dengan pengecekan data, pengosongan daftar sebelumnya, serta penambahan hasil deret ke `ListBox`:

```vb
Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
    Dim nilaiAwal As Integer
    Dim nilaiAkhir As Integer

    ' 1. Validasi konversi Nilai Awal
    If Not Integer.TryParse(txtNilaiAwal.Text, nilaiAwal) Then
        MessageBox.Show("Masukkan dalam bentuk Angka")
        txtNilaiAwal.Focus()
        Return
    End If

    ' 2. Validasi konversi Nilai Akhir
    If Not Integer.TryParse(txtNilaiAkhir.Text, nilaiAkhir) Then
        MessageBox.Show("Masukkan dalam bentuk Angka")
        txtNilaiAkhir.Focus()
        Return
    End If

    ' 3. Mengosongkan item ListBox dari hasil sebelumnya
    lsHasil.Items.Clear()

    ' 4. Perulangan dari nilaiAwal sampai nilaiAkhir dengan penambahan 2 (Step 2)
    For i As Integer = nilaiAwal To nilaiAkhir Step 2
        lsHasil.Items.Add(i)
    Next
End Sub
```

> **Alur Logika & Penjelasan:**
> 1. **`Integer.TryParse(..., ...)`**: Mengonversi teks input menjadi tipe `Integer` secara aman. Jika gagal atau kosong, kotak pesan peringatan muncul dan kursor difokuskan kembali dengan `.Focus()`.
> 2. **`lsHasil.Items.Clear()`**: Mengosongkan item `ListBox` agar hasil iterasi baru tidak bertumpuk dengan hasil komputasi sebelumnya.
> 3. **`For i As Integer = nilaiAwal To nilaiAkhir Step 2`**: Memulai iterasi dari nilai awal hingga nilai akhir dengan kenaikan langkah sebesar `2`.
> 4. **`lsHasil.Items.Add(i)`**: Menambahkan nilai variabel pencacah `i` pada setiap putaran iterasi ke dalam daftar koleksi item `ListBox`.

---

## 5. Poin-Poin Kunci yang Dipelajari

1. **Struktur Kontrol Perulangan (`For...To...Step...Next`):** Mengontrol eksekusi kode berulang dengan batasan nilai tertentu dan parameter kenaikan langkah (`Step`).
2. **Pengelolaan Komponen ListBox:** Menampilkan data koleksi secara dinamis menggunakan `.Items.Add()` serta mereset daftar menggunakan `.Items.Clear()`.
3. **Validasi Input Berlapis:** Menerapkan filter pengetikan keyboard (*event `KeyPress`*) dan validasi konversi tipe numerik (*`Integer.TryParse`*).
4. **Fokus Kontrol Antarmuka:** Menggunakan `.Focus()` untuk mengarahkan pengalaman pengguna (*user experience*) secara intuitif ke kontrol yang memerlukan perbaikan input.
