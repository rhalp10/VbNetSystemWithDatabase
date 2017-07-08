Imports System.Data.OleDb

Public Class profile
    Private db As New dbconnector
    Private ds, ds2 As New DataSet
    Private sql As String
    Public current As String

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        WindowsApplication2.txtPost.Show()
        Me.Hide()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.Hide()
        login.Show()

    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub profile_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim a As Integer
        Dim check As Boolean
        Dim postIndent As String
        Try
            sql = "SELECT * FROM tblpost"
            'sql = "SELECT * FROM tbllogin WHERE UserName = '" + txtuserName.Text + "' AND Password = '" + txtmainpassword.Text + "'"
            ds = db.sqlSelect(sql)
            sql = "SELECT * FROM tbllogin"
            ds2 = db.sqlSelect(sql)
            check = False
            a = 0
            While (check = False)
                If (ds2.Tables("Results").Rows(a).Item(1) = current) Then
                    lblprofileName.Text = ds2.Tables("Results").Rows(a).Item(3) + " " + ds2.Tables("Results").Rows(a).Item(4)
                    check = True
                Else
                    a = a + 1
                    check = False
                End If
                If (ds2.Tables("Results").Rows.Count = a) Then
                    check = True
                End If
            End While

            If (current = login.lbllogged.Text) Then
                Panel1.Visible = True
                Button7.Visible = True
                txtPost.Visible = True
            Else
                Panel1.Visible = False
                Button7.Visible = False
                txtPost.Visible = False
            End If



            'ds = db.sqlSelect(sql)
            a = 0
            check = False
            postIndent = "     "
            lblStatus.Text = ""
            While (check = False)
                If (ds.Tables("Results").Rows(a).Item(2) = current) Then
                    lblStatus.Text = lblStatus.Text + vbCrLf + current + " posted:" + vbCrLf + vbCrLf + postIndent + ds.Tables("Results").Rows(a).Item(1) + vbCrLf + vbCrLf
                    a = a + 1
                    check = False
                Else
                    a = a + 1
                    check = False
                End If
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

    Private Sub profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db.connect()


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Dim cnnOLEDB As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\My Documents\dt\WindowsApplication2\dt.accdb;")
            Dim cmdOLEDB As New OleDb.OleDbCommand
            Dim cmdInsert As New OleDb.OleDbCommand
            Dim InsertQuery As String
            InsertQuery = "INSERT INTO tblpost ([userPost],[post_userName]) VALUES (@Post,@userName)"
            cnnOLEDB.Open()
            Dim cmd As OleDb.OleDbCommand = New OleDbCommand(InsertQuery, cnnOLEDB)
            cmd.Parameters.AddWithValue("@Post", txtPost.Text)
            cmd.Parameters.AddWithValue("@userName", login.txtuserName.Text)
            cmd.ExecuteNonQuery()
            cnnOLEDB.Close()
            MsgBox("Status Updated")
            txtPost.Text = ""





        Catch ex As Exception
            MsgBox(ex.Message)

        End Try



    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        frmSearch.keyWord = txtSearch.Text
        frmSearch.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        settings.Show()
        Me.Hide()

    End Sub

    Private Sub lblprofileName_Click(sender As Object, e As EventArgs) Handles lblprofileName.Click

    End Sub
End Class