<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deac
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
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnDeac = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(72, 180)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(281, 20)
        Me.txtPass.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(140, 147)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 29)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Password:"
        '
        'btnDeac
        '
        Me.btnDeac.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnDeac.FlatAppearance.BorderSize = 0
        Me.btnDeac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeac.ForeColor = System.Drawing.Color.Transparent
        Me.btnDeac.Location = New System.Drawing.Point(135, 266)
        Me.btnDeac.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeac.Name = "btnDeac"
        Me.btnDeac.Size = New System.Drawing.Size(151, 33)
        Me.btnDeac.TabIndex = 27
        Me.btnDeac.Text = "Deactivate my account"
        Me.btnDeac.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(135, 307)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 33)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'deac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication2.My.Resources.Resources.HOME1
        Me.ClientSize = New System.Drawing.Size(427, 387)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDeac)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label7)
        Me.Name = "deac"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnDeac As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
