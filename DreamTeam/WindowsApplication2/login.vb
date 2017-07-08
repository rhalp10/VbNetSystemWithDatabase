


Public Class login
    Private db As New dbconnector
    Private ds As New DataSet
    Private sql As String

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbluser.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click

        registration.Show()
        Me.Hide()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim check As Boolean
        Dim a As Integer
        db.connect()
        If txtuserName.Text = "" Or txtmainpassword.Text = "" Then
            MessageBox.Show("Please enter your username and password.")
        Else
            Try
                sql = "SELECT * FROM tbllogin"
                'sql = "SELECT * FROM tbllogin WHERE UserName = '" + txtuserName.Text + "' AND Password = '" + txtmainpassword.Text + "'"
                ds = db.sqlSelect(sql)
                'ds = db.sqlSelect(sql)
                a = 0
                While (check = False)
                    If (a = ds.Tables("Results").Rows.Count) Then
                        check = True
                        Throw New System.Exception("Error Occured.")
                    End If
                    If (ds.Tables("Results").Rows(a).Item(1) = txtuserName.Text And ds.Tables("Results").Rows(a).Item(2) = txtmainpassword.Text) Then
                        MsgBox("Login successful!", vbInformation, "login")
                        lblUname.Text = ds.Tables("Results").Rows(a).Item("FirstName") & " " & ds.Tables("Results").Rows(a).Item("LastName").ToString()
                        lbllogged.Text = txtuserName.Text
                        check = True
                        txtPost.Show()
                        Me.Hide()
                        txtuserName.Text = ""
                        txtmainpassword.Text = ""
                    Else
                        a = a + 1
                        check = False
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

        End If
    End Sub

    Shared Function NewRow() As DataRow
        Throw New NotImplementedException
    End Function

    Shared Function Rows() As Object
        Throw New NotImplementedException
    End Function

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblUname.Click

    End Sub
End Class