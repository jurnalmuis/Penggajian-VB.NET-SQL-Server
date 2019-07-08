Public Class TMenu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TGAJI.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TKaryawan.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TLembur.ShowDialog()
    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        FRLaporKaryawan.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FRLaporLembur.ShowDialog()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Close()
        End
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FRLapGajiKar.ShowDialog()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        FRLapGajiPerKar.ShowDialog()
    End Sub

    Private Sub TMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Text = "Project Payroll!!! by Muhammad Ismail"
        Button1.Cursor = Cursors.Hand
        Button2.Cursor = Cursors.Hand
        Button4.Cursor = Cursors.Hand
        Button5.Cursor = Cursors.Hand
        Button6.Cursor = Cursors.Hand
        Button7.Cursor = Cursors.Hand
        Button10.Cursor = Cursors.Hand
    End Sub

    Private Sub ProsesGaji_Click(sender As Object, e As EventArgs) Handles ProsesGaji.Click
        If Label4.Text = "Operator" Then
            ProsesGaji.Cursor = Cursors.No : IntPengguna.Cursor = Cursors.No
            MsgBox("Anda Tidak Punya Hak Akses Ke Sini")
            TRekap.Close()
            Exit Sub
        Else
            ProsesGaji.Cursor = Cursors.Hand : IntPengguna.Cursor = Cursors.Hand
            ProsesGaji.Enabled = True : IntPengguna.Enabled = True
            TRekap.ShowDialog()
        End If
    End Sub

    Private Sub IntPengguna_Click(sender As Object, e As EventArgs) Handles IntPengguna.Click
        If Label4.Text = "Operator" Then
            ProsesGaji.Cursor = Cursors.No : IntPengguna.Cursor = Cursors.No
            MsgBox("Anda Tidak Punya Hak Akses Ke Sini")
            Pengguna.Close()
            Exit Sub
        Else
            ProsesGaji.Cursor = Cursors.Hand : IntPengguna.Cursor = Cursors.Hand
            ProsesGaji.Enabled = True : IntPengguna.Enabled = True
            Pengguna.ShowDialog()
        End If
    End Sub
End Class