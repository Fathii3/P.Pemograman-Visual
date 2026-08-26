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
        spnnama = New Label()
        txtNama = New TextBox()
        txtNim = New TextBox()
        lblNim = New Label()
        lblKom = New Label()
        txtKom = New TextBox()
        btnTampilkan = New Button()
        btnHapus = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' spnnama
        ' 
        spnnama.AutoSize = True
        spnnama.Location = New Point(102, 27)
        spnnama.Name = "spnnama"
        spnnama.Size = New Size(56, 20)
        spnnama.TabIndex = 0
        spnnama.Text = "Nama :"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(176, 27)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(125, 27)
        txtNama.TabIndex = 1
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(176, 85)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(125, 27)
        txtNim.TabIndex = 2
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Location = New Point(114, 85)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(44, 20)
        lblNim.TabIndex = 3
        lblNim.Text = "NIM :"
        ' 
        ' lblKom
        ' 
        lblKom.AutoSize = True
        lblKom.Location = New Point(110, 146)
        lblKom.Name = "lblKom"
        lblKom.Size = New Size(48, 20)
        lblKom.TabIndex = 5
        lblKom.Text = "KOM :"
        ' 
        ' txtKom
        ' 
        txtKom.Location = New Point(176, 143)
        txtKom.Name = "txtKom"
        txtKom.Size = New Size(125, 27)
        txtKom.TabIndex = 4
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.Location = New Point(224, 216)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(94, 29)
        btnTampilkan.TabIndex = 6
        btnTampilkan.Text = "Tampilkan"
        btnTampilkan.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(339, 216)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 7
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(275, 274)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(94, 29)
        btnKeluar.TabIndex = 8
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(672, 362)
        Controls.Add(btnKeluar)
        Controls.Add(btnHapus)
        Controls.Add(btnTampilkan)
        Controls.Add(lblKom)
        Controls.Add(txtKom)
        Controls.Add(lblNim)
        Controls.Add(txtNim)
        Controls.Add(txtNama)
        Controls.Add(spnnama)
        Name = "Form1"
        Text = "Profile Mahasiswa"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents spnnama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents lblNim As Label
    Friend WithEvents lblKom As Label
    Friend WithEvents txtKom As TextBox
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnKeluar As Button

End Class
