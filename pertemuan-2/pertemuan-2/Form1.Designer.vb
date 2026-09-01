<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlHeader = New Panel()
        lblHeaderSub = New Label()
        lblHeaderTitle = New Label()
        pnlCard = New Panel()
        btnKeluar = New Button()
        btnHapus = New Button()
        btnTampilkan = New Button()
        txtKom = New TextBox()
        lblKom = New Label()
        txtNim = New TextBox()
        lblNim = New Label()
        txtNama = New TextBox()
        spnnama = New Label()
        pnlHeader.SuspendLayout()
        pnlCard.SuspendLayout()
        SuspendLayout()
        '
        ' pnlHeader
        '
        pnlHeader.BackColor = Color.FromArgb(37, 99, 235)
        pnlHeader.Controls.Add(lblHeaderSub)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(484, 80)
        pnlHeader.TabIndex = 0
        '
        ' lblHeaderSub
        '
        lblHeaderSub.AutoSize = True
        lblHeaderSub.Font = New Font("Segoe UI", 9.0F)
        lblHeaderSub.ForeColor = Color.FromArgb(219, 234, 254)
        lblHeaderSub.Location = New Point(24, 44)
        lblHeaderSub.Name = "lblHeaderSub"
        lblHeaderSub.Size = New Size(295, 20)
        lblHeaderSub.TabIndex = 1
        lblHeaderSub.Text = "Silakan lengkapi formulir identitas di bawah ini"
        '
        ' lblHeaderTitle
        '
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI Semibold", 13.0F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.White
        lblHeaderTitle.Location = New Point(23, 14)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(244, 30)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "Data Profil Mahasiswa"
        '
        ' pnlCard
        '
        pnlCard.BackColor = Color.White
        pnlCard.Controls.Add(btnKeluar)
        pnlCard.Controls.Add(btnHapus)
        pnlCard.Controls.Add(btnTampilkan)
        pnlCard.Controls.Add(txtKom)
        pnlCard.Controls.Add(lblKom)
        pnlCard.Controls.Add(txtNim)
        pnlCard.Controls.Add(lblNim)
        pnlCard.Controls.Add(txtNama)
        pnlCard.Controls.Add(spnnama)
        pnlCard.Location = New Point(25, 100)
        pnlCard.Name = "pnlCard"
        pnlCard.Size = New Size(434, 315)
        pnlCard.TabIndex = 1
        '
        ' btnKeluar
        '
        btnKeluar.BackColor = Color.FromArgb(254, 242, 242)
        btnKeluar.Cursor = Cursors.Hand
        btnKeluar.FlatAppearance.BorderColor = Color.FromArgb(254, 202, 202)
        btnKeluar.FlatStyle = FlatStyle.Flat
        btnKeluar.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        btnKeluar.ForeColor = Color.FromArgb(220, 38, 38)
        btnKeluar.Location = New Point(310, 242)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(95, 38)
        btnKeluar.TabIndex = 8
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = False
        '
        ' btnHapus
        '
        btnHapus.BackColor = Color.FromArgb(241, 245, 249)
        btnHapus.Cursor = Cursors.Hand
        btnHapus.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225)
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        btnHapus.ForeColor = Color.FromArgb(71, 85, 105)
        btnHapus.Location = New Point(195, 242)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(105, 38)
        btnHapus.TabIndex = 7
        btnHapus.Text = "Bersihkan"
        btnHapus.UseVisualStyleBackColor = False
        '
        ' btnTampilkan
        '
        btnTampilkan.BackColor = Color.FromArgb(37, 99, 235)
        btnTampilkan.Cursor = Cursors.Hand
        btnTampilkan.FlatAppearance.BorderSize = 0
        btnTampilkan.FlatStyle = FlatStyle.Flat
        btnTampilkan.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnTampilkan.ForeColor = Color.White
        btnTampilkan.Location = New Point(25, 242)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(160, 38)
        btnTampilkan.TabIndex = 6
        btnTampilkan.Text = "Tampilkan Data"
        btnTampilkan.UseVisualStyleBackColor = False
        '
        ' txtKom
        '
        txtKom.Font = New Font("Segoe UI", 10.0F)
        txtKom.Location = New Point(25, 185)
        txtKom.Name = "txtKom"
        txtKom.PlaceholderText = "Contoh: KOM C"
        txtKom.Size = New Size(380, 30)
        txtKom.TabIndex = 5
        '
        ' lblKom
        '
        lblKom.AutoSize = True
        lblKom.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblKom.ForeColor = Color.FromArgb(51, 65, 85)
        lblKom.Location = New Point(25, 160)
        lblKom.Name = "lblKom"
        lblKom.Size = New Size(95, 20)
        lblKom.TabIndex = 4
        lblKom.Text = "KOM / Kelas"
        '
        ' txtNim
        '
        txtNim.Font = New Font("Segoe UI", 10.0F)
        txtNim.Location = New Point(25, 115)
        txtNim.Name = "txtNim"
        txtNim.PlaceholderText = "Contoh: 231401001"
        txtNim.Size = New Size(380, 30)
        txtNim.TabIndex = 3
        '
        ' lblNim
        '
        lblNim.AutoSize = True
        lblNim.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblNim.ForeColor = Color.FromArgb(51, 65, 85)
        lblNim.Location = New Point(25, 90)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(224, 20)
        lblNim.TabIndex = 2
        lblNim.Text = "NIM (Nomor Induk Mahasiswa)"
        '
        ' txtNama
        '
        txtNama.Font = New Font("Segoe UI", 10.0F)
        txtNama.Location = New Point(25, 45)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Masukkan nama lengkap"
        txtNama.Size = New Size(380, 30)
        txtNama.TabIndex = 1
        '
        ' spnnama
        '
        spnnama.AutoSize = True
        spnnama.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        spnnama.ForeColor = Color.FromArgb(51, 65, 85)
        spnnama.Location = New Point(25, 20)
        spnnama.Name = "spnnama"
        spnnama.Size = New Size(113, 20)
        spnnama.TabIndex = 0
        spnnama.Text = "Nama Lengkap"
        '
        ' Form1
        '
        AcceptButton = btnTampilkan
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(241, 245, 249)
        CancelButton = btnKeluar
        ClientSize = New Size(484, 440)
        Controls.Add(pnlCard)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sistem Profil Mahasiswa"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlCard.ResumeLayout(False)
        pnlCard.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblHeaderSub As Label
    Friend WithEvents pnlCard As Panel
    Friend WithEvents spnnama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblNim As Label
    Friend WithEvents txtNim As TextBox
    Friend WithEvents lblKom As Label
    Friend WithEvents txtKom As TextBox
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnKeluar As Button

End Class
