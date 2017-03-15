<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ansattSide
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnInnkalling = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tappeKalender = New System.Windows.Forms.MonthCalendar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstKandidater = New System.Windows.Forms.ListBox()
        Me.CBoxBlodtype = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lstBestillinger = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBlodtype = New System.Windows.Forms.TextBox()
        Me.txtMengde = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTidspunkt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(590, 414)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnInnkalling)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.tappeKalender)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.lstKandidater)
        Me.TabPage1.Controls.Add(Me.CBoxBlodtype)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(582, 388)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnInnkalling
        '
        Me.btnInnkalling.Location = New System.Drawing.Point(306, 227)
        Me.btnInnkalling.Name = "btnInnkalling"
        Me.btnInnkalling.Size = New System.Drawing.Size(129, 51)
        Me.btnInnkalling.TabIndex = 6
        Me.btnInnkalling.Text = "Send innkalling"
        Me.btnInnkalling.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(250, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tappedato"
        '
        'tappeKalender
        '
        Me.tappeKalender.Location = New System.Drawing.Point(253, 44)
        Me.tappeKalender.Name = "tappeKalender"
        Me.tappeKalender.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(133, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Kandidater"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Velg blodtype:"
        '
        'lstKandidater
        '
        Me.lstKandidater.FormattingEnabled = True
        Me.lstKandidater.Location = New System.Drawing.Point(133, 44)
        Me.lstKandidater.Name = "lstKandidater"
        Me.lstKandidater.Size = New System.Drawing.Size(108, 264)
        Me.lstKandidater.TabIndex = 1
        '
        'CBoxBlodtype
        '
        Me.CBoxBlodtype.FormattingEnabled = True
        Me.CBoxBlodtype.Items.AddRange(New Object() {"O+", "O-", "A+", "A-", "B+", "B-", "AB+", "AB-"})
        Me.CBoxBlodtype.Location = New System.Drawing.Point(6, 44)
        Me.CBoxBlodtype.Name = "CBoxBlodtype"
        Me.CBoxBlodtype.Size = New System.Drawing.Size(121, 21)
        Me.CBoxBlodtype.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnSend)
        Me.TabPage2.Controls.Add(Me.CheckBox1)
        Me.TabPage2.Controls.Add(Me.txtTidspunkt)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txtMengde)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txtBlodtype)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.lstBestillinger)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(582, 388)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lstBestillinger
        '
        Me.lstBestillinger.FormattingEnabled = True
        Me.lstBestillinger.Location = New System.Drawing.Point(24, 35)
        Me.lstBestillinger.Name = "lstBestillinger"
        Me.lstBestillinger.Size = New System.Drawing.Size(184, 225)
        Me.lstBestillinger.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Alle bestillinger"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(260, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Blodtype:"
        '
        'txtBlodtype
        '
        Me.txtBlodtype.Location = New System.Drawing.Point(263, 36)
        Me.txtBlodtype.Name = "txtBlodtype"
        Me.txtBlodtype.Size = New System.Drawing.Size(100, 20)
        Me.txtBlodtype.TabIndex = 4
        '
        'txtMengde
        '
        Me.txtMengde.Location = New System.Drawing.Point(263, 97)
        Me.txtMengde.Name = "txtMengde"
        Me.txtMengde.Size = New System.Drawing.Size(100, 20)
        Me.txtMengde.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(260, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Mengde:"
        '
        'txtTidspunkt
        '
        Me.txtTidspunkt.Location = New System.Drawing.Point(263, 157)
        Me.txtTidspunkt.Name = "txtTidspunkt"
        Me.txtTidspunkt.Size = New System.Drawing.Size(100, 20)
        Me.txtTidspunkt.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(260, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Tidspunkt mottatt:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(263, 198)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(115, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Godkjenn bestilling"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(263, 237)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(100, 23)
        Me.btnSend.TabIndex = 10
        Me.btnSend.Text = "Send bestilling"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'ansattSide
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 411)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "ansattSide"
        Me.Text = "ansattSide"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnInnkalling As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tappeKalender As MonthCalendar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lstKandidater As ListBox
    Friend WithEvents CBoxBlodtype As ComboBox
    Friend WithEvents btnSend As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtTidspunkt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMengde As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBlodtype As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lstBestillinger As ListBox
End Class
