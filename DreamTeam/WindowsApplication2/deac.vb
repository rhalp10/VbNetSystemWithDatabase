Public Class deac
    Dim provider As String
    Dim datafile As String
    Dim connstring As String
    Dim conn As OleDb.OleDbConnection = New OleDb.OleDbConnection

    Private Sub txtUname_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub

    Private Sub btnDeac_Click(sender As Object, e As EventArgs) Handles btnDeac.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\My Documents\dt\WindowsApplication2\dt.accdb"
        connstring = provider & datafile
        conn.ConnectionString = connstring
        conn.Open()
        Dim str As String
        str = "DELETE from [tbllogin] WHERE [Password] = '" & txtPass.Text & "'"
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(str, conn)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
            txtPass.Clear()
            Me.Close()
            login.Show()



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        settings.show

    End Sub
End Class