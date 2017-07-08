Imports System.Data.OleDb
Public Class general
    Dim provider As String
    Dim datafile As String
    Dim connstring As String
    Private fieldcheck As Boolean
    Dim conn As OleDbConnection = New OleDbConnection
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        txtPost.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\My Documents\dt\WindowsApplication2\dt.accdb"
        

        connstring = provider & datafile
        conn.ConnectionString = connstring
        conn.Open()
        Dim str As String
        str = "Update [tbllogin] set [FirstName] = '" & txtFName.Text & "', [LastName] = '" & txtLname.Text & "', [Email] =' " & txtEmail.Text & "',[Password] ='" & txtPass.Text & "', [Retype] = '" & txtPass2.Text & "',[Status] = '" & cboStatus.Text & "',[Question] ='" & cboQuestion.Text & "',[Answer] = '" & txtAnswer.Text & "' WHERE [Password] = '" & txtpass3.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(str, conn)



        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
            txtFName.Text = ""
            txtLname.Text = ""
            txtEmail.Text = ""
            txtPass.Text = ""
            txtPass2.Text = ""
            txtpass3.Text = ""
            cboStatus.Text = ""
            cboQuestion.Text = ""
            txtAnswer.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message)


        End Try


    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtLname.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtFName.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Function cmd() As Object
        Throw New NotImplementedException
    End Function

    Private Sub general_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtUname_TextChanged(sender As Object, e As EventArgs) Handles txtpass3.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub txtPass2_TextChanged(sender As Object, e As EventArgs) Handles txtPass2.TextChanged

        If (txtPass2.Text = txtPass.Text) Then
            lblmatch.Text = "Password Matched"
            fieldcheck = True
        Else
            lblmatch.Text = "Password Doesn't Match"
            fieldcheck = False
        End If

    End Sub

    Private Sub lblRetype_Click(sender As Object, e As EventArgs) Handles lblRetype.Click

    End Sub

    Private Sub btnDeac_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblmatch_Click(sender As Object, e As EventArgs) Handles lblmatch.Click

    End Sub
End Class