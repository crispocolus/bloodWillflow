<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblLoginBrukernavn = New System.Windows.Forms.Label()
        Me.lblLoginPwd = New System.Windows.Forms.Label()
        Me.llblLoginFgtPwd = New System.Windows.Forms.LinkLabel()
        Me.llblLoginReg = New System.Windows.Forms.LinkLabel()
        Me.txtLoginBrukernavn = New System.Windows.Forms.TextBox()
        Me.txtLoginPwd = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(92, 123)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(100, 36)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Logg inn"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblLoginBrukernavn
        '
        Me.lblLoginBrukernavn.AutoSize = True
        Me.lblLoginBrukernavn.BackColor = System.Drawing.Color.Transparent
        Me.lblLoginBrukernavn.ForeColor = System.Drawing.SystemColors.Control
        Me.lblLoginBrukernavn.Location = New System.Drawing.Point(42, 58)
        Me.lblLoginBrukernavn.Name = "lblLoginBrukernavn"
        Me.lblLoginBrukernavn.Size = New System.Drawing.Size(37, 13)
        Me.lblLoginBrukernavn.TabIndex = 1
        Me.lblLoginBrukernavn.Text = "Epost:"
        '
        'lblLoginPwd
        '
        Me.lblLoginPwd.AutoSize = True
        Me.lblLoginPwd.BackColor = System.Drawing.Color.Transparent
        Me.lblLoginPwd.ForeColor = System.Drawing.SystemColors.Control
        Me.lblLoginPwd.Location = New System.Drawing.Point(31, 88)
        Me.lblLoginPwd.Name = "lblLoginPwd"
        Me.lblLoginPwd.Size = New System.Drawing.Size(48, 13)
        Me.lblLoginPwd.TabIndex = 2
        Me.lblLoginPwd.Text = "Passord:"
        '
        'llblLoginFgtPwd
        '
        Me.llblLoginFgtPwd.AutoSize = True
        Me.llblLoginFgtPwd.BackColor = System.Drawing.Color.Transparent
        Me.llblLoginFgtPwd.LinkColor = System.Drawing.Color.DodgerBlue
        Me.llblLoginFgtPwd.Location = New System.Drawing.Point(12, 206)
        Me.llblLoginFgtPwd.Name = "llblLoginFgtPwd"
        Me.llblLoginFgtPwd.Size = New System.Drawing.Size(80, 13)
        Me.llblLoginFgtPwd.TabIndex = 3
        Me.llblLoginFgtPwd.TabStop = True
        Me.llblLoginFgtPwd.Text = "Glemt passord?"
        '
        'llblLoginReg
        '
        Me.llblLoginReg.AutoSize = True
        Me.llblLoginReg.BackColor = System.Drawing.Color.Transparent
        Me.llblLoginReg.LinkColor = System.Drawing.Color.DodgerBlue
        Me.llblLoginReg.Location = New System.Drawing.Point(190, 206)
        Me.llblLoginReg.Name = "llblLoginReg"
        Me.llblLoginReg.Size = New System.Drawing.Size(70, 13)
        Me.llblLoginReg.TabIndex = 4
        Me.llblLoginReg.TabStop = True
        Me.llblLoginReg.Text = "Registrer deg"
        '
        'txtLoginBrukernavn
        '
        Me.txtLoginBrukernavn.Location = New System.Drawing.Point(92, 55)
        Me.txtLoginBrukernavn.Name = "txtLoginBrukernavn"
        Me.txtLoginBrukernavn.Size = New System.Drawing.Size(100, 20)
        Me.txtLoginBrukernavn.TabIndex = 5
        '
        'txtLoginPwd
        '
        Me.txtLoginPwd.Location = New System.Drawing.Point(92, 85)
        Me.txtLoginPwd.Name = "txtLoginPwd"
        Me.txtLoginPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtLoginPwd.Size = New System.Drawing.Size(100, 20)
        Me.txtLoginPwd.TabIndex = 6
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(281, 256)
        Me.Controls.Add(Me.txtLoginPwd)
        Me.Controls.Add(Me.txtLoginBrukernavn)
        Me.Controls.Add(Me.llblLoginReg)
        Me.Controls.Add(Me.llblLoginFgtPwd)
        Me.Controls.Add(Me.lblLoginPwd)
        Me.Controls.Add(Me.lblLoginBrukernavn)
        Me.Controls.Add(Me.btnLogin)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "LoginForm"
        Me.Text = "Logg inn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents lblLoginBrukernavn As Label
    Friend WithEvents lblLoginPwd As Label
    Friend WithEvents llblLoginFgtPwd As LinkLabel
    Friend WithEvents llblLoginReg As LinkLabel
    Friend WithEvents txtLoginBrukernavn As TextBox
    Friend WithEvents txtLoginPwd As TextBox
End Class
