Public Class login
    Dim loginerror As String 'this will tell user what is going wrong with his/her login.

    Public Function Login() 'Name the login section whatever you want, does not really matter
        Dim DBConn As New ADODB.Connection 'this is how we tell vs how to connect to oyr database
        Dim User As New ADODB.Recordset 'we psas our arguments through our recordset.
        Dim Username As String 'this will be our "query"
        Dim userDB As String 'this gets set to the username field of our databse
        Dim passDB As String 'same as abose exceot for the password field
        Dim UserFound As Boolean 'we will be using a do loop so we use this as our condition.

        'lets open our connection
        DBConn.open("provider = Microsoft.Jet.OLEDB.4.0;" & "Data Source = '" & Application.StartupPath
                     & "\logindbms.accdb'")
        '
        '
        User.Open("Usertable", DBConn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.CursorTypeEnum.adLockOptimistic)
        UserFound = False
        Login = False
        Username = "username = '" & txtuserName.Text & "'"

        Do
            User.Find(Username)
            If User.BOF = False And User.EOF = False Then
                'BOF and EOF = beggining of file 
                'And end of file, it tests whwthwe the database has reached its sentinel
                'value, if it hasnt then the username has been found, if it has 
                'the username is invalid.



                userDB = User.Fields("Username").Value.To
            End If

        Loop Until UserFound = True
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbluser.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblforgot.LinkClicked

    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        registration.Show()
        Me.Hide()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtuserName.Text = "dangdc" Then
            homepage.Show()
        Else
            MessageBox.Show("Wrong Password!")
        End If
    End Sub
End Class
