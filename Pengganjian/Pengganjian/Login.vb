Imports System.Data
Imports System.Data.SqlClient
Public Class Login
    Dim reader As SqlDataReader
    Dim cek As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd = New SqlCommand("select * from tlogin where iduser='" & TextBox1.Text & "' AND password='" & TextBox2.Text & "'", database)
        reader = cmd.ExecuteReader
        If reader.HasRows Then
            reader.Read()
            TMenu.Label2.Text = reader("nama")
            TMenu.Label4.Text = reader("leveluser")
            Me.Hide()
            TMenu.ShowDialog()
        Else
            MsgBox("User / Pass Salah")
        End If
        reader.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi() : Call bersih()
    End Sub
    Sub bersih()
        TextBox1.Text = "" : TextBox2.Text = "" : TextBox2.PasswordChar = "X" : TextBox1.CharacterCasing = CharacterCasing.Upper : TextBox1.MaxLength = 6
    End Sub

End Class