Public Class FormPajak

    Private Sub FormPajak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RunSelfCheck()
    End Sub

    ' Pure function untuk logika penentuan persentase tarif pajak
    Public Shared Function HitungTarifPajak(pendapatan As Double) As Double
        If pendapatan > 100000000 Then
            Return 0.3
        ElseIf pendapatan > 30000000 Then
            Return 0.2
        ElseIf pendapatan > 5000000 Then
            Return 0.1
        Else
            Return 0.0
        End If
    End Function

    ' Assert-based self-check
    <System.Diagnostics.Conditional("DEBUG")>
    Public Shared Sub RunSelfCheck()
        Debug.Assert(HitungTarifPajak(4000000) = 0.0, "Test <= 5M gagal")
        Debug.Assert(HitungTarifPajak(5000000) = 0.0, "Test batas 5M gagal")
        Debug.Assert(HitungTarifPajak(10000000) = 0.1, "Test > 5M gagal")
        Debug.Assert(HitungTarifPajak(30000000) = 0.1, "Test batas 30M gagal")
        Debug.Assert(HitungTarifPajak(50000000) = 0.2, "Test > 30M gagal")
        Debug.Assert(HitungTarifPajak(100000000) = 0.2, "Test batas 100M gagal")
        Debug.Assert(HitungTarifPajak(150000000) = 0.3, "Test > 100M gagal")
    End Sub

    Private Sub txtPendapatan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPendapatan.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim pendapatan As Double

        ' Validasi format angka dan cek input kosong
        If Not Double.TryParse(txtPendapatan.Text.Trim(), pendapatan) OrElse pendapatan < 0 Then
            MessageBox.Show("Masukkan nominal pendapatan yang valid (angka positif)!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPendapatan.Focus()
            Return
        End If

        ' Percabangan if-else penentuan tarif pajak
        ' ponytail: flat bracket calculation; upgrade to tiered marginal progressive brackets if requested
        Dim persentase As Double = HitungTarifPajak(pendapatan)
        Dim totalPajak As Double = pendapatan * persentase
        Dim pendapatanBersih As Double = pendapatan - totalPajak

        ' Tampilkan hasil perhitungan ke label
        lblHasilPajak.Text = "Total Pajak (" & (persentase * 100).ToString("0") & "%): Rp " & totalPajak.ToString("N0")
        lblHasilBersih.Text = "Pendapatan Bersih: Rp " & pendapatanBersih.ToString("N0")
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        FormLogin.Show()
    End Sub

    Private Sub FormPajak_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

End Class
