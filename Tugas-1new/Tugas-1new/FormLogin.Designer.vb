<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        picImage = New PictureBox()
        btnLogin = New Button()
        txtNIM = New TextBox()
        lblNIM = New Label()
        cmbRole = New ComboBox()
        lblNama = New Label()
        txtNama = New TextBox()
        CType(picImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picImage
        ' 
        picImage.Location = New Point(155, 58)
        picImage.Name = "picImage"
        picImage.Size = New Size(125, 113)
        picImage.SizeMode = PictureBoxSizeMode.Zoom
        picImage.TabIndex = 0
        picImage.TabStop = False
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(168, 343)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 29)
        btnLogin.TabIndex = 1
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtNIM
        ' 
        txtNIM.Location = New Point(155, 278)
        txtNIM.MaxLength = 12
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(125, 27)
        txtNIM.TabIndex = 2
        ' 
        ' lblNIM
        ' 
        lblNIM.AutoSize = True
        lblNIM.Location = New Point(94, 285)
        lblNIM.Name = "lblNIM"
        lblNIM.Size = New Size(44, 20)
        lblNIM.TabIndex = 3
        lblNIM.Text = "NIM :"
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.ImeMode = ImeMode.NoControl
        cmbRole.Items.AddRange(New Object() {"Staff", "Manager"})
        cmbRole.Location = New Point(155, 177)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(125, 28)
        cmbRole.TabIndex = 4
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(82, 237)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(56, 20)
        lblNama.TabIndex = 6
        lblNama.Text = "Nama :"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(155, 230)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(125, 27)
        txtNama.TabIndex = 5
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(456, 468)
        Controls.Add(lblNama)
        Controls.Add(txtNama)
        Controls.Add(cmbRole)
        Controls.Add(lblNIM)
        Controls.Add(txtNIM)
        Controls.Add(btnLogin)
        Controls.Add(picImage)
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormLogin"
        CType(picImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picImage As PictureBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents lblNIM As Label
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox

End Class
