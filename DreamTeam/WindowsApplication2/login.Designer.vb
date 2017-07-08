<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtuserName = New System.Windows.Forms.TextBox()
        Me.txtmainpassword = New System.Windows.Forms.TextBox()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.lblUname = New System.Windows.Forms.Label()
        Me.lbllogged = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtuserName
        '
        Me.txtuserName.Location = New System.Drawing.Point(779, 76)
        Me.txtuserName.Name = "txtuserName"
        Me.txtuserName.Size = New System.Drawing.Size(258, 20)
        Me.txtuserName.TabIndex = 0
        '
        'txtmainpassword
        '
        Me.txtmainpassword.Location = New System.Drawing.Point(779, 146)
        Me.txtmainpassword.Name = "txtmainpassword"
        Me.txtmainpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtmainpassword.Size = New System.Drawing.Size(258, 20)
        Me.txtmainpassword.TabIndex = 1
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.BackColor = System.Drawing.Color.Transparent
        Me.lbluser.Location = New System.Drawing.Point(776, 44)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(68, 13)
        Me.lbluser.TabIndex = 2
        Me.lbluser.Text = "USERNAME"
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.BackColor = System.Drawing.Color.Transparent
        Me.lblpass.Location = New System.Drawing.Point(776, 118)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(70, 13)
        Me.lblpass.TabIndex = 3
        Me.lblpass.Text = "PASSWORD"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLogin.Location = New System.Drawing.Point(789, 191)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnReg
        '
        Me.btnReg.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnReg.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReg.Location = New System.Drawing.Point(870, 191)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(75, 23)
        Me.btnReg.TabIndex = 5
        Me.btnReg.Text = "Register"
        Me.btnReg.UseVisualStyleBackColor = False
        '
        'lblUname
        '
        Me.lblUname.AutoSize = True
        Me.lblUname.BackColor = System.Drawing.Color.Transparent
        Me.lblUname.Location = New System.Drawing.Point(244, 252)
        Me.lblUname.Name = "lblUname"
        Me.lblUname.Size = New System.Drawing.Size(10, 13)
        Me.lblUname.TabIndex = 6
        Me.lblUname.Text = " "
        Me.lblUname.Visible = False
        '
        'lbllogged
        '
        Me.lbllogged.AutoSize = True
        Me.lbllogged.Location = New System.Drawing.Point(943, 371)
        Me.lbllogged.Name = "lbllogged"
        Me.lbllogged.Size = New System.Drawing.Size(0, 13)
        Me.lbllogged.TabIndex = 7
        Me.lbllogged.Visible = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.BackgroundImage = Global.WindowsApplication2.My.Resources.Resources.LOGIN
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1087, 446)
        Me.Controls.Add(Me.lbllogged)
        Me.Controls.Add(Me.lblUname)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblpass)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.txtmainpassword)
        Me.Controls.Add(Me.txtuserName)
        Me.Name = "login"
        Me.Text = "LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtuserName As System.Windows.Forms.TextBox
    Friend WithEvents txtmainpassword As System.Windows.Forms.TextBox
    Friend WithEvents lbluser As System.Windows.Forms.Label
    Friend WithEvents lblpass As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnReg As System.Windows.Forms.Button
    Friend WithEvents lblUname As System.Windows.Forms.Label
    Friend WithEvents lbllogged As System.Windows.Forms.Label

End Class
