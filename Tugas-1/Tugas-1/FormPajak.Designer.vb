<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPajak
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblJudul = New Label()
        grpPanduan = New GroupBox()
        lblPanduan3 = New Label()
        lblPanduan2 = New Label()
        lblPanduan1 = New Label()
        lblPendapatan = New Label()
        txtPendapatan = New TextBox()
        btnHitung = New Button()
        btnLogout = New Button()
        grpHasil = New GroupBox()
        lblHasilBersih = New Label()
        lblHasilPajak = New Label()
        grpPanduan.SuspendLayout()
        grpHasil.SuspendLayout()
        SuspendLayout()
        '
        ' lblJudul
        '
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblJudul.Location = New Point(45, 18)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(390, 30)
        lblJudul.TabIndex = 0
        lblJudul.Text = "FORM PERHITUNGAN PAJAK"
        lblJudul.TextAlign = ContentAlignment.MiddleCenter
        '
        ' grpPanduan
        '
        grpPanduan.Controls.Add(lblPanduan3)
        grpPanduan.Controls.Add(lblPanduan2)
        grpPanduan.Controls.Add(lblPanduan1)
        grpPanduan.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        grpPanduan.Location = New Point(30, 60)
        grpPanduan.Name = "grpPanduan"
        grpPanduan.Size = New Size(420, 115)
        grpPanduan.TabIndex = 1
        grpPanduan.TabStop = False
        grpPanduan.Text = "Panduan Persentase Pajak"
        '
        ' lblPanduan3
        '
        lblPanduan3.AutoSize = True
        lblPanduan3.Font = New Font("Segoe UI", 9.0F)
        lblPanduan3.Location = New Point(20, 80)
        lblPanduan3.Name = "lblPanduan3"
        lblPanduan3.Size = New Size(244, 20)
        lblPanduan3.TabIndex = 2
        lblPanduan3.Text = "• Pendapatan > 100.000.000 = 30%"
        '
        ' lblPanduan2
        '
        lblPanduan2.AutoSize = True
        lblPanduan2.Font = New Font("Segoe UI", 9.0F)
        lblPanduan2.Location = New Point(20, 53)
        lblPanduan2.Name = "lblPanduan2"
        lblPanduan2.Size = New Size(236, 20)
        lblPanduan2.TabIndex = 1
        lblPanduan2.Text = "• Pendapatan > 30.000.000 = 20%"
        '
        ' lblPanduan1
        '
        lblPanduan1.AutoSize = True
        lblPanduan1.Font = New Font("Segoe UI", 9.0F)
        lblPanduan1.Location = New Point(20, 26)
        lblPanduan1.Name = "lblPanduan1"
        lblPanduan1.Size = New Size(228, 20)
        lblPanduan1.TabIndex = 0
        lblPanduan1.Text = "• Pendapatan > 5.000.000 = 10%"
        '
        ' lblPendapatan
        '
        lblPendapatan.AutoSize = True
        lblPendapatan.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblPendapatan.Location = New Point(30, 192)
        lblPendapatan.Name = "lblPendapatan"
        lblPendapatan.Size = New Size(155, 20)
        lblPendapatan.TabIndex = 2
        lblPendapatan.Text = "Nominal Pendapatan:"
        '
        ' txtPendapatan
        '
        txtPendapatan.Location = New Point(195, 189)
        txtPendapatan.Name = "txtPendapatan"
        txtPendapatan.PlaceholderText = "Contoh: 15000000"
        txtPendapatan.Size = New Size(255, 27)
        txtPendapatan.TabIndex = 3
        '
        ' btnHitung
        '
        btnHitung.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnHitung.Location = New Point(195, 230)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(120, 36)
        btnHitung.TabIndex = 4
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        '
        ' btnLogout
        '
        btnLogout.Location = New Point(330, 230)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(120, 36)
        btnLogout.TabIndex = 5
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        '
        ' grpHasil
        '
        grpHasil.Controls.Add(lblHasilBersih)
        grpHasil.Controls.Add(lblHasilPajak)
        grpHasil.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        grpHasil.Location = New Point(30, 280)
        grpHasil.Name = "grpHasil"
        grpHasil.Size = New Size(420, 100)
        grpHasil.TabIndex = 6
        grpHasil.TabStop = False
        grpHasil.Text = "Hasil Perhitungan"
        '
        ' lblHasilBersih
        '
        lblHasilBersih.AutoSize = True
        lblHasilBersih.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblHasilBersih.ForeColor = Color.DarkGreen
        lblHasilBersih.Location = New Point(20, 60)
        lblHasilBersih.Name = "lblHasilBersih"
        lblHasilBersih.Size = New Size(198, 23)
        lblHasilBersih.TabIndex = 1
        lblHasilBersih.Text = "Pendapatan Bersih: Rp -"
        '
        ' lblHasilPajak
        '
        lblHasilPajak.AutoSize = True
        lblHasilPajak.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblHasilPajak.ForeColor = Color.DarkRed
        lblHasilPajak.Location = New Point(20, 28)
        lblHasilPajak.Name = "lblHasilPajak"
        lblHasilPajak.Size = New Size(141, 23)
        lblHasilPajak.TabIndex = 0
        lblHasilPajak.Text = "Total Pajak: Rp -"
        '
        ' FormPajak
        '
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(480, 405)
        Controls.Add(grpHasil)
        Controls.Add(btnLogout)
        Controls.Add(btnHitung)
        Controls.Add(txtPendapatan)
        Controls.Add(lblPendapatan)
        Controls.Add(grpPanduan)
        Controls.Add(lblJudul)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FormPajak"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Perhitungan Pajak"
        grpPanduan.ResumeLayout(False)
        grpPanduan.PerformLayout()
        grpHasil.ResumeLayout(False)
        grpHasil.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents grpPanduan As GroupBox
    Friend WithEvents lblPanduan1 As Label
    Friend WithEvents lblPanduan2 As Label
    Friend WithEvents lblPanduan3 As Label
    Friend WithEvents lblPendapatan As Label
    Friend WithEvents txtPendapatan As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents grpHasil As GroupBox
    Friend WithEvents lblHasilPajak As Label
    Friend WithEvents lblHasilBersih As Label

End Class
