<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        picAvatar = New PictureBox()
        lblRole = New Label()
        cmbRole = New ComboBox()
        lblNama = New Label()
        txtNama = New TextBox()
        lblNIM = New Label()
        txtNIM = New TextBox()
        btnLogin = New Button()
        CType(picAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        ' lblJudul
        '
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblJudul.Location = New Point(140, 15)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(163, 32)
        lblJudul.TabIndex = 0
        lblJudul.Text = "FORM LOGIN"
        lblJudul.TextAlign = ContentAlignment.MiddleCenter
        '
        ' picAvatar
        '
        picAvatar.BackColor = Color.Transparent
        picAvatar.BorderStyle = BorderStyle.FixedSingle
        picAvatar.Location = New Point(160, 55)
        picAvatar.Name = "picAvatar"
        picAvatar.Size = New Size(120, 120)
        picAvatar.SizeMode = PictureBoxSizeMode.Zoom
        picAvatar.TabIndex = 1
        picAvatar.TabStop = False
        '
        ' lblRole
        '
        lblRole.AutoSize = True
        lblRole.Location = New Point(50, 195)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(46, 20)
        lblRole.TabIndex = 2
        lblRole.Text = "Role :"
        '
        ' cmbRole
        '
        cmbRole.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"Staff", "Manager"})
        cmbRole.Location = New Point(140, 192)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(240, 28)
        cmbRole.TabIndex = 3
        '
        ' lblNama
        '
        lblNama.AutoSize = True
        lblNama.Location = New Point(50, 240)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(56, 20)
        lblNama.TabIndex = 4
        lblNama.Text = "Nama :"
        '
        ' txtNama
        '
        txtNama.Location = New Point(140, 237)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Masukkan nama pengguna"
        txtNama.Size = New Size(240, 27)
        txtNama.TabIndex = 5
        '
        ' lblNIM
        '
        lblNIM.AutoSize = True
        lblNIM.Location = New Point(50, 285)
        lblNIM.Name = "lblNIM"
        lblNIM.Size = New Size(44, 20)
        lblNIM.TabIndex = 6
        lblNIM.Text = "NIM :"
        '
        ' txtNIM
        '
        txtNIM.Location = New Point(140, 282)
        txtNIM.Name = "txtNIM"
        txtNIM.PlaceholderText = "Masukkan NIM pengguna"
        txtNIM.Size = New Size(240, 27)
        txtNIM.TabIndex = 7
        '
        ' btnLogin
        '
        btnLogin.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnLogin.Location = New Point(140, 330)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(240, 38)
        btnLogin.TabIndex = 8
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        '
        ' FormLogin
        '
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(430, 395)
        Controls.Add(btnLogin)
        Controls.Add(txtNIM)
        Controls.Add(lblNIM)
        Controls.Add(txtNama)
        Controls.Add(lblNama)
        Controls.Add(cmbRole)
        Controls.Add(lblRole)
        Controls.Add(picAvatar)
        Controls.Add(lblJudul)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Login"
        CType(picAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents picAvatar As PictureBox
    Friend WithEvents lblRole As Label
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblNIM As Label
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents btnLogin As Button

End Class
