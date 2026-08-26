# PEMROGRAMAN VISUAL

# PERTEMUAN 2: Pengenalan Windows Forms & Event Handling Dasar (VB.NET)

---

## Ringkasan Materi

Pada pertemuan ke-2 ini, dipelajari implementasi dasar aplikasi desktop berbasis **Windows Forms (VB.NET)** dengan studi kasus pembuatan form input **Profile Mahasiswa**. Mahasiswa mempraktikkan cara mendesain antarmuka grafis (GUI) sederhana dan menghubungkan kontrol visual dengan kode logika program (Event Handling).

---

## Komponen Kontrol yang Digunakan (Form Controls)

Aplikasi terdiri dari beberapa kontrol utama:

| Kontrol | Nama Objek (*Control Name*) | Fungsi |
| :--- | :--- | :--- |
| **Label** | `spnnama`, `lblNim`, `lblKom` | Menampilkan teks instruksi/label statis (*Nama, NIM, KOM*) |
| **TextBox** | `txtNama`, `txtNim`, `txtKom` | Area input teks dari pengguna untuk memasukkan data |
| **Button** | `btnTampilkan` | Memicu aksi untuk menampilkan data ke kotak pesan (*MessageBox*) |
| **Button** | `btnHapus` | Mengosongkan seluruh kolom input form |
| **Button** | `btnKeluar` | Menutup aplikasi |

---

## Logika Program & Event Handling (`Form1.vb`)

Berikut adalah penjelasan fungsi logika pada tombol-tombol yang dibuat:

### 1. Menampilkan Data (`btnTampilkan_Click`)
Mengambil nilai dari properti `.Text` masing-masing `TextBox` dan menampilkannya melalui dialog box `MessageBox.Show()`.
```vb
Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
    MessageBox.Show("Selamat Datang" & vbCrLf &
        "Nama   : " & txtNama.Text & vbCrLf &
        "NIM    : " & txtNim.Text & vbCrLf &
        "KOM    : " & txtKom.Text
        )
End Sub
```
> **Konsep Penting:**
> - `&` : Operator penggabungan teks (*String Concatenation*).
> - `vbCrLf` : Konstanta untuk membuat baris baru (*Carriage Return + Line Feed / Enter*).

---

### 2. Mengosongkan Input (`btnHapus_Click`)
Membersihkan teks di dalam TextBox agar pengguna dapat mengisi kembali dari awal menggunakan method `.Clear()`.
```vb
Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
    txtNama.Clear()
    txtNim.Clear()
    txtKom.Clear()
End Sub
```

---

### 3. Menutup Aplikasi (`btnKeluar_Click`)
Menutup jendela form dan mengakhiri jalannya aplikasi menggunakan perintah `Me.Close()`.
```vb
Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
    Me.Close()
End Sub
```

---

## Poin-Poin Kunci yang Dipelajari

1. **GUI Designer:** Memposisikan kontrol pada Form menggunakan drag-and-drop dan mengatur properti seperti `Text`, `Name`, `Size`, dan `Location`.
2. **Event Driven Programming:** Program berjalan berdasarkan aksi/kejadian yang dipicu oleh user (misalnya event `Click` pada button).
3. **Manipulasi Input:** Membaca data input (`TextBox.Text`) dan mereset nilai kontrol (`TextBox.Clear()`).
4. **Interaksi Dialog:** Menggunakan `MessageBox.Show()` untuk memberikan output informasi kepada pengguna.
