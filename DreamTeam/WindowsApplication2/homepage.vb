Imports System.Data.OleDb
Public Class txtPost
    Private db As New dbconnector
    Private ds As New DataSet
    Private sql As String
    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles btnpost2.Click
        Try
            Dim cnnOLEDB As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\My Documents\dt\WindowsApplication2\dt.accdb;")
            Dim cmdOLEDB As New OleDb.OleDbCommand
            Dim cmdInsert As New OleDb.OleDbCommand
            Dim InsertQuery As String
            InsertQuery = "INSERT INTO tblpost ([userPost],[post_userName]) VALUES (@Post,@userName)"
            cnnOLEDB.Open()
            Dim cmd As OleDb.OleDbCommand = New OleDbCommand(InsertQuery, cnnOLEDB)
            cmd.Parameters.AddWithValue("@Post", postBox.Text)
            cmd.Parameters.AddWithValue("@userName", login.txtuserName.Text)
            cmd.ExecuteNonQuery()
            cnnOLEDB.Close()
            MsgBox("Status Updated")
            postBox.Text = ""
            




        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        profile.current = login.lbllogged.Text
        profile.Show()
        Me.Hide()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtPost_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim a As Integer
        Dim check As Boolean
        Dim postIndent As String
        Try
            sql = "SELECT * FROM tblpost"
            'sql = "SELECT * FROM tbllogin WHERE UserName = '" + txtuserName.Text + "' AND Password = '" + txtmainpassword.Text + "'"
            ds = db.sqlSelect(sql)

            'ds = db.sqlSelect(sql)
            a = 0
            check = False
            postIndent = "     "
            While (check = False)
                
                lblStatus.Text = lblStatus.Text + vbCrLf + ds.Tables("Results").Rows(a).Item(2) + " posted:" + vbCrLf + vbCrLf + postIndent + ds.Tables("Results").Rows(a).Item(1) + vbCrLf + vbCrLf
                a = a + 1
                check = False

                If (a = ds.Tables("Results").Rows.Count) Then
                    check = True
                End If

            End While



            'If ds.Tables("Results").Rows(0).Item(1) = txtuserName.Text Then
            '    MsgBox("login successful!", vbInformation, "login")
            '    HomeUserForm.Show()
            '    Me.Close()
            'End If
        Catch ex As Exception
            MessageBox.Show("Incorrect username/password. Please try again." + ex.Message)


        End Try
    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblName.Text = login.lblUname.Text
        db.connect()
        
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        login.Show()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub Splitter1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles Splitter1.SplitterMoved

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlowLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel2.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        frmSearch.keyWord = txtSearch.Text
        frmSearch.Show()
        Me.Hide()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Show()
        profile.Hide()


    End Sub

    Private Sub lblName_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles postBox.TextChanged

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class
