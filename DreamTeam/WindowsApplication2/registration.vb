Imports System.Data.OleDb

Public Class registration
    Private db As New dbconnector
    Private ds As New DataSet
    Private sql As String
    Private fieldcheck As Boolean
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub registration_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub registration_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate

    End Sub

    Private Sub registration_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub registration_Leave(sender As Object, e As EventArgs) Handles Me.Leave

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtEmail.Text = ""
        txtFname.Text = ""
        txtLname.Text = ""
        txtPass2.Text = ""
        txtPass.Text = ""
        txtAnswer.Text = ""
        txtUname.Text = ""
        cboGender.Text = ""
        cboQuestion.Text = ""
        cboStatus.Text = ""
        DateTimePicker1.Value = "1/1/1980"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        txtEmail.Text = ""
        txtFname.Text = ""
        txtLname.Text = ""
        txtPass2.Text = ""
        txtPass.Text = ""
        txtAnswer.Text = ""
        txtUname.Text = ""
        cboGender.Text = ""
        cboQuestion.Text = ""
        cboStatus.Text = ""
        DateTimePicker1.Value = "1/1/1980"
        login.Show()
        Me.Hide()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (txtFname.Text = "" Or txtFname.Text = "" Or txtLname.Text = "" Or txtPass2.Text = "" Or txtPass.Text = "" Or txtAnswer.Text = "" Or txtUname.Text = "" Or cboGender.Text = "" Or cboQuestion.Text = "" Or cboStatus.Text = "") Then
            MsgBox("You are missing something!", vbInformation, "Blank Field")
        Else
            Try
                If (fieldcheck = True) Then
                    Dim cnnOLEDB As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\My Documents\dt\WindowsApplication2\dt.accdb;")
                    Dim cmdOLEDB As New OleDb.OleDbCommand
                    Dim cmdInsert As New OleDb.OleDbCommand
                    Dim InsertQuery As String
                    InsertQuery = "INSERT INTO tbllogin (UserName,[password],FirstName,[LastName],Retype,[Email],Birthday,[Gender],Status,[Question],Answer) VALUES (@user,@pw,@firstname,@lastname,@retype,@Email,@Birthday,@Gender,@Status,@Question,@Answer)"
                    cnnOLEDB.Open()
                    Dim cmd As OleDb.OleDbCommand = New OleDbCommand(InsertQuery, cnnOLEDB)
                    cmd.Parameters.AddWithValue("@user", txtUname.Text)
                    cmd.Parameters.AddWithValue("@pw", txtPass.Text)
                    cmd.Parameters.AddWithValue("@firstname", txtFname.Text)
                    cmd.Parameters.AddWithValue("@lastname", txtLname.Text)
                    cmd.Parameters.AddWithValue("@retype", txtPass2.Text)
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@Birthday", DateTimePicker1.Value)
                    cmd.Parameters.AddWithValue("@Gender", cboGender.Text)
                    cmd.Parameters.AddWithValue("@Status", cboStatus.Text)
                    cmd.Parameters.AddWithValue("@Question", cboQuestion.Text)
                    cmd.Parameters.AddWithValue("@Answer", txtAnswer.Text)
                    cmd.ExecuteNonQuery()
                    MsgBox("Registered Successfully")
                    cnnOLEDB.Close()
                    txtEmail.Text = ""
                    txtFname.Text = ""
                    txtLname.Text = ""
                    txtPass2.Text = ""
                    txtPass.Text = ""
                    txtAnswer.Text = ""
                    txtUname.Text = ""
                    cboGender.Text = ""
                    cboQuestion.Text = ""
                    cboStatus.Text = ""
                    DateTimePicker1.Value = "1/1/1980"
                    login.Show()
                    Me.Hide()

                Else
                    MsgBox("Registration Failed. Please check your information")
                End If



            Catch ex As Exception
                MsgBox("Error Inserting Data " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub registration_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatus.SelectedIndexChanged

    End Sub

    Private Sub Label10_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtPass2_TextChanged(sender As Object, e As EventArgs) Handles txtPass2.TextChanged
        If (txtPass2.Text = txtPass.Text) Then
            lblcheckretype.Text = "Password Matched"
            fieldcheck = True
        Else
            lblcheckretype.Text = "Password Doesn't Match"
            fieldcheck = False
        End If
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub
End Class