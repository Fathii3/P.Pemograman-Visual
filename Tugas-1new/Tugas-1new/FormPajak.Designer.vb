<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPajak
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblPajak = New Label()
        lblPendapat = New Label()
        btnHitung = New Button()
        lblRp = New Label()
        txtPendapatan = New TextBox()
        SuspendLayout()
        ' 
        ' lblPajak
        ' 
        lblPajak.AutoSize = True
        lblPajak.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblPajak.Location = New Point(89, 52)
        lblPajak.Name = "lblPajak"
        lblPajak.Size = New Size(389, 84)
        lblPajak.TabIndex = 0
        lblPajak.Text = "Pendapatan lebih dari 5 juta, 10% Pajak" & vbCrLf & "Pendapatan lebih dari 30 juta, 20% Pajak" & vbCrLf & "Pendapatan lebih dari 100 juta, 30% Pajak"
        ' 
        ' lblPendapat
        ' 
        lblPendapat.AutoSize = True
        lblPendapat.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblPendapat.Location = New Point(163, 218)
        lblPendapat.Name = "lblPendapat"
        lblPendapat.Size = New Size(202, 23)
        lblPendapat.TabIndex = 2
        lblPendapat.Text = "Masukkan Pendapatanmu"
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(200, 329)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(94, 29)
        btnHitung.TabIndex = 4
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' lblRp
        ' 
        lblRp.AutoSize = True
        lblRp.Location = New Point(142, 263)
        lblRp.Name = "lblRp"
        lblRp.Size = New Size(30, 20)
        lblRp.TabIndex = 3
        lblRp.Text = "Rp."
        ' 
        ' txtPendapatan
        ' 
        txtPendapatan.Location = New Point(178, 260)
        txtPendapatan.Name = "txtPendapatan"
        txtPendapatan.Size = New Size(171, 27)
        txtPendapatan.TabIndex = 1
        ' 
        ' FormPajak
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(581, 450)
        Controls.Add(btnHitung)
        Controls.Add(lblRp)
        Controls.Add(lblPendapat)
        Controls.Add(txtPendapatan)
        Controls.Add(lblPajak)
        Name = "FormPajak"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormPajak"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblPajak As Label
    Friend WithEvents lblPendapat As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents lblRp As Label
    Friend WithEvents txtPendapatan As TextBox
End Class
