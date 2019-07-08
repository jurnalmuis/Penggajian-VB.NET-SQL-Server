Imports System.Data
Imports System.Data.SqlClient
Module Module1
    Public database As New SqlConnection
    Public cmd As SqlCommand
    Private constr As String = "Data Source=ADHYEN;Initial Catalog=gajian;Integrated Security=True;MultipleActiveResultSets=True"
    Public Sub koneksi()
        If database.State = ConnectionState.Closed Then
            database.ConnectionString = constr
            Try
                database.Open()
            Catch ex As Exception
                MsgBox("Koneksi Gagal" & ex.Message)
                Exit Sub
            End Try
        End If
    End Sub
End Module
