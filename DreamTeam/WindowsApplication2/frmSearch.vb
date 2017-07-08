Imports System.Data.OleDb

Public Class frmSearch
    Public keyWord As String
    Private sql As String
    Private db As dbconnector
    Private ds As DataSet

    Private Sub FlowLayoutPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtPost.Show()
        Me.Hide()

    End Sub

    Private Sub frmSearch_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Try
            Dim cnnOLEDB As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\My Documents\dt\WindowsApplication2\dt.accdb;")
            Dim cmdOLEDB As New OleDb.OleDbCommand
            Dim cmdInsert As New OleDb.OleDbCommand
            Dim reader As OleDbDataReader
            Dim InsertQuery As String
            InsertQuery = "SELECT [userName] FROM tbllogin WHERE ([userName] LIKE @key & '%') OR ([userName] LIKE '%' & @key & '%') OR ([userName] LIKE '%' & @key)"
            'InsertQuery = "SELECT userName FROM tbllogin"
            cnnOLEDB.Open()
            Dim cmd As OleDb.OleDbCommand = New OleDbCommand(InsertQuery, cnnOLEDB)
            cmd.Parameters.AddWithValue("@key", keyWord)
            cmd.Parameters.AddWithValue("@key", keyWord)
            cmd.Parameters.AddWithValue("@key", keyWord)
            Dim a As Integer
            reader = cmd.ExecuteReader()
            Dim aLabels() As Label = {lbltemp, lbltemp2, lbltemp3, lbltemp4, lbltemp5, lbltemp6}

            While (reader.HasRows)
                a = 0
                Do While (reader.Read())
                    aLabels(a).Text = reader.GetString(0)
                    aLabels(a).Visible = True
                    a = a + 1
                Loop

                reader.NextResult()
            End While

            cnnOLEDB.Close()





        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lbltemp_Click(sender As Object, e As EventArgs) Handles lbltemp.Click
        profile.current = lbltemp.Text
        profile.Show()
        Me.Hide()

    End Sub

    Private Sub lbltemp2_Click(sender As Object, e As EventArgs) Handles lbltemp2.Click
        profile.current = lbltemp2.Text
        profile.Show()
        Me.Hide()
    End Sub

    Private Sub lbltemp3_Click(sender As Object, e As EventArgs) Handles lbltemp3.Click
        profile.current = lbltemp3.Text
        profile.Show()
        Me.Hide()
    End Sub

    Private Sub lbltemp4_Click(sender As Object, e As EventArgs) Handles lbltemp4.Click
        profile.current = lbltemp4.Text
        profile.Show()
        Me.Hide()
    End Sub

    Private Sub lbltemp5_Click(sender As Object, e As EventArgs) Handles lbltemp5.Click
        profile.current = lbltemp5.Text
        profile.Show()
        Me.Hide()
    End Sub

    Private Sub lbltemp6_Click(sender As Object, e As EventArgs) Handles lbltemp6.Click
        profile.current = lbltemp6.Text
        profile.Show()
        Me.Hide()
    End Sub
End Class