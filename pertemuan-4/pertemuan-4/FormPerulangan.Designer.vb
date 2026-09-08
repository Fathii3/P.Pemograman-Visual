<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPerulangan
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
        lblNilaiAwal = New Label()
        txtNilaiAwal = New TextBox()
        lblNilaiAkhir = New Label()
        btnInput = New Button()
        txtNilaiAkhir = New TextBox()
        lsHasil = New ListBox()
        SuspendLayout()
        ' 
        ' lblNilaiAwal
        ' 
        lblNilaiAwal.AutoSize = True
        lblNilaiAwal.Location = New Point(104, 68)
        lblNilaiAwal.Name = "lblNilaiAwal"
        lblNilaiAwal.Size = New Size(84, 20)
        lblNilaiAwal.TabIndex = 0
        lblNilaiAwal.Text = "Nilai Awal :"
        ' 
        ' txtNilaiAwal
        ' 
        txtNilaiAwal.Location = New Point(230, 68)
        txtNilaiAwal.Name = "txtNilaiAwal"
        txtNilaiAwal.Size = New Size(125, 27)
        txtNilaiAwal.TabIndex = 1
        ' 
        ' lblNilaiAkhir
        ' 
        lblNilaiAkhir.AutoSize = True
        lblNilaiAkhir.Location = New Point(104, 113)
        lblNilaiAkhir.Name = "lblNilaiAkhir"
        lblNilaiAkhir.Size = New Size(85, 20)
        lblNilaiAkhir.TabIndex = 2
        lblNilaiAkhir.Text = "Nilai Akhir :"
        ' 
        ' btnInput
        ' 
        btnInput.Location = New Point(245, 156)
        btnInput.Name = "btnInput"
        btnInput.Size = New Size(94, 29)
        btnInput.TabIndex = 3
        btnInput.Text = "Input"
        btnInput.UseVisualStyleBackColor = True
        ' 
        ' txtNilaiAkhir
        ' 
        txtNilaiAkhir.Location = New Point(230, 113)
        txtNilaiAkhir.Name = "txtNilaiAkhir"
        txtNilaiAkhir.Size = New Size(125, 27)
        txtNilaiAkhir.TabIndex = 4
        ' 
        ' lsHasil
        ' 
        lsHasil.FormattingEnabled = True
        lsHasil.Location = New Point(147, 231)
        lsHasil.Name = "lsHasil"
        lsHasil.Size = New Size(271, 124)
        lsHasil.TabIndex = 5
        ' 
        ' FormPerulangan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(570, 450)
        Controls.Add(lsHasil)
        Controls.Add(txtNilaiAkhir)
        Controls.Add(btnInput)
        Controls.Add(lblNilaiAkhir)
        Controls.Add(txtNilaiAwal)
        Controls.Add(lblNilaiAwal)
        Name = "FormPerulangan"
        Text = "FormPerulangan"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNilaiAwal As Label
    Friend WithEvents txtNilaiAwal As TextBox
    Friend WithEvents lblNilaiAkhir As Label
    Friend WithEvents btnInput As Button
    Friend WithEvents txtNilaiAkhir As TextBox
    Friend WithEvents lsHasil As ListBox

End Class
