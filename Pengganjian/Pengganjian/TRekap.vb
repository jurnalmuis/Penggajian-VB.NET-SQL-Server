Imports System.Data
Imports System.Data.SqlClient
Public Class TRekap

    Private Sub TRekap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Label2.Text = "Proses melakukan Posting akhir bulan. Semua Transaksi sudah dimasukkan" + Chr(13) + _
            "Proses Akan Menghapus Semua Data Transaksi, lap Transaksi Sudah dicetak" + Chr(13) + _
            "Pastikan Database tidak sedang digunakan, kemudian klik PROSES"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim reclbr As Long
        Dim karya As SqlCommand
        Dim rsr As SqlDataReader
        Dim lembur As New SqlCommand
        lembur.Connection = database
        lembur.CommandType = CommandType.Text
        lembur.CommandText = "Select Count(*) from Tlembur"
        reclbr = lembur.ExecuteScalar
        If reclbr = 0 Then
            MsgBox("Proses Penggajian Sudah Dijalankan")
            Close()
            Exit Sub
        End If
        Dim gajian As New SqlClient.SqlCommand
        gajian.Connection = database
        gajian.CommandType = CommandType.Text

        Dim mperiode, mnik, mnama As String
        Dim mgapok, mtunjab, mtunis, mtunak, mtunlbr, mbpjs, mgaber As Long

        'If Month(Now) = Month(Now.AddDays(1)) Then
        '    MsgBox("Belum Akhir Bulan...........!!!!!!")
        '    Close()
        '    Exit Sub
        'End If

        mperiode = Mid(Now, 4, 2) + LTrim(Str(Year(Now)))
        karya = New SqlCommand("Select * from Tkaryawan", database)
        rsr = karya.ExecuteReader()
        While rsr.Read()
            mnik = rsr("NIK")
            mnama = rsr("Nama")
            mgapok = rsr("Gapok")
            mtunis = IIf(rsr("Stat") = "K" And rsr("Jkel") = "L", 0.1, 0) * mgapok
            mtunak = IIf(rsr("Anak") >= 2, 2, rsr("Anak")) * (0.1 * mgapok)
            mtunjab = rsr("Tunjab")
            mtunlbr = (mgapok * 0.01 * rsr("Totlbb")) + (mgapok * 0.02 * rsr("Totlbk"))
            mbpjs = IIf(rsr("Stat") = "K", 50000, 25000) + (rsr("Anak") * 25000)
            mgaber = (mgapok + mtunis + mtunjab + mtunak + mtunlbr) - mbpjs
            gajian.CommandText = "INSERT into TREKAPGJ values('" & mperiode & "','" & mnik & "','" & mnama & "','" & mgapok & "','" & mtunjab & "','" & mtunis & "','" & mtunak & "','" & mtunlbr & "','" & mbpjs & "','" & mgaber & "')"
            gajian.ExecuteNonQuery()
        End While
        rsr.Close()
        lembur.CommandText = "Delete from TLEMBUR"
        lembur.ExecuteNonQuery()

        karya.CommandText = "Update Tkaryawan SET TOTLBB=0,TOTLBK=0"
        karya.ExecuteNonQuery()
        MsgBox("Proses Penggajian Sudah Selesai")
    End Sub
End Class