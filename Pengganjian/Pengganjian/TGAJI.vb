Public Class TGAJI
    Private cek As Boolean
    Private Sub bersih()
        cek = False
        idgol.Text = "" : idgol.Enabled = True : idgol.CharacterCasing = CharacterCasing.Upper
        namagol.Text = "" : namagol.CharacterCasing = CharacterCasing.Upper
        gapok.Text = "" : gapok.TextAlign = HorizontalAlignment.Right
        BtnSimpan.Enabled = False : BtnHapus.Enabled = False : BtnBatal.Enabled = True : btnKeluar.Enabled = True
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Close()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim sql As String
        database.Close()
        database.Open()
        If Not cek Then
            sql = "INSERT INTO TGAJI VALUES ('" & idgol.Text & "' , '" & namagol.Text & "' , " & gapok.Text & ")"
            'cmd.Dispose()
            cmd = New SqlClient.SqlCommand(sql)
            cmd.Connection = database
        Else
            sql = "Update TGAJI set NMGOL = '" & namagol.Text & "', NGAPOK = " & gapok.Text.ToString & " where IDGOL='" & idgol.Text & "'"
            'cmd.Dispose()
            cmd = New SqlClient.SqlCommand(sql)
            cmd.Connection = database
        End If
        cmd.ExecuteNonQuery()
        Call bersih() : idgol.Focus()
    End Sub

    Private Sub TGAJI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Call bersih()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Call bersih() : idgol.Focus()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim sqlcmd As New SqlClient.SqlCommand
        sqlcmd.Connection = database
        sqlcmd.CommandType = CommandType.Text
        sqlcmd.CommandText = "delete from tgaji where idgol='" & idgol.Text & "' "
        sqlcmd.ExecuteNonQuery()
        Call bersih()
        idgol.Focus()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles gapok.TextChanged
        BtnSimpan.Enabled = True
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles idgol.LostFocus
        Dim cmd As New SqlClient.SqlCommand
        Dim rd As SqlClient.SqlDataReader
        cmd = New SqlClient.SqlCommand("select * from tgaji where idgol='" & idgol.Text & "' ", database)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            idgol.Text = rd(0) : namagol.Text = rd(1) : gapok.Text = rd(2)
            BtnSimpan.Enabled = True : BtnHapus.Enabled = True
            cek = True : idgol.Enabled = False
        Else
            cek = False
        End If
        rd.Close()
    End Sub
End Class
