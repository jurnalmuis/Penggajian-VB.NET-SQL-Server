Public Class Pengguna
    Private cek As Boolean
    Private Sub Pengguna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi() : bersih() : bagiancombo()
    End Sub
    Sub bersih()
        idPengguna.Text = "" : idPengguna.MaxLength = 6 : idPengguna.CharacterCasing = CharacterCasing.Upper : password.PasswordChar = "X"
        leveluser.Text = "" : password.Text = "" : namaPengguna.Text = "" : idPengguna.Enabled = True
        btSimpan.Enabled = False : btHapus.Enabled = False : Button4.Enabled = True : btBatal.Enabled = True
    End Sub

    Private Sub btBatal_Click(sender As Object, e As EventArgs) Handles btBatal.Click
        bersih()
    End Sub


    Private Sub idPengguna_LostFocus(sender As Object, e As EventArgs) Handles idPengguna.LostFocus
        Dim cmd As New SqlClient.SqlCommand
        Dim rd As SqlClient.SqlDataReader
        cmd = New SqlClient.SqlCommand("select * from tlogin where iduser='" & idPengguna.Text & "' ", database)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            idPengguna.Text = rd(0) : namaPengguna.Text = rd(1) : leveluser.Text = rd(3) : password.Text = rd(2)
            btSimpan.Enabled = True : btHapus.Enabled = True
            cek = True : idPengguna.Enabled = False
        Else
            cek = False
        End If
        rd.Close()
        btSimpan.Enabled = True : btHapus.Enabled = True
    End Sub
    Sub bagiancombo()
        leveluser.Items.Add("Admin")
        leveluser.Items.Add("Operator")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub btHapus_Click(sender As Object, e As EventArgs) Handles btHapus.Click
        Dim sqlcmd As New SqlClient.SqlCommand
        sqlcmd.Connection = database
        sqlcmd.CommandType = CommandType.Text
        sqlcmd.CommandText = "delete from tlogin where iduser='" & idPengguna.Text & "' "
        sqlcmd.ExecuteNonQuery()
        Call bersih()
        idPengguna.Focus()
    End Sub

    Private Sub btSimpan_Click(sender As Object, e As EventArgs) Handles btSimpan.Click
        Dim sql As String
        database.Close()
        database.Open()
        If Not cek Then
            sql = "INSERT INTO tlogin VALUES ('" & idPengguna.Text & "','" & namaPengguna.Text & "','" & password.Text & "','" & leveluser.Text & "')"
            'cmd.Dispose()
            cmd = New SqlClient.SqlCommand(sql)
            cmd.Connection = database
        Else
            sql = "Update tlogin set nama='" & namaPengguna.Text & "', password='" & password.Text & "', leveluser='" & leveluser.Text & "' where iduser='" & idPengguna.Text & "'"
            'cmd.Dispose()
            cmd = New SqlClient.SqlCommand(sql)
            cmd.Connection = database
        End If
        cmd.ExecuteNonQuery()
        Call bersih() : idPengguna.Focus()
    End Sub

End Class