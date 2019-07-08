Imports System.Data
Imports System.Data.SqlClient
Public Class TKaryawan
    Dim tabele As SqlDataAdapter
    Dim datane As DataSet
    Dim cek As Boolean
    Private rd As SqlDataReader
    Private jkel, stat As String
    Private Sub TKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi() : ngisicombo() : Call bersih()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ngisitextbox()
    End Sub
    Sub bersih()
        tbNik.Enabled = True : tbNik.Text = "" : tbNik.MaxLength = 4 : tbNik.CharacterCasing = CharacterCasing.Upper
        Tbnama.Text = "" : tbAlamat.Text = "" : tbAnak.Text = "" : ComboBox1.Text = "" : tbTunjangan.Text = ""
        cek = False
        LK.Checked = False : PR.Checked = False : KW.Checked = False : BJ.Checked = False : tbAnak.Enabled = False
        btnsimpan.Enabled = False : btnhapus.Enabled = False : btnbatal.Enabled = True : btnkeluar.Enabled = True
        Call tampil() : tbNik.Focus()
    End Sub
    Sub ngisicombo()
        cmd = New SqlCommand("select * from tgaji", database)
        rd = cmd.ExecuteReader
        ComboBox1.Items.Clear()
        Do While rd.Read
            ComboBox1.Items.Add(rd("NGAPOK"))
        Loop
        ComboBox1.Text = False
        rd.Close()
    End Sub
    Sub tampil()
        cmd = New SqlClient.SqlCommand("SELECT *  FROM  Tkaryawan", database)
        tabele = New SqlClient.SqlDataAdapter
        tabele.SelectCommand = cmd
        datane = New Data.DataSet
        tabele.Fill(datane, "c")
        DataGridView1.DataSource = datane
        DataGridView1.DataMember = "c"
        DataGridView1.ReadOnly = True
    End Sub
    Sub ngisitextbox()
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        tbNik.Text = DataGridView1.Item(0, i).Value
        Tbnama.Text = DataGridView1.Item(1, i).Value
        If DataGridView1.Item(2, i).Value = "L" Then
            LK.Checked = True
        Else
            PR.Checked = True
        End If
        If DataGridView1.Item(4, i).Value = "K" Then
            KW.Checked = True
        Else
            BJ.Checked = True
        End If
        tbAlamat.Text = DataGridView1.Item(3, i).Value
        tbAnak.Text = DataGridView1.Item(5, i).Value
        ComboBox1.Text = DataGridView1.Item(6, i).Value
        tbTunjangan.Text = DataGridView1.Item(7, i).Value
        If DataGridView1.Item(2, i).Value = "L" Then
            LK.Checked = True
        Else
            PR.Checked = True
        End If
        btnsimpan.Enabled = True : btnhapus.Enabled = True
        cek = True
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        Close()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Call bersih()
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Dim sqlcmd As New SqlClient.SqlCommand
        sqlcmd.Connection = database
        sqlcmd.CommandType = CommandType.Text
        sqlcmd.CommandText = "Delete from tkaryawan where NIK='" & tbNik.Text & "'"
        sqlcmd.ExecuteNonQuery()
        Call bersih()
        tbNik.Focus()
    End Sub

    Private Sub BJ_CheckedChanged(sender As Object, e As EventArgs) Handles BJ.CheckedChanged
        If BJ.Checked Then
            tbAnak.Text = "0" : tbAnak.Enabled = False
        End If
    End Sub

    Private Sub KW_CheckedChanged(sender As Object, e As EventArgs) Handles KW.CheckedChanged
        tbAnak.Enabled = True
    End Sub

    Private Sub tbTunjangan_TextChanged(sender As Object, e As EventArgs) Handles tbTunjangan.TextChanged
        btnsimpan.Enabled = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        btnsimpan.Enabled = True
    End Sub

    Private Sub tbNik_LostFocus(sender As Object, e As EventArgs) Handles tbNik.LostFocus
        cmd = New SqlCommand("select * from tkaryawan where nik='" & tbNik.Text & "'", database)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            cek = True
            tbNik.Enabled = False
            Tbnama.Text = rd("Nama") : tbAlamat.Text = rd("alamat") : tbAnak.Text = rd("anak") : ComboBox1.Text = rd("gapok") : tbTunjangan.Text = rd("tunjab")
            If rd("stat") = "K" Then
                KW.Checked = True
                tbAnak.Enabled = True
            Else
                BJ.Checked = True
                tbAnak.Enabled = False
            End If
            If rd("Jkel") = "L" Then
                LK.Checked = True
            Else
                PR.Checked = True
            End If

            btnsimpan.Enabled = True : btnhapus.Enabled = True
        End If
        rd.Close()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        database.Close()
        database.Open()
        Dim sql As String
        jkel = IIf(LK.Checked, "L", "P")
        stat = IIf(KW.Checked, "K", "B")
        If tbNik.Text = "" Or Tbnama.Text = "" Or tbAlamat.Text = "" Or tbAnak.Text = "" Then
            MsgBox("Data Belum Lengkap!!")
            Exit Sub
        End If
        If cek Then
            sql = "Update Tkaryawan set Nama='" & Tbnama.Text & "',JKel='" & jkel & "',Alamat='" & tbAlamat.Text & "',Stat='" & stat & "',Anak='" & tbAnak.Text & "',Gapok='" & ComboBox1.Text & "',Tunjab='" & tbTunjangan.Text & "' where NIK='" & tbNik.Text & "'"
            cmd.Dispose()
            cmd = New SqlClient.SqlCommand(sql)
            cmd.Connection = database
            cmd.ExecuteNonQuery()
        Else
            sql = "INSERT INTO Tkaryawan(NIK,Nama,JKel,Alamat,Stat,Anak,Gapok,Tunjab,totlbb,totlbk) VALUES ('" & tbNik.Text & "','" & Tbnama.Text & "','" & jkel & "','" & tbAlamat.Text & "','" & stat & "','" & tbAnak.Text & "','" & ComboBox1.Text & "','" & tbTunjangan.Text & "','0','0')"
            cmd.Dispose()
            cmd = New SqlClient.SqlCommand(sql)
            cmd.Connection = database
            cmd.ExecuteNonQuery()
        End If
        Call bersih() : tbNik.Focus()
    End Sub
End Class