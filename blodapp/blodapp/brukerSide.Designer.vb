<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class brukerSide
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.btnSokTime = New System.Windows.Forms.Button()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.innkallingLst = New System.Windows.Forms.ListBox()
        Me.btnAvbestillTime = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnEndrePersinfo = New System.Windows.Forms.Button()
        Me.btnLoggUt = New System.Windows.Forms.Button()
        Me.fornavnTxt = New System.Windows.Forms.TextBox()
        Me.etternavnTxt = New System.Windows.Forms.TextBox()
        Me.telefonTxt = New System.Windows.Forms.TextBox()
        Me.epostTxt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(18, 45)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(159, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Velg en ledig time"
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 16
        Me.ListBox4.Location = New System.Drawing.Point(310, 45)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(87, 148)
        Me.ListBox4.TabIndex = 2
        '
        'btnSokTime
        '
        Me.btnSokTime.Location = New System.Drawing.Point(310, 219)
        Me.btnSokTime.Name = "btnSokTime"
        Me.btnSokTime.Size = New System.Drawing.Size(103, 23)
        Me.btnSokTime.TabIndex = 3
        Me.btnSokTime.Text = "Søk om å gi blod"
        Me.btnSokTime.UseVisualStyleBackColor = True
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.ItemHeight = 16
        Me.ListBox5.Location = New System.Drawing.Point(310, 287)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(85, 116)
        Me.ListBox5.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(307, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Giverinfo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(179, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Personlig info"
        '
        'innkallingLst
        '
        Me.innkallingLst.FormattingEnabled = True
        Me.innkallingLst.ItemHeight = 16
        Me.innkallingLst.Location = New System.Drawing.Point(12, 287)
        Me.innkallingLst.Name = "innkallingLst"
        Me.innkallingLst.Size = New System.Drawing.Size(119, 116)
        Me.innkallingLst.TabIndex = 8
        '
        'btnAvbestillTime
        '
        Me.btnAvbestillTime.Location = New System.Drawing.Point(12, 414)
        Me.btnAvbestillTime.Name = "btnAvbestillTime"
        Me.btnAvbestillTime.Size = New System.Drawing.Size(103, 23)
        Me.btnAvbestillTime.TabIndex = 9
        Me.btnAvbestillTime.Text = "Avbestill time"
        Me.btnAvbestillTime.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Aktive innkallinger"
        '
        'btnEndrePersinfo
        '
        Me.btnEndrePersinfo.Location = New System.Drawing.Point(310, 414)
        Me.btnEndrePersinfo.Name = "btnEndrePersinfo"
        Me.btnEndrePersinfo.Size = New System.Drawing.Size(103, 23)
        Me.btnEndrePersinfo.TabIndex = 11
        Me.btnEndrePersinfo.Text = "Endre personinfo"
        Me.btnEndrePersinfo.UseVisualStyleBackColor = True
        '
        'btnLoggUt
        '
        Me.btnLoggUt.Location = New System.Drawing.Point(600, 12)
        Me.btnLoggUt.Name = "btnLoggUt"
        Me.btnLoggUt.Size = New System.Drawing.Size(103, 23)
        Me.btnLoggUt.TabIndex = 12
        Me.btnLoggUt.Text = "Logg ut"
        Me.btnLoggUt.UseVisualStyleBackColor = True
        '
        'fornavnTxt
        '
        Me.fornavnTxt.Location = New System.Drawing.Point(179, 287)
        Me.fornavnTxt.Name = "fornavnTxt"
        Me.fornavnTxt.Size = New System.Drawing.Size(100, 22)
        Me.fornavnTxt.TabIndex = 13
        '
        'etternavnTxt
        '
        Me.etternavnTxt.Location = New System.Drawing.Point(179, 325)
        Me.etternavnTxt.Name = "etternavnTxt"
        Me.etternavnTxt.Size = New System.Drawing.Size(100, 22)
        Me.etternavnTxt.TabIndex = 14
        '
        'telefonTxt
        '
        Me.telefonTxt.Location = New System.Drawing.Point(179, 368)
        Me.telefonTxt.Name = "telefonTxt"
        Me.telefonTxt.Size = New System.Drawing.Size(100, 22)
        Me.telefonTxt.TabIndex = 15
        '
        'epostTxt
        '
        Me.epostTxt.Location = New System.Drawing.Point(179, 414)
        Me.epostTxt.Name = "epostTxt"
        Me.epostTxt.Size = New System.Drawing.Size(100, 22)
        Me.epostTxt.TabIndex = 16
        '
        'brukerSide
        '
        Me.ClientSize = New System.Drawing.Size(715, 585)
        Me.Controls.Add(Me.epostTxt)
        Me.Controls.Add(Me.telefonTxt)
        Me.Controls.Add(Me.etternavnTxt)
        Me.Controls.Add(Me.fornavnTxt)
        Me.Controls.Add(Me.btnLoggUt)
        Me.Controls.Add(Me.btnEndrePersinfo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnAvbestillTime)
        Me.Controls.Add(Me.innkallingLst)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListBox5)
        Me.Controls.Add(Me.btnSokTime)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MonthCalendar2)
        Me.Name = "brukerSide"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents btnSokBlodgiving As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEndrePersoninfo As Button
    Friend WithEvents lstLedigeTimer As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAvbestill As Button
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents btnSokTime As Button
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents innkallingLst As ListBox
    Friend WithEvents btnAvbestillTime As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btnEndrePersinfo As Button
    Friend WithEvents btnLoggUt As Button
    Friend WithEvents fornavnTxt As TextBox
    Friend WithEvents etternavnTxt As TextBox
    Friend WithEvents telefonTxt As TextBox
    Friend WithEvents epostTxt As TextBox
End Class
