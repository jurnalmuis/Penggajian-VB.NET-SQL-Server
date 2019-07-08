Imports System.Data
Imports System.Data.SqlClient
Public Class TLembur
    Private mtotlbb, mtotlbk, mgapok As Integer
    Dim tabele As SqlDataAdapter
    Dim datane As DataSet
    Private rd As SqlDataReader

    Private Sub TLembur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi() : Call tampil() : Call bersih()
    End Sub
    Sub bersih()
        tbNik.CharacterCasing = CharacterCasing.Upper : tbJenisLem.CharacterCasing = CharacterCasing.Upper : Tbnama.Enabled = False
        tbNik.Text = "" : Tbnama.Text = "" : DateTimePicker1.Text = "" : tbKet.Text = "" : tbLamalem.Text = "" : tbJenisLem.Text = "" : TextBox1.Text = "" : TextBox2.Text = ""
        tbNik.Focus() : Call tampil() : TextBox1.ReadOnly = True : TextBox2.ReadOnly = True
    End Sub
    Sub tampil()
        cmd = New SqlClient.SqlCommand("SELECT * FROM Tkaryawan", database)
        tabele = New SqlClient.SqlDataAdapter
        tabele.SelectCommand = cmd
        datane = New Data.DataSet
        tabele.Fill(datane, "c")
        DataGridView1.DataSource = datane
        DataGridView1.DataMember = "c"
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub tbLamalem_LostFocus(sender As Object, e As EventArgs) Handles tbLamalem.LostFocus
        mtotlbb = mtotlbb + Val(tbLamalem.Text)
        mtotlbk = mtotlbk + Val(tbLamalem.Text)
        
    End Sub

    Private Sub tbNik_LostFocus(sender As Object, e As EventArgs) Handles tbNik.LostFocus
        cmd = New SqlCommand("select * from tkaryawan where nik='" & tbNik.Text & "'", database)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Tbnama.Text = rd("nama")
            mtotlbb = rd("Totlbb")
            mtotlbk = rd("totlbk")
            mgapok = rd("Gapok")
            TextBox1.Text = "Total Lembur Biasa Yang Didapatkan = Rp." & (mgapok * 0.01 * mtotlbb) & ",00"
            TextBox2.Text = "Total Lembur Khusus Yang Didapatkan = Rp." & (mgapok * 0.02 * mtotlbk) & ",00"
            Tbnama.Enabled = False
        End If
        rd.Close()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Call bersih()
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        Close()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If tbNik.Text = "" Or DateTimePicker1.Text = "" Or tbJenisLem.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        End If
        Call koneksi()
        Dim dmlLbr As New SqlCommand
        Dim dmlkar As New SqlCommand
        dmlLbr.Connection = database
        dmlLbr.CommandType = CommandType.Text
        dmlLbr.CommandText = "insert into Tlembur values('" & tbNik.Text & "','" & DateTimePicker1.Text & "','" & tbJenisLem.Text & "','" & tbLamalem.Text & "','" & tbKet.Text & "')"
        dmlLbr.ExecuteNonQuery()


        dmlkar.Connection = database
        dmlkar.CommandType = CommandType.Text
        If UCase(tbJenisLem.Text) = "B" Then
            dmlkar.CommandText = "Update Tkaryawan set totlbb='" & mtotlbb & "' where nik='" & tbNik.Text & "'"
        Else
            dmlkar.CommandText = "Update Tkaryawan set totlbk='" & mtotlbk & "' where nik='" & tbNik.Text & "'"
        End If
        dmlkar.ExecuteNonQuery()
        Call bersih()
    End Sub

End Class